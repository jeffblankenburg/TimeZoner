using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace TimeZone
{
    public partial class ZoneSelect : PhoneApplicationPage
    {
        List<TimeZoneItem> Zones = new List<TimeZoneItem>();
        
        public ZoneSelect()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            Zones.Clear();
            Zones.Add(new TimeZoneItem { Id=1, Name = "", Offset = new TimeSpan(0, 0, 0), UTCName = "", CityList = "" });
            Zones.Add(new TimeZoneItem { Id=2, Name = "UTC -12:00", Offset = new TimeSpan(-12, 0, 0), UTCName = "", CityList = "" });
            Zones.Add(new TimeZoneItem { Id=3, Name = "UTC -11:00", Offset = new TimeSpan(-11, 0, 0), UTCName = "", CityList = "" });
            Zones.Add(new TimeZoneItem { Id=4, Name = "UTC -10:00", Offset = new TimeSpan(-10, 0, 0), UTCName = "", CityList = "Papeete, Honolulu" });
            Zones.Add(new TimeZoneItem { Id=5, Name = "UTC -09:30", Offset = new TimeSpan(-9, 30, 0), UTCName = "", CityList = "" });
            Zones.Add(new TimeZoneItem { Id=6, Name = "UTC -09:00", Offset = new TimeSpan(-9, 0, 0), UTCName = "", CityList = "Anchorage, Alaska" });
            Zones.Add(new TimeZoneItem { Id=7, Name = "Pacific Time", Offset = new TimeSpan(-8, 0, 0), UTCName = "UTC -08:00", CityList = "Los Angeles, Vancouver, Tijuana" });
            Zones.Add(new TimeZoneItem { Id=8, Name = "Mountain Time", Offset = new TimeSpan(-7, 0, 0), UTCName = "UTC -07:00", CityList = "Phoenix, Calgary, Ciudad Juárez" });
            Zones.Add(new TimeZoneItem { Id=9, Name = "Central Time", Offset = new TimeSpan(-6, 0, 0), UTCName = "UTC -06:00", CityList = "Chicago, Guatemala City, Mexico City, San José, San Salvador, Tegucigalpa, Winnipeg" });
            Zones.Add(new TimeZoneItem { Id=10, Name = "Eastern Time", Offset = new TimeSpan(-5, 0, 0), UTCName = "UTC -05:00", CityList = "New York, Lima, Toronto, Bogotá, Havana, Kingston" });
            Zones.Add(new TimeZoneItem { Id=11, Name = "UTC -04:30", Offset = new TimeSpan(-4, 30, 0), UTCName = "", CityList = "Caracas" });
            Zones.Add(new TimeZoneItem { Id=12, Name = "UTC -04:00", Offset = new TimeSpan(-4, 0, 0), UTCName = "", CityList = "Santiago, La Paz, San Juan de Puerto Rico, Manaus, Halifax" });
            Zones.Add(new TimeZoneItem { Id=13, Name = "UTC -03:30", Offset = new TimeSpan(-3, 30, 0), UTCName = "", CityList = "St. John's" });
            Zones.Add(new TimeZoneItem { Id=14, Name = "UTC -03:00", Offset = new TimeSpan(-3, 0, 0), UTCName = "", CityList = "Buenos Aires, Montevideo, São Paulo" });
            Zones.Add(new TimeZoneItem { Id=15, Name = "UTC -02:00", Offset = new TimeSpan(-2, 0, 0), UTCName = "", CityList = "" });
            Zones.Add(new TimeZoneItem { Id=16, Name = "UTC -01:00", Offset = new TimeSpan(-1, 0, 0), UTCName = "", CityList = "" });
            Zones.Add(new TimeZoneItem { Id=17, Name = "UTC 00:00", Offset = new TimeSpan(0, 0, 0), UTCName = "", CityList = "Accra, Abidjan, Casablanca, Dakar, Dublin, Lisbon, London" });
            Zones.Add(new TimeZoneItem { Id=18, Name = "UTC +01:00", Offset = new TimeSpan(1, 0, 0), UTCName = "", CityList = "Belgrade, Berlin, Brussels, Copenhagen, Kinshasa, Lagos, Madrid, Paris, Rome, Stockholm, Tunis" });
            Zones.Add(new TimeZoneItem { Id=19, Name = "UTC +02:00", Offset = new TimeSpan(2, 0, 0), UTCName = "", CityList = "Athens, Sofia, Cairo, Kiev, Istanbul, Beirut, Helsinki, Jerusalem, Johannesburg, Bucharest" });
            Zones.Add(new TimeZoneItem { Id=20, Name = "UTC +03:00", Offset = new TimeSpan(3, 0, 0), UTCName = "", CityList = "Nairobi, Baghdad, Doha, Khartoum, Minsk, Riyadh" });
            Zones.Add(new TimeZoneItem { Id=21, Name = "UTC +03:30", Offset = new TimeSpan(3, 30, 0), UTCName = "", CityList = "Tehran" });
            Zones.Add(new TimeZoneItem { Id=22, Name = "UTC +04:00", Offset = new TimeSpan(4, 0, 0), UTCName = "", CityList = "Baku, Dubai, Moscow" });
            Zones.Add(new TimeZoneItem { Id=23, Name = "UTC +04:30", Offset = new TimeSpan(4, 30, 0), UTCName = "", CityList = "Kabul" });
            Zones.Add(new TimeZoneItem { Id=24, Name = "UTC +05:00", Offset = new TimeSpan(5, 0, 0), UTCName = "", CityList = "Karachi, Tashkent" });
            Zones.Add(new TimeZoneItem { Id=25, Name = "UTC +05:30", Offset = new TimeSpan(5, 30, 0), UTCName = "", CityList = "Colombo, Delhi" });
            Zones.Add(new TimeZoneItem { Id=26, Name = "UTC +05:45", Offset = new TimeSpan(5, 45, 0), UTCName = "", CityList = "Kathmandu" });
            Zones.Add(new TimeZoneItem { Id=27, Name = "UTC +06:00", Offset = new TimeSpan(6, 0, 0), UTCName = "", CityList = "Almaty, Dhaka, Yekaterinburg" });
            Zones.Add(new TimeZoneItem { Id=28, Name = "UTC +06:30", Offset = new TimeSpan(6, 30, 0), UTCName = "", CityList = "Yangon" });
            Zones.Add(new TimeZoneItem { Id=29, Name = "UTC +07:00", Offset = new TimeSpan(7, 0, 0), UTCName = "", CityList = "Jakarta, Bangkok, Novosibirsk, Hanoi" });
            Zones.Add(new TimeZoneItem { Id=30, Name = "UTC +08:00", Offset = new TimeSpan(8, 0, 0), UTCName = "", CityList = "Perth, Beijing, Manila, Singapore, Kuala Lumpur, Denpasar, Krasnoyarsk" });
            Zones.Add(new TimeZoneItem { Id=31, Name = "UTC +08:45", Offset = new TimeSpan(8, 45, 0), UTCName = "", CityList = "" });
            Zones.Add(new TimeZoneItem { Id=32, Name = "UTC +09:00", Offset = new TimeSpan(9, 0, 0), UTCName = "", CityList = "Seoul, Tokyo, Pyongyang, Ambon, Irkutsk" });
            Zones.Add(new TimeZoneItem { Id=33, Name = "UTC +09:30", Offset = new TimeSpan(9, 30, 0), UTCName = "", CityList = "Adelaide" });
            Zones.Add(new TimeZoneItem { Id=34, Name = "UTC +10:00", Offset = new TimeSpan(10, 0, 0), UTCName = "", CityList = "Canberra, Yakutsk, Port Moresby" });
            Zones.Add(new TimeZoneItem { Id=35, Name = "UTC +10:30", Offset = new TimeSpan(10, 30, 0), UTCName = "", CityList = "" });
            Zones.Add(new TimeZoneItem { Id=36, Name = "UTC +11:00", Offset = new TimeSpan(11, 0, 0), UTCName = "", CityList = "Vladivostok, Noumea" });
            Zones.Add(new TimeZoneItem { Id=37, Name = "UTC +11:30", Offset = new TimeSpan(11, 30, 0), UTCName = "", CityList = "" });
            Zones.Add(new TimeZoneItem { Id=38, Name = "UTC +12:00", Offset = new TimeSpan(12, 0, 0), UTCName = "", CityList = "Auckland, Suva" });
            Zones.Add(new TimeZoneItem { Id=39, Name = "UTC +12:45", Offset = new TimeSpan(12, 45, 0), UTCName = "", CityList = "" });
            Zones.Add(new TimeZoneItem { Id=40, Name = "UTC +13:00", Offset = new TimeSpan(13, 0, 0), UTCName = "", CityList = "" });
            Zones.Add(new TimeZoneItem { Id=41, Name = "UTC +14:00", Offset = new TimeSpan(14, 0, 0), UTCName = "", CityList = "" });

            ZoneSelector.ItemsSource = Zones;
        }

        private void SaveZones_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (TimeZoneItem x in ZoneSelector.SelectedItems)
            {
                s = s + x.Id + "|";
            }
        }
    }
}