namespace BurgerApp.DomainModels
{
    public class Size
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Size() { }

        public Size(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
