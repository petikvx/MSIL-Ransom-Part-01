using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExceptionFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionFacade()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralRegistry()
	{
	}
}
