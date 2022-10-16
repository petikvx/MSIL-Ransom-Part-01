using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class OrderFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceStruct()
	{
	}
}
