using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CandidateOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceException()
	{
	}
}
