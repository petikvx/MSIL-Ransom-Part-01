using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PolicyAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceManager()
	{
	}
}
