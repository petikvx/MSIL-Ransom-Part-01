using System;
using System.Runtime.CompilerServices;

namespace Ionic.Zip;

public class SelfExtractorSaveOptions
{
	public extern SelfExtractorFlavor Flavor
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public string PostExtractCommandLine
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_0006, IL_0007, IL_000c
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected I4, but got Unknown
			/*Error: ldloc 1 (out-of-bounds)*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	public string DefaultExtractDirectory
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_000f, IL_0013
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected I4, but got Unknown
			//IL_0011: Expected O, but got I4
			short num = (short)/*Error near IL_0002: Stack underflow*/;
			long num2;
			checked
			{
				num2 = (byte)unchecked(/*Error near IL_0003: Stack underflow*/ % num);
			}
			_003F val = /*Error near IL_0006: Stack underflow*/* num2;
			((short[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/] = (short)(int)val;
			/*Error near IL_000a: Invalid metadata token*/;
		}
		[CompilerGenerated]
		set;
	}

	public extern string IconFile
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern bool Quiet
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public ExtractExistingFileAction ExtractExistingFile
	{
		[CompilerGenerated]
		get
		{
			return (ExtractExistingFileAction)/*OpCode not supported: Nop*/;
		}
		[CompilerGenerated]
		set;
	}

	public unsafe bool RemoveUnpackedFilesAfterExecute
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_000c, IL_0011, IL_0016, IL_001c, IL_0021, IL_0027, IL_002f, IL_0036, IL_003b
			//IL_0002: Expected native int or pointer, but got O
			//IL_0017: Incompatible stack heights: 0 vs 1
			//IL_0022: Invalid comparison between Unknown and I8
			//IL_0027: Unsupported input type for neg.
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				ushort num;
				checked
				{
					num = (ushort)unchecked((int)((uint[])7)[*(sbyte*)(nint)this]);
				}
				*(int*)(nint)/*Error near IL_0007: Stack underflow*/ = num;
			}
		}
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_0006, IL_000b, IL_0011, IL_0016, IL_001c, IL_0024, IL_002b, IL_0030, IL_0036
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_0017: Invalid comparison between Unknown and I8
			//IL_001c: Unsupported input type for neg.
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	public extern Version FileVersion
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern string ProductVersion
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern string Copyright
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern string Description
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern string ProductName
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern string SfxExeWindowTitle
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public unsafe string AdditionalCompilerSwitches
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_001b, IL_0025, IL_002a
			//IL_000d: Invalid comparison between Unknown and I4
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			do
			{
				sbyte num = checked((sbyte)/*Error near IL_0002: Stack underflow*/);
				*(IntPtr*)(nint)/*Error near IL_0003: Stack underflow*/ = (nint)num;
				((object[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (object)/*Error near IL_0004: Stack underflow*/;
			}
			while ((int)/*Error near IL_0012: Stack underflow*/ < (int)(uint)"");
			*(_003F*)(nint)/*Error near IL_0013: Stack underflow*/ = /*Error near IL_0013: Stack underflow*/;
			checked
			{
				_ = /*Error near IL_0014: Stack underflow*/* /*Error near IL_0014: Stack underflow*/;
				/*Error near IL_0014: stloc 0 (out-of-bounds)*/;
				/*Error near IL_0016: Invalid metadata token*/;
			}
		}
		[CompilerGenerated]
		set;
	}

	public extern SelfExtractorSaveOptions();
}
