using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ItemWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CancelReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelReponse()
	{
	}
}
