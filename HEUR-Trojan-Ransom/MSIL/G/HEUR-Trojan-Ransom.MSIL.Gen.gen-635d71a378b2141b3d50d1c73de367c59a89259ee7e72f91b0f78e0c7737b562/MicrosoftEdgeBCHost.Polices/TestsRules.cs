using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TestsRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsRules()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveParameter()
	{
	}
}
