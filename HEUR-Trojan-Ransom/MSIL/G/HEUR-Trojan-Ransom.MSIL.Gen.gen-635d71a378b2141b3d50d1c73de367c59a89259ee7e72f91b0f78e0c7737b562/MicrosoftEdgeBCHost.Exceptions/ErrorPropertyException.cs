using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ErrorPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralDefinition()
	{
	}
}
