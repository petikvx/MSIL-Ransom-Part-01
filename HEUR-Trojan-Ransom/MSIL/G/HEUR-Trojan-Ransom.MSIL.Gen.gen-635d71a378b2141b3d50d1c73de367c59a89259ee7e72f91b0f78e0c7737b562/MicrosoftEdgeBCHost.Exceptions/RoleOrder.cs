using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RoleOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleOrder()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeBase()
	{
	}
}
