using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MapperWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeThread()
	{
	}
}
