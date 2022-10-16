using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InterceptorDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorDic()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralReader()
	{
	}
}
