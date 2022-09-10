using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Vestris.ResourceLib;

public class FixedFileInfo
{
	private Kernel32.VS_FIXEDFILEINFO _fixedfileinfo = Kernel32.VS_FIXEDFILEINFO.GetWindowsDefault();

	public Kernel32.VS_FIXEDFILEINFO Value => _fixedfileinfo;

	public string FileVersion
	{
		get
		{
			return $"{ResourceUtil.HiWord(_fixedfileinfo.dwFileVersionMS)}.{ResourceUtil.LoWord(_fixedfileinfo.dwFileVersionMS)}.{ResourceUtil.HiWord(_fixedfileinfo.dwFileVersionLS)}.{ResourceUtil.LoWord(_fixedfileinfo.dwFileVersionLS)}";
		}
		set
		{
			uint num = 0u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			string[] array = value.Split(".".ToCharArray(), 4);
			if (array.Length >= 1)
			{
				num = uint.Parse(array[0]);
			}
			if (array.Length >= 2)
			{
				num2 = uint.Parse(array[1]);
			}
			if (array.Length >= 3)
			{
				num3 = uint.Parse(array[2]);
			}
			if (array.Length >= 4)
			{
				num4 = uint.Parse(array[3]);
			}
			_fixedfileinfo.dwFileVersionMS = (num << 16) + num2;
			_fixedfileinfo.dwFileVersionLS = (num3 << 16) + num4;
		}
	}

	public string ProductVersion
	{
		get
		{
			return $"{ResourceUtil.HiWord(_fixedfileinfo.dwProductVersionMS)}.{ResourceUtil.LoWord(_fixedfileinfo.dwProductVersionMS)}.{ResourceUtil.HiWord(_fixedfileinfo.dwProductVersionLS)}.{ResourceUtil.LoWord(_fixedfileinfo.dwProductVersionLS)}";
		}
		set
		{
			uint num = 0u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			string[] array = value.Split(".".ToCharArray(), 4);
			if (array.Length >= 1)
			{
				num = uint.Parse(array[0]);
			}
			if (array.Length >= 2)
			{
				num2 = uint.Parse(array[1]);
			}
			if (array.Length >= 3)
			{
				num3 = uint.Parse(array[2]);
			}
			if (array.Length >= 4)
			{
				num4 = uint.Parse(array[3]);
			}
			_fixedfileinfo.dwProductVersionMS = (num << 16) + num2;
			_fixedfileinfo.dwProductVersionLS = (num3 << 16) + num4;
		}
	}

	public ushort Size => (ushort)Marshal.SizeOf((object)_fixedfileinfo);

	internal void Read(IntPtr lpRes)
	{
		_fixedfileinfo = (Kernel32.VS_FIXEDFILEINFO)Marshal.PtrToStructure(lpRes, typeof(Kernel32.VS_FIXEDFILEINFO));
	}

	public void Write(BinaryWriter w)
	{
		w.Write(ResourceUtil.GetBytes(_fixedfileinfo));
		ResourceUtil.PadToDWORD(w);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"FILEVERSION {ResourceUtil.HiWord(_fixedfileinfo.dwFileVersionMS)},{ResourceUtil.LoWord(_fixedfileinfo.dwFileVersionMS)},{ResourceUtil.HiWord(_fixedfileinfo.dwFileVersionLS)},{ResourceUtil.LoWord(_fixedfileinfo.dwFileVersionLS)}");
		stringBuilder.AppendLine($"PRODUCTVERSION {ResourceUtil.HiWord(_fixedfileinfo.dwProductVersionMS)},{ResourceUtil.LoWord(_fixedfileinfo.dwProductVersionMS)},{ResourceUtil.HiWord(_fixedfileinfo.dwProductVersionLS)},{ResourceUtil.LoWord(_fixedfileinfo.dwProductVersionLS)}");
		if (_fixedfileinfo.dwFileFlagsMask == 63)
		{
			stringBuilder.AppendLine("FILEFLAGSMASK VS_FFI_FILEFLAGSMASK");
		}
		else
		{
			stringBuilder.AppendLine($"FILEFLAGSMASK 0x{_fixedfileinfo.dwFileFlagsMask.ToString():x}");
		}
		stringBuilder.AppendLine(string.Format("FILEFLAGS {0}", (_fixedfileinfo.dwFileFlags == 0) ? "0" : ResourceUtil.FlagsToString<Winver.FileFlags>(_fixedfileinfo.dwFileFlags)));
		stringBuilder.AppendLine($"FILEOS {ResourceUtil.FlagsToString<Winver.FileOs>(_fixedfileinfo.dwFileFlags)}");
		stringBuilder.AppendLine($"FILETYPE {ResourceUtil.FlagsToString<Winver.FileType>(_fixedfileinfo.dwFileType)}");
		stringBuilder.AppendLine($"FILESUBTYPE {ResourceUtil.FlagsToString<Winver.FileSubType>(_fixedfileinfo.dwFileSubtype)}");
		return stringBuilder.ToString();
	}
}
