using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParameterWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		RevertRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertRole()
	{
	}
}
