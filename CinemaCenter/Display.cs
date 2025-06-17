using CinemaCenter.Core;
using CinemaCenter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


//this was changed
namespace CinemaCenter.ConsoleApp
{
    public class Display
    {

        private CinemaCenterDbContext context = new CinemaCenterDbContext();
        private ActorController actorController;
        private ProducersController producerController;  
        private DirectorController directorController;
        private StudioController studioController;
        private FilmController filmController;
        private ActorFilmController actorFilmController;
        private ProducerFilmController producerFilmController;

        public Display(ActorController actorController, ProducersController producerController, DirectorController directorController, StudioController studioController, FilmController filmController, ActorFilmController actorFilmController,ProducerFilmController producerFilmController)
        {
            this.actorController = new ActorController(context);
            this.producerController = new ProducersController(context);
            this.directorController = new DirectorController(context);
            this.studioController = new StudioController(context);
            this.filmController = new FilmController(context);
            this.actorFilmController = new ActorFilmController(context);
            this.producerFilmController =new ProducerFilmController(context);
        }

        public async Task ControllerConfiguration()
        {
            
            await actorController.ActorConfigurations();
            
            await producerController.ProducerConfigurations();
            DirectorController directorController = new DirectorController(context);
            await directorController.DirectorConfigurations();
            StudioController studioController = new StudioController(context);
            await studioController.StudioConfigurations();
            FilmController filmController = new FilmController(context);
            await filmController.FilmConfigurations();
            ActorFilmController actorFilmController = new ActorFilmController(context);
            await actorFilmController.ActorFilmConfigurations();
            ProducerFilmController producerFilmController = new ProducerFilmController(context);
            await producerFilmController.ProducerFilmConfigurations();
        }

        public async Task ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Добавяне на нов актьор");
                Console.WriteLine("2. Четене на актьор по id");
                Console.WriteLine("3. Актуализиране на актьор по id");
                Console.WriteLine("4. Изтриване на актьор по id");
                Console.WriteLine("5. Търсене на актьор по име");
                Console.WriteLine("6. Търсене на филм по определена година");
                Console.WriteLine("7. Търсене на актьори, които участват във филми на даден режисьор");
                Console.WriteLine("8. Търсене на филми от дадено студио");
                Console.WriteLine("9. Търсене на продуценти по име");
                Console.WriteLine("10. Търсене на актьори, които участват във филми на даден режисьор, включително информация за филма");
                Console.WriteLine("11. Търсене на продуценти за даден филм");
                Console.WriteLine("12. Търсене на филми, които имат актьори и продуценти от определени студия");
                Console.WriteLine("13. Търсене на филми, които са продуцирани от определен продуцент и режисирани от определен режисьор");
                Console.WriteLine("0. Изход ");
                Console.WriteLine("Моля, въведете избора си: ");

                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        Console.WriteLine();
                        break;
                    case 1:
                        Console.WriteLine("FirstName:");
                        string firstname = Console.ReadLine();
                        Console.WriteLine("Surname:");
                        string surname = Console.ReadLine();
                        Console.WriteLine("YearWork:");
                        int yearwork=int.Parse(Console.ReadLine());
                        Console.WriteLine("Phone Number:");
                        string phonenumber=Console.ReadLine();
                        Console.WriteLine("Email:");
                        string email=Console.ReadLine();
                        await actorController.AddActor(firstname, surname, yearwork,phonenumber, email);
                        Console.WriteLine("Актьора е добавен успешно!");
                    break;
                    case 2:
                        Console.WriteLine("ID:");
                        int id = int.Parse(Console.ReadLine());
                        Actors act=await actorController.GetActorById(id);
                        Console.WriteLine($"{act.FirstName} - {act.SurName} - {act.PhoneNumber} - {act.Email}");
                    break;
                    case 3:
                        Console.WriteLine("ID:");
                        int id1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Surname:");
                        string surnamenew = Console.ReadLine();
                        Actors act2 = await actorController.UpdateActor(id1,surnamenew);
                        Console.WriteLine($"{act2.FirstName} - {act2.SurName} - {act2.PhoneNumber} - {act2.Email}");
                    break;
                    case 4:
                        Console.WriteLine("ID:");
                        int id2 = int.Parse(Console.ReadLine());
                        await actorController.DeleteActor(id2);
                        Console.WriteLine("Актьора е изтрит успешно!");
                    break;
                    case 5:
                        Console.WriteLine("FirstName:");
                        string firstname2 = Console.ReadLine();
                        List<Actors> actorsss1=await actorController.GetActorsByName(firstname2);
                        foreach( Actors actor in actorsss1)
                        {
                            Console.WriteLine($"{actor.FirstName} - {actor.SurName} - {actor.PhoneNumber} - {actor.Email}");
                        }
                    break;
                    case 6:
                        Console.WriteLine("Year film:");
                            int yers=int.Parse(Console.ReadLine());
                        List<Films> filmiii=await filmController.GetFilmsByYear(yers);
                        foreach(Films film in filmiii)
                        {
                            Console.WriteLine($"{film.Title} - {film.Author} - {film.Director} - {film.YearPublished}");
                        }
                    break;
                    case 7:
                        Console.WriteLine("DirectorID:");
                        int iddirector=int.Parse(Console.ReadLine());
                        List<Actors> actorsdir=await actorController.GetActorsByDirector(iddirector);
                        foreach( Actors actor in actorsdir)
                        {
                            Console.WriteLine($"{actor.FirstName} - {actor.SurName} - {actor.PhoneNumber} - {actor.Email}");
                        }
                    break;
                    case 8:
                        Console.WriteLine("StudioID:");
                        int studioid = int.Parse(Console.ReadLine());
                        List<Films> filmstudio = await filmController.GetFilmsByStudioAndGenre(studioid);
                        foreach (Films film in filmstudio)
                        {
                            Console.WriteLine($"{film.Title} - {film.Studio}");
                        }
                    break;
                    case 9:
                        Console.WriteLine("NameProducer:");
                        string namepr=Console.ReadLine();
                        List<Producers> producerssss=await producerController.GetProducersByName(namepr);
                        foreach( Producers producers in producerssss)
                        {
                            Console.WriteLine($"{producers.FirstName} - {producers.SurName} - {producers.ProducersFilms}");
                        }
                    break;
                    case 10:
                        Console.WriteLine("DirectorID:");
                        int iddirector3 = int.Parse(Console.ReadLine());
                        List<Actors> actor555=await actorController.GetActorsWithFilmsByDirector(iddirector3);
                        foreach(Actors actors in actor555)
                        {
                            Console.WriteLine($"{actors.FirstName} - {actors.SurName} - {actors.PhoneNumber} - {actors.Email}");
                        }
                    break;
                    case 11:
                        Console.WriteLine("FilmID:");
                        int filmiddd=int.Parse(Console.ReadLine());
                        List<Producers> pro=await producerController.GetProducersForFilm(filmiddd);
                        foreach( Producers producers in pro)
                        {
                            Console.WriteLine($"{producers.FirstName} - {producers.SurName} - {producers.ProducersFilms}");
                        }
                    break;
                    case 12:
                        Console.WriteLine("StudioID:");
                        int studioid3 = int.Parse(Console.ReadLine());
                        List<Films> fimsssss = await filmController.GetFilmsWithActorsAndProducersByStudio(studioid3);
                        foreach(Films films in fimsssss)
                        {
                            Console.WriteLine($"{films.Title} - {films.Studio}");
                        }
                    break;
                    case 13:
                        Console.WriteLine("DirectorID:");
                        int iddirector31 = int.Parse(Console.ReadLine());
                        Console.WriteLine("ProducedID:");
                        int produced = int.Parse(Console.ReadLine());
                        List<Films> ddznam=await filmController.GetFilmsByProducerAndDirector(produced,iddirector31);
                        foreach(Films films in ddznam)
                        {
                            Console.WriteLine($"{films.Title} - {films.Studio}");
                        }
                    break;
                }
                if (n == 0)
                {
                    break;
                }
            }
        }
    }
}

