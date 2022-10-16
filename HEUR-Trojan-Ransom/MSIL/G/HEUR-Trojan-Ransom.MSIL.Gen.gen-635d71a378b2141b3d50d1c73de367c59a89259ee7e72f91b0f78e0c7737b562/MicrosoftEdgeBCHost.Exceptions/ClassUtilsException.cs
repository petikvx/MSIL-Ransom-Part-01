using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ClassUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralStruct()
	{
	}
}
