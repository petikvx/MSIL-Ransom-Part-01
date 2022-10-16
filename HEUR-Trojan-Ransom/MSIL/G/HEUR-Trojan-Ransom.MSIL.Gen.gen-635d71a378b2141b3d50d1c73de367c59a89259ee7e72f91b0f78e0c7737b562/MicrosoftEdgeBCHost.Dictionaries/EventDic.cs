using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class EventDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventDic()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralReader()
	{
	}
}
