using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExceptionContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionContext()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfacePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfacePublisher()
	{
	}
}
