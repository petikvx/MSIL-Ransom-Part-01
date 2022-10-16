using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TokenBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenBridge()
	{
		WriterPropertyProducer.ResolveStub();
		SetupTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupTests()
	{
	}
}
