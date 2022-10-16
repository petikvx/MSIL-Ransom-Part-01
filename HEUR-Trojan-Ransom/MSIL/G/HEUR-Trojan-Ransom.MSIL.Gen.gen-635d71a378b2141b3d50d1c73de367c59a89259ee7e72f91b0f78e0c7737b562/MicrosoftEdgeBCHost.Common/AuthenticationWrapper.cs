using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AuthenticationWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectDecorator()
	{
	}
}
