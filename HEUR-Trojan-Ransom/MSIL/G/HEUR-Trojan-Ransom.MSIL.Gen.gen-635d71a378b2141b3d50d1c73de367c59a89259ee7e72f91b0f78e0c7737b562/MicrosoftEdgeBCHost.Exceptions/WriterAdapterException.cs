using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WriterAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceStub()
	{
	}
}
