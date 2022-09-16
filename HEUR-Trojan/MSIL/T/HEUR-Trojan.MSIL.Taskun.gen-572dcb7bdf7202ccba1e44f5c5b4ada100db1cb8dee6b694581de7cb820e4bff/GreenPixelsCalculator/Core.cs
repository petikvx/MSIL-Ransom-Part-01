using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using GreenPixelsCalculator.IO;

namespace GreenPixelsCalculator;

public static class Core
{
	private static FileStream debugFile;

	private static StreamWriter debugWriter;

	public static void DebugStart(string folder)
	{
		if (debugFile != null)
		{
			throw new Exception();
		}
		string path = Path.Combine(folder, $"debug {DateTime.Now:u}.txt".Replace(':', '-'));
		debugFile = new FileStream(path, FileMode.Create);
		debugWriter = new StreamWriter(debugFile);
	}

	public static void DebugWriteLine(string text)
	{
		if (debugWriter != null)
		{
			debugWriter.WriteLine(text);
		}
	}

	public static void DebugStop()
	{
		if (debugFile != null)
		{
			debugWriter.Close();
			debugWriter.Dispose();
			debugWriter = null;
			debugFile.Dispose();
			debugFile = null;
		}
	}

	public static ParamType FindType(object obj, bool fixedWhenPowerTwoArray = false)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (!(obj is bool))
		{
			if (!(obj is char))
			{
				if (!(obj is sbyte))
				{
					if (!(obj is byte))
					{
						if (!(obj is short))
						{
							if (!(obj is ushort))
							{
								if (!(obj is int))
								{
									if (!(obj is uint))
									{
										if (!(obj is long))
										{
											if (!(obj is ulong))
											{
												if (!(obj is float))
												{
													if (!(obj is double))
													{
														if (!(obj is decimal))
														{
															if (!(obj is DateTime))
															{
																if (!(obj is Guid))
																{
																	if (!(obj is string))
																	{
																		if (!(obj is byte[] array))
																		{
																			throw new ArgumentException("The type of this object (" + obj.GetType().Name + ") is not supported", "obj");
																		}
																		if (fixedWhenPowerTwoArray)
																		{
																			if (array.Length == 1)
																			{
																				return ParamType.BYTES_1;
																			}
																			if (array.Length == 2)
																			{
																				return ParamType.BYTES_2;
																			}
																			if (array.Length == 4)
																			{
																				return ParamType.BYTES_4;
																			}
																			if (array.Length == 8)
																			{
																				return ParamType.BYTES_8;
																			}
																			if (array.Length == 16)
																			{
																				return ParamType.BYTES_16;
																			}
																		}
																		return ParamType.RAW;
																	}
																	return ParamType.STRING;
																}
																return ParamType.GUID;
															}
															return ParamType.DATETIME;
														}
														return ParamType.DECIMAL;
													}
													return ParamType.DOUBLE;
												}
												return ParamType.FLOAT;
											}
											return ParamType.ULONG;
										}
										return ParamType.LONG;
									}
									return ParamType.UINT;
								}
								return ParamType.INT;
							}
							return ParamType.USHORT;
						}
						return ParamType.SHORT;
					}
					return ParamType.BYTE;
				}
				return ParamType.SBYTE;
			}
			return ParamType.CHAR;
		}
		return ParamType.BOOLEAN;
	}

	public static T[] Repeat<T>(this T value, int times)
	{
		T[] array = new T[times];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = value;
		}
		return array;
	}

	public static string ToExpandedString<T>(this T obj)
	{
		if (obj == null)
		{
			return "<null>";
		}
		if ((object)obj is string text)
		{
			return "\"" + text + "\"";
		}
		if ((object)obj is IEnumerable source)
		{
			return "[" + string.Join(", ", from object o in source
				select o.ToExpandedString()) + "]";
		}
		return obj.ToString();
	}

	public static bool EqualsZero(this object a)
	{
		return a.GetHashCode() == 0;
	}

	public static void Write(this Stream stream, byte[] buffer)
	{
		stream.Write(buffer, 0, buffer.Length);
	}

	public static IntPtr AddressOf<T>(T t)
	{
		return (IntPtr)0;
	}

	public static IntPtr AddressOfRef<T>(ref T t)
	{
		return (IntPtr)0;
	}

	public static T[] ReadBytesAsArrayOf<T>(this byte[] raw, int startIndex = 0, int maxOutputElements = -1)
	{
		int num = Marshal.SizeOf(typeof(T));
		int val = (raw.Length - startIndex) / num;
		val = Math.Max(val, 0);
		if (maxOutputElements > -1)
		{
			val = Math.Min(val, maxOutputElements);
		}
		T[] result = new T[val];
		if (val < 1)
		{
			return result;
		}
		return result;
	}

	public static T ReadBytesAs<T>(this byte[] raw, int startIndex = 0)
	{
		return raw.ReadBytesAsArrayOf<T>(startIndex, 1)[0];
	}

	public static byte[] ReadObjectsAsByteArray(this object[] values, int fromIndex = 0, int maxInputElements = -1)
	{
		if (values.Length < 1)
		{
			throw new ArgumentException("At least one value is required.", "values");
		}
		Type[] array = values.Select((object v) => v.GetType()).Distinct().ToArray();
		if (array.Length != 1)
		{
			throw new ArgumentException("The values must be of the same type.", "values");
		}
		int num = Marshal.SizeOf(array[0]);
		int val = values.Length - fromIndex;
		val = Math.Max(val, 0);
		if (maxInputElements > -1)
		{
			val = Math.Min(val, maxInputElements);
		}
		byte[] result = new byte[val * num];
		if (val < 1)
		{
			return result;
		}
		return result;
	}

	public static byte[] ReadObjectAsByteArray(this object value, int startIndex = 0)
	{
		return new object[1] { value }.ReadObjectsAsByteArray(startIndex, 1);
	}

	public static void WriteObjectsInByteArray(this object[] values, byte[] raw, int fromIndexOut = 0, int fromIndexIn = 0, int maxInputElements = -1)
	{
		if (values.Length < 1)
		{
			throw new ArgumentException("At least one value is required.", "values");
		}
		Type[] array = values.Select((object v) => v.GetType()).Distinct().ToArray();
		if (array.Length != 1)
		{
			throw new ArgumentException("The values must be of the same type.", "values");
		}
		Marshal.SizeOf(array[0]);
		int val = values.Length - fromIndexIn;
		val = Math.Max(val, 0);
		if (maxInputElements > -1)
		{
			val = Math.Min(val, maxInputElements);
		}
		if (val < 1)
		{
		}
	}

	public static void WriteObjectInByteArray(this object value, byte[] raw, int fromIndexOut = 0, int fromIndexIn = 0)
	{
		new object[1] { value }.WriteObjectsInByteArray(raw, fromIndexOut, fromIndexIn, 1);
	}

	public static void BreakDebugger(string message)
	{
		DebugWriteLine(message);
	}
}
