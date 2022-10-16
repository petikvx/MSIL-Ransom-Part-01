using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AlgoFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceBase()
	{
	}
}
