using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RoleAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceCode()
	{
	}
}
