using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Domain.Entities
{
    public class ToDoItem : EntityBase
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool IsDone { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        //For entity framework
        protected ToDoItem()
        {

        }
        public ToDoItem(string title, string desc, bool isDone, DateTime endTime)
        {
            if (string.IsNullOrEmpty(title)) throw new ArgumentNullException(nameof(title));
            if (string.IsNullOrEmpty(desc)) throw new ArgumentNullException(nameof(desc));
            if (endTime == null) throw new ArgumentNullException(nameof(endTime));

            Id = Guid.NewGuid();
            Title = title;
            Description = desc;
            IsDone = isDone;
            StartTime = DateTime.Now.Date;
            EndTime = endTime.Date.Date;
        }

        public void UpdateTitle(string title)
        {
            if (string.IsNullOrEmpty(title)) throw new ArgumentNullException(nameof(title));
            Title = title;
        }
        public void UpdateDescription(string desc)
        {
            if (string.IsNullOrEmpty(desc)) throw new ArgumentNullException(nameof(desc));
            Description = desc;
        }
        public void UpdateEndDate(DateTime endDate)
        {
            if (endTime == null) throw new ArgumentNullException(nameof(endTime));
            EndTime = endDate;
        }


    }
}
