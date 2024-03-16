using KodlamaIo.Business;
using KodlamaIo.DataAccess.Concrete;
using KodlamaIo.Entities;

CoursesManager _courses = new (new CourseDal());
InstructorManager _instructor = new(new InstructorDal());
CategoriesManager _categories = new(new CategoryDal());

List<Courses> courses = _courses.GetAll();
List<Instructor> instructors = _instructor.GetAll();
List<Category> categories = _categories.GetAll();

for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(" Course Name: "+ courses[i].CourseName + " --- Course Description: " + courses[i].CourseDescription +" --- Course Price: "+ courses[i].CoursePrice+ "\r\n"+ "\r\n");
}

for (int i = 0; i < instructors.Count; i++)
{
    Console.WriteLine("Instructor "+(i+1)+ ": " + instructors[i].InstructorFirstName + " " + instructors[i].InstructorLastName+ "\r\n");
}

for (int i = 0; i < categories.Count; i++)
{
    Console.WriteLine("\r\n"+"Category "  + categories[i].Id+ " " + categories[i].Name+"(" +courses.Count+")");
}
