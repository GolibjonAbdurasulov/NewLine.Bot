using System.ComponentModel.DataAnnotations.Schema;

namespace NewLine.Bot.Domain;
[Table("groups")]
public class Group:BaseModel
{
    [Column("group_number")]
    public int  GroupNumber { get; set; }
    [Column("teacher_id")]
    public int TeacherId { get; set; }
    [Column("number_of_student")]
    public int NumberOfStudent { get; set; }
    [Column("room_number")]
    public int RoomNumber{ get; set; }
    [Column("group_level")]
    public string? GroupLevel { get; set; }
}