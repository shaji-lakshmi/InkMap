using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InkMapAPI.Models
{
    public class Portfolio
    {
        public int accountid { get; set; }
        public String title { get; set; }
        public String type { get; set; }
        public byte[] data { get; set; }
        public int length { get; set; }
    }
}