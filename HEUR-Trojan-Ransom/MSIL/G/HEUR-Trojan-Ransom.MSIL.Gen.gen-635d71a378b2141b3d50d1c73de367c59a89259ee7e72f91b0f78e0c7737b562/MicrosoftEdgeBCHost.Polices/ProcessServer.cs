using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProcessServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessServer()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralWrapper()
	{
	}
}
