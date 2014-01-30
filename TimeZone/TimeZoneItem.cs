using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeZone
{
    public class TimeZoneItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Offset { get; set; }
        public string UTCName { get; set; }
        public string CityList { get; set; }
    }
}
