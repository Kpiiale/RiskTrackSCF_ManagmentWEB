﻿namespace RiskTrackSCF_ManagmentWEB.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public int? CompanyId { get; set; }

    }

}
