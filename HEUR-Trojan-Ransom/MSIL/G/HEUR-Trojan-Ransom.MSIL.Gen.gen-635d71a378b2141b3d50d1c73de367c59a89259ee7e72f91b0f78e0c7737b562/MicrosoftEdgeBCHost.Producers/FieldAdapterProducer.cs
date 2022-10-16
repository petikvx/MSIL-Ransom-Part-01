using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FieldAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralMessage()
	{
	}
}
