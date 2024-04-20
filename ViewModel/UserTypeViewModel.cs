using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LawX_Utanganan.ViewModel
{
    public class UserTypeViewModel
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}