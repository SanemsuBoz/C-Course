using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager 
    {
        
        public int _id { get; set; }
        public string _name { get; set; }

        public Dictionary<int, string> mus = new Dictionary<int, string>();
        public void Add(int id,string name)
        {
            Musteri m = new Musteri();

            m.id = id;
            m.name = name;

            mus.Add(id,name);

            Console.WriteLine("Added");
        }

        public void Delete(int id)
        {
            _id = id;

            mus.Remove(_id);

            Console.WriteLine("Deleted");
        }

        public void musteriList()
        {
            foreach (KeyValuePair<int, string> musteri in mus)
                Console.WriteLine("Id:{0} - Name:{1}", musteri.Key, musteri.Value);
        }
    }
}
