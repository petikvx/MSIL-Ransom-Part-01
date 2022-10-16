using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StubBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubBridge()
	{
		WriterPropertyProducer.ResolveStub();
		SetupParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupParser()
	{
	}
}
