using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class BridgeOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		StopRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopRegistry()
	{
	}
}
