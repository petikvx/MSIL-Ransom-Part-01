using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ItemFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemFilter()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeRules()
	{
	}
}
