using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DicAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfacePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfacePublisher()
	{
	}
}
