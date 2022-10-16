using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExpressionReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionReponse()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceConsumer()
	{
	}
}
