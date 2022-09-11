using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public class NoteEvent : MidiEvent
{
	private int noteNumber;

	private int velocity;

	private static readonly string[] NoteNames;

	[NonSerialized]
	internal static GetString _001E;

	public virtual int NoteNumber
	{
		get
		{
			return noteNumber;
		}
		set
		{
			if (value < 0 || value > 127)
			{
				throw new ArgumentOutOfRangeException(_001E(107392492), _001E(107413087));
			}
			noteNumber = value;
		}
	}

	public int Velocity
	{
		get
		{
			return velocity;
		}
		set
		{
			if (value < 0 || value > 127)
			{
				throw new ArgumentOutOfRangeException(_001E(107392492), _001E(107413025));
			}
			velocity = value;
		}
	}

	public string NoteName
	{
		get
		{
			if (Channel == 16 || Channel == 10)
			{
				return noteNumber switch
				{
					35 => _001E(107413324), 
					36 => _001E(107413267), 
					37 => _001E(107413282), 
					38 => _001E(107413233), 
					39 => _001E(107412700), 
					40 => _001E(107412687), 
					41 => _001E(107412666), 
					42 => _001E(107412677), 
					43 => _001E(107412624), 
					44 => _001E(107412603), 
					45 => _001E(107412618), 
					46 => _001E(107412573), 
					47 => _001E(107412588), 
					48 => _001E(107412539), 
					49 => _001E(107412554), 
					50 => _001E(107412501), 
					51 => _001E(107412520), 
					52 => _001E(107412467), 
					53 => _001E(107412478), 
					54 => _001E(107412945), 
					55 => _001E(107412960), 
					56 => _001E(107412939), 
					57 => _001E(107412926), 
					58 => _001E(107412905), 
					59 => _001E(107412860), 
					60 => _001E(107412871), 
					61 => _001E(107412826), 
					62 => _001E(107412845), 
					63 => _001E(107412792), 
					64 => _001E(107412803), 
					65 => _001E(107412758), 
					66 => _001E(107412773), 
					67 => _001E(107412724), 
					68 => _001E(107412739), 
					69 => _001E(107412182), 
					70 => _001E(107412205), 
					71 => _001E(107412192), 
					72 => _001E(107412171), 
					73 => _001E(107412122), 
					74 => _001E(107412137), 
					75 => _001E(107412088), 
					76 => _001E(107412079), 
					77 => _001E(107412058), 
					78 => _001E(107412069), 
					79 => _001E(107412020), 
					80 => _001E(107412035), 
					81 => _001E(107411982), 
					_ => string.Format(_001E(107411961), noteNumber), 
				};
			}
			int num = noteNumber / 12;
			return string.Format(_001E(107411980), NoteNames[noteNumber % 12], num);
		}
	}

	public NoteEvent(BinaryReader br)
	{
		NoteNumber = br.ReadByte();
		velocity = br.ReadByte();
		if (velocity > 127)
		{
			velocity = 127;
		}
	}

	public NoteEvent(long absoluteTime, int channel, MidiCommandCode commandCode, int noteNumber, int velocity)
		: base(absoluteTime, channel, commandCode)
	{
		NoteNumber = noteNumber;
		Velocity = velocity;
	}

	public override int GetAsShortMessage()
	{
		return base.GetAsShortMessage() + (noteNumber << 8) + (velocity << 16);
	}

	public override string ToString()
	{
		return string.Format(_001E(107411971), base.ToString(), NoteName, Velocity);
	}

	public override void Export(ref long absoluteTime, BinaryWriter writer)
	{
		base.Export(ref absoluteTime, writer);
		writer.Write((byte)noteNumber);
		writer.Write((byte)velocity);
	}

	static NoteEvent()
	{
		Strings.CreateGetStringDelegate(typeof(NoteEvent));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_001E(107399263), _001E(107399226)).Replace(_001E(107399221), _001E(107399216)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_001E(107399243)))
		{
			throw new SecurityException(_001E(107399186));
		}
		NoteNames = new string[12]
		{
			_001E(107397429),
			_001E(107412430),
			_001E(107412457),
			_001E(107412452),
			_001E(107412447),
			_001E(107412410),
			_001E(107412405),
			_001E(107412400),
			_001E(107412427),
			_001E(107412422),
			_001E(107412417),
			_001E(107391913)
		};
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
