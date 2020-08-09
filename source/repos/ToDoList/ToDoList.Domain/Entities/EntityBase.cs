using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Domain.Entities
{
    public class TEntityBase
    {
        public Guid Id { get; protected set; }
    }
}
