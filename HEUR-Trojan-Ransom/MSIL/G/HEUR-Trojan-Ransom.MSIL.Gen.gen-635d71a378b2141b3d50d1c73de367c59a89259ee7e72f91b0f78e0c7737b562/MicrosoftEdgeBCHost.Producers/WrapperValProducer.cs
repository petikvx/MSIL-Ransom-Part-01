using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WrapperValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CallDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallDescriptor()
	{
	}
}
