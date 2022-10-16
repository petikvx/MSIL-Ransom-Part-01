using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AttributeFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeFilter()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeRules()
	{
	}
}
