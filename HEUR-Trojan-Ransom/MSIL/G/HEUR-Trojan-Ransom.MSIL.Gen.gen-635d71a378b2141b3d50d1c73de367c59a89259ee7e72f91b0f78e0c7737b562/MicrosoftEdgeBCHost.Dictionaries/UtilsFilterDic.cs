using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class UtilsFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceStruct()
	{
	}
}
