namespace WebApi.DevOps
{
    public class Enviroment
    {
        public int EnviromentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Enviroment(int enviromentId, string name, string description)
        {
            EnviromentId = enviromentId;
            Name = name;
            Description = description;
        }
    }
}
