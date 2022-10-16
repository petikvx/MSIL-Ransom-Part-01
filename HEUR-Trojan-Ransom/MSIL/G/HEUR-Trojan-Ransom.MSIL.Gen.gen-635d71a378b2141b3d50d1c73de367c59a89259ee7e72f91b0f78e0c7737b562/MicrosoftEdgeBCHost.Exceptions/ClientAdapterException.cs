using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ClientAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralInstance()
	{
	}
}
