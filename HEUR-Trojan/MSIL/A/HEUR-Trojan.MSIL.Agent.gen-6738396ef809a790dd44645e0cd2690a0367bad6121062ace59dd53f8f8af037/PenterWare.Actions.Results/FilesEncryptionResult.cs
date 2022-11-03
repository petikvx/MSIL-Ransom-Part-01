using System.Collections.Generic;

namespace PenterWare.Actions.Results;

internal class FilesEncryptionResult : ActionResult
{
	public class EncryptionStatus
	{
		public string BackupPath { get; set; }

		public string EncryptedPath { get; set; }

		public bool Done { get; set; }

		public string ErrorStatus { get; set; } = string.Empty;


		public bool DeletedEnumerated { get; set; }

		public string SHA256 { get; set; }
	}

	public double EncryptionProgress { get; set; }

	public string TargetUsername { get; set; }

	public string BaseDirectory { get; set; }

	public Dictionary<string, EncryptionStatus> EncryptedFiles { get; set; } = new Dictionary<string, EncryptionStatus>();

}
