using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class OrderValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralListener()
	{
	}
}
