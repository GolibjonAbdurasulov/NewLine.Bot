using System.ComponentModel.DataAnnotations.Schema;
using NewLine.Bot.Domain.Enums;

namespace NewLine.Bot.Domain;
[Table("daily_reports")]
public class DailyReport:BaseModel
{
    [Column("user_id")]
    public int UserId { get; set; }   
    [Column("group_number")] 
    public int GroupNumber { get; set; }
    [Column("attendance")] 
    public string Attendance { get; set; }
    [Column("home_work_statsus")]
    public HomeWorkStatus HomeWorkStatus { get; set; }
}