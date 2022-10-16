using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ModelUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelUtils()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceCollection()
	{
	}
}
