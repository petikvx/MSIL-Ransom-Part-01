using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MapperExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperExpression()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralTests()
	{
	}
}
