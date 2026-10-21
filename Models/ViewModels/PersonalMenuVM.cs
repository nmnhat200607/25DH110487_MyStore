using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _25DH110487_MyStore.Models.ViewModels
{
    public class PersonalMenuVM
    {
        public bool IsLoggedIn { get; set; }
        public string Username { get; set; }
        public int CartCount { get; set; }
    }
}