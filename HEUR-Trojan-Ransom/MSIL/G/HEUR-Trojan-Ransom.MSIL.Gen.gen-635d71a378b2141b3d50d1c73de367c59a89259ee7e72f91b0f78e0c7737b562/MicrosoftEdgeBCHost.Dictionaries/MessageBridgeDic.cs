using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MessageBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInvocation()
	{
	}
}
