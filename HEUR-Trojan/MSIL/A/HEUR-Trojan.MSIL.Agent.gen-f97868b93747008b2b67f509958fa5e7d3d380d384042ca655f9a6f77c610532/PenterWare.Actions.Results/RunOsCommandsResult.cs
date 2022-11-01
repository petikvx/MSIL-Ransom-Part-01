using System.Collections.Generic;

namespace PenterWare.Actions.Results;

internal class RunOsCommandsResult : ActionResult
{
	public class commandRunned
	{
		public string Command { get; set; }

		public bool Success { get; set; }
	}

	public List<commandRunned> commandsRunned { get; set; } = new List<commandRunned>();

}
