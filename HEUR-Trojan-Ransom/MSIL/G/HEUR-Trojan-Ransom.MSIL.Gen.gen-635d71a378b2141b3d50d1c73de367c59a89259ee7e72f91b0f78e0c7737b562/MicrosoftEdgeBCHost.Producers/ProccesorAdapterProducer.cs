using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProccesorAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralComparator()
	{
	}
}
