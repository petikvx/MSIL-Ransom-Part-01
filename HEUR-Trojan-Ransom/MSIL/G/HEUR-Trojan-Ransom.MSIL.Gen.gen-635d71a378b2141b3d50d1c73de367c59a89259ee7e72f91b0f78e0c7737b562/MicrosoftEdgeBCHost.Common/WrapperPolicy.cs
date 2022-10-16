using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class WrapperPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceAnnotation()
	{
	}
}
