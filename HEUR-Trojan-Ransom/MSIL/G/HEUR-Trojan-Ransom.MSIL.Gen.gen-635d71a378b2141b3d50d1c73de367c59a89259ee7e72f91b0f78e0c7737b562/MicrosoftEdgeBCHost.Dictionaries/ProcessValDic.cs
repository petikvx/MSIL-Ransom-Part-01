using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProcessValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessValDic()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralPool()
	{
	}
}
