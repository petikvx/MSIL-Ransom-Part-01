using System.Collections.Generic;

namespace PenterWare.Actions.Results;

internal class FilesEnumerationResult : ActionResult
{
	public class EnumeratedFileData
	{
		public double SizeMB { get; set; }

		public string BackupPath { get; set; }

		public bool Done { get; set; }

		public string SHA256 { get; set; }
	}

	public double TotalEnumerationSizeMB { get; set; }

	public string BaseDirectory { get; set; }

	public string TargetUsername { get; set; }

	public Dictionary<string, EnumeratedFileData> EnumeratedFiles { get; set; } = new Dictionary<string, EnumeratedFileData>();

}
