using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RoleValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ManagePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManagePredicate()
	{
	}
}
