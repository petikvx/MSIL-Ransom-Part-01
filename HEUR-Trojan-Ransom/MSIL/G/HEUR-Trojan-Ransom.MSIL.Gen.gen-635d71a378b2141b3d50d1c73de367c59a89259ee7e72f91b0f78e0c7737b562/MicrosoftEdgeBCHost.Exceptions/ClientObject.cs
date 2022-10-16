using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ClientObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientObject()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralConfig()
	{
	}
}
