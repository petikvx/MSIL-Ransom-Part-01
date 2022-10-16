using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IdentifierPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceProcess()
	{
	}
}
