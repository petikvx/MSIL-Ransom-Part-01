using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProxyBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		SearchAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchAccount()
	{
	}
}
