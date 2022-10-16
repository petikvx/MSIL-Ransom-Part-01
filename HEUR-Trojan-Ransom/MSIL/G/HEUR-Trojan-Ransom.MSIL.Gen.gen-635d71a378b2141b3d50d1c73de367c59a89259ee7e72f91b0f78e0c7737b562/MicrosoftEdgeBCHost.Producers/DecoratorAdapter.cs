using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DecoratorAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceMapping()
	{
	}
}
