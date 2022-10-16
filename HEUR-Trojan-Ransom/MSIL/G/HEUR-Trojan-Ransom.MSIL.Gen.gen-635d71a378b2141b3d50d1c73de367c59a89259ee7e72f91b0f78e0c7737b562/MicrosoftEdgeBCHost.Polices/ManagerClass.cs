using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ManagerClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerClass()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceInterceptor()
	{
	}
}
