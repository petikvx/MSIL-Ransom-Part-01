using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class TextEvent : MetaEvent
{
	private string text;

	[NonSerialized]
	internal static GetString _009B;

	public string Text
	{
		get
		{
			return text;
		}
		set
		{
			text = value;
			metaDataLength = text.Length;
		}
	}

	public TextEvent(BinaryReader br, int length)
	{
		Encoding instance = ByteEncoding.Instance;
		text = instance.GetString(br.ReadBytes(length));
	}

	public TextEvent(string text, MetaEventType metaEventType, long absoluteTime)
		: base(metaEventType, text.Length, absoluteTime)
	{
		this.text = text;
	}

	public override MidiEvent Clone()
	{
		return (TextEvent)MemberwiseClone();
	}

	public override string ToString()
	{
		return string.Format(_009B(107397694), base.ToString(), text);
	}

	public override void Export(ref long absoluteTime, BinaryWriter writer)
	{
		base.Export(ref absoluteTime, writer);
		byte[] bytes = ByteEncoding.Instance.GetBytes(text);
		writer.Write(bytes);
	}

	static TextEvent()
	{
		Strings.CreateGetStringDelegate(typeof(TextEvent));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _009B(107399284), _009B(107399247)), _009B(107399242), _009B(107399237)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _009B(107399264)))
		{
			return;
		}
		throw new SecurityException(_009B(107399207));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
