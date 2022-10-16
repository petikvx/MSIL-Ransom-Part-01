using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FacadeReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeReponse()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceMerchant()
	{
	}
}
