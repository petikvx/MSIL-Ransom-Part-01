using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExceptionPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralDefinition()
	{
	}
}
