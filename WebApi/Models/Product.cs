namespace WebApi.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Product(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }

}
