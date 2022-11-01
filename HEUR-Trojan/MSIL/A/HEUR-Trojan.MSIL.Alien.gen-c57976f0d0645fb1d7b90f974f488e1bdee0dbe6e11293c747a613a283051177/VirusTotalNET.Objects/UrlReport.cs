using System;
using System.Collections.Generic;

namespace VirusTotalNET.Objects;

public class UrlReport
{
	public string FilescanId { get; set; }

	public string Permalink { get; set; }

	public int Positives { get; set; }

	public string Resource { get; set; }

	public ReportResponseCode ResponseCode { get; set; }

	public DateTime ScanDate { get; set; }

	public string ScanId { get; set; }

	public List<ScanEngine> Scans { get; set; }

	public int Total { get; set; }

	public string URL { get; set; }

	public string VerboseMsg { get; set; }
}
