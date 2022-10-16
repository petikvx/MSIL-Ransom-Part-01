using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProxyRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceProxy()
	{
	}
}
