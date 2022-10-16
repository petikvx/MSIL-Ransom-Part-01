using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StubPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceAnnotation()
	{
	}
}
