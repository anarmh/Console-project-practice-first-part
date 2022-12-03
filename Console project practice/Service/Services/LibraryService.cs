using Domain.Enteties;
using Repository.Repositories;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly LibraryRepository _repo;
        private int _count = 1;
        public LibraryService()
        {
          _repo= new LibraryRepository();   
        }

        public Library Create(Library library)
        {
            library.Id = _count;
            _repo.Add(library);
            _count++;
            return library;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Library> GetAll()
        {
            throw new NotImplementedException();
        }

        public Library GetById(int id)
        {
            return _repo.Get(m=>m.Id == id);    
        }

        public Library GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Library Update(Library library, int id)
        {
            throw new NotImplementedException();
        }
    }
}
