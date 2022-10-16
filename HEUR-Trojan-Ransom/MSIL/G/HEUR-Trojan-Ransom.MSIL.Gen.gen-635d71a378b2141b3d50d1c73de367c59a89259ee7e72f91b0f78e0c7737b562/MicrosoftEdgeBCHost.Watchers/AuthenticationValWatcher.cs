using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AuthenticationValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceAttribute()
	{
	}
}
