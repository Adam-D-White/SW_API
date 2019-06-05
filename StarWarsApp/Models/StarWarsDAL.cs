using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace StarWarsApp.Models
{
    public class StarWarsDAL
    {

        public static string GetData(string url)
        {
            
            HttpWebRequest request = WebRequest.CreateHttp($"http://swapi.co/api/");
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                StreamReader data = new StreamReader(response.GetResponseStream());
                JObject SWdata = JObject.Parse(data.ReadToEnd());
                string SWStuff = (string)SWdata;
                
                return SWStuff;
            }
            return "";
            
        }

        public static Person GetPerson(int i)
        {
            string data = GetData($"https://swapi.co/api/people/{i}/");

            return new Person(personData);
        }
        public static Planet GetPlanet(int i)
        {
            string planetData = GetData($"https://swapi.co/api/planets/{i}/");

            return new Planet(planetData);
        }







    }
}