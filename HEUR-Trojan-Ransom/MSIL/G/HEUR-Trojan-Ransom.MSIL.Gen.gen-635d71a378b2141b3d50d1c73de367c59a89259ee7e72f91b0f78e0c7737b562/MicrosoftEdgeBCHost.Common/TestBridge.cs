using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TestBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestBridge()
	{
		WriterPropertyProducer.ResolveStub();
		RestartPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartPrototype()
	{
	}
}
