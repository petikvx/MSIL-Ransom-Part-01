using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DicWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfacePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfacePrototype()
	{
	}
}
