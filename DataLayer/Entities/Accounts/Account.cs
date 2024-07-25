using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Accounts
{
    public class Account : BaseModel
    {
        [EmailAddress]
        [Required]
        public required string Email { get; set; }
        [Required]
        [PasswordPropertyText]
        public required string Password { get; set; }
    }
}
