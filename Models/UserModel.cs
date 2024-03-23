using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ExperimentalThingsUsingWPF.Models;

public class UserModel
{
    private string _displayName;
    public int Id { get; set; }
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
    public UserType UserType { get; set; }

    public string DisplayName
    {
        get => string.IsNullOrEmpty(_displayName) ? UserName : _displayName;
        set => _displayName = value;
    }
}


