using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TokenPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralParam()
	{
	}
}
