using CinemaCenter.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCenter.Core
{
    public class ActorController
    {
        private CinemaCenterDbContext db;

        public ActorController(CinemaCenterDbContext db)
        {
            this.db = db;
        }

       

        public async Task ActorConfigurations()
        {
            using var stream = new FileStream("../../../../CinemaCenter.Data/Data/actors.txt",
                FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);

            if (db.Actors.Count() == 0)
            {
                while (reader.EndOfStream == false)
                {
                    var line = reader.ReadLine();
                    var parts = line.Split(',');

                    var actor = new Actors
                    {
                        FirstName = parts[0],
                        SurName = parts[1],
                        YearWork = int.Parse(parts[2]),
                        PhoneNumber = parts[3],
                        Email = parts[4]
                    };

                    await db.Actors.AddAsync(actor);
                    await db.SaveChangesAsync();
                }
            }
        }

        public async Task AddActor(string firstname, string surname, int yearwork, string phone, string email)
        {
            Actors actor = new Actors
            {
                FirstName = firstname,
                SurName = surname,
                YearWork = yearwork,
                PhoneNumber = phone,
                Email = email
            };
            await db.Actors.AddAsync(actor);
            await db.SaveChangesAsync();
        }

        public async Task<Actors> GetActorById(int id)
        {
            var actor = await db.Actors.FirstOrDefaultAsync(a => a.Id == id);
            return actor;
        }

        public async Task<Actors> UpdateActor(int id, string surnameNew)
        {
            var actor = await db.Actors.FirstOrDefaultAsync(a => a.Id == id);
            actor.SurName = surnameNew;
            db.Actors.Update(actor);
            db.SaveChanges();
            return actor;
        }

        public async Task DeleteActor(int id)
        {
            var actor = await db.Actors.FirstOrDefaultAsync(a => a.Id == id);
            if (actor != null)
            {
                db.Actors.Remove(actor);
                db.SaveChanges();

            }
        }

        public async Task<List<Actors>> GetActorsByName(string firstName)
        {
            var actors = await db.Actors.Where(a=>a.FirstName == firstName).ToListAsync();
            return actors;
        }

        public async Task<List<Actors>> GetActorsByDirector(int directorId)
        {
            var actrrev= db.Actors.Where(a => a.ActorsFilms.Any(af => af.Film.DirectorId == directorId)).ToList();
            return actrrev;
        }

        public async Task<List<Actors>> GetActorsWithFilmsByDirector(int directorId)
        {
            var listche = await db.Actors.Include(a => a.ActorsFilms).ThenInclude(af => af.Film).Where(a => a.ActorsFilms.Any(af => af.Film.DirectorId == directorId)).ToListAsync();
            return listche;
        }
    }
}
