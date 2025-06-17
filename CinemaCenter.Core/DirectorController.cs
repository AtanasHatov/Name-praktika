using CinemaCenter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCenter.Core
{
    public class DirectorController
    {
        private CinemaCenterDbContext db;

        public DirectorController(CinemaCenterDbContext db)
        {
            this.db = db;
        }

        public async Task DirectorConfigurations()
        {
            using var stream = new FileStream("../../../../CinemaCenter.Data/Data/directors.txt",
                FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);

            if (db.Directors.Count() == 0)
            {
                while (reader.EndOfStream == false)
                {
                    var line = reader.ReadLine();
                    var parts = line.Split(',');

                    var director = new Directors
                    {
                        FirstName = parts[0],
                        SurName = parts[1],
                        YearWork = int.Parse(parts[2]),
                        PhoneNumber = parts[3],
                        Email = parts[4]
                    };

                    await db.Directors.AddAsync(director);
                    await db.SaveChangesAsync();
                }
            }
        }

        public async Task AddDirector(string firstname, string surname, int yearwork, string phone, string email)
        {
            Directors director = new Directors
            {
                FirstName = firstname,
                SurName = surname,
                YearWork = yearwork,
                PhoneNumber = phone,
                Email = email
            };
            await db.Directors.AddAsync(director);
            await db.SaveChangesAsync();
        }
    }
}
