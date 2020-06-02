using Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class TypeValueRepository : ITypeValueRepo
    {
        private readonly SensorContext context;
        public TypeValueRepository(SensorContext context)
        {
            this.context = context;
        }
        public IEnumerable<Typevalue> getAll()
        {
            return context.TypeValues.ToList();
        }

        public Typevalue getById(int id)
        {
            return context.TypeValues.Find(id);
        }
    }
}
