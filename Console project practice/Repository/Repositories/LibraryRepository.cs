using Domain.Enteties;
using Repository.data;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public  class LibraryRepository : IRepository<Library>
    {
        public void Add(Library entity)
        {
            if (entity is null) throw new Exception();
           AppDbContext<Library>.datas.Add(entity);
        }

        public void Delete(Library entity)
        {
            throw new NotImplementedException();
        }

        public Library Get(Predicate<Library> predicate)
        {
            return AppDbContext<Library>.datas.Find(predicate);
        }

        public List<Library> GetAll(Predicate<Library> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Library entity)
        {
            throw new NotImplementedException();
        }
    }
}
