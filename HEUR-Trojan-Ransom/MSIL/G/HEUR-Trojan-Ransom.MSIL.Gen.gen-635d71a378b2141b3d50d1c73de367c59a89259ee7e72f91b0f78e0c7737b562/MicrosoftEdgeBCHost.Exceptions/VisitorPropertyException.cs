using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class VisitorPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralProperty()
	{
	}
}
