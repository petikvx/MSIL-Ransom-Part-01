using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParameterValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriteRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteRequest()
	{
	}
}
