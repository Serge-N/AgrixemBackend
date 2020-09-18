using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AgrixemBackend
{
    public class User : IdentityUser
    {
        [PersonalData, Required, StringLength(20)]
        public string FirstName { get; set; }
        [AllowNull]
        [PersonalData, StringLength(20)]
        public string MiddleName { get; set; }

        [PersonalData, Required, StringLength(20)]
        public string LastName { get; set; }
        [PersonalData, Required, StringLength(6)]
        public string Sex { get; set; }

        [PersonalData, Required, StringLength(11)]
        public string NRC { get; set; }
        [AllowNull]
        public string FullName { get { return $"{FirstName} {MiddleName} {LastName}"; } }

        [PersonalData, Required, StringLength(20)]
        public DateTime DOB { get; set; }

        [PersonalData]
        public int FarmID { get; set; }

    }
}
