namespace CarService.Dal.Entities
{
    public class Address
    {
        public int? Zip { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int? HouseNumber { get; set; }
    }
}