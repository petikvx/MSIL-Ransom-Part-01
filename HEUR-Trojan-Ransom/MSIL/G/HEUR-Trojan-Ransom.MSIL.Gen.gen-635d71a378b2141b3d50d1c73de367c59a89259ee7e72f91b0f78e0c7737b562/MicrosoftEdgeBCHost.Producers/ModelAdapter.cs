using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ModelAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceIdentifier()
	{
	}
}
