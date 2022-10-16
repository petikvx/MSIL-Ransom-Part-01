using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PageValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageValDic()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralReponse()
	{
	}
}
