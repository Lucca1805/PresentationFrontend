namespace PresentationFrontend.Models
{
    public class Presentation
    {
        public string Name { get; set; }
        public string Location { get; set; }
        //Default Values for UI
        public DateTime FromDate { get; set; } = DateTime.Today.AddHours(2);
        public DateTime ToDate { get; set; } = DateTime.Today.AddDays(1);
    }
}
