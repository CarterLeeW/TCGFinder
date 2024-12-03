using System;
using API.Models;

namespace API.DTOs;

public class MemberDto
{
    public int Id { get; set; }
    public string? Location { get; set; }
    public string? Handle { get; set; }
    public string? FavoriteTCG { get; set; }
    public string? About { get; set; }
    public Photo? ProfilePicture { get; set; }
    public string? PreferredFormat { get; set; }
    public ICollection<AppUser>? Friends { get; set; }
}
