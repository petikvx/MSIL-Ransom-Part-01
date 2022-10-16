using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class GetterObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterObject()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralExpression()
	{
	}
}
