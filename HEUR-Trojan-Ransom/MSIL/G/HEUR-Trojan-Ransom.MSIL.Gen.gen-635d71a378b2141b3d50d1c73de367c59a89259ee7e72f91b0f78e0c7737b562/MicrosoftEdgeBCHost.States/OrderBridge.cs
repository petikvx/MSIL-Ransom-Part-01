using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class OrderBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderBridge()
	{
		WriterPropertyProducer.ResolveStub();
		PostParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostParser()
	{
	}
}
