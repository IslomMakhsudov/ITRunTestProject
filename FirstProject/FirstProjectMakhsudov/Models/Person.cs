﻿using PetShop.Services;

namespace PetShop.Models
{
    public class Person
    {
        public int Id { get; set; } = ++Global.PersonId;
        public string UserName { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Guid ExternalId { get; set; } = Guid.NewGuid();
        public int RoleId { get; set; } = 2;
    }
}
