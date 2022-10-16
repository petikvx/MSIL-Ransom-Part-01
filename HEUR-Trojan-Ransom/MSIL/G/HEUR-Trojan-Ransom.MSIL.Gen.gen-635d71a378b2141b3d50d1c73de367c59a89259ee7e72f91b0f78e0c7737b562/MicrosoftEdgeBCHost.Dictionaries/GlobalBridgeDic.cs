using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class GlobalBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		TestToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestToken()
	{
	}
}
