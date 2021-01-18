using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Todos
{
    [Table("TodoApp")]
    public class Todo: Entity, IHasCreationTime
    {
        public const int MaxTitleLength = 256;

        [Required]
        [StringLength(MaxTitleLength)]
        public string Title { get; set; }

        public DateTime CreationTime { get; set; }

        public TaskState Completed { get; set; }


        public Todo()
        {
            CreationTime = Clock.Now;
            Completed = TaskState.Open;
        }

        public Todo(string title)
            : this()
        {
            Title = title;
            
        }
    }

    public enum TaskState : byte
    {
        Open = 0,
        Complete = 1
    }
}
