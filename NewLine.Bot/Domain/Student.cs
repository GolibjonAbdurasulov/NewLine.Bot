using System.ComponentModel.DataAnnotations.Schema;

namespace NewLine.Bot.Domain;
[Table("students")]
public class Student:BaseModel
{
    [Column("user_id")]
    public double UserId { get; set; }
    [Column("parent_phone_number")]
    public string? ParentPhoneNumber { get; set; }
    [Column("parent_chat_number")]
    public double ParentTelegramChatId { get; set; }
}