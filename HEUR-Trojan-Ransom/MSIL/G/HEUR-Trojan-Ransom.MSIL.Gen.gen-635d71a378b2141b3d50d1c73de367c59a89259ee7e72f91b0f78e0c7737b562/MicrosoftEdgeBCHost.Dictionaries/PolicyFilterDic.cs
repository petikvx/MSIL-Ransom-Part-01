using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PolicyFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceRegistry()
	{
	}
}
