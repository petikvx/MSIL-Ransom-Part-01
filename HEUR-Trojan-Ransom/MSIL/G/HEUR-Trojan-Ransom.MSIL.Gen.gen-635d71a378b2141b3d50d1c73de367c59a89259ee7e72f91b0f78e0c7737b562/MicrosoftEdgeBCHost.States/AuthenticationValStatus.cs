using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AuthenticationValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralDescriptor()
	{
	}
}
