using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InterpreterAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralIdentifier()
	{
	}
}
