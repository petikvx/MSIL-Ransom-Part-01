using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class GetterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceList()
	{
	}
}
