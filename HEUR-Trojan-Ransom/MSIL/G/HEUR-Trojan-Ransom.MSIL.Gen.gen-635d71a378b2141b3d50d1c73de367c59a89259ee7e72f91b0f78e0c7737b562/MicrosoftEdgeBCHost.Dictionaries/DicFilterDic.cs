using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DicFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceConsumer()
	{
	}
}
