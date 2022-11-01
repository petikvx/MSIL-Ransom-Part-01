using System.Collections.Generic;

namespace PenterWare.Actions.Results;

internal class ShadowCopyResult : ActionResult
{
	public class ShadowCopy
	{
		public string Id { get; set; }

		public string ComputerName { get; set; }

		public string Volume { get; set; }
	}

	public List<ShadowCopy> ShadowCopies = new List<ShadowCopy>();

	public string Command { get; set; }

	public bool ExecuteSuccess { get; set; }
}
