using System.Text.Json;
using Domain.Entities.Base;

namespace Domain.Entities;

public class ChangeHistory : BaseEntity
{
    public string OldValue { get; private set; }
    
    public string NewValue { get;private set; }
    
    public string RelatedEntityId { get; private set; }
    
    public string RelatedEntityType { get; private set; }

    public void LogHistory(BaseEntity oldEntity , BaseEntity newEntity)
    {
        OldValue = JsonSerializer.Serialize(oldEntity);
        NewValue = JsonSerializer.Serialize(oldEntity);
        RelatedEntityId = oldEntity.Id.ToString();
        RelatedEntityType = oldEntity.GetType().Name;
    }
}