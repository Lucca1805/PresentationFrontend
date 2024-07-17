namespace PresentationFrontend.Models
{
	public class PresentationStatisticsQuery
	{
		// Default Values for UI
		public DateTime FromDate { get; set; } = DateTime.Now;
		public DateTime ToDate { get; set; } = DateTime.Now.AddDays(2);
	}
}
