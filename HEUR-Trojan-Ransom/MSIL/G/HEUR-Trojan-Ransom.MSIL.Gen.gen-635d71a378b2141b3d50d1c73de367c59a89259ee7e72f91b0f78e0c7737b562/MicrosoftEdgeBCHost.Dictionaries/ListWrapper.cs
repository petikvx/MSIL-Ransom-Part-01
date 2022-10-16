using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ListWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ManageTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageTest()
	{
	}
}
