using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ModelProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelProperty()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceDic()
	{
	}
}
