using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AdapterFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceStruct()
	{
	}
}
