using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RequestWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestWorker()
	{
		WriterPropertyProducer.ResolveStub();
		QueryField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryField()
	{
	}
}
