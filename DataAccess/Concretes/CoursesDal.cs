using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Concretes;

public class CoursesDal : ICourseDal
{
    List<Courses> _courses;

    public CoursesDal()
    {
        Courses course1 = new Courses();
        course1.CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
        course1.InstructorName = "Engin Demiroğ";
        course1.CourseId = 1;

        Courses course2 = new Courses();
        course2.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)";
        course2.InstructorName = "Engin Demiroğ";
        course2.CourseId = 2;

        Courses course3 = new Courses();
        course3.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)";
        course3.InstructorName = "Engin Demiroğ";
        course3.CourseId = 3;

        Courses course4 = new Courses();
        course4.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)";
        course4.InstructorName = "Engin Demiroğ";
        course4.CourseId = 4;

        Courses course5 = new Courses();
        course5.CourseName = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)";
        course5.InstructorName = "Engin Demiroğ";
        course5.CourseId = 5;

        Courses course6 = new Courses();
        course6.CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium";
        course6.InstructorName = "Halit Enes Kalaycı";
        course6.CourseId = 6;

        Courses course7 = new Courses();
        course7.CourseName = "Programlamaya Giriş için Temel Kurs";
        course7.InstructorName = "Engin Demiroğ";
        course7.CourseId = 7;

        Courses course8 = new Courses();
        course8.CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
        course8.InstructorName = "Engin Demiroğ";
        course8.CourseId = 8;

        _courses = new List<Courses> { course1, course2, course3, course4, course5, course6, course7, course8 };
    }

    public void Add(Courses courses)  
    {
        _courses.Add(courses);
        _courses.ForEach(courses => Console.WriteLine(courses.CourseName));
    }

    public void Delete(Courses courses)  
    {
        Courses coursesToDelete = _courses.SingleOrDefault(c => c.CourseId == courses.CourseId);
        _courses.Remove(coursesToDelete);
    }

    public void Update(Courses courses)
    {
        var courseId = _courses.FirstOrDefault(x => x.CourseId == courses.CourseId);
        if (courseId != null)
        {
            courseId.CourseName = courses.CourseName;
            courseId.InstructorName = courses.InstructorName;
            courseId.CourseId = courses.CourseId;
        }
    }

    public List<Courses> GetAll()
    {
        return _courses;
    }
}