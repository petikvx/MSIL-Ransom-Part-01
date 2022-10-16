using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RefFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralMessage()
	{
	}
}
