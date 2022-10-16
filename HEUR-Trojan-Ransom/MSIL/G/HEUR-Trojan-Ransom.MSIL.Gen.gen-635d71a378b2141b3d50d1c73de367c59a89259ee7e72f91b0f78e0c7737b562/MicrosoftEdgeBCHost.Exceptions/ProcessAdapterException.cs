using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProcessAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralError()
	{
	}
}
