using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Areas.Admin.Data
{
    public class Login_NetModels
    {
        [Required] 
        public string Username { set; get; }
        public string PasswordHash { set; get; }
        public bool Remember { set; get; }

    }
}