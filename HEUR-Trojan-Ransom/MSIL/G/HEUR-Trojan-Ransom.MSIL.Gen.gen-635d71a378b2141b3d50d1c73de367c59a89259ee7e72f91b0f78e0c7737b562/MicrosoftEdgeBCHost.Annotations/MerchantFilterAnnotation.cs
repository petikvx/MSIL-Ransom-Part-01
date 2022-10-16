using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MerchantFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceRole()
	{
	}
}
