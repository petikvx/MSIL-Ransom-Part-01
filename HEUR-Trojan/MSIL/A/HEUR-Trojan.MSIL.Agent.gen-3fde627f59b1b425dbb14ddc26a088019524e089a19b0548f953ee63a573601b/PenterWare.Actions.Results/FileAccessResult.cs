using System.Collections.Generic;

namespace PenterWare.Actions.Results;

internal class FileAccessResult : ActionResult
{
	public List<string> Filenames { get; set; } = new List<string>();

}
