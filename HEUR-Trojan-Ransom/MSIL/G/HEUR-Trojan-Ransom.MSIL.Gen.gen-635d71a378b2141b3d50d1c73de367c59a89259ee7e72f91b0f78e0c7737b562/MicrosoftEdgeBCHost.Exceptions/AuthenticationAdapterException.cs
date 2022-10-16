using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AuthenticationAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceUtils()
	{
	}
}
