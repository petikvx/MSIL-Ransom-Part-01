using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WriterOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceAlgo()
	{
	}
}
