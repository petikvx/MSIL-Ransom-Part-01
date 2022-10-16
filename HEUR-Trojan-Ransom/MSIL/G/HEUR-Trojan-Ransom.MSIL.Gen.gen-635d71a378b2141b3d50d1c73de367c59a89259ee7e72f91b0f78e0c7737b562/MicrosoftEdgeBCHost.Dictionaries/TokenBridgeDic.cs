using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TokenBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutTokenizer()
	{
	}
}
