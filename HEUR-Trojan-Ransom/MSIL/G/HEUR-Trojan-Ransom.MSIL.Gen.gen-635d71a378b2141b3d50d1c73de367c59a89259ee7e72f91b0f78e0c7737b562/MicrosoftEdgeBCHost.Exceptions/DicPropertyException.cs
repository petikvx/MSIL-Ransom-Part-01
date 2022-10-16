using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DicPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralResolver()
	{
	}
}
