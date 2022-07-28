using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PropertyTracker.Models
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string name, string role)
        {           
            Name = name;
            Role = role;
        }
        
        [Key]
        public Guid Id { get; set; } = new Guid();
        public string Name { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        
        
        public static bool IsAnEmail (Person person)
        {
            if (string.IsNullOrWhiteSpace(person.Email))
                return false;
            try
            {
                return Regex.IsMatch(person.Email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

        }
    }
}
