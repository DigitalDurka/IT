using System;
namespace Domain
{
    public class Schedule
    {
        public Schedule() { }
        public int id;
        public DateTime startwork;
        public DateTime endwork;

        public int ID { get; set; }

        public DateTime StartWork { get; set; }

        public DateTime EndWork { get; set; }
    }
}
