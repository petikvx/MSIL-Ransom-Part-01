using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Modest.Audio;

public class Player
{
	private static readonly object object_0;

	private static object object_1;

	[CompilerGenerated]
	private static object object_2;

	[CompilerGenerated]
	private static object object_3;

	public static object WaveFormatConversionStream
	{
		[CompilerGenerated]
		get
		{
			return object_2;
		}
		[CompilerGenerated]
		private set
		{
			object_2 = value;
		}
	}

	public static object PlaybackState
	{
		[CompilerGenerated]
		get
		{
			return object_3;
		}
		[CompilerGenerated]
		private set
		{
			object_3 = value;
		}
	}

	public static void PlayFromFile(string filename, int frequency)
	{
		using (new FileStream(filename, FileMode.Open))
		{
			Class3 @class = new Class3();
			Class2 class2_ = new Class2(object_1);
			@class.method_2(class2_);
			@class.method_1();
			while (@class == object_3)
			{
				Thread.Sleep(100);
				_ = Console.ReadKey().KeyChar;
				@class.method_0();
			}
		}
	}

	public Player()
	{
		Class9.T7DkdFQzGSTU8();
		base._002Ector();
	}
}
