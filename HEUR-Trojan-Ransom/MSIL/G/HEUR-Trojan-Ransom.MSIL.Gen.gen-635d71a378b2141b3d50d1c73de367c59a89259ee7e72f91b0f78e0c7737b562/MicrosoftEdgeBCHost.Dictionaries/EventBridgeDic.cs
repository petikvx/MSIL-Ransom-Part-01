using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class EventBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterceptor()
	{
	}
}
