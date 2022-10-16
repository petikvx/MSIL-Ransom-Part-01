using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WorkerAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralConfiguration()
	{
	}
}
