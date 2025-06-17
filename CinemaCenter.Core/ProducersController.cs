using CinemaCenter.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCenter.Core
{
     public class ProducersController
    {
        private CinemaCenterDbContext db;

        public ProducersController(CinemaCenterDbContext db)
        {
            this.db = db;
        }

        public async Task ProducerConfigurations()
        {
            using var stream = new FileStream("../../../../CinemaCenter.Data/Data/producers.txt",
                FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);

            if (db.Producers.Count() == 0)
            {
                while (reader.EndOfStream == false)
                {
                    var line = reader.ReadLine();
                    var parts = line.Split(',');

                    var producer = new Producers
                    {
                        FirstName = parts[0],
                        SurName = parts[1],
                        YearWork = int.Parse(parts[2]),
                        PhoneNumber = parts[3],
                        Email = parts[4]
                    };

                    await db.Producers.AddAsync(producer);
                    await db.SaveChangesAsync();
                }
            }
        }
        public async Task AddProducer(string firstname, string surname, int yearwork, string phone, string email)
        {
            Producers producer = new Producers
            {
                FirstName = firstname,
                SurName = surname,
                YearWork = yearwork,
                PhoneNumber = phone,
                Email = email
            };
            await db.Producers.AddAsync(producer);
            await db.SaveChangesAsync();
        }
        public async Task<List<Producers>> GetProducersByName(string name)
        {
              var prname=await db.Producers.Where(p => p.FirstName==name).ToListAsync();
           return prname;   
        }

        public async Task<List<Producers>> GetProducersForFilm(int filmId)
        {
            var producerseee = await db.Producers.Where(p => p.ProducersFilms.Any(pf => pf.FilmId == filmId)).ToListAsync();
            return producerseee;
        }
    }
}
