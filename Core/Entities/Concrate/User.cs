using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Comcrate
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PaswordSalt { get; set; }
        public byte[] PaswordHash { get; set; }
        public bool Status { get; set; }
    }
}
