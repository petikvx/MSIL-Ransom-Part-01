using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InfoWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CountSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountSystem()
	{
	}
}
