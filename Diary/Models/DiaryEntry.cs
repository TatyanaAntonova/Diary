using System.ComponentModel.DataAnnotations;

namespace Diary.Models;

public class DiaryEntry
{
    //[Key] If the value name is ID, we don't need to use [Key] annotation 
    public int Id { get; set; }
    [Required] public string Title { get; set; } = string.Empty;
    [Required] public string Content { get; set; } = string.Empty;
    [Required] public DateTime DateCreated { get; set; } = DateTime.Now;
}