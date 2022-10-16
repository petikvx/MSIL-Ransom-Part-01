using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class OrderBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectParser()
	{
	}
}
