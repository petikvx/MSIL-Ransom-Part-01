using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class GlobalPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralPrototype()
	{
	}
}
