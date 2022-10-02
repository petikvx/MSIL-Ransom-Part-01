using System;
using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Bridges;

internal class PrototypeManagerBridge : Attribute
{
	internal static object DeleteBroadcaster;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PrototypeManagerBridge(string spec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeManagerBridge()
	{
		DicWriterConsumer.ListIndexer();
		QueryBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateBroadcaster()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CustomizeBroadcaster()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PrototypeManagerBridge PatchBroadcaster()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryBroadcaster()
	{
	}
}
