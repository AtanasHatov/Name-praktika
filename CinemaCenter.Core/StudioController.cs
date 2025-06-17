using CinemaCenter.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCenter.Core
{
    public class StudioController
    {
        private CinemaCenterDbContext db;

        public StudioController(CinemaCenterDbContext db)
        {
            this.db = db;
        }

        public async Task StudioConfigurations()
        {
            using var stream = new FileStream("../../../../CinemaCenter.Data/Data/studios.txt",
                FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);

            if (db.Studios.Count() == 0)
            {
                while (reader.EndOfStream == false)
                {
                    var line = reader.ReadLine();
                    var parts = line.Split(',');

                    var studio = new Studios
                    {
                        Name = parts[0],
                        Address = parts[1],
                        PhoneNumber = parts[2],
                        Email = parts[3]
                    };

                    await db.Studios.AddAsync(studio);
                    await db.SaveChangesAsync();
                }
            }
        }
        public async Task AddStudio(string name, string address, string phone, string email)
        {
            Studios studio = new Studios
            {
                Name=name,
                Address=address,
                PhoneNumber=phone,
                Email=email
            };
            await db.Studios.AddAsync(studio);
            await db.SaveChangesAsync();
        }

        public async Task<List<Studios>> GetStudiosByName(string name)
        {
            var prname = await db.Studios.Where(p => p.Name == name).ToListAsync();
            return prname;
        }

        public async Task<List<Studios>> GetStudiosByEmail(string mail)
        {
            var prname = await db.Studios.Where(p => p.Email == mail).ToListAsync();
            return prname;
        }
    }
}
