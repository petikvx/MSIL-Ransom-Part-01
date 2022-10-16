using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ResolverFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PrintCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintCode()
	{
	}
}
