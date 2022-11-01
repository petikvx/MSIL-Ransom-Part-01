using PenterWare.Actions.Results;
using PenterWare.Utils;

namespace PenterWare.Actions;

internal class SendInjectedStringsAction : SubAction<InjectedStringsResult>
{
	private static string Name = "InjectedStrings";

	public override string ActionName => Name;

	protected override void Run()
	{
		foreach (string @string in Policy.Strings)
		{
			InjectedStringsResult.ExeString item = new InjectedStringsResult.ExeString
			{
				StringExe = @string
			};
			base.Result.ExeStrings.Add(item);
		}
	}
}
