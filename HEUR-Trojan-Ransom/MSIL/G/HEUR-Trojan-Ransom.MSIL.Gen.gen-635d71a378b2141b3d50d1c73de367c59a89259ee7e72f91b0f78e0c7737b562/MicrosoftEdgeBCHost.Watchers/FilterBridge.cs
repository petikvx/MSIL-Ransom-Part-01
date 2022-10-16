using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FilterBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterBridge()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteParser()
	{
	}
}
