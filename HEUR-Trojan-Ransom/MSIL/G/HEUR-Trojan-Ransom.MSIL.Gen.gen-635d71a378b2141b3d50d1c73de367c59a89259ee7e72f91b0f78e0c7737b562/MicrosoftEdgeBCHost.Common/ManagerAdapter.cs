using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ManagerAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceMapping()
	{
	}
}
