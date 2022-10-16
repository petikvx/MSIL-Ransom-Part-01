using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class IssuerServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerServer()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralInterpreter()
	{
	}
}
