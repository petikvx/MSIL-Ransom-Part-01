using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DefinitionValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ReadProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadProxy()
	{
	}
}
