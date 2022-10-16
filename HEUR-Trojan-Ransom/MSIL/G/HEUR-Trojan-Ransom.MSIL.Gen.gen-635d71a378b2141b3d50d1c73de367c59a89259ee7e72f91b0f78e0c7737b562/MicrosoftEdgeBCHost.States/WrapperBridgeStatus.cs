using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WrapperBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ManageRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageRole()
	{
	}
}
