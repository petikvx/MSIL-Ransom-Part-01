using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SchemaHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaHelper()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralSerializer()
	{
	}
}
