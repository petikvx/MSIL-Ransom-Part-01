using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DispatcherDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherDic()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralProcess()
	{
	}
}
