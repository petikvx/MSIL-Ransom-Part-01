using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MapperAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralAlgo()
	{
	}
}
