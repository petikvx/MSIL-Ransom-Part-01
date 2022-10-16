using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class BridgeValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralContext()
	{
	}
}
