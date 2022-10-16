using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MessageValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SortCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortCreator()
	{
	}
}
