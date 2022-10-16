using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InterceptorAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceTokenizer()
	{
	}
}
