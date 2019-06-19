using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb.Models
{
    public class Desk
    {
        public int DeskId { get; set; }
        public int MaterialId { get; set; }
        public int DeskWidth { get; set; }
        public int DeskHeight { get; set; }
        public int DeskNumDrawers { get; set; }

    }
}
