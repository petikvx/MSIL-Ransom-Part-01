using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ServiceContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceContext()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceSingleton()
	{
	}
}
