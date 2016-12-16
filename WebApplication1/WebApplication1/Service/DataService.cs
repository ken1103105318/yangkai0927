using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace WebApplication1.Service
{
    public class DataService
    {
        private static List<Models.Album> list = new List<Models.Album>();

        static DataService()
        {
            var item = new Models.Album();

            item.ID = "1103105318";
            item.name = "羅揚凱";
            item.Class = "四子三丙";
            item.Constellation = "天秤座";
            item.birthday = "1995/09/27";
            //item.Genre = 8;

            list.Add(item);

            var item2 = new Models.Album();
            item2.ID = "1103105330";
            item2.name = "孫承榮";
            item2.Class = "四子三丙";
            item2.Constellation = "水瓶座";
            item2.birthday = "1996/01/30";
            //item2.Genre = 8; ;
            list.Add(item2);

            

            var item3 = new Models.Album();
            item3.ID = "1103105301";
            item3.name = "黃靖瑋";
            item3.Class = "四子三丙";
            item3.Constellation = "雙子座";
            item3.birthday = "1996/05/29";
            //item3.Genre = 8; ;
            list.Add(item3);

           

            


            //var table1= new Models.Album();
            //table1.one = "4564 ";
            //table1.two = " ";
            //table1.three = " ";
            //table1.four = " ";
            //table1.five = " ";
            ////table1.six = " ";
            ////table1.seven = " ";
            ////table1.eight = " ";
            ////table1.nine = "行動平台";
            ////table1.ten = "行動平台";
            ////table1.eleven = "行動平台";
            ////table1.twelve = "行動平台";
            //list.Add(table1);

            //var table2 = new Models.Album();
            //table2.one = " ";
            //table2.two = "1 ";
            //table2.three = " ";
            //table2.four = "1 ";
            //table2.five= " ";
            //list.Add(table2);

            //var table3 = new Models.Album();
            //table3.one = " ";
            //table3.two = " 1";
            //table3.three = "1 ";
            //table3.four = " 1";
            //table3.five= " ";
            //list.Add(table3);

            //var table4 = new Models.Album();
            //table4.one = " 1";
            //table4.two= " 1";
            //table4.three = " ";
            //table4.four= " ";
            //table4.five= " ";
            //list.Add(table4);

            //var table5 = new Models.Album();
            //table5.one = " ";
            //table5.two= " ";
            //table5.three = " ";
            //table5.four= " ";
            //table5.five= " 1";
            //list.Add(table5);
        }
        public DataService()
        {

        }

        public List<Models.Album> LoadAllAlbum()
        {
             
            return list;
        }

        public void LoadCandidate()
        {
            using (var webClient = new System.Net.WebClient())
            {
               // var json = webClient(URL);
                // Now parse with JSON.Net
            }
            var baseAddress = "http://www.taichungfes.com.tw/api/Candidate/GetPage";

            var http = (HttpWebRequest)WebRequest.Create(new Uri(baseAddress));
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Method = "POST";

            string parsedContent = @"{'PageNo':1,'PageSize':16,'TotalCount':0}";

            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(parsedContent);

            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();

            var response = http.GetResponse();

            var stream = response.GetResponseStream();
            var sr = new StreamReader(stream);
            var content = sr.ReadToEnd();

            //
        }



    }
}