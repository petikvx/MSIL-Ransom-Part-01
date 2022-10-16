using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DescriptorWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CreateSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateSetter()
	{
	}
}
