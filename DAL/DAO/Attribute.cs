namespace DAL.DAO
{
    public class Attribute
    {
        public Attribute(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }

        public Attribute()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
