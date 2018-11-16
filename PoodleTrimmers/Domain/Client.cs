namespace PoodleTrimmers.Domain
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }

        public Client()
        {
            //EMPTY CONSTRUCTOR MEMERY
        }

        public Client(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }
    }
}