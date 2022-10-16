using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CollectionWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyPrinter()
	{
	}
}
