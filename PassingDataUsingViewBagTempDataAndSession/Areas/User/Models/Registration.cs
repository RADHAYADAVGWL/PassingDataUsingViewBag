using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PassingDataUsingViewBagTempDataAndSession.Areas.User.Models
{
    public class Registration
    {
        [Required]
        [EmailAddress(ErrorMessage = "The Username field is not a valid")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
