using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SingletonBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateStrategy()
	{
	}
}
