using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CandidateAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		ListLiteralServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListLiteralServer()
	{
	}
}
