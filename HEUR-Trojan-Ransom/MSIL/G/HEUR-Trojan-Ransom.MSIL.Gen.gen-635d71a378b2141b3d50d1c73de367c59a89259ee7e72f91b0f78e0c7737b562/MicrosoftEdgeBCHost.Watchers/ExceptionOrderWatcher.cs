using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ExceptionOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		VisitLiteralMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitLiteralMessage()
	{
	}
}
