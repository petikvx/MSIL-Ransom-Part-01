using System.Drawing;
using System.IO;
using StreamLibrary.src;

namespace StreamLibrary;

public abstract class IVideoCodec
{
	public delegate void VideoCodeProgress(Stream stream, Rectangle[] MotionChanges);

	public delegate void VideoDecodeProgress(Bitmap bitmap);

	public delegate void VideoDebugScanningDelegate(Rectangle ScanArea);

	protected JpgCompression jpgCompression;

	public abstract ulong CachedSize { get; internal set; }

	public int ImageQuality { get; set; }

	public abstract int BufferCount { get; }

	public abstract CodecOption CodecOptions { get; }

	public abstract event VideoCodeProgress onVideoStreamCoding;

	public abstract event VideoDecodeProgress onVideoStreamDecoding;

	public abstract event VideoDebugScanningDelegate onCodeDebugScan;

	public abstract event VideoDebugScanningDelegate onDecodeDebugScan;

	public IVideoCodec(int ImageQuality = 100)
	{
		jpgCompression = new JpgCompression(ImageQuality);
		this.ImageQuality = ImageQuality;
	}

	public abstract void CodeImage(Bitmap bitmap, Stream outStream);

	public abstract Bitmap DecodeData(Stream inStream);
}
