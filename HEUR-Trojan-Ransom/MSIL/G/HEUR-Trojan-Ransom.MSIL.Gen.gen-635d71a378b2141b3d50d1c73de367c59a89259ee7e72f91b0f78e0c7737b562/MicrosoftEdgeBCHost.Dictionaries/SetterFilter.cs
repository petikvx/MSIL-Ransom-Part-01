using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SetterFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterFilter()
	{
		WriterPropertyProducer.ResolveStub();
		DisableCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableCandidate()
	{
	}
}
