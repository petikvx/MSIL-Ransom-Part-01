using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class GetterExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterExpression()
	{
		WriterPropertyProducer.ResolveStub();
		AddLiteralTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddLiteralTests()
	{
	}
}
