// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul8_1302210123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = File.ReadAllText("D:\\Code\\TPKPL\\TPMOD8\\tpmodul8_1302210123\\Covid_Config.json");
            CovidConfig config = JsonSerializer.Deserialize<CovidConfig>(jsonString);

            Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai " + config.satuan_Suhu);
            double suhu = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
            int hariDemam = 0;
            hariDemam = Convert.ToInt32(Console.ReadLine());
                   
            if (suhu >= 36.5 && suhu <= 37.5 && hariDemam >= config.batas_hari_demam)
            {
                Console.WriteLine(config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(config.Pesan_ditolak);
            }
        }
    }
}
