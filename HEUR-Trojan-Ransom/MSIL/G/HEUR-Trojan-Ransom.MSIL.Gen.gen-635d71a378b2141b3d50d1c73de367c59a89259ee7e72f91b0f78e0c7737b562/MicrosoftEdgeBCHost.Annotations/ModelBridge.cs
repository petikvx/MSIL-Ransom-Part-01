using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ModelBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelBridge()
	{
		WriterPropertyProducer.ResolveStub();
		PatchStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchStatus()
	{
	}
}
