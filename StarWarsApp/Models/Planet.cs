using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWarsApp.Models
{
    public class Planet
    {

        public string Name { get; set; }


        public Planet(string APIText)
        {
            JObject planetData = JObject.Parse();

            Name = planetData["name"].ToString();

        }


    }
}