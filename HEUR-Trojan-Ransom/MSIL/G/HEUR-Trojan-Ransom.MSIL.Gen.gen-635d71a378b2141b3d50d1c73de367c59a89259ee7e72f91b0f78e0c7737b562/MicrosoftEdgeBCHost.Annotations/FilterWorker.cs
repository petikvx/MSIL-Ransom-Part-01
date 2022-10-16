using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FilterWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterWorker()
	{
		WriterPropertyProducer.ResolveStub();
		StopProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopProcess()
	{
	}
}
