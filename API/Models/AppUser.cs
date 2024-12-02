using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace API.Models;

public class AppUser : IdentityUser<int>
{
    public ICollection<AppUserRole> UserRoles { get; set; } = [];
    // public string? Location { get; set; } // TODO: this will need a useful implementation. This is only a placeholder for now

    // public string? Handle { get; set; }
    // public string? FavoriteTCG { get; set; }
    // public string? About { get; set; }
    // public Photo? ProfilePicture { get; set; }
    // public string? PreferredFormat { get; set; }
    // public ICollection<AppUser>? Friends { get; set; }
}
