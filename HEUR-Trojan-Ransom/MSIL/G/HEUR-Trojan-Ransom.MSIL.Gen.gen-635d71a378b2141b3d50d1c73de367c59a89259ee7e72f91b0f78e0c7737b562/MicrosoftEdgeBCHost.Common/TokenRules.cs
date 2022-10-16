using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TokenRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenRules()
	{
		WriterPropertyProducer.ResolveStub();
		CountProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountProxy()
	{
	}
}
