using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class VisitorGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceTemplate()
	{
	}
}
