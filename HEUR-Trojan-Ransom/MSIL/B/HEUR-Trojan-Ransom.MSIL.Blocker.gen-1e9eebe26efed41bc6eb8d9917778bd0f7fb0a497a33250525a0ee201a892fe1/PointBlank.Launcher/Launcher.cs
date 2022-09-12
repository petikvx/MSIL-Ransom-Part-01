using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using Ionic.Zip;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;
using PointBlank.DLL;
using PointBlank.DLL.Modul;
using PointBlank.DLL.Xml;
using PointBlank.Launcher.Properties;

namespace PointBlank.Launcher;

public class Launcher : Form
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _SvlT3BphcQE8Nq8BtGiqQIfqEaS
	{
		public static readonly _SvlT3BphcQE8Nq8BtGiqQIfqEaS _003C_003E9 = new _SvlT3BphcQE8Nq8BtGiqQIfqEaS();

		public static Func<string, char> _003C_003E9__16_0;

		public static Func<string, char> _003C_003E9__16_1;

		internal char _lwS4Ta3PU0fiGG7xStOLzLVvK8f(string s)
		{
			return _SvlT3BphcQE8Nq8BtGiqQIfqEaS.smethod_2(s, _SvlT3BphcQE8Nq8BtGiqQIfqEaS.smethod_1(_ghvLUSn4Fzu2CMbm5kyvskUEmhy, _SvlT3BphcQE8Nq8BtGiqQIfqEaS.smethod_0(s)));
		}

		internal char _7SBgEbtLKj0bFgVJHCKURw5bIOS(string s)
		{
			return _SvlT3BphcQE8Nq8BtGiqQIfqEaS.smethod_2(s, _SvlT3BphcQE8Nq8BtGiqQIfqEaS.smethod_1(_ghvLUSn4Fzu2CMbm5kyvskUEmhy, _SvlT3BphcQE8Nq8BtGiqQIfqEaS.smethod_0(s)));
		}

		static int smethod_0(string string_0)
		{
			return string_0.Length;
		}

		static int smethod_1(Random random_0, int int_0)
		{
			return random_0.Next(int_0);
		}

		static char smethod_2(string string_0, int int_0)
		{
			return string_0[int_0];
		}
	}

	public Connection Connection;

	public WebClient GameUpdate;

	public Computer Computer;

	public WebClient Web;

	private AuthModul _jeR2Fb0AnoRKqb7H6cdwMZV747;

	private bool _J264zco1L7zFr672vD4ksBxdVTJ = true;

	private CookieContainer _AplIwinD1EMPlwaoHL6wfU2ESHO;

	private string _eYVWI3saHZogd5BhoJi3xIu3wty = "";

	private string _xv94XCVHlQvAUknApQdLlWeNv24 = "";

	private static Random _ghvLUSn4Fzu2CMbm5kyvskUEmhy = Launcher.smethod_228();

	private bool _iXf43gUCujqfp2Uu47NlyEhZR9L = true;

	private Process[] _IjCC56JDCskrP5ko3jbQkHSi79v = Launcher.smethod_0();

	private IContainer _ZxAbWPOeuBqLkbv0v0TsfEpIn4bA;

	private PictureBox _zRZ60lgdqQASmrQNuIMUp6Kl0E;

	private Label _QbRDXY9MdrbjPbIoQbBO3Qyj9Vc;

	private Label _mbsDcDn93HHjFNYjIiVkujw4hZdA;

	private Label _wTSjSMMVFgw0QS5tNzS67z8pnQA;

	private Point _Yuo6vpnr7kWs5JZnSAEO7nF80wA;

	private PictureBox _tjjl483RAJdLFKvmQ4UTRigyQgw;

	private PictureBox _8LPD4rh6TaT5k8Q41ZsQtMQ3m9D;

	private Timer _R575EO1C8lNv0DYXTkgSFDnmc1R;

	private Button _6pvQk0j5sE5FBQbDSeiw2ePkTAn;

	private BackgroundWorker _TBI3mcIaIjcivimwjB3dQABjClbA;

	private Button _IXyaILfGfoRU7y19VCVwEVnpWRi;

	private Button _syRJKEl0Zo29MJCAALIFHwyuNzL;

	private TextBox _WZwbftUaOkN5EVZdxYoqpzzYxlM;

	private TextBox _gX17TpQ4KmPuqoLVq1aRPizgKsc;

	private Panel _Yf4Br9INNMyzll1WDXNGSAznxBR;

	private Button _b85JSvMrG3n11jqeoaExP08P6PB;

	private Label _gmamJY8lwVcBO1R83D4oo5AnDaS;

	private Label _ETXSN2WvPb5TIur9Xhq3nauc3hb;

	private Label _jQvQgS4regCy5A1D5MfBzvn9Joy;

	private Label _H1kB4xR6rZWaBoRcAzW96XpRSe0;

	private CheckBox _floJR9K3dDRsUoJ7xNw2QunPrvg;

	public Launcher(Connection Connection, AuthModul AuthModul)
	{
		GameUpdate = Launcher.smethod_1();
		Computer = Launcher.smethod_2();
		Web = Launcher.smethod_1();
		this.Connection = Connection;
		_jeR2Fb0AnoRKqb7H6cdwMZV747 = AuthModul;
		_QeLc76eWmkdedtAuJ38IUOaf8ZrA();
		_zaUbcRtm4QciaMQEhVeZgaILZjz();
		Launcher.smethod_3(GameUpdate, (AsyncCompletedEventHandler)_5squILNwRvSDquK68u7WigOVJtD);
		Launcher.smethod_4(GameUpdate, (DownloadProgressChangedEventHandler)_q14wqht244nwPwufyaGxQQyzRJA);
	}

	private void _ZlJqgMWldqDdSHbEbwCi3REUR2v(string Text)
	{
		string string_ = Launcher.smethod_6(Launcher.smethod_5(), _003CModule_003E.smethod_2<string>(171155406u));
		_ = DateTime.Now;
		StreamWriter textWriter_ = Launcher.smethod_7(string_, bool_0: true);
		Launcher.smethod_8((TextWriter)textWriter_, Text);
		Launcher.smethod_9((TextWriter)textWriter_);
		Launcher.smethod_10((TextWriter)textWriter_);
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string dllName);

	public void Launcher_Load(object sender, EventArgs e)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		PrivateFontCollection val = Launcher.smethod_11();
		Launcher.smethod_13(val, Launcher.smethod_6(Launcher.smethod_12(), _003CModule_003E.smethod_1<string>(2689970256u)));
		IEnumerator enumerator = Launcher.smethod_15((ArrangedElementCollection)(object)Launcher.smethod_14((Control)(object)this));
		try
		{
			while (Launcher.smethod_20(enumerator))
			{
				Launcher.smethod_19((Control)Launcher.smethod_16(enumerator), Launcher.smethod_18(Launcher.smethod_17((FontCollection)(object)val)[0], 15f, (FontStyle)1));
			}
		}
		finally
		{
			if (enumerator is IDisposable idisposable_)
			{
				Launcher.smethod_21(idisposable_);
			}
		}
		_AplIwinD1EMPlwaoHL6wfU2ESHO = Launcher.smethod_22();
		SearchFileExtension();
		Launcher.smethod_23((Control)(object)this, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._GMThphC7NrL3ClF1cmjN0BP6p0B);
		Launcher.smethod_24((Form)(object)this, bool_0: true);
		int num = int.Parse(Launcher.smethod_25(Web, Launcher.smethod_6(Modul.WEB, _003CModule_003E.smethod_5<string>(273978267u))));
		Launcher.smethod_26((Control)(object)_mbsDcDn93HHjFNYjIiVkujw4hZdA, "");
		Launcher.smethod_26((Control)(object)_ETXSN2WvPb5TIur9Xhq3nauc3hb, "");
		Launcher.smethod_27((Form)(object)this, (FormWindowState)0);
		Launcher.smethod_28((Control)(object)this, bool_0: true);
		Launcher.smethod_29((Control)(object)_wTSjSMMVFgw0QS5tNzS67z8pnQA, bool_0: false);
		Launcher.smethod_29((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: true);
		LauncherModul.LastVersion = int.Parse(Launcher.smethod_25(Web, Launcher.smethod_6(Modul.WEB, _003CModule_003E.smethod_2<string>(1561332809u))));
		Launcher.smethod_26((Control)(object)_wTSjSMMVFgw0QS5tNzS67z8pnQA, Launcher.smethod_32(_003CModule_003E.smethod_5<string>(2090093140u), Launcher.smethod_31(Launcher.smethod_30(Launcher.smethod_5(), _003CModule_003E.smethod_2<string>(1120437261u), Modul.Ver)), _003CModule_003E.smethod_1<string>(939926568u), LauncherModul.LastVersion.ToString()));
		Launcher.smethod_33((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: false);
		if (Launcher.smethod_35(Launcher.smethod_34((ServerComputer)(object)Computer), Launcher.smethod_6(Launcher.smethod_5(), _003CModule_003E.smethod_2<string>(1995097875u))))
		{
			Launcher.smethod_36(Launcher.smethod_34((ServerComputer)(object)Computer), Launcher.smethod_6(Launcher.smethod_5(), _003CModule_003E.smethod_1<string>(3233247190u)), (DeleteDirectoryOption)5);
		}
		switch (num)
		{
		case 2:
			Launcher.smethod_23((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._STl6P5oGyAqrVVgjdILSQmV2dzF);
			Launcher.smethod_33((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: false);
			break;
		case 3:
			Launcher.smethod_33((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: true);
			break;
		case 4:
			Launcher.smethod_33((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: true);
			break;
		case 1:
			Launcher.smethod_33((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: true);
			break;
		}
		Launcher.smethod_29((Control)(object)_Yf4Br9INNMyzll1WDXNGSAznxBR, bool_0: false);
		Launcher.smethod_29((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: false);
		if (Launcher.smethod_37(LauncherModul.LastVersion.ToString(), Launcher.smethod_31(Launcher.smethod_30(Launcher.smethod_5(), _003CModule_003E.smethod_2<string>(1120437261u), Modul.Ver))))
		{
			XmlLoad();
			return;
		}
		if (LauncherModul.LastVersion < int.Parse(Launcher.smethod_31(Launcher.smethod_30(Launcher.smethod_5(), _003CModule_003E.smethod_5<string>(3336964772u), Modul.Ver))))
		{
			Launcher.smethod_38(Launcher.smethod_30(Launcher.smethod_5(), _003CModule_003E.smethod_1<string>(968820316u), Modul.Ver), 0.ToString());
			_J264zco1L7zFr672vD4ksBxdVTJ = true;
			Launcher.smethod_39((Control)(object)_zRZ60lgdqQASmrQNuIMUp6Kl0E, 0);
			Launcher.smethod_23((Control)(object)this, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._iNBgEHcvRo4yeahJ73MdbdCmVCd);
			Launcher.smethod_29((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, bool_0: false);
			Launcher.smethod_29((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, bool_0: false);
			Launcher.smethod_29((Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, bool_0: false);
			Launcher.smethod_29((Control)(object)_b85JSvMrG3n11jqeoaExP08P6PB, bool_0: false);
			Launcher.smethod_29((Control)(object)_Yf4Br9INNMyzll1WDXNGSAznxBR, bool_0: false);
			Launcher.smethod_29((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: false);
			Launcher.smethod_29((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: false);
			Launcher.smethod_33((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: true);
			Launcher.smethod_33((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, bool_0: true);
			Launcher.smethod_40((Control)(object)_floJR9K3dDRsUoJ7xNw2QunPrvg);
			Launcher.smethod_29((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, bool_0: true);
			return;
		}
		_J264zco1L7zFr672vD4ksBxdVTJ = true;
		Launcher.smethod_39((Control)(object)_zRZ60lgdqQASmrQNuIMUp6Kl0E, 0);
		Launcher.smethod_23((Control)(object)this, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._iNBgEHcvRo4yeahJ73MdbdCmVCd);
		Launcher.smethod_29((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, bool_0: false);
		Launcher.smethod_29((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, bool_0: false);
		Launcher.smethod_29((Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, bool_0: false);
		Launcher.smethod_29((Control)(object)_b85JSvMrG3n11jqeoaExP08P6PB, bool_0: false);
		Launcher.smethod_29((Control)(object)_Yf4Br9INNMyzll1WDXNGSAznxBR, bool_0: false);
		Launcher.smethod_29((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: false);
		Launcher.smethod_29((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: false);
		Launcher.smethod_33((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: true);
		Launcher.smethod_33((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, bool_0: true);
		Launcher.smethod_29((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, bool_0: true);
		Launcher.smethod_40((Control)(object)_floJR9K3dDRsUoJ7xNw2QunPrvg);
		Launcher.smethod_40((Control)(object)_jQvQgS4regCy5A1D5MfBzvn9Joy);
		Launcher.smethod_40((Control)(object)_H1kB4xR6rZWaBoRcAzW96XpRSe0);
		Launcher.smethod_41(_003CModule_003E.smethod_1<string>(2805545248u), _003CModule_003E.smethod_5<string>(810954496u));
		if (!Launcher.smethod_42(_003CModule_003E.smethod_1<string>(4263914988u)))
		{
			Launcher.smethod_45(_003CModule_003E.smethod_2<string>(3367498837u), _003CModule_003E.smethod_2<string>(1959544993u), (MessageBoxButtons)0, (MessageBoxIcon)16);
			Launcher.smethod_46();
		}
		else
		{
			Launcher.smethod_43(Launcher.smethod_6(Launcher.smethod_5(), _003CModule_003E.smethod_4<string>(3814812945u)));
			Launcher.smethod_44((Form)(object)this);
		}
	}

	public static void dosyadanOku()
	{
		string string_ = Launcher.smethod_49(Launcher.smethod_48(Launcher.smethod_47(Registry.CurrentUser, _003CModule_003E.smethod_1<string>(3416836179u), bool_0: true), _003CModule_003E.smethod_4<string>(4225259989u), (object)true));
		FileStream stream_ = Launcher.smethod_50(Launcher.smethod_6(Launcher.smethod_5(), _003CModule_003E.smethod_5<string>(3906208013u)), FileMode.Open, FileAccess.Read);
		StreamReader textReader_ = Launcher.smethod_51((Stream)stream_);
		string text = Launcher.smethod_52((TextReader)textReader_);
		if (text != null && Launcher.smethod_53(text, string_))
		{
			Launcher.smethod_54(1);
		}
		Launcher.smethod_55((TextReader)textReader_);
		Launcher.smethod_56((Stream)stream_);
	}

	public static string RegHWID()
	{
		try
		{
			if (Launcher.smethod_57(Registry.CurrentUser, _003CModule_003E.smethod_5<string>(3806921647u)) == null)
			{
				RegistryKey registryKey_ = Launcher.smethod_58(Registry.CurrentUser, _003CModule_003E.smethod_4<string>(346423978u));
				Launcher.smethod_60(registryKey_, _003CModule_003E.smethod_5<string>(1129496492u), (object)Launcher.smethod_59(new string[9]
				{
					RandomString(4, 0),
					_003CModule_003E.smethod_1<string>(3766297623u),
					RandomString(4, 0),
					_003CModule_003E.smethod_2<string>(1436897722u),
					RandomString(4, 0),
					_003CModule_003E.smethod_5<string>(3940960355u),
					RandomString(4, 0),
					_003CModule_003E.smethod_5<string>(3940960355u),
					RandomString(4, 0)
				}));
				Launcher.smethod_61(registryKey_);
				string string_ = Launcher.smethod_6(Launcher.smethod_5(), _003CModule_003E.smethod_5<string>(3906208013u));
				string string_2 = Launcher.smethod_49(Launcher.smethod_48(Launcher.smethod_47(Registry.CurrentUser, _003CModule_003E.smethod_5<string>(3806921647u), bool_0: true), _003CModule_003E.smethod_1<string>(706040116u), (object)true));
				FileStream stream_ = Launcher.smethod_50(string_, FileMode.OpenOrCreate, FileAccess.Write);
				StreamWriter textWriter_ = Launcher.smethod_62((Stream)stream_);
				Launcher.smethod_63((TextWriter)textWriter_, string_2);
				Launcher.smethod_9((TextWriter)textWriter_);
				Launcher.smethod_56((Stream)stream_);
				Launcher.smethod_10((TextWriter)textWriter_);
				Launcher.smethod_56((Stream)stream_);
			}
			string result = Launcher.smethod_49(Launcher.smethod_48(Launcher.smethod_47(Registry.CurrentUser, _003CModule_003E.smethod_4<string>(346423978u), bool_0: true), _003CModule_003E.smethod_1<string>(706040116u), (object)true));
			dosyadanOku();
			return result;
		}
		catch
		{
			return _003CModule_003E.smethod_1<string>(414366168u);
		}
	}

	public static string RandomString(int length, int type)
	{
		if (type == 1)
		{
			return Launcher.smethod_64((from s in Enumerable.Repeat(_003CModule_003E.smethod_1<string>(1764650949u), length)
				select _SvlT3BphcQE8Nq8BtGiqQIfqEaS.smethod_2(s, _SvlT3BphcQE8Nq8BtGiqQIfqEaS.smethod_1(_ghvLUSn4Fzu2CMbm5kyvskUEmhy, _SvlT3BphcQE8Nq8BtGiqQIfqEaS.smethod_0(s)))).ToArray());
		}
		return Launcher.smethod_64((from s in Enumerable.Repeat(_003CModule_003E.smethod_1<string>(3932170078u), length)
			select _SvlT3BphcQE8Nq8BtGiqQIfqEaS.smethod_2(s, _SvlT3BphcQE8Nq8BtGiqQIfqEaS.smethod_1(_ghvLUSn4Fzu2CMbm5kyvskUEmhy, _SvlT3BphcQE8Nq8BtGiqQIfqEaS.smethod_0(s)))).ToArray());
	}

	private void _YdaMfAPg5D7ba6VPuQX7zVRdIpb(object sender, FormClosingEventArgs e)
	{
		if (!_J264zco1L7zFr672vD4ksBxdVTJ)
		{
			Launcher.smethod_54(0);
		}
	}

	private void _ZNJz10pBEL6IevvOfdRU4ObGE9n(object sender, MouseEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		if ((int)Launcher.smethod_65() == 1048576)
		{
			_Yuo6vpnr7kWs5JZnSAEO7nF80wA.X = Launcher.smethod_66((Control)(object)this) - Launcher.smethod_67().X;
			_Yuo6vpnr7kWs5JZnSAEO7nF80wA.Y = Launcher.smethod_68((Control)(object)this) - Launcher.smethod_67().Y;
		}
	}

	private void _f2yrVPecFpla0QOu49b8QuDjHFq(object sender, MouseEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		if ((int)Launcher.smethod_65() == 1048576)
		{
			Launcher.smethod_69((Control)(object)this, _Yuo6vpnr7kWs5JZnSAEO7nF80wA.X + Launcher.smethod_67().X);
			Launcher.smethod_70((Control)(object)this, _Yuo6vpnr7kWs5JZnSAEO7nF80wA.Y + Launcher.smethod_67().Y);
		}
	}

	private void _PxXQTkp7H4cIQHBGB1pE566au2R(object sender, EventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		if ((int)Launcher.smethod_45(_003CModule_003E.smethod_4<string>(2689647442u), Launcher.smethod_71(), (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
		{
			Launcher.smethod_44((Form)(object)this);
		}
	}

	private void _8xCY9vhS13oPTc9CwfdKXPRqt2J(object sender, EventArgs e)
	{
		Launcher.smethod_72(_tjjl483RAJdLFKvmQ4UTRigyQgw, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._iDVni9rZVa1eXBXRzdYhFsD1peF);
		Launcher.smethod_73((Control)(object)_tjjl483RAJdLFKvmQ4UTRigyQgw, Color.Transparent);
	}

	private void _4mmvvKHE466mPNBZ7CzV2drRaqH(object sender, EventArgs e)
	{
		Launcher.smethod_72(_tjjl483RAJdLFKvmQ4UTRigyQgw, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._FVIsUxdtQaNrw36v12xd2FHbUUk);
		Launcher.smethod_73((Control)(object)_tjjl483RAJdLFKvmQ4UTRigyQgw, Color.Transparent);
	}

	private void _VruweBJcLrvdHbyOybWj6mphAgX(object sender, EventArgs e)
	{
		Launcher.smethod_27((Form)(object)this, (FormWindowState)1);
	}

	private void _i6DJq5sgHTS6sO109OgpV3iQwDf(object sender, EventArgs e)
	{
		Launcher.smethod_23((Control)(object)_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._zkPCbal61fVRabvaLVDq9YaPuRQ);
		Launcher.smethod_73((Control)(object)_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D, Color.Transparent);
	}

	private void _8RQ8ZEKyneZXmpD9raGDv0qrHLM(object sender, MouseEventArgs e)
	{
		Launcher.smethod_23((Control)(object)_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._bm9KgjFcHVIG9C62okrPtRklTsu);
		Launcher.smethod_73((Control)(object)_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D, Color.Transparent);
	}

	private void _AO0yawrCYtBANUAiKr9lQWoF2ui(object sender, EventArgs e)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Invalid comparison between Unknown and I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = int.Parse(Launcher.smethod_25(GameUpdate, Launcher.smethod_6(Modul.WEB, _003CModule_003E.smethod_5<string>(273978267u))));
			string object_ = Launcher.smethod_25(GameUpdate, Launcher.smethod_6(Modul.WEB, _003CModule_003E.smethod_2<string>(3260840191u)));
			string object_2 = Launcher.smethod_25(GameUpdate, Launcher.smethod_6(Modul.WEB, _003CModule_003E.smethod_5<string>(1903104522u)));
			switch (num)
			{
			case 2:
				if ((int)Launcher.smethod_74(Launcher.smethod_49((object)object_2), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0) != 1)
				{
					Launcher.smethod_74(Launcher.smethod_49((object)object_2), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
				}
				_ZlJqgMWldqDdSHbEbwCi3REUR2v(Launcher.smethod_6(_003CModule_003E.smethod_4<string>(2175881846u), Launcher.smethod_49((object)object_2)));
				break;
			case 3:
				Launcher.smethod_74(Launcher.smethod_49((object)object_), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
				break;
			}
		}
		catch
		{
			Launcher.smethod_74(_003CModule_003E.smethod_2<string>(843144687u), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0);
		}
	}

	private void _Sd558BaAXvArHEKjtgwlTiX8O5S(object sender, EventArgs e)
	{
		AntiHack control_ = new AntiHack();
		Launcher.smethod_75((Control)(object)control_);
		Launcher.smethod_40((Control)(object)control_);
		Launcher.smethod_76((Control)(object)this);
	}

	private void _aDWdLECHeTPYOYVcC32O6tN8vUBA(object sender, EventArgs e)
	{
		Launcher.smethod_23((Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._14oRpmNIqF0rG4MpAWRZ3kMSqfD);
	}

	private void _5ykuKX49GRc59OkqjxniLAeWNJC(object sender, MouseEventArgs e)
	{
		Launcher.smethod_23((Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._HZsWa2s8CKV32QJ2BZnrsZgjjXb);
	}

	private void _ErP7bTQI3AjpD7KyLRoPWSno2wc(object sender, EventArgs e)
	{
		Launcher.smethod_23((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._S2DAnKmkLCLVwQ3sKhFlG3RjugE);
	}

	private void _RvZCgC9mvj9GJ9OuPp7OE3dy27f(object sender, MouseEventArgs e)
	{
		Launcher.smethod_23((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._wUTjrivhRNjC4RLboUtnX7qxMOx);
	}

	public void Bar1SetProgress(long received, long maximum, bool progress)
	{
		Launcher.smethod_39((Control)(object)_zRZ60lgdqQASmrQNuIMUp6Kl0E, (int)(received * 463L / maximum));
	}

	public void Bar2SetProgress(ulong received, ulong maximum)
	{
	}

	private void _LYYaWT5oGfslB7jX5WbRfgHHmLB(object sender, EventArgs e)
	{
		Launcher.smethod_23((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._LFtRH0Vll0gI6O5T50IMgdrb03K);
	}

	private void _sLRdPGqJzAiX2qH6bNTFjkGIZvW(object sender, MouseEventArgs e)
	{
		Launcher.smethod_23((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._RUMaMowbobqHULS479nOK4kADTs);
	}

	private List<XMLModel> _LG97xEnjlNy1ajfklPwEyc9O3PO(string Path)
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		List<XMLModel> list = new List<XMLModel>();
		XmlDocument xmlDocument = Launcher.smethod_77();
		FileStream stream_ = Launcher.smethod_78(Path, FileMode.Open);
		if (Launcher.smethod_79((Stream)stream_) == 0L)
		{
			_ZlJqgMWldqDdSHbEbwCi3REUR2v(_003CModule_003E.smethod_3<string>(3981740863u));
		}
		else
		{
			try
			{
				Launcher.smethod_80(xmlDocument, (Stream)stream_);
				for (XmlNode xmlNode = Launcher.smethod_81((XmlNode)xmlDocument); xmlNode != null; xmlNode = Launcher.smethod_87(xmlNode))
				{
					if (((Launcher)(object)_003CModule_003E.smethod_4<string>(4256538271u)).method_0(Launcher.smethod_82(xmlNode)))
					{
						for (XmlNode xmlNode2 = Launcher.smethod_81(xmlNode); xmlNode2 != null; xmlNode2 = Launcher.smethod_87(xmlNode2))
						{
							if (((Launcher)(object)_003CModule_003E.smethod_2<string>(2215545649u)).method_0(Launcher.smethod_82(xmlNode2)))
							{
								XmlNamedNodeMap xmlNamedNodeMap_ = Launcher.smethod_83(xmlNode2);
								list.Add(Launcher.smethod_86(Launcher.smethod_85(Launcher.smethod_84(xmlNamedNodeMap_, _003CModule_003E.smethod_4<string>(1564481939u)))));
							}
						}
					}
				}
			}
			catch (XmlException object_)
			{
				Launcher.smethod_88(Launcher.smethod_49((object)object_));
			}
		}
		Launcher.smethod_89((Stream)stream_);
		Launcher.smethod_56((Stream)stream_);
		return list;
	}

	public void XmlLoad()
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!Launcher.smethod_42(Launcher.smethod_6(Launcher.smethod_5(), _003CModule_003E.smethod_1<string>(2353587452u))))
			{
				return;
			}
			List<XMLModel> list = _LG97xEnjlNy1ajfklPwEyc9O3PO(Launcher.smethod_6(Launcher.smethod_5(), _003CModule_003E.smethod_1<string>(2353587452u)));
			int num = 0;
			foreach (XMLModel item in list)
			{
				_ = item;
				num++;
				Bar2SetProgress((ulong)num, (ulong)list.Count);
			}
			Launcher.smethod_90(Launcher.smethod_6(Launcher.smethod_5(), _003CModule_003E.smethod_2<string>(2684863597u)));
			Launcher.smethod_33((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: true);
			Launcher.smethod_23((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._HfcWsCnbq4vDHVvsYMBUrN7I6eQ);
		}
		catch
		{
			Launcher.smethod_74(_003CModule_003E.smethod_2<string>(3154181545u), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0);
		}
	}

	private void _5squILNwRvSDquK68u7WigOVJtD(object sender, AsyncCompletedEventArgs e)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Launcher.smethod_91(e) == null)
			{
				int num = int.Parse(Launcher.smethod_31(Launcher.smethod_30(Launcher.smethod_5(), _003CModule_003E.smethod_3<string>(4178905955u), Modul.Ver))) + 1;
				Launcher.smethod_39((Control)(object)_zRZ60lgdqQASmrQNuIMUp6Kl0E, 0);
				Unzip(Launcher.smethod_5(), Launcher.smethod_92(new object[4]
				{
					Launcher.smethod_5(),
					_003CModule_003E.smethod_2<string>(1710674819u),
					num,
					_003CModule_003E.smethod_3<string>(891027014u)
				}));
				Launcher.smethod_93(_R575EO1C8lNv0DYXTkgSFDnmc1R);
				Launcher.smethod_94(Launcher.smethod_6(Launcher.smethod_5(), _003CModule_003E.smethod_5<string>(43138523u)), bool_0: true);
				Launcher.smethod_39((Control)(object)_zRZ60lgdqQASmrQNuIMUp6Kl0E, 463);
			}
		}
		catch
		{
			Launcher.smethod_74(_003CModule_003E.smethod_3<string>(566145614u), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0);
		}
	}

	private void _q14wqht244nwPwufyaGxQQyzRJA(object sender, DownloadProgressChangedEventArgs e)
	{
		Bar1SetProgress(Launcher.smethod_95(e), Launcher.smethod_96(e), progress: false);
	}

	private void _kOOYvdik29SS8wid6yyD4HAtuJH(object sender, ExtractProgressEventArgs e)
	{
		if (Launcher.smethod_97((ZipProgressEventArgs)(object)e) != 0L)
		{
			Bar1SetProgress(Launcher.smethod_98((ZipProgressEventArgs)(object)e), Launcher.smethod_97((ZipProgressEventArgs)(object)e), progress: false);
		}
		Launcher.smethod_99((Control)(object)_zRZ60lgdqQASmrQNuIMUp6Kl0E);
		Launcher.smethod_100((Control)(object)_zRZ60lgdqQASmrQNuIMUp6Kl0E);
	}

	public void Unzip(string TargetDir, string ZipToUnpack)
	{
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			SearchFileExtension();
			_J264zco1L7zFr672vD4ksBxdVTJ = true;
			ZipFile val = Launcher.smethod_101(ZipToUnpack);
			try
			{
				Launcher.smethod_102(val, (EventHandler<ExtractProgressEventArgs>)_kOOYvdik29SS8wid6yyD4HAtuJH);
				int num = 0;
				int num2 = 0;
				IEnumerator<ZipEntry> enumerator = Launcher.smethod_103(val);
				try
				{
					while (Launcher.smethod_20((IEnumerator)enumerator))
					{
						if (!Launcher.smethod_104(enumerator.Current))
						{
							num2++;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						Launcher.smethod_21((IDisposable)enumerator);
					}
				}
				enumerator = Launcher.smethod_103(val);
				try
				{
					while (Launcher.smethod_20((IEnumerator)enumerator))
					{
						ZipEntry current = enumerator.Current;
						string text = Launcher.smethod_105(current);
						if (Launcher.smethod_106(text, _003CModule_003E.smethod_3<string>(3186899559u)))
						{
							int num3 = Launcher.smethod_107(text, _003CModule_003E.smethod_2<string>(82273201u));
							text = Launcher.smethod_108(text, num3 + 1);
						}
						if (!Launcher.smethod_104(current))
						{
							if (Launcher.smethod_53(text, Modul.Ver ?? ""))
							{
								_ZlJqgMWldqDdSHbEbwCi3REUR2v(Launcher.smethod_6(_003CModule_003E.smethod_4<string>(2263090063u), text));
							}
							Launcher.smethod_109((Control)(object)this);
							Launcher.smethod_99((Control)(object)this);
							Bar2SetProgress((ulong)(++num), (ulong)num2);
						}
						Launcher.smethod_110(current, TargetDir, (ExtractExistingFileAction)1);
					}
				}
				finally
				{
					if (enumerator != null)
					{
						Launcher.smethod_21((IDisposable)enumerator);
					}
				}
			}
			finally
			{
				if (val != null)
				{
					Launcher.smethod_21((IDisposable)val);
				}
			}
		}
		catch
		{
			Launcher.smethod_74(_003CModule_003E.smethod_5<string>(1809610213u), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0);
		}
	}

	private void _6O2rfFJI7ArhG9V8ZJZOc71mtYf(object sender, EventArgs e)
	{
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			LauncherModul.LastVersion = int.Parse(Launcher.smethod_25(Web, Launcher.smethod_6(Modul.WEB, _003CModule_003E.smethod_3<string>(3295193359u))));
			if (LauncherModul.LastVersion != int.Parse(Launcher.smethod_31(Launcher.smethod_30(Launcher.smethod_5(), _003CModule_003E.smethod_2<string>(1120437261u), Modul.Ver))))
			{
				_J264zco1L7zFr672vD4ksBxdVTJ = true;
				int num = int.Parse(Launcher.smethod_31(Launcher.smethod_30(Launcher.smethod_5(), _003CModule_003E.smethod_4<string>(1450737293u), Modul.Ver))) + 1;
				Launcher.smethod_112(Launcher.smethod_34((ServerComputer)(object)Computer), Launcher.smethod_6(Launcher.smethod_5(), _003CModule_003E.smethod_3<string>(3011437212u)));
				try
				{
					Launcher.smethod_114(GameUpdate, Launcher.smethod_113(Launcher.smethod_32(Modul.WEB, _003CModule_003E.smethod_3<string>(507658165u), num.ToString(), _003CModule_003E.smethod_4<string>(3645138364u))), Launcher.smethod_92(new object[4]
					{
						Launcher.smethod_5(),
						_003CModule_003E.smethod_5<string>(1307386326u),
						num,
						_003CModule_003E.smethod_2<string>(4075041000u)
					}));
				}
				catch
				{
					Launcher.smethod_74(_003CModule_003E.smethod_4<string>(2617607172u), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0);
					_ZlJqgMWldqDdSHbEbwCi3REUR2v(_003CModule_003E.smethod_2<string>(1063592461u));
				}
				Bar2SetProgress(0uL, 100uL);
				_ZlJqgMWldqDdSHbEbwCi3REUR2v(Launcher.smethod_6(_003CModule_003E.smethod_4<string>(721793275u), num.ToString()));
				Launcher.smethod_111(_R575EO1C8lNv0DYXTkgSFDnmc1R);
				return;
			}
			Launcher.smethod_24((Form)(object)this, bool_0: true);
			int num2 = int.Parse(Launcher.smethod_25(Web, Launcher.smethod_6(Modul.WEB, _003CModule_003E.smethod_4<string>(2915251958u))));
			Launcher.smethod_28((Control)(object)this, bool_0: true);
			Launcher.smethod_29((Control)(object)_wTSjSMMVFgw0QS5tNzS67z8pnQA, bool_0: false);
			Launcher.smethod_29((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: true);
			Launcher.smethod_29((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, bool_0: false);
			LauncherModul.LastVersion = int.Parse(Launcher.smethod_25(Web, Launcher.smethod_6(Modul.WEB, _003CModule_003E.smethod_2<string>(1561332809u))));
			Launcher.smethod_26((Control)(object)_wTSjSMMVFgw0QS5tNzS67z8pnQA, Launcher.smethod_32(_003CModule_003E.smethod_1<string>(648252620u), Launcher.smethod_31(Launcher.smethod_30(Launcher.smethod_5(), _003CModule_003E.smethod_4<string>(1450737293u), Modul.Ver)), _003CModule_003E.smethod_5<string>(1383504464u), LauncherModul.LastVersion.ToString()));
			Launcher.smethod_33((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: false);
			if (Launcher.smethod_35(Launcher.smethod_34((ServerComputer)(object)Computer), Launcher.smethod_6(Launcher.smethod_5(), _003CModule_003E.smethod_3<string>(1012342461u))))
			{
				Launcher.smethod_36(Launcher.smethod_34((ServerComputer)(object)Computer), Launcher.smethod_6(Launcher.smethod_5(), _003CModule_003E.smethod_5<string>(69613478u)), (DeleteDirectoryOption)5);
			}
			switch (num2)
			{
			case 1:
				Launcher.smethod_33((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: true);
				break;
			case 2:
				Launcher.smethod_23((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._STl6P5oGyAqrVVgjdILSQmV2dzF);
				Launcher.smethod_33((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: false);
				break;
			case 3:
				Launcher.smethod_33((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: true);
				break;
			case 4:
				Launcher.smethod_33((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: true);
				break;
			}
			XmlLoad();
			Launcher.smethod_111(_R575EO1C8lNv0DYXTkgSFDnmc1R);
		}
		catch
		{
			Launcher.smethod_74(_003CModule_003E.smethod_4<string>(2617607172u), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0);
		}
	}

	private void _K5AKtPIDn0daLThWrY84jaxnmUi(object sender, EventArgs e)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (Launcher.smethod_42(_003CModule_003E.smethod_3<string>(3602712563u)))
		{
			Launcher.smethod_115(Launcher.smethod_6(Launcher.smethod_5(), _003CModule_003E.smethod_3<string>(3548565663u)), _003CModule_003E.smethod_3<string>(1486642914u));
			return;
		}
		Launcher.smethod_45(_003CModule_003E.smethod_2<string>(2940864253u), _003CModule_003E.smethod_3<string>(2541477308u), (MessageBoxButtons)0, (MessageBoxIcon)16);
		Launcher.smethod_46();
	}

	public static List<string> GetFilesRecursive(string Initial, string[] Extension)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>();
		stack.Push(Initial);
		while (stack.Count > 0)
		{
			try
			{
				string string_ = stack.Pop();
				string[] array = Extension;
				foreach (string text in array)
				{
					string string_2 = (Launcher.smethod_53(Launcher.smethod_116(text, 0, 1), _003CModule_003E.smethod_5<string>(3725011452u)) ? Launcher.smethod_6(_003CModule_003E.smethod_1<string>(1398423684u), text) : text);
					list.AddRange(Launcher.smethod_117(string_, string_2));
				}
				string text2 = null;
				array = Launcher.smethod_118(string_);
				for (int i = 0; i < array.Length; i++)
				{
					text2 = array[i];
					stack.Push(text2);
				}
			}
			catch
			{
				Launcher.smethod_74(_003CModule_003E.smethod_4<string>(208027679u), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0);
			}
		}
		return list;
	}

	public void SearchFileExtension()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string[] extension = new string[2]
			{
				_003CModule_003E.smethod_1<string>(2399247021u),
				_003CModule_003E.smethod_2<string>(523168749u)
			};
			foreach (string item in GetFilesRecursive(Launcher.smethod_5(), extension))
			{
				Launcher.smethod_90(item);
			}
		}
		catch
		{
			Launcher.smethod_74(_003CModule_003E.smethod_3<string>(761030469u), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0);
		}
	}

	private string _j9qEY1hKpAGaG5EdRLe0EFMHTk9()
	{
		string result = string.Empty;
		long num = -1L;
		NetworkInterface[] array = Launcher.smethod_119();
		foreach (NetworkInterface networkInterface_ in array)
		{
			string text = Launcher.smethod_49((object)Launcher.smethod_120(networkInterface_));
			if (Launcher.smethod_121(networkInterface_) > num && !Launcher.smethod_122(text) && Launcher.smethod_123(text) >= 12)
			{
				num = Launcher.smethod_121(networkInterface_);
				result = text;
			}
		}
		return result;
	}

	private string _XapSgEsD08pCIbTEeVrAuGkMuGB()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string result = string.Empty;
		ManagementObjectEnumerator val = Launcher.smethod_126(Launcher.smethod_125(Launcher.smethod_124(_003CModule_003E.smethod_1<string>(2359176059u))));
		try
		{
			while (Launcher.smethod_129(val))
			{
				result = Launcher.smethod_49(Launcher.smethod_128((ManagementBaseObject)(ManagementObject)Launcher.smethod_127(val), _003CModule_003E.smethod_3<string>(2556559267u)));
			}
			return result;
		}
		finally
		{
			if (val != null)
			{
				Launcher.smethod_21((IDisposable)val);
			}
		}
	}

	private string _6xSbCQcO9Cskknab8oFD9qrBgVP()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string result = string.Empty;
		ManagementObjectEnumerator val = Launcher.smethod_126(Launcher.smethod_125(Launcher.smethod_124(_003CModule_003E.smethod_4<string>(1205222977u))));
		try
		{
			while (Launcher.smethod_129(val))
			{
				result = Launcher.smethod_49(Launcher.smethod_128((ManagementBaseObject)(ManagementObject)Launcher.smethod_127(val), _003CModule_003E.smethod_1<string>(860735357u)));
			}
			return result;
		}
		finally
		{
			if (val != null)
			{
				Launcher.smethod_21((IDisposable)val);
			}
		}
	}

	private string _iM26CtacChCgOTXgoBbAmqGfL3wb()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		string result = string.Empty;
		ManagementObjectEnumerator val = Launcher.smethod_126(Launcher.smethod_125(Launcher.smethod_124(_003CModule_003E.smethod_1<string>(1735757201u))));
		try
		{
			while (Launcher.smethod_129(val))
			{
				ManagementObject managementBaseObject_ = (ManagementObject)Launcher.smethod_127(val);
				result = ((Launcher.smethod_130((ManagementBaseObject)(object)managementBaseObject_, _003CModule_003E.smethod_5<string>(4261987681u)) == null) ? null : Launcher.smethod_49(Launcher.smethod_130((ManagementBaseObject)(object)managementBaseObject_, _003CModule_003E.smethod_3<string>(1523427618u))));
			}
			return result;
		}
		finally
		{
			if (val != null)
			{
				Launcher.smethod_21((IDisposable)val);
			}
		}
	}

	private void _5YnALCcYGPJaMJH5ZZmBRrLKfVQ(object sender, EventArgs e)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		_CwddAuZhodt2YibTqcHBYKNo82o();
		string text = _j8S9PWZaFUlpUQR02Lp5YeMCGns(Launcher.smethod_6(Modul.WEB, _003CModule_003E.smethod_4<string>(3640396511u)), Launcher.smethod_131((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc), Launcher.smethod_131((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM), _j9qEY1hKpAGaG5EdRLe0EFMHTk9(), _XapSgEsD08pCIbTEeVrAuGkMuGB(), _iM26CtacChCgOTXgoBbAmqGfL3wb(), _6xSbCQcO9Cskknab8oFD9qrBgVP(), RegHWID());
		if (Launcher.smethod_37(Launcher.smethod_131((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc), "") || Launcher.smethod_37(Launcher.smethod_131((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM), ""))
		{
			Launcher.smethod_41(_003CModule_003E.smethod_4<string>(3958893485u), _003CModule_003E.smethod_2<string>(380957221u));
		}
		else if (Launcher.smethod_37(text, _003CModule_003E.smethod_1<string>(528990447u)))
		{
			Launcher.smethod_75((Control)(object)_jQvQgS4regCy5A1D5MfBzvn9Joy);
			Launcher.smethod_75((Control)(object)_H1kB4xR6rZWaBoRcAzW96XpRSe0);
			Launcher.smethod_26((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, "");
			Launcher.smethod_26((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, "");
			Launcher.smethod_132((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc);
		}
		Launcher.smethod_40((Control)(object)_jQvQgS4regCy5A1D5MfBzvn9Joy);
		Launcher.smethod_40((Control)(object)_H1kB4xR6rZWaBoRcAzW96XpRSe0);
		Launcher.smethod_29((Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS, bool_0: true);
		Launcher.smethod_26((Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS, _003CModule_003E.smethod_5<string>(419601089u));
		if (!Launcher.smethod_37(text, _003CModule_003E.smethod_4<string>(3799644998u)))
		{
			if (Launcher.smethod_37(text, _003CModule_003E.smethod_1<string>(2782240107u)))
			{
				Launcher.smethod_26((Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS, _003CModule_003E.smethod_5<string>(3196312610u));
				Launcher.smethod_26((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, "");
				Launcher.smethod_26((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, "");
				Launcher.smethod_132((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc);
			}
			else if (Launcher.smethod_37(text, _003CModule_003E.smethod_4<string>(2833727982u)))
			{
				Launcher.smethod_26((Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS, _003CModule_003E.smethod_1<string>(1072267381u));
				Launcher.smethod_41(_003CModule_003E.smethod_2<string>(2656441197u), Launcher.smethod_71());
				Launcher.smethod_26((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, "");
				Launcher.smethod_26((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, "");
				Launcher.smethod_132((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc);
			}
			else if (!Launcher.smethod_37(text, _003CModule_003E.smethod_3<string>(3106709365u)))
			{
				if (!Launcher.smethod_37(text, _003CModule_003E.smethod_2<string>(149863488u)))
				{
					string text2 = "";
					text2 = (_eYVWI3saHZogd5BhoJi3xIu3wty = text);
					Launcher.smethod_23((Control)(object)this, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._kLE6CsaaL19IfLcrR1mIAGNk9Ko);
					Launcher.smethod_29((Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS, bool_0: false);
					Launcher.smethod_29((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, bool_0: false);
					Launcher.smethod_29((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, bool_0: false);
					Launcher.smethod_29((Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, bool_0: false);
					Launcher.smethod_29((Control)(object)_b85JSvMrG3n11jqeoaExP08P6PB, bool_0: false);
					Launcher.smethod_29((Control)(object)_Yf4Br9INNMyzll1WDXNGSAznxBR, bool_0: true);
					Launcher.smethod_40((Control)(object)_floJR9K3dDRsUoJ7xNw2QunPrvg);
					AntiHack control_ = new AntiHack();
					Launcher.smethod_75((Control)(object)control_);
					Launcher.smethod_40((Control)(object)control_);
					Launcher.smethod_76((Control)(object)this);
				}
				else
				{
					Launcher.smethod_26((Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS, _003CModule_003E.smethod_1<string>(202834144u));
					Launcher.smethod_26((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, "");
					Launcher.smethod_26((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, "");
					Launcher.smethod_132((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc);
				}
			}
			else
			{
				Launcher.smethod_26((Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS, _003CModule_003E.smethod_4<string>(3152224956u));
				Launcher.smethod_41(_003CModule_003E.smethod_5<string>(159801060u), Launcher.smethod_71());
				Launcher.smethod_26((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, "");
				Launcher.smethod_26((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, "");
				Launcher.smethod_132((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc);
			}
		}
		else
		{
			Launcher.smethod_26((Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS, _003CModule_003E.smethod_2<string>(2745323402u));
			Launcher.smethod_41(_003CModule_003E.smethod_3<string>(485955420u), Launcher.smethod_71());
			Launcher.smethod_75((Control)(object)_jQvQgS4regCy5A1D5MfBzvn9Joy);
			Launcher.smethod_75((Control)(object)_H1kB4xR6rZWaBoRcAzW96XpRSe0);
			Launcher.smethod_26((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, "");
			Launcher.smethod_26((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, Settings.Default.Username);
			Launcher.smethod_132((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc);
		}
	}

	private string _j8S9PWZaFUlpUQR02Lp5YeMCGns(string url, string username, string password, string mac, string cpuinfo, string hddserial, string boardid, string RegHWID)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)Launcher.smethod_133(url);
		Launcher.smethod_134(httpWebRequest, _AplIwinD1EMPlwaoHL6wfU2ESHO);
		string string_ = Launcher.smethod_59(new string[16]
		{
			_003CModule_003E.smethod_4<string>(3116204821u),
			username,
			_003CModule_003E.smethod_4<string>(424148489u),
			password,
			_003CModule_003E.smethod_4<string>(2088673629u),
			mac,
			_003CModule_003E.smethod_1<string>(368706599u),
			cpuinfo,
			_003CModule_003E.smethod_1<string>(1243728443u),
			hddserial,
			_003CModule_003E.smethod_2<string>(1522264450u),
			boardid,
			_003CModule_003E.smethod_1<string>(2456083804u),
			GetMD5HashFromFile(Launcher.smethod_6(Launcher.smethod_136(Launcher.smethod_135()), _003CModule_003E.smethod_3<string>(2723340516u))),
			_003CModule_003E.smethod_1<string>(3456907141u),
			RegHWID
		});
		byte[] array = Launcher.smethod_138(Launcher.smethod_137(), string_);
		Launcher.smethod_139((WebRequest)httpWebRequest, _003CModule_003E.smethod_1<string>(36961689u));
		Launcher.smethod_140((WebRequest)httpWebRequest, _003CModule_003E.smethod_2<string>(3399536242u));
		Launcher.smethod_141((WebRequest)httpWebRequest, (long)array.Length);
		Stream stream = Launcher.smethod_142((WebRequest)httpWebRequest);
		try
		{
			Launcher.smethod_143(stream, array, 0, array.Length);
		}
		finally
		{
			if (stream != null)
			{
				Launcher.smethod_21((IDisposable)stream);
			}
		}
		return Launcher.smethod_146((TextReader)Launcher.smethod_51(Launcher.smethod_145((WebResponse)(HttpWebResponse)Launcher.smethod_144((WebRequest)httpWebRequest))));
	}

	protected string GetMD5HashFromFile(string fileName)
	{
		MD5 mD = Launcher.smethod_147();
		try
		{
			FileStream fileStream = Launcher.smethod_148(fileName);
			try
			{
				return Launcher.smethod_151(Launcher.smethod_150(Launcher.smethod_149((HashAlgorithm)mD, (Stream)fileStream)), _003CModule_003E.smethod_3<string>(124289316u), string.Empty);
			}
			finally
			{
				if (fileStream != null)
				{
					Launcher.smethod_21((IDisposable)fileStream);
				}
			}
		}
		finally
		{
			if (mD != null)
			{
				Launcher.smethod_21((IDisposable)mD);
			}
		}
	}

	private void _KDtCBmtyEv6Um9Zdggc2F9ULzhk(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)Launcher.smethod_152(e) == 13)
		{
			Launcher.smethod_153(_syRJKEl0Zo29MJCAALIFHwyuNzL);
		}
	}

	private void _pGJS20b3uuv0YddFhGnZNxHhamh(object sender, EventArgs e)
	{
		Launcher.smethod_154((TextBoxBase)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, 16);
	}

	private void _zaUbcRtm4QciaMQEhVeZgaILZjz()
	{
		if (Launcher.smethod_53(Settings.Default.Username, string.Empty))
		{
			if (Settings.Default.remember)
			{
				Launcher.smethod_26((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, Settings.Default.Username);
				Launcher.smethod_155(_floJR9K3dDRsUoJ7xNw2QunPrvg, bool_0: true);
			}
			else
			{
				Launcher.smethod_26((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, Settings.Default.Username);
			}
		}
	}

	private void _CwddAuZhodt2YibTqcHBYKNo82o()
	{
		if (Launcher.smethod_156(_floJR9K3dDRsUoJ7xNw2QunPrvg))
		{
			Settings.Default.Username = Launcher.smethod_157(Launcher.smethod_131((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc));
			Settings.Default.remember = true;
			Launcher.smethod_158((SettingsBase)(object)Settings.Default);
		}
		else
		{
			Settings.Default.Username = "";
			Settings.Default.remember = false;
			Launcher.smethod_158((SettingsBase)(object)Settings.Default);
		}
	}

	private void _anFIUXbfiaiaUJhMhB2QnExXi5(object sender, EventArgs e)
	{
		Launcher.smethod_43(_003CModule_003E.smethod_4<string>(1061142437u));
	}

	private void _YPs43SzlBYtWdZAbTfz3JpKvxch(object sender, DoWorkEventArgs e)
	{
	}

	private void _0AzI6H1eeVBoxr7ZcsDF9W2lD8p(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)Launcher.smethod_152(e) == 13)
		{
			_5YnALCcYGPJaMJH5ZZmBRrLKfVQ(this, Launcher.smethod_159());
		}
	}

	private void _XvMNd1wrgfM1NtkhcqcbDM0RkeD(object sender, EventArgs e)
	{
		Launcher.smethod_154((TextBoxBase)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, 16);
	}

	private void _wqtPaBsoaapbFsACxf0YCSgFPlD(object sender, EventArgs e)
	{
	}

	private void _lKCe5uggi4LfI6AJU99B1PmChQV(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && _ZxAbWPOeuBqLkbv0v0TsfEpIn4bA != null)
		{
			Launcher.smethod_21((IDisposable)_ZxAbWPOeuBqLkbv0v0TsfEpIn4bA);
		}
		((Form)this).Dispose(disposing);
	}

	private void _QeLc76eWmkdedtAuJ38IUOaf8ZrA()
	{
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected O, but got Unknown
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected O, but got Unknown
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected O, but got Unknown
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected O, but got Unknown
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_094e: Expected O, but got Unknown
		//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Expected O, but got Unknown
		//IL_0b9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3e: Expected O, but got Unknown
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc1: Expected O, but got Unknown
		//IL_0cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8e: Expected O, but got Unknown
		//IL_1285: Unknown result type (might be due to invalid IL or missing references)
		//IL_128f: Expected O, but got Unknown
		//IL_1291: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d2: Expected O, but got Unknown
		//IL_12ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f6: Expected O, but got Unknown
		//IL_12fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1308: Expected O, but got Unknown
		_ZxAbWPOeuBqLkbv0v0TsfEpIn4bA = Launcher.smethod_160();
		ComponentResourceManager resourceManager_ = Launcher.smethod_162(Launcher.smethod_161(typeof(Launcher).TypeHandle));
		_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc = Launcher.smethod_163();
		_mbsDcDn93HHjFNYjIiVkujw4hZdA = Launcher.smethod_163();
		_ETXSN2WvPb5TIur9Xhq3nauc3hb = Launcher.smethod_163();
		_wTSjSMMVFgw0QS5tNzS67z8pnQA = Launcher.smethod_163();
		_tjjl483RAJdLFKvmQ4UTRigyQgw = Launcher.smethod_164();
		_zRZ60lgdqQASmrQNuIMUp6Kl0E = Launcher.smethod_164();
		_R575EO1C8lNv0DYXTkgSFDnmc1R = Launcher.smethod_165(_ZxAbWPOeuBqLkbv0v0TsfEpIn4bA);
		_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D = Launcher.smethod_164();
		_TBI3mcIaIjcivimwjB3dQABjClbA = Launcher.smethod_166();
		_6pvQk0j5sE5FBQbDSeiw2ePkTAn = Launcher.smethod_167();
		_IXyaILfGfoRU7y19VCVwEVnpWRi = Launcher.smethod_167();
		_WZwbftUaOkN5EVZdxYoqpzzYxlM = Launcher.smethod_168();
		_gX17TpQ4KmPuqoLVq1aRPizgKsc = Launcher.smethod_168();
		_syRJKEl0Zo29MJCAALIFHwyuNzL = Launcher.smethod_167();
		_b85JSvMrG3n11jqeoaExP08P6PB = Launcher.smethod_167();
		_Yf4Br9INNMyzll1WDXNGSAznxBR = Launcher.smethod_169();
		_gmamJY8lwVcBO1R83D4oo5AnDaS = Launcher.smethod_163();
		_jQvQgS4regCy5A1D5MfBzvn9Joy = Launcher.smethod_163();
		_H1kB4xR6rZWaBoRcAzW96XpRSe0 = Launcher.smethod_163();
		_floJR9K3dDRsUoJ7xNw2QunPrvg = Launcher.smethod_170();
		Launcher.smethod_171((ISupportInitialize)_tjjl483RAJdLFKvmQ4UTRigyQgw);
		Launcher.smethod_171((ISupportInitialize)_zRZ60lgdqQASmrQNuIMUp6Kl0E);
		Launcher.smethod_171((ISupportInitialize)_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D);
		Launcher.smethod_172((Control)(object)_Yf4Br9INNMyzll1WDXNGSAznxBR);
		Launcher.smethod_173((Control)(object)this);
		Launcher.smethod_73((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, Color.Transparent);
		Launcher.smethod_19((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, Launcher.smethod_174(_003CModule_003E.smethod_2<string>(2571074469u), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)222));
		Launcher.smethod_175((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, Color.Transparent);
		Launcher.smethod_176((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, new Point(16, 526));
		Launcher.smethod_177((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, new Padding(2, 0, 2, 0));
		Launcher.smethod_178((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, _003CModule_003E.smethod_3<string>(2641090010u));
		Launcher.smethod_179((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, new Size(465, 16));
		Launcher.smethod_180((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, 0);
		Launcher.smethod_26((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, _003CModule_003E.smethod_3<string>(2106021871u));
		Launcher.smethod_181((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, new MouseEventHandler(_ZNJz10pBEL6IevvOfdRU4ObGE9n));
		Launcher.smethod_182((Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc, new MouseEventHandler(_f2yrVPecFpla0QOu49b8QuDjHFq));
		Launcher.smethod_73((Control)(object)_mbsDcDn93HHjFNYjIiVkujw4hZdA, Color.Transparent);
		Launcher.smethod_19((Control)(object)_mbsDcDn93HHjFNYjIiVkujw4hZdA, Launcher.smethod_183(_003CModule_003E.smethod_4<string>(3247974491u), 14.25f, (FontStyle)1));
		Launcher.smethod_175((Control)(object)_mbsDcDn93HHjFNYjIiVkujw4hZdA, Color.Transparent);
		Launcher.smethod_176((Control)(object)_mbsDcDn93HHjFNYjIiVkujw4hZdA, new Point(8, -1));
		Launcher.smethod_177((Control)(object)_mbsDcDn93HHjFNYjIiVkujw4hZdA, new Padding(2, 0, 2, 0));
		Launcher.smethod_178((Control)(object)_mbsDcDn93HHjFNYjIiVkujw4hZdA, _003CModule_003E.smethod_5<string>(2159597824u));
		Launcher.smethod_179((Control)(object)_mbsDcDn93HHjFNYjIiVkujw4hZdA, new Size(38, 16));
		Launcher.smethod_180((Control)(object)_mbsDcDn93HHjFNYjIiVkujw4hZdA, 1);
		Launcher.smethod_181((Control)(object)_mbsDcDn93HHjFNYjIiVkujw4hZdA, new MouseEventHandler(_ZNJz10pBEL6IevvOfdRU4ObGE9n));
		Launcher.smethod_182((Control)(object)_mbsDcDn93HHjFNYjIiVkujw4hZdA, new MouseEventHandler(_f2yrVPecFpla0QOu49b8QuDjHFq));
		Launcher.smethod_73((Control)(object)_ETXSN2WvPb5TIur9Xhq3nauc3hb, Color.Transparent);
		Launcher.smethod_19((Control)(object)_ETXSN2WvPb5TIur9Xhq3nauc3hb, Launcher.smethod_183(_003CModule_003E.smethod_4<string>(3247974491u), 14.25f, (FontStyle)1));
		Launcher.smethod_175((Control)(object)_ETXSN2WvPb5TIur9Xhq3nauc3hb, Color.Transparent);
		Launcher.smethod_176((Control)(object)_ETXSN2WvPb5TIur9Xhq3nauc3hb, new Point(8, 31));
		Launcher.smethod_177((Control)(object)_ETXSN2WvPb5TIur9Xhq3nauc3hb, new Padding(2, 0, 2, 0));
		Launcher.smethod_178((Control)(object)_ETXSN2WvPb5TIur9Xhq3nauc3hb, _003CModule_003E.smethod_3<string>(1943581171u));
		Launcher.smethod_179((Control)(object)_ETXSN2WvPb5TIur9Xhq3nauc3hb, new Size(465, 16));
		Launcher.smethod_180((Control)(object)_ETXSN2WvPb5TIur9Xhq3nauc3hb, 2);
		Launcher.smethod_26((Control)(object)_ETXSN2WvPb5TIur9Xhq3nauc3hb, _003CModule_003E.smethod_2<string>(1191443497u));
		Launcher.smethod_181((Control)(object)_ETXSN2WvPb5TIur9Xhq3nauc3hb, new MouseEventHandler(_ZNJz10pBEL6IevvOfdRU4ObGE9n));
		Launcher.smethod_182((Control)(object)_ETXSN2WvPb5TIur9Xhq3nauc3hb, new MouseEventHandler(_f2yrVPecFpla0QOu49b8QuDjHFq));
		Launcher.smethod_73((Control)(object)_wTSjSMMVFgw0QS5tNzS67z8pnQA, Color.Transparent);
		Launcher.smethod_175((Control)(object)_wTSjSMMVFgw0QS5tNzS67z8pnQA, Color.White);
		Launcher.smethod_176((Control)(object)_wTSjSMMVFgw0QS5tNzS67z8pnQA, new Point(262, 7));
		Launcher.smethod_177((Control)(object)_wTSjSMMVFgw0QS5tNzS67z8pnQA, new Padding(2, 0, 2, 0));
		Launcher.smethod_178((Control)(object)_wTSjSMMVFgw0QS5tNzS67z8pnQA, _003CModule_003E.smethod_1<string>(2651800720u));
		Launcher.smethod_179((Control)(object)_wTSjSMMVFgw0QS5tNzS67z8pnQA, new Size(471, 13));
		Launcher.smethod_180((Control)(object)_wTSjSMMVFgw0QS5tNzS67z8pnQA, 3);
		Launcher.smethod_181((Control)(object)_wTSjSMMVFgw0QS5tNzS67z8pnQA, new MouseEventHandler(_ZNJz10pBEL6IevvOfdRU4ObGE9n));
		Launcher.smethod_182((Control)(object)_wTSjSMMVFgw0QS5tNzS67z8pnQA, new MouseEventHandler(_f2yrVPecFpla0QOu49b8QuDjHFq));
		Launcher.smethod_73((Control)(object)_tjjl483RAJdLFKvmQ4UTRigyQgw, Color.White);
		Launcher.smethod_72(_tjjl483RAJdLFKvmQ4UTRigyQgw, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._FVIsUxdtQaNrw36v12xd2FHbUUk);
		Launcher.smethod_176((Control)(object)_tjjl483RAJdLFKvmQ4UTRigyQgw, new Point(703, 7));
		Launcher.smethod_177((Control)(object)_tjjl483RAJdLFKvmQ4UTRigyQgw, new Padding(2));
		Launcher.smethod_178((Control)(object)_tjjl483RAJdLFKvmQ4UTRigyQgw, _003CModule_003E.smethod_5<string>(4229720669u));
		Launcher.smethod_179((Control)(object)_tjjl483RAJdLFKvmQ4UTRigyQgw, new Size(23, 23));
		Launcher.smethod_184(_tjjl483RAJdLFKvmQ4UTRigyQgw, 4);
		Launcher.smethod_185(_tjjl483RAJdLFKvmQ4UTRigyQgw, bool_0: false);
		Launcher.smethod_186((Control)(object)_tjjl483RAJdLFKvmQ4UTRigyQgw, (EventHandler)_PxXQTkp7H4cIQHBGB1pE566au2R);
		Launcher.smethod_187((Control)(object)_tjjl483RAJdLFKvmQ4UTRigyQgw, (EventHandler)_4mmvvKHE466mPNBZ7CzV2drRaqH);
		Launcher.smethod_188((Control)(object)_tjjl483RAJdLFKvmQ4UTRigyQgw, (EventHandler)_8xCY9vhS13oPTc9CwfdKXPRqt2J);
		Launcher.smethod_73((Control)(object)_zRZ60lgdqQASmrQNuIMUp6Kl0E, Color.DarkOliveGreen);
		Launcher.smethod_176((Control)(object)_zRZ60lgdqQASmrQNuIMUp6Kl0E, new Point(8, 20));
		Launcher.smethod_178((Control)(object)_zRZ60lgdqQASmrQNuIMUp6Kl0E, _003CModule_003E.smethod_5<string>(3876426331u));
		Launcher.smethod_179((Control)(object)_zRZ60lgdqQASmrQNuIMUp6Kl0E, new Size(541, 10));
		Launcher.smethod_184(_zRZ60lgdqQASmrQNuIMUp6Kl0E, 11);
		Launcher.smethod_185(_zRZ60lgdqQASmrQNuIMUp6Kl0E, bool_0: false);
		Launcher.smethod_181((Control)(object)_zRZ60lgdqQASmrQNuIMUp6Kl0E, new MouseEventHandler(_ZNJz10pBEL6IevvOfdRU4ObGE9n));
		Launcher.smethod_182((Control)(object)_zRZ60lgdqQASmrQNuIMUp6Kl0E, new MouseEventHandler(_f2yrVPecFpla0QOu49b8QuDjHFq));
		Launcher.smethod_189(_R575EO1C8lNv0DYXTkgSFDnmc1R, (EventHandler)_6O2rfFJI7ArhG9V8ZJZOc71mtYf);
		Launcher.smethod_73((Control)(object)_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D, Color.White);
		Launcher.smethod_72(_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._zkPCbal61fVRabvaLVDq9YaPuRQ);
		Launcher.smethod_176((Control)(object)_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D, new Point(675, 7));
		Launcher.smethod_178((Control)(object)_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D, _003CModule_003E.smethod_2<string>(1138114174u));
		Launcher.smethod_179((Control)(object)_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D, new Size(23, 23));
		Launcher.smethod_184(_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D, 15);
		Launcher.smethod_185(_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D, bool_0: false);
		Launcher.smethod_186((Control)(object)_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D, (EventHandler)_VruweBJcLrvdHbyOybWj6mphAgX);
		Launcher.smethod_188((Control)(object)_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D, (EventHandler)_i6DJq5sgHTS6sO109OgpV3iQwDf);
		Launcher.smethod_182((Control)(object)_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D, new MouseEventHandler(_8RQ8ZEKyneZXmpD9raGDv0qrHLM));
		Launcher.smethod_190(_TBI3mcIaIjcivimwjB3dQABjClbA, (DoWorkEventHandler)_YPs43SzlBYtWdZAbTfz3JpKvxch);
		Launcher.smethod_192(Launcher.smethod_191((ButtonBase)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn), 0);
		Launcher.smethod_193((ButtonBase)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, (FlatStyle)0);
		Launcher.smethod_19((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, Launcher.smethod_183(_003CModule_003E.smethod_3<string>(3847403769u), 12f, (FontStyle)1));
		Launcher.smethod_175((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, Color.FromArgb(20, 32, 45));
		Launcher.smethod_194((ButtonBase)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._6ejuKiMtfZbDJHm90fsdJOTPDbP);
		Launcher.smethod_195((ButtonBase)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, (ImeMode)0);
		Launcher.smethod_176((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, new Point(232, 241));
		Launcher.smethod_177((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, new Padding(0));
		Launcher.smethod_178((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, _003CModule_003E.smethod_2<string>(3520256796u));
		Launcher.smethod_179((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, new Size(169, 55));
		Launcher.smethod_180((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, 0);
		Launcher.smethod_196((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: false);
		Launcher.smethod_29((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, bool_0: false);
		Launcher.smethod_186((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, (EventHandler)_Sd558BaAXvArHEKjtgwlTiX8O5S);
		Launcher.smethod_188((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, (EventHandler)_ErP7bTQI3AjpD7KyLRoPWSno2wc);
		Launcher.smethod_182((Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn, new MouseEventHandler(_RvZCgC9mvj9GJ9OuPp7OE3dy27f));
		Launcher.smethod_73((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, Color.Transparent);
		Launcher.smethod_33((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, bool_0: false);
		Launcher.smethod_192(Launcher.smethod_191((ButtonBase)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi), 0);
		Launcher.smethod_193((ButtonBase)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, (FlatStyle)0);
		Launcher.smethod_19((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, Launcher.smethod_183(_003CModule_003E.smethod_4<string>(1706677703u), 12f, (FontStyle)1));
		Launcher.smethod_175((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, Color.FromArgb(20, 32, 45));
		Launcher.smethod_194((ButtonBase)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._yoYUcYVuy3mYDppNBs7xKCdyLuG);
		Launcher.smethod_195((ButtonBase)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, (ImeMode)0);
		Launcher.smethod_176((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, new Point(249, 236));
		Launcher.smethod_177((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, new Padding(0));
		Launcher.smethod_178((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, _003CModule_003E.smethod_5<string>(4279363852u));
		Launcher.smethod_179((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, new Size(152, 64));
		Launcher.smethod_180((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, 1001);
		Launcher.smethod_196((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, bool_0: false);
		Launcher.smethod_197((ButtonBase)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, bool_0: false);
		Launcher.smethod_29((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, bool_0: false);
		Launcher.smethod_186((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, (EventHandler)_K5AKtPIDn0daLThWrY84jaxnmUi);
		Launcher.smethod_188((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, (EventHandler)_LYYaWT5oGfslB7jX5WbRfgHHmLB);
		Launcher.smethod_182((Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi, new MouseEventHandler(_sLRdPGqJzAiX2qH6bNTFjkGIZvW));
		Launcher.smethod_73((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, Color.White);
		Launcher.smethod_198((TextBoxBase)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, (BorderStyle)0);
		Launcher.smethod_19((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, Launcher.smethod_183(_003CModule_003E.smethod_1<string>(3778425550u), 14.25f, (FontStyle)1));
		Launcher.smethod_175((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, Color.Black);
		Launcher.smethod_176((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, new Point(198, 304));
		Launcher.smethod_199((TextBoxBase)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, bool_0: true);
		Launcher.smethod_178((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, _003CModule_003E.smethod_1<string>(4030028536u));
		Launcher.smethod_200(_WZwbftUaOkN5EVZdxYoqpzzYxlM, '*');
		Launcher.smethod_179((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, new Size(248, 16));
		Launcher.smethod_180((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, 1004);
		Launcher.smethod_201((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, (EventHandler)_pGJS20b3uuv0YddFhGnZNxHhamh);
		Launcher.smethod_202((Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM, new KeyEventHandler(_KDtCBmtyEv6Um9Zdggc2F9ULzhk));
		Launcher.smethod_73((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, Color.White);
		Launcher.smethod_198((TextBoxBase)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, (BorderStyle)0);
		Launcher.smethod_19((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, Launcher.smethod_174(_003CModule_003E.smethod_4<string>(3247974491u), 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Launcher.smethod_175((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, Color.Black);
		Launcher.smethod_176((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, new Point(198, 214));
		Launcher.smethod_199((TextBoxBase)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, bool_0: true);
		Launcher.smethod_178((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, _003CModule_003E.smethod_5<string>(740628415u));
		Launcher.smethod_179((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, new Size(248, 19));
		Launcher.smethod_180((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, 1003);
		Launcher.smethod_201((Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc, (EventHandler)_XvMNd1wrgfM1NtkhcqcbDM0RkeD);
		Launcher.smethod_73((Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, Color.Transparent);
		Launcher.smethod_192(Launcher.smethod_191((ButtonBase)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL), 0);
		Launcher.smethod_193((ButtonBase)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, (FlatStyle)0);
		Launcher.smethod_19((Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, Launcher.smethod_183(_003CModule_003E.smethod_3<string>(3847403769u), 12f, (FontStyle)1));
		Launcher.smethod_175((Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, Color.FromArgb(20, 32, 45));
		Launcher.smethod_194((ButtonBase)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._VhQWDo3xfJzvFPmuXToggjSGxtg);
		Launcher.smethod_195((ButtonBase)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, (ImeMode)0);
		Launcher.smethod_176((Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, new Point(264, 343));
		Launcher.smethod_177((Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, new Padding(0));
		Launcher.smethod_178((Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, _003CModule_003E.smethod_5<string>(83682922u));
		Launcher.smethod_179((Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, new Size(110, 60));
		Launcher.smethod_180((Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, 1003);
		Launcher.smethod_196((Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, bool_0: false);
		Launcher.smethod_197((ButtonBase)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, bool_0: false);
		Launcher.smethod_186((Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, (EventHandler)_5YnALCcYGPJaMJH5ZZmBRrLKfVQ);
		Launcher.smethod_188((Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, (EventHandler)_aDWdLECHeTPYOYVcC32O6tN8vUBA);
		Launcher.smethod_182((Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL, new MouseEventHandler(_5ykuKX49GRc59OkqjxniLAeWNJC));
		Launcher.smethod_73((Control)(object)_b85JSvMrG3n11jqeoaExP08P6PB, Color.Transparent);
		Launcher.smethod_192(Launcher.smethod_191((ButtonBase)(object)_b85JSvMrG3n11jqeoaExP08P6PB), 0);
		Launcher.smethod_193((ButtonBase)(object)_b85JSvMrG3n11jqeoaExP08P6PB, (FlatStyle)0);
		Launcher.smethod_19((Control)(object)_b85JSvMrG3n11jqeoaExP08P6PB, Launcher.smethod_183(_003CModule_003E.smethod_5<string>(2004876218u), 12f, (FontStyle)1));
		Launcher.smethod_175((Control)(object)_b85JSvMrG3n11jqeoaExP08P6PB, Color.FromArgb(20, 32, 45));
		Launcher.smethod_194((ButtonBase)(object)_b85JSvMrG3n11jqeoaExP08P6PB, (Image)Launcher.smethod_203((ResourceManager)resourceManager_, _003CModule_003E.smethod_3<string>(3576669269u)));
		Launcher.smethod_195((ButtonBase)(object)_b85JSvMrG3n11jqeoaExP08P6PB, (ImeMode)0);
		Launcher.smethod_176((Control)(object)_b85JSvMrG3n11jqeoaExP08P6PB, new Point(281, 431));
		Launcher.smethod_177((Control)(object)_b85JSvMrG3n11jqeoaExP08P6PB, new Padding(0));
		Launcher.smethod_178((Control)(object)_b85JSvMrG3n11jqeoaExP08P6PB, _003CModule_003E.smethod_2<string>(128372514u));
		Launcher.smethod_179((Control)(object)_b85JSvMrG3n11jqeoaExP08P6PB, new Size(78, 22));
		Launcher.smethod_180((Control)(object)_b85JSvMrG3n11jqeoaExP08P6PB, 1008);
		Launcher.smethod_196((Control)(object)_b85JSvMrG3n11jqeoaExP08P6PB, bool_0: false);
		Launcher.smethod_197((ButtonBase)(object)_b85JSvMrG3n11jqeoaExP08P6PB, bool_0: false);
		Launcher.smethod_186((Control)(object)_b85JSvMrG3n11jqeoaExP08P6PB, (EventHandler)_anFIUXbfiaiaUJhMhB2QnExXi5);
		Launcher.smethod_188((Control)(object)_b85JSvMrG3n11jqeoaExP08P6PB, (EventHandler)_aDWdLECHeTPYOYVcC32O6tN8vUBA);
		Launcher.smethod_182((Control)(object)_b85JSvMrG3n11jqeoaExP08P6PB, new MouseEventHandler(_5ykuKX49GRc59OkqjxniLAeWNJC));
		Launcher.smethod_73((Control)(object)_Yf4Br9INNMyzll1WDXNGSAznxBR, Color.Transparent);
		Launcher.smethod_205(Launcher.smethod_204((Control)(object)_Yf4Br9INNMyzll1WDXNGSAznxBR), (Control)(object)_ETXSN2WvPb5TIur9Xhq3nauc3hb);
		Launcher.smethod_205(Launcher.smethod_204((Control)(object)_Yf4Br9INNMyzll1WDXNGSAznxBR), (Control)(object)_mbsDcDn93HHjFNYjIiVkujw4hZdA);
		Launcher.smethod_205(Launcher.smethod_204((Control)(object)_Yf4Br9INNMyzll1WDXNGSAznxBR), (Control)(object)_zRZ60lgdqQASmrQNuIMUp6Kl0E);
		Launcher.smethod_19((Control)(object)_Yf4Br9INNMyzll1WDXNGSAznxBR, Launcher.smethod_183(_003CModule_003E.smethod_4<string>(3247974491u), 14.25f, (FontStyle)1));
		Launcher.smethod_176((Control)(object)_Yf4Br9INNMyzll1WDXNGSAznxBR, new Point(29, 545));
		Launcher.smethod_178((Control)(object)_Yf4Br9INNMyzll1WDXNGSAznxBR, _003CModule_003E.smethod_4<string>(103766739u));
		Launcher.smethod_179((Control)(object)_Yf4Br9INNMyzll1WDXNGSAznxBR, new Size(530, 53));
		Launcher.smethod_180((Control)(object)_Yf4Br9INNMyzll1WDXNGSAznxBR, 1006);
		Launcher.smethod_29((Control)(object)_Yf4Br9INNMyzll1WDXNGSAznxBR, bool_0: false);
		Launcher.smethod_73((Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS, Color.Transparent);
		Launcher.smethod_19((Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS, Launcher.smethod_174(_003CModule_003E.smethod_4<string>(3247974491u), 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Launcher.smethod_175((Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS, Color.Yellow);
		Launcher.smethod_176((Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS, new Point(175, 115));
		Launcher.smethod_178((Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS, _003CModule_003E.smethod_2<string>(2510515136u));
		Launcher.smethod_179((Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS, new Size(271, 21));
		Launcher.smethod_180((Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS, 101);
		Launcher.smethod_26((Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS, _003CModule_003E.smethod_3<string>(2106021871u));
		Launcher.smethod_29((Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS, bool_0: false);
		Launcher.smethod_73((Control)(object)_jQvQgS4regCy5A1D5MfBzvn9Joy, Launcher.smethod_206());
		Launcher.smethod_19((Control)(object)_jQvQgS4regCy5A1D5MfBzvn9Joy, Launcher.smethod_174(_003CModule_003E.smethod_2<string>(2979833084u), 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)162));
		Launcher.smethod_176((Control)(object)_jQvQgS4regCy5A1D5MfBzvn9Joy, new Point(41, 214));
		Launcher.smethod_178((Control)(object)_jQvQgS4regCy5A1D5MfBzvn9Joy, _003CModule_003E.smethod_2<string>(2492738695u));
		Launcher.smethod_179((Control)(object)_jQvQgS4regCy5A1D5MfBzvn9Joy, new Size(151, 19));
		Launcher.smethod_180((Control)(object)_jQvQgS4regCy5A1D5MfBzvn9Joy, 1009);
		Launcher.smethod_26((Control)(object)_jQvQgS4regCy5A1D5MfBzvn9Joy, _003CModule_003E.smethod_5<string>(1093922753u));
		Launcher.smethod_73((Control)(object)_H1kB4xR6rZWaBoRcAzW96XpRSe0, Launcher.smethod_206());
		Launcher.smethod_19((Control)(object)_H1kB4xR6rZWaBoRcAzW96XpRSe0, Launcher.smethod_174(_003CModule_003E.smethod_5<string>(3820991091u), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		Launcher.smethod_176((Control)(object)_H1kB4xR6rZWaBoRcAzW96XpRSe0, new Point(97, 302));
		Launcher.smethod_178((Control)(object)_H1kB4xR6rZWaBoRcAzW96XpRSe0, _003CModule_003E.smethod_1<string>(152536681u));
		Launcher.smethod_179((Control)(object)_H1kB4xR6rZWaBoRcAzW96XpRSe0, new Size(95, 18));
		Launcher.smethod_180((Control)(object)_H1kB4xR6rZWaBoRcAzW96XpRSe0, 1010);
		Launcher.smethod_26((Control)(object)_H1kB4xR6rZWaBoRcAzW96XpRSe0, _003CModule_003E.smethod_3<string>(2864078471u));
		Launcher.smethod_186((Control)(object)_H1kB4xR6rZWaBoRcAzW96XpRSe0, (EventHandler)_lKCe5uggi4LfI6AJU99B1PmChQV);
		Launcher.smethod_207((Control)(object)_floJR9K3dDRsUoJ7xNw2QunPrvg, bool_0: true);
		Launcher.smethod_73((Control)(object)_floJR9K3dDRsUoJ7xNw2QunPrvg, Launcher.smethod_206());
		Launcher.smethod_208((Control)(object)_floJR9K3dDRsUoJ7xNw2QunPrvg, (ImageLayout)2);
		Launcher.smethod_175((Control)(object)_floJR9K3dDRsUoJ7xNw2QunPrvg, Color.White);
		Launcher.smethod_176((Control)(object)_floJR9K3dDRsUoJ7xNw2QunPrvg, new Point(62, 343));
		Launcher.smethod_178((Control)(object)_floJR9K3dDRsUoJ7xNw2QunPrvg, _003CModule_003E.smethod_1<string>(364068705u));
		Launcher.smethod_179((Control)(object)_floJR9K3dDRsUoJ7xNw2QunPrvg, new Size(94, 14));
		Launcher.smethod_180((Control)(object)_floJR9K3dDRsUoJ7xNw2QunPrvg, 1011);
		Launcher.smethod_26((Control)(object)_floJR9K3dDRsUoJ7xNw2QunPrvg, _003CModule_003E.smethod_3<string>(1451918522u));
		Launcher.smethod_197((ButtonBase)(object)_floJR9K3dDRsUoJ7xNw2QunPrvg, bool_0: false);
		Launcher.smethod_209(_floJR9K3dDRsUoJ7xNw2QunPrvg, (EventHandler)_wqtPaBsoaapbFsACxf0YCSgFPlD);
		Launcher.smethod_210((ContainerControl)(object)this, (AutoScaleMode)0);
		Launcher.smethod_23((Control)(object)this, (Image)(object)_nxj6bGEF4p4pNxMDC7KxaJN4PAN._iNBgEHcvRo4yeahJ73MdbdCmVCd);
		Launcher.smethod_211((Form)(object)this, new Size(731, 482));
		Launcher.smethod_205(Launcher.smethod_14((Control)(object)this), (Control)(object)_floJR9K3dDRsUoJ7xNw2QunPrvg);
		Launcher.smethod_205(Launcher.smethod_14((Control)(object)this), (Control)(object)_H1kB4xR6rZWaBoRcAzW96XpRSe0);
		Launcher.smethod_205(Launcher.smethod_14((Control)(object)this), (Control)(object)_jQvQgS4regCy5A1D5MfBzvn9Joy);
		Launcher.smethod_205(Launcher.smethod_14((Control)(object)this), (Control)(object)_gmamJY8lwVcBO1R83D4oo5AnDaS);
		Launcher.smethod_205(Launcher.smethod_14((Control)(object)this), (Control)(object)_Yf4Br9INNMyzll1WDXNGSAznxBR);
		Launcher.smethod_205(Launcher.smethod_14((Control)(object)this), (Control)(object)_syRJKEl0Zo29MJCAALIFHwyuNzL);
		Launcher.smethod_205(Launcher.smethod_14((Control)(object)this), (Control)(object)_b85JSvMrG3n11jqeoaExP08P6PB);
		Launcher.smethod_205(Launcher.smethod_14((Control)(object)this), (Control)(object)_WZwbftUaOkN5EVZdxYoqpzzYxlM);
		Launcher.smethod_205(Launcher.smethod_14((Control)(object)this), (Control)(object)_gX17TpQ4KmPuqoLVq1aRPizgKsc);
		Launcher.smethod_205(Launcher.smethod_14((Control)(object)this), (Control)(object)_6pvQk0j5sE5FBQbDSeiw2ePkTAn);
		Launcher.smethod_205(Launcher.smethod_14((Control)(object)this), (Control)(object)_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D);
		Launcher.smethod_205(Launcher.smethod_14((Control)(object)this), (Control)(object)_tjjl483RAJdLFKvmQ4UTRigyQgw);
		Launcher.smethod_205(Launcher.smethod_14((Control)(object)this), (Control)(object)_wTSjSMMVFgw0QS5tNzS67z8pnQA);
		Launcher.smethod_205(Launcher.smethod_14((Control)(object)this), (Control)(object)_QbRDXY9MdrbjPbIoQbBO3Qyj9Vc);
		Launcher.smethod_205(Launcher.smethod_14((Control)(object)this), (Control)(object)_IXyaILfGfoRU7y19VCVwEVnpWRi);
		Launcher.smethod_19((Control)(object)this, Launcher.smethod_212(_003CModule_003E.smethod_3<string>(4226432069u), 5f));
		Launcher.smethod_175((Control)(object)this, Color.Transparent);
		Launcher.smethod_213((Form)(object)this, (FormBorderStyle)0);
		Launcher.smethod_214((Form)(object)this, (Icon)Launcher.smethod_203((ResourceManager)resourceManager_, _003CModule_003E.smethod_3<string>(1560212322u)));
		Launcher.smethod_215((Form)(object)this, new Padding(2));
		Launcher.smethod_216((Form)(object)this, bool_0: false);
		Launcher.smethod_217((Form)(object)this, bool_0: false);
		Launcher.smethod_218((Control)(object)this, _003CModule_003E.smethod_2<string>(3847363216u));
		Launcher.smethod_219((Form)(object)this, (FormStartPosition)1);
		Launcher.smethod_220((Form)(object)this, new FormClosingEventHandler(_YdaMfAPg5D7ba6VPuQX7zVRdIpb));
		Launcher.smethod_221((Form)(object)this, (EventHandler)Launcher_Load);
		Launcher.smethod_222((Control)(object)this, new MouseEventHandler(_ZNJz10pBEL6IevvOfdRU4ObGE9n));
		Launcher.smethod_223((Control)(object)this, new MouseEventHandler(_f2yrVPecFpla0QOu49b8QuDjHFq));
		Launcher.smethod_224((ISupportInitialize)_tjjl483RAJdLFKvmQ4UTRigyQgw);
		Launcher.smethod_224((ISupportInitialize)_zRZ60lgdqQASmrQNuIMUp6Kl0E);
		Launcher.smethod_224((ISupportInitialize)_8LPD4rh6TaT5k8Q41ZsQtMQ3m9D);
		Launcher.smethod_225((Control)(object)_Yf4Br9INNMyzll1WDXNGSAznxBR, bool_0: false);
		Launcher.smethod_226((Control)(object)this, bool_0: false);
		Launcher.smethod_227((Control)(object)this);
	}

	static Process[] smethod_0()
	{
		return Process.GetProcesses();
	}

	static WebClient smethod_1()
	{
		return new WebClient();
	}

	static Computer smethod_2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Computer();
	}

	static void smethod_3(WebClient webClient_0, AsyncCompletedEventHandler asyncCompletedEventHandler_0)
	{
		webClient_0.DownloadFileCompleted += asyncCompletedEventHandler_0;
	}

	static void smethod_4(WebClient webClient_0, DownloadProgressChangedEventHandler downloadProgressChangedEventHandler_0)
	{
		webClient_0.DownloadProgressChanged += downloadProgressChangedEventHandler_0;
	}

	static string smethod_5()
	{
		return Application.get_StartupPath();
	}

	static string smethod_6(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static StreamWriter smethod_7(string string_0, bool bool_0)
	{
		return new StreamWriter(string_0, bool_0);
	}

	static void smethod_8(TextWriter textWriter_0, string string_0)
	{
		textWriter_0.WriteLine(string_0);
	}

	static void smethod_9(TextWriter textWriter_0)
	{
		textWriter_0.Flush();
	}

	static void smethod_10(TextWriter textWriter_0)
	{
		textWriter_0.Close();
	}

	static PrivateFontCollection smethod_11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PrivateFontCollection();
	}

	static string smethod_12()
	{
		return Directory.GetCurrentDirectory();
	}

	static void smethod_13(PrivateFontCollection privateFontCollection_0, string string_0)
	{
		privateFontCollection_0.AddFontFile(string_0);
	}

	static ControlCollection smethod_14(Control control_0)
	{
		return control_0.get_Controls();
	}

	static IEnumerator smethod_15(ArrangedElementCollection arrangedElementCollection_0)
	{
		return arrangedElementCollection_0.GetEnumerator();
	}

	static object smethod_16(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	static FontFamily[] smethod_17(FontCollection fontCollection_0)
	{
		return fontCollection_0.get_Families();
	}

	static Font smethod_18(FontFamily fontFamily_0, float float_0, FontStyle fontStyle_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return new Font(fontFamily_0, float_0, fontStyle_0);
	}

	static void smethod_19(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static bool smethod_20(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	static void smethod_21(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static CookieContainer smethod_22()
	{
		return new CookieContainer();
	}

	static void smethod_23(Control control_0, Image image_0)
	{
		control_0.set_BackgroundImage(image_0);
	}

	static void smethod_24(Form form_0, bool bool_0)
	{
		form_0.set_KeyPreview(bool_0);
	}

	static string smethod_25(WebClient webClient_0, string string_0)
	{
		return webClient_0.DownloadString(string_0);
	}

	static void smethod_26(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_27(Form form_0, FormWindowState formWindowState_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_WindowState(formWindowState_0);
	}

	static void smethod_28(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static void smethod_29(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static string smethod_30(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static string smethod_31(string string_0)
	{
		return File.ReadAllText(string_0);
	}

	static string smethod_32(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	static void smethod_33(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static FileSystemProxy smethod_34(ServerComputer serverComputer_0)
	{
		return serverComputer_0.get_FileSystem();
	}

	static bool smethod_35(FileSystemProxy fileSystemProxy_0, string string_0)
	{
		return fileSystemProxy_0.DirectoryExists(string_0);
	}

	static void smethod_36(FileSystemProxy fileSystemProxy_0, string string_0, DeleteDirectoryOption deleteDirectoryOption_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		fileSystemProxy_0.DeleteDirectory(string_0, deleteDirectoryOption_0);
	}

	static bool smethod_37(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static void smethod_38(string string_0, string string_1)
	{
		File.WriteAllText(string_0, string_1);
	}

	static void smethod_39(Control control_0, int int_0)
	{
		control_0.set_Width(int_0);
	}

	static void smethod_40(Control control_0)
	{
		control_0.Hide();
	}

	static DialogResult smethod_41(string string_0, string string_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1);
	}

	static bool smethod_42(string string_0)
	{
		return File.Exists(string_0);
	}

	static Process smethod_43(string string_0)
	{
		return Process.Start(string_0);
	}

	static void smethod_44(Form form_0)
	{
		form_0.Close();
	}

	static DialogResult smethod_45(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	static void smethod_46()
	{
		Application.Exit();
	}

	static RegistryKey smethod_47(RegistryKey registryKey_0, string string_0, bool bool_0)
	{
		return registryKey_0.OpenSubKey(string_0, bool_0);
	}

	static object smethod_48(RegistryKey registryKey_0, string string_0, object object_0)
	{
		return registryKey_0.GetValue(string_0, object_0);
	}

	static string smethod_49(object object_0)
	{
		return object_0.ToString();
	}

	static FileStream smethod_50(string string_0, FileMode fileMode_0, FileAccess fileAccess_0)
	{
		return new FileStream(string_0, fileMode_0, fileAccess_0);
	}

	static StreamReader smethod_51(Stream stream_0)
	{
		return new StreamReader(stream_0);
	}

	static string smethod_52(TextReader textReader_0)
	{
		return textReader_0.ReadLine();
	}

	static bool smethod_53(string string_0, string string_1)
	{
		return string_0 != string_1;
	}

	static void smethod_54(int int_0)
	{
		Environment.Exit(int_0);
	}

	static void smethod_55(TextReader textReader_0)
	{
		textReader_0.Close();
	}

	static void smethod_56(Stream stream_0)
	{
		stream_0.Close();
	}

	static RegistryKey smethod_57(RegistryKey registryKey_0, string string_0)
	{
		return registryKey_0.OpenSubKey(string_0);
	}

	static RegistryKey smethod_58(RegistryKey registryKey_0, string string_0)
	{
		return registryKey_0.CreateSubKey(string_0);
	}

	static string smethod_59(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static void smethod_60(RegistryKey registryKey_0, string string_0, object object_0)
	{
		registryKey_0.SetValue(string_0, object_0);
	}

	static void smethod_61(RegistryKey registryKey_0)
	{
		registryKey_0.Close();
	}

	static StreamWriter smethod_62(Stream stream_0)
	{
		return new StreamWriter(stream_0);
	}

	static void smethod_63(TextWriter textWriter_0, string string_0)
	{
		textWriter_0.Write(string_0);
	}

	static string smethod_64(char[] char_0)
	{
		return new string(char_0);
	}

	static MouseButtons smethod_65()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Control.get_MouseButtons();
	}

	static int smethod_66(Control control_0)
	{
		return control_0.get_Left();
	}

	static Point smethod_67()
	{
		return Control.get_MousePosition();
	}

	static int smethod_68(Control control_0)
	{
		return control_0.get_Top();
	}

	static void smethod_69(Control control_0, int int_0)
	{
		control_0.set_Left(int_0);
	}

	static void smethod_70(Control control_0, int int_0)
	{
		control_0.set_Top(int_0);
	}

	static string smethod_71()
	{
		return Application.get_ProductName();
	}

	static void smethod_72(PictureBox pictureBox_0, Image image_0)
	{
		pictureBox_0.set_Image(image_0);
	}

	static void smethod_73(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static DialogResult smethod_74(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0, MessageBoxDefaultButton messageBoxDefaultButton_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, messageBoxDefaultButton_0);
	}

	static void smethod_75(Control control_0)
	{
		control_0.Show();
	}

	static void smethod_76(Control control_0)
	{
		control_0.Hide();
	}

	static XmlDocument smethod_77()
	{
		return new XmlDocument();
	}

	static FileStream smethod_78(string string_0, FileMode fileMode_0)
	{
		return new FileStream(string_0, fileMode_0);
	}

	static long smethod_79(Stream stream_0)
	{
		return stream_0.Length;
	}

	static void smethod_80(XmlDocument xmlDocument_0, Stream stream_0)
	{
		xmlDocument_0.Load(stream_0);
	}

	static XmlNode smethod_81(XmlNode xmlNode_0)
	{
		return xmlNode_0.FirstChild;
	}

	static string smethod_82(XmlNode xmlNode_0)
	{
		return xmlNode_0.Name;
	}

	bool method_0(string string_0)
	{
		return ((string)this).Equals(string_0);
	}

	static XmlAttributeCollection smethod_83(XmlNode xmlNode_0)
	{
		return xmlNode_0.Attributes;
	}

	static XmlNode smethod_84(XmlNamedNodeMap xmlNamedNodeMap_0, string string_0)
	{
		return xmlNamedNodeMap_0.GetNamedItem(string_0);
	}

	static string smethod_85(XmlNode xmlNode_0)
	{
		return xmlNode_0.Value;
	}

	static XMLModel smethod_86(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new XMLModel(string_0);
	}

	static XmlNode smethod_87(XmlNode xmlNode_0)
	{
		return xmlNode_0.NextSibling;
	}

	static DialogResult smethod_88(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static void smethod_89(Stream stream_0)
	{
		stream_0.Dispose();
	}

	static void smethod_90(string string_0)
	{
		File.Delete(string_0);
	}

	static Exception smethod_91(AsyncCompletedEventArgs asyncCompletedEventArgs_0)
	{
		return asyncCompletedEventArgs_0.Error;
	}

	static string smethod_92(object[] object_0)
	{
		return string.Concat(object_0);
	}

	static void smethod_93(Timer timer_0)
	{
		timer_0.Start();
	}

	static void smethod_94(string string_0, bool bool_0)
	{
		Directory.Delete(string_0, bool_0);
	}

	static long smethod_95(DownloadProgressChangedEventArgs downloadProgressChangedEventArgs_0)
	{
		return downloadProgressChangedEventArgs_0.BytesReceived;
	}

	static long smethod_96(DownloadProgressChangedEventArgs downloadProgressChangedEventArgs_0)
	{
		return downloadProgressChangedEventArgs_0.TotalBytesToReceive;
	}

	static long smethod_97(ZipProgressEventArgs zipProgressEventArgs_0)
	{
		return zipProgressEventArgs_0.get_TotalBytesToTransfer();
	}

	static long smethod_98(ZipProgressEventArgs zipProgressEventArgs_0)
	{
		return zipProgressEventArgs_0.get_BytesTransferred();
	}

	static void smethod_99(Control control_0)
	{
		control_0.Refresh();
	}

	static void smethod_100(Control control_0)
	{
		control_0.Update();
	}

	static ZipFile smethod_101(string string_0)
	{
		return ZipFile.Read(string_0);
	}

	static void smethod_102(ZipFile zipFile_0, EventHandler<ExtractProgressEventArgs> eventHandler_0)
	{
		zipFile_0.add_ExtractProgress(eventHandler_0);
	}

	static IEnumerator<ZipEntry> smethod_103(ZipFile zipFile_0)
	{
		return zipFile_0.GetEnumerator();
	}

	static bool smethod_104(ZipEntry zipEntry_0)
	{
		return zipEntry_0.get_IsDirectory();
	}

	static string smethod_105(ZipEntry zipEntry_0)
	{
		return zipEntry_0.get_FileName();
	}

	static bool smethod_106(string string_0, string string_1)
	{
		return string_0.Contains(string_1);
	}

	static int smethod_107(string string_0, string string_1)
	{
		return string_0.LastIndexOf(string_1);
	}

	static string smethod_108(string string_0, int int_0)
	{
		return string_0.Substring(int_0);
	}

	static void smethod_109(Control control_0)
	{
		control_0.Update();
	}

	static void smethod_110(ZipEntry zipEntry_0, string string_0, ExtractExistingFileAction extractExistingFileAction_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		zipEntry_0.Extract(string_0, extractExistingFileAction_0);
	}

	static void smethod_111(Timer timer_0)
	{
		timer_0.Stop();
	}

	static void smethod_112(FileSystemProxy fileSystemProxy_0, string string_0)
	{
		fileSystemProxy_0.CreateDirectory(string_0);
	}

	static Uri smethod_113(string string_0)
	{
		return new Uri(string_0);
	}

	static void smethod_114(WebClient webClient_0, Uri uri_0, string string_0)
	{
		webClient_0.DownloadFileAsync(uri_0, string_0);
	}

	static Process smethod_115(string string_0, string string_1)
	{
		return Process.Start(string_0, string_1);
	}

	static string smethod_116(string string_0, int int_0, int int_1)
	{
		return string_0.Substring(int_0, int_1);
	}

	static string[] smethod_117(string string_0, string string_1)
	{
		return Directory.GetFiles(string_0, string_1);
	}

	static string[] smethod_118(string string_0)
	{
		return Directory.GetDirectories(string_0);
	}

	static NetworkInterface[] smethod_119()
	{
		return NetworkInterface.GetAllNetworkInterfaces();
	}

	static PhysicalAddress smethod_120(NetworkInterface networkInterface_0)
	{
		return networkInterface_0.GetPhysicalAddress();
	}

	static long smethod_121(NetworkInterface networkInterface_0)
	{
		return networkInterface_0.Speed;
	}

	static bool smethod_122(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static int smethod_123(string string_0)
	{
		return string_0.Length;
	}

	static ManagementObjectSearcher smethod_124(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new ManagementObjectSearcher(string_0);
	}

	static ManagementObjectCollection smethod_125(ManagementObjectSearcher managementObjectSearcher_0)
	{
		return managementObjectSearcher_0.Get();
	}

	static ManagementObjectEnumerator smethod_126(ManagementObjectCollection managementObjectCollection_0)
	{
		return managementObjectCollection_0.GetEnumerator();
	}

	static ManagementBaseObject smethod_127(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		return managementObjectEnumerator_0.get_Current();
	}

	static object smethod_128(ManagementBaseObject managementBaseObject_0, string string_0)
	{
		return managementBaseObject_0.GetPropertyValue(string_0);
	}

	static bool smethod_129(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		return managementObjectEnumerator_0.MoveNext();
	}

	static object smethod_130(ManagementBaseObject managementBaseObject_0, string string_0)
	{
		return managementBaseObject_0.get_Item(string_0);
	}

	static string smethod_131(Control control_0)
	{
		return control_0.get_Text();
	}

	static bool smethod_132(Control control_0)
	{
		return control_0.Focus();
	}

	static WebRequest smethod_133(string string_0)
	{
		return WebRequest.Create(string_0);
	}

	static void smethod_134(HttpWebRequest httpWebRequest_0, CookieContainer cookieContainer_0)
	{
		httpWebRequest_0.CookieContainer = cookieContainer_0;
	}

	static Process smethod_135()
	{
		return Process.GetCurrentProcess();
	}

	static string smethod_136(Process process_0)
	{
		return process_0.ProcessName;
	}

	static Encoding smethod_137()
	{
		return Encoding.UTF8;
	}

	static byte[] smethod_138(Encoding encoding_0, string string_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	static void smethod_139(WebRequest webRequest_0, string string_0)
	{
		webRequest_0.Method = string_0;
	}

	static void smethod_140(WebRequest webRequest_0, string string_0)
	{
		webRequest_0.ContentType = string_0;
	}

	static void smethod_141(WebRequest webRequest_0, long long_0)
	{
		webRequest_0.ContentLength = long_0;
	}

	static Stream smethod_142(WebRequest webRequest_0)
	{
		return webRequest_0.GetRequestStream();
	}

	static void smethod_143(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		stream_0.Write(byte_0, int_0, int_1);
	}

	static WebResponse smethod_144(WebRequest webRequest_0)
	{
		return webRequest_0.GetResponse();
	}

	static Stream smethod_145(WebResponse webResponse_0)
	{
		return webResponse_0.GetResponseStream();
	}

	static string smethod_146(TextReader textReader_0)
	{
		return textReader_0.ReadToEnd();
	}

	static MD5 smethod_147()
	{
		return MD5.Create();
	}

	static FileStream smethod_148(string string_0)
	{
		return File.OpenRead(string_0);
	}

	static byte[] smethod_149(HashAlgorithm hashAlgorithm_0, Stream stream_0)
	{
		return hashAlgorithm_0.ComputeHash(stream_0);
	}

	static string smethod_150(byte[] byte_0)
	{
		return BitConverter.ToString(byte_0);
	}

	static string smethod_151(string string_0, string string_1, string string_2)
	{
		return string_0.Replace(string_1, string_2);
	}

	static Keys smethod_152(KeyEventArgs keyEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return keyEventArgs_0.get_KeyCode();
	}

	static void smethod_153(Button button_0)
	{
		button_0.PerformClick();
	}

	static void smethod_154(TextBoxBase textBoxBase_0, int int_0)
	{
		textBoxBase_0.set_MaxLength(int_0);
	}

	static void smethod_155(CheckBox checkBox_0, bool bool_0)
	{
		checkBox_0.set_Checked(bool_0);
	}

	static bool smethod_156(CheckBox checkBox_0)
	{
		return checkBox_0.get_Checked();
	}

	static string smethod_157(string string_0)
	{
		return string_0.Trim();
	}

	static void smethod_158(SettingsBase settingsBase_0)
	{
		settingsBase_0.Save();
	}

	static EventArgs smethod_159()
	{
		return new EventArgs();
	}

	static Container smethod_160()
	{
		return new Container();
	}

	static Type smethod_161(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ComponentResourceManager smethod_162(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	static Label smethod_163()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static PictureBox smethod_164()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static Timer smethod_165(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_0);
	}

	static BackgroundWorker smethod_166()
	{
		return new BackgroundWorker();
	}

	static Button smethod_167()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static TextBox smethod_168()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Panel smethod_169()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Panel();
	}

	static CheckBox smethod_170()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new CheckBox();
	}

	static void smethod_171(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_172(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_173(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static Font smethod_174(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_175(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_176(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_177(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_178(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_179(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_180(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_181(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.add_MouseDown(mouseEventHandler_0);
	}

	static void smethod_182(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.add_MouseMove(mouseEventHandler_0);
	}

	static Font smethod_183(string string_0, float float_0, FontStyle fontStyle_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0);
	}

	static void smethod_184(PictureBox pictureBox_0, int int_0)
	{
		pictureBox_0.set_TabIndex(int_0);
	}

	static void smethod_185(PictureBox pictureBox_0, bool bool_0)
	{
		pictureBox_0.set_TabStop(bool_0);
	}

	static void smethod_186(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_187(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_MouseEnter(eventHandler_0);
	}

	static void smethod_188(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_MouseLeave(eventHandler_0);
	}

	static void smethod_189(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.add_Tick(eventHandler_0);
	}

	static void smethod_190(BackgroundWorker backgroundWorker_0, DoWorkEventHandler doWorkEventHandler_0)
	{
		backgroundWorker_0.DoWork += doWorkEventHandler_0;
	}

	static FlatButtonAppearance smethod_191(ButtonBase buttonBase_0)
	{
		return buttonBase_0.get_FlatAppearance();
	}

	static void smethod_192(FlatButtonAppearance flatButtonAppearance_0, int int_0)
	{
		flatButtonAppearance_0.set_BorderSize(int_0);
	}

	static void smethod_193(ButtonBase buttonBase_0, FlatStyle flatStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		buttonBase_0.set_FlatStyle(flatStyle_0);
	}

	static void smethod_194(ButtonBase buttonBase_0, Image image_0)
	{
		buttonBase_0.set_Image(image_0);
	}

	static void smethod_195(ButtonBase buttonBase_0, ImeMode imeMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		buttonBase_0.set_ImeMode(imeMode_0);
	}

	static void smethod_196(Control control_0, bool bool_0)
	{
		control_0.set_TabStop(bool_0);
	}

	static void smethod_197(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_198(TextBoxBase textBoxBase_0, BorderStyle borderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		textBoxBase_0.set_BorderStyle(borderStyle_0);
	}

	static void smethod_199(TextBoxBase textBoxBase_0, bool bool_0)
	{
		textBoxBase_0.set_Multiline(bool_0);
	}

	static void smethod_200(TextBox textBox_0, char char_0)
	{
		textBox_0.set_PasswordChar(char_0);
	}

	static void smethod_201(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_TextChanged(eventHandler_0);
	}

	static void smethod_202(Control control_0, KeyEventHandler keyEventHandler_0)
	{
		control_0.add_KeyDown(keyEventHandler_0);
	}

	static object smethod_203(ResourceManager resourceManager_0, string string_0)
	{
		return resourceManager_0.GetObject(string_0);
	}

	static ControlCollection smethod_204(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_205(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static Color smethod_206()
	{
		return SystemColors.ActiveCaptionText;
	}

	static void smethod_207(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static void smethod_208(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_209(CheckBox checkBox_0, EventHandler eventHandler_0)
	{
		checkBox_0.add_CheckedChanged(eventHandler_0);
	}

	static void smethod_210(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_211(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static Font smethod_212(string string_0, float float_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Font(string_0, float_0);
	}

	static void smethod_213(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_214(Form form_0, Icon icon_0)
	{
		form_0.set_Icon(icon_0);
	}

	static void smethod_215(Form form_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_Margin(padding_0);
	}

	static void smethod_216(Form form_0, bool bool_0)
	{
		form_0.set_MaximizeBox(bool_0);
	}

	static void smethod_217(Form form_0, bool bool_0)
	{
		form_0.set_MinimizeBox(bool_0);
	}

	static void smethod_218(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_219(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_220(Form form_0, FormClosingEventHandler formClosingEventHandler_0)
	{
		form_0.add_FormClosing(formClosingEventHandler_0);
	}

	static void smethod_221(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_222(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.add_MouseDown(mouseEventHandler_0);
	}

	static void smethod_223(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.add_MouseMove(mouseEventHandler_0);
	}

	static void smethod_224(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_225(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_226(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_227(Control control_0)
	{
		control_0.PerformLayout();
	}

	static Random smethod_228()
	{
		return new Random();
	}
}
