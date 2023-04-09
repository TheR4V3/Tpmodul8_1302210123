using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace tpmodul8_1302210123
{
    internal class CovidConfig
    {
        public string satuan_Suhu { get; set; }
        public int batas_hari_demam { get; set; }
        public string Pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }

        public CovidConfig()
        {
            satuan_Suhu = "celcius";
            batas_hari_demam = 3;
            Pesan_ditolak = "Anda tidak lolos screening COVID-19.";
            pesan_diterima = "Anda lolos screening COVID-19.";
        }

        public static void UbahSatuan(ref CovidConfig config)
        {
            if (config.satuan_Suhu == "celcius")
            {
                config.satuan_Suhu = "fahrenheit";
            }
            else if (config.satuan_Suhu == "fahrenheit")
            {
                config.satuan_Suhu = "celcius";
            }
            else
            {
                Console.WriteLine("Satuan suhu tidak valid!");
            }
        }

    }
}
