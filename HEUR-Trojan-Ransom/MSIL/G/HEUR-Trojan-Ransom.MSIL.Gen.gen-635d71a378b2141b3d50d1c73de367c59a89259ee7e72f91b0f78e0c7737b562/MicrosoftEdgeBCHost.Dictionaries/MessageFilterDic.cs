using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MessageFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralWorker()
	{
	}
}
