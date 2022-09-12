using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;

namespace PointBlank.Launcher;

public class Connection : Form
{
	public Computer MyComputer = Connection.smethod_0();

	private bool _TF7BqpfVni7n4Zlgo0S9seWf1nE = true;

	public WebClient Web = Connection.smethod_1();

	public Process[] Processos;

	private IContainer _ZxAbWPOeuBqLkbv0v0TsfEpIn4bA;

	private Label _QbRDXY9MdrbjPbIoQbBO3Qyj9Vc;

	public BackgroundWorker Start;

	public Connection()
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		_QeLc76eWmkdedtAuJ38IUOaf8ZrA();
		try
		{
			Connection.smethod_2(Web, (AsyncCompletedEventHandler)_wm4tQRq7bRgnnjclAtUguICBQnU);
			Connection.smethod_3((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, _003CModule_003E.smethod_4<string>(1425143252u));
		}
		catch
		{
			Connection.smethod_3((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, _003CModule_003E.smethod_1<string>(339812851u));
			if ((int)Connection.smethod_4(_003CModule_003E.smethod_2<string>(740001518u), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)16, (MessageBoxDefaultButton)0) == 1)
			{
				Connection.smethod_5((Form)(object)this);
				this.method_0();
			}
			_ZlJqgMWldqDdSHbEbwCi3REUR2v(Connection.smethod_6(_003CModule_003E.smethod_4<string>(2416654309u), Modul.Name, _003CModule_003E.smethod_2<string>(2635049751u)));
			_ZlJqgMWldqDdSHbEbwCi3REUR2v(Connection.smethod_6(Modul.Name, _003CModule_003E.smethod_4<string>(1805254402u), DateTime.Now.ToString(_003CModule_003E.smethod_2<string>(2094626039u))));
		}
	}

	private void _5KVDKXtf7oZdNo6RpERr5YcZZjx(object sender, EventArgs e)
	{
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Invalid comparison between Unknown and I4
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		Process[] array = Connection.smethod_7();
		Processos = Connection.smethod_10(Connection.smethod_9(Connection.smethod_8()));
		if (!Connection.smethod_14(Connection.smethod_11((ServerComputer)(object)Connection.smethod_0()), Connection.smethod_13(Connection.smethod_12(), _003CModule_003E.smethod_4<string>(1450737293u), Modul.Name, _003CModule_003E.smethod_1<string>(3262140938u))))
		{
			Connection.smethod_16((TextWriter)Connection.smethod_15(Connection.smethod_13(Connection.smethod_12(), _003CModule_003E.smethod_1<string>(968820316u), Modul.Name, _003CModule_003E.smethod_1<string>(3262140938u))));
		}
		_ZlJqgMWldqDdSHbEbwCi3REUR2v("");
		_ZlJqgMWldqDdSHbEbwCi3REUR2v("");
		_ZlJqgMWldqDdSHbEbwCi3REUR2v("");
		_ZlJqgMWldqDdSHbEbwCi3REUR2v(Connection.smethod_6(Modul.Name, _003CModule_003E.smethod_5<string>(1669779448u), DateTime.Now.ToString(_003CModule_003E.smethod_4<string>(1132240319u))));
		_ZlJqgMWldqDdSHbEbwCi3REUR2v(Connection.smethod_13(_003CModule_003E.smethod_4<string>(361591925u), Modul.Name, _003CModule_003E.smethod_3<string>(2112642657u), Connection.smethod_17((object)Version.getVersion())));
		if (Processos.Length > 1)
		{
			if ((int)Connection.smethod_4(Connection.smethod_18(Modul.Name, _003CModule_003E.smethod_5<string>(659539617u)), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0) == 1)
			{
				Connection.smethod_5((Form)(object)this);
				this.method_0();
			}
			_TF7BqpfVni7n4Zlgo0S9seWf1nE = false;
		}
		else
		{
			Process[] array2 = array;
			foreach (Process process_ in array2)
			{
				if (Connection.smethod_19(Connection.smethod_9(process_), _003CModule_003E.smethod_3<string>(1787761257u), bool_0: false) == 0)
				{
					Connection.smethod_20(process_);
					Connection.smethod_4(_003CModule_003E.smethod_2<string>(2041296716u), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)16, (MessageBoxDefaultButton)0);
				}
			}
		}
		_TyWO5eTCF1eZMlSwxH7SjTPAFNF();
	}

	private void _wm4tQRq7bRgnnjclAtUguICBQnU(object sender, AsyncCompletedEventArgs e)
	{
		if (Connection.smethod_21(e) == null)
		{
			Connection.smethod_22((Form)(object)this, bool_0: false);
			Connection.smethod_23((Control)(object)this, bool_0: false);
		}
	}

	private void _ZlJqgMWldqDdSHbEbwCi3REUR2v(string texto)
	{
		string string_ = Connection.smethod_13(Connection.smethod_12(), _003CModule_003E.smethod_2<string>(1120437261u), Modul.Name, _003CModule_003E.smethod_1<string>(3262140938u));
		_ = DateTime.Now;
		StreamWriter textWriter_ = Connection.smethod_24(string_, bool_0: true);
		Connection.smethod_25((TextWriter)textWriter_, texto);
		Connection.smethod_26((TextWriter)textWriter_);
		Connection.smethod_16((TextWriter)textWriter_);
	}

	private void _TyWO5eTCF1eZMlSwxH7SjTPAFNF()
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Invalid comparison between Unknown and I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Invalid comparison between Unknown and I4
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Invalid comparison between Unknown and I4
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Invalid comparison between Unknown and I4
		if (!_TF7BqpfVni7n4Zlgo0S9seWf1nE)
		{
			return;
		}
		try
		{
			int num = int.Parse(Connection.smethod_27(Web, Connection.smethod_18(Modul.WEB, _003CModule_003E.smethod_4<string>(526524653u))));
			int num2 = int.Parse(Connection.smethod_27(Web, Connection.smethod_18(Modul.WEB, _003CModule_003E.smethod_1<string>(511273913u))));
			string object_ = Connection.smethod_27(Web, Connection.smethod_18(Modul.WEB, _003CModule_003E.smethod_2<string>(75142719u)));
			if (num2 != Modul.Version)
			{
				Connection.smethod_3((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, _003CModule_003E.smethod_4<string>(269641855u));
				if ((int)Connection.smethod_4(_003CModule_003E.smethod_4<string>(269641855u), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0) == 1)
				{
					Connection.smethod_5((Form)(object)this);
					this.method_0();
				}
			}
			switch (num)
			{
			case 0:
				Connection.smethod_3((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, _003CModule_003E.smethod_3<string>(1274395863u));
				if ((int)Connection.smethod_4(_003CModule_003E.smethod_3<string>(2907483961u), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0) == 1)
				{
					Connection.smethod_5((Form)(object)this);
					this.method_0();
				}
				_ZlJqgMWldqDdSHbEbwCi3REUR2v(Connection.smethod_6(_003CModule_003E.smethod_3<string>(3204261755u), Modul.Name, _003CModule_003E.smethod_5<string>(3818505761u)));
				_ZlJqgMWldqDdSHbEbwCi3REUR2v(Connection.smethod_18(_003CModule_003E.smethod_5<string>(3310489817u), DateTime.Now.ToString(_003CModule_003E.smethod_3<string>(2329230257u))));
				break;
			case 2:
				Connection.smethod_3((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, _003CModule_003E.smethod_4<string>(1518035710u));
				if ((int)Connection.smethod_4(Connection.smethod_17((object)object_), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0) == 1)
				{
					Connection.smethod_29(_003CModule_003E.smethod_2<string>(942672851u));
					Connection.smethod_5((Form)(object)this);
					this.method_0();
				}
				_ZlJqgMWldqDdSHbEbwCi3REUR2v(Connection.smethod_13(_003CModule_003E.smethod_1<string>(3090679876u), Modul.Name, _003CModule_003E.smethod_2<string>(437802021u), Connection.smethod_17((object)object_)));
				_ZlJqgMWldqDdSHbEbwCi3REUR2v(Connection.smethod_6(Modul.Name, _003CModule_003E.smethod_5<string>(1266841927u), DateTime.Now.ToString(_003CModule_003E.smethod_4<string>(1132240319u))));
				break;
			case 1:
				Connection.smethod_28(Start);
				break;
			}
		}
		catch
		{
			Connection.smethod_3((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, _003CModule_003E.smethod_5<string>(1290010155u));
			if ((int)Connection.smethod_4(_003CModule_003E.smethod_5<string>(887072634u), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0) == 1)
			{
				Connection.smethod_5((Form)(object)this);
				this.method_0();
			}
			_ZlJqgMWldqDdSHbEbwCi3REUR2v(Connection.smethod_6(_003CModule_003E.smethod_2<string>(722225077u), Modul.Name, _003CModule_003E.smethod_3<string>(3678562208u)));
			_ZlJqgMWldqDdSHbEbwCi3REUR2v(Connection.smethod_6(Modul.Name, _003CModule_003E.smethod_3<string>(1296098608u), DateTime.Now.ToString(_003CModule_003E.smethod_1<string>(3050608914u))));
		}
	}

	public void Start_DoWork(object sender, DoWorkEventArgs e)
	{
		Connection.smethod_30(0);
	}

	public void Start_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		Connection.smethod_31((Form)(object)this, (DialogResult)1);
		Connection.smethod_5((Form)(object)this);
	}

	private void _hBciiXGVQ8xSUW0ajh8pyrGe1KV(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && _ZxAbWPOeuBqLkbv0v0TsfEpIn4bA != null)
		{
			Connection.smethod_32((IDisposable)_ZxAbWPOeuBqLkbv0v0TsfEpIn4bA);
		}
		((Form)this).Dispose(disposing);
	}

	private void _QeLc76eWmkdedtAuJ38IUOaf8ZrA()
	{
		Connection.smethod_34(Connection.smethod_33(typeof(Connection).TypeHandle));
		_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc = Connection.smethod_35();
		Start = Connection.smethod_36();
		Connection.smethod_37((Control)(object)this);
		Connection.smethod_38((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, Color.Transparent);
		Connection.smethod_39((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, new Point(1, 9));
		Connection.smethod_40((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, _003CModule_003E.smethod_2<string>(676026236u));
		Connection.smethod_41((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, new Size(264, 21));
		Connection.smethod_42((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, 0);
		Connection.smethod_43(_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, (ContentAlignment)32);
		Connection.smethod_44((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, (EventHandler)_hBciiXGVQ8xSUW0ajh8pyrGe1KV);
		Connection.smethod_45(Start, bool_0: true);
		Connection.smethod_46(Start, (DoWorkEventHandler)Start_DoWork);
		Connection.smethod_47(Start, (RunWorkerCompletedEventHandler)Start_RunWorkerCompleted);
		Connection.smethod_48((ContainerControl)(object)this, new SizeF(6f, 13f));
		Connection.smethod_49((ContainerControl)(object)this, (AutoScaleMode)1);
		Connection.smethod_50((Control)(object)this, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._FJRB5sBaPzOSCrDgMkyEBTiWjLC);
		Connection.smethod_51((Form)(object)this, new Size(266, 42));
		Connection.smethod_53(Connection.smethod_52((Control)(object)this), (Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc);
		Connection.smethod_55((Control)(object)this, Connection.smethod_54(_003CModule_003E.smethod_3<string>(3890809259u), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)222));
		Connection.smethod_56((Form)(object)this, (FormBorderStyle)0);
		Connection.smethod_57((Control)(object)this, _003CModule_003E.smethod_5<string>(2195171563u));
		Connection.smethod_58((Form)(object)this, (FormStartPosition)1);
		Connection.smethod_3((Control)(object)this, Modul.Name);
		Connection.smethod_59((Form)(object)this, (EventHandler)_5KVDKXtf7oZdNo6RpERr5YcZZjx);
		Connection.smethod_60((Control)(object)this, bool_0: false);
	}

	static Computer smethod_0()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Computer();
	}

	static WebClient smethod_1()
	{
		return new WebClient();
	}

	static void smethod_2(WebClient webClient_0, AsyncCompletedEventHandler asyncCompletedEventHandler_0)
	{
		webClient_0.DownloadFileCompleted += asyncCompletedEventHandler_0;
	}

	static void smethod_3(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static DialogResult smethod_4(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0, MessageBoxDefaultButton messageBoxDefaultButton_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, messageBoxDefaultButton_0);
	}

	static void smethod_5(Form form_0)
	{
		form_0.Close();
	}

	void method_0()
	{
		((Component)this).Dispose();
	}

	static string smethod_6(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static Process[] smethod_7()
	{
		return Process.GetProcesses();
	}

	static Process smethod_8()
	{
		return Process.GetCurrentProcess();
	}

	static string smethod_9(Process process_0)
	{
		return process_0.ProcessName;
	}

	static Process[] smethod_10(string string_0)
	{
		return Process.GetProcessesByName(string_0);
	}

	static FileSystemProxy smethod_11(ServerComputer serverComputer_0)
	{
		return serverComputer_0.get_FileSystem();
	}

	static string smethod_12()
	{
		return Application.get_StartupPath();
	}

	static string smethod_13(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	static bool smethod_14(FileSystemProxy fileSystemProxy_0, string string_0)
	{
		return fileSystemProxy_0.FileExists(string_0);
	}

	static StreamWriter smethod_15(string string_0)
	{
		return new StreamWriter(string_0);
	}

	static void smethod_16(TextWriter textWriter_0)
	{
		textWriter_0.Close();
	}

	static string smethod_17(object object_0)
	{
		return object_0.ToString();
	}

	static string smethod_18(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static int smethod_19(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static void smethod_20(Process process_0)
	{
		process_0.Kill();
	}

	static Exception smethod_21(AsyncCompletedEventArgs asyncCompletedEventArgs_0)
	{
		return asyncCompletedEventArgs_0.Error;
	}

	static void smethod_22(Form form_0, bool bool_0)
	{
		form_0.set_ShowInTaskbar(bool_0);
	}

	static void smethod_23(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static StreamWriter smethod_24(string string_0, bool bool_0)
	{
		return new StreamWriter(string_0, bool_0);
	}

	static void smethod_25(TextWriter textWriter_0, string string_0)
	{
		textWriter_0.WriteLine(string_0);
	}

	static void smethod_26(TextWriter textWriter_0)
	{
		textWriter_0.Flush();
	}

	static string smethod_27(WebClient webClient_0, string string_0)
	{
		return webClient_0.DownloadString(string_0);
	}

	static void smethod_28(BackgroundWorker backgroundWorker_0)
	{
		backgroundWorker_0.RunWorkerAsync();
	}

	static Process smethod_29(string string_0)
	{
		return Process.Start(string_0);
	}

	static void smethod_30(int int_0)
	{
		Thread.Sleep(int_0);
	}

	static void smethod_31(Form form_0, DialogResult dialogResult_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_DialogResult(dialogResult_0);
	}

	static void smethod_32(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Type smethod_33(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ComponentResourceManager smethod_34(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	static Label smethod_35()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static BackgroundWorker smethod_36()
	{
		return new BackgroundWorker();
	}

	static void smethod_37(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_38(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_39(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_40(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_41(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_42(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_43(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static void smethod_44(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_45(BackgroundWorker backgroundWorker_0, bool bool_0)
	{
		backgroundWorker_0.WorkerReportsProgress = bool_0;
	}

	static void smethod_46(BackgroundWorker backgroundWorker_0, DoWorkEventHandler doWorkEventHandler_0)
	{
		backgroundWorker_0.DoWork += doWorkEventHandler_0;
	}

	static void smethod_47(BackgroundWorker backgroundWorker_0, RunWorkerCompletedEventHandler runWorkerCompletedEventHandler_0)
	{
		backgroundWorker_0.RunWorkerCompleted += runWorkerCompletedEventHandler_0;
	}

	static void smethod_48(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_49(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_50(Control control_0, Image image_0)
	{
		control_0.set_BackgroundImage(image_0);
	}

	static void smethod_51(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_52(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_53(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static Font smethod_54(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_55(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_56(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_57(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_58(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_59(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_60(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}
}
