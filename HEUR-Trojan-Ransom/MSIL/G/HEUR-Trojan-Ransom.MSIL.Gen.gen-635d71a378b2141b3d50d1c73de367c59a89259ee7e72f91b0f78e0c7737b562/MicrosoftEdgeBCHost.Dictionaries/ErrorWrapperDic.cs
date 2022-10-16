using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ErrorWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeService()
	{
	}
}
