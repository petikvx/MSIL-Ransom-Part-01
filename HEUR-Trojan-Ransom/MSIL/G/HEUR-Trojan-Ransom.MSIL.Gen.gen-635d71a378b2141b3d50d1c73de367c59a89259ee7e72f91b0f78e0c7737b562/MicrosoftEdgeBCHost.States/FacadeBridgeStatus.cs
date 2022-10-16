using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FacadeBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectStatus()
	{
	}
}
