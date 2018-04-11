﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace GuguDadah.Pages
{
    public class Register : PageModel
    {
        public string Message { get; set; }

        [Display(Name = "Username")]
        public string userName { get; set; }

        [Display(Name = "Email")]
        public string eMail { get; set; }

        [Display(Name = "Contacto Telefónico")]
        public string contact { get; set; }

        [Display(Name = "Password")]
        public string password { get; set; }

        [Display(Name = "Confirmar Password")]
        public string confirmPassword { get; set; }



        public void OnGet()
        {
            Message = "Your application description page.";
        }
    }
}
