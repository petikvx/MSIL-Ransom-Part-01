using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WatcherValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherValDic()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralAnnotation()
	{
	}
}
