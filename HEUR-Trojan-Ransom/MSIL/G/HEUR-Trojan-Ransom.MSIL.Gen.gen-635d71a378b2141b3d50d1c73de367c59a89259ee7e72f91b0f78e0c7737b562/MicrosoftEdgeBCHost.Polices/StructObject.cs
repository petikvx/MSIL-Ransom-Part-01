using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StructObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructObject()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralTemplate()
	{
	}
}
