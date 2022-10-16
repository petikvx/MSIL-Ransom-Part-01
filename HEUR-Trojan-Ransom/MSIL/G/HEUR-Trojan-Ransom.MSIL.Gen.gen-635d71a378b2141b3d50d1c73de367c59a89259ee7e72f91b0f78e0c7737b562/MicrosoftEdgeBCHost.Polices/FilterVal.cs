using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FilterVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterVal()
	{
		WriterPropertyProducer.ResolveStub();
		InsertPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertPublisher()
	{
	}
}
