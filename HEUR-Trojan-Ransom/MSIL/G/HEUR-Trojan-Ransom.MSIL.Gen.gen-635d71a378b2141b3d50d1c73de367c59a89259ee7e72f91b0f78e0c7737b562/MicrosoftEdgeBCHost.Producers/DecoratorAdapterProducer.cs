using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DecoratorAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralInterpreter()
	{
	}
}
