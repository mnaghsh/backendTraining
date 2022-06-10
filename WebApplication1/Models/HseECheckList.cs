using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class HseECheckList
    {
        public short CodChkHecli { get; set; }
        public string DesChkHecli { get; set; }
        public short? FlgChkHecli { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateInfo { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateInfo { get; set; }
        public long? RowVersion { get; set; }
        public string NamChkHecli { get; set; }
        public long? HecltETypId { get; set; }
        public string UnitCehckListsHecli { get; set; }
        public long? DocId { get; set; }
        public DateTime? AddDate { get; set; }
        public long ECheckListId { get; set; }
        public string TypChkHecli { get; set; }
        public string NamDepartmentHecli { get; set; }
    }
}
