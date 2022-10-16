using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MethodPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceCreator()
	{
	}
}
