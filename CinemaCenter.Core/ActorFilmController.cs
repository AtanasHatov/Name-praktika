using CinemaCenter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCenter.Core
{
    public class ActorFilmController
    {
        private CinemaCenterDbContext db;

        public ActorFilmController(CinemaCenterDbContext db)
        {
            this.db = db;
        }

        public async Task ActorFilmConfigurations()
        {
            using var stream = new FileStream("../../../../CinemaCenter.Data/Data/actorsfilms.txt",
                FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);

            if (db.ActorsFilms.Count() == 0)
            {
                while (reader.EndOfStream == false)
                {
                    var line = reader.ReadLine();
                    var parts = line.Split(',');

                    var actorfilm = new ActorsFilms
                    {
                        ActorId = int.Parse(parts[0]),
                        FilmId = int.Parse(parts[1])
                    };

                    await db.ActorsFilms.AddAsync(actorfilm);
                    await db.SaveChangesAsync();
                }
            }
        }
    }
}
