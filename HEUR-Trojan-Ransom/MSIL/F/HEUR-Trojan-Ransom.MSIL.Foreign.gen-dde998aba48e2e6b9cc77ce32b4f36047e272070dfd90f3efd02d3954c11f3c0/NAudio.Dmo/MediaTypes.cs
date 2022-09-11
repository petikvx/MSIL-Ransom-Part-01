using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Dmo;

internal static class MediaTypes
{
	public static readonly Guid MEDIATYPE_AnalogAudio;

	public static readonly Guid MEDIATYPE_AnalogVideo;

	public static readonly Guid MEDIATYPE_Audio;

	public static readonly Guid MEDIATYPE_AUXLine21Data;

	public static readonly Guid MEDIATYPE_File;

	public static readonly Guid MEDIATYPE_Interleaved;

	public static readonly Guid MEDIATYPE_Midi;

	public static readonly Guid MEDIATYPE_ScriptCommand;

	public static readonly Guid MEDIATYPE_Stream;

	public static readonly Guid MEDIATYPE_Text;

	public static readonly Guid MEDIATYPE_Timecode;

	public static readonly Guid MEDIATYPE_Video;

	public static readonly Guid[] MajorTypes;

	public static readonly string[] MajorTypeNames;

	[NonSerialized]
	internal static GetString _0005;

	public static string GetMediaTypeName(Guid majorType)
	{
		for (int i = 0; i < MajorTypes.Length; i++)
		{
			if (majorType == MajorTypes[i])
			{
				return MajorTypeNames[i];
			}
		}
		throw new ArgumentException(_0005(107391350));
	}

	static MediaTypes()
	{
		Strings.CreateGetStringDelegate(typeof(MediaTypes));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0005(107397604), _0005(107397567)).Replace(_0005(107397562), _0005(107397557)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_0005(107397584)))
		{
			throw new SecurityException(_0005(107397527));
		}
		MEDIATYPE_AnalogAudio = new Guid(_0005(107391833));
		MEDIATYPE_AnalogVideo = new Guid(_0005(107391816));
		MEDIATYPE_Audio = new Guid(_0005(107391735));
		MEDIATYPE_AUXLine21Data = new Guid(_0005(107391718));
		MEDIATYPE_File = new Guid(_0005(107391637));
		MEDIATYPE_Interleaved = new Guid(_0005(107391620));
		MEDIATYPE_Midi = new Guid(_0005(107391027));
		MEDIATYPE_ScriptCommand = new Guid(_0005(107390978));
		MEDIATYPE_Stream = new Guid(_0005(107390961));
		MEDIATYPE_Text = new Guid(_0005(107390880));
		MEDIATYPE_Timecode = new Guid(_0005(107390863));
		MEDIATYPE_Video = new Guid(_0005(107391294));
		MajorTypes = new Guid[12]
		{
			MEDIATYPE_AnalogAudio, MEDIATYPE_AnalogVideo, MEDIATYPE_Audio, MEDIATYPE_AUXLine21Data, MEDIATYPE_File, MEDIATYPE_Interleaved, MEDIATYPE_Midi, MEDIATYPE_ScriptCommand, MEDIATYPE_Stream, MEDIATYPE_Text,
			MEDIATYPE_Timecode, MEDIATYPE_Video
		};
		MajorTypeNames = new string[12]
		{
			_0005(107391277),
			_0005(107391228),
			_0005(107391243),
			_0005(107391202),
			_0005(107391213),
			_0005(107391204),
			_0005(107391155),
			_0005(107391178),
			_0005(107391125),
			_0005(107391148),
			_0005(107391139),
			_0005(107391094)
		};
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
