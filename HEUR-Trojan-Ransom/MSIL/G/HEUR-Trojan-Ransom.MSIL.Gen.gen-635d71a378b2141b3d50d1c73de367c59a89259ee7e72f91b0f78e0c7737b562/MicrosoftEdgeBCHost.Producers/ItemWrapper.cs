using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ItemWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateRef()
	{
	}
}
