using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FieldOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfaceField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfaceField()
	{
	}
}
