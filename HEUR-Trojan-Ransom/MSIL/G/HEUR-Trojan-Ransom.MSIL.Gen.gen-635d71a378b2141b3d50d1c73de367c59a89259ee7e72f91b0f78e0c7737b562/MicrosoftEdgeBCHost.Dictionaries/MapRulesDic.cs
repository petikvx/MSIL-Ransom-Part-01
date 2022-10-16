using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MapRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfaceParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfaceParameter()
	{
	}
}
