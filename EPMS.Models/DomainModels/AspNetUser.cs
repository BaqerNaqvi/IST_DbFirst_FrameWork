﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using EPMS.Models.DomainModels;

namespace EPMS.Models.DomainModels
{
    public partial class AspNetUser
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public long UserDomainKey { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string CompnayName { get; set; }
        public string Country { get; set; }

         [NotMapped]
        public string ImageName { get; set; }
         public DateTime? DateOfBirth { get; set; }

         [NotMapped]
        public string Qualification { get; set; }
      
       
     
      

        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
    }
}
