using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConsumerContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerContext()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceWrapper()
	{
	}
}
