using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ValVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValVal()
	{
		WriterPropertyProducer.ResolveStub();
		SelectPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectPublisher()
	{
	}
}
