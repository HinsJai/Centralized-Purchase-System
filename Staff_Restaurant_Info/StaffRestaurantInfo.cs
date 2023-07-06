using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Staff_Restaurant_Info
{

    public struct RestaurantInfo
    {
        public RestaurantInfo(string name,string type, string content, string address)
        {
            Name = name;
            Type = type;
            Content = content;
            Address = address;
        }

        public string Name { get;}
        public string Type { get;}
        public string Content { get;}
        public string Address { get;}
    }

}
