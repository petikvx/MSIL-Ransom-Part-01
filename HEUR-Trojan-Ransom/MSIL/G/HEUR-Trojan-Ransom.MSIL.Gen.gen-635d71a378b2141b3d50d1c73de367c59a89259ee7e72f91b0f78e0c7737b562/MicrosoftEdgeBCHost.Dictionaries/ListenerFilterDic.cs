using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ListenerFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralValue()
	{
	}
}
