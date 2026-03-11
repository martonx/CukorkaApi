namespace CukorkaApi
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
    }
}
