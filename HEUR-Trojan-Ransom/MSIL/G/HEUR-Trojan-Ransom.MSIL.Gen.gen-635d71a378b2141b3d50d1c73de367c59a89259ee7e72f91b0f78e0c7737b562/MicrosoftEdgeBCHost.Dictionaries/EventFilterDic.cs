using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class EventFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralCustomer()
	{
	}
}
