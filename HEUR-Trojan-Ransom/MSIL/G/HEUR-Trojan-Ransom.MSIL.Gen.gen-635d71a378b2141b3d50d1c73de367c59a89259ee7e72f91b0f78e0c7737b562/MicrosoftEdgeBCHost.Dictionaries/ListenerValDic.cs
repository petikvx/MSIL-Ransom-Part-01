using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ListenerValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerValDic()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralInterpreter()
	{
	}
}
