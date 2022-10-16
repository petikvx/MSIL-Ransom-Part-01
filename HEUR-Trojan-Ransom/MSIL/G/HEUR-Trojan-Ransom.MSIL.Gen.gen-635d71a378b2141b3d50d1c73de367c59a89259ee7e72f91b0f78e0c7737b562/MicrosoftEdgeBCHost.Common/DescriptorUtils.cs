using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DescriptorUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorUtils()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceCollection()
	{
	}
}
