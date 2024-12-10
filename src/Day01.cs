using System;
using System.Text;
using System.IO;

namespace AoC.Day01 {
    public class Day01 {
        private List<int>? DiffList {
             get; set; 
        }
        // Sort the lists then 
        
        public Day01() {
            
        }

        public void CalcPosition() {
            using(FileStream fs = File.Open("input.txt", FileMode.Open, FileAccess.Read, FileShare.Read)) {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);

                while ( fs.Read(b, 0, b.Length) > 0) {
                    Console.WriteLine(temp.GetString(b));
                }
            }
        }

    }
}
