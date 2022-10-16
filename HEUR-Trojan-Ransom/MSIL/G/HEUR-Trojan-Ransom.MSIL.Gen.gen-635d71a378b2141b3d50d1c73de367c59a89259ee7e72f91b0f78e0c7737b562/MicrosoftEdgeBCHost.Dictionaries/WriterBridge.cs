using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WriterBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterBridge()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyTests()
	{
	}
}
