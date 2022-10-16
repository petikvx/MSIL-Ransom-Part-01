using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProxyState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyState()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceException()
	{
	}
}
