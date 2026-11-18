using System;
using System.Collections.Generic;
using System.Text;

namespace MVP_Domain.Dto.Request
{
    public record TaskItemRequest
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }
    }
}
