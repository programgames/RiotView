using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Champions
{
    [Serializable]
    public class Champion
    {
        private string _nomChamps;
        public string NomChamps {
            get { return _nomChamps; }
            set { _nomChamps = value; }
        }
        public string Histoire { get; set; }
        private Sort[] spell;
        public Sort[] Spell {
            get { return spell; }
            set { spell = value; } } 
        public string VideoChamps { get; set; }
        public string Image { get; set; }

        public Champion(string nomchamps, string Histoire, Sort[] spell,string videoChamps,string ImageChamp)
        {

            Console.WriteLine("9999999999999999999");
            Console.WriteLine(nomchamps);
            Console.WriteLine("99999999999999999999");
            this.NomChamps = nomchamps;
            Console.WriteLine("*********************");
            Console.WriteLine(this.NomChamps);
            Console.WriteLine("*********************");
            this.Histoire = Histoire;
            this.Spell = spell;
            this.VideoChamps = VideoChamps;
            Image = ImageChamp;

        }
        override
            public string ToString()
        {
            string a;
            a = NomChamps + "/n" + Histoire + "/n";
             /*  for (int i = 0; i < 4; i++)
            {
                a =a + Spell[i].ToString;
            }
            a = a + VideoChamps;*/
            return a;
        }


    }
}

