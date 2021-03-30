using System;

namespace net_rest_service.Model
{
    public class Greetings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Greetings(int id, string name)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
