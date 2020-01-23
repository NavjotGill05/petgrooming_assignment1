﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Owner
    {
        /*
            An owner is someone who owns one or more pets
            Some things that describe an owner:
                - First Name
                - Last Name
                - Address
                - Phone Number (work)
                - Phone Number (home)

            An owner must reference a list of pets
            
        */
        [Key]
        public string OwnerId { get; set; }
        public string OwnerFName { get; set; }
        public string OwnerLName { get; set; }
        public int OwnerPhone { get; set; }
        public string OwnerEmail { get; set; }
        public string OwnerAddress { get; set; }
        public int PetId { get; set; }

    }
}