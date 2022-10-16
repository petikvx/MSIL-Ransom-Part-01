using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TestsFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralObject()
	{
	}
}
