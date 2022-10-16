using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ComposerWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateRequest()
	{
	}
}
