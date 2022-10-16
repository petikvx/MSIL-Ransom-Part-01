using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ThreadProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadProperty()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceAttribute()
	{
	}
}
