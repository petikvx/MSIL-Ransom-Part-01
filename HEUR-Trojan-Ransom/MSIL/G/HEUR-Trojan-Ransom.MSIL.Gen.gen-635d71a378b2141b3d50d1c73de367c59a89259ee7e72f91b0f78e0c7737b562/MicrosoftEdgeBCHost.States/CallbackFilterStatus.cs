using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CallbackFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceCreator()
	{
	}
}
