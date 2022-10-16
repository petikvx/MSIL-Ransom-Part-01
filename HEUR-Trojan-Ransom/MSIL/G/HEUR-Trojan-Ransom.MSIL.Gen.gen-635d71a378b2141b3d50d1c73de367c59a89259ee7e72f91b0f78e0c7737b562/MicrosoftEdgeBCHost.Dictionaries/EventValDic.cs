using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class EventValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralToken()
	{
	}
}
