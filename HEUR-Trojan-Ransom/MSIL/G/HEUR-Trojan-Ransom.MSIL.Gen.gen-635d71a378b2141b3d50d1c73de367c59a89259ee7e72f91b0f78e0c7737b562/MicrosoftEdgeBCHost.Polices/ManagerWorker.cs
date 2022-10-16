using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ManagerWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerWorker()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareWriter()
	{
	}
}
