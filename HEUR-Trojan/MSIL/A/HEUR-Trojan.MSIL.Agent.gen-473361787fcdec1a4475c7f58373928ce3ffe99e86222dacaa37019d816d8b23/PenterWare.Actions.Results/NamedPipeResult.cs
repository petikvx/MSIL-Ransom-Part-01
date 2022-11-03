using System.Collections.Generic;

namespace PenterWare.Actions.Results;

internal class NamedPipeResult : ActionResult
{
	public class NamedPipe
	{
		public string Name { get; set; }
	}

	public List<NamedPipe> NamedPipes { get; set; } = new List<NamedPipe>();

}
