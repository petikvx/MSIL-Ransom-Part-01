using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MapperPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceHelper()
	{
	}
}
