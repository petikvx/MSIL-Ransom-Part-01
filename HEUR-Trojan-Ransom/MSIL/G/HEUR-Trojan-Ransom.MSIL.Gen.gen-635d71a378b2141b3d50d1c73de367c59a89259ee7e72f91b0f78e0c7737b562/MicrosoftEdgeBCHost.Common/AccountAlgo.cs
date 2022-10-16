using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AccountAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralTag()
	{
	}
}
