using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InvocationBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DefineConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineConfig()
	{
	}
}
