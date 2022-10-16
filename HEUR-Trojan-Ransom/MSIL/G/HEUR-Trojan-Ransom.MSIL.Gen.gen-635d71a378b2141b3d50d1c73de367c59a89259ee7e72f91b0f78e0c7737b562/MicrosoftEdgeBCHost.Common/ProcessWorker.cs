using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProcessWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessWorker()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptWriter()
	{
	}
}
