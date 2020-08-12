using System;
using System.Collections.Generic;

namespace gwent_diff_backend.DTO
{
    public class PatchSummaryDTO
    {
        public string VersionNumber {get;set;}
        public string PreviousVersionNumber {get;set;}
        public DateTime DatePublished {get;set;}
        public IEnumerable<PatchedCardDTO> ChangedItems {get;set;}
    }
}