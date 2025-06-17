using CinemaCenter.Core;
using CinemaCenter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// this was changed
namespace CinemaCenter.ConsoleApp
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            CinemaCenterDbContext cinemaCenterDbContext = new CinemaCenterDbContext();
            ActorController actorController = new ActorController(cinemaCenterDbContext);
            ProducersController producerController = new ProducersController(cinemaCenterDbContext);
            DirectorController directorController = new DirectorController(cinemaCenterDbContext);
            StudioController studioController = new StudioController(cinemaCenterDbContext);
            FilmController filmController = new FilmController(cinemaCenterDbContext);
            ActorFilmController actorFilmController = new ActorFilmController(cinemaCenterDbContext);
            ProducerFilmController producerFilmController = new ProducerFilmController(cinemaCenterDbContext);
            Display display = new Display(actorController,producerController,directorController,studioController,filmController,actorFilmController,producerFilmController);
            await display.ControllerConfiguration();
            await display.ShowMenu();
        }
    }
}
