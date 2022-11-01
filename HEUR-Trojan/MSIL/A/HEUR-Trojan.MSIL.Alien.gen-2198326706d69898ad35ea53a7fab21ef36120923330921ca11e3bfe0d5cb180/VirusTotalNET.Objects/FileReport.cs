using System;
using System.Collections.Generic;

namespace VirusTotalNET.Objects;

public class FileReport
{
	public string MD5 { get; set; }

	public string Permalink { get; set; }

	public int Positives { get; set; }

	public string Resource { get; set; }

	public ReportResponseCode ResponseCode { get; set; }

	public DateTime ScanDate { get; set; }

	public string ScanId { get; set; }

	public List<ScanEngine> Scans { get; set; }

	public string SHA1 { get; set; }

	public string SHA256 { get; set; }

	public int Total { get; set; }

	public string VerboseMsg { get; set; }
}
