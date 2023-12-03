using CsharpProject.Canstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject.Models
{
    internal class Product : BaseEntity
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string BrandName { get; set; }

        public bool IsValidetion { get; set; }

        public int count { get; set; }
    }
}
