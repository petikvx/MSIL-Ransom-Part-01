using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InstanceAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralRef()
	{
	}
}
