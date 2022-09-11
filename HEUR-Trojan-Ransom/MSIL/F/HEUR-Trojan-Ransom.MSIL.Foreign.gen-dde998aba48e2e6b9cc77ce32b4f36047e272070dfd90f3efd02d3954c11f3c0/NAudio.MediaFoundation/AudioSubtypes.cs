using System;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.MediaFoundation;

public static class AudioSubtypes
{
	[FieldDescription("AAC")]
	public static readonly Guid MFAudioFormat_AAC;

	[FieldDescription("ADTS")]
	public static readonly Guid MFAudioFormat_ADTS;

	[FieldDescription("Dolby AC3 SPDIF")]
	public static readonly Guid MFAudioFormat_Dolby_AC3_SPDIF;

	[FieldDescription("DRM")]
	public static readonly Guid MFAudioFormat_DRM;

	[FieldDescription("DTS")]
	public static readonly Guid MFAudioFormat_DTS;

	[FieldDescription("IEEE floating-point")]
	public static readonly Guid MFAudioFormat_Float;

	[FieldDescription("MP3")]
	public static readonly Guid MFAudioFormat_MP3;

	[FieldDescription("MPEG")]
	public static readonly Guid MFAudioFormat_MPEG;

	[FieldDescription("WMA 9 Voice codec")]
	public static readonly Guid MFAudioFormat_MSP1;

	[FieldDescription("PCM")]
	public static readonly Guid MFAudioFormat_PCM;

	[FieldDescription("WMA SPDIF")]
	public static readonly Guid MFAudioFormat_WMASPDIF;

	[FieldDescription("WMAudio Lossless")]
	public static readonly Guid MFAudioFormat_WMAudio_Lossless;

	[FieldDescription("Windows Media Audio")]
	public static readonly Guid MFAudioFormat_WMAudioV8;

	[FieldDescription("Windows Media Audio Professional")]
	public static readonly Guid MFAudioFormat_WMAudioV9;

	[FieldDescription("Dolby AC3")]
	public static readonly Guid MFAudioFormat_Dolby_AC3;

	[FieldDescription("MPEG-4 and AAC Audio Types")]
	public static readonly Guid MEDIASUBTYPE_RAW_AAC1;

	[FieldDescription("Dolby Audio Types")]
	public static readonly Guid MEDIASUBTYPE_DVM;

	[FieldDescription("Dolby Audio Types")]
	public static readonly Guid MEDIASUBTYPE_DOLBY_DDPLUS;

	[FieldDescription("μ-law")]
	public static readonly Guid KSDATAFORMAT_SUBTYPE_MULAW;

	[FieldDescription("ADPCM")]
	public static readonly Guid KSDATAFORMAT_SUBTYPE_ADPCM;

	[FieldDescription("Dolby Digital Plus for HDMI")]
	public static readonly Guid KSDATAFORMAT_SUBTYPE_IEC61937_DOLBY_DIGITAL_PLUS;

	[FieldDescription("MSAudio1")]
	public static readonly Guid MEDIASUBTYPE_MSAUDIO1;

	[FieldDescription("IMA ADPCM")]
	public static readonly Guid ImaAdpcm;

	[FieldDescription("WMSP2")]
	public static readonly Guid WMMEDIASUBTYPE_WMSP2;

	[NonSerialized]
	internal static GetString _008F;

	static AudioSubtypes()
	{
		Strings.CreateGetStringDelegate(typeof(AudioSubtypes));
		MFAudioFormat_AAC = new Guid(_008F(107408611));
		MFAudioFormat_ADTS = new Guid(_008F(107408562));
		MFAudioFormat_Dolby_AC3_SPDIF = new Guid(_008F(107395058));
		MFAudioFormat_DRM = new Guid(_008F(107394693));
		MFAudioFormat_DTS = new Guid(_008F(107408545));
		MFAudioFormat_Float = new Guid(_008F(107394676));
		MFAudioFormat_MP3 = new Guid(_008F(107408464));
		MFAudioFormat_MPEG = new Guid(_008F(107408447));
		MFAudioFormat_MSP1 = new Guid(_008F(107408878));
		MFAudioFormat_PCM = new Guid(_008F(107408861));
		MFAudioFormat_WMASPDIF = new Guid(_008F(107408780));
		MFAudioFormat_WMAudio_Lossless = new Guid(_008F(107408763));
		MFAudioFormat_WMAudioV8 = new Guid(_008F(107408682));
		MFAudioFormat_WMAudioV9 = new Guid(_008F(107408153));
		MFAudioFormat_Dolby_AC3 = new Guid(_008F(107394595));
		MEDIASUBTYPE_RAW_AAC1 = new Guid(_008F(107408072));
		MEDIASUBTYPE_DVM = new Guid(_008F(107408055));
		MEDIASUBTYPE_DOLBY_DDPLUS = new Guid(_008F(107407974));
		KSDATAFORMAT_SUBTYPE_MULAW = new Guid(_008F(107407957));
		KSDATAFORMAT_SUBTYPE_ADPCM = new Guid(_008F(107408388));
		KSDATAFORMAT_SUBTYPE_IEC61937_DOLBY_DIGITAL_PLUS = new Guid(_008F(107408371));
		MEDIASUBTYPE_MSAUDIO1 = new Guid(_008F(107408322));
		ImaAdpcm = new Guid(_008F(107408241));
		WMMEDIASUBTYPE_WMSP2 = new Guid(_008F(107408224));
	}
}
