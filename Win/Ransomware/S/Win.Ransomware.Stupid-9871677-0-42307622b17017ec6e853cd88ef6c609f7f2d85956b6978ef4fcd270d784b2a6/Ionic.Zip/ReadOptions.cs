using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ionic.Zip;

public class ReadOptions
{
	public extern EventHandler<ReadProgressEventArgs> ReadProgress
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public TextWriter StatusMessageWriter
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_0006, IL_000c, IL_0015, IL_0023, IL_0029
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Incompatible stack heights: 0 vs 1
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0002: Stack underflow*/^ /*Error near IL_0002: Stack underflow*/;
			_ = (long)/*Error near IL_0002: ldloca 0 (out-of-bounds)*/;
			/*Error near IL_0005: Unknown opcode: 0xFF*/;
		}
	}

	public Encoding Encoding
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_0005, IL_000c, IL_001a, IL_0020
			//IL_0015: Incompatible stack heights: 0 vs 1
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			/*Error: Invalid metadata token*/;
		}
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_0005, IL_0015, IL_001b
			//IL_0010: Incompatible stack heights: 0 vs 1
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			/*Error: Invalid metadata token*/;
		}
	}

	public extern ReadOptions();
}
