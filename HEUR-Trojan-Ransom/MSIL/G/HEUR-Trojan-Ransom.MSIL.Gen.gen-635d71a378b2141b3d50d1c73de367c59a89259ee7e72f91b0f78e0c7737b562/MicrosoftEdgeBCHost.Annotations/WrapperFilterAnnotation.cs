using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WrapperFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterMerchant()
	{
	}
}
