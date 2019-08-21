using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;



namespace PrisonBase
{
    public class Prisoner
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public string Age { set; get; }
        public string Character { set; get; }
        public string City { set; get; }
        public string Relatives { set; get; }
        public string Article { set; get; }
        public string Term { set; get; }
        public string PrisonDate { set; get; }
        public string Caste { set; get; }
        public string Room { set; get; }
        public string ImageData;

        public Prisoner(string name, string article, string room, string age,
                        string character, string city, string relatives,
                        string term, string prisondate, string caste, string imageData)
        {
            Name = name;
            Article = article;
            Room = room;
            Age = age;
            Character = character;
            City = city;
            Relatives = relatives;
            Term = term;
            PrisonDate = prisondate;
            Caste = caste;
            ImageData = imageData;
        }
    }
   
}
