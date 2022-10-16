using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RegFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralState()
	{
	}
}
