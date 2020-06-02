using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface ITypeValueRepo
    {
        Typevalue getById(int id);
        IEnumerable<Typevalue> getAll();
    }
}
