using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class VisitorBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorBridge()
	{
		WriterPropertyProducer.ResolveStub();
		TestPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestPrototype()
	{
	}
}
