using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MapperFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatPublisher()
	{
	}
}
