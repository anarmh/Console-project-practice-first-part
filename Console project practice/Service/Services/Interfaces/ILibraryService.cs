using Domain.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface ILibraryService
    {
        Library Create(Library library);
        Library Update(Library library,int id);
        void Delete(int id);
        Library GetById(int id);
        Library GetByName(string name);
        List<Library> GetAll();
    }
}
