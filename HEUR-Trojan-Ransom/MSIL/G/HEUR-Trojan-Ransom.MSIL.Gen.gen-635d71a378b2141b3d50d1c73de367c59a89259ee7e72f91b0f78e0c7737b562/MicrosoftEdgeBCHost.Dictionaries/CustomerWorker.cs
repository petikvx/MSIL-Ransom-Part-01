using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CustomerWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerWorker()
	{
		WriterPropertyProducer.ResolveStub();
		RateWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateWriter()
	{
	}
}
