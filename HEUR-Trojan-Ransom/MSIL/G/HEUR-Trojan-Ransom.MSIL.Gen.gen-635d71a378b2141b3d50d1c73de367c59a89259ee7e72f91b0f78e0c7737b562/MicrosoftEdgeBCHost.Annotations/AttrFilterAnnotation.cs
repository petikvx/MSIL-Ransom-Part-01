using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AttrFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceState()
	{
	}
}
