using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class GlobalDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalDic()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralSingleton()
	{
	}
}
