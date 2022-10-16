using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class HelperRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperRules()
	{
		WriterPropertyProducer.ResolveStub();
		SortTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortTag()
	{
	}
}
