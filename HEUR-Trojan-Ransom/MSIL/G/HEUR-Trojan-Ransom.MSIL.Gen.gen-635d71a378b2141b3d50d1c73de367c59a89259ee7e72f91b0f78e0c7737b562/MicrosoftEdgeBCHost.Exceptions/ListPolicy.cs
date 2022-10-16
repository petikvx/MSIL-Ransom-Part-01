using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ListPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceInvocation()
	{
	}
}
