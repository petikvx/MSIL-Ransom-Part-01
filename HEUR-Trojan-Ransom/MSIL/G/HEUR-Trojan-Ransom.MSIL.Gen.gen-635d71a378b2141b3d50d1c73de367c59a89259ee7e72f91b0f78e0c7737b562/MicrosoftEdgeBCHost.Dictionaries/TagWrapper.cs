using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TagWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateTest()
	{
	}
}
