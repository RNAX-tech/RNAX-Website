using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace RNAX_web.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string password { get; set; }

        public Project projects { get; set; }
    }
}
