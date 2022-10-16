using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ListVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListVal()
	{
		WriterPropertyProducer.ResolveStub();
		SelectSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectSpecification()
	{
	}
}
