using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TemplateValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceDescriptor()
	{
	}
}
