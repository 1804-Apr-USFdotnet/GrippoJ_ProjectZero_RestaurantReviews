using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZModels
{
    public class Franchise
    {
        public int fIndex { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }

        public override string ToString()
        {
            return $"\nfIndex: {fIndex}\nName: {Name}\nGenre: {Genre}\n";
        }

    }
}
