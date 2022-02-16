using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WebAPI_Task.Models
{
    public static class CustomersDB
    {
        public static IReadOnlyCollection<CustomerDTO> CustomersList
        {
            get
            {
                var lista = new List<CustomerDTO>()
                {
                     new CustomerDTO("Eberton"),
                     new CustomerDTO("Gabriele"),
                     new CustomerDTO("Guilherme"),
                     new CustomerDTO("Rafaela"),
                     new CustomerDTO("Lukelson"),
                     new CustomerDTO("Gatuga")
                };
                return new ReadOnlyCollection<CustomerDTO>(lista);
            }
        }

    }
}