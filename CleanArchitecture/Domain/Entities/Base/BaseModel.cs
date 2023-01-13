namespace Domain.Entities.BaseEntity;

public class BaseModel
{
    public  long CreateDate { get; set; }
    public  long? UpdateDate { get; set; }
    public  long? DeleteDate { get; set; }
}