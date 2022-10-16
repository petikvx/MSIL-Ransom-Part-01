using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WriterVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterVal()
	{
		WriterPropertyProducer.ResolveStub();
		OrderContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderContainer()
	{
	}
}
