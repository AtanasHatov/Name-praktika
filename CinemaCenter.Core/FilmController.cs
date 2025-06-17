using CinemaCenter.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCenter.Core
{
    public class FilmController
    {
        private CinemaCenterDbContext db;

        public FilmController(CinemaCenterDbContext db)
        {
            this.db = db;
        }

        public async Task FilmConfigurations()
        {
            using var stream = new FileStream("../../../../CinemaCenter.Data/Data/films.txt", 
                FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);

            if (db.Films.Count() == 0)
            {
                while (reader.EndOfStream == false)
                {
                    var line = reader.ReadLine();
                    var parts = line.Split(',');

                    var film = new Films
                    {
                        StudioId = int.Parse(parts[0]),
                        DirectorId = int.Parse(parts[1]),
                        Title = parts[2],
                        Author = parts[3],
                        YearPublished = int.Parse(parts[4])
                    };

                    await db.Films.AddAsync(film);
                    await db.SaveChangesAsync();
                }
            }
        }

        public async Task AddFilm(int studioid, int directorId, string title, string author, int yearpublished)
        {
            Films film = new Films
            {
                StudioId= studioid,
                DirectorId= directorId,
                Title= title,
                Author= author,
                YearPublished= yearpublished
            };
            await db.Films.AddAsync(film);
            await db.SaveChangesAsync();
        }

        public async Task<List<Films>> GetFilmsByYear(int year)
        {
            var listfilmigodina = await db.Films.Where(film => film.YearPublished == year).ToListAsync(); 
            return listfilmigodina;
        }

        public async Task<List<Films>> GetFilmsByStudioAndGenre(int studioId)
        {
           var listfilmstudio= await db.Films.Where(f => f.StudioId == studioId).ToListAsync();
            return listfilmstudio;
        }

        public async Task<List<Films>> GetFilmsWithActorsAndProducersByStudio(int studioId)
        {
                var filmssss= await db.Films
                    .Include(f => f.ActorsFilms)
                    .ThenInclude(af => af.Actor)
                    .Include(f => f.ProducersFilms)
                    .ThenInclude(pf => pf.Producer)
                    .Where(f => f.StudioId == studioId)
                    .ToListAsync();
            return filmssss;    
        }

        public async Task<List<Films>> GetFilmsByProducerAndDirector(int producerId, int directorId)
        {
           
                var filmsmsms=await db.Films
                    .Include(f => f.ProducersFilms)
                    .ThenInclude(pf => pf.Producer)
                    .Include(f => f.Director)
                    .Where(f => f.ProducersFilms.Any(pf => pf.ProducerId == producerId) && f.DirectorId == directorId)
                    .ToListAsync();
           return filmsmsms;
        }
    }
}
