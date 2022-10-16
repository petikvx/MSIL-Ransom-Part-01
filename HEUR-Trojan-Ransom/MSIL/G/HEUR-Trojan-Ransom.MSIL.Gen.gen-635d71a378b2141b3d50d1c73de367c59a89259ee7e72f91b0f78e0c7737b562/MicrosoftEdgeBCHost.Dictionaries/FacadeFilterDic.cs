using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FacadeFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceMerchant()
	{
	}
}
