using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AdvisorUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceCollection()
	{
	}
}
