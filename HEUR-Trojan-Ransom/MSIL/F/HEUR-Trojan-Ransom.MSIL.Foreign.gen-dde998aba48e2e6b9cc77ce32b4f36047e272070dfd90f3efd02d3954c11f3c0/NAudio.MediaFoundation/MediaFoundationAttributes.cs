using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.MediaFoundation;

public static class MediaFoundationAttributes
{
	public static readonly Guid MF_TRANSFORM_ASYNC;

	public static readonly Guid MF_TRANSFORM_ASYNC_UNLOCK;

	[FieldDescription("Transform Flags")]
	public static readonly Guid MF_TRANSFORM_FLAGS_Attribute;

	[FieldDescription("Transform Category")]
	public static readonly Guid MF_TRANSFORM_CATEGORY_Attribute;

	[FieldDescription("Class identifier")]
	public static readonly Guid MFT_TRANSFORM_CLSID_Attribute;

	[FieldDescription("Input Types")]
	public static readonly Guid MFT_INPUT_TYPES_Attributes;

	[FieldDescription("Output Types")]
	public static readonly Guid MFT_OUTPUT_TYPES_Attributes;

	public static readonly Guid MFT_ENUM_HARDWARE_URL_Attribute;

	[FieldDescription("Name")]
	public static readonly Guid MFT_FRIENDLY_NAME_Attribute;

	public static readonly Guid MFT_CONNECTED_STREAM_ATTRIBUTE;

	public static readonly Guid MFT_CONNECTED_TO_HW_STREAM;

	[FieldDescription("Preferred Output Format")]
	public static readonly Guid MFT_PREFERRED_OUTPUTTYPE_Attribute;

	public static readonly Guid MFT_PROCESS_LOCAL_Attribute;

	public static readonly Guid MFT_PREFERRED_ENCODER_PROFILE;

	public static readonly Guid MFT_HW_TIMESTAMP_WITH_QPC_Attribute;

	public static readonly Guid MFT_FIELDOFUSE_UNLOCK_Attribute;

	public static readonly Guid MFT_CODEC_MERIT_Attribute;

	public static readonly Guid MFT_ENUM_TRANSCODE_ONLY_ATTRIBUTE;

	[FieldDescription("PMP Host Context")]
	public static readonly Guid MF_PD_PMPHOST_CONTEXT;

	[FieldDescription("App Context")]
	public static readonly Guid MF_PD_APP_CONTEXT;

	[FieldDescription("Duration")]
	public static readonly Guid MF_PD_DURATION;

	[FieldDescription("Total File Size")]
	public static readonly Guid MF_PD_TOTAL_FILE_SIZE;

	[FieldDescription("Audio encoding bitrate")]
	public static readonly Guid MF_PD_AUDIO_ENCODING_BITRATE;

	[FieldDescription("Video Encoding Bitrate")]
	public static readonly Guid MF_PD_VIDEO_ENCODING_BITRATE;

	[FieldDescription("MIME Type")]
	public static readonly Guid MF_PD_MIME_TYPE;

	[FieldDescription("Last Modified Time")]
	public static readonly Guid MF_PD_LAST_MODIFIED_TIME;

	[FieldDescription("Element ID")]
	public static readonly Guid MF_PD_PLAYBACK_ELEMENT_ID;

	[FieldDescription("Preferred Language")]
	public static readonly Guid MF_PD_PREFERRED_LANGUAGE;

	[FieldDescription("Playback boundary time")]
	public static readonly Guid MF_PD_PLAYBACK_BOUNDARY_TIME;

	[FieldDescription("Audio is variable bitrate")]
	public static readonly Guid MF_PD_AUDIO_ISVARIABLEBITRATE;

	[FieldDescription("Major Media Type")]
	public static readonly Guid MF_MT_MAJOR_TYPE;

	[FieldDescription("Media Subtype")]
	public static readonly Guid MF_MT_SUBTYPE;

	[FieldDescription("Audio block alignment")]
	public static readonly Guid MF_MT_AUDIO_BLOCK_ALIGNMENT;

	[FieldDescription("Audio average bytes per second")]
	public static readonly Guid MF_MT_AUDIO_AVG_BYTES_PER_SECOND;

	[FieldDescription("Audio number of channels")]
	public static readonly Guid MF_MT_AUDIO_NUM_CHANNELS;

	[FieldDescription("Audio samples per second")]
	public static readonly Guid MF_MT_AUDIO_SAMPLES_PER_SECOND;

	[FieldDescription("Audio bits per sample")]
	public static readonly Guid MF_MT_AUDIO_BITS_PER_SAMPLE;

	[FieldDescription("Enable Hardware Transforms")]
	public static readonly Guid MF_READWRITE_ENABLE_HARDWARE_TRANSFORMS;

	[FieldDescription("User data")]
	public static readonly Guid MF_MT_USER_DATA;

	[FieldDescription("All samples independent")]
	public static readonly Guid MF_MT_ALL_SAMPLES_INDEPENDENT;

	[FieldDescription("Fixed size samples")]
	public static readonly Guid MF_MT_FIXED_SIZE_SAMPLES;

	[FieldDescription("DirectShow Format Guid")]
	public static readonly Guid MF_MT_AM_FORMAT_TYPE;

	[FieldDescription("Preferred legacy format structure")]
	public static readonly Guid MF_MT_AUDIO_PREFER_WAVEFORMATEX;

	[FieldDescription("Is Compressed")]
	public static readonly Guid MF_MT_COMPRESSED;

	[FieldDescription("Average bitrate")]
	public static readonly Guid MF_MT_AVG_BITRATE;

	[FieldDescription("AAC payload type")]
	public static readonly Guid MF_MT_AAC_PAYLOAD_TYPE;

	[FieldDescription("AAC Audio Profile Level Indication")]
	public static readonly Guid MF_MT_AAC_AUDIO_PROFILE_LEVEL_INDICATION;

	[NonSerialized]
	internal static GetString _0084;

	static MediaFoundationAttributes()
	{
		Strings.CreateGetStringDelegate(typeof(MediaFoundationAttributes));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0084(107399773), _0084(107399736)).Replace(_0084(107399731), _0084(107399726)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_0084(107399753)))
		{
			throw new SecurityException(_0084(107399696));
		}
		MF_TRANSFORM_ASYNC = new Guid(_0084(107408110));
		MF_TRANSFORM_ASYNC_UNLOCK = new Guid(_0084(107407581));
		MF_TRANSFORM_FLAGS_Attribute = new Guid(_0084(107407500));
		MF_TRANSFORM_CATEGORY_Attribute = new Guid(_0084(107407451));
		MFT_TRANSFORM_CLSID_Attribute = new Guid(_0084(107407434));
		MFT_INPUT_TYPES_Attributes = new Guid(_0084(107407353));
		MFT_OUTPUT_TYPES_Attributes = new Guid(_0084(107407848));
		MFT_ENUM_HARDWARE_URL_Attribute = new Guid(_0084(107407767));
		MFT_FRIENDLY_NAME_Attribute = new Guid(_0084(107407750));
		MFT_CONNECTED_STREAM_ATTRIBUTE = new Guid(_0084(107407669));
		MFT_CONNECTED_TO_HW_STREAM = new Guid(_0084(107407652));
		MFT_PREFERRED_OUTPUTTYPE_Attribute = new Guid(_0084(107407059));
		MFT_PROCESS_LOCAL_Attribute = new Guid(_0084(107407042));
		MFT_PREFERRED_ENCODER_PROFILE = new Guid(_0084(107406961));
		MFT_HW_TIMESTAMP_WITH_QPC_Attribute = new Guid(_0084(107406944));
		MFT_FIELDOFUSE_UNLOCK_Attribute = new Guid(_0084(107406863));
		MFT_CODEC_MERIT_Attribute = new Guid(_0084(107406846));
		MFT_ENUM_TRANSCODE_ONLY_ATTRIBUTE = new Guid(_0084(107407277));
		MF_PD_PMPHOST_CONTEXT = new Guid(_0084(107407260));
		MF_PD_APP_CONTEXT = new Guid(_0084(107407211));
		MF_PD_DURATION = new Guid(_0084(107407130));
		MF_PD_TOTAL_FILE_SIZE = new Guid(_0084(107407113));
		MF_PD_AUDIO_ENCODING_BITRATE = new Guid(_0084(107406520));
		MF_PD_VIDEO_ENCODING_BITRATE = new Guid(_0084(107406503));
		MF_PD_MIME_TYPE = new Guid(_0084(107406422));
		MF_PD_LAST_MODIFIED_TIME = new Guid(_0084(107406405));
		MF_PD_PLAYBACK_ELEMENT_ID = new Guid(_0084(107406324));
		MF_PD_PREFERRED_LANGUAGE = new Guid(_0084(107406819));
		MF_PD_PLAYBACK_BOUNDARY_TIME = new Guid(_0084(107406738));
		MF_PD_AUDIO_ISVARIABLEBITRATE = new Guid(_0084(107406721));
		MF_MT_MAJOR_TYPE = new Guid(_0084(107406640));
		MF_MT_SUBTYPE = new Guid(_0084(107406623));
		MF_MT_AUDIO_BLOCK_ALIGNMENT = new Guid(_0084(107406030));
		MF_MT_AUDIO_AVG_BYTES_PER_SECOND = new Guid(_0084(107406013));
		MF_MT_AUDIO_NUM_CHANNELS = new Guid(_0084(107405932));
		MF_MT_AUDIO_SAMPLES_PER_SECOND = new Guid(_0084(107405883));
		MF_MT_AUDIO_BITS_PER_SAMPLE = new Guid(_0084(107405866));
		MF_READWRITE_ENABLE_HARDWARE_TRANSFORMS = new Guid(_0084(107406297));
		MF_MT_USER_DATA = new Guid(_0084(107406280));
		MF_MT_ALL_SAMPLES_INDEPENDENT = new Guid(_0084(107406199));
		MF_MT_FIXED_SIZE_SAMPLES = new Guid(_0084(107406182));
		MF_MT_AM_FORMAT_TYPE = new Guid(_0084(107406101));
		MF_MT_AUDIO_PREFER_WAVEFORMATEX = new Guid(_0084(107406084));
		MF_MT_COMPRESSED = new Guid(_0084(107405491));
		MF_MT_AVG_BITRATE = new Guid(_0084(107405474));
		MF_MT_AAC_PAYLOAD_TYPE = new Guid(_0084(107405393));
		MF_MT_AAC_AUDIO_PROFILE_LEVEL_INDICATION = new Guid(_0084(107405376));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
