using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PredicatePropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicatePropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralList()
	{
	}
}
