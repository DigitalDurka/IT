using System;
using domain;
namespace Domain
{
    public class User
    {

        public int ID { get; set; }

        public int Number { get; set; }

        public string FullName { get; set; }

        public Role Role { get; set; }
    }
}
