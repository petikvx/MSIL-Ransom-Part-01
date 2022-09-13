using System.Text.RegularExpressions;
using Ionic.Zip;

namespace Ionic;

internal class NameCriterion : SelectionCriterion
{
	private Regex _re;

	private string _regexString;

	internal ComparisonOperator Operator;

	private string _MatchingFileSpec;

	internal virtual extern string MatchingFileSpec { set; }

	public override extern string ToString();

	internal override extern bool Evaluate(string filename);

	private extern bool _Evaluate(string fullpath);

	internal override bool Evaluate(ZipEntry entry)
	{
		//Discarded unreachable code: IL_0009, IL_000d, IL_000f, IL_0018
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Incompatible stack heights: 0 vs 1
		//IL_0013: Invalid comparison between Unknown and O
		//IL_0013: Incompatible stack heights: 0 vs 1
		while (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0008: Unknown opcode: 0xFC*/;
	}

	public extern NameCriterion();
}
