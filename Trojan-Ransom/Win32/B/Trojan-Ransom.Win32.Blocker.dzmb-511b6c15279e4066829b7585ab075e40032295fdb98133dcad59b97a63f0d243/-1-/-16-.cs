using System;
using System.Runtime.InteropServices;
using System.Text;

namespace _003F1_003F;

internal class _003F16_003F
{
	[StructLayout(LayoutKind.Sequential)]
	internal class _003F17_003F
	{
		internal IntPtr _003F279_003F;

		internal IntPtr _003F280_003F;

		internal IntPtr _003F281_003F;

		internal IntPtr _003F282_003F;

		internal IntPtr _003F283_003F;

		internal IntPtr _003F284_003F;
	}

	internal delegate int _003F18_003F(IntPtr _003F191_003F, int _003F192_003F, _003F17_003F _003F193_003F, uint _003F194_003F, out uint _003F195_003F);

	internal delegate int _003F19_003F(IntPtr _003F191_003F, int _003F192_003F, out uint _003F198_003F, uint _003F194_003F, out uint _003F195_003F);

	internal delegate int _003F20_003F();

	internal delegate void _003F21_003F([MarshalAs(UnmanagedType.LPStr)] string _003F199_003F);

	internal delegate int _003F22_003F(IntPtr _003F200_003F, ref int _003F201_003F);

	internal delegate int _003F23_003F(IntPtr _003F202_003F, IntPtr _003F203_003F);

	internal delegate int _003F24_003F(_003F23_003F _003F204_003F, IntPtr _003F203_003F);

	internal const uint _003F275_003F = 1024u;

	internal const uint _003F276_003F = 64u;

	internal const int _003F277_003F = 0;

	private static bool _003F278_003F;

	[DllImport("kernel32.dll", EntryPoint = "SetLastError", ExactSpelling = true)]
	internal static extern void _003F129_003F(uint _003F175_003F);

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle", ExactSpelling = true)]
	internal static extern int _003F130_003F(IntPtr _003F176_003F);

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess", ExactSpelling = true)]
	internal static extern IntPtr _003F131_003F(uint _003F177_003F, int _003F178_003F, uint _003F179_003F);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessId", ExactSpelling = true)]
	internal static extern uint _003F132_003F();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "LoadLibrary", SetLastError = true)]
	internal static extern IntPtr _003F133_003F(string _003F180_003F);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern _003F18_003F _003F134_003F(IntPtr _003F181_003F, string _003F182_003F);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern _003F19_003F _003F135_003F(IntPtr _003F181_003F, string _003F182_003F);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern _003F22_003F _003F136_003F(IntPtr _003F181_003F, string _003F182_003F);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern _003F20_003F _003F137_003F(IntPtr _003F181_003F, string _003F182_003F);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern _003F21_003F _003F138_003F(IntPtr _003F181_003F, string _003F182_003F);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern _003F24_003F _003F139_003F(IntPtr _003F181_003F, string _003F182_003F);

	private static int _003F140_003F(IntPtr _003F183_003F, IntPtr _003F184_003F)
	{
		string[] array = new string[1] { _003F14_003F._003F124_003F(34449) };
		string _003F218_003F = _003F142_003F(_003F183_003F);
		string[] array2 = array;
		foreach (string _003F218_003F2 in array2)
		{
			if (_003F46_003F._003F157_003F(_003F218_003F, _003F218_003F2, _003F218_003F: true) != 0)
			{
				continue;
			}
			while (true)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				_003F278_003F = true;
				return 0;
			}
		}
		while (true)
		{
			switch (4)
			{
			case 0:
				continue;
			}
			return 1;
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetClassName")]
	internal static extern int _003F141_003F(IntPtr _003F185_003F, StringBuilder _003F186_003F, int _003F187_003F);

	internal static string _003F142_003F(IntPtr _003F188_003F)
	{
		StringBuilder stringBuilder = _003F30_003F._003F157_003F(260);
		_003F141_003F(_003F188_003F, stringBuilder, _003F64_003F._003F158_003F(stringBuilder));
		return _003F75_003F._003F158_003F(stringBuilder);
	}

	internal static void _003F143_003F()
	{
		if (!_003F144_003F())
		{
			return;
		}
		while (true)
		{
			switch (1)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			string _003F218_003F = _003F14_003F._003F124_003F(34464);
			throw _003F105_003F._003F157_003F(_003F89_003F._003F157_003F(_003F14_003F._003F124_003F(34481), _003F218_003F));
		}
	}

	internal static bool _003F144_003F()
	{
		try
		{
			if (_003F36_003F._003F157_003F())
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					return true;
				}
			}
			IntPtr _003F181_003F = _003F133_003F(_003F14_003F._003F124_003F(34590));
			_003F20_003F _003F20_003F = _003F137_003F(_003F181_003F, _003F14_003F._003F124_003F(34615));
			if (_003F20_003F != null)
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				if (_003F82_003F._003F158_003F(_003F20_003F) != 0)
				{
					while (true)
					{
						switch (7)
						{
						case 0:
							break;
						default:
							return true;
						}
					}
				}
			}
			uint _003F179_003F = _003F132_003F();
			IntPtr intPtr = _003F131_003F(1024u, 0, _003F179_003F);
			if (_003F61_003F._003F157_003F(intPtr, IntPtr.Zero))
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				try
				{
					_003F22_003F _003F22_003F = _003F136_003F(_003F181_003F, _003F14_003F._003F124_003F(34650));
					if (_003F22_003F != null)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							int _003F223_003F = 0;
							if (_003F101_003F._003F158_003F(_003F22_003F, intPtr, ref _003F223_003F) == 0)
							{
								break;
							}
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								if (_003F223_003F == 0)
								{
									break;
								}
								while (true)
								{
									switch (5)
									{
									case 0:
										continue;
									}
									return true;
								}
							}
							break;
						}
					}
				}
				finally
				{
					_003F130_003F(intPtr);
				}
			}
			bool flag = false;
			try
			{
				_003F130_003F(new IntPtr(305419896));
			}
			catch
			{
				flag = true;
			}
			if (flag)
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					return true;
				}
			}
			try
			{
				IntPtr _003F181_003F2 = _003F133_003F(_003F14_003F._003F124_003F(34703));
				_003F24_003F _003F24_003F = _003F139_003F(_003F181_003F2, _003F14_003F._003F124_003F(34724));
				if (_003F24_003F != null)
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						_003F278_003F = false;
						_003F78_003F._003F158_003F(_003F24_003F, _003F140_003F, IntPtr.Zero);
						if (!_003F278_003F)
						{
							break;
						}
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							return true;
						}
					}
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
		return false;
	}
}
