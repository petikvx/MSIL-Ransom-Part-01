using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InstanceObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceObject()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralParams()
	{
	}
}
