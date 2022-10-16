using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ObjectPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralVal()
	{
	}
}
