using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ErrorValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CreateGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateGlobal()
	{
	}
}
