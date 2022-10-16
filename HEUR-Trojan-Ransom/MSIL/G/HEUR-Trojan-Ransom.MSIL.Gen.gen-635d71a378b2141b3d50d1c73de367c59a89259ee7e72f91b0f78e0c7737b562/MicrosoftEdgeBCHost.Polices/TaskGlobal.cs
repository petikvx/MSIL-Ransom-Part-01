using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TaskGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceAuthentication()
	{
	}
}
