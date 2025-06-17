using CinemaCenter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCenter.Core
{
     public class ProducerFilmController
    {
        private CinemaCenterDbContext db;

        public ProducerFilmController(CinemaCenterDbContext db)
        {
            this.db = db;
        }

        public async Task ProducerFilmConfigurations()
        {
            using var stream = new FileStream("../../../../CinemaCenter.Data/Data/producersfilms.txt",
                FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);

            if (db.ProducersFilms.Count() == 0)
            {
                while (reader.EndOfStream == false)
                {
                    var line = reader.ReadLine();
                    var parts = line.Split(',');

                    var prodfilm = new ProducersFilms
                    {
                        ProducerId = int.Parse(parts[0]),
                        FilmId = int.Parse(parts[1])
                    };

                    await db.ProducersFilms.AddAsync(prodfilm);
                    await db.SaveChangesAsync();
                }
            }
        }
    }
}
