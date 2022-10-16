using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InitializerGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceProduct()
	{
	}
}
