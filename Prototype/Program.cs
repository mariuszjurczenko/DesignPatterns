using Prototype;
Console.Title = "Prototype";

var teacher = new Teacher(1, "Marcin");
var teacherClone = (Teacher)teacher.Clone();
Console.WriteLine(teacherClone);

var student = new Student(2, "Tomasz", teacherClone);
var studentClone = (Student)student.Clone(true);
Console.WriteLine(studentClone);

teacherClone.Name = "Wanda";
Console.WriteLine(studentClone);

Console.ReadKey();