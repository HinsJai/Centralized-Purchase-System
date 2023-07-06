using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Staff_Restaurant_Info;

namespace UI
{
    public static class User
    {
        public static string UserID { get;set; }
        public static string DepartmentID { get; set;}
        public static string Position { get;set; }
        public static RestaurantInfo RestaurantInfo { get; set; }
    }
}
