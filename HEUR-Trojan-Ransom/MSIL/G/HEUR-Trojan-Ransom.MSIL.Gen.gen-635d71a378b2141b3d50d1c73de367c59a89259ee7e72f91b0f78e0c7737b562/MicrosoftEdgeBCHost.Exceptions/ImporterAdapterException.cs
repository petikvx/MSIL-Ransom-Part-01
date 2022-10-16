using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ImporterAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfacePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfacePolicy()
	{
	}
}
