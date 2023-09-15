using System.ComponentModel.DataAnnotations.Schema;
using NewLine.Bot.Domain.Enums;

namespace NewLine.Bot.Domain;
[Table("users")]
public class User:BaseModel
{
   [Column("name")]
   public string Name { get; set; }
   [Column("phone_number")]
   public string PhoneNumber { get; set; }
   [Column("password")]
   public string Password { get; set; }
   [Column("telegram_chat_id")]
   public double TelegramChatId { get; set; }
   [Column("role")]
   public Role Role { get; set; }
}