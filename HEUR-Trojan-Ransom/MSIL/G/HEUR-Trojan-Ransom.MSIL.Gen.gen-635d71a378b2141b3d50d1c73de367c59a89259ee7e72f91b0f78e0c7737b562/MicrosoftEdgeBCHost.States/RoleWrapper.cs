using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RoleWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateRole()
	{
	}
}
