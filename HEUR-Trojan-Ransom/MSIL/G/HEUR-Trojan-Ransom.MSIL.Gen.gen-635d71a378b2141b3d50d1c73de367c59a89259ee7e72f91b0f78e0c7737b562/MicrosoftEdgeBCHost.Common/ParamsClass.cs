using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParamsClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsClass()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceReponse()
	{
	}
}
