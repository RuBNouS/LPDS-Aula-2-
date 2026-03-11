using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProjectLpdsw.Models
{
    internal class Client
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ClientEmail { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string pais { get; set; }
        public string PhoneNumber { get; set; }

        public Client(int id, string clientName, string clientEmail, string address1, string address2, string postalCode, string country, string phoneNumber)
        {
            Id = id;
            ClientName = clientName;
            ClientEmail = clientEmail;
            Address1 = address1;
            Address2 = address2;
            PostalCode = postalCode;
            Country = country;
            PhoneNumber = phoneNumber;
        }
    }
}