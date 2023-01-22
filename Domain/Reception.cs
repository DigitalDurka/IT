using System;
namespace Domain
{
    public class Reception
    {

        public DateTime StartRecept { get; set; }

        public DateTime EndRecept { get; set; }

        public int IDPatient { get; set; }

        public int IDDoctor { get; set; }
    }
}
