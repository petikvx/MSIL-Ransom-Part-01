using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ComposerFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralRef()
	{
	}
}
