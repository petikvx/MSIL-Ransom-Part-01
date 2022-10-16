using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MockAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceGetter()
	{
	}
}
