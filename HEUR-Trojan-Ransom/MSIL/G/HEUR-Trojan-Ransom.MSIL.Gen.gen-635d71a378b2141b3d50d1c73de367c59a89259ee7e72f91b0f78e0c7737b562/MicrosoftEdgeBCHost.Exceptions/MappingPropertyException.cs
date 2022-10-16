using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MappingPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralInfo()
	{
	}
}
