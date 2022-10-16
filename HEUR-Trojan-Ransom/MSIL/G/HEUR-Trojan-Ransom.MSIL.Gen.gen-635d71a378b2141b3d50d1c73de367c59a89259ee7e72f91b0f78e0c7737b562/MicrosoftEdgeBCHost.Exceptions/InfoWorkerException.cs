using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InfoWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareWatcher()
	{
	}
}
