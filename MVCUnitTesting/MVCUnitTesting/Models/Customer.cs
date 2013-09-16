using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVCUnitTesting.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [DisplayName("Salutation")]
        public int? SalutationId { get; set; }

        [DisplayName("First name")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        public string LastName { get; set; }

        [DisplayName("Street 1")]
        public string Street1 { get; set; }

        [DisplayName("Street 2")]
        public string Street2 { get; set; }
        public string City { get; set; }

        [DisplayName("State")]
        public string StateCode { get; set; }

        [DisplayName("Postal code")]
        public string PostalCode { get; set; }

        [DisplayName("Phone number")]
        public string PhoneNumber { get; set; }
    }
}