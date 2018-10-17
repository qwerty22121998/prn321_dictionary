using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Entry {
        public String Word { get; set; }
        public String Pronounce { get; set; }
        public String Meanings { get; set; }

        public override String ToString() {
            return $"{Word} - {Pronounce} \n {Meanings}";
        }
    }
}
