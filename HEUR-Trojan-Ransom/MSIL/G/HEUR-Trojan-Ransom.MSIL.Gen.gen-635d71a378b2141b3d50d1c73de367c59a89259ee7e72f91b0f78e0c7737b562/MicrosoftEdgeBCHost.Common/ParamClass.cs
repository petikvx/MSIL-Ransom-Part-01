using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParamClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamClass()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfacePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfacePool()
	{
	}
}
