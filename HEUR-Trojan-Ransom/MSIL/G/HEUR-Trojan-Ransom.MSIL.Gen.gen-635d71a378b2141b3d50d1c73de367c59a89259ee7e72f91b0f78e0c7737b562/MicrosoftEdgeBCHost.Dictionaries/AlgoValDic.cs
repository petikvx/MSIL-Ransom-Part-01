using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AlgoValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoValDic()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralComposer()
	{
	}
}
