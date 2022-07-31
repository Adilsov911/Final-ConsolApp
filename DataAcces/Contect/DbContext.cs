using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Contect
{
    static class DbContext
    {
        static DbContext()
        {
            Druggis = new List<Drug>();
            Druggists = new List<Druggist>();
            Drugstores = new List<DrugStore>();
            Owners = new List<Owner>();

        }
        public static List<Drug> Druggis { get; set; }
        public static List<Druggist> Druggists { get; set; }
        public static List<DrugStore> Drugstores { get; set; }
        public static List<Owner> Owners { get; set; }

    }

    
}
