using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RoleBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareToken()
	{
	}
}
