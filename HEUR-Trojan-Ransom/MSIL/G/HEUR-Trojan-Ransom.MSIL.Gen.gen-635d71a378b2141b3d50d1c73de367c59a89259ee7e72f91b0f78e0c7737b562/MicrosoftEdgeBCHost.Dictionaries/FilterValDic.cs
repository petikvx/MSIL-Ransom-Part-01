using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FilterValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterValDic()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralListener()
	{
	}
}
