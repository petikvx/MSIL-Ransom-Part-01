using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PoolState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolState()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceModel()
	{
	}
}
