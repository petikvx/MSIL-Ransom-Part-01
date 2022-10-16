using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ContainerAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralPrinter()
	{
	}
}
