using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProductExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductExpression()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralRole()
	{
	}
}
