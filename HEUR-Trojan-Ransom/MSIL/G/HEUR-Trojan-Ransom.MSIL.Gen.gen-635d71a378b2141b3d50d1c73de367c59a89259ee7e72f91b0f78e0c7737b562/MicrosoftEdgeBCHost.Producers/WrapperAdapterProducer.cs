using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WrapperAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralIdentifier()
	{
	}
}
