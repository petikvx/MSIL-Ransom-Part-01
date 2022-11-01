namespace VirusTotalNET.Objects;

public class ScanResult
{
	public string MD5 { get; set; }

	public string Permalink { get; set; }

	public string Resource { get; set; }

	public ScanResponseCode ResponseCode { get; set; }

	public string ScanId { get; set; }

	public string SHA1 { get; set; }

	public string SHA256 { get; set; }

	public string VerboseMsg { get; set; }
}
