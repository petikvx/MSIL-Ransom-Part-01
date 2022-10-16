using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MessageAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ListLiteralComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListLiteralComposer()
	{
	}
}
