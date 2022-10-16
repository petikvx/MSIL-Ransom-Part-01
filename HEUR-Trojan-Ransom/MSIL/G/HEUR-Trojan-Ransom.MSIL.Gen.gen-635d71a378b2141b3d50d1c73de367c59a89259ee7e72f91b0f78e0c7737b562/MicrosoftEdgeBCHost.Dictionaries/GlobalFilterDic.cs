using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class GlobalFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceRegistry()
	{
	}
}
