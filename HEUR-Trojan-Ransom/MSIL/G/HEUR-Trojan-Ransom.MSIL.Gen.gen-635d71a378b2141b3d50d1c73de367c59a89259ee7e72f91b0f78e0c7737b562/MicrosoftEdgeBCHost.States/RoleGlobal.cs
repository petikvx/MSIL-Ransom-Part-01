using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RoleGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceStrategy()
	{
	}
}
