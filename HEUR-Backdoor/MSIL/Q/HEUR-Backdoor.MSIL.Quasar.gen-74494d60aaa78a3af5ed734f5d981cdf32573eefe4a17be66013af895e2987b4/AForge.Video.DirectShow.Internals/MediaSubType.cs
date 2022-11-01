using System;
using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[ComVisible(false)]
internal static class MediaSubType
{
	public static readonly Guid YUYV = new Guid(1448695129, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);

	public static readonly Guid IYUV = new Guid(1448433993, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);

	public static readonly Guid DVSD = new Guid(1146312260, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);

	public static readonly Guid RGB1 = new Guid(3828804472u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

	public static readonly Guid RGB4 = new Guid(3828804473u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

	public static readonly Guid RGB8 = new Guid(3828804474u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

	public static readonly Guid RGB565 = new Guid(3828804475u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

	public static readonly Guid RGB555 = new Guid(3828804476u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

	public static readonly Guid RGB24 = new Guid(3828804477u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

	public static readonly Guid RGB32 = new Guid(3828804478u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

	public static readonly Guid Avi = new Guid(3828804488u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

	public static readonly Guid Asf = new Guid(1035472784u, 37906, 4561, 173, 237, 0, 0, 248, 117, 75, 153);
}
