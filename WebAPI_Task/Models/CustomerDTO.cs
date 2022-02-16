using System;

namespace WebAPI_Task.Models
{
    public class CustomerDTO
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public DateTime DateCreated { get; private set; }

        public CustomerDTO(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            DateCreated = DateTime.Now.AddMinutes(1);
        }
    }
}