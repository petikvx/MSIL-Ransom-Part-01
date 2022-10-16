using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StructPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralConfig()
	{
	}
}
