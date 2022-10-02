using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using LitJson;
namespace cs_hanyu
{
    internal class Utils
    {
        public static Dictionary<string, string> loadWords()
        {

            string filePath = Directory.GetCurrentDirectory() + "\\ci.json";
            string jsonStv;
            JsonData json;
            Dictionary<string, string> ret = new Dictionary<string, string>();



            if (File.Exists(filePath))
            {
                jsonStv = File.ReadAllText(filePath);
            }
            else
            {
                WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/majesty17/chinese-xinhua/master/data/ci.json");
                request.Timeout = 20 * 1000;
                WebResponse response = request.GetResponse();
                Stream resStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(resStream);
                jsonStv = sr.ReadToEnd();
                sr.Close();
                resStream.Close();
                File.WriteAllText(filePath, jsonStv);
            }

            json = JsonMapper.ToObject(jsonStv);
            foreach (JsonData item in json)
            {
                string key = item["ci"].ToString();
                if (ret.ContainsKey(key) == false)
                    ret.Add(key, item["explanation"].ToString());
            }




            filePath = Directory.GetCurrentDirectory() + "\\idiom.json";
            if (File.Exists(filePath))
            {
                jsonStv = File.ReadAllText(filePath);
            }
            else
            {
                WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/majesty17/chinese-xinhua/master/data/idiom.json");
                request.Timeout = 20 * 1000;
                WebResponse response = request.GetResponse();
                Stream resStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(resStream);
                jsonStv = sr.ReadToEnd();
                sr.Close();
                resStream.Close();
                File.WriteAllText(filePath, jsonStv);
            }

            json = JsonMapper.ToObject(jsonStv);

            foreach (JsonData item in json)
            {
                string key = item["word"].ToString();
                if (ret.ContainsKey(key) == false)
                    ret.Add(key, "【释义】" + item["explanation"].ToString() + "【由来】" + item["derivation"].ToString());
            }



            return ret;
        }
    }
}
