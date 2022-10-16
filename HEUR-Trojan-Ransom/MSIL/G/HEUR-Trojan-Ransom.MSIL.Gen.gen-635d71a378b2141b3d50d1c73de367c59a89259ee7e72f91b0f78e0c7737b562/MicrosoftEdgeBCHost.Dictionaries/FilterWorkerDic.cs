using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FilterWorkerDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterWorkerDic()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralMerchant()
	{
	}
}
