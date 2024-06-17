using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TestESG;

namespace TestESG
{
    public class ReadData
    {
        public string file_name;
        public string jasonstr;
        public Client client;

        public Client ReadDataFromJson()
        {
            file_name = "DATA.json";
            using (StreamReader r = new StreamReader(file_name))
            {
                jasonstr = r.ReadToEnd();
                client = JsonConvert.DeserializeObject<Client>(jasonstr);
            }
            return client;
        }


    }
}

