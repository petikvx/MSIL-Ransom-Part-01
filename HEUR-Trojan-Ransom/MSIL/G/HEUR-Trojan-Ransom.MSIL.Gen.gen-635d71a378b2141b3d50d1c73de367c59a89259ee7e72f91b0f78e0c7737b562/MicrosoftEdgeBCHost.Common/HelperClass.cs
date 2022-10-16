using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class HelperClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperClass()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceSerializer()
	{
	}
}
