namespace RiskTrackSCF_ManagmentWEB.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Ruc { get; set; } = string.Empty;
        public string Sector { get; set; } = string.Empty;
    }
}
