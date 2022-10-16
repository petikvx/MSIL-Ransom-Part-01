using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WatcherDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherDic()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralReader()
	{
	}
}
