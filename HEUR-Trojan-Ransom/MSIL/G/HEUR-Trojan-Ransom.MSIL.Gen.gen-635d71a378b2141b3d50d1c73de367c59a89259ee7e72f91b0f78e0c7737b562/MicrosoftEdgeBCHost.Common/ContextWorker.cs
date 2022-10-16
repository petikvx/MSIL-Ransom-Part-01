using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ContextWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextWorker()
	{
		WriterPropertyProducer.ResolveStub();
		FlushProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushProcess()
	{
	}
}
