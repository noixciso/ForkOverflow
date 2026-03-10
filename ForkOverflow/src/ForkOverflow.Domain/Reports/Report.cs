using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ForkOverflow.Domain.Reports
{
    public class Report
    {
        public Guid Id { get; set; }
        public required Guid UserId { get; set; }
        public required Guid ReporterUserId { get; set; }
        public Guid? ResolvedByUserId { get; set; }
        public required string Reason { get; set; }
        public Status Status { get; set; } = Status.Open;
        public DateTime CreateAt {  get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
