using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Qsrjkm.Properties;

internal class Class1
{
	internal readonly TaskCompletionSource<object> taskCompletionSource_0;

	internal readonly CancellationToken? nullable_0;

	internal readonly object object_0;

	internal Class1(TaskCompletionSource<object> taskCompletionSource_1, CancellationToken? nullable_1, object object_1)
	{
		while (true)
		{
			int num = Class5.smethod_0(24);
			int num2 = 26;
			while (true)
			{
				IL_00bb:
				num2 ^= 0x15;
				int num3;
				while (true)
				{
					num3 = Class12.smethod_2(22);
					switch (num3 ^ 0x13)
					{
					case -17:
						goto end_IL_000c;
					case -18:
						goto IL_004b;
					case -16:
						goto IL_00bb;
					}
					continue;
					end_IL_000c:
					break;
				}
				switch (num2)
				{
				case 14:
					goto IL_005b;
				case 15:
					goto IL_00a8;
				case 13:
					goto end_IL_00bb;
				}
				num3 = -3;
				num3 = -18;
				goto IL_004b;
				IL_00a8:
				num ^= 0x16;
				num2 = Class12.smethod_2(25);
				num3 = -29;
				num3 = -16;
				continue;
				IL_004b:
				num2 = Class12.smethod_2(25);
				num3 = -29;
				num3 = -16;
				continue;
				IL_005b:
				switch (num)
				{
				default:
					num2 = 24;
					continue;
				case 26:
					num = 11;
					break;
				case 27:
					object_0 = object_1;
					num = 8;
					break;
				case 28:
					nullable_0 = nullable_1;
					num = 13;
					break;
				case 29:
					taskCompletionSource_0 = taskCompletionSource_1;
					num = Class5.smethod_0(20);
					break;
				case 30:
					return;
				}
				goto IL_00a8;
				continue;
				end_IL_00bb:
				break;
			}
		}
	}

	internal byte[] method_0()
	{
		byte[] byte_ = default(byte[]);
		byte[] result = default(byte[]);
		while (true)
		{
			int num = Class9.smethod_0(38);
			int num2 = -18;
			while (true)
			{
				IL_00b7:
				num2 ^= 0x38;
				int num3;
				while (true)
				{
					num3 = Class2.smethod_0(64);
					switch (num3 ^ 0x35)
					{
					case 53:
						goto end_IL_0007;
					case 52:
						goto IL_004b;
					case 54:
						goto IL_00b7;
					}
					continue;
					end_IL_0007:
					break;
				}
				switch (num2)
				{
				case -44:
					goto IL_005c;
				case -42:
					goto IL_00a3;
				case -43:
					goto end_IL_00b7;
				}
				num3 = 1;
				num3 = 52;
				goto IL_004b;
				IL_00a3:
				num ^= 0x38;
				num2 = Class9.smethod_0(56);
				num3 = 3;
				num3 = 54;
				continue;
				IL_004b:
				num2 = Class9.smethod_0(56);
				num3 = 3;
				num3 = 54;
				continue;
				IL_005c:
				switch (num)
				{
				default:
					num2 = -19;
					continue;
				case -50:
					byte_ = Resources.Byte_0;
					num = -24;
					break;
				case -49:
					result = byte_;
					num = -11;
					break;
				case -48:
					Class0.smethod_0(ref byte_);
					num = -23;
					break;
				case -47:
					num = -9;
					break;
				case -51:
				case -46:
					return result;
				}
				goto IL_00a3;
				continue;
				end_IL_00b7:
				break;
			}
		}
	}

	internal byte[] method_1(string string_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(string_0));
			byte[] array = default(byte[]);
			Stream responseStream = default(Stream);
			byte[] result = default(byte[]);
			while (true)
			{
				int num = Class2.smethod_0(60);
				int num2 = 0;
				while (true)
				{
					IL_011c:
					num2 ^= 0x3A;
					int num3;
					while (true)
					{
						num3 = Class9.smethod_0(51);
						switch (num3 ^ 0x3A)
						{
						case 57:
							goto end_IL_001d;
						case 58:
							goto IL_010c;
						case 59:
							goto IL_011c;
						}
						continue;
						end_IL_001d:
						break;
					}
					switch (num2)
					{
					case 57:
						goto IL_0067;
					case 58:
						goto IL_00f3;
					case 56:
						goto end_IL_011c;
					}
					num3 = 0;
					num3 = 58;
					goto IL_010c;
					IL_00f3:
					num ^= 0x36;
					num2 = Class9.smethod_0(51);
					num3 = 1;
					num3 = 59;
					continue;
					IL_010c:
					num2 = Class9.smethod_0(51);
					num3 = 1;
					num3 = 59;
					continue;
					IL_0067:
					switch (num)
					{
					default:
						num2 = 2;
						continue;
					case -66:
						array = memoryStream.ToArray();
						num = Class12.smethod_2(19);
						break;
					case -65:
						num = -120;
						break;
					case -64:
						responseStream = httpWebRequest.GetResponse().GetResponseStream();
						num = -9;
						break;
					case -63:
						responseStream.CopyTo(memoryStream);
						num = -119;
						break;
					case -62:
						num = -10;
						break;
					case -61:
						httpWebRequest.UserAgent = Class3.smethod_0(32441);
						num = -12;
						break;
					case -60:
						result = array;
						num = -13;
						break;
					case -59:
						return result;
					}
					goto IL_00f3;
					continue;
					end_IL_011c:
					break;
				}
			}
		}
		finally
		{
			if (memoryStream != null || 1 == 0)
			{
				((IDisposable)memoryStream).Dispose();
			}
		}
	}
}
