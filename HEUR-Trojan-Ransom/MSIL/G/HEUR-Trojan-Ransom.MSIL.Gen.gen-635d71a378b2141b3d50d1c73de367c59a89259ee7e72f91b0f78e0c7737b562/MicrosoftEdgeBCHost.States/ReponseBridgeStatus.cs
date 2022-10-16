using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ReponseBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotGlobal()
	{
	}
}
