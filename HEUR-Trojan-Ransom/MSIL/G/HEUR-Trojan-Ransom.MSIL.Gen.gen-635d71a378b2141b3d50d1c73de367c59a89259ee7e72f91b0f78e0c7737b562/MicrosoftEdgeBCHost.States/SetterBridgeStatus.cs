using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SetterBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatPage()
	{
	}
}
