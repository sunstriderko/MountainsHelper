using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountainHelperLibrary.Models
{
    public class CountryModel
    {
        public string CountryName { get; set; }
        public List<MountainModel> MountainsInCountry { get; set; }
    }
}
