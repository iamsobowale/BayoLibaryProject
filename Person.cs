using System;
namespace Libary_Project
{
    public abstract class Person
    {
        public Person(string firstName, string lastName, string phoneNumber, string email, Prefix title)
        {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
        Title=title;
        }

  public string FirstName{get; set;}
        public string LastName{get; set;}
        public string PhoneNumber{get; set;} 
        public string Email{get; set;}
        public Prefix Title;
        
    }
}