using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AuthenticationBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationBridge()
	{
		WriterPropertyProducer.ResolveStub();
		PushAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushAttr()
	{
	}
}
