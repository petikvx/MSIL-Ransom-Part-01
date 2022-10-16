using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ErrorObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorObject()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralSchema()
	{
	}
}
