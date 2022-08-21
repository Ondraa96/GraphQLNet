using System.ComponentModel.DataAnnotations;

namespace API.Notes;

/// <summary>
/// TODO: 1. Create Note.cs in GraphQLNetExample/Notes. 
/// This class is the model definition.
/// </summary>
public class Note
{
    public Guid Id { get; set; }
    [Required]
    public string Message { get; set; }
}