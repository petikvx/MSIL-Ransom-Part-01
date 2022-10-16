using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CreatorReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorReponse()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceMerchant()
	{
	}
}
