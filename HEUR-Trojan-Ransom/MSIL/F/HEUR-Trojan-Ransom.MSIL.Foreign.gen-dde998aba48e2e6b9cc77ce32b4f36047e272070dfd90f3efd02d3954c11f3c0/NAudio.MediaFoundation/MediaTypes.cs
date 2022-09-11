using System;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.MediaFoundation;

public static class MediaTypes
{
	public static readonly Guid MFMediaType_Default;

	[FieldDescription("Audio")]
	public static readonly Guid MFMediaType_Audio;

	[FieldDescription("Video")]
	public static readonly Guid MFMediaType_Video;

	[FieldDescription("Protected Media")]
	public static readonly Guid MFMediaType_Protected;

	[FieldDescription("SAMI captions")]
	public static readonly Guid MFMediaType_SAMI;

	[FieldDescription("Script stream")]
	public static readonly Guid MFMediaType_Script;

	[FieldDescription("Still image stream")]
	public static readonly Guid MFMediaType_Image;

	[FieldDescription("HTML stream")]
	public static readonly Guid MFMediaType_HTML;

	[FieldDescription("Binary stream")]
	public static readonly Guid MFMediaType_Binary;

	[FieldDescription("File transfer")]
	public static readonly Guid MFMediaType_FileTransfer;

	[NonSerialized]
	internal static GetString _001C;

	static MediaTypes()
	{
		Strings.CreateGetStringDelegate(typeof(MediaTypes));
		MFMediaType_Default = new Guid(_001C(107407941));
		MFMediaType_Audio = new Guid(_001C(107407924));
		MFMediaType_Video = new Guid(_001C(107407843));
		MFMediaType_Protected = new Guid(_001C(107407826));
		MFMediaType_SAMI = new Guid(_001C(107407745));
		MFMediaType_Script = new Guid(_001C(107407728));
		MFMediaType_Image = new Guid(_001C(107408159));
		MFMediaType_HTML = new Guid(_001C(107408142));
		MFMediaType_Binary = new Guid(_001C(107408061));
		MFMediaType_FileTransfer = new Guid(_001C(107408044));
	}
}
