using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Domain.Entities
{
    public class EntityBase
    {
        public Guid Id { get; protected set; }
    }
}
