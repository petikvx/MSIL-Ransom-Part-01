using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DicPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralCreator()
	{
	}
}
