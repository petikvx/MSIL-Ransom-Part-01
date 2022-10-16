using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MapPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		AddLiteralPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddLiteralPrinter()
	{
	}
}
