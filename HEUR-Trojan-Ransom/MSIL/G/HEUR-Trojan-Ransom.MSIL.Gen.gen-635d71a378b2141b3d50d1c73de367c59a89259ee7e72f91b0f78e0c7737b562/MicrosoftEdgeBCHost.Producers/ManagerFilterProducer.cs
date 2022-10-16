using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ManagerFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CancelMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelMapping()
	{
	}
}
