using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ErrorBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RevertDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertDefinition()
	{
	}
}
