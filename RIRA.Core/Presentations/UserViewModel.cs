using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIRA.Core.Presentations
{
    public class UserViewModel
    {
        /// <summary>
        /// شناسه
        /// </summary>
        public int ID { get; set; }

      
        /// <summary>
        /// نام کارمند
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// نام خانوادگی کارمند
        /// </summary>
        public string LastName { get; set; }

        

        /// <summary>
        /// تاریخ شمسی
        /// </summary>
        public string BirthDate { get; set; }

        /// <summary>
        /// شناسه ملی
        /// </summary>
        public string NID { get; set; }

     
        /// <summary>
        /// وضعیت فیلد
        /// </summary>
        public bool IsActive { get; set; }
    }
}

