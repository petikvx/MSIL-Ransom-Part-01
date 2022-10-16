using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InfoBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterceptor()
	{
	}
}
