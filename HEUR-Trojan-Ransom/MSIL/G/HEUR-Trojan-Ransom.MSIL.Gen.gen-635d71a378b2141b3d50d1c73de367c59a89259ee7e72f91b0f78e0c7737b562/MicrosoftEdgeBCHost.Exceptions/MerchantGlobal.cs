using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MerchantGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceTemplate()
	{
	}
}
