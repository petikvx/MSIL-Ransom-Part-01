using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RoleContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleContext()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceSpecification()
	{
	}
}
