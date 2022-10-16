using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AlgoPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralVal()
	{
	}
}
