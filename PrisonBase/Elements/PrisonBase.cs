using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonBase.Elements
{
     class PrisonBase: IBase
    {
        public List<Prisoner> Prisoners {protected set; get; }
        string path { set; get; }
        public PrisonBase(string path )
        {
            this.path = path;
            if(File.Exists(path))
            {
                LoadBase();
            }
            else
            {
                Prisoners = new List<Prisoner>();
            }
        }
        public void LoadBase()
        {
          
            Prisoners = new List<Prisoner>();
            using (TextReader reader = new StreamReader(File.OpenRead(path)))
            {
                string s = null;
                while ((s = reader.ReadLine()) != null)
                {
                    var name = reader.ReadLine();
                    var article = reader.ReadLine();
                    var room = reader.ReadLine();
                    var age = reader.ReadLine();
                    var character = reader.ReadLine();
                    var city = reader.ReadLine();
                    var relatives = reader.ReadLine();
                    var term = reader.ReadLine();
                    var prisonDate = reader.ReadLine();
                    var caste = reader.ReadLine();
                    var imageData = reader.ReadLine();
                    Prisoners.Add(new Prisoner(name,article,room, age, character, city, relatives,term,prisonDate, caste, imageData));
                }
            }
        }
        public void SavePrisoner()
        {
            using (TextWriter writer = new StreamWriter(path))
            {
                foreach (Prisoner prisoner in Prisoners)
                {
                    writer.WriteLine(prisoner.Id);
                    writer.WriteLine(prisoner.Name);
                    writer.WriteLine(prisoner.Article);
                    writer.WriteLine(prisoner.Room);
                    writer.WriteLine(prisoner.Age);
                    writer.WriteLine(prisoner.Character);
                    writer.WriteLine(prisoner.City);
                    writer.WriteLine(prisoner.Relatives);
                    writer.WriteLine(prisoner.Term);
                    writer.WriteLine(prisoner.PrisonDate);
                    writer.WriteLine(prisoner.Caste);
                    writer.WriteLine(prisoner.ImageData);
                     
                }
            }
        }
        public Prisoner AddPrisoner (Prisoner prisoner)
        {

            prisoner.Id = Prisoners.Count() == 0 ? "1" : (Prisoners.Max(b => Convert.ToInt32(b.Id)) + 1).ToString();
            Prisoners.Add(prisoner);
            return prisoner;
        }
        public void DeletePrisoner (string id)
        {
            int id_p = 0;
            
            for(int i = 0; i < Prisoners.Count; i++)
            {
                if( Prisoners[i].Id == id )
                {
                    id_p = i;
                    break;
                }
            }

            Prisoners.RemoveAt(id_p);
        }
    }
}
