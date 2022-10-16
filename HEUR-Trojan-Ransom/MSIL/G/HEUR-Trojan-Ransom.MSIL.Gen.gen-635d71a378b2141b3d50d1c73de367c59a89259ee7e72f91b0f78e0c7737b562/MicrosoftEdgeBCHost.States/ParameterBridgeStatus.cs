using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParameterBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SortAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortAccount()
	{
	}
}
