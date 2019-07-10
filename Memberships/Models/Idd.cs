using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Memberships.Controllers;

namespace Memberships.Models
{
    public class Idd
    {
        private static string id = HomeController.userId;

        public static string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}