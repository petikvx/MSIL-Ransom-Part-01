using System.Diagnostics;
using Ionic.Zip;

namespace Ionic;

internal abstract class SelectionCriterion
{
	internal virtual bool Verbose { get; set; }

	internal abstract bool Evaluate(string filename);

	[Conditional("SelectorTrace")]
	protected static void CriterionTrace(string format, params object[] args)
	{
	}

	internal abstract bool Evaluate(ZipEntry entry);
}
