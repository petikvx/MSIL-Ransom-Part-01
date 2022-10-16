using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InvocationPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralConfig()
	{
	}
}
