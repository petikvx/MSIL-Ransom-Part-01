using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TokenWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		WriteProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteProduct()
	{
	}
}
