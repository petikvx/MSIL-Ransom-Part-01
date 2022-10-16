using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ModelPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralVisitor()
	{
	}
}
