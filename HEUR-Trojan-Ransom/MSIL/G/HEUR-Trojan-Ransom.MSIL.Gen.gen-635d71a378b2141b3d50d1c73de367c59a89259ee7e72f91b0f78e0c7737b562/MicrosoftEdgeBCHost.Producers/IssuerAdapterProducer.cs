using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IssuerAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralTemplate()
	{
	}
}
