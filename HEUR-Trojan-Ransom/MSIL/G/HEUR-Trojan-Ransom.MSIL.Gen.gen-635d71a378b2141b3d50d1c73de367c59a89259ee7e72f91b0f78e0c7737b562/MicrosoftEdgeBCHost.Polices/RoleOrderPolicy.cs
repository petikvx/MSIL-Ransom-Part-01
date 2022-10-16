using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RoleOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralAttr()
	{
	}
}
