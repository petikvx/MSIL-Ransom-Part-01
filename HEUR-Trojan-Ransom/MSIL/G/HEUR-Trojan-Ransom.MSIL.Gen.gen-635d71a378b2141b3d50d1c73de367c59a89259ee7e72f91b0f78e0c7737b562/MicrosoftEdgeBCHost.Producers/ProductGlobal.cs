using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProductGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceParameter()
	{
	}
}
