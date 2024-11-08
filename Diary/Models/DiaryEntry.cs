using System.ComponentModel.DataAnnotations;

namespace Diary.Models;

public class DiaryEntry
{
    //[Key] If the value name is ID, we don't need to use [Key] annotation 
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter a title.")]
    // [StringLength(100, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 100 characters.")] // Client side validation
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter content.")]
    public string Content { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter date.")]
    public DateTime DateCreated { get; set; } = DateTime.Now;
}