using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Champions
{
    [Serializable]
    public class Sort
    {
        private string nomSort;
        public string NomSort{ get
            {
                return nomSort;
            }
            set
            {
                nomSort = value;
            }
        }
        public string Description { get; set; }
        public string Image { get; set; }
        public TypeSpell Type { get; set; }

        public Sort (string NomSort, string Description,string Image, TypeSpell Type)
        {
            this.NomSort = NomSort;
            this.Description = Description;
            this.Image = Image;
            this.Type = Type;
        }

    }
}
