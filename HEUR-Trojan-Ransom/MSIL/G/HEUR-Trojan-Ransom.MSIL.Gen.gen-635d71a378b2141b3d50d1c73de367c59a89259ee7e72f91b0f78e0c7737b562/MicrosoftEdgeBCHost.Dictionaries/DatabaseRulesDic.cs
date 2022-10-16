using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DatabaseRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceList()
	{
	}
}
