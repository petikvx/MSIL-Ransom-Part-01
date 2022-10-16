using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ContextBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectMapper()
	{
	}
}
