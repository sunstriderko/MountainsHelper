using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountainHelperLibrary.Models
{
    public class MountainDifficultyModel
    {
        public int DifficultyNumber { get; set; }
        public List<MountainModel> ListOfMountains { get; set; }
    }
}
