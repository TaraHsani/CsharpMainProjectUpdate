using CsharpProject.Canstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject
{
    internal class Customer : BaseEntity
    {

        public DateTime BirthDate { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    
        public string PhoneNumber { get; set; }

        public bool IsValidPhoneNumber { get; set; }

        public bool IsValidEmail { get; set; }

        public DateTime CreationDate { get; set; }

        public string PersianBirthDate
        {
            get
            {
                string persianD = CreationDate.ToString("yyyy/mm/dd", new CultureInfo("fa-IR"));
                return persianD;
            }

        }

    }
}
