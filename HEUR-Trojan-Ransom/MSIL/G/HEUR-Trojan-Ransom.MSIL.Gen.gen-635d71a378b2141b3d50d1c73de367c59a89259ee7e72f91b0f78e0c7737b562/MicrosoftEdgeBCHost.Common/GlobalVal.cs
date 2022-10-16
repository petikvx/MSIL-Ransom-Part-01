using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class GlobalVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalVal()
	{
		WriterPropertyProducer.ResolveStub();
		QueryPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryPublisher()
	{
	}
}
