using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParamValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CancelResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelResolver()
	{
	}
}
