using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class HelperFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceConsumer()
	{
	}
}
