using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class UtilsPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceInfo()
	{
	}
}
