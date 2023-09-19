using Abp.Domain.Entities.Auditing;
using System;

namespace SK.Support.Common
{
    public class BaseEntity : AuditedEntity<Guid>
    {
    }
}
