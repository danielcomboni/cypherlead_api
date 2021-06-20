using Cypherlead.Api.Models;
using System;
using System.Text.Json;

namespace Cypherlead.Api.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public JsonDocument ExtraDetails { get; set; }
    }
}
