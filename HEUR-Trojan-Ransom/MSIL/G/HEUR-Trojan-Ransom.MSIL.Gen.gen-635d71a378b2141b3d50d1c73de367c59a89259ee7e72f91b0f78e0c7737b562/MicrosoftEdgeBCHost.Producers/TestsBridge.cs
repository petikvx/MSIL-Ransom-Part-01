using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TestsBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsBridge()
	{
		WriterPropertyProducer.ResolveStub();
		DefineDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineDefinition()
	{
	}
}
