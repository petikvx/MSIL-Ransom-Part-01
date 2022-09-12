namespace Coache.Common;

public class ReportType
{
	public string StoredProcedure { get; set; }

	public string ReportDescription { get; set; }

	public override string ToString()
	{
		return ReportDescription;
	}

	public ReportType(string storedProcedure, string description)
	{
		StoredProcedure = storedProcedure;
		ReportDescription = description;
	}
}
