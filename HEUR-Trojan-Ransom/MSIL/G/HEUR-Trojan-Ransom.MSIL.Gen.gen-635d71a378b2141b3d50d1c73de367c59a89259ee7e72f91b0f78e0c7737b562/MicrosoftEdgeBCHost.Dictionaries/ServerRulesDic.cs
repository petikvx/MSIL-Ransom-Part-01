using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ServerRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceConfiguration()
	{
	}
}
