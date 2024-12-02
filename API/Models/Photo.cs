// using System;
// using System.ComponentModel.DataAnnotations.Schema;

// namespace API.Models;

// [Table("Photos")]
// public class Photo
// {
//     public int Id { get; set; }
//     public string? Url { get; set; }
//     public string? PublicId { get; set; }
//     // Navigation properties - required one-to-one relationship
//     public int? AppUserId { get; set; }
//     public AppUser? AppUser { get; set; } = null!;
// }
