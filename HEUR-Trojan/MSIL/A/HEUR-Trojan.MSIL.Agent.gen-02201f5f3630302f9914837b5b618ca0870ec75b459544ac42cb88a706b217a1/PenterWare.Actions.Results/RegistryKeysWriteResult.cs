using System.Collections.Generic;

namespace PenterWare.Actions.Results;

internal class RegistryKeysWriteResult : ActionResult
{
	public class RegistryKeyWritten
	{
		public bool SuccessfullyWritten { get; set; }

		public string Data { get; set; }

		public string Key { get; set; }

		public RegistryValueType Type { get; set; }

		public string Value { get; set; }
	}

	public enum RegistryValueType
	{
		STRING,
		BINARY,
		DWORD,
		QWORD,
		MULTISTRING,
		EXPANDABLESTRING
	}

	public List<RegistryKeyWritten> KeysWritten { get; set; } = new List<RegistryKeyWritten>();

}
