using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TokenizerWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		StartFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartFacade()
	{
	}
}
