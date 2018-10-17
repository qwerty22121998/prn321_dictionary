using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller {
    class Util {
        private static string JoinString(string[] str) {
            string result = "";
            foreach(string s in str) {
                result += $"{s}\n";
            }
            return result;
        }
        public static Model.Entry Parse(string data) {
            string[] lines = data.Split("\r\n".ToCharArray());
            string word = new string(lines[0].TakeWhile(c => c != '/').ToArray()).Trim();
            string pronounce = lines[0].Substring(word.Length).Trim();
            lines[0] = lines[1] = "";
            string mean = JoinString(lines);
            return new Model.Entry() {
                Word = word,
                Pronounce = pronounce,
                Meanings = mean
            };
        }
    }
}
