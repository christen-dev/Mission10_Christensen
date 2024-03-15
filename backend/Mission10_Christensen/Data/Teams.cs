﻿using System.ComponentModel.DataAnnotations;

namespace Mission10_Christensen.Data
{
    public class Teams
    {
        [Key]
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public int CaptainID { get; set; }
    }
}
