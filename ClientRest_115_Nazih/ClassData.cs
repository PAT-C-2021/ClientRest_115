using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Net;
using static ClientRest_115_Nazih.Program;

namespace ClientRest_115_Nazih
{
    class ClassData
    {
        public void getData()
        {
            //var type data yang tidak peduli pada bentuk, tapi isinya
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

            foreach (var mhs in data)
            {
                Console.WriteLine("NIM : " + mhs.nim);
                Console.WriteLine("Nama : " + mhs.nama);
                Console.WriteLine("Prodi : " + mhs.prodi);
                Console.WriteLine("Angkatan : " + mhs.angkatan);
                Console.WriteLine(" ");
            }
        }
    }
}
