using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InterceptorPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralAuthentication()
	{
	}
}
