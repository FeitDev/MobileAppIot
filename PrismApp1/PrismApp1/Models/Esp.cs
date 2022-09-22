using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp1.Models
{
    public class Esp
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SSID { get; set; }
        public string Password { get; set; }
        public string IpAddress { get; set; }
        public string IsActive { get; set; }
        public int HasLight { get; set; }
        public int IsEmptyRoom { get; set; }
        public int Manual { get; set; }
    }
}
