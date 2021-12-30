using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSelling.Local.Data
{
    public class Car
    {
        public int Sort { get; set; }
        public string CarName { get; set; }
        public string ModelName { get; set; }

        public List<CarOption> Options { get; set; }
        public string Wallpaper { get; set; }
    }
}
