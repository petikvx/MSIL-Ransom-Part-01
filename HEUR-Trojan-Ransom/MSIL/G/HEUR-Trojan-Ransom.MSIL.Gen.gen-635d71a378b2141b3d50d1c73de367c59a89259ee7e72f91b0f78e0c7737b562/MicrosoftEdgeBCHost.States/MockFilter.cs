using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MockFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockFilter()
	{
		WriterPropertyProducer.ResolveStub();
		CheckIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckIterator()
	{
	}
}
