using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PoolHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolHelper()
	{
		WriterPropertyProducer.ResolveStub();
		VisitLiteralObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitLiteralObserver()
	{
	}
}
