using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MappingWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeRole()
	{
	}
}
