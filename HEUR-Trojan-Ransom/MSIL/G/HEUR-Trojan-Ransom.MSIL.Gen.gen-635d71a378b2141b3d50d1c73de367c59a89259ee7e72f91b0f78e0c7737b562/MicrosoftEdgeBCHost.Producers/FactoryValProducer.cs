using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FactoryValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PopRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopRecord()
	{
	}
}
