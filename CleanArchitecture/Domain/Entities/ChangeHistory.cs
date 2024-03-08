using System.Text.Json;
using Domain.Entities.BaseEntity;

namespace Domain.Entities;

public class ChangeHistory : BaseEntity.BaseEntity
{
    public string OldValue { get; private set; }
    
    public string NewValue { get;private set; }
    
    public string RelatedEntityId { get; private set; }
    
    public string RelatedEntityType { get; private set; }

    public void LogHistory(BaseEntity.BaseEntity oldEntity , BaseEntity.BaseEntity newEntity)
    {
        OldValue = JsonSerializer.Serialize(oldEntity);
        NewValue = JsonSerializer.Serialize(oldEntity);
        RelatedEntityId = oldEntity.Id.ToString();
        RelatedEntityType = oldEntity.GetType().Name;
    }
}