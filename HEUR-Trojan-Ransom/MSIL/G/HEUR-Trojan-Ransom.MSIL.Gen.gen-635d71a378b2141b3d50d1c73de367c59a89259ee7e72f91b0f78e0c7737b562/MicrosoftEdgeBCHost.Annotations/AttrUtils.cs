using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AttrUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrUtils()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceAdapter()
	{
	}
}
