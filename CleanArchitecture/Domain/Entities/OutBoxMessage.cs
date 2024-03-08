using System.Text.Json;
using Domain.Entities.BaseEntity;

namespace Domain.Entities;

public class OutBoxMessage : BaseEntity.BaseEntity
{
    public OutBoxMessage(string type , string content)
    {
        Type = type;
        Content = content;
    }
    public OutBoxMessage(IDomainEvent domainEvent)
    {
        Type = domainEvent.GetType().Name;
        Content = JsonSerializer.Serialize(domainEvent);
    }

    public string Type { get; private set; }
    public string Content { get; private set; }
}