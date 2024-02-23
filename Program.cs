using Kodlamaio.Business;
using Kodlamaio.DataAccess.Concretes;
using Kodlamaio.Entities;

CourseManager courseManager = new(new CoursesDal());

List<Courses> _courses = courseManager.GetAll();
for (int i = 0; i < _courses.Count; i++)
{
    Console.WriteLine(_courses[i].CourseName + "  Eğitmen: " + _courses[i].InstructorName);
}

Console.WriteLine();
Console.WriteLine();

InstructorManager instructorManager = new(new InstructorDal());

List<Instructor> _instructor = instructorManager.GetAll();
for (int i = 0; i < _instructor.Count; i++)
{
    Console.WriteLine(_instructor[i].FirstName + " " + _instructor[i].LastName);
}

Console.WriteLine();
Console.WriteLine();

CategoryManager categoryManager = new(new CategoryDal());

List<Category> _category = categoryManager.GetAll();
for (int i = 0; i < _category.Count; i++)
{
    Console.WriteLine(_category[i].CategoryName);
}