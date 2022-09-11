using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Wheels;

public class GClass2
{
	private string string_0;

	private JSHandler jshandler_0;

	private AudioHandler audioHandler_0;

	private AppSettings appSettings_0;

	private AppSettings appSettings_1;

	[CompilerGenerated]
	private static TransferString transferString_0;

	private UdpClient udpClient_0;

	public JSdeviceState JSdeviceState_0
	{
		get
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			if (jshandler_0 != null)
			{
				return GClass2.smethod_18(jshandler_0);
			}
			return (JSdeviceState)10;
		}
	}

	public static event TransferString Event_0
	{
		[CompilerGenerated]
		add
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			TransferString val = transferString_0;
			TransferString val2;
			do
			{
				val2 = val;
				TransferString value2 = (TransferString)GClass2.smethod_19((Delegate)(object)val2, (Delegate)(object)value);
				val = Interlocked.CompareExchange(ref transferString_0, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			TransferString val = transferString_0;
			TransferString val2;
			do
			{
				val2 = val;
				TransferString value2 = (TransferString)GClass2.smethod_20((Delegate)(object)val2, (Delegate)(object)value);
				val = Interlocked.CompareExchange(ref transferString_0, value2, val2);
			}
			while (val != val2);
		}
	}

	public GClass2(AppSettings appSettings_2, AppSettings appSettings_3)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		appSettings_0 = appSettings_2;
		appSettings_1 = appSettings_3;
		string_0 = ((GClass2.smethod_0(appSettings_1) == 0) ? "" : GClass2.smethod_1((object)"Car", (object)GClass2.smethod_0(appSettings_1), (object)"\\"));
		if (!GClass2.smethod_2(appSettings_0) && !GClass2.smethod_3(appSettings_0))
		{
			if (GClass2.smethod_8(appSettings_0))
			{
				jshandler_0 = GClass2.smethod_6(method_1(), appSettings_0);
				GClass2.smethod_7(new TransferString(method_0));
			}
		}
		else
		{
			if (appSettings_0.DebugMode)
			{
				try
				{
					udpClient_0 = GClass2.smethod_4("127.0.0.1", 29376);
				}
				catch (Exception exception_)
				{
					transferString_0.Invoke(GClass2.smethod_5(exception_), false, 0);
				}
			}
			else
			{
				jshandler_0 = GClass2.smethod_6(method_1(), appSettings_0);
			}
			GClass2.smethod_7(new TransferString(method_0));
		}
		if (GClass2.smethod_9(appSettings_0))
		{
			GClass2.smethod_10(new TransferString(method_0));
			audioHandler_0 = GClass2.smethod_11(appSettings_0, method_2());
		}
	}

	private void method_0(string string_1, bool bool_0 = false, int int_0 = 0)
	{
		transferString_0.Invoke(string_1, bool_0, int_0);
	}

	private List<string> method_1()
	{
		List<string> list = new List<string>();
		foreach (string uwvFiles in Utils.UwvFilesList)
		{
			string text = GClass2.smethod_12(new string[5]
			{
				Utils.SamplesFolder,
				Utils.SamplesSubfolders_JS[3],
				string_0,
				uwvFiles,
				".uwv"
			});
			string text2 = GClass2.smethod_13(Utils.SamplesFolder, Utils.SamplesSubfolders_JS[2], uwvFiles, ".uwv");
			if (GClass2.smethod_3(appSettings_0))
			{
				text2 = GClass2.smethod_13(Utils.SamplesFolder, Utils.SamplesSubfolders_JS[4], uwvFiles, ".uwv");
			}
			string text3 = GClass2.smethod_14("uwv_files\\", uwvFiles, ".uwv");
			if (GClass2.smethod_15(text))
			{
				list.Add(text);
				transferString_0.Invoke(GClass2.smethod_12(new string[5]
				{
					"Customized FX file found: ",
					Utils.SamplesSubfolders_JS[3],
					string_0,
					uwvFiles,
					".uwv"
				}), true, 0);
			}
			else if (!GClass2.smethod_15(text2))
			{
				if (!GClass2.smethod_15(text3))
				{
					transferString_0.Invoke(GClass2.smethod_14("Could not find a file: ", uwvFiles, ".uwv"), true, 1);
				}
				else
				{
					list.Add(text3);
				}
			}
			else
			{
				list.Add(text2);
			}
		}
		return list;
	}

	private List<string> method_2()
	{
		List<string> list = new List<string>();
		foreach (string wavFiles in Utils.WavFilesList)
		{
			string text = GClass2.smethod_17(new object[7]
			{
				Utils.SamplesFolder,
				Utils.SamplesSubfolders_AD[6],
				GClass2.smethod_16(appSettings_0),
				"\\",
				string_0,
				wavFiles,
				".wav"
			});
			string text2 = GClass2.smethod_17(new object[6]
			{
				Utils.SamplesFolder,
				Utils.SamplesSubfolders_AD[2],
				GClass2.smethod_16(appSettings_0),
				"\\",
				wavFiles,
				".wav"
			});
			string text3 = GClass2.smethod_14("wav_files\\", wavFiles, ".wav");
			if (!GClass2.smethod_15(text))
			{
				if (GClass2.smethod_15(text2))
				{
					list.Add(text2);
				}
				else if (!GClass2.smethod_15(text3))
				{
					transferString_0.Invoke(GClass2.smethod_14("Could not find a file: ", wavFiles, ".wav"), true, 1);
				}
				else
				{
					list.Add(text3);
				}
			}
			else
			{
				list.Add(text);
				transferString_0.Invoke(GClass2.smethod_17(new object[7]
				{
					"Customized FX file found: ",
					Utils.SamplesSubfolders_AD[6],
					GClass2.smethod_16(appSettings_0),
					"\\",
					string_0,
					wavFiles,
					".wav"
				}), true, 0);
			}
		}
		return list;
	}

	private void method_3(string string_1)
	{
		byte[] array = GClass2.smethod_22(GClass2.smethod_21(), string_1);
		try
		{
			GClass2.smethod_23(udpClient_0, array, array.Length);
		}
		catch (Exception exception_)
		{
			transferString_0.Invoke(GClass2.smethod_24("Oops! Something's got wrong at UDP send: ", GClass2.smethod_5(exception_)), false, 0);
		}
	}

	public void method_4(EffectActions effectActions_0, string string_1, Tuple<int, int> tuple_0, int int_0 = 1)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I4, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		string string_2 = GClass2.smethod_25("{0}~{1}~{2}~{3}", new object[4]
		{
			string_1,
			(int)effectActions_0,
			tuple_0.Item1,
			int_0
		});
		if (GClass2.smethod_2(appSettings_0) || GClass2.smethod_3(appSettings_0) || GClass2.smethod_8(appSettings_0))
		{
			if (!appSettings_0.DebugMode)
			{
				if (jshandler_0 != null)
				{
					GClass2.smethod_26(jshandler_0, string_2);
				}
			}
			else
			{
				method_3(string_2);
			}
		}
		if (GClass2.smethod_9(appSettings_0) && audioHandler_0 != null)
		{
			GClass2.smethod_27(audioHandler_0, string_1, effectActions_0, tuple_0.Item2, int_0);
		}
	}

	public void method_5()
	{
		if (audioHandler_0 != null)
		{
			GClass2.smethod_28(audioHandler_0);
			audioHandler_0 = null;
		}
		if (jshandler_0 != null)
		{
			jshandler_0 = null;
		}
	}

	static int smethod_0(AppSettings appSettings_2)
	{
		return appSettings_2.get_SubfolderSelectorIndex();
	}

	static string smethod_1(object object_0, object object_1, object object_2)
	{
		return string.Concat(object_0, object_1, object_2);
	}

	static bool smethod_2(AppSettings appSettings_2)
	{
		return appSettings_2.get_EnableJetSeat();
	}

	static bool smethod_3(AppSettings appSettings_2)
	{
		return appSettings_2.get_EnableJetSeatRace();
	}

	static UdpClient smethod_4(string string_1, int int_0)
	{
		return new UdpClient(string_1, int_0);
	}

	static string smethod_5(Exception exception_0)
	{
		return exception_0.Message;
	}

	static JSHandler smethod_6(List<string> list_0, AppSettings appSettings_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new JSHandler(list_0, appSettings_2);
	}

	static void smethod_7(TransferString transferString_1)
	{
		JSHandler.add_AddToLog_JSH(transferString_1);
	}

	static bool smethod_8(AppSettings appSettings_2)
	{
		return appSettings_2.get_EnableForcefeel();
	}

	static bool smethod_9(AppSettings appSettings_2)
	{
		return appSettings_2.get_EnableAudio();
	}

	static void smethod_10(TransferString transferString_1)
	{
		AudioHandler.add_AddToLog_ADH(transferString_1);
	}

	static AudioHandler smethod_11(AppSettings appSettings_2, List<string> list_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new AudioHandler(appSettings_2, list_0);
	}

	static string smethod_12(string[] string_1)
	{
		return string.Concat(string_1);
	}

	static string smethod_13(string string_1, string string_2, string string_3, string string_4)
	{
		return string_1 + string_2 + string_3 + string_4;
	}

	static string smethod_14(string string_1, string string_2, string string_3)
	{
		return string_1 + string_2 + string_3;
	}

	static bool smethod_15(string string_1)
	{
		return File.Exists(string_1);
	}

	static int smethod_16(AppSettings appSettings_2)
	{
		return appSettings_2.get_SelectedMaxAudioChannels();
	}

	static string smethod_17(object[] object_0)
	{
		return string.Concat(object_0);
	}

	static JSdeviceState smethod_18(JSHandler jshandler_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return jshandler_1.get_JetseatState();
	}

	static Delegate smethod_19(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Combine(delegate_0, delegate_1);
	}

	static Delegate smethod_20(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Remove(delegate_0, delegate_1);
	}

	static Encoding smethod_21()
	{
		return Encoding.ASCII;
	}

	static byte[] smethod_22(Encoding encoding_0, string string_1)
	{
		return encoding_0.GetBytes(string_1);
	}

	static int smethod_23(UdpClient udpClient_1, byte[] byte_0, int int_0)
	{
		return udpClient_1.Send(byte_0, int_0);
	}

	static string smethod_24(string string_1, string string_2)
	{
		return string_1 + string_2;
	}

	static string smethod_25(string string_1, object[] object_0)
	{
		return string.Format(string_1, object_0);
	}

	static void smethod_26(JSHandler jshandler_1, string string_1)
	{
		jshandler_1.PlayEffectOnJS(string_1);
	}

	static void smethod_27(AudioHandler audioHandler_1, string string_1, EffectActions effectActions_0, int int_0, int int_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		audioHandler_1.PlayEffectOnBS(string_1, effectActions_0, int_0, int_1);
	}

	static void smethod_28(AudioHandler audioHandler_1)
	{
		audioHandler_1.Stop();
	}
}
