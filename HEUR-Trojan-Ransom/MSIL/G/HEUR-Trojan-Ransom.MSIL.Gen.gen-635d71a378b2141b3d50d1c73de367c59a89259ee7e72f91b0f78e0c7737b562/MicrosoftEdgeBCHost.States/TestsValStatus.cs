using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TestsValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralComparator()
	{
	}
}
