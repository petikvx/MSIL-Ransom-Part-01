using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RoleFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleFilter()
	{
		WriterPropertyProducer.ResolveStub();
		InsertFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertFacade()
	{
	}
}
