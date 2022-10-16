using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AdapterReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterReponse()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceBase()
	{
	}
}
