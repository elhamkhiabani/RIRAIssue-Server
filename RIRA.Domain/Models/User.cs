using RIRA.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIRA.Domain.Models
{
    public class User:IEntity
    {
        public User()
        {

        }
        public int ID { get; set; }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NID { get; set; }

        public string BirthDate { get; set; }

        public bool IsActive { get; set; }

        public bool IsDelete { get; set; }


        public int CreatorID { get; set; }

        public DateTime CreationDateTime { get; set; }

        public int ModifierID { get; set; }

        public DateTime ModifierDateTime { get; set; }

    }
}
