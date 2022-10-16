using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SingletonFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralService()
	{
	}
}
