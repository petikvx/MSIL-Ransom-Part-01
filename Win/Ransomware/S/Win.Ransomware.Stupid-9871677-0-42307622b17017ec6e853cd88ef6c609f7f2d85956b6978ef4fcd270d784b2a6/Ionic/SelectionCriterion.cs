using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ionic.Zip;

namespace Ionic;

internal abstract class SelectionCriterion
{
	internal virtual extern bool Verbose
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	internal abstract bool Evaluate(string filename);

	[Conditional("SelectorTrace")]
	protected static extern void CriterionTrace(string format, params object[] args);

	internal abstract bool Evaluate(ZipEntry entry);

	protected extern SelectionCriterion();
}
