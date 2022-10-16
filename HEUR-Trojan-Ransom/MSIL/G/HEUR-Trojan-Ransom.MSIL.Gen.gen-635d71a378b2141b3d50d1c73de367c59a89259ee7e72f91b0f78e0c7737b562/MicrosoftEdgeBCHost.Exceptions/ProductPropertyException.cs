using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProductPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralDefinition()
	{
	}
}
