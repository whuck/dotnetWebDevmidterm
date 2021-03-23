using System;
using System.ComponentModel.DataAnnotations;

namespace Module5.Models
{
    public class Customer
    {
        
        public int CustomerId {get;set;}
        
        [Required]
        [MinLength(1, ErrorMessage="Company Name is Required!")]
        public string CompanyName {get;set;}
        public string Address {get;set;}
        public string City {get;set;}
        public string Region {get;set;}
        public string PostalCode {get;set;}
        public string Country {get;set;}
        public string Phone {get;set;}
        public string Fax {get;set;}
        
    }
}