using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RepositoryBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateUtils()
	{
	}
}
