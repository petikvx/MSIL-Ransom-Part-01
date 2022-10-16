using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ModelBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceInstance()
	{
	}
}
