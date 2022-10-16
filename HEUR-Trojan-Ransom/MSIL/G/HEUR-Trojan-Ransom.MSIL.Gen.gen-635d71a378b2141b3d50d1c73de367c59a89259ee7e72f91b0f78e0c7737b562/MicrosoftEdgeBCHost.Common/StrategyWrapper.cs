using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StrategyWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CancelRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelRole()
	{
	}
}
