using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InstanceBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInitializer()
	{
	}
}
