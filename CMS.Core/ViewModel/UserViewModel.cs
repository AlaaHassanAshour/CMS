using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Core.ViewModel
{
    public class UserViewModel
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime? DOB { get; set; }

    }
}
