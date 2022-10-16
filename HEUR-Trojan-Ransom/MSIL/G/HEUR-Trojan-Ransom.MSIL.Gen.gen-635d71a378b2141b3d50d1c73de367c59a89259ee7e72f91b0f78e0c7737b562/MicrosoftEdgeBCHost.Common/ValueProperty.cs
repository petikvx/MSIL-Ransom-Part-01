using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ValueProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueProperty()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceDescriptor()
	{
	}
}
