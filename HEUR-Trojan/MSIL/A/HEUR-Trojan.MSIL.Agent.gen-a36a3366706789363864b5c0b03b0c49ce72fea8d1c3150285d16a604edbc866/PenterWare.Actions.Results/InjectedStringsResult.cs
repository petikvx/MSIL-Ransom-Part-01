using System.Collections.Generic;

namespace PenterWare.Actions.Results;

internal class InjectedStringsResult : ActionResult
{
	public class ExeString
	{
		public string StringExe { get; set; }
	}

	public List<ExeString> ExeStrings { get; set; } = new List<ExeString>();

}
