using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InstancePropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstancePropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralPrinter()
	{
	}
}
