using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ListenerBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeTokenizer()
	{
	}
}
