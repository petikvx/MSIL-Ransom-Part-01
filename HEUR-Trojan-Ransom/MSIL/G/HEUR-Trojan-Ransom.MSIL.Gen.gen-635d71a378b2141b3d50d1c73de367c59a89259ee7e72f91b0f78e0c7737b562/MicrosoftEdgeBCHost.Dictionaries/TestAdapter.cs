using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TestAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceServer()
	{
	}
}
