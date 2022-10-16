using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ConnectionRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceProperty()
	{
	}
}
