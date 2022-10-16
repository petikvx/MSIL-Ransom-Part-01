using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProducerRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceToken()
	{
	}
}
