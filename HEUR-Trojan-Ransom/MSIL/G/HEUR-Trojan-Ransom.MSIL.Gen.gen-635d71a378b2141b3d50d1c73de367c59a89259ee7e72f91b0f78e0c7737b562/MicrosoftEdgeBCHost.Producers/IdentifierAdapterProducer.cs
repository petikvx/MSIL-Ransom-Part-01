using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IdentifierAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralDic()
	{
	}
}
