using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Concrete;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Repositories
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		public void Delete(T t)
		{
			using var context = new Context();
			context.Set<T>().Remove(t);
			context.SaveChanges();
		}

		public T GetByID(int id)
		{
			using var context = new Context();
			return context.Set<T>().Find(id);
		}

		public List<T> GetList()
		{
			using var context = new Context();
			return context.Set<T>().ToList();
		}

		public void Insert(T t)
		{
			using var context = new Context();
			context.Set<T>().Add(t);
			context.SaveChanges();
		}

        public List<CustomerAccountProcess> MyLastProcess(int id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerAccountProcess> MyLastProcess1(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T t)
		{
			using var context = new Context();
			context.Set<T>().Update(t);
			context.SaveChanges();
		}
	}
}
