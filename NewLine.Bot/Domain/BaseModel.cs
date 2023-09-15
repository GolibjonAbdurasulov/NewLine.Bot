using System.ComponentModel.DataAnnotations.Schema;

namespace NewLine.Bot.Domain;

public class BaseModel
{ 
    [Column("id")]
    public int  Id { get; set; }
}