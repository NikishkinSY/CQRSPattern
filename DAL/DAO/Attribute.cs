namespace DAL.DAO
{
    public class Attribute
    {
        public Attribute(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Attribute()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
