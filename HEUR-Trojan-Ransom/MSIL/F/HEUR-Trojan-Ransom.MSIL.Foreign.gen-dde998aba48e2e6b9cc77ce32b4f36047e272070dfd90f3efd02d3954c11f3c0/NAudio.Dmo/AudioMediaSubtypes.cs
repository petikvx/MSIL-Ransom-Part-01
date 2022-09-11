using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Dmo;

internal sealed class AudioMediaSubtypes
{
	public static readonly Guid MEDIASUBTYPE_PCM;

	public static readonly Guid MEDIASUBTYPE_PCMAudioObsolete;

	public static readonly Guid MEDIASUBTYPE_MPEG1Packet;

	public static readonly Guid MEDIASUBTYPE_MPEG1Payload;

	public static readonly Guid MEDIASUBTYPE_MPEG2_AUDIO;

	public static readonly Guid MEDIASUBTYPE_DVD_LPCM_AUDIO;

	public static readonly Guid MEDIASUBTYPE_DRM_Audio;

	public static readonly Guid MEDIASUBTYPE_IEEE_FLOAT;

	public static readonly Guid MEDIASUBTYPE_DOLBY_AC3;

	public static readonly Guid MEDIASUBTYPE_DOLBY_AC3_SPDIF;

	public static readonly Guid MEDIASUBTYPE_RAW_SPORT;

	public static readonly Guid MEDIASUBTYPE_SPDIF_TAG_241h;

	public static readonly Guid WMMEDIASUBTYPE_MP3;

	public static readonly Guid MEDIASUBTYPE_WAVE;

	public static readonly Guid MEDIASUBTYPE_AU;

	public static readonly Guid MEDIASUBTYPE_AIFF;

	public static readonly Guid[] AudioSubTypes;

	public static readonly string[] AudioSubTypeNames;

	[NonSerialized]
	internal static GetString _0098;

	public static string GetAudioSubtypeName(Guid subType)
	{
		for (int i = 0; i < AudioSubTypes.Length; i++)
		{
			if (subType == AudioSubTypes[i])
			{
				return AudioSubTypeNames[i];
			}
		}
		return subType.ToString();
	}

	static AudioMediaSubtypes()
	{
		Strings.CreateGetStringDelegate(typeof(AudioMediaSubtypes));
		MEDIASUBTYPE_PCM = new Guid(_0098(107393675));
		MEDIASUBTYPE_PCMAudioObsolete = new Guid(_0098(107393658));
		MEDIASUBTYPE_MPEG1Packet = new Guid(_0098(107393577));
		MEDIASUBTYPE_MPEG1Payload = new Guid(_0098(107393560));
		MEDIASUBTYPE_MPEG2_AUDIO = new Guid(_0098(107392967));
		MEDIASUBTYPE_DVD_LPCM_AUDIO = new Guid(_0098(107392950));
		MEDIASUBTYPE_DRM_Audio = new Guid(_0098(107392869));
		MEDIASUBTYPE_IEEE_FLOAT = new Guid(_0098(107392852));
		MEDIASUBTYPE_DOLBY_AC3 = new Guid(_0098(107392771));
		MEDIASUBTYPE_DOLBY_AC3_SPDIF = new Guid(_0098(107393234));
		MEDIASUBTYPE_RAW_SPORT = new Guid(_0098(107393217));
		MEDIASUBTYPE_SPDIF_TAG_241h = new Guid(_0098(107393136));
		WMMEDIASUBTYPE_MP3 = new Guid(_0098(107393119));
		MEDIASUBTYPE_WAVE = new Guid(_0098(107393038));
		MEDIASUBTYPE_AU = new Guid(_0098(107392509));
		MEDIASUBTYPE_AIFF = new Guid(_0098(107392428));
		AudioSubTypes = new Guid[13]
		{
			MEDIASUBTYPE_PCM, MEDIASUBTYPE_PCMAudioObsolete, MEDIASUBTYPE_MPEG1Packet, MEDIASUBTYPE_MPEG1Payload, MEDIASUBTYPE_MPEG2_AUDIO, MEDIASUBTYPE_DVD_LPCM_AUDIO, MEDIASUBTYPE_DRM_Audio, MEDIASUBTYPE_IEEE_FLOAT, MEDIASUBTYPE_DOLBY_AC3, MEDIASUBTYPE_DOLBY_AC3_SPDIF,
			MEDIASUBTYPE_RAW_SPORT, MEDIASUBTYPE_SPDIF_TAG_241h, WMMEDIASUBTYPE_MP3
		};
		AudioSubTypeNames = new string[13]
		{
			_0098(107392411),
			_0098(107392406),
			_0098(107392357),
			_0098(107392372),
			_0098(107392323),
			_0098(107392306),
			_0098(107392317),
			_0098(107392272),
			_0098(107392287),
			_0098(107392754),
			_0098(107392765),
			_0098(107392720),
			_0098(107392731)
		};
	}
}
