using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class GetterRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfacePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfacePool()
	{
	}
}
