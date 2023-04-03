namespace Domain.Entities
{
    public class Brand : BaseEntity
    {
        public Brand(string? name)
        {
            Name = name;
        }

        public string? Name { get; set; }
    }
}
