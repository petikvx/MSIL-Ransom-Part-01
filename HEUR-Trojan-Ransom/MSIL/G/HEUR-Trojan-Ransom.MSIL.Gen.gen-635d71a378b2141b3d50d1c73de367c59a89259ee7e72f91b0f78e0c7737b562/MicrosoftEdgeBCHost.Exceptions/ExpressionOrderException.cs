using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExpressionOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		QueryMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryMerchant()
	{
	}
}
