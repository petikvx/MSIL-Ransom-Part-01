using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SystemVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemVal()
	{
		WriterPropertyProducer.ResolveStub();
		ManageSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageSingleton()
	{
	}
}
