using Newtonsoft.Json;

namespace Prototype
{
    /// <summary>
    /// ConcretePrototype2
    /// </summary>
    public class Student : Person
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public Teacher Teacher { get; set; }

        public Student(int id, string name, Teacher teacher)
        {
            Id = id;
            Name = name;
            Teacher = teacher;
        }

        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var objectAsJson = JsonConvert.SerializeObject(this);
                return JsonConvert.DeserializeObject<Student>(objectAsJson);
            }

            return (Person)MemberwiseClone();
        }
        public override string ToString()
        {
            return $"Sklonowany: Student\t{Name} o id {Id} ze swoim nauczycielem  {Teacher.Name} o id {Teacher.Id}";
        }
    }
}
