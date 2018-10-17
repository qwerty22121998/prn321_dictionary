using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Controller {
    public class DataFetcher {
        public static String ReadDataRaw() {
            return System.IO.File.ReadAllText(CONST.DataURL, Encoding.UTF8);
        }



        public static List<Model.Entry> ReadData() {
            List<Model.Entry> list = new List<Model.Entry>();
            Regex regex = new Regex(CONST.Regex, RegexOptions.Multiline);
            MatchCollection datas = regex.Matches(ReadDataRaw());
            foreach (Match data in datas) {
                var entry = Util.Parse(data.Value);
                list.Add(entry);

            }
            return list;
        }

        public static void Main() {
            Console.OutputEncoding = Encoding.UTF8;
            foreach (var e in ReadData()) Console.WriteLine(e) ;
        }
    }
}
