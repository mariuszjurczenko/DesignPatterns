using Newtonsoft.Json;

namespace Prototype
{
    /// <summary>
    /// ConcretePrototype1
    /// </summary>
    public class Teacher : Person
    {
        public override int Id { get; set; }
        public override string Name { get; set; }

        public Teacher(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var objectAsJson = JsonConvert.SerializeObject(this);
                return JsonConvert.DeserializeObject<Teacher>(objectAsJson);
            }

            return (Person)MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Sklonowany: Nauczyciel\t{Name} o id {Id}";
        }
    }
}
