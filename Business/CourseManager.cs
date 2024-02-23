using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.DataAccess.Concretes;
using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Business;

public class CourseManager : ICourseDal
{


    private readonly CoursesDal _courseDal;

    public CourseManager(CoursesDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Courses courses)
    {
        _courseDal.Add(courses);
    }

    public void Delete(Courses courses)
    {
        _courseDal.Delete(courses);
    }

    public List<Courses> GetAll()
    {
        return _courseDal.GetAll();
    }

    public void Update(Courses courses)
    {
        _courseDal.Update(courses);
    }
}
