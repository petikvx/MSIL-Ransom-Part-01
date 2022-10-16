using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MapWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralStub()
	{
	}
}
