using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StateObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateObject()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralModel()
	{
	}
}
