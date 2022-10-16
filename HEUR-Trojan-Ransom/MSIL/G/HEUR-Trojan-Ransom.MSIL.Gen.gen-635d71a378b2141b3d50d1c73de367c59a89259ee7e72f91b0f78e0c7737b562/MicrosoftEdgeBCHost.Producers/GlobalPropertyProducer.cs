using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class GlobalPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralStub()
	{
	}
}
