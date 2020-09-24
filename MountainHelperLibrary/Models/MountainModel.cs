using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountainHelperLibrary.Models
{
    public class MountainModel
    {
        public int Id { get; set; }
        public string MountainName { get; set; }

        public int MountainHeight { get; set; }

        public int MountainDifficulty { get; set; }

        public string MountainTourStart { get; set; }

        public string MountainTimeOfTour { get; set; }

        public string MountainCountryName { get; set; }

        public bool MountainFinished { get; set; }



    }
}
