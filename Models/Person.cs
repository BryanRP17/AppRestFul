namespace AppRestFul.Models
{
    public class Person
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
        public required string City { get; set; }
    }
}
