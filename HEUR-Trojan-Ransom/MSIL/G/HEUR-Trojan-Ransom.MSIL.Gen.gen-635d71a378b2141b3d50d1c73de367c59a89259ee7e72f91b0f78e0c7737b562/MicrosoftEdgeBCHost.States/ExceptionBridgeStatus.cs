using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExceptionBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AddDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddDefinition()
	{
	}
}
