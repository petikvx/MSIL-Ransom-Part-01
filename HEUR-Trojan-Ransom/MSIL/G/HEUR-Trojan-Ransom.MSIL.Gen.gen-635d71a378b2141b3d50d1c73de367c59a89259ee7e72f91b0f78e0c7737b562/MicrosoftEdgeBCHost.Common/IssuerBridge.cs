using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IssuerBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerBridge()
	{
		WriterPropertyProducer.ResolveStub();
		CheckStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckStatus()
	{
	}
}
