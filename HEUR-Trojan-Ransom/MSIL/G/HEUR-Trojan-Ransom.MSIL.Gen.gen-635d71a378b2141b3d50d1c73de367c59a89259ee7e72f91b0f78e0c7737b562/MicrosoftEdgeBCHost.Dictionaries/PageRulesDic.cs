using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PageRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceField()
	{
	}
}
