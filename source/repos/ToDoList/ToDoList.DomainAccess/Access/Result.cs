using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.DomainAccess.Access
{
    public class Result
    {
        public string Status { get; set; }
        public bool IsDone { get; set; }
    }
    public class Result<T> : Result
    {
        public T Data { get; set; }
    }
}
