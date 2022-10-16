using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class VisitorWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeAttribute()
	{
	}
}
