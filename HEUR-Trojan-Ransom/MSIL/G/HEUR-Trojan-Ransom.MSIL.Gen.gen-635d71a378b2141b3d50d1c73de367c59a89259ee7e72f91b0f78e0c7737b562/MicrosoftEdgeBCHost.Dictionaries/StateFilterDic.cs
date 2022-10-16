using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StateFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceRegistry()
	{
	}
}
