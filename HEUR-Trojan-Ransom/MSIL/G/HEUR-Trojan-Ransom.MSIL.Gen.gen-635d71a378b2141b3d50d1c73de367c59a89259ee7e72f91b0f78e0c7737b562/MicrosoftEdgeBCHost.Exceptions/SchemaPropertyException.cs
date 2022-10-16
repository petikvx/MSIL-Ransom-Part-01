using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SchemaPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralRules()
	{
	}
}
