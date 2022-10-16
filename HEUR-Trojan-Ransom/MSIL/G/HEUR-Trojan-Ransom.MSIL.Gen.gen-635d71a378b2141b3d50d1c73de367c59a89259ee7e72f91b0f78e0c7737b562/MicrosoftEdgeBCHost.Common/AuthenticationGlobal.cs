using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AuthenticationGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfaceParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfaceParams()
	{
	}
}
