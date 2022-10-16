using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InterpreterPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		ListLiteralInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListLiteralInvocation()
	{
	}
}
