using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class Role
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Role()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeMapping()
	{
	}
}
