using System;
namespace Domain
{
    public class Doctor
    {
        public int ID { get; set; }

        public string FullName { get; set; }

        public Specialization Specialization { get; set; }
    }
}
