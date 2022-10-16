using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ContextPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralStub()
	{
	}
}
