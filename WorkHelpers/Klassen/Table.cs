using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHelpers.Klassen
{
    public class Table
    {
        public string Name { get; set; }
        public string Schema { get; set; }
        public List<Column> Cokumns { get; set; }
        public Table() {
            this.Cokumns = new List<Column>();
        }
    }
}
