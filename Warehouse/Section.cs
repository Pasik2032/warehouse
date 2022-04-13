using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class Section
    {
        public string Name { get; set; }
        public List<Section> sections = new List<Section>();
        public List<Product> products = new List<Product>();

        public Section(string name)
        {
            Name = name;
        }
    }
}
