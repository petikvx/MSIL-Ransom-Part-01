using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace _003F1_003F;

internal class _003F15_003F
{
	private static readonly object _003F270_003F;

	private static readonly int _003F271_003F;

	private static readonly int _003F272_003F;

	private static readonly MemoryStream _003F273_003F;

	private static readonly MemoryStream _003F274_003F;

	static _003F15_003F()
	{
		_003F273_003F = null;
		_003F274_003F = null;
		_003F271_003F = int.MaxValue;
		_003F272_003F = int.MinValue;
		_003F273_003F = _003F35_003F._003F157_003F(0);
		_003F274_003F = _003F35_003F._003F157_003F(0);
		_003F270_003F = _003F76_003F._003F157_003F();
	}

	private static string _003F115_003F(Assembly _003F162_003F)
	{
		string text = _003F40_003F._003F158_003F(_003F162_003F);
		int num = _003F41_003F._003F158_003F(text, ',');
		if (num >= 0)
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
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			text = _003F81_003F._003F158_003F(text, 0, num);
		}
		return text;
	}

	private static byte[] _003F125_003F(Assembly _003F162_003F)
	{
		try
		{
			string _003F218_003F = _003F40_003F._003F158_003F(_003F162_003F);
			int num = _003F79_003F._003F158_003F(_003F218_003F, _003F305_003F._003F306_003F("_Żɯ\u0360Ѣթقݭ\u087e\u0952੪୯౦൬\u0e3c"));
			if (num < 0)
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
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				num = _003F79_003F._003F158_003F(_003F218_003F, _003F305_003F._003F306_003F("\u007fŻɯ\u0360Ѣթ٢ݭ\u087eॲ੪୯౦൬\u0e3c"));
			}
			if (num < 0)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						break;
					default:
						return null;
					}
				}
			}
			num += 15;
			if (_003F104_003F._003F158_003F(_003F218_003F, num) != 'n')
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
				if (_003F104_003F._003F158_003F(_003F218_003F, num) != 'N')
				{
					string _003F218_003F2 = _003F81_003F._003F158_003F(_003F218_003F, num, 16);
					long _003F218_003F3 = _003F67_003F._003F157_003F(_003F218_003F2, NumberStyles.HexNumber);
					byte[] array = _003F103_003F._003F157_003F(_003F218_003F3);
					_003F87_003F._003F157_003F(array);
					return array;
				}
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			return null;
		}
		catch
		{
		}
		return null;
	}

	internal static byte[] _003F126_003F(Stream _003F173_003F)
	{
		object _003F218_003F;
		_003F94_003F._003F157_003F(_003F218_003F = _003F270_003F);
		try
		{
			return _003F128_003F(0, _003F173_003F);
		}
		finally
		{
			_003F57_003F._003F157_003F(_003F218_003F);
		}
	}

	internal static byte[] _003F127_003F(sbyte _003F174_003F, Stream _003F173_003F)
	{
		try
		{
			return _003F126_003F(_003F173_003F);
		}
		catch (HostProtectionException)
		{
			return _003F128_003F(0, _003F173_003F);
		}
	}

	internal static byte[] _003F128_003F(sbyte _003F174_003F, Stream _003F173_003F)
	{
		Stream _003F218_003F = _003F173_003F;
		MemoryStream memoryStream = null;
		ushort num = (ushort)_003F31_003F._003F158_003F(_003F173_003F);
		num = (ushort)(~num);
		for (int i = 1; i < 3; i++)
		{
			_003F31_003F._003F158_003F(_003F173_003F);
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
			if ((num & 2u) != 0)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				DESCryptoServiceProvider _003F218_003F2 = _003F62_003F._003F157_003F();
				byte[] _003F218_003F3 = new byte[8];
				_003F39_003F._003F158_003F(_003F173_003F, _003F218_003F3, 0, 8);
				_003F80_003F._003F158_003F(_003F218_003F2, _003F218_003F3);
				byte[] array = new byte[8];
				_003F39_003F._003F158_003F(_003F173_003F, array, 0, 8);
				bool flag = true;
				byte[] array2 = array;
				int num2 = 0;
				while (true)
				{
					if (num2 < array2.Length)
					{
						if (array2[num2] != 0)
						{
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								break;
							}
							flag = false;
							break;
						}
						num2++;
						continue;
					}
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					break;
				}
				if (flag)
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					array = _003F125_003F(_003F59_003F._003F157_003F());
				}
				_003F73_003F._003F158_003F(_003F218_003F2, array);
				if (_003F273_003F == null)
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					if (_003F271_003F == int.MaxValue)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						_003F96_003F._003F158_003F(_003F273_003F, (int)_003F74_003F._003F158_003F(_003F173_003F));
					}
					else
					{
						_003F96_003F._003F158_003F(_003F273_003F, _003F271_003F);
					}
				}
				_003F95_003F._003F158_003F(_003F273_003F, 0L);
				ICryptoTransform _003F218_003F4 = _003F68_003F._003F158_003F(_003F218_003F2);
				int num3 = _003F70_003F._003F158_003F(_003F218_003F4);
				_003F66_003F._003F158_003F(_003F218_003F4);
				byte[] _003F218_003F5 = new byte[_003F66_003F._003F158_003F(_003F218_003F4)];
				byte[] _003F218_003F6 = new byte[_003F70_003F._003F158_003F(_003F218_003F4)];
				int j;
				for (j = (int)_003F42_003F._003F158_003F(_003F173_003F); j + num3 < _003F74_003F._003F158_003F(_003F173_003F); j += num3)
				{
					_003F39_003F._003F158_003F(_003F173_003F, _003F218_003F6, 0, num3);
					int _003F218_003F7 = _003F84_003F._003F158_003F(_003F218_003F4, _003F218_003F6, 0, num3, _003F218_003F5, 0);
					_003F43_003F._003F158_003F(_003F273_003F, _003F218_003F5, 0, _003F218_003F7);
				}
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				_003F39_003F._003F158_003F(_003F173_003F, _003F218_003F6, 0, (int)(_003F74_003F._003F158_003F(_003F173_003F) - j));
				byte[] array3 = _003F72_003F._003F158_003F(_003F218_003F4, _003F218_003F6, 0, (int)(_003F74_003F._003F158_003F(_003F173_003F) - j));
				_003F43_003F._003F158_003F(_003F273_003F, array3, 0, array3.Length);
				_003F218_003F = _003F273_003F;
				_003F95_003F._003F158_003F(_003F218_003F, 0L);
				memoryStream = _003F273_003F;
			}
			if ((num & 8u) != 0)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				try
				{
					if (_003F274_003F == null)
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						if (_003F272_003F == int.MinValue)
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
							_003F96_003F._003F158_003F(_003F274_003F, (int)_003F74_003F._003F158_003F(_003F218_003F) * 2);
						}
						else
						{
							_003F96_003F._003F158_003F(_003F274_003F, _003F272_003F);
						}
					}
					_003F95_003F._003F158_003F(_003F274_003F, 0L);
					DeflateStream _003F218_003F8 = _003F100_003F._003F157_003F(_003F218_003F, CompressionMode.Decompress);
					int num4 = 1000;
					byte[] _003F218_003F9 = new byte[num4];
					int num5;
					do
					{
						num5 = _003F39_003F._003F158_003F(_003F218_003F8, _003F218_003F9, 0, num4);
						if (num5 <= 0)
						{
							continue;
						}
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						_003F43_003F._003F158_003F(_003F274_003F, _003F218_003F9, 0, num5);
					}
					while (num5 >= num4);
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						memoryStream = _003F274_003F;
						break;
					}
				}
				catch (Exception)
				{
				}
			}
			if (memoryStream != null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						break;
					default:
						return _003F51_003F._003F158_003F(memoryStream);
					}
				}
			}
			byte[] array4 = new byte[_003F74_003F._003F158_003F(_003F173_003F) - _003F42_003F._003F158_003F(_003F173_003F)];
			_003F39_003F._003F158_003F(_003F173_003F, array4, 0, array4.Length);
			return array4;
		}
	}
}
