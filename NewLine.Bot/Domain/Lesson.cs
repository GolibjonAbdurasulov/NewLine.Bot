using System.ComponentModel.DataAnnotations.Schema;

namespace NewLine.Bot.Domain;
[Table("lessons")]
public class Lesson:BaseModel
{
    [Column("lesson_subject")]
    public string LessonSubject { get; set; }
    [Column("start_time")]
    public DateTime StartTime { get; set; }
    [Column("end_time")]
    public DateTime EndTime { get; set; }
    [Column("teacher_id")]
    public int TeacherId { get; set; }
}