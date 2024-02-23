using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        List<Courses> GetAll();
        void Add(Courses courses);
        void Delete(Courses courses);
        void Update(Courses courses);

    }
}
