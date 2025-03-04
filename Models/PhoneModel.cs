namespace AppRestFul.Models
{
    public class PhoneModel
    {
        public int Id { get; set; }
        public required string BrandId { get; set; }
        public int Model { get; set; }
        public required int Budget { get; set; }

    }
}
