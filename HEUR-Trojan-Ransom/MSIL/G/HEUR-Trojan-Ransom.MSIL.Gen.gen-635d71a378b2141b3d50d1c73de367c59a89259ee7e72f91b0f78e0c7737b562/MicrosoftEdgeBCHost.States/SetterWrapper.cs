using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SetterWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ManageState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageState()
	{
	}
}
