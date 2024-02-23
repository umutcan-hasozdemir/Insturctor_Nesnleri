using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> _instructors;
    public InstructorDal()
    {
        Instructor instructor1 = new Instructor();
        instructor1.FirstName = "Engin";
        instructor1.LastName = "Demiroğ";
        instructor1.InstructorId = 1;

        Instructor instructor2 = new Instructor();
        instructor2.FirstName = "Halit Enes";
        instructor2.LastName = "Kalaycı";
        instructor2.InstructorId = 2;

        _instructors = new List<Instructor> { instructor1, instructor2 };
    }

    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
        _instructors.ForEach(instructor => Console.WriteLine(instructor.FirstName));
    }

    public void Delete(Instructor instructor)
    {
        Instructor instructorToDelete = _instructors.SingleOrDefault(i => i.FirstName == instructor.FirstName);
        if (instructorToDelete != null)
        {
            _instructors.Remove(instructorToDelete);
        }
        else
        {
            
        }
    }

    public void Update(Instructor instructor)
    {
        var instructorId = _instructors.FirstOrDefault(i => i.InstructorId == instructor.InstructorId);
        if (instructorId != null)
        {
            instructorId.FirstName = instructor.FirstName;
            instructorId.LastName = instructor.LastName;
            instructorId.InstructorId = instructor.InstructorId;
        }
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }
}
