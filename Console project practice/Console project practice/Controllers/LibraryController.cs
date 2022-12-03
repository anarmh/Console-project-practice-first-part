using Domain.Enteties;
using Service.Helpers;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_project_practice.Controllers
{
    public class LibraryController
    {
        private readonly LibraryService _libraryService;

        public LibraryController()
        {
            _libraryService= new LibraryService();
        }

        public void Create()
        {
            try
            {
                ConsoleColor.Blue.WriteConsole("Add library name:");

                string name = Console.ReadLine();

                ConsoleColor.Blue.WriteConsole("Add library seat Count");

            Seatcount: string seatcountstr = Console.ReadLine();

                int seatCount;

                bool isParseSeatCount = int.TryParse(seatcountstr, out seatCount);

                if (isParseSeatCount)
                {
                    Library library = new()
                    {
                        Name = name,
                        SeatCount = seatCount
                    };

                    //library = null;

                    var result = _libraryService.Create(library);

                    ConsoleColor.Green.WriteConsole($"Id: {result.Id},Name: {result.Name},SeatCount: {result.SeatCount}");
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please add correct seat count");
                    goto Seatcount;
                }
            }
            catch (Exception ex)
            {

                ConsoleColor.Red.WriteConsole(ex.Message);
            }

        }


        public void GetById()
        {
            try
            {
                ConsoleColor.Yellow.WriteConsole("Add library id:");
               Id: string Idstr= Console.ReadLine();

                int id;

                bool isParsedId= int.TryParse(Idstr, out id);
                if (isParsedId)
                {
                    var result= _libraryService.GetById(id);
                    if(result is null)
                    {
                        ConsoleColor.Red.WriteConsole("Library not found,please try again");
                        goto Id;
                    }


                    ConsoleColor.Green.WriteConsole($"Id: {result.Id},Name: {result.Name},SeatCount: {result.SeatCount}");
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please add correct id:");
                    goto Id;
                }

            }
            catch (Exception ex)
            {

                ConsoleColor.Red.WriteConsole(ex.Message); 
            }
        }



        
    }
}
