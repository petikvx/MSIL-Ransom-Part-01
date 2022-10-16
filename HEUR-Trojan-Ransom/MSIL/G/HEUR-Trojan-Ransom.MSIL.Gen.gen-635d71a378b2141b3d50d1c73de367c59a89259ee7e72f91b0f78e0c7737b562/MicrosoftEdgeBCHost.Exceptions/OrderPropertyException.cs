using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class OrderPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralExporter()
	{
	}
}
