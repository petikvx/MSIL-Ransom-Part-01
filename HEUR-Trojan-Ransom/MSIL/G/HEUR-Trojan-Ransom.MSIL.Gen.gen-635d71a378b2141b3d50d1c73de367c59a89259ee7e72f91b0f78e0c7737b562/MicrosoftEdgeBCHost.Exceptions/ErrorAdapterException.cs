using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ErrorAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceProducer()
	{
	}
}
