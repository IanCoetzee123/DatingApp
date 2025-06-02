using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApi.Models;

public class AppUser
{
    public int Id { get; set; }
    [Required]
    public required string Username { get; set; }
}
