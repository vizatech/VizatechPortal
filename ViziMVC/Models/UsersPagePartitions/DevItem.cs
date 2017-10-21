using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViziMVC.Models.UsersPagePartitions
{
    public class DevItem
    {
        public string DeviceOwnerName { get; set; }
        public string DeviceID { get; set; }
        public string DeviceIconURL { get; set; }
        public string DeviceOwnerIconURL { get; set; }
        public string DeviceView { get; set; }
        public string DeviceFilters { get; set; }
    }
}