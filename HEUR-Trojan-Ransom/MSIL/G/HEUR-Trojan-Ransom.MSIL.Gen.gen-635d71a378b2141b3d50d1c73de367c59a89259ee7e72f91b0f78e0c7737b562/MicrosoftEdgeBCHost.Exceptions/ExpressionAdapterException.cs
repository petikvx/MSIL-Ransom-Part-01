using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExpressionAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceWatcher()
	{
	}
}
