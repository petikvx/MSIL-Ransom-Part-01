using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class GetterWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectRef()
	{
	}
}
