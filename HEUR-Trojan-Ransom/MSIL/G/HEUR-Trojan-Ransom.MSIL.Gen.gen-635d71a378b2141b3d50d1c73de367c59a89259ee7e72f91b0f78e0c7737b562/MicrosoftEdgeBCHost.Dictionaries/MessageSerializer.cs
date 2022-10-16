using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MessageSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralEvent()
	{
	}
}
