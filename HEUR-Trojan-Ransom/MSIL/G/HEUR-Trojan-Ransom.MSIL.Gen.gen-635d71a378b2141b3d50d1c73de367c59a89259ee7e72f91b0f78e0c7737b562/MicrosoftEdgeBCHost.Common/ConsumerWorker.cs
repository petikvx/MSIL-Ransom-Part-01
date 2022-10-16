using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConsumerWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerWorker()
	{
		WriterPropertyProducer.ResolveStub();
		SelectSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectSystem()
	{
	}
}
