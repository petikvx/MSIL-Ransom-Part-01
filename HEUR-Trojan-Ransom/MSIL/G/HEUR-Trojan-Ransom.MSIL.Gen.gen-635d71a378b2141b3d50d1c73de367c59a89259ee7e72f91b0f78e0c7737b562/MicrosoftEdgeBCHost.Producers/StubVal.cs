using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StubVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubVal()
	{
		WriterPropertyProducer.ResolveStub();
		DefineRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineRules()
	{
	}
}
