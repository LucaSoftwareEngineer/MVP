using System;
using System.Collections.Generic;
using System.Text;

namespace MVP_Domain.Dto.Response
{
    public record TaskItemResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }
    }
}
