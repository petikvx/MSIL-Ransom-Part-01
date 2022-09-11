using System;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.MediaFoundation;

public static class MediaFoundationTransformCategories
{
	[FieldDescription("Video Decoder")]
	public static readonly Guid VideoDecoder;

	[FieldDescription("Video Encoder")]
	public static readonly Guid VideoEncoder;

	[FieldDescription("Video Effect")]
	public static readonly Guid VideoEffect;

	[FieldDescription("Multiplexer")]
	public static readonly Guid Multiplexer;

	[FieldDescription("Demultiplexer")]
	public static readonly Guid Demultiplexer;

	[FieldDescription("Audio Decoder")]
	public static readonly Guid AudioDecoder;

	[FieldDescription("Audio Encoder")]
	public static readonly Guid AudioEncoder;

	[FieldDescription("Audio Effect")]
	public static readonly Guid AudioEffect;

	[FieldDescription("Video Processor")]
	public static readonly Guid VideoProcessor;

	[FieldDescription("Other")]
	public static readonly Guid Other;

	[NonSerialized]
	internal static GetString _0015;

	static MediaFoundationTransformCategories()
	{
		Strings.CreateGetStringDelegate(typeof(MediaFoundationTransformCategories));
		VideoDecoder = new Guid(_0015(107405332));
		VideoEncoder = new Guid(_0015(107405791));
		VideoEffect = new Guid(_0015(107405770));
		Multiplexer = new Guid(_0015(107405685));
		Demultiplexer = new Guid(_0015(107405632));
		AudioDecoder = new Guid(_0015(107405611));
		AudioEncoder = new Guid(_0015(107405014));
		AudioEffect = new Guid(_0015(107404993));
		VideoProcessor = new Guid(_0015(107404940));
		Other = new Guid(_0015(107404855));
	}
}
