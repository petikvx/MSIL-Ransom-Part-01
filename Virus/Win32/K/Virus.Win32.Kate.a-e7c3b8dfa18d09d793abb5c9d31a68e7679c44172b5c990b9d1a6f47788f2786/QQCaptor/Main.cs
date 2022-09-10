using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using AxWMPLib;
using Helper;
using QQCaptor.Tools;
using QQCaptor.Users;

namespace QQCaptor;

public class Main : Form
{
	public enum KeyModifiers
	{
		None = 0,
		Alt = 1,
		Control = 2,
		Shift = 4,
		Windows = 8
	}

	private delegate void aa(string s);

	private class ThreadProcPamaDxh
	{
		public int iIndex;

		public User ur;

		public bool bThread;
	}

	private delegate void aaxx(int iIndex, int Column, string s);

	private class ThreadProcPamaCity
	{
		public string province;

		public string city;

		public string sSex;

		public string sAge;

		public string sOnline;
	}

	private delegate void addxx(QQCityInfo qc);

	private string m_sVer = "2.1.0";

	private Thread m_tver;

	public HttpHelper m_hh = new HttpHelper();

	private Collection<User> m_UserList = new Collection<User>();

	private Collection<ElapsedEventHandler> m_EventJiaoBenList = new Collection<ElapsedEventHandler>();

	private Collection<JiaoBenInfo> m_JiaoBenInfoList = new Collection<JiaoBenInfo>();

	private Collection<SlaveInfo> m_SlaveInfoList = new Collection<SlaveInfo>();

	private Collection<SlaveInfo> m_SlaveInfoListQC = new Collection<SlaveInfo>();

	private Collection<DhUserInfo> m_DhUserList = new Collection<DhUserInfo>();

	private Collection<DhUserInfo> m_DhTsUserList = new Collection<DhUserInfo>();

	private Collection<DhUserInfo> m_BuyUserList = new Collection<DhUserInfo>();

	private Collection<JbUserInfo> m_JbUserList = new Collection<JbUserInfo>();

	private Collection<JbUserInfo> m_RunJbUserList = new Collection<JbUserInfo>();

	private Collection<Thread> m_ThreadDxhList = new Collection<Thread>();

	private Collection<Thread> m_ThreadRzList = new Collection<Thread>();

	private Thread m_tx;

	private Collection<Thread> m_ThreadFxList = new Collection<Thread>();

	private Thread m_fx;

	private Collection<Thread> m_ThreadZjList = new Collection<Thread>();

	private Thread m_zj;

	private Thread m_city;

	private Thread m_jubao;

	private User m_userJc;

	private Thread m_jc;

	private Collection<string> m_sJcQQNumList = new Collection<string>();

	private User m_userJb;

	private User m_strUserDingShiMai;

	private User m_strUserQiangGou;

	private User m_user;

	private static User m_user_current;

	private FilePro fp = new FilePro();

	private string m_strConfigPath;

	private string m_strLogPath;

	private string m_strFriendPath;

	private string m_strJiaoBenPath;

	private SymmetricMethod sm = new SymmetricMethod();

	private CarType ct = new CarType();

	private CityType m_ctt = new CityType();

	private HaoYouMaiMaiType hymmt = new HaoYouMaiMaiType();

	public int iReCount = 2;

	public int iListFocus;

	private bool m_bGoBack;

	private bool m_bSaveQQNum = true;

	private bool m_bNormal;

	private bool m_bPark = true;

	private bool m_bBuyFriend;

	private bool m_bQuery4;

	private bool m_bQuery5;

	private bool m_bQuery6;

	private bool m_bLoginPark = true;

	private bool m_bLoginFriend = true;

	private bool m_bJb = true;

	private bool m_bCancel = true;

	private bool m_bShowAllTime;

	private string m_strTiTiaoLiuYan = "";

	private string sQQNumExcess;

	private string sQueryQQBuyFriendMe;

	private string sQueryQQBuyFriendMaster;

	private string sBuyFriendMe;

	private string sBuyFriendMaster;

	private string m_sQueryQQZh;

	private string m_sQueryQQJb;

	private long m_sMyBuyMoney;

	private long m_sMyCapital;

	private long m_sMyMoney;

	private System.Timers.Timer timersTimer = new System.Timers.Timer();

	private System.Timers.Timer timersTimerJiaoBen = new System.Timers.Timer();

	private System.Timers.Timer timersTimerHaoYou = new System.Timers.Timer();

	private System.Timers.Timer timersTimerQiangGou = new System.Timers.Timer();

	private ListViewColumnSorter lvwColumnSorter;

	private ListViewColumnSorter lvwColumnSorterCityList;

	private bool m_bAddTieTiao;

	private long m_lSumMoney;

	private long m_iCurrentMoney;

	private long m_iYinli;

	private long m_iTietiao;

	private long m_iSumMiniteDoMoney;

	private long m_iSumMiniteDoTieTiao;

	private string m_sDoCarid;

	private int m_iDoCarCode;

	private string m_sBuyCarCode;

	private bool m_bKeyShowWindow = true;

	private bool bJundao = true;

	private long m_iPaiHangPageNo = 1L;

	private int m_JiaoBenUseriIndex = -1;

	private string m_sJiaoBenQQNum = "";

	private FileJiaoBen fjb = new FileJiaoBen();

	private string m_sJuBaoQQNum = "";

	private int m_JuBaoUseriIndex = -1;

	private bool m_bLianXu;

	private bool m_bZhiDuiDangQian;

	private bool m_bZhiDuiDangQianRun;

	private long m_iQueryPege = 1000L;

	private bool m_bShowBMD;

	private bool m_bLoginZhzx = true;

	private FriendBuyInfo m_fb1;

	private bool m_bDxhzx1 = true;

	private bool m_bDxhzx2 = true;

	private bool m_bDxhzx3 = true;

	private bool m_bDxhzx4 = true;

	private bool m_bDxhzx5 = true;

	private bool m_bDxhzx6 = true;

	private bool m_bDxhzx7 = true;

	private bool m_bDxhzx8 = true;

	private bool m_bDxhzx9 = true;

	private bool m_bDxhzx10 = true;

	private bool m_bDxhzx11 = true;

	private string m_sTieTiaoLiuYan = "yxz123.com";

	private string m_sSlaveChuoHao = "yxz123.com";

	private string m_sFileDhUserPath = "";

	private string m_sFileBuyUserPath = "";

	private string m_sFileJbUserPath = "";

	private string m_sExeDir = "";

	private Collection<QQPhotoInfo> m_qplist;

	private int m_curr_qp_index = -1;

	private Collection<QQRiZhiInfo> m_rzlist;

	private string m_sQueryRzQQNum = "";

	private int m_iQQZoneIndex = -1;

	private int m_iQiangGou = 5;

	private string m_sPKQQNum = "";

	private string m_sBuKuaiPass = "";

	private bool m_bSuoDing;

	private BuKuaiMiMaInput m_bm;

	private int m_iJuBaoTime = 1000;

	private int m_iCiShu = 100;

	public DateTime m_preTime = default(DateTime);

	public string m_strPreQQnum = "";

	private IContainer components;

	private MenuStrip menuStrip1;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem toolStripMenuItem_5;

	private ToolStripMenuItem toolStripMenuItem_6;

	private Label label1;

	private Label label2;

	private TextBox textQQPass;

	private Button buttonDelete;

	private ComboBox comboQQNum;

	private CheckBox checkMark;

	private Label label3;

	private TextBox textValidate;

	private PictureBox pictureBoxValidate;

	private Button buttonLogin;

	private ListView listUser;

	private TabControl tabControl1;

	private TabPage tabPageFriendBuy;

	private ToolStrip toolStrip1;

	private ToolStripButton toolStripButton_0;

	private ColumnHeader columnHeader25;

	private ColumnHeader columnHeader26;

	private StatusStrip statusStrip1;

	private ToolStripStatusLabel toolStripStatusLabel1;

	private TabPage tabPageQueryFriend;

	private ToolTip toolTipAll;

	private NotifyIcon notifyIcon1;

	private ContextMenuStrip MenuNotify;

	private ToolStripMenuItem toolStripMenuItem_7;

	private ToolStripMenuItem toolStripMenuItem_8;

	private ToolStripButton toolStripButton_1;

	private ToolStripButton toolStripButton_2;

	private ToolStripMenuItem toolStripMenuItem_9;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem toolStripMenuItem_10;

	private ToolStripMenuItem toolStripMenuItem_11;

	private ToolStripMenuItem toolStripMenuItem_12;

	private ToolStripMenuItem toolStripMenuItem_13;

	private ToolStripMenuItem toolStripMenuItem_14;

	private ToolStripMenuItem toolStripMenuItem_15;

	private ToolStripButton toolStripButtonHelp;

	private Label label14;

	private TextBox textBox1;

	private Button buttonQueryQQ;

	private TabControl tabControl2;

	private TabPage tabPageJinBen;

	private TabPage tabPageQueryPark;

	private TabPage tabPageQueryQQBuyFriend;

	private ListBox listBox1;

	private Label label17;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private Label label18;

	private ListBox listBox2;

	private ToolStripMenuItem toolStripMenuItem_16;

	private ToolStripSeparator toolStripMenuItem1;

	private ListView listSlave;

	private ColumnHeader columnHeader40;

	private ColumnHeader columnHeader41;

	private ColumnHeader columnHeader42;

	private ColumnHeader columnHeader43;

	private ColumnHeader columnHeader44;

	private ColumnHeader columnHeader45;

	private ColumnHeader columnHeader46;

	private ColumnHeader columnHeader47;

	private ColumnHeader columnHeader48;

	private ListView listQueryCars;

	private ColumnHeader columnHeader49;

	private ColumnHeader columnHeader50;

	private ColumnHeader columnHeader51;

	private ColumnHeader columnHeader52;

	private ColumnHeader columnHeader53;

	private ColumnHeader columnHeader54;

	private ColumnHeader columnHeader55;

	private ColumnHeader columnHeader56;

	private ColumnHeader columnHeader57;

	private ListView listQueryPark;

	private ColumnHeader columnHeader58;

	private ColumnHeader columnHeader59;

	private ColumnHeader columnHeader60;

	private ColumnHeader columnHeader61;

	private ColumnHeader columnHeader62;

	private ColumnHeader columnHeader63;

	private ColumnHeader columnHeader64;

	private ColumnHeader columnHeader65;

	private Label label19;

	private Label label20;

	private Label label21;

	private Label label22;

	private Label label23;

	private Label label24;

	private CheckBox checkBox3;

	private CheckBox checkBox2;

	private CheckBox checkBox1;

	private ColumnHeader columnHeader66;

	private ToolStripMenuItem toolStripMenuItem_17;

	private Label label27;

	private ListBox listBox5;

	private Label label25;

	private ListBox listBox3;

	private Label label26;

	private ListBox listBox4;

	private TabPage tabPage1;

	private Label label28;

	private Label label29;

	private Label label30;

	private Button button8;

	private Label label31;

	private ComboBox comboBox1;

	private Label label32;

	private CheckBox checkBox4;

	private Button button9;

	private Button button10;

	private Button button11;

	private Button button12;

	private Button button13;

	private Button button14;

	private Button button15;

	private Label label33;

	private Button button16;

	private ListView listView1;

	private ColumnHeader columnHeader67;

	private ColumnHeader columnHeader68;

	private ColumnHeader columnHeader69;

	private ColumnHeader columnHeader70;

	private ColumnHeader columnHeader71;

	private ColumnHeader columnHeader72;

	private ColumnHeader columnHeader73;

	private Label label34;

	private Label label35;

	private Label label36;

	private Button button17;

	private ListView listView2;

	private ColumnHeader columnHeader74;

	private ColumnHeader columnHeader75;

	private ColumnHeader columnHeader76;

	private ColumnHeader columnHeader77;

	private ColumnHeader columnHeader78;

	private ColumnHeader columnHeader79;

	private ColumnHeader columnHeader80;

	private ColumnHeader columnHeader81;

	private ColumnHeader columnHeader82;

	private Button button18;

	private ListView listView3;

	private ColumnHeader columnHeader83;

	private ColumnHeader columnHeader84;

	private ColumnHeader columnHeader85;

	private ColumnHeader columnHeader86;

	private ColumnHeader columnHeader87;

	private ColumnHeader columnHeader88;

	private ColumnHeader columnHeader89;

	private ColumnHeader columnHeader90;

	private TabPage tabPage2;

	private Button button19;

	private Button button20;

	private Label label37;

	private ListView listView4;

	private ColumnHeader columnHeader91;

	private ColumnHeader columnHeader92;

	private ColumnHeader columnHeader93;

	private ColumnHeader columnHeader94;

	private ComboBox comboBox2;

	private ComboBox comboBox3;

	private ListView listView5;

	private ColumnHeader columnHeader95;

	private ColumnHeader columnHeader96;

	private ColumnHeader columnHeader97;

	private ColumnHeader columnHeader98;

	private ColumnHeader columnHeader99;

	private ColumnHeader columnHeader100;

	private ColumnHeader columnHeader101;

	private ColumnHeader columnHeader102;

	private ColumnHeader columnHeader103;

	private TabPage tabPage3;

	private Label label38;

	private TabPage tabPage4;

	private CheckBox checkBox5;

	private CheckBox checkBox6;

	private CheckBox checkBox7;

	private TabControl tabControl4;

	private TabPage tabPage5;

	private Label label39;

	private ListBox listBox6;

	private Label label40;

	private ListBox listBox7;

	private TabPage tabPage6;

	private Button button21;

	private Button button22;

	private Button button23;

	private Button button24;

	private Button button25;

	private Button button26;

	private Button button27;

	private Button button28;

	private Label label41;

	private Label label42;

	private Label label43;

	private Label label44;

	private Label label45;

	private Label label46;

	private ListView listView6;

	private ColumnHeader columnHeader104;

	private ColumnHeader columnHeader105;

	private ColumnHeader columnHeader106;

	private ColumnHeader columnHeader107;

	private ColumnHeader columnHeader108;

	private ColumnHeader columnHeader109;

	private ColumnHeader columnHeader110;

	private ColumnHeader columnHeader111;

	private ColumnHeader columnHeader112;

	private ListView listView7;

	private ColumnHeader columnHeader113;

	private ColumnHeader columnHeader114;

	private ColumnHeader columnHeader115;

	private ColumnHeader columnHeader116;

	private ColumnHeader columnHeader117;

	private ColumnHeader columnHeader118;

	private ColumnHeader columnHeader119;

	private ColumnHeader columnHeader120;

	private TabPage tabPage7;

	private ListView listView8;

	private ColumnHeader columnHeader121;

	private ColumnHeader columnHeader122;

	private ColumnHeader columnHeader123;

	private ColumnHeader columnHeader124;

	private ColumnHeader columnHeader125;

	private ColumnHeader columnHeader126;

	private ColumnHeader columnHeader127;

	private ColumnHeader columnHeader128;

	private ColumnHeader columnHeader129;

	private ColumnHeader columnHeader130;

	private PictureBox pictureBox3;

	private Label label47;

	private ListBox listBox8;

	private PictureBox pictureBox4;

	private Label label48;

	private ListBox listBox9;

	private Button button29;

	private Label label49;

	private TextBox textBox2;

	private TabPage tabPage8;

	private Label label50;

	private OpenFileDialog openFileDialog1;

	private ToolStripMenuItem toolStripMenuItem_18;

	private Label label64;

	private ToolStripMenuItem toolStripMenuItem_19;

	private TabPage tabPageParks;

	private TabPage tabPageXi;

	private ListView listViewSlave;

	private ColumnHeader columnHeader149;

	private ColumnHeader columnHeader150;

	private ColumnHeader columnHeader151;

	private ColumnHeader columnHeader152;

	private ColumnHeader columnHeader153;

	private ColumnHeader columnHeader154;

	private ColumnHeader columnHeader155;

	private ColumnHeader columnHeader156;

	private ColumnHeader columnHeader157;

	private ColumnHeader columnHeader158;

	private Label label13;

	private ListBox listBoxMast;

	private Label label15;

	private ListBox listBoxMy;

	private TabControl tabControl5;

	private TabPage tabPageJilu;

	private Button buttonMinYunKa;

	private Button buttonWoYaoSuShen;

	private Button buttonQingKongCuoHao;

	private ComboBox comboBoxDaZhe;

	private ComboBox comboBoxAnFu;

	private ComboBox comboBoxZheMo;

	private ComboBox comboBoxTaoHaoZhuRen;

	private Button buttonShuaXin;

	private Button buttonZhiXing;

	private Button buttonQuanXuan;

	private Button buttonQuanBuXuan;

	private Button buttonDaZhe;

	private Button buttonShiFang;

	private TextBox textBoxNuLiShiJian;

	private ListView listViewMaiDeQi;

	private ColumnHeader columnHeader159;

	private ColumnHeader columnHeader160;

	private ColumnHeader columnHeader161;

	private ToolStripSeparator toolStripMenuItem2;

	private ToolStripMenuItem toolStripMenuItem_20;

	private CheckBox checkBoxLoginPark;

	private CheckBox checkBoxLoginFriend;

	private Button buttonShuaXinMaiDeQi;

	private Button buttonTaoHaoZhuRen;

	private ListView listViewAllFriend;

	private ColumnHeader columnHeader162;

	private ColumnHeader columnHeader163;

	private ColumnHeader columnHeader164;

	private ColumnHeader columnHeader165;

	private ColumnHeader columnHeader166;

	private Button buttonTxt;

	private ToolStripButton toolStripButton_3;

	private ToolStripMenuItem toolStripMenuItem_21;

	private TabPage tabPage14;

	private Button button3;

	private Button button4;

	private Label label69;

	private Label label70;

	private Label label71;

	private Button button5;

	private Label label72;

	private ComboBox comboBox4;

	private Label label73;

	private CheckBox checkBox8;

	private Button button6;

	private Button button7;

	private Button button39;

	private Button button40;

	private Button button41;

	private Button button42;

	private Button button43;

	private Label label74;

	private Button button44;

	private ListView listView9;

	private ColumnHeader columnHeader168;

	private ColumnHeader columnHeader169;

	private ColumnHeader columnHeader170;

	private ColumnHeader columnHeader171;

	private ColumnHeader columnHeader172;

	private ColumnHeader columnHeader173;

	private ColumnHeader columnHeader174;

	private Label label75;

	private Label label76;

	private Label label77;

	private Button button45;

	private ListView listView10;

	private ColumnHeader columnHeader175;

	private ColumnHeader columnHeader176;

	private ColumnHeader columnHeader177;

	private ColumnHeader columnHeader178;

	private ColumnHeader columnHeader179;

	private ColumnHeader columnHeader180;

	private ColumnHeader columnHeader181;

	private ColumnHeader columnHeader182;

	private ColumnHeader columnHeader183;

	private Button button46;

	private ListView listView11;

	private ColumnHeader columnHeader184;

	private ColumnHeader columnHeader185;

	private ColumnHeader columnHeader186;

	private ColumnHeader columnHeader187;

	private ColumnHeader columnHeader188;

	private ColumnHeader columnHeader189;

	private ColumnHeader columnHeader190;

	private ColumnHeader columnHeader191;

	private TabPage tabPage15;

	private Label label78;

	private Label label79;

	private Button button47;

	private Button button48;

	private Button button49;

	private Button button50;

	private Button button51;

	private Button button52;

	private Button button53;

	private Button button54;

	private Label label80;

	private Label label81;

	private Label label82;

	private Label label83;

	private Label label84;

	private Label label85;

	private ListView listView12;

	private ColumnHeader columnHeader192;

	private ColumnHeader columnHeader193;

	private ColumnHeader columnHeader194;

	private ColumnHeader columnHeader195;

	private ColumnHeader columnHeader196;

	private ColumnHeader columnHeader197;

	private ColumnHeader columnHeader198;

	private ColumnHeader columnHeader199;

	private ColumnHeader columnHeader200;

	private ListView listView13;

	private ColumnHeader columnHeader201;

	private ColumnHeader columnHeader202;

	private ColumnHeader columnHeader203;

	private ColumnHeader columnHeader204;

	private ColumnHeader columnHeader205;

	private ColumnHeader columnHeader206;

	private ColumnHeader columnHeader207;

	private ColumnHeader columnHeader208;

	private Button button55;

	private Label label86;

	private TextBox textBox4;

	private TabPage tabPage16;

	private Label label87;

	private Label label88;

	private CheckBox checkBox10;

	private Button button56;

	private Button button57;

	private Label label89;

	private ListView listView14;

	private ColumnHeader columnHeader209;

	private ColumnHeader columnHeader210;

	private ColumnHeader columnHeader211;

	private ColumnHeader columnHeader212;

	private ColumnHeader columnHeader213;

	private ColumnHeader columnHeader214;

	private ComboBox comboBox5;

	private ComboBox comboBox6;

	private ListView listView15;

	private ColumnHeader columnHeader215;

	private ColumnHeader columnHeader216;

	private ColumnHeader columnHeader217;

	private ColumnHeader columnHeader218;

	private ColumnHeader columnHeader219;

	private ColumnHeader columnHeader220;

	private ColumnHeader columnHeader221;

	private ColumnHeader columnHeader222;

	private ColumnHeader columnHeader223;

	private TabPage tabPage17;

	private Label label90;

	private TabPage tabPage18;

	private TextBox textBox5;

	private Button button58;

	private TabPage tabPage19;

	private TextBox textBox6;

	private Button button59;

	private ToolStripMenuItem toolStripMenuItem_22;

	private TabControl tabControl3;

	private TabPage tabPagePark;

	private Button buttonSaveFriend;

	private Button button2;

	private Label label16;

	private Label label12;

	private Label label8;

	private Label label6;

	private ComboBox comboExcessQQ;

	private Label label5;

	private CheckBox checkGoBack;

	private Button buttonAllYes1;

	private Button buttonYuan;

	private Button buttonAllNo1;

	private Button buttonNuo;

	private Button buttonTie;

	private Label label4;

	private Button buttonRefres3;

	private ListView listFriend;

	private ColumnHeader columnHeader17;

	private ColumnHeader columnHeader18;

	private ColumnHeader columnHeader19;

	private ColumnHeader columnHeader20;

	private ColumnHeader columnHeader21;

	private ColumnHeader columnHeader22;

	private ColumnHeader columnHeader24;

	private Label label11;

	private Label label10;

	private Label label9;

	private Button buttonRefres2;

	private ListView listCars;

	private ColumnHeader columnHeader8;

	private ColumnHeader columnHeader9;

	private ColumnHeader columnHeader10;

	private ColumnHeader columnHeader11;

	private ColumnHeader columnHeader12;

	private ColumnHeader columnHeader13;

	private ColumnHeader columnHeader14;

	private ColumnHeader columnHeader15;

	private ColumnHeader columnHeader16;

	private Button buttonRefres1;

	private ListView listPark;

	private ColumnHeader columnHeader1;

	private ColumnHeader columnHeader2;

	private ColumnHeader columnHeader3;

	private ColumnHeader columnHeader23;

	private ColumnHeader columnHeader4;

	private ColumnHeader columnHeader5;

	private ColumnHeader columnHeader6;

	private ColumnHeader columnHeader7;

	private TabPage tabPageJubao;

	private Button button31;

	private Button button32;

	private Button button33;

	private Button button34;

	private Button button35;

	private Button button36;

	private Button button37;

	private Button button38;

	private Label label52;

	private Label label53;

	private Label label54;

	private Label label55;

	private Label label56;

	private Label label57;

	private ListView listJubaoCars;

	private ColumnHeader columnHeader131;

	private ColumnHeader columnHeader132;

	private ColumnHeader columnHeader133;

	private ColumnHeader columnHeader134;

	private ColumnHeader columnHeader135;

	private ColumnHeader columnHeader136;

	private ColumnHeader columnHeader137;

	private ColumnHeader columnHeader138;

	private ColumnHeader columnHeader139;

	private ListView listJubaoPark;

	private ColumnHeader columnHeader140;

	private ColumnHeader columnHeader141;

	private ColumnHeader columnHeader142;

	private ColumnHeader columnHeader143;

	private ColumnHeader columnHeader144;

	private ColumnHeader columnHeader145;

	private ColumnHeader columnHeader146;

	private ColumnHeader columnHeader147;

	private Button button30;

	private Label label51;

	private TabPage tabPageCheshi;

	private Label label62;

	private Label label63;

	private CheckBox checkBox9;

	private Button buttonBuyCar;

	private Button buttonChangeCar;

	private Label label7;

	private ListView listBuyCar;

	private ColumnHeader columnHeader36;

	private ColumnHeader columnHeader37;

	private ColumnHeader columnHeader38;

	private ColumnHeader columnHeader39;

	private ColumnHeader columnHeader148;

	private ColumnHeader columnHeader167;

	private ComboBox comboCarColor;

	private ComboBox comboCarType;

	private ListView listCarInfo;

	private ColumnHeader columnHeader27;

	private ColumnHeader columnHeader28;

	private ColumnHeader columnHeader29;

	private ColumnHeader columnHeader30;

	private ColumnHeader columnHeader31;

	private ColumnHeader columnHeader32;

	private ColumnHeader columnHeader33;

	private ColumnHeader columnHeader34;

	private ColumnHeader columnHeader35;

	private TabPage tabPageJiaoben;

	private TabPage tabPageWoDeCheZiJinKuang;

	private Label label93;

	private TextBox textBoxWoCheWeiJinKuang;

	private TextBox textBoxWoCheZiJinKuang;

	private Button buttonShuaXinWoCheWeiJinKuang;

	private Label label92;

	private Button buttonShuaXinWoCheZiJinKuang;

	private TabPage tabPage20;

	private Label label91;

	private TextBox textBoxQueryQQNum;

	private TextBox textBoxHaoYouTingCheXin;

	private Button buttonChaKanHaoYouTingCheJiLu;

	private Label labelChaJu;

	private ToolStripMenuItem toolStripMenuItem_23;

	private ToolStripMenuItem toolStripMenuItem_24;

	private Button buttonYiJianHaoYouMaiMai;

	private Button buttonYiJianPark;

	private Button buttonYiJianParkPiLiang;

	private Button button60;

	private Button button61;

	private ComboBox comboExcessQQ2;

	private TabControl tabControl6;

	private TabPage tabPageLogin;

	private TabPage tabPageHaveLogin;

	private GroupBox groupBox1;

	private TabPage tabPage21;

	private Button buttonZongPaiHangBang;

	private ListView listViewPaiMin;

	private ColumnHeader columnHeader224;

	private ColumnHeader columnHeader225;

	private ColumnHeader columnHeader226;

	private ColumnHeader columnHeader227;

	private ColumnHeader columnHeader228;

	private ColumnHeader columnHeader229;

	private ColumnHeader columnHeader230;

	private Button buttonWeiYe;

	private Button buttonShouYe;

	private Button buttonShangYe;

	private Button buttonXiaYe;

	private Label labelYeMa;

	private ListView listViewJiaoBenUser;

	private ColumnHeader columnHeader231;

	private ColumnHeader columnHeader232;

	private Button button62;

	private Button button63;

	private TabControl tabControl7;

	private TabPage tabPage22;

	private TabPage tabPage23;

	private Label label65;

	private TextBox textBox3;

	private Label label96;

	private TextBox textBox7;

	private CheckBox checkBox11;

	private TextBox textBox8;

	private Label label97;

	private CheckBox checkBox12;

	private Button button65;

	private TextBox textBox9;

	private Label label98;

	private Label label100;

	private Label label99;

	private Label label102;

	private TextBox textBox10;

	private Label label101;

	private Label label104;

	private TextBox textBox11;

	private Label label103;

	private Button button66;

	private Button button67;

	private ComboBox comboBoxColor9;

	private ComboBox comboBoxCarName9;

	private CheckBox checkBoxHuanChe9;

	private CheckBox checkBoxCar9;

	private ComboBox comboBoxColor8;

	private ComboBox comboBoxCarName8;

	private CheckBox checkBoxHuanChe8;

	private CheckBox checkBoxCar8;

	private ComboBox comboBoxColor7;

	private ComboBox comboBoxCarName7;

	private CheckBox checkBoxHuanChe7;

	private CheckBox checkBoxCar7;

	private ComboBox comboBoxColor6;

	private ComboBox comboBoxCarName6;

	private CheckBox checkBoxHuanChe6;

	private CheckBox checkBoxCar6;

	private ComboBox comboBoxColor5;

	private ComboBox comboBoxCarName5;

	private CheckBox checkBoxHuanChe5;

	private CheckBox checkBoxCar5;

	private ComboBox comboBoxColor4;

	private ComboBox comboBoxCarName4;

	private CheckBox checkBoxHuanChe4;

	private CheckBox checkBoxCar4;

	private ComboBox comboBoxColor3;

	private ComboBox comboBoxCarName3;

	private CheckBox checkBoxHuanChe3;

	private CheckBox checkBoxCar3;

	private ComboBox comboBoxColor2;

	private ComboBox comboBoxCarName2;

	private CheckBox checkBoxHuanChe2;

	private CheckBox checkBoxCar2;

	private ComboBox comboBoxColor1;

	private ComboBox comboBoxCarName1;

	private CheckBox checkBoxHuanChe1;

	private CheckBox checkBoxCar1;

	private CheckBox checkBox31;

	private CheckBox checkBox32;

	private ComboBox comboBox25;

	private ComboBox comboBox26;

	private ComboBox comboBox27;

	private ComboBox comboBox28;

	private CheckBox checkBox33;

	private CheckBox checkBox34;

	private ComboBox comboBox29;

	private ComboBox comboBox30;

	private CheckBox checkBox35;

	private CheckBox checkBox36;

	private ComboBox comboBox31;

	private ComboBox comboBox32;

	private CheckBox checkBox37;

	private CheckBox checkBox38;

	private ComboBox comboBox33;

	private ComboBox comboBox34;

	private CheckBox checkBox39;

	private CheckBox checkBox40;

	private ComboBox comboBox35;

	private ComboBox comboBox36;

	private CheckBox checkBox41;

	private CheckBox checkBox42;

	private ComboBox comboBox37;

	private ComboBox comboBox38;

	private CheckBox checkBox43;

	private CheckBox checkBox44;

	private ComboBox comboBox39;

	private ComboBox comboBox40;

	private CheckBox checkBox45;

	private CheckBox checkBox46;

	private ComboBox comboBox41;

	private ComboBox comboBox42;

	private CheckBox checkBox47;

	private CheckBox checkBox48;

	private Button button68;

	private Button button69;

	private Label label105;

	private TextBox textBox12;

	private Label label106;

	private Label label107;

	private TextBox textBox13;

	private Label label108;

	private Label label109;

	private Label label110;

	private Button button70;

	private TextBox textBox14;

	private Label label111;

	private CheckBox checkBox49;

	private TextBox textBox15;

	private Label label112;

	private CheckBox checkBox50;

	private Label label113;

	private TextBox textBox16;

	private Label label114;

	private Label label115;

	private ListView listView17;

	private ColumnHeader columnHeader233;

	private ColumnHeader columnHeader234;

	private Button button71;

	private Button button72;

	private Button button73;

	private ComboBox comboBoxColor10;

	private ComboBox comboBoxCarName10;

	private CheckBox checkBoxHuanChe10;

	private CheckBox checkBoxCar10;

	private Button button74;

	private Label label116;

	private Button button75;

	private Button button76;

	private Button button64;

	private ContextMenuStrip contextMenuStrip2;

	private ToolStripMenuItem toolStripMenuItem_25;

	private Label label117;

	private Button button77;

	private CheckBox checkBox13;

	private ComboBox comboExcessQQ3;

	private ToolStripLabel toolStripLabel1;

	private ToolStripMenuItem toolStripMenuItem_26;

	private ColumnHeader columnHeader235;

	private Label label119;

	private Label label118;

	private Label label120;

	private Label label121;

	private ColumnHeader columnHeader236;

	private ColumnHeader columnHeader237;

	private Button button78;

	private Button button79;

	private Button button80;

	private Button button81;

	private CheckBox checkBox14;

	private ColumnHeader columnHeader238;

	private ColumnHeader columnHeader239;

	private ColumnHeader columnHeader240;

	private ColumnHeader columnHeader241;

	private ColumnHeader columnHeader242;

	private ColumnHeader columnHeader243;

	private Button button_0;

	private ColumnHeader columnHeader244;

	private ColumnHeader columnHeader248;

	private Button button_1;

	private Button button_2;

	private Button button_3;

	private Button button_4;

	private ColumnHeader columnHeader245;

	private ColumnHeader columnHeader246;

	private CheckBox checkBox_0;

	private CheckBox checkBox_1;

	private TabPage tabPageZhzx;

	private Label label60;

	private ListView listView_0;

	private ColumnHeader columnHeader247;

	private ColumnHeader columnHeader249;

	private CheckBox checkBox_2;

	private ColumnHeader columnHeader250;

	private ColumnHeader columnHeader251;

	private CheckBox checkBox_3;

	private CheckBox checkBox_4;

	private CheckBox checkBox_5;

	private CheckBox checkBox_6;

	private CheckBox checkBox_7;

	private CheckBox checkBox_8;

	private ListView listView_1;

	private ColumnHeader columnHeader252;

	private ColumnHeader columnHeader253;

	private ColumnHeader columnHeader255;

	private Label label61;

	private TextBox textBox_0;

	private Button button_5;

	private Button button_6;

	private Button button_7;

	private Button button_8;

	private Button button_9;

	private Button buttonDaoRuJunDao;

	private Button button_10;

	private ToolStripMenuItem toolStripMenuItem_27;

	private ToolStripMenuItem toolStripMenuItem_28;

	private ToolStripMenuItem toolStripMenuItem_29;

	private ToolStripMenuItem toolStripMenuItem_30;

	private ToolStripMenuItem toolStripMenuItem_31;

	private ToolStripMenuItem toolStripMenuItem_32;

	private ToolStripMenuItem toolStripMenuItem_33;

	private ColumnHeader columnHeader254;

	private TabPage tabPage9;

	private TabPage tabPage10;

	private TabPage tabPage11;

	private CheckBox checkBox15;

	private CheckBox checkBox16;

	private CheckBox checkBox17;

	private Label label66;

	private Label label67;

	private ListView listView16;

	private ColumnHeader columnHeader256;

	private ColumnHeader columnHeader257;

	private ListView listView18;

	private ColumnHeader columnHeader265;

	private ColumnHeader columnHeader266;

	private ColumnHeader columnHeader267;

	private ListView listView19;

	private ColumnHeader columnHeader258;

	private ColumnHeader columnHeader259;

	private ColumnHeader columnHeader260;

	private AxWindowsMediaPlayer axWindowsMediaPlayer1;

	private ContextMenuStrip contextMenuStrip3;

	private ToolStripMenuItem toolStripMenuItem_34;

	private ToolStripMenuItem toolStripMenuItem_35;

	private ToolStripMenuItem toolStripMenuItem_36;

	private ListView listView20;

	private ColumnHeader columnHeader261;

	private ColumnHeader columnHeader262;

	private ColumnHeader columnHeader263;

	private PictureBox pictureBox5;

	private ContextMenuStrip contextMenuStrip4;

	private ToolStripMenuItem toolStripMenuItem_37;

	private ToolStripMenuItem toolStripMenuItem_38;

	private ToolStripSeparator toolStripMenuItem3;

	private ToolStripMenuItem toolStripMenuItem_39;

	private Button button_11;

	private TabPage tabPageZone;

	private TabPage tabPageCity;

	private Button button_12;

	private Label label68;

	private TextBox textBox17;

	private TabControl tabControl8;

	private TabPage tabPage12;

	private TabPage tabPage13;

	private Button button_13;

	private TextBox textBoxContent;

	private ListView listView21;

	private ColumnHeader columnHeader264;

	private ColumnHeader columnHeader268;

	private ColumnHeader columnHeader269;

	private ColumnHeader columnHeader270;

	private WebBrowser webBrowserReadQQZone;

	private ContextMenuStrip contextMenuStrip5;

	private ToolStripMenuItem toolStripMenuItem_40;

	private ToolStripMenuItem toolStripMenuItem_41;

	private ToolStripSeparator toolStripMenuItem4;

	private ToolStripMenuItem toolStripMenuItem_42;

	private ToolStripMenuItem toolStripMenuItem_43;

	private ToolStripMenuItem toolStripMenuItem_44;

	private ColumnHeader columnHeader271;

	private ToolStripMenuItem toolStripMenuItem_45;

	private ComboBox comboBoxSheng;

	private Label label94;

	private ColumnHeader columnHeader272;

	private ColumnHeader columnHeader273;

	private ColumnHeader columnHeader274;

	private Label labelAge;

	private ComboBox comboBoxAge;

	private Label label123;

	private ComboBox comboBoxSex;

	private Label label122;

	private ComboBox comboBoxCity;

	private Button button_14;

	private Button button_15;

	private ColumnHeader columnHeader275;

	private ColumnHeader columnHeader276;

	private ColumnHeader columnHeader277;

	private Label label125;

	private Label label124;

	private DoubleBufferListView listViewCity;

	private PictureBox pictureBoxCity;

	private TabPage tabPageShiJian;

	private TextBox textBoxShiJian;

	private Button button_16;

	private Label label126;

	private TabControl tabControl9;

	private TabPage tabPage24;

	private TabPage tabPage25;

	private TabPage tabPage26;

	private Label label127;

	private Button button_17;

	private ListView listViewJc;

	private ColumnHeader columnHeader278;

	private ColumnHeader columnHeader279;

	private ColumnHeader columnHeader280;

	private Button button_18;

	private Button button_19;

	private Button button87;

	private Button button88;

	private Button button85;

	private Button button86;

	private TextBox textBox18;

	private Button button_20;

	private Label label128;

	private Label label129;

	private TextBox textBox19;

	private Button button_21;

	private Label label130;

	private Label label131;

	private Button button_22;

	private Label label132;

	private Button button_23;

	private Button button_24;

	private Button button_25;

	private Label label135;

	private Label label134;

	private Label label133;

	private ListView listViewPK0;

	private ColumnHeader columnHeader284;

	private ColumnHeader columnHeader285;

	private ColumnHeader columnHeader286;

	private ListView listViewPK1;

	private ColumnHeader columnHeader281;

	private ColumnHeader columnHeader282;

	private ColumnHeader columnHeader283;

	private ColumnHeader columnHeader290;

	private ColumnHeader columnHeader291;

	private ColumnHeader columnHeader292;

	private ListView listViewPK2;

	private ColumnHeader columnHeader287;

	private ColumnHeader columnHeader288;

	private ColumnHeader columnHeader289;

	private ColumnHeader columnHeader293;

	private ColumnHeader columnHeader294;

	private ColumnHeader columnHeader295;

	private Button button_26;

	private Label label136;

	private Button button_27;

	private ToolStripMenuItem toolStripMenuItem_46;

	private ToolStripMenuItem toolStripMenuItem_47;

	private Label label137;

	private Button button84;

	private Button button89;

	private Button button82;

	private Button button83;

	private Label label138;

	private ComboBox comboBoxOnline;

	private ToolStripSeparator toolStripMenuItem5;

	private ToolStripMenuItem toolStripMenuItem_48;

	private ToolStripMenuItem toolStripMenuItem_49;

	private ColumnHeader columnHeader296;

	private ComboBox comboBox_0;

	private Button button_28;

	private TabControl tabControl10;

	private TabPage tabPage27;

	private TabPage tabPage28;

	private TextBox textBox_1;

	private Button button_29;

	private Label label59;

	private Button button_30;

	private ListView listView_2;

	private ColumnHeader columnHeader297;

	private ColumnHeader columnHeader298;

	private ColumnHeader columnHeader299;

	private Button button_31;

	private Button button_32;

	private Label label58;

	private TextBox textBox22;

	private Label label139;

	private Button button1;

	private Button button92;

	private Button button93;

	private Button button_33;

	private Button button_34;

	private CheckBox checkBox18;

	private ToolStripMenuItem toolStripMenuItem_50;

	private ToolStripMenuItem toolStripMenuItem_51;

	private SaveFileDialog saveFileDialog1;

	private ToolStripMenuItem toolStripMenuItem_52;

	private ComboBox comboExcessQQ4;

	private Button button90;

	private Label label95;

	private Label label140;

	private TextBox textBox20;

	private Label label141;

	private Label label142;

	private TextBox textBox21;

	private Button button91;

	private Button button94;

	private CheckBox checkBox_9;

	private CheckBox checkBox_10;

	private CheckBox checkBox_11;

	private CheckBox checkBox_12;

	private Button button95;

	private Button button96;

	private ToolStripMenuItem toolStripMenuItem_53;

	private ToolStripMenuItem toolStripMenuItem_54;

	private ToolStripButton toolStripButton_4;

	private ToolStripMenuItem toolStripMenuItem_55;

	private ToolStripMenuItem toolStripMenuItem_56;

	private ToolStripButton toolStripButton_5;

	private Button button_35;

	private ColumnHeader columnHeader300;

	public Main()
	{
		InitializeComponent();
	}

	private void Main_Load(object sender, EventArgs e)
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected O, but got Unknown
		((Control)this).set_Text("QQ捕快2009 [" + m_sVer + "]  官网：yxz123.com");
		m_sBuKuaiPass = fp.ReadIniData("User0", "qq", "", Application.get_StartupPath() + "\\UserInfo.ini");
		if (m_sBuKuaiPass != string.Empty)
		{
			m_sBuKuaiPass = sm.Decrypto(m_sBuKuaiPass);
		}
		if (m_sBuKuaiPass == string.Empty)
		{
			m_sBuKuaiPass = "8888";
			BuKuaiMiMaAdd buKuaiMiMaAdd = new BuKuaiMiMaAdd();
			buKuaiMiMaAdd.m_sBuKuaiPass = m_sBuKuaiPass;
			((Form)buKuaiMiMaAdd).ShowDialog();
			if (buKuaiMiMaAdd.m_bOK)
			{
				m_sBuKuaiPass = buKuaiMiMaAdd.m_sBuKuaiPass;
				fp.WriteIniData("User0", "qq", sm.Encrypto(m_sBuKuaiPass), Application.get_StartupPath() + "\\UserInfo.ini");
			}
		}
		tabControl5.set_SelectedIndex(0);
		pictureBoxValidate_Click(null, null);
		m_sExeDir = Application.get_StartupPath();
		m_strConfigPath = m_sExeDir + "\\Config.ini";
		m_strLogPath = m_sExeDir + "\\Log.ini";
		m_strFriendPath = m_sExeDir + "\\Friend\\";
		m_strJiaoBenPath = m_sExeDir + "\\CarScript\\";
		m_sFileDhUserPath = m_sExeDir + "\\DxUser.ini";
		m_sFileBuyUserPath = m_sExeDir + "\\BuyUser\\";
		m_sFileJbUserPath = m_sExeDir + "\\JbUser\\";
		if (!Directory.Exists(m_strFriendPath))
		{
			Directory.CreateDirectory(m_strFriendPath);
		}
		if (!Directory.Exists(m_strJiaoBenPath))
		{
			Directory.CreateDirectory(m_strJiaoBenPath);
		}
		if (!Directory.Exists(m_sFileBuyUserPath))
		{
			Directory.CreateDirectory(m_sFileBuyUserPath);
		}
		if (!Directory.Exists(m_sFileJbUserPath))
		{
			Directory.CreateDirectory(m_sFileJbUserPath);
		}
		fp.SetFriendDir(m_strFriendPath);
		ReadConfig();
		if (((Control)comboExcessQQ).get_Text().Length > 0)
		{
			sQQNumExcess = StringChar.GetQQNum(((Control)comboExcessQQ).get_Text());
		}
		fp.SetFilePath(Application.get_StartupPath() + "\\UserInfo.ini");
		fp.ReadAll();
		for (int i = 0; i < fp.GetCount(); i++)
		{
			UserInfo userInfo = fp.GetUserInfo(i);
			comboQQNum.get_Items().Add((object)userInfo.sQQNum);
		}
		if (comboQQNum.get_Items().get_Count() > 0)
		{
			((ListControl)comboQQNum).set_SelectedIndex(0);
		}
		((Control)label11).set_Text("现金：0");
		((Control)label6).set_Text("开通日期：0");
		((Control)label8).set_Text("车辆数：0");
		((Control)label9).set_Text("每日能盈利：0");
		((Control)label10).set_Text("当前已盈利：0");
		((Control)label4).set_Text("你在好友圈内排行位数：0");
		long num = ct.GetTypeCount();
		for (int j = 0; j < num; j++)
		{
			comboCarType.get_Items().Add((object)ct.GetTypeName(j));
		}
		((ListControl)comboCarType).set_SelectedIndex(0);
		num = ct.GetColorCount();
		for (int k = 0; k < num; k++)
		{
			comboCarColor.get_Items().Add((object)ct.GetColorName(k));
		}
		((ListControl)comboCarColor).set_SelectedIndex(0);
		num = m_ctt.GetSengCount();
		for (int l = 0; l < num; l++)
		{
			comboBoxSheng.get_Items().Add((object)m_ctt.GetShengTypeInfoByIndex(l).m_shenname);
		}
		((ListControl)comboBoxSheng).set_SelectedIndex(0);
		comboBoxSex.get_Items().Add((object)"不限");
		comboBoxSex.get_Items().Add((object)"男");
		comboBoxSex.get_Items().Add((object)"女");
		((ListControl)comboBoxSex).set_SelectedIndex(0);
		comboBoxAge.get_Items().Add((object)"不限");
		comboBoxAge.get_Items().Add((object)"0-14岁");
		comboBoxAge.get_Items().Add((object)"15-18岁");
		comboBoxAge.get_Items().Add((object)"19-22岁");
		comboBoxAge.get_Items().Add((object)"23-26岁");
		comboBoxAge.get_Items().Add((object)"27-30岁");
		comboBoxAge.get_Items().Add((object)"31-35岁");
		comboBoxAge.get_Items().Add((object)"36-45岁");
		comboBoxAge.get_Items().Add((object)"46岁以上");
		((ListControl)comboBoxAge).set_SelectedIndex(0);
		comboBoxOnline.get_Items().Add((object)"不限");
		comboBoxOnline.get_Items().Add((object)"在线");
		comboBoxOnline.get_Items().Add((object)"不在线");
		((ListControl)comboBoxOnline).set_SelectedIndex(0);
		comboBox_0.get_Items().Add((object)"勾选车");
		comboBox_0.get_Items().Add((object)"全部勾选");
		comboBox_0.get_Items().Add((object)"全部取消");
		comboBox_0.get_Items().Add((object)"未停车");
		comboBox_0.get_Items().Add((object)"已停车");
		comboBox_0.get_Items().Add((object)"停车满15分钟[3辆]");
		comboBox_0.get_Items().Add((object)"停车满15分钟");
		comboBox_0.get_Items().Add((object)"停车满8小时");
		comboBox_0.get_Items().Add((object)"停车满12小时");
		((ListControl)comboBox_0).set_SelectedIndex(0);
		((Control)button_15).set_Enabled(false);
		((Control)button_23).set_Enabled(false);
		((Control)button_4).set_Enabled(false);
		((Control)textBox22).set_Text("1,2,3,4,5,6,7,8,9,10");
		timersTimer.Start();
		timersTimer.Interval = 600000.0;
		timersTimer.Elapsed += timersTimer_Elapsed;
		timersTimerHaoYou.Elapsed += timersTimerHaoYou_Elapsed;
		timersTimerQiangGou.Elapsed += timersTimerQiangGou_Elapsed;
		WinKey.RegisterHotKey(((Control)this).get_Handle(), 100, 1u, (Keys)32);
		InitBuyFriendCombox();
		lvwColumnSorter = new ListViewColumnSorter();
		listFriend.set_ListViewItemSorter((IComparer)lvwColumnSorter);
		lvwColumnSorterCityList = new ListViewColumnSorter();
		((ListView)listViewCity).set_ListViewItemSorter((IComparer)lvwColumnSorterCityList);
		JiaoBenInit();
		m_DhUserList = fp.ReadDhUserList(m_sFileDhUserPath);
		foreach (DhUserInfo dhUser in m_DhUserList)
		{
			listView_0.set_View((View)1);
			ListViewItem val = new ListViewItem(dhUser.sQQNum);
			val.get_SubItems().Add(dhUser.sQQName);
			val.get_SubItems().Add("");
			val.get_SubItems().Add("");
			listView_0.get_Items().Add(val);
		}
	}

	public void ReadConfig()
	{
		((Control)comboExcessQQ).set_Text(fp.ReadIniData("config", "Excess", "", m_strConfigPath));
		string text = fp.ReadIniData("config", "GoBack", "", m_strConfigPath);
		string text2 = fp.ReadIniData("config", "SaveQQNum", "", m_strConfigPath);
		string text3 = fp.ReadIniData("config", "Normal", "", m_strConfigPath);
		string text4 = fp.ReadIniData("config", "Park", "", m_strConfigPath);
		string text5 = fp.ReadIniData("config", "BuyFriend", "", m_strConfigPath);
		string text6 = fp.ReadIniData("config", "LoginPark", "", m_strConfigPath);
		string text7 = fp.ReadIniData("config", "LoginFriend", "", m_strConfigPath);
		string text8 = fp.ReadIniData("config", "Cancel", "", m_strConfigPath);
		string text9 = fp.ReadIniData("config", "ShowAllTime", "", m_strConfigPath);
		string text10 = fp.ReadIniData("config", "LianXu", "", m_strConfigPath);
		string text11 = fp.ReadIniData("config", "ShowBMD", "", m_strConfigPath);
		string text12 = fp.ReadIniData("config", "LoginZhzx", "", m_strConfigPath);
		string text13 = fp.ReadIniData("config", "JuBao", "", m_strConfigPath);
		string text14 = fp.ReadIniData("config", "Dxhzx1", "", m_strConfigPath);
		string text15 = fp.ReadIniData("config", "Dxhzx2", "", m_strConfigPath);
		string text16 = fp.ReadIniData("config", "Dxhzx3", "", m_strConfigPath);
		string text17 = fp.ReadIniData("config", "Dxhzx4", "", m_strConfigPath);
		string text18 = fp.ReadIniData("config", "Dxhzx5", "", m_strConfigPath);
		string text19 = fp.ReadIniData("config", "Dxhzx6", "", m_strConfigPath);
		string text20 = fp.ReadIniData("config", "Dxhzx7", "", m_strConfigPath);
		string text21 = fp.ReadIniData("config", "Dxhzx8", "", m_strConfigPath);
		string text22 = fp.ReadIniData("config", "Dxhzx9", "", m_strConfigPath);
		string text23 = fp.ReadIniData("config", "Dxhzx10", "", m_strConfigPath);
		string text24 = fp.ReadIniData("config", "Dxhzx11", "", m_strConfigPath);
		m_sTieTiaoLiuYan = fp.ReadIniData("config", "TieTiaoLiuYan", "yxz123.com", m_strConfigPath);
		m_sSlaveChuoHao = fp.ReadIniData("config", "SlaveChuoHao", "yxz123.com", m_strConfigPath);
		string text25 = fp.ReadIniData("config", "Query4", "", m_strConfigPath);
		string text26 = fp.ReadIniData("config", "Query5", "", m_strConfigPath);
		string text27 = fp.ReadIniData("config", "Query6", "", m_strConfigPath);
		string sString = fp.ReadIniData("config", "QiangGou", "5", m_strConfigPath);
		m_iQiangGou = StringChar.SToInt(sString);
		if (m_iQiangGou < 5)
		{
			m_iQiangGou = 5;
		}
		string sString2 = fp.ReadIniData("config", "JuBaoTime", "1000", m_strConfigPath);
		m_iJuBaoTime = StringChar.SToInt(sString2);
		if (m_iJuBaoTime < 1000)
		{
			m_iJuBaoTime = 1000;
		}
		string sString3 = fp.ReadIniData("config", "CiShu", "100", m_strConfigPath);
		m_iCiShu = StringChar.SToInt(sString3);
		if (m_iCiShu < 1)
		{
			m_iCiShu = 1;
		}
		if (m_iCiShu > 100)
		{
			m_iCiShu = 100;
		}
		((Control)textBox19).set_Text(m_iQiangGou.ToString());
		((Control)textBox20).set_Text(m_iJuBaoTime.ToString());
		((Control)textBox21).set_Text(m_iCiShu.ToString());
		checkBox18.set_Checked(true);
		if (text13 == "False")
		{
			m_bJb = false;
			checkBox18.set_Checked(false);
		}
		if (text25 == "True")
		{
			m_bQuery4 = true;
			checkBox17.set_Checked(true);
		}
		if (text26 == "True")
		{
			m_bQuery5 = true;
			checkBox16.set_Checked(true);
		}
		if (text27 == "True")
		{
			m_bQuery6 = true;
			checkBox15.set_Checked(true);
		}
		checkBox_2.set_Checked(true);
		if (text14 == "False")
		{
			m_bDxhzx1 = false;
			checkBox_2.set_Checked(false);
		}
		checkBox_6.set_Checked(true);
		if (text15 == "False")
		{
			m_bDxhzx2 = false;
			checkBox_6.set_Checked(false);
		}
		checkBox_5.set_Checked(true);
		if (text16 == "False")
		{
			m_bDxhzx3 = false;
			checkBox_5.set_Checked(false);
		}
		checkBox_4.set_Checked(true);
		if (text17 == "False")
		{
			m_bDxhzx4 = false;
			checkBox_4.set_Checked(false);
		}
		checkBox_3.set_Checked(true);
		if (text18 == "False")
		{
			m_bDxhzx5 = false;
			checkBox_3.set_Checked(false);
		}
		checkBox_8.set_Checked(true);
		if (text19 == "False")
		{
			m_bDxhzx6 = false;
			checkBox_8.set_Checked(false);
		}
		checkBox_7.set_Checked(true);
		if (text20 == "False")
		{
			m_bDxhzx7 = false;
			checkBox_7.set_Checked(false);
		}
		checkBox_9.set_Checked(true);
		if (text21 == "False")
		{
			m_bDxhzx8 = false;
			checkBox_9.set_Checked(false);
		}
		checkBox_12.set_Checked(true);
		if (text22 == "False")
		{
			m_bDxhzx9 = false;
			checkBox_12.set_Checked(false);
		}
		checkBox_11.set_Checked(true);
		if (text23 == "False")
		{
			m_bDxhzx10 = false;
			checkBox_11.set_Checked(false);
		}
		checkBox_10.set_Checked(true);
		if (text24 == "False")
		{
			m_bDxhzx11 = false;
			checkBox_10.set_Checked(false);
		}
		checkBox_1.set_Checked(true);
		if (text12 == "False")
		{
			m_bLoginZhzx = false;
			checkBox_1.set_Checked(false);
		}
		if (text11 == "True")
		{
			m_bShowBMD = true;
			checkBox_0.set_Checked(true);
		}
		if (text10 == "True")
		{
			m_bLianXu = true;
			checkBox14.set_Checked(true);
		}
		if (text == "True")
		{
			m_bGoBack = true;
			checkGoBack.set_Checked(true);
		}
		checkMark.set_Checked(true);
		if (text2 == "False")
		{
			m_bSaveQQNum = false;
			checkMark.set_Checked(false);
		}
		if (text3 == "True")
		{
			m_bNormal = true;
			checkBox1.set_Checked(true);
		}
		checkBox2.set_Checked(true);
		if (text4 == "False")
		{
			m_bPark = false;
			checkBox2.set_Checked(false);
		}
		if (text5 == "True")
		{
			m_bBuyFriend = true;
			checkBox3.set_Checked(true);
		}
		checkBoxLoginPark.set_Checked(true);
		if (text6 == "False")
		{
			m_bLoginPark = false;
			checkBoxLoginPark.set_Checked(false);
		}
		checkBoxLoginFriend.set_Checked(true);
		if (text7 == "False")
		{
			m_bLoginFriend = false;
			checkBoxLoginFriend.set_Checked(false);
		}
		if (text8 == "False")
		{
			m_bCancel = false;
		}
		if (text9 == "True")
		{
			m_bShowAllTime = true;
		}
	}

	private void toolStripMenuItem_8_Click(object sender, EventArgs e)
	{
		m_bCancel = false;
		((Form)this).Close();
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		m_bCancel = false;
		((Form)this).Close();
	}

	public void ProcessStart(string strUrl)
	{
		try
		{
			Process.Start(strUrl);
		}
		catch
		{
		}
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		ProcessStart("http://yxz123.com");
	}

	private void toolStripMenuItem_6_Click(object sender, EventArgs e)
	{
		AboutBox1 aboutBox = new AboutBox1();
		((Control)aboutBox).Show();
	}

	private void toolStripMenuItem_9_Click(object sender, EventArgs e)
	{
		ProcessStart("http://yxz123.com");
	}

	private void toolStripMenuItem_21_Click(object sender, EventArgs e)
	{
		ProcessStart("http://yxz123.com/read.php?tid=1");
	}

	private void toolStripMenuItem_23_Click(object sender, EventArgs e)
	{
		ProcessStart("http://yxz123.com/read.php?tid=1");
	}

	private void toolStripMenuItem_18_Click(object sender, EventArgs e)
	{
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
		ProcessStart("http://www.mmu5.cn");
	}

	private void method_2(object sender, EventArgs e)
	{
		ProcessStart("http://www.petrochemicalhome.com");
	}

	private void method_3(object sender, EventArgs e)
	{
		ProcessStart("http://www.3avi.cn");
	}

	private void method_4(object sender, EventArgs e)
	{
		ProcessStart("http://www.cunbaba.com");
	}

	private void method_5(object sender, EventArgs e)
	{
		ProcessStart("http://qiuqian.net");
	}

	private void toolStripMenuItem_5_Click(object sender, EventArgs e)
	{
		ProcessStart("http://yxz123.com/read.php?tid=2");
	}

	private void toolStripButtonHelp_Click(object sender, EventArgs e)
	{
		ProcessStart("http://yxz123.com/read.php?tid=2");
	}

	private void toolStripMenuItem_46_Click(object sender, EventArgs e)
	{
		ProcessStart("http://www.brsbox.com/yxzbbc");
	}

	private void toolStripMenuItem_47_Click(object sender, EventArgs e)
	{
		ProcessStart("http://www.brsbox.com/yxzbbc");
	}

	private void comboQQNum_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.get_KeyValue() == Convert.ToChar(13))
		{
			((Control)textQQPass).Select();
		}
	}

	private void textQQPass_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.get_KeyValue() == Convert.ToChar(13))
		{
			((Control)textValidate).Select();
		}
	}

	private void textValidate_KeyDown(object sender, KeyEventArgs e)
	{
		e.get_KeyValue();
		Convert.ToChar(13);
	}

	private void pictureBoxValidate_Click(object sender, EventArgs e)
	{
		((Control)textValidate).Select();
		if (m_user == null)
		{
			m_user = new User();
		}
		try
		{
			Stream validate = m_user.GetValidate();
			if (validate != null)
			{
				pictureBoxValidate.set_Image(Image.FromStream(validate));
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		((Control)textValidate).set_Text("");
	}

	private void buttonLogin_Click(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Invalid comparison between Unknown and I4
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		if (m_user == null)
		{
			MessageBox.Show("请重新获取验证码！", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		string text = ((Control)comboQQNum).get_Text().Trim();
		string text2 = ((Control)textQQPass).get_Text().Trim();
		string text3 = ((Control)textValidate).get_Text().Trim();
		string qQNum = StringChar.GetQQNum(text);
		if (qQNum == string.Empty)
		{
			MessageBox.Show("请输入QQ号码！", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			((Control)comboQQNum).Select();
			return;
		}
		if (text2 == string.Empty)
		{
			MessageBox.Show("请输入QQ密码！", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			((Control)textQQPass).Select();
			return;
		}
		if (text3 == string.Empty)
		{
			MessageBox.Show("请输入验证码！", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			((Control)textValidate).Select();
			return;
		}
		long num = listUser.get_Items().get_Count();
		int num2 = 0;
		while (true)
		{
			if (num2 < num)
			{
				string text4 = listUser.get_Items().get_Item(num2).get_SubItems()
					.get_Item(0)
					.get_Text();
				if (qQNum == text4)
				{
					break;
				}
				num2++;
				continue;
			}
			m_user.m_sQQnum = qQNum;
			m_user.m_sQQpass = text2;
			((Control)buttonLogin).set_Enabled(false);
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			string message = null;
			if (!m_user.Login(text2, text3, out message, m_bLoginPark, m_bLoginFriend))
			{
				MessageBox.Show(message, "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				m_user = null;
				pictureBoxValidate_Click(null, null);
				((Control)buttonLogin).set_Enabled(true);
				((Control)this).set_Cursor(Cursors.get_Default());
				return;
			}
			string text5 = StringChar.GetQQNick(text);
			if (text5 != null && !(text5 == string.Empty))
			{
				m_user.SetQQNick(text5);
			}
			else
			{
				text5 = m_user.GetNickSelf();
				m_user.SetQQNick(text5);
			}
			m_UserList.Count.ToString();
			listUser.set_View((View)1);
			ListViewItem val = new ListViewItem(m_user.m_sQQnum);
			val.get_SubItems().Add(m_user.m_sQQnick);
			listUser.get_Items().Add(val);
			listViewJiaoBenUser.set_View((View)1);
			ListViewItem val2 = new ListViewItem(m_user.m_sQQnum);
			val2.get_SubItems().Add(m_user.m_sQQnick);
			listViewJiaoBenUser.get_Items().Add(val2);
			if (m_bLoginZhzx)
			{
				listView_1.set_View((View)1);
				ListViewItem val3 = new ListViewItem(m_user.m_sQQnum);
				val3.get_SubItems().Add(m_user.m_sQQnick);
				val3.get_SubItems().Add("");
				listView_1.get_Items().Add(val3);
			}
			comboExcessQQ.get_Items().Add((object)text);
			comboExcessQQ2.get_Items().Add((object)text);
			comboExcessQQ3.get_Items().Add((object)text);
			comboExcessQQ4.get_Items().Add((object)text);
			if (m_bSaveQQNum)
			{
				fp.AddUser(qQNum + " [" + text5 + "]", text2);
				bool flag = false;
				for (int i = 0; i < comboQQNum.get_Items().get_Count(); i++)
				{
					if (qQNum == StringChar.GetQQNum(comboQQNum.get_Items().get_Item(i).ToString()))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					comboQQNum.get_Items().Add((object)(qQNum + " [" + text5 + "]"));
				}
				for (int j = 0; j < fp.GetCount(); j++)
				{
					UserInfo userInfo = fp.GetUserInfo(j);
					_ = qQNum == StringChar.GetQQNum(userInfo.sQQNum);
				}
			}
			if (((ListControl)comboQQNum).get_SelectedIndex() >= 0 && ((ListControl)comboQQNum).get_SelectedIndex() + 1 < comboQQNum.get_Items().get_Count())
			{
				ComboBox obj = comboQQNum;
				((ListControl)obj).set_SelectedIndex(((ListControl)obj).get_SelectedIndex() + 1);
			}
			m_UserList.Add(m_user);
			if (m_UserList.Count == 1)
			{
				m_user_current = m_user;
				listUser.get_Items().get_Item(0).set_ForeColor(Color.Blue);
				m_JiaoBenUseriIndex = 0;
				m_sJiaoBenQQNum = m_user_current.m_sQQnum;
				listViewJiaoBenUser.get_Items().get_Item(0).set_ForeColor(Color.Blue);
				ShowCarName(m_sJiaoBenQQNum);
				ReadJiaoBen(m_sJiaoBenQQNum, m_user_current.m_sQQnick);
				RefresALL();
			}
			m_user = null;
			pictureBoxValidate_Click(null, null);
			((Control)buttonLogin).set_Enabled(true);
			((Control)this).set_Cursor(Cursors.get_Default());
			return;
		}
		DialogResult val4 = MessageBox.Show("该QQ号码已经登陆，如果刷新不了抢车位和好友买卖，可以重新登录解决，你确认重新登录吗？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
		if ((int)val4 != 6)
		{
			return;
		}
		User userByQQNum = GetUserByQQNum(qQNum);
		if (userByQQNum == null)
		{
			MessageBox.Show("该号码本来就没有登陆！", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)buttonLogin).set_Enabled(false);
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		m_user.m_sQQnum = qQNum;
		m_user.m_sQQpass = text2;
		m_user.m_sQQnick = userByQQNum.m_sQQnick;
		string message2 = null;
		if (!m_user.Login(text2, text3, out message2, m_bLoginPark, m_bLoginFriend))
		{
			MessageBox.Show(message2, "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			m_user = null;
			return;
		}
		m_UserList.Remove(userByQQNum);
		userByQQNum = m_user;
		m_UserList.Add(userByQQNum);
		if (qQNum == m_user_current.m_sQQnum)
		{
			m_user_current = m_user;
		}
		m_user = null;
		pictureBoxValidate_Click(null, null);
		((Control)buttonLogin).set_Enabled(true);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void toolStripButton_0_Click(object sender, EventArgs e)
	{
		RefresALL();
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		RefresALL();
	}

	public void RefresALL()
	{
		if (m_bLoginPark)
		{
			RefresParker();
			RefresFriend(bXianShiXiangXi: false);
			RefresCars();
			button1_Click(null, null);
		}
		if (m_bLoginFriend)
		{
			RefresBuyFriend();
			button_24_Click(null, null);
			if (!m_bLoginPark)
			{
				tabControl1.set_SelectedIndex(2);
			}
		}
	}

	private void checkGoBack_CheckedChanged(object sender, EventArgs e)
	{
		m_bGoBack = checkGoBack.get_Checked();
		fp.WriteIniData("config", "GoBack", m_bGoBack.ToString(), m_strConfigPath);
	}

	private void checkMark_CheckedChanged(object sender, EventArgs e)
	{
		m_bSaveQQNum = checkMark.get_Checked();
		fp.WriteIniData("config", "SaveQQNum", m_bSaveQQNum.ToString(), m_strConfigPath);
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		m_bNormal = checkBox1.get_Checked();
		fp.WriteIniData("config", "Normal", m_bNormal.ToString(), m_strConfigPath);
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		m_bPark = checkBox2.get_Checked();
		fp.WriteIniData("config", "Park", m_bPark.ToString(), m_strConfigPath);
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		m_bBuyFriend = checkBox3.get_Checked();
		fp.WriteIniData("config", "BuyFriend", m_bBuyFriend.ToString(), m_strConfigPath);
	}

	private void checkBox17_CheckedChanged(object sender, EventArgs e)
	{
		m_bQuery4 = checkBox17.get_Checked();
		fp.WriteIniData("config", "Query4", m_bQuery4.ToString(), m_strConfigPath);
	}

	private void checkBox16_CheckedChanged(object sender, EventArgs e)
	{
		m_bQuery5 = checkBox16.get_Checked();
		fp.WriteIniData("config", "Query5", m_bQuery5.ToString(), m_strConfigPath);
	}

	private void checkBox15_CheckedChanged(object sender, EventArgs e)
	{
		m_bQuery6 = checkBox15.get_Checked();
		fp.WriteIniData("config", "Query6", m_bQuery6.ToString(), m_strConfigPath);
	}

	private void checkBoxLoginPark_CheckedChanged(object sender, EventArgs e)
	{
		m_bLoginPark = checkBoxLoginPark.get_Checked();
		fp.WriteIniData("config", "LoginPark", m_bLoginPark.ToString(), m_strConfigPath);
	}

	private void checkBoxLoginFriend_CheckedChanged(object sender, EventArgs e)
	{
		m_bLoginFriend = checkBoxLoginFriend.get_Checked();
		fp.WriteIniData("config", "LoginFriend", m_bLoginFriend.ToString(), m_strConfigPath);
	}

	private void buttonAllYes1_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listPark.get_Items().get_Count(); i++)
		{
			listPark.get_Items().get_Item(i).set_Checked(true);
		}
	}

	private void buttonAllNo1_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listPark.get_Items().get_Count(); i++)
		{
			listPark.get_Items().get_Item(i).set_Checked(false);
		}
	}

	private void buttonTie_Click(object sender, EventArgs e)
	{
		StopCars();
	}

	private void buttonRefres1_Click(object sender, EventArgs e)
	{
		RefresParker();
	}

	private void button60_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listFriend.get_Items().get_Count(); i++)
		{
			listFriend.get_Items().get_Item(i).set_Checked(true);
		}
	}

	private void button61_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listFriend.get_Items().get_Count(); i++)
		{
			listFriend.get_Items().get_Item(i).set_Checked(false);
		}
	}

	private void buttonRefres2_Click(object sender, EventArgs e)
	{
		RefresCars();
	}

	private void buttonRefres3_Click(object sender, EventArgs e)
	{
		RefresFriend(bXianShiXiangXi: false);
	}

	public void RefresParker()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (m_user_current == null)
			{
				MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			((Control)buttonRefres1).set_Enabled(false);
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			bool bPark = false;
			bool bPark2 = false;
			bool bPark3 = false;
			bool bPark4 = false;
			m_user_current.m_qp.QueryParkerInfo(m_user_current.m_sQQnum, out bPark, out bPark2, out bPark3, out bPark4);
			((Control)label11).set_Text("现金：" + m_user_current.m_qp.GetSelfMoney());
			((Control)label7).set_Text("现金：" + m_user_current.m_qp.GetSelfMoney());
			((Control)label6).set_Text("开通游戏日期：" + m_user_current.m_qp.GetStartGameTime().ToString());
			((Control)label8).set_Text("车辆数：" + m_user_current.m_qp.GetHaveCarNum());
			((Control)label118).set_Text("等级：" + m_user_current.m_qp.m_sDengji);
			((Control)label119).set_Text("经验值：" + m_user_current.m_qp.m_sJinYan);
			m_iCurrentMoney = m_user_current.m_qp.GetSelfMoney();
			m_iSumMiniteDoTieTiao = 0L;
			long num = 0L;
			listPark.get_Items().Clear();
			((Control)listPark).Update();
			long num2 = m_user_current.m_qp.GetCount();
			for (int i = 0; i < num2; i++)
			{
				ParkInfo parkInfo = m_user_current.m_qp.GetParkInfo(i);
				if (parkInfo == null)
				{
					continue;
				}
				string text = i.ToString();
				listPark.get_Items().Add(text, parkInfo.sQQNum, 0);
				listPark.get_Items().get_Item(text).get_SubItems()
					.Add(parkInfo.sQQName);
				listPark.get_Items().get_Item(text).get_SubItems()
					.Add(parkInfo.sCarNum);
				int code = StringChar.SToInt(parkInfo.sCarName);
				CarTypeInfo carTypeInfo = ct.GetCarTypeInfo(code);
				listPark.get_Items().get_Item(text).get_SubItems()
					.Add(parkInfo.sParkID);
				if (carTypeInfo != null)
				{
					listPark.get_Items().get_Item(text).get_SubItems()
						.Add(carTypeInfo.CarName);
					listPark.get_Items().get_Item(text).get_SubItems()
						.Add(carTypeInfo.MinuteMoney.ToString());
					listPark.get_Items().get_Item(text).get_SubItems()
						.Add(StringChar.GetStringTime(parkInfo.iTime));
					if (parkInfo.iTime > 720)
					{
						listPark.get_Items().get_Item(text).get_SubItems()
							.Add((carTypeInfo.MinuteMoney * 60 * 12).ToString());
						if (i > 0)
						{
							num += carTypeInfo.MinuteMoney * 60 * 12;
						}
						listPark.get_Items().get_Item(text).set_ForeColor(Color.Red);
					}
					else
					{
						listPark.get_Items().get_Item(text).get_SubItems()
							.Add((carTypeInfo.MinuteMoney * parkInfo.iTime).ToString());
						if (i > 0)
						{
							num += carTypeInfo.MinuteMoney * parkInfo.iTime;
						}
					}
					if (i > 0)
					{
						m_iSumMiniteDoTieTiao += carTypeInfo.MinuteMoney;
					}
				}
				else
				{
					listPark.get_Items().get_Item(text).get_SubItems()
						.Add(parkInfo.sCarName);
					listPark.get_Items().get_Item(text).get_SubItems()
						.Add(parkInfo.iMinuteMoney.ToString());
					listPark.get_Items().get_Item(text).get_SubItems()
						.Add(StringChar.GetStringTime(parkInfo.iTime));
					listPark.get_Items().get_Item(text).get_SubItems()
						.Add((parkInfo.iMinuteMoney * parkInfo.iTime).ToString());
					if (i > 0)
					{
						m_iSumMiniteDoTieTiao += parkInfo.iMinuteMoney;
					}
				}
			}
			((Control)listPark).Update();
			((Control)label12).set_Text("贴条收入：" + num);
			((Control)label62).set_Text("贴条收入：" + num);
			m_iTietiao = num;
			m_lSumMoney = m_iCurrentMoney + m_iYinli;
			if (m_bAddTieTiao)
			{
				m_lSumMoney += m_iTietiao;
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		((Control)buttonRefres1).set_Enabled(true);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void button81_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		m_user_current.m_qp.QueryDengJi(m_user_current.m_sQQnum);
		((Control)label118).set_Text("等级：" + m_user_current.m_qp.m_sDengji);
		((Control)label119).set_Text("经验值：" + m_user_current.m_qp.m_sJinYan);
	}

	public void RefresCars()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (m_user_current == null)
			{
				MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			((Control)buttonRefres2).set_Enabled(false);
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			long num = 0L;
			long num2 = 0L;
			m_iSumMiniteDoMoney = 0L;
			m_user_current.m_qc.QueryCarInfo(m_user_current.m_sQQnum);
			listCars.get_Items().Clear();
			listCarInfo.get_Items().Clear();
			if (m_sJiaoBenQQNum == m_user_current.m_sQQnum)
			{
				((Control)checkBoxCar1).set_Text("无车");
				((Control)checkBoxCar2).set_Text("无车");
				((Control)checkBoxCar3).set_Text("无车");
				((Control)checkBoxCar4).set_Text("无车");
				((Control)checkBoxCar5).set_Text("无车");
				((Control)checkBoxCar6).set_Text("无车");
				((Control)checkBoxCar7).set_Text("无车");
				((Control)checkBoxCar8).set_Text("无车");
				((Control)checkBoxCar9).set_Text("无车");
				((Control)checkBoxCar10).set_Text("无车");
			}
			long count = m_user_current.m_qc.GetCount();
			for (int i = 0; i < count; i++)
			{
				CarInfo carInfo = m_user_current.m_qc.GetCarInfo(i);
				if (carInfo == null)
				{
					continue;
				}
				string text = i.ToString();
				listCars.get_Items().Add(text, carInfo.QQNum, 0);
				listCars.get_Items().get_Item(text).set_Tag((object)carInfo.strParkNum);
				if (m_user_current.m_qf != null)
				{
					for (int j = 0; j < m_user_current.m_qf.GetCount(); j++)
					{
						FriendInfo friendInfo = m_user_current.m_qf.GetFriendInfo(j);
						if (friendInfo.QQNum == carInfo.QQNum)
						{
							carInfo.QQName = friendInfo.QQName;
							break;
						}
					}
				}
				listCars.get_Items().get_Item(text).get_SubItems()
					.Add(carInfo.QQName);
				listCars.get_Items().get_Item(text).get_SubItems()
					.Add(carInfo.CarNum);
				listCars.get_Items().get_Item(text).get_SubItems()
					.Add(carInfo.CarColor);
				int code = StringChar.SToInt(carInfo.CarName);
				CarTypeInfo carTypeInfo = ct.GetCarTypeInfo(code);
				if (carTypeInfo != null)
				{
					switch (i)
					{
					case 0:
						((Control)checkBoxCar1).set_Text(carTypeInfo.CarName);
						break;
					case 1:
						((Control)checkBoxCar2).set_Text(carTypeInfo.CarName);
						break;
					case 2:
						((Control)checkBoxCar3).set_Text(carTypeInfo.CarName);
						break;
					case 3:
						((Control)checkBoxCar4).set_Text(carTypeInfo.CarName);
						break;
					case 4:
						((Control)checkBoxCar5).set_Text(carTypeInfo.CarName);
						break;
					case 5:
						((Control)checkBoxCar6).set_Text(carTypeInfo.CarName);
						break;
					case 6:
						((Control)checkBoxCar7).set_Text(carTypeInfo.CarName);
						break;
					case 7:
						((Control)checkBoxCar8).set_Text(carTypeInfo.CarName);
						break;
					case 8:
						((Control)checkBoxCar9).set_Text(carTypeInfo.CarName);
						break;
					case 9:
						((Control)checkBoxCar10).set_Text(carTypeInfo.CarName);
						break;
					}
					listCars.get_Items().get_Item(text).get_SubItems()
						.Add(carTypeInfo.CarName);
					listCars.get_Items().get_Item(text).get_SubItems()
						.Add(carTypeInfo.CarPrice.ToString());
					listCars.get_Items().get_Item(text).get_SubItems()
						.Add(carTypeInfo.MinuteMoney.ToString());
					listCars.get_Items().get_Item(text).get_SubItems()
						.Add(StringChar.GetStringTime(carInfo.iTime));
					if (carInfo.iTime > 720)
					{
						if (carInfo.QQNum.Length > 3)
						{
							listCars.get_Items().get_Item(text).get_SubItems()
								.Add((carTypeInfo.MinuteMoney * 60 * 12).ToString());
							num2 += carTypeInfo.MinuteMoney * 60 * 12;
						}
						else
						{
							listCars.get_Items().get_Item(text).get_SubItems()
								.Add("0");
						}
						listCars.get_Items().get_Item(text).set_ForeColor(Color.Red);
					}
					else if (carInfo.QQNum.Length > 3)
					{
						listCars.get_Items().get_Item(text).get_SubItems()
							.Add((carTypeInfo.MinuteMoney * carInfo.iTime).ToString());
						num2 += carTypeInfo.MinuteMoney * carInfo.iTime;
					}
					else
					{
						listCars.get_Items().get_Item(text).get_SubItems()
							.Add("0");
					}
					listCars.get_Items().get_Item(text).get_SubItems()
						.get_Item(7)
						.set_Tag((object)carInfo.iTime);
					num += carTypeInfo.MinuteMoney * 60 * 24;
					m_iSumMiniteDoMoney += carTypeInfo.MinuteMoney;
				}
				else
				{
					listCars.get_Items().get_Item(text).get_SubItems()
						.Add(carInfo.CarName);
					listCars.get_Items().get_Item(text).get_SubItems()
						.Add(carInfo.CarPrice);
					listCars.get_Items().get_Item(text).get_SubItems()
						.Add(carInfo.MinuteMoney.ToString());
					listCars.get_Items().get_Item(text).get_SubItems()
						.Add(StringChar.GetStringTime(carInfo.iTime));
					listCars.get_Items().get_Item(text).get_SubItems()
						.Add((carInfo.MinuteMoney * carInfo.iTime).ToString());
					num2 += carInfo.MinuteMoney * carInfo.iTime;
					num += carInfo.MinuteMoney * 60 * 24;
					m_iSumMiniteDoMoney += carInfo.MinuteMoney;
				}
				listCars.get_Items().get_Item(text).get_SubItems()
					.Add(carInfo.reportUin);
				if (carInfo.reportUin.Length > 2)
				{
					listCars.get_Items().get_Item(text).set_BackColor(Color.GreenYellow);
				}
			}
			for (int k = 0; k < count; k++)
			{
				CarInfo carInfo2 = m_user_current.m_qc.GetCarInfo(k);
				if (carInfo2 == null)
				{
					continue;
				}
				string text2 = k.ToString();
				listCarInfo.get_Items().Add(text2, carInfo2.QQNum, 0);
				if (m_user_current.m_qf != null)
				{
					for (int l = 0; l < m_user_current.m_qf.GetCount(); l++)
					{
						FriendInfo friendInfo2 = m_user_current.m_qf.GetFriendInfo(l);
						if (friendInfo2.QQNum == carInfo2.QQNum)
						{
							carInfo2.QQName = friendInfo2.QQName;
							break;
						}
					}
				}
				listCarInfo.get_Items().get_Item(text2).get_SubItems()
					.Add(carInfo2.QQName);
				listCarInfo.get_Items().get_Item(text2).get_SubItems()
					.Add(carInfo2.CarNum);
				listCarInfo.get_Items().get_Item(text2).get_SubItems()
					.Add(carInfo2.CarColor);
				int num3 = StringChar.SToInt(carInfo2.CarName);
				CarTypeInfo carTypeInfo2 = ct.GetCarTypeInfo(num3);
				if (carTypeInfo2 != null)
				{
					listCarInfo.get_Items().get_Item(text2).get_SubItems()
						.Add(carTypeInfo2.CarName);
					listCarInfo.get_Items().get_Item(text2).get_SubItems()
						.get_Item(4)
						.set_Tag((object)num3);
					listCarInfo.get_Items().get_Item(text2).get_SubItems()
						.Add(carTypeInfo2.CarPrice.ToString());
					listCarInfo.get_Items().get_Item(text2).get_SubItems()
						.Add(carTypeInfo2.MinuteMoney.ToString());
					listCarInfo.get_Items().get_Item(text2).get_SubItems()
						.Add(StringChar.GetStringTime(carInfo2.iTime));
					if (carInfo2.iTime > 720)
					{
						if (carInfo2.QQNum.Length > 3)
						{
							listCarInfo.get_Items().get_Item(text2).get_SubItems()
								.Add((carTypeInfo2.MinuteMoney * 60 * 12).ToString());
						}
						else
						{
							listCarInfo.get_Items().get_Item(text2).get_SubItems()
								.Add("0");
						}
					}
					else if (carInfo2.QQNum.Length > 3)
					{
						listCarInfo.get_Items().get_Item(text2).get_SubItems()
							.Add((carTypeInfo2.MinuteMoney * carInfo2.iTime).ToString());
					}
					else
					{
						listCarInfo.get_Items().get_Item(text2).get_SubItems()
							.Add("0");
					}
					listCarInfo.get_Items().get_Item(text2).get_SubItems()
						.get_Item(7)
						.set_Tag((object)carInfo2.iTime);
				}
				else
				{
					listCarInfo.get_Items().get_Item(text2).get_SubItems()
						.Add(carInfo2.CarName);
					listCarInfo.get_Items().get_Item(text2).get_SubItems()
						.get_Item(4)
						.set_Tag((object)num3);
					listCarInfo.get_Items().get_Item(text2).get_SubItems()
						.Add(carInfo2.CarPrice);
					listCarInfo.get_Items().get_Item(text2).get_SubItems()
						.Add(carInfo2.MinuteMoney.ToString());
					listCarInfo.get_Items().get_Item(text2).get_SubItems()
						.Add(StringChar.GetStringTime(carInfo2.iTime));
					listCarInfo.get_Items().get_Item(text2).get_SubItems()
						.Add((carInfo2.MinuteMoney * carInfo2.iTime).ToString());
				}
			}
			((Control)listCars).Update();
			((Control)listCarInfo).Update();
			((Control)label9).set_Text("每日能盈利：" + num);
			((Control)label10).set_Text("当前已盈利 ：" + num2);
			((Control)label63).set_Text("当前已盈利 ：" + num2);
			((Control)label11).set_Text("现金：" + m_user_current.m_qc.GetSelfMoney());
			((Control)label7).set_Text("现金：" + m_user_current.m_qc.GetSelfMoney());
			m_iCurrentMoney = m_user_current.m_qc.GetSelfMoney();
			m_iYinli = num2;
			m_lSumMoney = m_iCurrentMoney + m_iYinli;
			if (m_bAddTieTiao)
			{
				m_lSumMoney += m_iTietiao;
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		((Control)buttonRefres2).set_Enabled(true);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	public static void ThreadProcQuery(object date)
	{
		FriendInfo friendInfo = (FriendInfo)date;
		if (friendInfo != null)
		{
			QueryPark queryPark = new QueryPark();
			queryPark.QueryEmptyParker(m_user_current.m_hh, friendInfo.QQNum);
			friendInfo.m_iEmptyNum = queryPark.GetEmptyCount();
			friendInfo.m_ilastLogin = queryPark.GetLastLogin();
			friendInfo.m_iLoveColor = queryPark.m_iLoveColor;
			friendInfo.m_sDengji = queryPark.m_sDengji;
			friendInfo.m_sJinYan = queryPark.m_sJinYan;
			friendInfo.bThread = false;
		}
	}

	public void RefresFriend(bool bXianShiXiangXi)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		try
		{
			if (m_user_current == null)
			{
				MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			((Control)buttonSaveFriend).set_Enabled(false);
			((Control)button77).set_Enabled(false);
			((Control)buttonRefres3).set_Enabled(false);
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			m_user_current.m_qf.QueryFriendsInfo();
			listFriend.get_Items().Clear();
			int num = 0;
			long count = m_user_current.m_qf.GetCount();
			fp.ReadFriend(m_user_current.m_sQQnum);
			if (m_bShowAllTime || bXianShiXiangXi)
			{
				Collection<Thread> collection = new Collection<Thread>();
				for (int i = 0; i < count; i++)
				{
					FriendInfo friendInfo = m_user_current.m_qf.GetFriendInfo(i);
					if (friendInfo != null && (!m_bShowBMD || fp.FindFriend(friendInfo.QQNum)))
					{
						Thread thread = new Thread(ThreadProcQuery);
						collection.Add(thread);
						friendInfo.bThread = true;
						thread.Start(friendInfo);
					}
				}
				num = 0;
				bool flag;
				do
				{
					num = 0;
					flag = true;
					for (int j = 0; j < count; j++)
					{
						FriendInfo friendInfo2 = m_user_current.m_qf.GetFriendInfo(j);
						if (friendInfo2 != null && (!m_bShowBMD || fp.FindFriend(friendInfo2.QQNum)))
						{
							if (friendInfo2.bThread)
							{
								flag = false;
							}
							else if (num < collection.Count)
							{
								collection[num].Abort();
							}
							num++;
						}
					}
				}
				while (!flag);
			}
			listFriend.set_View((View)1);
			DateTime now = DateTime.Now;
			long num2 = 0L;
			long num3 = 0L;
			num = 0;
			for (int k = 0; k < count; k++)
			{
				FriendInfo friendInfo3 = m_user_current.m_qf.GetFriendInfo(k);
				if (friendInfo3 != null)
				{
					num++;
					if (friendInfo3.QQNum == m_user_current.m_sQQnum)
					{
						num2 = num;
						if (k > 0)
						{
							FriendInfo friendInfo4 = m_user_current.m_qf.GetFriendInfo(k - 1);
							long num4 = StringChar.SToLong(friendInfo4.CarPrice) + StringChar.SToLong(friendInfo4.Cash);
							long num5 = StringChar.SToLong(friendInfo3.CarPrice) + StringChar.SToLong(friendInfo3.Cash);
							num3 = num4 - num5;
						}
					}
					if (m_bShowBMD && !fp.FindFriend(friendInfo3.QQNum))
					{
						continue;
					}
					k.ToString();
					ListViewItem val = new ListViewItem(friendInfo3.QQNum);
					val.set_ForeColor(Color.Blue);
					val.get_SubItems().Add(friendInfo3.QQName);
					val.get_SubItems().Add(friendInfo3.Cash);
					val.get_SubItems().Add(friendInfo3.CarPrice);
					if (friendInfo3.isDirty == 1)
					{
						val.get_SubItems().Add("垃圾场 ");
						val.set_ForeColor(Color.Red);
					}
					else
					{
						val.get_SubItems().Add("干净");
					}
					if (!m_bShowAllTime && !bXianShiXiangXi)
					{
						if (friendInfo3.full == 1)
						{
							val.get_SubItems().Add("满");
							val.set_ForeColor(Color.Black);
						}
						else
						{
							val.get_SubItems().Add("有空位");
						}
					}
					else if (friendInfo3.m_iEmptyNum > 0 && friendInfo3.full != 1)
					{
						val.get_SubItems().Add("空位 " + friendInfo3.m_iEmptyNum + " 个");
					}
					else
					{
						val.get_SubItems().Add("满");
						val.set_ForeColor(Color.Black);
					}
					if ((!m_bShowAllTime && !bXianShiXiangXi) || friendInfo3.full != 0)
					{
					}
					if (!m_bShowAllTime && !bXianShiXiangXi)
					{
						val.get_SubItems().Add("");
						val.get_SubItems().Add("");
						val.get_SubItems().Add("");
					}
					else
					{
						val.get_SubItems().Add(ct.carColor[friendInfo3.m_iLoveColor - 1]);
						val.get_SubItems().Add(friendInfo3.m_sDengji);
						val.get_SubItems().Add(friendInfo3.m_sJinYan);
					}
					if ((m_bShowAllTime || bXianShiXiangXi) && friendInfo3.m_ilastLogin > 0)
					{
						val.get_SubItems().Add(now.AddSeconds(-friendInfo3.m_ilastLogin).ToString("yyyy-MM-dd HH:mm:ss"));
					}
					else
					{
						val.get_SubItems().Add("");
					}
					if (friendInfo3.isDirty == 1)
					{
						val.set_ForeColor(Color.Red);
					}
					if (fp.FindFriend(friendInfo3.QQNum))
					{
						val.set_Checked(true);
					}
					listFriend.get_Items().Add(val);
				}
				((Control)label4).set_Text("你在好友圈内排行位数：" + num2);
				((Control)labelChaJu).set_Text("与上一名差距：" + num3);
			}
			((Control)listFriend).Update();
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		((Control)buttonSaveFriend).set_Enabled(true);
		((Control)button77).set_Enabled(true);
		((Control)buttonRefres3).set_Enabled(true);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	public void StopCars()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Invalid comparison between Unknown and I4
		try
		{
			if (m_user_current == null)
			{
				MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			User user = null;
			if (m_bGoBack)
			{
				string text = ((Control)comboExcessQQ).get_Text();
				if (text == null || !(text != string.Empty) || !(text != ""))
				{
					MessageBox.Show("请选择过渡停车场", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
					return;
				}
				bool flag = false;
				string qQNum = StringChar.GetQQNum(text);
				for (int i = 0; i < listUser.get_Items().get_Count(); i++)
				{
					string text2 = listUser.get_Items().get_Item(i).get_SubItems()
						.get_Item(0)
						.get_Text();
					if (qQNum == text2)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					MessageBox.Show("过渡停车场的QQ号还没登陆，不能自动回停", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
					return;
				}
				sQQNumExcess = StringChar.GetQQNum(((Control)comboExcessQQ).get_Text());
				user = GetUserByQQNum(sQQNumExcess);
				if (user == null)
				{
					MessageBox.Show("获取过渡停车场信息失败", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
					return;
				}
				fp.WriteIniData("config", "Excess", ((Control)comboExcessQQ).get_Text(), m_strConfigPath);
			}
			((Control)buttonTie).set_Enabled(false);
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			bool flag2 = false;
			string text3 = null;
			string text4 = null;
			string text5 = null;
			long num = listPark.get_Items().get_Count();
			for (int j = 1; j < num; j++)
			{
				if (!listPark.get_Items().get_Item(j).get_Checked())
				{
					continue;
				}
				flag2 = true;
				text3 = listPark.get_Items().get_Item(j).get_SubItems()
					.get_Item(0)
					.get_Text()
					.Trim();
				text4 = listPark.get_Items().get_Item(j).get_SubItems()
					.get_Item(2)
					.get_Text()
					.Trim();
				text5 = listPark.get_Items().get_Item(j).get_SubItems()
					.get_Item(3)
					.get_Text()
					.Trim();
				if (text3 == null || text3 == string.Empty)
				{
					continue;
				}
				User userByQQNum = GetUserByQQNum(text3);
				if (userByQQNum == null && m_bGoBack)
				{
					DialogResult val = MessageBox.Show("号码为[" + text3 + "]的车辆没有登陆,将不能进行回停，是否继续?", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
					if ((int)val == 7)
					{
						((Control)buttonTie).set_Enabled(true);
						((Control)this).set_Cursor(Cursors.get_Default());
						return;
					}
				}
				string text6 = m_user_current.m_spc.ProStopCars(text3, text4, text5, m_strTiTiaoLiuYan);
				if (text6 != null)
				{
					int num2 = 0;
					while (true)
					{
						if (m_iJuBaoTime > 0)
						{
							Thread.Sleep(m_iJuBaoTime);
						}
						text6 = m_user_current.m_spc.ProStopCars(text3, text4, text5, m_strTiTiaoLiuYan);
						if (text6 == null || num2 > iReCount)
						{
							break;
						}
						num2++;
					}
				}
				if (text6 != null || !m_bGoBack)
				{
					continue;
				}
				User userByQQNum2 = GetUserByQQNum(text3);
				if (userByQQNum2 == null)
				{
					continue;
				}
				string outparkno = null;
				userByQQNum2.m_stc.InitPark(sQQNumExcess);
				text6 = userByQQNum2.m_stc.ProStartCars(text4, null, out outparkno);
				if (text6 != null)
				{
					int num3 = 0;
					while (true)
					{
						if (m_iJuBaoTime > 0)
						{
							Thread.Sleep(m_iJuBaoTime);
						}
						text6 = userByQQNum2.m_stc.ProStartCars(text4, null, out outparkno);
						if (text6 == null || num3 > iReCount)
						{
							break;
						}
						num3++;
					}
				}
				if (text6 != null)
				{
					continue;
				}
				text6 = user.m_spc.ProStopCars(text3, text4, outparkno, m_strTiTiaoLiuYan);
				if (text6 != null)
				{
					int num4 = 0;
					while (true)
					{
						if (m_iJuBaoTime > 0)
						{
							Thread.Sleep(m_iJuBaoTime);
						}
						text6 = user.m_spc.ProStopCars(text3, text4, outparkno, m_strTiTiaoLiuYan);
						if (text6 == null || num4 > iReCount)
						{
							break;
						}
						num4++;
					}
				}
				if (text6 != null)
				{
					continue;
				}
				userByQQNum2.m_stc.InitPark(m_user_current.m_sQQnum);
				text6 = userByQQNum2.m_stc.ProStartCars(text4, null, out outparkno);
				if (text6 == null)
				{
					continue;
				}
				int num5 = 0;
				while (true)
				{
					if (m_iJuBaoTime > 0)
					{
						Thread.Sleep(m_iJuBaoTime);
					}
					text6 = userByQQNum2.m_stc.ProStartCars(text4, null, out outparkno);
					if (text6 == null || num5 > iReCount)
					{
						break;
					}
					num5++;
				}
			}
			if (flag2)
			{
				RefresParker();
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		((Control)buttonTie).set_Enabled(true);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void toolStripMenuItem_10_Click(object sender, EventArgs e)
	{
		string listSelectQQNum = GetListSelectQQNum();
		if (listSelectQQNum == null || !(listSelectQQNum != string.Empty))
		{
			return;
		}
		for (int i = 0; i < 10; i++)
		{
			try
			{
				Clipboard.SetText(listSelectQQNum);
				break;
			}
			catch
			{
			}
		}
	}

	private void toolStripMenuItem_11_Click(object sender, EventArgs e)
	{
		if (iListFocus == 2)
		{
			StopCars();
		}
	}

	private void listUser_MouseUp(object sender, MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		iListFocus = 1;
		if ((int)e.get_Button() == 1048576)
		{
			ChangeUser();
		}
	}

	public void ChangeUser()
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		if (listUser.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		string text = listUser.get_SelectedItems().get_Item(0).get_SubItems()
			.get_Item(0)
			.get_Text();
		if (m_user_current != null && text == m_user_current.m_sQQnum)
		{
			return;
		}
		m_user_current = null;
		m_sPKQQNum = "";
		m_sJuBaoQQNum = "";
		foreach (User user in m_UserList)
		{
			if (user.m_sQQnum == text)
			{
				m_user_current = user;
			}
		}
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		for (int i = 0; i < listUser.get_Items().get_Count(); i++)
		{
			listUser.get_Items().get_Item(i).set_ForeColor(Color.Black);
		}
		listUser.get_SelectedItems().get_Item(0).set_ForeColor(Color.Blue);
		((Control)comboQQNum).set_Text(m_user_current.m_sQQnum + " [" + m_user_current.m_sQQnick + "]");
		((Control)textQQPass).set_Text(m_user_current.m_sQQpass);
		RefresALL();
		((Control)textBoxNuLiShiJian).set_Text("");
	}

	private void listPark_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 2;
	}

	private void listCars_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 3;
	}

	private void listFriend_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 4;
	}

	private void listCarInfo_MouseUp(object sender, MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		iListFocus = 5;
		if ((int)e.get_Button() != 1048576 || listCarInfo.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		m_sDoCarid = listCarInfo.get_SelectedItems().get_Item(0).get_SubItems()
			.get_Item(2)
			.get_Text();
		m_iDoCarCode = (int)listCarInfo.get_SelectedItems().get_Item(0).get_SubItems()
			.get_Item(4)
			.get_Tag();
		for (int i = 0; i < listCarInfo.get_Items().get_Count(); i++)
		{
			if (listCarInfo.get_Items().get_Item(i).get_ForeColor() != Color.Black)
			{
				listCarInfo.get_Items().get_Item(i).set_ForeColor(Color.Black);
			}
		}
		listCarInfo.get_SelectedItems().get_Item(0).set_ForeColor(Color.SkyBlue);
		ProYuGouTime();
	}

	private void listBuyCar_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 6;
		if (listBuyCar.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		m_sBuyCarCode = listBuyCar.get_SelectedItems().get_Item(0).get_SubItems()
			.get_Item(3)
			.get_Text();
		for (int i = 0; i < listBuyCar.get_Items().get_Count(); i++)
		{
			if (listBuyCar.get_Items().get_Item(i).get_BackColor() != Color.White)
			{
				listBuyCar.get_Items().get_Item(i).set_BackColor(Color.White);
			}
		}
		listBuyCar.get_SelectedItems().get_Item(0).set_BackColor(Color.Blue);
	}

	private void listBox1_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 7;
	}

	private void listBox2_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 8;
	}

	private void listSlave_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 9;
	}

	private void listQueryPark_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 10;
	}

	private void listQueryCars_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 11;
	}

	private void listJubaoPark_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 12;
	}

	private void listJubaoCars_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 13;
	}

	private void listBoxMy_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 14;
	}

	private void listBoxMast_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 15;
	}

	private void listViewSlave_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 16;
	}

	private void listView9_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 17;
	}

	private void listViewAllFriend_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 18;
	}

	private void listViewPaiMin_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 19;
	}

	private void listView18_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 20;
	}

	private void listView16_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 21;
	}

	private void listView_0_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 22;
	}

	private void listView_1_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 23;
	}

	private void listViewCity_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 24;
	}

	private void listViewJc_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 25;
	}

	private void listViewPK1_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 27;
	}

	private void listViewPK2_MouseUp(object sender, MouseEventArgs e)
	{
		iListFocus = 28;
	}

	public string GetListSelectQQNum()
	{
		string result = null;
		if (iListFocus == 1 && listUser.get_SelectedItems().get_Count() > 0)
		{
			result = listUser.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 2 && listPark.get_SelectedItems().get_Count() > 0)
		{
			result = listPark.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 3 && listCars.get_SelectedItems().get_Count() > 0)
		{
			result = listCars.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 4 && listFriend.get_SelectedItems().get_Count() > 0)
		{
			result = listFriend.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 5 && listCarInfo.get_SelectedItems().get_Count() > 0)
		{
			result = listCarInfo.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 7)
		{
			result = sQueryQQBuyFriendMe;
		}
		if (iListFocus == 8)
		{
			result = sQueryQQBuyFriendMaster;
		}
		if (iListFocus == 9 && listSlave.get_SelectedItems().get_Count() > 0)
		{
			result = listSlave.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 10 && listQueryPark.get_SelectedItems().get_Count() > 0)
		{
			result = listQueryPark.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 11 && listQueryCars.get_SelectedItems().get_Count() > 0)
		{
			result = listQueryCars.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 12 && listJubaoPark.get_SelectedItems().get_Count() > 0)
		{
			result = listJubaoPark.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 13 && listJubaoCars.get_SelectedItems().get_Count() > 0)
		{
			result = listJubaoCars.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 14)
		{
			result = sBuyFriendMe;
		}
		if (iListFocus == 15)
		{
			result = sBuyFriendMaster;
		}
		if (iListFocus == 16 && listViewSlave.get_SelectedItems().get_Count() > 0)
		{
			result = listViewSlave.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 17 && listViewMaiDeQi.get_SelectedItems().get_Count() > 0)
		{
			result = listViewMaiDeQi.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 18 && listViewAllFriend.get_SelectedItems().get_Count() > 0)
		{
			result = listViewAllFriend.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 19 && listViewPaiMin.get_SelectedItems().get_Count() > 0)
		{
			result = listViewPaiMin.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(1)
				.get_Text();
		}
		if (iListFocus == 20 && listView18.get_SelectedItems().get_Count() > 0)
		{
			result = listView18.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 21 && listView16.get_SelectedItems().get_Count() > 0)
		{
			result = listView16.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 22 && listView_0.get_SelectedItems().get_Count() > 0)
		{
			result = listView_0.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 23 && listView_1.get_SelectedItems().get_Count() > 0)
		{
			result = listView_1.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 24 && ((ListView)listViewCity).get_SelectedItems().get_Count() > 0)
		{
			result = ((ListView)listViewCity).get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 25 && listViewJc.get_SelectedItems().get_Count() > 0)
		{
			result = listViewJc.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 26 && listViewPK0.get_SelectedItems().get_Count() > 0)
		{
			result = listViewPK0.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 27 && listViewPK1.get_SelectedItems().get_Count() > 0)
		{
			result = listViewPK1.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 28 && listViewPK2.get_SelectedItems().get_Count() > 0)
		{
			result = listViewPK2.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		if (iListFocus == 29 && listView_2.get_SelectedItems().get_Count() > 0)
		{
			result = listView_2.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
		}
		return result;
	}

	public void ProYuGouTime()
	{
		CarTypeInfo carTypeInfo = ct.GetCarTypeInfo(m_iDoCarCode);
		if (m_sDoCarid == null || carTypeInfo == null)
		{
			return;
		}
		DateTime now = DateTime.Now;
		long num = m_iSumMiniteDoMoney;
		if (m_bAddTieTiao)
		{
			num += m_iSumMiniteDoTieTiao;
		}
		long num2 = carTypeInfo.CarPrice;
		for (int i = 0; i < listBuyCar.get_Items().get_Count(); i++)
		{
			int code = StringChar.SToInt(listBuyCar.get_Items().get_Item(i).get_SubItems()
				.get_Item(3)
				.get_Text());
			CarTypeInfo carTypeInfo2 = ct.GetCarTypeInfo(code);
			long num3 = carTypeInfo2.CarPrice;
			long num4 = num3 - num2;
			if (num4 <= 0L)
			{
				listBuyCar.get_Items().get_Item(i).get_SubItems()
					.get_Item(4)
					.set_Text("-");
				continue;
			}
			if (num4 > 0L && num4 < m_lSumMoney)
			{
				listBuyCar.get_Items().get_Item(i).get_SubItems()
					.get_Item(4)
					.set_Text("可以立刻换车");
				continue;
			}
			long num5 = num4 - m_lSumMoney;
			long num6 = num5 / num;
			DateTime dateTime = now.AddMinutes(num6);
			listBuyCar.get_Items().get_Item(i).get_SubItems()
				.get_Item(4)
				.set_Text(dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
		}
	}

	private void toolStripMenuItem_13_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		bool flag = false;
		try
		{
			string text = null;
			string listSelectQQNum = GetListSelectQQNum();
			if (listSelectQQNum.Length > 3)
			{
				m_user_current.m_stc.InitPark(listSelectQQNum);
				bool flag2 = false;
				long num = listCars.get_Items().get_Count();
				for (int i = 0; i < num; i++)
				{
					if (listCars.get_Items().get_Item(i).get_Checked())
					{
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					MessageBox.Show("请在车辆列表中勾选需要停车的车辆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
					return;
				}
				((Control)this).set_Cursor(Cursors.get_WaitCursor());
				for (int j = 0; j < num; j++)
				{
					if (listCars.get_Items().get_Item(j).get_Checked())
					{
						if (m_user_current.m_stc.IsFull())
						{
							MessageBox.Show("停车场已满！", "失败", (MessageBoxButtons)0, (MessageBoxIcon)16);
							break;
						}
						text = listCars.get_Items().get_Item(j).get_SubItems()
							.get_Item(2)
							.get_Text();
						string outparkno = null;
						string text2 = m_user_current.m_stc.ProStartCars(text, null, out outparkno);
						if (text2 != null)
						{
							MessageBox.Show(text2, "失败", (MessageBoxButtons)0, (MessageBoxIcon)16);
							listCars.get_Items().get_Item(j).set_Checked(true);
						}
						else
						{
							flag = true;
							listCars.get_Items().get_Item(j).set_Checked(false);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		if (flag)
		{
			RefresCars();
		}
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void toolStripMenuItem_26_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		bool flag = false;
		try
		{
			string text = null;
			string listSelectQQNum = GetListSelectQQNum();
			if (listSelectQQNum.Length > 3)
			{
				m_user_current.m_stc.InitPark(listSelectQQNum);
				bool flag2 = false;
				long num = listCars.get_Items().get_Count();
				for (int i = 0; i < num; i++)
				{
					if (listCars.get_Items().get_Item(i).get_Checked())
					{
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					MessageBox.Show("请在车辆列表中勾选需要停车的车辆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
					return;
				}
				((Control)this).set_Cursor(Cursors.get_WaitCursor());
				for (int j = 0; j < num; j++)
				{
					if (!listCars.get_Items().get_Item(j).get_Checked())
					{
						continue;
					}
					if (!m_user_current.m_stc.IsAiXinCheWeiFull())
					{
						text = listCars.get_Items().get_Item(j).get_SubItems()
							.get_Item(2)
							.get_Text();
						string outparkno = null;
						string text2 = m_user_current.m_stc.ProStartCars(text, "1", out outparkno);
						if (text2 != null)
						{
							if (text2.IndexOf("繁忙") != -1)
							{
								text2 = "该爱心车位不支持这个颜色";
							}
							MessageBox.Show(text2, "失败", (MessageBoxButtons)0, (MessageBoxIcon)16);
							listCars.get_Items().get_Item(j).set_Checked(true);
						}
						else
						{
							flag = true;
							listCars.get_Items().get_Item(j).set_Checked(false);
						}
						continue;
					}
					MessageBox.Show("爱心车位已满！", "失败", (MessageBoxButtons)0, (MessageBoxIcon)16);
					break;
				}
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		if (flag)
		{
			RefresCars();
		}
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void toolStripMenuItem_15_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		try
		{
			string text = ((Control)comboExcessQQ).get_Text();
			if (text == null || !(text != string.Empty) || !(text != ""))
			{
				MessageBox.Show("请选择过渡停车场", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			bool flag = false;
			string qQNum = StringChar.GetQQNum(text);
			for (int i = 0; i < listUser.get_Items().get_Count(); i++)
			{
				string text2 = listUser.get_Items().get_Item(i).get_SubItems()
					.get_Item(0)
					.get_Text();
				if (qQNum == text2)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				MessageBox.Show("过渡停车场的QQ号还没登陆，不能自动回停", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			sQQNumExcess = StringChar.GetQQNum(((Control)comboExcessQQ).get_Text());
			User userByQQNum = GetUserByQQNum(sQQNumExcess);
			if (userByQQNum == null)
			{
				MessageBox.Show("获取过渡停车场信息失败", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			string listSelectQQNum = GetListSelectQQNum();
			if (listSelectQQNum.Length < 4)
			{
				return;
			}
			string text3 = null;
			m_user_current.m_stc.InitPark(sQQNumExcess);
			if (m_user_current.m_stc.IsFull())
			{
				MessageBox.Show("过渡停车场已满！", "失败", (MessageBoxButtons)0, (MessageBoxIcon)16);
				return;
			}
			m_user_current.m_stc.InitPark(listSelectQQNum);
			if (m_user_current.m_stc.IsFull())
			{
				MessageBox.Show("好友停车场已满！", "失败", (MessageBoxButtons)0, (MessageBoxIcon)16);
				return;
			}
			bool flag2 = false;
			long num = listCars.get_Items().get_Count();
			for (int j = 0; j < num; j++)
			{
				if (listCars.get_Items().get_Item(j).get_Checked())
				{
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				MessageBox.Show("请在车辆列表中勾选需要过渡停车的车辆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			for (int k = 0; k < num; k++)
			{
				if (!listCars.get_Items().get_Item(k).get_Checked())
				{
					continue;
				}
				m_user_current.m_stc.InitPark(listSelectQQNum);
				if (!m_user_current.m_stc.IsFull())
				{
					text3 = listCars.get_Items().get_Item(k).get_SubItems()
						.get_Item(2)
						.get_Text();
					string outparkno = null;
					m_user_current.m_stc.InitPark(sQQNumExcess);
					string text4 = m_user_current.m_stc.ProStartCars(text3, null, out outparkno);
					if (text4 == null)
					{
						text4 = userByQQNum.m_spc.ProStopCars(m_user_current.m_sQQnum, text3, outparkno, m_strTiTiaoLiuYan);
						if (text4 == null)
						{
							m_user_current.m_stc.InitPark(listSelectQQNum);
							text4 = m_user_current.m_stc.ProStartCars(text3, null, out outparkno);
						}
					}
					continue;
				}
				MessageBox.Show("好友停车场已满！", "失败", (MessageBoxButtons)0, (MessageBoxIcon)16);
				break;
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		((Control)this).set_Cursor(Cursors.get_Default());
		RefresCars();
	}

	private void buttonYuan_Click(object sender, EventArgs e)
	{
		YuandiOrNuo(bYuandi: true);
	}

	private void buttonNuo_Click(object sender, EventArgs e)
	{
		YuandiOrNuo(bYuandi: false);
	}

	public void YuandiOrNuo(bool bYuandi)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		try
		{
			string text = ((Control)comboExcessQQ).get_Text();
			if (text == null || !(text != string.Empty) || !(text != ""))
			{
				MessageBox.Show("请选择过渡停车场", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			bool flag = false;
			string qQNum = StringChar.GetQQNum(text);
			for (int i = 0; i < listUser.get_Items().get_Count(); i++)
			{
				string text2 = listUser.get_Items().get_Item(i).get_SubItems()
					.get_Item(0)
					.get_Text();
				if (qQNum == text2)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				MessageBox.Show("过渡停车场的QQ号还没登陆，不能自动回停", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			sQQNumExcess = StringChar.GetQQNum(((Control)comboExcessQQ).get_Text());
			User userByQQNum = GetUserByQQNum(sQQNumExcess);
			if (userByQQNum == null)
			{
				MessageBox.Show("获取过渡停车场信息失败", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			fp.WriteIniData("config", "Excess", ((Control)comboExcessQQ).get_Text(), m_strConfigPath);
			string text3 = null;
			string text4 = null;
			m_user_current.m_stc.InitPark(sQQNumExcess);
			if (m_user_current.m_stc.IsFull())
			{
				MessageBox.Show("过渡停车场已满！", "失败", (MessageBoxButtons)0, (MessageBoxIcon)16);
				return;
			}
			bool flag2 = false;
			long num = listCars.get_Items().get_Count();
			for (int j = 0; j < num; j++)
			{
				if (listCars.get_Items().get_Item(j).get_Checked())
				{
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				MessageBox.Show("请在车辆列表中勾选需要原地停车或挪车的车辆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			for (int k = 0; k < num; k++)
			{
				if (!listCars.get_Items().get_Item(k).get_Checked())
				{
					continue;
				}
				text3 = listCars.get_Items().get_Item(k).get_SubItems()
					.get_Item(0)
					.get_Text();
				text4 = listCars.get_Items().get_Item(k).get_SubItems()
					.get_Item(2)
					.get_Text();
				string outparkno = null;
				m_user_current.m_stc.InitPark(sQQNumExcess);
				string text5 = m_user_current.m_stc.ProStartCars(text4, null, out outparkno);
				if (text5 != null)
				{
					int num2 = 0;
					while (true)
					{
						if (m_iJuBaoTime > 0)
						{
							Thread.Sleep(m_iJuBaoTime);
						}
						text5 = m_user_current.m_stc.ProStartCars(text4, null, out outparkno);
						if (text5 == null || num2 > iReCount)
						{
							break;
						}
						num2++;
					}
				}
				if (text5 != null)
				{
					continue;
				}
				text5 = userByQQNum.m_spc.ProStopCars(m_user_current.m_sQQnum, text4, outparkno, m_strTiTiaoLiuYan);
				if (text5 != null)
				{
					int num3 = 0;
					while (true)
					{
						if (m_iJuBaoTime > 0)
						{
							Thread.Sleep(m_iJuBaoTime);
						}
						text5 = userByQQNum.m_spc.ProStopCars(m_user_current.m_sQQnum, text4, outparkno, m_strTiTiaoLiuYan);
						if (text5 == null || num3 > iReCount)
						{
							break;
						}
						num3++;
					}
				}
				if (text5 != null || !bYuandi)
				{
					continue;
				}
				m_user_current.m_stc.InitPark(text3);
				text5 = m_user_current.m_stc.ProStartCars(text4, null, out outparkno);
				if (text5 == null)
				{
					continue;
				}
				int num4 = 0;
				while (true)
				{
					if (m_iJuBaoTime > 0)
					{
						Thread.Sleep(m_iJuBaoTime);
					}
					text5 = m_user_current.m_stc.ProStartCars(text4, null, out outparkno);
					if (text5 == null || num4 > iReCount)
					{
						break;
					}
					num4++;
				}
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		((Control)this).set_Cursor(Cursors.get_Default());
		RefresCars();
	}

	private void comboCarType_SelectedIndexChanged(object sender, EventArgs e)
	{
		listBuyCar.get_Items().Clear();
		long num = ct.GetCountByType(((ListControl)comboCarType).get_SelectedIndex() + 1);
		for (int i = 0; i < num; i++)
		{
			CarTypeInfo carTypeInfoByType = ct.GetCarTypeInfoByType(((ListControl)comboCarType).get_SelectedIndex() + 1, i);
			string text = i.ToString();
			listBuyCar.get_Items().Add(text, carTypeInfoByType.CarName, 0);
			listBuyCar.get_Items().get_Item(text).get_SubItems()
				.Add(carTypeInfoByType.CarPrice.ToString());
			listBuyCar.get_Items().get_Item(text).get_SubItems()
				.Add(carTypeInfoByType.MinuteMoney.ToString());
			listBuyCar.get_Items().get_Item(text).get_SubItems()
				.Add(carTypeInfoByType.code.ToString());
			listBuyCar.get_Items().get_Item(text).get_SubItems()
				.Add("");
			listBuyCar.get_Items().get_Item(text).get_SubItems()
				.Add(carTypeInfoByType.sColorType);
			if (carTypeInfoByType.sZsType == "0")
			{
				listBuyCar.get_Items().get_Item(text).get_SubItems()
					.Add("");
				continue;
			}
			listBuyCar.get_Items().get_Item(text).get_SubItems()
				.Add(carTypeInfoByType.sZsType);
			listBuyCar.get_Items().get_Item(text).set_ForeColor(Color.Red);
		}
		ProYuGouTime();
		m_sBuyCarCode = null;
	}

	private void buttonChangeCar_Click(object sender, EventArgs e)
	{
		ChangeCars();
	}

	private void buttonBuyCar_Click(object sender, EventArgs e)
	{
		BuyCars();
	}

	private void toolStripMenuItem_14_Click(object sender, EventArgs e)
	{
		ChangeCars();
	}

	private void toolStripMenuItem_12_Click(object sender, EventArgs e)
	{
		BuyCars();
	}

	public void ChangeCars()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Invalid comparison between Unknown and I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		bool flag = false;
		try
		{
			CarTypeInfo carTypeInfo = ct.GetCarTypeInfo(m_iDoCarCode);
			if (m_sDoCarid == null || carTypeInfo == null || m_sBuyCarCode == null)
			{
				return;
			}
			string carcolor = (((ListControl)comboCarColor).get_SelectedIndex() + 1).ToString();
			CarTypeInfo carTypeInfo2 = ct.GetCarTypeInfo(StringChar.SToInt(m_sBuyCarCode));
			string text = ((Control)comboCarColor).get_Text();
			string sColorType = carTypeInfo2.sColorType;
			if (sColorType.IndexOf(text) < 0)
			{
				DialogResult val = MessageBox.Show(carTypeInfo2.CarName + " 不支持此种颜色，如果买入，车辆将在网页中不显示\r\n支持颜色有：" + carTypeInfo2.sColorType + "\r\n是否确定非买不可？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
				if ((int)val != 6)
				{
					return;
				}
			}
			if (m_sDoCarid == null)
			{
				MessageBox.Show("请在上方车辆列表中选中需要换购的车辆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			if (m_sBuyCarCode != null)
			{
				CarTypeInfo carTypeInfo3 = ct.GetCarTypeInfo(StringChar.SToInt(m_sBuyCarCode));
				bool flag2 = true;
				if (carTypeInfo.CarPrice > carTypeInfo3.CarPrice)
				{
					DialogResult val2 = MessageBox.Show("是否确定购买低价的车？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
					if ((int)val2 != 6)
					{
						flag2 = false;
					}
				}
				if (flag2)
				{
					string text2 = m_user_current.m_bc.ProChangeCars(m_sBuyCarCode, carcolor, m_sDoCarid);
					if (text2 != null)
					{
						MessageBox.Show(text2, "失败", (MessageBoxButtons)0, (MessageBoxIcon)16);
					}
					else
					{
						flag = true;
					}
				}
			}
			else
			{
				MessageBox.Show("请在左边车辆类型列表中选中需要更换后的车辆类型", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		if (flag)
		{
			m_sDoCarid = null;
			m_iDoCarCode = 0;
			RefresCars();
		}
	}

	public void BuyCars()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		bool flag = false;
		try
		{
			if (m_sBuyCarCode == null)
			{
				return;
			}
			string text = (((ListControl)comboCarColor).get_SelectedIndex() + 1).ToString();
			CarTypeInfo carTypeInfo = ct.GetCarTypeInfo(StringChar.SToInt(m_sBuyCarCode));
			string text2 = ((Control)comboCarColor).get_Text();
			string sColorType = carTypeInfo.sColorType;
			if (sColorType.IndexOf(text2) < 0)
			{
				DialogResult val = MessageBox.Show(carTypeInfo.CarName + " 不支持此种颜色，如果买入，车辆将在网页中不显示\r\n支持颜色有：" + carTypeInfo.sColorType + "\r\n是否确定非买不可？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
				if ((int)val != 6)
				{
					return;
				}
			}
			text = (((ListControl)comboCarColor).get_SelectedIndex() + 1).ToString();
			string text3 = m_user_current.m_bc.ProBuyCars(m_sBuyCarCode, text);
			if (text3 != null)
			{
				MessageBox.Show(text3, "失败", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else
			{
				flag = true;
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		if (flag)
		{
			RefresCars();
		}
	}

	private void buttonDelete_Click(object sender, EventArgs e)
	{
		fp.DeleteUser(((Control)comboQQNum).get_Text());
		comboQQNum.get_Items().Remove((object)((Control)comboQQNum).get_Text());
		if (fp.GetCount() < 1)
		{
			((Control)comboQQNum).set_Text("");
			((Control)textQQPass).set_Text("");
		}
		else
		{
			((ListControl)comboQQNum).set_SelectedIndex(0);
		}
	}

	private void comboQQNum_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text = ((Control)comboQQNum).get_Text();
		if (text != null && text != string.Empty && text != "")
		{
			UserInfo userInfo = fp.GetUserInfo(text);
			if (userInfo != null && userInfo.sQQPass.Length > 1)
			{
				((Control)textQQPass).set_Text(userInfo.sQQPass);
			}
		}
	}

	private void comboExcessQQ_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text = ((Control)comboExcessQQ).get_Text();
		if (text != null && text != string.Empty && text != "")
		{
			fp.WriteIniData("config", "Excess", text, m_strConfigPath);
			sQQNumExcess = StringChar.GetQQNum(text);
		}
	}

	private User GetUserByQQNum(string sQQNum)
	{
		foreach (User user in m_UserList)
		{
			if (user != null && user.m_sQQnum == sQQNum)
			{
				return user;
			}
		}
		return null;
	}

	private void Main_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		button65_Click(sender, (EventArgs)(object)e);
		if (m_bCancel && (int)e.get_CloseReason() == 3)
		{
			((Control)this).Hide();
			((CancelEventArgs)(object)e).Cancel = true;
			return;
		}
		if (m_jubao != null)
		{
			m_jubao.Abort();
		}
		WinKey.UnregisterHotKey(((Control)this).get_Handle(), 100);
		foreach (Thread threadDxh in m_ThreadDxhList)
		{
			threadDxh.Abort();
		}
		string path = m_sExeDir + "\\ver.txt";
		File.Delete(path);
		if (m_tx != null)
		{
			m_tx.Abort();
		}
		foreach (Thread threadRz in m_ThreadRzList)
		{
			threadRz.Abort();
		}
		m_ThreadRzList.Clear();
		if (m_zj != null)
		{
			m_zj.Abort();
		}
		if (m_city != null)
		{
			m_city.Abort();
		}
		foreach (Thread threadZj in m_ThreadZjList)
		{
			threadZj.Abort();
		}
		m_ThreadZjList.Clear();
		if (m_fx != null)
		{
			m_fx.Abort();
		}
		if (m_jc != null)
		{
			m_jc.Abort();
		}
		foreach (Thread threadFx in m_ThreadFxList)
		{
			threadFx.Abort();
		}
		m_ThreadFxList.Clear();
	}

	private void listFriend_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		if (e.get_Column() == lvwColumnSorter.SortColumn)
		{
			if ((int)lvwColumnSorter.Order == 1)
			{
				lvwColumnSorter.Order = (SortOrder)2;
			}
			else
			{
				lvwColumnSorter.Order = (SortOrder)1;
			}
		}
		else
		{
			lvwColumnSorter.SortColumn = e.get_Column();
			lvwColumnSorter.Order = (SortOrder)1;
		}
		listFriend.Sort();
	}

	private void listUser_ColumnClick(object sender, ColumnClickEventArgs e)
	{
	}

	private void textBox1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.get_KeyValue() == Convert.ToChar(13))
		{
			string text = ((Control)textBox1).get_Text();
			if (text != null && text != string.Empty)
			{
				QueryQQ(text);
			}
		}
	}

	private void buttonQueryQQ_Click(object sender, EventArgs e)
	{
		string text = ((Control)textBox1).get_Text();
		if (text != null && text != string.Empty)
		{
			QueryQQ(text);
		}
	}

	private void toolStripMenuItem_16_Click(object sender, EventArgs e)
	{
		string listSelectQQNum = GetListSelectQQNum();
		if (listSelectQQNum != null && listSelectQQNum != string.Empty)
		{
			QueryQQ(listSelectQQNum);
		}
	}

	public void QueryQQ(string QQNum)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		m_sQueryQQZh = QQNum;
		if (QQNum.Length < 4)
		{
			return;
		}
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		try
		{
			((Control)textBox1).set_Text(QQNum);
			if (m_bBuyFriend)
			{
				QueryQQBuyFriend(QQNum);
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		try
		{
			if (m_bPark)
			{
				QueryQQParkZh(QQNum);
				QueryQQCarsZh(QQNum);
			}
		}
		catch (Exception ex2)
		{
			fp.WriteLog("[" + ex2.StackTrace + "][" + ex2.Message + "]\r\n", m_strLogPath);
		}
		try
		{
			if (m_bNormal)
			{
				QueryQQNormal(QQNum);
			}
		}
		catch (Exception ex3)
		{
			fp.WriteLog("[" + ex3.StackTrace + "][" + ex3.Message + "]\r\n", m_strLogPath);
		}
		try
		{
			if (m_bQuery6)
			{
				QueryQQFwzj(QQNum);
			}
		}
		catch (Exception ex4)
		{
			fp.WriteLog("[" + ex4.StackTrace + "][" + ex4.Message + "]\r\n", m_strLogPath);
		}
		try
		{
			if (m_bQuery5)
			{
				QueryQQMusic(QQNum);
			}
		}
		catch (Exception ex5)
		{
			fp.WriteLog("[" + ex5.StackTrace + "][" + ex5.Message + "]\r\n", m_strLogPath);
		}
		try
		{
			if (m_bQuery4)
			{
				QueryQQPhoto(QQNum);
			}
		}
		catch (Exception ex6)
		{
			fp.WriteLog("[" + ex6.StackTrace + "][" + ex6.Message + "]\r\n", m_strLogPath);
		}
		tabControl1.set_SelectedIndex(3);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	public void QueryQQPhoto(string QQNum)
	{
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		m_qplist = m_user_current.m_qn.ProQueryPhoto(QQNum);
		if (m_qplist != null)
		{
			listView20.get_Items().Clear();
			for (int i = 0; i < m_qplist.Count; i++)
			{
				QQPhotoInfo qQPhotoInfo = m_qplist[i];
				if (qQPhotoInfo != null)
				{
					string text = i.ToString();
					listView20.get_Items().Add(text, qQPhotoInfo.sName, 0);
					listView20.get_Items().get_Item(text).get_SubItems()
						.Add(qQPhotoInfo.sShuXing);
					listView20.get_Items().get_Item(text).get_SubItems()
						.Add(qQPhotoInfo.sNum);
				}
			}
			((Control)listView20).Update();
		}
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	public void QueryQQMusic(string QQNum)
	{
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		Collection<QQMusicInfo> collection = m_user_current.m_qn.ProQueryMusic(QQNum);
		if (collection != null)
		{
			listView19.get_Items().Clear();
			for (int i = 0; i < collection.Count; i++)
			{
				QQMusicInfo qQMusicInfo = collection[i];
				if (qQMusicInfo != null)
				{
					string text = i.ToString();
					listView19.get_Items().Add(text, qQMusicInfo.sName, 0);
					listView19.get_Items().get_Item(text).get_SubItems()
						.Add(qQMusicInfo.sMusicName);
					listView19.get_Items().get_Item(text).get_SubItems()
						.Add(qQMusicInfo.sDown);
				}
			}
			((Control)listView19).Update();
		}
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	public void QueryQQFwzj(string QQNum)
	{
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		Collection<QQFwzjInfo> collection = m_user_current.m_qn.ProQueryFangWenZuJi2(QQNum);
		if (collection != null)
		{
			listView18.get_Items().Clear();
			for (int i = 0; i < collection.Count; i++)
			{
				QQFwzjInfo qQFwzjInfo = collection[i];
				if (qQFwzjInfo != null)
				{
					string text = i.ToString();
					listView18.get_Items().Add(text, qQFwzjInfo.sQQNum, 0);
					listView18.get_Items().get_Item(text).get_SubItems()
						.Add(qQFwzjInfo.sQQName);
					listView18.get_Items().get_Item(text).get_SubItems()
						.Add(qQFwzjInfo.sQQKjName);
				}
			}
			((Control)listView18).Update();
		}
		Collection<QQFwzjInfo> collection2 = m_user_current.m_qn.ProQueryFangWenZuJi1(QQNum);
		if (collection2 != null)
		{
			listView16.get_Items().Clear();
			for (int j = 0; j < collection2.Count; j++)
			{
				QQFwzjInfo qQFwzjInfo2 = collection2[j];
				if (qQFwzjInfo2 != null)
				{
					string text2 = j.ToString();
					listView16.get_Items().Add(text2, qQFwzjInfo2.sQQNum, 0);
					listView16.get_Items().get_Item(text2).get_SubItems()
						.Add(qQFwzjInfo2.sQQName);
				}
			}
			((Control)listView16).Update();
		}
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	public void QueryQQBuyFriend(string QQNum)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		string text = m_user_current.m_qqq.QueryQQBuyFriend(QQNum);
		if (text != null)
		{
			MessageBox.Show(text, "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		FriendBuyInfo meFriendBuyInfo = m_user_current.m_qqq.GetMeFriendBuyInfo();
		FriendBuyInfo masterFriendBuyInfo = m_user_current.m_qqq.GetMasterFriendBuyInfo();
		if (meFriendBuyInfo != null)
		{
			listBox1.get_Items().Clear();
			listBox1.get_Items().Add((object)("帐  号：" + meFriendBuyInfo.sQQNum));
			listBox1.get_Items().Add((object)("昵  称：" + meFriendBuyInfo.sQQName));
			listBox1.get_Items().Add((object)("绰  号：" + meFriendBuyInfo.sCuohao));
			listBox1.get_Items().Add((object)("身  价：" + meFriendBuyInfo.sBuyMoney));
			listBox1.get_Items().Add((object)("总资产：" + meFriendBuyInfo.sCapital));
			listBox1.get_Items().Add((object)("现  金：" + meFriendBuyInfo.sMoney));
			listBox1.get_Items().Add((object)("奴  隶：" + meFriendBuyInfo.sHelot));
			listBox1.get_Items().Add((object)("性  别：" + meFriendBuyInfo.sSex));
			listBox1.get_Items().Add((object)("最近状态：" + meFriendBuyInfo.sState));
			listBox1.get_Items().Add((object)("开始时间：" + meFriendBuyInfo.sStartTime));
			listBox1.get_Items().Add((object)("结束时间：" + meFriendBuyInfo.sEndTime));
			listBox1.get_Items().Add((object)("经 验 值：" + meFriendBuyInfo.sExp));
			Stream pic = m_user_current.m_qqq.GetPic(meFriendBuyInfo.sQQNum);
			if (pic != null)
			{
				pictureBox1.set_Image(Image.FromStream(pic));
			}
			sQueryQQBuyFriendMe = meFriendBuyInfo.sQQNum;
		}
		listBox2.get_Items().Clear();
		if (masterFriendBuyInfo != null)
		{
			if (masterFriendBuyInfo.sQQNum != null && masterFriendBuyInfo.sQQNum != string.Empty)
			{
				listBox2.get_Items().Add((object)("帐  号：" + masterFriendBuyInfo.sQQNum));
				listBox2.get_Items().Add((object)("昵  称：" + masterFriendBuyInfo.sQQName));
				listBox2.get_Items().Add((object)("绰  号：" + masterFriendBuyInfo.sCuohao));
				listBox2.get_Items().Add((object)("身  价：" + masterFriendBuyInfo.sBuyMoney));
				listBox2.get_Items().Add((object)("总资产：" + masterFriendBuyInfo.sCapital));
				listBox2.get_Items().Add((object)("现  金：" + masterFriendBuyInfo.sMoney));
				listBox2.get_Items().Add((object)("奴  隶：" + masterFriendBuyInfo.sHelot));
				listBox2.get_Items().Add((object)("性  别：" + masterFriendBuyInfo.sSex));
				listBox2.get_Items().Add((object)("最近状态：" + masterFriendBuyInfo.sState));
				listBox2.get_Items().Add((object)("开始时间：" + masterFriendBuyInfo.sStartTime));
				listBox2.get_Items().Add((object)("结束时间：" + masterFriendBuyInfo.sEndTime));
				listBox2.get_Items().Add((object)("经 验 值：" + masterFriendBuyInfo.sExp));
				Stream pic2 = m_user_current.m_qqq.GetPic(masterFriendBuyInfo.sQQNum);
				if (pic2 != null)
				{
					pictureBox2.set_Image(Image.FromStream(pic2));
				}
				sQueryQQBuyFriendMaster = masterFriendBuyInfo.sQQNum;
			}
		}
		else
		{
			listBox2.get_Items().Add((object)"冇得主人");
			sQueryQQBuyFriendMaster = null;
			pictureBox2.set_Image((Image)null);
		}
		listSlave.get_Items().Clear();
		long count = m_user_current.m_qqq.GetCount();
		for (int i = 0; i < count; i++)
		{
			SlaveInfo slaveInfo = m_user_current.m_qqq.GetSlaveInfo(i);
			if (slaveInfo == null)
			{
				continue;
			}
			ListViewItem val = new ListViewItem(slaveInfo.sQQNum);
			val.get_SubItems().Add(slaveInfo.sQQName);
			val.get_SubItems().Add(slaveInfo.sCuohao);
			val.get_SubItems().Add(slaveInfo.sBuyMoney);
			val.get_SubItems().Add(slaveInfo.sCapital);
			val.get_SubItems().Add(slaveInfo.sMoney);
			val.get_SubItems().Add(slaveInfo.sHelot);
			val.get_SubItems().Add(slaveInfo.sBuyNum);
			val.get_SubItems().Add(slaveInfo.sBuyPrice);
			val.get_SubItems().Add(slaveInfo.sBuyTime);
			val.get_SubItems().Add(slaveInfo.sState);
			val.get_SubItems().Add(slaveInfo.sStartTime);
			val.get_SubItems().Add(slaveInfo.sEndTime);
			val.get_SubItems().Add(slaveInfo.sExp);
			if (slaveInfo.sStartTime.Length > 4)
			{
				long num = DateTime.Compare(DateTime.Now, slaveInfo.dEndTime);
				if (num < 0L)
				{
					val.set_ForeColor(Color.Red);
				}
			}
			listSlave.get_Items().Add(val);
		}
		((Control)listSlave).Update();
	}

	public void QueryQQParkZh(string QQNum)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		bool bPark = false;
		bool bPark2 = false;
		bool bPark3 = false;
		bool bPark4 = false;
		m_user_current.m_qp.QueryParkerInfo(QQNum, out bPark, out bPark2, out bPark3, out bPark4);
		((Control)label22).set_Text("现金：" + m_user_current.m_qp.GetSelfMoney());
		((Control)label21).set_Text("开通游戏日期：" + m_user_current.m_qp.GetStartGameTime().ToString());
		((Control)label64).set_Text("最后登录时间：" + DateTime.Now.AddSeconds(-m_user_current.m_qp.GetLastLogin()).ToString("yyyy-MM-dd HH:mm:ss"));
		((Control)label20).set_Text("车辆数：" + m_user_current.m_qp.GetHaveCarNum());
		((Control)label121).set_Text("等级：" + m_user_current.m_qp.m_sDengji);
		((Control)label120).set_Text("经验值：" + m_user_current.m_qp.m_sJinYan);
		long num = 0L;
		listQueryPark.get_Items().Clear();
		long num2 = m_user_current.m_qp.GetCount();
		for (int i = 0; i < num2; i++)
		{
			ParkInfo parkInfo = m_user_current.m_qp.GetParkInfo(i);
			if (parkInfo == null)
			{
				continue;
			}
			string text = i.ToString();
			listQueryPark.get_Items().Add(text, parkInfo.sQQNum, 0);
			listQueryPark.get_Items().get_Item(text).get_SubItems()
				.Add(parkInfo.sQQName);
			listQueryPark.get_Items().get_Item(text).get_SubItems()
				.Add(parkInfo.sCarNum);
			int code = StringChar.SToInt(parkInfo.sCarName);
			CarTypeInfo carTypeInfo = ct.GetCarTypeInfo(code);
			listQueryPark.get_Items().get_Item(text).get_SubItems()
				.Add(parkInfo.sParkID);
			if (carTypeInfo != null)
			{
				listQueryPark.get_Items().get_Item(text).get_SubItems()
					.Add(carTypeInfo.CarName);
				listQueryPark.get_Items().get_Item(text).get_SubItems()
					.Add(carTypeInfo.MinuteMoney.ToString());
				listQueryPark.get_Items().get_Item(text).get_SubItems()
					.Add(StringChar.GetStringTime(parkInfo.iTime));
				if (parkInfo.iTime > 720)
				{
					listQueryPark.get_Items().get_Item(text).get_SubItems()
						.Add((carTypeInfo.MinuteMoney * 60 * 12).ToString());
					num += carTypeInfo.MinuteMoney * 60 * 12;
					listQueryPark.get_Items().get_Item(text).set_ForeColor(Color.Red);
				}
				else
				{
					listQueryPark.get_Items().get_Item(text).get_SubItems()
						.Add((carTypeInfo.MinuteMoney * parkInfo.iTime).ToString());
					num += carTypeInfo.MinuteMoney * parkInfo.iTime;
				}
			}
			else
			{
				listQueryPark.get_Items().get_Item(text).get_SubItems()
					.Add(parkInfo.sCarName);
				listQueryPark.get_Items().get_Item(text).get_SubItems()
					.Add(parkInfo.iMinuteMoney.ToString());
				listQueryPark.get_Items().get_Item(text).get_SubItems()
					.Add(StringChar.GetStringTime(parkInfo.iTime));
				listQueryPark.get_Items().get_Item(text).get_SubItems()
					.Add((parkInfo.iMinuteMoney * parkInfo.iTime).ToString());
			}
		}
		((Control)listQueryPark).Update();
		((Control)label19).set_Text("贴条收入：" + num);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	public void QueryQQParkJb(string QQNum)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		bool bPark = false;
		bool bPark2 = false;
		bool bPark3 = false;
		bool bPark4 = false;
		m_user_current.m_qp.QueryParkerInfo(QQNum, out bPark, out bPark2, out bPark3, out bPark4);
		((Control)label55).set_Text("现金：" + m_user_current.m_qp.GetSelfMoney());
		((Control)label54).set_Text("开通游戏日期：" + m_user_current.m_qp.GetStartGameTime().ToString());
		((Control)label53).set_Text("车辆数：" + m_user_current.m_qp.GetHaveCarNum());
		long num = 0L;
		listJubaoPark.get_Items().Clear();
		long num2 = m_user_current.m_qp.GetCount();
		for (int i = 0; i < num2; i++)
		{
			ParkInfo parkInfo = m_user_current.m_qp.GetParkInfo(i);
			if (parkInfo == null)
			{
				continue;
			}
			string text = i.ToString();
			listJubaoPark.get_Items().Add(text, parkInfo.sQQNum, 0);
			listJubaoPark.get_Items().get_Item(text).get_SubItems()
				.Add(parkInfo.sQQName);
			listJubaoPark.get_Items().get_Item(text).get_SubItems()
				.Add(parkInfo.sCarNum);
			int code = StringChar.SToInt(parkInfo.sCarName);
			CarTypeInfo carTypeInfo = ct.GetCarTypeInfo(code);
			listJubaoPark.get_Items().get_Item(text).get_SubItems()
				.Add(parkInfo.sParkID);
			if (carTypeInfo != null)
			{
				listJubaoPark.get_Items().get_Item(text).get_SubItems()
					.Add(carTypeInfo.CarName);
				listJubaoPark.get_Items().get_Item(text).get_SubItems()
					.Add(carTypeInfo.MinuteMoney.ToString());
				listJubaoPark.get_Items().get_Item(text).get_SubItems()
					.Add(StringChar.GetStringTime(parkInfo.iTime));
				if (parkInfo.iTime > 720)
				{
					listJubaoPark.get_Items().get_Item(text).get_SubItems()
						.Add((carTypeInfo.MinuteMoney * 60 * 12).ToString());
					num += carTypeInfo.MinuteMoney * 60 * 12;
					listJubaoPark.get_Items().get_Item(text).set_ForeColor(Color.Red);
				}
				else
				{
					listJubaoPark.get_Items().get_Item(text).get_SubItems()
						.Add((carTypeInfo.MinuteMoney * parkInfo.iTime).ToString());
					num += carTypeInfo.MinuteMoney * parkInfo.iTime;
				}
			}
			else
			{
				listJubaoPark.get_Items().get_Item(text).get_SubItems()
					.Add(parkInfo.sCarName);
				listJubaoPark.get_Items().get_Item(text).get_SubItems()
					.Add(parkInfo.iMinuteMoney.ToString());
				listJubaoPark.get_Items().get_Item(text).get_SubItems()
					.Add(StringChar.GetStringTime(parkInfo.iTime));
				listJubaoPark.get_Items().get_Item(text).get_SubItems()
					.Add((parkInfo.iMinuteMoney * parkInfo.iTime).ToString());
			}
		}
		((Control)listJubaoPark).Update();
		((Control)label52).set_Text("贴条收入：" + num);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	public void QueryQQCarsZh(string QQNum)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		long num = 0L;
		long num2 = 0L;
		m_user_current.m_qc.QueryQQCarInfo(QQNum);
		listQueryCars.get_Items().Clear();
		long count = m_user_current.m_qc.GetCount();
		for (int i = 0; i < count; i++)
		{
			CarInfo carInfo = m_user_current.m_qc.GetCarInfo(i);
			if (carInfo == null)
			{
				continue;
			}
			string text = i.ToString();
			listQueryCars.get_Items().Add(text, carInfo.QQNum, 0);
			listQueryCars.get_Items().get_Item(text).get_SubItems()
				.Add(carInfo.QQName);
			listQueryCars.get_Items().get_Item(text).get_SubItems()
				.Add(carInfo.CarNum);
			listQueryCars.get_Items().get_Item(text).get_SubItems()
				.Add(carInfo.CarColor);
			int code = StringChar.SToInt(carInfo.CarName);
			CarTypeInfo carTypeInfo = ct.GetCarTypeInfo(code);
			if (carTypeInfo != null)
			{
				listQueryCars.get_Items().get_Item(text).get_SubItems()
					.Add(carTypeInfo.CarName);
				listQueryCars.get_Items().get_Item(text).get_SubItems()
					.Add(carTypeInfo.CarPrice.ToString());
				listQueryCars.get_Items().get_Item(text).get_SubItems()
					.Add(carTypeInfo.MinuteMoney.ToString());
				listQueryCars.get_Items().get_Item(text).get_SubItems()
					.Add(StringChar.GetStringTime(carInfo.iTime));
				if (carInfo.iTime > 720)
				{
					listQueryCars.get_Items().get_Item(text).get_SubItems()
						.Add((carTypeInfo.MinuteMoney * 60 * 12).ToString());
					num2 += carTypeInfo.MinuteMoney * 60 * 12;
					listQueryCars.get_Items().get_Item(text).set_ForeColor(Color.Red);
				}
				else
				{
					listQueryCars.get_Items().get_Item(text).get_SubItems()
						.Add((carTypeInfo.MinuteMoney * carInfo.iTime).ToString());
					num2 += carTypeInfo.MinuteMoney * carInfo.iTime;
				}
				listQueryCars.get_Items().get_Item(text).get_SubItems()
					.get_Item(7)
					.set_Tag((object)carInfo.iTime);
				num += carTypeInfo.MinuteMoney * 60 * 24;
			}
			else
			{
				listQueryCars.get_Items().get_Item(text).get_SubItems()
					.Add(carInfo.CarName);
				listQueryCars.get_Items().get_Item(text).get_SubItems()
					.Add(carInfo.CarPrice);
				listQueryCars.get_Items().get_Item(text).get_SubItems()
					.Add(carInfo.MinuteMoney.ToString());
				listQueryCars.get_Items().get_Item(text).get_SubItems()
					.Add(StringChar.GetStringTime(carInfo.iTime));
				listQueryCars.get_Items().get_Item(text).get_SubItems()
					.Add((carInfo.MinuteMoney * carInfo.iTime).ToString());
				num2 += carInfo.MinuteMoney * carInfo.iTime;
				num += carInfo.MinuteMoney * 60 * 24;
			}
		}
		((Control)listQueryCars).Update();
		((Control)label24).set_Text("每日能盈利：" + num);
		((Control)label23).set_Text("当前已盈利 ：" + num2);
		((Control)label22).set_Text("现金：" + m_user_current.m_qc.GetSelfMoney());
		if (count <= 0L)
		{
			((Control)label20).set_Text("车辆数：你无法查看TA的车");
		}
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void QueryQQCarsJb(User ur, string QQNum)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null && ur == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		if (ur == null)
		{
			ur = m_user_current;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		long num = 0L;
		long num2 = 0L;
		ur.m_qc.QueryQQCarInfo(QQNum);
		listJubaoCars.get_Items().Clear();
		long count = ur.m_qc.GetCount();
		for (int i = 0; i < count; i++)
		{
			CarInfo carInfo = ur.m_qc.GetCarInfo(i);
			if (carInfo == null)
			{
				continue;
			}
			string text = i.ToString();
			listJubaoCars.get_Items().Add(text, carInfo.QQNum, 0);
			listJubaoCars.get_Items().get_Item(text).set_Tag((object)carInfo.strParkNum);
			listJubaoCars.get_Items().get_Item(text).get_SubItems()
				.Add(carInfo.QQName);
			listJubaoCars.get_Items().get_Item(text).get_SubItems()
				.Add(carInfo.CarNum);
			listJubaoCars.get_Items().get_Item(text).get_SubItems()
				.Add(carInfo.CarColor);
			int code = StringChar.SToInt(carInfo.CarName);
			CarTypeInfo carTypeInfo = ct.GetCarTypeInfo(code);
			if (carTypeInfo != null)
			{
				listJubaoCars.get_Items().get_Item(text).get_SubItems()
					.Add(carTypeInfo.CarName);
				listJubaoCars.get_Items().get_Item(text).get_SubItems()
					.Add(carTypeInfo.CarPrice.ToString());
				listJubaoCars.get_Items().get_Item(text).get_SubItems()
					.Add(carTypeInfo.MinuteMoney.ToString());
				listJubaoCars.get_Items().get_Item(text).get_SubItems()
					.Add(StringChar.GetStringTime(carInfo.iTime));
				if (carInfo.iTime > 720)
				{
					listJubaoCars.get_Items().get_Item(text).get_SubItems()
						.Add((carTypeInfo.MinuteMoney * 60 * 12).ToString());
					num2 += carTypeInfo.MinuteMoney * 60 * 12;
					listJubaoCars.get_Items().get_Item(text).set_ForeColor(Color.Red);
				}
				else
				{
					listJubaoCars.get_Items().get_Item(text).get_SubItems()
						.Add((carTypeInfo.MinuteMoney * carInfo.iTime).ToString());
					num2 += carTypeInfo.MinuteMoney * carInfo.iTime;
				}
				listJubaoCars.get_Items().get_Item(text).get_SubItems()
					.get_Item(7)
					.set_Tag((object)carInfo.iTime);
				num += carTypeInfo.MinuteMoney * 60 * 24;
			}
			else
			{
				listJubaoCars.get_Items().get_Item(text).get_SubItems()
					.Add(carInfo.CarName);
				listJubaoCars.get_Items().get_Item(text).get_SubItems()
					.Add(carInfo.CarPrice);
				listJubaoCars.get_Items().get_Item(text).get_SubItems()
					.Add(carInfo.MinuteMoney.ToString());
				listJubaoCars.get_Items().get_Item(text).get_SubItems()
					.Add(StringChar.GetStringTime(carInfo.iTime));
				listJubaoCars.get_Items().get_Item(text).get_SubItems()
					.Add((carInfo.MinuteMoney * carInfo.iTime).ToString());
				num2 += carInfo.MinuteMoney * carInfo.iTime;
				num += carInfo.MinuteMoney * 60 * 24;
			}
		}
		((Control)listJubaoCars).Update();
		((Control)label57).set_Text("每日能盈利：" + num);
		((Control)label56).set_Text("当前已盈利 ：" + num2);
		((Control)label55).set_Text("现金：" + m_user_current.m_qc.GetSelfMoney());
		if (count <= 0L)
		{
			((Control)label53).set_Text("车辆数：你无法查看TA的车");
		}
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	public void QueryQQNormal(string QQNum)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		QQKjInfo qQKjInfo = m_user_current.m_qn.ProQueryNormalKongJian(QQNum);
		QQCsdrInfo qQCsdrInfo = m_user_current.m_qn.ProQueryNormalCity(QQNum);
		listBox3.get_Items().Clear();
		listBox5.get_Items().Clear();
		if (qQKjInfo != null)
		{
			listBox3.get_Items().Add((object)("空间名称：" + qQKjInfo.sSpacename));
			listBox3.get_Items().Add((object)("空间说明：" + qQKjInfo.sdesc));
			listBox3.get_Items().Add((object)("    昵称：" + qQKjInfo.sQQName));
			listBox3.get_Items().Add((object)("    性别：" + qQKjInfo.sSex));
			listBox3.get_Items().Add((object)("    年龄：" + qQKjInfo.sAge));
			listBox3.get_Items().Add((object)("    生日：" + qQKjInfo.sBirthday));
			listBox3.get_Items().Add((object)("  现居地：" + qQKjInfo.scountry + " " + qQKjInfo.sprovince + " " + qQKjInfo.scity));
			listBox3.get_Items().Add((object)("    婚姻：" + qQKjInfo.sMarriage));
			listBox3.get_Items().Add((object)("    血型：" + qQKjInfo.sBloodtype));
			listBox3.get_Items().Add((object)("    故乡：" + qQKjInfo.shco + " " + qQKjInfo.shp + " " + qQKjInfo.shc));
		}
		if (qQCsdrInfo != null)
		{
			listBox5.get_Items().Add((object)("    昵称：" + qQCsdrInfo.sQQName));
			listBox5.get_Items().Add((object)("    性别：" + qQCsdrInfo.sSex));
			listBox5.get_Items().Add((object)("    年龄：" + qQCsdrInfo.sAge));
			listBox5.get_Items().Add((object)("    生日：" + qQCsdrInfo.sBirthday));
			listBox5.get_Items().Add((object)("    星座：" + qQCsdrInfo.sastro));
			listBox5.get_Items().Add((object)("    身高：" + qQCsdrInfo.sheight));
			listBox5.get_Items().Add((object)("    体重：" + qQCsdrInfo.sweight));
			listBox5.get_Items().Add((object)("    血型：" + qQCsdrInfo.sBloodtype));
			listBox5.get_Items().Add((object)("    学历：" + qQCsdrInfo.seducation));
			listBox5.get_Items().Add((object)("    职业：" + qQCsdrInfo.sjob));
			listBox5.get_Items().Add((object)("  居住地：" + qQCsdrInfo.scity));
			listBox5.get_Items().Add((object)("    情感：" + qQCsdrInfo.semotion));
			listBox5.get_Items().Add((object)("交友目的：" + qQCsdrInfo.slongent));
			listBox5.get_Items().Add((object)("理想朋友：[居住地：" + qQCsdrInfo.smCity + "] [年龄：" + qQCsdrInfo.smAge + "] [身高：" + qQCsdrInfo.smHeight + "] [体重：" + qQCsdrInfo.smWeight + "]"));
		}
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void toolStripMenuItem_17_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		string listSelectQQNum = GetListSelectQQNum();
		if (listSelectQQNum != null && listSelectQQNum != string.Empty)
		{
			((Control)comboExcessQQ2).set_Text(listSelectQQNum);
			m_sQueryQQJb = listSelectQQNum;
			button30_Click(sender, e);
			tabControl1.set_SelectedIndex(1);
			tabControl3.set_SelectedIndex(1);
		}
	}

	private void button36_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listJubaoPark.get_Items().get_Count(); i++)
		{
			listJubaoPark.get_Items().get_Item(i).set_Checked(true);
		}
	}

	private void button34_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listJubaoCars.get_Items().get_Count(); i++)
		{
			listJubaoCars.get_Items().get_Item(i).set_Checked(true);
		}
	}

	private void button37_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listJubaoPark.get_Items().get_Count(); i++)
		{
			listJubaoPark.get_Items().get_Item(i).set_Checked(false);
		}
	}

	private void button35_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listJubaoCars.get_Items().get_Count(); i++)
		{
			listJubaoCars.get_Items().get_Item(i).set_Checked(false);
		}
	}

	private void button38_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)button38).set_Enabled(false);
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		bool flag = false;
		long num = listJubaoPark.get_Items().get_Count();
		for (int i = 0; i < num; i++)
		{
			if (!listJubaoPark.get_Items().get_Item(i).get_Checked())
			{
				continue;
			}
			text3 = listJubaoPark.get_Items().get_Item(i).get_SubItems()
				.get_Item(0)
				.get_Text();
			text4 = listJubaoPark.get_Items().get_Item(i).get_SubItems()
				.get_Item(1)
				.get_Text();
			text2 = listJubaoPark.get_Items().get_Item(i).get_SubItems()
				.get_Item(2)
				.get_Text();
			text = listJubaoPark.get_Items().get_Item(i).get_SubItems()
				.get_Item(3)
				.get_Text();
			if (text3 != null && !(text3 == string.Empty))
			{
				string text5 = m_user_current.m_jb.ProJuBao(text3, m_sQueryQQJb, text, text2);
				if (text5 == null)
				{
					flag = true;
					((TextBoxBase)textBox_1).AppendText(DateTime.Now.ToString("【HH:mm:ss】") + "举报【" + text4 + "】车牌号为【" + text2 + "】的车辆成功\r\n");
				}
				else
				{
					((TextBoxBase)textBox_1).AppendText(DateTime.Now.ToString("【HH:mm:ss】") + "举报【" + text4 + "】车牌号为【" + text2 + "】的车辆失败：" + text5 + "\r\n");
				}
				Thread.Sleep(m_iJuBaoTime);
			}
		}
		if (flag)
		{
			try
			{
				QueryQQParkJb(m_sQueryQQJb);
			}
			catch (Exception ex)
			{
				fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
			}
		}
		((Control)button38).set_Enabled(true);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void button32_Click(object sender, EventArgs e)
	{
		try
		{
			if (m_bPark)
			{
				QueryQQParkJb(m_sQueryQQJb);
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
	}

	private void button33_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		else
		{
			if (m_sQueryQQJb == null || m_sQueryQQJb == string.Empty)
			{
				return;
			}
			User userByQQNum = GetUserByQQNum(m_sQueryQQJb);
			((Control)button33).set_Enabled(false);
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			string text = "";
			string text2 = "";
			string text3 = "";
			string qQNick = m_user_current.m_qp.GetQQNick(m_sQueryQQJb);
			bool flag = false;
			long num = listJubaoCars.get_Items().get_Count();
			for (int i = 0; i < num; i++)
			{
				if (!listJubaoCars.get_Items().get_Item(i).get_Checked())
				{
					continue;
				}
				text3 = listJubaoCars.get_Items().get_Item(i).get_SubItems()
					.get_Item(0)
					.get_Text();
				text = listJubaoCars.get_Items().get_Item(i).get_SubItems()
					.get_Item(2)
					.get_Text();
				text2 = (string)listJubaoCars.get_Items().get_Item(i).get_Tag();
				if (text2 == null || text2.Length < 1)
				{
					continue;
				}
				string text4 = m_user_current.m_jb.ProJuBao(m_sQueryQQJb, text3, text2, text);
				if (text4 != null && text4.IndexOf("频繁") != -1)
				{
					int num2 = 0;
					while (true)
					{
						if (m_iJuBaoTime > 0)
						{
							Thread.Sleep(m_iJuBaoTime);
						}
						text4 = m_user_current.m_jb.ProJuBao(m_sQueryQQJb, text3, text2, text);
						if (text4 == null || num2 > iReCount)
						{
							break;
						}
						num2++;
					}
				}
				if (text4 == null)
				{
					flag = true;
					((TextBoxBase)textBox_1).AppendText(DateTime.Now.ToString("【HH:mm:ss】") + "举报【" + qQNick + "】车牌号为【" + text + "】的车辆成功\r\n");
				}
				else
				{
					((TextBoxBase)textBox_1).AppendText(DateTime.Now.ToString("【HH:mm:ss】") + "举报【" + qQNick + "】车牌号为【" + text + "】的车辆失败：" + text4 + "\r\n");
				}
				Thread.Sleep(m_iJuBaoTime);
			}
			if (flag)
			{
				try
				{
					if (userByQQNum != null)
					{
						QueryQQCarsJb(userByQQNum, m_sQueryQQJb);
					}
					else
					{
						QueryQQCarsJb(null, m_sQueryQQJb);
					}
				}
				catch (Exception ex)
				{
					fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
				}
			}
			((Control)button33).set_Enabled(true);
			((Control)this).set_Cursor(Cursors.get_Default());
		}
	}

	private void button31_Click(object sender, EventArgs e)
	{
		try
		{
			if (m_bPark)
			{
				User userByQQNum = GetUserByQQNum(m_sQueryQQJb);
				if (userByQQNum != null)
				{
					QueryQQCarsJb(userByQQNum, m_sQueryQQJb);
				}
				else
				{
					QueryQQCarsJb(null, m_sQueryQQJb);
				}
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
	}

	private void button30_Click(object sender, EventArgs e)
	{
		string qQNum = StringChar.GetQQNum(((Control)comboExcessQQ2).get_Text());
		if (qQNum == null || !(qQNum != string.Empty))
		{
			return;
		}
		try
		{
			m_sQueryQQJb = qQNum;
			QueryQQParkJb(qQNum);
			User userByQQNum = GetUserByQQNum(qQNum);
			if (userByQQNum != null)
			{
				QueryQQCarsJb(userByQQNum, qQNum);
			}
			else
			{
				QueryQQCarsJb(null, qQNum);
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
	}

	protected override void WndProc(ref Message m)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		int msg = ((Message)(ref m)).get_Msg();
		if (msg == 786)
		{
			ProcessHotkey(m);
		}
		((Form)this).WndProc(ref m);
	}

	private void ProcessHotkey(Message m)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Message)(ref m)).get_WParam().ToString();
		m_bKeyShowWindow = !m_bKeyShowWindow;
		if (!(text == "100"))
		{
			return;
		}
		if (m_bKeyShowWindow)
		{
			if (m_bm != null)
			{
				return;
			}
			if (m_bSuoDing)
			{
				m_bm = new BuKuaiMiMaInput();
				m_bm.m_sBuKuaiPass = m_sBuKuaiPass;
				((Form)m_bm).ShowDialog();
				if (!m_bm.m_bOK)
				{
					m_bm = null;
					return;
				}
			}
			m_bm = null;
			m_bSuoDing = false;
			notifyIcon1.set_Visible(true);
			((Control)this).Show();
		}
		else
		{
			notifyIcon1.set_Visible(false);
			((Control)this).Hide();
		}
	}

	private void checkBox9_CheckedChanged(object sender, EventArgs e)
	{
		m_bAddTieTiao = checkBox9.get_Checked();
		m_lSumMoney = m_iCurrentMoney + m_iYinli;
		if (m_bAddTieTiao)
		{
			m_lSumMoney += m_iTietiao;
		}
		ProYuGouTime();
	}

	private void toolStripMenuItem_19_Click(object sender, EventArgs e)
	{
		ProPiLiangTingChe();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		ProPiLiangTingChe();
	}

	public void ProPiLiangTingChe()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		try
		{
			string text = null;
			bool flag = false;
			long num = listCars.get_Items().get_Count();
			for (int i = 0; i < num; i++)
			{
				if (listCars.get_Items().get_Item(i).get_Checked())
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				MessageBox.Show("请在车辆列表中勾选需要停车的车辆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			flag = false;
			num = listFriend.get_Items().get_Count();
			for (int j = 0; j < num; j++)
			{
				if (listFriend.get_Items().get_Item(j).get_Checked())
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				MessageBox.Show("请在好友列表中勾选多个车位", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			WriteAllFriend();
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			num = listCars.get_Items().get_Count();
			for (int k = 0; k < num; k++)
			{
				if (listCars.get_Items().get_Item(k).get_Checked())
				{
					text = listCars.get_Items().get_Item(k).get_SubItems()
						.get_Item(2)
						.get_Text();
					ProPiLiangTingCheByCarID(text);
				}
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		RefresCars();
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	public bool ProPiLiangTingCheByCarID(string carid)
	{
		long num = listFriend.get_Items().get_Count();
		int num2 = 0;
		while (true)
		{
			if (num2 < num)
			{
				if (listFriend.get_Items().get_Item(num2).get_Checked())
				{
					string text = listFriend.get_Items().get_Item(num2).get_SubItems()
						.get_Item(0)
						.get_Text();
					m_user_current.m_stc.InitPark(text);
					if (!m_user_current.m_stc.IsFull())
					{
						string outparkno = null;
						string text2 = m_user_current.m_stc.ProStartCars(carid, null, out outparkno);
						if (text2 == null)
						{
							break;
						}
					}
				}
				num2++;
				continue;
			}
			return false;
		}
		if (m_iJuBaoTime > 0)
		{
			Thread.Sleep(m_iJuBaoTime);
		}
		return true;
	}

	public void WriteAllFriend()
	{
		fp.DeleteFriendFile(m_user_current.m_sQQnum);
		fp.ClearFriend();
		for (int i = 0; i < listFriend.get_Items().get_Count(); i++)
		{
			if (listFriend.get_Items().get_Item(i).get_Checked())
			{
				string text = listFriend.get_Items().get_Item(i).get_SubItems()
					.get_Item(0)
					.get_Text();
				fp.AddFriend(m_user_current.m_sQQnum, text);
			}
		}
	}

	private void buttonSaveFriend_Click(object sender, EventArgs e)
	{
		WriteAllFriend();
	}

	public void RefresBuyFriend()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		RefresFriendNormal();
		MaiDeQiFriend(bXiangXi: false);
		button_16_Click(null, null);
	}

	private void buttonShuaXin_Click(object sender, EventArgs e)
	{
		RefresFriendNormal();
	}

	public void RefresFriendNormal()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected O, but got Unknown
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		string text = m_user_current.m_qqq.QueryQQBuyFriend(m_user_current.m_sQQnum);
		if (text != null)
		{
			((Control)this).set_Cursor(Cursors.get_Default());
			MessageBox.Show(text, "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		m_sMyBuyMoney = 0L;
		m_sMyCapital = 0L;
		m_sMyMoney = 0L;
		FriendBuyInfo meFriendBuyInfo = m_user_current.m_qqq.GetMeFriendBuyInfo();
		FriendBuyInfo masterFriendBuyInfo = m_user_current.m_qqq.GetMasterFriendBuyInfo();
		if (meFriendBuyInfo != null)
		{
			m_fb1 = meFriendBuyInfo;
			listBoxMy.get_Items().Clear();
			listBoxMy.get_Items().Add((object)("帐    号：" + meFriendBuyInfo.sQQNum));
			listBoxMy.get_Items().Add((object)("昵    称：" + meFriendBuyInfo.sQQName));
			listBoxMy.get_Items().Add((object)("绰    号：" + meFriendBuyInfo.sCuohao));
			listBoxMy.get_Items().Add((object)("身    价：" + meFriendBuyInfo.sBuyMoney));
			listBoxMy.get_Items().Add((object)("总 资 产：" + meFriendBuyInfo.sCapital));
			listBoxMy.get_Items().Add((object)("现    金：" + meFriendBuyInfo.sMoney));
			listBoxMy.get_Items().Add((object)("奴    隶：" + meFriendBuyInfo.sHelot));
			listBoxMy.get_Items().Add((object)("性    别：" + meFriendBuyInfo.sSex));
			listBoxMy.get_Items().Add((object)("最近状态：" + meFriendBuyInfo.sState));
			listBoxMy.get_Items().Add((object)("开始时间：" + meFriendBuyInfo.sStartTime));
			listBoxMy.get_Items().Add((object)("结束时间：" + meFriendBuyInfo.sEndTime));
			listBoxMy.get_Items().Add((object)("经 验 值：" + meFriendBuyInfo.sExp));
			m_sMyBuyMoney = StringChar.SToLong(meFriendBuyInfo.sBuyMoney);
			m_sMyCapital = StringChar.SToLong(meFriendBuyInfo.sCapital);
			m_sMyMoney = StringChar.SToLong(meFriendBuyInfo.sMoney);
			sBuyFriendMe = meFriendBuyInfo.sQQNum;
		}
		listBoxMast.get_Items().Clear();
		if (masterFriendBuyInfo != null)
		{
			if (masterFriendBuyInfo.sQQNum != null && masterFriendBuyInfo.sQQNum != string.Empty)
			{
				listBoxMast.get_Items().Add((object)("帐  号：" + masterFriendBuyInfo.sQQNum));
				listBoxMast.get_Items().Add((object)("昵  称：" + masterFriendBuyInfo.sQQName));
				listBoxMast.get_Items().Add((object)("绰  号：" + masterFriendBuyInfo.sCuohao));
				listBoxMast.get_Items().Add((object)("身  价：" + masterFriendBuyInfo.sBuyMoney));
				listBoxMast.get_Items().Add((object)("总资产：" + masterFriendBuyInfo.sCapital));
				listBoxMast.get_Items().Add((object)("现  金：" + masterFriendBuyInfo.sMoney));
				listBoxMast.get_Items().Add((object)("奴  隶：" + masterFriendBuyInfo.sHelot));
				listBoxMast.get_Items().Add((object)("性  别：" + masterFriendBuyInfo.sSex));
				listBoxMast.get_Items().Add((object)("最近状态：" + masterFriendBuyInfo.sState));
				listBoxMast.get_Items().Add((object)("开始时间：" + masterFriendBuyInfo.sStartTime));
				listBoxMast.get_Items().Add((object)("结束时间：" + masterFriendBuyInfo.sEndTime));
				listBoxMast.get_Items().Add((object)("经 验 值：" + masterFriendBuyInfo.sExp));
				sBuyFriendMaster = masterFriendBuyInfo.sQQNum;
			}
		}
		else
		{
			listBoxMast.get_Items().Add((object)"冇得主人");
			sBuyFriendMaster = null;
			pictureBox2.set_Image((Image)null);
		}
		listViewSlave.get_Items().Clear();
		long count = m_user_current.m_qqq.GetCount();
		for (int i = 0; i < count; i++)
		{
			SlaveInfo slaveInfo = m_user_current.m_qqq.GetSlaveInfo(i);
			if (slaveInfo == null)
			{
				continue;
			}
			ListViewItem val = new ListViewItem(slaveInfo.sQQNum);
			val.get_SubItems().Add(slaveInfo.sQQName);
			val.get_SubItems().Add(slaveInfo.sCuohao);
			val.get_SubItems().Add(slaveInfo.sBuyMoney);
			val.get_SubItems().Add(slaveInfo.sCapital);
			val.get_SubItems().Add(slaveInfo.sMoney);
			val.get_SubItems().Add(slaveInfo.sHelot);
			val.get_SubItems().Add(slaveInfo.sBuyNum);
			val.get_SubItems().Add(slaveInfo.sBuyPrice);
			val.get_SubItems().Add(slaveInfo.sBuyTime);
			val.get_SubItems().Add(slaveInfo.sState);
			val.get_SubItems().Add(slaveInfo.sStartTime);
			val.get_SubItems().Add(slaveInfo.sEndTime);
			val.get_SubItems().Add(slaveInfo.sExp);
			if (slaveInfo.sStartTime.Length > 4)
			{
				long num = DateTime.Compare(DateTime.Now, slaveInfo.dEndTime);
				if (num < 0L)
				{
					val.set_ForeColor(Color.Red);
				}
			}
			if (val.get_ForeColor() != Color.Red)
			{
				DateTime dBuyTime = slaveInfo.dBuyTime;
				DateTime now = DateTime.Now;
				dBuyTime = dBuyTime.AddDays(2.0);
				if (dBuyTime.Year < now.Year)
				{
					val.set_ForeColor(Color.Blue);
				}
				else if (dBuyTime.Year == now.Year)
				{
					if (dBuyTime.Month < now.Month)
					{
						val.set_ForeColor(Color.Blue);
					}
					else if (dBuyTime.Month == now.Month && dBuyTime.Day <= now.Day)
					{
						val.set_ForeColor(Color.Blue);
					}
				}
			}
			listViewSlave.get_Items().Add(val);
		}
		((Control)listViewSlave).Update();
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	public static void ThreadProcMaiDeQI(object date)
	{
		MaiDeQiInfo maiDeQiInfo = (MaiDeQiInfo)date;
		if (maiDeQiInfo != null)
		{
			QueryQQ queryQQ = new QueryQQ(m_user_current);
			queryQQ.QueryQQBuyFriendForBuy(maiDeQiInfo.sQQNum);
			FriendBuyInfo masterFriendBuyInfo = queryQQ.GetMasterFriendBuyInfo();
			if (masterFriendBuyInfo != null)
			{
				maiDeQiInfo.sMasterQQNum = masterFriendBuyInfo.sQQNum;
				maiDeQiInfo.sMasterQQName = masterFriendBuyInfo.sQQName;
			}
			maiDeQiInfo.bThread = false;
		}
	}

	public void MaiDeQiFriend(bool bXiangXi)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		listViewMaiDeQi.get_Items().Clear();
		m_user_current.m_hymm.QueryMaiDeQiFriend();
		if (bXiangXi)
		{
			Collection<Thread> collection = new Collection<Thread>();
			for (int i = 0; i < m_user_current.m_hymm.GetCount(); i++)
			{
				MaiDeQiInfo maiDeQiInfo = m_user_current.m_hymm.GetMaiDeQiInfo(i);
				if (maiDeQiInfo != null)
				{
					Thread thread = new Thread(ThreadProcMaiDeQI);
					collection.Add(thread);
					maiDeQiInfo.bThread = true;
					thread.Start(maiDeQiInfo);
				}
			}
			int num = 0;
			bool flag;
			do
			{
				num = 0;
				flag = true;
				for (int j = 0; j < m_user_current.m_hymm.GetCount(); j++)
				{
					MaiDeQiInfo maiDeQiInfo2 = m_user_current.m_hymm.GetMaiDeQiInfo(j);
					if (maiDeQiInfo2 != null)
					{
						if (maiDeQiInfo2.bThread)
						{
							flag = false;
						}
						else if (num < collection.Count)
						{
							collection[num].Abort();
						}
						num++;
					}
				}
			}
			while (!flag);
		}
		for (int k = 0; k < m_user_current.m_hymm.GetCount(); k++)
		{
			MaiDeQiInfo maiDeQiInfo3 = m_user_current.m_hymm.GetMaiDeQiInfo(k);
			if (maiDeQiInfo3 != null)
			{
				listViewMaiDeQi.set_View((View)1);
				ListViewItem val = new ListViewItem(maiDeQiInfo3.sQQNum);
				val.get_SubItems().Add(maiDeQiInfo3.sQQName);
				val.get_SubItems().Add(maiDeQiInfo3.sBuyMoney);
				val.get_SubItems().Add(maiDeQiInfo3.sMasterQQNum);
				val.get_SubItems().Add(maiDeQiInfo3.sMasterQQName);
				listViewMaiDeQi.get_Items().Add(val);
			}
		}
		((Control)listViewMaiDeQi).Update();
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void toolStripMenuItem_20_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Invalid comparison between Unknown and I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Invalid comparison between Unknown and I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Invalid comparison between Unknown and I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		else if (iListFocus == 17 && listViewMaiDeQi.get_SelectedItems().get_Count() > 0)
		{
			long sMyBuyMoney = m_sMyBuyMoney;
			long sMyCapital = m_sMyCapital;
			long sMyMoney = m_sMyMoney;
			string text = listViewMaiDeQi.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
			string text2 = listViewMaiDeQi.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(1)
				.get_Text();
			int slaveCount = m_user_current.m_qqq.GetSlaveCount(m_user_current.m_sQQnum);
			if (slaveCount == 0)
			{
				DialogResult val = MessageBox.Show("当前奴隶数为0，可能读取努力数失败，你还想买吗？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
				if ((int)val != 6)
				{
					return;
				}
			}
			else if (slaveCount >= 9)
			{
				DialogResult val2 = MessageBox.Show("大哥，你已经有 9 个奴隶，你还想买吗？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
				if ((int)val2 != 6)
				{
					return;
				}
			}
			else
			{
				DialogResult val3 = MessageBox.Show("请确定购买好友 [" + text2 + "] 吗？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
				if ((int)val3 != 6)
				{
					return;
				}
			}
			FriendCuohao friendCuohao = new FriendCuohao();
			friendCuohao.m_sSlaveChuoHao = m_sSlaveChuoHao;
			((Form)friendCuohao).ShowDialog();
			if (friendCuohao.m_bOK)
			{
				((Control)this).set_Cursor(Cursors.get_WaitCursor());
				string sSlaveChuoHao = friendCuohao.m_sSlaveChuoHao;
				string text3 = m_user_current.m_hymm.ProBuyFriend(text, sSlaveChuoHao);
				if (text3 != null)
				{
					((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [购买奴隶失败] [") + sSlaveChuoHao + "]" + text3 + "\r\n");
				}
				else
				{
					RefresFriendNormal();
					MaiDeQiFriend(bXiangXi: false);
					((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [购买奴隶成功] [") + sSlaveChuoHao + "]\r\n");
				}
				ShowMyhaoyuMaiInfo(sMyBuyMoney, sMyCapital, sMyMoney);
				((Control)this).set_Cursor(Cursors.get_Default());
			}
		}
		else
		{
			MessageBox.Show("请在买得起的好友列表中选择想买的好友", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void listViewMaiDeQi_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		toolStripMenuItem_20_Click(sender, (EventArgs)(object)e);
	}

	private void buttonQingKongCuoHao_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		string text = m_user_current.m_hymm.ClearNick();
		if (text != null)
		{
			((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [清空绰号失败] ") + text + "\r\n");
		}
		else
		{
			RefresFriendNormal();
			((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [清空绰号成功] ") + "\r\n");
		}
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	public void ShowMyhaoyuMaiInfo(long OldMyBuyMoney, long OldMyCapital, long OldMyMoney)
	{
		if (OldMyBuyMoney != m_sMyBuyMoney)
		{
			if (OldMyBuyMoney < m_sMyBuyMoney)
			{
				((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [身价涨了] ") + (m_sMyBuyMoney - OldMyBuyMoney) + "\r\n");
			}
			else
			{
				((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [身价跌了] ") + (OldMyBuyMoney - m_sMyBuyMoney) + "\r\n");
			}
		}
		if (OldMyCapital != m_sMyCapital)
		{
			if (OldMyCapital < m_sMyCapital)
			{
				((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [总资产增加] ") + (m_sMyCapital - OldMyCapital) + "\r\n");
			}
			else
			{
				((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [总资产减少] ") + (OldMyCapital - m_sMyCapital) + "\r\n");
			}
		}
		if (OldMyMoney != m_sMyMoney)
		{
			if (OldMyMoney < m_sMyMoney)
			{
				((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [现金增加] ") + (m_sMyMoney - OldMyMoney) + "\r\n");
			}
			else
			{
				((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [现金减少] ") + (OldMyMoney - m_sMyMoney) + "\r\n");
			}
		}
	}

	private void buttonWoYaoSuShen_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		DialogResult val = MessageBox.Show("你确定你要赎身吗？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
		if ((int)val == 6)
		{
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			long sMyBuyMoney = m_sMyBuyMoney;
			long sMyCapital = m_sMyCapital;
			long sMyMoney = m_sMyMoney;
			string text = m_user_current.m_hymm.ProShuShen();
			if (text != null)
			{
				((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [赎身失败] ") + text + "\r\n");
			}
			else
			{
				RefresFriendNormal();
				((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [赎身成功] ") + "\r\n");
			}
			ShowMyhaoyuMaiInfo(sMyBuyMoney, sMyCapital, sMyMoney);
			((Control)this).set_Cursor(Cursors.get_Default());
		}
	}

	private void buttonMinYunKa_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		tabControl5.set_SelectedIndex(1);
		long sMyBuyMoney = m_sMyBuyMoney;
		long sMyCapital = m_sMyCapital;
		long sMyMoney = m_sMyMoney;
		string text = m_user_current.m_hymm.ProMinYunKa();
		if (text != null)
		{
			((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [使用命运卡失败] ") + text + "\r\n");
		}
		else if (m_sMyCapital > 0L)
		{
			RefresFriendNormal();
			((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [使用命运卡成功] ") + "\r\n");
		}
		if (m_sMyCapital > 0L)
		{
			ShowMyhaoyuMaiInfo(sMyBuyMoney, sMyCapital, sMyMoney);
		}
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void buttonQuanXuan_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listViewSlave.get_Items().get_Count(); i++)
		{
			listViewSlave.get_Items().get_Item(i).set_Checked(true);
		}
	}

	private void buttonQuanBuXuan_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listViewSlave.get_Items().get_Count(); i++)
		{
			listViewSlave.get_Items().get_Item(i).set_Checked(false);
		}
	}

	private void buttonZhiXing_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		tabControl5.set_SelectedIndex(1);
		long sMyBuyMoney = m_sMyBuyMoney;
		long sMyCapital = m_sMyCapital;
		long sMyMoney = m_sMyMoney;
		bool flag = false;
		int selectedIndex = ((ListControl)comboBoxZheMo).get_SelectedIndex();
		for (int i = 0; i < listViewSlave.get_Items().get_Count(); i++)
		{
			if (listViewSlave.get_Items().get_Item(i).get_Checked())
			{
				string text = listViewSlave.get_Items().get_Item(i).get_SubItems()
					.get_Item(0)
					.get_Text();
				string text2 = listViewSlave.get_Items().get_Item(i).get_SubItems()
					.get_Item(1)
					.get_Text();
				string text3 = listViewSlave.get_Items().get_Item(i).get_SubItems()
					.get_Item(7)
					.get_Text();
				string text4 = null;
				if (selectedIndex == 0)
				{
					string sTaoHao = null;
					string sAnFu = null;
					string sZheMo = null;
					hymmt.GetType(text3, out sTaoHao, out sAnFu, out sZheMo);
					text4 = m_user_current.m_hymm.ProZheMo(text, sZheMo);
				}
				else
				{
					text4 = m_user_current.m_hymm.ProZheMo(text, hymmt.m_ZheMoList[selectedIndex].strAid);
				}
				if (text4 != null)
				{
					((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [折磨失败] [") + text2 + "] " + text4 + "\r\n");
				}
				else
				{
					flag = true;
					((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [折磨成功] [") + text2 + "] \r\n");
				}
				Thread.Sleep(100);
			}
		}
		int selectedIndex2 = ((ListControl)comboBoxAnFu).get_SelectedIndex();
		for (int j = 0; j < listViewSlave.get_Items().get_Count(); j++)
		{
			if (listViewSlave.get_Items().get_Item(j).get_Checked())
			{
				string text5 = listViewSlave.get_Items().get_Item(j).get_SubItems()
					.get_Item(0)
					.get_Text();
				string text6 = listViewSlave.get_Items().get_Item(j).get_SubItems()
					.get_Item(1)
					.get_Text();
				string text7 = listViewSlave.get_Items().get_Item(j).get_SubItems()
					.get_Item(7)
					.get_Text();
				string text8 = null;
				if (selectedIndex2 == 0)
				{
					string sTaoHao2 = null;
					string sAnFu2 = null;
					string sZheMo2 = null;
					hymmt.GetType(text7, out sTaoHao2, out sAnFu2, out sZheMo2);
					text8 = m_user_current.m_hymm.ProAnFu(text5, sAnFu2);
				}
				else
				{
					text8 = m_user_current.m_hymm.ProAnFu(text5, hymmt.m_AnFuList[selectedIndex2].strAid);
				}
				if (text8 != null)
				{
					((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [安抚失败] [") + text6 + "] " + text8 + "\r\n");
				}
				else
				{
					flag = true;
					((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [安抚成功] [") + text6 + "] \r\n");
				}
				Thread.Sleep(200);
			}
		}
		if (flag)
		{
			RefresFriendNormal();
		}
		ShowMyhaoyuMaiInfo(sMyBuyMoney, sMyCapital, sMyMoney);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void buttonTaoHaoZhuRen_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		tabControl5.set_SelectedIndex(1);
		long sMyBuyMoney = m_sMyBuyMoney;
		long sMyCapital = m_sMyCapital;
		long sMyMoney = m_sMyMoney;
		int selectedIndex = ((ListControl)comboBoxTaoHaoZhuRen).get_SelectedIndex();
		string text = null;
		if (selectedIndex == 0)
		{
			string sTaoHao = null;
			string sAnFu = null;
			string sZheMo = null;
			hymmt.GetType(m_fb1.sBuyNum, out sTaoHao, out sAnFu, out sZheMo);
			text = m_user_current.m_hymm.ProQingAn(sBuyFriendMaster, sTaoHao);
		}
		else
		{
			text = m_user_current.m_hymm.ProQingAn(sBuyFriendMaster, hymmt.m_QingAnList[selectedIndex].strAid);
		}
		if (sBuyFriendMaster != null && sBuyFriendMaster.Length > 3)
		{
			if (text != null)
			{
				((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [讨好主人失败]") + text + "\r\n");
			}
			else
			{
				RefresFriendNormal();
				((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [讨好主人成功]") + "\r\n");
			}
		}
		if (sBuyFriendMaster == null || sBuyFriendMaster.Length < 4)
		{
			((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [讨好主人失败]你没有主人，你讨好个鬼撒") + "\r\n");
		}
		ShowMyhaoyuMaiInfo(sMyBuyMoney, sMyCapital, sMyMoney);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void buttonShiFang_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		string text = "购买奴隶后当天释放：1分钱都不退\r\n购买奴隶后二天释放：退给你原价的80%\r\n购买奴隶后三天释放：退给你原价（但要扣¥50手续费）\r\n你铁了心要释放吗？";
		DialogResult val = MessageBox.Show(text, "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
		if ((int)val != 6)
		{
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		tabControl5.set_SelectedIndex(1);
		long sMyBuyMoney = m_sMyBuyMoney;
		long sMyCapital = m_sMyCapital;
		long sMyMoney = m_sMyMoney;
		bool flag = false;
		for (int i = 0; i < listViewSlave.get_Items().get_Count(); i++)
		{
			if (listViewSlave.get_Items().get_Item(i).get_Checked())
			{
				string text2 = listViewSlave.get_Items().get_Item(i).get_SubItems()
					.get_Item(0)
					.get_Text();
				string text3 = listViewSlave.get_Items().get_Item(i).get_SubItems()
					.get_Item(1)
					.get_Text();
				string text4 = m_user_current.m_hymm.ProShiFang(text2);
				if (text4 != null)
				{
					((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [释放奴隶失败] [") + text3 + "] " + text4 + "\r\n");
				}
				else
				{
					flag = true;
					((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [释放奴隶成功] [") + text3 + "] \r\n");
				}
			}
		}
		if (flag)
		{
			RefresFriendNormal();
		}
		ShowMyhaoyuMaiInfo(sMyBuyMoney, sMyCapital, sMyMoney);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void buttonDaZhe_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		DialogResult val = MessageBox.Show("这样做你会亏本的，你铁了心要打折吗？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
		if ((int)val != 6)
		{
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		tabControl5.set_SelectedIndex(1);
		long sMyBuyMoney = m_sMyBuyMoney;
		long sMyCapital = m_sMyCapital;
		long sMyMoney = m_sMyMoney;
		bool flag = false;
		string discount = (9 - ((ListControl)comboBoxDaZhe).get_SelectedIndex()).ToString();
		for (int i = 0; i < listViewSlave.get_Items().get_Count(); i++)
		{
			if (listViewSlave.get_Items().get_Item(i).get_Checked())
			{
				string text = listViewSlave.get_Items().get_Item(i).get_SubItems()
					.get_Item(0)
					.get_Text();
				string text2 = listViewSlave.get_Items().get_Item(i).get_SubItems()
					.get_Item(1)
					.get_Text();
				string text3 = m_user_current.m_hymm.ProDaZhe(text, discount);
				if (text3 != null)
				{
					((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [打折奴隶失败] [") + text2 + "] " + text3 + "\r\n");
				}
				else
				{
					flag = true;
					((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [打折奴隶成功] [") + text2 + "] \r\n");
				}
			}
		}
		if (flag)
		{
			RefresFriendNormal();
		}
		ShowMyhaoyuMaiInfo(sMyBuyMoney, sMyCapital, sMyMoney);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void InitBuyFriendCombox()
	{
		foreach (HaoYouTypeInfo qingAn in hymmt.m_QingAnList)
		{
			comboBoxTaoHaoZhuRen.get_Items().Add((object)qingAn.strConten);
		}
		((ListControl)comboBoxTaoHaoZhuRen).set_SelectedIndex(0);
		foreach (HaoYouTypeInfo zheMo in hymmt.m_ZheMoList)
		{
			comboBoxZheMo.get_Items().Add((object)zheMo.strConten);
		}
		((ListControl)comboBoxZheMo).set_SelectedIndex(0);
		foreach (HaoYouTypeInfo anFu in hymmt.m_AnFuList)
		{
			comboBoxAnFu.get_Items().Add((object)anFu.strConten);
		}
		((ListControl)comboBoxAnFu).set_SelectedIndex(0);
		for (int num = 9; num > 0; num--)
		{
			comboBoxDaZhe.get_Items().Add((object)(num + " 折"));
		}
		((ListControl)comboBoxDaZhe).set_SelectedIndex(0);
	}

	private void buttonShuaXinMaiDeQi_Click(object sender, EventArgs e)
	{
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		MaiDeQiFriend(bXiangXi: false);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		MaiDeQiFriend(bXiangXi: true);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void toolStripButton_2_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		tabControl1.set_SelectedIndex(4);
		((Control)tabControl1).Update();
		string text = m_user_current.m_fxhy.ProFenXiHaoYou();
		if (text != null)
		{
			MessageBox.Show(text, "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		listViewAllFriend.get_Items().Clear();
		foreach (AllFriendInfo friend in m_user_current.m_fxhy.m_FriendList)
		{
			listViewMaiDeQi.set_View((View)1);
			ListViewItem val = new ListViewItem(friend.sQQNum);
			val.get_SubItems().Add(friend.sQQName);
			val.get_SubItems().Add(friend.sQQNick);
			val.get_SubItems().Add(friend.sQQGroup);
			val.get_SubItems().Add(friend.sGuanXi);
			listViewAllFriend.get_Items().Add(val);
		}
		((Control)listViewAllFriend).Update();
		((Control)label132).set_Text("好友总数：" + listViewAllFriend.get_Items().get_Count());
		if (m_fx != null)
		{
			m_fx.Abort();
		}
		foreach (Thread threadFx in m_ThreadFxList)
		{
			threadFx.Abort();
		}
		m_ThreadFxList.Clear();
		m_fx = new Thread(ThreadProcStartFxs);
		m_fx.Start(0);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	public void ThreadProcStartFxs(object date)
	{
		for (int i = 0; i < m_user_current.m_fxhy.m_FriendList.Count; i++)
		{
			Thread thread = new Thread(ThreadProcStartFx);
			thread.Start(i);
			m_ThreadFxList.Add(thread);
			Thread.Sleep(100);
		}
		if (m_fx != null)
		{
			m_fx.Abort();
		}
	}

	public void ThreadProcStartFx(object date)
	{
		int num = (int)date;
		FenXiHaoYou fenXiHaoYou = new FenXiHaoYou(m_user_current);
		string s = fenXiHaoYou.ProFenXiHaoYouGuanXi(m_user_current.m_fxhy.m_FriendList[num].sQQNum, m_user_current);
		priFx(num, 4, s);
	}

	private void button78_Click(object sender, EventArgs e)
	{
		toolStripButton_2_Click(sender, e);
	}

	private void toolStripButton_3_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		Config config = new Config();
		config.m_bCancel = m_bCancel;
		config.m_bShowAllTime = m_bShowAllTime;
		config.m_sTieTiaoLiuYan = m_sTieTiaoLiuYan;
		config.m_sSlaveChuoHao = m_sSlaveChuoHao;
		((Form)config).ShowDialog();
		if (config.m_bOK)
		{
			m_bCancel = config.m_bCancel;
			m_bShowAllTime = config.m_bShowAllTime;
			m_sTieTiaoLiuYan = config.m_sTieTiaoLiuYan;
			m_sSlaveChuoHao = config.m_sSlaveChuoHao;
			fp.WriteIniData("config", "Cancel", m_bCancel.ToString(), m_strConfigPath);
			fp.WriteIniData("config", "ShowAllTime", m_bShowAllTime.ToString(), m_strConfigPath);
			fp.WriteIniData("config", "TieTiaoLiuYan", m_sTieTiaoLiuYan, m_strConfigPath);
			fp.WriteIniData("config", "SlaveChuoHao", m_sSlaveChuoHao, m_strConfigPath);
		}
	}

	private void buttonShuaXinWoCheZiJinKuang_Click(object sender, EventArgs e)
	{
		if (m_user_current != null)
		{
			((Control)textBoxWoCheZiJinKuang).set_Text("");
			((Control)buttonShuaXinWoCheZiJinKuang).set_Enabled(false);
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			string text = m_user_current.m_tcj.WoCheZiJinKuang();
			((Control)textBoxWoCheZiJinKuang).set_Text(text);
			((Control)this).set_Cursor(Cursors.get_Default());
			((Control)buttonShuaXinWoCheZiJinKuang).set_Enabled(true);
		}
	}

	private void buttonShuaXinWoCheWeiJinKuang_Click(object sender, EventArgs e)
	{
		if (m_user_current != null)
		{
			((Control)textBoxWoCheWeiJinKuang).set_Text("");
			((Control)buttonShuaXinWoCheWeiJinKuang).set_Enabled(false);
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			string text = m_user_current.m_tcj.WoCheWeiJinKuang();
			((Control)textBoxWoCheWeiJinKuang).set_Text(text);
			((Control)this).set_Cursor(Cursors.get_Default());
			((Control)buttonShuaXinWoCheWeiJinKuang).set_Enabled(true);
		}
	}

	private void toolStripMenuItem_22_Click(object sender, EventArgs e)
	{
		string listSelectQQNum = GetListSelectQQNum();
		if (listSelectQQNum != null && listSelectQQNum != string.Empty)
		{
			QueryHaoYouTingCheJiLu(listSelectQQNum);
		}
	}

	private void toolStripMenuItem_44_Click(object sender, EventArgs e)
	{
		string listSelectQQNum = GetListSelectQQNum();
		if (listSelectQQNum != null && listSelectQQNum != string.Empty)
		{
			QueryRiZhi(listSelectQQNum);
		}
	}

	private void buttonChaKanHaoYouTingCheJiLu_Click(object sender, EventArgs e)
	{
		string text = ((Control)textBoxQueryQQNum).get_Text();
		QueryHaoYouTingCheJiLu(text);
	}

	private void textBoxQueryQQNum_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.get_KeyValue() == Convert.ToChar(13))
		{
			string text = ((Control)textBoxQueryQQNum).get_Text();
			QueryHaoYouTingCheJiLu(text);
		}
	}

	public void QueryHaoYouTingCheJiLu(string strQQNum)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)textBoxQueryQQNum).set_Text(strQQNum);
		tabControl1.set_SelectedIndex(1);
		tabControl3.set_SelectedIndex(5);
		((Control)textBoxHaoYouTingCheXin).set_Text("");
		((Control)buttonChaKanHaoYouTingCheJiLu).set_Enabled(false);
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		string text = m_user_current.m_tcj.ChaKanHaoYouTingCheXin(strQQNum);
		((Control)textBoxHaoYouTingCheXin).set_Text(text);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Control)buttonChaKanHaoYouTingCheJiLu).set_Enabled(true);
	}

	private void tabControl3_Selected(object sender, TabControlEventArgs e)
	{
		if (tabControl3.get_SelectedIndex() == 4)
		{
			if (((Control)textBoxWoCheZiJinKuang).get_Text().Length < 3)
			{
				buttonShuaXinWoCheZiJinKuang_Click(sender, (EventArgs)(object)e);
			}
			if (((Control)textBoxWoCheWeiJinKuang).get_Text().Length < 3)
			{
				buttonShuaXinWoCheWeiJinKuang_Click(sender, (EventArgs)(object)e);
			}
		}
	}

	private void toolStripMenuItem_24_Click(object sender, EventArgs e)
	{
		LogoOut();
	}

	private void listUser_DoubleClick(object sender, EventArgs e)
	{
		LogoOut();
	}

	public void LogoOut()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Invalid comparison between Unknown and I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		else if (iListFocus == 1 && listUser.get_SelectedItems().get_Count() >= 1)
		{
			string text = null;
			text = listUser.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
			int index = listUser.get_SelectedItems().get_Item(0).get_Index();
			User userByQQNum = GetUserByQQNum(text);
			if (userByQQNum == null)
			{
				MessageBox.Show("需要注销登录的账号的信息获取失败", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			DialogResult val = MessageBox.Show("你确定要注销 [" + userByQQNum.m_sQQnick + "] 登录吗？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
			if ((int)val != 6)
			{
				return;
			}
			if (!m_UserList.Remove(userByQQNum))
			{
				MessageBox.Show("注销登录失败", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			if (index == 0)
			{
				if (listUser.get_Items().get_Count() == 1)
				{
					m_user_current = null;
				}
				else
				{
					listUser.get_Items().get_Item(index + 1).set_Selected(true);
					ChangeUser();
				}
			}
			else
			{
				listUser.get_Items().get_Item(index - 1).set_Selected(true);
				ChangeUser();
			}
			listUser.get_Items().RemoveAt(index);
			((Control)listUser).Update();
			for (int i = 0; i < listViewJiaoBenUser.get_Items().get_Count(); i++)
			{
				string text2 = listViewJiaoBenUser.get_Items().get_Item(i).get_SubItems()
					.get_Item(0)
					.get_Text();
				if (text2 == text)
				{
					listViewJiaoBenUser.get_Items().RemoveAt(i);
					break;
				}
			}
			int num = 0;
			while (true)
			{
				if (num < listView_1.get_Items().get_Count())
				{
					string text3 = listView_1.get_Items().get_Item(num).get_SubItems()
						.get_Item(0)
						.get_Text();
					if (text3 == text)
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			listView_1.get_Items().RemoveAt(num);
		}
		else
		{
			MessageBox.Show("请在已登录账号列表中选择需要注销登录的账号", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void buttonYiJianHaoYouMaiMai_Click(object sender, EventArgs e)
	{
		buttonMinYunKa_Click(sender, e);
		buttonTaoHaoZhuRen_Click(sender, e);
		buttonQuanXuan_Click(sender, e);
		buttonZhiXing_Click(sender, e);
	}

	private void buttonYiJianPark_Click(object sender, EventArgs e)
	{
		checkGoBack.set_Checked(true);
		m_bGoBack = true;
		fp.WriteIniData("config", "GoBack", m_bGoBack.ToString(), m_strConfigPath);
		buttonAllYes1_Click(sender, e);
		for (int i = 0; i < listCars.get_Items().get_Count(); i++)
		{
			listCars.get_Items().get_Item(i).set_Checked(true);
		}
		StopCars();
		YuandiOrNuo(bYuandi: true);
	}

	private void buttonYiJianParkPiLiang_Click(object sender, EventArgs e)
	{
		checkGoBack.set_Checked(true);
		m_bGoBack = true;
		fp.WriteIniData("config", "GoBack", m_bGoBack.ToString(), m_strConfigPath);
		buttonAllYes1_Click(sender, e);
		for (int i = 0; i < listCars.get_Items().get_Count(); i++)
		{
			listCars.get_Items().get_Item(i).set_Checked(true);
		}
		StopCars();
		ProPiLiangTingChe();
	}

	private void comboExcessQQ2_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text = ((Control)comboExcessQQ2).get_Text();
		if (text == null || !(text != string.Empty) || !(text != ""))
		{
			return;
		}
		text = StringChar.GetQQNum(text);
		try
		{
			m_sQueryQQJb = text;
			QueryQQParkJb(text);
			User userByQQNum = GetUserByQQNum(text);
			if (userByQQNum != null)
			{
				QueryQQCarsJb(userByQQNum, text);
			}
			else
			{
				QueryQQCarsJb(null, text);
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
	}

	private void buttonZongPaiHangBang_Click(object sender, EventArgs e)
	{
		((Control)labelYeMa).set_Text("页码：" + m_iPaiHangPageNo);
		((Control)buttonZongPaiHangBang).set_Enabled(false);
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		try
		{
			ZongPaiHangBang zongPaiHangBang = new ZongPaiHangBang();
			zongPaiHangBang.ProGetPaiMin(m_iPaiHangPageNo);
			listViewPaiMin.get_Items().Clear();
			((Control)listViewPaiMin).Update();
			for (int i = 0; i < zongPaiHangBang.GetCount(); i++)
			{
				PaiMinInfo paiMinInfo = zongPaiHangBang.GetPaiMinInfo(i);
				if (paiMinInfo != null)
				{
					string text = (20L * (m_iPaiHangPageNo - 1L) + i + 1L).ToString();
					listViewPaiMin.get_Items().Add(text, text, 0);
					listViewPaiMin.get_Items().get_Item(text).get_SubItems()
						.Add(paiMinInfo.QQNum);
					listViewPaiMin.get_Items().get_Item(text).get_SubItems()
						.Add(paiMinInfo.QQName);
					listViewPaiMin.get_Items().get_Item(text).get_SubItems()
						.Add(paiMinInfo.strZongZiChan);
					listViewPaiMin.get_Items().get_Item(text).get_SubItems()
						.Add(paiMinInfo.strXianJin);
					listViewPaiMin.get_Items().get_Item(text).get_SubItems()
						.Add(paiMinInfo.strQiChe);
					listViewPaiMin.get_Items().get_Item(text).get_SubItems()
						.Add(paiMinInfo.strJingYan);
					listViewPaiMin.get_Items().get_Item(text).get_SubItems()
						.Add(paiMinInfo.strTime);
				}
			}
			((Control)listViewPaiMin).Update();
		}
		catch
		{
		}
		((Control)buttonZongPaiHangBang).set_Enabled(true);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void buttonShouYe_Click(object sender, EventArgs e)
	{
		if (m_iPaiHangPageNo > 1L)
		{
			m_iPaiHangPageNo = 1L;
			((Control)labelYeMa).set_Text("页码：" + m_iPaiHangPageNo);
			buttonZongPaiHangBang_Click(sender, e);
		}
	}

	private void buttonXiaYe_Click(object sender, EventArgs e)
	{
		if (m_iPaiHangPageNo < m_iQueryPege)
		{
			m_iPaiHangPageNo++;
			((Control)labelYeMa).set_Text("页码：" + m_iPaiHangPageNo);
			buttonZongPaiHangBang_Click(sender, e);
		}
	}

	private void buttonShangYe_Click(object sender, EventArgs e)
	{
		if (m_iPaiHangPageNo > 1L)
		{
			m_iPaiHangPageNo--;
			((Control)labelYeMa).set_Text("页码：" + m_iPaiHangPageNo);
			buttonZongPaiHangBang_Click(sender, e);
		}
	}

	private void buttonWeiYe_Click(object sender, EventArgs e)
	{
		if (m_iPaiHangPageNo < m_iQueryPege)
		{
			m_iPaiHangPageNo = m_iQueryPege;
			((Control)labelYeMa).set_Text("页码：" + m_iPaiHangPageNo);
			buttonZongPaiHangBang_Click(sender, e);
		}
	}

	public void JiaoBenInit()
	{
		((Control)button63).set_Enabled(false);
		checkBox11.set_Checked(false);
		checkBox12.set_Checked(false);
		((Control)checkBox12).set_Enabled(false);
		((Control)comboExcessQQ3).set_Text(StringChar.GetQQNum(((Control)comboExcessQQ).get_Text()));
		((Control)textBox8).set_Text("2,3,4");
		((Control)textBox8).set_Enabled(false);
		((Control)textBox9).set_Text("1,2,3,4,5,6,7,8,9,10");
		((Control)textBox11).set_Text("1000");
		long num = ct.GetCount();
		for (int i = 0; i < num; i++)
		{
			CarTypeInfo carTypeInfoByIndex = ct.GetCarTypeInfoByIndex(i);
			if (carTypeInfoByIndex != null)
			{
				comboBoxCarName1.get_Items().Add((object)carTypeInfoByIndex.CarName);
				comboBoxCarName2.get_Items().Add((object)carTypeInfoByIndex.CarName);
				comboBoxCarName3.get_Items().Add((object)carTypeInfoByIndex.CarName);
				comboBoxCarName4.get_Items().Add((object)carTypeInfoByIndex.CarName);
				comboBoxCarName5.get_Items().Add((object)carTypeInfoByIndex.CarName);
				comboBoxCarName6.get_Items().Add((object)carTypeInfoByIndex.CarName);
				comboBoxCarName7.get_Items().Add((object)carTypeInfoByIndex.CarName);
				comboBoxCarName8.get_Items().Add((object)carTypeInfoByIndex.CarName);
				comboBoxCarName9.get_Items().Add((object)carTypeInfoByIndex.CarName);
				comboBoxCarName10.get_Items().Add((object)carTypeInfoByIndex.CarName);
			}
		}
		((ListControl)comboBoxCarName1).set_SelectedIndex(0);
		((ListControl)comboBoxCarName2).set_SelectedIndex(0);
		((ListControl)comboBoxCarName3).set_SelectedIndex(0);
		((ListControl)comboBoxCarName4).set_SelectedIndex(0);
		((ListControl)comboBoxCarName5).set_SelectedIndex(0);
		((ListControl)comboBoxCarName6).set_SelectedIndex(0);
		((ListControl)comboBoxCarName7).set_SelectedIndex(0);
		((ListControl)comboBoxCarName8).set_SelectedIndex(0);
		((ListControl)comboBoxCarName9).set_SelectedIndex(0);
		((ListControl)comboBoxCarName10).set_SelectedIndex(0);
		num = ct.GetColorCount();
		for (int j = 0; j < num; j++)
		{
			string colorName = ct.GetColorName(j);
			comboBoxColor1.get_Items().Add((object)colorName);
			comboBoxColor2.get_Items().Add((object)colorName);
			comboBoxColor3.get_Items().Add((object)colorName);
			comboBoxColor4.get_Items().Add((object)colorName);
			comboBoxColor5.get_Items().Add((object)colorName);
			comboBoxColor6.get_Items().Add((object)colorName);
			comboBoxColor7.get_Items().Add((object)colorName);
			comboBoxColor8.get_Items().Add((object)colorName);
			comboBoxColor9.get_Items().Add((object)colorName);
			comboBoxColor10.get_Items().Add((object)colorName);
		}
		((ListControl)comboBoxColor1).set_SelectedIndex(0);
		((ListControl)comboBoxColor2).set_SelectedIndex(0);
		((ListControl)comboBoxColor3).set_SelectedIndex(0);
		((ListControl)comboBoxColor4).set_SelectedIndex(0);
		((ListControl)comboBoxColor5).set_SelectedIndex(0);
		((ListControl)comboBoxColor6).set_SelectedIndex(0);
		((ListControl)comboBoxColor7).set_SelectedIndex(0);
		((ListControl)comboBoxColor8).set_SelectedIndex(0);
		((ListControl)comboBoxColor9).set_SelectedIndex(0);
		((ListControl)comboBoxColor10).set_SelectedIndex(0);
		checkBoxCar1.set_Checked(true);
		checkBoxCar2.set_Checked(true);
		checkBoxCar3.set_Checked(true);
		checkBoxCar4.set_Checked(true);
		checkBoxCar5.set_Checked(true);
		checkBoxCar6.set_Checked(true);
		checkBoxCar7.set_Checked(true);
		checkBoxCar8.set_Checked(true);
		checkBoxCar9.set_Checked(true);
		checkBoxCar10.set_Checked(true);
		checkBox13.set_Checked(true);
	}

	private void checkBox11_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox11.get_Checked())
		{
			((Control)checkBox12).set_Enabled(true);
			((Control)textBox8).set_Enabled(true);
		}
		else
		{
			((Control)checkBox12).set_Enabled(false);
			((Control)textBox8).set_Enabled(false);
		}
	}

	private void checkBox12_CheckedChanged(object sender, EventArgs e)
	{
	}

	public void ReadJiaoBen(string sQQNum, string sQQName)
	{
		FileJiaoBen fileJiaoBen = new FileJiaoBen();
		JiaoBenInfo jiaoBenInfo = fileJiaoBen.ReadJiaoBen(m_strJiaoBenPath + sQQNum.ToString() + ".ini", sQQNum, sQQName);
		if (jiaoBenInfo == null)
		{
			return;
		}
		if (jiaoBenInfo.sYuanDi == "1")
		{
			checkBox13.set_Checked(true);
		}
		else
		{
			checkBox13.set_Checked(false);
		}
		((Control)textBox7).set_Text(jiaoBenInfo.sTime);
		if (jiaoBenInfo.sTieTiaoCheWei != "")
		{
			checkBox11.set_Checked(true);
			((Control)textBox8).set_Text(jiaoBenInfo.sTieTiaoCheWei);
		}
		else
		{
			checkBox11.set_Checked(false);
			((Control)textBox8).set_Text("");
		}
		if (jiaoBenInfo.sHuiTing == "1")
		{
			checkBox12.set_Checked(true);
		}
		else
		{
			checkBox12.set_Checked(false);
		}
		((Control)comboExcessQQ3).set_Text(jiaoBenInfo.sGuoDu);
		((Control)textBox9).set_Text(jiaoBenInfo.sTingCheShunXu);
		((Control)textBox10).set_Text(jiaoBenInfo.sTingCheChang);
		((Control)textBox11).set_Text(jiaoBenInfo.sTingCheYanShi);
		if (jiaoBenInfo.m_CheZiInfoList[0].sTingChe == "1")
		{
			checkBoxCar1.set_Checked(true);
			if (jiaoBenInfo.m_CheZiInfoList[0].sHuanChe == "1")
			{
				checkBoxHuanChe1.set_Checked(true);
				((Control)comboBoxCarName1).set_Enabled(true);
				((Control)comboBoxColor1).set_Enabled(true);
				int num = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[0].sCarCode);
				if (num > 0)
				{
					int carIndex = ct.GetCarIndex(num);
					if (carIndex > -1)
					{
						((ListControl)comboBoxCarName1).set_SelectedIndex(carIndex);
					}
				}
				int num2 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[0].sColor);
				if (num2 > 0 && num2 <= 7)
				{
					((ListControl)comboBoxColor1).set_SelectedIndex(num2 - 1);
				}
			}
			else
			{
				checkBoxHuanChe1.set_Checked(false);
				((Control)comboBoxCarName1).set_Enabled(false);
				((Control)comboBoxColor1).set_Enabled(false);
			}
		}
		else
		{
			checkBoxCar1.set_Checked(false);
			checkBoxHuanChe1.set_Checked(false);
			((Control)comboBoxCarName1).set_Enabled(false);
			((Control)comboBoxColor1).set_Enabled(false);
		}
		if (jiaoBenInfo.m_CheZiInfoList[1].sTingChe == "1")
		{
			checkBoxCar2.set_Checked(true);
			if (jiaoBenInfo.m_CheZiInfoList[1].sHuanChe == "1")
			{
				checkBoxHuanChe2.set_Checked(true);
				((Control)comboBoxCarName2).set_Enabled(true);
				((Control)comboBoxColor2).set_Enabled(true);
				int num3 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[1].sCarCode);
				if (num3 > 0)
				{
					int carIndex2 = ct.GetCarIndex(num3);
					if (carIndex2 > -1)
					{
						((ListControl)comboBoxCarName2).set_SelectedIndex(carIndex2);
					}
				}
				int num4 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[1].sColor);
				if (num4 > 0 && num4 <= 7)
				{
					((ListControl)comboBoxColor2).set_SelectedIndex(num4 - 1);
				}
			}
			else
			{
				checkBoxHuanChe2.set_Checked(false);
				((Control)comboBoxCarName2).set_Enabled(false);
				((Control)comboBoxColor2).set_Enabled(false);
			}
		}
		else
		{
			checkBoxCar2.set_Checked(false);
			checkBoxHuanChe2.set_Checked(false);
			((Control)comboBoxCarName2).set_Enabled(false);
			((Control)comboBoxColor2).set_Enabled(false);
		}
		if (jiaoBenInfo.m_CheZiInfoList[2].sTingChe == "1")
		{
			checkBoxCar3.set_Checked(true);
			if (jiaoBenInfo.m_CheZiInfoList[2].sHuanChe == "1")
			{
				checkBoxHuanChe3.set_Checked(true);
				((Control)comboBoxCarName3).set_Enabled(true);
				((Control)comboBoxColor3).set_Enabled(true);
				int num5 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[2].sCarCode);
				if (num5 > 0)
				{
					int carIndex3 = ct.GetCarIndex(num5);
					if (carIndex3 > -1)
					{
						((ListControl)comboBoxCarName3).set_SelectedIndex(carIndex3);
					}
				}
				int num6 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[2].sColor);
				if (num6 > 0 && num6 <= 7)
				{
					((ListControl)comboBoxColor3).set_SelectedIndex(num6 - 1);
				}
			}
			else
			{
				checkBoxHuanChe3.set_Checked(false);
				((Control)comboBoxCarName3).set_Enabled(false);
				((Control)comboBoxColor3).set_Enabled(false);
			}
		}
		else
		{
			checkBoxCar3.set_Checked(false);
			checkBoxHuanChe3.set_Checked(false);
			((Control)comboBoxCarName3).set_Enabled(false);
			((Control)comboBoxColor3).set_Enabled(false);
		}
		if (jiaoBenInfo.m_CheZiInfoList[3].sTingChe == "1")
		{
			checkBoxCar4.set_Checked(true);
			if (jiaoBenInfo.m_CheZiInfoList[3].sHuanChe == "1")
			{
				checkBoxHuanChe4.set_Checked(true);
				((Control)comboBoxCarName4).set_Enabled(true);
				((Control)comboBoxColor4).set_Enabled(true);
				int num7 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[3].sCarCode);
				if (num7 > 0)
				{
					int carIndex4 = ct.GetCarIndex(num7);
					if (carIndex4 > -1)
					{
						((ListControl)comboBoxCarName4).set_SelectedIndex(carIndex4);
					}
				}
				int num8 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[3].sColor);
				if (num8 > 0 && num8 <= 7)
				{
					((ListControl)comboBoxColor4).set_SelectedIndex(num8 - 1);
				}
			}
			else
			{
				checkBoxHuanChe4.set_Checked(false);
				((Control)comboBoxCarName4).set_Enabled(false);
				((Control)comboBoxColor4).set_Enabled(false);
			}
		}
		else
		{
			checkBoxCar4.set_Checked(false);
			checkBoxHuanChe4.set_Checked(false);
			((Control)comboBoxCarName4).set_Enabled(false);
			((Control)comboBoxColor4).set_Enabled(false);
		}
		if (jiaoBenInfo.m_CheZiInfoList[4].sTingChe == "1")
		{
			checkBoxCar5.set_Checked(true);
			if (jiaoBenInfo.m_CheZiInfoList[4].sHuanChe == "1")
			{
				checkBoxHuanChe5.set_Checked(true);
				((Control)comboBoxCarName5).set_Enabled(true);
				((Control)comboBoxColor5).set_Enabled(true);
				int num9 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[4].sCarCode);
				if (num9 > 0)
				{
					int carIndex5 = ct.GetCarIndex(num9);
					if (carIndex5 > -1)
					{
						((ListControl)comboBoxCarName5).set_SelectedIndex(carIndex5);
					}
				}
				int num10 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[4].sColor);
				if (num10 > 0 && num10 <= 7)
				{
					((ListControl)comboBoxColor5).set_SelectedIndex(num10 - 1);
				}
			}
			else
			{
				checkBoxHuanChe5.set_Checked(false);
				((Control)comboBoxCarName5).set_Enabled(false);
				((Control)comboBoxColor5).set_Enabled(false);
			}
		}
		else
		{
			checkBoxCar5.set_Checked(false);
			checkBoxHuanChe5.set_Checked(false);
			((Control)comboBoxCarName5).set_Enabled(false);
			((Control)comboBoxColor5).set_Enabled(false);
		}
		if (jiaoBenInfo.m_CheZiInfoList[5].sTingChe == "1")
		{
			checkBoxCar6.set_Checked(true);
			if (jiaoBenInfo.m_CheZiInfoList[5].sHuanChe == "1")
			{
				checkBoxHuanChe6.set_Checked(true);
				((Control)comboBoxCarName6).set_Enabled(true);
				((Control)comboBoxColor6).set_Enabled(true);
				int num11 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[5].sCarCode);
				if (num11 > 0)
				{
					int carIndex6 = ct.GetCarIndex(num11);
					if (carIndex6 > -1)
					{
						((ListControl)comboBoxCarName6).set_SelectedIndex(carIndex6);
					}
				}
				int num12 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[5].sColor);
				if (num12 > 0 && num12 <= 7)
				{
					((ListControl)comboBoxColor6).set_SelectedIndex(num12 - 1);
				}
			}
			else
			{
				checkBoxHuanChe6.set_Checked(false);
				((Control)comboBoxCarName6).set_Enabled(false);
				((Control)comboBoxColor6).set_Enabled(false);
			}
		}
		else
		{
			checkBoxCar6.set_Checked(false);
			checkBoxHuanChe6.set_Checked(false);
			((Control)comboBoxCarName6).set_Enabled(false);
			((Control)comboBoxColor6).set_Enabled(false);
		}
		if (jiaoBenInfo.m_CheZiInfoList[6].sTingChe == "1")
		{
			checkBoxCar7.set_Checked(true);
			if (jiaoBenInfo.m_CheZiInfoList[6].sHuanChe == "1")
			{
				checkBoxHuanChe7.set_Checked(true);
				((Control)comboBoxCarName7).set_Enabled(true);
				((Control)comboBoxColor7).set_Enabled(true);
				int num13 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[6].sCarCode);
				if (num13 > 0)
				{
					int carIndex7 = ct.GetCarIndex(num13);
					if (carIndex7 > -1)
					{
						((ListControl)comboBoxCarName7).set_SelectedIndex(carIndex7);
					}
				}
				int num14 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[6].sColor);
				if (num14 > 0 && num14 <= 7)
				{
					((ListControl)comboBoxColor7).set_SelectedIndex(num14 - 1);
				}
			}
			else
			{
				checkBoxHuanChe7.set_Checked(false);
				((Control)comboBoxCarName7).set_Enabled(false);
				((Control)comboBoxColor7).set_Enabled(false);
			}
		}
		else
		{
			checkBoxCar7.set_Checked(false);
			checkBoxHuanChe7.set_Checked(false);
			((Control)comboBoxCarName7).set_Enabled(false);
			((Control)comboBoxColor7).set_Enabled(false);
		}
		if (jiaoBenInfo.m_CheZiInfoList[7].sTingChe == "1")
		{
			checkBoxCar8.set_Checked(true);
			if (jiaoBenInfo.m_CheZiInfoList[7].sHuanChe == "1")
			{
				checkBoxHuanChe8.set_Checked(true);
				((Control)comboBoxCarName8).set_Enabled(true);
				((Control)comboBoxColor8).set_Enabled(true);
				int num15 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[7].sCarCode);
				if (num15 > 0)
				{
					int carIndex8 = ct.GetCarIndex(num15);
					if (carIndex8 > -1)
					{
						((ListControl)comboBoxCarName8).set_SelectedIndex(carIndex8);
					}
				}
				int num16 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[7].sColor);
				if (num16 > 0 && num16 <= 7)
				{
					((ListControl)comboBoxColor8).set_SelectedIndex(num16 - 1);
				}
			}
			else
			{
				checkBoxHuanChe8.set_Checked(false);
				((Control)comboBoxCarName8).set_Enabled(false);
				((Control)comboBoxColor8).set_Enabled(false);
			}
		}
		else
		{
			checkBoxCar8.set_Checked(false);
			checkBoxHuanChe8.set_Checked(false);
			((Control)comboBoxCarName8).set_Enabled(false);
			((Control)comboBoxColor8).set_Enabled(false);
		}
		if (jiaoBenInfo.m_CheZiInfoList[8].sTingChe == "1")
		{
			checkBoxCar9.set_Checked(true);
			if (jiaoBenInfo.m_CheZiInfoList[8].sHuanChe == "1")
			{
				checkBoxHuanChe9.set_Checked(true);
				((Control)comboBoxCarName9).set_Enabled(true);
				((Control)comboBoxColor9).set_Enabled(true);
				int num17 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[8].sCarCode);
				if (num17 > 0)
				{
					int carIndex9 = ct.GetCarIndex(num17);
					if (carIndex9 > -1)
					{
						((ListControl)comboBoxCarName9).set_SelectedIndex(carIndex9);
					}
				}
				int num18 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[8].sColor);
				if (num18 > 0 && num18 <= 7)
				{
					((ListControl)comboBoxColor9).set_SelectedIndex(num18 - 1);
				}
			}
			else
			{
				checkBoxHuanChe9.set_Checked(false);
				((Control)comboBoxCarName9).set_Enabled(false);
				((Control)comboBoxColor9).set_Enabled(false);
			}
		}
		else
		{
			checkBoxCar9.set_Checked(false);
			checkBoxHuanChe9.set_Checked(false);
			((Control)comboBoxCarName9).set_Enabled(false);
			((Control)comboBoxColor9).set_Enabled(false);
		}
		if (jiaoBenInfo.m_CheZiInfoList[9].sTingChe == "1")
		{
			checkBoxCar10.set_Checked(true);
			if (jiaoBenInfo.m_CheZiInfoList[9].sHuanChe == "1")
			{
				checkBoxHuanChe10.set_Checked(true);
				((Control)comboBoxCarName10).set_Enabled(true);
				((Control)comboBoxColor10).set_Enabled(true);
				int num19 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[9].sCarCode);
				if (num19 > 0)
				{
					int carIndex10 = ct.GetCarIndex(num19);
					if (carIndex10 > -1)
					{
						((ListControl)comboBoxCarName10).set_SelectedIndex(carIndex10);
					}
				}
				int num20 = StringChar.SToInt(jiaoBenInfo.m_CheZiInfoList[9].sColor);
				if (num20 > 0 && num20 <= 7)
				{
					((ListControl)comboBoxColor10).set_SelectedIndex(num20 - 1);
				}
			}
			else
			{
				checkBoxHuanChe10.set_Checked(false);
				((Control)comboBoxCarName10).set_Enabled(false);
				((Control)comboBoxColor10).set_Enabled(false);
			}
		}
		else
		{
			checkBoxCar10.set_Checked(false);
			checkBoxHuanChe10.set_Checked(false);
			((Control)comboBoxCarName10).set_Enabled(false);
			((Control)comboBoxColor10).set_Enabled(false);
		}
	}

	public void ShowCarName(string sQQNum)
	{
		((Control)checkBoxCar1).set_Text("无车");
		((Control)checkBoxCar2).set_Text("无车");
		((Control)checkBoxCar3).set_Text("无车");
		((Control)checkBoxCar4).set_Text("无车");
		((Control)checkBoxCar5).set_Text("无车");
		((Control)checkBoxCar6).set_Text("无车");
		((Control)checkBoxCar7).set_Text("无车");
		((Control)checkBoxCar8).set_Text("无车");
		((Control)checkBoxCar9).set_Text("无车");
		((Control)checkBoxCar10).set_Text("无车");
		User userByQQNum = GetUserByQQNum(sQQNum);
		if (userByQQNum == null)
		{
			return;
		}
		userByQQNum.m_qc.QueryCarInfo(sQQNum);
		long count = userByQQNum.m_qc.GetCount();
		for (int i = 0; i < count; i++)
		{
			CarInfo carInfo = userByQQNum.m_qc.GetCarInfo(i);
			if (carInfo == null)
			{
				continue;
			}
			int code = StringChar.SToInt(carInfo.CarName);
			CarTypeInfo carTypeInfo = ct.GetCarTypeInfo(code);
			if (carTypeInfo != null)
			{
				switch (i)
				{
				case 0:
					((Control)checkBoxCar1).set_Text(carTypeInfo.CarName);
					break;
				case 1:
					((Control)checkBoxCar2).set_Text(carTypeInfo.CarName);
					break;
				case 2:
					((Control)checkBoxCar3).set_Text(carTypeInfo.CarName);
					break;
				case 3:
					((Control)checkBoxCar4).set_Text(carTypeInfo.CarName);
					break;
				case 4:
					((Control)checkBoxCar5).set_Text(carTypeInfo.CarName);
					break;
				case 5:
					((Control)checkBoxCar6).set_Text(carTypeInfo.CarName);
					break;
				case 6:
					((Control)checkBoxCar7).set_Text(carTypeInfo.CarName);
					break;
				case 7:
					((Control)checkBoxCar8).set_Text(carTypeInfo.CarName);
					break;
				case 8:
					((Control)checkBoxCar9).set_Text(carTypeInfo.CarName);
					break;
				case 9:
					((Control)checkBoxCar10).set_Text(carTypeInfo.CarName);
					break;
				}
			}
		}
	}

	private void listViewJiaoBenUser_MouseUp(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() != 1048576 || listViewJiaoBenUser.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		string text = listViewJiaoBenUser.get_SelectedItems().get_Item(0).get_SubItems()
			.get_Item(0)
			.get_Text();
		string text2 = listViewJiaoBenUser.get_SelectedItems().get_Item(0).get_SubItems()
			.get_Item(1)
			.get_Text();
		ShowCarName(text);
		m_JiaoBenUseriIndex = listViewJiaoBenUser.get_SelectedItems().get_Item(0).get_Index();
		if (!(m_sJiaoBenQQNum == text))
		{
			m_sJiaoBenQQNum = text;
			for (int i = 0; i < listUser.get_Items().get_Count(); i++)
			{
				listViewJiaoBenUser.get_Items().get_Item(i).set_ForeColor(Color.Black);
			}
			listViewJiaoBenUser.get_SelectedItems().get_Item(0).set_ForeColor(Color.Blue);
			ReadJiaoBen(m_sJiaoBenQQNum, text2);
		}
	}

	private void button65_Click(object sender, EventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (listViewJiaoBenUser.get_SelectedItems().get_Count() > 0 && listViewJiaoBenUser.get_SelectedItems().get_Item(0).get_Index() >= 0)
		{
			if (m_sJiaoBenQQNum.Length < 4)
			{
				MessageBox.Show("请在左侧列表中选择一个号码", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			if (((Control)textBox10).get_Text().Length < 3 && !checkBox13.get_Checked())
			{
				MessageBox.Show("请正确设置停车场", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			if (((Control)textBox11).get_Text().Length < 1)
			{
				MessageBox.Show("请正确设置脚本延时", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
		}
		if (m_sJuBaoQQNum.Length > 1)
		{
			string text = ((Control)textBox20).get_Text();
			m_iJuBaoTime = StringChar.SToInt(text);
			if (m_iJuBaoTime < 1000)
			{
				m_iJuBaoTime = 1000;
			}
			fp.WriteIniData("config", "JuBaoTime", m_iJuBaoTime.ToString(), m_strConfigPath);
			foreach (JbUserInfo jbUser in m_JbUserList)
			{
				if (jbUser.sQQNum == m_sJuBaoQQNum)
				{
					jbUser.sCars = ((Control)textBox22).get_Text();
					fp.WriteJbUser(m_sFileJbUserPath + m_user_current.m_sQQnum.ToString() + ".ini", m_JbUserList);
					break;
				}
			}
		}
		string sJiaoBenQQNum = m_sJiaoBenQQNum;
		FileJiaoBen fileJiaoBen = new FileJiaoBen();
		JiaoBenInfo jiaoBenInfo = new JiaoBenInfo();
		jiaoBenInfo.sTime = ((Control)textBox7).get_Text();
		if (checkBox11.get_Checked())
		{
			jiaoBenInfo.sTieTiaoCheWei = ((Control)textBox8).get_Text();
			if (checkBox12.get_Checked())
			{
				jiaoBenInfo.sHuiTing = "1";
			}
		}
		jiaoBenInfo.sTingCheShunXu = ((Control)textBox9).get_Text();
		jiaoBenInfo.sTingCheChang = ((Control)textBox10).get_Text();
		jiaoBenInfo.sTingCheYanShi = ((Control)textBox11).get_Text();
		jiaoBenInfo.sGuoDu = StringChar.GetQQNum(((Control)comboExcessQQ3).get_Text());
		if (checkBox13.get_Checked())
		{
			jiaoBenInfo.sYuanDi = "1";
		}
		int num = 0;
		if (checkBoxCar1.get_Checked())
		{
			jiaoBenInfo.m_CheZiInfoList[num].sTingChe = "1";
			if (checkBoxHuanChe1.get_Checked())
			{
				jiaoBenInfo.m_CheZiInfoList[num].sHuanChe = "1";
				int selectedIndex = ((ListControl)comboBoxCarName1).get_SelectedIndex();
				CarTypeInfo carTypeInfoByIndex = ct.GetCarTypeInfoByIndex(selectedIndex);
				if (carTypeInfoByIndex != null)
				{
					jiaoBenInfo.m_CheZiInfoList[num].sCarCode = carTypeInfoByIndex.code.ToString();
				}
				jiaoBenInfo.m_CheZiInfoList[num].sColor = (((ListControl)comboBoxColor1).get_SelectedIndex() + 1).ToString();
			}
		}
		num++;
		if (checkBoxCar2.get_Checked())
		{
			jiaoBenInfo.m_CheZiInfoList[num].sTingChe = "1";
			if (checkBoxHuanChe2.get_Checked())
			{
				jiaoBenInfo.m_CheZiInfoList[num].sHuanChe = "1";
				int selectedIndex2 = ((ListControl)comboBoxCarName2).get_SelectedIndex();
				CarTypeInfo carTypeInfoByIndex2 = ct.GetCarTypeInfoByIndex(selectedIndex2);
				if (carTypeInfoByIndex2 != null)
				{
					jiaoBenInfo.m_CheZiInfoList[num].sCarCode = carTypeInfoByIndex2.code.ToString();
				}
				jiaoBenInfo.m_CheZiInfoList[num].sColor = (((ListControl)comboBoxColor2).get_SelectedIndex() + 1).ToString();
			}
		}
		num++;
		if (checkBoxCar3.get_Checked())
		{
			jiaoBenInfo.m_CheZiInfoList[num].sTingChe = "1";
			if (checkBoxHuanChe3.get_Checked())
			{
				jiaoBenInfo.m_CheZiInfoList[num].sHuanChe = "1";
				int selectedIndex3 = ((ListControl)comboBoxCarName3).get_SelectedIndex();
				CarTypeInfo carTypeInfoByIndex3 = ct.GetCarTypeInfoByIndex(selectedIndex3);
				if (carTypeInfoByIndex3 != null)
				{
					jiaoBenInfo.m_CheZiInfoList[num].sCarCode = carTypeInfoByIndex3.code.ToString();
				}
				jiaoBenInfo.m_CheZiInfoList[num].sColor = (((ListControl)comboBoxColor3).get_SelectedIndex() + 1).ToString();
			}
		}
		num++;
		if (checkBoxCar4.get_Checked())
		{
			jiaoBenInfo.m_CheZiInfoList[num].sTingChe = "1";
			if (checkBoxHuanChe4.get_Checked())
			{
				jiaoBenInfo.m_CheZiInfoList[num].sHuanChe = "1";
				int selectedIndex4 = ((ListControl)comboBoxCarName4).get_SelectedIndex();
				CarTypeInfo carTypeInfoByIndex4 = ct.GetCarTypeInfoByIndex(selectedIndex4);
				if (carTypeInfoByIndex4 != null)
				{
					jiaoBenInfo.m_CheZiInfoList[num].sCarCode = carTypeInfoByIndex4.code.ToString();
				}
				jiaoBenInfo.m_CheZiInfoList[num].sColor = (((ListControl)comboBoxColor4).get_SelectedIndex() + 1).ToString();
			}
		}
		num++;
		if (checkBoxCar5.get_Checked())
		{
			jiaoBenInfo.m_CheZiInfoList[num].sTingChe = "1";
			if (checkBoxHuanChe5.get_Checked())
			{
				jiaoBenInfo.m_CheZiInfoList[num].sHuanChe = "1";
				int selectedIndex5 = ((ListControl)comboBoxCarName5).get_SelectedIndex();
				CarTypeInfo carTypeInfoByIndex5 = ct.GetCarTypeInfoByIndex(selectedIndex5);
				if (carTypeInfoByIndex5 != null)
				{
					jiaoBenInfo.m_CheZiInfoList[num].sCarCode = carTypeInfoByIndex5.code.ToString();
				}
				jiaoBenInfo.m_CheZiInfoList[num].sColor = (((ListControl)comboBoxColor5).get_SelectedIndex() + 1).ToString();
			}
		}
		num++;
		if (checkBoxCar6.get_Checked())
		{
			jiaoBenInfo.m_CheZiInfoList[num].sTingChe = "1";
			if (checkBoxHuanChe6.get_Checked())
			{
				jiaoBenInfo.m_CheZiInfoList[num].sHuanChe = "1";
				int selectedIndex6 = ((ListControl)comboBoxCarName6).get_SelectedIndex();
				CarTypeInfo carTypeInfoByIndex6 = ct.GetCarTypeInfoByIndex(selectedIndex6);
				if (carTypeInfoByIndex6 != null)
				{
					jiaoBenInfo.m_CheZiInfoList[num].sCarCode = carTypeInfoByIndex6.code.ToString();
				}
				jiaoBenInfo.m_CheZiInfoList[num].sColor = (((ListControl)comboBoxColor6).get_SelectedIndex() + 1).ToString();
			}
		}
		num++;
		if (checkBoxCar7.get_Checked())
		{
			jiaoBenInfo.m_CheZiInfoList[num].sTingChe = "1";
			if (checkBoxHuanChe7.get_Checked())
			{
				jiaoBenInfo.m_CheZiInfoList[num].sHuanChe = "1";
				int selectedIndex7 = ((ListControl)comboBoxCarName7).get_SelectedIndex();
				CarTypeInfo carTypeInfoByIndex7 = ct.GetCarTypeInfoByIndex(selectedIndex7);
				if (carTypeInfoByIndex7 != null)
				{
					jiaoBenInfo.m_CheZiInfoList[num].sCarCode = carTypeInfoByIndex7.code.ToString();
				}
				jiaoBenInfo.m_CheZiInfoList[num].sColor = (((ListControl)comboBoxColor7).get_SelectedIndex() + 1).ToString();
			}
		}
		num++;
		if (checkBoxCar8.get_Checked())
		{
			jiaoBenInfo.m_CheZiInfoList[num].sTingChe = "1";
			if (checkBoxHuanChe8.get_Checked())
			{
				jiaoBenInfo.m_CheZiInfoList[num].sHuanChe = "1";
				int selectedIndex8 = ((ListControl)comboBoxCarName8).get_SelectedIndex();
				CarTypeInfo carTypeInfoByIndex8 = ct.GetCarTypeInfoByIndex(selectedIndex8);
				if (carTypeInfoByIndex8 != null)
				{
					jiaoBenInfo.m_CheZiInfoList[num].sCarCode = carTypeInfoByIndex8.code.ToString();
				}
				jiaoBenInfo.m_CheZiInfoList[num].sColor = (((ListControl)comboBoxColor8).get_SelectedIndex() + 1).ToString();
			}
		}
		num++;
		if (checkBoxCar9.get_Checked())
		{
			jiaoBenInfo.m_CheZiInfoList[num].sTingChe = "1";
			if (checkBoxHuanChe9.get_Checked())
			{
				jiaoBenInfo.m_CheZiInfoList[num].sHuanChe = "1";
				int selectedIndex9 = ((ListControl)comboBoxCarName9).get_SelectedIndex();
				CarTypeInfo carTypeInfoByIndex9 = ct.GetCarTypeInfoByIndex(selectedIndex9);
				if (carTypeInfoByIndex9 != null)
				{
					jiaoBenInfo.m_CheZiInfoList[num].sCarCode = carTypeInfoByIndex9.code.ToString();
				}
				jiaoBenInfo.m_CheZiInfoList[num].sColor = (((ListControl)comboBoxColor9).get_SelectedIndex() + 1).ToString();
			}
		}
		num++;
		if (checkBoxCar10.get_Checked())
		{
			jiaoBenInfo.m_CheZiInfoList[num].sTingChe = "1";
			if (checkBoxHuanChe10.get_Checked())
			{
				jiaoBenInfo.m_CheZiInfoList[num].sHuanChe = "1";
				int selectedIndex10 = ((ListControl)comboBoxCarName10).get_SelectedIndex();
				CarTypeInfo carTypeInfoByIndex10 = ct.GetCarTypeInfoByIndex(selectedIndex10);
				if (carTypeInfoByIndex10 != null)
				{
					jiaoBenInfo.m_CheZiInfoList[num].sCarCode = carTypeInfoByIndex10.code.ToString();
				}
				jiaoBenInfo.m_CheZiInfoList[num].sColor = (((ListControl)comboBoxColor10).get_SelectedIndex() + 1).ToString();
			}
		}
		num++;
		fileJiaoBen.WriteJiaoBen(jiaoBenInfo, m_strJiaoBenPath + sJiaoBenQQNum.ToString() + ".ini");
	}

	private void button75_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listViewJiaoBenUser.get_Items().get_Count(); i++)
		{
			listViewJiaoBenUser.get_Items().get_Item(i).set_Checked(true);
		}
	}

	private void button76_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listViewJiaoBenUser.get_Items().get_Count(); i++)
		{
			listViewJiaoBenUser.get_Items().get_Item(i).set_Checked(false);
		}
	}

	private void button66_Click(object sender, EventArgs e)
	{
		checkBoxCar1.set_Checked(true);
		checkBoxCar2.set_Checked(true);
		checkBoxCar3.set_Checked(true);
		checkBoxCar4.set_Checked(true);
		checkBoxCar5.set_Checked(true);
		checkBoxCar6.set_Checked(true);
		checkBoxCar7.set_Checked(true);
		checkBoxCar8.set_Checked(true);
		checkBoxCar9.set_Checked(true);
		checkBoxCar10.set_Checked(true);
	}

	private void button67_Click(object sender, EventArgs e)
	{
		checkBoxCar1.set_Checked(false);
		checkBoxCar2.set_Checked(false);
		checkBoxCar3.set_Checked(false);
		checkBoxCar4.set_Checked(false);
		checkBoxCar5.set_Checked(false);
		checkBoxCar6.set_Checked(false);
		checkBoxCar7.set_Checked(false);
		checkBoxCar8.set_Checked(false);
		checkBoxCar9.set_Checked(false);
		checkBoxCar10.set_Checked(false);
	}

	private void button64_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (m_sJiaoBenQQNum.Length < 4)
		{
			MessageBox.Show("请在左侧列表中选择一个号码", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		string text = fp.ReadFriendToJiaoBen(m_sJiaoBenQQNum);
		if (text.Length >= 4)
		{
			((Control)textBox10).set_Text(text);
		}
	}

	private void checkBoxCar1_CheckedChanged(object sender, EventArgs e)
	{
		((Control)checkBoxHuanChe1).set_Enabled(checkBoxCar1.get_Checked());
		if (checkBoxCar1.get_Checked() && checkBoxHuanChe1.get_Checked())
		{
			((Control)comboBoxCarName1).set_Enabled(true);
			((Control)comboBoxColor1).set_Enabled(true);
		}
		else
		{
			((Control)comboBoxCarName1).set_Enabled(false);
			((Control)comboBoxColor1).set_Enabled(false);
		}
	}

	private void checkBoxCar2_CheckedChanged(object sender, EventArgs e)
	{
		((Control)checkBoxHuanChe2).set_Enabled(checkBoxCar2.get_Checked());
		if (checkBoxCar2.get_Checked() && checkBoxHuanChe2.get_Checked())
		{
			((Control)comboBoxCarName2).set_Enabled(true);
			((Control)comboBoxColor2).set_Enabled(true);
		}
		else
		{
			((Control)comboBoxCarName2).set_Enabled(false);
			((Control)comboBoxColor2).set_Enabled(false);
		}
	}

	private void checkBoxCar3_CheckedChanged(object sender, EventArgs e)
	{
		((Control)checkBoxHuanChe3).set_Enabled(checkBoxCar3.get_Checked());
		if (checkBoxCar3.get_Checked() && checkBoxHuanChe3.get_Checked())
		{
			((Control)comboBoxCarName3).set_Enabled(true);
			((Control)comboBoxColor3).set_Enabled(true);
		}
		else
		{
			((Control)comboBoxCarName3).set_Enabled(false);
			((Control)comboBoxColor3).set_Enabled(false);
		}
	}

	private void checkBoxCar4_CheckedChanged(object sender, EventArgs e)
	{
		((Control)checkBoxHuanChe4).set_Enabled(checkBoxCar4.get_Checked());
		if (checkBoxCar4.get_Checked() && checkBoxHuanChe4.get_Checked())
		{
			((Control)comboBoxCarName4).set_Enabled(true);
			((Control)comboBoxColor4).set_Enabled(true);
		}
		else
		{
			((Control)comboBoxCarName4).set_Enabled(false);
			((Control)comboBoxColor4).set_Enabled(false);
		}
	}

	private void checkBoxCar5_CheckedChanged(object sender, EventArgs e)
	{
		((Control)checkBoxHuanChe5).set_Enabled(checkBoxCar5.get_Checked());
		if (checkBoxCar5.get_Checked() && checkBoxHuanChe5.get_Checked())
		{
			((Control)comboBoxCarName5).set_Enabled(true);
			((Control)comboBoxColor5).set_Enabled(true);
		}
		else
		{
			((Control)comboBoxCarName5).set_Enabled(false);
			((Control)comboBoxColor5).set_Enabled(false);
		}
	}

	private void checkBoxCar6_CheckedChanged(object sender, EventArgs e)
	{
		((Control)checkBoxHuanChe6).set_Enabled(checkBoxCar6.get_Checked());
		if (checkBoxCar6.get_Checked() && checkBoxHuanChe6.get_Checked())
		{
			((Control)comboBoxCarName6).set_Enabled(true);
			((Control)comboBoxColor6).set_Enabled(true);
		}
		else
		{
			((Control)comboBoxCarName6).set_Enabled(false);
			((Control)comboBoxColor6).set_Enabled(false);
		}
	}

	private void checkBoxCar7_CheckedChanged(object sender, EventArgs e)
	{
		((Control)checkBoxHuanChe7).set_Enabled(checkBoxCar7.get_Checked());
		if (checkBoxCar7.get_Checked() && checkBoxHuanChe7.get_Checked())
		{
			((Control)comboBoxCarName7).set_Enabled(true);
			((Control)comboBoxColor7).set_Enabled(true);
		}
		else
		{
			((Control)comboBoxCarName7).set_Enabled(false);
			((Control)comboBoxColor7).set_Enabled(false);
		}
	}

	private void checkBoxCar8_CheckedChanged(object sender, EventArgs e)
	{
		((Control)checkBoxHuanChe8).set_Enabled(checkBoxCar8.get_Checked());
		if (checkBoxCar8.get_Checked() && checkBoxHuanChe8.get_Checked())
		{
			((Control)comboBoxCarName8).set_Enabled(true);
			((Control)comboBoxColor8).set_Enabled(true);
		}
		else
		{
			((Control)comboBoxCarName8).set_Enabled(false);
			((Control)comboBoxColor8).set_Enabled(false);
		}
	}

	private void checkBoxCar9_CheckedChanged(object sender, EventArgs e)
	{
		((Control)checkBoxHuanChe9).set_Enabled(checkBoxCar9.get_Checked());
		if (checkBoxCar9.get_Checked() && checkBoxHuanChe9.get_Checked())
		{
			((Control)comboBoxCarName9).set_Enabled(true);
			((Control)comboBoxColor9).set_Enabled(true);
		}
		else
		{
			((Control)comboBoxCarName9).set_Enabled(false);
			((Control)comboBoxColor9).set_Enabled(false);
		}
	}

	private void checkBoxCar10_CheckedChanged(object sender, EventArgs e)
	{
		((Control)checkBoxHuanChe10).set_Enabled(checkBoxCar10.get_Checked());
		if (checkBoxCar10.get_Checked() && checkBoxHuanChe10.get_Checked())
		{
			((Control)comboBoxCarName10).set_Enabled(true);
			((Control)comboBoxColor10).set_Enabled(true);
		}
		else
		{
			((Control)comboBoxCarName10).set_Enabled(false);
			((Control)comboBoxColor10).set_Enabled(false);
		}
	}

	private void checkBoxHuanChe1_CheckedChanged(object sender, EventArgs e)
	{
		((Control)comboBoxCarName1).set_Enabled(checkBoxHuanChe1.get_Checked());
		((Control)comboBoxColor1).set_Enabled(checkBoxHuanChe1.get_Checked());
	}

	private void checkBoxHuanChe2_CheckedChanged(object sender, EventArgs e)
	{
		((Control)comboBoxCarName2).set_Enabled(checkBoxHuanChe2.get_Checked());
		((Control)comboBoxColor2).set_Enabled(checkBoxHuanChe2.get_Checked());
	}

	private void checkBoxHuanChe3_CheckedChanged(object sender, EventArgs e)
	{
		((Control)comboBoxCarName3).set_Enabled(checkBoxHuanChe3.get_Checked());
		((Control)comboBoxColor3).set_Enabled(checkBoxHuanChe3.get_Checked());
	}

	private void checkBoxHuanChe4_CheckedChanged(object sender, EventArgs e)
	{
		((Control)comboBoxCarName4).set_Enabled(checkBoxHuanChe4.get_Checked());
		((Control)comboBoxColor4).set_Enabled(checkBoxHuanChe4.get_Checked());
	}

	private void checkBoxHuanChe5_CheckedChanged(object sender, EventArgs e)
	{
		((Control)comboBoxCarName5).set_Enabled(checkBoxHuanChe5.get_Checked());
		((Control)comboBoxColor5).set_Enabled(checkBoxHuanChe5.get_Checked());
	}

	private void checkBoxHuanChe6_CheckedChanged(object sender, EventArgs e)
	{
		((Control)comboBoxCarName6).set_Enabled(checkBoxHuanChe6.get_Checked());
		((Control)comboBoxColor6).set_Enabled(checkBoxHuanChe6.get_Checked());
	}

	private void checkBoxHuanChe7_CheckedChanged(object sender, EventArgs e)
	{
		((Control)comboBoxCarName7).set_Enabled(checkBoxHuanChe7.get_Checked());
		((Control)comboBoxColor7).set_Enabled(checkBoxHuanChe7.get_Checked());
	}

	private void checkBoxHuanChe8_CheckedChanged(object sender, EventArgs e)
	{
		((Control)comboBoxCarName8).set_Enabled(checkBoxHuanChe8.get_Checked());
		((Control)comboBoxColor8).set_Enabled(checkBoxHuanChe8.get_Checked());
	}

	private void checkBoxHuanChe9_CheckedChanged(object sender, EventArgs e)
	{
		((Control)comboBoxCarName9).set_Enabled(checkBoxHuanChe9.get_Checked());
		((Control)comboBoxColor9).set_Enabled(checkBoxHuanChe9.get_Checked());
	}

	private void checkBoxHuanChe10_CheckedChanged(object sender, EventArgs e)
	{
		((Control)comboBoxCarName10).set_Enabled(checkBoxHuanChe10.get_Checked());
		((Control)comboBoxColor10).set_Enabled(checkBoxHuanChe10.get_Checked());
	}

	private void button62_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		button65_Click(sender, e);
		timersTimerJiaoBen.Interval = 60000.0;
		m_bZhiDuiDangQian = false;
		m_bZhiDuiDangQianRun = true;
		m_strPreQQnum = "";
		m_bLianXu = checkBox14.get_Checked();
		RunJiaoBen();
	}

	private void toolStripMenuItem_25_Click(object sender, EventArgs e)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		button65_Click(sender, e);
		if (!m_bZhiDuiDangQianRun)
		{
			m_strPreQQnum = "";
			m_bZhiDuiDangQianRun = true;
			m_bZhiDuiDangQian = true;
			timersTimerJiaoBen.Interval = 2000.0;
			RunJiaoBen();
		}
		else
		{
			MessageBox.Show("脚本正在运行中，请先停止脚本运行或者等待脚本运行完毕", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void RunJiaoBen()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		long num = listViewJiaoBenUser.get_Items().get_Count();
		for (int i = 0; i < num; i++)
		{
			if (listViewJiaoBenUser.get_Items().get_Item(i).get_Checked())
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			MessageBox.Show("请在左侧列表勾选需要运行脚本的号码", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			m_bZhiDuiDangQian = false;
			m_bZhiDuiDangQianRun = false;
			return;
		}
		m_JiaoBenInfoList.Clear();
		try
		{
			for (int j = 0; j < num; j++)
			{
				if (!listViewJiaoBenUser.get_Items().get_Item(j).get_Checked())
				{
					continue;
				}
				string text = listViewJiaoBenUser.get_Items().get_Item(j).get_SubItems()
					.get_Item(0)
					.get_Text();
				string text2 = listViewJiaoBenUser.get_Items().get_Item(j).get_SubItems()
					.get_Item(1)
					.get_Text();
				JiaoBenInfo jiaoBenInfo = fjb.ReadJiaoBen(m_strJiaoBenPath + text.ToString() + ".ini", text, text2);
				if (jiaoBenInfo != null)
				{
					if (m_bJb)
					{
						jiaoBenInfo.m_RunJbUserList = fp.ReadJbUserList(m_sFileJbUserPath + text.ToString() + ".ini");
					}
					m_JiaoBenInfoList.Add(jiaoBenInfo);
				}
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		if (!m_bZhiDuiDangQian)
		{
			((Control)button62).set_Enabled(false);
			((Control)button63).set_Enabled(true);
			((Control)button65).set_Enabled(false);
		}
		foreach (ElapsedEventHandler eventJiaoBen in m_EventJiaoBenList)
		{
			timersTimerJiaoBen.Elapsed -= eventJiaoBen;
		}
		m_EventJiaoBenList.Clear();
		ElapsedEventHandler elapsedEventHandler = timersTimerJiaoBen_Elapsed;
		timersTimerJiaoBen.Elapsed += elapsedEventHandler;
		m_EventJiaoBenList.Add(elapsedEventHandler);
		timersTimerJiaoBen.Start();
	}

	private void button63_Click(object sender, EventArgs e)
	{
		timersTimerJiaoBen.Stop();
		foreach (ElapsedEventHandler eventJiaoBen in m_EventJiaoBenList)
		{
			timersTimerJiaoBen.Elapsed -= eventJiaoBen;
		}
		m_EventJiaoBenList.Clear();
		((Control)button62).set_Enabled(true);
		((Control)button63).set_Enabled(false);
		((Control)button65).set_Enabled(true);
		m_bZhiDuiDangQianRun = false;
		m_bZhiDuiDangQian = false;
	}

	private void timersTimerJiaoBen_Elapsed(object sender, ElapsedEventArgs e)
	{
		timersTimerJiaoBen.Stop();
		DateTime now = DateTime.Now;
		DateTime now2 = new DateTime(2000, 1, 1, now.Hour, now.Minute, now.Second);
		if (m_bLianXu && !m_bZhiDuiDangQian)
		{
			if (m_JiaoBenInfoList.Count > 0)
			{
				JiaoBenInfo jiaoBenInfo = m_JiaoBenInfoList[0];
				if (jiaoBenInfo != null && fjb.GetChuFa(jiaoBenInfo, now2))
				{
					bool flag = true;
					if (m_strPreQQnum == jiaoBenInfo.sQQNum && m_preTime.Hour == now2.Hour && now2.Minute - m_preTime.Minute <= 10)
					{
						flag = false;
					}
					if (flag)
					{
						m_preTime = DateTime.Now;
						m_strPreQQnum = jiaoBenInfo.sQQNum;
						foreach (JiaoBenInfo jiaoBenInfo2 in m_JiaoBenInfoList)
						{
							pri(DateTime.Now.ToString("【HH:mm:ss】") + "脚本【" + jiaoBenInfo2.sQQName + "】开始执行++++++++++++++++++++++++++++++++++++\r\n");
							ProcessJiaoBenAll(jiaoBenInfo2);
							pri(DateTime.Now.ToString("【HH:mm:ss】") + "脚本【" + jiaoBenInfo2.sQQName + "】执行完毕++++++++++++++++++++++++++++++++++++\r\n");
						}
					}
				}
			}
		}
		else if (!m_bZhiDuiDangQian)
		{
			foreach (JiaoBenInfo jiaoBenInfo3 in m_JiaoBenInfoList)
			{
				if (jiaoBenInfo3 != null && (fjb.GetChuFa(jiaoBenInfo3, now2) || m_bZhiDuiDangQian) && (!(m_strPreQQnum == jiaoBenInfo3.sQQNum) || m_bZhiDuiDangQian || m_preTime.Hour != now2.Hour || now2.Minute - m_preTime.Minute > 10))
				{
					pri(DateTime.Now.ToString("【HH:mm:ss】") + "脚本【" + jiaoBenInfo3.sQQName + "】开始执行++++++++++++++++++++++++++++++++++++\r\n");
					ProcessJiaoBenAll(jiaoBenInfo3);
					pri(DateTime.Now.ToString("【HH:mm:ss】") + "脚本【" + jiaoBenInfo3.sQQName + "】执行完毕++++++++++++++++++++++++++++++++++++\r\n");
					m_preTime = DateTime.Now;
					m_strPreQQnum = jiaoBenInfo3.sQQNum;
					break;
				}
			}
		}
		if (m_bZhiDuiDangQian)
		{
			timersTimerJiaoBen.Stop();
			foreach (ElapsedEventHandler eventJiaoBen in m_EventJiaoBenList)
			{
				timersTimerJiaoBen.Elapsed -= eventJiaoBen;
			}
			foreach (JiaoBenInfo jiaoBenInfo4 in m_JiaoBenInfoList)
			{
				pri(DateTime.Now.ToString("【HH:mm:ss】") + "脚本【" + jiaoBenInfo4.sQQName + "】开始执行++++++++++++++++++++++++++++++++++++\r\n");
				ProcessJiaoBenAll(jiaoBenInfo4);
				pri(DateTime.Now.ToString("【HH:mm:ss】") + "脚本【" + jiaoBenInfo4.sQQName + "】执行完毕++++++++++++++++++++++++++++++++++++\r\n");
			}
			m_EventJiaoBenList.Clear();
			m_bZhiDuiDangQianRun = false;
			m_bZhiDuiDangQian = false;
			m_strPreQQnum = "";
		}
		else
		{
			timersTimerJiaoBen.Start();
		}
	}

	private void ProcessJiaoBenAll(JiaoBenInfo jbinfo)
	{
		if (m_bJb)
		{
			try
			{
				pri(DateTime.Now.ToString("【HH:mm:ss】【" + jbinfo.sQQName + "】举报开始++++++++++++++++++++++++++++++++++++\r\n"));
				if (jbinfo.m_RunJbUserList.Count > 0)
				{
					ProJuBaoJiaoBen(jbinfo);
				}
				else
				{
					pri(DateTime.Now.ToString("【HH:mm:ss】【" + jbinfo.sQQName + "】没有配置举报脚本\r\n"));
				}
				pri(DateTime.Now.ToString("【HH:mm:ss】【" + jbinfo.sQQName + "】举报完毕++++++++++++++++++++++++++++++++++++\r\n"));
			}
			catch (Exception ex)
			{
				if (ex.Message.IndexOf("中止") == -1)
				{
					pri(DateTime.Now.ToString("【HH:mm:ss】") + "举报【" + jbinfo.sQQName + "】执行异常+" + ex.Message + "\r\n");
				}
				fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
			}
		}
		else
		{
			pri(DateTime.Now.ToString("【HH:mm:ss】") + "举报【" + jbinfo.sQQName + "】脚本配置为不举报\r\n");
		}
		try
		{
			ProcessJiaoBen(jbinfo);
		}
		catch (Exception ex2)
		{
			pri(DateTime.Now.ToString("【HH:mm:ss】") + "脚本【" + jbinfo.sQQName + "】执行异常+" + ex2.Message + "\r\n");
			fp.WriteLog("[" + ex2.StackTrace + "][" + ex2.Message + "]\r\n", m_strLogPath);
		}
	}

	private void ProcessJiaoBen(JiaoBenInfo jbinfo)
	{
		pri(DateTime.Now.ToString("【HH:mm:ss】") + "开始获取【" + jbinfo.sQQName + "】车位信息\r\n");
		string sQQNum = jbinfo.sQQNum;
		User userByQQNum = GetUserByQQNum(sQQNum);
		if (userByQQNum == null)
		{
			pri(DateTime.Now.ToString("【HH:mm:ss】") + "获取【" + jbinfo.sQQName + "】车位信息失败，找不到用户登陆信息\r\n");
			return;
		}
		int num = 1000;
		if (jbinfo.sTingCheYanShi.Length < 2)
		{
			num = 1000;
		}
		else
		{
			num = StringChar.SToInt(jbinfo.sTingCheYanShi);
			if (num < 1000)
			{
				num = 1000;
			}
		}
		bool bPark = false;
		bool bPark2 = false;
		bool bPark3 = false;
		bool bPark4 = false;
		if (jbinfo.sHuiTing == "1" || jbinfo.sYuanDi == "1")
		{
			string nickJB = userByQQNum.m_qc.GetNickJB(jbinfo.sGuoDu);
			User userByQQNum2 = GetUserByQQNum(jbinfo.sGuoDu);
			if (userByQQNum2 == null)
			{
				pri(DateTime.Now.ToString("【HH:mm:ss】") + "过渡车辆【" + nickJB + "】找不到过渡停车场登陆信息\r\n");
				return;
			}
			userByQQNum.m_qp.QueryParkerInfoJB(jbinfo.sGuoDu, out bPark, out bPark2, out bPark3, out bPark4);
			if (!bPark4)
			{
				ParkInfo parkInfoJB = userByQQNum.m_qp.GetParkInfoJB(3);
				if (parkInfoJB != null)
				{
					userByQQNum2.m_spc.ProStopCarsJB(parkInfoJB.sQQNum, parkInfoJB.sCarNum, "4", m_strTiTiaoLiuYan);
				}
			}
			pri(DateTime.Now.ToString("【HH:mm:ss】") + "过渡停车场【" + nickJB + "】第4个车位清空成功\r\n");
		}
		bool flag = false;
		if (jbinfo.m_sTieTiaoList.Count > 0)
		{
			if (!userByQQNum.m_qp.QueryParkerInfoJB(userByQQNum.m_sQQnum, out bPark, out bPark2, out bPark3, out bPark4))
			{
				pri(DateTime.Now.ToString("【HH:mm:ss】") + "获取【" + jbinfo.sQQName + "】车位信息失败，服务器返回信息错误\r\n");
				return;
			}
			if (!bPark && fjb.FindPark(jbinfo, "1"))
			{
				flag = true;
				ParkInfo parkInfoJB2 = userByQQNum.m_qp.GetParkInfoJB(0);
				if (parkInfoJB2 != null)
				{
					TieTiaoJiaoBen(jbinfo, userByQQNum, parkInfoJB2, num);
				}
			}
			if (!bPark2 && fjb.FindPark(jbinfo, "2"))
			{
				flag = true;
				ParkInfo parkInfoJB3 = userByQQNum.m_qp.GetParkInfoJB(1);
				if (parkInfoJB3 != null)
				{
					TieTiaoJiaoBen(jbinfo, userByQQNum, parkInfoJB3, num);
				}
			}
			if (!bPark3 && fjb.FindPark(jbinfo, "3"))
			{
				flag = true;
				ParkInfo parkInfoJB4 = userByQQNum.m_qp.GetParkInfoJB(2);
				if (parkInfoJB4 != null)
				{
					TieTiaoJiaoBen(jbinfo, userByQQNum, parkInfoJB4, num);
				}
			}
			if (!bPark4)
			{
				flag = true;
				if (fjb.FindPark(jbinfo, "4"))
				{
					ParkInfo parkInfoJB5 = userByQQNum.m_qp.GetParkInfoJB(3);
					if (parkInfoJB5 != null)
					{
						TieTiaoJiaoBen(jbinfo, userByQQNum, parkInfoJB5, num);
					}
				}
			}
		}
		if (!flag)
		{
			pri(DateTime.Now.ToString("【HH:mm:ss】") + "全部车位配置为不贴条\r\n");
		}
		pri(DateTime.Now.ToString("【HH:mm:ss】") + "开始获取【" + jbinfo.sQQName + "】车辆信息\r\n");
		bool flag2 = userByQQNum.m_qc.QueryCarInfoJB(userByQQNum.m_sQQnum);
		long countJB = userByQQNum.m_qc.GetCountJB();
		if (flag2 && countJB >= 0L)
		{
			foreach (string sTingCheShunXu in jbinfo.m_sTingCheShunXuList)
			{
				int num2 = StringChar.SToInt(sTingCheShunXu);
				if (num2 > countJB && num2 < 1)
				{
					pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + num2 + "】的车辆车牌错误\r\n");
					continue;
				}
				CarInfo carInfoJB = userByQQNum.m_qc.GetCarInfoJB(num2 - 1);
				if (carInfoJB == null)
				{
					pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + num2 + "】的车辆型号未识别\r\n");
				}
				else if (jbinfo.m_CheZiInfoList[num2 - 1].sTingChe != "1")
				{
					CarTypeInfo carTypeInfo = ct.GetCarTypeInfo(StringChar.SToInt(carInfoJB.CarName));
					pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + num2 + "】的【" + carTypeInfo.CarName + "】脚本配置为不停车\r\n");
				}
				else if (jbinfo.sYuanDi == "1")
				{
					flag2 = YuanDiTingCheJiaoBen(jbinfo, userByQQNum, carInfoJB, num);
				}
				else if (!(flag2 = PiLiangTingCheJiaoBen(jbinfo, userByQQNum, carInfoJB)))
				{
					CarTypeInfo carTypeInfo2 = ct.GetCarTypeInfo(StringChar.SToInt(carInfoJB.CarName));
					pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + num2 + "】的【" + carTypeInfo2.CarName + "】停车失败，可能是由于停车场已满\r\n");
				}
			}
			if (jbinfo.m_sTingCheShunXuList.Count < 1)
			{
				pri(DateTime.Now.ToString("【HH:mm:ss】") + "全部车辆配置为不停车\r\n");
			}
		}
		else
		{
			pri(DateTime.Now.ToString("【HH:mm:ss】") + "获取【" + jbinfo.sQQName + "】车辆信息发生错误\r\n");
		}
	}

	private bool YuanDiTingCheJiaoBen(JiaoBenInfo jbinfo, User urme, CarInfo car, int iYanShi)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Invalid comparison between Unknown and I4
		string text = null;
		CarTypeInfo carTypeInfo = ct.GetCarTypeInfo(StringChar.SToInt(car.CarName));
		string carName = carTypeInfo.CarName;
		CarTypeInfo carTypeInfo2 = ct.GetCarTypeInfo(StringChar.SToInt(jbinfo.m_CheZiInfoList[StringChar.SToInt(car.CarNum) - 1].sCarCode));
		if (jbinfo.m_CheZiInfoList[StringChar.SToInt(car.CarNum) - 1].sHuanChe == "1")
		{
			bool flag = true;
			if (carTypeInfo.CarPrice > carTypeInfo2.CarPrice)
			{
				DialogResult val = MessageBox.Show("是否确定购买低价的车？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
				if ((int)val != 6)
				{
					flag = false;
				}
			}
			if (flag)
			{
				text = urme.m_bc.ProChangeCarsJB(jbinfo.m_CheZiInfoList[StringChar.SToInt(car.CarNum) - 1].sCarCode, jbinfo.m_CheZiInfoList[StringChar.SToInt(car.CarNum) - 1].sColor, car.CarNum);
				if (text != null)
				{
					long num = carTypeInfo.CarPrice;
					long num2 = carTypeInfo2.CarPrice;
					for (int num3 = ct.GetCount() - 1; num3 >= 0; num3--)
					{
						CarTypeInfo carTypeInfoByIndex = ct.GetCarTypeInfoByIndex(num3);
						if (carTypeInfoByIndex != null)
						{
							long num4 = carTypeInfoByIndex.CarPrice;
							if (num4 > num && num4 <= num2)
							{
								text = urme.m_bc.ProChangeCarsJB(carTypeInfoByIndex.code.ToString(), jbinfo.m_CheZiInfoList[StringChar.SToInt(car.CarNum) - 1].sColor, car.CarNum);
								if (text == null)
								{
									carTypeInfo2 = carTypeInfoByIndex;
									pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + car.CarNum + "】的【" + carName + "】成功换为【" + carTypeInfo2.CarName + "】\r\n");
									carName = carTypeInfo2.CarName;
									carTypeInfo = carTypeInfo2;
									break;
								}
							}
							if (num4 <= num)
							{
								break;
							}
						}
					}
					if (text != null)
					{
						pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + car.CarNum + "】的【" + carTypeInfo.CarName + "】换车失败：" + text + "\r\n");
					}
				}
				else
				{
					pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + car.CarNum + "】的【" + carName + "】成功换为【" + carTypeInfo2.CarName + "】\r\n");
					carName = carTypeInfo2.CarName;
					carTypeInfo = carTypeInfo2;
				}
			}
		}
		string nickJB = urme.m_qc.GetNickJB(car.QQNum);
		string nickJB2 = urme.m_qc.GetNickJB(jbinfo.sGuoDu);
		User userByQQNum = GetUserByQQNum(jbinfo.sGuoDu);
		if (userByQQNum == null)
		{
			pri(DateTime.Now.ToString("【HH:mm:ss】") + "过渡车辆【" + nickJB2 + "】找不到过渡停车场登陆信息\r\n");
			return false;
		}
		string outparkno = null;
		urme.m_stc.InitParkJB(jbinfo.sGuoDu);
		text = urme.m_stc.ProStartCarsJB(car.CarNum, "4", out outparkno);
		if (text != null)
		{
			int num5 = 0;
			while (true)
			{
				if (iYanShi > 0)
				{
					Thread.Sleep(iYanShi);
				}
				text = urme.m_stc.ProStartCarsJB(car.CarNum, "4", out outparkno);
				if (text == null || num5 > iReCount * 3)
				{
					break;
				}
				num5++;
			}
		}
		if (text != null)
		{
			pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + car.CarNum + "】的【" + carName + "】停到过渡停车场【" + nickJB2 + "】失败：" + text + "\r\n");
		}
		if (text == null)
		{
			text = userByQQNum.m_spc.ProStopCarsJB(urme.m_sQQnum, car.CarNum, "4", m_strTiTiaoLiuYan);
			if (text != null)
			{
				int num6 = 0;
				while (true)
				{
					if (iYanShi > 0)
					{
						Thread.Sleep(iYanShi);
					}
					text = userByQQNum.m_spc.ProStopCarsJB(urme.m_sQQnum, car.CarNum, "4", m_strTiTiaoLiuYan);
					if (text == null || num6 > iReCount * 3)
					{
						break;
					}
					num6++;
				}
			}
			if (text != null)
			{
				pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + car.CarNum + "】的【" + carName + "】过渡停车场【" + nickJB2 + "】贴条失败：" + text + "\r\n");
			}
			if (text == null)
			{
				urme.m_stc.InitParkJB(car.QQNum);
				text = urme.m_stc.ProStartCarsJB(car.CarNum, null, out outparkno);
				if (text != null)
				{
					int num7 = 0;
					while (true)
					{
						if (iYanShi > 0)
						{
							Thread.Sleep(iYanShi);
						}
						text = urme.m_stc.ProStartCarsJB(car.CarNum, null, out outparkno);
						if (text == null || num7 > iReCount * 3)
						{
							break;
						}
						num7++;
					}
				}
				if (text == null)
				{
					pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + car.CarNum + "】的【" + carName + "】成功的原地停到【" + nickJB + "】的停车场\r\n");
					return true;
				}
				pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + car.CarNum + "】的【" + carName + "】原地停到【" + nickJB + "】失败：" + text + "\r\n");
			}
		}
		return false;
	}

	private bool PiLiangTingCheJiaoBen(JiaoBenInfo jbinfo, User urme, CarInfo car)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Invalid comparison between Unknown and I4
		string text = null;
		CarTypeInfo carTypeInfo = ct.GetCarTypeInfo(StringChar.SToInt(car.CarName));
		string carName = carTypeInfo.CarName;
		CarTypeInfo carTypeInfo2 = ct.GetCarTypeInfo(StringChar.SToInt(jbinfo.m_CheZiInfoList[StringChar.SToInt(car.CarNum) - 1].sCarCode));
		if (jbinfo.m_CheZiInfoList[StringChar.SToInt(car.CarNum) - 1].sHuanChe == "1")
		{
			bool flag = true;
			if (carTypeInfo.CarPrice > carTypeInfo2.CarPrice)
			{
				DialogResult val = MessageBox.Show("是否确定购买低价的车？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
				if ((int)val != 6)
				{
					flag = false;
				}
			}
			if (flag)
			{
				text = urme.m_bc.ProChangeCarsJB(jbinfo.m_CheZiInfoList[StringChar.SToInt(car.CarNum) - 1].sCarCode, jbinfo.m_CheZiInfoList[StringChar.SToInt(car.CarNum) - 1].sColor, car.CarNum);
				if (text != null)
				{
					long num = carTypeInfo.CarPrice;
					long num2 = carTypeInfo2.CarPrice;
					for (int num3 = ct.GetCount() - 1; num3 >= 0; num3--)
					{
						CarTypeInfo carTypeInfoByIndex = ct.GetCarTypeInfoByIndex(num3);
						if (carTypeInfoByIndex != null)
						{
							long num4 = carTypeInfoByIndex.CarPrice;
							if (num4 > num && num4 <= num2)
							{
								text = urme.m_bc.ProChangeCarsJB(carTypeInfoByIndex.code.ToString(), jbinfo.m_CheZiInfoList[StringChar.SToInt(car.CarNum) - 1].sColor, car.CarNum);
								if (text == null)
								{
									carTypeInfo2 = carTypeInfoByIndex;
									pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + car.CarNum + "】的【" + carName + "】成功换为【" + carTypeInfo2.CarName + "】\r\n");
									carName = carTypeInfo2.CarName;
									carTypeInfo = carTypeInfo2;
									break;
								}
							}
							if (num4 <= num)
							{
								break;
							}
						}
					}
					if (text != null)
					{
						pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + car.CarNum + "】的【" + carTypeInfo.CarName + "】换车失败：" + text + "\r\n");
					}
				}
				else
				{
					pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + car.CarNum + "】的【" + carName + "】成功换为【" + carTypeInfo2.CarName + "】\r\n");
					carName = carTypeInfo2.CarName;
					carTypeInfo = carTypeInfo2;
				}
			}
		}
		foreach (string sTingCheChang in jbinfo.m_sTingCheChangList)
		{
			urme.m_stc.InitParkJB(sTingCheChang);
			if (!urme.m_stc.IsFullJB())
			{
				string outparkno = null;
				text = urme.m_stc.ProStartCarsJB(car.CarNum, null, out outparkno);
				if (text == null)
				{
					string nickJB = urme.m_qc.GetNickJB(sTingCheChang);
					pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + car.CarNum + "】的【" + carName + "】成功的停到【" + nickJB + "】的停车场\r\n");
					return true;
				}
				if (text.IndexOf("停满15分钟") != -1)
				{
					pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + car.CarNum + "】的【" + carName + "】停车失败：" + text + "\r\n");
					return true;
				}
			}
			if (jbinfo.m_sTingCheChangList.Count < 1)
			{
				pri(DateTime.Now.ToString("【HH:mm:ss】") + "没有配置足够的停车场\r\n");
			}
		}
		return false;
	}

	private bool TieTiaoJiaoBen(JiaoBenInfo jbinfo, User urme, ParkInfo par, int iYanShi)
	{
		CarTypeInfo carTypeInfo = ct.GetCarTypeInfo(StringChar.SToInt(par.sCarName));
		string text = urme.m_spc.ProStopCarsJB(par.sQQNum, par.sCarNum, par.sParkID, m_strTiTiaoLiuYan);
		if (text != null)
		{
			int num = 0;
			while (true)
			{
				if (iYanShi > 0)
				{
					Thread.Sleep(iYanShi);
				}
				text = urme.m_spc.ProStopCarsJB(par.sQQNum, par.sCarNum, par.sParkID, m_strTiTiaoLiuYan);
				if (text == null || num > iReCount * 3)
				{
					break;
				}
				num++;
			}
		}
		if (text == null)
		{
			pri(DateTime.Now.ToString("【HH:mm:ss】") + "【" + par.sQQName + "】的【" + carTypeInfo.CarName + "】成功地被贴条\r\n");
		}
		if (text == null && jbinfo.sHuiTing == "1")
		{
			User userByQQNum = GetUserByQQNum(par.sQQNum);
			if (userByQQNum == null)
			{
				pri(DateTime.Now.ToString("【HH:mm:ss】") + "被贴车辆【" + par.sQQName + "】找不到用户登陆信息\r\n");
				return false;
			}
			User userByQQNum2 = GetUserByQQNum(jbinfo.sGuoDu);
			if (userByQQNum2 == null)
			{
				string nickJB = urme.m_qc.GetNickJB(jbinfo.sGuoDu);
				pri(DateTime.Now.ToString("【HH:mm:ss】") + "过渡停车场【" + nickJB + "】找不到过渡停车场登陆信息\r\n");
				return false;
			}
			string outparkno = null;
			userByQQNum.m_stc.InitParkJB(jbinfo.sGuoDu);
			text = userByQQNum.m_stc.ProStartCarsJB(par.sCarNum, "4", out outparkno);
			if (text != null)
			{
				int num2 = 0;
				while (true)
				{
					if (iYanShi > 0)
					{
						Thread.Sleep(iYanShi);
					}
					text = userByQQNum.m_stc.ProStartCarsJB(par.sCarNum, "4", out outparkno);
					if (text == null || num2 > iReCount * 3)
					{
						break;
					}
					num2++;
				}
			}
			if (text != null)
			{
				pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + par.sCarNum + "】的【" + carTypeInfo.CarName + "】回停失败：" + text + "\r\n");
			}
			if (text == null)
			{
				text = userByQQNum2.m_spc.ProStopCarsJB(par.sQQNum, par.sCarNum, "4", m_strTiTiaoLiuYan);
				if (text != null)
				{
					int num3 = 0;
					while (true)
					{
						if (iYanShi > 0)
						{
							Thread.Sleep(iYanShi);
						}
						text = userByQQNum2.m_spc.ProStopCarsJB(par.sQQNum, par.sCarNum, "4", m_strTiTiaoLiuYan);
						if (text == null || num3 > iReCount * 3)
						{
							break;
						}
						num3++;
					}
				}
				if (text == null)
				{
					userByQQNum.m_stc.InitParkJB(urme.m_sQQnum);
					text = userByQQNum.m_stc.ProStartCarsJB(par.sCarNum, par.sParkID, out outparkno);
					if (text != null)
					{
						int num4 = 0;
						while (true)
						{
							if (iYanShi > 0)
							{
								Thread.Sleep(iYanShi);
							}
							text = userByQQNum.m_stc.ProStartCarsJB(par.sCarNum, par.sParkID, out outparkno);
							if (text == null || num4 > iReCount * 3)
							{
								break;
							}
							num4++;
						}
					}
				}
			}
			if (text == null)
			{
				pri(DateTime.Now.ToString("【HH:mm:ss】") + "【" + par.sQQName + "】的【" + carTypeInfo.CarName + "】成功地回停\r\n");
			}
		}
		return true;
	}

	private void button74_Click(object sender, EventArgs e)
	{
		((Control)textBox3).set_Text("");
	}

	private void pri(string t)
	{
		if (!((Control)textBox3).get_InvokeRequired())
		{
			((TextBoxBase)textBox3).AppendText(t);
			return;
		}
		aa aa = pri;
		((Control)this).Invoke((Delegate)aa, new object[1] { t });
	}

	private void priSlave(string t)
	{
		if (!((Control)textBoxNuLiShiJian).get_InvokeRequired())
		{
			((TextBoxBase)textBoxNuLiShiJian).AppendText(t);
			return;
		}
		aa aa = priSlave;
		((Control)this).Invoke((Delegate)aa, new object[1] { t });
	}

	private void button77_Click(object sender, EventArgs e)
	{
		RefresFriend(bXianShiXiangXi: true);
	}

	private void checkBox13_CheckedChanged(object sender, EventArgs e)
	{
		((Control)textBox10).set_Enabled(!checkBox13.get_Checked());
	}

	private void button79_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (m_sJiaoBenQQNum.Length < 4)
		{
			MessageBox.Show("请在下面用户列表中选中一个号码", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		long num = listViewJiaoBenUser.get_Items().get_Count();
		if (m_JiaoBenUseriIndex >= 1 && num >= 2L)
		{
			string text = listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex).get_SubItems()
				.get_Item(0)
				.get_Text();
			string text2 = listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex).get_SubItems()
				.get_Item(1)
				.get_Text();
			bool @checked = listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex).get_Checked();
			string text3 = listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex - 1).get_SubItems()
				.get_Item(0)
				.get_Text();
			string text4 = listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex - 1).get_SubItems()
				.get_Item(1)
				.get_Text();
			bool checked2 = listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex - 1).get_Checked();
			listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex).get_SubItems()
				.get_Item(0)
				.set_Text(text3);
			listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex).get_SubItems()
				.get_Item(1)
				.set_Text(text4);
			listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex).set_Checked(checked2);
			listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex - 1).get_SubItems()
				.get_Item(0)
				.set_Text(text);
			listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex - 1).get_SubItems()
				.get_Item(1)
				.set_Text(text2);
			listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex - 1).set_Checked(@checked);
			listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex).set_ForeColor(Color.Black);
			listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex - 1).set_ForeColor(Color.Blue);
			m_JiaoBenUseriIndex--;
		}
	}

	private void button80_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (m_sJiaoBenQQNum.Length < 4)
		{
			MessageBox.Show("请在下面用户列表中选中一个号码", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		long num = listViewJiaoBenUser.get_Items().get_Count();
		if (m_JiaoBenUseriIndex != num - 1L && num >= 2L && m_JiaoBenUseriIndex >= 0)
		{
			string text = listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex).get_SubItems()
				.get_Item(0)
				.get_Text();
			string text2 = listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex).get_SubItems()
				.get_Item(1)
				.get_Text();
			bool @checked = listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex).get_Checked();
			string text3 = listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex + 1).get_SubItems()
				.get_Item(0)
				.get_Text();
			string text4 = listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex + 1).get_SubItems()
				.get_Item(1)
				.get_Text();
			bool checked2 = listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex + 1).get_Checked();
			listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex).get_SubItems()
				.get_Item(0)
				.set_Text(text3);
			listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex).get_SubItems()
				.get_Item(1)
				.set_Text(text4);
			listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex).set_Checked(checked2);
			listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex + 1).get_SubItems()
				.get_Item(0)
				.set_Text(text);
			listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex + 1).get_SubItems()
				.get_Item(1)
				.set_Text(text2);
			listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex + 1).set_Checked(@checked);
			listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex).set_ForeColor(Color.Black);
			listViewJiaoBenUser.get_Items().get_Item(m_JiaoBenUseriIndex + 1).set_ForeColor(Color.Blue);
			m_JiaoBenUseriIndex++;
		}
	}

	private void checkBox14_CheckedChanged(object sender, EventArgs e)
	{
		m_bLianXu = checkBox14.get_Checked();
		fp.WriteIniData("config", "LianXu", m_bLianXu.ToString(), m_strConfigPath);
	}

	private void textValidate_TextChanged(object sender, EventArgs e)
	{
		if (((Control)textValidate).get_Text().Length >= 4)
		{
			buttonLogin_Click(sender, e);
		}
	}

	private void listViewJiaoBenUser_MouseDown(object sender, MouseEventArgs e)
	{
		button65_Click(sender, (EventArgs)(object)e);
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		_ = DateTime.Now;
		for (int i = 0; i < listViewSlave.get_Items().get_Count(); i++)
		{
			if (listViewSlave.get_Items().get_Item(i).get_ForeColor() == Color.Blue)
			{
				listViewSlave.get_Items().get_Item(i).set_Checked(true);
			}
			else
			{
				listViewSlave.get_Items().get_Item(i).set_Checked(false);
			}
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		string text = "购买奴隶后当天释放：1分钱都不退\r\n购买奴隶后二天释放：退给你原价的80%\r\n购买奴隶后三天释放：退给你原价（但要扣¥50手续费）\r\n你铁了心要释放并回购吗？";
		DialogResult val = MessageBox.Show(text, "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
		if ((int)val != 6)
		{
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		tabControl5.set_SelectedIndex(1);
		long sMyBuyMoney = m_sMyBuyMoney;
		long sMyCapital = m_sMyCapital;
		long sMyMoney = m_sMyMoney;
		bool flag = false;
		for (int i = 0; i < listViewSlave.get_Items().get_Count(); i++)
		{
			if (!listViewSlave.get_Items().get_Item(i).get_Checked())
			{
				continue;
			}
			string text2 = listViewSlave.get_Items().get_Item(i).get_SubItems()
				.get_Item(0)
				.get_Text();
			string text3 = listViewSlave.get_Items().get_Item(i).get_SubItems()
				.get_Item(1)
				.get_Text();
			string text4 = m_user_current.m_hymm.ProShiFang(text2);
			if (text4 != null)
			{
				((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [释放奴隶失败] [") + text3 + "] " + text4 + "\r\n");
				continue;
			}
			flag = true;
			((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [释放奴隶成功] [") + text3 + "] \r\n");
			string text5 = listViewSlave.get_Items().get_Item(i).get_SubItems()
				.get_Item(2)
				.get_Text();
			text4 = m_user_current.m_hymm.ProBuyFriend(text2, text5);
			if (text4 != null)
			{
				((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [购买奴隶失败] [") + text3 + "]" + text4 + "\r\n");
			}
			else
			{
				MaiDeQiFriend(bXiangXi: false);
				((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [购买奴隶成功] [") + text3 + "]\r\n");
			}
		}
		if (flag)
		{
			RefresFriendNormal();
		}
		ShowMyhaoyuMaiInfo(sMyBuyMoney, sMyCapital, sMyMoney);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void button_3_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		timersTimerHaoYou.Interval = 10000.0;
		tabControl5.set_SelectedIndex(1);
		((Control)button_4).set_Enabled(true);
		((Control)button_3).set_Enabled(false);
		m_strUserDingShiMai = m_user_current;
		m_SlaveInfoList.Clear();
		string text = m_user_current.m_qqq.QueryQQBuyFriendDS(m_user_current.m_sQQnum);
		if (text != null)
		{
			((Control)this).set_Cursor(Cursors.get_Default());
			priSlave(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [查询奴隶信息发生错误] ") + text + "\r\n");
		}
		else
		{
			long countDS = m_user_current.m_qqq.GetCountDS();
			for (int i = 0; i < countDS; i++)
			{
				SlaveInfo slaveInfoDS = m_user_current.m_qqq.GetSlaveInfoDS(i);
				if (slaveInfoDS != null)
				{
					m_SlaveInfoList.Add(slaveInfoDS);
				}
			}
		}
		timersTimerHaoYou.Start();
	}

	private void button_4_Click(object sender, EventArgs e)
	{
		timersTimerHaoYou.Stop();
		m_SlaveInfoList.Clear();
		((Control)button_4).set_Enabled(false);
		((Control)button_3).set_Enabled(true);
	}

	private void timersTimerHaoYou_Elapsed(object sender, ElapsedEventArgs e)
	{
		timersTimerHaoYou.Stop();
		if (m_strUserDingShiMai != null)
		{
			Collection<SlaveInfo> collection = new Collection<SlaveInfo>();
			string text = m_strUserDingShiMai.m_qqq.QueryQQBuyFriendDS(m_strUserDingShiMai.m_sQQnum);
			if (text != null)
			{
				((Control)this).set_Cursor(Cursors.get_Default());
				priSlave(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [查询奴隶信息发生错误] ") + text + "\r\n");
			}
			else
			{
				long countDS = m_strUserDingShiMai.m_qqq.GetCountDS();
				for (int i = 0; i < countDS; i++)
				{
					SlaveInfo slaveInfoDS = m_strUserDingShiMai.m_qqq.GetSlaveInfoDS(i);
					if (slaveInfoDS != null)
					{
						collection.Add(slaveInfoDS);
					}
				}
				foreach (SlaveInfo slaveInfo in m_SlaveInfoList)
				{
					if (slaveInfo == null)
					{
						continue;
					}
					bool flag = false;
					foreach (SlaveInfo item in collection)
					{
						if (item != null && slaveInfo.sQQNum == item.sQQNum)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						priSlave(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [发现奴隶被购买了，开始回购] ") + slaveInfo.sQQName + "\r\n");
						text = m_strUserDingShiMai.m_hymm.ProBuyFriend(slaveInfo.sQQNum, m_sSlaveChuoHao);
						if (text != null)
						{
							priSlave(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [购买奴隶失败] [") + slaveInfo.sQQName + "]" + text + "\r\n");
						}
						else
						{
							priSlave(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [购买奴隶成功] [") + slaveInfo.sQQName + "]\r\n");
						}
					}
				}
			}
		}
		timersTimerHaoYou.Start();
	}

	private void checkBox_0_CheckedChanged(object sender, EventArgs e)
	{
		m_bShowBMD = checkBox_0.get_Checked();
		fp.WriteIniData("config", "ShowBMD", m_bShowBMD.ToString(), m_strConfigPath);
	}

	private void checkBox_1_CheckedChanged(object sender, EventArgs e)
	{
		m_bLoginZhzx = checkBox_1.get_Checked();
		fp.WriteIniData("config", "LoginZhzx", m_bLoginZhzx.ToString(), m_strConfigPath);
	}

	private void checkBox_2_CheckedChanged(object sender, EventArgs e)
	{
		m_bDxhzx1 = checkBox_2.get_Checked();
		fp.WriteIniData("config", "Dxhzx1", m_bDxhzx1.ToString(), m_strConfigPath);
	}

	private void checkBox_6_CheckedChanged(object sender, EventArgs e)
	{
		m_bDxhzx2 = checkBox_6.get_Checked();
		fp.WriteIniData("config", "Dxhzx2", m_bDxhzx2.ToString(), m_strConfigPath);
	}

	private void checkBox_5_CheckedChanged(object sender, EventArgs e)
	{
		m_bDxhzx3 = checkBox_5.get_Checked();
		fp.WriteIniData("config", "Dxhzx3", m_bDxhzx3.ToString(), m_strConfigPath);
	}

	private void checkBox_4_CheckedChanged(object sender, EventArgs e)
	{
		m_bDxhzx4 = checkBox_4.get_Checked();
		fp.WriteIniData("config", "Dxhzx4", m_bDxhzx4.ToString(), m_strConfigPath);
	}

	private void checkBox_3_CheckedChanged(object sender, EventArgs e)
	{
		m_bDxhzx5 = checkBox_3.get_Checked();
		fp.WriteIniData("config", "Dxhzx5", m_bDxhzx5.ToString(), m_strConfigPath);
	}

	private void checkBox_8_CheckedChanged(object sender, EventArgs e)
	{
		m_bDxhzx6 = checkBox_8.get_Checked();
		fp.WriteIniData("config", "Dxhzx6", m_bDxhzx6.ToString(), m_strConfigPath);
	}

	private void checkBox_7_CheckedChanged(object sender, EventArgs e)
	{
		m_bDxhzx7 = checkBox_7.get_Checked();
		fp.WriteIniData("config", "Dxhzx7", m_bDxhzx7.ToString(), m_strConfigPath);
	}

	private void button_7_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listView_1.get_Items().get_Count(); i++)
		{
			listView_1.get_Items().get_Item(i).set_Checked(true);
		}
	}

	private void button_8_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listView_1.get_Items().get_Count(); i++)
		{
			listView_1.get_Items().get_Item(i).set_Checked(false);
		}
	}

	private void button_5_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		string text = ((Control)textBox_0).get_Text().Trim();
		if (text.Length < 4)
		{
			return;
		}
		int num = 0;
		while (true)
		{
			if (num < listView_0.get_Items().get_Count())
			{
				string text2 = listView_0.get_Items().get_Item(num).get_SubItems()
					.get_Item(0)
					.get_Text();
				if (!(text == text2))
				{
					num++;
					continue;
				}
				break;
			}
			string qQNick = m_user_current.m_qp.GetQQNick(text);
			string text3 = listView_0.get_Items().get_Count().ToString();
			listView_0.get_Items().Add(text3, text, 0);
			listView_0.get_Items().get_Item(text3).get_SubItems()
				.Add(qQNick);
			listView_0.get_Items().get_Item(text3).get_SubItems()
				.Add("");
			listView_0.get_Items().get_Item(text3).get_SubItems()
				.Add("");
			DhUserInfo dhUserInfo = new DhUserInfo();
			dhUserInfo.sQQNum = text;
			dhUserInfo.sQQName = qQNick;
			m_DhUserList.Add(dhUserInfo);
			fp.AddDhUser(m_sFileDhUserPath, m_DhUserList, text, qQNick);
			break;
		}
	}

	private void button_6_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		if (listView_0.get_SelectedItems().get_Count() < 1)
		{
			MessageBox.Show("请在下面列表中左键选中需要删除的项", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		DialogResult val = MessageBox.Show("你确定要在列表中删除该大号吗？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
		if ((int)val != 6)
		{
			return;
		}
		int index = listView_0.get_SelectedItems().get_Item(0).get_Index();
		string text = listView_0.get_SelectedItems().get_Item(0).get_SubItems()
			.get_Item(0)
			.get_Text();
		listView_0.get_Items().RemoveAt(index);
		foreach (DhUserInfo dhUser in m_DhUserList)
		{
			if (dhUser.sQQNum == text)
			{
				m_DhUserList.Remove(dhUser);
				break;
			}
		}
		fp.WriteDhUser(m_sFileDhUserPath, m_DhUserList);
	}

	private void button_10_Click(object sender, EventArgs e)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		listView_1.get_Items().Clear();
		foreach (User user in m_UserList)
		{
			string qQNum = StringChar.GetQQNum(user.m_sQQnum);
			string sQQnick = user.m_sQQnick;
			listView_1.set_View((View)1);
			ListViewItem val = new ListViewItem(qQNum);
			val.get_SubItems().Add(sQQnick);
			val.get_SubItems().Add("");
			listView_1.get_Items().Add(val);
		}
		((Control)listView_1).Update();
	}

	private void button_11_Click(object sender, EventArgs e)
	{
		foreach (Thread threadDxh in m_ThreadDxhList)
		{
			threadDxh.Abort();
		}
		m_ThreadDxhList.Clear();
		m_DhTsUserList.Clear();
	}

	private void button_9_Click(object sender, EventArgs e)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Control)textBox21).get_Text();
		m_iCiShu = StringChar.SToInt(text);
		if (m_iCiShu >= 1 && m_iCiShu <= 100)
		{
			fp.WriteIniData("config", "CiShu", m_iCiShu.ToString(), m_strConfigPath);
			bool flag = false;
			long num = listView_0.get_Items().get_Count();
			for (int i = 0; i < num; i++)
			{
				if (listView_0.get_Items().get_Item(i).get_Checked())
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				MessageBox.Show("请在大号列表中勾选需要执行的大号", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			m_DhTsUserList.Clear();
			for (int j = 0; j < num; j++)
			{
				if (listView_0.get_Items().get_Item(j).get_Checked())
				{
					DhUserInfo dhUserInfo = new DhUserInfo();
					dhUserInfo.sQQNum = listView_0.get_Items().get_Item(j).get_SubItems()
						.get_Item(0)
						.get_Text();
					dhUserInfo.sQQName = listView_0.get_Items().get_Item(j).get_SubItems()
						.get_Item(1)
						.get_Text();
					dhUserInfo.iIndex = j;
					m_DhTsUserList.Add(dhUserInfo);
				}
			}
			flag = false;
			num = listView_1.get_Items().get_Count();
			for (int k = 0; k < num; k++)
			{
				if (listView_1.get_Items().get_Item(k).get_Checked())
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				MessageBox.Show("请在小号列表中勾选需要执行的小号", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			for (int l = 0; l < num; l++)
			{
				if (listView_1.get_Items().get_Item(l).get_Checked())
				{
					string text2 = listView_1.get_Items().get_Item(l).get_SubItems()
						.get_Item(0)
						.get_Text();
					listView_1.get_Items().get_Item(l).get_SubItems()
						.get_Item(1)
						.get_Text();
					ThreadProcPamaDxh threadProcPamaDxh = new ThreadProcPamaDxh();
					threadProcPamaDxh.bThread = true;
					threadProcPamaDxh.iIndex = l;
					User user = (threadProcPamaDxh.ur = GetUserByQQNum(text2));
					Thread thread = new Thread(ThreadProcStartDxh);
					thread.Start(threadProcPamaDxh);
					m_ThreadDxhList.Add(thread);
				}
			}
		}
		else
		{
			MessageBox.Show("QQ空间访问次数范围为（1-100）", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	public void ThreadProcStartDxh(object date)
	{
		ThreadProcPamaDxh threadProcPamaDxh = (ThreadProcPamaDxh)date;
		if (threadProcPamaDxh != null)
		{
			if (m_bDxhzx5)
			{
				method_10(threadProcPamaDxh);
			}
			if (m_bDxhzx6)
			{
				method_11(threadProcPamaDxh);
			}
			if (m_bDxhzx7)
			{
				method_12(threadProcPamaDxh);
			}
			if (m_bDxhzx2)
			{
				method_13(threadProcPamaDxh);
			}
			if (m_bDxhzx3)
			{
				method_14(threadProcPamaDxh);
			}
			if (m_bDxhzx4)
			{
				method_15(threadProcPamaDxh);
			}
			if (m_bDxhzx8)
			{
				method_6(threadProcPamaDxh);
			}
			if (m_bDxhzx9)
			{
				method_7(threadProcPamaDxh);
			}
			if (m_bDxhzx10)
			{
				method_8(threadProcPamaDxh);
			}
			if (m_bDxhzx11)
			{
				method_9(threadProcPamaDxh);
			}
			if (m_bDxhzx1)
			{
				method_16(threadProcPamaDxh);
			}
			priXx(threadProcPamaDxh.iIndex, 2, "全部完成");
			threadProcPamaDxh.bThread = false;
		}
	}

	private void method_6(ThreadProcPamaDxh tp)
	{
		tp.ur.ProBblykd();
		priXx(tp.iIndex, 2, "宝宝乐园开蛋完成");
	}

	private void method_7(ThreadProcPamaDxh tp)
	{
		tp.ur.ProKtht();
		priXx(tp.iIndex, 2, "开通花藤完成");
	}

	private void method_8(ThreadProcPamaDxh tp)
	{
		tp.ur.ProKtqcw();
		priXx(tp.iIndex, 2, "开通抢车位完成");
	}

	private void method_9(ThreadProcPamaDxh tp)
	{
		tp.ur.ProKthymm();
		priXx(tp.iIndex, 2, "开通好友买卖完成");
	}

	private void method_10(ThreadProcPamaDxh tp)
	{
		tp.ur.LoginQcw();
		priXx(tp.iIndex, 2, "登录抢车位完成");
	}

	private void method_11(ThreadProcPamaDxh tp)
	{
		tp.ur.LoginHymm();
		priXx(tp.iIndex, 2, "登录好友买卖完成");
	}

	private void method_12(ThreadProcPamaDxh tp)
	{
		tp.ur.LoginHymmMyk();
		priXx(tp.iIndex, 2, "好友买卖命运卡完成");
	}

	private void method_13(ThreadProcPamaDxh tp)
	{
		foreach (DhUserInfo dhTsUser in m_DhTsUserList)
		{
			tp.ur.ProHt(dhTsUser.sQQNum);
		}
		priXx(tp.iIndex, 2, "增加大号QQ花藤属性完成");
	}

	private void method_14(ThreadProcPamaDxh tp)
	{
		foreach (DhUserInfo dhTsUser in m_DhTsUserList)
		{
			tp.ur.ProMgy(dhTsUser.sQQNum);
		}
		priXx(tp.iIndex, 2, "浪漫玫瑰园完成");
	}

	private void method_15(ThreadProcPamaDxh tp)
	{
		foreach (DhUserInfo dhTsUser in m_DhTsUserList)
		{
			tp.ur.ProXhmg(dhTsUser.sQQNum);
		}
		priXx(tp.iIndex, 2, "赠送鲜花红玫瑰完成");
	}

	private void method_16(ThreadProcPamaDxh tp)
	{
		foreach (DhUserInfo dhTsUser in m_DhTsUserList)
		{
			string sVisitcount = null;
			string sDayvisit = null;
			for (int i = 1; i <= m_iCiShu; i++)
			{
				tp.ur.QQKongJian(dhTsUser.sQQNum, out sVisitcount, out sDayvisit);
				priXx(tp.iIndex, 2, "【" + dhTsUser.sQQName + "】的空间访问 " + i + " 次");
				if (sVisitcount != null)
				{
					priDx(dhTsUser.iIndex, 3, sVisitcount);
				}
				if (sDayvisit != null)
				{
					priDx(dhTsUser.iIndex, 2, sDayvisit);
				}
			}
		}
	}

	private void priXx(int iIndex, int Column, string s)
	{
		if (!((Control)listView_1).get_InvokeRequired())
		{
			listView_1.get_Items().get_Item(iIndex).get_SubItems()
				.get_Item(Column)
				.set_Text(s);
			return;
		}
		aaxx aaxx = priXx;
		((Control)this).Invoke((Delegate)aaxx, new object[3] { iIndex, Column, s });
	}

	private void priDx(int iIndex, int Column, string s)
	{
		if (!((Control)listView_0).get_InvokeRequired())
		{
			listView_0.get_Items().get_Item(iIndex).get_SubItems()
				.get_Item(Column)
				.set_Text(s);
			return;
		}
		aaxx aaxx = priDx;
		((Control)this).Invoke((Delegate)aaxx, new object[3] { iIndex, Column, s });
	}

	private void priRz(int iIndex, int Column, string s)
	{
		if (!((Control)listView21).get_InvokeRequired())
		{
			listView21.get_Items().get_Item(iIndex).get_SubItems()
				.get_Item(Column)
				.set_Text(s);
			return;
		}
		aaxx aaxx = priRz;
		((Control)this).Invoke((Delegate)aaxx, new object[3] { iIndex, Column, s });
	}

	private void priFx(int iIndex, int Column, string s)
	{
		if (!((Control)listViewAllFriend).get_InvokeRequired())
		{
			listViewAllFriend.get_Items().get_Item(iIndex).get_SubItems()
				.get_Item(Column)
				.set_Text(s);
			return;
		}
		aaxx aaxx = priFx;
		((Control)this).Invoke((Delegate)aaxx, new object[3] { iIndex, Column, s });
	}

	private void priJc(int iIndex, int Column, string s)
	{
		if (!((Control)listViewJc).get_InvokeRequired())
		{
			listViewJc.get_Items().get_Item(iIndex).get_SubItems()
				.get_Item(Column)
				.set_Text(s);
			return;
		}
		aaxx aaxx = priJc;
		((Control)this).Invoke((Delegate)aaxx, new object[3] { iIndex, Column, s });
	}

	private void toolStripMenuItem_28_Click(object sender, EventArgs e)
	{
		string listSelectQQNum = GetListSelectQQNum();
		if (listSelectQQNum != null && listSelectQQNum != string.Empty)
		{
			ProcessStart("http://" + listSelectQQNum + ".qzone.qq.com/");
		}
	}

	private void toolStripMenuItem_29_Click(object sender, EventArgs e)
	{
		string listSelectQQNum = GetListSelectQQNum();
		if (listSelectQQNum != null && listSelectQQNum != string.Empty)
		{
			ProcessStart("http://photo.qq.com/portal/albumMain.shtml?%23uin=59024886#uin=" + listSelectQQNum);
		}
	}

	private void toolStripMenuItem_30_Click(object sender, EventArgs e)
	{
		string listSelectQQNum = GetListSelectQQNum();
		if (listSelectQQNum != null && listSelectQQNum != string.Empty)
		{
			ProcessStart("http://city.qzone.qq.com/html/user/guest.htm#uin=" + listSelectQQNum);
		}
	}

	private void toolStripMenuItem_31_Click(object sender, EventArgs e)
	{
		string listSelectQQNum = GetListSelectQQNum();
		if (listSelectQQNum != null && listSelectQQNum != string.Empty)
		{
			ProcessStart("http://jiaoyou.qq.com/cgi-bin/portal2qq?frienduin=" + listSelectQQNum);
		}
	}

	private void toolStripMenuItem_32_Click(object sender, EventArgs e)
	{
		string listSelectQQNum = GetListSelectQQNum();
		if (listSelectQQNum != null && listSelectQQNum != string.Empty)
		{
			ProcessStart("http://wenwen.soso.com/z/ShowUser.e?sp=S" + listSelectQQNum);
		}
	}

	private void toolStripMenuItem_33_Click(object sender, EventArgs e)
	{
		string listSelectQQNum = GetListSelectQQNum();
		if (listSelectQQNum != null && listSelectQQNum != string.Empty)
		{
			ProcessStart("http://user.qbar.qq.com/" + listSelectQQNum);
		}
	}

	private void toolStripMenuItem_35_Click(object sender, EventArgs e)
	{
		if (listView19.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		string text = listView19.get_SelectedItems().get_Item(0).get_SubItems()
			.get_Item(0)
			.get_Text();
		string text2 = listView19.get_SelectedItems().get_Item(0).get_SubItems()
			.get_Item(1)
			.get_Text();
		for (int i = 0; i < 10; i++)
		{
			try
			{
				Clipboard.SetText(text + " " + text2);
				break;
			}
			catch
			{
			}
		}
	}

	private void toolStripMenuItem_36_Click(object sender, EventArgs e)
	{
		if (listView19.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		string text = listView19.get_SelectedItems().get_Item(0).get_SubItems()
			.get_Item(2)
			.get_Text();
		for (int i = 0; i < 10; i++)
		{
			try
			{
				Clipboard.SetText(text);
				break;
			}
			catch
			{
			}
		}
	}

	private void toolStripMenuItem_34_Click(object sender, EventArgs e)
	{
		if (listView19.get_SelectedItems().get_Count() > 0)
		{
			string text = listView19.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(2)
				.get_Text();
			axWindowsMediaPlayer1.set_URL(text);
		}
	}

	private void listView19_DoubleClick(object sender, EventArgs e)
	{
		if (listView19.get_SelectedItems().get_Count() > 0)
		{
			string text = listView19.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(2)
				.get_Text();
			axWindowsMediaPlayer1.set_URL(text);
		}
	}

	private void listView20_MouseUp(object sender, MouseEventArgs e)
	{
		if (listView20.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		long num = m_curr_qp_index;
		m_curr_qp_index = listView20.get_SelectedItems().get_Item(0).get_Index();
		QQPhotoInfo qQPhotoInfo = m_qplist[m_curr_qp_index];
		string sHttpUrl = qQPhotoInfo.sHttpUrl;
		for (int i = 0; i < listView20.get_Items().get_Count(); i++)
		{
			listView20.get_Items().get_Item(i).set_ForeColor(Color.Black);
		}
		listView20.get_SelectedItems().get_Item(0).set_ForeColor(Color.Blue);
		if (num != m_curr_qp_index)
		{
			Stream photo = m_user_current.GetPhoto(sHttpUrl);
			if (photo != null)
			{
				pictureBox5.set_Image(Image.FromStream(photo));
			}
		}
		string text = listView20.get_SelectedItems().get_Item(0).get_SubItems()
			.get_Item(1)
			.get_Text();
		if (qQPhotoInfo.sPicUrlList.Count < 1 && text == "公开")
		{
			m_qplist[m_curr_qp_index].sPicUrlList = m_user_current.m_qn.ProQueryPicUrl(m_sQueryQQZh, qQPhotoInfo.sGuid);
		}
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void toolStripMenuItem_38_Click(object sender, EventArgs e)
	{
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		if (listView20.get_SelectedItems().get_Count() > 0)
		{
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			m_curr_qp_index = listView20.get_SelectedItems().get_Item(0).get_Index();
			QQPhotoInfo qQPhotoInfo = m_qplist[m_curr_qp_index];
			for (int i = 0; i < listView20.get_Items().get_Count(); i++)
			{
				listView20.get_Items().get_Item(i).set_ForeColor(Color.Black);
			}
			listView20.get_SelectedItems().get_Item(0).set_ForeColor(Color.Blue);
			string text = Application.get_StartupPath() + "\\Photo.html";
			File.Delete(text);
			File.AppendAllText(text, "<pre>");
			for (int j = 0; j < qQPhotoInfo.sPicUrlList.Count; j++)
			{
				File.AppendAllText(text, "<center><img src=\"");
				string contents = qQPhotoInfo.sPicUrlList[j];
				File.AppendAllText(text, contents);
				File.AppendAllText(text, "\"/></center>");
				File.AppendAllText(text, "<center>------------------------------------------------------------------</center>");
			}
			File.AppendAllText(text, "</pre>");
			Photo photo = new Photo();
			photo.strPath = text;
			((Form)photo).ShowDialog();
			((Control)this).set_Cursor(Cursors.get_Default());
		}
	}

	private void toolStripMenuItem_37_Click(object sender, EventArgs e)
	{
		if (listView20.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		m_curr_qp_index = listView20.get_SelectedItems().get_Item(0).get_Index();
		QQPhotoInfo qQPhotoInfo = m_qplist[m_curr_qp_index];
		for (int i = 0; i < listView20.get_Items().get_Count(); i++)
		{
			listView20.get_Items().get_Item(i).set_ForeColor(Color.Black);
		}
		listView20.get_SelectedItems().get_Item(0).set_ForeColor(Color.Blue);
		string text = GetDir();
		if (text != string.Empty)
		{
			char c = text[text.Length - 1];
			if (c != '\\')
			{
				text += "\\";
			}
			text = text + m_sQueryQQZh + "\\";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			text = text + qQPhotoInfo.sName + "\\";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			for (int j = 0; j < qQPhotoInfo.sPicUrlList.Count; j++)
			{
				string sUrl = qQPhotoInfo.sPicUrlList[j];
				Stream photo = m_user_current.GetPhoto(sUrl);
				if (photo != null)
				{
					string text2 = text + j + ".jpg";
					File.Delete(text2);
					SaveFile(text2, photo);
				}
			}
		}
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	public void SaveFile(string strFilePath, Stream st)
	{
		Collection<byte> collection = new Collection<byte>();
		long num;
		while ((num = st.ReadByte()) != -1L)
		{
			collection.Add((byte)num);
		}
		long num2 = collection.Count;
		byte[] array = new byte[num2];
		for (int i = 0; i < num2; i++)
		{
			array[i] = collection[i];
		}
		FileStream fileStream = new FileStream(strFilePath, FileMode.Create);
		fileStream.Write(array, 0, array.Length);
		fileStream.Close();
	}

	public string GetDir()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		MyFolderDialog myFolderDialog = new MyFolderDialog();
		if ((int)myFolderDialog.DisplayDialog() == 1)
		{
			return myFolderDialog.Path.ToString();
		}
		return string.Empty;
	}

	private void toolStripMenuItem_39_Click(object sender, EventArgs e)
	{
		if (listView20.get_SelectedItems().get_Count() > 0)
		{
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			m_curr_qp_index = listView20.get_SelectedItems().get_Item(0).get_Index();
			QQPhotoInfo qQPhotoInfo = m_qplist[m_curr_qp_index];
			for (int i = 0; i < listView20.get_Items().get_Count(); i++)
			{
				listView20.get_Items().get_Item(i).set_ForeColor(Color.Black);
			}
			listView20.get_SelectedItems().get_Item(0).set_ForeColor(Color.Blue);
			ProcessStart("http://photo.qq.com/portal/albumMain.shtml#uin=" + m_sQueryQQZh + "&albumid=" + qQPhotoInfo.sGuid);
			((Control)this).set_Cursor(Cursors.get_Default());
		}
	}

	private void toolStripMenuItem_40_Click(object sender, EventArgs e)
	{
		if (listView21.get_SelectedItems().get_Count() > 0)
		{
			tabControl8.set_SelectedIndex(1);
			int index = listView21.get_SelectedItems().get_Item(0).get_Index();
			QueryNormal queryNormal = new QueryNormal(m_user_current);
			string contents = queryNormal.ProQueryReadRz(m_sQueryRzQQNum, m_rzlist[index].sblogid);
			string text = Application.get_StartupPath() + "\\Qzone.html";
			File.Delete(text);
			File.AppendAllText(text, contents, Encoding.UTF8);
			webBrowserReadQQZone.Navigate(text);
		}
	}

	private void toolStripMenuItem_41_Click(object sender, EventArgs e)
	{
		if (listView21.get_SelectedItems().get_Count() > 0)
		{
			int index = listView21.get_SelectedItems().get_Item(0).get_Index();
			ProcessStart("http://user.qzone.qq.com/" + m_sQueryRzQQNum + "/blog/" + m_rzlist[index].sblogid);
		}
	}

	private void toolStripMenuItem_42_Click(object sender, EventArgs e)
	{
		if (m_zj != null)
		{
			m_zj.Abort();
		}
		foreach (Thread threadZj in m_ThreadZjList)
		{
			threadZj.Abort();
		}
		m_ThreadZjList.Clear();
		if (listView21.get_SelectedItems().get_Count() > 0)
		{
			int index = listView21.get_SelectedItems().get_Item(0).get_Index();
			m_zj = new Thread(ThreadProcStartZjs);
			m_zj.Start(index);
		}
	}

	private void toolStripMenuItem_45_Click(object sender, EventArgs e)
	{
		if (m_zj != null)
		{
			m_zj.Abort();
		}
		foreach (Thread threadZj in m_ThreadZjList)
		{
			threadZj.Abort();
		}
		m_ThreadZjList.Clear();
	}

	private void toolStripMenuItem_43_Click(object sender, EventArgs e)
	{
		if (listView21.get_SelectedItems().get_Count() > 0)
		{
			int index = listView21.get_SelectedItems().get_Item(0).get_Index();
			QueryNormal queryNormal = new QueryNormal(m_user_current);
			string text = queryNormal.ProQueryLiuLanNum(m_sQueryRzQQNum, m_rzlist[index].sblogid);
			listView21.get_Items().get_Item(index).get_SubItems()
				.get_Item(3)
				.set_Text(text);
		}
	}

	private void button_12_Click(object sender, EventArgs e)
	{
		string text = ((Control)textBox17).get_Text();
		if (text != null && text != string.Empty)
		{
			QueryRiZhi(text);
		}
	}

	private void textBox17_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.get_KeyValue() == Convert.ToChar(13))
		{
			string text = ((Control)textBox17).get_Text();
			if (text != null && text != string.Empty)
			{
				QueryRiZhi(text);
			}
		}
	}

	public void QueryRiZhi(string sQQNum)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		if (sQQNum.Length < 4)
		{
			return;
		}
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		((Control)textBox17).set_Text(sQQNum);
		m_sQueryRzQQNum = sQQNum;
		m_iQQZoneIndex = -1;
		if (m_tx != null)
		{
			m_tx.Abort();
		}
		foreach (Thread threadRz in m_ThreadRzList)
		{
			threadRz.Abort();
		}
		m_ThreadRzList.Clear();
		try
		{
			m_rzlist = m_user_current.m_qn.ProQueryRiZhi(sQQNum);
			if (m_rzlist != null)
			{
				listView21.get_Items().Clear();
				for (int i = 0; i < m_rzlist.Count; i++)
				{
					QQRiZhiInfo qQRiZhiInfo = m_rzlist[i];
					if (qQRiZhiInfo != null)
					{
						listView21.set_View((View)1);
						ListViewItem val = new ListViewItem(qQRiZhiInfo.sFenLei);
						val.get_SubItems().Add(qQRiZhiInfo.sTitle);
						val.get_SubItems().Add(qQRiZhiInfo.sPingLun);
						val.get_SubItems().Add(qQRiZhiInfo.sLiuLan);
						val.get_SubItems().Add(qQRiZhiInfo.sFaBiaoTime);
						listView21.get_Items().Add(val);
					}
				}
				((Control)listView21).Update();
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		tabControl1.set_SelectedIndex(5);
		tabControl8.set_SelectedIndex(0);
		m_tx = new Thread(ThreadProcStartRzs);
		m_tx.Start(0);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	public void ThreadProcStartRzs(object date)
	{
		for (int i = 0; i < m_rzlist.Count; i++)
		{
			Thread thread = new Thread(ThreadProcStartRz);
			thread.Start(i);
			m_ThreadRzList.Add(thread);
			Thread.Sleep(100);
		}
		if (m_tx != null)
		{
			m_tx.Abort();
		}
	}

	public void ThreadProcStartRz(object date)
	{
		int num = (int)date;
		QQRiZhiInfo qQRiZhiInfo = m_rzlist[num];
		QueryNormal queryNormal = new QueryNormal(m_user_current);
		string s = queryNormal.ProQueryLiuLanNum(m_sQueryRzQQNum, qQRiZhiInfo.sblogid);
		priRz(num, 3, s);
		if (num < m_rzlist.Count - 1)
		{
			return;
		}
		foreach (Thread threadRz in m_ThreadRzList)
		{
			threadRz.Abort();
		}
		m_ThreadRzList.Clear();
	}

	public void ThreadProcStartZjs(object date)
	{
		int num = (int)date;
		for (int i = 0; i < 10; i++)
		{
			Thread thread = new Thread(ThreadProcStartZj);
			thread.Start(num);
			m_ThreadZjList.Add(thread);
			Thread.Sleep(100);
		}
	}

	public void ThreadProcStartZj(object date)
	{
		int index = (int)date;
		QQRiZhiInfo qQRiZhiInfo = m_rzlist[index];
		QueryNormal queryNormal = new QueryNormal(m_user_current);
		while (true)
		{
			queryNormal.ProQueryZengJiaLiuLan(m_sQueryRzQQNum, qQRiZhiInfo.sblogid);
			Thread.Sleep(100);
		}
	}

	private void button_13_Click(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (m_iQQZoneIndex < 0)
		{
			MessageBox.Show("请在上方日志列表中选择一篇文章进行评论", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		string text = ((Control)textBoxContent).get_Text();
		if (text != null && !(text == string.Empty))
		{
			QueryNormal queryNormal = new QueryNormal(m_user_current);
			queryNormal.ProQQZoneSendContent(m_sQueryRzQQNum, m_rzlist[m_iQQZoneIndex].sblogid, text);
		}
		else
		{
			MessageBox.Show("评论不能为空", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void listView21_MouseUp(object sender, MouseEventArgs e)
	{
		if (listView21.get_SelectedItems().get_Count() > 0)
		{
			for (int i = 0; i < listView21.get_Items().get_Count(); i++)
			{
				listView21.get_Items().get_Item(i).set_ForeColor(Color.Black);
			}
			listView21.get_SelectedItems().get_Item(0).set_ForeColor(Color.Blue);
			m_iQQZoneIndex = listView21.get_SelectedItems().get_Item(0).get_Index();
		}
	}

	private void comboBoxSheng_SelectedIndexChanged(object sender, EventArgs e)
	{
		comboBoxCity.get_Items().Clear();
		int selectedIndex = ((ListControl)comboBoxSheng).get_SelectedIndex();
		long num = m_ctt.GetCityCount(selectedIndex);
		for (int i = 0; i < num; i++)
		{
			CityTypeInfo cityTypeInfoByIndex = m_ctt.GetCityTypeInfoByIndex(selectedIndex, i);
			if (cityTypeInfoByIndex != null)
			{
				comboBoxCity.get_Items().Add((object)cityTypeInfoByIndex.m_cityname);
			}
		}
		((ListControl)comboBoxCity).set_SelectedIndex(0);
	}

	private void button_14_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)button_14).set_Enabled(false);
		((Control)button_15).set_Enabled(true);
		((ListView)listViewCity).get_Items().Clear();
		int selectedIndex = ((ListControl)comboBoxSheng).get_SelectedIndex();
		string code = m_ctt.GetShengTypeInfoByIndex(selectedIndex).m_code;
		int selectedIndex2 = ((ListControl)comboBoxCity).get_SelectedIndex();
		string code2 = m_ctt.GetCityTypeInfoByIndex(selectedIndex, selectedIndex2).m_code;
		string sSex = ((ListControl)comboBoxSex).get_SelectedIndex().ToString();
		string sAge = ((ListControl)comboBoxAge).get_SelectedIndex().ToString();
		string sOnline = ((ListControl)comboBoxOnline).get_SelectedIndex().ToString();
		if (m_city != null)
		{
			m_city.Abort();
		}
		ThreadProcPamaCity threadProcPamaCity = new ThreadProcPamaCity();
		threadProcPamaCity.province = code;
		threadProcPamaCity.city = code2;
		threadProcPamaCity.sSex = sSex;
		threadProcPamaCity.sAge = sAge;
		threadProcPamaCity.sOnline = sOnline;
		m_city = new Thread(ThreadProcStartCity);
		m_city.Start(threadProcPamaCity);
	}

	public void ThreadProcStartCity(object date)
	{
		ThreadProcPamaCity threadProcPamaCity = (ThreadProcPamaCity)date;
		if (threadProcPamaCity == null)
		{
			return;
		}
		int num = 1;
		while (true)
		{
			QueryNormal queryNormal = new QueryNormal(m_user_current);
			Collection<QQCityInfo> collection = queryNormal.ProQueryCity(threadProcPamaCity.province, threadProcPamaCity.city, threadProcPamaCity.sSex, threadProcPamaCity.sAge, num.ToString());
			foreach (QQCityInfo item in collection)
			{
				if (threadProcPamaCity.sOnline == "0")
				{
					priAddXx(item);
				}
				else if (threadProcPamaCity.sOnline == "1" && item.sOnline == "1")
				{
					priAddXx(item);
				}
				else if (threadProcPamaCity.sOnline == "2" && item.sOnline == "0")
				{
					priAddXx(item);
				}
			}
			num++;
		}
	}

	private void button_15_Click(object sender, EventArgs e)
	{
		((Control)button_14).set_Enabled(true);
		((Control)button_15).set_Enabled(false);
		if (m_city != null)
		{
			m_city.Abort();
		}
	}

	private void priAddXx(QQCityInfo qc)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		if (!((Control)listViewCity).get_InvokeRequired())
		{
			((ListView)listViewCity).set_View((View)1);
			ListViewItem val = new ListViewItem(qc.sQQNum);
			val.get_SubItems().Add(qc.sBirthday);
			val.get_SubItems().Add(qc.sSex);
			val.get_SubItems().Add(qc.semotion);
			val.get_SubItems().Add(qc.smWeight);
			val.get_SubItems().Add(qc.smHeight);
			if (qc.sOnline != "1")
			{
				val.set_BackColor(Color.SkyBlue);
			}
			val.set_Tag((object)qc.sID);
			((ListView)listViewCity).get_Items().Add(val);
			((Control)label126).set_Text("搜索数目：" + ((ListView)listViewCity).get_Items().get_Count());
		}
		else
		{
			addxx addxx = priAddXx;
			((Control)this).Invoke((Delegate)addxx, new object[1] { qc });
		}
	}

	private void listViewCity_Click(object sender, EventArgs e)
	{
		if (((ListView)listViewCity).get_SelectedItems().get_Count() > 0)
		{
			string sID = (string)((ListView)listViewCity).get_SelectedItems().get_Item(0).get_Tag();
			Stream cityImage = m_user.GetCityImage(sID);
			if (cityImage != null)
			{
				pictureBoxCity.set_Image(Image.FromStream(cityImage));
			}
		}
	}

	private void button_16_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		((Control)button_16).set_Enabled(false);
		((Control)textBoxShiJian).set_Text(m_user_current.m_hymm.QueryInfo());
		((Control)button_16).set_Enabled(true);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void button85_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listViewMaiDeQi.get_Items().get_Count(); i++)
		{
			listViewMaiDeQi.get_Items().get_Item(i).set_Checked(true);
		}
	}

	private void button86_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listViewMaiDeQi.get_Items().get_Count(); i++)
		{
			listViewMaiDeQi.get_Items().get_Item(i).set_Checked(false);
		}
	}

	private void button87_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listViewJc.get_Items().get_Count(); i++)
		{
			listViewJc.get_Items().get_Item(i).set_Checked(true);
		}
	}

	private void button88_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listViewJc.get_Items().get_Count(); i++)
		{
			listViewJc.get_Items().get_Item(i).set_Checked(false);
		}
	}

	private void button_17_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Invalid comparison between Unknown and I4
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		bool flag = false;
		long num = listViewMaiDeQi.get_Items().get_Count();
		for (int i = 0; i < num; i++)
		{
			if (listViewMaiDeQi.get_Items().get_Item(i).get_Checked())
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			MessageBox.Show("请在下面买得起的好友列表中勾选需要购买的好友", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		DialogResult val = MessageBox.Show("请确定批量购买好友吗？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
		if ((int)val != 6)
		{
			return;
		}
		tabControl5.set_SelectedIndex(1);
		long sMyBuyMoney = m_sMyBuyMoney;
		long sMyCapital = m_sMyCapital;
		long sMyMoney = m_sMyMoney;
		int num2 = m_user_current.m_qqq.GetSlaveCount(m_user_current.m_sQQnum);
		bool flag2 = false;
		bool flag3 = false;
		int num3 = 0;
		while (true)
		{
			if (num3 < num)
			{
				if (listViewMaiDeQi.get_Items().get_Item(num3).get_Checked())
				{
					string text = listViewMaiDeQi.get_Items().get_Item(num3).get_SubItems()
						.get_Item(0)
						.get_Text();
					string text2 = listViewMaiDeQi.get_Items().get_Item(num3).get_SubItems()
						.get_Item(1)
						.get_Text();
					if (flag3)
					{
						int slaveCount = m_user_current.m_qqq.GetSlaveCount(m_user_current.m_sQQnum);
						if (slaveCount < num2)
						{
							break;
						}
						num2 = slaveCount;
					}
					flag3 = true;
					if (num2 >= 9)
					{
						val = MessageBox.Show("大哥，你已经有 9 个以上的奴隶了，你还想买吗？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
						if ((int)val != 6)
						{
							return;
						}
					}
					((Control)this).set_Cursor(Cursors.get_WaitCursor());
					string text3 = m_user_current.m_hymm.ProBuyFriend(text, m_sSlaveChuoHao);
					if (text3 != null)
					{
						((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [购买奴隶失败] [") + text2 + "]" + text3 + "\r\n");
					}
					else
					{
						((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [购买奴隶成功] [") + text2 + "]\r\n");
						flag2 = true;
					}
					((Control)this).set_Cursor(Cursors.get_Default());
				}
				num3++;
				continue;
			}
			if (flag2)
			{
				RefresFriendNormal();
				MaiDeQiFriend(bXiangXi: false);
			}
			ShowMyhaoyuMaiInfo(sMyBuyMoney, sMyCapital, sMyMoney);
			return;
		}
		MessageBox.Show("获取奴隶数失败，为保证不买到第十个奴隶，停止执行", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void button_20_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		string text = ((Control)textBox18).get_Text().Trim();
		if (text.Length >= 4)
		{
			AddJcgmFriend(text, null, null);
		}
	}

	private void button_25_Click(object sender, EventArgs e)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		long num = listViewMaiDeQi.get_Items().get_Count();
		for (int i = 0; i < num; i++)
		{
			if (listViewMaiDeQi.get_Items().get_Item(i).get_Checked())
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			MessageBox.Show("请在下面买得起的好友列表中勾选需要添加的好友", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		((Control)button_25).set_Enabled(false);
		for (int j = 0; j < num; j++)
		{
			if (listViewMaiDeQi.get_Items().get_Item(j).get_Checked())
			{
				string text = listViewMaiDeQi.get_Items().get_Item(j).get_SubItems()
					.get_Item(0)
					.get_Text();
				AddJcgmFriend(text, null, null);
			}
		}
		((Control)this).set_Cursor(Cursors.get_Default());
		((Control)button_25).set_Enabled(true);
	}

	public void AddJcgmFriend(string sQQNum, string sNick, string sPrice)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		int num = 0;
		while (true)
		{
			if (num < listViewJc.get_Items().get_Count())
			{
				string text = listViewJc.get_Items().get_Item(num).get_SubItems()
					.get_Item(0)
					.get_Text();
				if (!(sQQNum == text))
				{
					num++;
					continue;
				}
				break;
			}
			string text2 = listViewJc.get_Items().get_Count().ToString();
			listViewJc.get_Items().Add(text2, sQQNum, 0);
			if (sNick == null || sPrice == null)
			{
				sNick = "";
				sPrice = "";
				m_user_current.m_qqq.QueryQQFriendPrice(sQQNum, out sNick, out sPrice);
			}
			listViewJc.get_Items().get_Item(text2).get_SubItems()
				.Add(sNick);
			listViewJc.get_Items().get_Item(text2).get_SubItems()
				.Add(sPrice);
			DhUserInfo dhUserInfo = new DhUserInfo();
			dhUserInfo.sQQNum = sQQNum;
			dhUserInfo.sQQName = sNick;
			m_BuyUserList.Add(dhUserInfo);
			fp.AddDhUser(m_sFileBuyUserPath + m_user_current.m_sQQnum.ToString() + ".ini", m_BuyUserList, sQQNum, sNick);
			break;
		}
	}

	private void button_22_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		string text = m_user_current.m_qqq.QueryQQSlave(m_user_current.m_sQQnum);
		if (text != null)
		{
			((Control)this).set_Cursor(Cursors.get_Default());
			MessageBox.Show(text, "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		listViewSlave.get_Items().Clear();
		long count = m_user_current.m_qqq.GetCount();
		for (int i = 0; i < count; i++)
		{
			SlaveInfo slaveInfo = m_user_current.m_qqq.GetSlaveInfo(i);
			if (slaveInfo != null)
			{
				AddJcgmFriend(slaveInfo.sQQNum, slaveInfo.sQQName, slaveInfo.sBuyMoney);
			}
		}
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void button_21_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		bool flag = false;
		long num = listViewJc.get_Items().get_Count();
		for (int i = 0; i < num; i++)
		{
			if (listViewJc.get_Items().get_Item(i).get_Checked())
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			MessageBox.Show("请在左边列表中勾选需要删除的项", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		DialogResult val = MessageBox.Show("你确定要在列表中删除该好友吗？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
		if ((int)val != 6)
		{
			return;
		}
		bool flag2;
		do
		{
			flag2 = true;
			num = listViewJc.get_Items().get_Count();
			for (int j = 0; j < num; j++)
			{
				if (!listViewJc.get_Items().get_Item(j).get_Checked())
				{
					continue;
				}
				string text = listViewJc.get_Items().get_Item(j).get_SubItems()
					.get_Item(0)
					.get_Text();
				listViewJc.get_Items().RemoveAt(j);
				flag2 = false;
				foreach (DhUserInfo buyUser in m_BuyUserList)
				{
					if (buyUser.sQQNum == text)
					{
						m_BuyUserList.Remove(buyUser);
						break;
					}
				}
				break;
			}
		}
		while (!flag2);
		fp.WriteDhUser(m_sFileBuyUserPath + m_user_current.m_sQQnum.ToString() + ".ini", m_BuyUserList);
	}

	private void button_18_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Invalid comparison between Unknown and I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		bool flag = false;
		long num = listViewJc.get_Items().get_Count();
		for (int i = 0; i < num; i++)
		{
			if (listViewJc.get_Items().get_Item(i).get_Checked())
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			MessageBox.Show("请在左边经常购买的好友列表中勾选需要购买的好友", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		DialogResult val = MessageBox.Show("请确定批量购买好友吗？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
		if ((int)val != 6)
		{
			return;
		}
		tabControl5.set_SelectedIndex(1);
		long sMyBuyMoney = m_sMyBuyMoney;
		long sMyCapital = m_sMyCapital;
		long sMyMoney = m_sMyMoney;
		int num2 = m_user_current.m_qqq.GetSlaveCount(m_user_current.m_sQQnum);
		bool flag2 = false;
		bool flag3 = false;
		int num3 = 0;
		while (true)
		{
			if (num3 < num)
			{
				if (listViewJc.get_Items().get_Item(num3).get_Checked())
				{
					string text = listViewJc.get_Items().get_Item(num3).get_SubItems()
						.get_Item(0)
						.get_Text();
					string text2 = listViewJc.get_Items().get_Item(num3).get_SubItems()
						.get_Item(1)
						.get_Text();
					if (flag3)
					{
						int slaveCount = m_user_current.m_qqq.GetSlaveCount(m_user_current.m_sQQnum);
						if (slaveCount < num2)
						{
							break;
						}
						num2 = slaveCount;
					}
					flag3 = true;
					if (num2 >= 9)
					{
						val = MessageBox.Show("大哥，你已经有 9 个以上的奴隶了，你还想买吗？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
						if ((int)val != 6)
						{
							return;
						}
					}
					((Control)this).set_Cursor(Cursors.get_WaitCursor());
					string text3 = m_user_current.m_hymm.ProBuyFriend(text, m_sSlaveChuoHao);
					if (text3 != null)
					{
						((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [购买奴隶失败] [") + text2 + "]" + text3 + "\r\n");
					}
					else
					{
						((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] [购买奴隶成功] [") + text2 + "]\r\n");
						num2++;
						flag2 = true;
					}
					((Control)this).set_Cursor(Cursors.get_Default());
				}
				num3++;
				continue;
			}
			if (flag2)
			{
				RefresFriendNormal();
				MaiDeQiFriend(bXiangXi: false);
			}
			ShowMyhaoyuMaiInfo(sMyBuyMoney, sMyCapital, sMyMoney);
			return;
		}
		MessageBox.Show("获取奴隶数失败，为保证不买到第十个奴隶，停止执行", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void button_24_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		((Control)button_24).set_Enabled(false);
		if (m_jc != null)
		{
			m_jc.Abort();
		}
		m_sJcQQNumList.Clear();
		listViewJc.get_Items().Clear();
		m_userJc = m_user_current;
		m_BuyUserList = fp.ReadDhUserList(m_sFileBuyUserPath + m_user_current.m_sQQnum.ToString() + ".ini");
		foreach (DhUserInfo buyUser in m_BuyUserList)
		{
			listViewJc.set_View((View)1);
			ListViewItem val = new ListViewItem(buyUser.sQQNum);
			val.get_SubItems().Add("");
			val.get_SubItems().Add("");
			listViewJc.get_Items().Add(val);
			m_sJcQQNumList.Add(buyUser.sQQNum);
		}
		((Control)listViewJc).Update();
		m_jc = new Thread(ThreadProcStartJc);
		m_jc.Start(0);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Control)button_24).set_Enabled(true);
	}

	public void ThreadProcStartJc(object date)
	{
		for (int i = 0; i < m_sJcQQNumList.Count; i++)
		{
			string sQueryQQNum = m_sJcQQNumList[i];
			string sNick = "";
			string sPrice = "";
			if (m_user_current != null)
			{
				m_userJc.m_qqq.QueryQQFriendPrice(sQueryQQNum, out sNick, out sPrice);
			}
			priJc(i, 1, sNick);
			priJc(i, 2, sPrice);
		}
		if (m_jc != null)
		{
			m_jc.Abort();
		}
	}

	private void button_19_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		bool flag = false;
		long num = listViewJc.get_Items().get_Count();
		for (int i = 0; i < num; i++)
		{
			if (listViewJc.get_Items().get_Item(i).get_Checked())
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			MessageBox.Show("请在左边经常购买的好友列表中勾选需要抢购的好友", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		string text = ((Control)textBox19).get_Text();
		int num2 = StringChar.SToInt(text);
		if (num2 >= 5 && num2 <= 3600)
		{
			timersTimerQiangGou.Interval = 1000 * num2;
			tabControl5.set_SelectedIndex(1);
			((Control)button_19).set_Enabled(false);
			((Control)button_23).set_Enabled(true);
			m_strUserQiangGou = m_user_current;
			m_SlaveInfoListQC.Clear();
			for (int j = 0; j < listViewJc.get_Items().get_Count(); j++)
			{
				if (listViewJc.get_Items().get_Item(j).get_Checked())
				{
					SlaveInfo slaveInfo = new SlaveInfo();
					slaveInfo.sQQNum = listViewJc.get_Items().get_Item(j).get_SubItems()
						.get_Item(0)
						.get_Text();
					slaveInfo.sQQName = listViewJc.get_Items().get_Item(j).get_SubItems()
						.get_Item(1)
						.get_Text();
					m_SlaveInfoListQC.Add(slaveInfo);
				}
			}
			timersTimerQiangGou.Start();
		}
		else
		{
			MessageBox.Show("抢购时间间隔不得小于5秒,不得大于3600秒", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void button_23_Click(object sender, EventArgs e)
	{
		timersTimerQiangGou.Stop();
		m_SlaveInfoListQC.Clear();
		((Control)button_19).set_Enabled(true);
		((Control)button_23).set_Enabled(false);
	}

	private void timersTimerQiangGou_Elapsed(object sender, ElapsedEventArgs e)
	{
		timersTimerQiangGou.Stop();
		if (m_strUserQiangGou != null)
		{
			foreach (SlaveInfo item in m_SlaveInfoListQC)
			{
				if (item != null)
				{
					int slaveCount = m_strUserQiangGou.m_qqq.GetSlaveCount(m_strUserQiangGou.m_sQQnum);
					if (slaveCount == 0)
					{
						priSlave(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] 账号[" + m_strUserQiangGou.m_sQQnick + "]获取奴隶数失败，为保证不买到第十个奴隶，停止购买\r\n"));
						break;
					}
					if (slaveCount >= 9)
					{
						priSlave(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] 账号[" + m_strUserQiangGou.m_sQQnick + "]奴隶数超过9个，停止购买\r\n"));
						break;
					}
					string text = m_strUserQiangGou.m_hymm.ProBuyFriend(item.sQQNum, m_sSlaveChuoHao);
					if (text != null)
					{
						priSlave(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] 账号[" + m_strUserQiangGou.m_sQQnick + "][抢购奴隶失败] [") + item.sQQName + "]" + text + "\r\n");
					}
					else
					{
						priSlave(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] 账号[" + m_strUserQiangGou.m_sQQnick + "][抢购奴隶成功] [") + item.sQQName + "]\r\n");
					}
				}
			}
		}
		timersTimerQiangGou.Start();
	}

	private void button_27_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		listViewPK0.get_Items().Clear();
		listViewPK1.get_Items().Clear();
		listViewPK2.get_Items().Clear();
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		((Control)button_27).set_Enabled(false);
		string text = m_user_current.m_qqq.QueryQQMyPk(m_user_current.m_sQQnum);
		if (text != null)
		{
			((Control)this).set_Cursor(Cursors.get_Default());
			((Control)button_27).set_Enabled(true);
			MessageBox.Show(text, "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		listViewPK1.get_Items().Clear();
		long count = m_user_current.m_qqq.GetCount();
		for (int i = 0; i < count; i++)
		{
			SlaveInfo slaveInfo = m_user_current.m_qqq.GetSlaveInfo(i);
			if (slaveInfo != null)
			{
				ListViewItem val = new ListViewItem(slaveInfo.sQQNum);
				val.get_SubItems().Add(slaveInfo.sQQName);
				val.get_SubItems().Add(slaveInfo.sBuyMoney);
				val.get_SubItems().Add(slaveInfo.sWin);
				val.get_SubItems().Add(slaveInfo.sFail);
				val.get_SubItems().Add(slaveInfo.sExp);
				listViewPK1.get_Items().Add(val);
			}
		}
		((Control)listViewPK1).Update();
		text = m_user_current.m_qqq.QueryQQPkFriend(m_user_current.m_sQQnum);
		if (text != null)
		{
			((Control)this).set_Cursor(Cursors.get_Default());
			((Control)button_27).set_Enabled(true);
			MessageBox.Show(text, "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		listViewPK0.get_Items().Clear();
		count = m_user_current.m_qqq.GetCount();
		for (int j = 0; j < count; j++)
		{
			SlaveInfo slaveInfo2 = m_user_current.m_qqq.GetSlaveInfo(j);
			if (slaveInfo2 != null)
			{
				ListViewItem val2 = new ListViewItem(slaveInfo2.sQQNum);
				val2.get_SubItems().Add(slaveInfo2.sQQName);
				val2.get_SubItems().Add(slaveInfo2.sHelot);
				listViewPK0.get_Items().Add(val2);
			}
		}
		((Control)listViewPK0).Update();
		if (m_sPKQQNum != null && m_sPKQQNum.Length > 3)
		{
			listViewPK2.get_Items().Clear();
			text = m_user_current.m_qqq.QueryQQMyPk(m_sPKQQNum);
			if (text != null)
			{
				((Control)this).set_Cursor(Cursors.get_Default());
				((Control)button_27).set_Enabled(true);
				MessageBox.Show(text, "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			count = m_user_current.m_qqq.GetCount();
			for (int k = 0; k < count; k++)
			{
				SlaveInfo slaveInfo3 = m_user_current.m_qqq.GetSlaveInfo(k);
				if (slaveInfo3 != null)
				{
					ListViewItem val3 = new ListViewItem(slaveInfo3.sQQNum);
					val3.get_SubItems().Add(slaveInfo3.sQQName);
					val3.get_SubItems().Add(slaveInfo3.sBuyMoney);
					val3.get_SubItems().Add(slaveInfo3.sWin);
					val3.get_SubItems().Add(slaveInfo3.sFail);
					val3.get_SubItems().Add(slaveInfo3.sExp);
					listViewPK2.get_Items().Add(val3);
				}
			}
			((Control)listViewPK2).Update();
		}
		((Control)this).set_Cursor(Cursors.get_Default());
		((Control)button_27).set_Enabled(true);
	}

	private void listViewPK0_MouseUp(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		if ((int)e.get_Button() != 1048576)
		{
			iListFocus = 26;
		}
		else
		{
			if (listViewPK0.get_SelectedItems().get_Count() <= 0)
			{
				return;
			}
			string text = listViewPK0.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(0)
				.get_Text();
			if (text == m_sPKQQNum)
			{
				return;
			}
			m_sPKQQNum = text;
			listViewPK2.get_Items().Clear();
			for (int i = 0; i < listViewPK0.get_Items().get_Count(); i++)
			{
				listViewPK0.get_Items().get_Item(i).set_ForeColor(Color.Black);
			}
			listViewPK0.get_SelectedItems().get_Item(0).set_ForeColor(Color.Blue);
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			((Control)button_27).set_Enabled(false);
			string text2 = m_user_current.m_qqq.QueryQQMyPk(text);
			if (text2 != null)
			{
				((Control)this).set_Cursor(Cursors.get_Default());
				((Control)button_27).set_Enabled(true);
				MessageBox.Show(text2, "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			long count = m_user_current.m_qqq.GetCount();
			for (int j = 0; j < count; j++)
			{
				SlaveInfo slaveInfo = m_user_current.m_qqq.GetSlaveInfo(j);
				if (slaveInfo != null)
				{
					ListViewItem val = new ListViewItem(slaveInfo.sQQNum);
					val.get_SubItems().Add(slaveInfo.sQQName);
					val.get_SubItems().Add(slaveInfo.sBuyMoney);
					val.get_SubItems().Add(slaveInfo.sWin);
					val.get_SubItems().Add(slaveInfo.sFail);
					val.get_SubItems().Add(slaveInfo.sExp);
					listViewPK2.get_Items().Add(val);
				}
			}
			((Control)listViewPK2).Update();
			((Control)this).set_Cursor(Cursors.get_Default());
			((Control)button_27).set_Enabled(true);
		}
	}

	private void tabControl9_Selected(object sender, TabControlEventArgs e)
	{
		if (tabControl9.get_SelectedIndex() == 2 && m_bLoginFriend && listViewPK1.get_Items().get_Count() < 1)
		{
			button_27_Click(sender, (EventArgs)(object)e);
		}
	}

	private void button_26_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		if (listViewPK2.get_Items().get_Count() < 1)
		{
			MessageBox.Show("请左键选择想PK他的奴隶的好友", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		bool flag = false;
		long num = listViewPK1.get_Items().get_Count();
		for (int i = 0; i < num; i++)
		{
			if (listViewPK1.get_Items().get_Item(i).get_Checked())
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			MessageBox.Show("请在我的奴隶列表中勾选派出PK的奴隶", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		flag = false;
		long num2 = listViewPK2.get_Items().get_Count();
		for (int j = 0; j < num2; j++)
		{
			if (listViewPK2.get_Items().get_Item(j).get_Checked())
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			MessageBox.Show("请在对方的奴隶列表中勾选需要被PK的奴隶", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		tabControl5.set_SelectedIndex(1);
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		((Control)button_26).set_Enabled(false);
		for (int k = 0; k < num; k++)
		{
			if (!listViewPK1.get_Items().get_Item(k).get_Checked())
			{
				continue;
			}
			string text = listViewPK1.get_Items().get_Item(k).get_SubItems()
				.get_Item(0)
				.get_Text();
			string text2 = listViewPK1.get_Items().get_Item(k).get_SubItems()
				.get_Item(1)
				.get_Text();
			for (int l = 0; l < num2; l++)
			{
				if (listViewPK2.get_Items().get_Item(l).get_Checked())
				{
					string text3 = listViewPK2.get_Items().get_Item(l).get_SubItems()
						.get_Item(0)
						.get_Text();
					string text4 = listViewPK2.get_Items().get_Item(l).get_SubItems()
						.get_Item(1)
						.get_Text();
					string text5 = m_user_current.m_qqq.ProPK(m_user_current.m_sQQnum, text, text3, m_sPKQQNum);
					((TextBoxBase)textBoxNuLiShiJian).AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + "[" + text2 + "] PK [" + text4 + "]：" + text5 + "\r\n");
					Thread.Sleep(100);
					if (text5.IndexOf("PK胜利") != -1 || text5.IndexOf("PK失败") != -1 || text5.IndexOf("已经PK过") != -1)
					{
						break;
					}
				}
			}
		}
		((Control)this).set_Cursor(Cursors.get_Default());
		((Control)button_26).set_Enabled(true);
	}

	private void listViewCity_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		if (!((Control)button_14).get_Enabled())
		{
			return;
		}
		if (e.get_Column() == lvwColumnSorterCityList.SortColumn)
		{
			if ((int)lvwColumnSorterCityList.Order == 1)
			{
				lvwColumnSorterCityList.Order = (SortOrder)2;
			}
			else
			{
				lvwColumnSorterCityList.Order = (SortOrder)1;
			}
		}
		else
		{
			lvwColumnSorterCityList.SortColumn = e.get_Column();
			lvwColumnSorterCityList.Order = (SortOrder)1;
		}
		((ListView)listViewCity).Sort();
	}

	private void button82_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listViewPK1.get_Items().get_Count(); i++)
		{
			listViewPK1.get_Items().get_Item(i).set_Checked(true);
		}
	}

	private void button83_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listViewPK1.get_Items().get_Count(); i++)
		{
			listViewPK1.get_Items().get_Item(i).set_Checked(false);
		}
	}

	private void button84_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listViewPK2.get_Items().get_Count(); i++)
		{
			listViewPK2.get_Items().get_Item(i).set_Checked(true);
		}
	}

	private void button89_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listViewPK2.get_Items().get_Count(); i++)
		{
			listViewPK2.get_Items().get_Item(i).set_Checked(false);
		}
	}

	private void toolStripMenuItem_48_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		string listSelectQQNum = GetListSelectQQNum();
		if (listSelectQQNum != null && listSelectQQNum != string.Empty)
		{
			AddFriend addFriend = new AddFriend();
			addFriend.SetUser(m_user_current, listSelectQQNum);
			((Form)addFriend).ShowDialog();
		}
	}

	private void toolStripMenuItem_49_Click(object sender, EventArgs e)
	{
		string listSelectQQNum = GetListSelectQQNum();
		if (listSelectQQNum != null && listSelectQQNum != string.Empty)
		{
			ProcessStart("http://wpa.qq.com//msgrd?V=1&Uin=" + listSelectQQNum);
		}
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		switch (((ListControl)comboBox_0).get_SelectedIndex())
		{
		case 1:
		{
			for (int num7 = 0; num7 < listCars.get_Items().get_Count(); num7++)
			{
				listCars.get_Items().get_Item(num7).set_Checked(true);
			}
			break;
		}
		case 2:
		{
			for (int l = 0; l < listCars.get_Items().get_Count(); l++)
			{
				listCars.get_Items().get_Item(l).set_Checked(false);
			}
			break;
		}
		case 3:
		{
			for (int n = 0; n < listCars.get_Items().get_Count(); n++)
			{
				string text2 = listCars.get_Items().get_Item(n).get_SubItems()
					.get_Item(0)
					.get_Text();
				if (text2.Length < 4)
				{
					listCars.get_Items().get_Item(n).set_Checked(true);
				}
				else
				{
					listCars.get_Items().get_Item(n).set_Checked(false);
				}
			}
			break;
		}
		case 4:
		{
			for (int j = 0; j < listCars.get_Items().get_Count(); j++)
			{
				string text = listCars.get_Items().get_Item(j).get_SubItems()
					.get_Item(0)
					.get_Text();
				if (text.Length >= 4)
				{
					listCars.get_Items().get_Item(j).set_Checked(true);
				}
				else
				{
					listCars.get_Items().get_Item(j).set_Checked(false);
				}
			}
			break;
		}
		case 5:
		{
			int num4 = 0;
			for (int num5 = 0; num5 < listCars.get_Items().get_Count(); num5++)
			{
				int num6 = (int)listCars.get_Items().get_Item(num5).get_SubItems()
					.get_Item(7)
					.get_Tag();
				if (num6 >= 15 && num4 < 3)
				{
					listCars.get_Items().get_Item(num5).set_Checked(true);
					num4++;
				}
				else
				{
					listCars.get_Items().get_Item(num5).set_Checked(false);
				}
			}
			break;
		}
		case 6:
		{
			for (int m = 0; m < listCars.get_Items().get_Count(); m++)
			{
				int num3 = (int)listCars.get_Items().get_Item(m).get_SubItems()
					.get_Item(7)
					.get_Tag();
				if (num3 >= 15)
				{
					listCars.get_Items().get_Item(m).set_Checked(true);
				}
				else
				{
					listCars.get_Items().get_Item(m).set_Checked(false);
				}
			}
			break;
		}
		case 7:
		{
			for (int k = 0; k < listCars.get_Items().get_Count(); k++)
			{
				int num2 = (int)listCars.get_Items().get_Item(k).get_SubItems()
					.get_Item(7)
					.get_Tag();
				if (num2 >= 480)
				{
					listCars.get_Items().get_Item(k).set_Checked(true);
				}
				else
				{
					listCars.get_Items().get_Item(k).set_Checked(false);
				}
			}
			break;
		}
		case 8:
		{
			for (int i = 0; i < listCars.get_Items().get_Count(); i++)
			{
				int num = (int)listCars.get_Items().get_Item(i).get_SubItems()
					.get_Item(7)
					.get_Tag();
				if (num >= 720)
				{
					listCars.get_Items().get_Item(i).set_Checked(true);
				}
				else
				{
					listCars.get_Items().get_Item(i).set_Checked(false);
				}
			}
			break;
		}
		}
	}

	private void button_28_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Invalid comparison between Unknown and I4
		try
		{
			if (m_user_current == null)
			{
				MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			DialogResult val = MessageBox.Show("这样收入将全部归对方，你确定要进行被贴吗？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
			if ((int)val != 6)
			{
				return;
			}
			((Control)button_28).set_Enabled(false);
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			bool flag = false;
			string text = null;
			string text2 = null;
			string text3 = null;
			long num = listCars.get_Items().get_Count();
			for (int i = 0; i < num; i++)
			{
				if (!listCars.get_Items().get_Item(i).get_Checked())
				{
					continue;
				}
				flag = true;
				text = listCars.get_Items().get_Item(i).get_SubItems()
					.get_Item(0)
					.get_Text()
					.Trim();
				text2 = listCars.get_Items().get_Item(i).get_SubItems()
					.get_Item(2)
					.get_Text()
					.Trim();
				text3 = (string)listCars.get_Items().get_Item(i).get_Tag();
				if (text == null || text == string.Empty)
				{
					continue;
				}
				User userByQQNum = GetUserByQQNum(text);
				if (userByQQNum == null && m_bGoBack)
				{
					val = MessageBox.Show("停车处号码为[" + text + "]的号码没有登陆,将不能进行贴条，是否继续?", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
					if ((int)val == 7)
					{
						((Control)button_28).set_Enabled(true);
						((Control)this).set_Cursor(Cursors.get_Default());
						return;
					}
				}
				string text4 = userByQQNum.m_spc.ProStopCars(m_user_current.m_sQQnum, text2, text3, m_strTiTiaoLiuYan);
				if (text4 == null)
				{
					continue;
				}
				int num2 = 0;
				while (true)
				{
					if (m_iJuBaoTime > 0)
					{
						Thread.Sleep(m_iJuBaoTime);
					}
					text4 = userByQQNum.m_spc.ProStopCars(m_user_current.m_sQQnum, text2, text3, m_strTiTiaoLiuYan);
					if (text4 == null || num2 > iReCount)
					{
						break;
					}
					num2++;
				}
			}
			if (flag)
			{
				RefresCars();
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		((Control)button_28).set_Enabled(true);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void button92_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listView_2.get_Items().get_Count(); i++)
		{
			listView_2.get_Items().get_Item(i).set_Checked(true);
		}
	}

	private void button93_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listView_2.get_Items().get_Count(); i++)
		{
			listView_2.get_Items().get_Item(i).set_Checked(false);
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		if (m_sJuBaoQQNum.Length > 1)
		{
			string text = ((Control)textBox20).get_Text();
			m_iJuBaoTime = StringChar.SToInt(text);
			if (m_iJuBaoTime < 1000)
			{
				m_iJuBaoTime = 1000;
			}
			fp.WriteIniData("config", "JuBaoTime", m_iJuBaoTime.ToString(), m_strConfigPath);
			foreach (JbUserInfo jbUser in m_JbUserList)
			{
				if (jbUser.sQQNum == m_sJuBaoQQNum)
				{
					jbUser.sCars = ((Control)textBox22).get_Text();
					fp.WriteJbUser(m_sFileJbUserPath + m_user_current.m_sQQnum.ToString() + ".ini", m_JbUserList);
					break;
				}
			}
		}
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		((Control)button1).set_Enabled(false);
		m_JbUserList.Clear();
		listView_2.get_Items().Clear();
		m_JbUserList = fp.ReadJbUserList(m_sFileJbUserPath + m_user_current.m_sQQnum.ToString() + ".ini");
		foreach (JbUserInfo jbUser2 in m_JbUserList)
		{
			listViewJc.set_View((View)1);
			ListViewItem val = new ListViewItem(jbUser2.sQQNum);
			val.get_SubItems().Add(jbUser2.sQQName);
			val.get_SubItems().Add(jbUser2.sCars);
			listView_2.get_Items().Add(val);
		}
		((Control)listView_2).Update();
		((Control)this).set_Cursor(Cursors.get_Default());
		((Control)button1).set_Enabled(true);
	}

	private void button_30_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		string qQNum = StringChar.GetQQNum(((Control)comboExcessQQ4).get_Text());
		string text = ((Control)textBox22).get_Text().Trim();
		if (qQNum.Length >= 4 && text.Length >= 1)
		{
			int num = 0;
			while (true)
			{
				if (num < listView_2.get_Items().get_Count())
				{
					string text2 = listView_2.get_Items().get_Item(num).get_SubItems()
						.get_Item(0)
						.get_Text();
					if (!(qQNum == text2))
					{
						num++;
						continue;
					}
					break;
				}
				m_sJuBaoQQNum = qQNum;
				string qQNick = m_user_current.m_qp.GetQQNick(qQNum);
				string text3 = listView_2.get_Items().get_Count().ToString();
				listView_2.get_Items().Add(text3, qQNum, 0);
				listView_2.get_Items().get_Item(text3).get_SubItems()
					.Add(qQNick);
				listView_2.get_Items().get_Item(text3).get_SubItems()
					.Add(text);
				for (int i = 0; i < listView_2.get_Items().get_Count(); i++)
				{
					listView_2.get_Items().get_Item(i).set_ForeColor(Color.Black);
				}
				listView_2.get_Items().get_Item(listView_2.get_Items().get_Count() - 1).set_ForeColor(Color.Blue);
				JbUserInfo jbUserInfo = new JbUserInfo();
				jbUserInfo.sQQNum = qQNum;
				jbUserInfo.sQQName = qQNick;
				jbUserInfo.sCars = text;
				m_JbUserList.Add(jbUserInfo);
				fp.AddJbUser(m_sFileJbUserPath + m_user_current.m_sQQnum.ToString() + ".ini", m_JbUserList, qQNum, qQNick, text);
				break;
			}
		}
		else
		{
			MessageBox.Show("请正确配置被举报信息", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void button_29_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		bool flag = false;
		long num = listView_2.get_Items().get_Count();
		for (int i = 0; i < num; i++)
		{
			if (listView_2.get_Items().get_Item(i).get_Checked())
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			MessageBox.Show("请在左边列表中勾选需要删除的项", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		DialogResult val = MessageBox.Show("你确定要在列表中删除该好友吗？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
		if ((int)val != 6)
		{
			return;
		}
		bool flag2;
		do
		{
			flag2 = true;
			num = listView_2.get_Items().get_Count();
			for (int j = 0; j < num; j++)
			{
				if (!listView_2.get_Items().get_Item(j).get_Checked())
				{
					continue;
				}
				string text = listView_2.get_Items().get_Item(j).get_SubItems()
					.get_Item(0)
					.get_Text();
				listView_2.get_Items().RemoveAt(j);
				flag2 = false;
				foreach (JbUserInfo jbUser in m_JbUserList)
				{
					if (jbUser.sQQNum == text)
					{
						m_JbUserList.Remove(jbUser);
						if (m_sJuBaoQQNum == text)
						{
							m_sJuBaoQQNum = "";
						}
						break;
					}
				}
				break;
			}
		}
		while (!flag2);
		fp.WriteJbUser(m_sFileJbUserPath + m_user_current.m_sQQnum.ToString() + ".ini", m_JbUserList);
	}

	private void button_33_Click(object sender, EventArgs e)
	{
		tabControl3.set_SelectedIndex(1);
		tabControl10.set_SelectedIndex(1);
	}

	private void checkBox18_CheckedChanged(object sender, EventArgs e)
	{
		m_bJb = checkBox18.get_Checked();
		fp.WriteIniData("config", "JuBao", m_bJb.ToString(), m_strConfigPath);
	}

	private void listView_2_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() != 1048576 || m_sJuBaoQQNum.Length <= 1 || listView_2.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		foreach (JbUserInfo jbUser in m_JbUserList)
		{
			if (!(jbUser.sQQNum == m_sJuBaoQQNum))
			{
				continue;
			}
			jbUser.sCars = ((Control)textBox22).get_Text();
			for (int i = 0; i < listView_2.get_Items().get_Count(); i++)
			{
				string text = listView_2.get_Items().get_Item(i).get_SubItems()
					.get_Item(0)
					.get_Text();
				if (text == m_sJuBaoQQNum)
				{
					listView_2.get_Items().get_Item(i).get_SubItems()
						.get_Item(2)
						.set_Text(((Control)textBox22).get_Text());
				}
			}
			string text2 = ((Control)textBox20).get_Text();
			m_iJuBaoTime = StringChar.SToInt(text2);
			if (m_iJuBaoTime < 1000)
			{
				m_iJuBaoTime = 1000;
			}
			fp.WriteIniData("config", "JuBaoTime", m_iJuBaoTime.ToString(), m_strConfigPath);
			fp.WriteJbUser(m_sFileJbUserPath + m_user_current.m_sQQnum.ToString() + ".ini", m_JbUserList);
			break;
		}
	}

	private void listView_2_MouseUp(object sender, MouseEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		iListFocus = 29;
		if ((int)e.get_Button() != 1048576 || listView_2.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		string text = listView_2.get_SelectedItems().get_Item(0).get_SubItems()
			.get_Item(0)
			.get_Text();
		listView_2.get_SelectedItems().get_Item(0).get_SubItems()
			.get_Item(1)
			.get_Text();
		m_JuBaoUseriIndex = listView_2.get_SelectedItems().get_Item(0).get_Index();
		if (m_sJuBaoQQNum == text)
		{
			return;
		}
		m_sJuBaoQQNum = text;
		for (int i = 0; i < listView_2.get_Items().get_Count(); i++)
		{
			listView_2.get_Items().get_Item(i).set_ForeColor(Color.Black);
		}
		listView_2.get_SelectedItems().get_Item(0).set_ForeColor(Color.Blue);
		foreach (JbUserInfo jbUser in m_JbUserList)
		{
			if (jbUser.sQQNum == text)
			{
				((Control)textBox22).set_Text(jbUser.sCars);
				break;
			}
		}
	}

	private void button_32_Click(object sender, EventArgs e)
	{
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		if (m_sJuBaoQQNum.Length > 1)
		{
			foreach (JbUserInfo jbUser in m_JbUserList)
			{
				if (jbUser.sQQNum == m_sJuBaoQQNum)
				{
					string text = ((Control)textBox20).get_Text();
					m_iJuBaoTime = StringChar.SToInt(text);
					if (m_iJuBaoTime < 1000)
					{
						m_iJuBaoTime = 1000;
					}
					fp.WriteIniData("config", "JuBaoTime", m_iJuBaoTime.ToString(), m_strConfigPath);
					jbUser.sCars = ((Control)textBox22).get_Text();
					fp.WriteJbUser(m_sFileJbUserPath + m_user_current.m_sQQnum.ToString() + ".ini", m_JbUserList);
					break;
				}
			}
		}
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		bool flag = false;
		long num = listView_2.get_Items().get_Count();
		for (int i = 0; i < num; i++)
		{
			if (listView_2.get_Items().get_Item(i).get_Checked())
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			MessageBox.Show("请在左边列表中勾选需要举报的的号码", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		m_userJb = m_user_current;
		m_RunJbUserList.Clear();
		m_JbUserList.Clear();
		m_JbUserList = fp.ReadJbUserList(m_sFileJbUserPath + m_user_current.m_sQQnum.ToString() + ".ini");
		for (int j = 0; j < num; j++)
		{
			if (!listView_2.get_Items().get_Item(j).get_Checked())
			{
				continue;
			}
			string text2 = listView_2.get_Items().get_Item(j).get_SubItems()
				.get_Item(0)
				.get_Text();
			foreach (JbUserInfo jbUser2 in m_JbUserList)
			{
				if (jbUser2.sQQNum == text2)
				{
					m_RunJbUserList.Add(jbUser2);
				}
			}
		}
		((Control)button_32).set_Enabled(false);
		((Control)button_31).set_Enabled(true);
		if (m_jubao != null)
		{
			m_jubao.Abort();
		}
		m_jubao = new Thread(ThreadProcStartJuBao);
		m_jubao.Start(null);
	}

	private void priJuBao(string t)
	{
		if (!((Control)textBox_1).get_InvokeRequired())
		{
			((TextBoxBase)textBox_1).AppendText(t);
			return;
		}
		aa aa = priJuBao;
		((Control)this).Invoke((Delegate)aa, new object[1] { t });
	}

	public void ThreadProcStartJuBao(object date)
	{
		try
		{
			priJuBao(DateTime.Now.ToString("【HH:mm:ss】【" + m_userJb.m_sQQnick + "】举报开始++++++++++++++++++++++++++++++++++++\r\n"));
			ProJuBao();
			priJuBao(DateTime.Now.ToString("【HH:mm:ss】【" + m_userJb.m_sQQnick + "】举报完毕++++++++++++++++++++++++++++++++++++\r\n"));
		}
		catch (Exception ex)
		{
			if (ex.Message.IndexOf("中止") == -1)
			{
				priJuBao(DateTime.Now.ToString("【HH:mm:ss】") + "【" + m_userJb.m_sQQnick + "】举报执行异常+" + ex.Message + "\r\n");
			}
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		if (m_jubao != null)
		{
			m_jubao.Abort();
		}
	}

	private void button_31_Click(object sender, EventArgs e)
	{
		((Control)button_32).set_Enabled(true);
		((Control)button_31).set_Enabled(false);
		if (m_jubao != null)
		{
			m_jubao.Abort();
		}
	}

	public void ProJuBao()
	{
		foreach (JbUserInfo runJbUser in m_RunJbUserList)
		{
			string text = runJbUser.sQQNum.Trim();
			string text2 = runJbUser.sQQName.Trim();
			User user = GetUserByQQNum(text);
			if (user == null)
			{
				user = m_userJb;
			}
			priJuBao(DateTime.Now.ToString("【HH:mm:ss】") + "开始获取【" + text2 + "】车辆信息\r\n");
			bool flag = user.m_qc.QueryCarInfoJB(text);
			long countJB = user.m_qc.GetCountJB();
			if (flag && countJB >= 0L)
			{
				foreach (string sCar in runJbUser.m_sCarList)
				{
					int num = StringChar.SToInt(sCar);
					CarInfo carInfoJB = user.m_qc.GetCarInfoJB(num - 1);
					if (carInfoJB == null)
					{
						priJuBao(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + num + "】的车辆信息未能识别\r\n");
						continue;
					}
					string text3 = m_userJb.m_jb.ProJuBao(text, carInfoJB.QQNum, carInfoJB.strParkNum, num.ToString());
					if (text3 != null && text3.IndexOf("频繁") != -1)
					{
						int num2 = 0;
						while (true)
						{
							if (m_iJuBaoTime > 0)
							{
								Thread.Sleep(m_iJuBaoTime);
							}
							m_userJb.m_jb.ProJuBao(text, carInfoJB.QQNum, carInfoJB.strParkNum, num.ToString());
							if (text3 == null || num2 > iReCount * 2)
							{
								break;
							}
							num2++;
						}
					}
					else
					{
						Thread.Sleep(m_iJuBaoTime);
					}
					if (text3 == null)
					{
						priJuBao(DateTime.Now.ToString("【HH:mm:ss】") + "举报【" + text2 + "】车牌号为【" + num + "】的车辆成功\r\n");
					}
					else
					{
						priJuBao(DateTime.Now.ToString("【HH:mm:ss】") + "举报【" + text2 + "】车牌号为【" + num + "】的车辆失败：" + text3 + "\r\n");
					}
				}
				continue;
			}
			priJuBao(DateTime.Now.ToString("【HH:mm:ss】") + "获取【" + text2 + "】车辆信息发生错误\r\n");
			break;
		}
	}

	public void ProJuBaoJiaoBen(JiaoBenInfo jbinfo)
	{
		string sQQNum = jbinfo.sQQNum.Trim();
		jbinfo.sQQName.Trim();
		User userByQQNum = GetUserByQQNum(sQQNum);
		if (userByQQNum == null)
		{
			pri(DateTime.Now.ToString("【HH:mm:ss】") + "获取【" + jbinfo.sQQName + "】用户登陆信息失败\r\n");
			return;
		}
		foreach (JbUserInfo runJbUser in jbinfo.m_RunJbUserList)
		{
			string sQQNum2 = runJbUser.sQQNum;
			string sQQName = runJbUser.sQQName;
			User user = GetUserByQQNum(sQQNum2);
			if (user == null)
			{
				user = userByQQNum;
			}
			pri(DateTime.Now.ToString("【HH:mm:ss】") + "开始获取【" + sQQName + "】车辆信息\r\n");
			bool flag = user.m_qc.QueryCarInfoJB(sQQNum2);
			long countJB = user.m_qc.GetCountJB();
			if (flag && countJB >= 0L)
			{
				foreach (string sCar in runJbUser.m_sCarList)
				{
					int num = StringChar.SToInt(sCar);
					CarInfo carInfoJB = user.m_qc.GetCarInfoJB(num - 1);
					if (carInfoJB == null)
					{
						pri(DateTime.Now.ToString("【HH:mm:ss】") + "车牌号为【" + num + "】的车辆信息未能识别\r\n");
						continue;
					}
					string text = userByQQNum.m_jb.ProJuBao(sQQNum2, carInfoJB.QQNum, carInfoJB.strParkNum, num.ToString());
					if (text != null && text.IndexOf("频繁") != -1)
					{
						int num2 = 0;
						while (true)
						{
							if (m_iJuBaoTime > 0)
							{
								Thread.Sleep(m_iJuBaoTime);
							}
							userByQQNum.m_jb.ProJuBao(sQQNum2, carInfoJB.QQNum, carInfoJB.strParkNum, num.ToString());
							if (text == null || num2 > iReCount * 2)
							{
								break;
							}
							num2++;
						}
					}
					else
					{
						Thread.Sleep(m_iJuBaoTime);
					}
					if (text == null)
					{
						pri(DateTime.Now.ToString("【HH:mm:ss】") + "举报【" + sQQName + "】车牌号为【" + num + "】的车辆成功\r\n");
					}
					else
					{
						pri(DateTime.Now.ToString("【HH:mm:ss】") + "举报【" + sQQName + "】车牌号为【" + num + "】的车辆失败：" + text + "\r\n");
					}
				}
				continue;
			}
			pri(DateTime.Now.ToString("【HH:mm:ss】") + "获取【" + sQQName + "】车辆信息发生错误\r\n");
			break;
		}
	}

	private void tabControl10_Selected(object sender, TabControlEventArgs e)
	{
		if (tabControl10.get_SelectedIndex() == 1 && m_bLoginPark && listView_2.get_Items().get_Count() < 1)
		{
			button1_Click(sender, (EventArgs)(object)e);
		}
	}

	private void toolStripMenuItem_50_Click(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (m_bm != null)
		{
			return;
		}
		if (!m_bSuoDing)
		{
			m_bm = new BuKuaiMiMaInput();
			m_bm.m_sBuKuaiPass = m_sBuKuaiPass;
			((Form)m_bm).ShowDialog();
			if (!m_bm.m_bOK)
			{
				m_bm = null;
				return;
			}
			m_bm = null;
		}
		m_bSuoDing = true;
		((Control)this).Hide();
	}

	private void toolStripMenuItem_51_Click(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		BuKuaiMiMaAdd buKuaiMiMaAdd = new BuKuaiMiMaAdd();
		buKuaiMiMaAdd.m_sBuKuaiPass = m_sBuKuaiPass;
		((Form)buKuaiMiMaAdd).ShowDialog();
		if (buKuaiMiMaAdd.m_bOK)
		{
			m_sBuKuaiPass = buKuaiMiMaAdd.m_sBuKuaiPass;
			fp.WriteIniData("User0", "qq", sm.Encrypto(m_sBuKuaiPass), Application.get_StartupPath() + "\\UserInfo.ini");
		}
	}

	private void Main_SizeChanged(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Form)this).get_WindowState() == 1)
		{
			((Control)this).Hide();
		}
	}

	private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (m_bm != null)
		{
			return;
		}
		if (m_bSuoDing)
		{
			m_bm = new BuKuaiMiMaInput();
			m_bm.m_sBuKuaiPass = m_sBuKuaiPass;
			((Form)m_bm).ShowDialog();
			if (!m_bm.m_bOK)
			{
				m_bm = null;
				return;
			}
		}
		m_bm = null;
		m_bSuoDing = false;
		((Control)this).set_Visible(true);
		((Form)this).set_WindowState((FormWindowState)0);
	}

	private void toolStripMenuItem_7_Click(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (m_bm != null)
		{
			return;
		}
		if (m_bSuoDing)
		{
			m_bm = new BuKuaiMiMaInput();
			m_bm.m_sBuKuaiPass = m_sBuKuaiPass;
			((Form)m_bm).ShowDialog();
			if (!m_bm.m_bOK)
			{
				m_bm = null;
				return;
			}
		}
		m_bm = null;
		m_bSuoDing = false;
		((Control)this).set_Visible(true);
		((Form)this).set_WindowState((FormWindowState)0);
	}

	private void buttonDaoRuJunDao_Click(object sender, EventArgs e)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		bJundao = true;
		((FileDialog)openFileDialog1).set_FilterIndex(1);
		((FileDialog)openFileDialog1).set_FileName("Config.ini");
		((CommonDialog)openFileDialog1).ShowDialog();
	}

	private void buttonTxt_Click(object sender, EventArgs e)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		bJundao = false;
		((FileDialog)openFileDialog1).set_FilterIndex(2);
		((FileDialog)openFileDialog1).set_FileName("");
		((CommonDialog)openFileDialog1).ShowDialog();
	}

	private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		string fileName = ((FileDialog)openFileDialog1).get_FileName();
		if (!File.Exists(fileName))
		{
			MessageBox.Show("文件并不存在：" + fileName, "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		if (bJundao)
		{
			if (!fp.ReadJunDao(fileName))
			{
				MessageBox.Show("没有账号导入，请确认是否为XX刀的账号文件", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
		}
		else if (!fp.ReadTxt(fileName))
		{
			MessageBox.Show("没有账号导入，请确认是否为Txt账号文件", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		comboQQNum.get_Items().Clear();
		for (int i = 0; i < fp.GetCount(); i++)
		{
			UserInfo userInfo = fp.GetUserInfo(i);
			comboQQNum.get_Items().Add((object)userInfo.sQQNum);
		}
		if (comboQQNum.get_Items().get_Count() > 0)
		{
			((ListControl)comboQQNum).set_SelectedIndex(0);
		}
	}

	private void timersTimer_Elapsed(object sender, ElapsedEventArgs e)
	{
		timersTimer.Stop();
		foreach (User user in m_UserList)
		{
			user.m_qp.QueryParkerInfoForActive(user.m_sQQnum);
		}
		timersTimer.Start();
	}

	private void button_34_Click(object sender, EventArgs e)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		if (m_bm == null)
		{
			m_bm = new BuKuaiMiMaInput();
			m_bm.m_sBuKuaiPass = m_sBuKuaiPass;
			((Form)m_bm).ShowDialog();
			if (!m_bm.m_bOK)
			{
				m_bm = null;
				return;
			}
			m_bm = null;
			((FileDialog)saveFileDialog1).set_FileName("");
			((CommonDialog)saveFileDialog1).ShowDialog();
		}
	}

	private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
	{
		string fileName = ((FileDialog)saveFileDialog1).get_FileName();
		fp.DaoChuTxt(fileName);
	}

	private void toolStripMenuItem_52_Click(object sender, EventArgs e)
	{
		((Control)this).set_Visible(true);
	}

	private void button90_Click(object sender, EventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (m_sJuBaoQQNum.Length <= 1)
		{
			return;
		}
		string text = ((Control)textBox22).get_Text().Trim();
		if (text.Length < 1)
		{
			MessageBox.Show("请正确配置被举报信息", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		string text2 = ((Control)textBox20).get_Text();
		m_iJuBaoTime = StringChar.SToInt(text2);
		if (m_iJuBaoTime < 1000)
		{
			MessageBox.Show("举报时间间隔不得小于1000毫秒", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		fp.WriteIniData("config", "JuBaoTime", m_iJuBaoTime.ToString(), m_strConfigPath);
		foreach (JbUserInfo jbUser in m_JbUserList)
		{
			if (!(jbUser.sQQNum == m_sJuBaoQQNum))
			{
				continue;
			}
			jbUser.sCars = ((Control)textBox22).get_Text();
			for (int i = 0; i < listView_2.get_Items().get_Count(); i++)
			{
				string text3 = listView_2.get_Items().get_Item(i).get_SubItems()
					.get_Item(0)
					.get_Text();
				if (text3 == m_sJuBaoQQNum)
				{
					listView_2.get_Items().get_Item(i).get_SubItems()
						.get_Item(2)
						.set_Text(((Control)textBox22).get_Text());
				}
			}
			fp.WriteJbUser(m_sFileJbUserPath + m_user_current.m_sQQnum.ToString() + ".ini", m_JbUserList);
			break;
		}
	}

	private void button91_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listCars.get_Items().get_Count(); i++)
		{
			listCars.get_Items().get_Item(i).set_Checked(true);
		}
	}

	private void button94_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listCars.get_Items().get_Count(); i++)
		{
			listCars.get_Items().get_Item(i).set_Checked(false);
		}
	}

	private void checkBox_9_CheckedChanged(object sender, EventArgs e)
	{
		m_bDxhzx8 = checkBox_9.get_Checked();
		fp.WriteIniData("config", "Dxhzx8", m_bDxhzx8.ToString(), m_strConfigPath);
	}

	private void checkBox_12_CheckedChanged(object sender, EventArgs e)
	{
		m_bDxhzx9 = checkBox_12.get_Checked();
		fp.WriteIniData("config", "Dxhzx9", m_bDxhzx9.ToString(), m_strConfigPath);
	}

	private void checkBox_11_CheckedChanged(object sender, EventArgs e)
	{
		m_bDxhzx10 = checkBox_11.get_Checked();
		fp.WriteIniData("config", "Dxhzx10", m_bDxhzx10.ToString(), m_strConfigPath);
	}

	private void checkBox_10_CheckedChanged(object sender, EventArgs e)
	{
		m_bDxhzx11 = checkBox_10.get_Checked();
		fp.WriteIniData("config", "Dxhzx11", m_bDxhzx11.ToString(), m_strConfigPath);
	}

	public void CheckDxh(bool bCheck)
	{
		checkBox_2.set_Checked(bCheck);
		m_bDxhzx1 = bCheck;
		fp.WriteIniData("config", "Dxhzx1", m_bDxhzx1.ToString(), m_strConfigPath);
		checkBox_6.set_Checked(bCheck);
		m_bDxhzx2 = bCheck;
		fp.WriteIniData("config", "Dxhzx2", m_bDxhzx2.ToString(), m_strConfigPath);
		checkBox_5.set_Checked(bCheck);
		m_bDxhzx3 = bCheck;
		fp.WriteIniData("config", "Dxhzx3", m_bDxhzx3.ToString(), m_strConfigPath);
		checkBox_4.set_Checked(bCheck);
		m_bDxhzx4 = bCheck;
		fp.WriteIniData("config", "Dxhzx4", m_bDxhzx4.ToString(), m_strConfigPath);
		checkBox_3.set_Checked(bCheck);
		m_bDxhzx5 = bCheck;
		fp.WriteIniData("config", "Dxhzx5", m_bDxhzx5.ToString(), m_strConfigPath);
		checkBox_8.set_Checked(bCheck);
		m_bDxhzx6 = bCheck;
		fp.WriteIniData("config", "Dxhzx6", m_bDxhzx6.ToString(), m_strConfigPath);
		checkBox_7.set_Checked(bCheck);
		m_bDxhzx7 = bCheck;
		fp.WriteIniData("config", "Dxhzx7", m_bDxhzx7.ToString(), m_strConfigPath);
		checkBox_9.set_Checked(bCheck);
		m_bDxhzx8 = bCheck;
		fp.WriteIniData("config", "Dxhzx8", m_bDxhzx8.ToString(), m_strConfigPath);
		checkBox_12.set_Checked(bCheck);
		m_bDxhzx9 = bCheck;
		fp.WriteIniData("config", "Dxhzx9", m_bDxhzx9.ToString(), m_strConfigPath);
		checkBox_11.set_Checked(bCheck);
		m_bDxhzx10 = bCheck;
		fp.WriteIniData("config", "Dxhzx10", m_bDxhzx10.ToString(), m_strConfigPath);
		checkBox_10.set_Checked(bCheck);
		m_bDxhzx11 = bCheck;
		fp.WriteIniData("config", "Dxhzx11", m_bDxhzx11.ToString(), m_strConfigPath);
	}

	private void button95_Click(object sender, EventArgs e)
	{
		CheckDxh(bCheck: true);
	}

	private void button96_Click(object sender, EventArgs e)
	{
		CheckDxh(bCheck: false);
	}

	private void toolStripMenuItem_53_Click(object sender, EventArgs e)
	{
		ProcessStart("http://www1.400disk.com/?yxzbbc");
	}

	private void toolStripMenuItem_54_Click(object sender, EventArgs e)
	{
		ProcessStart("http://www1.400disk.com/?yxzbbc");
	}

	private void toolStripButton_4_Click(object sender, EventArgs e)
	{
		if (m_tver != null)
		{
			m_tver.Abort();
		}
		m_tver = new Thread(ThreadProcGetVer);
		m_tver.Start(null);
	}

	public void ThreadProcGetVer(object date)
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Invalid comparison between Unknown and I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream stream = m_hh.GetStream("http://yxz123.com/ver/BkVer.txt", null);
			if (stream != null)
			{
				string text = m_sExeDir + "\\ver.txt";
				File.Delete(text);
				SaveFile(text, stream);
				if (File.Exists(text))
				{
					string text2 = fp.ReadIniData("config", "ver", "", text);
					string text3 = fp.ReadIniData("config", "msg", "", text);
					if (text2 != null && text2 != "")
					{
						int num = StringChar.SToInt(text2);
						string sString = m_sVer.Replace(".", "");
						int num2 = StringChar.SToInt(sString);
						if (num2 < num)
						{
							DialogResult val = MessageBox.Show("发现最新版本 [Ver " + num + "] 是否去作者的网盘下载？\r\n关键提示：" + text3, "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
							if ((int)val != 6)
							{
								return;
							}
							ProcessStart("http://www.brsbox.com/yxzbbc");
						}
						else
						{
							MessageBox.Show("当前版本是最新的", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
						}
					}
					else
					{
						MessageBox.Show("检测失败", "提示", (MessageBoxButtons)0, (MessageBoxIcon)16);
					}
				}
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		m_tver.Abort();
	}

	private void toolStripMenuItem_56_Click(object sender, EventArgs e)
	{
		if (m_tver != null)
		{
			m_tver.Abort();
		}
		m_tver = new Thread(ThreadProcGetVer);
		m_tver.Start(null);
	}

	private void toolStripMenuItem_55_Click(object sender, EventArgs e)
	{
		if (m_tver != null)
		{
			m_tver.Abort();
		}
		m_tver = new Thread(ThreadProcGetVer);
		m_tver.Start(null);
	}

	private void toolStripButton_5_Click(object sender, EventArgs e)
	{
		ProcessStart("http://59024886.qzone.qq.com/");
	}

	private void textBox20_TextChanged(object sender, EventArgs e)
	{
		string text = ((Control)textBox20).get_Text();
		m_iJuBaoTime = StringChar.SToInt(text);
		if (m_iJuBaoTime < 1000)
		{
			m_iJuBaoTime = 1000;
		}
		fp.WriteIniData("config", "JuBaoTime", m_iJuBaoTime.ToString(), m_strConfigPath);
	}

	private void button_35_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		if (m_user_current == null)
		{
			MessageBox.Show("需要重新登陆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		bool flag = false;
		try
		{
			CarTypeInfo carTypeInfo = ct.GetCarTypeInfo(m_iDoCarCode);
			if (m_sDoCarid == null || carTypeInfo == null || m_sBuyCarCode == null)
			{
				return;
			}
			string carcolor = (((ListControl)comboCarColor).get_SelectedIndex() + 1).ToString();
			CarTypeInfo carTypeInfo2 = ct.GetCarTypeInfo(StringChar.SToInt(m_sBuyCarCode));
			string text = ((Control)comboCarColor).get_Text();
			string sColorType = carTypeInfo2.sColorType;
			if (sColorType.IndexOf(text) < 0)
			{
				DialogResult val = MessageBox.Show(carTypeInfo2.CarName + " 不支持此种颜色，如果买入，车辆将在网页中不显示\r\n支持颜色有：" + carTypeInfo2.sColorType + "\r\n是否确定非买不可？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)32);
				if ((int)val != 6)
				{
					return;
				}
			}
			if (m_sDoCarid == null)
			{
				MessageBox.Show("请在上方车辆列表中选中需要换购的车辆", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
				return;
			}
			if (m_sBuyCarCode != null)
			{
				string text2 = null;
				CarTypeInfo carTypeInfo3 = ct.GetCarTypeInfo(StringChar.SToInt(m_sBuyCarCode));
				CarTypeInfo carTypeInfo4 = carTypeInfo;
				long num = carTypeInfo.CarPrice;
				long num2 = carTypeInfo3.CarPrice;
				for (int i = 0; i < ct.GetCount(); i++)
				{
					CarTypeInfo carTypeInfoByIndex = ct.GetCarTypeInfoByIndex(i);
					if (carTypeInfoByIndex == null)
					{
						continue;
					}
					long num3 = carTypeInfoByIndex.CarPrice;
					if (num3 >= num && num3 <= num2 && carTypeInfo4.code != carTypeInfoByIndex.code)
					{
						text2 = m_user_current.m_bc.ProChangeCars(carTypeInfoByIndex.code.ToString(), carcolor, m_sDoCarid);
						if (text2 == null)
						{
							carTypeInfo4 = carTypeInfoByIndex;
							flag = true;
						}
						else
						{
							MessageBox.Show(text2, "失败", (MessageBoxButtons)0, (MessageBoxIcon)16);
						}
					}
					if (num3 >= num2)
					{
						break;
					}
				}
			}
			else
			{
				MessageBox.Show("请在左边车辆类型列表中选中需要更换后的车辆类型", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
		}
		catch (Exception ex)
		{
			fp.WriteLog("[" + ex.StackTrace + "][" + ex.Message + "]\r\n", m_strLogPath);
		}
		if (flag)
		{
			m_sDoCarid = null;
			m_iDoCarCode = 0;
			RefresCars();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected O, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected O, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected O, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected O, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected O, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected O, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected O, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected O, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected O, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected O, but got Unknown
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected O, but got Unknown
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected O, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected O, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected O, but got Unknown
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected O, but got Unknown
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Expected O, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected O, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected O, but got Unknown
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Expected O, but got Unknown
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected O, but got Unknown
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected O, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected O, but got Unknown
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected O, but got Unknown
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected O, but got Unknown
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected O, but got Unknown
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected O, but got Unknown
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected O, but got Unknown
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected O, but got Unknown
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected O, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected O, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected O, but got Unknown
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected O, but got Unknown
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected O, but got Unknown
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected O, but got Unknown
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected O, but got Unknown
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Expected O, but got Unknown
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Expected O, but got Unknown
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected O, but got Unknown
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected O, but got Unknown
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected O, but got Unknown
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected O, but got Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected O, but got Unknown
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Expected O, but got Unknown
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected O, but got Unknown
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Expected O, but got Unknown
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Expected O, but got Unknown
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected O, but got Unknown
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected O, but got Unknown
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected O, but got Unknown
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Expected O, but got Unknown
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected O, but got Unknown
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected O, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected O, but got Unknown
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected O, but got Unknown
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected O, but got Unknown
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected O, but got Unknown
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected O, but got Unknown
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected O, but got Unknown
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected O, but got Unknown
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Expected O, but got Unknown
		//IL_0836: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected O, but got Unknown
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected O, but got Unknown
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected O, but got Unknown
		//IL_0857: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Expected O, but got Unknown
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Expected O, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected O, but got Unknown
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected O, but got Unknown
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_088d: Expected O, but got Unknown
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Expected O, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected O, but got Unknown
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Expected O, but got Unknown
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected O, but got Unknown
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c4: Expected O, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Expected O, but got Unknown
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Expected O, but got Unknown
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Expected O, but got Unknown
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Expected O, but got Unknown
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected O, but got Unknown
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Expected O, but got Unknown
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Expected O, but got Unknown
		//IL_0912: Unknown result type (might be due to invalid IL or missing references)
		//IL_091c: Expected O, but got Unknown
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0927: Expected O, but got Unknown
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected O, but got Unknown
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Expected O, but got Unknown
		//IL_093e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Expected O, but got Unknown
		//IL_0949: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Expected O, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected O, but got Unknown
		//IL_095f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Expected O, but got Unknown
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected O, but got Unknown
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected O, but got Unknown
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Expected O, but got Unknown
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Expected O, but got Unknown
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Expected O, but got Unknown
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Expected O, but got Unknown
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Expected O, but got Unknown
		//IL_09b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c1: Expected O, but got Unknown
		//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cc: Expected O, but got Unknown
		//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Expected O, but got Unknown
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e2: Expected O, but got Unknown
		//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ed: Expected O, but got Unknown
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Expected O, but got Unknown
		//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Expected O, but got Unknown
		//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Expected O, but got Unknown
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a19: Expected O, but got Unknown
		//IL_0a1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Expected O, but got Unknown
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2f: Expected O, but got Unknown
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Expected O, but got Unknown
		//IL_0a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a45: Expected O, but got Unknown
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Expected O, but got Unknown
		//IL_0a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5b: Expected O, but got Unknown
		//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Expected O, but got Unknown
		//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Expected O, but got Unknown
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Expected O, but got Unknown
		//IL_0a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a87: Expected O, but got Unknown
		//IL_0a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a92: Expected O, but got Unknown
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Expected O, but got Unknown
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa8: Expected O, but got Unknown
		//IL_0aa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab3: Expected O, but got Unknown
		//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abe: Expected O, but got Unknown
		//IL_0abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Expected O, but got Unknown
		//IL_0aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad4: Expected O, but got Unknown
		//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adf: Expected O, but got Unknown
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aea: Expected O, but got Unknown
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Expected O, but got Unknown
		//IL_0af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b00: Expected O, but got Unknown
		//IL_0b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0b: Expected O, but got Unknown
		//IL_0b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b16: Expected O, but got Unknown
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Expected O, but got Unknown
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected O, but got Unknown
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected O, but got Unknown
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b42: Expected O, but got Unknown
		//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Expected O, but got Unknown
		//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Expected O, but got Unknown
		//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b63: Expected O, but got Unknown
		//IL_0b64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6e: Expected O, but got Unknown
		//IL_0b6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b79: Expected O, but got Unknown
		//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b84: Expected O, but got Unknown
		//IL_0b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8f: Expected O, but got Unknown
		//IL_0b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Expected O, but got Unknown
		//IL_0b9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba5: Expected O, but got Unknown
		//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb0: Expected O, but got Unknown
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbb: Expected O, but got Unknown
		//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc6: Expected O, but got Unknown
		//IL_0bc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd1: Expected O, but got Unknown
		//IL_0bd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdc: Expected O, but got Unknown
		//IL_0bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be7: Expected O, but got Unknown
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf2: Expected O, but got Unknown
		//IL_0bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfd: Expected O, but got Unknown
		//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c08: Expected O, but got Unknown
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c13: Expected O, but got Unknown
		//IL_0c14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1e: Expected O, but got Unknown
		//IL_0c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c29: Expected O, but got Unknown
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c34: Expected O, but got Unknown
		//IL_0c35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3f: Expected O, but got Unknown
		//IL_0c40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4a: Expected O, but got Unknown
		//IL_0c4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c55: Expected O, but got Unknown
		//IL_0c56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c60: Expected O, but got Unknown
		//IL_0c61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6b: Expected O, but got Unknown
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c76: Expected O, but got Unknown
		//IL_0c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c81: Expected O, but got Unknown
		//IL_0c82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8c: Expected O, but got Unknown
		//IL_0c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c97: Expected O, but got Unknown
		//IL_0c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca2: Expected O, but got Unknown
		//IL_0ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cad: Expected O, but got Unknown
		//IL_0cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb8: Expected O, but got Unknown
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc3: Expected O, but got Unknown
		//IL_0cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cce: Expected O, but got Unknown
		//IL_0ccf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd9: Expected O, but got Unknown
		//IL_0cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce4: Expected O, but got Unknown
		//IL_0ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cef: Expected O, but got Unknown
		//IL_0cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfa: Expected O, but got Unknown
		//IL_0cfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d05: Expected O, but got Unknown
		//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d10: Expected O, but got Unknown
		//IL_0d11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1b: Expected O, but got Unknown
		//IL_0d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d26: Expected O, but got Unknown
		//IL_0d27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d31: Expected O, but got Unknown
		//IL_0d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3c: Expected O, but got Unknown
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d47: Expected O, but got Unknown
		//IL_0d48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d52: Expected O, but got Unknown
		//IL_0d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5d: Expected O, but got Unknown
		//IL_0d5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d68: Expected O, but got Unknown
		//IL_0d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d73: Expected O, but got Unknown
		//IL_0d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7e: Expected O, but got Unknown
		//IL_0d7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d89: Expected O, but got Unknown
		//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d94: Expected O, but got Unknown
		//IL_0d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9f: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daa: Expected O, but got Unknown
		//IL_0dab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db5: Expected O, but got Unknown
		//IL_0db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc0: Expected O, but got Unknown
		//IL_0dc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcb: Expected O, but got Unknown
		//IL_0dcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd6: Expected O, but got Unknown
		//IL_0dd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de1: Expected O, but got Unknown
		//IL_0de2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dec: Expected O, but got Unknown
		//IL_0ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df7: Expected O, but got Unknown
		//IL_0df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e02: Expected O, but got Unknown
		//IL_0e03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0d: Expected O, but got Unknown
		//IL_0e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1e: Expected O, but got Unknown
		//IL_0e1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e29: Expected O, but got Unknown
		//IL_0e2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e34: Expected O, but got Unknown
		//IL_0e35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3f: Expected O, but got Unknown
		//IL_0e40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4a: Expected O, but got Unknown
		//IL_0e4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e55: Expected O, but got Unknown
		//IL_0e56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e60: Expected O, but got Unknown
		//IL_0e61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6b: Expected O, but got Unknown
		//IL_0e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e76: Expected O, but got Unknown
		//IL_0e77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e81: Expected O, but got Unknown
		//IL_0e82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8c: Expected O, but got Unknown
		//IL_0e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e97: Expected O, but got Unknown
		//IL_0e98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea2: Expected O, but got Unknown
		//IL_0ea3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ead: Expected O, but got Unknown
		//IL_0eae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb8: Expected O, but got Unknown
		//IL_0eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Expected O, but got Unknown
		//IL_0ec4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ece: Expected O, but got Unknown
		//IL_0ecf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed9: Expected O, but got Unknown
		//IL_0eda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee4: Expected O, but got Unknown
		//IL_0ee5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eef: Expected O, but got Unknown
		//IL_0ef0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efa: Expected O, but got Unknown
		//IL_0efb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f05: Expected O, but got Unknown
		//IL_0f06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f10: Expected O, but got Unknown
		//IL_0f11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1b: Expected O, but got Unknown
		//IL_0f1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f26: Expected O, but got Unknown
		//IL_0f27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f31: Expected O, but got Unknown
		//IL_0f32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3c: Expected O, but got Unknown
		//IL_0f3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f47: Expected O, but got Unknown
		//IL_0f48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f52: Expected O, but got Unknown
		//IL_0f53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5d: Expected O, but got Unknown
		//IL_0f5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f68: Expected O, but got Unknown
		//IL_0f69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f73: Expected O, but got Unknown
		//IL_0f74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7e: Expected O, but got Unknown
		//IL_0f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f89: Expected O, but got Unknown
		//IL_0f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f94: Expected O, but got Unknown
		//IL_0f95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9f: Expected O, but got Unknown
		//IL_0fa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faa: Expected O, but got Unknown
		//IL_0fab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb5: Expected O, but got Unknown
		//IL_0fb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc0: Expected O, but got Unknown
		//IL_0fc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcb: Expected O, but got Unknown
		//IL_0fcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd6: Expected O, but got Unknown
		//IL_0fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe1: Expected O, but got Unknown
		//IL_0fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fec: Expected O, but got Unknown
		//IL_0fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff7: Expected O, but got Unknown
		//IL_0ff8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1002: Expected O, but got Unknown
		//IL_1003: Unknown result type (might be due to invalid IL or missing references)
		//IL_100d: Expected O, but got Unknown
		//IL_100e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1018: Expected O, but got Unknown
		//IL_1019: Unknown result type (might be due to invalid IL or missing references)
		//IL_1023: Expected O, but got Unknown
		//IL_1024: Unknown result type (might be due to invalid IL or missing references)
		//IL_102e: Expected O, but got Unknown
		//IL_102f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1039: Expected O, but got Unknown
		//IL_103a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1044: Expected O, but got Unknown
		//IL_1045: Unknown result type (might be due to invalid IL or missing references)
		//IL_104f: Expected O, but got Unknown
		//IL_1050: Unknown result type (might be due to invalid IL or missing references)
		//IL_105a: Expected O, but got Unknown
		//IL_105b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1065: Expected O, but got Unknown
		//IL_1066: Unknown result type (might be due to invalid IL or missing references)
		//IL_1070: Expected O, but got Unknown
		//IL_1071: Unknown result type (might be due to invalid IL or missing references)
		//IL_107b: Expected O, but got Unknown
		//IL_107c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1086: Expected O, but got Unknown
		//IL_1087: Unknown result type (might be due to invalid IL or missing references)
		//IL_1091: Expected O, but got Unknown
		//IL_1092: Unknown result type (might be due to invalid IL or missing references)
		//IL_109c: Expected O, but got Unknown
		//IL_109d: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a7: Expected O, but got Unknown
		//IL_10a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b2: Expected O, but got Unknown
		//IL_10b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bd: Expected O, but got Unknown
		//IL_10be: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c8: Expected O, but got Unknown
		//IL_10c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d3: Expected O, but got Unknown
		//IL_10d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10de: Expected O, but got Unknown
		//IL_10df: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e9: Expected O, but got Unknown
		//IL_10ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f4: Expected O, but got Unknown
		//IL_10f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ff: Expected O, but got Unknown
		//IL_1100: Unknown result type (might be due to invalid IL or missing references)
		//IL_110a: Expected O, but got Unknown
		//IL_110b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1115: Expected O, but got Unknown
		//IL_1116: Unknown result type (might be due to invalid IL or missing references)
		//IL_1120: Expected O, but got Unknown
		//IL_1121: Unknown result type (might be due to invalid IL or missing references)
		//IL_112b: Expected O, but got Unknown
		//IL_112c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1136: Expected O, but got Unknown
		//IL_1137: Unknown result type (might be due to invalid IL or missing references)
		//IL_1141: Expected O, but got Unknown
		//IL_1142: Unknown result type (might be due to invalid IL or missing references)
		//IL_114c: Expected O, but got Unknown
		//IL_114d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1157: Expected O, but got Unknown
		//IL_1158: Unknown result type (might be due to invalid IL or missing references)
		//IL_1162: Expected O, but got Unknown
		//IL_1163: Unknown result type (might be due to invalid IL or missing references)
		//IL_116d: Expected O, but got Unknown
		//IL_116e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1178: Expected O, but got Unknown
		//IL_1179: Unknown result type (might be due to invalid IL or missing references)
		//IL_1183: Expected O, but got Unknown
		//IL_1184: Unknown result type (might be due to invalid IL or missing references)
		//IL_118e: Expected O, but got Unknown
		//IL_118f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1199: Expected O, but got Unknown
		//IL_119a: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a4: Expected O, but got Unknown
		//IL_11a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11af: Expected O, but got Unknown
		//IL_11b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ba: Expected O, but got Unknown
		//IL_11bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c5: Expected O, but got Unknown
		//IL_11c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d0: Expected O, but got Unknown
		//IL_11d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_11dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e6: Expected O, but got Unknown
		//IL_11e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f1: Expected O, but got Unknown
		//IL_11f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fc: Expected O, but got Unknown
		//IL_11fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1207: Expected O, but got Unknown
		//IL_1208: Unknown result type (might be due to invalid IL or missing references)
		//IL_1212: Expected O, but got Unknown
		//IL_1213: Unknown result type (might be due to invalid IL or missing references)
		//IL_121d: Expected O, but got Unknown
		//IL_121e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1228: Expected O, but got Unknown
		//IL_1229: Unknown result type (might be due to invalid IL or missing references)
		//IL_1233: Expected O, but got Unknown
		//IL_1234: Unknown result type (might be due to invalid IL or missing references)
		//IL_123e: Expected O, but got Unknown
		//IL_123f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1249: Expected O, but got Unknown
		//IL_124a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1254: Expected O, but got Unknown
		//IL_1255: Unknown result type (might be due to invalid IL or missing references)
		//IL_125f: Expected O, but got Unknown
		//IL_1260: Unknown result type (might be due to invalid IL or missing references)
		//IL_126a: Expected O, but got Unknown
		//IL_126b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1275: Expected O, but got Unknown
		//IL_1276: Unknown result type (might be due to invalid IL or missing references)
		//IL_1280: Expected O, but got Unknown
		//IL_1281: Unknown result type (might be due to invalid IL or missing references)
		//IL_128b: Expected O, but got Unknown
		//IL_128c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1296: Expected O, but got Unknown
		//IL_1297: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a1: Expected O, but got Unknown
		//IL_12a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ac: Expected O, but got Unknown
		//IL_12ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b7: Expected O, but got Unknown
		//IL_12b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c2: Expected O, but got Unknown
		//IL_12c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cd: Expected O, but got Unknown
		//IL_12ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d8: Expected O, but got Unknown
		//IL_12d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e3: Expected O, but got Unknown
		//IL_12e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ee: Expected O, but got Unknown
		//IL_12ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f9: Expected O, but got Unknown
		//IL_12fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1304: Expected O, but got Unknown
		//IL_1305: Unknown result type (might be due to invalid IL or missing references)
		//IL_130f: Expected O, but got Unknown
		//IL_1310: Unknown result type (might be due to invalid IL or missing references)
		//IL_131a: Expected O, but got Unknown
		//IL_131b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1325: Expected O, but got Unknown
		//IL_1326: Unknown result type (might be due to invalid IL or missing references)
		//IL_1330: Expected O, but got Unknown
		//IL_1331: Unknown result type (might be due to invalid IL or missing references)
		//IL_133b: Expected O, but got Unknown
		//IL_133c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1346: Expected O, but got Unknown
		//IL_1347: Unknown result type (might be due to invalid IL or missing references)
		//IL_1351: Expected O, but got Unknown
		//IL_1352: Unknown result type (might be due to invalid IL or missing references)
		//IL_135c: Expected O, but got Unknown
		//IL_135d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1367: Expected O, but got Unknown
		//IL_1368: Unknown result type (might be due to invalid IL or missing references)
		//IL_1372: Expected O, but got Unknown
		//IL_1373: Unknown result type (might be due to invalid IL or missing references)
		//IL_137d: Expected O, but got Unknown
		//IL_137e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1388: Expected O, but got Unknown
		//IL_1389: Unknown result type (might be due to invalid IL or missing references)
		//IL_1393: Expected O, but got Unknown
		//IL_1394: Unknown result type (might be due to invalid IL or missing references)
		//IL_139e: Expected O, but got Unknown
		//IL_139f: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a9: Expected O, but got Unknown
		//IL_13aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b4: Expected O, but got Unknown
		//IL_13b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bf: Expected O, but got Unknown
		//IL_13c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ca: Expected O, but got Unknown
		//IL_13cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d5: Expected O, but got Unknown
		//IL_13d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e0: Expected O, but got Unknown
		//IL_13e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13eb: Expected O, but got Unknown
		//IL_13ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f6: Expected O, but got Unknown
		//IL_13f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1401: Expected O, but got Unknown
		//IL_1402: Unknown result type (might be due to invalid IL or missing references)
		//IL_140c: Expected O, but got Unknown
		//IL_140d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1417: Expected O, but got Unknown
		//IL_1418: Unknown result type (might be due to invalid IL or missing references)
		//IL_1422: Expected O, but got Unknown
		//IL_1423: Unknown result type (might be due to invalid IL or missing references)
		//IL_142d: Expected O, but got Unknown
		//IL_142e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1438: Expected O, but got Unknown
		//IL_1439: Unknown result type (might be due to invalid IL or missing references)
		//IL_1443: Expected O, but got Unknown
		//IL_1444: Unknown result type (might be due to invalid IL or missing references)
		//IL_144e: Expected O, but got Unknown
		//IL_144f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1459: Expected O, but got Unknown
		//IL_145a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1464: Expected O, but got Unknown
		//IL_1465: Unknown result type (might be due to invalid IL or missing references)
		//IL_146f: Expected O, but got Unknown
		//IL_1470: Unknown result type (might be due to invalid IL or missing references)
		//IL_147a: Expected O, but got Unknown
		//IL_147b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1485: Expected O, but got Unknown
		//IL_1486: Unknown result type (might be due to invalid IL or missing references)
		//IL_1490: Expected O, but got Unknown
		//IL_1491: Unknown result type (might be due to invalid IL or missing references)
		//IL_149b: Expected O, but got Unknown
		//IL_149c: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a6: Expected O, but got Unknown
		//IL_14a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b1: Expected O, but got Unknown
		//IL_14b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14bc: Expected O, but got Unknown
		//IL_14bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c7: Expected O, but got Unknown
		//IL_14c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d2: Expected O, but got Unknown
		//IL_14d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14dd: Expected O, but got Unknown
		//IL_14de: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e8: Expected O, but got Unknown
		//IL_14e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f3: Expected O, but got Unknown
		//IL_14f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fe: Expected O, but got Unknown
		//IL_14ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1509: Expected O, but got Unknown
		//IL_150a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1514: Expected O, but got Unknown
		//IL_1515: Unknown result type (might be due to invalid IL or missing references)
		//IL_151f: Expected O, but got Unknown
		//IL_1520: Unknown result type (might be due to invalid IL or missing references)
		//IL_152a: Expected O, but got Unknown
		//IL_152b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1535: Expected O, but got Unknown
		//IL_1536: Unknown result type (might be due to invalid IL or missing references)
		//IL_1540: Expected O, but got Unknown
		//IL_1541: Unknown result type (might be due to invalid IL or missing references)
		//IL_154b: Expected O, but got Unknown
		//IL_154c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1556: Expected O, but got Unknown
		//IL_1557: Unknown result type (might be due to invalid IL or missing references)
		//IL_1561: Expected O, but got Unknown
		//IL_1562: Unknown result type (might be due to invalid IL or missing references)
		//IL_156c: Expected O, but got Unknown
		//IL_156d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1577: Expected O, but got Unknown
		//IL_1578: Unknown result type (might be due to invalid IL or missing references)
		//IL_1582: Expected O, but got Unknown
		//IL_1583: Unknown result type (might be due to invalid IL or missing references)
		//IL_158d: Expected O, but got Unknown
		//IL_158e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1598: Expected O, but got Unknown
		//IL_1599: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a3: Expected O, but got Unknown
		//IL_15a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ae: Expected O, but got Unknown
		//IL_15af: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b9: Expected O, but got Unknown
		//IL_15ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c4: Expected O, but got Unknown
		//IL_15c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cf: Expected O, but got Unknown
		//IL_15d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15da: Expected O, but got Unknown
		//IL_15db: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e5: Expected O, but got Unknown
		//IL_15e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f0: Expected O, but got Unknown
		//IL_15f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fb: Expected O, but got Unknown
		//IL_15fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1606: Expected O, but got Unknown
		//IL_1607: Unknown result type (might be due to invalid IL or missing references)
		//IL_1611: Expected O, but got Unknown
		//IL_1612: Unknown result type (might be due to invalid IL or missing references)
		//IL_161c: Expected O, but got Unknown
		//IL_161d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1627: Expected O, but got Unknown
		//IL_1628: Unknown result type (might be due to invalid IL or missing references)
		//IL_1632: Expected O, but got Unknown
		//IL_1633: Unknown result type (might be due to invalid IL or missing references)
		//IL_163d: Expected O, but got Unknown
		//IL_163e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1648: Expected O, but got Unknown
		//IL_1649: Unknown result type (might be due to invalid IL or missing references)
		//IL_1653: Expected O, but got Unknown
		//IL_1654: Unknown result type (might be due to invalid IL or missing references)
		//IL_165e: Expected O, but got Unknown
		//IL_165f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1669: Expected O, but got Unknown
		//IL_166a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1674: Expected O, but got Unknown
		//IL_1675: Unknown result type (might be due to invalid IL or missing references)
		//IL_167f: Expected O, but got Unknown
		//IL_1680: Unknown result type (might be due to invalid IL or missing references)
		//IL_168a: Expected O, but got Unknown
		//IL_168b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1695: Expected O, but got Unknown
		//IL_1696: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a0: Expected O, but got Unknown
		//IL_16a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ab: Expected O, but got Unknown
		//IL_16ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b6: Expected O, but got Unknown
		//IL_16b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c1: Expected O, but got Unknown
		//IL_16c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cc: Expected O, but got Unknown
		//IL_16cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d7: Expected O, but got Unknown
		//IL_16d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e2: Expected O, but got Unknown
		//IL_16e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ed: Expected O, but got Unknown
		//IL_16ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f8: Expected O, but got Unknown
		//IL_16f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1703: Expected O, but got Unknown
		//IL_1704: Unknown result type (might be due to invalid IL or missing references)
		//IL_170e: Expected O, but got Unknown
		//IL_170f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1719: Expected O, but got Unknown
		//IL_171a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1724: Expected O, but got Unknown
		//IL_1725: Unknown result type (might be due to invalid IL or missing references)
		//IL_172f: Expected O, but got Unknown
		//IL_1730: Unknown result type (might be due to invalid IL or missing references)
		//IL_173a: Expected O, but got Unknown
		//IL_173b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1745: Expected O, but got Unknown
		//IL_174c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1756: Expected O, but got Unknown
		//IL_1757: Unknown result type (might be due to invalid IL or missing references)
		//IL_1761: Expected O, but got Unknown
		//IL_1762: Unknown result type (might be due to invalid IL or missing references)
		//IL_176c: Expected O, but got Unknown
		//IL_176d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1777: Expected O, but got Unknown
		//IL_1778: Unknown result type (might be due to invalid IL or missing references)
		//IL_1782: Expected O, but got Unknown
		//IL_1783: Unknown result type (might be due to invalid IL or missing references)
		//IL_178d: Expected O, but got Unknown
		//IL_178e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1798: Expected O, but got Unknown
		//IL_1799: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a3: Expected O, but got Unknown
		//IL_17a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ae: Expected O, but got Unknown
		//IL_17af: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b9: Expected O, but got Unknown
		//IL_17ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c4: Expected O, but got Unknown
		//IL_17cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d5: Expected O, but got Unknown
		//IL_17d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e0: Expected O, but got Unknown
		//IL_17e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17eb: Expected O, but got Unknown
		//IL_17ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f6: Expected O, but got Unknown
		//IL_17f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1801: Expected O, but got Unknown
		//IL_1802: Unknown result type (might be due to invalid IL or missing references)
		//IL_180c: Expected O, but got Unknown
		//IL_180d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1817: Expected O, but got Unknown
		//IL_1818: Unknown result type (might be due to invalid IL or missing references)
		//IL_1822: Expected O, but got Unknown
		//IL_1823: Unknown result type (might be due to invalid IL or missing references)
		//IL_182d: Expected O, but got Unknown
		//IL_182e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1838: Expected O, but got Unknown
		//IL_1839: Unknown result type (might be due to invalid IL or missing references)
		//IL_1843: Expected O, but got Unknown
		//IL_1844: Unknown result type (might be due to invalid IL or missing references)
		//IL_184e: Expected O, but got Unknown
		//IL_184f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1859: Expected O, but got Unknown
		//IL_185a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1864: Expected O, but got Unknown
		//IL_1865: Unknown result type (might be due to invalid IL or missing references)
		//IL_186f: Expected O, but got Unknown
		//IL_1870: Unknown result type (might be due to invalid IL or missing references)
		//IL_187a: Expected O, but got Unknown
		//IL_187b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1885: Expected O, but got Unknown
		//IL_1886: Unknown result type (might be due to invalid IL or missing references)
		//IL_1890: Expected O, but got Unknown
		//IL_1891: Unknown result type (might be due to invalid IL or missing references)
		//IL_189b: Expected O, but got Unknown
		//IL_189c: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a6: Expected O, but got Unknown
		//IL_18a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b1: Expected O, but got Unknown
		//IL_18b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18bc: Expected O, but got Unknown
		//IL_18bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c7: Expected O, but got Unknown
		//IL_18c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d2: Expected O, but got Unknown
		//IL_18d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18dd: Expected O, but got Unknown
		//IL_18de: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e8: Expected O, but got Unknown
		//IL_18e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f3: Expected O, but got Unknown
		//IL_18f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18fe: Expected O, but got Unknown
		//IL_18ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1909: Expected O, but got Unknown
		//IL_190a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1914: Expected O, but got Unknown
		//IL_1915: Unknown result type (might be due to invalid IL or missing references)
		//IL_191f: Expected O, but got Unknown
		//IL_1920: Unknown result type (might be due to invalid IL or missing references)
		//IL_192a: Expected O, but got Unknown
		//IL_192b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1935: Expected O, but got Unknown
		//IL_1936: Unknown result type (might be due to invalid IL or missing references)
		//IL_1940: Expected O, but got Unknown
		//IL_1941: Unknown result type (might be due to invalid IL or missing references)
		//IL_194b: Expected O, but got Unknown
		//IL_194c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1956: Expected O, but got Unknown
		//IL_1957: Unknown result type (might be due to invalid IL or missing references)
		//IL_1961: Expected O, but got Unknown
		//IL_1968: Unknown result type (might be due to invalid IL or missing references)
		//IL_1972: Expected O, but got Unknown
		//IL_1973: Unknown result type (might be due to invalid IL or missing references)
		//IL_197d: Expected O, but got Unknown
		//IL_197e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1988: Expected O, but got Unknown
		//IL_1989: Unknown result type (might be due to invalid IL or missing references)
		//IL_1993: Expected O, but got Unknown
		//IL_1994: Unknown result type (might be due to invalid IL or missing references)
		//IL_199e: Expected O, but got Unknown
		//IL_199f: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a9: Expected O, but got Unknown
		//IL_19aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b4: Expected O, but got Unknown
		//IL_19b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19bf: Expected O, but got Unknown
		//IL_19c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ca: Expected O, but got Unknown
		//IL_19cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d5: Expected O, but got Unknown
		//IL_19d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e0: Expected O, but got Unknown
		//IL_19e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19eb: Expected O, but got Unknown
		//IL_19ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f6: Expected O, but got Unknown
		//IL_19f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a01: Expected O, but got Unknown
		//IL_1a02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0c: Expected O, but got Unknown
		//IL_1a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a17: Expected O, but got Unknown
		//IL_1a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a22: Expected O, but got Unknown
		//IL_1a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2d: Expected O, but got Unknown
		//IL_1a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a38: Expected O, but got Unknown
		//IL_1a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a43: Expected O, but got Unknown
		//IL_1a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4e: Expected O, but got Unknown
		//IL_1a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a59: Expected O, but got Unknown
		//IL_1a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a64: Expected O, but got Unknown
		//IL_1a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6f: Expected O, but got Unknown
		//IL_1a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7a: Expected O, but got Unknown
		//IL_1a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a85: Expected O, but got Unknown
		//IL_1a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a90: Expected O, but got Unknown
		//IL_1a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9b: Expected O, but got Unknown
		//IL_1aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab1: Expected O, but got Unknown
		//IL_1ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1abc: Expected O, but got Unknown
		//IL_1abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac7: Expected O, but got Unknown
		//IL_1ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad2: Expected O, but got Unknown
		//IL_1ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1add: Expected O, but got Unknown
		//IL_1ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae8: Expected O, but got Unknown
		//IL_1ae9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af3: Expected O, but got Unknown
		//IL_1af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afe: Expected O, but got Unknown
		//IL_1aff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b09: Expected O, but got Unknown
		//IL_1b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b14: Expected O, but got Unknown
		//IL_1b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1f: Expected O, but got Unknown
		//IL_1b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2a: Expected O, but got Unknown
		//IL_1b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b35: Expected O, but got Unknown
		//IL_1b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b40: Expected O, but got Unknown
		//IL_1b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4b: Expected O, but got Unknown
		//IL_1b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b56: Expected O, but got Unknown
		//IL_1b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b61: Expected O, but got Unknown
		//IL_1b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6c: Expected O, but got Unknown
		//IL_1b6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b77: Expected O, but got Unknown
		//IL_1b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b82: Expected O, but got Unknown
		//IL_1b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8d: Expected O, but got Unknown
		//IL_1b8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b98: Expected O, but got Unknown
		//IL_1b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba9: Expected O, but got Unknown
		//IL_1baa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb4: Expected O, but got Unknown
		//IL_1bb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bbf: Expected O, but got Unknown
		//IL_1bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bca: Expected O, but got Unknown
		//IL_1bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd5: Expected O, but got Unknown
		//IL_1bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be0: Expected O, but got Unknown
		//IL_1be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1beb: Expected O, but got Unknown
		//IL_1bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf6: Expected O, but got Unknown
		//IL_1bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c01: Expected O, but got Unknown
		//IL_1c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0c: Expected O, but got Unknown
		//IL_1c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c17: Expected O, but got Unknown
		//IL_1c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c22: Expected O, but got Unknown
		//IL_1c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2d: Expected O, but got Unknown
		//IL_1c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c38: Expected O, but got Unknown
		//IL_1c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c43: Expected O, but got Unknown
		//IL_1c44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4e: Expected O, but got Unknown
		//IL_1c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c59: Expected O, but got Unknown
		//IL_1c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c64: Expected O, but got Unknown
		//IL_1c65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6f: Expected O, but got Unknown
		//IL_1c70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7a: Expected O, but got Unknown
		//IL_1c7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c85: Expected O, but got Unknown
		//IL_1c86: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c90: Expected O, but got Unknown
		//IL_1c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9b: Expected O, but got Unknown
		//IL_1c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca6: Expected O, but got Unknown
		//IL_1ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb1: Expected O, but got Unknown
		//IL_1cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cbc: Expected O, but got Unknown
		//IL_1cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc7: Expected O, but got Unknown
		//IL_1cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd2: Expected O, but got Unknown
		//IL_1cd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cdd: Expected O, but got Unknown
		//IL_1cde: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce8: Expected O, but got Unknown
		//IL_1ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf3: Expected O, but got Unknown
		//IL_1cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfe: Expected O, but got Unknown
		//IL_1cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d09: Expected O, but got Unknown
		//IL_1d0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d14: Expected O, but got Unknown
		//IL_1d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d1f: Expected O, but got Unknown
		//IL_1d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d2a: Expected O, but got Unknown
		//IL_1d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d35: Expected O, but got Unknown
		//IL_1d36: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d40: Expected O, but got Unknown
		//IL_1d41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d4b: Expected O, but got Unknown
		//IL_1d4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d56: Expected O, but got Unknown
		//IL_1d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d61: Expected O, but got Unknown
		//IL_1d62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6c: Expected O, but got Unknown
		//IL_1d6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d77: Expected O, but got Unknown
		//IL_1d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d82: Expected O, but got Unknown
		//IL_1d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8d: Expected O, but got Unknown
		//IL_1d8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d98: Expected O, but got Unknown
		//IL_1d99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da3: Expected O, but got Unknown
		//IL_1da4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dae: Expected O, but got Unknown
		//IL_1daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db9: Expected O, but got Unknown
		//IL_1dba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc4: Expected O, but got Unknown
		//IL_1dc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dcf: Expected O, but got Unknown
		//IL_1dd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dda: Expected O, but got Unknown
		//IL_1ddb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de5: Expected O, but got Unknown
		//IL_1de6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df0: Expected O, but got Unknown
		//IL_1df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dfb: Expected O, but got Unknown
		//IL_1e02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0c: Expected O, but got Unknown
		//IL_1e13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e1d: Expected O, but got Unknown
		//IL_1e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e28: Expected O, but got Unknown
		//IL_1e29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e33: Expected O, but got Unknown
		//IL_1e34: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3e: Expected O, but got Unknown
		//IL_1e3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e49: Expected O, but got Unknown
		//IL_1e4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e54: Expected O, but got Unknown
		//IL_1e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5f: Expected O, but got Unknown
		//IL_1e60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6a: Expected O, but got Unknown
		//IL_1e6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e75: Expected O, but got Unknown
		//IL_1e76: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e80: Expected O, but got Unknown
		//IL_1e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8b: Expected O, but got Unknown
		//IL_1e8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e96: Expected O, but got Unknown
		//IL_1e97: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea1: Expected O, but got Unknown
		//IL_1ea2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eac: Expected O, but got Unknown
		//IL_1ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb7: Expected O, but got Unknown
		//IL_1eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec2: Expected O, but got Unknown
		//IL_1ec3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ecd: Expected O, but got Unknown
		//IL_1ece: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed8: Expected O, but got Unknown
		//IL_1ed9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee3: Expected O, but got Unknown
		//IL_1ee4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eee: Expected O, but got Unknown
		//IL_1eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef9: Expected O, but got Unknown
		//IL_1efa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f04: Expected O, but got Unknown
		//IL_1f05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f0f: Expected O, but got Unknown
		//IL_1f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1a: Expected O, but got Unknown
		//IL_1f1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f25: Expected O, but got Unknown
		//IL_1f26: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f30: Expected O, but got Unknown
		//IL_1f31: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3b: Expected O, but got Unknown
		//IL_1f3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f46: Expected O, but got Unknown
		//IL_1f47: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f51: Expected O, but got Unknown
		//IL_1f52: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5c: Expected O, but got Unknown
		//IL_1f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f67: Expected O, but got Unknown
		//IL_1f68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f72: Expected O, but got Unknown
		//IL_1f73: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f7d: Expected O, but got Unknown
		//IL_1f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f88: Expected O, but got Unknown
		//IL_1f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f93: Expected O, but got Unknown
		//IL_1f94: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9e: Expected O, but got Unknown
		//IL_1f9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa9: Expected O, but got Unknown
		//IL_1faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb4: Expected O, but got Unknown
		//IL_1fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fbf: Expected O, but got Unknown
		//IL_1fc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fca: Expected O, but got Unknown
		//IL_1fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd5: Expected O, but got Unknown
		//IL_1fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe0: Expected O, but got Unknown
		//IL_1fe1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1feb: Expected O, but got Unknown
		//IL_1fec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ff6: Expected O, but got Unknown
		//IL_1ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2001: Expected O, but got Unknown
		//IL_2002: Unknown result type (might be due to invalid IL or missing references)
		//IL_200c: Expected O, but got Unknown
		//IL_200d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2017: Expected O, but got Unknown
		//IL_2018: Unknown result type (might be due to invalid IL or missing references)
		//IL_2022: Expected O, but got Unknown
		//IL_2023: Unknown result type (might be due to invalid IL or missing references)
		//IL_202d: Expected O, but got Unknown
		//IL_202e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2038: Expected O, but got Unknown
		//IL_2039: Unknown result type (might be due to invalid IL or missing references)
		//IL_2043: Expected O, but got Unknown
		//IL_2044: Unknown result type (might be due to invalid IL or missing references)
		//IL_204e: Expected O, but got Unknown
		//IL_204f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2059: Expected O, but got Unknown
		//IL_205a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2064: Expected O, but got Unknown
		//IL_2065: Unknown result type (might be due to invalid IL or missing references)
		//IL_206f: Expected O, but got Unknown
		//IL_2070: Unknown result type (might be due to invalid IL or missing references)
		//IL_207a: Expected O, but got Unknown
		//IL_207b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2085: Expected O, but got Unknown
		//IL_2086: Unknown result type (might be due to invalid IL or missing references)
		//IL_2090: Expected O, but got Unknown
		//IL_2091: Unknown result type (might be due to invalid IL or missing references)
		//IL_209b: Expected O, but got Unknown
		//IL_209c: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a6: Expected O, but got Unknown
		//IL_20a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b1: Expected O, but got Unknown
		//IL_20b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_20bc: Expected O, but got Unknown
		//IL_20bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c7: Expected O, but got Unknown
		//IL_20c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d2: Expected O, but got Unknown
		//IL_20d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20dd: Expected O, but got Unknown
		//IL_20de: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e8: Expected O, but got Unknown
		//IL_20e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f3: Expected O, but got Unknown
		//IL_20f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_20fe: Expected O, but got Unknown
		//IL_20ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2109: Expected O, but got Unknown
		//IL_210a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2114: Expected O, but got Unknown
		//IL_2115: Unknown result type (might be due to invalid IL or missing references)
		//IL_211f: Expected O, but got Unknown
		//IL_2120: Unknown result type (might be due to invalid IL or missing references)
		//IL_212a: Expected O, but got Unknown
		//IL_212b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2135: Expected O, but got Unknown
		//IL_2136: Unknown result type (might be due to invalid IL or missing references)
		//IL_2140: Expected O, but got Unknown
		//IL_2141: Unknown result type (might be due to invalid IL or missing references)
		//IL_214b: Expected O, but got Unknown
		//IL_214c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2156: Expected O, but got Unknown
		//IL_2157: Unknown result type (might be due to invalid IL or missing references)
		//IL_2161: Expected O, but got Unknown
		//IL_2162: Unknown result type (might be due to invalid IL or missing references)
		//IL_216c: Expected O, but got Unknown
		//IL_216d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2177: Expected O, but got Unknown
		//IL_2178: Unknown result type (might be due to invalid IL or missing references)
		//IL_2182: Expected O, but got Unknown
		//IL_2183: Unknown result type (might be due to invalid IL or missing references)
		//IL_218d: Expected O, but got Unknown
		//IL_218e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2198: Expected O, but got Unknown
		//IL_2199: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a3: Expected O, but got Unknown
		//IL_21a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ae: Expected O, but got Unknown
		//IL_21af: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b9: Expected O, but got Unknown
		//IL_21ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c4: Expected O, but got Unknown
		//IL_21c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_21cf: Expected O, but got Unknown
		//IL_21d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_21da: Expected O, but got Unknown
		//IL_21db: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e5: Expected O, but got Unknown
		//IL_21e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f0: Expected O, but got Unknown
		//IL_21f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_21fb: Expected O, but got Unknown
		//IL_21fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2206: Expected O, but got Unknown
		//IL_2207: Unknown result type (might be due to invalid IL or missing references)
		//IL_2211: Expected O, but got Unknown
		//IL_2212: Unknown result type (might be due to invalid IL or missing references)
		//IL_221c: Expected O, but got Unknown
		//IL_221d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2227: Expected O, but got Unknown
		//IL_2228: Unknown result type (might be due to invalid IL or missing references)
		//IL_2232: Expected O, but got Unknown
		//IL_2233: Unknown result type (might be due to invalid IL or missing references)
		//IL_223d: Expected O, but got Unknown
		//IL_223e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2248: Expected O, but got Unknown
		//IL_2249: Unknown result type (might be due to invalid IL or missing references)
		//IL_2253: Expected O, but got Unknown
		//IL_2254: Unknown result type (might be due to invalid IL or missing references)
		//IL_225e: Expected O, but got Unknown
		//IL_225f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2269: Expected O, but got Unknown
		//IL_226a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2274: Expected O, but got Unknown
		//IL_2275: Unknown result type (might be due to invalid IL or missing references)
		//IL_227f: Expected O, but got Unknown
		//IL_2280: Unknown result type (might be due to invalid IL or missing references)
		//IL_228a: Expected O, but got Unknown
		//IL_228b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2295: Expected O, but got Unknown
		//IL_2296: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a0: Expected O, but got Unknown
		//IL_22a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ab: Expected O, but got Unknown
		//IL_22ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_22b6: Expected O, but got Unknown
		//IL_22b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c1: Expected O, but got Unknown
		//IL_22c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_22cc: Expected O, but got Unknown
		//IL_22cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d7: Expected O, but got Unknown
		//IL_22d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e2: Expected O, but got Unknown
		//IL_22e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ed: Expected O, but got Unknown
		//IL_22ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f8: Expected O, but got Unknown
		//IL_22f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2303: Expected O, but got Unknown
		//IL_2304: Unknown result type (might be due to invalid IL or missing references)
		//IL_230e: Expected O, but got Unknown
		//IL_230f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2319: Expected O, but got Unknown
		//IL_231a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2324: Expected O, but got Unknown
		//IL_2325: Unknown result type (might be due to invalid IL or missing references)
		//IL_232f: Expected O, but got Unknown
		//IL_2330: Unknown result type (might be due to invalid IL or missing references)
		//IL_233a: Expected O, but got Unknown
		//IL_233b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2345: Expected O, but got Unknown
		//IL_2346: Unknown result type (might be due to invalid IL or missing references)
		//IL_2350: Expected O, but got Unknown
		//IL_2351: Unknown result type (might be due to invalid IL or missing references)
		//IL_235b: Expected O, but got Unknown
		//IL_235c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2366: Expected O, but got Unknown
		//IL_2367: Unknown result type (might be due to invalid IL or missing references)
		//IL_2371: Expected O, but got Unknown
		//IL_2372: Unknown result type (might be due to invalid IL or missing references)
		//IL_237c: Expected O, but got Unknown
		//IL_237d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2387: Expected O, but got Unknown
		//IL_2388: Unknown result type (might be due to invalid IL or missing references)
		//IL_2392: Expected O, but got Unknown
		//IL_2393: Unknown result type (might be due to invalid IL or missing references)
		//IL_239d: Expected O, but got Unknown
		//IL_239e: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a8: Expected O, but got Unknown
		//IL_23a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b3: Expected O, but got Unknown
		//IL_23b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_23be: Expected O, but got Unknown
		//IL_23bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c9: Expected O, but got Unknown
		//IL_23ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d4: Expected O, but got Unknown
		//IL_23d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_23df: Expected O, but got Unknown
		//IL_23e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ea: Expected O, but got Unknown
		//IL_23eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f5: Expected O, but got Unknown
		//IL_23f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2400: Expected O, but got Unknown
		//IL_2401: Unknown result type (might be due to invalid IL or missing references)
		//IL_240b: Expected O, but got Unknown
		//IL_240c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2416: Expected O, but got Unknown
		//IL_2417: Unknown result type (might be due to invalid IL or missing references)
		//IL_2421: Expected O, but got Unknown
		//IL_2422: Unknown result type (might be due to invalid IL or missing references)
		//IL_242c: Expected O, but got Unknown
		//IL_242d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2437: Expected O, but got Unknown
		//IL_2438: Unknown result type (might be due to invalid IL or missing references)
		//IL_2442: Expected O, but got Unknown
		//IL_2443: Unknown result type (might be due to invalid IL or missing references)
		//IL_244d: Expected O, but got Unknown
		//IL_244e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2458: Expected O, but got Unknown
		//IL_2459: Unknown result type (might be due to invalid IL or missing references)
		//IL_2463: Expected O, but got Unknown
		//IL_2464: Unknown result type (might be due to invalid IL or missing references)
		//IL_246e: Expected O, but got Unknown
		//IL_246f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2479: Expected O, but got Unknown
		//IL_247a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2484: Expected O, but got Unknown
		//IL_2485: Unknown result type (might be due to invalid IL or missing references)
		//IL_248f: Expected O, but got Unknown
		//IL_2490: Unknown result type (might be due to invalid IL or missing references)
		//IL_249a: Expected O, but got Unknown
		//IL_249b: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a5: Expected O, but got Unknown
		//IL_24a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_24b0: Expected O, but got Unknown
		//IL_24b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_24bb: Expected O, but got Unknown
		//IL_24bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c6: Expected O, but got Unknown
		//IL_24c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d1: Expected O, but got Unknown
		//IL_24d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_24dc: Expected O, but got Unknown
		//IL_24dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_24e7: Expected O, but got Unknown
		//IL_24e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_24f2: Expected O, but got Unknown
		//IL_24f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_24fd: Expected O, but got Unknown
		//IL_24fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2508: Expected O, but got Unknown
		//IL_2509: Unknown result type (might be due to invalid IL or missing references)
		//IL_2513: Expected O, but got Unknown
		//IL_2514: Unknown result type (might be due to invalid IL or missing references)
		//IL_251e: Expected O, but got Unknown
		//IL_251f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2529: Expected O, but got Unknown
		//IL_252a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2534: Expected O, but got Unknown
		//IL_2535: Unknown result type (might be due to invalid IL or missing references)
		//IL_253f: Expected O, but got Unknown
		//IL_2540: Unknown result type (might be due to invalid IL or missing references)
		//IL_254a: Expected O, but got Unknown
		//IL_254b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2555: Expected O, but got Unknown
		//IL_2556: Unknown result type (might be due to invalid IL or missing references)
		//IL_2560: Expected O, but got Unknown
		//IL_2561: Unknown result type (might be due to invalid IL or missing references)
		//IL_256b: Expected O, but got Unknown
		//IL_256c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2576: Expected O, but got Unknown
		//IL_2577: Unknown result type (might be due to invalid IL or missing references)
		//IL_2581: Expected O, but got Unknown
		//IL_2582: Unknown result type (might be due to invalid IL or missing references)
		//IL_258c: Expected O, but got Unknown
		//IL_258d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2597: Expected O, but got Unknown
		//IL_2598: Unknown result type (might be due to invalid IL or missing references)
		//IL_25a2: Expected O, but got Unknown
		//IL_25a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ad: Expected O, but got Unknown
		//IL_25ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b8: Expected O, but got Unknown
		//IL_25b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c3: Expected O, but got Unknown
		//IL_25c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ce: Expected O, but got Unknown
		//IL_25cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_25d9: Expected O, but got Unknown
		//IL_25da: Unknown result type (might be due to invalid IL or missing references)
		//IL_25e4: Expected O, but got Unknown
		//IL_25e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ef: Expected O, but got Unknown
		//IL_25f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_25fa: Expected O, but got Unknown
		//IL_25fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2605: Expected O, but got Unknown
		//IL_2606: Unknown result type (might be due to invalid IL or missing references)
		//IL_2610: Expected O, but got Unknown
		//IL_2611: Unknown result type (might be due to invalid IL or missing references)
		//IL_261b: Expected O, but got Unknown
		//IL_261c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2626: Expected O, but got Unknown
		//IL_2627: Unknown result type (might be due to invalid IL or missing references)
		//IL_2631: Expected O, but got Unknown
		//IL_2632: Unknown result type (might be due to invalid IL or missing references)
		//IL_263c: Expected O, but got Unknown
		//IL_263d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2647: Expected O, but got Unknown
		//IL_2648: Unknown result type (might be due to invalid IL or missing references)
		//IL_2652: Expected O, but got Unknown
		//IL_2653: Unknown result type (might be due to invalid IL or missing references)
		//IL_265d: Expected O, but got Unknown
		//IL_265e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2668: Expected O, but got Unknown
		//IL_2669: Unknown result type (might be due to invalid IL or missing references)
		//IL_2673: Expected O, but got Unknown
		//IL_2674: Unknown result type (might be due to invalid IL or missing references)
		//IL_267e: Expected O, but got Unknown
		//IL_267f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2689: Expected O, but got Unknown
		//IL_268a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2694: Expected O, but got Unknown
		//IL_2695: Unknown result type (might be due to invalid IL or missing references)
		//IL_269f: Expected O, but got Unknown
		//IL_26a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_26aa: Expected O, but got Unknown
		//IL_26ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b5: Expected O, but got Unknown
		//IL_26b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_26c0: Expected O, but got Unknown
		//IL_26c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_26cb: Expected O, but got Unknown
		//IL_26cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d6: Expected O, but got Unknown
		//IL_26d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e1: Expected O, but got Unknown
		//IL_26e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ec: Expected O, but got Unknown
		//IL_26ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f7: Expected O, but got Unknown
		//IL_26f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2702: Expected O, but got Unknown
		//IL_2703: Unknown result type (might be due to invalid IL or missing references)
		//IL_270d: Expected O, but got Unknown
		//IL_270e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2718: Expected O, but got Unknown
		//IL_2719: Unknown result type (might be due to invalid IL or missing references)
		//IL_2723: Expected O, but got Unknown
		//IL_2724: Unknown result type (might be due to invalid IL or missing references)
		//IL_272e: Expected O, but got Unknown
		//IL_272f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2739: Expected O, but got Unknown
		//IL_273a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2744: Expected O, but got Unknown
		//IL_2745: Unknown result type (might be due to invalid IL or missing references)
		//IL_274f: Expected O, but got Unknown
		//IL_2750: Unknown result type (might be due to invalid IL or missing references)
		//IL_275a: Expected O, but got Unknown
		//IL_275b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2765: Expected O, but got Unknown
		//IL_2766: Unknown result type (might be due to invalid IL or missing references)
		//IL_2770: Expected O, but got Unknown
		//IL_2771: Unknown result type (might be due to invalid IL or missing references)
		//IL_277b: Expected O, but got Unknown
		//IL_277c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2786: Expected O, but got Unknown
		//IL_2787: Unknown result type (might be due to invalid IL or missing references)
		//IL_2791: Expected O, but got Unknown
		//IL_2792: Unknown result type (might be due to invalid IL or missing references)
		//IL_279c: Expected O, but got Unknown
		//IL_279d: Unknown result type (might be due to invalid IL or missing references)
		//IL_27a7: Expected O, but got Unknown
		//IL_27a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b2: Expected O, but got Unknown
		//IL_27b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_27bd: Expected O, but got Unknown
		//IL_27be: Unknown result type (might be due to invalid IL or missing references)
		//IL_27c8: Expected O, but got Unknown
		//IL_27c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_27d3: Expected O, but got Unknown
		//IL_27d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_27de: Expected O, but got Unknown
		//IL_27df: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e9: Expected O, but got Unknown
		//IL_27ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f4: Expected O, but got Unknown
		//IL_27f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ff: Expected O, but got Unknown
		//IL_2800: Unknown result type (might be due to invalid IL or missing references)
		//IL_280a: Expected O, but got Unknown
		//IL_280b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2815: Expected O, but got Unknown
		//IL_2816: Unknown result type (might be due to invalid IL or missing references)
		//IL_2820: Expected O, but got Unknown
		//IL_2821: Unknown result type (might be due to invalid IL or missing references)
		//IL_282b: Expected O, but got Unknown
		//IL_282c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2836: Expected O, but got Unknown
		//IL_2837: Unknown result type (might be due to invalid IL or missing references)
		//IL_2841: Expected O, but got Unknown
		//IL_2842: Unknown result type (might be due to invalid IL or missing references)
		//IL_284c: Expected O, but got Unknown
		//IL_284d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2857: Expected O, but got Unknown
		//IL_2858: Unknown result type (might be due to invalid IL or missing references)
		//IL_2862: Expected O, but got Unknown
		//IL_2863: Unknown result type (might be due to invalid IL or missing references)
		//IL_286d: Expected O, but got Unknown
		//IL_286e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2878: Expected O, but got Unknown
		//IL_2879: Unknown result type (might be due to invalid IL or missing references)
		//IL_2883: Expected O, but got Unknown
		//IL_2884: Unknown result type (might be due to invalid IL or missing references)
		//IL_288e: Expected O, but got Unknown
		//IL_288f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2899: Expected O, but got Unknown
		//IL_289a: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a4: Expected O, but got Unknown
		//IL_28a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_28af: Expected O, but got Unknown
		//IL_28b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ba: Expected O, but got Unknown
		//IL_28bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_28c5: Expected O, but got Unknown
		//IL_28c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d0: Expected O, but got Unknown
		//IL_28d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_28db: Expected O, but got Unknown
		//IL_28dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_28e6: Expected O, but got Unknown
		//IL_28e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_28f1: Expected O, but got Unknown
		//IL_28f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_28fc: Expected O, but got Unknown
		//IL_28fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2907: Expected O, but got Unknown
		//IL_2908: Unknown result type (might be due to invalid IL or missing references)
		//IL_2912: Expected O, but got Unknown
		//IL_2913: Unknown result type (might be due to invalid IL or missing references)
		//IL_291d: Expected O, but got Unknown
		//IL_291e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2928: Expected O, but got Unknown
		//IL_2929: Unknown result type (might be due to invalid IL or missing references)
		//IL_2933: Expected O, but got Unknown
		//IL_2934: Unknown result type (might be due to invalid IL or missing references)
		//IL_293e: Expected O, but got Unknown
		//IL_293f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2949: Expected O, but got Unknown
		//IL_294a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2954: Expected O, but got Unknown
		//IL_2955: Unknown result type (might be due to invalid IL or missing references)
		//IL_295f: Expected O, but got Unknown
		//IL_2960: Unknown result type (might be due to invalid IL or missing references)
		//IL_296a: Expected O, but got Unknown
		//IL_296b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2975: Expected O, but got Unknown
		//IL_2976: Unknown result type (might be due to invalid IL or missing references)
		//IL_2980: Expected O, but got Unknown
		//IL_2981: Unknown result type (might be due to invalid IL or missing references)
		//IL_298b: Expected O, but got Unknown
		//IL_298c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2996: Expected O, but got Unknown
		//IL_2997: Unknown result type (might be due to invalid IL or missing references)
		//IL_29a1: Expected O, but got Unknown
		//IL_29a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ac: Expected O, but got Unknown
		//IL_29ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_29b7: Expected O, but got Unknown
		//IL_29b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_29c2: Expected O, but got Unknown
		//IL_29c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_29cd: Expected O, but got Unknown
		//IL_29ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d8: Expected O, but got Unknown
		//IL_29d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_29e3: Expected O, but got Unknown
		//IL_29e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ee: Expected O, but got Unknown
		//IL_29ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f9: Expected O, but got Unknown
		//IL_29fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a04: Expected O, but got Unknown
		//IL_2a05: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a0f: Expected O, but got Unknown
		//IL_2a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a1a: Expected O, but got Unknown
		//IL_2a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a25: Expected O, but got Unknown
		//IL_2a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a30: Expected O, but got Unknown
		//IL_2a31: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a3b: Expected O, but got Unknown
		//IL_2a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a46: Expected O, but got Unknown
		//IL_2a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a51: Expected O, but got Unknown
		//IL_2a52: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a5c: Expected O, but got Unknown
		//IL_2a5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a67: Expected O, but got Unknown
		//IL_2a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a72: Expected O, but got Unknown
		//IL_2a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7d: Expected O, but got Unknown
		//IL_2a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a88: Expected O, but got Unknown
		//IL_2a89: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a93: Expected O, but got Unknown
		//IL_2a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a9e: Expected O, but got Unknown
		//IL_2a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aa9: Expected O, but got Unknown
		//IL_2aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ab4: Expected O, but got Unknown
		//IL_2ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2abf: Expected O, but got Unknown
		//IL_2ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aca: Expected O, but got Unknown
		//IL_2acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ad5: Expected O, but got Unknown
		//IL_2ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ae0: Expected O, but got Unknown
		//IL_341c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3426: Expected O, but got Unknown
		//IL_35de: Unknown result type (might be due to invalid IL or missing references)
		//IL_35e8: Expected O, but got Unknown
		//IL_36bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_36c6: Expected O, but got Unknown
		//IL_386f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3879: Expected O, but got Unknown
		//IL_389c: Unknown result type (might be due to invalid IL or missing references)
		//IL_38a6: Expected O, but got Unknown
		//IL_3970: Unknown result type (might be due to invalid IL or missing references)
		//IL_397a: Expected O, but got Unknown
		//IL_39ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_39f6: Expected O, but got Unknown
		//IL_3aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aaa: Expected O, but got Unknown
		//IL_3ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ac1: Expected O, but got Unknown
		//IL_51a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_51aa: Expected O, but got Unknown
		//IL_5241: Unknown result type (might be due to invalid IL or missing references)
		//IL_524b: Expected O, but got Unknown
		//IL_52cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_52d5: Expected O, but got Unknown
		//IL_5863: Unknown result type (might be due to invalid IL or missing references)
		//IL_586d: Expected O, but got Unknown
		//IL_5901: Unknown result type (might be due to invalid IL or missing references)
		//IL_590b: Expected O, but got Unknown
		//IL_59a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_59ac: Expected O, but got Unknown
		//IL_5b94: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b9e: Expected O, but got Unknown
		//IL_5eca: Unknown result type (might be due to invalid IL or missing references)
		//IL_69a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_69ac: Expected O, but got Unknown
		//IL_6fa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_6fac: Expected O, but got Unknown
		//IL_7042: Unknown result type (might be due to invalid IL or missing references)
		//IL_704c: Expected O, but got Unknown
		//IL_7059: Unknown result type (might be due to invalid IL or missing references)
		//IL_7063: Expected O, but got Unknown
		//IL_7430: Unknown result type (might be due to invalid IL or missing references)
		//IL_743a: Expected O, but got Unknown
		//IL_74d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_74da: Expected O, but got Unknown
		//IL_774a: Unknown result type (might be due to invalid IL or missing references)
		//IL_7754: Expected O, but got Unknown
		//IL_77e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_77ee: Expected O, but got Unknown
		//IL_792c: Unknown result type (might be due to invalid IL or missing references)
		//IL_7a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7aa8: Expected O, but got Unknown
		//IL_7c74: Unknown result type (might be due to invalid IL or missing references)
		//IL_7d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_7d7e: Expected O, but got Unknown
		//IL_7e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e18: Expected O, but got Unknown
		//IL_8599: Unknown result type (might be due to invalid IL or missing references)
		//IL_85a3: Expected O, but got Unknown
		//IL_8639: Unknown result type (might be due to invalid IL or missing references)
		//IL_8643: Expected O, but got Unknown
		//IL_8bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_92c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_92d3: Expected O, but got Unknown
		//IL_947b: Unknown result type (might be due to invalid IL or missing references)
		//IL_9485: Expected O, but got Unknown
		//IL_951b: Unknown result type (might be due to invalid IL or missing references)
		//IL_9525: Expected O, but got Unknown
		//IL_9532: Unknown result type (might be due to invalid IL or missing references)
		//IL_953c: Expected O, but got Unknown
		//IL_9b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_9b64: Expected O, but got Unknown
		//IL_9bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_9c04: Expected O, but got Unknown
		//IL_9e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_9e71: Expected O, but got Unknown
		//IL_9f03: Unknown result type (might be due to invalid IL or missing references)
		//IL_9f0d: Expected O, but got Unknown
		//IL_a7aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_ce54: Unknown result type (might be due to invalid IL or missing references)
		//IL_ce5e: Expected O, but got Unknown
		//IL_cef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_cefb: Expected O, but got Unknown
		//IL_cf08: Unknown result type (might be due to invalid IL or missing references)
		//IL_cf12: Expected O, but got Unknown
		//IL_d12f: Unknown result type (might be due to invalid IL or missing references)
		//IL_d399: Unknown result type (might be due to invalid IL or missing references)
		//IL_d3a3: Expected O, but got Unknown
		//IL_d5eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_d5f5: Expected O, but got Unknown
		//IL_d870: Unknown result type (might be due to invalid IL or missing references)
		//IL_d87a: Expected O, but got Unknown
		//IL_de22: Unknown result type (might be due to invalid IL or missing references)
		//IL_de2c: Expected O, but got Unknown
		//IL_debf: Unknown result type (might be due to invalid IL or missing references)
		//IL_dec9: Expected O, but got Unknown
		//IL_e0b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_e394: Unknown result type (might be due to invalid IL or missing references)
		//IL_e514: Unknown result type (might be due to invalid IL or missing references)
		//IL_e51e: Expected O, but got Unknown
		//IL_e758: Unknown result type (might be due to invalid IL or missing references)
		//IL_e942: Unknown result type (might be due to invalid IL or missing references)
		//IL_e94c: Expected O, but got Unknown
		//IL_e9e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_e9ec: Expected O, but got Unknown
		//IL_ec40: Unknown result type (might be due to invalid IL or missing references)
		//IL_ec4a: Expected O, but got Unknown
		//IL_ecbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_ecc8: Expected O, but got Unknown
		//IL_ed9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_eda4: Expected O, but got Unknown
		//IL_ee14: Unknown result type (might be due to invalid IL or missing references)
		//IL_ee1e: Expected O, but got Unknown
		//IL_eef0: Unknown result type (might be due to invalid IL or missing references)
		//IL_eefa: Expected O, but got Unknown
		//IL_f022: Unknown result type (might be due to invalid IL or missing references)
		//IL_f02c: Expected O, but got Unknown
		//IL_fa91: Unknown result type (might be due to invalid IL or missing references)
		//IL_fd8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_fd96: Expected O, but got Unknown
		//IL_fe8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_fe95: Expected O, but got Unknown
		//IL_10015: Unknown result type (might be due to invalid IL or missing references)
		//IL_1001f: Expected O, but got Unknown
		//IL_105a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_105ac: Expected O, but got Unknown
		//IL_10642: Unknown result type (might be due to invalid IL or missing references)
		//IL_1064c: Expected O, but got Unknown
		//IL_1090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_10914: Expected O, but got Unknown
		//IL_109a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_109b1: Expected O, but got Unknown
		//IL_109be: Unknown result type (might be due to invalid IL or missing references)
		//IL_109c8: Expected O, but got Unknown
		//IL_1116f: Unknown result type (might be due to invalid IL or missing references)
		//IL_11179: Expected O, but got Unknown
		//IL_1120f: Unknown result type (might be due to invalid IL or missing references)
		//IL_11219: Expected O, but got Unknown
		//IL_114a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_114b3: Expected O, but got Unknown
		//IL_1154a: Unknown result type (might be due to invalid IL or missing references)
		//IL_11554: Expected O, but got Unknown
		//IL_11652: Unknown result type (might be due to invalid IL or missing references)
		//IL_1165c: Expected O, but got Unknown
		//IL_116ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_116f9: Expected O, but got Unknown
		//IL_11dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e53: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e5d: Expected O, but got Unknown
		//IL_11ee3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11eed: Expected O, but got Unknown
		//IL_11f86: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f90: Expected O, but got Unknown
		//IL_12012: Unknown result type (might be due to invalid IL or missing references)
		//IL_1201c: Expected O, but got Unknown
		//IL_1219a: Unknown result type (might be due to invalid IL or missing references)
		//IL_126dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_126e7: Expected O, but got Unknown
		//IL_1277d: Unknown result type (might be due to invalid IL or missing references)
		//IL_12787: Expected O, but got Unknown
		//IL_12934: Unknown result type (might be due to invalid IL or missing references)
		//IL_1293e: Expected O, but got Unknown
		//IL_129ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_129d8: Expected O, but got Unknown
		//IL_12b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b7e: Expected O, but got Unknown
		//IL_12cd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cde: Expected O, but got Unknown
		//IL_12d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d7e: Expected O, but got Unknown
		//IL_12f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f3e: Expected O, but got Unknown
		//IL_13022: Unknown result type (might be due to invalid IL or missing references)
		//IL_1302c: Expected O, but got Unknown
		//IL_1309f: Unknown result type (might be due to invalid IL or missing references)
		//IL_130a9: Expected O, but got Unknown
		//IL_130ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_130d4: Expected O, but got Unknown
		//IL_131b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_131be: Expected O, but got Unknown
		//IL_1322d: Unknown result type (might be due to invalid IL or missing references)
		//IL_13237: Expected O, but got Unknown
		//IL_133bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_133c9: Expected O, but got Unknown
		//IL_1345b: Unknown result type (might be due to invalid IL or missing references)
		//IL_13465: Expected O, but got Unknown
		//IL_13716: Unknown result type (might be due to invalid IL or missing references)
		//IL_13720: Expected O, but got Unknown
		//IL_137ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_137c4: Expected O, but got Unknown
		//IL_13c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c1f: Expected O, but got Unknown
		//IL_13cb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cbf: Expected O, but got Unknown
		//IL_13d75: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d7f: Expected O, but got Unknown
		//IL_13e12: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e1c: Expected O, but got Unknown
		//IL_13fc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fcb: Expected O, but got Unknown
		//IL_14216: Unknown result type (might be due to invalid IL or missing references)
		//IL_14220: Expected O, but got Unknown
		//IL_142b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_142bd: Expected O, but got Unknown
		//IL_14628: Unknown result type (might be due to invalid IL or missing references)
		//IL_14704: Unknown result type (might be due to invalid IL or missing references)
		//IL_1470e: Expected O, but got Unknown
		//IL_147a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_147aa: Expected O, but got Unknown
		//IL_14aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ca4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14cae: Expected O, but got Unknown
		//IL_156f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15700: Expected O, but got Unknown
		//IL_15793: Unknown result type (might be due to invalid IL or missing references)
		//IL_1579d: Expected O, but got Unknown
		//IL_157aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_157b4: Expected O, but got Unknown
		//IL_15c1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c24: Expected O, but got Unknown
		//IL_15cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cc6: Expected O, but got Unknown
		//IL_15d5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d68: Expected O, but got Unknown
		//IL_15e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e0a: Expected O, but got Unknown
		//IL_15ea2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15eac: Expected O, but got Unknown
		//IL_15f2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f38: Expected O, but got Unknown
		//IL_15fa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fb2: Expected O, but got Unknown
		//IL_1605a: Unknown result type (might be due to invalid IL or missing references)
		//IL_16064: Expected O, but got Unknown
		//IL_16167: Unknown result type (might be due to invalid IL or missing references)
		//IL_16171: Expected O, but got Unknown
		//IL_17a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a7f: Expected O, but got Unknown
		//IL_17aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ab2: Expected O, but got Unknown
		//IL_17db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17dc0: Expected O, but got Unknown
		//IL_18082: Unknown result type (might be due to invalid IL or missing references)
		//IL_18338: Unknown result type (might be due to invalid IL or missing references)
		//IL_18342: Expected O, but got Unknown
		//IL_18545: Unknown result type (might be due to invalid IL or missing references)
		//IL_1854f: Expected O, but got Unknown
		//IL_188c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_188d1: Expected O, but got Unknown
		//IL_18b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b17: Expected O, but got Unknown
		//IL_18e7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e85: Expected O, but got Unknown
		//IL_19110: Unknown result type (might be due to invalid IL or missing references)
		//IL_1911a: Expected O, but got Unknown
		//IL_19335: Unknown result type (might be due to invalid IL or missing references)
		//IL_1933f: Expected O, but got Unknown
		//IL_1970e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1978e: Unknown result type (might be due to invalid IL or missing references)
		//IL_19798: Expected O, but got Unknown
		//IL_1981e: Unknown result type (might be due to invalid IL or missing references)
		//IL_19828: Expected O, but got Unknown
		//IL_198c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_198cb: Expected O, but got Unknown
		//IL_1994d: Unknown result type (might be due to invalid IL or missing references)
		//IL_19957: Expected O, but got Unknown
		//IL_19b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f06: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f10: Expected O, but got Unknown
		//IL_1a152: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a15c: Expected O, but got Unknown
		//IL_1a37b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a385: Expected O, but got Unknown
		//IL_1a4af: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4b9: Expected O, but got Unknown
		//IL_1a758: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a762: Expected O, but got Unknown
		//IL_1a8b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8c2: Expected O, but got Unknown
		//IL_1aa1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa96: Expected O, but got Unknown
		//IL_1aef6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1b0: Expected O, but got Unknown
		//IL_1b3be: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3c8: Expected O, but got Unknown
		//IL_1b73e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b748: Expected O, but got Unknown
		//IL_1b984: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b98e: Expected O, but got Unknown
		//IL_1bcf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1b1: Expected O, but got Unknown
		//IL_1c3f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c3fe: Expected O, but got Unknown
		//IL_1c9d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9e2: Expected O, but got Unknown
		//IL_1cc9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cca4: Expected O, but got Unknown
		//IL_1cebf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cec9: Expected O, but got Unknown
		//IL_1d357: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d5de: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee8f: Expected O, but got Unknown
		//IL_1efe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1efea: Expected O, but got Unknown
		//IL_1f296: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f2a0: Expected O, but got Unknown
		//IL_1f2e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f2f0: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main));
		menuStrip1 = new MenuStrip();
		toolStripMenuItem_0 = new ToolStripMenuItem();
		toolStripMenuItem_55 = new ToolStripMenuItem();
		toolStripMenuItem_46 = new ToolStripMenuItem();
		toolStripMenuItem_53 = new ToolStripMenuItem();
		toolStripMenuItem_1 = new ToolStripMenuItem();
		toolStripMenuItem_2 = new ToolStripMenuItem();
		toolStripMenuItem_3 = new ToolStripMenuItem();
		toolStripMenuItem_50 = new ToolStripMenuItem();
		toolStripMenuItem_51 = new ToolStripMenuItem();
		toolStripMenuItem_52 = new ToolStripMenuItem();
		toolStripMenuItem_4 = new ToolStripMenuItem();
		toolStripMenuItem_9 = new ToolStripMenuItem();
		toolStripMenuItem_18 = new ToolStripMenuItem();
		toolStripMenuItem_5 = new ToolStripMenuItem();
		toolStripMenuItem_6 = new ToolStripMenuItem();
		toolStripMenuItem_23 = new ToolStripMenuItem();
		label1 = new Label();
		buttonTxt = new Button();
		buttonLogin = new Button();
		label3 = new Label();
		textValidate = new TextBox();
		checkMark = new CheckBox();
		buttonDelete = new Button();
		comboQQNum = new ComboBox();
		label2 = new Label();
		textQQPass = new TextBox();
		listUser = new ListView();
		columnHeader25 = new ColumnHeader();
		columnHeader26 = new ColumnHeader();
		contextMenuStrip1 = new ContextMenuStrip(components);
		toolStripMenuItem_10 = new ToolStripMenuItem();
		toolStripMenuItem_16 = new ToolStripMenuItem();
		toolStripMenuItem_48 = new ToolStripMenuItem();
		toolStripMenuItem_49 = new ToolStripMenuItem();
		toolStripMenuItem5 = new ToolStripSeparator();
		toolStripMenuItem_17 = new ToolStripMenuItem();
		toolStripMenuItem_22 = new ToolStripMenuItem();
		toolStripMenuItem_44 = new ToolStripMenuItem();
		toolStripMenuItem_27 = new ToolStripMenuItem();
		toolStripMenuItem_28 = new ToolStripMenuItem();
		toolStripMenuItem_29 = new ToolStripMenuItem();
		toolStripMenuItem_30 = new ToolStripMenuItem();
		toolStripMenuItem_31 = new ToolStripMenuItem();
		toolStripMenuItem_32 = new ToolStripMenuItem();
		toolStripMenuItem_33 = new ToolStripMenuItem();
		toolStripMenuItem1 = new ToolStripSeparator();
		toolStripMenuItem_13 = new ToolStripMenuItem();
		toolStripMenuItem_26 = new ToolStripMenuItem();
		toolStripMenuItem_19 = new ToolStripMenuItem();
		toolStripMenuItem_15 = new ToolStripMenuItem();
		toolStripMenuItem_11 = new ToolStripMenuItem();
		toolStripMenuItem_12 = new ToolStripMenuItem();
		toolStripMenuItem_14 = new ToolStripMenuItem();
		toolStripMenuItem2 = new ToolStripSeparator();
		toolStripMenuItem_20 = new ToolStripMenuItem();
		toolStripMenuItem_24 = new ToolStripMenuItem();
		tabControl1 = new TabControl();
		tabPageZhzx = new TabPage();
		button95 = new Button();
		button96 = new Button();
		checkBox_10 = new CheckBox();
		checkBox_11 = new CheckBox();
		checkBox_12 = new CheckBox();
		checkBox_9 = new CheckBox();
		label141 = new Label();
		label142 = new Label();
		textBox21 = new TextBox();
		button_11 = new Button();
		button_10 = new Button();
		button_9 = new Button();
		button_7 = new Button();
		button_8 = new Button();
		button_6 = new Button();
		button_5 = new Button();
		textBox_0 = new TextBox();
		listView_1 = new ListView();
		columnHeader252 = new ColumnHeader();
		columnHeader253 = new ColumnHeader();
		columnHeader255 = new ColumnHeader();
		label61 = new Label();
		checkBox_7 = new CheckBox();
		checkBox_8 = new CheckBox();
		checkBox_3 = new CheckBox();
		checkBox_4 = new CheckBox();
		checkBox_5 = new CheckBox();
		checkBox_6 = new CheckBox();
		checkBox_2 = new CheckBox();
		listView_0 = new ListView();
		columnHeader247 = new ColumnHeader();
		columnHeader249 = new ColumnHeader();
		columnHeader250 = new ColumnHeader();
		columnHeader251 = new ColumnHeader();
		label60 = new Label();
		tabPageParks = new TabPage();
		tabControl3 = new TabControl();
		tabPagePark = new TabPage();
		button91 = new Button();
		button94 = new Button();
		button_28 = new Button();
		comboBox_0 = new ComboBox();
		checkBox_0 = new CheckBox();
		button77 = new Button();
		button60 = new Button();
		button61 = new Button();
		buttonYiJianParkPiLiang = new Button();
		buttonYiJianPark = new Button();
		labelChaJu = new Label();
		buttonSaveFriend = new Button();
		button2 = new Button();
		label16 = new Label();
		label12 = new Label();
		label8 = new Label();
		label6 = new Label();
		comboExcessQQ = new ComboBox();
		label5 = new Label();
		checkGoBack = new CheckBox();
		buttonAllYes1 = new Button();
		buttonYuan = new Button();
		buttonAllNo1 = new Button();
		buttonNuo = new Button();
		buttonTie = new Button();
		label4 = new Label();
		buttonRefres3 = new Button();
		listFriend = new ListView();
		columnHeader17 = new ColumnHeader();
		columnHeader18 = new ColumnHeader();
		columnHeader19 = new ColumnHeader();
		columnHeader20 = new ColumnHeader();
		columnHeader21 = new ColumnHeader();
		columnHeader22 = new ColumnHeader();
		columnHeader235 = new ColumnHeader();
		columnHeader236 = new ColumnHeader();
		columnHeader237 = new ColumnHeader();
		columnHeader24 = new ColumnHeader();
		label11 = new Label();
		label10 = new Label();
		label9 = new Label();
		buttonRefres2 = new Button();
		listCars = new ListView();
		columnHeader8 = new ColumnHeader();
		columnHeader9 = new ColumnHeader();
		columnHeader10 = new ColumnHeader();
		columnHeader11 = new ColumnHeader();
		columnHeader12 = new ColumnHeader();
		columnHeader13 = new ColumnHeader();
		columnHeader14 = new ColumnHeader();
		columnHeader15 = new ColumnHeader();
		columnHeader16 = new ColumnHeader();
		columnHeader254 = new ColumnHeader();
		buttonRefres1 = new Button();
		listPark = new ListView();
		columnHeader1 = new ColumnHeader();
		columnHeader2 = new ColumnHeader();
		columnHeader3 = new ColumnHeader();
		columnHeader23 = new ColumnHeader();
		columnHeader4 = new ColumnHeader();
		columnHeader5 = new ColumnHeader();
		columnHeader6 = new ColumnHeader();
		columnHeader7 = new ColumnHeader();
		tabPageJubao = new TabPage();
		textBox_1 = new TextBox();
		tabControl10 = new TabControl();
		tabPage27 = new TabPage();
		listJubaoPark = new ListView();
		columnHeader140 = new ColumnHeader();
		columnHeader141 = new ColumnHeader();
		columnHeader142 = new ColumnHeader();
		columnHeader143 = new ColumnHeader();
		columnHeader144 = new ColumnHeader();
		columnHeader145 = new ColumnHeader();
		columnHeader146 = new ColumnHeader();
		columnHeader147 = new ColumnHeader();
		button31 = new Button();
		comboExcessQQ2 = new ComboBox();
		button33 = new Button();
		label51 = new Label();
		button34 = new Button();
		button35 = new Button();
		button30 = new Button();
		label56 = new Label();
		label55 = new Label();
		label57 = new Label();
		button32 = new Button();
		listJubaoCars = new ListView();
		columnHeader131 = new ColumnHeader();
		columnHeader132 = new ColumnHeader();
		columnHeader133 = new ColumnHeader();
		columnHeader134 = new ColumnHeader();
		columnHeader135 = new ColumnHeader();
		columnHeader136 = new ColumnHeader();
		columnHeader137 = new ColumnHeader();
		columnHeader138 = new ColumnHeader();
		columnHeader139 = new ColumnHeader();
		label54 = new Label();
		label53 = new Label();
		label52 = new Label();
		button38 = new Button();
		button36 = new Button();
		button37 = new Button();
		tabPage28 = new TabPage();
		button90 = new Button();
		comboExcessQQ4 = new ComboBox();
		button1 = new Button();
		button92 = new Button();
		button93 = new Button();
		label58 = new Label();
		textBox22 = new TextBox();
		label139 = new Label();
		button_31 = new Button();
		button_32 = new Button();
		button_29 = new Button();
		label59 = new Label();
		button_30 = new Button();
		listView_2 = new ListView();
		columnHeader297 = new ColumnHeader();
		columnHeader298 = new ColumnHeader();
		columnHeader299 = new ColumnHeader();
		tabPageCheshi = new TabPage();
		button_35 = new Button();
		label62 = new Label();
		label63 = new Label();
		checkBox9 = new CheckBox();
		buttonBuyCar = new Button();
		buttonChangeCar = new Button();
		label7 = new Label();
		listBuyCar = new ListView();
		columnHeader36 = new ColumnHeader();
		columnHeader37 = new ColumnHeader();
		columnHeader38 = new ColumnHeader();
		columnHeader39 = new ColumnHeader();
		columnHeader148 = new ColumnHeader();
		columnHeader167 = new ColumnHeader();
		columnHeader300 = new ColumnHeader();
		comboCarColor = new ComboBox();
		comboCarType = new ComboBox();
		listCarInfo = new ListView();
		columnHeader27 = new ColumnHeader();
		columnHeader28 = new ColumnHeader();
		columnHeader29 = new ColumnHeader();
		columnHeader30 = new ColumnHeader();
		columnHeader31 = new ColumnHeader();
		columnHeader32 = new ColumnHeader();
		columnHeader33 = new ColumnHeader();
		columnHeader34 = new ColumnHeader();
		columnHeader35 = new ColumnHeader();
		tabPageJiaoben = new TabPage();
		tabControl7 = new TabControl();
		tabPage22 = new TabPage();
		checkBox18 = new CheckBox();
		button_33 = new Button();
		checkBox14 = new CheckBox();
		button79 = new Button();
		button80 = new Button();
		comboExcessQQ3 = new ComboBox();
		checkBox13 = new CheckBox();
		label117 = new Label();
		button64 = new Button();
		button75 = new Button();
		button76 = new Button();
		label116 = new Label();
		comboBoxColor10 = new ComboBox();
		comboBoxCarName10 = new ComboBox();
		checkBoxHuanChe10 = new CheckBox();
		checkBoxCar10 = new CheckBox();
		comboBoxColor9 = new ComboBox();
		comboBoxCarName9 = new ComboBox();
		checkBoxHuanChe9 = new CheckBox();
		checkBoxCar9 = new CheckBox();
		comboBoxColor8 = new ComboBox();
		comboBoxCarName8 = new ComboBox();
		checkBoxHuanChe8 = new CheckBox();
		checkBoxCar8 = new CheckBox();
		comboBoxColor7 = new ComboBox();
		comboBoxCarName7 = new ComboBox();
		checkBoxHuanChe7 = new CheckBox();
		checkBoxCar7 = new CheckBox();
		comboBoxColor6 = new ComboBox();
		comboBoxCarName6 = new ComboBox();
		checkBoxHuanChe6 = new CheckBox();
		checkBoxCar6 = new CheckBox();
		comboBoxColor5 = new ComboBox();
		comboBoxCarName5 = new ComboBox();
		checkBoxHuanChe5 = new CheckBox();
		checkBoxCar5 = new CheckBox();
		comboBoxColor4 = new ComboBox();
		comboBoxCarName4 = new ComboBox();
		checkBoxHuanChe4 = new CheckBox();
		checkBoxCar4 = new CheckBox();
		comboBoxColor3 = new ComboBox();
		comboBoxCarName3 = new ComboBox();
		checkBoxHuanChe3 = new CheckBox();
		checkBoxCar3 = new CheckBox();
		comboBoxColor2 = new ComboBox();
		comboBoxCarName2 = new ComboBox();
		checkBoxHuanChe2 = new CheckBox();
		checkBoxCar2 = new CheckBox();
		comboBoxColor1 = new ComboBox();
		comboBoxCarName1 = new ComboBox();
		checkBoxHuanChe1 = new CheckBox();
		checkBoxCar1 = new CheckBox();
		button66 = new Button();
		button67 = new Button();
		label104 = new Label();
		textBox11 = new TextBox();
		label103 = new Label();
		label102 = new Label();
		textBox10 = new TextBox();
		label101 = new Label();
		label100 = new Label();
		label99 = new Label();
		button65 = new Button();
		textBox9 = new TextBox();
		label98 = new Label();
		checkBox12 = new CheckBox();
		textBox8 = new TextBox();
		label97 = new Label();
		checkBox11 = new CheckBox();
		label96 = new Label();
		textBox7 = new TextBox();
		label65 = new Label();
		listViewJiaoBenUser = new ListView();
		columnHeader231 = new ColumnHeader();
		columnHeader232 = new ColumnHeader();
		contextMenuStrip2 = new ContextMenuStrip(components);
		toolStripMenuItem_25 = new ToolStripMenuItem();
		button63 = new Button();
		button62 = new Button();
		tabPage23 = new TabPage();
		button74 = new Button();
		textBox3 = new TextBox();
		tabPageWoDeCheZiJinKuang = new TabPage();
		label93 = new Label();
		textBoxWoCheWeiJinKuang = new TextBox();
		textBoxWoCheZiJinKuang = new TextBox();
		buttonShuaXinWoCheWeiJinKuang = new Button();
		label92 = new Label();
		buttonShuaXinWoCheZiJinKuang = new Button();
		tabPage20 = new TabPage();
		label91 = new Label();
		textBoxQueryQQNum = new TextBox();
		textBoxHaoYouTingCheXin = new TextBox();
		buttonChaKanHaoYouTingCheJiLu = new Button();
		tabPage21 = new TabPage();
		labelYeMa = new Label();
		buttonWeiYe = new Button();
		buttonShouYe = new Button();
		buttonShangYe = new Button();
		buttonXiaYe = new Button();
		listViewPaiMin = new ListView();
		columnHeader224 = new ColumnHeader();
		columnHeader225 = new ColumnHeader();
		columnHeader226 = new ColumnHeader();
		columnHeader227 = new ColumnHeader();
		columnHeader228 = new ColumnHeader();
		columnHeader229 = new ColumnHeader();
		columnHeader296 = new ColumnHeader();
		columnHeader230 = new ColumnHeader();
		buttonZongPaiHangBang = new Button();
		tabPageFriendBuy = new TabPage();
		tabControl5 = new TabControl();
		tabPageShiJian = new TabPage();
		button_16 = new Button();
		textBoxShiJian = new TextBox();
		tabPageJilu = new TabPage();
		textBoxNuLiShiJian = new TextBox();
		tabControl9 = new TabControl();
		tabPage24 = new TabPage();
		button_4 = new Button();
		listViewSlave = new ListView();
		columnHeader149 = new ColumnHeader();
		columnHeader150 = new ColumnHeader();
		columnHeader151 = new ColumnHeader();
		columnHeader152 = new ColumnHeader();
		columnHeader153 = new ColumnHeader();
		columnHeader154 = new ColumnHeader();
		columnHeader155 = new ColumnHeader();
		columnHeader156 = new ColumnHeader();
		columnHeader157 = new ColumnHeader();
		columnHeader158 = new ColumnHeader();
		columnHeader238 = new ColumnHeader();
		columnHeader239 = new ColumnHeader();
		columnHeader240 = new ColumnHeader();
		columnHeader245 = new ColumnHeader();
		button_3 = new Button();
		listBoxMast = new ListBox();
		button_1 = new Button();
		listBoxMy = new ListBox();
		button_2 = new Button();
		label15 = new Label();
		buttonYiJianHaoYouMaiMai = new Button();
		label13 = new Label();
		buttonTaoHaoZhuRen = new Button();
		buttonQingKongCuoHao = new Button();
		buttonDaZhe = new Button();
		buttonWoYaoSuShen = new Button();
		buttonShiFang = new Button();
		buttonMinYunKa = new Button();
		buttonShuaXin = new Button();
		comboBoxTaoHaoZhuRen = new ComboBox();
		buttonZhiXing = new Button();
		comboBoxZheMo = new ComboBox();
		buttonQuanXuan = new Button();
		comboBoxAnFu = new ComboBox();
		buttonQuanBuXuan = new Button();
		comboBoxDaZhe = new ComboBox();
		tabPage25 = new TabPage();
		button_25 = new Button();
		button_24 = new Button();
		button_23 = new Button();
		button_22 = new Button();
		label131 = new Label();
		label130 = new Label();
		label129 = new Label();
		textBox19 = new TextBox();
		button_21 = new Button();
		label128 = new Label();
		textBox18 = new TextBox();
		button_20 = new Button();
		button87 = new Button();
		button88 = new Button();
		button85 = new Button();
		button86 = new Button();
		button_19 = new Button();
		button_18 = new Button();
		listViewJc = new ListView();
		columnHeader278 = new ColumnHeader();
		columnHeader279 = new ColumnHeader();
		columnHeader280 = new ColumnHeader();
		button_17 = new Button();
		label127 = new Label();
		button_0 = new Button();
		listViewMaiDeQi = new ListView();
		columnHeader159 = new ColumnHeader();
		columnHeader160 = new ColumnHeader();
		columnHeader161 = new ColumnHeader();
		columnHeader248 = new ColumnHeader();
		columnHeader244 = new ColumnHeader();
		buttonShuaXinMaiDeQi = new Button();
		tabPage26 = new TabPage();
		button84 = new Button();
		button89 = new Button();
		button82 = new Button();
		button83 = new Button();
		button_27 = new Button();
		label136 = new Label();
		button_26 = new Button();
		listViewPK2 = new ListView();
		columnHeader287 = new ColumnHeader();
		columnHeader288 = new ColumnHeader();
		columnHeader289 = new ColumnHeader();
		columnHeader293 = new ColumnHeader();
		columnHeader294 = new ColumnHeader();
		columnHeader295 = new ColumnHeader();
		label135 = new Label();
		label134 = new Label();
		label133 = new Label();
		listViewPK0 = new ListView();
		columnHeader284 = new ColumnHeader();
		columnHeader285 = new ColumnHeader();
		columnHeader286 = new ColumnHeader();
		listViewPK1 = new ListView();
		columnHeader281 = new ColumnHeader();
		columnHeader282 = new ColumnHeader();
		columnHeader283 = new ColumnHeader();
		columnHeader290 = new ColumnHeader();
		columnHeader291 = new ColumnHeader();
		columnHeader292 = new ColumnHeader();
		tabPageQueryFriend = new TabPage();
		checkBox15 = new CheckBox();
		checkBox16 = new CheckBox();
		checkBox17 = new CheckBox();
		checkBox3 = new CheckBox();
		checkBox2 = new CheckBox();
		checkBox1 = new CheckBox();
		tabControl2 = new TabControl();
		tabPageJinBen = new TabPage();
		label27 = new Label();
		listBox5 = new ListBox();
		label25 = new Label();
		listBox3 = new ListBox();
		tabPageQueryPark = new TabPage();
		label120 = new Label();
		label121 = new Label();
		label64 = new Label();
		label19 = new Label();
		label20 = new Label();
		label21 = new Label();
		label22 = new Label();
		label23 = new Label();
		label24 = new Label();
		listQueryCars = new ListView();
		columnHeader49 = new ColumnHeader();
		columnHeader50 = new ColumnHeader();
		columnHeader51 = new ColumnHeader();
		columnHeader52 = new ColumnHeader();
		columnHeader53 = new ColumnHeader();
		columnHeader54 = new ColumnHeader();
		columnHeader55 = new ColumnHeader();
		columnHeader56 = new ColumnHeader();
		columnHeader57 = new ColumnHeader();
		listQueryPark = new ListView();
		columnHeader58 = new ColumnHeader();
		columnHeader59 = new ColumnHeader();
		columnHeader60 = new ColumnHeader();
		columnHeader61 = new ColumnHeader();
		columnHeader62 = new ColumnHeader();
		columnHeader63 = new ColumnHeader();
		columnHeader64 = new ColumnHeader();
		columnHeader65 = new ColumnHeader();
		tabPageQueryQQBuyFriend = new TabPage();
		listSlave = new ListView();
		columnHeader40 = new ColumnHeader();
		columnHeader41 = new ColumnHeader();
		columnHeader42 = new ColumnHeader();
		columnHeader43 = new ColumnHeader();
		columnHeader44 = new ColumnHeader();
		columnHeader45 = new ColumnHeader();
		columnHeader46 = new ColumnHeader();
		columnHeader47 = new ColumnHeader();
		columnHeader66 = new ColumnHeader();
		columnHeader48 = new ColumnHeader();
		columnHeader241 = new ColumnHeader();
		columnHeader242 = new ColumnHeader();
		columnHeader243 = new ColumnHeader();
		columnHeader246 = new ColumnHeader();
		label18 = new Label();
		pictureBox2 = new PictureBox();
		listBox2 = new ListBox();
		label17 = new Label();
		pictureBox1 = new PictureBox();
		listBox1 = new ListBox();
		tabPage9 = new TabPage();
		pictureBox5 = new PictureBox();
		listView20 = new ListView();
		columnHeader261 = new ColumnHeader();
		columnHeader262 = new ColumnHeader();
		columnHeader263 = new ColumnHeader();
		contextMenuStrip4 = new ContextMenuStrip(components);
		toolStripMenuItem_38 = new ToolStripMenuItem();
		toolStripMenuItem_37 = new ToolStripMenuItem();
		toolStripMenuItem3 = new ToolStripSeparator();
		toolStripMenuItem_39 = new ToolStripMenuItem();
		tabPage10 = new TabPage();
		axWindowsMediaPlayer1 = new AxWindowsMediaPlayer();
		listView19 = new ListView();
		columnHeader258 = new ColumnHeader();
		columnHeader259 = new ColumnHeader();
		columnHeader260 = new ColumnHeader();
		contextMenuStrip3 = new ContextMenuStrip(components);
		toolStripMenuItem_34 = new ToolStripMenuItem();
		toolStripMenuItem_35 = new ToolStripMenuItem();
		toolStripMenuItem_36 = new ToolStripMenuItem();
		tabPage11 = new TabPage();
		label66 = new Label();
		label67 = new Label();
		listView16 = new ListView();
		columnHeader256 = new ColumnHeader();
		columnHeader257 = new ColumnHeader();
		listView18 = new ListView();
		columnHeader265 = new ColumnHeader();
		columnHeader266 = new ColumnHeader();
		columnHeader267 = new ColumnHeader();
		buttonQueryQQ = new Button();
		label14 = new Label();
		textBox1 = new TextBox();
		tabPageXi = new TabPage();
		label132 = new Label();
		button78 = new Button();
		listViewAllFriend = new ListView();
		columnHeader162 = new ColumnHeader();
		columnHeader163 = new ColumnHeader();
		columnHeader166 = new ColumnHeader();
		columnHeader164 = new ColumnHeader();
		columnHeader165 = new ColumnHeader();
		tabPageZone = new TabPage();
		button_13 = new Button();
		textBoxContent = new TextBox();
		tabControl8 = new TabControl();
		tabPage12 = new TabPage();
		listView21 = new ListView();
		columnHeader264 = new ColumnHeader();
		columnHeader268 = new ColumnHeader();
		columnHeader269 = new ColumnHeader();
		columnHeader270 = new ColumnHeader();
		columnHeader271 = new ColumnHeader();
		contextMenuStrip5 = new ContextMenuStrip(components);
		toolStripMenuItem_40 = new ToolStripMenuItem();
		toolStripMenuItem_41 = new ToolStripMenuItem();
		toolStripMenuItem4 = new ToolStripSeparator();
		toolStripMenuItem_42 = new ToolStripMenuItem();
		toolStripMenuItem_45 = new ToolStripMenuItem();
		toolStripMenuItem_43 = new ToolStripMenuItem();
		tabPage13 = new TabPage();
		webBrowserReadQQZone = new WebBrowser();
		button_12 = new Button();
		label68 = new Label();
		textBox17 = new TextBox();
		tabPageCity = new TabPage();
		label138 = new Label();
		comboBoxOnline = new ComboBox();
		label137 = new Label();
		label126 = new Label();
		label125 = new Label();
		label124 = new Label();
		button_15 = new Button();
		button_14 = new Button();
		labelAge = new Label();
		comboBoxAge = new ComboBox();
		label123 = new Label();
		comboBoxSex = new ComboBox();
		label122 = new Label();
		comboBoxCity = new ComboBox();
		pictureBoxCity = new PictureBox();
		listViewCity = new DoubleBufferListView();
		columnHeader272 = new ColumnHeader();
		columnHeader273 = new ColumnHeader();
		columnHeader274 = new ColumnHeader();
		columnHeader275 = new ColumnHeader();
		columnHeader276 = new ColumnHeader();
		columnHeader277 = new ColumnHeader();
		label94 = new Label();
		comboBoxSheng = new ComboBox();
		label95 = new Label();
		label140 = new Label();
		textBox20 = new TextBox();
		toolStrip1 = new ToolStrip();
		toolStripButton_0 = new ToolStripButton();
		toolStripButton_1 = new ToolStripButton();
		toolStripButton_2 = new ToolStripButton();
		toolStripButton_3 = new ToolStripButton();
		toolStripButtonHelp = new ToolStripButton();
		toolStripLabel1 = new ToolStripLabel();
		toolStripButton_4 = new ToolStripButton();
		toolStripButton_5 = new ToolStripButton();
		statusStrip1 = new StatusStrip();
		toolStripStatusLabel1 = new ToolStripStatusLabel();
		toolTipAll = new ToolTip(components);
		button68 = new Button();
		button69 = new Button();
		button81 = new Button();
		buttonDaoRuJunDao = new Button();
		button_34 = new Button();
		pictureBoxValidate = new PictureBox();
		button8 = new Button();
		button9 = new Button();
		button10 = new Button();
		button11 = new Button();
		button12 = new Button();
		button13 = new Button();
		button14 = new Button();
		button15 = new Button();
		button16 = new Button();
		button17 = new Button();
		button18 = new Button();
		button19 = new Button();
		button20 = new Button();
		button21 = new Button();
		button22 = new Button();
		button23 = new Button();
		button24 = new Button();
		button25 = new Button();
		button26 = new Button();
		button27 = new Button();
		button28 = new Button();
		button29 = new Button();
		button3 = new Button();
		button4 = new Button();
		button5 = new Button();
		button6 = new Button();
		button7 = new Button();
		button39 = new Button();
		button40 = new Button();
		button41 = new Button();
		button42 = new Button();
		button43 = new Button();
		button44 = new Button();
		button45 = new Button();
		button46 = new Button();
		button47 = new Button();
		button48 = new Button();
		button49 = new Button();
		button50 = new Button();
		button51 = new Button();
		button52 = new Button();
		button53 = new Button();
		button54 = new Button();
		button55 = new Button();
		button56 = new Button();
		button57 = new Button();
		button58 = new Button();
		button59 = new Button();
		notifyIcon1 = new NotifyIcon(components);
		MenuNotify = new ContextMenuStrip(components);
		toolStripMenuItem_56 = new ToolStripMenuItem();
		toolStripMenuItem_47 = new ToolStripMenuItem();
		toolStripMenuItem_54 = new ToolStripMenuItem();
		toolStripMenuItem_21 = new ToolStripMenuItem();
		toolStripMenuItem_7 = new ToolStripMenuItem();
		toolStripMenuItem_8 = new ToolStripMenuItem();
		label26 = new Label();
		listBox4 = new ListBox();
		tabPage1 = new TabPage();
		label28 = new Label();
		label29 = new Label();
		label30 = new Label();
		label31 = new Label();
		comboBox1 = new ComboBox();
		label32 = new Label();
		checkBox4 = new CheckBox();
		label33 = new Label();
		listView1 = new ListView();
		columnHeader67 = new ColumnHeader();
		columnHeader68 = new ColumnHeader();
		columnHeader69 = new ColumnHeader();
		columnHeader70 = new ColumnHeader();
		columnHeader71 = new ColumnHeader();
		columnHeader72 = new ColumnHeader();
		columnHeader73 = new ColumnHeader();
		label34 = new Label();
		label35 = new Label();
		label36 = new Label();
		listView2 = new ListView();
		columnHeader74 = new ColumnHeader();
		columnHeader75 = new ColumnHeader();
		columnHeader76 = new ColumnHeader();
		columnHeader77 = new ColumnHeader();
		columnHeader78 = new ColumnHeader();
		columnHeader79 = new ColumnHeader();
		columnHeader80 = new ColumnHeader();
		columnHeader81 = new ColumnHeader();
		columnHeader82 = new ColumnHeader();
		listView3 = new ListView();
		columnHeader83 = new ColumnHeader();
		columnHeader84 = new ColumnHeader();
		columnHeader85 = new ColumnHeader();
		columnHeader86 = new ColumnHeader();
		columnHeader87 = new ColumnHeader();
		columnHeader88 = new ColumnHeader();
		columnHeader89 = new ColumnHeader();
		columnHeader90 = new ColumnHeader();
		tabPage2 = new TabPage();
		label37 = new Label();
		listView4 = new ListView();
		columnHeader91 = new ColumnHeader();
		columnHeader92 = new ColumnHeader();
		columnHeader93 = new ColumnHeader();
		columnHeader94 = new ColumnHeader();
		comboBox2 = new ComboBox();
		comboBox3 = new ComboBox();
		listView5 = new ListView();
		columnHeader95 = new ColumnHeader();
		columnHeader96 = new ColumnHeader();
		columnHeader97 = new ColumnHeader();
		columnHeader98 = new ColumnHeader();
		columnHeader99 = new ColumnHeader();
		columnHeader100 = new ColumnHeader();
		columnHeader101 = new ColumnHeader();
		columnHeader102 = new ColumnHeader();
		columnHeader103 = new ColumnHeader();
		tabPage3 = new TabPage();
		label38 = new Label();
		tabPage4 = new TabPage();
		checkBox5 = new CheckBox();
		checkBox6 = new CheckBox();
		checkBox7 = new CheckBox();
		tabControl4 = new TabControl();
		tabPage5 = new TabPage();
		label39 = new Label();
		listBox6 = new ListBox();
		label40 = new Label();
		listBox7 = new ListBox();
		tabPage6 = new TabPage();
		label41 = new Label();
		label42 = new Label();
		label43 = new Label();
		label44 = new Label();
		label45 = new Label();
		label46 = new Label();
		listView6 = new ListView();
		columnHeader104 = new ColumnHeader();
		columnHeader105 = new ColumnHeader();
		columnHeader106 = new ColumnHeader();
		columnHeader107 = new ColumnHeader();
		columnHeader108 = new ColumnHeader();
		columnHeader109 = new ColumnHeader();
		columnHeader110 = new ColumnHeader();
		columnHeader111 = new ColumnHeader();
		columnHeader112 = new ColumnHeader();
		listView7 = new ListView();
		columnHeader113 = new ColumnHeader();
		columnHeader114 = new ColumnHeader();
		columnHeader115 = new ColumnHeader();
		columnHeader116 = new ColumnHeader();
		columnHeader117 = new ColumnHeader();
		columnHeader118 = new ColumnHeader();
		columnHeader119 = new ColumnHeader();
		columnHeader120 = new ColumnHeader();
		tabPage7 = new TabPage();
		listView8 = new ListView();
		columnHeader121 = new ColumnHeader();
		columnHeader122 = new ColumnHeader();
		columnHeader123 = new ColumnHeader();
		columnHeader124 = new ColumnHeader();
		columnHeader125 = new ColumnHeader();
		columnHeader126 = new ColumnHeader();
		columnHeader127 = new ColumnHeader();
		columnHeader128 = new ColumnHeader();
		columnHeader129 = new ColumnHeader();
		columnHeader130 = new ColumnHeader();
		label47 = new Label();
		pictureBox3 = new PictureBox();
		listBox8 = new ListBox();
		label48 = new Label();
		pictureBox4 = new PictureBox();
		listBox9 = new ListBox();
		label49 = new Label();
		textBox2 = new TextBox();
		tabPage8 = new TabPage();
		label50 = new Label();
		openFileDialog1 = new OpenFileDialog();
		checkBoxLoginPark = new CheckBox();
		checkBoxLoginFriend = new CheckBox();
		tabPage14 = new TabPage();
		label69 = new Label();
		label70 = new Label();
		label71 = new Label();
		label72 = new Label();
		comboBox4 = new ComboBox();
		label73 = new Label();
		checkBox8 = new CheckBox();
		label74 = new Label();
		listView9 = new ListView();
		columnHeader168 = new ColumnHeader();
		columnHeader169 = new ColumnHeader();
		columnHeader170 = new ColumnHeader();
		columnHeader171 = new ColumnHeader();
		columnHeader172 = new ColumnHeader();
		columnHeader173 = new ColumnHeader();
		columnHeader174 = new ColumnHeader();
		label75 = new Label();
		label76 = new Label();
		label77 = new Label();
		listView10 = new ListView();
		columnHeader175 = new ColumnHeader();
		columnHeader176 = new ColumnHeader();
		columnHeader177 = new ColumnHeader();
		columnHeader178 = new ColumnHeader();
		columnHeader179 = new ColumnHeader();
		columnHeader180 = new ColumnHeader();
		columnHeader181 = new ColumnHeader();
		columnHeader182 = new ColumnHeader();
		columnHeader183 = new ColumnHeader();
		listView11 = new ListView();
		columnHeader184 = new ColumnHeader();
		columnHeader185 = new ColumnHeader();
		columnHeader186 = new ColumnHeader();
		columnHeader187 = new ColumnHeader();
		columnHeader188 = new ColumnHeader();
		columnHeader189 = new ColumnHeader();
		columnHeader190 = new ColumnHeader();
		columnHeader191 = new ColumnHeader();
		tabPage15 = new TabPage();
		label78 = new Label();
		label79 = new Label();
		label80 = new Label();
		label81 = new Label();
		label82 = new Label();
		label83 = new Label();
		label84 = new Label();
		label85 = new Label();
		listView12 = new ListView();
		columnHeader192 = new ColumnHeader();
		columnHeader193 = new ColumnHeader();
		columnHeader194 = new ColumnHeader();
		columnHeader195 = new ColumnHeader();
		columnHeader196 = new ColumnHeader();
		columnHeader197 = new ColumnHeader();
		columnHeader198 = new ColumnHeader();
		columnHeader199 = new ColumnHeader();
		columnHeader200 = new ColumnHeader();
		listView13 = new ListView();
		columnHeader201 = new ColumnHeader();
		columnHeader202 = new ColumnHeader();
		columnHeader203 = new ColumnHeader();
		columnHeader204 = new ColumnHeader();
		columnHeader205 = new ColumnHeader();
		columnHeader206 = new ColumnHeader();
		columnHeader207 = new ColumnHeader();
		columnHeader208 = new ColumnHeader();
		label86 = new Label();
		textBox4 = new TextBox();
		tabPage16 = new TabPage();
		label87 = new Label();
		label88 = new Label();
		checkBox10 = new CheckBox();
		label89 = new Label();
		listView14 = new ListView();
		columnHeader209 = new ColumnHeader();
		columnHeader210 = new ColumnHeader();
		columnHeader211 = new ColumnHeader();
		columnHeader212 = new ColumnHeader();
		columnHeader213 = new ColumnHeader();
		columnHeader214 = new ColumnHeader();
		comboBox5 = new ComboBox();
		comboBox6 = new ComboBox();
		listView15 = new ListView();
		columnHeader215 = new ColumnHeader();
		columnHeader216 = new ColumnHeader();
		columnHeader217 = new ColumnHeader();
		columnHeader218 = new ColumnHeader();
		columnHeader219 = new ColumnHeader();
		columnHeader220 = new ColumnHeader();
		columnHeader221 = new ColumnHeader();
		columnHeader222 = new ColumnHeader();
		columnHeader223 = new ColumnHeader();
		tabPage17 = new TabPage();
		label90 = new Label();
		tabPage18 = new TabPage();
		textBox5 = new TextBox();
		tabPage19 = new TabPage();
		textBox6 = new TextBox();
		tabControl6 = new TabControl();
		tabPageLogin = new TabPage();
		groupBox1 = new GroupBox();
		checkBox_1 = new CheckBox();
		tabPageHaveLogin = new TabPage();
		label119 = new Label();
		label118 = new Label();
		checkBox31 = new CheckBox();
		checkBox32 = new CheckBox();
		comboBox25 = new ComboBox();
		comboBox26 = new ComboBox();
		comboBox27 = new ComboBox();
		comboBox28 = new ComboBox();
		checkBox33 = new CheckBox();
		checkBox34 = new CheckBox();
		comboBox29 = new ComboBox();
		comboBox30 = new ComboBox();
		checkBox35 = new CheckBox();
		checkBox36 = new CheckBox();
		comboBox31 = new ComboBox();
		comboBox32 = new ComboBox();
		checkBox37 = new CheckBox();
		checkBox38 = new CheckBox();
		comboBox33 = new ComboBox();
		comboBox34 = new ComboBox();
		checkBox39 = new CheckBox();
		checkBox40 = new CheckBox();
		comboBox35 = new ComboBox();
		comboBox36 = new ComboBox();
		checkBox41 = new CheckBox();
		checkBox42 = new CheckBox();
		comboBox37 = new ComboBox();
		comboBox38 = new ComboBox();
		checkBox43 = new CheckBox();
		checkBox44 = new CheckBox();
		comboBox39 = new ComboBox();
		comboBox40 = new ComboBox();
		checkBox45 = new CheckBox();
		checkBox46 = new CheckBox();
		comboBox41 = new ComboBox();
		comboBox42 = new ComboBox();
		checkBox47 = new CheckBox();
		checkBox48 = new CheckBox();
		label105 = new Label();
		textBox12 = new TextBox();
		label106 = new Label();
		label107 = new Label();
		textBox13 = new TextBox();
		label108 = new Label();
		label109 = new Label();
		label110 = new Label();
		button70 = new Button();
		textBox14 = new TextBox();
		label111 = new Label();
		checkBox49 = new CheckBox();
		textBox15 = new TextBox();
		label112 = new Label();
		checkBox50 = new CheckBox();
		label113 = new Label();
		textBox16 = new TextBox();
		label114 = new Label();
		label115 = new Label();
		listView17 = new ListView();
		columnHeader233 = new ColumnHeader();
		columnHeader234 = new ColumnHeader();
		button71 = new Button();
		button72 = new Button();
		button73 = new Button();
		saveFileDialog1 = new SaveFileDialog();
		((Control)menuStrip1).SuspendLayout();
		((Control)contextMenuStrip1).SuspendLayout();
		((Control)tabControl1).SuspendLayout();
		((Control)tabPageZhzx).SuspendLayout();
		((Control)tabPageParks).SuspendLayout();
		((Control)tabControl3).SuspendLayout();
		((Control)tabPagePark).SuspendLayout();
		((Control)tabPageJubao).SuspendLayout();
		((Control)tabControl10).SuspendLayout();
		((Control)tabPage27).SuspendLayout();
		((Control)tabPage28).SuspendLayout();
		((Control)tabPageCheshi).SuspendLayout();
		((Control)tabPageJiaoben).SuspendLayout();
		((Control)tabControl7).SuspendLayout();
		((Control)tabPage22).SuspendLayout();
		((Control)contextMenuStrip2).SuspendLayout();
		((Control)tabPage23).SuspendLayout();
		((Control)tabPageWoDeCheZiJinKuang).SuspendLayout();
		((Control)tabPage20).SuspendLayout();
		((Control)tabPage21).SuspendLayout();
		((Control)tabPageFriendBuy).SuspendLayout();
		((Control)tabControl5).SuspendLayout();
		((Control)tabPageShiJian).SuspendLayout();
		((Control)tabPageJilu).SuspendLayout();
		((Control)tabControl9).SuspendLayout();
		((Control)tabPage24).SuspendLayout();
		((Control)tabPage25).SuspendLayout();
		((Control)tabPage26).SuspendLayout();
		((Control)tabPageQueryFriend).SuspendLayout();
		((Control)tabControl2).SuspendLayout();
		((Control)tabPageJinBen).SuspendLayout();
		((Control)tabPageQueryPark).SuspendLayout();
		((Control)tabPageQueryQQBuyFriend).SuspendLayout();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)tabPage9).SuspendLayout();
		((ISupportInitialize)pictureBox5).BeginInit();
		((Control)contextMenuStrip4).SuspendLayout();
		((Control)tabPage10).SuspendLayout();
		((ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
		((Control)contextMenuStrip3).SuspendLayout();
		((Control)tabPage11).SuspendLayout();
		((Control)tabPageXi).SuspendLayout();
		((Control)tabPageZone).SuspendLayout();
		((Control)tabControl8).SuspendLayout();
		((Control)tabPage12).SuspendLayout();
		((Control)contextMenuStrip5).SuspendLayout();
		((Control)tabPage13).SuspendLayout();
		((Control)tabPageCity).SuspendLayout();
		((ISupportInitialize)pictureBoxCity).BeginInit();
		((Control)toolStrip1).SuspendLayout();
		((Control)statusStrip1).SuspendLayout();
		((ISupportInitialize)pictureBoxValidate).BeginInit();
		((Control)MenuNotify).SuspendLayout();
		((Control)tabPage1).SuspendLayout();
		((Control)tabPage2).SuspendLayout();
		((Control)tabPage3).SuspendLayout();
		((Control)tabPage4).SuspendLayout();
		((Control)tabControl4).SuspendLayout();
		((Control)tabPage5).SuspendLayout();
		((Control)tabPage6).SuspendLayout();
		((Control)tabPage7).SuspendLayout();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox4).BeginInit();
		((Control)tabPage8).SuspendLayout();
		((Control)tabPage14).SuspendLayout();
		((Control)tabPage15).SuspendLayout();
		((Control)tabPage16).SuspendLayout();
		((Control)tabPage17).SuspendLayout();
		((Control)tabPage18).SuspendLayout();
		((Control)tabPage19).SuspendLayout();
		((Control)tabControl6).SuspendLayout();
		((Control)tabPageLogin).SuspendLayout();
		((Control)groupBox1).SuspendLayout();
		((Control)tabPageHaveLogin).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)menuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)toolStripMenuItem_0,
			(ToolStripItem)toolStripMenuItem_2,
			(ToolStripItem)toolStripMenuItem_4,
			(ToolStripItem)toolStripMenuItem_23
		});
		((Control)menuStrip1).set_Location(new Point(0, 0));
		((Control)menuStrip1).set_Name("menuStrip1");
		((Control)menuStrip1).set_Size(new Size(988, 24));
		((Control)menuStrip1).set_TabIndex(0);
		((Control)menuStrip1).set_Text("menuStrip1");
		((ToolStripDropDownItem)toolStripMenuItem_0).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)toolStripMenuItem_55,
			(ToolStripItem)toolStripMenuItem_46,
			(ToolStripItem)toolStripMenuItem_53,
			(ToolStripItem)toolStripMenuItem_1
		});
		((ToolStripItem)toolStripMenuItem_0).set_Name("文件ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_0).set_Size(new Size(41, 20));
		((ToolStripItem)toolStripMenuItem_0).set_Text("文件");
		((ToolStripItem)toolStripMenuItem_55).set_Name("检测新版本ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_55).set_Size(new Size(166, 22));
		((ToolStripItem)toolStripMenuItem_55).set_Text("检测新版本");
		((ToolStripItem)toolStripMenuItem_55).add_Click((EventHandler)toolStripMenuItem_55_Click);
		((ToolStripItem)toolStripMenuItem_46).set_Name("去作者的网盘下载ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_46).set_Size(new Size(166, 22));
		((ToolStripItem)toolStripMenuItem_46).set_Text("去作者的网盘下载");
		((ToolStripItem)toolStripMenuItem_46).add_Click((EventHandler)toolStripMenuItem_46_Click);
		((ToolStripItem)toolStripMenuItem_53).set_Name("备用网盘ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_53).set_Size(new Size(166, 22));
		((ToolStripItem)toolStripMenuItem_53).set_Text("备用网盘");
		((ToolStripItem)toolStripMenuItem_53).add_Click((EventHandler)toolStripMenuItem_53_Click);
		((ToolStripItem)toolStripMenuItem_1).set_Name("退出ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_1).set_Size(new Size(166, 22));
		((ToolStripItem)toolStripMenuItem_1).set_Text("退出");
		((ToolStripItem)toolStripMenuItem_1).add_Click((EventHandler)toolStripMenuItem_1_Click);
		((ToolStripDropDownItem)toolStripMenuItem_2).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)toolStripMenuItem_3,
			(ToolStripItem)toolStripMenuItem_50,
			(ToolStripItem)toolStripMenuItem_51,
			(ToolStripItem)toolStripMenuItem_52
		});
		((ToolStripItem)toolStripMenuItem_2).set_Name("工具ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_2).set_Size(new Size(41, 20));
		((ToolStripItem)toolStripMenuItem_2).set_Text("工具");
		((ToolStripItem)toolStripMenuItem_3).set_Name("刷新ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_3).set_Size(new Size(238, 22));
		((ToolStripItem)toolStripMenuItem_3).set_Text("刷新");
		((ToolStripItem)toolStripMenuItem_3).add_Click((EventHandler)toolStripMenuItem_3_Click);
		((ToolStripItem)toolStripMenuItem_50).set_Name("锁定程序ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_50).set_Size(new Size(238, 22));
		((ToolStripItem)toolStripMenuItem_50).set_Text("锁定程序");
		((ToolStripItem)toolStripMenuItem_50).add_Click((EventHandler)toolStripMenuItem_50_Click);
		((ToolStripItem)toolStripMenuItem_51).set_Name("修改密码ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_51).set_Size(new Size(238, 22));
		((ToolStripItem)toolStripMenuItem_51).set_Text("修改密码");
		((ToolStripItem)toolStripMenuItem_51).add_Click((EventHandler)toolStripMenuItem_51_Click);
		((ToolStripItem)toolStripMenuItem_52).set_Name("显示界面当控件看不到时使用ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_52).set_Size(new Size(238, 22));
		((ToolStripItem)toolStripMenuItem_52).set_Text("界面复位[当控件看不到时使用]");
		((ToolStripItem)toolStripMenuItem_52).add_Click((EventHandler)toolStripMenuItem_52_Click);
		((ToolStripDropDownItem)toolStripMenuItem_4).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)toolStripMenuItem_9,
			(ToolStripItem)toolStripMenuItem_18,
			(ToolStripItem)toolStripMenuItem_5,
			(ToolStripItem)toolStripMenuItem_6
		});
		((ToolStripItem)toolStripMenuItem_4).set_Name("关于ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_4).set_Size(new Size(41, 20));
		((ToolStripItem)toolStripMenuItem_4).set_Text("关于");
		((ToolStripItem)toolStripMenuItem_9).set_Name("官方论坛ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_9).set_Size(new Size(160, 22));
		((ToolStripItem)toolStripMenuItem_9).set_Text("官方论坛");
		((ToolStripItem)toolStripMenuItem_9).add_Click((EventHandler)toolStripMenuItem_9_Click);
		((ToolStripItem)toolStripMenuItem_18).set_Name("举报Bug和建议ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_18).set_Size(new Size(160, 22));
		((ToolStripItem)toolStripMenuItem_18).set_Text("举报Bug和建议");
		((ToolStripItem)toolStripMenuItem_18).add_Click((EventHandler)toolStripMenuItem_18_Click);
		((ToolStripItem)toolStripMenuItem_5).set_Name("帮助ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_5).set_Size(new Size(160, 22));
		((ToolStripItem)toolStripMenuItem_5).set_Text("帮助");
		((ToolStripItem)toolStripMenuItem_5).add_Click((EventHandler)toolStripMenuItem_5_Click);
		((ToolStripItem)toolStripMenuItem_6).set_Name("关于QQParkToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_6).set_Size(new Size(160, 22));
		((ToolStripItem)toolStripMenuItem_6).set_Text("关于 QQ捕快2009");
		((ToolStripItem)toolStripMenuItem_6).add_Click((EventHandler)toolStripMenuItem_6_Click);
		((ToolStripItem)toolStripMenuItem_23).set_Name("软件更新toolStripMenuItem3");
		((ToolStripItem)toolStripMenuItem_23).set_Size(new Size(65, 20));
		((ToolStripItem)toolStripMenuItem_23).set_Text("软件更新");
		((ToolStripItem)toolStripMenuItem_23).add_Click((EventHandler)toolStripMenuItem_23_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label1).set_ForeColor(Color.Blue);
		((Control)label1).set_Location(new Point(8, 83));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(53, 12));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("QQ号码：");
		((Control)buttonTxt).set_ForeColor(Color.Black);
		((Control)buttonTxt).set_Location(new Point(15, 8));
		((Control)buttonTxt).set_Name("buttonTxt");
		((Control)buttonTxt).set_Size(new Size(162, 28));
		((Control)buttonTxt).set_TabIndex(8);
		((Control)buttonTxt).set_Text("导入Txt文件QQ账号");
		toolTipAll.SetToolTip((Control)(object)buttonTxt, "导入Txt中的QQ账号，Txt格式为每行一个QQ号码和密码，QQ号码和密码以空格或者----间隔");
		((ButtonBase)buttonTxt).set_UseVisualStyleBackColor(true);
		((Control)buttonTxt).add_Click((EventHandler)buttonTxt_Click);
		((Control)buttonLogin).set_Location(new Point(15, 294));
		((Control)buttonLogin).set_Name("buttonLogin");
		((Control)buttonLogin).set_Size(new Size(162, 33));
		((Control)buttonLogin).set_TabIndex(4);
		((Control)buttonLogin).set_Text("登录");
		toolTipAll.SetToolTip((Control)(object)buttonLogin, "登入QQ相关模块");
		((ButtonBase)buttonLogin).set_UseVisualStyleBackColor(true);
		((Control)buttonLogin).add_Click((EventHandler)buttonLogin_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label3).set_ForeColor(Color.Blue);
		((Control)label3).set_Location(new Point(8, 187));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(53, 12));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("验证码：");
		((Control)textValidate).set_Location(new Point(13, 205));
		((Control)textValidate).set_Name("textValidate");
		((Control)textValidate).set_Size(new Size(166, 21));
		((Control)textValidate).set_TabIndex(3);
		((Control)textValidate).add_TextChanged((EventHandler)textValidate_TextChanged);
		((Control)textValidate).add_KeyDown(new KeyEventHandler(textValidate_KeyDown));
		((Control)checkMark).set_AutoSize(true);
		((Control)checkMark).set_Location(new Point(77, 134));
		((Control)checkMark).set_Name("checkMark");
		((Control)checkMark).set_Size(new Size(108, 16));
		((Control)checkMark).set_TabIndex(4);
		((Control)checkMark).set_Text("记住号码和密码");
		((ButtonBase)checkMark).set_UseVisualStyleBackColor(true);
		checkMark.add_CheckedChanged((EventHandler)checkMark_CheckedChanged);
		((Control)buttonDelete).set_Location(new Point(154, 78));
		((Control)buttonDelete).set_Name("buttonDelete");
		((Control)buttonDelete).set_Size(new Size(23, 23));
		((Control)buttonDelete).set_TabIndex(4);
		((Control)buttonDelete).set_Text("删");
		toolTipAll.SetToolTip((Control)(object)buttonDelete, "删除QQ号码");
		((ButtonBase)buttonDelete).set_UseVisualStyleBackColor(true);
		((Control)buttonDelete).add_Click((EventHandler)buttonDelete_Click);
		comboQQNum.set_DropDownHeight(400);
		((ListControl)comboQQNum).set_FormattingEnabled(true);
		comboQQNum.set_IntegralHeight(false);
		((Control)comboQQNum).set_Location(new Point(13, 107));
		((Control)comboQQNum).set_Name("comboQQNum");
		((Control)comboQQNum).set_Size(new Size(166, 20));
		((Control)comboQQNum).set_TabIndex(1);
		comboQQNum.add_SelectedIndexChanged((EventHandler)comboQQNum_SelectedIndexChanged);
		((Control)comboQQNum).add_KeyDown(new KeyEventHandler(comboQQNum_KeyDown));
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label2).set_ForeColor(Color.Blue);
		((Control)label2).set_Location(new Point(8, 135));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(53, 12));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("QQ密码：");
		((Control)textQQPass).set_Location(new Point(13, 155));
		((Control)textQQPass).set_Name("textQQPass");
		textQQPass.set_PasswordChar('*');
		((Control)textQQPass).set_Size(new Size(166, 21));
		((Control)textQQPass).set_TabIndex(2);
		((Control)textQQPass).add_KeyDown(new KeyEventHandler(textQQPass_KeyDown));
		((Control)listUser).set_Anchor((AnchorStyles)7);
		listUser.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { columnHeader25, columnHeader26 });
		((Control)listUser).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listUser).set_Cursor(Cursors.get_Default());
		((Control)listUser).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listUser.set_FullRowSelect(true);
		listUser.set_GridLines(true);
		((Control)listUser).set_Location(new Point(3, 58));
		listUser.set_MultiSelect(false);
		((Control)listUser).set_Name("listUser");
		((Control)listUser).set_Size(new Size(189, 493));
		((Control)listUser).set_TabIndex(18);
		listUser.set_UseCompatibleStateImageBehavior(false);
		listUser.set_View((View)1);
		((Control)listUser).add_DoubleClick((EventHandler)listUser_DoubleClick);
		((Control)listUser).add_MouseUp(new MouseEventHandler(listUser_MouseUp));
		listUser.add_ColumnClick(new ColumnClickEventHandler(listUser_ColumnClick));
		columnHeader25.set_Text("QQ号码");
		columnHeader25.set_Width(71);
		columnHeader26.set_Text("昵称");
		columnHeader26.set_Width(95);
		((ToolStrip)contextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[20]
		{
			(ToolStripItem)toolStripMenuItem_10,
			(ToolStripItem)toolStripMenuItem_16,
			(ToolStripItem)toolStripMenuItem_48,
			(ToolStripItem)toolStripMenuItem_49,
			(ToolStripItem)toolStripMenuItem5,
			(ToolStripItem)toolStripMenuItem_17,
			(ToolStripItem)toolStripMenuItem_22,
			(ToolStripItem)toolStripMenuItem_44,
			(ToolStripItem)toolStripMenuItem_27,
			(ToolStripItem)toolStripMenuItem1,
			(ToolStripItem)toolStripMenuItem_13,
			(ToolStripItem)toolStripMenuItem_26,
			(ToolStripItem)toolStripMenuItem_19,
			(ToolStripItem)toolStripMenuItem_15,
			(ToolStripItem)toolStripMenuItem_11,
			(ToolStripItem)toolStripMenuItem_12,
			(ToolStripItem)toolStripMenuItem_14,
			(ToolStripItem)toolStripMenuItem2,
			(ToolStripItem)toolStripMenuItem_20,
			(ToolStripItem)toolStripMenuItem_24
		});
		((Control)contextMenuStrip1).set_Name("contextMenuStrip1");
		((Control)contextMenuStrip1).set_Size(new Size(173, 396));
		((ToolStripItem)toolStripMenuItem_10).set_Name("复制QQToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_10).set_Size(new Size(172, 22));
		((ToolStripItem)toolStripMenuItem_10).set_Text("复制QQ号");
		((ToolStripItem)toolStripMenuItem_10).add_Click((EventHandler)toolStripMenuItem_10_Click);
		((ToolStripItem)toolStripMenuItem_16).set_Name("综合查询ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_16).set_Size(new Size(172, 22));
		((ToolStripItem)toolStripMenuItem_16).set_Text("综合查询");
		((ToolStripItem)toolStripMenuItem_16).add_Click((EventHandler)toolStripMenuItem_16_Click);
		((ToolStripItem)toolStripMenuItem_48).set_Name("加为QQ好友ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_48).set_Size(new Size(172, 22));
		((ToolStripItem)toolStripMenuItem_48).set_Text("加为QQ好友");
		((ToolStripItem)toolStripMenuItem_48).add_Click((EventHandler)toolStripMenuItem_48_Click);
		((ToolStripItem)toolStripMenuItem_49).set_Name("与TA临时会话ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_49).set_Size(new Size(172, 22));
		((ToolStripItem)toolStripMenuItem_49).set_Text("与TA临时会话");
		((ToolStripItem)toolStripMenuItem_49).add_Click((EventHandler)toolStripMenuItem_49_Click);
		((ToolStripItem)toolStripMenuItem5).set_Name("toolStripMenuItem5");
		((ToolStripItem)toolStripMenuItem5).set_Size(new Size(169, 6));
		((ToolStripItem)toolStripMenuItem_17).set_Name("举报ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_17).set_Size(new Size(172, 22));
		((ToolStripItem)toolStripMenuItem_17).set_Text("举报TA");
		((ToolStripItem)toolStripMenuItem_17).add_Click((EventHandler)toolStripMenuItem_17_Click);
		((ToolStripItem)toolStripMenuItem_22).set_Name("查看TA的停车记录ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_22).set_Size(new Size(172, 22));
		((ToolStripItem)toolStripMenuItem_22).set_Text("查看TA的停车记录");
		((ToolStripItem)toolStripMenuItem_22).add_Click((EventHandler)toolStripMenuItem_22_Click);
		((ToolStripItem)toolStripMenuItem_44).set_Name("查看TAQzone日子ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_44).set_Size(new Size(172, 22));
		((ToolStripItem)toolStripMenuItem_44).set_Text("查看TA的Qzone日志");
		((ToolStripItem)toolStripMenuItem_44).add_Click((EventHandler)toolStripMenuItem_44_Click);
		((ToolStripDropDownItem)toolStripMenuItem_27).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)toolStripMenuItem_28,
			(ToolStripItem)toolStripMenuItem_29,
			(ToolStripItem)toolStripMenuItem_30,
			(ToolStripItem)toolStripMenuItem_31,
			(ToolStripItem)toolStripMenuItem_32,
			(ToolStripItem)toolStripMenuItem_33
		});
		((ToolStripItem)toolStripMenuItem_27).set_Name("在浏览器中打开ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_27).set_Size(new Size(172, 22));
		((ToolStripItem)toolStripMenuItem_27).set_Text("在浏览器中打开");
		((ToolStripItem)toolStripMenuItem_28).set_Name("QQ空间ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_28).set_Size(new Size(118, 22));
		((ToolStripItem)toolStripMenuItem_28).set_Text("QQ空间");
		((ToolStripItem)toolStripMenuItem_28).add_Click((EventHandler)toolStripMenuItem_28_Click);
		((ToolStripItem)toolStripMenuItem_29).set_Name("QQ相册ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_29).set_Size(new Size(118, 22));
		((ToolStripItem)toolStripMenuItem_29).set_Text("QQ相册");
		((ToolStripItem)toolStripMenuItem_29).add_Click((EventHandler)toolStripMenuItem_29_Click);
		((ToolStripItem)toolStripMenuItem_30).set_Name("城市达人ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_30).set_Size(new Size(118, 22));
		((ToolStripItem)toolStripMenuItem_30).set_Text("城市达人");
		((ToolStripItem)toolStripMenuItem_30).add_Click((EventHandler)toolStripMenuItem_30_Click);
		((ToolStripItem)toolStripMenuItem_31).set_Name("交友中心ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_31).set_Size(new Size(118, 22));
		((ToolStripItem)toolStripMenuItem_31).set_Text("交友中心");
		((ToolStripItem)toolStripMenuItem_31).add_Click((EventHandler)toolStripMenuItem_31_Click);
		((ToolStripItem)toolStripMenuItem_32).set_Name("问问ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_32).set_Size(new Size(118, 22));
		((ToolStripItem)toolStripMenuItem_32).set_Text("问问");
		((ToolStripItem)toolStripMenuItem_32).add_Click((EventHandler)toolStripMenuItem_32_Click);
		((ToolStripItem)toolStripMenuItem_33).set_Name("Q吧社区ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_33).set_Size(new Size(118, 22));
		((ToolStripItem)toolStripMenuItem_33).set_Text("Q吧社区");
		((ToolStripItem)toolStripMenuItem_33).add_Click((EventHandler)toolStripMenuItem_33_Click);
		((ToolStripItem)toolStripMenuItem1).set_Name("toolStripMenuItem1");
		((ToolStripItem)toolStripMenuItem1).set_Size(new Size(169, 6));
		((ToolStripItem)toolStripMenuItem_13).set_Name("停车ToolStripMenuItem1");
		((ToolStripItem)toolStripMenuItem_13).set_Size(new Size(172, 22));
		((ToolStripItem)toolStripMenuItem_13).set_Text("停车");
		((ToolStripItem)toolStripMenuItem_13).add_Click((EventHandler)toolStripMenuItem_13_Click);
		((ToolStripItem)toolStripMenuItem_26).set_Name("停车爱心车位ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_26).set_Size(new Size(172, 22));
		((ToolStripItem)toolStripMenuItem_26).set_Text("停车[爱心车位]");
		((ToolStripItem)toolStripMenuItem_26).add_Click((EventHandler)toolStripMenuItem_26_Click);
		((ToolStripItem)toolStripMenuItem_19).set_Name("批量停车ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_19).set_Size(new Size(172, 22));
		((ToolStripItem)toolStripMenuItem_19).set_Text("批量停车");
		((ToolStripItem)toolStripMenuItem_19).add_Click((EventHandler)toolStripMenuItem_19_Click);
		((ToolStripItem)toolStripMenuItem_15).set_Name("过渡停车ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_15).set_Size(new Size(172, 22));
		((ToolStripItem)toolStripMenuItem_15).set_Text("过渡停车");
		((ToolStripItem)toolStripMenuItem_15).add_Click((EventHandler)toolStripMenuItem_15_Click);
		((ToolStripItem)toolStripMenuItem_11).set_Name("贴条ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_11).set_Size(new Size(172, 22));
		((ToolStripItem)toolStripMenuItem_11).set_Text("贴条");
		((ToolStripItem)toolStripMenuItem_11).add_Click((EventHandler)toolStripMenuItem_11_Click);
		((ToolStripItem)toolStripMenuItem_12).set_Name("买车ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_12).set_Size(new Size(172, 22));
		((ToolStripItem)toolStripMenuItem_12).set_Text("买车");
		((ToolStripItem)toolStripMenuItem_12).add_Click((EventHandler)toolStripMenuItem_12_Click);
		((ToolStripItem)toolStripMenuItem_14).set_Name("换车ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_14).set_Size(new Size(172, 22));
		((ToolStripItem)toolStripMenuItem_14).set_Text("换车");
		((ToolStripItem)toolStripMenuItem_14).add_Click((EventHandler)toolStripMenuItem_14_Click);
		((ToolStripItem)toolStripMenuItem2).set_Name("toolStripMenuItem2");
		((ToolStripItem)toolStripMenuItem2).set_Size(new Size(169, 6));
		((ToolStripItem)toolStripMenuItem_20).set_Name("购买奴隶ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_20).set_Size(new Size(172, 22));
		((ToolStripItem)toolStripMenuItem_20).set_Text("购买奴隶");
		((ToolStripItem)toolStripMenuItem_20).add_Click((EventHandler)toolStripMenuItem_20_Click);
		((ToolStripItem)toolStripMenuItem_24).set_Name("注销登录ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_24).set_Size(new Size(172, 22));
		((ToolStripItem)toolStripMenuItem_24).set_Text("注销登录");
		((ToolStripItem)toolStripMenuItem_24).add_Click((EventHandler)toolStripMenuItem_24_Click);
		((Control)tabControl1).set_Anchor((AnchorStyles)15);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPageZhzx);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPageParks);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPageFriendBuy);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPageQueryFriend);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPageXi);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPageZone);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPageCity);
		((Control)tabControl1).set_Location(new Point(206, 69));
		((Control)tabControl1).set_Name("tabControl1");
		tabControl1.set_SelectedIndex(0);
		((Control)tabControl1).set_Size(new Size(782, 572));
		((Control)tabControl1).set_TabIndex(19);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)button95);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)button96);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)checkBox_10);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)checkBox_11);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)checkBox_12);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)checkBox_9);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)label141);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)label142);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)textBox21);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)button_11);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)button_10);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)button_9);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)button_7);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)button_8);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)button_6);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)button_5);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)textBox_0);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)listView_1);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)label61);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)checkBox_7);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)checkBox_8);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)checkBox_3);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)checkBox_4);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)checkBox_5);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)checkBox_6);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)checkBox_2);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)listView_0);
		((Control)tabPageZhzx).get_Controls().Add((Control)(object)label60);
		tabPageZhzx.set_Location(new Point(4, 21));
		((Control)tabPageZhzx).set_Name("tabPageZhzx");
		((Control)tabPageZhzx).set_Size(new Size(774, 547));
		tabPageZhzx.set_TabIndex(14);
		((Control)tabPageZhzx).set_Text("大小号中心");
		tabPageZhzx.set_UseVisualStyleBackColor(true);
		((Control)button95).set_Location(new Point(610, 136));
		((Control)button95).set_Name("button95");
		((Control)button95).set_Size(new Size(20, 20));
		((Control)button95).set_TabIndex(164);
		((Control)button95).set_Text("√");
		toolTipAll.SetToolTip((Control)(object)button95, "全选");
		((ButtonBase)button95).set_UseVisualStyleBackColor(true);
		((Control)button95).add_Click((EventHandler)button95_Click);
		((Control)button96).set_Location(new Point(640, 136));
		((Control)button96).set_Name("button96");
		((Control)button96).set_Size(new Size(20, 20));
		((Control)button96).set_TabIndex(163);
		((Control)button96).set_Text("×");
		toolTipAll.SetToolTip((Control)(object)button96, "全不选");
		((ButtonBase)button96).set_UseVisualStyleBackColor(true);
		((Control)button96).add_Click((EventHandler)button96_Click);
		((Control)checkBox_10).set_AutoSize(true);
		((Control)checkBox_10).set_BackColor(Color.Transparent);
		((Control)checkBox_10).set_ForeColor(Color.Green);
		((Control)checkBox_10).set_Location(new Point(456, 177));
		((Control)checkBox_10).set_Name("checkBox开通好友买卖");
		((Control)checkBox_10).set_Size(new Size(96, 16));
		((Control)checkBox_10).set_TabIndex(162);
		((Control)checkBox_10).set_Text("开通好友买卖");
		((ButtonBase)checkBox_10).set_UseVisualStyleBackColor(false);
		checkBox_10.add_CheckedChanged((EventHandler)checkBox_10_CheckedChanged);
		((Control)checkBox_11).set_AutoSize(true);
		((Control)checkBox_11).set_BackColor(Color.Transparent);
		((Control)checkBox_11).set_ForeColor(Color.Green);
		((Control)checkBox_11).set_Location(new Point(456, 151));
		((Control)checkBox_11).set_Name("checkBox开通抢车位");
		((Control)checkBox_11).set_Size(new Size(84, 16));
		((Control)checkBox_11).set_TabIndex(161);
		((Control)checkBox_11).set_Text("开通抢车位");
		((ButtonBase)checkBox_11).set_UseVisualStyleBackColor(false);
		checkBox_11.add_CheckedChanged((EventHandler)checkBox_11_CheckedChanged);
		((Control)checkBox_12).set_AutoSize(true);
		((Control)checkBox_12).set_BackColor(Color.Transparent);
		((Control)checkBox_12).set_ForeColor(Color.Green);
		((Control)checkBox_12).set_Location(new Point(456, 125));
		((Control)checkBox_12).set_Name("checkBox开通花藤");
		((Control)checkBox_12).set_Size(new Size(72, 16));
		((Control)checkBox_12).set_TabIndex(160);
		((Control)checkBox_12).set_Text("开通花藤");
		((ButtonBase)checkBox_12).set_UseVisualStyleBackColor(false);
		checkBox_12.add_CheckedChanged((EventHandler)checkBox_12_CheckedChanged);
		((Control)checkBox_9).set_AutoSize(true);
		((Control)checkBox_9).set_BackColor(Color.Transparent);
		((Control)checkBox_9).set_ForeColor(Color.Blue);
		((Control)checkBox_9).set_Location(new Point(611, 99));
		((Control)checkBox_9).set_Name("checkBox宝宝乐园开蛋");
		((Control)checkBox_9).set_Size(new Size(96, 16));
		((Control)checkBox_9).set_TabIndex(159);
		((Control)checkBox_9).set_Text("宝宝乐园开蛋");
		((ButtonBase)checkBox_9).set_UseVisualStyleBackColor(false);
		checkBox_9.add_CheckedChanged((EventHandler)checkBox_9_CheckedChanged);
		((Control)label141).set_ForeColor(Color.Blue);
		((Control)label141).set_Location(new Point(710, 205));
		((Control)label141).set_Name("label141");
		((Control)label141).set_Size(new Size(46, 18));
		((Control)label141).set_TabIndex(158);
		((Control)label141).set_Text("1-100");
		((Control)label142).set_AutoSize(true);
		((Control)label142).set_ForeColor(Color.Red);
		((Control)label142).set_Location(new Point(463, 207));
		((Control)label142).set_Name("label142");
		((Control)label142).set_Size(new Size(101, 12));
		((Control)label142).set_TabIndex(157);
		((Control)label142).set_Text("QQ空间访问次数：");
		((Control)textBox21).set_ForeColor(Color.Black);
		((Control)textBox21).set_Location(new Point(570, 202));
		((Control)textBox21).set_Name("textBox21");
		((Control)textBox21).set_Size(new Size(134, 21));
		((Control)textBox21).set_TabIndex(156);
		((Control)button_11).set_Anchor((AnchorStyles)9);
		((Control)button_11).set_Location(new Point(684, 233));
		((Control)button_11).set_Name("button停止");
		((Control)button_11).set_Size(new Size(44, 20));
		((Control)button_11).set_TabIndex(151);
		((Control)button_11).set_Text("停止");
		toolTipAll.SetToolTip((Control)(object)button_11, "停止执行所有勾选的小号");
		((ButtonBase)button_11).set_UseVisualStyleBackColor(true);
		((Control)button_11).add_Click((EventHandler)button_11_Click);
		((Control)button_10).set_Anchor((AnchorStyles)9);
		((Control)button_10).set_Location(new Point(738, 233));
		((Control)button_10).set_Name("button刷新小号");
		((Control)button_10).set_Size(new Size(31, 20));
		((Control)button_10).set_TabIndex(150);
		((Control)button_10).set_Text("刷");
		toolTipAll.SetToolTip((Control)(object)button_10, "刷新显示所有已经登录的小号");
		((ButtonBase)button_10).set_UseVisualStyleBackColor(true);
		((Control)button_10).add_Click((EventHandler)button_10_Click);
		((Control)button_9).set_Anchor((AnchorStyles)9);
		((Control)button_9).set_Location(new Point(630, 233));
		((Control)button_9).set_Name("button开始小号");
		((Control)button_9).set_Size(new Size(44, 20));
		((Control)button_9).set_TabIndex(149);
		((Control)button_9).set_Text("执行");
		toolTipAll.SetToolTip((Control)(object)button_9, "开始执行所有勾选的小号");
		((ButtonBase)button_9).set_UseVisualStyleBackColor(true);
		((Control)button_9).add_Click((EventHandler)button_9_Click);
		((Control)button_7).set_Anchor((AnchorStyles)9);
		((Control)button_7).set_Location(new Point(570, 233));
		((Control)button_7).set_Name("button全选");
		((Control)button_7).set_Size(new Size(20, 20));
		((Control)button_7).set_TabIndex(148);
		((Control)button_7).set_Text("√");
		toolTipAll.SetToolTip((Control)(object)button_7, "全选");
		((ButtonBase)button_7).set_UseVisualStyleBackColor(true);
		((Control)button_7).add_Click((EventHandler)button_7_Click);
		((Control)button_8).set_Anchor((AnchorStyles)9);
		((Control)button_8).set_Location(new Point(600, 233));
		((Control)button_8).set_Name("button全不选");
		((Control)button_8).set_Size(new Size(20, 20));
		((Control)button_8).set_TabIndex(147);
		((Control)button_8).set_Text("×");
		toolTipAll.SetToolTip((Control)(object)button_8, "全不选");
		((ButtonBase)button_8).set_UseVisualStyleBackColor(true);
		((Control)button_8).add_Click((EventHandler)button_8_Click);
		((Control)button_6).set_Location(new Point(360, 5));
		((Control)button_6).set_Name("button删除大号");
		((Control)button_6).set_Size(new Size(75, 23));
		((Control)button_6).set_TabIndex(103);
		((Control)button_6).set_Text("删除大号");
		((ButtonBase)button_6).set_UseVisualStyleBackColor(true);
		((Control)button_6).add_Click((EventHandler)button_6_Click);
		((Control)button_5).set_Location(new Point(275, 5));
		((Control)button_5).set_Name("button添加大号");
		((Control)button_5).set_Size(new Size(75, 23));
		((Control)button_5).set_TabIndex(102);
		((Control)button_5).set_Text("添加大号");
		((ButtonBase)button_5).set_UseVisualStyleBackColor(true);
		((Control)button_5).add_Click((EventHandler)button_5_Click);
		((Control)textBox_0).set_Location(new Point(97, 6));
		((Control)textBox_0).set_Name("textBox大号号码");
		((Control)textBox_0).set_Size(new Size(172, 21));
		((Control)textBox_0).set_TabIndex(101);
		((Control)listView_1).set_Anchor((AnchorStyles)15);
		listView_1.set_CheckBoxes(true);
		listView_1.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[3] { columnHeader252, columnHeader253, columnHeader255 });
		((Control)listView_1).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView_1).set_Cursor(Cursors.get_Default());
		((Control)listView_1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listView_1.set_FullRowSelect(true);
		listView_1.set_GridLines(true);
		((Control)listView_1).set_Location(new Point(9, 259));
		listView_1.set_MultiSelect(false);
		((Control)listView_1).set_Name("listView小号列表");
		((Control)listView_1).set_Size(new Size(762, 293));
		((Control)listView_1).set_TabIndex(100);
		listView_1.set_UseCompatibleStateImageBehavior(false);
		listView_1.set_View((View)1);
		((Control)listView_1).add_MouseUp(new MouseEventHandler(listView_1_MouseUp));
		columnHeader252.set_Text("QQ号码");
		columnHeader252.set_Width(107);
		columnHeader253.set_Text("昵称");
		columnHeader253.set_Width(155);
		columnHeader255.set_Text("执行进度");
		columnHeader255.set_Width(439);
		((Control)label61).set_AutoSize(true);
		((Control)label61).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label61).set_ForeColor(Color.Blue);
		((Control)label61).set_Location(new Point(10, 240));
		((Control)label61).set_Name("label61");
		((Control)label61).set_Size(new Size(137, 12));
		((Control)label61).set_TabIndex(99);
		((Control)label61).set_Text("已经登录的小号QQ列表：");
		((Control)checkBox_7).set_AutoSize(true);
		((Control)checkBox_7).set_BackColor(Color.Transparent);
		((Control)checkBox_7).set_ForeColor(Color.Blue);
		((Control)checkBox_7).set_Location(new Point(611, 73));
		((Control)checkBox_7).set_Name("checkBox小号好友买卖使用命运卡");
		((Control)checkBox_7).set_Size(new Size(156, 16));
		((Control)checkBox_7).set_TabIndex(98);
		((Control)checkBox_7).set_Text("小号好友买卖使用命运卡");
		((ButtonBase)checkBox_7).set_UseVisualStyleBackColor(false);
		checkBox_7.add_CheckedChanged((EventHandler)checkBox_7_CheckedChanged);
		((Control)checkBox_8).set_AutoSize(true);
		((Control)checkBox_8).set_BackColor(Color.Transparent);
		((Control)checkBox_8).set_ForeColor(Color.Blue);
		((Control)checkBox_8).set_Location(new Point(611, 47));
		((Control)checkBox_8).set_Name("checkBox小号登录好友买卖");
		((Control)checkBox_8).set_Size(new Size(120, 16));
		((Control)checkBox_8).set_TabIndex(97);
		((Control)checkBox_8).set_Text("小号登录好友买卖");
		((ButtonBase)checkBox_8).set_UseVisualStyleBackColor(false);
		checkBox_8.add_CheckedChanged((EventHandler)checkBox_8_CheckedChanged);
		((Control)checkBox_3).set_AutoSize(true);
		((Control)checkBox_3).set_BackColor(Color.Transparent);
		((Control)checkBox_3).set_ForeColor(Color.Blue);
		((Control)checkBox_3).set_Location(new Point(611, 21));
		((Control)checkBox_3).set_Name("checkBox小号登录抢车位");
		((Control)checkBox_3).set_Size(new Size(108, 16));
		((Control)checkBox_3).set_TabIndex(96);
		((Control)checkBox_3).set_Text("小号登录抢车位");
		((ButtonBase)checkBox_3).set_UseVisualStyleBackColor(false);
		checkBox_3.add_CheckedChanged((EventHandler)checkBox_3_CheckedChanged);
		((Control)checkBox_4).set_AutoSize(true);
		((Control)checkBox_4).set_BackColor(Color.Transparent);
		((Control)checkBox_4).set_ForeColor(Color.Blue);
		((Control)checkBox_4).set_Location(new Point(456, 99));
		((Control)checkBox_4).set_Name("checkBox赠送鲜花红玫瑰");
		((Control)checkBox_4).set_Size(new Size(144, 16));
		((Control)checkBox_4).set_TabIndex(95);
		((Control)checkBox_4).set_Text("赠送大号QQ鲜花红玫瑰");
		((ButtonBase)checkBox_4).set_UseVisualStyleBackColor(false);
		checkBox_4.add_CheckedChanged((EventHandler)checkBox_4_CheckedChanged);
		((Control)checkBox_5).set_AutoSize(true);
		((Control)checkBox_5).set_BackColor(Color.Transparent);
		((Control)checkBox_5).set_ForeColor(Color.Blue);
		((Control)checkBox_5).set_Location(new Point(456, 73));
		((Control)checkBox_5).set_Name("checkBox浪漫玫瑰园");
		((Control)checkBox_5).set_Size(new Size(84, 16));
		((Control)checkBox_5).set_TabIndex(94);
		((Control)checkBox_5).set_Text("浪漫玫瑰园");
		((ButtonBase)checkBox_5).set_UseVisualStyleBackColor(false);
		checkBox_5.add_CheckedChanged((EventHandler)checkBox_5_CheckedChanged);
		((Control)checkBox_6).set_AutoSize(true);
		((Control)checkBox_6).set_BackColor(Color.Transparent);
		((Control)checkBox_6).set_ForeColor(Color.Blue);
		((Control)checkBox_6).set_Location(new Point(456, 47));
		((Control)checkBox_6).set_Name("checkBox增加小号QQ花藤属性");
		((Control)checkBox_6).set_Size(new Size(132, 16));
		((Control)checkBox_6).set_TabIndex(93);
		((Control)checkBox_6).set_Text("增加大号QQ花藤属性");
		((ButtonBase)checkBox_6).set_UseVisualStyleBackColor(false);
		checkBox_6.add_CheckedChanged((EventHandler)checkBox_6_CheckedChanged);
		((Control)checkBox_2).set_AutoSize(true);
		((Control)checkBox_2).set_BackColor(Color.Transparent);
		((Control)checkBox_2).set_ForeColor(Color.Blue);
		((Control)checkBox_2).set_Location(new Point(456, 21));
		((Control)checkBox_2).set_Name("checkBox增加大号QQ空间访问量");
		((Control)checkBox_2).set_Size(new Size(144, 16));
		((Control)checkBox_2).set_TabIndex(92);
		((Control)checkBox_2).set_Text("增加大号QQ空间访问量");
		((ButtonBase)checkBox_2).set_UseVisualStyleBackColor(false);
		checkBox_2.add_CheckedChanged((EventHandler)checkBox_2_CheckedChanged);
		listView_0.set_CheckBoxes(true);
		listView_0.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[4] { columnHeader247, columnHeader249, columnHeader250, columnHeader251 });
		((Control)listView_0).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView_0).set_Cursor(Cursors.get_Default());
		((Control)listView_0).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listView_0.set_FullRowSelect(true);
		listView_0.set_GridLines(true);
		((Control)listView_0).set_Location(new Point(9, 31));
		listView_0.set_MultiSelect(false);
		((Control)listView_0).set_Name("listView大号列表");
		((Control)listView_0).set_Size(new Size(426, 196));
		((Control)listView_0).set_TabIndex(91);
		listView_0.set_UseCompatibleStateImageBehavior(false);
		listView_0.set_View((View)1);
		((Control)listView_0).add_MouseUp(new MouseEventHandler(listView_0_MouseUp));
		columnHeader247.set_Text("QQ号码");
		columnHeader247.set_Width(93);
		columnHeader249.set_Text("昵称");
		columnHeader249.set_Width(89);
		columnHeader250.set_Text("今日访问量");
		columnHeader250.set_Width(98);
		columnHeader251.set_Text("历史访问量");
		columnHeader251.set_Width(93);
		((Control)label60).set_AutoSize(true);
		((Control)label60).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label60).set_ForeColor(Color.Blue);
		((Control)label60).set_Location(new Point(10, 10));
		((Control)label60).set_Name("label60");
		((Control)label60).set_Size(new Size(77, 12));
		((Control)label60).set_TabIndex(90);
		((Control)label60).set_Text("大号QQ列表：");
		((Control)tabPageParks).get_Controls().Add((Control)(object)tabControl3);
		tabPageParks.set_Location(new Point(4, 21));
		((Control)tabPageParks).set_Name("tabPageParks");
		((Control)tabPageParks).set_Size(new Size(774, 547));
		tabPageParks.set_TabIndex(6);
		((Control)tabPageParks).set_Text("抢车位");
		tabPageParks.set_UseVisualStyleBackColor(true);
		((Control)tabControl3).set_Anchor((AnchorStyles)15);
		((Control)tabControl3).get_Controls().Add((Control)(object)tabPagePark);
		((Control)tabControl3).get_Controls().Add((Control)(object)tabPageJubao);
		((Control)tabControl3).get_Controls().Add((Control)(object)tabPageCheshi);
		((Control)tabControl3).get_Controls().Add((Control)(object)tabPageJiaoben);
		((Control)tabControl3).get_Controls().Add((Control)(object)tabPageWoDeCheZiJinKuang);
		((Control)tabControl3).get_Controls().Add((Control)(object)tabPage20);
		((Control)tabControl3).get_Controls().Add((Control)(object)tabPage21);
		((Control)tabControl3).set_Location(new Point(3, 0));
		((Control)tabControl3).set_Name("tabControl3");
		tabControl3.set_SelectedIndex(0);
		((Control)tabControl3).set_Size(new Size(771, 555));
		((Control)tabControl3).set_TabIndex(0);
		tabControl3.add_Selected(new TabControlEventHandler(tabControl3_Selected));
		((Control)tabPagePark).get_Controls().Add((Control)(object)button91);
		((Control)tabPagePark).get_Controls().Add((Control)(object)button94);
		((Control)tabPagePark).get_Controls().Add((Control)(object)button_28);
		((Control)tabPagePark).get_Controls().Add((Control)(object)comboBox_0);
		((Control)tabPagePark).get_Controls().Add((Control)(object)checkBox_0);
		((Control)tabPagePark).get_Controls().Add((Control)(object)button77);
		((Control)tabPagePark).get_Controls().Add((Control)(object)button60);
		((Control)tabPagePark).get_Controls().Add((Control)(object)button61);
		((Control)tabPagePark).get_Controls().Add((Control)(object)buttonYiJianParkPiLiang);
		((Control)tabPagePark).get_Controls().Add((Control)(object)buttonYiJianPark);
		((Control)tabPagePark).get_Controls().Add((Control)(object)labelChaJu);
		((Control)tabPagePark).get_Controls().Add((Control)(object)buttonSaveFriend);
		((Control)tabPagePark).get_Controls().Add((Control)(object)button2);
		((Control)tabPagePark).get_Controls().Add((Control)(object)label16);
		((Control)tabPagePark).get_Controls().Add((Control)(object)label12);
		((Control)tabPagePark).get_Controls().Add((Control)(object)label8);
		((Control)tabPagePark).get_Controls().Add((Control)(object)label6);
		((Control)tabPagePark).get_Controls().Add((Control)(object)comboExcessQQ);
		((Control)tabPagePark).get_Controls().Add((Control)(object)label5);
		((Control)tabPagePark).get_Controls().Add((Control)(object)checkGoBack);
		((Control)tabPagePark).get_Controls().Add((Control)(object)buttonAllYes1);
		((Control)tabPagePark).get_Controls().Add((Control)(object)buttonYuan);
		((Control)tabPagePark).get_Controls().Add((Control)(object)buttonAllNo1);
		((Control)tabPagePark).get_Controls().Add((Control)(object)buttonNuo);
		((Control)tabPagePark).get_Controls().Add((Control)(object)buttonTie);
		((Control)tabPagePark).get_Controls().Add((Control)(object)label4);
		((Control)tabPagePark).get_Controls().Add((Control)(object)buttonRefres3);
		((Control)tabPagePark).get_Controls().Add((Control)(object)listFriend);
		((Control)tabPagePark).get_Controls().Add((Control)(object)label11);
		((Control)tabPagePark).get_Controls().Add((Control)(object)label10);
		((Control)tabPagePark).get_Controls().Add((Control)(object)label9);
		((Control)tabPagePark).get_Controls().Add((Control)(object)buttonRefres2);
		((Control)tabPagePark).get_Controls().Add((Control)(object)listCars);
		((Control)tabPagePark).get_Controls().Add((Control)(object)buttonRefres1);
		((Control)tabPagePark).get_Controls().Add((Control)(object)listPark);
		tabPagePark.set_Location(new Point(4, 21));
		((Control)tabPagePark).set_Name("tabPagePark");
		((Control)tabPagePark).set_Padding(new Padding(3));
		((Control)tabPagePark).set_Size(new Size(763, 530));
		tabPagePark.set_TabIndex(0);
		((Control)tabPagePark).set_Text("基本");
		tabPagePark.set_UseVisualStyleBackColor(true);
		((Control)button91).set_Anchor((AnchorStyles)9);
		((Control)button91).set_Location(new Point(564, 121));
		((Control)button91).set_Name("button91");
		((Control)button91).set_Size(new Size(20, 20));
		((Control)button91).set_TabIndex(110);
		((Control)button91).set_Text("√");
		toolTipAll.SetToolTip((Control)(object)button91, "全选");
		((ButtonBase)button91).set_UseVisualStyleBackColor(true);
		((Control)button91).add_Click((EventHandler)button91_Click);
		((Control)button94).set_Anchor((AnchorStyles)9);
		((Control)button94).set_Location(new Point(588, 121));
		((Control)button94).set_Name("button94");
		((Control)button94).set_Size(new Size(20, 20));
		((Control)button94).set_TabIndex(109);
		((Control)button94).set_Text("×");
		toolTipAll.SetToolTip((Control)(object)button94, "全不选");
		((ButtonBase)button94).set_UseVisualStyleBackColor(true);
		((Control)button94).add_Click((EventHandler)button94_Click);
		((Control)button_28).set_Anchor((AnchorStyles)9);
		((Control)button_28).set_Location(new Point(612, 121));
		((Control)button_28).set_Name("button被贴");
		((Control)button_28).set_Size(new Size(47, 20));
		((Control)button_28).set_TabIndex(108);
		((Control)button_28).set_Text("被贴");
		toolTipAll.SetToolTip((Control)(object)button_28, "让自己的车被对方贴，收入归对方");
		((ButtonBase)button_28).set_UseVisualStyleBackColor(true);
		((Control)button_28).add_Click((EventHandler)button_28_Click);
		((Control)comboBox_0).set_Anchor((AnchorStyles)9);
		comboBox_0.set_DropDownHeight(300);
		comboBox_0.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox_0).set_FormattingEnabled(true);
		comboBox_0.set_IntegralHeight(false);
		((Control)comboBox_0).set_Location(new Point(453, 121));
		((Control)comboBox_0).set_Name("comboBox选车");
		((Control)comboBox_0).set_Size(new Size(104, 20));
		((Control)comboBox_0).set_TabIndex(107);
		comboBox_0.add_SelectedIndexChanged((EventHandler)comboBox_0_SelectedIndexChanged);
		((Control)checkBox_0).set_Anchor((AnchorStyles)9);
		((Control)checkBox_0).set_AutoSize(true);
		((Control)checkBox_0).set_BackColor(Color.Transparent);
		((Control)checkBox_0).set_ForeColor(Color.Red);
		((Control)checkBox_0).set_Location(new Point(381, 357));
		((Control)checkBox_0).set_Name("checkBox只显示白名单好友");
		((Control)checkBox_0).set_Size(new Size(168, 16));
		((Control)checkBox_0).set_TabIndex(106);
		((Control)checkBox_0).set_Text("只显示白名单[不贴条]好友");
		((ButtonBase)checkBox_0).set_UseVisualStyleBackColor(false);
		checkBox_0.add_CheckedChanged((EventHandler)checkBox_0_CheckedChanged);
		((Control)button77).set_Anchor((AnchorStyles)9);
		((Control)button77).set_ForeColor(Color.Black);
		((Control)button77).set_Location(new Point(690, 354));
		((Control)button77).set_Name("button77");
		((Control)button77).set_Size(new Size(38, 20));
		((Control)button77).set_TabIndex(104);
		((Control)button77).set_Text("详细");
		toolTipAll.SetToolTip((Control)(object)button77, "刷新显示详细空位数和爱心车位颜色和最近登录时间");
		((ButtonBase)button77).set_UseVisualStyleBackColor(true);
		((Control)button77).add_Click((EventHandler)button77_Click);
		((Control)button60).set_Anchor((AnchorStyles)9);
		((Control)button60).set_Location(new Point(555, 354));
		((Control)button60).set_Name("button60");
		((Control)button60).set_Size(new Size(20, 20));
		((Control)button60).set_TabIndex(103);
		((Control)button60).set_Text("√");
		toolTipAll.SetToolTip((Control)(object)button60, "全选");
		((ButtonBase)button60).set_UseVisualStyleBackColor(true);
		((Control)button60).add_Click((EventHandler)button60_Click);
		((Control)button61).set_Anchor((AnchorStyles)9);
		((Control)button61).set_Location(new Point(579, 354));
		((Control)button61).set_Name("button61");
		((Control)button61).set_Size(new Size(20, 20));
		((Control)button61).set_TabIndex(102);
		((Control)button61).set_Text("×");
		toolTipAll.SetToolTip((Control)(object)button61, "全不选");
		((ButtonBase)button61).set_UseVisualStyleBackColor(true);
		((Control)button61).add_Click((EventHandler)button61_Click);
		((Control)buttonYiJianParkPiLiang).set_Anchor((AnchorStyles)9);
		((Control)buttonYiJianParkPiLiang).set_Location(new Point(656, 1));
		((Control)buttonYiJianParkPiLiang).set_Name("buttonYiJianParkPiLiang");
		((Control)buttonYiJianParkPiLiang).set_Size(new Size(20, 20));
		((Control)buttonYiJianParkPiLiang).set_TabIndex(101);
		((Control)buttonYiJianParkPiLiang).set_Text("1");
		toolTipAll.SetToolTip((Control)(object)buttonYiJianParkPiLiang, "一键全搞定，包括贴条回停和批量停车");
		((ButtonBase)buttonYiJianParkPiLiang).set_UseVisualStyleBackColor(true);
		((Control)buttonYiJianParkPiLiang).add_Click((EventHandler)buttonYiJianParkPiLiang_Click);
		((Control)buttonYiJianPark).set_Anchor((AnchorStyles)9);
		((Control)buttonYiJianPark).set_Location(new Point(683, 1));
		((Control)buttonYiJianPark).set_Name("buttonYiJianPark");
		((Control)buttonYiJianPark).set_Size(new Size(20, 20));
		((Control)buttonYiJianPark).set_TabIndex(100);
		((Control)buttonYiJianPark).set_Text("2");
		toolTipAll.SetToolTip((Control)(object)buttonYiJianPark, "一键全搞定，包括贴条回停和原地停车");
		((ButtonBase)buttonYiJianPark).set_UseVisualStyleBackColor(true);
		((Control)buttonYiJianPark).add_Click((EventHandler)buttonYiJianPark_Click);
		((Control)labelChaJu).set_AutoSize(true);
		((Control)labelChaJu).set_ForeColor(Color.Blue);
		((Control)labelChaJu).set_Location(new Point(154, 358));
		((Control)labelChaJu).set_Name("labelChaJu");
		((Control)labelChaJu).set_Size(new Size(89, 12));
		((Control)labelChaJu).set_TabIndex(98);
		((Control)labelChaJu).set_Text("与上一名差距：");
		((Control)buttonSaveFriend).set_Anchor((AnchorStyles)9);
		((Control)buttonSaveFriend).set_Location(new Point(603, 354));
		((Control)buttonSaveFriend).set_Name("buttonSaveFriend");
		((Control)buttonSaveFriend).set_Size(new Size(83, 20));
		((Control)buttonSaveFriend).set_TabIndex(97);
		((Control)buttonSaveFriend).set_Text("保存白名单");
		toolTipAll.SetToolTip((Control)(object)buttonSaveFriend, "保存批量停车白名单[不贴条]好友");
		((ButtonBase)buttonSaveFriend).set_UseVisualStyleBackColor(true);
		((Control)buttonSaveFriend).add_Click((EventHandler)buttonSaveFriend_Click);
		((Control)button2).set_Anchor((AnchorStyles)9);
		((Control)button2).set_Location(new Point(663, 121));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(20, 20));
		((Control)button2).set_TabIndex(96);
		((Control)button2).set_Text("批");
		toolTipAll.SetToolTip((Control)(object)button2, "多选中几个好友，可以批量停车，速度比原地停车会快很多");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)label16).set_AutoSize(true);
		((Control)label16).set_ForeColor(Color.Blue);
		((Control)label16).set_Location(new Point(298, 358));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(77, 12));
		((Control)label16).set_TabIndex(94);
		((Control)label16).set_Text("单击列头排序");
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_ForeColor(Color.Blue);
		((Control)label12).set_Location(new Point(111, 5));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(65, 12));
		((Control)label12).set_TabIndex(93);
		((Control)label12).set_Text("贴条收入：");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_ForeColor(Color.Blue);
		((Control)label8).set_Location(new Point(403, 5));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(53, 12));
		((Control)label8).set_TabIndex(92);
		((Control)label8).set_Text("车辆数：");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_ForeColor(Color.Blue);
		((Control)label6).set_Location(new Point(238, 5));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(65, 12));
		((Control)label6).set_TabIndex(90);
		((Control)label6).set_Text("开通日期：");
		((Control)comboExcessQQ).set_Anchor((AnchorStyles)9);
		((ListControl)comboExcessQQ).set_FormattingEnabled(true);
		((Control)comboExcessQQ).set_Location(new Point(335, 121));
		((Control)comboExcessQQ).set_Name("comboExcessQQ");
		((Control)comboExcessQQ).set_Size(new Size(114, 20));
		((Control)comboExcessQQ).set_TabIndex(89);
		comboExcessQQ.add_SelectedIndexChanged((EventHandler)comboExcessQQ_SelectedIndexChanged);
		((Control)label5).set_Anchor((AnchorStyles)9);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label5).set_ForeColor(Color.Blue);
		((Control)label5).set_Location(new Point(283, 127));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(53, 12));
		((Control)label5).set_TabIndex(88);
		((Control)label5).set_Text("过渡场：");
		((Control)checkGoBack).set_Anchor((AnchorStyles)9);
		((Control)checkGoBack).set_AutoSize(true);
		((Control)checkGoBack).set_Location(new Point(496, 3));
		((Control)checkGoBack).set_Name("checkGoBack");
		((Control)checkGoBack).set_Size(new Size(96, 16));
		((Control)checkGoBack).set_TabIndex(87);
		((Control)checkGoBack).set_Text("被贴自动回停");
		((ButtonBase)checkGoBack).set_UseVisualStyleBackColor(true);
		checkGoBack.add_CheckedChanged((EventHandler)checkGoBack_CheckedChanged);
		((Control)buttonAllYes1).set_Anchor((AnchorStyles)9);
		((Control)buttonAllYes1).set_Location(new Point(602, 1));
		((Control)buttonAllYes1).set_Name("buttonAllYes1");
		((Control)buttonAllYes1).set_Size(new Size(20, 20));
		((Control)buttonAllYes1).set_TabIndex(84);
		((Control)buttonAllYes1).set_Text("√");
		toolTipAll.SetToolTip((Control)(object)buttonAllYes1, "全选");
		((ButtonBase)buttonAllYes1).set_UseVisualStyleBackColor(true);
		((Control)buttonAllYes1).add_Click((EventHandler)buttonAllYes1_Click);
		((Control)buttonYuan).set_Anchor((AnchorStyles)9);
		((Control)buttonYuan).set_Location(new Point(687, 121));
		((Control)buttonYuan).set_Name("buttonYuan");
		((Control)buttonYuan).set_Size(new Size(20, 20));
		((Control)buttonYuan).set_TabIndex(83);
		((Control)buttonYuan).set_Text("原");
		toolTipAll.SetToolTip((Control)(object)buttonYuan, "原地停车后,车辆停在原先的车位上");
		((ButtonBase)buttonYuan).set_UseVisualStyleBackColor(true);
		((Control)buttonYuan).add_Click((EventHandler)buttonYuan_Click);
		((Control)buttonAllNo1).set_Anchor((AnchorStyles)9);
		((Control)buttonAllNo1).set_Location(new Point(628, 1));
		((Control)buttonAllNo1).set_Name("buttonAllNo1");
		((Control)buttonAllNo1).set_Size(new Size(20, 20));
		((Control)buttonAllNo1).set_TabIndex(82);
		((Control)buttonAllNo1).set_Text("×");
		toolTipAll.SetToolTip((Control)(object)buttonAllNo1, "全不选");
		((ButtonBase)buttonAllNo1).set_UseVisualStyleBackColor(true);
		((Control)buttonAllNo1).add_Click((EventHandler)buttonAllNo1_Click);
		((Control)buttonNuo).set_Anchor((AnchorStyles)9);
		((Control)buttonNuo).set_Location(new Point(711, 121));
		((Control)buttonNuo).set_Name("buttonNuo");
		((Control)buttonNuo).set_Size(new Size(20, 20));
		((Control)buttonNuo).set_TabIndex(81);
		((Control)buttonNuo).set_Text("挪");
		toolTipAll.SetToolTip((Control)(object)buttonNuo, "挪动车辆后,车辆不在任何车位,处于自由状态");
		((ButtonBase)buttonNuo).set_UseVisualStyleBackColor(true);
		((Control)buttonNuo).add_Click((EventHandler)buttonNuo_Click);
		((Control)buttonTie).set_Anchor((AnchorStyles)9);
		((Control)buttonTie).set_Location(new Point(710, 1));
		((Control)buttonTie).set_Name("buttonTie");
		((Control)buttonTie).set_Size(new Size(20, 20));
		((Control)buttonTie).set_TabIndex(80);
		((Control)buttonTie).set_Text("贴");
		toolTipAll.SetToolTip((Control)(object)buttonTie, "对我的车位上的车辆进行贴条");
		((ButtonBase)buttonTie).set_UseVisualStyleBackColor(true);
		((Control)buttonTie).add_Click((EventHandler)buttonTie_Click);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_ForeColor(Color.Blue);
		((Control)label4).set_Location(new Point(1, 358));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(137, 12));
		((Control)label4).set_TabIndex(79);
		((Control)label4).set_Text("你在好友圈内排行位数：");
		((Control)buttonRefres3).set_Anchor((AnchorStyles)9);
		((Control)buttonRefres3).set_Location(new Point(732, 354));
		((Control)buttonRefres3).set_Name("buttonRefres3");
		((Control)buttonRefres3).set_Size(new Size(20, 20));
		((Control)buttonRefres3).set_TabIndex(77);
		((Control)buttonRefres3).set_Text("刷");
		toolTipAll.SetToolTip((Control)(object)buttonRefres3, "刷新好友信息");
		((ButtonBase)buttonRefres3).set_UseVisualStyleBackColor(true);
		((Control)buttonRefres3).add_Click((EventHandler)buttonRefres3_Click);
		((Control)listFriend).set_Anchor((AnchorStyles)15);
		listFriend.set_CheckBoxes(true);
		listFriend.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[10] { columnHeader17, columnHeader18, columnHeader19, columnHeader20, columnHeader21, columnHeader22, columnHeader235, columnHeader236, columnHeader237, columnHeader24 });
		((Control)listFriend).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listFriend).set_Cursor(Cursors.get_Default());
		((Control)listFriend).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listFriend.set_FullRowSelect(true);
		listFriend.set_GridLines(true);
		((Control)listFriend).set_Location(new Point(1, 374));
		listFriend.set_MultiSelect(false);
		((Control)listFriend).set_Name("listFriend");
		((Control)listFriend).set_Size(new Size(763, 159));
		((Control)listFriend).set_TabIndex(78);
		listFriend.set_UseCompatibleStateImageBehavior(false);
		listFriend.set_View((View)1);
		((Control)listFriend).add_MouseUp(new MouseEventHandler(listFriend_MouseUp));
		listFriend.add_ColumnClick(new ColumnClickEventHandler(listFriend_ColumnClick));
		columnHeader17.set_Text("QQ号码");
		columnHeader17.set_Width(86);
		columnHeader18.set_Text("昵称");
		columnHeader18.set_Width(93);
		columnHeader19.set_Text("现金");
		columnHeader19.set_Width(78);
		columnHeader20.set_Text("汽车总价");
		columnHeader20.set_Width(85);
		columnHeader21.set_Text("状态");
		columnHeader21.set_Width(59);
		columnHeader22.set_Text("空车位");
		columnHeader22.set_Width(67);
		columnHeader235.set_Text("爱心车位颜色");
		columnHeader235.set_Width(92);
		columnHeader236.set_Text("等级");
		columnHeader237.set_Text("经验值");
		columnHeader24.set_Text("最近登录时间");
		columnHeader24.set_Width(154);
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_ForeColor(Color.Blue);
		((Control)label11).set_Location(new Point(2, 5));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(41, 12));
		((Control)label11).set_TabIndex(76);
		((Control)label11).set_Text("现金：");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_ForeColor(Color.Blue);
		((Control)label10).set_Location(new Point(158, 127));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(77, 12));
		((Control)label10).set_TabIndex(75);
		((Control)label10).set_Text("当前已盈利：");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_ForeColor(Color.Blue);
		((Control)label9).set_Location(new Point(1, 127));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(77, 12));
		((Control)label9).set_TabIndex(74);
		((Control)label9).set_Text("每日能盈利：");
		((Control)buttonRefres2).set_Anchor((AnchorStyles)9);
		((Control)buttonRefres2).set_Location(new Point(735, 121));
		((Control)buttonRefres2).set_Name("buttonRefres2");
		((Control)buttonRefres2).set_Size(new Size(20, 20));
		((Control)buttonRefres2).set_TabIndex(72);
		((Control)buttonRefres2).set_Text("刷");
		toolTipAll.SetToolTip((Control)(object)buttonRefres2, "刷新我的车辆信息");
		((ButtonBase)buttonRefres2).set_UseVisualStyleBackColor(true);
		((Control)buttonRefres2).add_Click((EventHandler)buttonRefres2_Click);
		((Control)listCars).set_Anchor((AnchorStyles)13);
		listCars.set_CheckBoxes(true);
		listCars.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[10] { columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16, columnHeader254 });
		((Control)listCars).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listCars).set_Cursor(Cursors.get_Default());
		((Control)listCars).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listCars.set_FullRowSelect(true);
		listCars.set_GridLines(true);
		((Control)listCars).set_Location(new Point(0, 144));
		listCars.set_MultiSelect(false);
		((Control)listCars).set_Name("listCars");
		((Control)listCars).set_Size(new Size(763, 211));
		((Control)listCars).set_TabIndex(73);
		listCars.set_UseCompatibleStateImageBehavior(false);
		listCars.set_View((View)1);
		((Control)listCars).add_MouseUp(new MouseEventHandler(listCars_MouseUp));
		columnHeader8.set_Text("当前停车处");
		columnHeader8.set_Width(97);
		columnHeader9.set_Text("昵称");
		columnHeader9.set_Width(121);
		columnHeader10.set_Text("车牌");
		columnHeader10.set_Width(47);
		columnHeader11.set_Text("颜色");
		columnHeader11.set_Width(52);
		columnHeader12.set_Text("车辆");
		columnHeader12.set_Width(105);
		columnHeader13.set_Text("价格");
		columnHeader13.set_Width(83);
		columnHeader14.set_Text("盈利");
		columnHeader15.set_Text("已停时间");
		columnHeader15.set_Width(103);
		columnHeader16.set_Text("预计收入");
		columnHeader16.set_Width(83);
		columnHeader254.set_Text("举报人");
		columnHeader254.set_Width(240);
		((Control)buttonRefres1).set_Anchor((AnchorStyles)9);
		((Control)buttonRefres1).set_Location(new Point(736, 1));
		((Control)buttonRefres1).set_Name("buttonRefres1");
		((Control)buttonRefres1).set_Size(new Size(20, 20));
		((Control)buttonRefres1).set_TabIndex(70);
		((Control)buttonRefres1).set_Text("刷");
		toolTipAll.SetToolTip((Control)(object)buttonRefres1, "刷新我的车位信息");
		((ButtonBase)buttonRefres1).set_UseVisualStyleBackColor(true);
		((Control)buttonRefres1).add_Click((EventHandler)buttonRefres1_Click);
		((Control)listPark).set_Anchor((AnchorStyles)13);
		listPark.set_CheckBoxes(true);
		listPark.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[8] { columnHeader1, columnHeader2, columnHeader3, columnHeader23, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
		((Control)listPark).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listPark).set_Cursor(Cursors.get_Default());
		((Control)listPark).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listPark.set_FullRowSelect(true);
		listPark.set_GridLines(true);
		((Control)listPark).set_Location(new Point(0, 24));
		listPark.set_MultiSelect(false);
		((Control)listPark).set_Name("listPark");
		((Control)listPark).set_Size(new Size(763, 94));
		((Control)listPark).set_TabIndex(71);
		listPark.set_UseCompatibleStateImageBehavior(false);
		listPark.set_View((View)1);
		((Control)listPark).add_MouseUp(new MouseEventHandler(listPark_MouseUp));
		columnHeader1.set_Text("车主");
		columnHeader1.set_Width(100);
		columnHeader2.set_Text("昵称");
		columnHeader2.set_Width(115);
		columnHeader3.set_Text("车牌");
		columnHeader3.set_Width(52);
		columnHeader23.set_Text("车位号");
		columnHeader23.set_Width(73);
		columnHeader4.set_Text("车辆");
		columnHeader4.set_Width(104);
		columnHeader5.set_Text("盈利");
		columnHeader5.set_Width(78);
		columnHeader6.set_Text("已停时间");
		columnHeader6.set_Width(112);
		columnHeader7.set_Text("预计收入");
		columnHeader7.set_Width(120);
		((Control)tabPageJubao).get_Controls().Add((Control)(object)textBox_1);
		((Control)tabPageJubao).get_Controls().Add((Control)(object)tabControl10);
		tabPageJubao.set_Location(new Point(4, 21));
		((Control)tabPageJubao).set_Name("tabPageJubao");
		((Control)tabPageJubao).set_Padding(new Padding(3));
		((Control)tabPageJubao).set_Size(new Size(763, 530));
		tabPageJubao.set_TabIndex(1);
		((Control)tabPageJubao).set_Text("举报");
		tabPageJubao.set_UseVisualStyleBackColor(true);
		((Control)textBox_1).set_Anchor((AnchorStyles)15);
		((Control)textBox_1).set_BackColor(SystemColors.Info);
		((Control)textBox_1).set_Location(new Point(2, 412));
		((TextBoxBase)textBox_1).set_Multiline(true);
		((Control)textBox_1).set_Name("textBox举报");
		((TextBoxBase)textBox_1).set_ReadOnly(true);
		textBox_1.set_ScrollBars((ScrollBars)2);
		((Control)textBox_1).set_Size(new Size(761, 114));
		((Control)textBox_1).set_TabIndex(122);
		((Control)tabControl10).set_Anchor((AnchorStyles)13);
		((Control)tabControl10).get_Controls().Add((Control)(object)tabPage27);
		((Control)tabControl10).get_Controls().Add((Control)(object)tabPage28);
		((Control)tabControl10).set_Location(new Point(1, 1));
		((Control)tabControl10).set_Name("tabControl10");
		tabControl10.set_SelectedIndex(0);
		((Control)tabControl10).set_Size(new Size(762, 409));
		((Control)tabControl10).set_TabIndex(121);
		tabControl10.add_Selected(new TabControlEventHandler(tabControl10_Selected));
		((Control)tabPage27).get_Controls().Add((Control)(object)listJubaoPark);
		((Control)tabPage27).get_Controls().Add((Control)(object)button31);
		((Control)tabPage27).get_Controls().Add((Control)(object)comboExcessQQ2);
		((Control)tabPage27).get_Controls().Add((Control)(object)button33);
		((Control)tabPage27).get_Controls().Add((Control)(object)label51);
		((Control)tabPage27).get_Controls().Add((Control)(object)button34);
		((Control)tabPage27).get_Controls().Add((Control)(object)button35);
		((Control)tabPage27).get_Controls().Add((Control)(object)button30);
		((Control)tabPage27).get_Controls().Add((Control)(object)label56);
		((Control)tabPage27).get_Controls().Add((Control)(object)label55);
		((Control)tabPage27).get_Controls().Add((Control)(object)label57);
		((Control)tabPage27).get_Controls().Add((Control)(object)button32);
		((Control)tabPage27).get_Controls().Add((Control)(object)listJubaoCars);
		((Control)tabPage27).get_Controls().Add((Control)(object)label54);
		((Control)tabPage27).get_Controls().Add((Control)(object)label53);
		((Control)tabPage27).get_Controls().Add((Control)(object)label52);
		((Control)tabPage27).get_Controls().Add((Control)(object)button38);
		((Control)tabPage27).get_Controls().Add((Control)(object)button36);
		((Control)tabPage27).get_Controls().Add((Control)(object)button37);
		tabPage27.set_Location(new Point(4, 21));
		((Control)tabPage27).set_Name("tabPage27");
		((Control)tabPage27).set_Padding(new Padding(3));
		((Control)tabPage27).set_Size(new Size(754, 384));
		tabPage27.set_TabIndex(0);
		((Control)tabPage27).set_Text("基本举报");
		tabPage27.set_UseVisualStyleBackColor(true);
		((Control)listJubaoPark).set_Anchor((AnchorStyles)13);
		listJubaoPark.set_CheckBoxes(true);
		listJubaoPark.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[8] { columnHeader140, columnHeader141, columnHeader142, columnHeader143, columnHeader144, columnHeader145, columnHeader146, columnHeader147 });
		((Control)listJubaoPark).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listJubaoPark).set_Cursor(Cursors.get_Default());
		((Control)listJubaoPark).set_Font(new Font("宋体", 9f));
		listJubaoPark.set_FullRowSelect(true);
		listJubaoPark.set_GridLines(true);
		((Control)listJubaoPark).set_Location(new Point(2, 64));
		listJubaoPark.set_MultiSelect(false);
		((Control)listJubaoPark).set_Name("listJubaoPark");
		((Control)listJubaoPark).set_Size(new Size(749, 98));
		((Control)listJubaoPark).set_TabIndex(101);
		listJubaoPark.set_UseCompatibleStateImageBehavior(false);
		listJubaoPark.set_View((View)1);
		((Control)listJubaoPark).add_MouseUp(new MouseEventHandler(listJubaoPark_MouseUp));
		columnHeader140.set_Text("车主");
		columnHeader140.set_Width(100);
		columnHeader141.set_Text("昵称");
		columnHeader141.set_Width(113);
		columnHeader142.set_Text("车牌");
		columnHeader142.set_Width(52);
		columnHeader143.set_Text("车位号");
		columnHeader143.set_Width(73);
		columnHeader144.set_Text("车辆");
		columnHeader144.set_Width(117);
		columnHeader145.set_Text("盈利");
		columnHeader145.set_Width(56);
		columnHeader146.set_Text("已停时间");
		columnHeader146.set_Width(118);
		columnHeader147.set_Text("预计收入");
		columnHeader147.set_Width(99);
		((Control)button31).set_Anchor((AnchorStyles)9);
		((Control)button31).set_Location(new Point(725, 164));
		((Control)button31).set_Name("button31");
		((Control)button31).set_Size(new Size(20, 20));
		((Control)button31).set_TabIndex(116);
		((Control)button31).set_Text("刷");
		toolTipAll.SetToolTip((Control)(object)button31, "刷新车辆信息");
		((ButtonBase)button31).set_UseVisualStyleBackColor(true);
		((Control)button31).add_Click((EventHandler)button31_Click);
		((ListControl)comboExcessQQ2).set_FormattingEnabled(true);
		((Control)comboExcessQQ2).set_Location(new Point(135, 8));
		((Control)comboExcessQQ2).set_Name("comboExcessQQ2");
		((Control)comboExcessQQ2).set_Size(new Size(185, 20));
		((Control)comboExcessQQ2).set_TabIndex(120);
		comboExcessQQ2.add_SelectedIndexChanged((EventHandler)comboExcessQQ2_SelectedIndexChanged);
		((Control)button33).set_Anchor((AnchorStyles)9);
		((Control)button33).set_Location(new Point(699, 164));
		((Control)button33).set_Name("button33");
		((Control)button33).set_Size(new Size(20, 20));
		((Control)button33).set_TabIndex(114);
		((Control)button33).set_Text("举");
		toolTipAll.SetToolTip((Control)(object)button33, "举报TA的车辆");
		((ButtonBase)button33).set_UseVisualStyleBackColor(true);
		((Control)button33).add_Click((EventHandler)button33_Click);
		((Control)label51).set_AutoSize(true);
		((Control)label51).set_Location(new Point(6, 13));
		((Control)label51).set_Name("label51");
		((Control)label51).set_Size(new Size(125, 12));
		((Control)label51).set_TabIndex(99);
		((Control)label51).set_Text("输入需要举报的QQ号码");
		((Control)button34).set_Anchor((AnchorStyles)9);
		((Control)button34).set_Location(new Point(647, 164));
		((Control)button34).set_Name("button34");
		((Control)button34).set_Size(new Size(20, 20));
		((Control)button34).set_TabIndex(113);
		((Control)button34).set_Text("√");
		toolTipAll.SetToolTip((Control)(object)button34, "全选");
		((ButtonBase)button34).set_UseVisualStyleBackColor(true);
		((Control)button34).add_Click((EventHandler)button34_Click);
		((Control)button35).set_Anchor((AnchorStyles)9);
		((Control)button35).set_Location(new Point(673, 164));
		((Control)button35).set_Name("button35");
		((Control)button35).set_Size(new Size(20, 20));
		((Control)button35).set_TabIndex(112);
		((Control)button35).set_Text("×");
		toolTipAll.SetToolTip((Control)(object)button35, "全不选");
		((ButtonBase)button35).set_UseVisualStyleBackColor(true);
		((Control)button35).add_Click((EventHandler)button35_Click);
		((Control)button30).set_Location(new Point(326, 6));
		((Control)button30).set_Name("button30");
		((Control)button30).set_Size(new Size(61, 23));
		((Control)button30).set_TabIndex(100);
		((Control)button30).set_Text("查");
		toolTipAll.SetToolTip((Control)(object)button30, "举报查询");
		((ButtonBase)button30).set_UseVisualStyleBackColor(true);
		((Control)button30).add_Click((EventHandler)button30_Click);
		((Control)label56).set_AutoSize(true);
		((Control)label56).set_ForeColor(Color.Blue);
		((Control)label56).set_Location(new Point(210, 170));
		((Control)label56).set_Name("label56");
		((Control)label56).set_Size(new Size(77, 12));
		((Control)label56).set_TabIndex(104);
		((Control)label56).set_Text("当前已盈利：");
		((Control)label55).set_AutoSize(true);
		((Control)label55).set_ForeColor(Color.Blue);
		((Control)label55).set_Location(new Point(8, 42));
		((Control)label55).set_Name("label55");
		((Control)label55).set_Size(new Size(41, 12));
		((Control)label55).set_TabIndex(105);
		((Control)label55).set_Text("现金：");
		((Control)label57).set_AutoSize(true);
		((Control)label57).set_ForeColor(Color.Blue);
		((Control)label57).set_Location(new Point(11, 170));
		((Control)label57).set_Name("label57");
		((Control)label57).set_Size(new Size(77, 12));
		((Control)label57).set_TabIndex(103);
		((Control)label57).set_Text("每日能盈利：");
		((Control)button32).set_Anchor((AnchorStyles)9);
		((Control)button32).set_Location(new Point(725, 38));
		((Control)button32).set_Name("button32");
		((Control)button32).set_Size(new Size(20, 20));
		((Control)button32).set_TabIndex(115);
		((Control)button32).set_Text("刷");
		toolTipAll.SetToolTip((Control)(object)button32, "刷新车位信息");
		((ButtonBase)button32).set_UseVisualStyleBackColor(true);
		((Control)button32).add_Click((EventHandler)button32_Click);
		((Control)listJubaoCars).set_Anchor((AnchorStyles)13);
		listJubaoCars.set_CheckBoxes(true);
		listJubaoCars.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[9] { columnHeader131, columnHeader132, columnHeader133, columnHeader134, columnHeader135, columnHeader136, columnHeader137, columnHeader138, columnHeader139 });
		((Control)listJubaoCars).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listJubaoCars).set_Cursor(Cursors.get_Default());
		((Control)listJubaoCars).set_Font(new Font("宋体", 9f));
		listJubaoCars.set_FullRowSelect(true);
		listJubaoCars.set_GridLines(true);
		((Control)listJubaoCars).set_Location(new Point(4, 189));
		listJubaoCars.set_MultiSelect(false);
		((Control)listJubaoCars).set_Name("listJubaoCars");
		((Control)listJubaoCars).set_Size(new Size(748, 195));
		((Control)listJubaoCars).set_TabIndex(102);
		listJubaoCars.set_UseCompatibleStateImageBehavior(false);
		listJubaoCars.set_View((View)1);
		((Control)listJubaoCars).add_MouseUp(new MouseEventHandler(listJubaoCars_MouseUp));
		columnHeader131.set_Text("当前停车处");
		columnHeader131.set_Width(97);
		columnHeader132.set_Text("昵称");
		columnHeader132.set_Width(112);
		columnHeader133.set_Text("车牌");
		columnHeader133.set_Width(47);
		columnHeader134.set_Text("颜色");
		columnHeader134.set_Width(52);
		columnHeader135.set_Text("车辆");
		columnHeader135.set_Width(119);
		columnHeader136.set_Text("价格");
		columnHeader136.set_Width(69);
		columnHeader137.set_Text("盈利");
		columnHeader137.set_Width(48);
		columnHeader138.set_Text("已停时间");
		columnHeader138.set_Width(107);
		columnHeader139.set_Text("预计收入");
		columnHeader139.set_Width(82);
		((Control)label54).set_AutoSize(true);
		((Control)label54).set_ForeColor(Color.Blue);
		((Control)label54).set_Location(new Point(266, 42));
		((Control)label54).set_Name("label54");
		((Control)label54).set_Size(new Size(65, 12));
		((Control)label54).set_TabIndex(106);
		((Control)label54).set_Text("开通日期：");
		((Control)label53).set_AutoSize(true);
		((Control)label53).set_ForeColor(Color.Blue);
		((Control)label53).set_Location(new Point(439, 42));
		((Control)label53).set_Name("label53");
		((Control)label53).set_Size(new Size(53, 12));
		((Control)label53).set_TabIndex(107);
		((Control)label53).set_Text("车辆数：");
		((Control)label52).set_AutoSize(true);
		((Control)label52).set_ForeColor(Color.Blue);
		((Control)label52).set_Location(new Point(127, 42));
		((Control)label52).set_Name("label52");
		((Control)label52).set_Size(new Size(65, 12));
		((Control)label52).set_TabIndex(108);
		((Control)label52).set_Text("贴条收入：");
		((Control)button38).set_Anchor((AnchorStyles)9);
		((Control)button38).set_Location(new Point(699, 38));
		((Control)button38).set_Name("button38");
		((Control)button38).set_Size(new Size(20, 20));
		((Control)button38).set_TabIndex(109);
		((Control)button38).set_Text("举");
		toolTipAll.SetToolTip((Control)(object)button38, "举报车位上的车辆");
		((ButtonBase)button38).set_UseVisualStyleBackColor(true);
		((Control)button38).add_Click((EventHandler)button38_Click);
		((Control)button36).set_Anchor((AnchorStyles)9);
		((Control)button36).set_Location(new Point(647, 38));
		((Control)button36).set_Name("button36");
		((Control)button36).set_Size(new Size(20, 20));
		((Control)button36).set_TabIndex(111);
		((Control)button36).set_Text("√");
		toolTipAll.SetToolTip((Control)(object)button36, "全选");
		((ButtonBase)button36).set_UseVisualStyleBackColor(true);
		((Control)button36).add_Click((EventHandler)button36_Click);
		((Control)button37).set_Anchor((AnchorStyles)9);
		((Control)button37).set_Location(new Point(673, 38));
		((Control)button37).set_Name("button37");
		((Control)button37).set_Size(new Size(20, 20));
		((Control)button37).set_TabIndex(110);
		((Control)button37).set_Text("×");
		toolTipAll.SetToolTip((Control)(object)button37, "全不选");
		((ButtonBase)button37).set_UseVisualStyleBackColor(true);
		((Control)button37).add_Click((EventHandler)button37_Click);
		((Control)tabPage28).get_Controls().Add((Control)(object)button90);
		((Control)tabPage28).get_Controls().Add((Control)(object)comboExcessQQ4);
		((Control)tabPage28).get_Controls().Add((Control)(object)button1);
		((Control)tabPage28).get_Controls().Add((Control)(object)button92);
		((Control)tabPage28).get_Controls().Add((Control)(object)button93);
		((Control)tabPage28).get_Controls().Add((Control)(object)label58);
		((Control)tabPage28).get_Controls().Add((Control)(object)textBox22);
		((Control)tabPage28).get_Controls().Add((Control)(object)label139);
		((Control)tabPage28).get_Controls().Add((Control)(object)button_31);
		((Control)tabPage28).get_Controls().Add((Control)(object)button_32);
		((Control)tabPage28).get_Controls().Add((Control)(object)button_29);
		((Control)tabPage28).get_Controls().Add((Control)(object)label59);
		((Control)tabPage28).get_Controls().Add((Control)(object)button_30);
		((Control)tabPage28).get_Controls().Add((Control)(object)listView_2);
		tabPage28.set_Location(new Point(4, 21));
		((Control)tabPage28).set_Name("tabPage28");
		((Control)tabPage28).set_Padding(new Padding(3));
		((Control)tabPage28).set_Size(new Size(754, 384));
		tabPage28.set_TabIndex(1);
		((Control)tabPage28).set_Text("一键举报");
		tabPage28.set_UseVisualStyleBackColor(true);
		((Control)button90).set_Anchor((AnchorStyles)9);
		((Control)button90).set_ForeColor(Color.Black);
		((Control)button90).set_Location(new Point(485, 159));
		((Control)button90).set_Name("button90");
		((Control)button90).set_Size(new Size(127, 24));
		((Control)button90).set_TabIndex(152);
		((Control)button90).set_Text("手动保存");
		toolTipAll.SetToolTip((Control)(object)button90, "手动保存");
		((ButtonBase)button90).set_UseVisualStyleBackColor(true);
		((Control)button90).add_Click((EventHandler)button90_Click);
		((Control)comboExcessQQ4).set_Anchor((AnchorStyles)9);
		((ListControl)comboExcessQQ4).set_FormattingEnabled(true);
		((Control)comboExcessQQ4).set_Location(new Point(575, 41));
		((Control)comboExcessQQ4).set_Name("comboExcessQQ4");
		((Control)comboExcessQQ4).set_Size(new Size(171, 20));
		((Control)comboExcessQQ4).set_TabIndex(151);
		((Control)button1).set_Anchor((AnchorStyles)9);
		((Control)button1).set_Location(new Point(449, 3));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(21, 20));
		((Control)button1).set_TabIndex(144);
		((Control)button1).set_Text("刷");
		toolTipAll.SetToolTip((Control)(object)button1, "刷新显示需要被举报的列表");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button92).set_Anchor((AnchorStyles)9);
		((Control)button92).set_Location(new Point(395, 3));
		((Control)button92).set_Name("button92");
		((Control)button92).set_Size(new Size(21, 20));
		((Control)button92).set_TabIndex(143);
		((Control)button92).set_Text("√");
		toolTipAll.SetToolTip((Control)(object)button92, "全选");
		((ButtonBase)button92).set_UseVisualStyleBackColor(true);
		((Control)button92).add_Click((EventHandler)button92_Click);
		((Control)button93).set_Anchor((AnchorStyles)9);
		((Control)button93).set_Location(new Point(422, 3));
		((Control)button93).set_Name("button93");
		((Control)button93).set_Size(new Size(21, 20));
		((Control)button93).set_TabIndex(142);
		((Control)button93).set_Text("×");
		toolTipAll.SetToolTip((Control)(object)button93, "全不选");
		((ButtonBase)button93).set_UseVisualStyleBackColor(true);
		((Control)button93).add_Click((EventHandler)button93_Click);
		((Control)label58).set_Anchor((AnchorStyles)9);
		((Control)label58).set_ForeColor(Color.Blue);
		((Control)label58).set_Location(new Point(482, 129));
		((Control)label58).set_Name("label58");
		((Control)label58).set_Size(new Size(264, 25));
		((Control)label58).set_TabIndex(141);
		((Control)label58).set_Text("车牌号编号以逗号隔开，如1,2,3,4,5,6,7,8,9,10");
		((Control)textBox22).set_Anchor((AnchorStyles)9);
		((Control)textBox22).set_Location(new Point(482, 102));
		((Control)textBox22).set_Name("textBox22");
		((Control)textBox22).set_Size(new Size(264, 21));
		((Control)textBox22).set_TabIndex(140);
		((Control)label139).set_Anchor((AnchorStyles)9);
		((Control)label139).set_AutoSize(true);
		((Control)label139).set_ForeColor(Color.Blue);
		((Control)label139).set_Location(new Point(482, 84));
		((Control)label139).set_Name("label139");
		((Control)label139).set_Size(new Size(113, 12));
		((Control)label139).set_TabIndex(139);
		((Control)label139).set_Text("需要举报的车牌号：");
		((Control)button_31).set_Anchor((AnchorStyles)9);
		((Control)button_31).set_ForeColor(Color.Black);
		((Control)button_31).set_Location(new Point(620, 238));
		((Control)button_31).set_Name("button停止举报");
		((Control)button_31).set_Size(new Size(127, 24));
		((Control)button_31).set_TabIndex(138);
		((Control)button_31).set_Text("停止举报");
		toolTipAll.SetToolTip((Control)(object)button_31, "停止举报");
		((ButtonBase)button_31).set_UseVisualStyleBackColor(true);
		((Control)button_31).add_Click((EventHandler)button_31_Click);
		((Control)button_32).set_Anchor((AnchorStyles)9);
		((Control)button_32).set_ForeColor(Color.Black);
		((Control)button_32).set_Location(new Point(485, 238));
		((Control)button_32).set_Name("button开始举报");
		((Control)button_32).set_Size(new Size(127, 24));
		((Control)button_32).set_TabIndex(137);
		((Control)button_32).set_Text("开始举报");
		toolTipAll.SetToolTip((Control)(object)button_32, "开始举报");
		((ButtonBase)button_32).set_UseVisualStyleBackColor(true);
		((Control)button_32).add_Click((EventHandler)button_32_Click);
		((Control)button_29).set_Anchor((AnchorStyles)9);
		((Control)button_29).set_ForeColor(Color.Black);
		((Control)button_29).set_Location(new Point(620, 197));
		((Control)button_29).set_Name("button删除举报");
		((Control)button_29).set_Size(new Size(127, 24));
		((Control)button_29).set_TabIndex(134);
		((Control)button_29).set_Text("删除");
		toolTipAll.SetToolTip((Control)(object)button_29, "删除左列表中的好友");
		((ButtonBase)button_29).set_UseVisualStyleBackColor(true);
		((Control)button_29).add_Click((EventHandler)button_29_Click);
		((Control)label59).set_Anchor((AnchorStyles)9);
		((Control)label59).set_AutoSize(true);
		((Control)label59).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label59).set_ForeColor(Color.Blue);
		((Control)label59).set_Location(new Point(482, 47));
		((Control)label59).set_Name("label59");
		((Control)label59).set_Size(new Size(89, 12));
		((Control)label59).set_TabIndex(133);
		((Control)label59).set_Text("被举报QQ号码：");
		((Control)button_30).set_Anchor((AnchorStyles)9);
		((Control)button_30).set_ForeColor(Color.Black);
		((Control)button_30).set_Location(new Point(485, 197));
		((Control)button_30).set_Name("button添加举报");
		((Control)button_30).set_Size(new Size(127, 24));
		((Control)button_30).set_TabIndex(131);
		((Control)button_30).set_Text("添加");
		toolTipAll.SetToolTip((Control)(object)button_30, "添加到被举报列表");
		((ButtonBase)button_30).set_UseVisualStyleBackColor(true);
		((Control)button_30).add_Click((EventHandler)button_30_Click);
		((Control)listView_2).set_Anchor((AnchorStyles)13);
		listView_2.set_CheckBoxes(true);
		listView_2.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[3] { columnHeader297, columnHeader298, columnHeader299 });
		((Control)listView_2).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView_2).set_Cursor(Cursors.get_Default());
		((Control)listView_2).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listView_2.set_FullRowSelect(true);
		listView_2.set_GridLines(true);
		((Control)listView_2).set_Location(new Point(4, 26));
		listView_2.set_MultiSelect(false);
		((Control)listView_2).set_Name("listView举报");
		((Control)listView_2).set_Size(new Size(467, 355));
		((Control)listView_2).set_TabIndex(128);
		listView_2.set_UseCompatibleStateImageBehavior(false);
		listView_2.set_View((View)1);
		((Control)listView_2).add_MouseUp(new MouseEventHandler(listView_2_MouseUp));
		((Control)listView_2).add_MouseDown(new MouseEventHandler(listView_2_MouseDown));
		columnHeader297.set_Text("QQ号码");
		columnHeader297.set_Width(92);
		columnHeader298.set_Text("昵称");
		columnHeader298.set_Width(124);
		columnHeader299.set_Text("车牌号码");
		columnHeader299.set_Width(219);
		((Control)tabPageCheshi).get_Controls().Add((Control)(object)button_35);
		((Control)tabPageCheshi).get_Controls().Add((Control)(object)label62);
		((Control)tabPageCheshi).get_Controls().Add((Control)(object)label63);
		((Control)tabPageCheshi).get_Controls().Add((Control)(object)checkBox9);
		((Control)tabPageCheshi).get_Controls().Add((Control)(object)buttonBuyCar);
		((Control)tabPageCheshi).get_Controls().Add((Control)(object)buttonChangeCar);
		((Control)tabPageCheshi).get_Controls().Add((Control)(object)label7);
		((Control)tabPageCheshi).get_Controls().Add((Control)(object)listBuyCar);
		((Control)tabPageCheshi).get_Controls().Add((Control)(object)comboCarColor);
		((Control)tabPageCheshi).get_Controls().Add((Control)(object)comboCarType);
		((Control)tabPageCheshi).get_Controls().Add((Control)(object)listCarInfo);
		tabPageCheshi.set_Location(new Point(4, 21));
		((Control)tabPageCheshi).set_Name("tabPageCheshi");
		((Control)tabPageCheshi).set_Size(new Size(763, 530));
		tabPageCheshi.set_TabIndex(2);
		((Control)tabPageCheshi).set_Text("车市");
		tabPageCheshi.set_UseVisualStyleBackColor(true);
		((Control)button_35).set_ForeColor(Color.Red);
		((Control)button_35).set_Location(new Point(384, 192));
		((Control)button_35).set_Name("button智能换车");
		((Control)button_35).set_Size(new Size(89, 36));
		((Control)button_35).set_TabIndex(100);
		((Control)button_35).set_Text("智能换车");
		toolTipAll.SetToolTip((Control)(object)button_35, "智能换购新车辆，换车经验赚个够");
		((ButtonBase)button_35).set_UseVisualStyleBackColor(true);
		((Control)button_35).add_Click((EventHandler)button_35_Click);
		((Control)label62).set_AutoSize(true);
		((Control)label62).set_ForeColor(Color.Blue);
		((Control)label62).set_Location(new Point(272, 176));
		((Control)label62).set_Name("label62");
		((Control)label62).set_Size(new Size(65, 12));
		((Control)label62).set_TabIndex(99);
		((Control)label62).set_Text("贴条收入：");
		((Control)label63).set_AutoSize(true);
		((Control)label63).set_ForeColor(Color.Blue);
		((Control)label63).set_Location(new Point(114, 176));
		((Control)label63).set_Name("label63");
		((Control)label63).set_Size(new Size(77, 12));
		((Control)label63).set_TabIndex(98);
		((Control)label63).set_Text("当前已盈利：");
		((Control)checkBox9).set_AutoSize(true);
		((Control)checkBox9).set_ForeColor(Color.Red);
		((Control)checkBox9).set_Location(new Point(390, 172));
		((Control)checkBox9).set_Name("checkBox9");
		((Control)checkBox9).set_Size(new Size(246, 16));
		((Control)checkBox9).set_TabIndex(97);
		((Control)checkBox9).set_Text("贴条收入加入统计,并包含将来的贴条收入");
		((ButtonBase)checkBox9).set_UseVisualStyleBackColor(true);
		checkBox9.add_CheckedChanged((EventHandler)checkBox9_CheckedChanged);
		((Control)buttonBuyCar).set_Location(new Point(641, 192));
		((Control)buttonBuyCar).set_Name("buttonBuyCar");
		((Control)buttonBuyCar).set_Size(new Size(89, 36));
		((Control)buttonBuyCar).set_TabIndex(96);
		((Control)buttonBuyCar).set_Text("买车");
		toolTipAll.SetToolTip((Control)(object)buttonBuyCar, "购买新车辆");
		((ButtonBase)buttonBuyCar).set_UseVisualStyleBackColor(true);
		((Control)buttonBuyCar).add_Click((EventHandler)buttonBuyCar_Click);
		((Control)buttonChangeCar).set_Location(new Point(514, 192));
		((Control)buttonChangeCar).set_Name("buttonChangeCar");
		((Control)buttonChangeCar).set_Size(new Size(89, 36));
		((Control)buttonChangeCar).set_TabIndex(95);
		((Control)buttonChangeCar).set_Text("换车");
		toolTipAll.SetToolTip((Control)(object)buttonChangeCar, "换购新车辆");
		((ButtonBase)buttonChangeCar).set_UseVisualStyleBackColor(true);
		((Control)buttonChangeCar).add_Click((EventHandler)buttonChangeCar_Click);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_ForeColor(Color.Blue);
		((Control)label7).set_Location(new Point(12, 177));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(41, 12));
		((Control)label7).set_TabIndex(94);
		((Control)label7).set_Text("现金：");
		((Control)listBuyCar).set_Anchor((AnchorStyles)15);
		listBuyCar.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[7] { columnHeader36, columnHeader37, columnHeader38, columnHeader39, columnHeader148, columnHeader167, columnHeader300 });
		((Control)listBuyCar).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listBuyCar).set_Cursor(Cursors.get_Default());
		((Control)listBuyCar).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listBuyCar.set_FullRowSelect(true);
		listBuyCar.set_GridLines(true);
		((Control)listBuyCar).set_Location(new Point(1, 234));
		listBuyCar.set_MultiSelect(false);
		((Control)listBuyCar).set_Name("listBuyCar");
		((Control)listBuyCar).set_Size(new Size(750, 293));
		((Control)listBuyCar).set_TabIndex(93);
		listBuyCar.set_UseCompatibleStateImageBehavior(false);
		listBuyCar.set_View((View)1);
		((Control)listBuyCar).add_MouseUp(new MouseEventHandler(listBuyCar_MouseUp));
		columnHeader36.set_Text("汽车");
		columnHeader36.set_Width(120);
		columnHeader37.set_Text("价格");
		columnHeader37.set_Width(76);
		columnHeader38.set_Text("盈利");
		columnHeader38.set_Width(51);
		columnHeader39.set_Text("代码");
		columnHeader39.set_Width(47);
		columnHeader148.set_Text("预计换购时间");
		columnHeader148.set_Width(151);
		columnHeader167.set_Text("支持的颜色");
		columnHeader167.set_Width(177);
		columnHeader300.set_Text("专属车等级");
		columnHeader300.set_Width(108);
		comboCarColor.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboCarColor).set_FormattingEnabled(true);
		((Control)comboCarColor).set_Location(new Point(192, 196));
		((Control)comboCarColor).set_Name("comboCarColor");
		((Control)comboCarColor).set_Size(new Size(156, 20));
		((Control)comboCarColor).set_TabIndex(92);
		comboCarType.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboCarType).set_FormattingEnabled(true);
		((Control)comboCarType).set_Location(new Point(5, 196));
		((Control)comboCarType).set_Name("comboCarType");
		((Control)comboCarType).set_Size(new Size(171, 20));
		((Control)comboCarType).set_TabIndex(91);
		comboCarType.add_SelectedIndexChanged((EventHandler)comboCarType_SelectedIndexChanged);
		((Control)listCarInfo).set_Anchor((AnchorStyles)13);
		listCarInfo.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[9] { columnHeader27, columnHeader28, columnHeader29, columnHeader30, columnHeader31, columnHeader32, columnHeader33, columnHeader34, columnHeader35 });
		((Control)listCarInfo).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listCarInfo).set_Cursor(Cursors.get_Default());
		((Control)listCarInfo).set_Font(new Font("宋体", 9f));
		listCarInfo.set_FullRowSelect(true);
		listCarInfo.set_GridLines(true);
		((Control)listCarInfo).set_Location(new Point(0, 4));
		listCarInfo.set_MultiSelect(false);
		((Control)listCarInfo).set_Name("listCarInfo");
		((Control)listCarInfo).set_Size(new Size(763, 156));
		((Control)listCarInfo).set_TabIndex(90);
		listCarInfo.set_UseCompatibleStateImageBehavior(false);
		listCarInfo.set_View((View)1);
		((Control)listCarInfo).add_MouseUp(new MouseEventHandler(listCarInfo_MouseUp));
		columnHeader27.set_Text("当前停车处");
		columnHeader27.set_Width(97);
		columnHeader28.set_Text("昵称");
		columnHeader28.set_Width(116);
		columnHeader29.set_Text("车牌");
		columnHeader29.set_Width(47);
		columnHeader30.set_Text("颜色");
		columnHeader30.set_Width(52);
		columnHeader31.set_Text("车辆");
		columnHeader31.set_Width(101);
		columnHeader32.set_Text("价格");
		columnHeader32.set_Width(81);
		columnHeader33.set_Text("盈利");
		columnHeader34.set_Text("已停时间");
		columnHeader34.set_Width(120);
		columnHeader35.set_Text("预计收入");
		columnHeader35.set_Width(78);
		((Control)tabPageJiaoben).get_Controls().Add((Control)(object)tabControl7);
		tabPageJiaoben.set_Location(new Point(4, 21));
		((Control)tabPageJiaoben).set_Name("tabPageJiaoben");
		((Control)tabPageJiaoben).set_Size(new Size(763, 530));
		tabPageJiaoben.set_TabIndex(3);
		((Control)tabPageJiaoben).set_Text("脚本停车");
		tabPageJiaoben.set_UseVisualStyleBackColor(true);
		((Control)tabControl7).set_Anchor((AnchorStyles)15);
		((Control)tabControl7).get_Controls().Add((Control)(object)tabPage22);
		((Control)tabControl7).get_Controls().Add((Control)(object)tabPage23);
		((Control)tabControl7).set_Location(new Point(3, 3));
		((Control)tabControl7).set_Name("tabControl7");
		tabControl7.set_SelectedIndex(0);
		((Control)tabControl7).set_Size(new Size(761, 524));
		((Control)tabControl7).set_TabIndex(78);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBox18);
		((Control)tabPage22).get_Controls().Add((Control)(object)button_33);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBox14);
		((Control)tabPage22).get_Controls().Add((Control)(object)button79);
		((Control)tabPage22).get_Controls().Add((Control)(object)button80);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboExcessQQ3);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBox13);
		((Control)tabPage22).get_Controls().Add((Control)(object)label117);
		((Control)tabPage22).get_Controls().Add((Control)(object)button64);
		((Control)tabPage22).get_Controls().Add((Control)(object)button75);
		((Control)tabPage22).get_Controls().Add((Control)(object)button76);
		((Control)tabPage22).get_Controls().Add((Control)(object)label116);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxColor10);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxCarName10);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxHuanChe10);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxCar10);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxColor9);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxCarName9);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxHuanChe9);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxCar9);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxColor8);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxCarName8);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxHuanChe8);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxCar8);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxColor7);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxCarName7);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxHuanChe7);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxCar7);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxColor6);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxCarName6);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxHuanChe6);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxCar6);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxColor5);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxCarName5);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxHuanChe5);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxCar5);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxColor4);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxCarName4);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxHuanChe4);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxCar4);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxColor3);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxCarName3);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxHuanChe3);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxCar3);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxColor2);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxCarName2);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxHuanChe2);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxCar2);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxColor1);
		((Control)tabPage22).get_Controls().Add((Control)(object)comboBoxCarName1);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxHuanChe1);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBoxCar1);
		((Control)tabPage22).get_Controls().Add((Control)(object)button66);
		((Control)tabPage22).get_Controls().Add((Control)(object)button67);
		((Control)tabPage22).get_Controls().Add((Control)(object)label104);
		((Control)tabPage22).get_Controls().Add((Control)(object)textBox11);
		((Control)tabPage22).get_Controls().Add((Control)(object)label103);
		((Control)tabPage22).get_Controls().Add((Control)(object)label102);
		((Control)tabPage22).get_Controls().Add((Control)(object)textBox10);
		((Control)tabPage22).get_Controls().Add((Control)(object)label101);
		((Control)tabPage22).get_Controls().Add((Control)(object)label100);
		((Control)tabPage22).get_Controls().Add((Control)(object)label99);
		((Control)tabPage22).get_Controls().Add((Control)(object)button65);
		((Control)tabPage22).get_Controls().Add((Control)(object)textBox9);
		((Control)tabPage22).get_Controls().Add((Control)(object)label98);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBox12);
		((Control)tabPage22).get_Controls().Add((Control)(object)textBox8);
		((Control)tabPage22).get_Controls().Add((Control)(object)label97);
		((Control)tabPage22).get_Controls().Add((Control)(object)checkBox11);
		((Control)tabPage22).get_Controls().Add((Control)(object)label96);
		((Control)tabPage22).get_Controls().Add((Control)(object)textBox7);
		((Control)tabPage22).get_Controls().Add((Control)(object)label65);
		((Control)tabPage22).get_Controls().Add((Control)(object)listViewJiaoBenUser);
		((Control)tabPage22).get_Controls().Add((Control)(object)button63);
		((Control)tabPage22).get_Controls().Add((Control)(object)button62);
		tabPage22.set_Location(new Point(4, 21));
		((Control)tabPage22).set_Name("tabPage22");
		((Control)tabPage22).set_Padding(new Padding(3));
		((Control)tabPage22).set_Size(new Size(753, 499));
		tabPage22.set_TabIndex(0);
		((Control)tabPage22).set_Text("脚本配置");
		tabPage22.set_UseVisualStyleBackColor(true);
		((Control)checkBox18).set_AutoSize(true);
		((Control)checkBox18).set_ForeColor(Color.Green);
		((Control)checkBox18).set_Location(new Point(216, 5));
		((Control)checkBox18).set_Name("checkBox18");
		((Control)checkBox18).set_Size(new Size(72, 16));
		((Control)checkBox18).set_TabIndex(146);
		((Control)checkBox18).set_Text("是否举报");
		((ButtonBase)checkBox18).set_UseVisualStyleBackColor(true);
		checkBox18.add_CheckedChanged((EventHandler)checkBox18_CheckedChanged);
		((Control)button_33).set_ForeColor(Color.Red);
		((Control)button_33).set_Location(new Point(325, 3));
		((Control)button_33).set_Name("button配置脚本举报");
		((Control)button_33).set_Size(new Size(102, 31));
		((Control)button_33).set_TabIndex(154);
		((Control)button_33).set_Text("配置脚本举报");
		((ButtonBase)button_33).set_UseVisualStyleBackColor(true);
		((Control)button_33).add_Click((EventHandler)button_33_Click);
		((Control)checkBox14).set_AutoSize(true);
		((Control)checkBox14).set_ForeColor(Color.Red);
		((Control)checkBox14).set_Location(new Point(216, 25));
		((Control)checkBox14).set_Name("checkBox14");
		((Control)checkBox14).set_Size(new Size(96, 16));
		((Control)checkBox14).set_TabIndex(153);
		((Control)checkBox14).set_Text("脚本连续执行");
		toolTipAll.SetToolTip((Control)(object)checkBox14, "勾上后，只需要设置第一个号码的时间，多个号码的脚本将会连续的进行执行，不需要设置多个时间那么麻烦");
		((ButtonBase)checkBox14).set_UseVisualStyleBackColor(true);
		checkBox14.add_CheckedChanged((EventHandler)checkBox14_CheckedChanged);
		((Control)button79).set_Location(new Point(102, 26));
		((Control)button79).set_Name("button79");
		((Control)button79).set_Size(new Size(20, 20));
		((Control)button79).set_TabIndex(152);
		((Control)button79).set_Text("↑");
		toolTipAll.SetToolTip((Control)(object)button79, "上升一位");
		((ButtonBase)button79).set_UseVisualStyleBackColor(true);
		((Control)button79).add_Click((EventHandler)button79_Click);
		((Control)button80).set_Location(new Point(127, 26));
		((Control)button80).set_Name("button80");
		((Control)button80).set_Size(new Size(20, 20));
		((Control)button80).set_TabIndex(151);
		((Control)button80).set_Text("↓");
		toolTipAll.SetToolTip((Control)(object)button80, "下降一位");
		((ButtonBase)button80).set_UseVisualStyleBackColor(true);
		((Control)button80).add_Click((EventHandler)button80_Click);
		((ListControl)comboExcessQQ3).set_FormattingEnabled(true);
		((Control)comboExcessQQ3).set_Location(new Point(537, 67));
		((Control)comboExcessQQ3).set_Name("comboExcessQQ3");
		((Control)comboExcessQQ3).set_Size(new Size(195, 20));
		((Control)comboExcessQQ3).set_TabIndex(150);
		((Control)checkBox13).set_AutoSize(true);
		((Control)checkBox13).set_ForeColor(Color.Red);
		((Control)checkBox13).set_Location(new Point(217, 142));
		((Control)checkBox13).set_Name("checkBox13");
		((Control)checkBox13).set_Size(new Size(492, 16));
		((Control)checkBox13).set_TabIndex(149);
		((Control)checkBox13).set_Text("车子原地停车【因为原地比批量停多几个过程，耗时多，脚本之前间隔最好为6-10分钟】");
		((ButtonBase)checkBox13).set_UseVisualStyleBackColor(true);
		checkBox13.add_CheckedChanged((EventHandler)checkBox13_CheckedChanged);
		((Control)label117).set_AutoSize(true);
		((Control)label117).set_ForeColor(Color.Red);
		((Control)label117).set_Location(new Point(2, 9));
		((Control)label117).set_Name("label117");
		((Control)label117).set_Size(new Size(155, 12));
		((Control)label117).set_TabIndex(148);
		((Control)label117).set_Text("脚本之前间隔最好为2-3分钟");
		((Control)button64).set_ForeColor(Color.Red);
		((Control)button64).set_Location(new Point(217, 189));
		((Control)button64).set_Name("button64");
		((Control)button64).set_Size(new Size(99, 31));
		((Control)button64).set_TabIndex(147);
		((Control)button64).set_Text("读取白名单");
		toolTipAll.SetToolTip((Control)(object)button64, "可以自动加载白名单文件，就是之前在好友列表中选择存的号码");
		((ButtonBase)button64).set_UseVisualStyleBackColor(true);
		((Control)button64).add_Click((EventHandler)button64_Click);
		((Control)button75).set_Location(new Point(154, 26));
		((Control)button75).set_Name("button75");
		((Control)button75).set_Size(new Size(20, 20));
		((Control)button75).set_TabIndex(146);
		((Control)button75).set_Text("√");
		toolTipAll.SetToolTip((Control)(object)button75, "全选所有需要运行脚本的号码");
		((ButtonBase)button75).set_UseVisualStyleBackColor(true);
		((Control)button75).add_Click((EventHandler)button75_Click);
		((Control)button76).set_Location(new Point(179, 26));
		((Control)button76).set_Name("button76");
		((Control)button76).set_Size(new Size(20, 20));
		((Control)button76).set_TabIndex(145);
		((Control)button76).set_Text("×");
		toolTipAll.SetToolTip((Control)(object)button76, "全不选所有需要运行脚本的号码");
		((ButtonBase)button76).set_UseVisualStyleBackColor(true);
		((Control)button76).add_Click((EventHandler)button76_Click);
		((Control)label116).set_AutoSize(true);
		((Control)label116).set_ForeColor(Color.Red);
		((Control)label116).set_Location(new Point(456, 72));
		((Control)label116).set_Name("label116");
		((Control)label116).set_Size(new Size(77, 12));
		((Control)label116).set_TabIndex(143);
		((Control)label116).set_Text("过渡停车场：");
		comboBoxColor10.set_DropDownHeight(400);
		comboBoxColor10.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxColor10).set_FormattingEnabled(true);
		comboBoxColor10.set_IntegralHeight(false);
		((Control)comboBoxColor10).set_Location(new Point(589, 475));
		((Control)comboBoxColor10).set_Name("comboBoxColor10");
		((Control)comboBoxColor10).set_Size(new Size(156, 20));
		((Control)comboBoxColor10).set_TabIndex(142);
		comboBoxCarName10.set_DropDownHeight(400);
		comboBoxCarName10.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxCarName10).set_FormattingEnabled(true);
		comboBoxCarName10.set_IntegralHeight(false);
		((Control)comboBoxCarName10).set_Location(new Point(412, 476));
		((Control)comboBoxCarName10).set_Name("comboBoxCarName10");
		((Control)comboBoxCarName10).set_Size(new Size(171, 20));
		((Control)comboBoxCarName10).set_TabIndex(141);
		((Control)checkBoxHuanChe10).set_AutoSize(true);
		((Control)checkBoxHuanChe10).set_ForeColor(Color.Blue);
		((Control)checkBoxHuanChe10).set_Location(new Point(358, 477));
		((Control)checkBoxHuanChe10).set_Name("checkBoxHuanChe10");
		((Control)checkBoxHuanChe10).set_Size(new Size(48, 16));
		((Control)checkBoxHuanChe10).set_TabIndex(140);
		((Control)checkBoxHuanChe10).set_Text("换车");
		((ButtonBase)checkBoxHuanChe10).set_UseVisualStyleBackColor(true);
		checkBoxHuanChe10.add_CheckedChanged((EventHandler)checkBoxHuanChe10_CheckedChanged);
		((Control)checkBoxCar10).set_AutoSize(true);
		((Control)checkBoxCar10).set_ForeColor(Color.Blue);
		((Control)checkBoxCar10).set_Location(new Point(234, 479));
		((Control)checkBoxCar10).set_Name("checkBoxCar10");
		((Control)checkBoxCar10).set_Size(new Size(84, 16));
		((Control)checkBoxCar10).set_TabIndex(139);
		((Control)checkBoxCar10).set_Text("10号车停车");
		((ButtonBase)checkBoxCar10).set_UseVisualStyleBackColor(true);
		checkBoxCar10.add_CheckedChanged((EventHandler)checkBoxCar10_CheckedChanged);
		comboBoxColor9.set_DropDownHeight(400);
		comboBoxColor9.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxColor9).set_FormattingEnabled(true);
		comboBoxColor9.set_IntegralHeight(false);
		((Control)comboBoxColor9).set_Location(new Point(589, 453));
		((Control)comboBoxColor9).set_Name("comboBoxColor9");
		((Control)comboBoxColor9).set_Size(new Size(156, 20));
		((Control)comboBoxColor9).set_TabIndex(138);
		comboBoxCarName9.set_DropDownHeight(400);
		comboBoxCarName9.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxCarName9).set_FormattingEnabled(true);
		comboBoxCarName9.set_IntegralHeight(false);
		((Control)comboBoxCarName9).set_Location(new Point(412, 454));
		((Control)comboBoxCarName9).set_Name("comboBoxCarName9");
		((Control)comboBoxCarName9).set_Size(new Size(171, 20));
		((Control)comboBoxCarName9).set_TabIndex(137);
		((Control)checkBoxHuanChe9).set_AutoSize(true);
		((Control)checkBoxHuanChe9).set_ForeColor(Color.Blue);
		((Control)checkBoxHuanChe9).set_Location(new Point(358, 455));
		((Control)checkBoxHuanChe9).set_Name("checkBoxHuanChe9");
		((Control)checkBoxHuanChe9).set_Size(new Size(48, 16));
		((Control)checkBoxHuanChe9).set_TabIndex(136);
		((Control)checkBoxHuanChe9).set_Text("换车");
		((ButtonBase)checkBoxHuanChe9).set_UseVisualStyleBackColor(true);
		checkBoxHuanChe9.add_CheckedChanged((EventHandler)checkBoxHuanChe9_CheckedChanged);
		((Control)checkBoxCar9).set_AutoSize(true);
		((Control)checkBoxCar9).set_ForeColor(Color.Blue);
		((Control)checkBoxCar9).set_Location(new Point(234, 457));
		((Control)checkBoxCar9).set_Name("checkBoxCar9");
		((Control)checkBoxCar9).set_Size(new Size(78, 16));
		((Control)checkBoxCar9).set_TabIndex(135);
		((Control)checkBoxCar9).set_Text("9号车停车");
		((ButtonBase)checkBoxCar9).set_UseVisualStyleBackColor(true);
		checkBoxCar9.add_CheckedChanged((EventHandler)checkBoxCar9_CheckedChanged);
		comboBoxColor8.set_DropDownHeight(400);
		comboBoxColor8.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxColor8).set_FormattingEnabled(true);
		comboBoxColor8.set_IntegralHeight(false);
		((Control)comboBoxColor8).set_Location(new Point(589, 428));
		((Control)comboBoxColor8).set_Name("comboBoxColor8");
		((Control)comboBoxColor8).set_Size(new Size(156, 20));
		((Control)comboBoxColor8).set_TabIndex(134);
		comboBoxCarName8.set_DropDownHeight(400);
		comboBoxCarName8.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxCarName8).set_FormattingEnabled(true);
		comboBoxCarName8.set_IntegralHeight(false);
		((Control)comboBoxCarName8).set_Location(new Point(412, 429));
		((Control)comboBoxCarName8).set_Name("comboBoxCarName8");
		((Control)comboBoxCarName8).set_Size(new Size(171, 20));
		((Control)comboBoxCarName8).set_TabIndex(133);
		((Control)checkBoxHuanChe8).set_AutoSize(true);
		((Control)checkBoxHuanChe8).set_ForeColor(Color.Blue);
		((Control)checkBoxHuanChe8).set_Location(new Point(358, 430));
		((Control)checkBoxHuanChe8).set_Name("checkBoxHuanChe8");
		((Control)checkBoxHuanChe8).set_Size(new Size(48, 16));
		((Control)checkBoxHuanChe8).set_TabIndex(132);
		((Control)checkBoxHuanChe8).set_Text("换车");
		((ButtonBase)checkBoxHuanChe8).set_UseVisualStyleBackColor(true);
		checkBoxHuanChe8.add_CheckedChanged((EventHandler)checkBoxHuanChe8_CheckedChanged);
		((Control)checkBoxCar8).set_AutoSize(true);
		((Control)checkBoxCar8).set_ForeColor(Color.Blue);
		((Control)checkBoxCar8).set_Location(new Point(234, 432));
		((Control)checkBoxCar8).set_Name("checkBoxCar8");
		((Control)checkBoxCar8).set_Size(new Size(78, 16));
		((Control)checkBoxCar8).set_TabIndex(131);
		((Control)checkBoxCar8).set_Text("8号车停车");
		((ButtonBase)checkBoxCar8).set_UseVisualStyleBackColor(true);
		checkBoxCar8.add_CheckedChanged((EventHandler)checkBoxCar8_CheckedChanged);
		comboBoxColor7.set_DropDownHeight(400);
		comboBoxColor7.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxColor7).set_FormattingEnabled(true);
		comboBoxColor7.set_IntegralHeight(false);
		((Control)comboBoxColor7).set_Location(new Point(589, 404));
		((Control)comboBoxColor7).set_Name("comboBoxColor7");
		((Control)comboBoxColor7).set_Size(new Size(156, 20));
		((Control)comboBoxColor7).set_TabIndex(130);
		comboBoxCarName7.set_DropDownHeight(400);
		comboBoxCarName7.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxCarName7).set_FormattingEnabled(true);
		comboBoxCarName7.set_IntegralHeight(false);
		((Control)comboBoxCarName7).set_Location(new Point(412, 405));
		((Control)comboBoxCarName7).set_Name("comboBoxCarName7");
		((Control)comboBoxCarName7).set_Size(new Size(171, 20));
		((Control)comboBoxCarName7).set_TabIndex(129);
		((Control)checkBoxHuanChe7).set_AutoSize(true);
		((Control)checkBoxHuanChe7).set_ForeColor(Color.Blue);
		((Control)checkBoxHuanChe7).set_Location(new Point(358, 406));
		((Control)checkBoxHuanChe7).set_Name("checkBoxHuanChe7");
		((Control)checkBoxHuanChe7).set_Size(new Size(48, 16));
		((Control)checkBoxHuanChe7).set_TabIndex(128);
		((Control)checkBoxHuanChe7).set_Text("换车");
		((ButtonBase)checkBoxHuanChe7).set_UseVisualStyleBackColor(true);
		checkBoxHuanChe7.add_CheckedChanged((EventHandler)checkBoxHuanChe7_CheckedChanged);
		((Control)checkBoxCar7).set_AutoSize(true);
		((Control)checkBoxCar7).set_ForeColor(Color.Blue);
		((Control)checkBoxCar7).set_Location(new Point(234, 408));
		((Control)checkBoxCar7).set_Name("checkBoxCar7");
		((Control)checkBoxCar7).set_Size(new Size(78, 16));
		((Control)checkBoxCar7).set_TabIndex(127);
		((Control)checkBoxCar7).set_Text("7号车停车");
		((ButtonBase)checkBoxCar7).set_UseVisualStyleBackColor(true);
		checkBoxCar7.add_CheckedChanged((EventHandler)checkBoxCar7_CheckedChanged);
		comboBoxColor6.set_DropDownHeight(400);
		comboBoxColor6.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxColor6).set_FormattingEnabled(true);
		comboBoxColor6.set_IntegralHeight(false);
		((Control)comboBoxColor6).set_Location(new Point(589, 381));
		((Control)comboBoxColor6).set_Name("comboBoxColor6");
		((Control)comboBoxColor6).set_Size(new Size(156, 20));
		((Control)comboBoxColor6).set_TabIndex(126);
		comboBoxCarName6.set_DropDownHeight(400);
		comboBoxCarName6.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxCarName6).set_FormattingEnabled(true);
		comboBoxCarName6.set_IntegralHeight(false);
		((Control)comboBoxCarName6).set_Location(new Point(412, 382));
		((Control)comboBoxCarName6).set_Name("comboBoxCarName6");
		((Control)comboBoxCarName6).set_Size(new Size(171, 20));
		((Control)comboBoxCarName6).set_TabIndex(125);
		((Control)checkBoxHuanChe6).set_AutoSize(true);
		((Control)checkBoxHuanChe6).set_ForeColor(Color.Blue);
		((Control)checkBoxHuanChe6).set_Location(new Point(358, 383));
		((Control)checkBoxHuanChe6).set_Name("checkBoxHuanChe6");
		((Control)checkBoxHuanChe6).set_Size(new Size(48, 16));
		((Control)checkBoxHuanChe6).set_TabIndex(124);
		((Control)checkBoxHuanChe6).set_Text("换车");
		((ButtonBase)checkBoxHuanChe6).set_UseVisualStyleBackColor(true);
		checkBoxHuanChe6.add_CheckedChanged((EventHandler)checkBoxHuanChe6_CheckedChanged);
		((Control)checkBoxCar6).set_AutoSize(true);
		((Control)checkBoxCar6).set_ForeColor(Color.Blue);
		((Control)checkBoxCar6).set_Location(new Point(234, 385));
		((Control)checkBoxCar6).set_Name("checkBoxCar6");
		((Control)checkBoxCar6).set_Size(new Size(78, 16));
		((Control)checkBoxCar6).set_TabIndex(123);
		((Control)checkBoxCar6).set_Text("6号车停车");
		((ButtonBase)checkBoxCar6).set_UseVisualStyleBackColor(true);
		checkBoxCar6.add_CheckedChanged((EventHandler)checkBoxCar6_CheckedChanged);
		comboBoxColor5.set_DropDownHeight(400);
		comboBoxColor5.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxColor5).set_FormattingEnabled(true);
		comboBoxColor5.set_IntegralHeight(false);
		((Control)comboBoxColor5).set_Location(new Point(589, 356));
		((Control)comboBoxColor5).set_Name("comboBoxColor5");
		((Control)comboBoxColor5).set_Size(new Size(156, 20));
		((Control)comboBoxColor5).set_TabIndex(122);
		comboBoxCarName5.set_DropDownHeight(400);
		comboBoxCarName5.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxCarName5).set_FormattingEnabled(true);
		comboBoxCarName5.set_IntegralHeight(false);
		((Control)comboBoxCarName5).set_Location(new Point(412, 357));
		((Control)comboBoxCarName5).set_Name("comboBoxCarName5");
		((Control)comboBoxCarName5).set_Size(new Size(171, 20));
		((Control)comboBoxCarName5).set_TabIndex(121);
		((Control)checkBoxHuanChe5).set_AutoSize(true);
		((Control)checkBoxHuanChe5).set_ForeColor(Color.Blue);
		((Control)checkBoxHuanChe5).set_Location(new Point(358, 358));
		((Control)checkBoxHuanChe5).set_Name("checkBoxHuanChe5");
		((Control)checkBoxHuanChe5).set_Size(new Size(48, 16));
		((Control)checkBoxHuanChe5).set_TabIndex(120);
		((Control)checkBoxHuanChe5).set_Text("换车");
		((ButtonBase)checkBoxHuanChe5).set_UseVisualStyleBackColor(true);
		checkBoxHuanChe5.add_CheckedChanged((EventHandler)checkBoxHuanChe5_CheckedChanged);
		((Control)checkBoxCar5).set_AutoSize(true);
		((Control)checkBoxCar5).set_ForeColor(Color.Blue);
		((Control)checkBoxCar5).set_Location(new Point(234, 360));
		((Control)checkBoxCar5).set_Name("checkBoxCar5");
		((Control)checkBoxCar5).set_Size(new Size(78, 16));
		((Control)checkBoxCar5).set_TabIndex(119);
		((Control)checkBoxCar5).set_Text("5号车停车");
		((ButtonBase)checkBoxCar5).set_UseVisualStyleBackColor(true);
		checkBoxCar5.add_CheckedChanged((EventHandler)checkBoxCar5_CheckedChanged);
		comboBoxColor4.set_DropDownHeight(400);
		comboBoxColor4.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxColor4).set_FormattingEnabled(true);
		comboBoxColor4.set_IntegralHeight(false);
		((Control)comboBoxColor4).set_Location(new Point(589, 333));
		((Control)comboBoxColor4).set_Name("comboBoxColor4");
		((Control)comboBoxColor4).set_Size(new Size(156, 20));
		((Control)comboBoxColor4).set_TabIndex(118);
		comboBoxCarName4.set_DropDownHeight(400);
		comboBoxCarName4.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxCarName4).set_FormattingEnabled(true);
		comboBoxCarName4.set_IntegralHeight(false);
		((Control)comboBoxCarName4).set_Location(new Point(412, 334));
		((Control)comboBoxCarName4).set_Name("comboBoxCarName4");
		((Control)comboBoxCarName4).set_Size(new Size(171, 20));
		((Control)comboBoxCarName4).set_TabIndex(117);
		((Control)checkBoxHuanChe4).set_AutoSize(true);
		((Control)checkBoxHuanChe4).set_ForeColor(Color.Blue);
		((Control)checkBoxHuanChe4).set_Location(new Point(358, 335));
		((Control)checkBoxHuanChe4).set_Name("checkBoxHuanChe4");
		((Control)checkBoxHuanChe4).set_Size(new Size(48, 16));
		((Control)checkBoxHuanChe4).set_TabIndex(116);
		((Control)checkBoxHuanChe4).set_Text("换车");
		((ButtonBase)checkBoxHuanChe4).set_UseVisualStyleBackColor(true);
		checkBoxHuanChe4.add_CheckedChanged((EventHandler)checkBoxHuanChe4_CheckedChanged);
		((Control)checkBoxCar4).set_AutoSize(true);
		((Control)checkBoxCar4).set_ForeColor(Color.Blue);
		((Control)checkBoxCar4).set_Location(new Point(234, 337));
		((Control)checkBoxCar4).set_Name("checkBoxCar4");
		((Control)checkBoxCar4).set_Size(new Size(78, 16));
		((Control)checkBoxCar4).set_TabIndex(115);
		((Control)checkBoxCar4).set_Text("4号车停车");
		((ButtonBase)checkBoxCar4).set_UseVisualStyleBackColor(true);
		checkBoxCar4.add_CheckedChanged((EventHandler)checkBoxCar4_CheckedChanged);
		comboBoxColor3.set_DropDownHeight(400);
		comboBoxColor3.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxColor3).set_FormattingEnabled(true);
		comboBoxColor3.set_IntegralHeight(false);
		((Control)comboBoxColor3).set_Location(new Point(589, 309));
		((Control)comboBoxColor3).set_Name("comboBoxColor3");
		((Control)comboBoxColor3).set_Size(new Size(156, 20));
		((Control)comboBoxColor3).set_TabIndex(114);
		comboBoxCarName3.set_DropDownHeight(400);
		comboBoxCarName3.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxCarName3).set_FormattingEnabled(true);
		comboBoxCarName3.set_IntegralHeight(false);
		((Control)comboBoxCarName3).set_Location(new Point(412, 310));
		((Control)comboBoxCarName3).set_Name("comboBoxCarName3");
		((Control)comboBoxCarName3).set_Size(new Size(171, 20));
		((Control)comboBoxCarName3).set_TabIndex(113);
		((Control)checkBoxHuanChe3).set_AutoSize(true);
		((Control)checkBoxHuanChe3).set_ForeColor(Color.Blue);
		((Control)checkBoxHuanChe3).set_Location(new Point(358, 311));
		((Control)checkBoxHuanChe3).set_Name("checkBoxHuanChe3");
		((Control)checkBoxHuanChe3).set_Size(new Size(48, 16));
		((Control)checkBoxHuanChe3).set_TabIndex(112);
		((Control)checkBoxHuanChe3).set_Text("换车");
		((ButtonBase)checkBoxHuanChe3).set_UseVisualStyleBackColor(true);
		checkBoxHuanChe3.add_CheckedChanged((EventHandler)checkBoxHuanChe3_CheckedChanged);
		((Control)checkBoxCar3).set_AutoSize(true);
		((Control)checkBoxCar3).set_ForeColor(Color.Blue);
		((Control)checkBoxCar3).set_Location(new Point(234, 313));
		((Control)checkBoxCar3).set_Name("checkBoxCar3");
		((Control)checkBoxCar3).set_Size(new Size(78, 16));
		((Control)checkBoxCar3).set_TabIndex(111);
		((Control)checkBoxCar3).set_Text("3号车停车");
		((ButtonBase)checkBoxCar3).set_UseVisualStyleBackColor(true);
		checkBoxCar3.add_CheckedChanged((EventHandler)checkBoxCar3_CheckedChanged);
		comboBoxColor2.set_DropDownHeight(400);
		comboBoxColor2.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxColor2).set_FormattingEnabled(true);
		comboBoxColor2.set_IntegralHeight(false);
		((Control)comboBoxColor2).set_Location(new Point(589, 285));
		((Control)comboBoxColor2).set_Name("comboBoxColor2");
		((Control)comboBoxColor2).set_Size(new Size(156, 20));
		((Control)comboBoxColor2).set_TabIndex(110);
		comboBoxCarName2.set_DropDownHeight(400);
		comboBoxCarName2.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxCarName2).set_FormattingEnabled(true);
		comboBoxCarName2.set_IntegralHeight(false);
		((Control)comboBoxCarName2).set_Location(new Point(412, 286));
		((Control)comboBoxCarName2).set_Name("comboBoxCarName2");
		((Control)comboBoxCarName2).set_Size(new Size(171, 20));
		((Control)comboBoxCarName2).set_TabIndex(109);
		((Control)checkBoxHuanChe2).set_AutoSize(true);
		((Control)checkBoxHuanChe2).set_ForeColor(Color.Blue);
		((Control)checkBoxHuanChe2).set_Location(new Point(358, 287));
		((Control)checkBoxHuanChe2).set_Name("checkBoxHuanChe2");
		((Control)checkBoxHuanChe2).set_Size(new Size(48, 16));
		((Control)checkBoxHuanChe2).set_TabIndex(108);
		((Control)checkBoxHuanChe2).set_Text("换车");
		((ButtonBase)checkBoxHuanChe2).set_UseVisualStyleBackColor(true);
		checkBoxHuanChe2.add_CheckedChanged((EventHandler)checkBoxHuanChe2_CheckedChanged);
		((Control)checkBoxCar2).set_AutoSize(true);
		((Control)checkBoxCar2).set_ForeColor(Color.Blue);
		((Control)checkBoxCar2).set_Location(new Point(234, 289));
		((Control)checkBoxCar2).set_Name("checkBoxCar2");
		((Control)checkBoxCar2).set_Size(new Size(78, 16));
		((Control)checkBoxCar2).set_TabIndex(107);
		((Control)checkBoxCar2).set_Text("2号车停车");
		((ButtonBase)checkBoxCar2).set_UseVisualStyleBackColor(true);
		checkBoxCar2.add_CheckedChanged((EventHandler)checkBoxCar2_CheckedChanged);
		comboBoxColor1.set_DropDownHeight(400);
		comboBoxColor1.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxColor1).set_FormattingEnabled(true);
		comboBoxColor1.set_IntegralHeight(false);
		((Control)comboBoxColor1).set_Location(new Point(589, 260));
		((Control)comboBoxColor1).set_Name("comboBoxColor1");
		((Control)comboBoxColor1).set_Size(new Size(156, 20));
		((Control)comboBoxColor1).set_TabIndex(106);
		comboBoxCarName1.set_DropDownHeight(400);
		comboBoxCarName1.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxCarName1).set_FormattingEnabled(true);
		comboBoxCarName1.set_IntegralHeight(false);
		((Control)comboBoxCarName1).set_Location(new Point(412, 261));
		((Control)comboBoxCarName1).set_Name("comboBoxCarName1");
		((Control)comboBoxCarName1).set_Size(new Size(171, 20));
		((Control)comboBoxCarName1).set_TabIndex(105);
		((Control)checkBoxHuanChe1).set_AutoSize(true);
		((Control)checkBoxHuanChe1).set_ForeColor(Color.Blue);
		((Control)checkBoxHuanChe1).set_Location(new Point(358, 262));
		((Control)checkBoxHuanChe1).set_Name("checkBoxHuanChe1");
		((Control)checkBoxHuanChe1).set_Size(new Size(48, 16));
		((Control)checkBoxHuanChe1).set_TabIndex(104);
		((Control)checkBoxHuanChe1).set_Text("换车");
		((ButtonBase)checkBoxHuanChe1).set_UseVisualStyleBackColor(true);
		checkBoxHuanChe1.add_CheckedChanged((EventHandler)checkBoxHuanChe1_CheckedChanged);
		((Control)checkBoxCar1).set_AutoSize(true);
		((Control)checkBoxCar1).set_ForeColor(Color.Blue);
		((Control)checkBoxCar1).set_Location(new Point(234, 264));
		((Control)checkBoxCar1).set_Name("checkBoxCar1");
		((Control)checkBoxCar1).set_Size(new Size(78, 16));
		((Control)checkBoxCar1).set_TabIndex(103);
		((Control)checkBoxCar1).set_Text("1号车停车");
		((ButtonBase)checkBoxCar1).set_UseVisualStyleBackColor(true);
		checkBoxCar1.add_CheckedChanged((EventHandler)checkBoxCar1_CheckedChanged);
		((Control)button66).set_Location(new Point(231, 244));
		((Control)button66).set_Name("button66");
		((Control)button66).set_Size(new Size(20, 20));
		((Control)button66).set_TabIndex(99);
		((Control)button66).set_Text("√");
		toolTipAll.SetToolTip((Control)(object)button66, "全选所有的车子");
		((ButtonBase)button66).set_UseVisualStyleBackColor(true);
		((Control)button66).add_Click((EventHandler)button66_Click);
		((Control)button67).set_Location(new Point(257, 244));
		((Control)button67).set_Name("button67");
		((Control)button67).set_Size(new Size(20, 20));
		((Control)button67).set_TabIndex(98);
		((Control)button67).set_Text("×");
		toolTipAll.SetToolTip((Control)(object)button67, "全不选所有的车子");
		((ButtonBase)button67).set_UseVisualStyleBackColor(true);
		((Control)button67).add_Click((EventHandler)button67_Click);
		((Control)label104).set_ForeColor(Color.Blue);
		((Control)label104).set_Location(new Point(540, 224));
		((Control)label104).set_Name("label104");
		((Control)label104).set_Size(new Size(159, 25));
		((Control)label104).set_TabIndex(96);
		((Control)label104).set_Text("单位：毫秒，默认延时时间为1000毫秒");
		((Control)textBox11).set_Location(new Point(325, 225));
		((Control)textBox11).set_Name("textBox11");
		((Control)textBox11).set_Size(new Size(209, 21));
		((Control)textBox11).set_TabIndex(95);
		((Control)label103).set_AutoSize(true);
		((Control)label103).set_ForeColor(Color.Blue);
		((Control)label103).set_Location(new Point(217, 228));
		((Control)label103).set_Name("label103");
		((Control)label103).set_Size(new Size(65, 12));
		((Control)label103).set_TabIndex(94);
		((Control)label103).set_Text("停车延时：");
		((Control)label102).set_ForeColor(Color.Blue);
		((Control)label102).set_Location(new Point(681, 161));
		((Control)label102).set_Name("label102");
		((Control)label102).set_Size(new Size(66, 65));
		((Control)label102).set_TabIndex(93);
		((Control)label102).set_Text("停车场QQ号以逗号隔开，如\u30001111,2222,3333");
		((Control)textBox10).set_Location(new Point(320, 161));
		((TextBoxBase)textBox10).set_Multiline(true);
		((Control)textBox10).set_Name("textBox10");
		textBox10.set_ScrollBars((ScrollBars)2);
		((Control)textBox10).set_Size(new Size(355, 59));
		((Control)textBox10).set_TabIndex(92);
		((Control)label101).set_AutoSize(true);
		((Control)label101).set_ForeColor(Color.Blue);
		((Control)label101).set_Location(new Point(217, 173));
		((Control)label101).set_Name("label101");
		((Control)label101).set_Size(new Size(89, 12));
		((Control)label101).set_TabIndex(91);
		((Control)label101).set_Text("停车场QQ号码：");
		((Control)label100).set_ForeColor(Color.Blue);
		((Control)label100).set_Location(new Point(542, 114));
		((Control)label100).set_Name("label100");
		((Control)label100).set_Size(new Size(159, 25));
		((Control)label100).set_TabIndex(90);
		((Control)label100).set_Text("车子编号以逗号隔开，如\u30001,2,3,4,5,6,7,8,9,10");
		((Control)label99).set_ForeColor(Color.Blue);
		((Control)label99).set_Location(new Point(542, 92));
		((Control)label99).set_Name("label99");
		((Control)label99).set_Size(new Size(159, 19));
		((Control)label99).set_TabIndex(89);
		((Control)label99).set_Text("车位以逗号隔开，如\u30002,3,4");
		((Control)button65).set_Location(new Point(711, 3));
		((Control)button65).set_Name("button65");
		((Control)button65).set_Size(new Size(39, 22));
		((Control)button65).set_TabIndex(88);
		((Control)button65).set_Text("保存当前号码脚本");
		((ButtonBase)button65).set_UseVisualStyleBackColor(true);
		((Control)button65).set_Visible(false);
		((Control)button65).add_Click((EventHandler)button65_Click);
		((Control)textBox9).set_Location(new Point(325, 117));
		((Control)textBox9).set_Name("textBox9");
		((Control)textBox9).set_Size(new Size(209, 21));
		((Control)textBox9).set_TabIndex(87);
		((Control)label98).set_AutoSize(true);
		((Control)label98).set_ForeColor(Color.Blue);
		((Control)label98).set_Location(new Point(217, 122));
		((Control)label98).set_Name("label98");
		((Control)label98).set_Size(new Size(101, 12));
		((Control)label98).set_TabIndex(86);
		((Control)label98).set_Text("车子停车的顺序：");
		((Control)checkBox12).set_AutoSize(true);
		((Control)checkBox12).set_ForeColor(Color.Blue);
		((Control)checkBox12).set_Location(new Point(325, 71));
		((Control)checkBox12).set_Name("checkBox12");
		((Control)checkBox12).set_Size(new Size(120, 16));
		((Control)checkBox12).set_TabIndex(85);
		((Control)checkBox12).set_Text("被贴车辆是否回停");
		((ButtonBase)checkBox12).set_UseVisualStyleBackColor(true);
		checkBox12.add_CheckedChanged((EventHandler)checkBox12_CheckedChanged);
		((Control)textBox8).set_Location(new Point(325, 90));
		((Control)textBox8).set_Name("textBox8");
		((Control)textBox8).set_Size(new Size(209, 21));
		((Control)textBox8).set_TabIndex(84);
		((Control)label97).set_AutoSize(true);
		((Control)label97).set_ForeColor(Color.Blue);
		((Control)label97).set_Location(new Point(217, 96));
		((Control)label97).set_Name("label97");
		((Control)label97).set_Size(new Size(101, 12));
		((Control)label97).set_TabIndex(83);
		((Control)label97).set_Text("需要贴条的车位：");
		((Control)checkBox11).set_AutoSize(true);
		((Control)checkBox11).set_ForeColor(Color.Blue);
		((Control)checkBox11).set_Location(new Point(217, 71));
		((Control)checkBox11).set_Name("checkBox11");
		((Control)checkBox11).set_Size(new Size(72, 16));
		((Control)checkBox11).set_TabIndex(82);
		((Control)checkBox11).set_Text("是否贴条");
		((ButtonBase)checkBox11).set_UseVisualStyleBackColor(true);
		checkBox11.add_CheckedChanged((EventHandler)checkBox11_CheckedChanged);
		((Control)label96).set_ForeColor(Color.Blue);
		((Control)label96).set_Location(new Point(588, 38));
		((Control)label96).set_Name("label96");
		((Control)label96).set_Size(new Size(159, 25));
		((Control)label96).set_TabIndex(81);
		((Control)label96).set_Text("可设定多个时间，时间之间以逗号隔开,如 21:30,22:40");
		((Control)textBox7).set_Location(new Point(325, 41));
		((Control)textBox7).set_Name("textBox7");
		((Control)textBox7).set_Size(new Size(257, 21));
		((Control)textBox7).set_TabIndex(80);
		((Control)label65).set_AutoSize(true);
		((Control)label65).set_ForeColor(Color.Blue);
		((Control)label65).set_Location(new Point(217, 47));
		((Control)label65).set_Name("label65");
		((Control)label65).set_Size(new Size(89, 12));
		((Control)label65).set_TabIndex(78);
		((Control)label65).set_Text("脚本开始时间：");
		((Control)listViewJiaoBenUser).set_Anchor((AnchorStyles)7);
		listViewJiaoBenUser.set_CheckBoxes(true);
		listViewJiaoBenUser.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { columnHeader231, columnHeader232 });
		((Control)listViewJiaoBenUser).set_ContextMenuStrip(contextMenuStrip2);
		((Control)listViewJiaoBenUser).set_Cursor(Cursors.get_Default());
		((Control)listViewJiaoBenUser).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listViewJiaoBenUser.set_FullRowSelect(true);
		listViewJiaoBenUser.set_GridLines(true);
		((Control)listViewJiaoBenUser).set_Location(new Point(0, 52));
		listViewJiaoBenUser.set_MultiSelect(false);
		((Control)listViewJiaoBenUser).set_Name("listViewJiaoBenUser");
		((Control)listViewJiaoBenUser).set_Size(new Size(203, 444));
		((Control)listViewJiaoBenUser).set_TabIndex(19);
		listViewJiaoBenUser.set_UseCompatibleStateImageBehavior(false);
		listViewJiaoBenUser.set_View((View)1);
		((Control)listViewJiaoBenUser).add_MouseUp(new MouseEventHandler(listViewJiaoBenUser_MouseUp));
		((Control)listViewJiaoBenUser).add_MouseDown(new MouseEventHandler(listViewJiaoBenUser_MouseDown));
		columnHeader231.set_Text("QQ号码");
		columnHeader231.set_Width(93);
		columnHeader232.set_Text("昵称");
		columnHeader232.set_Width(89);
		((ToolStrip)contextMenuStrip2).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)toolStripMenuItem_25 });
		((Control)contextMenuStrip2).set_Name("contextMenuStrip2");
		((Control)contextMenuStrip2).set_Size(new Size(143, 26));
		((ToolStripItem)toolStripMenuItem_25).set_Name("执行脚本只对当前QQToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_25).set_Size(new Size(142, 22));
		((ToolStripItem)toolStripMenuItem_25).set_Text("立即执行脚本");
		((ToolStripItem)toolStripMenuItem_25).add_Click((EventHandler)toolStripMenuItem_25_Click);
		((Control)button63).set_Location(new Point(508, 3));
		((Control)button63).set_Name("button63");
		((Control)button63).set_Size(new Size(75, 31));
		((Control)button63).set_TabIndex(76);
		((Control)button63).set_Text("停止脚本");
		((ButtonBase)button63).set_UseVisualStyleBackColor(true);
		((Control)button63).add_Click((EventHandler)button63_Click);
		((Control)button62).set_Location(new Point(430, 3));
		((Control)button62).set_Name("button62");
		((Control)button62).set_Size(new Size(75, 31));
		((Control)button62).set_TabIndex(75);
		((Control)button62).set_Text("开始脚本");
		((ButtonBase)button62).set_UseVisualStyleBackColor(true);
		((Control)button62).add_Click((EventHandler)button62_Click);
		((Control)tabPage23).get_Controls().Add((Control)(object)button74);
		((Control)tabPage23).get_Controls().Add((Control)(object)textBox3);
		tabPage23.set_Location(new Point(4, 21));
		((Control)tabPage23).set_Name("tabPage23");
		((Control)tabPage23).set_Padding(new Padding(3));
		((Control)tabPage23).set_Size(new Size(753, 499));
		tabPage23.set_TabIndex(1);
		((Control)tabPage23).set_Text("运行记录");
		tabPage23.set_UseVisualStyleBackColor(true);
		((Control)button74).set_Anchor((AnchorStyles)9);
		((Control)button74).set_Location(new Point(677, 4));
		((Control)button74).set_Name("button74");
		((Control)button74).set_Size(new Size(75, 31));
		((Control)button74).set_TabIndex(78);
		((Control)button74).set_Text("清空记录");
		((ButtonBase)button74).set_UseVisualStyleBackColor(true);
		((Control)button74).add_Click((EventHandler)button74_Click);
		((Control)textBox3).set_Anchor((AnchorStyles)15);
		((Control)textBox3).set_BackColor(SystemColors.Info);
		((Control)textBox3).set_Location(new Point(3, 39));
		((TextBoxBase)textBox3).set_Multiline(true);
		((Control)textBox3).set_Name("textBox3");
		((TextBoxBase)textBox3).set_ReadOnly(true);
		textBox3.set_ScrollBars((ScrollBars)2);
		((Control)textBox3).set_Size(new Size(754, 466));
		((Control)textBox3).set_TabIndex(74);
		((Control)tabPageWoDeCheZiJinKuang).get_Controls().Add((Control)(object)label93);
		((Control)tabPageWoDeCheZiJinKuang).get_Controls().Add((Control)(object)textBoxWoCheWeiJinKuang);
		((Control)tabPageWoDeCheZiJinKuang).get_Controls().Add((Control)(object)textBoxWoCheZiJinKuang);
		((Control)tabPageWoDeCheZiJinKuang).get_Controls().Add((Control)(object)buttonShuaXinWoCheWeiJinKuang);
		((Control)tabPageWoDeCheZiJinKuang).get_Controls().Add((Control)(object)label92);
		((Control)tabPageWoDeCheZiJinKuang).get_Controls().Add((Control)(object)buttonShuaXinWoCheZiJinKuang);
		tabPageWoDeCheZiJinKuang.set_Location(new Point(4, 21));
		((Control)tabPageWoDeCheZiJinKuang).set_Name("tabPageWoDeCheZiJinKuang");
		((Control)tabPageWoDeCheZiJinKuang).set_Size(new Size(763, 530));
		tabPageWoDeCheZiJinKuang.set_TabIndex(4);
		((Control)tabPageWoDeCheZiJinKuang).set_Text("我的车子近况");
		tabPageWoDeCheZiJinKuang.set_UseVisualStyleBackColor(true);
		((Control)label93).set_AutoSize(true);
		((Control)label93).set_Font(new Font("宋体", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)134));
		((Control)label93).set_ForeColor(Color.Blue);
		((Control)label93).set_Location(new Point(300, 277));
		((Control)label93).set_Name("label93");
		((Control)label93).set_Size(new Size(83, 12));
		((Control)label93).set_TabIndex(79);
		((Control)label93).set_Text("我的车位近况");
		((Control)textBoxWoCheWeiJinKuang).set_Anchor((AnchorStyles)15);
		((Control)textBoxWoCheWeiJinKuang).set_BackColor(SystemColors.Info);
		((Control)textBoxWoCheWeiJinKuang).set_Location(new Point(1, 300));
		((TextBoxBase)textBoxWoCheWeiJinKuang).set_Multiline(true);
		((Control)textBoxWoCheWeiJinKuang).set_Name("textBoxWoCheWeiJinKuang");
		((TextBoxBase)textBoxWoCheWeiJinKuang).set_ReadOnly(true);
		textBoxWoCheWeiJinKuang.set_ScrollBars((ScrollBars)2);
		((Control)textBoxWoCheWeiJinKuang).set_Size(new Size(761, 229));
		((Control)textBoxWoCheWeiJinKuang).set_TabIndex(78);
		((Control)textBoxWoCheZiJinKuang).set_Anchor((AnchorStyles)13);
		((Control)textBoxWoCheZiJinKuang).set_BackColor(SystemColors.Info);
		((Control)textBoxWoCheZiJinKuang).set_Location(new Point(1, 36));
		((TextBoxBase)textBoxWoCheZiJinKuang).set_Multiline(true);
		((Control)textBoxWoCheZiJinKuang).set_Name("textBoxWoCheZiJinKuang");
		((TextBoxBase)textBoxWoCheZiJinKuang).set_ReadOnly(true);
		textBoxWoCheZiJinKuang.set_ScrollBars((ScrollBars)2);
		((Control)textBoxWoCheZiJinKuang).set_Size(new Size(761, 229));
		((Control)textBoxWoCheZiJinKuang).set_TabIndex(72);
		((Control)buttonShuaXinWoCheWeiJinKuang).set_Anchor((AnchorStyles)9);
		((Control)buttonShuaXinWoCheWeiJinKuang).set_Location(new Point(704, 268));
		((Control)buttonShuaXinWoCheWeiJinKuang).set_Name("buttonShuaXinWoCheWeiJinKuang");
		((Control)buttonShuaXinWoCheWeiJinKuang).set_Size(new Size(56, 30));
		((Control)buttonShuaXinWoCheWeiJinKuang).set_TabIndex(77);
		((Control)buttonShuaXinWoCheWeiJinKuang).set_Text("刷");
		toolTipAll.SetToolTip((Control)(object)buttonShuaXinWoCheWeiJinKuang, "刷新我的车辆近况");
		((ButtonBase)buttonShuaXinWoCheWeiJinKuang).set_UseVisualStyleBackColor(true);
		((Control)buttonShuaXinWoCheWeiJinKuang).add_Click((EventHandler)buttonShuaXinWoCheWeiJinKuang_Click);
		((Control)label92).set_AutoSize(true);
		((Control)label92).set_Font(new Font("宋体", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)134));
		((Control)label92).set_ForeColor(Color.Blue);
		((Control)label92).set_Location(new Point(300, 12));
		((Control)label92).set_Name("label92");
		((Control)label92).set_Size(new Size(83, 12));
		((Control)label92).set_TabIndex(76);
		((Control)label92).set_Text("我的车子近况");
		((Control)buttonShuaXinWoCheZiJinKuang).set_Anchor((AnchorStyles)9);
		((Control)buttonShuaXinWoCheZiJinKuang).set_Location(new Point(704, 3));
		((Control)buttonShuaXinWoCheZiJinKuang).set_Name("buttonShuaXinWoCheZiJinKuang");
		((Control)buttonShuaXinWoCheZiJinKuang).set_Size(new Size(56, 30));
		((Control)buttonShuaXinWoCheZiJinKuang).set_TabIndex(71);
		((Control)buttonShuaXinWoCheZiJinKuang).set_Text("刷");
		toolTipAll.SetToolTip((Control)(object)buttonShuaXinWoCheZiJinKuang, "刷新我的车辆近况");
		((ButtonBase)buttonShuaXinWoCheZiJinKuang).set_UseVisualStyleBackColor(true);
		((Control)buttonShuaXinWoCheZiJinKuang).add_Click((EventHandler)buttonShuaXinWoCheZiJinKuang_Click);
		((Control)tabPage20).get_Controls().Add((Control)(object)label91);
		((Control)tabPage20).get_Controls().Add((Control)(object)textBoxQueryQQNum);
		((Control)tabPage20).get_Controls().Add((Control)(object)textBoxHaoYouTingCheXin);
		((Control)tabPage20).get_Controls().Add((Control)(object)buttonChaKanHaoYouTingCheJiLu);
		tabPage20.set_Location(new Point(4, 21));
		((Control)tabPage20).set_Name("tabPage20");
		((Control)tabPage20).set_Size(new Size(763, 530));
		tabPage20.set_TabIndex(6);
		((Control)tabPage20).set_Text("好友停车记录");
		tabPage20.set_UseVisualStyleBackColor(true);
		((Control)label91).set_AutoSize(true);
		((Control)label91).set_Location(new Point(13, 20));
		((Control)label91).set_Name("label91");
		((Control)label91).set_Size(new Size(125, 12));
		((Control)label91).set_TabIndex(75);
		((Control)label91).set_Text("输入需要查询的QQ号码");
		((Control)textBoxQueryQQNum).set_Location(new Point(143, 14));
		((Control)textBoxQueryQQNum).set_Name("textBoxQueryQQNum");
		((Control)textBoxQueryQQNum).set_Size(new Size(184, 21));
		((Control)textBoxQueryQQNum).set_TabIndex(74);
		((Control)textBoxQueryQQNum).add_KeyDown(new KeyEventHandler(textBoxQueryQQNum_KeyDown));
		((Control)textBoxHaoYouTingCheXin).set_Anchor((AnchorStyles)15);
		((Control)textBoxHaoYouTingCheXin).set_BackColor(SystemColors.Info);
		((Control)textBoxHaoYouTingCheXin).set_Location(new Point(0, 50));
		((TextBoxBase)textBoxHaoYouTingCheXin).set_Multiline(true);
		((Control)textBoxHaoYouTingCheXin).set_Name("textBoxHaoYouTingCheXin");
		((TextBoxBase)textBoxHaoYouTingCheXin).set_ReadOnly(true);
		textBoxHaoYouTingCheXin.set_ScrollBars((ScrollBars)2);
		((Control)textBoxHaoYouTingCheXin).set_Size(new Size(761, 480));
		((Control)textBoxHaoYouTingCheXin).set_TabIndex(73);
		((Control)buttonChaKanHaoYouTingCheJiLu).set_Location(new Point(338, 12));
		((Control)buttonChaKanHaoYouTingCheJiLu).set_Name("buttonChaKanHaoYouTingCheJiLu");
		((Control)buttonChaKanHaoYouTingCheJiLu).set_Size(new Size(60, 24));
		((Control)buttonChaKanHaoYouTingCheJiLu).set_TabIndex(72);
		((Control)buttonChaKanHaoYouTingCheJiLu).set_Text("查");
		toolTipAll.SetToolTip((Control)(object)buttonChaKanHaoYouTingCheJiLu, "刷新我的车辆近况");
		((ButtonBase)buttonChaKanHaoYouTingCheJiLu).set_UseVisualStyleBackColor(true);
		((Control)buttonChaKanHaoYouTingCheJiLu).add_Click((EventHandler)buttonChaKanHaoYouTingCheJiLu_Click);
		((Control)tabPage21).get_Controls().Add((Control)(object)labelYeMa);
		((Control)tabPage21).get_Controls().Add((Control)(object)buttonWeiYe);
		((Control)tabPage21).get_Controls().Add((Control)(object)buttonShouYe);
		((Control)tabPage21).get_Controls().Add((Control)(object)buttonShangYe);
		((Control)tabPage21).get_Controls().Add((Control)(object)buttonXiaYe);
		((Control)tabPage21).get_Controls().Add((Control)(object)listViewPaiMin);
		((Control)tabPage21).get_Controls().Add((Control)(object)buttonZongPaiHangBang);
		tabPage21.set_Location(new Point(4, 21));
		((Control)tabPage21).set_Name("tabPage21");
		((Control)tabPage21).set_Size(new Size(763, 530));
		tabPage21.set_TabIndex(7);
		((Control)tabPage21).set_Text("QQ抢车位小谢排行榜");
		tabPage21.set_UseVisualStyleBackColor(true);
		((Control)labelYeMa).set_AutoSize(true);
		((Control)labelYeMa).set_ForeColor(Color.Blue);
		((Control)labelYeMa).set_Location(new Point(100, 15));
		((Control)labelYeMa).set_Name("labelYeMa");
		((Control)labelYeMa).set_Size(new Size(41, 12));
		((Control)labelYeMa).set_TabIndex(96);
		((Control)labelYeMa).set_Text("页码：");
		((Control)buttonWeiYe).set_Anchor((AnchorStyles)9);
		((Control)buttonWeiYe).set_Location(new Point(424, 3));
		((Control)buttonWeiYe).set_Name("buttonWeiYe");
		((Control)buttonWeiYe).set_Size(new Size(56, 30));
		((Control)buttonWeiYe).set_TabIndex(95);
		((Control)buttonWeiYe).set_Text("尾页");
		toolTipAll.SetToolTip((Control)(object)buttonWeiYe, "尾页");
		((ButtonBase)buttonWeiYe).set_UseVisualStyleBackColor(true);
		((Control)buttonWeiYe).add_Click((EventHandler)buttonWeiYe_Click);
		((Control)buttonShouYe).set_Anchor((AnchorStyles)9);
		((Control)buttonShouYe).set_Location(new Point(208, 4));
		((Control)buttonShouYe).set_Name("buttonShouYe");
		((Control)buttonShouYe).set_Size(new Size(56, 30));
		((Control)buttonShouYe).set_TabIndex(94);
		((Control)buttonShouYe).set_Text("首页");
		toolTipAll.SetToolTip((Control)(object)buttonShouYe, "首页");
		((ButtonBase)buttonShouYe).set_UseVisualStyleBackColor(true);
		((Control)buttonShouYe).add_Click((EventHandler)buttonShouYe_Click);
		((Control)buttonShangYe).set_Anchor((AnchorStyles)9);
		((Control)buttonShangYe).set_Location(new Point(352, 4));
		((Control)buttonShangYe).set_Name("buttonShangYe");
		((Control)buttonShangYe).set_Size(new Size(56, 30));
		((Control)buttonShangYe).set_TabIndex(93);
		((Control)buttonShangYe).set_Text("上页");
		toolTipAll.SetToolTip((Control)(object)buttonShangYe, "上页");
		((ButtonBase)buttonShangYe).set_UseVisualStyleBackColor(true);
		((Control)buttonShangYe).add_Click((EventHandler)buttonShangYe_Click);
		((Control)buttonXiaYe).set_Anchor((AnchorStyles)9);
		((Control)buttonXiaYe).set_Location(new Point(280, 4));
		((Control)buttonXiaYe).set_Name("buttonXiaYe");
		((Control)buttonXiaYe).set_Size(new Size(56, 30));
		((Control)buttonXiaYe).set_TabIndex(92);
		((Control)buttonXiaYe).set_Text("下页");
		toolTipAll.SetToolTip((Control)(object)buttonXiaYe, "下页");
		((ButtonBase)buttonXiaYe).set_UseVisualStyleBackColor(true);
		((Control)buttonXiaYe).add_Click((EventHandler)buttonXiaYe_Click);
		((Control)listViewPaiMin).set_Anchor((AnchorStyles)15);
		listViewPaiMin.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[8] { columnHeader224, columnHeader225, columnHeader226, columnHeader227, columnHeader228, columnHeader229, columnHeader296, columnHeader230 });
		((Control)listViewPaiMin).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listViewPaiMin).set_Cursor(Cursors.get_Default());
		((Control)listViewPaiMin).set_Font(new Font("宋体", 9f));
		listViewPaiMin.set_FullRowSelect(true);
		listViewPaiMin.set_GridLines(true);
		((Control)listViewPaiMin).set_Location(new Point(0, 38));
		listViewPaiMin.set_MultiSelect(false);
		((Control)listViewPaiMin).set_Name("listViewPaiMin");
		((Control)listViewPaiMin).set_Size(new Size(763, 489));
		((Control)listViewPaiMin).set_TabIndex(91);
		listViewPaiMin.set_UseCompatibleStateImageBehavior(false);
		listViewPaiMin.set_View((View)1);
		((Control)listViewPaiMin).add_MouseUp(new MouseEventHandler(listViewPaiMin_MouseUp));
		columnHeader224.set_Text("排名");
		columnHeader224.set_Width(49);
		columnHeader225.set_Text("QQ号码");
		columnHeader225.set_Width(89);
		columnHeader226.set_Text("昵称");
		columnHeader226.set_Width(117);
		columnHeader227.set_Text("总资产");
		columnHeader227.set_Width(97);
		columnHeader228.set_Text("现金");
		columnHeader228.set_Width(86);
		columnHeader229.set_Text("汽车价格");
		columnHeader229.set_Width(83);
		columnHeader296.set_Text("经验");
		columnHeader296.set_Width(103);
		columnHeader230.set_Text("开通日期");
		columnHeader230.set_Width(110);
		((Control)buttonZongPaiHangBang).set_Anchor((AnchorStyles)9);
		((Control)buttonZongPaiHangBang).set_Location(new Point(703, 4));
		((Control)buttonZongPaiHangBang).set_Name("buttonZongPaiHangBang");
		((Control)buttonZongPaiHangBang).set_Size(new Size(56, 30));
		((Control)buttonZongPaiHangBang).set_TabIndex(73);
		((Control)buttonZongPaiHangBang).set_Text("刷");
		toolTipAll.SetToolTip((Control)(object)buttonZongPaiHangBang, "刷新总排名");
		((ButtonBase)buttonZongPaiHangBang).set_UseVisualStyleBackColor(true);
		((Control)buttonZongPaiHangBang).add_Click((EventHandler)buttonZongPaiHangBang_Click);
		((Control)tabPageFriendBuy).set_BackColor(Color.Transparent);
		((Control)tabPageFriendBuy).get_Controls().Add((Control)(object)tabControl5);
		((Control)tabPageFriendBuy).get_Controls().Add((Control)(object)tabControl9);
		tabPageFriendBuy.set_Location(new Point(4, 21));
		((Control)tabPageFriendBuy).set_Name("tabPageFriendBuy");
		((Control)tabPageFriendBuy).set_Padding(new Padding(3));
		((Control)tabPageFriendBuy).set_Size(new Size(774, 547));
		tabPageFriendBuy.set_TabIndex(1);
		((Control)tabPageFriendBuy).set_Text("好友买卖");
		tabPageFriendBuy.set_UseVisualStyleBackColor(true);
		((Control)tabControl5).set_Anchor((AnchorStyles)15);
		((Control)tabControl5).get_Controls().Add((Control)(object)tabPageShiJian);
		((Control)tabControl5).get_Controls().Add((Control)(object)tabPageJilu);
		((Control)tabControl5).set_Location(new Point(4, 405));
		((Control)tabControl5).set_Name("tabControl5");
		tabControl5.set_SelectedIndex(1);
		((Control)tabControl5).set_Size(new Size(769, 146));
		((Control)tabControl5).set_TabIndex(54);
		((Control)tabPageShiJian).get_Controls().Add((Control)(object)button_16);
		((Control)tabPageShiJian).get_Controls().Add((Control)(object)textBoxShiJian);
		tabPageShiJian.set_Location(new Point(4, 21));
		((Control)tabPageShiJian).set_Name("tabPageShiJian");
		((Control)tabPageShiJian).set_Size(new Size(761, 121));
		tabPageShiJian.set_TabIndex(2);
		((Control)tabPageShiJian).set_Text("最近事件");
		tabPageShiJian.set_UseVisualStyleBackColor(true);
		((Control)button_16).set_Anchor((AnchorStyles)9);
		((Control)button_16).set_ForeColor(Color.Red);
		((Control)button_16).set_Location(new Point(738, 1));
		((Control)button_16).set_Name("button刷新最近事件");
		((Control)button_16).set_Size(new Size(21, 20));
		((Control)button_16).set_TabIndex(91);
		((Control)button_16).set_Text("刷");
		toolTipAll.SetToolTip((Control)(object)button_16, "刷新最近事件");
		((ButtonBase)button_16).set_UseVisualStyleBackColor(true);
		((Control)button_16).add_Click((EventHandler)button_16_Click);
		((Control)textBoxShiJian).set_Anchor((AnchorStyles)15);
		((Control)textBoxShiJian).set_BackColor(SystemColors.Info);
		((Control)textBoxShiJian).set_Location(new Point(1, 25));
		((TextBoxBase)textBoxShiJian).set_Multiline(true);
		((Control)textBoxShiJian).set_Name("textBoxShiJian");
		((TextBoxBase)textBoxShiJian).set_ReadOnly(true);
		textBoxShiJian.set_ScrollBars((ScrollBars)2);
		((Control)textBoxShiJian).set_Size(new Size(761, 94));
		((Control)textBoxShiJian).set_TabIndex(1);
		((Control)tabPageJilu).get_Controls().Add((Control)(object)textBoxNuLiShiJian);
		tabPageJilu.set_Location(new Point(4, 21));
		((Control)tabPageJilu).set_Name("tabPageJilu");
		((Control)tabPageJilu).set_Padding(new Padding(3));
		((Control)tabPageJilu).set_Size(new Size(761, 121));
		tabPageJilu.set_TabIndex(0);
		((Control)tabPageJilu).set_Text("运行记录");
		tabPageJilu.set_UseVisualStyleBackColor(true);
		((Control)textBoxNuLiShiJian).set_Anchor((AnchorStyles)15);
		((Control)textBoxNuLiShiJian).set_BackColor(SystemColors.Info);
		((Control)textBoxNuLiShiJian).set_Location(new Point(1, 1));
		((TextBoxBase)textBoxNuLiShiJian).set_Multiline(true);
		((Control)textBoxNuLiShiJian).set_Name("textBoxNuLiShiJian");
		((TextBoxBase)textBoxNuLiShiJian).set_ReadOnly(true);
		textBoxNuLiShiJian.set_ScrollBars((ScrollBars)2);
		((Control)textBoxNuLiShiJian).set_Size(new Size(761, 124));
		((Control)textBoxNuLiShiJian).set_TabIndex(0);
		((Control)tabControl9).set_Anchor((AnchorStyles)15);
		((Control)tabControl9).get_Controls().Add((Control)(object)tabPage24);
		((Control)tabControl9).get_Controls().Add((Control)(object)tabPage25);
		((Control)tabControl9).get_Controls().Add((Control)(object)tabPage26);
		((Control)tabControl9).set_Location(new Point(4, 3));
		((Control)tabControl9).set_Name("tabControl9");
		tabControl9.set_SelectedIndex(0);
		((Control)tabControl9).set_Size(new Size(772, 403));
		((Control)tabControl9).set_TabIndex(98);
		tabControl9.add_Selected(new TabControlEventHandler(tabControl9_Selected));
		((Control)tabPage24).get_Controls().Add((Control)(object)button_4);
		((Control)tabPage24).get_Controls().Add((Control)(object)listViewSlave);
		((Control)tabPage24).get_Controls().Add((Control)(object)button_3);
		((Control)tabPage24).get_Controls().Add((Control)(object)listBoxMast);
		((Control)tabPage24).get_Controls().Add((Control)(object)button_1);
		((Control)tabPage24).get_Controls().Add((Control)(object)listBoxMy);
		((Control)tabPage24).get_Controls().Add((Control)(object)button_2);
		((Control)tabPage24).get_Controls().Add((Control)(object)label15);
		((Control)tabPage24).get_Controls().Add((Control)(object)buttonYiJianHaoYouMaiMai);
		((Control)tabPage24).get_Controls().Add((Control)(object)label13);
		((Control)tabPage24).get_Controls().Add((Control)(object)buttonTaoHaoZhuRen);
		((Control)tabPage24).get_Controls().Add((Control)(object)buttonQingKongCuoHao);
		((Control)tabPage24).get_Controls().Add((Control)(object)buttonDaZhe);
		((Control)tabPage24).get_Controls().Add((Control)(object)buttonWoYaoSuShen);
		((Control)tabPage24).get_Controls().Add((Control)(object)buttonShiFang);
		((Control)tabPage24).get_Controls().Add((Control)(object)buttonMinYunKa);
		((Control)tabPage24).get_Controls().Add((Control)(object)buttonShuaXin);
		((Control)tabPage24).get_Controls().Add((Control)(object)comboBoxTaoHaoZhuRen);
		((Control)tabPage24).get_Controls().Add((Control)(object)buttonZhiXing);
		((Control)tabPage24).get_Controls().Add((Control)(object)comboBoxZheMo);
		((Control)tabPage24).get_Controls().Add((Control)(object)buttonQuanXuan);
		((Control)tabPage24).get_Controls().Add((Control)(object)comboBoxAnFu);
		((Control)tabPage24).get_Controls().Add((Control)(object)buttonQuanBuXuan);
		((Control)tabPage24).get_Controls().Add((Control)(object)comboBoxDaZhe);
		tabPage24.set_Location(new Point(4, 21));
		((Control)tabPage24).set_Name("tabPage24");
		((Control)tabPage24).set_Padding(new Padding(3));
		((Control)tabPage24).set_Size(new Size(764, 378));
		tabPage24.set_TabIndex(0);
		((Control)tabPage24).set_Text("基本信息");
		tabPage24.set_UseVisualStyleBackColor(true);
		((Control)button_4).set_ForeColor(Color.Black);
		((Control)button_4).set_Location(new Point(679, 101));
		((Control)button_4).set_Name("button停止回购奴隶");
		((Control)button_4).set_Size(new Size(76, 24));
		((Control)button_4).set_TabIndex(97);
		((Control)button_4).set_Text("停止[回购]");
		toolTipAll.SetToolTip((Control)(object)button_4, "开始如果奴隶被别人买走，马上进行回购");
		((ButtonBase)button_4).set_UseVisualStyleBackColor(true);
		((Control)button_4).add_Click((EventHandler)button_4_Click);
		((Control)listViewSlave).set_Anchor((AnchorStyles)13);
		listViewSlave.set_CheckBoxes(true);
		listViewSlave.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[14]
		{
			columnHeader149, columnHeader150, columnHeader151, columnHeader152, columnHeader153, columnHeader154, columnHeader155, columnHeader156, columnHeader157, columnHeader158,
			columnHeader238, columnHeader239, columnHeader240, columnHeader245
		});
		((Control)listViewSlave).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listViewSlave).set_Cursor(Cursors.get_Default());
		((Control)listViewSlave).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listViewSlave.set_FullRowSelect(true);
		listViewSlave.set_GridLines(true);
		((Control)listViewSlave).set_Location(new Point(0, 175));
		listViewSlave.set_MultiSelect(false);
		((Control)listViewSlave).set_Name("listViewSlave");
		((Control)listViewSlave).set_Size(new Size(770, 200));
		((Control)listViewSlave).set_TabIndex(53);
		listViewSlave.set_UseCompatibleStateImageBehavior(false);
		listViewSlave.set_View((View)1);
		((Control)listViewSlave).add_MouseUp(new MouseEventHandler(listViewSlave_MouseUp));
		columnHeader149.set_Text("QQ号码");
		columnHeader149.set_Width(92);
		columnHeader150.set_Text("昵称");
		columnHeader150.set_Width(83);
		columnHeader151.set_Text("绰号");
		columnHeader151.set_Width(65);
		columnHeader152.set_Text("身价");
		columnHeader152.set_Width(46);
		columnHeader153.set_Text("资产");
		columnHeader153.set_Width(59);
		columnHeader154.set_Text("现金");
		columnHeader154.set_Width(56);
		columnHeader155.set_Text("奴隶");
		columnHeader155.set_Width(48);
		columnHeader156.set_Text("买入次数");
		columnHeader156.set_Width(65);
		columnHeader157.set_Text("买入价格");
		columnHeader157.set_Width(68);
		columnHeader158.set_Text("买入时间");
		columnHeader158.set_Width(73);
		columnHeader238.set_Text("最近状态");
		columnHeader238.set_Width(138);
		columnHeader239.set_Text("开始时间");
		columnHeader239.set_Width(138);
		columnHeader240.set_Text("结束时间");
		columnHeader240.set_Width(138);
		columnHeader245.set_Text("经验值");
		((Control)button_3).set_ForeColor(Color.Black);
		((Control)button_3).set_Location(new Point(598, 101));
		((Control)button_3).set_Name("button开始回购奴隶");
		((Control)button_3).set_Size(new Size(75, 24));
		((Control)button_3).set_TabIndex(96);
		((Control)button_3).set_Text("开始[回购]");
		toolTipAll.SetToolTip((Control)(object)button_3, "开始如果奴隶被别人买走，马上进行回购");
		((ButtonBase)button_3).set_UseVisualStyleBackColor(true);
		((Control)button_3).add_Click((EventHandler)button_3_Click);
		((Control)listBoxMast).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listBoxMast).set_Font(new Font("宋体", 9f));
		((ListControl)listBoxMast).set_FormattingEnabled(true);
		listBoxMast.set_ItemHeight(12);
		((Control)listBoxMast).set_Location(new Point(206, 14));
		((Control)listBoxMast).set_Name("listBoxMast");
		((Control)listBoxMast).set_Size(new Size(200, 160));
		((Control)listBoxMast).set_TabIndex(51);
		((Control)listBoxMast).add_MouseUp(new MouseEventHandler(listBoxMast_MouseUp));
		((Control)button_1).set_Anchor((AnchorStyles)9);
		((Control)button_1).set_ForeColor(Color.Black);
		((Control)button_1).set_Location(new Point(678, 144));
		((Control)button_1).set_Name("button释买");
		((Control)button_1).set_Size(new Size(38, 20));
		((Control)button_1).set_TabIndex(95);
		((Control)button_1).set_Text("释买");
		toolTipAll.SetToolTip((Control)(object)button_1, "释放奴隶并回购");
		((ButtonBase)button_1).set_UseVisualStyleBackColor(true);
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((Control)listBoxMy).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listBoxMy).set_Font(new Font("宋体", 9f));
		((ListControl)listBoxMy).set_FormattingEnabled(true);
		listBoxMy.set_ItemHeight(12);
		((Control)listBoxMy).set_Location(new Point(0, 14));
		((Control)listBoxMy).set_Name("listBoxMy");
		((Control)listBoxMy).set_Size(new Size(200, 160));
		((Control)listBoxMy).set_TabIndex(48);
		((Control)listBoxMy).add_MouseUp(new MouseEventHandler(listBoxMy_MouseUp));
		((Control)button_2).set_Anchor((AnchorStyles)9);
		((Control)button_2).set_ForeColor(Color.Black);
		((Control)button_2).set_Location(new Point(583, 144));
		((Control)button_2).set_Name("button筛");
		((Control)button_2).set_Size(new Size(20, 20));
		((Control)button_2).set_TabIndex(94);
		((Control)button_2).set_Text("筛");
		toolTipAll.SetToolTip((Control)(object)button_2, "自动选中购买时间有3天的奴隶，且奴隶没有在工作中");
		((ButtonBase)button_2).set_UseVisualStyleBackColor(true);
		((Control)button_2).add_Click((EventHandler)button_2_Click);
		((Control)label15).set_BackColor(SystemColors.InactiveCaptionText);
		((Control)label15).set_Font(new Font("宋体", 9f, (FontStyle)1));
		((Control)label15).set_ForeColor(Color.Blue);
		((Control)label15).set_Location(new Point(0, 1));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(200, 13));
		((Control)label15).set_TabIndex(49);
		((Control)label15).set_Text("我自己");
		((Control)buttonYiJianHaoYouMaiMai).set_ForeColor(Color.Red);
		((Control)buttonYiJianHaoYouMaiMai).set_Location(new Point(637, 69));
		((Control)buttonYiJianHaoYouMaiMai).set_Name("buttonYiJianHaoYouMaiMai");
		((Control)buttonYiJianHaoYouMaiMai).set_Size(new Size(118, 24));
		((Control)buttonYiJianHaoYouMaiMai).set_TabIndex(93);
		((Control)buttonYiJianHaoYouMaiMai).set_Text("一键式");
		toolTipAll.SetToolTip((Control)(object)buttonYiJianHaoYouMaiMai, "命运卡，讨好主人，执行折磨和安抚全部奴隶，智能选择最优化的方式进行");
		((ButtonBase)buttonYiJianHaoYouMaiMai).set_UseVisualStyleBackColor(true);
		((Control)buttonYiJianHaoYouMaiMai).add_Click((EventHandler)buttonYiJianHaoYouMaiMai_Click);
		((Control)label13).set_BackColor(SystemColors.InactiveCaptionText);
		((Control)label13).set_Font(new Font("宋体", 9f, (FontStyle)1));
		((Control)label13).set_ForeColor(Color.Blue);
		((Control)label13).set_Location(new Point(206, 1));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(200, 13));
		((Control)label13).set_TabIndex(52);
		((Control)label13).set_Text("我的主人");
		((Control)buttonTaoHaoZhuRen).set_Location(new Point(637, 36));
		((Control)buttonTaoHaoZhuRen).set_Name("buttonTaoHaoZhuRen");
		((Control)buttonTaoHaoZhuRen).set_Size(new Size(118, 24));
		((Control)buttonTaoHaoZhuRen).set_TabIndex(92);
		((Control)buttonTaoHaoZhuRen).set_Text("讨好主人");
		toolTipAll.SetToolTip((Control)(object)buttonTaoHaoZhuRen, "讨好主人");
		((ButtonBase)buttonTaoHaoZhuRen).set_UseVisualStyleBackColor(true);
		((Control)buttonTaoHaoZhuRen).add_Click((EventHandler)buttonTaoHaoZhuRen_Click);
		((Control)buttonQingKongCuoHao).set_Location(new Point(419, 6));
		((Control)buttonQingKongCuoHao).set_Name("buttonQingKongCuoHao");
		((Control)buttonQingKongCuoHao).set_Size(new Size(75, 23));
		((Control)buttonQingKongCuoHao).set_TabIndex(55);
		((Control)buttonQingKongCuoHao).set_Text("清空绰号");
		((ButtonBase)buttonQingKongCuoHao).set_UseVisualStyleBackColor(true);
		((Control)buttonQingKongCuoHao).add_Click((EventHandler)buttonQingKongCuoHao_Click);
		((Control)buttonDaZhe).set_Anchor((AnchorStyles)9);
		((Control)buttonDaZhe).set_Location(new Point(487, 144));
		((Control)buttonDaZhe).set_Name("buttonDaZhe");
		((Control)buttonDaZhe).set_Size(new Size(21, 20));
		((Control)buttonDaZhe).set_TabIndex(91);
		((Control)buttonDaZhe).set_Text("折");
		toolTipAll.SetToolTip((Control)(object)buttonDaZhe, "打折奴隶");
		((ButtonBase)buttonDaZhe).set_UseVisualStyleBackColor(true);
		((Control)buttonDaZhe).add_Click((EventHandler)buttonDaZhe_Click);
		((Control)buttonWoYaoSuShen).set_Location(new Point(508, 6));
		((Control)buttonWoYaoSuShen).set_Name("buttonWoYaoSuShen");
		((Control)buttonWoYaoSuShen).set_Size(new Size(75, 23));
		((Control)buttonWoYaoSuShen).set_TabIndex(56);
		((Control)buttonWoYaoSuShen).set_Text("我要赎身");
		((ButtonBase)buttonWoYaoSuShen).set_UseVisualStyleBackColor(true);
		((Control)buttonWoYaoSuShen).add_Click((EventHandler)buttonWoYaoSuShen_Click);
		((Control)buttonShiFang).set_Anchor((AnchorStyles)9);
		((Control)buttonShiFang).set_Location(new Point(646, 144));
		((Control)buttonShiFang).set_Name("buttonShiFang");
		((Control)buttonShiFang).set_Size(new Size(21, 20));
		((Control)buttonShiFang).set_TabIndex(90);
		((Control)buttonShiFang).set_Text("释");
		toolTipAll.SetToolTip((Control)(object)buttonShiFang, "释放奴隶");
		((ButtonBase)buttonShiFang).set_UseVisualStyleBackColor(true);
		((Control)buttonShiFang).add_Click((EventHandler)buttonShiFang_Click);
		((Control)buttonMinYunKa).set_Location(new Point(597, 6));
		((Control)buttonMinYunKa).set_Name("buttonMinYunKa");
		((Control)buttonMinYunKa).set_Size(new Size(75, 23));
		((Control)buttonMinYunKa).set_TabIndex(57);
		((Control)buttonMinYunKa).set_Text("命运卡");
		((ButtonBase)buttonMinYunKa).set_UseVisualStyleBackColor(true);
		((Control)buttonMinYunKa).add_Click((EventHandler)buttonMinYunKa_Click);
		((Control)buttonShuaXin).set_Anchor((AnchorStyles)9);
		((Control)buttonShuaXin).set_Location(new Point(727, 144));
		((Control)buttonShuaXin).set_Name("buttonShuaXin");
		((Control)buttonShuaXin).set_Size(new Size(21, 20));
		((Control)buttonShuaXin).set_TabIndex(89);
		((Control)buttonShuaXin).set_Text("刷");
		toolTipAll.SetToolTip((Control)(object)buttonShuaXin, "全部刷新");
		((ButtonBase)buttonShuaXin).set_UseVisualStyleBackColor(true);
		((Control)buttonShuaXin).add_Click((EventHandler)buttonShuaXin_Click);
		comboBoxTaoHaoZhuRen.set_DropDownHeight(400);
		comboBoxTaoHaoZhuRen.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxTaoHaoZhuRen).set_FormattingEnabled(true);
		comboBoxTaoHaoZhuRen.set_IntegralHeight(false);
		((Control)comboBoxTaoHaoZhuRen).set_Location(new Point(413, 39));
		((Control)comboBoxTaoHaoZhuRen).set_Name("comboBoxTaoHaoZhuRen");
		((Control)comboBoxTaoHaoZhuRen).set_Size(new Size(216, 20));
		((Control)comboBoxTaoHaoZhuRen).set_TabIndex(58);
		((Control)buttonZhiXing).set_Anchor((AnchorStyles)9);
		((Control)buttonZhiXing).set_Location(new Point(614, 144));
		((Control)buttonZhiXing).set_Name("buttonZhiXing");
		((Control)buttonZhiXing).set_Size(new Size(21, 20));
		((Control)buttonZhiXing).set_TabIndex(88);
		((Control)buttonZhiXing).set_Text("执");
		toolTipAll.SetToolTip((Control)(object)buttonZhiXing, "执行折磨和安抚");
		((ButtonBase)buttonZhiXing).set_UseVisualStyleBackColor(true);
		((Control)buttonZhiXing).add_Click((EventHandler)buttonZhiXing_Click);
		comboBoxZheMo.set_DropDownHeight(400);
		comboBoxZheMo.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxZheMo).set_FormattingEnabled(true);
		comboBoxZheMo.set_IntegralHeight(false);
		((Control)comboBoxZheMo).set_Location(new Point(413, 71));
		((Control)comboBoxZheMo).set_Name("comboBoxZheMo");
		((Control)comboBoxZheMo).set_Size(new Size(216, 20));
		((Control)comboBoxZheMo).set_TabIndex(59);
		((Control)buttonQuanXuan).set_Anchor((AnchorStyles)9);
		((Control)buttonQuanXuan).set_Location(new Point(519, 144));
		((Control)buttonQuanXuan).set_Name("buttonQuanXuan");
		((Control)buttonQuanXuan).set_Size(new Size(21, 20));
		((Control)buttonQuanXuan).set_TabIndex(86);
		((Control)buttonQuanXuan).set_Text("√");
		toolTipAll.SetToolTip((Control)(object)buttonQuanXuan, "全选");
		((ButtonBase)buttonQuanXuan).set_UseVisualStyleBackColor(true);
		((Control)buttonQuanXuan).add_Click((EventHandler)buttonQuanXuan_Click);
		comboBoxAnFu.set_DropDownHeight(400);
		comboBoxAnFu.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxAnFu).set_FormattingEnabled(true);
		comboBoxAnFu.set_IntegralHeight(false);
		((Control)comboBoxAnFu).set_Location(new Point(413, 103));
		((Control)comboBoxAnFu).set_Name("comboBoxAnFu");
		((Control)comboBoxAnFu).set_Size(new Size(178, 20));
		((Control)comboBoxAnFu).set_TabIndex(60);
		((Control)buttonQuanBuXuan).set_Anchor((AnchorStyles)9);
		((Control)buttonQuanBuXuan).set_Location(new Point(551, 144));
		((Control)buttonQuanBuXuan).set_Name("buttonQuanBuXuan");
		((Control)buttonQuanBuXuan).set_Size(new Size(21, 20));
		((Control)buttonQuanBuXuan).set_TabIndex(85);
		((Control)buttonQuanBuXuan).set_Text("×");
		toolTipAll.SetToolTip((Control)(object)buttonQuanBuXuan, "全不选");
		((ButtonBase)buttonQuanBuXuan).set_UseVisualStyleBackColor(true);
		((Control)buttonQuanBuXuan).add_Click((EventHandler)buttonQuanBuXuan_Click);
		comboBoxDaZhe.set_DropDownHeight(400);
		comboBoxDaZhe.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxDaZhe).set_FormattingEnabled(true);
		comboBoxDaZhe.set_IntegralHeight(false);
		((Control)comboBoxDaZhe).set_Location(new Point(412, 144));
		((Control)comboBoxDaZhe).set_Name("comboBoxDaZhe");
		((Control)comboBoxDaZhe).set_Size(new Size(62, 20));
		((Control)comboBoxDaZhe).set_TabIndex(61);
		((Control)tabPage25).get_Controls().Add((Control)(object)button_25);
		((Control)tabPage25).get_Controls().Add((Control)(object)button_24);
		((Control)tabPage25).get_Controls().Add((Control)(object)button_23);
		((Control)tabPage25).get_Controls().Add((Control)(object)button_22);
		((Control)tabPage25).get_Controls().Add((Control)(object)label131);
		((Control)tabPage25).get_Controls().Add((Control)(object)label130);
		((Control)tabPage25).get_Controls().Add((Control)(object)label129);
		((Control)tabPage25).get_Controls().Add((Control)(object)textBox19);
		((Control)tabPage25).get_Controls().Add((Control)(object)button_21);
		((Control)tabPage25).get_Controls().Add((Control)(object)label128);
		((Control)tabPage25).get_Controls().Add((Control)(object)textBox18);
		((Control)tabPage25).get_Controls().Add((Control)(object)button_20);
		((Control)tabPage25).get_Controls().Add((Control)(object)button87);
		((Control)tabPage25).get_Controls().Add((Control)(object)button88);
		((Control)tabPage25).get_Controls().Add((Control)(object)button85);
		((Control)tabPage25).get_Controls().Add((Control)(object)button86);
		((Control)tabPage25).get_Controls().Add((Control)(object)button_19);
		((Control)tabPage25).get_Controls().Add((Control)(object)button_18);
		((Control)tabPage25).get_Controls().Add((Control)(object)listViewJc);
		((Control)tabPage25).get_Controls().Add((Control)(object)button_17);
		((Control)tabPage25).get_Controls().Add((Control)(object)label127);
		((Control)tabPage25).get_Controls().Add((Control)(object)button_0);
		((Control)tabPage25).get_Controls().Add((Control)(object)listViewMaiDeQi);
		((Control)tabPage25).get_Controls().Add((Control)(object)buttonShuaXinMaiDeQi);
		tabPage25.set_Location(new Point(4, 21));
		((Control)tabPage25).set_Name("tabPage25");
		((Control)tabPage25).set_Padding(new Padding(3));
		((Control)tabPage25).set_Size(new Size(764, 378));
		tabPage25.set_TabIndex(1);
		((Control)tabPage25).set_Text("购买好友");
		tabPage25.set_UseVisualStyleBackColor(true);
		((Control)button_25).set_Anchor((AnchorStyles)9);
		((Control)button_25).set_ForeColor(Color.Blue);
		((Control)button_25).set_Location(new Point(510, 3));
		((Control)button_25).set_Name("button添加到经常购买2");
		((Control)button_25).set_Size(new Size(99, 20));
		((Control)button_25).set_TabIndex(128);
		((Control)button_25).set_Text("添加到经常购买");
		toolTipAll.SetToolTip((Control)(object)button_25, "添加到经常购买");
		((ButtonBase)button_25).set_UseVisualStyleBackColor(true);
		((Control)button_25).add_Click((EventHandler)button_25_Click);
		((Control)button_24).set_Location(new Point(345, 196));
		((Control)button_24).set_Name("button刷新经常购买好友");
		((Control)button_24).set_Size(new Size(21, 20));
		((Control)button_24).set_TabIndex(127);
		((Control)button_24).set_Text("刷");
		toolTipAll.SetToolTip((Control)(object)button_24, "刷新显示经常购买好友");
		((ButtonBase)button_24).set_UseVisualStyleBackColor(true);
		((Control)button_24).add_Click((EventHandler)button_24_Click);
		((Control)button_23).set_ForeColor(Color.Blue);
		((Control)button_23).set_Location(new Point(587, 346));
		((Control)button_23).set_Name("button停止抢购");
		((Control)button_23).set_Size(new Size(61, 24));
		((Control)button_23).set_TabIndex(125);
		((Control)button_23).set_Text("停止抢购");
		toolTipAll.SetToolTip((Control)(object)button_23, "停止抢购做列表中已经勾选的好友");
		((ButtonBase)button_23).set_UseVisualStyleBackColor(true);
		((Control)button_23).add_Click((EventHandler)button_23_Click);
		((Control)button_22).set_ForeColor(Color.Blue);
		((Control)button_22).set_Location(new Point(520, 248));
		((Control)button_22).set_Name("button添加当前所有奴隶");
		((Control)button_22).set_Size(new Size(116, 24));
		((Control)button_22).set_TabIndex(124);
		((Control)button_22).set_Text("添加当前所有奴隶");
		toolTipAll.SetToolTip((Control)(object)button_22, "将当前自己所有的奴隶添加到经常购买列表中");
		((ButtonBase)button_22).set_UseVisualStyleBackColor(true);
		((Control)button_22).add_Click((EventHandler)button_22_Click);
		((Control)label131).set_AutoSize(true);
		((Control)label131).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label131).set_ForeColor(Color.Blue);
		((Control)label131).set_Location(new Point(3, 200));
		((Control)label131).set_Name("label131");
		((Control)label131).set_Size(new Size(89, 12));
		((Control)label131).set_TabIndex(123);
		((Control)label131).set_Text("经常购买好友：");
		((Control)label130).set_ForeColor(Color.Red);
		((Control)label130).set_Location(new Point(669, 331));
		((Control)label130).set_Name("label130");
		((Control)label130).set_Size(new Size(93, 45));
		((Control)label130).set_TabIndex(122);
		((Control)label130).set_Text("批量购买和抢购将不会购买第十个奴隶");
		((Control)label129).set_AutoSize(true);
		((Control)label129).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label129).set_ForeColor(Color.Blue);
		((Control)label129).set_Location(new Point(374, 331));
		((Control)label129).set_Name("label129");
		((Control)label129).set_Size(new Size(113, 12));
		((Control)label129).set_TabIndex(121);
		((Control)label129).set_Text("抢购时间间隔[秒]：");
		((Control)textBox19).set_Location(new Point(374, 348));
		((Control)textBox19).set_Name("textBox19");
		((Control)textBox19).set_Size(new Size(134, 21));
		((Control)textBox19).set_TabIndex(120);
		((Control)button_21).set_ForeColor(Color.Blue);
		((Control)button_21).set_Location(new Point(520, 278));
		((Control)button_21).set_Name("button删除");
		((Control)button_21).set_Size(new Size(116, 24));
		((Control)button_21).set_TabIndex(119);
		((Control)button_21).set_Text("删除");
		toolTipAll.SetToolTip((Control)(object)button_21, "删除左列表中的好友");
		((ButtonBase)button_21).set_UseVisualStyleBackColor(true);
		((Control)button_21).add_Click((EventHandler)button_21_Click);
		((Control)label128).set_AutoSize(true);
		((Control)label128).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label128).set_ForeColor(Color.Blue);
		((Control)label128).set_Location(new Point(374, 203));
		((Control)label128).set_Name("label128");
		((Control)label128).set_Size(new Size(77, 12));
		((Control)label128).set_TabIndex(118);
		((Control)label128).set_Text("好友QQ号码：");
		((Control)textBox18).set_Location(new Point(374, 219));
		((Control)textBox18).set_Name("textBox18");
		((Control)textBox18).set_Size(new Size(134, 21));
		((Control)textBox18).set_TabIndex(117);
		((Control)button_20).set_ForeColor(Color.Blue);
		((Control)button_20).set_Location(new Point(520, 218));
		((Control)button_20).set_Name("button添加到经常购买");
		((Control)button_20).set_Size(new Size(116, 24));
		((Control)button_20).set_TabIndex(116);
		((Control)button_20).set_Text("添加到经常购买");
		toolTipAll.SetToolTip((Control)(object)button_20, "添加到经常购买");
		((ButtonBase)button_20).set_UseVisualStyleBackColor(true);
		((Control)button_20).add_Click((EventHandler)button_20_Click);
		((Control)button87).set_Location(new Point(291, 196));
		((Control)button87).set_Name("button87");
		((Control)button87).set_Size(new Size(21, 20));
		((Control)button87).set_TabIndex(115);
		((Control)button87).set_Text("√");
		toolTipAll.SetToolTip((Control)(object)button87, "全选");
		((ButtonBase)button87).set_UseVisualStyleBackColor(true);
		((Control)button87).add_Click((EventHandler)button87_Click);
		((Control)button88).set_Location(new Point(318, 196));
		((Control)button88).set_Name("button88");
		((Control)button88).set_Size(new Size(21, 20));
		((Control)button88).set_TabIndex(114);
		((Control)button88).set_Text("×");
		toolTipAll.SetToolTip((Control)(object)button88, "全不选");
		((ButtonBase)button88).set_UseVisualStyleBackColor(true);
		((Control)button88).add_Click((EventHandler)button88_Click);
		((Control)button85).set_Anchor((AnchorStyles)9);
		((Control)button85).set_Location(new Point(454, 3));
		((Control)button85).set_Name("button85");
		((Control)button85).set_Size(new Size(21, 20));
		((Control)button85).set_TabIndex(113);
		((Control)button85).set_Text("√");
		toolTipAll.SetToolTip((Control)(object)button85, "全选");
		((ButtonBase)button85).set_UseVisualStyleBackColor(true);
		((Control)button85).add_Click((EventHandler)button85_Click);
		((Control)button86).set_Anchor((AnchorStyles)9);
		((Control)button86).set_Location(new Point(482, 3));
		((Control)button86).set_Name("button86");
		((Control)button86).set_Size(new Size(21, 20));
		((Control)button86).set_TabIndex(112);
		((Control)button86).set_Text("×");
		toolTipAll.SetToolTip((Control)(object)button86, "全不选");
		((ButtonBase)button86).set_UseVisualStyleBackColor(true);
		((Control)button86).add_Click((EventHandler)button86_Click);
		((Control)button_19).set_ForeColor(Color.Blue);
		((Control)button_19).set_Location(new Point(520, 346));
		((Control)button_19).set_Name("button开始抢购");
		((Control)button_19).set_Size(new Size(61, 24));
		((Control)button_19).set_TabIndex(111);
		((Control)button_19).set_Text("开始抢购");
		toolTipAll.SetToolTip((Control)(object)button_19, "开始抢购做列表中已经勾选的好友");
		((ButtonBase)button_19).set_UseVisualStyleBackColor(true);
		((Control)button_19).add_Click((EventHandler)button_19_Click);
		((Control)button_18).set_ForeColor(Color.Blue);
		((Control)button_18).set_Location(new Point(520, 308));
		((Control)button_18).set_Name("button批量购买2");
		((Control)button_18).set_Size(new Size(116, 24));
		((Control)button_18).set_TabIndex(110);
		((Control)button_18).set_Text("批量购买");
		toolTipAll.SetToolTip((Control)(object)button_18, "批量购买左列表勾选的所有奴隶");
		((ButtonBase)button_18).set_UseVisualStyleBackColor(true);
		((Control)button_18).add_Click((EventHandler)button_18_Click);
		listViewJc.set_CheckBoxes(true);
		listViewJc.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[3] { columnHeader278, columnHeader279, columnHeader280 });
		((Control)listViewJc).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listViewJc).set_Cursor(Cursors.get_Default());
		((Control)listViewJc).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listViewJc.set_FullRowSelect(true);
		listViewJc.set_GridLines(true);
		((Control)listViewJc).set_Location(new Point(3, 218));
		listViewJc.set_MultiSelect(false);
		((Control)listViewJc).set_Name("listViewJc");
		((Control)listViewJc).set_Size(new Size(365, 151));
		((Control)listViewJc).set_TabIndex(109);
		listViewJc.set_UseCompatibleStateImageBehavior(false);
		listViewJc.set_View((View)1);
		((Control)listViewJc).add_MouseUp(new MouseEventHandler(listViewJc_MouseUp));
		columnHeader278.set_Text("QQ号码");
		columnHeader278.set_Width(92);
		columnHeader279.set_Text("昵称");
		columnHeader279.set_Width(124);
		columnHeader280.set_Text("身价");
		columnHeader280.set_Width(90);
		((Control)button_17).set_Anchor((AnchorStyles)9);
		((Control)button_17).set_ForeColor(Color.Blue);
		((Control)button_17).set_Location(new Point(616, 3));
		((Control)button_17).set_Name("button批量购买1");
		((Control)button_17).set_Size(new Size(71, 20));
		((Control)button_17).set_TabIndex(108);
		((Control)button_17).set_Text("批量购买");
		toolTipAll.SetToolTip((Control)(object)button_17, "批量购买下列表勾选的所有奴隶");
		((ButtonBase)button_17).set_UseVisualStyleBackColor(true);
		((Control)button_17).add_Click((EventHandler)button_17_Click);
		((Control)label127).set_AutoSize(true);
		((Control)label127).set_ForeColor(Color.Blue);
		((Control)label127).set_Location(new Point(3, 10));
		((Control)label127).set_Name("label127");
		((Control)label127).set_Size(new Size(89, 12));
		((Control)label127).set_TabIndex(107);
		((Control)label127).set_Text("买得起的好友：");
		((Control)button_0).set_Anchor((AnchorStyles)9);
		((Control)button_0).set_ForeColor(Color.Blue);
		((Control)button_0).set_Location(new Point(694, 3));
		((Control)button_0).set_Name("button详细");
		((Control)button_0).set_Size(new Size(38, 20));
		((Control)button_0).set_TabIndex(105);
		((Control)button_0).set_Text("详细");
		toolTipAll.SetToolTip((Control)(object)button_0, "显示他的主人");
		((ButtonBase)button_0).set_UseVisualStyleBackColor(true);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)listViewMaiDeQi).set_Anchor((AnchorStyles)13);
		listViewMaiDeQi.set_CheckBoxes(true);
		listViewMaiDeQi.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[5] { columnHeader159, columnHeader160, columnHeader161, columnHeader248, columnHeader244 });
		((Control)listViewMaiDeQi).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listViewMaiDeQi).set_Cursor(Cursors.get_Default());
		((Control)listViewMaiDeQi).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listViewMaiDeQi.set_FullRowSelect(true);
		listViewMaiDeQi.set_GridLines(true);
		((Control)listViewMaiDeQi).set_Location(new Point(1, 26));
		listViewMaiDeQi.set_MultiSelect(false);
		((Control)listViewMaiDeQi).set_Name("listViewMaiDeQi");
		((Control)listViewMaiDeQi).set_Size(new Size(762, 168));
		((Control)listViewMaiDeQi).set_TabIndex(54);
		listViewMaiDeQi.set_UseCompatibleStateImageBehavior(false);
		listViewMaiDeQi.set_View((View)1);
		((Control)listViewMaiDeQi).add_MouseDoubleClick(new MouseEventHandler(listViewMaiDeQi_MouseDoubleClick));
		((Control)listViewMaiDeQi).add_MouseUp(new MouseEventHandler(listView9_MouseUp));
		columnHeader159.set_Text("QQ号码");
		columnHeader159.set_Width(92);
		columnHeader160.set_Text("昵称");
		columnHeader160.set_Width(124);
		columnHeader161.set_Text("身价");
		columnHeader161.set_Width(90);
		columnHeader248.set_Text("主人的QQ号码");
		columnHeader248.set_Width(111);
		columnHeader244.set_Text("主人的昵称");
		columnHeader244.set_Width(159);
		((Control)buttonShuaXinMaiDeQi).set_Anchor((AnchorStyles)9);
		((Control)buttonShuaXinMaiDeQi).set_Location(new Point(739, 3));
		((Control)buttonShuaXinMaiDeQi).set_Name("buttonShuaXinMaiDeQi");
		((Control)buttonShuaXinMaiDeQi).set_Size(new Size(21, 20));
		((Control)buttonShuaXinMaiDeQi).set_TabIndex(90);
		((Control)buttonShuaXinMaiDeQi).set_Text("刷");
		toolTipAll.SetToolTip((Control)(object)buttonShuaXinMaiDeQi, "刷新买得起的好友");
		((ButtonBase)buttonShuaXinMaiDeQi).set_UseVisualStyleBackColor(true);
		((Control)buttonShuaXinMaiDeQi).add_Click((EventHandler)buttonShuaXinMaiDeQi_Click);
		((Control)tabPage26).get_Controls().Add((Control)(object)button84);
		((Control)tabPage26).get_Controls().Add((Control)(object)button89);
		((Control)tabPage26).get_Controls().Add((Control)(object)button82);
		((Control)tabPage26).get_Controls().Add((Control)(object)button83);
		((Control)tabPage26).get_Controls().Add((Control)(object)button_27);
		((Control)tabPage26).get_Controls().Add((Control)(object)label136);
		((Control)tabPage26).get_Controls().Add((Control)(object)button_26);
		((Control)tabPage26).get_Controls().Add((Control)(object)listViewPK2);
		((Control)tabPage26).get_Controls().Add((Control)(object)label135);
		((Control)tabPage26).get_Controls().Add((Control)(object)label134);
		((Control)tabPage26).get_Controls().Add((Control)(object)label133);
		((Control)tabPage26).get_Controls().Add((Control)(object)listViewPK0);
		((Control)tabPage26).get_Controls().Add((Control)(object)listViewPK1);
		tabPage26.set_Location(new Point(4, 21));
		((Control)tabPage26).set_Name("tabPage26");
		((Control)tabPage26).set_Size(new Size(764, 378));
		tabPage26.set_TabIndex(2);
		((Control)tabPage26).set_Text("奴隶PK");
		tabPage26.set_UseVisualStyleBackColor(true);
		((Control)button84).set_Anchor((AnchorStyles)9);
		((Control)button84).set_Location(new Point(418, 189));
		((Control)button84).set_Name("button84");
		((Control)button84).set_Size(new Size(21, 20));
		((Control)button84).set_TabIndex(128);
		((Control)button84).set_Text("√");
		toolTipAll.SetToolTip((Control)(object)button84, "全选");
		((ButtonBase)button84).set_UseVisualStyleBackColor(true);
		((Control)button84).add_Click((EventHandler)button84_Click);
		((Control)button89).set_Anchor((AnchorStyles)9);
		((Control)button89).set_Location(new Point(445, 189));
		((Control)button89).set_Name("button89");
		((Control)button89).set_Size(new Size(21, 20));
		((Control)button89).set_TabIndex(127);
		((Control)button89).set_Text("×");
		toolTipAll.SetToolTip((Control)(object)button89, "全不选");
		((ButtonBase)button89).set_UseVisualStyleBackColor(true);
		((Control)button89).add_Click((EventHandler)button89_Click);
		((Control)button82).set_Anchor((AnchorStyles)9);
		((Control)button82).set_Location(new Point(418, 0));
		((Control)button82).set_Name("button82");
		((Control)button82).set_Size(new Size(21, 20));
		((Control)button82).set_TabIndex(126);
		((Control)button82).set_Text("√");
		toolTipAll.SetToolTip((Control)(object)button82, "全选");
		((ButtonBase)button82).set_UseVisualStyleBackColor(true);
		((Control)button82).add_Click((EventHandler)button82_Click);
		((Control)button83).set_Anchor((AnchorStyles)9);
		((Control)button83).set_Location(new Point(445, 0));
		((Control)button83).set_Name("button83");
		((Control)button83).set_Size(new Size(21, 20));
		((Control)button83).set_TabIndex(125);
		((Control)button83).set_Text("×");
		toolTipAll.SetToolTip((Control)(object)button83, "全不选");
		((ButtonBase)button83).set_UseVisualStyleBackColor(true);
		((Control)button83).add_Click((EventHandler)button83_Click);
		((Control)button_27).set_Anchor((AnchorStyles)9);
		((Control)button_27).set_Location(new Point(478, 343));
		((Control)button_27).set_Name("button刷新PK数据");
		((Control)button_27).set_Size(new Size(92, 30));
		((Control)button_27).set_TabIndex(124);
		((Control)button_27).set_Text("刷新PK数据");
		toolTipAll.SetToolTip((Control)(object)button_27, "刷新PK数据");
		((ButtonBase)button_27).set_UseVisualStyleBackColor(true);
		((Control)button_27).add_Click((EventHandler)button_27_Click);
		((Control)label136).set_Anchor((AnchorStyles)9);
		((Control)label136).set_ForeColor(Color.Red);
		((Control)label136).set_Location(new Point(585, 327));
		((Control)label136).set_Name("label136");
		((Control)label136).set_Size(new Size(170, 26));
		((Control)label136).set_TabIndex(123);
		((Control)label136).set_Text("每人每天只能被派出PK一次，每人每天只能接受别人PK两次");
		((Control)button_26).set_Anchor((AnchorStyles)9);
		((Control)button_26).set_ForeColor(SystemColors.ControlText);
		((Control)button_26).set_Location(new Point(478, 310));
		((Control)button_26).set_Name("button开始PK");
		((Control)button_26).set_Size(new Size(92, 30));
		((Control)button_26).set_TabIndex(117);
		((Control)button_26).set_Text("开始PK");
		toolTipAll.SetToolTip((Control)(object)button_26, "开始批量PK");
		((ButtonBase)button_26).set_UseVisualStyleBackColor(true);
		((Control)button_26).add_Click((EventHandler)button_26_Click);
		((Control)listViewPK2).set_Anchor((AnchorStyles)13);
		listViewPK2.set_CheckBoxes(true);
		listViewPK2.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[6] { columnHeader287, columnHeader288, columnHeader289, columnHeader293, columnHeader294, columnHeader295 });
		((Control)listViewPK2).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listViewPK2).set_Cursor(Cursors.get_Default());
		((Control)listViewPK2).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listViewPK2.set_FullRowSelect(true);
		listViewPK2.set_GridLines(true);
		((Control)listViewPK2).set_Location(new Point(3, 212));
		listViewPK2.set_MultiSelect(false);
		((Control)listViewPK2).set_Name("listViewPK2");
		((Control)listViewPK2).set_Size(new Size(463, 166));
		((Control)listViewPK2).set_TabIndex(116);
		listViewPK2.set_UseCompatibleStateImageBehavior(false);
		listViewPK2.set_View((View)1);
		((Control)listViewPK2).add_MouseUp(new MouseEventHandler(listViewPK2_MouseUp));
		columnHeader287.set_Text("QQ号码");
		columnHeader287.set_Width(92);
		columnHeader288.set_Text("昵称");
		columnHeader288.set_Width(93);
		columnHeader289.set_Text("身价");
		columnHeader289.set_Width(76);
		columnHeader293.set_Text("胜利");
		columnHeader293.set_Width(50);
		columnHeader294.set_Text("失败");
		columnHeader294.set_Width(46);
		columnHeader295.set_Text("经验");
		columnHeader295.set_Width(72);
		((Control)label135).set_AutoSize(true);
		((Control)label135).set_ForeColor(Color.Blue);
		((Control)label135).set_Location(new Point(6, 193));
		((Control)label135).set_Name("label135");
		((Control)label135).set_Size(new Size(77, 12));
		((Control)label135).set_TabIndex(115);
		((Control)label135).set_Text("对方的奴隶：");
		((Control)label134).set_Anchor((AnchorStyles)9);
		((Control)label134).set_AutoSize(true);
		((Control)label134).set_ForeColor(Color.Blue);
		((Control)label134).set_Location(new Point(480, 6));
		((Control)label134).set_Name("label134");
		((Control)label134).set_Size(new Size(173, 12));
		((Control)label134).set_TabIndex(114);
		((Control)label134).set_Text("左键选择想PK他的奴隶的好友：");
		((Control)label133).set_AutoSize(true);
		((Control)label133).set_ForeColor(Color.Blue);
		((Control)label133).set_Location(new Point(6, 6));
		((Control)label133).set_Name("label133");
		((Control)label133).set_Size(new Size(65, 12));
		((Control)label133).set_TabIndex(113);
		((Control)label133).set_Text("我的奴隶：");
		((Control)listViewPK0).set_Anchor((AnchorStyles)9);
		listViewPK0.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[3] { columnHeader284, columnHeader285, columnHeader286 });
		((Control)listViewPK0).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listViewPK0).set_Cursor(Cursors.get_Default());
		((Control)listViewPK0).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listViewPK0.set_FullRowSelect(true);
		listViewPK0.set_GridLines(true);
		((Control)listViewPK0).set_Location(new Point(478, 20));
		listViewPK0.set_MultiSelect(false);
		((Control)listViewPK0).set_Name("listViewPK0");
		((Control)listViewPK0).set_Size(new Size(284, 284));
		((Control)listViewPK0).set_TabIndex(111);
		listViewPK0.set_UseCompatibleStateImageBehavior(false);
		listViewPK0.set_View((View)1);
		((Control)listViewPK0).add_MouseUp(new MouseEventHandler(listViewPK0_MouseUp));
		columnHeader284.set_Text("QQ号码");
		columnHeader284.set_Width(99);
		columnHeader285.set_Text("昵称");
		columnHeader285.set_Width(89);
		columnHeader286.set_Text("奴隶数");
		columnHeader286.set_Width(63);
		((Control)listViewPK1).set_Anchor((AnchorStyles)13);
		listViewPK1.set_CheckBoxes(true);
		listViewPK1.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[6] { columnHeader281, columnHeader282, columnHeader283, columnHeader290, columnHeader291, columnHeader292 });
		((Control)listViewPK1).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listViewPK1).set_Cursor(Cursors.get_Default());
		((Control)listViewPK1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listViewPK1.set_FullRowSelect(true);
		listViewPK1.set_GridLines(true);
		((Control)listViewPK1).set_Location(new Point(3, 20));
		listViewPK1.set_MultiSelect(false);
		((Control)listViewPK1).set_Name("listViewPK1");
		((Control)listViewPK1).set_Size(new Size(463, 166));
		((Control)listViewPK1).set_TabIndex(110);
		listViewPK1.set_UseCompatibleStateImageBehavior(false);
		listViewPK1.set_View((View)1);
		((Control)listViewPK1).add_MouseUp(new MouseEventHandler(listViewPK1_MouseUp));
		columnHeader281.set_Text("QQ号码");
		columnHeader281.set_Width(92);
		columnHeader282.set_Text("昵称");
		columnHeader282.set_Width(93);
		columnHeader283.set_Text("身价");
		columnHeader283.set_Width(76);
		columnHeader290.set_Text("胜利");
		columnHeader290.set_Width(50);
		columnHeader291.set_Text("失败");
		columnHeader291.set_Width(46);
		columnHeader292.set_Text("经验");
		columnHeader292.set_Width(72);
		((Control)tabPageQueryFriend).get_Controls().Add((Control)(object)checkBox15);
		((Control)tabPageQueryFriend).get_Controls().Add((Control)(object)checkBox16);
		((Control)tabPageQueryFriend).get_Controls().Add((Control)(object)checkBox17);
		((Control)tabPageQueryFriend).get_Controls().Add((Control)(object)checkBox3);
		((Control)tabPageQueryFriend).get_Controls().Add((Control)(object)checkBox2);
		((Control)tabPageQueryFriend).get_Controls().Add((Control)(object)checkBox1);
		((Control)tabPageQueryFriend).get_Controls().Add((Control)(object)tabControl2);
		((Control)tabPageQueryFriend).get_Controls().Add((Control)(object)buttonQueryQQ);
		((Control)tabPageQueryFriend).get_Controls().Add((Control)(object)label14);
		((Control)tabPageQueryFriend).get_Controls().Add((Control)(object)textBox1);
		tabPageQueryFriend.set_Location(new Point(4, 21));
		((Control)tabPageQueryFriend).set_Name("tabPageQueryFriend");
		((Control)tabPageQueryFriend).set_Size(new Size(774, 547));
		tabPageQueryFriend.set_TabIndex(3);
		((Control)tabPageQueryFriend).set_Text("综合查询");
		tabPageQueryFriend.set_UseVisualStyleBackColor(true);
		((Control)checkBox15).set_AutoSize(true);
		((Control)checkBox15).set_ForeColor(Color.Red);
		((Control)checkBox15).set_Location(new Point(638, 23));
		((Control)checkBox15).set_Name("checkBox15");
		((Control)checkBox15).set_Size(new Size(72, 16));
		((Control)checkBox15).set_TabIndex(10);
		((Control)checkBox15).set_Text("访问足迹");
		((ButtonBase)checkBox15).set_UseVisualStyleBackColor(true);
		checkBox15.add_CheckedChanged((EventHandler)checkBox15_CheckedChanged);
		((Control)checkBox16).set_AutoSize(true);
		((Control)checkBox16).set_ForeColor(Color.Red);
		((Control)checkBox16).set_Location(new Point(557, 23));
		((Control)checkBox16).set_Name("checkBox16");
		((Control)checkBox16).set_Size(new Size(78, 16));
		((Control)checkBox16).set_TabIndex(9);
		((Control)checkBox16).set_Text("Qzone音乐");
		((ButtonBase)checkBox16).set_UseVisualStyleBackColor(true);
		checkBox16.add_CheckedChanged((EventHandler)checkBox16_CheckedChanged);
		((Control)checkBox17).set_AutoSize(true);
		((Control)checkBox17).set_ForeColor(Color.Red);
		((Control)checkBox17).set_Location(new Point(462, 23));
		((Control)checkBox17).set_Name("checkBox17");
		((Control)checkBox17).set_Size(new Size(60, 16));
		((Control)checkBox17).set_TabIndex(8);
		((Control)checkBox17).set_Text("QQ相册");
		((ButtonBase)checkBox17).set_UseVisualStyleBackColor(true);
		checkBox17.add_CheckedChanged((EventHandler)checkBox17_CheckedChanged);
		((Control)checkBox3).set_AutoSize(true);
		((Control)checkBox3).set_ForeColor(Color.Red);
		((Control)checkBox3).set_Location(new Point(638, 4));
		((Control)checkBox3).set_Name("checkBox3");
		((Control)checkBox3).set_Size(new Size(72, 16));
		((Control)checkBox3).set_TabIndex(7);
		((Control)checkBox3).set_Text("好友买卖");
		((ButtonBase)checkBox3).set_UseVisualStyleBackColor(true);
		checkBox3.add_CheckedChanged((EventHandler)checkBox3_CheckedChanged);
		((Control)checkBox2).set_AutoSize(true);
		((Control)checkBox2).set_ForeColor(Color.Red);
		((Control)checkBox2).set_Location(new Point(557, 4));
		((Control)checkBox2).set_Name("checkBox2");
		((Control)checkBox2).set_Size(new Size(60, 16));
		((Control)checkBox2).set_TabIndex(6);
		((Control)checkBox2).set_Text("抢车位");
		((ButtonBase)checkBox2).set_UseVisualStyleBackColor(true);
		checkBox2.add_CheckedChanged((EventHandler)checkBox2_CheckedChanged);
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_ForeColor(Color.Red);
		((Control)checkBox1).set_Location(new Point(462, 4));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(72, 16));
		((Control)checkBox1).set_TabIndex(5);
		((Control)checkBox1).set_Text("个人信息");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		checkBox1.add_CheckedChanged((EventHandler)checkBox1_CheckedChanged);
		((Control)tabControl2).set_Anchor((AnchorStyles)15);
		((Control)tabControl2).get_Controls().Add((Control)(object)tabPageJinBen);
		((Control)tabControl2).get_Controls().Add((Control)(object)tabPageQueryPark);
		((Control)tabControl2).get_Controls().Add((Control)(object)tabPageQueryQQBuyFriend);
		((Control)tabControl2).get_Controls().Add((Control)(object)tabPage9);
		((Control)tabControl2).get_Controls().Add((Control)(object)tabPage10);
		((Control)tabControl2).get_Controls().Add((Control)(object)tabPage11);
		((Control)tabControl2).set_Location(new Point(3, 34));
		((Control)tabControl2).set_Name("tabControl2");
		tabControl2.set_SelectedIndex(0);
		((Control)tabControl2).set_Size(new Size(775, 524));
		((Control)tabControl2).set_TabIndex(3);
		((Control)tabPageJinBen).get_Controls().Add((Control)(object)label27);
		((Control)tabPageJinBen).get_Controls().Add((Control)(object)listBox5);
		((Control)tabPageJinBen).get_Controls().Add((Control)(object)label25);
		((Control)tabPageJinBen).get_Controls().Add((Control)(object)listBox3);
		tabPageJinBen.set_Location(new Point(4, 21));
		((Control)tabPageJinBen).set_Name("tabPageJinBen");
		((Control)tabPageJinBen).set_Padding(new Padding(3));
		((Control)tabPageJinBen).set_Size(new Size(767, 499));
		tabPageJinBen.set_TabIndex(0);
		((Control)tabPageJinBen).set_Text("个人信息");
		tabPageJinBen.set_UseVisualStyleBackColor(true);
		((Control)label27).set_Anchor((AnchorStyles)13);
		((Control)label27).set_BackColor(SystemColors.InactiveCaptionText);
		((Control)label27).set_Font(new Font("宋体", 10.5f, (FontStyle)1, (GraphicsUnit)3, (byte)134));
		((Control)label27).set_ForeColor(Color.Blue);
		((Control)label27).set_Location(new Point(0, 244));
		((Control)label27).set_Name("label27");
		((Control)label27).set_Size(new Size(769, 19));
		((Control)label27).set_TabIndex(5);
		((Control)label27).set_Text("QQ城市达人信息");
		((Control)listBox5).set_Anchor((AnchorStyles)15);
		((Control)listBox5).set_Font(new Font("宋体", 9f));
		((ListControl)listBox5).set_FormattingEnabled(true);
		listBox5.set_ItemHeight(12);
		((Control)listBox5).set_Location(new Point(2, 263));
		((Control)listBox5).set_Name("listBox5");
		((Control)listBox5).set_Size(new Size(771, 232));
		((Control)listBox5).set_TabIndex(4);
		((Control)label25).set_Anchor((AnchorStyles)13);
		((Control)label25).set_BackColor(SystemColors.InactiveCaptionText);
		((Control)label25).set_Font(new Font("宋体", 10.5f, (FontStyle)1, (GraphicsUnit)3, (byte)134));
		((Control)label25).set_ForeColor(Color.Blue);
		((Control)label25).set_Location(new Point(0, 2));
		((Control)label25).set_Name("label25");
		((Control)label25).set_Size(new Size(767, 19));
		((Control)label25).set_TabIndex(3);
		((Control)label25).set_Text("QQ空间个人信息");
		((Control)listBox3).set_Anchor((AnchorStyles)13);
		((Control)listBox3).set_Font(new Font("宋体", 9f));
		((ListControl)listBox3).set_FormattingEnabled(true);
		listBox3.set_ItemHeight(12);
		((Control)listBox3).set_Location(new Point(0, 21));
		((Control)listBox3).set_Name("listBox3");
		((Control)listBox3).set_Size(new Size(771, 220));
		((Control)listBox3).set_TabIndex(2);
		((Control)tabPageQueryPark).get_Controls().Add((Control)(object)label120);
		((Control)tabPageQueryPark).get_Controls().Add((Control)(object)label121);
		((Control)tabPageQueryPark).get_Controls().Add((Control)(object)label64);
		((Control)tabPageQueryPark).get_Controls().Add((Control)(object)label19);
		((Control)tabPageQueryPark).get_Controls().Add((Control)(object)label20);
		((Control)tabPageQueryPark).get_Controls().Add((Control)(object)label21);
		((Control)tabPageQueryPark).get_Controls().Add((Control)(object)label22);
		((Control)tabPageQueryPark).get_Controls().Add((Control)(object)label23);
		((Control)tabPageQueryPark).get_Controls().Add((Control)(object)label24);
		((Control)tabPageQueryPark).get_Controls().Add((Control)(object)listQueryCars);
		((Control)tabPageQueryPark).get_Controls().Add((Control)(object)listQueryPark);
		tabPageQueryPark.set_Location(new Point(4, 21));
		((Control)tabPageQueryPark).set_Name("tabPageQueryPark");
		((Control)tabPageQueryPark).set_Padding(new Padding(3));
		((Control)tabPageQueryPark).set_Size(new Size(767, 499));
		tabPageQueryPark.set_TabIndex(1);
		((Control)tabPageQueryPark).set_Text("抢车位");
		tabPageQueryPark.set_UseVisualStyleBackColor(true);
		((Control)label120).set_Anchor((AnchorStyles)6);
		((Control)label120).set_AutoSize(true);
		((Control)label120).set_ForeColor(Color.Red);
		((Control)label120).set_Location(new Point(15, 461));
		((Control)label120).set_Name("label120");
		((Control)label120).set_Size(new Size(53, 12));
		((Control)label120).set_TabIndex(80);
		((Control)label120).set_Text("经验值：");
		((Control)label121).set_Anchor((AnchorStyles)6);
		((Control)label121).set_AutoSize(true);
		((Control)label121).set_ForeColor(Color.Red);
		((Control)label121).set_Location(new Point(15, 438));
		((Control)label121).set_Name("label121");
		((Control)label121).set_Size(new Size(41, 12));
		((Control)label121).set_TabIndex(79);
		((Control)label121).set_Text("等级：");
		((Control)label64).set_Anchor((AnchorStyles)6);
		((Control)label64).set_AutoSize(true);
		((Control)label64).set_ForeColor(Color.Blue);
		((Control)label64).set_Location(new Point(15, 415));
		((Control)label64).set_Name("label64");
		((Control)label64).set_Size(new Size(89, 12));
		((Control)label64).set_TabIndex(72);
		((Control)label64).set_Text("最后登录时间：");
		((Control)label19).set_AutoSize(true);
		((Control)label19).set_ForeColor(Color.Blue);
		((Control)label19).set_Location(new Point(134, 12));
		((Control)label19).set_Name("label19");
		((Control)label19).set_Size(new Size(65, 12));
		((Control)label19).set_TabIndex(71);
		((Control)label19).set_Text("贴条收入：");
		((Control)label20).set_AutoSize(true);
		((Control)label20).set_ForeColor(Color.Blue);
		((Control)label20).set_Location(new Point(446, 12));
		((Control)label20).set_Name("label20");
		((Control)label20).set_Size(new Size(53, 12));
		((Control)label20).set_TabIndex(70);
		((Control)label20).set_Text("车辆数：");
		((Control)label21).set_Anchor((AnchorStyles)6);
		((Control)label21).set_AutoSize(true);
		((Control)label21).set_ForeColor(Color.Blue);
		((Control)label21).set_Location(new Point(15, 387));
		((Control)label21).set_Name("label21");
		((Control)label21).set_Size(new Size(65, 12));
		((Control)label21).set_TabIndex(69);
		((Control)label21).set_Text("开通日期：");
		((Control)label22).set_AutoSize(true);
		((Control)label22).set_ForeColor(Color.Blue);
		((Control)label22).set_Location(new Point(15, 12));
		((Control)label22).set_Name("label22");
		((Control)label22).set_Size(new Size(41, 12));
		((Control)label22).set_TabIndex(68);
		((Control)label22).set_Text("现金：");
		((Control)label23).set_AutoSize(true);
		((Control)label23).set_ForeColor(Color.Blue);
		((Control)label23).set_Location(new Point(213, 142));
		((Control)label23).set_Name("label23");
		((Control)label23).set_Size(new Size(77, 12));
		((Control)label23).set_TabIndex(67);
		((Control)label23).set_Text("当前已盈利：");
		((Control)label24).set_AutoSize(true);
		((Control)label24).set_ForeColor(Color.Blue);
		((Control)label24).set_Location(new Point(14, 142));
		((Control)label24).set_Name("label24");
		((Control)label24).set_Size(new Size(77, 12));
		((Control)label24).set_TabIndex(66);
		((Control)label24).set_Text("每日能盈利：");
		((Control)listQueryCars).set_Anchor((AnchorStyles)15);
		listQueryCars.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[9] { columnHeader49, columnHeader50, columnHeader51, columnHeader52, columnHeader53, columnHeader54, columnHeader55, columnHeader56, columnHeader57 });
		((Control)listQueryCars).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listQueryCars).set_Cursor(Cursors.get_Default());
		((Control)listQueryCars).set_Font(new Font("宋体", 9f));
		listQueryCars.set_FullRowSelect(true);
		listQueryCars.set_GridLines(true);
		((Control)listQueryCars).set_Location(new Point(1, 165));
		listQueryCars.set_MultiSelect(false);
		((Control)listQueryCars).set_Name("listQueryCars");
		((Control)listQueryCars).set_Size(new Size(763, 200));
		((Control)listQueryCars).set_TabIndex(43);
		listQueryCars.set_UseCompatibleStateImageBehavior(false);
		listQueryCars.set_View((View)1);
		((Control)listQueryCars).add_MouseUp(new MouseEventHandler(listQueryCars_MouseUp));
		columnHeader49.set_Text("当前停车处");
		columnHeader49.set_Width(97);
		columnHeader50.set_Text("昵称");
		columnHeader50.set_Width(112);
		columnHeader51.set_Text("车牌");
		columnHeader51.set_Width(47);
		columnHeader52.set_Text("颜色");
		columnHeader52.set_Width(52);
		columnHeader53.set_Text("车辆");
		columnHeader53.set_Width(119);
		columnHeader54.set_Text("价格");
		columnHeader54.set_Width(69);
		columnHeader55.set_Text("盈利");
		columnHeader55.set_Width(48);
		columnHeader56.set_Text("已停时间");
		columnHeader56.set_Width(127);
		columnHeader57.set_Text("预计收入");
		columnHeader57.set_Width(82);
		((Control)listQueryPark).set_Anchor((AnchorStyles)13);
		listQueryPark.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[8] { columnHeader58, columnHeader59, columnHeader60, columnHeader61, columnHeader62, columnHeader63, columnHeader64, columnHeader65 });
		((Control)listQueryPark).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listQueryPark).set_Cursor(Cursors.get_Default());
		((Control)listQueryPark).set_Font(new Font("宋体", 9f));
		listQueryPark.set_FullRowSelect(true);
		listQueryPark.set_GridLines(true);
		((Control)listQueryPark).set_Location(new Point(1, 34));
		listQueryPark.set_MultiSelect(false);
		((Control)listQueryPark).set_Name("listQueryPark");
		((Control)listQueryPark).set_Size(new Size(763, 98));
		((Control)listQueryPark).set_TabIndex(42);
		listQueryPark.set_UseCompatibleStateImageBehavior(false);
		listQueryPark.set_View((View)1);
		((Control)listQueryPark).add_MouseUp(new MouseEventHandler(listQueryPark_MouseUp));
		columnHeader58.set_Text("车主");
		columnHeader58.set_Width(100);
		columnHeader59.set_Text("昵称");
		columnHeader59.set_Width(113);
		columnHeader60.set_Text("车牌");
		columnHeader60.set_Width(52);
		columnHeader61.set_Text("车位号");
		columnHeader61.set_Width(73);
		columnHeader62.set_Text("车辆");
		columnHeader62.set_Width(117);
		columnHeader63.set_Text("盈利");
		columnHeader63.set_Width(56);
		columnHeader64.set_Text("已停时间");
		columnHeader64.set_Width(141);
		columnHeader65.set_Text("预计收入");
		columnHeader65.set_Width(98);
		((Control)tabPageQueryQQBuyFriend).get_Controls().Add((Control)(object)listSlave);
		((Control)tabPageQueryQQBuyFriend).get_Controls().Add((Control)(object)label18);
		((Control)tabPageQueryQQBuyFriend).get_Controls().Add((Control)(object)pictureBox2);
		((Control)tabPageQueryQQBuyFriend).get_Controls().Add((Control)(object)listBox2);
		((Control)tabPageQueryQQBuyFriend).get_Controls().Add((Control)(object)label17);
		((Control)tabPageQueryQQBuyFriend).get_Controls().Add((Control)(object)pictureBox1);
		((Control)tabPageQueryQQBuyFriend).get_Controls().Add((Control)(object)listBox1);
		((Control)tabPageQueryQQBuyFriend).set_Font(new Font("宋体", 10.5f, (FontStyle)1, (GraphicsUnit)3, (byte)134));
		tabPageQueryQQBuyFriend.set_Location(new Point(4, 21));
		((Control)tabPageQueryQQBuyFriend).set_Name("tabPageQueryQQBuyFriend");
		((Control)tabPageQueryQQBuyFriend).set_Size(new Size(767, 499));
		tabPageQueryQQBuyFriend.set_TabIndex(2);
		((Control)tabPageQueryQQBuyFriend).set_Text("好友买卖");
		tabPageQueryQQBuyFriend.set_UseVisualStyleBackColor(true);
		((Control)listSlave).set_Anchor((AnchorStyles)15);
		listSlave.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[14]
		{
			columnHeader40, columnHeader41, columnHeader42, columnHeader43, columnHeader44, columnHeader45, columnHeader46, columnHeader47, columnHeader66, columnHeader48,
			columnHeader241, columnHeader242, columnHeader243, columnHeader246
		});
		((Control)listSlave).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listSlave).set_Cursor(Cursors.get_Default());
		((Control)listSlave).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listSlave.set_FullRowSelect(true);
		listSlave.set_GridLines(true);
		((Control)listSlave).set_Location(new Point(1, 262));
		listSlave.set_MultiSelect(false);
		((Control)listSlave).set_Name("listSlave");
		((Control)listSlave).set_Size(new Size(763, 234));
		((Control)listSlave).set_TabIndex(47);
		listSlave.set_UseCompatibleStateImageBehavior(false);
		listSlave.set_View((View)1);
		((Control)listSlave).add_MouseUp(new MouseEventHandler(listSlave_MouseUp));
		columnHeader40.set_Text("QQ号码");
		columnHeader40.set_Width(92);
		columnHeader41.set_Text("昵称");
		columnHeader41.set_Width(83);
		columnHeader42.set_Text("绰号");
		columnHeader42.set_Width(79);
		columnHeader43.set_Text("身价");
		columnHeader43.set_Width(46);
		columnHeader44.set_Text("资产");
		columnHeader44.set_Width(59);
		columnHeader45.set_Text("现金");
		columnHeader45.set_Width(56);
		columnHeader46.set_Text("奴隶");
		columnHeader46.set_Width(48);
		columnHeader47.set_Text("买入次数");
		columnHeader47.set_Width(73);
		columnHeader66.set_Text("买入价格");
		columnHeader66.set_Width(78);
		columnHeader48.set_Text("买入时间");
		columnHeader48.set_Width(135);
		columnHeader241.set_Text("最近状态");
		columnHeader241.set_Width(135);
		columnHeader242.set_Text("开始时间");
		columnHeader242.set_Width(135);
		columnHeader243.set_Text("结束时间");
		columnHeader243.set_Width(135);
		columnHeader246.set_Text("经验值");
		((Control)label18).set_BackColor(SystemColors.InactiveCaptionText);
		((Control)label18).set_Font(new Font("宋体", 9f, (FontStyle)1));
		((Control)label18).set_ForeColor(Color.Blue);
		((Control)label18).set_Location(new Point(386, 12));
		((Control)label18).set_Name("label18");
		((Control)label18).set_Size(new Size(200, 19));
		((Control)label18).set_TabIndex(4);
		((Control)label18).set_Text("我的主人");
		((Control)pictureBox2).set_Location(new Point(592, 12));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(166, 246));
		pictureBox2.set_TabIndex(5);
		pictureBox2.set_TabStop(false);
		((Control)listBox2).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listBox2).set_Font(new Font("宋体", 9f));
		((ListControl)listBox2).set_FormattingEnabled(true);
		listBox2.set_ItemHeight(12);
		((Control)listBox2).set_Location(new Point(386, 31));
		((Control)listBox2).set_Name("listBox2");
		((Control)listBox2).set_Size(new Size(200, 220));
		((Control)listBox2).set_TabIndex(3);
		((Control)listBox2).add_MouseUp(new MouseEventHandler(listBox2_MouseUp));
		((Control)label17).set_BackColor(SystemColors.InactiveCaptionText);
		((Control)label17).set_Font(new Font("宋体", 9f, (FontStyle)1));
		((Control)label17).set_ForeColor(Color.Blue);
		((Control)label17).set_Location(new Point(8, 12));
		((Control)label17).set_Name("label17");
		((Control)label17).set_Size(new Size(200, 19));
		((Control)label17).set_TabIndex(1);
		((Control)label17).set_Text("我自己");
		((Control)pictureBox1).set_Location(new Point(214, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(166, 246));
		pictureBox1.set_TabIndex(2);
		pictureBox1.set_TabStop(false);
		((Control)listBox1).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listBox1).set_Font(new Font("宋体", 9f));
		((ListControl)listBox1).set_FormattingEnabled(true);
		listBox1.set_ItemHeight(12);
		((Control)listBox1).set_Location(new Point(8, 31));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(200, 220));
		((Control)listBox1).set_TabIndex(0);
		((Control)listBox1).add_MouseUp(new MouseEventHandler(listBox1_MouseUp));
		((Control)tabPage9).get_Controls().Add((Control)(object)pictureBox5);
		((Control)tabPage9).get_Controls().Add((Control)(object)listView20);
		tabPage9.set_Location(new Point(4, 21));
		((Control)tabPage9).set_Name("tabPage9");
		((Control)tabPage9).set_Size(new Size(767, 499));
		tabPage9.set_TabIndex(3);
		((Control)tabPage9).set_Text("QQ相册");
		tabPage9.set_UseVisualStyleBackColor(true);
		((Control)pictureBox5).set_Anchor((AnchorStyles)9);
		((Control)pictureBox5).set_Cursor(Cursors.get_Default());
		((Control)pictureBox5).set_Location(new Point(428, 8));
		((Control)pictureBox5).set_Name("pictureBox5");
		((Control)pictureBox5).set_Size(new Size(331, 236));
		pictureBox5.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox5.set_TabIndex(102);
		pictureBox5.set_TabStop(false);
		((Control)listView20).set_Anchor((AnchorStyles)7);
		listView20.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[3] { columnHeader261, columnHeader262, columnHeader263 });
		((Control)listView20).set_ContextMenuStrip(contextMenuStrip4);
		((Control)listView20).set_Cursor(Cursors.get_Default());
		((Control)listView20).set_Font(new Font("宋体", 9f));
		listView20.set_FullRowSelect(true);
		listView20.set_GridLines(true);
		((Control)listView20).set_Location(new Point(1, 0));
		listView20.set_MultiSelect(false);
		((Control)listView20).set_Name("listView20");
		((Control)listView20).set_Size(new Size(398, 489));
		((Control)listView20).set_TabIndex(71);
		listView20.set_UseCompatibleStateImageBehavior(false);
		listView20.set_View((View)1);
		((Control)listView20).add_MouseUp(new MouseEventHandler(listView20_MouseUp));
		columnHeader261.set_Text("名称");
		columnHeader261.set_Width(101);
		columnHeader262.set_Text("属性");
		columnHeader262.set_Width(54);
		columnHeader263.set_Text("相片数");
		columnHeader263.set_Width(59);
		((ToolStrip)contextMenuStrip4).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)toolStripMenuItem_38,
			(ToolStripItem)toolStripMenuItem_37,
			(ToolStripItem)toolStripMenuItem3,
			(ToolStripItem)toolStripMenuItem_39
		});
		((Control)contextMenuStrip4).set_Name("contextMenuStrip3");
		((Control)contextMenuStrip4).set_Size(new Size(155, 76));
		((ToolStripItem)toolStripMenuItem_38).set_Name("浏览相册ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_38).set_Size(new Size(154, 22));
		((ToolStripItem)toolStripMenuItem_38).set_Text("浏览相册");
		((ToolStripItem)toolStripMenuItem_38).add_Click((EventHandler)toolStripMenuItem_38_Click);
		((ToolStripItem)toolStripMenuItem_37).set_Name("下载相册ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_37).set_Size(new Size(154, 22));
		((ToolStripItem)toolStripMenuItem_37).set_Text("下载相册");
		((ToolStripItem)toolStripMenuItem_37).add_Click((EventHandler)toolStripMenuItem_37_Click);
		((ToolStripItem)toolStripMenuItem3).set_Name("toolStripMenuItem3");
		((ToolStripItem)toolStripMenuItem3).set_Size(new Size(151, 6));
		((ToolStripItem)toolStripMenuItem_39).set_Name("在浏览器中打开ToolStripMenuItem1");
		((ToolStripItem)toolStripMenuItem_39).set_Size(new Size(154, 22));
		((ToolStripItem)toolStripMenuItem_39).set_Text("在浏览器中打开");
		((ToolStripItem)toolStripMenuItem_39).add_Click((EventHandler)toolStripMenuItem_39_Click);
		((Control)tabPage10).get_Controls().Add((Control)(object)axWindowsMediaPlayer1);
		((Control)tabPage10).get_Controls().Add((Control)(object)listView19);
		tabPage10.set_Location(new Point(4, 21));
		((Control)tabPage10).set_Name("tabPage10");
		((Control)tabPage10).set_Size(new Size(767, 499));
		tabPage10.set_TabIndex(4);
		((Control)tabPage10).set_Text("Qzone音乐");
		tabPage10.set_UseVisualStyleBackColor(true);
		((Control)axWindowsMediaPlayer1).set_Anchor((AnchorStyles)14);
		((AxHost)axWindowsMediaPlayer1).set_Enabled(true);
		((Control)axWindowsMediaPlayer1).set_Location(new Point(0, 382));
		((Control)axWindowsMediaPlayer1).set_Name("axWindowsMediaPlayer1");
		((AxHost)axWindowsMediaPlayer1).set_OcxState((State)componentResourceManager.GetObject("axWindowsMediaPlayer1.OcxState"));
		((Control)axWindowsMediaPlayer1).set_Size(new Size(764, 115));
		((Control)axWindowsMediaPlayer1).set_TabIndex(71);
		((Control)listView19).set_Anchor((AnchorStyles)15);
		listView19.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[3] { columnHeader258, columnHeader259, columnHeader260 });
		((Control)listView19).set_ContextMenuStrip(contextMenuStrip3);
		((Control)listView19).set_Cursor(Cursors.get_Default());
		((Control)listView19).set_Font(new Font("宋体", 9f));
		listView19.set_FullRowSelect(true);
		listView19.set_GridLines(true);
		((Control)listView19).set_Location(new Point(1, 0));
		listView19.set_MultiSelect(false);
		((Control)listView19).set_Name("listView19");
		((Control)listView19).set_Size(new Size(763, 376));
		((Control)listView19).set_TabIndex(70);
		listView19.set_UseCompatibleStateImageBehavior(false);
		listView19.set_View((View)1);
		((Control)listView19).add_DoubleClick((EventHandler)listView19_DoubleClick);
		columnHeader258.set_Text("歌手");
		columnHeader258.set_Width(104);
		columnHeader259.set_Text("歌曲");
		columnHeader259.set_Width(166);
		columnHeader260.set_Text("地址");
		columnHeader260.set_Width(427);
		((ToolStrip)contextMenuStrip3).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)toolStripMenuItem_34,
			(ToolStripItem)toolStripMenuItem_35,
			(ToolStripItem)toolStripMenuItem_36
		});
		((Control)contextMenuStrip3).set_Name("contextMenuStrip3");
		((Control)contextMenuStrip3).set_Size(new Size(143, 70));
		((ToolStripItem)toolStripMenuItem_34).set_Name("播放ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_34).set_Size(new Size(142, 22));
		((ToolStripItem)toolStripMenuItem_34).set_Text("播放");
		((ToolStripItem)toolStripMenuItem_34).add_Click((EventHandler)toolStripMenuItem_34_Click);
		((ToolStripItem)toolStripMenuItem_35).set_Name("复制歌曲信息ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_35).set_Size(new Size(142, 22));
		((ToolStripItem)toolStripMenuItem_35).set_Text("复制歌曲信息");
		((ToolStripItem)toolStripMenuItem_35).add_Click((EventHandler)toolStripMenuItem_35_Click);
		((ToolStripItem)toolStripMenuItem_36).set_Name("复制歌曲地址ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_36).set_Size(new Size(142, 22));
		((ToolStripItem)toolStripMenuItem_36).set_Text("复制歌曲地址");
		((ToolStripItem)toolStripMenuItem_36).add_Click((EventHandler)toolStripMenuItem_36_Click);
		((Control)tabPage11).get_Controls().Add((Control)(object)label66);
		((Control)tabPage11).get_Controls().Add((Control)(object)label67);
		((Control)tabPage11).get_Controls().Add((Control)(object)listView16);
		((Control)tabPage11).get_Controls().Add((Control)(object)listView18);
		tabPage11.set_Location(new Point(4, 21));
		((Control)tabPage11).set_Name("tabPage11");
		((Control)tabPage11).set_Size(new Size(767, 499));
		tabPage11.set_TabIndex(5);
		((Control)tabPage11).set_Text("访问足迹");
		tabPage11.set_UseVisualStyleBackColor(true);
		((Control)label66).set_AutoSize(true);
		((Control)label66).set_ForeColor(Color.Blue);
		((Control)label66).set_Location(new Point(3, 10));
		((Control)label66).set_Name("label66");
		((Control)label66).set_Size(new Size(125, 12));
		((Control)label66).set_TabIndex(72);
		((Control)label66).set_Text("TA最近访问过的QQ空间");
		((Control)label67).set_AutoSize(true);
		((Control)label67).set_ForeColor(Color.Blue);
		((Control)label67).set_Location(new Point(3, 254));
		((Control)label67).set_Name("label67");
		((Control)label67).set_Size(new Size(137, 12));
		((Control)label67).set_TabIndex(71);
		((Control)label67).set_Text("最近访问过TA空间的用户");
		((Control)listView16).set_Anchor((AnchorStyles)15);
		listView16.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { columnHeader256, columnHeader257 });
		((Control)listView16).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView16).set_Cursor(Cursors.get_Default());
		((Control)listView16).set_Font(new Font("宋体", 9f));
		listView16.set_FullRowSelect(true);
		listView16.set_GridLines(true);
		((Control)listView16).set_Location(new Point(4, 275));
		listView16.set_MultiSelect(false);
		((Control)listView16).set_Name("listView16");
		((Control)listView16).set_Size(new Size(763, 211));
		((Control)listView16).set_TabIndex(70);
		listView16.set_UseCompatibleStateImageBehavior(false);
		listView16.set_View((View)1);
		((Control)listView16).add_MouseUp(new MouseEventHandler(listView16_MouseUp));
		columnHeader256.set_Text("QQ号码");
		columnHeader256.set_Width(134);
		columnHeader257.set_Text("QQ昵称");
		columnHeader257.set_Width(184);
		((Control)listView18).set_Anchor((AnchorStyles)13);
		listView18.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[3] { columnHeader265, columnHeader266, columnHeader267 });
		((Control)listView18).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView18).set_Cursor(Cursors.get_Default());
		((Control)listView18).set_Font(new Font("宋体", 9f));
		listView18.set_FullRowSelect(true);
		listView18.set_GridLines(true);
		((Control)listView18).set_Location(new Point(5, 32));
		listView18.set_MultiSelect(false);
		((Control)listView18).set_Name("listView18");
		((Control)listView18).set_Size(new Size(763, 211));
		((Control)listView18).set_TabIndex(69);
		listView18.set_UseCompatibleStateImageBehavior(false);
		listView18.set_View((View)1);
		((Control)listView18).add_MouseUp(new MouseEventHandler(listView18_MouseUp));
		columnHeader265.set_Text("QQ号码");
		columnHeader265.set_Width(132);
		columnHeader266.set_Text("QQ昵称");
		columnHeader266.set_Width(184);
		columnHeader267.set_Text("QQ空间名称");
		columnHeader267.set_Width(369);
		((Control)buttonQueryQQ).set_Location(new Point(333, 5));
		((Control)buttonQueryQQ).set_Name("buttonQueryQQ");
		((Control)buttonQueryQQ).set_Size(new Size(61, 23));
		((Control)buttonQueryQQ).set_TabIndex(2);
		((Control)buttonQueryQQ).set_Text("查");
		toolTipAll.SetToolTip((Control)(object)buttonQueryQQ, "综合查询");
		((ButtonBase)buttonQueryQQ).set_UseVisualStyleBackColor(true);
		((Control)buttonQueryQQ).add_Click((EventHandler)buttonQueryQQ_Click);
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_Location(new Point(13, 12));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(125, 12));
		((Control)label14).set_TabIndex(1);
		((Control)label14).set_Text("输入需要查询的QQ号码");
		((Control)textBox1).set_Location(new Point(143, 6));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(184, 21));
		((Control)textBox1).set_TabIndex(0);
		((Control)textBox1).add_KeyDown(new KeyEventHandler(textBox1_KeyDown));
		((Control)tabPageXi).get_Controls().Add((Control)(object)label132);
		((Control)tabPageXi).get_Controls().Add((Control)(object)button78);
		((Control)tabPageXi).get_Controls().Add((Control)(object)listViewAllFriend);
		tabPageXi.set_Location(new Point(4, 21));
		((Control)tabPageXi).set_Name("tabPageXi");
		((Control)tabPageXi).set_Size(new Size(774, 547));
		tabPageXi.set_TabIndex(7);
		((Control)tabPageXi).set_Text("好友分析");
		tabPageXi.set_UseVisualStyleBackColor(true);
		((Control)label132).set_AutoSize(true);
		((Control)label132).set_ForeColor(Color.Blue);
		((Control)label132).set_Location(new Point(12, 11));
		((Control)label132).set_Name("label132");
		((Control)label132).set_Size(new Size(65, 12));
		((Control)label132).set_TabIndex(108);
		((Control)label132).set_Text("好友总数：");
		((Control)button78).set_Anchor((AnchorStyles)9);
		((Control)button78).set_Location(new Point(715, 0));
		((Control)button78).set_Name("button78");
		((Control)button78).set_Size(new Size(56, 30));
		((Control)button78).set_TabIndex(74);
		((Control)button78).set_Text("刷");
		toolTipAll.SetToolTip((Control)(object)button78, "刷新好友分析");
		((ButtonBase)button78).set_UseVisualStyleBackColor(true);
		((Control)button78).add_Click((EventHandler)button78_Click);
		((Control)listViewAllFriend).set_Anchor((AnchorStyles)15);
		listViewAllFriend.set_CheckBoxes(true);
		listViewAllFriend.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[5] { columnHeader162, columnHeader163, columnHeader166, columnHeader164, columnHeader165 });
		((Control)listViewAllFriend).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listViewAllFriend).set_Cursor(Cursors.get_Default());
		((Control)listViewAllFriend).set_Font(new Font("宋体", 9f));
		listViewAllFriend.set_FullRowSelect(true);
		listViewAllFriend.set_GridLines(true);
		((Control)listViewAllFriend).set_Location(new Point(3, 30));
		listViewAllFriend.set_MultiSelect(false);
		((Control)listViewAllFriend).set_Name("listViewAllFriend");
		((Control)listViewAllFriend).set_Size(new Size(770, 521));
		((Control)listViewAllFriend).set_TabIndex(48);
		listViewAllFriend.set_UseCompatibleStateImageBehavior(false);
		listViewAllFriend.set_View((View)1);
		((Control)listViewAllFriend).add_MouseUp(new MouseEventHandler(listViewAllFriend_MouseUp));
		columnHeader162.set_Text("QQ号码");
		columnHeader162.set_Width(108);
		columnHeader163.set_Text("昵称");
		columnHeader163.set_TextAlign((HorizontalAlignment)2);
		columnHeader163.set_Width(104);
		columnHeader166.set_Text("备注");
		columnHeader166.set_TextAlign((HorizontalAlignment)2);
		columnHeader166.set_Width(145);
		columnHeader164.set_Text("所属分组");
		columnHeader164.set_TextAlign((HorizontalAlignment)2);
		columnHeader164.set_Width(127);
		columnHeader165.set_Text("好友信息");
		columnHeader165.set_TextAlign((HorizontalAlignment)2);
		columnHeader165.set_Width(182);
		((Control)tabPageZone).get_Controls().Add((Control)(object)button_13);
		((Control)tabPageZone).get_Controls().Add((Control)(object)textBoxContent);
		((Control)tabPageZone).get_Controls().Add((Control)(object)tabControl8);
		((Control)tabPageZone).get_Controls().Add((Control)(object)button_12);
		((Control)tabPageZone).get_Controls().Add((Control)(object)label68);
		((Control)tabPageZone).get_Controls().Add((Control)(object)textBox17);
		tabPageZone.set_Location(new Point(4, 21));
		((Control)tabPageZone).set_Name("tabPageZone");
		((Control)tabPageZone).set_Size(new Size(774, 547));
		tabPageZone.set_TabIndex(15);
		((Control)tabPageZone).set_Text("Qzone日志");
		tabPageZone.set_UseVisualStyleBackColor(true);
		((Control)button_13).set_Anchor((AnchorStyles)10);
		((Control)button_13).set_Location(new Point(721, 481));
		((Control)button_13).set_Name("button发表");
		((Control)button_13).set_Size(new Size(51, 67));
		((Control)button_13).set_TabIndex(8);
		((Control)button_13).set_Text("评论");
		((ButtonBase)button_13).set_UseVisualStyleBackColor(true);
		((Control)button_13).add_Click((EventHandler)button_13_Click);
		((Control)textBoxContent).set_Anchor((AnchorStyles)14);
		((Control)textBoxContent).set_Location(new Point(4, 481));
		((TextBoxBase)textBoxContent).set_Multiline(true);
		((Control)textBoxContent).set_Name("textBoxContent");
		((Control)textBoxContent).set_Size(new Size(715, 65));
		((Control)textBoxContent).set_TabIndex(7);
		((Control)tabControl8).set_Anchor((AnchorStyles)15);
		((Control)tabControl8).get_Controls().Add((Control)(object)tabPage12);
		((Control)tabControl8).get_Controls().Add((Control)(object)tabPage13);
		((Control)tabControl8).set_Location(new Point(3, 33));
		((Control)tabControl8).set_Name("tabControl8");
		tabControl8.set_SelectedIndex(0);
		((Control)tabControl8).set_Size(new Size(771, 445));
		((Control)tabControl8).set_TabIndex(6);
		((Control)tabPage12).get_Controls().Add((Control)(object)listView21);
		tabPage12.set_Location(new Point(4, 21));
		((Control)tabPage12).set_Name("tabPage12");
		((Control)tabPage12).set_Padding(new Padding(3));
		((Control)tabPage12).set_Size(new Size(763, 420));
		tabPage12.set_TabIndex(0);
		((Control)tabPage12).set_Text("日志列表");
		tabPage12.set_UseVisualStyleBackColor(true);
		listView21.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[5] { columnHeader264, columnHeader268, columnHeader269, columnHeader270, columnHeader271 });
		((Control)listView21).set_ContextMenuStrip(contextMenuStrip5);
		((Control)listView21).set_Cursor(Cursors.get_Default());
		((Control)listView21).set_Dock((DockStyle)5);
		((Control)listView21).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listView21.set_FullRowSelect(true);
		listView21.set_GridLines(true);
		((Control)listView21).set_Location(new Point(3, 3));
		listView21.set_MultiSelect(false);
		((Control)listView21).set_Name("listView21");
		((Control)listView21).set_Size(new Size(757, 414));
		((Control)listView21).set_TabIndex(92);
		listView21.set_UseCompatibleStateImageBehavior(false);
		listView21.set_View((View)1);
		((Control)listView21).add_MouseUp(new MouseEventHandler(listView21_MouseUp));
		columnHeader264.set_Text("日志类别");
		columnHeader264.set_Width(93);
		columnHeader268.set_Text("日志标题");
		columnHeader268.set_Width(351);
		columnHeader269.set_Text("评论数");
		columnHeader269.set_Width(68);
		columnHeader270.set_Text("访问数");
		columnHeader270.set_Width(63);
		columnHeader271.set_Text("发表时间");
		columnHeader271.set_Width(149);
		((ToolStrip)contextMenuStrip5).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)toolStripMenuItem_40,
			(ToolStripItem)toolStripMenuItem_41,
			(ToolStripItem)toolStripMenuItem4,
			(ToolStripItem)toolStripMenuItem_42,
			(ToolStripItem)toolStripMenuItem_45,
			(ToolStripItem)toolStripMenuItem_43
		});
		((Control)contextMenuStrip5).set_Name("contextMenuStrip5");
		((Control)contextMenuStrip5).set_Size(new Size(203, 120));
		((ToolStripItem)toolStripMenuItem_40).set_Name("阅读日志ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_40).set_Size(new Size(202, 22));
		((ToolStripItem)toolStripMenuItem_40).set_Text("阅读日志");
		((ToolStripItem)toolStripMenuItem_40).add_Click((EventHandler)toolStripMenuItem_40_Click);
		((ToolStripItem)toolStripMenuItem_41).set_Name("在浏览器中阅读ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_41).set_Size(new Size(202, 22));
		((ToolStripItem)toolStripMenuItem_41).set_Text("在浏览器中阅读");
		((ToolStripItem)toolStripMenuItem_41).add_Click((EventHandler)toolStripMenuItem_41_Click);
		((ToolStripItem)toolStripMenuItem4).set_Name("toolStripMenuItem4");
		((ToolStripItem)toolStripMenuItem4).set_Size(new Size(199, 6));
		((ToolStripItem)toolStripMenuItem_42).set_Name("增加浏览量ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_42).set_Size(new Size(202, 22));
		((ToolStripItem)toolStripMenuItem_42).set_Text("开始增加当前文章浏览量");
		((ToolStripItem)toolStripMenuItem_42).add_Click((EventHandler)toolStripMenuItem_42_Click);
		((ToolStripItem)toolStripMenuItem_45).set_Name("停止增加浏览量ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_45).set_Size(new Size(202, 22));
		((ToolStripItem)toolStripMenuItem_45).set_Text("停止增加当前文章浏览量");
		((ToolStripItem)toolStripMenuItem_45).add_Click((EventHandler)toolStripMenuItem_45_Click);
		((ToolStripItem)toolStripMenuItem_43).set_Name("刷新浏览量ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_43).set_Size(new Size(202, 22));
		((ToolStripItem)toolStripMenuItem_43).set_Text("刷新当前文章浏览量");
		((ToolStripItem)toolStripMenuItem_43).add_Click((EventHandler)toolStripMenuItem_43_Click);
		((Control)tabPage13).get_Controls().Add((Control)(object)webBrowserReadQQZone);
		tabPage13.set_Location(new Point(4, 21));
		((Control)tabPage13).set_Name("tabPage13");
		((Control)tabPage13).set_Padding(new Padding(3));
		((Control)tabPage13).set_Size(new Size(763, 420));
		tabPage13.set_TabIndex(1);
		((Control)tabPage13).set_Text("日志内容");
		tabPage13.set_UseVisualStyleBackColor(true);
		((Control)webBrowserReadQQZone).set_Dock((DockStyle)5);
		((Control)webBrowserReadQQZone).set_Location(new Point(3, 3));
		((Control)webBrowserReadQQZone).set_MinimumSize(new Size(20, 20));
		((Control)webBrowserReadQQZone).set_Name("webBrowserReadQQZone");
		((Control)webBrowserReadQQZone).set_Size(new Size(757, 414));
		((Control)webBrowserReadQQZone).set_TabIndex(104);
		((Control)button_12).set_Location(new Point(333, 5));
		((Control)button_12).set_Name("button查询日志");
		((Control)button_12).set_Size(new Size(61, 23));
		((Control)button_12).set_TabIndex(5);
		((Control)button_12).set_Text("查");
		toolTipAll.SetToolTip((Control)(object)button_12, "综合查询");
		((ButtonBase)button_12).set_UseVisualStyleBackColor(true);
		((Control)button_12).add_Click((EventHandler)button_12_Click);
		((Control)label68).set_AutoSize(true);
		((Control)label68).set_Location(new Point(13, 12));
		((Control)label68).set_Name("label68");
		((Control)label68).set_Size(new Size(125, 12));
		((Control)label68).set_TabIndex(4);
		((Control)label68).set_Text("输入需要查询的QQ号码");
		((Control)textBox17).set_Location(new Point(143, 6));
		((Control)textBox17).set_Name("textBox17");
		((Control)textBox17).set_Size(new Size(184, 21));
		((Control)textBox17).set_TabIndex(3);
		((Control)textBox17).add_KeyDown(new KeyEventHandler(textBox17_KeyDown));
		((Control)tabPageCity).get_Controls().Add((Control)(object)label138);
		((Control)tabPageCity).get_Controls().Add((Control)(object)comboBoxOnline);
		((Control)tabPageCity).get_Controls().Add((Control)(object)label137);
		((Control)tabPageCity).get_Controls().Add((Control)(object)label126);
		((Control)tabPageCity).get_Controls().Add((Control)(object)label125);
		((Control)tabPageCity).get_Controls().Add((Control)(object)label124);
		((Control)tabPageCity).get_Controls().Add((Control)(object)button_15);
		((Control)tabPageCity).get_Controls().Add((Control)(object)button_14);
		((Control)tabPageCity).get_Controls().Add((Control)(object)labelAge);
		((Control)tabPageCity).get_Controls().Add((Control)(object)comboBoxAge);
		((Control)tabPageCity).get_Controls().Add((Control)(object)label123);
		((Control)tabPageCity).get_Controls().Add((Control)(object)comboBoxSex);
		((Control)tabPageCity).get_Controls().Add((Control)(object)label122);
		((Control)tabPageCity).get_Controls().Add((Control)(object)comboBoxCity);
		((Control)tabPageCity).get_Controls().Add((Control)(object)pictureBoxCity);
		((Control)tabPageCity).get_Controls().Add((Control)(object)listViewCity);
		((Control)tabPageCity).get_Controls().Add((Control)(object)label94);
		((Control)tabPageCity).get_Controls().Add((Control)(object)comboBoxSheng);
		tabPageCity.set_Location(new Point(4, 21));
		((Control)tabPageCity).set_Name("tabPageCity");
		((Control)tabPageCity).set_Size(new Size(774, 547));
		tabPageCity.set_TabIndex(16);
		((Control)tabPageCity).set_Text("城市达人");
		tabPageCity.set_UseVisualStyleBackColor(true);
		((Control)label138).set_Anchor((AnchorStyles)9);
		((Control)label138).set_AutoSize(true);
		((Control)label138).set_ForeColor(Color.Red);
		((Control)label138).set_Location(new Point(643, 24));
		((Control)label138).set_Name("label138");
		((Control)label138).set_Size(new Size(65, 12));
		((Control)label138).set_TabIndex(109);
		((Control)label138).set_Text("是否在线：");
		((Control)comboBoxOnline).set_Anchor((AnchorStyles)9);
		comboBoxOnline.set_DropDownHeight(800);
		comboBoxOnline.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxOnline).set_FormattingEnabled(true);
		comboBoxOnline.set_IntegralHeight(false);
		((Control)comboBoxOnline).set_Location(new Point(645, 40));
		((Control)comboBoxOnline).set_Name("comboBoxOnline");
		((Control)comboBoxOnline).set_Size(new Size(121, 20));
		((Control)comboBoxOnline).set_TabIndex(108);
		((Control)label137).set_AutoSize(true);
		((Control)label137).set_ForeColor(Color.Red);
		((Control)label137).set_Location(new Point(247, 7));
		((Control)label137).set_Name("label137");
		((Control)label137).set_Size(new Size(101, 12));
		((Control)label137).set_TabIndex(107);
		((Control)label137).set_Text("单击列头可以排序");
		((Control)label126).set_Anchor((AnchorStyles)9);
		((Control)label126).set_AutoSize(true);
		((Control)label126).set_ForeColor(Color.Blue);
		((Control)label126).set_Location(new Point(654, 488));
		((Control)label126).set_Name("label126");
		((Control)label126).set_Size(new Size(65, 12));
		((Control)label126).set_TabIndex(106);
		((Control)label126).set_Text("搜索数目：");
		((Control)label125).set_Anchor((AnchorStyles)9);
		((Control)label125).set_AutoSize(true);
		((Control)label125).set_ForeColor(Color.Red);
		((Control)label125).set_Location(new Point(654, 526));
		((Control)label125).set_Name("label125");
		((Control)label125).set_Size(new Size(89, 12));
		((Control)label125).set_TabIndex(104);
		((Control)label125).set_Text("蓝底色：不在线");
		((Control)label124).set_Anchor((AnchorStyles)9);
		((Control)label124).set_AutoSize(true);
		((Control)label124).set_ForeColor(Color.Red);
		((Control)label124).set_Location(new Point(654, 506));
		((Control)label124).set_Name("label124");
		((Control)label124).set_Size(new Size(77, 12));
		((Control)label124).set_TabIndex(103);
		((Control)label124).set_Text("白底色：在线");
		((Control)button_15).set_Anchor((AnchorStyles)9);
		((Control)button_15).set_Location(new Point(645, 307));
		((Control)button_15).set_Name("button停止搜索");
		((Control)button_15).set_Size(new Size(121, 30));
		((Control)button_15).set_TabIndex(102);
		((Control)button_15).set_Text("停止搜索");
		((ButtonBase)button_15).set_UseVisualStyleBackColor(true);
		((Control)button_15).add_Click((EventHandler)button_15_Click);
		((Control)button_14).set_Anchor((AnchorStyles)9);
		((Control)button_14).set_Location(new Point(645, 266));
		((Control)button_14).set_Name("button开始搜索");
		((Control)button_14).set_Size(new Size(121, 30));
		((Control)button_14).set_TabIndex(101);
		((Control)button_14).set_Text("开始搜索");
		((ButtonBase)button_14).set_UseVisualStyleBackColor(true);
		((Control)button_14).add_Click((EventHandler)button_14_Click);
		((Control)labelAge).set_Anchor((AnchorStyles)9);
		((Control)labelAge).set_AutoSize(true);
		((Control)labelAge).set_ForeColor(Color.Blue);
		((Control)labelAge).set_Location(new Point(643, 220));
		((Control)labelAge).set_Name("labelAge");
		((Control)labelAge).set_Size(new Size(41, 12));
		((Control)labelAge).set_TabIndex(100);
		((Control)labelAge).set_Text("年龄：");
		((Control)comboBoxAge).set_Anchor((AnchorStyles)9);
		comboBoxAge.set_DropDownHeight(400);
		comboBoxAge.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxAge).set_FormattingEnabled(true);
		comboBoxAge.set_IntegralHeight(false);
		((Control)comboBoxAge).set_Location(new Point(645, 236));
		((Control)comboBoxAge).set_Name("comboBoxAge");
		((Control)comboBoxAge).set_Size(new Size(121, 20));
		((Control)comboBoxAge).set_TabIndex(99);
		((Control)label123).set_Anchor((AnchorStyles)9);
		((Control)label123).set_AutoSize(true);
		((Control)label123).set_ForeColor(Color.Blue);
		((Control)label123).set_Location(new Point(643, 171));
		((Control)label123).set_Name("label123");
		((Control)label123).set_Size(new Size(41, 12));
		((Control)label123).set_TabIndex(98);
		((Control)label123).set_Text("性别：");
		((Control)comboBoxSex).set_Anchor((AnchorStyles)9);
		comboBoxSex.set_DropDownHeight(400);
		comboBoxSex.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxSex).set_FormattingEnabled(true);
		comboBoxSex.set_IntegralHeight(false);
		((Control)comboBoxSex).set_Location(new Point(645, 187));
		((Control)comboBoxSex).set_Name("comboBoxSex");
		((Control)comboBoxSex).set_Size(new Size(121, 20));
		((Control)comboBoxSex).set_TabIndex(97);
		((Control)label122).set_Anchor((AnchorStyles)9);
		((Control)label122).set_AutoSize(true);
		((Control)label122).set_ForeColor(Color.Blue);
		((Control)label122).set_Location(new Point(643, 122));
		((Control)label122).set_Name("label122");
		((Control)label122).set_Size(new Size(41, 12));
		((Control)label122).set_TabIndex(96);
		((Control)label122).set_Text("城市：");
		((Control)comboBoxCity).set_Anchor((AnchorStyles)9);
		comboBoxCity.set_DropDownHeight(800);
		comboBoxCity.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxCity).set_FormattingEnabled(true);
		comboBoxCity.set_IntegralHeight(false);
		((Control)comboBoxCity).set_Location(new Point(645, 138));
		((Control)comboBoxCity).set_Name("comboBoxCity");
		((Control)comboBoxCity).set_Size(new Size(121, 20));
		((Control)comboBoxCity).set_TabIndex(95);
		((Control)pictureBoxCity).set_Anchor((AnchorStyles)9);
		((Control)pictureBoxCity).set_Location(new Point(640, 346));
		((Control)pictureBoxCity).set_Name("pictureBoxCity");
		((Control)pictureBoxCity).set_Size(new Size(134, 131));
		pictureBoxCity.set_SizeMode((PictureBoxSizeMode)3);
		pictureBoxCity.set_TabIndex(105);
		pictureBoxCity.set_TabStop(false);
		((Control)listViewCity).set_Anchor((AnchorStyles)15);
		((ListView)listViewCity).get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[6] { columnHeader272, columnHeader273, columnHeader274, columnHeader275, columnHeader276, columnHeader277 });
		((Control)listViewCity).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listViewCity).set_Cursor(Cursors.get_Default());
		((Control)listViewCity).set_Font(new Font("宋体", 9f));
		((ListView)listViewCity).set_FullRowSelect(true);
		((ListView)listViewCity).set_GridLines(true);
		((Control)listViewCity).set_Location(new Point(0, 27));
		((ListView)listViewCity).set_MultiSelect(false);
		((Control)listViewCity).set_Name("listViewCity");
		((Control)listViewCity).set_Size(new Size(639, 524));
		((Control)listViewCity).set_TabIndex(94);
		((ListView)listViewCity).set_UseCompatibleStateImageBehavior(false);
		((ListView)listViewCity).set_View((View)1);
		((Control)listViewCity).add_MouseUp(new MouseEventHandler(listViewCity_MouseUp));
		((ListView)listViewCity).add_ColumnClick(new ColumnClickEventHandler(listViewCity_ColumnClick));
		((Control)listViewCity).add_Click((EventHandler)listViewCity_Click);
		columnHeader272.set_Text("QQ号码");
		columnHeader272.set_Width(132);
		columnHeader273.set_Text("生日");
		columnHeader273.set_Width(125);
		columnHeader274.set_Text("性别");
		columnHeader274.set_Width(90);
		columnHeader275.set_Text("感情");
		columnHeader275.set_Width(90);
		columnHeader276.set_Text("体重");
		columnHeader276.set_Width(88);
		columnHeader277.set_Text("身高");
		columnHeader277.set_Width(81);
		((Control)label94).set_Anchor((AnchorStyles)9);
		((Control)label94).set_AutoSize(true);
		((Control)label94).set_ForeColor(Color.Blue);
		((Control)label94).set_Location(new Point(643, 73));
		((Control)label94).set_Name("label94");
		((Control)label94).set_Size(new Size(41, 12));
		((Control)label94).set_TabIndex(93);
		((Control)label94).set_Text("省份：");
		((Control)comboBoxSheng).set_Anchor((AnchorStyles)9);
		comboBoxSheng.set_DropDownHeight(800);
		comboBoxSheng.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBoxSheng).set_FormattingEnabled(true);
		comboBoxSheng.set_IntegralHeight(false);
		((Control)comboBoxSheng).set_Location(new Point(645, 89));
		((Control)comboBoxSheng).set_Name("comboBoxSheng");
		((Control)comboBoxSheng).set_Size(new Size(121, 20));
		((Control)comboBoxSheng).set_TabIndex(92);
		comboBoxSheng.add_SelectedIndexChanged((EventHandler)comboBoxSheng_SelectedIndexChanged);
		((Control)label95).set_Anchor((AnchorStyles)6);
		((Control)label95).set_ForeColor(Color.Blue);
		((Control)label95).set_Location(new Point(15, 163));
		((Control)label95).set_Name("label95");
		((Control)label95).set_Size(new Size(159, 25));
		((Control)label95).set_TabIndex(155);
		((Control)label95).set_Text("单位：毫秒，默认延时时间为1000毫秒");
		((Control)label140).set_Anchor((AnchorStyles)6);
		((Control)label140).set_AutoSize(true);
		((Control)label140).set_ForeColor(Color.Red);
		((Control)label140).set_Location(new Point(15, 132));
		((Control)label140).set_Name("label140");
		((Control)label140).set_Size(new Size(65, 12));
		((Control)label140).set_TabIndex(154);
		((Control)label140).set_Text("操作延时：");
		((Control)textBox20).set_Anchor((AnchorStyles)6);
		((Control)textBox20).set_ForeColor(Color.Black);
		((Control)textBox20).set_Location(new Point(98, 128));
		((Control)textBox20).set_Name("textBox20");
		((Control)textBox20).set_Size(new Size(73, 21));
		((Control)textBox20).set_TabIndex(153);
		((Control)textBox20).add_TextChanged((EventHandler)textBox20_TextChanged);
		toolStrip1.set_ImageScalingSize(new Size(48, 48));
		toolStrip1.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)toolStripButton_0,
			(ToolStripItem)toolStripButton_1,
			(ToolStripItem)toolStripButton_2,
			(ToolStripItem)toolStripButton_3,
			(ToolStripItem)toolStripButtonHelp,
			(ToolStripItem)toolStripLabel1,
			(ToolStripItem)toolStripButton_4,
			(ToolStripItem)toolStripButton_5
		});
		((Control)toolStrip1).set_Location(new Point(0, 24));
		((Control)toolStrip1).set_Name("toolStrip1");
		((Control)toolStrip1).set_Size(new Size(988, 43));
		((Control)toolStrip1).set_TabIndex(20);
		((Control)toolStrip1).set_Text("toolStrip1");
		((ToolStripItem)toolStripButton_0).set_AutoSize(false);
		((ToolStripItem)toolStripButton_0).set_BackColor(SystemColors.Control);
		((ToolStripItem)toolStripButton_0).set_Image((Image)componentResourceManager.GetObject("刷新toolStripButton.Image"));
		((ToolStripItem)toolStripButton_0).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripButton_0).set_Name("刷新toolStripButton");
		((ToolStripItem)toolStripButton_0).set_Size(new Size(70, 40));
		((ToolStripItem)toolStripButton_0).set_Text(" 刷新");
		((ToolStripItem)toolStripButton_0).set_ToolTipText("刷新抢车位信息");
		((ToolStripItem)toolStripButton_0).add_Click((EventHandler)toolStripButton_0_Click);
		((ToolStripItem)toolStripButton_1).set_AutoSize(false);
		((ToolStripItem)toolStripButton_1).set_BackColor(SystemColors.Control);
		((ToolStripItem)toolStripButton_1).set_Image((Image)componentResourceManager.GetObject("主页toolStripButton.Image"));
		((ToolStripItem)toolStripButton_1).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripButton_1).set_Name("主页toolStripButton");
		((ToolStripItem)toolStripButton_1).set_Size(new Size(70, 40));
		((ToolStripItem)toolStripButton_1).set_Text("主页");
		((ToolStripItem)toolStripButton_1).set_ToolTipText("打开官方论坛");
		((ToolStripItem)toolStripButton_1).add_Click((EventHandler)toolStripButton_1_Click);
		((ToolStripItem)toolStripButton_2).set_AutoSize(false);
		((ToolStripItem)toolStripButton_2).set_BackColor(SystemColors.Control);
		((ToolStripItem)toolStripButton_2).set_Image((Image)componentResourceManager.GetObject("好友分析toolStripButton.Image"));
		((ToolStripItem)toolStripButton_2).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripButton_2).set_Name("好友分析toolStripButton");
		((ToolStripItem)toolStripButton_2).set_Size(new Size(100, 40));
		((ToolStripItem)toolStripButton_2).set_Text("好友分析");
		((ToolStripItem)toolStripButton_2).set_ToolTipText("分析你的QQ好友");
		((ToolStripItem)toolStripButton_2).add_Click((EventHandler)toolStripButton_2_Click);
		((ToolStripItem)toolStripButton_3).set_AutoSize(false);
		((ToolStripItem)toolStripButton_3).set_BackColor(SystemColors.Control);
		((ToolStripItem)toolStripButton_3).set_Image((Image)componentResourceManager.GetObject("配置toolStripButton.Image"));
		((ToolStripItem)toolStripButton_3).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripButton_3).set_Name("配置toolStripButton");
		((ToolStripItem)toolStripButton_3).set_Size(new Size(70, 40));
		((ToolStripItem)toolStripButton_3).set_Text("配置");
		((ToolStripItem)toolStripButton_3).set_ToolTipText("系统配置");
		((ToolStripItem)toolStripButton_3).add_Click((EventHandler)toolStripButton_3_Click);
		((ToolStripItem)toolStripButtonHelp).set_AutoSize(false);
		((ToolStripItem)toolStripButtonHelp).set_BackColor(SystemColors.Control);
		((ToolStripItem)toolStripButtonHelp).set_Image((Image)componentResourceManager.GetObject("toolStripButtonHelp.Image"));
		((ToolStripItem)toolStripButtonHelp).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripButtonHelp).set_Name("toolStripButtonHelp");
		((ToolStripItem)toolStripButtonHelp).set_Size(new Size(70, 40));
		((ToolStripItem)toolStripButtonHelp).set_Text(" 帮助");
		((ToolStripItem)toolStripButtonHelp).set_ToolTipText("查看帮助文档");
		((ToolStripItem)toolStripButtonHelp).add_Click((EventHandler)toolStripButtonHelp_Click);
		((ToolStripItem)toolStripLabel1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((ToolStripItem)toolStripLabel1).set_ForeColor(Color.Blue);
		((ToolStripItem)toolStripLabel1).set_Name("toolStripLabel1");
		((ToolStripItem)toolStripLabel1).set_Size(new Size(0, 40));
		((ToolStripItem)toolStripButton_4).set_AutoSize(false);
		((ToolStripItem)toolStripButton_4).set_BackColor(SystemColors.Control);
		((ToolStripItem)toolStripButton_4).set_ForeColor(Color.Red);
		((ToolStripItem)toolStripButton_4).set_Image((Image)componentResourceManager.GetObject("检测新版本toolStripButton1.Image"));
		((ToolStripItem)toolStripButton_4).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripButton_4).set_Name("检测新版本toolStripButton1");
		((ToolStripItem)toolStripButton_4).set_Size(new Size(110, 40));
		((ToolStripItem)toolStripButton_4).set_Text("检测新版本");
		((ToolStripItem)toolStripButton_4).set_ToolTipText("系统配置");
		((ToolStripItem)toolStripButton_4).add_Click((EventHandler)toolStripButton_4_Click);
		((ToolStripItem)toolStripButton_5).set_AutoSize(false);
		((ToolStripItem)toolStripButton_5).set_BackColor(SystemColors.Control);
		((ToolStripItem)toolStripButton_5).set_ForeColor(Color.Red);
		((ToolStripItem)toolStripButton_5).set_Image((Image)componentResourceManager.GetObject("学习QQ捕快开发toolStripButton1.Image"));
		((ToolStripItem)toolStripButton_5).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripButton_5).set_Name("学习QQ捕快开发toolStripButton1");
		((ToolStripItem)toolStripButton_5).set_Size(new Size(130, 40));
		((ToolStripItem)toolStripButton_5).set_Text("学习QQ捕快开发");
		((ToolStripItem)toolStripButton_5).set_ToolTipText("系统配置");
		((ToolStripItem)toolStripButton_5).add_Click((EventHandler)toolStripButton_5_Click);
		((ToolStrip)statusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)toolStripStatusLabel1 });
		((Control)statusStrip1).set_Location(new Point(0, 644));
		((Control)statusStrip1).set_Name("statusStrip1");
		((Control)statusStrip1).set_Size(new Size(988, 22));
		((Control)statusStrip1).set_TabIndex(21);
		((Control)statusStrip1).set_Text("statusStrip1");
		((ToolStripItem)toolStripStatusLabel1).set_Font(new Font("宋体", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)134));
		((ToolStripItem)toolStripStatusLabel1).set_Name("toolStripStatusLabel1");
		((ToolStripItem)toolStripStatusLabel1).set_Size(new Size(166, 17));
		((ToolStripItem)toolStripStatusLabel1).set_Text("E-Mail:yxzbbc@gmail.com");
		toolTipAll.set_BackColor(Color.Transparent);
		toolTipAll.set_ForeColor(SystemColors.WindowText);
		toolTipAll.set_IsBalloon(true);
		((Control)button68).set_Anchor((AnchorStyles)9);
		((Control)button68).set_Location(new Point(224, 200));
		((Control)button68).set_Name("button68");
		((Control)button68).set_Size(new Size(20, 20));
		((Control)button68).set_TabIndex(99);
		((Control)button68).set_Text("√");
		toolTipAll.SetToolTip((Control)(object)button68, "全选");
		((ButtonBase)button68).set_UseVisualStyleBackColor(true);
		((Control)button69).set_Anchor((AnchorStyles)9);
		((Control)button69).set_Location(new Point(250, 200));
		((Control)button69).set_Name("button69");
		((Control)button69).set_Size(new Size(20, 20));
		((Control)button69).set_TabIndex(98);
		((Control)button69).set_Text("×");
		toolTipAll.SetToolTip((Control)(object)button69, "全不选");
		((ButtonBase)button69).set_UseVisualStyleBackColor(true);
		((Control)button81).set_Anchor((AnchorStyles)9);
		((Control)button81).set_Location(new Point(172, 36));
		((Control)button81).set_Name("button81");
		((Control)button81).set_Size(new Size(20, 20));
		((Control)button81).set_TabIndex(79);
		((Control)button81).set_Text("刷");
		toolTipAll.SetToolTip((Control)(object)button81, "刷新我的等级和经验");
		((ButtonBase)button81).set_UseVisualStyleBackColor(true);
		((Control)button81).add_Click((EventHandler)button81_Click);
		((Control)buttonDaoRuJunDao).set_ForeColor(Color.Black);
		((Control)buttonDaoRuJunDao).set_Location(new Point(-1, 1));
		((Control)buttonDaoRuJunDao).set_Name("buttonDaoRuJunDao");
		((Control)buttonDaoRuJunDao).set_Size(new Size(46, 22));
		((Control)buttonDaoRuJunDao).set_TabIndex(7);
		((Control)buttonDaoRuJunDao).set_Text("导入X刀QQ账号");
		toolTipAll.SetToolTip((Control)(object)buttonDaoRuJunDao, "导入X刀QQ账号，暂时不支持密码导入");
		((ButtonBase)buttonDaoRuJunDao).set_UseVisualStyleBackColor(true);
		((Control)buttonDaoRuJunDao).set_Visible(false);
		((Control)buttonDaoRuJunDao).add_Click((EventHandler)buttonDaoRuJunDao_Click);
		((Control)button_34).set_ForeColor(Color.Black);
		((Control)button_34).set_Location(new Point(15, 41));
		((Control)button_34).set_Name("button导出Txt文件QQ账号");
		((Control)button_34).set_Size(new Size(162, 28));
		((Control)button_34).set_TabIndex(25);
		((Control)button_34).set_Text("导出Txt文件QQ账号");
		toolTipAll.SetToolTip((Control)(object)button_34, "导出Txt文件QQ账号，Txt格式为每行一个QQ号码和密码，QQ号码和密码以----间隔");
		((ButtonBase)button_34).set_UseVisualStyleBackColor(true);
		((Control)button_34).add_Click((EventHandler)button_34_Click);
		((Control)pictureBoxValidate).set_Cursor(Cursors.get_Hand());
		((Control)pictureBoxValidate).set_Location(new Point(30, 236));
		((Control)pictureBoxValidate).set_Name("pictureBoxValidate");
		((Control)pictureBoxValidate).set_Size(new Size(133, 50));
		pictureBoxValidate.set_TabIndex(4);
		pictureBoxValidate.set_TabStop(false);
		toolTipAll.SetToolTip((Control)(object)pictureBoxValidate, "点击左键重新获取验证码");
		((Control)pictureBoxValidate).add_Click((EventHandler)pictureBoxValidate_Click);
		((Control)button8).set_Anchor((AnchorStyles)9);
		((Control)button8).set_Location(new Point(665, 128));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Size(new Size(20, 20));
		((Control)button8).set_TabIndex(63);
		((Control)button8).set_Text("筛");
		((ButtonBase)button8).set_UseVisualStyleBackColor(true);
		((Control)button9).set_Anchor((AnchorStyles)9);
		((Control)button9).set_Location(new Point(613, 128));
		((Control)button9).set_Name("button9");
		((Control)button9).set_Size(new Size(20, 20));
		((Control)button9).set_TabIndex(58);
		((Control)button9).set_Text("√");
		((ButtonBase)button9).set_UseVisualStyleBackColor(true);
		((Control)button10).set_Anchor((AnchorStyles)9);
		((Control)button10).set_Location(new Point(639, 128));
		((Control)button10).set_Name("button10");
		((Control)button10).set_Size(new Size(20, 20));
		((Control)button10).set_TabIndex(55);
		((Control)button10).set_Text("×");
		((ButtonBase)button10).set_UseVisualStyleBackColor(true);
		((Control)button11).set_Anchor((AnchorStyles)9);
		((Control)button11).set_Location(new Point(665, 4));
		((Control)button11).set_Name("button11");
		((Control)button11).set_Size(new Size(20, 20));
		((Control)button11).set_TabIndex(54);
		((Control)button11).set_Text("√");
		((ButtonBase)button11).set_UseVisualStyleBackColor(true);
		((Control)button12).set_Anchor((AnchorStyles)9);
		((Control)button12).set_Location(new Point(691, 128));
		((Control)button12).set_Name("button12");
		((Control)button12).set_Size(new Size(20, 20));
		((Control)button12).set_TabIndex(52);
		((Control)button12).set_Text("原");
		((ButtonBase)button12).set_UseVisualStyleBackColor(true);
		((Control)button13).set_Anchor((AnchorStyles)9);
		((Control)button13).set_Location(new Point(691, 4));
		((Control)button13).set_Name("button13");
		((Control)button13).set_Size(new Size(20, 20));
		((Control)button13).set_TabIndex(51);
		((Control)button13).set_Text("×");
		((ButtonBase)button13).set_UseVisualStyleBackColor(true);
		((Control)button14).set_Anchor((AnchorStyles)9);
		((Control)button14).set_Location(new Point(717, 128));
		((Control)button14).set_Name("button14");
		((Control)button14).set_Size(new Size(20, 20));
		((Control)button14).set_TabIndex(49);
		((Control)button14).set_Text("挪");
		((ButtonBase)button14).set_UseVisualStyleBackColor(true);
		((Control)button15).set_Anchor((AnchorStyles)9);
		((Control)button15).set_Location(new Point(717, 4));
		((Control)button15).set_Name("button15");
		((Control)button15).set_Size(new Size(20, 20));
		((Control)button15).set_TabIndex(48);
		((Control)button15).set_Text("贴");
		((ButtonBase)button15).set_UseVisualStyleBackColor(true);
		((Control)button16).set_Anchor((AnchorStyles)9);
		((Control)button16).set_Location(new Point(743, 360));
		((Control)button16).set_Name("button16");
		((Control)button16).set_Size(new Size(20, 20));
		((Control)button16).set_TabIndex(45);
		((Control)button16).set_Text("刷");
		((ButtonBase)button16).set_UseVisualStyleBackColor(true);
		((Control)button17).set_Anchor((AnchorStyles)9);
		((Control)button17).set_Location(new Point(743, 128));
		((Control)button17).set_Name("button17");
		((Control)button17).set_Size(new Size(20, 20));
		((Control)button17).set_TabIndex(40);
		((Control)button17).set_Text("刷");
		((ButtonBase)button17).set_UseVisualStyleBackColor(true);
		((Control)button18).set_Anchor((AnchorStyles)9);
		((Control)button18).set_Location(new Point(743, 4));
		((Control)button18).set_Name("button18");
		((Control)button18).set_Size(new Size(20, 20));
		((Control)button18).set_TabIndex(38);
		((Control)button18).set_Text("刷");
		((ButtonBase)button18).set_UseVisualStyleBackColor(true);
		((Control)button19).set_Location(new Point(374, 307));
		((Control)button19).set_Name("button19");
		((Control)button19).set_Size(new Size(89, 55));
		((Control)button19).set_TabIndex(49);
		((Control)button19).set_Text("买车");
		((ButtonBase)button19).set_UseVisualStyleBackColor(true);
		((Control)button20).set_Location(new Point(374, 235));
		((Control)button20).set_Name("button20");
		((Control)button20).set_Size(new Size(89, 55));
		((Control)button20).set_TabIndex(48);
		((Control)button20).set_Text("换车");
		((ButtonBase)button20).set_UseVisualStyleBackColor(true);
		((Control)button21).set_Anchor((AnchorStyles)9);
		((Control)button21).set_Location(new Point(741, 137));
		((Control)button21).set_Name("button21");
		((Control)button21).set_Size(new Size(20, 20));
		((Control)button21).set_TabIndex(79);
		((Control)button21).set_Text("刷");
		((ButtonBase)button21).set_UseVisualStyleBackColor(true);
		((Control)button22).set_Anchor((AnchorStyles)9);
		((Control)button22).set_Location(new Point(741, 8));
		((Control)button22).set_Name("button22");
		((Control)button22).set_Size(new Size(20, 20));
		((Control)button22).set_TabIndex(78);
		((Control)button22).set_Text("刷");
		((ButtonBase)button22).set_UseVisualStyleBackColor(true);
		((Control)button23).set_Anchor((AnchorStyles)9);
		((Control)button23).set_Location(new Point(715, 137));
		((Control)button23).set_Name("button23");
		((Control)button23).set_Size(new Size(20, 20));
		((Control)button23).set_TabIndex(77);
		((Control)button23).set_Text("举");
		((ButtonBase)button23).set_UseVisualStyleBackColor(true);
		((Control)button24).set_Anchor((AnchorStyles)9);
		((Control)button24).set_Location(new Point(663, 137));
		((Control)button24).set_Name("button24");
		((Control)button24).set_Size(new Size(20, 20));
		((Control)button24).set_TabIndex(76);
		((Control)button24).set_Text("√");
		((ButtonBase)button24).set_UseVisualStyleBackColor(true);
		((Control)button25).set_Anchor((AnchorStyles)9);
		((Control)button25).set_Location(new Point(689, 137));
		((Control)button25).set_Name("button25");
		((Control)button25).set_Size(new Size(20, 20));
		((Control)button25).set_TabIndex(75);
		((Control)button25).set_Text("×");
		((ButtonBase)button25).set_UseVisualStyleBackColor(true);
		((Control)button26).set_Anchor((AnchorStyles)9);
		((Control)button26).set_Location(new Point(663, 8));
		((Control)button26).set_Name("button26");
		((Control)button26).set_Size(new Size(20, 20));
		((Control)button26).set_TabIndex(74);
		((Control)button26).set_Text("√");
		((ButtonBase)button26).set_UseVisualStyleBackColor(true);
		((Control)button27).set_Anchor((AnchorStyles)9);
		((Control)button27).set_Location(new Point(689, 8));
		((Control)button27).set_Name("button27");
		((Control)button27).set_Size(new Size(20, 20));
		((Control)button27).set_TabIndex(73);
		((Control)button27).set_Text("×");
		((ButtonBase)button27).set_UseVisualStyleBackColor(true);
		((Control)button28).set_Anchor((AnchorStyles)9);
		((Control)button28).set_Location(new Point(715, 8));
		((Control)button28).set_Name("button28");
		((Control)button28).set_Size(new Size(20, 20));
		((Control)button28).set_TabIndex(72);
		((Control)button28).set_Text("举");
		((ButtonBase)button28).set_UseVisualStyleBackColor(true);
		((Control)button29).set_Location(new Point(333, 5));
		((Control)button29).set_Name("button29");
		((Control)button29).set_Size(new Size(61, 23));
		((Control)button29).set_TabIndex(2);
		((Control)button29).set_Text("查");
		((ButtonBase)button29).set_UseVisualStyleBackColor(true);
		((Control)button3).set_Anchor((AnchorStyles)9);
		((Control)button3).set_Location(new Point(708, 352));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(20, 20));
		((Control)button3).set_TabIndex(97);
		((Control)button3).set_Text("存");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button4).set_Anchor((AnchorStyles)9);
		((Control)button4).set_Location(new Point(653, 126));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(20, 20));
		((Control)button4).set_TabIndex(96);
		((Control)button4).set_Text("批");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button5).set_Anchor((AnchorStyles)9);
		((Control)button5).set_Location(new Point(626, 126));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(20, 20));
		((Control)button5).set_TabIndex(91);
		((Control)button5).set_Text("筛");
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button6).set_Anchor((AnchorStyles)9);
		((Control)button6).set_Location(new Point(570, 126));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(20, 20));
		((Control)button6).set_TabIndex(86);
		((Control)button6).set_Text("√");
		((ButtonBase)button6).set_UseVisualStyleBackColor(true);
		((Control)button7).set_Anchor((AnchorStyles)9);
		((Control)button7).set_Location(new Point(599, 126));
		((Control)button7).set_Name("button7");
		((Control)button7).set_Size(new Size(20, 20));
		((Control)button7).set_TabIndex(85);
		((Control)button7).set_Text("×");
		((ButtonBase)button7).set_UseVisualStyleBackColor(true);
		((Control)button39).set_Anchor((AnchorStyles)9);
		((Control)button39).set_Location(new Point(658, 4));
		((Control)button39).set_Name("button39");
		((Control)button39).set_Size(new Size(20, 20));
		((Control)button39).set_TabIndex(84);
		((Control)button39).set_Text("√");
		((ButtonBase)button39).set_UseVisualStyleBackColor(true);
		((Control)button40).set_Anchor((AnchorStyles)9);
		((Control)button40).set_Location(new Point(680, 126));
		((Control)button40).set_Name("button40");
		((Control)button40).set_Size(new Size(20, 20));
		((Control)button40).set_TabIndex(83);
		((Control)button40).set_Text("原");
		((ButtonBase)button40).set_UseVisualStyleBackColor(true);
		((Control)button41).set_Anchor((AnchorStyles)9);
		((Control)button41).set_Location(new Point(684, 4));
		((Control)button41).set_Name("button41");
		((Control)button41).set_Size(new Size(20, 20));
		((Control)button41).set_TabIndex(82);
		((Control)button41).set_Text("×");
		((ButtonBase)button41).set_UseVisualStyleBackColor(true);
		((Control)button42).set_Anchor((AnchorStyles)9);
		((Control)button42).set_Location(new Point(706, 126));
		((Control)button42).set_Name("button42");
		((Control)button42).set_Size(new Size(20, 20));
		((Control)button42).set_TabIndex(81);
		((Control)button42).set_Text("挪");
		((ButtonBase)button42).set_UseVisualStyleBackColor(true);
		((Control)button43).set_Anchor((AnchorStyles)9);
		((Control)button43).set_Location(new Point(710, 4));
		((Control)button43).set_Name("button43");
		((Control)button43).set_Size(new Size(20, 20));
		((Control)button43).set_TabIndex(80);
		((Control)button43).set_Text("贴");
		((ButtonBase)button43).set_UseVisualStyleBackColor(true);
		((Control)button44).set_Anchor((AnchorStyles)9);
		((Control)button44).set_Location(new Point(735, 352));
		((Control)button44).set_Name("button44");
		((Control)button44).set_Size(new Size(20, 20));
		((Control)button44).set_TabIndex(77);
		((Control)button44).set_Text("刷");
		((ButtonBase)button44).set_UseVisualStyleBackColor(true);
		((Control)button45).set_Anchor((AnchorStyles)9);
		((Control)button45).set_Location(new Point(732, 126));
		((Control)button45).set_Name("button45");
		((Control)button45).set_Size(new Size(20, 20));
		((Control)button45).set_TabIndex(72);
		((Control)button45).set_Text("刷");
		((ButtonBase)button45).set_UseVisualStyleBackColor(true);
		((Control)button46).set_Anchor((AnchorStyles)9);
		((Control)button46).set_Location(new Point(736, 4));
		((Control)button46).set_Name("button46");
		((Control)button46).set_Size(new Size(20, 20));
		((Control)button46).set_TabIndex(70);
		((Control)button46).set_Text("刷");
		((ButtonBase)button46).set_UseVisualStyleBackColor(true);
		((Control)button47).set_Anchor((AnchorStyles)9);
		((Control)button47).set_Location(new Point(735, 175));
		((Control)button47).set_Name("button47");
		((Control)button47).set_Size(new Size(20, 20));
		((Control)button47).set_TabIndex(116);
		((Control)button47).set_Text("刷");
		((ButtonBase)button47).set_UseVisualStyleBackColor(true);
		((Control)button48).set_Anchor((AnchorStyles)9);
		((Control)button48).set_Location(new Point(735, 46));
		((Control)button48).set_Name("button48");
		((Control)button48).set_Size(new Size(20, 20));
		((Control)button48).set_TabIndex(115);
		((Control)button48).set_Text("刷");
		((ButtonBase)button48).set_UseVisualStyleBackColor(true);
		((Control)button49).set_Anchor((AnchorStyles)9);
		((Control)button49).set_Location(new Point(709, 175));
		((Control)button49).set_Name("button49");
		((Control)button49).set_Size(new Size(20, 20));
		((Control)button49).set_TabIndex(114);
		((Control)button49).set_Text("举");
		((ButtonBase)button49).set_UseVisualStyleBackColor(true);
		((Control)button50).set_Anchor((AnchorStyles)9);
		((Control)button50).set_Location(new Point(657, 175));
		((Control)button50).set_Name("button50");
		((Control)button50).set_Size(new Size(20, 20));
		((Control)button50).set_TabIndex(113);
		((Control)button50).set_Text("√");
		((ButtonBase)button50).set_UseVisualStyleBackColor(true);
		((Control)button51).set_Anchor((AnchorStyles)9);
		((Control)button51).set_Location(new Point(683, 175));
		((Control)button51).set_Name("button51");
		((Control)button51).set_Size(new Size(20, 20));
		((Control)button51).set_TabIndex(112);
		((Control)button51).set_Text("×");
		((ButtonBase)button51).set_UseVisualStyleBackColor(true);
		((Control)button52).set_Anchor((AnchorStyles)9);
		((Control)button52).set_Location(new Point(657, 46));
		((Control)button52).set_Name("button52");
		((Control)button52).set_Size(new Size(20, 20));
		((Control)button52).set_TabIndex(111);
		((Control)button52).set_Text("√");
		((ButtonBase)button52).set_UseVisualStyleBackColor(true);
		((Control)button53).set_Anchor((AnchorStyles)9);
		((Control)button53).set_Location(new Point(683, 46));
		((Control)button53).set_Name("button53");
		((Control)button53).set_Size(new Size(20, 20));
		((Control)button53).set_TabIndex(110);
		((Control)button53).set_Text("×");
		((ButtonBase)button53).set_UseVisualStyleBackColor(true);
		((Control)button54).set_Anchor((AnchorStyles)9);
		((Control)button54).set_Location(new Point(709, 46));
		((Control)button54).set_Name("button54");
		((Control)button54).set_Size(new Size(20, 20));
		((Control)button54).set_TabIndex(109);
		((Control)button54).set_Text("举");
		((ButtonBase)button54).set_UseVisualStyleBackColor(true);
		((Control)button55).set_Location(new Point(327, 8));
		((Control)button55).set_Name("button55");
		((Control)button55).set_Size(new Size(61, 23));
		((Control)button55).set_TabIndex(100);
		((Control)button55).set_Text("查");
		((ButtonBase)button55).set_UseVisualStyleBackColor(true);
		((Control)button56).set_Location(new Point(387, 226));
		((Control)button56).set_Name("button56");
		((Control)button56).set_Size(new Size(89, 31));
		((Control)button56).set_TabIndex(96);
		((Control)button56).set_Text("买车");
		((ButtonBase)button56).set_UseVisualStyleBackColor(true);
		((Control)button57).set_Location(new Point(501, 226));
		((Control)button57).set_Name("button57");
		((Control)button57).set_Size(new Size(89, 31));
		((Control)button57).set_TabIndex(95);
		((Control)button57).set_Text("换车");
		((ButtonBase)button57).set_UseVisualStyleBackColor(true);
		((Control)button58).set_Location(new Point(14, 11));
		((Control)button58).set_Name("button58");
		((Control)button58).set_Size(new Size(108, 30));
		((Control)button58).set_TabIndex(71);
		((Control)button58).set_Text("刷新");
		((ButtonBase)button58).set_UseVisualStyleBackColor(true);
		((Control)button59).set_Location(new Point(14, 11));
		((Control)button59).set_Name("button59");
		((Control)button59).set_Size(new Size(108, 30));
		((Control)button59).set_TabIndex(72);
		((Control)button59).set_Text("刷新");
		((ButtonBase)button59).set_UseVisualStyleBackColor(true);
		notifyIcon1.set_ContextMenuStrip(MenuNotify);
		notifyIcon1.set_Icon((Icon)componentResourceManager.GetObject("notifyIcon1.Icon"));
		notifyIcon1.set_Text("QQ捕快2009");
		notifyIcon1.set_Visible(true);
		notifyIcon1.add_MouseDoubleClick(new MouseEventHandler(notifyIcon1_MouseDoubleClick));
		((ToolStrip)MenuNotify).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)toolStripMenuItem_56,
			(ToolStripItem)toolStripMenuItem_47,
			(ToolStripItem)toolStripMenuItem_54,
			(ToolStripItem)toolStripMenuItem_21,
			(ToolStripItem)toolStripMenuItem_7,
			(ToolStripItem)toolStripMenuItem_8
		});
		((Control)MenuNotify).set_Name("MenuNotify");
		((Control)MenuNotify).set_Size(new Size(167, 136));
		((ToolStripItem)toolStripMenuItem_56).set_Name("检测新版本ToolStripMenuItem1");
		((ToolStripItem)toolStripMenuItem_56).set_Size(new Size(166, 22));
		((ToolStripItem)toolStripMenuItem_56).set_Text("检测新版本");
		((ToolStripItem)toolStripMenuItem_56).add_Click((EventHandler)toolStripMenuItem_56_Click);
		((ToolStripItem)toolStripMenuItem_47).set_Name("去作者的网盘下载ToolStripMenuItem1");
		((ToolStripItem)toolStripMenuItem_47).set_Size(new Size(166, 22));
		((ToolStripItem)toolStripMenuItem_47).set_Text("去作者的网盘下载");
		((ToolStripItem)toolStripMenuItem_47).add_Click((EventHandler)toolStripMenuItem_47_Click);
		((ToolStripItem)toolStripMenuItem_54).set_Name("备用网盘ToolStripMenuItem1");
		((ToolStripItem)toolStripMenuItem_54).set_Size(new Size(166, 22));
		((ToolStripItem)toolStripMenuItem_54).set_Text("备用网盘");
		((ToolStripItem)toolStripMenuItem_54).add_Click((EventHandler)toolStripMenuItem_54_Click);
		((ToolStripItem)toolStripMenuItem_21).set_Name("软件更新toolStripMenuItem2");
		((ToolStripItem)toolStripMenuItem_21).set_Size(new Size(166, 22));
		((ToolStripItem)toolStripMenuItem_21).set_Text("软件更新");
		((ToolStripItem)toolStripMenuItem_21).add_Click((EventHandler)toolStripMenuItem_21_Click);
		((ToolStripItem)toolStripMenuItem_7).set_Name("显示ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_7).set_Size(new Size(166, 22));
		((ToolStripItem)toolStripMenuItem_7).set_Text("显示");
		((ToolStripItem)toolStripMenuItem_7).add_Click((EventHandler)toolStripMenuItem_7_Click);
		((ToolStripItem)toolStripMenuItem_8).set_Name("退出ToolStripMenuItem1");
		((ToolStripItem)toolStripMenuItem_8).set_Size(new Size(166, 22));
		((ToolStripItem)toolStripMenuItem_8).set_Text("退出");
		((ToolStripItem)toolStripMenuItem_8).add_Click((EventHandler)toolStripMenuItem_8_Click);
		((Control)label26).set_Anchor((AnchorStyles)13);
		((Control)label26).set_BackColor(SystemColors.InactiveCaptionText);
		((Control)label26).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label26).set_Location(new Point(6, 2));
		((Control)label26).set_Name("label26");
		((Control)label26).set_Size(new Size(761, 19));
		((Control)label26).set_TabIndex(3);
		((Control)label26).set_Text("我自己");
		((Control)listBox4).set_Anchor((AnchorStyles)13);
		((Control)listBox4).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listBox4).set_Font(new Font("宋体", 9f));
		((ListControl)listBox4).set_FormattingEnabled(true);
		listBox4.set_ItemHeight(12);
		((Control)listBox4).set_Location(new Point(6, 21));
		((Control)listBox4).set_Name("listBox4");
		((Control)listBox4).set_Size(new Size(765, 220));
		((Control)listBox4).set_TabIndex(2);
		((Control)tabPage1).set_BackColor(Color.Transparent);
		((Control)tabPage1).get_Controls().Add((Control)(object)label28);
		((Control)tabPage1).get_Controls().Add((Control)(object)label29);
		((Control)tabPage1).get_Controls().Add((Control)(object)label30);
		((Control)tabPage1).get_Controls().Add((Control)(object)button8);
		((Control)tabPage1).get_Controls().Add((Control)(object)label31);
		((Control)tabPage1).get_Controls().Add((Control)(object)comboBox1);
		((Control)tabPage1).get_Controls().Add((Control)(object)label32);
		((Control)tabPage1).get_Controls().Add((Control)(object)checkBox4);
		((Control)tabPage1).get_Controls().Add((Control)(object)button9);
		((Control)tabPage1).get_Controls().Add((Control)(object)button10);
		((Control)tabPage1).get_Controls().Add((Control)(object)button11);
		((Control)tabPage1).get_Controls().Add((Control)(object)button12);
		((Control)tabPage1).get_Controls().Add((Control)(object)button13);
		((Control)tabPage1).get_Controls().Add((Control)(object)button14);
		((Control)tabPage1).get_Controls().Add((Control)(object)button15);
		((Control)tabPage1).get_Controls().Add((Control)(object)label33);
		((Control)tabPage1).get_Controls().Add((Control)(object)button16);
		((Control)tabPage1).get_Controls().Add((Control)(object)listView1);
		((Control)tabPage1).get_Controls().Add((Control)(object)label34);
		((Control)tabPage1).get_Controls().Add((Control)(object)label35);
		((Control)tabPage1).get_Controls().Add((Control)(object)label36);
		((Control)tabPage1).get_Controls().Add((Control)(object)button17);
		((Control)tabPage1).get_Controls().Add((Control)(object)listView2);
		((Control)tabPage1).get_Controls().Add((Control)(object)button18);
		((Control)tabPage1).get_Controls().Add((Control)(object)listView3);
		tabPage1.set_Location(new Point(4, 21));
		((Control)tabPage1).set_Name("tabPage1");
		((Control)tabPage1).set_Padding(new Padding(3));
		((Control)tabPage1).set_Size(new Size(774, 561));
		tabPage1.set_TabIndex(0);
		((Control)tabPage1).set_Text("抢车位");
		tabPage1.set_UseVisualStyleBackColor(true);
		((Control)label28).set_AutoSize(true);
		((Control)label28).set_ForeColor(Color.Red);
		((Control)label28).set_Location(new Point(309, 363));
		((Control)label28).set_Name("label28");
		((Control)label28).set_Size(new Size(137, 12));
		((Control)label28).set_TabIndex(66);
		((Control)label28).set_Text("单击列可以按列进行排序");
		((Control)label29).set_AutoSize(true);
		((Control)label29).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label29).set_Location(new Point(128, 8));
		((Control)label29).set_Name("label29");
		((Control)label29).set_Size(new Size(65, 12));
		((Control)label29).set_TabIndex(65);
		((Control)label29).set_Text("贴条收入：");
		((Control)label30).set_AutoSize(true);
		((Control)label30).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label30).set_Location(new Point(440, 8));
		((Control)label30).set_Name("label30");
		((Control)label30).set_Size(new Size(53, 12));
		((Control)label30).set_TabIndex(64);
		((Control)label30).set_Text("车辆数：");
		((Control)label31).set_AutoSize(true);
		((Control)label31).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label31).set_Location(new Point(267, 8));
		((Control)label31).set_Name("label31");
		((Control)label31).set_Size(new Size(65, 12));
		((Control)label31).set_TabIndex(62);
		((Control)label31).set_Text("开通日期：");
		((Control)comboBox1).set_Anchor((AnchorStyles)9);
		((ListControl)comboBox1).set_FormattingEnabled(true);
		((Control)comboBox1).set_Location(new Point(422, 128));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(185, 20));
		((Control)comboBox1).set_TabIndex(61);
		((Control)label32).set_Anchor((AnchorStyles)9);
		((Control)label32).set_AutoSize(true);
		((Control)label32).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label32).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label32).set_Location(new Point(339, 134));
		((Control)label32).set_Name("label32");
		((Control)label32).set_Size(new Size(77, 12));
		((Control)label32).set_TabIndex(60);
		((Control)label32).set_Text("过渡停车场：");
		((Control)checkBox4).set_Anchor((AnchorStyles)9);
		((Control)checkBox4).set_AutoSize(true);
		((Control)checkBox4).set_Location(new Point(539, 6));
		((Control)checkBox4).set_Name("checkBox4");
		((Control)checkBox4).set_Size(new Size(96, 16));
		((Control)checkBox4).set_TabIndex(59);
		((Control)checkBox4).set_Text("被贴自动回停");
		((ButtonBase)checkBox4).set_UseVisualStyleBackColor(true);
		((Control)label33).set_AutoSize(true);
		((Control)label33).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label33).set_Location(new Point(9, 363));
		((Control)label33).set_Name("label33");
		((Control)label33).set_Size(new Size(137, 12));
		((Control)label33).set_TabIndex(47);
		((Control)label33).set_Text("你在好友圈内排行位数：");
		((Control)listView1).set_Anchor((AnchorStyles)15);
		listView1.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[7] { columnHeader67, columnHeader68, columnHeader69, columnHeader70, columnHeader71, columnHeader72, columnHeader73 });
		((Control)listView1).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView1).set_Cursor(Cursors.get_Default());
		((Control)listView1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listView1.set_FullRowSelect(true);
		listView1.set_GridLines(true);
		((Control)listView1).set_Location(new Point(8, 384));
		listView1.set_MultiSelect(false);
		((Control)listView1).set_Name("listView1");
		((Control)listView1).set_Size(new Size(763, 159));
		((Control)listView1).set_TabIndex(46);
		listView1.set_UseCompatibleStateImageBehavior(false);
		listView1.set_View((View)1);
		columnHeader67.set_Text("QQ号码");
		columnHeader67.set_Width(100);
		columnHeader68.set_Text("昵称");
		columnHeader68.set_Width(117);
		columnHeader69.set_Text("现金");
		columnHeader69.set_Width(68);
		columnHeader70.set_Text("汽车总价");
		columnHeader70.set_Width(85);
		columnHeader71.set_Text("状态");
		columnHeader71.set_Width(112);
		columnHeader72.set_Text("空车位");
		columnHeader72.set_Width(116);
		columnHeader73.set_Text("信息");
		columnHeader73.set_Width(128);
		((Control)label34).set_AutoSize(true);
		((Control)label34).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label34).set_Location(new Point(9, 8));
		((Control)label34).set_Name("label34");
		((Control)label34).set_Size(new Size(41, 12));
		((Control)label34).set_TabIndex(44);
		((Control)label34).set_Text("现金：");
		((Control)label35).set_AutoSize(true);
		((Control)label35).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label35).set_Location(new Point(169, 134));
		((Control)label35).set_Name("label35");
		((Control)label35).set_Size(new Size(77, 12));
		((Control)label35).set_TabIndex(43);
		((Control)label35).set_Text("当前已盈利：");
		((Control)label36).set_AutoSize(true);
		((Control)label36).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label36).set_Location(new Point(9, 134));
		((Control)label36).set_Name("label36");
		((Control)label36).set_Size(new Size(77, 12));
		((Control)label36).set_TabIndex(42);
		((Control)label36).set_Text("每日能盈利：");
		((Control)listView2).set_Anchor((AnchorStyles)13);
		listView2.set_CheckBoxes(true);
		listView2.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[9] { columnHeader74, columnHeader75, columnHeader76, columnHeader77, columnHeader78, columnHeader79, columnHeader80, columnHeader81, columnHeader82 });
		((Control)listView2).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView2).set_Cursor(Cursors.get_Default());
		((Control)listView2).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listView2.set_FullRowSelect(true);
		listView2.set_GridLines(true);
		((Control)listView2).set_Location(new Point(8, 158));
		listView2.set_MultiSelect(false);
		((Control)listView2).set_Name("listView2");
		((Control)listView2).set_Size(new Size(763, 196));
		((Control)listView2).set_TabIndex(41);
		listView2.set_UseCompatibleStateImageBehavior(false);
		listView2.set_View((View)1);
		columnHeader74.set_Text("当前停车处");
		columnHeader74.set_Width(97);
		columnHeader75.set_Text("昵称");
		columnHeader75.set_Width(121);
		columnHeader76.set_Text("车牌");
		columnHeader76.set_Width(47);
		columnHeader77.set_Text("颜色");
		columnHeader77.set_Width(52);
		columnHeader78.set_Text("车辆");
		columnHeader78.set_Width(105);
		columnHeader79.set_Text("价格");
		columnHeader79.set_Width(83);
		columnHeader80.set_Text("盈利");
		columnHeader81.set_Text("已停时间");
		columnHeader81.set_Width(103);
		columnHeader82.set_Text("预计收入");
		columnHeader82.set_Width(83);
		((Control)listView3).set_Anchor((AnchorStyles)13);
		listView3.set_CheckBoxes(true);
		listView3.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[8] { columnHeader83, columnHeader84, columnHeader85, columnHeader86, columnHeader87, columnHeader88, columnHeader89, columnHeader90 });
		((Control)listView3).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView3).set_Cursor(Cursors.get_Default());
		((Control)listView3).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listView3.set_FullRowSelect(true);
		listView3.set_GridLines(true);
		((Control)listView3).set_Location(new Point(8, 28));
		listView3.set_MultiSelect(false);
		((Control)listView3).set_Name("listView3");
		((Control)listView3).set_Size(new Size(763, 94));
		((Control)listView3).set_TabIndex(39);
		listView3.set_UseCompatibleStateImageBehavior(false);
		listView3.set_View((View)1);
		columnHeader83.set_Text("车主");
		columnHeader83.set_Width(100);
		columnHeader84.set_Text("昵称");
		columnHeader84.set_Width(118);
		columnHeader85.set_Text("车牌");
		columnHeader85.set_Width(52);
		columnHeader86.set_Text("车位号");
		columnHeader86.set_Width(73);
		columnHeader87.set_Text("车辆");
		columnHeader87.set_Width(120);
		columnHeader88.set_Text("盈利");
		columnHeader88.set_Width(56);
		columnHeader89.set_Text("已停时间");
		columnHeader89.set_Width(112);
		columnHeader90.set_Text("预计收入");
		columnHeader90.set_Width(120);
		((Control)tabPage2).get_Controls().Add((Control)(object)button19);
		((Control)tabPage2).get_Controls().Add((Control)(object)button20);
		((Control)tabPage2).get_Controls().Add((Control)(object)label37);
		((Control)tabPage2).get_Controls().Add((Control)(object)listView4);
		((Control)tabPage2).get_Controls().Add((Control)(object)comboBox2);
		((Control)tabPage2).get_Controls().Add((Control)(object)comboBox3);
		((Control)tabPage2).get_Controls().Add((Control)(object)listView5);
		tabPage2.set_Location(new Point(4, 21));
		((Control)tabPage2).set_Name("tabPage2");
		((Control)tabPage2).set_Size(new Size(774, 561));
		tabPage2.set_TabIndex(2);
		((Control)tabPage2).set_Text("车市");
		tabPage2.set_UseVisualStyleBackColor(true);
		((Control)label37).set_AutoSize(true);
		((Control)label37).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label37).set_Location(new Point(15, 214));
		((Control)label37).set_Name("label37");
		((Control)label37).set_Size(new Size(41, 12));
		((Control)label37).set_TabIndex(47);
		((Control)label37).set_Text("现金：");
		((Control)listView4).set_Anchor((AnchorStyles)7);
		listView4.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[4] { columnHeader91, columnHeader92, columnHeader93, columnHeader94 });
		((Control)listView4).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView4).set_Cursor(Cursors.get_Default());
		((Control)listView4).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listView4.set_FullRowSelect(true);
		listView4.set_GridLines(true);
		((Control)listView4).set_Location(new Point(6, 259));
		listView4.set_MultiSelect(false);
		((Control)listView4).set_Name("listView4");
		((Control)listView4).set_Size(new Size(345, 284));
		((Control)listView4).set_TabIndex(46);
		listView4.set_UseCompatibleStateImageBehavior(false);
		listView4.set_View((View)1);
		columnHeader91.set_Text("汽车");
		columnHeader91.set_Width(126);
		columnHeader92.set_Text("价格");
		columnHeader92.set_Width(76);
		columnHeader93.set_Text("盈利");
		columnHeader93.set_Width(51);
		columnHeader94.set_Text("代码");
		columnHeader94.set_Width(47);
		comboBox2.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox2).set_FormattingEnabled(true);
		((Control)comboBox2).set_Location(new Point(193, 233));
		((Control)comboBox2).set_Name("comboBox2");
		((Control)comboBox2).set_Size(new Size(158, 20));
		((Control)comboBox2).set_TabIndex(45);
		comboBox3.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox3).set_FormattingEnabled(true);
		((Control)comboBox3).set_Location(new Point(6, 233));
		((Control)comboBox3).set_Name("comboBox3");
		((Control)comboBox3).set_Size(new Size(158, 20));
		((Control)comboBox3).set_TabIndex(44);
		((Control)listView5).set_Anchor((AnchorStyles)13);
		listView5.set_CheckBoxes(true);
		listView5.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[9] { columnHeader95, columnHeader96, columnHeader97, columnHeader98, columnHeader99, columnHeader100, columnHeader101, columnHeader102, columnHeader103 });
		((Control)listView5).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView5).set_Cursor(Cursors.get_Default());
		((Control)listView5).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listView5.set_FullRowSelect(true);
		listView5.set_GridLines(true);
		((Control)listView5).set_Location(new Point(6, 6));
		listView5.set_MultiSelect(false);
		((Control)listView5).set_Name("listView5");
		((Control)listView5).set_Size(new Size(763, 196));
		((Control)listView5).set_TabIndex(43);
		listView5.set_UseCompatibleStateImageBehavior(false);
		listView5.set_View((View)1);
		columnHeader95.set_Text("当前停车处");
		columnHeader95.set_Width(97);
		columnHeader96.set_Text("昵称");
		columnHeader96.set_Width(121);
		columnHeader97.set_Text("车牌");
		columnHeader97.set_Width(47);
		columnHeader98.set_Text("颜色");
		columnHeader98.set_Width(52);
		columnHeader99.set_Text("车辆");
		columnHeader99.set_Width(119);
		columnHeader100.set_Text("价格");
		columnHeader100.set_Width(59);
		columnHeader101.set_Text("盈利");
		columnHeader102.set_Text("已停时间");
		columnHeader102.set_Width(103);
		columnHeader103.set_Text("预计收入");
		columnHeader103.set_Width(94);
		((Control)tabPage3).get_Controls().Add((Control)(object)label38);
		tabPage3.set_Location(new Point(4, 21));
		((Control)tabPage3).set_Name("tabPage3");
		((Control)tabPage3).set_Size(new Size(774, 561));
		tabPage3.set_TabIndex(4);
		((Control)tabPage3).set_Text("脚本停车");
		tabPage3.set_UseVisualStyleBackColor(true);
		((Control)label38).set_AutoSize(true);
		((Control)label38).set_Font(new Font("宋体", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label38).set_Location(new Point(253, 154));
		((Control)label38).set_Name("label38");
		((Control)label38).set_Size(new Size(158, 29));
		((Control)label38).set_TabIndex(0);
		((Control)label38).set_Text("尚在开发中");
		((Control)tabPage4).get_Controls().Add((Control)(object)checkBox5);
		((Control)tabPage4).get_Controls().Add((Control)(object)checkBox6);
		((Control)tabPage4).get_Controls().Add((Control)(object)checkBox7);
		((Control)tabPage4).get_Controls().Add((Control)(object)tabControl4);
		((Control)tabPage4).get_Controls().Add((Control)(object)button29);
		((Control)tabPage4).get_Controls().Add((Control)(object)label49);
		((Control)tabPage4).get_Controls().Add((Control)(object)textBox2);
		tabPage4.set_Location(new Point(4, 21));
		((Control)tabPage4).set_Name("tabPage4");
		((Control)tabPage4).set_Size(new Size(774, 561));
		tabPage4.set_TabIndex(3);
		((Control)tabPage4).set_Text("综合查询");
		tabPage4.set_UseVisualStyleBackColor(true);
		((Control)checkBox5).set_AutoSize(true);
		((Control)checkBox5).set_Location(new Point(648, 12));
		((Control)checkBox5).set_Name("checkBox5");
		((Control)checkBox5).set_Size(new Size(72, 16));
		((Control)checkBox5).set_TabIndex(7);
		((Control)checkBox5).set_Text("好友买卖");
		((ButtonBase)checkBox5).set_UseVisualStyleBackColor(true);
		((Control)checkBox6).set_AutoSize(true);
		((Control)checkBox6).set_Location(new Point(559, 12));
		((Control)checkBox6).set_Name("checkBox6");
		((Control)checkBox6).set_Size(new Size(60, 16));
		((Control)checkBox6).set_TabIndex(6);
		((Control)checkBox6).set_Text("抢车位");
		((ButtonBase)checkBox6).set_UseVisualStyleBackColor(true);
		((Control)checkBox7).set_AutoSize(true);
		((Control)checkBox7).set_Location(new Point(458, 12));
		((Control)checkBox7).set_Name("checkBox7");
		((Control)checkBox7).set_Size(new Size(72, 16));
		((Control)checkBox7).set_TabIndex(5);
		((Control)checkBox7).set_Text("个人信息");
		((ButtonBase)checkBox7).set_UseVisualStyleBackColor(true);
		((Control)tabControl4).set_Anchor((AnchorStyles)15);
		((Control)tabControl4).get_Controls().Add((Control)(object)tabPage5);
		((Control)tabControl4).get_Controls().Add((Control)(object)tabPage6);
		((Control)tabControl4).get_Controls().Add((Control)(object)tabPage7);
		((Control)tabControl4).set_Location(new Point(3, 34));
		((Control)tabControl4).set_Name("tabControl4");
		tabControl4.set_SelectedIndex(0);
		((Control)tabControl4).set_Size(new Size(775, 524));
		((Control)tabControl4).set_TabIndex(3);
		((Control)tabPage5).get_Controls().Add((Control)(object)label39);
		((Control)tabPage5).get_Controls().Add((Control)(object)listBox6);
		((Control)tabPage5).get_Controls().Add((Control)(object)label40);
		((Control)tabPage5).get_Controls().Add((Control)(object)listBox7);
		tabPage5.set_Location(new Point(4, 21));
		((Control)tabPage5).set_Name("tabPage5");
		((Control)tabPage5).set_Padding(new Padding(3));
		((Control)tabPage5).set_Size(new Size(767, 499));
		tabPage5.set_TabIndex(0);
		((Control)tabPage5).set_Text("个人信息");
		tabPage5.set_UseVisualStyleBackColor(true);
		((Control)label39).set_Anchor((AnchorStyles)13);
		((Control)label39).set_BackColor(SystemColors.InactiveCaptionText);
		((Control)label39).set_Font(new Font("宋体", 10.5f, (FontStyle)1, (GraphicsUnit)3, (byte)134));
		((Control)label39).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label39).set_Location(new Point(0, 244));
		((Control)label39).set_Name("label39");
		((Control)label39).set_Size(new Size(769, 19));
		((Control)label39).set_TabIndex(5);
		((Control)label39).set_Text("城市达人信息");
		((Control)listBox6).set_Anchor((AnchorStyles)15);
		((Control)listBox6).set_Font(new Font("宋体", 9f));
		((ListControl)listBox6).set_FormattingEnabled(true);
		listBox6.set_ItemHeight(12);
		((Control)listBox6).set_Location(new Point(2, 263));
		((Control)listBox6).set_Name("listBox6");
		((Control)listBox6).set_Size(new Size(771, 232));
		((Control)listBox6).set_TabIndex(4);
		((Control)label40).set_Anchor((AnchorStyles)13);
		((Control)label40).set_BackColor(SystemColors.InactiveCaptionText);
		((Control)label40).set_Font(new Font("宋体", 10.5f, (FontStyle)1, (GraphicsUnit)3, (byte)134));
		((Control)label40).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label40).set_Location(new Point(0, 2));
		((Control)label40).set_Name("label40");
		((Control)label40).set_Size(new Size(767, 19));
		((Control)label40).set_TabIndex(3);
		((Control)label40).set_Text("QQ空间个人信息");
		((Control)listBox7).set_Anchor((AnchorStyles)13);
		((Control)listBox7).set_Font(new Font("宋体", 9f));
		((ListControl)listBox7).set_FormattingEnabled(true);
		listBox7.set_ItemHeight(12);
		((Control)listBox7).set_Location(new Point(0, 21));
		((Control)listBox7).set_Name("listBox7");
		((Control)listBox7).set_Size(new Size(771, 220));
		((Control)listBox7).set_TabIndex(2);
		((Control)tabPage6).get_Controls().Add((Control)(object)button21);
		((Control)tabPage6).get_Controls().Add((Control)(object)button22);
		((Control)tabPage6).get_Controls().Add((Control)(object)button23);
		((Control)tabPage6).get_Controls().Add((Control)(object)button24);
		((Control)tabPage6).get_Controls().Add((Control)(object)button25);
		((Control)tabPage6).get_Controls().Add((Control)(object)button26);
		((Control)tabPage6).get_Controls().Add((Control)(object)button27);
		((Control)tabPage6).get_Controls().Add((Control)(object)button28);
		((Control)tabPage6).get_Controls().Add((Control)(object)label41);
		((Control)tabPage6).get_Controls().Add((Control)(object)label42);
		((Control)tabPage6).get_Controls().Add((Control)(object)label43);
		((Control)tabPage6).get_Controls().Add((Control)(object)label44);
		((Control)tabPage6).get_Controls().Add((Control)(object)label45);
		((Control)tabPage6).get_Controls().Add((Control)(object)label46);
		((Control)tabPage6).get_Controls().Add((Control)(object)listView6);
		((Control)tabPage6).get_Controls().Add((Control)(object)listView7);
		tabPage6.set_Location(new Point(4, 21));
		((Control)tabPage6).set_Name("tabPage6");
		((Control)tabPage6).set_Padding(new Padding(3));
		((Control)tabPage6).set_Size(new Size(767, 499));
		tabPage6.set_TabIndex(1);
		((Control)tabPage6).set_Text("抢车位");
		tabPage6.set_UseVisualStyleBackColor(true);
		((Control)label41).set_AutoSize(true);
		((Control)label41).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label41).set_Location(new Point(134, 12));
		((Control)label41).set_Name("label41");
		((Control)label41).set_Size(new Size(65, 12));
		((Control)label41).set_TabIndex(71);
		((Control)label41).set_Text("贴条收入：");
		((Control)label42).set_AutoSize(true);
		((Control)label42).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label42).set_Location(new Point(446, 12));
		((Control)label42).set_Name("label42");
		((Control)label42).set_Size(new Size(53, 12));
		((Control)label42).set_TabIndex(70);
		((Control)label42).set_Text("车辆数：");
		((Control)label43).set_AutoSize(true);
		((Control)label43).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label43).set_Location(new Point(273, 12));
		((Control)label43).set_Name("label43");
		((Control)label43).set_Size(new Size(65, 12));
		((Control)label43).set_TabIndex(69);
		((Control)label43).set_Text("开通日期：");
		((Control)label44).set_AutoSize(true);
		((Control)label44).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label44).set_Location(new Point(15, 12));
		((Control)label44).set_Name("label44");
		((Control)label44).set_Size(new Size(41, 12));
		((Control)label44).set_TabIndex(68);
		((Control)label44).set_Text("现金：");
		((Control)label45).set_AutoSize(true);
		((Control)label45).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label45).set_Location(new Point(213, 142));
		((Control)label45).set_Name("label45");
		((Control)label45).set_Size(new Size(77, 12));
		((Control)label45).set_TabIndex(67);
		((Control)label45).set_Text("当前已盈利：");
		((Control)label46).set_AutoSize(true);
		((Control)label46).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label46).set_Location(new Point(14, 142));
		((Control)label46).set_Name("label46");
		((Control)label46).set_Size(new Size(77, 12));
		((Control)label46).set_TabIndex(66);
		((Control)label46).set_Text("每日能盈利：");
		((Control)listView6).set_Anchor((AnchorStyles)15);
		listView6.set_CheckBoxes(true);
		listView6.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[9] { columnHeader104, columnHeader105, columnHeader106, columnHeader107, columnHeader108, columnHeader109, columnHeader110, columnHeader111, columnHeader112 });
		((Control)listView6).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView6).set_Cursor(Cursors.get_Default());
		((Control)listView6).set_Font(new Font("宋体", 9f));
		listView6.set_FullRowSelect(true);
		listView6.set_GridLines(true);
		((Control)listView6).set_Location(new Point(0, 163));
		listView6.set_MultiSelect(false);
		((Control)listView6).set_Name("listView6");
		((Control)listView6).set_Size(new Size(763, 200));
		((Control)listView6).set_TabIndex(43);
		listView6.set_UseCompatibleStateImageBehavior(false);
		listView6.set_View((View)1);
		columnHeader104.set_Text("当前停车处");
		columnHeader104.set_Width(97);
		columnHeader105.set_Text("昵称");
		columnHeader105.set_Width(112);
		columnHeader106.set_Text("车牌");
		columnHeader106.set_Width(47);
		columnHeader107.set_Text("颜色");
		columnHeader107.set_Width(52);
		columnHeader108.set_Text("车辆");
		columnHeader108.set_Width(119);
		columnHeader109.set_Text("价格");
		columnHeader109.set_Width(69);
		columnHeader110.set_Text("盈利");
		columnHeader110.set_Width(48);
		columnHeader111.set_Text("已停时间");
		columnHeader111.set_Width(127);
		columnHeader112.set_Text("预计收入");
		columnHeader112.set_Width(82);
		((Control)listView7).set_Anchor((AnchorStyles)13);
		listView7.set_CheckBoxes(true);
		listView7.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[8] { columnHeader113, columnHeader114, columnHeader115, columnHeader116, columnHeader117, columnHeader118, columnHeader119, columnHeader120 });
		((Control)listView7).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView7).set_Cursor(Cursors.get_Default());
		((Control)listView7).set_Font(new Font("宋体", 9f));
		listView7.set_FullRowSelect(true);
		listView7.set_GridLines(true);
		((Control)listView7).set_Location(new Point(1, 34));
		listView7.set_MultiSelect(false);
		((Control)listView7).set_Name("listView7");
		((Control)listView7).set_Size(new Size(763, 98));
		((Control)listView7).set_TabIndex(42);
		listView7.set_UseCompatibleStateImageBehavior(false);
		listView7.set_View((View)1);
		columnHeader113.set_Text("车主");
		columnHeader113.set_Width(100);
		columnHeader114.set_Text("昵称");
		columnHeader114.set_Width(113);
		columnHeader115.set_Text("车牌");
		columnHeader115.set_Width(52);
		columnHeader116.set_Text("车位号");
		columnHeader116.set_Width(73);
		columnHeader117.set_Text("车辆");
		columnHeader117.set_Width(117);
		columnHeader118.set_Text("盈利");
		columnHeader118.set_Width(56);
		columnHeader119.set_Text("已停时间");
		columnHeader119.set_Width(141);
		columnHeader120.set_Text("预计收入");
		columnHeader120.set_Width(98);
		((Control)tabPage7).get_Controls().Add((Control)(object)listView8);
		((Control)tabPage7).get_Controls().Add((Control)(object)label47);
		((Control)tabPage7).get_Controls().Add((Control)(object)pictureBox3);
		((Control)tabPage7).get_Controls().Add((Control)(object)listBox8);
		((Control)tabPage7).get_Controls().Add((Control)(object)label48);
		((Control)tabPage7).get_Controls().Add((Control)(object)pictureBox4);
		((Control)tabPage7).get_Controls().Add((Control)(object)listBox9);
		((Control)tabPage7).set_Font(new Font("宋体", 10.5f, (FontStyle)1, (GraphicsUnit)3, (byte)134));
		tabPage7.set_Location(new Point(4, 21));
		((Control)tabPage7).set_Name("tabPage7");
		((Control)tabPage7).set_Size(new Size(767, 499));
		tabPage7.set_TabIndex(2);
		((Control)tabPage7).set_Text("好友买卖");
		tabPage7.set_UseVisualStyleBackColor(true);
		((Control)listView8).set_Anchor((AnchorStyles)15);
		listView8.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[10] { columnHeader121, columnHeader122, columnHeader123, columnHeader124, columnHeader125, columnHeader126, columnHeader127, columnHeader128, columnHeader129, columnHeader130 });
		((Control)listView8).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView8).set_Cursor(Cursors.get_Default());
		((Control)listView8).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listView8.set_FullRowSelect(true);
		listView8.set_GridLines(true);
		((Control)listView8).set_Location(new Point(1, 262));
		listView8.set_MultiSelect(false);
		((Control)listView8).set_Name("listView8");
		((Control)listView8).set_Size(new Size(763, 234));
		((Control)listView8).set_TabIndex(47);
		listView8.set_UseCompatibleStateImageBehavior(false);
		listView8.set_View((View)1);
		columnHeader121.set_Text("QQ号码");
		columnHeader121.set_Width(92);
		columnHeader122.set_Text("昵称");
		columnHeader122.set_Width(83);
		columnHeader123.set_Text("绰号");
		columnHeader123.set_Width(79);
		columnHeader124.set_Text("身价");
		columnHeader124.set_Width(46);
		columnHeader125.set_Text("资产");
		columnHeader125.set_Width(59);
		columnHeader126.set_Text("现金");
		columnHeader126.set_Width(56);
		columnHeader127.set_Text("奴隶");
		columnHeader127.set_Width(48);
		columnHeader128.set_Text("买入次数");
		columnHeader128.set_Width(73);
		columnHeader129.set_Text("买入价格");
		columnHeader129.set_Width(78);
		columnHeader130.set_Text("买入时间");
		columnHeader130.set_Width(123);
		((Control)label47).set_BackColor(SystemColors.InactiveCaptionText);
		((Control)label47).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label47).set_Location(new Point(386, 12));
		((Control)label47).set_Name("label47");
		((Control)label47).set_Size(new Size(200, 19));
		((Control)label47).set_TabIndex(4);
		((Control)label47).set_Text("我的主人");
		((Control)pictureBox3).set_Location(new Point(592, 12));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(166, 246));
		pictureBox3.set_TabIndex(5);
		pictureBox3.set_TabStop(false);
		((Control)listBox8).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listBox8).set_Font(new Font("宋体", 9f));
		((ListControl)listBox8).set_FormattingEnabled(true);
		listBox8.set_ItemHeight(12);
		((Control)listBox8).set_Location(new Point(386, 31));
		((Control)listBox8).set_Name("listBox8");
		((Control)listBox8).set_Size(new Size(200, 220));
		((Control)listBox8).set_TabIndex(3);
		((Control)label48).set_BackColor(SystemColors.InactiveCaptionText);
		((Control)label48).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label48).set_Location(new Point(8, 12));
		((Control)label48).set_Name("label48");
		((Control)label48).set_Size(new Size(200, 19));
		((Control)label48).set_TabIndex(1);
		((Control)label48).set_Text("我自己");
		((Control)pictureBox4).set_Location(new Point(214, 12));
		((Control)pictureBox4).set_Name("pictureBox4");
		((Control)pictureBox4).set_Size(new Size(166, 246));
		pictureBox4.set_TabIndex(2);
		pictureBox4.set_TabStop(false);
		((Control)listBox9).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listBox9).set_Font(new Font("宋体", 9f));
		((ListControl)listBox9).set_FormattingEnabled(true);
		listBox9.set_ItemHeight(12);
		((Control)listBox9).set_Location(new Point(8, 31));
		((Control)listBox9).set_Name("listBox9");
		((Control)listBox9).set_Size(new Size(200, 220));
		((Control)listBox9).set_TabIndex(0);
		((Control)label49).set_AutoSize(true);
		((Control)label49).set_Location(new Point(13, 12));
		((Control)label49).set_Name("label49");
		((Control)label49).set_Size(new Size(125, 12));
		((Control)label49).set_TabIndex(1);
		((Control)label49).set_Text("输入需要查询的QQ号码");
		((Control)textBox2).set_Location(new Point(143, 6));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(184, 21));
		((Control)textBox2).set_TabIndex(0);
		((Control)tabPage8).set_BackColor(Color.Transparent);
		((Control)tabPage8).get_Controls().Add((Control)(object)label50);
		tabPage8.set_Location(new Point(4, 21));
		((Control)tabPage8).set_Name("tabPage8");
		((Control)tabPage8).set_Padding(new Padding(3));
		((Control)tabPage8).set_Size(new Size(774, 561));
		tabPage8.set_TabIndex(1);
		((Control)tabPage8).set_Text("好友买卖");
		tabPage8.set_UseVisualStyleBackColor(true);
		((Control)label50).set_AutoSize(true);
		((Control)label50).set_Font(new Font("宋体", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label50).set_Location(new Point(266, 154));
		((Control)label50).set_Name("label50");
		((Control)label50).set_Size(new Size(158, 29));
		((Control)label50).set_TabIndex(1);
		((Control)label50).set_Text("尚在开发中");
		((FileDialog)openFileDialog1).set_Filter("军刀QQ配文件|*.ini|Txt文件|*.txt|所有文件|*.*");
		((FileDialog)openFileDialog1).add_FileOk((CancelEventHandler)openFileDialog1_FileOk);
		((Control)checkBoxLoginPark).set_Anchor((AnchorStyles)6);
		((Control)checkBoxLoginPark).set_AutoSize(true);
		((Control)checkBoxLoginPark).set_BackColor(Color.Transparent);
		((Control)checkBoxLoginPark).set_ForeColor(Color.Blue);
		((Control)checkBoxLoginPark).set_Location(new Point(43, 39));
		((Control)checkBoxLoginPark).set_Name("checkBoxLoginPark");
		((Control)checkBoxLoginPark).set_Size(new Size(84, 16));
		((Control)checkBoxLoginPark).set_TabIndex(22);
		((Control)checkBoxLoginPark).set_Text("登录抢车位");
		((ButtonBase)checkBoxLoginPark).set_UseVisualStyleBackColor(false);
		checkBoxLoginPark.add_CheckedChanged((EventHandler)checkBoxLoginPark_CheckedChanged);
		((Control)checkBoxLoginFriend).set_Anchor((AnchorStyles)6);
		((Control)checkBoxLoginFriend).set_AutoSize(true);
		((Control)checkBoxLoginFriend).set_BackColor(Color.Transparent);
		((Control)checkBoxLoginFriend).set_ForeColor(Color.Blue);
		((Control)checkBoxLoginFriend).set_Location(new Point(43, 69));
		((Control)checkBoxLoginFriend).set_Name("checkBoxLoginFriend");
		((Control)checkBoxLoginFriend).set_Size(new Size(96, 16));
		((Control)checkBoxLoginFriend).set_TabIndex(23);
		((Control)checkBoxLoginFriend).set_Text("登录好友买卖");
		((ButtonBase)checkBoxLoginFriend).set_UseVisualStyleBackColor(false);
		checkBoxLoginFriend.add_CheckedChanged((EventHandler)checkBoxLoginFriend_CheckedChanged);
		((Control)tabPage14).get_Controls().Add((Control)(object)button3);
		((Control)tabPage14).get_Controls().Add((Control)(object)button4);
		((Control)tabPage14).get_Controls().Add((Control)(object)label69);
		((Control)tabPage14).get_Controls().Add((Control)(object)label70);
		((Control)tabPage14).get_Controls().Add((Control)(object)label71);
		((Control)tabPage14).get_Controls().Add((Control)(object)button5);
		((Control)tabPage14).get_Controls().Add((Control)(object)label72);
		((Control)tabPage14).get_Controls().Add((Control)(object)comboBox4);
		((Control)tabPage14).get_Controls().Add((Control)(object)label73);
		((Control)tabPage14).get_Controls().Add((Control)(object)checkBox8);
		((Control)tabPage14).get_Controls().Add((Control)(object)button6);
		((Control)tabPage14).get_Controls().Add((Control)(object)button7);
		((Control)tabPage14).get_Controls().Add((Control)(object)button39);
		((Control)tabPage14).get_Controls().Add((Control)(object)button40);
		((Control)tabPage14).get_Controls().Add((Control)(object)button41);
		((Control)tabPage14).get_Controls().Add((Control)(object)button42);
		((Control)tabPage14).get_Controls().Add((Control)(object)button43);
		((Control)tabPage14).get_Controls().Add((Control)(object)label74);
		((Control)tabPage14).get_Controls().Add((Control)(object)button44);
		((Control)tabPage14).get_Controls().Add((Control)(object)listView9);
		((Control)tabPage14).get_Controls().Add((Control)(object)label75);
		((Control)tabPage14).get_Controls().Add((Control)(object)label76);
		((Control)tabPage14).get_Controls().Add((Control)(object)label77);
		((Control)tabPage14).get_Controls().Add((Control)(object)button45);
		((Control)tabPage14).get_Controls().Add((Control)(object)listView10);
		((Control)tabPage14).get_Controls().Add((Control)(object)button46);
		((Control)tabPage14).get_Controls().Add((Control)(object)listView11);
		tabPage14.set_Location(new Point(4, 21));
		((Control)tabPage14).set_Name("tabPage14");
		((Control)tabPage14).set_Padding(new Padding(3));
		((Control)tabPage14).set_Size(new Size(763, 530));
		tabPage14.set_TabIndex(0);
		((Control)tabPage14).set_Text("我的抢车位");
		tabPage14.set_UseVisualStyleBackColor(true);
		((Control)label69).set_AutoSize(true);
		((Control)label69).set_ForeColor(Color.Red);
		((Control)label69).set_Location(new Point(337, 356));
		((Control)label69).set_Name("label69");
		((Control)label69).set_Size(new Size(149, 12));
		((Control)label69).set_TabIndex(94);
		((Control)label69).set_Text("单击列头可以按列进行排序");
		((Control)label70).set_AutoSize(true);
		((Control)label70).set_ForeColor(Color.Blue);
		((Control)label70).set_Location(new Point(121, 8));
		((Control)label70).set_Name("label70");
		((Control)label70).set_Size(new Size(65, 12));
		((Control)label70).set_TabIndex(93);
		((Control)label70).set_Text("贴条收入：");
		((Control)label71).set_AutoSize(true);
		((Control)label71).set_ForeColor(Color.Blue);
		((Control)label71).set_Location(new Point(433, 8));
		((Control)label71).set_Name("label71");
		((Control)label71).set_Size(new Size(53, 12));
		((Control)label71).set_TabIndex(92);
		((Control)label71).set_Text("车辆数：");
		((Control)label72).set_AutoSize(true);
		((Control)label72).set_ForeColor(Color.Blue);
		((Control)label72).set_Location(new Point(260, 8));
		((Control)label72).set_Name("label72");
		((Control)label72).set_Size(new Size(65, 12));
		((Control)label72).set_TabIndex(90);
		((Control)label72).set_Text("开通日期：");
		((Control)comboBox4).set_Anchor((AnchorStyles)9);
		((ListControl)comboBox4).set_FormattingEnabled(true);
		((Control)comboBox4).set_Location(new Point(368, 126));
		((Control)comboBox4).set_Name("comboBox4");
		((Control)comboBox4).set_Size(new Size(185, 20));
		((Control)comboBox4).set_TabIndex(89);
		((Control)label73).set_Anchor((AnchorStyles)9);
		((Control)label73).set_AutoSize(true);
		((Control)label73).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label73).set_ForeColor(Color.Blue);
		((Control)label73).set_Location(new Point(290, 132));
		((Control)label73).set_Name("label73");
		((Control)label73).set_Size(new Size(77, 12));
		((Control)label73).set_TabIndex(88);
		((Control)label73).set_Text("过渡停车场：");
		((Control)checkBox8).set_Anchor((AnchorStyles)9);
		((Control)checkBox8).set_AutoSize(true);
		((Control)checkBox8).set_Location(new Point(532, 6));
		((Control)checkBox8).set_Name("checkBox8");
		((Control)checkBox8).set_Size(new Size(96, 16));
		((Control)checkBox8).set_TabIndex(87);
		((Control)checkBox8).set_Text("被贴自动回停");
		((ButtonBase)checkBox8).set_UseVisualStyleBackColor(true);
		((Control)label74).set_AutoSize(true);
		((Control)label74).set_ForeColor(Color.Blue);
		((Control)label74).set_Location(new Point(1, 355));
		((Control)label74).set_Name("label74");
		((Control)label74).set_Size(new Size(137, 12));
		((Control)label74).set_TabIndex(79);
		((Control)label74).set_Text("你在好友圈内排行位数：");
		((Control)listView9).set_Anchor((AnchorStyles)15);
		listView9.set_CheckBoxes(true);
		listView9.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[7] { columnHeader168, columnHeader169, columnHeader170, columnHeader171, columnHeader172, columnHeader173, columnHeader174 });
		((Control)listView9).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView9).set_Cursor(Cursors.get_Default());
		((Control)listView9).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listView9.set_FullRowSelect(true);
		listView9.set_GridLines(true);
		((Control)listView9).set_Location(new Point(0, 376));
		listView9.set_MultiSelect(false);
		((Control)listView9).set_Name("listView9");
		((Control)listView9).set_Size(new Size(763, 159));
		((Control)listView9).set_TabIndex(78);
		listView9.set_UseCompatibleStateImageBehavior(false);
		listView9.set_View((View)1);
		columnHeader168.set_Text("QQ号码");
		columnHeader168.set_Width(100);
		columnHeader169.set_Text("昵称");
		columnHeader169.set_Width(111);
		columnHeader170.set_Text("现金");
		columnHeader170.set_Width(78);
		columnHeader171.set_Text("汽车总价");
		columnHeader171.set_Width(85);
		columnHeader172.set_Text("状态");
		columnHeader172.set_Width(112);
		columnHeader173.set_Text("空车位");
		columnHeader173.set_Width(94);
		columnHeader174.set_Text("最近登录时间");
		columnHeader174.set_Width(154);
		((Control)label75).set_AutoSize(true);
		((Control)label75).set_ForeColor(Color.Blue);
		((Control)label75).set_Location(new Point(2, 8));
		((Control)label75).set_Name("label75");
		((Control)label75).set_Size(new Size(41, 12));
		((Control)label75).set_TabIndex(76);
		((Control)label75).set_Text("现金：");
		((Control)label76).set_AutoSize(true);
		((Control)label76).set_ForeColor(Color.Blue);
		((Control)label76).set_Location(new Point(158, 132));
		((Control)label76).set_Name("label76");
		((Control)label76).set_Size(new Size(77, 12));
		((Control)label76).set_TabIndex(75);
		((Control)label76).set_Text("当前已盈利：");
		((Control)label77).set_AutoSize(true);
		((Control)label77).set_ForeColor(Color.Blue);
		((Control)label77).set_Location(new Point(1, 132));
		((Control)label77).set_Name("label77");
		((Control)label77).set_Size(new Size(77, 12));
		((Control)label77).set_TabIndex(74);
		((Control)label77).set_Text("每日能盈利：");
		((Control)listView10).set_Anchor((AnchorStyles)13);
		listView10.set_CheckBoxes(true);
		listView10.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[9] { columnHeader175, columnHeader176, columnHeader177, columnHeader178, columnHeader179, columnHeader180, columnHeader181, columnHeader182, columnHeader183 });
		((Control)listView10).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView10).set_Cursor(Cursors.get_Default());
		((Control)listView10).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listView10.set_FullRowSelect(true);
		listView10.set_GridLines(true);
		((Control)listView10).set_Location(new Point(0, 150));
		listView10.set_MultiSelect(false);
		((Control)listView10).set_Name("listView10");
		((Control)listView10).set_Size(new Size(763, 196));
		((Control)listView10).set_TabIndex(73);
		listView10.set_UseCompatibleStateImageBehavior(false);
		listView10.set_View((View)1);
		columnHeader175.set_Text("当前停车处");
		columnHeader175.set_Width(97);
		columnHeader176.set_Text("昵称");
		columnHeader176.set_Width(121);
		columnHeader177.set_Text("车牌");
		columnHeader177.set_Width(47);
		columnHeader178.set_Text("颜色");
		columnHeader178.set_Width(52);
		columnHeader179.set_Text("车辆");
		columnHeader179.set_Width(105);
		columnHeader180.set_Text("价格");
		columnHeader180.set_Width(83);
		columnHeader181.set_Text("盈利");
		columnHeader182.set_Text("已停时间");
		columnHeader182.set_Width(103);
		columnHeader183.set_Text("预计收入");
		columnHeader183.set_Width(83);
		((Control)listView11).set_Anchor((AnchorStyles)13);
		listView11.set_CheckBoxes(true);
		listView11.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[8] { columnHeader184, columnHeader185, columnHeader186, columnHeader187, columnHeader188, columnHeader189, columnHeader190, columnHeader191 });
		((Control)listView11).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView11).set_Cursor(Cursors.get_Default());
		((Control)listView11).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listView11.set_FullRowSelect(true);
		listView11.set_GridLines(true);
		((Control)listView11).set_Location(new Point(0, 28));
		listView11.set_MultiSelect(false);
		((Control)listView11).set_Name("listView11");
		((Control)listView11).set_Size(new Size(763, 94));
		((Control)listView11).set_TabIndex(71);
		listView11.set_UseCompatibleStateImageBehavior(false);
		listView11.set_View((View)1);
		columnHeader184.set_Text("车主");
		columnHeader184.set_Width(100);
		columnHeader185.set_Text("昵称");
		columnHeader185.set_Width(115);
		columnHeader186.set_Text("车牌");
		columnHeader186.set_Width(52);
		columnHeader187.set_Text("车位号");
		columnHeader187.set_Width(73);
		columnHeader188.set_Text("车辆");
		columnHeader188.set_Width(104);
		columnHeader189.set_Text("盈利");
		columnHeader189.set_Width(78);
		columnHeader190.set_Text("已停时间");
		columnHeader190.set_Width(112);
		columnHeader191.set_Text("预计收入");
		columnHeader191.set_Width(120);
		((Control)tabPage15).get_Controls().Add((Control)(object)label78);
		((Control)tabPage15).get_Controls().Add((Control)(object)label79);
		((Control)tabPage15).get_Controls().Add((Control)(object)button47);
		((Control)tabPage15).get_Controls().Add((Control)(object)button48);
		((Control)tabPage15).get_Controls().Add((Control)(object)button49);
		((Control)tabPage15).get_Controls().Add((Control)(object)button50);
		((Control)tabPage15).get_Controls().Add((Control)(object)button51);
		((Control)tabPage15).get_Controls().Add((Control)(object)button52);
		((Control)tabPage15).get_Controls().Add((Control)(object)button53);
		((Control)tabPage15).get_Controls().Add((Control)(object)button54);
		((Control)tabPage15).get_Controls().Add((Control)(object)label80);
		((Control)tabPage15).get_Controls().Add((Control)(object)label81);
		((Control)tabPage15).get_Controls().Add((Control)(object)label82);
		((Control)tabPage15).get_Controls().Add((Control)(object)label83);
		((Control)tabPage15).get_Controls().Add((Control)(object)label84);
		((Control)tabPage15).get_Controls().Add((Control)(object)label85);
		((Control)tabPage15).get_Controls().Add((Control)(object)listView12);
		((Control)tabPage15).get_Controls().Add((Control)(object)listView13);
		((Control)tabPage15).get_Controls().Add((Control)(object)button55);
		((Control)tabPage15).get_Controls().Add((Control)(object)label86);
		((Control)tabPage15).get_Controls().Add((Control)(object)textBox4);
		tabPage15.set_Location(new Point(4, 21));
		((Control)tabPage15).set_Name("tabPage15");
		((Control)tabPage15).set_Padding(new Padding(3));
		((Control)tabPage15).set_Size(new Size(763, 530));
		tabPage15.set_TabIndex(1);
		((Control)tabPage15).set_Text("举报");
		tabPage15.set_UseVisualStyleBackColor(true);
		((Control)label78).set_Anchor((AnchorStyles)6);
		((Control)label78).set_ForeColor(Color.Red);
		((Control)label78).set_Location(new Point(181, 424));
		((Control)label78).set_Name("label78");
		((Control)label78).set_Size(new Size(401, 29));
		((Control)label78).set_TabIndex(118);
		((Control)label78).set_Text("举报技巧：举报他的时候，举报界面不需要切换，只要需要在已经登陆的QQ列表中进行切换，切换后，即可对当前被举报号继续进行举报");
		((Control)label79).set_Anchor((AnchorStyles)6);
		((Control)label79).set_ForeColor(Color.Red);
		((Control)label79).set_Location(new Point(181, 474));
		((Control)label79).set_Name("label79");
		((Control)label79).set_Size(new Size(401, 45));
		((Control)label79).set_TabIndex(117);
		((Control)label79).set_Text("三人举报成功，警察叔叔就会贴条哦。但由于近期举报繁忙，您的举报可能会被警察叔叔遗漏。经测试被四个好友共举报4次成功率比较大。每个号码每天可以成功举报的次数大概在5到10之间");
		((Control)label80).set_AutoSize(true);
		((Control)label80).set_ForeColor(Color.Blue);
		((Control)label80).set_Location(new Point(128, 50));
		((Control)label80).set_Name("label80");
		((Control)label80).set_Size(new Size(65, 12));
		((Control)label80).set_TabIndex(108);
		((Control)label80).set_Text("贴条收入：");
		((Control)label81).set_AutoSize(true);
		((Control)label81).set_ForeColor(Color.Blue);
		((Control)label81).set_Location(new Point(440, 50));
		((Control)label81).set_Name("label81");
		((Control)label81).set_Size(new Size(53, 12));
		((Control)label81).set_TabIndex(107);
		((Control)label81).set_Text("车辆数：");
		((Control)label82).set_AutoSize(true);
		((Control)label82).set_ForeColor(Color.Blue);
		((Control)label82).set_Location(new Point(267, 50));
		((Control)label82).set_Name("label82");
		((Control)label82).set_Size(new Size(65, 12));
		((Control)label82).set_TabIndex(106);
		((Control)label82).set_Text("开通日期：");
		((Control)label83).set_AutoSize(true);
		((Control)label83).set_ForeColor(Color.Blue);
		((Control)label83).set_Location(new Point(9, 50));
		((Control)label83).set_Name("label83");
		((Control)label83).set_Size(new Size(41, 12));
		((Control)label83).set_TabIndex(105);
		((Control)label83).set_Text("现金：");
		((Control)label84).set_AutoSize(true);
		((Control)label84).set_ForeColor(Color.Blue);
		((Control)label84).set_Location(new Point(207, 180));
		((Control)label84).set_Name("label84");
		((Control)label84).set_Size(new Size(77, 12));
		((Control)label84).set_TabIndex(104);
		((Control)label84).set_Text("当前已盈利：");
		((Control)label85).set_AutoSize(true);
		((Control)label85).set_ForeColor(Color.Blue);
		((Control)label85).set_Location(new Point(8, 180));
		((Control)label85).set_Name("label85");
		((Control)label85).set_Size(new Size(77, 12));
		((Control)label85).set_TabIndex(103);
		((Control)label85).set_Text("每日能盈利：");
		((Control)listView12).set_Anchor((AnchorStyles)15);
		listView12.set_CheckBoxes(true);
		listView12.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[9] { columnHeader192, columnHeader193, columnHeader194, columnHeader195, columnHeader196, columnHeader197, columnHeader198, columnHeader199, columnHeader200 });
		((Control)listView12).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView12).set_Cursor(Cursors.get_Default());
		((Control)listView12).set_Font(new Font("宋体", 9f));
		listView12.set_FullRowSelect(true);
		listView12.set_GridLines(true);
		((Control)listView12).set_Location(new Point(-4, 201));
		listView12.set_MultiSelect(false);
		((Control)listView12).set_Name("listView12");
		((Control)listView12).set_Size(new Size(772, 200));
		((Control)listView12).set_TabIndex(102);
		listView12.set_UseCompatibleStateImageBehavior(false);
		listView12.set_View((View)1);
		columnHeader192.set_Text("当前停车处");
		columnHeader192.set_Width(97);
		columnHeader193.set_Text("昵称");
		columnHeader193.set_Width(112);
		columnHeader194.set_Text("车牌");
		columnHeader194.set_Width(47);
		columnHeader195.set_Text("颜色");
		columnHeader195.set_Width(52);
		columnHeader196.set_Text("车辆");
		columnHeader196.set_Width(119);
		columnHeader197.set_Text("价格");
		columnHeader197.set_Width(69);
		columnHeader198.set_Text("盈利");
		columnHeader198.set_Width(48);
		columnHeader199.set_Text("已停时间");
		columnHeader199.set_Width(127);
		columnHeader200.set_Text("预计收入");
		columnHeader200.set_Width(82);
		((Control)listView13).set_Anchor((AnchorStyles)13);
		listView13.set_CheckBoxes(true);
		listView13.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[8] { columnHeader201, columnHeader202, columnHeader203, columnHeader204, columnHeader205, columnHeader206, columnHeader207, columnHeader208 });
		((Control)listView13).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView13).set_Cursor(Cursors.get_Default());
		((Control)listView13).set_Font(new Font("宋体", 9f));
		listView13.set_FullRowSelect(true);
		listView13.set_GridLines(true);
		((Control)listView13).set_Location(new Point(-4, 72));
		listView13.set_MultiSelect(false);
		((Control)listView13).set_Name("listView13");
		((Control)listView13).set_Size(new Size(769, 98));
		((Control)listView13).set_TabIndex(101);
		listView13.set_UseCompatibleStateImageBehavior(false);
		listView13.set_View((View)1);
		columnHeader201.set_Text("车主");
		columnHeader201.set_Width(100);
		columnHeader202.set_Text("昵称");
		columnHeader202.set_Width(113);
		columnHeader203.set_Text("车牌");
		columnHeader203.set_Width(52);
		columnHeader204.set_Text("车位号");
		columnHeader204.set_Width(73);
		columnHeader205.set_Text("车辆");
		columnHeader205.set_Width(117);
		columnHeader206.set_Text("盈利");
		columnHeader206.set_Width(56);
		columnHeader207.set_Text("已停时间");
		columnHeader207.set_Width(141);
		columnHeader208.set_Text("预计收入");
		columnHeader208.set_Width(98);
		((Control)label86).set_AutoSize(true);
		((Control)label86).set_Location(new Point(7, 15));
		((Control)label86).set_Name("label86");
		((Control)label86).set_Size(new Size(125, 12));
		((Control)label86).set_TabIndex(99);
		((Control)label86).set_Text("输入需要举报的QQ号码");
		((Control)textBox4).set_Location(new Point(137, 9));
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(184, 21));
		((Control)textBox4).set_TabIndex(98);
		((Control)tabPage16).get_Controls().Add((Control)(object)label87);
		((Control)tabPage16).get_Controls().Add((Control)(object)label88);
		((Control)tabPage16).get_Controls().Add((Control)(object)checkBox10);
		((Control)tabPage16).get_Controls().Add((Control)(object)button56);
		((Control)tabPage16).get_Controls().Add((Control)(object)button57);
		((Control)tabPage16).get_Controls().Add((Control)(object)label89);
		((Control)tabPage16).get_Controls().Add((Control)(object)listView14);
		((Control)tabPage16).get_Controls().Add((Control)(object)comboBox5);
		((Control)tabPage16).get_Controls().Add((Control)(object)comboBox6);
		((Control)tabPage16).get_Controls().Add((Control)(object)listView15);
		tabPage16.set_Location(new Point(4, 21));
		((Control)tabPage16).set_Name("tabPage16");
		((Control)tabPage16).set_Size(new Size(763, 530));
		tabPage16.set_TabIndex(2);
		((Control)tabPage16).set_Text("车市");
		tabPage16.set_UseVisualStyleBackColor(true);
		((Control)label87).set_AutoSize(true);
		((Control)label87).set_ForeColor(Color.Blue);
		((Control)label87).set_Location(new Point(269, 211));
		((Control)label87).set_Name("label87");
		((Control)label87).set_Size(new Size(65, 12));
		((Control)label87).set_TabIndex(99);
		((Control)label87).set_Text("贴条收入：");
		((Control)label88).set_AutoSize(true);
		((Control)label88).set_ForeColor(Color.Blue);
		((Control)label88).set_Location(new Point(111, 211));
		((Control)label88).set_Name("label88");
		((Control)label88).set_Size(new Size(77, 12));
		((Control)label88).set_TabIndex(98);
		((Control)label88).set_Text("当前已盈利：");
		((Control)checkBox10).set_AutoSize(true);
		((Control)checkBox10).set_ForeColor(Color.Red);
		((Control)checkBox10).set_Location(new Point(387, 207));
		((Control)checkBox10).set_Name("checkBox10");
		((Control)checkBox10).set_Size(new Size(246, 16));
		((Control)checkBox10).set_TabIndex(97);
		((Control)checkBox10).set_Text("贴条收入加入统计,并包含将来的贴条收入");
		((ButtonBase)checkBox10).set_UseVisualStyleBackColor(true);
		((Control)label89).set_AutoSize(true);
		((Control)label89).set_ForeColor(Color.Blue);
		((Control)label89).set_Location(new Point(9, 212));
		((Control)label89).set_Name("label89");
		((Control)label89).set_Size(new Size(41, 12));
		((Control)label89).set_TabIndex(94);
		((Control)label89).set_Text("现金：");
		((Control)listView14).set_Anchor((AnchorStyles)7);
		listView14.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[6] { columnHeader209, columnHeader210, columnHeader211, columnHeader212, columnHeader213, columnHeader214 });
		((Control)listView14).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView14).set_Cursor(Cursors.get_Default());
		((Control)listView14).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listView14.set_FullRowSelect(true);
		listView14.set_GridLines(true);
		((Control)listView14).set_Location(new Point(1, 260));
		listView14.set_MultiSelect(false);
		((Control)listView14).set_Name("listView14");
		((Control)listView14).set_Size(new Size(750, 267));
		((Control)listView14).set_TabIndex(93);
		listView14.set_UseCompatibleStateImageBehavior(false);
		listView14.set_View((View)1);
		columnHeader209.set_Text("汽车");
		columnHeader209.set_Width(126);
		columnHeader210.set_Text("价格");
		columnHeader210.set_Width(76);
		columnHeader211.set_Text("盈利");
		columnHeader211.set_Width(51);
		columnHeader212.set_Text("代码");
		columnHeader212.set_Width(47);
		columnHeader213.set_Text("预计换购时间");
		columnHeader213.set_Width(193);
		columnHeader214.set_Text("支持的颜色");
		columnHeader214.set_Width(236);
		comboBox5.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox5).set_FormattingEnabled(true);
		((Control)comboBox5).set_Location(new Point(189, 231));
		((Control)comboBox5).set_Name("comboBox5");
		((Control)comboBox5).set_Size(new Size(156, 20));
		((Control)comboBox5).set_TabIndex(92);
		comboBox6.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox6).set_FormattingEnabled(true);
		((Control)comboBox6).set_Location(new Point(1, 231));
		((Control)comboBox6).set_Name("comboBox6");
		((Control)comboBox6).set_Size(new Size(171, 20));
		((Control)comboBox6).set_TabIndex(91);
		((Control)listView15).set_Anchor((AnchorStyles)13);
		listView15.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[9] { columnHeader215, columnHeader216, columnHeader217, columnHeader218, columnHeader219, columnHeader220, columnHeader221, columnHeader222, columnHeader223 });
		((Control)listView15).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView15).set_Cursor(Cursors.get_Default());
		((Control)listView15).set_Font(new Font("宋体", 10f));
		listView15.set_FullRowSelect(true);
		listView15.set_GridLines(true);
		((Control)listView15).set_Location(new Point(0, 4));
		listView15.set_MultiSelect(false);
		((Control)listView15).set_Name("listView15");
		((Control)listView15).set_Size(new Size(763, 198));
		((Control)listView15).set_TabIndex(90);
		listView15.set_UseCompatibleStateImageBehavior(false);
		listView15.set_View((View)1);
		columnHeader215.set_Text("当前停车处");
		columnHeader215.set_Width(97);
		columnHeader216.set_Text("昵称");
		columnHeader216.set_Width(116);
		columnHeader217.set_Text("车牌");
		columnHeader217.set_Width(47);
		columnHeader218.set_Text("颜色");
		columnHeader218.set_Width(52);
		columnHeader219.set_Text("车辆");
		columnHeader219.set_Width(101);
		columnHeader220.set_Text("价格");
		columnHeader220.set_Width(81);
		columnHeader221.set_Text("盈利");
		columnHeader222.set_Text("已停时间");
		columnHeader222.set_Width(120);
		columnHeader223.set_Text("预计收入");
		columnHeader223.set_Width(78);
		((Control)tabPage17).get_Controls().Add((Control)(object)label90);
		tabPage17.set_Location(new Point(4, 21));
		((Control)tabPage17).set_Name("tabPage17");
		((Control)tabPage17).set_Size(new Size(763, 530));
		tabPage17.set_TabIndex(3);
		((Control)tabPage17).set_Text("脚本停车");
		tabPage17.set_UseVisualStyleBackColor(true);
		((Control)label90).set_AutoSize(true);
		((Control)label90).set_Font(new Font("宋体", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label90).set_ForeColor(Color.Blue);
		((Control)label90).set_Location(new Point(339, 256));
		((Control)label90).set_Name("label90");
		((Control)label90).set_Size(new Size(104, 19));
		((Control)label90).set_TabIndex(1);
		((Control)label90).set_Text("尚在开发中");
		((Control)tabPage18).get_Controls().Add((Control)(object)textBox5);
		((Control)tabPage18).get_Controls().Add((Control)(object)button58);
		tabPage18.set_Location(new Point(4, 21));
		((Control)tabPage18).set_Name("tabPage18");
		((Control)tabPage18).set_Size(new Size(763, 530));
		tabPage18.set_TabIndex(4);
		((Control)tabPage18).set_Text("我的车子近况");
		tabPage18.set_UseVisualStyleBackColor(true);
		((Control)textBox5).set_Anchor((AnchorStyles)15);
		((Control)textBox5).set_BackColor(SystemColors.Info);
		((Control)textBox5).set_Location(new Point(0, 50));
		((TextBoxBase)textBox5).set_Multiline(true);
		((Control)textBox5).set_Name("textBox5");
		((TextBoxBase)textBox5).set_ReadOnly(true);
		textBox5.set_ScrollBars((ScrollBars)2);
		((Control)textBox5).set_Size(new Size(761, 480));
		((Control)textBox5).set_TabIndex(72);
		((Control)tabPage19).get_Controls().Add((Control)(object)textBox6);
		((Control)tabPage19).get_Controls().Add((Control)(object)button59);
		tabPage19.set_Location(new Point(4, 21));
		((Control)tabPage19).set_Name("tabPage19");
		((Control)tabPage19).set_Size(new Size(763, 530));
		tabPage19.set_TabIndex(5);
		((Control)tabPage19).set_Text("我的车位近况");
		tabPage19.set_UseVisualStyleBackColor(true);
		((Control)textBox6).set_Anchor((AnchorStyles)15);
		((Control)textBox6).set_BackColor(SystemColors.Info);
		((Control)textBox6).set_Location(new Point(0, 50));
		((TextBoxBase)textBox6).set_Multiline(true);
		((Control)textBox6).set_Name("textBox6");
		((TextBoxBase)textBox6).set_ReadOnly(true);
		textBox6.set_ScrollBars((ScrollBars)2);
		((Control)textBox6).set_Size(new Size(761, 480));
		((Control)textBox6).set_TabIndex(73);
		((Control)tabControl6).set_Anchor((AnchorStyles)7);
		((Control)tabControl6).get_Controls().Add((Control)(object)tabPageLogin);
		((Control)tabControl6).get_Controls().Add((Control)(object)tabPageHaveLogin);
		((Control)tabControl6).set_Location(new Point(0, 70));
		((Control)tabControl6).set_Name("tabControl6");
		tabControl6.set_SelectedIndex(0);
		((Control)tabControl6).set_Size(new Size(204, 578));
		((Control)tabControl6).set_TabIndex(24);
		((Control)tabPageLogin).get_Controls().Add((Control)(object)button_34);
		((Control)tabPageLogin).get_Controls().Add((Control)(object)groupBox1);
		((Control)tabPageLogin).get_Controls().Add((Control)(object)buttonTxt);
		((Control)tabPageLogin).get_Controls().Add((Control)(object)textQQPass);
		((Control)tabPageLogin).get_Controls().Add((Control)(object)buttonDaoRuJunDao);
		((Control)tabPageLogin).get_Controls().Add((Control)(object)label1);
		((Control)tabPageLogin).get_Controls().Add((Control)(object)buttonLogin);
		((Control)tabPageLogin).get_Controls().Add((Control)(object)label2);
		((Control)tabPageLogin).get_Controls().Add((Control)(object)pictureBoxValidate);
		((Control)tabPageLogin).get_Controls().Add((Control)(object)comboQQNum);
		((Control)tabPageLogin).get_Controls().Add((Control)(object)label3);
		((Control)tabPageLogin).get_Controls().Add((Control)(object)buttonDelete);
		((Control)tabPageLogin).get_Controls().Add((Control)(object)textValidate);
		((Control)tabPageLogin).get_Controls().Add((Control)(object)checkMark);
		tabPageLogin.set_Location(new Point(4, 21));
		((Control)tabPageLogin).set_Name("tabPageLogin");
		((Control)tabPageLogin).set_Padding(new Padding(3));
		((Control)tabPageLogin).set_Size(new Size(196, 553));
		tabPageLogin.set_TabIndex(0);
		((Control)tabPageLogin).set_Text("登陆");
		tabPageLogin.set_UseVisualStyleBackColor(true);
		((Control)groupBox1).set_Anchor((AnchorStyles)7);
		((Control)groupBox1).get_Controls().Add((Control)(object)label95);
		((Control)groupBox1).get_Controls().Add((Control)(object)checkBox_1);
		((Control)groupBox1).get_Controls().Add((Control)(object)label140);
		((Control)groupBox1).get_Controls().Add((Control)(object)checkBoxLoginPark);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox20);
		((Control)groupBox1).get_Controls().Add((Control)(object)checkBoxLoginFriend);
		((Control)groupBox1).set_ForeColor(Color.Blue);
		((Control)groupBox1).set_Location(new Point(5, 345));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(185, 205));
		((Control)groupBox1).set_TabIndex(24);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("选择需要登陆的模块");
		((Control)checkBox_1).set_Anchor((AnchorStyles)6);
		((Control)checkBox_1).set_AutoSize(true);
		((Control)checkBox_1).set_BackColor(Color.Transparent);
		((Control)checkBox_1).set_ForeColor(Color.Red);
		((Control)checkBox_1).set_Location(new Point(43, 100));
		((Control)checkBox_1).set_Name("checkBox登录账号中心");
		((Control)checkBox_1).set_Size(new Size(108, 16));
		((Control)checkBox_1).set_TabIndex(24);
		((Control)checkBox_1).set_Text("登录大小号中心");
		((ButtonBase)checkBox_1).set_UseVisualStyleBackColor(false);
		checkBox_1.add_CheckedChanged((EventHandler)checkBox_1_CheckedChanged);
		((Control)tabPageHaveLogin).get_Controls().Add((Control)(object)button81);
		((Control)tabPageHaveLogin).get_Controls().Add((Control)(object)label119);
		((Control)tabPageHaveLogin).get_Controls().Add((Control)(object)label118);
		((Control)tabPageHaveLogin).get_Controls().Add((Control)(object)listUser);
		tabPageHaveLogin.set_Location(new Point(4, 21));
		((Control)tabPageHaveLogin).set_Name("tabPageHaveLogin");
		((Control)tabPageHaveLogin).set_Padding(new Padding(3));
		((Control)tabPageHaveLogin).set_Size(new Size(196, 553));
		tabPageHaveLogin.set_TabIndex(1);
		((Control)tabPageHaveLogin).set_Text("已经登陆");
		tabPageHaveLogin.set_UseVisualStyleBackColor(true);
		((Control)label119).set_AutoSize(true);
		((Control)label119).set_ForeColor(Color.Red);
		((Control)label119).set_Location(new Point(21, 36));
		((Control)label119).set_Name("label119");
		((Control)label119).set_Size(new Size(53, 12));
		((Control)label119).set_TabIndex(78);
		((Control)label119).set_Text("经验值：");
		((Control)label118).set_AutoSize(true);
		((Control)label118).set_ForeColor(Color.Red);
		((Control)label118).set_Location(new Point(21, 13));
		((Control)label118).set_Name("label118");
		((Control)label118).set_Size(new Size(41, 12));
		((Control)label118).set_TabIndex(77);
		((Control)label118).set_Text("等级：");
		((Control)checkBox31).set_AutoSize(true);
		((Control)checkBox31).set_ForeColor(Color.Blue);
		((Control)checkBox31).set_Location(new Point(282, 440));
		((Control)checkBox31).set_Name("checkBox31");
		((Control)checkBox31).set_Size(new Size(48, 16));
		((Control)checkBox31).set_TabIndex(136);
		((Control)checkBox31).set_Text("换车");
		((ButtonBase)checkBox31).set_UseVisualStyleBackColor(true);
		((Control)checkBox32).set_AutoSize(true);
		((Control)checkBox32).set_ForeColor(Color.Blue);
		((Control)checkBox32).set_Location(new Point(222, 441));
		((Control)checkBox32).set_Name("checkBox32");
		((Control)checkBox32).set_Size(new Size(54, 16));
		((Control)checkBox32).set_TabIndex(135);
		((Control)checkBox32).set_Text("1号车");
		((ButtonBase)checkBox32).set_UseVisualStyleBackColor(true);
		comboBox25.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox25).set_FormattingEnabled(true);
		((Control)comboBox25).set_Location(new Point(523, 437));
		((Control)comboBox25).set_Name("comboBox25");
		((Control)comboBox25).set_Size(new Size(156, 20));
		((Control)comboBox25).set_TabIndex(138);
		comboBox26.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox26).set_FormattingEnabled(true);
		((Control)comboBox26).set_Location(new Point(336, 437));
		((Control)comboBox26).set_Name("comboBox26");
		((Control)comboBox26).set_Size(new Size(171, 20));
		((Control)comboBox26).set_TabIndex(137);
		comboBox27.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox27).set_FormattingEnabled(true);
		((Control)comboBox27).set_Location(new Point(523, 411));
		((Control)comboBox27).set_Name("comboBox27");
		((Control)comboBox27).set_Size(new Size(156, 20));
		((Control)comboBox27).set_TabIndex(134);
		comboBox28.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox28).set_FormattingEnabled(true);
		((Control)comboBox28).set_Location(new Point(336, 411));
		((Control)comboBox28).set_Name("comboBox28");
		((Control)comboBox28).set_Size(new Size(171, 20));
		((Control)comboBox28).set_TabIndex(133);
		((Control)checkBox33).set_AutoSize(true);
		((Control)checkBox33).set_ForeColor(Color.Blue);
		((Control)checkBox33).set_Location(new Point(282, 414));
		((Control)checkBox33).set_Name("checkBox33");
		((Control)checkBox33).set_Size(new Size(48, 16));
		((Control)checkBox33).set_TabIndex(132);
		((Control)checkBox33).set_Text("换车");
		((ButtonBase)checkBox33).set_UseVisualStyleBackColor(true);
		((Control)checkBox34).set_AutoSize(true);
		((Control)checkBox34).set_ForeColor(Color.Blue);
		((Control)checkBox34).set_Location(new Point(222, 415));
		((Control)checkBox34).set_Name("checkBox34");
		((Control)checkBox34).set_Size(new Size(54, 16));
		((Control)checkBox34).set_TabIndex(131);
		((Control)checkBox34).set_Text("1号车");
		((ButtonBase)checkBox34).set_UseVisualStyleBackColor(true);
		comboBox29.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox29).set_FormattingEnabled(true);
		((Control)comboBox29).set_Location(new Point(523, 383));
		((Control)comboBox29).set_Name("comboBox29");
		((Control)comboBox29).set_Size(new Size(156, 20));
		((Control)comboBox29).set_TabIndex(130);
		comboBox30.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox30).set_FormattingEnabled(true);
		((Control)comboBox30).set_Location(new Point(336, 383));
		((Control)comboBox30).set_Name("comboBox30");
		((Control)comboBox30).set_Size(new Size(171, 20));
		((Control)comboBox30).set_TabIndex(129);
		((Control)checkBox35).set_AutoSize(true);
		((Control)checkBox35).set_ForeColor(Color.Blue);
		((Control)checkBox35).set_Location(new Point(282, 386));
		((Control)checkBox35).set_Name("checkBox35");
		((Control)checkBox35).set_Size(new Size(48, 16));
		((Control)checkBox35).set_TabIndex(128);
		((Control)checkBox35).set_Text("换车");
		((ButtonBase)checkBox35).set_UseVisualStyleBackColor(true);
		((Control)checkBox36).set_AutoSize(true);
		((Control)checkBox36).set_ForeColor(Color.Blue);
		((Control)checkBox36).set_Location(new Point(222, 387));
		((Control)checkBox36).set_Name("checkBox36");
		((Control)checkBox36).set_Size(new Size(54, 16));
		((Control)checkBox36).set_TabIndex(127);
		((Control)checkBox36).set_Text("1号车");
		((ButtonBase)checkBox36).set_UseVisualStyleBackColor(true);
		comboBox31.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox31).set_FormattingEnabled(true);
		((Control)comboBox31).set_Location(new Point(523, 357));
		((Control)comboBox31).set_Name("comboBox31");
		((Control)comboBox31).set_Size(new Size(156, 20));
		((Control)comboBox31).set_TabIndex(126);
		comboBox32.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox32).set_FormattingEnabled(true);
		((Control)comboBox32).set_Location(new Point(336, 357));
		((Control)comboBox32).set_Name("comboBox32");
		((Control)comboBox32).set_Size(new Size(171, 20));
		((Control)comboBox32).set_TabIndex(125);
		((Control)checkBox37).set_AutoSize(true);
		((Control)checkBox37).set_ForeColor(Color.Blue);
		((Control)checkBox37).set_Location(new Point(282, 360));
		((Control)checkBox37).set_Name("checkBox37");
		((Control)checkBox37).set_Size(new Size(48, 16));
		((Control)checkBox37).set_TabIndex(124);
		((Control)checkBox37).set_Text("换车");
		((ButtonBase)checkBox37).set_UseVisualStyleBackColor(true);
		((Control)checkBox38).set_AutoSize(true);
		((Control)checkBox38).set_ForeColor(Color.Blue);
		((Control)checkBox38).set_Location(new Point(222, 361));
		((Control)checkBox38).set_Name("checkBox38");
		((Control)checkBox38).set_Size(new Size(54, 16));
		((Control)checkBox38).set_TabIndex(123);
		((Control)checkBox38).set_Text("1号车");
		((ButtonBase)checkBox38).set_UseVisualStyleBackColor(true);
		comboBox33.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox33).set_FormattingEnabled(true);
		((Control)comboBox33).set_Location(new Point(523, 331));
		((Control)comboBox33).set_Name("comboBox33");
		((Control)comboBox33).set_Size(new Size(156, 20));
		((Control)comboBox33).set_TabIndex(122);
		comboBox34.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox34).set_FormattingEnabled(true);
		((Control)comboBox34).set_Location(new Point(336, 331));
		((Control)comboBox34).set_Name("comboBox34");
		((Control)comboBox34).set_Size(new Size(171, 20));
		((Control)comboBox34).set_TabIndex(121);
		((Control)checkBox39).set_AutoSize(true);
		((Control)checkBox39).set_ForeColor(Color.Blue);
		((Control)checkBox39).set_Location(new Point(282, 334));
		((Control)checkBox39).set_Name("checkBox39");
		((Control)checkBox39).set_Size(new Size(48, 16));
		((Control)checkBox39).set_TabIndex(120);
		((Control)checkBox39).set_Text("换车");
		((ButtonBase)checkBox39).set_UseVisualStyleBackColor(true);
		((Control)checkBox40).set_AutoSize(true);
		((Control)checkBox40).set_ForeColor(Color.Blue);
		((Control)checkBox40).set_Location(new Point(222, 335));
		((Control)checkBox40).set_Name("checkBox40");
		((Control)checkBox40).set_Size(new Size(54, 16));
		((Control)checkBox40).set_TabIndex(119);
		((Control)checkBox40).set_Text("1号车");
		((ButtonBase)checkBox40).set_UseVisualStyleBackColor(true);
		comboBox35.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox35).set_FormattingEnabled(true);
		((Control)comboBox35).set_Location(new Point(523, 303));
		((Control)comboBox35).set_Name("comboBox35");
		((Control)comboBox35).set_Size(new Size(156, 20));
		((Control)comboBox35).set_TabIndex(118);
		comboBox36.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox36).set_FormattingEnabled(true);
		((Control)comboBox36).set_Location(new Point(336, 303));
		((Control)comboBox36).set_Name("comboBox36");
		((Control)comboBox36).set_Size(new Size(171, 20));
		((Control)comboBox36).set_TabIndex(117);
		((Control)checkBox41).set_AutoSize(true);
		((Control)checkBox41).set_ForeColor(Color.Blue);
		((Control)checkBox41).set_Location(new Point(282, 306));
		((Control)checkBox41).set_Name("checkBox41");
		((Control)checkBox41).set_Size(new Size(48, 16));
		((Control)checkBox41).set_TabIndex(116);
		((Control)checkBox41).set_Text("换车");
		((ButtonBase)checkBox41).set_UseVisualStyleBackColor(true);
		((Control)checkBox42).set_AutoSize(true);
		((Control)checkBox42).set_ForeColor(Color.Blue);
		((Control)checkBox42).set_Location(new Point(222, 307));
		((Control)checkBox42).set_Name("checkBox42");
		((Control)checkBox42).set_Size(new Size(54, 16));
		((Control)checkBox42).set_TabIndex(115);
		((Control)checkBox42).set_Text("1号车");
		((ButtonBase)checkBox42).set_UseVisualStyleBackColor(true);
		comboBox37.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox37).set_FormattingEnabled(true);
		((Control)comboBox37).set_Location(new Point(523, 277));
		((Control)comboBox37).set_Name("comboBox37");
		((Control)comboBox37).set_Size(new Size(156, 20));
		((Control)comboBox37).set_TabIndex(114);
		comboBox38.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox38).set_FormattingEnabled(true);
		((Control)comboBox38).set_Location(new Point(336, 277));
		((Control)comboBox38).set_Name("comboBox38");
		((Control)comboBox38).set_Size(new Size(171, 20));
		((Control)comboBox38).set_TabIndex(113);
		((Control)checkBox43).set_AutoSize(true);
		((Control)checkBox43).set_ForeColor(Color.Blue);
		((Control)checkBox43).set_Location(new Point(282, 280));
		((Control)checkBox43).set_Name("checkBox43");
		((Control)checkBox43).set_Size(new Size(48, 16));
		((Control)checkBox43).set_TabIndex(112);
		((Control)checkBox43).set_Text("换车");
		((ButtonBase)checkBox43).set_UseVisualStyleBackColor(true);
		((Control)checkBox44).set_AutoSize(true);
		((Control)checkBox44).set_ForeColor(Color.Blue);
		((Control)checkBox44).set_Location(new Point(222, 281));
		((Control)checkBox44).set_Name("checkBox44");
		((Control)checkBox44).set_Size(new Size(54, 16));
		((Control)checkBox44).set_TabIndex(111);
		((Control)checkBox44).set_Text("1号车");
		((ButtonBase)checkBox44).set_UseVisualStyleBackColor(true);
		comboBox39.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox39).set_FormattingEnabled(true);
		((Control)comboBox39).set_Location(new Point(523, 251));
		((Control)comboBox39).set_Name("comboBox39");
		((Control)comboBox39).set_Size(new Size(156, 20));
		((Control)comboBox39).set_TabIndex(110);
		comboBox40.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox40).set_FormattingEnabled(true);
		((Control)comboBox40).set_Location(new Point(336, 251));
		((Control)comboBox40).set_Name("comboBox40");
		((Control)comboBox40).set_Size(new Size(171, 20));
		((Control)comboBox40).set_TabIndex(109);
		((Control)checkBox45).set_AutoSize(true);
		((Control)checkBox45).set_ForeColor(Color.Blue);
		((Control)checkBox45).set_Location(new Point(282, 254));
		((Control)checkBox45).set_Name("checkBox45");
		((Control)checkBox45).set_Size(new Size(48, 16));
		((Control)checkBox45).set_TabIndex(108);
		((Control)checkBox45).set_Text("换车");
		((ButtonBase)checkBox45).set_UseVisualStyleBackColor(true);
		((Control)checkBox46).set_AutoSize(true);
		((Control)checkBox46).set_ForeColor(Color.Blue);
		((Control)checkBox46).set_Location(new Point(222, 255));
		((Control)checkBox46).set_Name("checkBox46");
		((Control)checkBox46).set_Size(new Size(54, 16));
		((Control)checkBox46).set_TabIndex(107);
		((Control)checkBox46).set_Text("1号车");
		((ButtonBase)checkBox46).set_UseVisualStyleBackColor(true);
		comboBox41.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox41).set_FormattingEnabled(true);
		((Control)comboBox41).set_Location(new Point(523, 223));
		((Control)comboBox41).set_Name("comboBox41");
		((Control)comboBox41).set_Size(new Size(156, 20));
		((Control)comboBox41).set_TabIndex(106);
		comboBox42.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox42).set_FormattingEnabled(true);
		((Control)comboBox42).set_Location(new Point(336, 223));
		((Control)comboBox42).set_Name("comboBox42");
		((Control)comboBox42).set_Size(new Size(171, 20));
		((Control)comboBox42).set_TabIndex(105);
		((Control)checkBox47).set_AutoSize(true);
		((Control)checkBox47).set_ForeColor(Color.Blue);
		((Control)checkBox47).set_Location(new Point(282, 226));
		((Control)checkBox47).set_Name("checkBox47");
		((Control)checkBox47).set_Size(new Size(48, 16));
		((Control)checkBox47).set_TabIndex(104);
		((Control)checkBox47).set_Text("换车");
		((ButtonBase)checkBox47).set_UseVisualStyleBackColor(true);
		((Control)checkBox48).set_AutoSize(true);
		((Control)checkBox48).set_ForeColor(Color.Blue);
		((Control)checkBox48).set_Location(new Point(222, 227));
		((Control)checkBox48).set_Name("checkBox48");
		((Control)checkBox48).set_Size(new Size(54, 16));
		((Control)checkBox48).set_TabIndex(103);
		((Control)checkBox48).set_Text("1号车");
		((ButtonBase)checkBox48).set_UseVisualStyleBackColor(true);
		((Control)label105).set_ForeColor(Color.Blue);
		((Control)label105).set_Location(new Point(540, 174));
		((Control)label105).set_Name("label105");
		((Control)label105).set_Size(new Size(159, 25));
		((Control)label105).set_TabIndex(96);
		((Control)label105).set_Text("单位：毫秒，默认延时时间为1000毫秒");
		((Control)textBox12).set_Location(new Point(325, 174));
		((Control)textBox12).set_Name("textBox12");
		((Control)textBox12).set_Size(new Size(209, 21));
		((Control)textBox12).set_TabIndex(95);
		((Control)label106).set_AutoSize(true);
		((Control)label106).set_ForeColor(Color.Blue);
		((Control)label106).set_Location(new Point(217, 180));
		((Control)label106).set_Name("label106");
		((Control)label106).set_Size(new Size(65, 12));
		((Control)label106).set_TabIndex(94);
		((Control)label106).set_Text("停车延时：");
		((Control)label107).set_ForeColor(Color.Blue);
		((Control)label107).set_Location(new Point(542, 147));
		((Control)label107).set_Name("label107");
		((Control)label107).set_Size(new Size(159, 25));
		((Control)label107).set_TabIndex(93);
		((Control)label107).set_Text("停车场QQ号以逗号隔开，如\u30001111,2222,3333");
		((Control)textBox13).set_Location(new Point(325, 147));
		((Control)textBox13).set_Name("textBox13");
		((Control)textBox13).set_Size(new Size(209, 21));
		((Control)textBox13).set_TabIndex(92);
		((Control)label108).set_AutoSize(true);
		((Control)label108).set_ForeColor(Color.Blue);
		((Control)label108).set_Location(new Point(217, 153));
		((Control)label108).set_Name("label108");
		((Control)label108).set_Size(new Size(89, 12));
		((Control)label108).set_TabIndex(91);
		((Control)label108).set_Text("停车场的顺序：");
		((Control)label109).set_ForeColor(Color.Blue);
		((Control)label109).set_Location(new Point(542, 118));
		((Control)label109).set_Name("label109");
		((Control)label109).set_Size(new Size(159, 25));
		((Control)label109).set_TabIndex(90);
		((Control)label109).set_Text("车子编号以逗号隔开，如\u30001,2,3,4,5,6,7,8,9,10");
		((Control)label110).set_ForeColor(Color.Blue);
		((Control)label110).set_Location(new Point(542, 93));
		((Control)label110).set_Name("label110");
		((Control)label110).set_Size(new Size(159, 25));
		((Control)label110).set_TabIndex(89);
		((Control)label110).set_Text("车位以逗号隔开，如\u30002,3,4");
		((Control)button70).set_Location(new Point(317, 6));
		((Control)button70).set_Name("button70");
		((Control)button70).set_Size(new Size(75, 31));
		((Control)button70).set_TabIndex(88);
		((Control)button70).set_Text("保存脚本");
		((ButtonBase)button70).set_UseVisualStyleBackColor(true);
		((Control)textBox14).set_Location(new Point(325, 120));
		((Control)textBox14).set_Name("textBox14");
		((Control)textBox14).set_Size(new Size(209, 21));
		((Control)textBox14).set_TabIndex(87);
		((Control)label111).set_AutoSize(true);
		((Control)label111).set_ForeColor(Color.Blue);
		((Control)label111).set_Location(new Point(217, 125));
		((Control)label111).set_Name("label111");
		((Control)label111).set_Size(new Size(101, 12));
		((Control)label111).set_TabIndex(86);
		((Control)label111).set_Text("车子停车的顺序：");
		((Control)checkBox49).set_AutoSize(true);
		((Control)checkBox49).set_ForeColor(Color.Blue);
		((Control)checkBox49).set_Location(new Point(325, 72));
		((Control)checkBox49).set_Name("checkBox49");
		((Control)checkBox49).set_Size(new Size(120, 16));
		((Control)checkBox49).set_TabIndex(85);
		((Control)checkBox49).set_Text("被贴车辆是否回停");
		((ButtonBase)checkBox49).set_UseVisualStyleBackColor(true);
		((Control)textBox15).set_Location(new Point(325, 93));
		((Control)textBox15).set_Name("textBox15");
		((Control)textBox15).set_Size(new Size(209, 21));
		((Control)textBox15).set_TabIndex(84);
		((Control)label112).set_AutoSize(true);
		((Control)label112).set_ForeColor(Color.Blue);
		((Control)label112).set_Location(new Point(217, 98));
		((Control)label112).set_Name("label112");
		((Control)label112).set_Size(new Size(101, 12));
		((Control)label112).set_TabIndex(83);
		((Control)label112).set_Text("需要贴条的车位：");
		((Control)checkBox50).set_AutoSize(true);
		((Control)checkBox50).set_ForeColor(Color.Blue);
		((Control)checkBox50).set_Location(new Point(217, 72));
		((Control)checkBox50).set_Name("checkBox50");
		((Control)checkBox50).set_Size(new Size(72, 16));
		((Control)checkBox50).set_TabIndex(82);
		((Control)checkBox50).set_Text("是否贴条");
		((ButtonBase)checkBox50).set_UseVisualStyleBackColor(true);
		((Control)label113).set_ForeColor(Color.Blue);
		((Control)label113).set_Location(new Point(542, 41));
		((Control)label113).set_Name("label113");
		((Control)label113).set_Size(new Size(159, 25));
		((Control)label113).set_TabIndex(81);
		((Control)label113).set_Text("可设定多个时间，时间之间以逗号隔开,如 21:30,22:40");
		((Control)textBox16).set_Location(new Point(325, 44));
		((Control)textBox16).set_Name("textBox16");
		((Control)textBox16).set_Size(new Size(209, 21));
		((Control)textBox16).set_TabIndex(80);
		((Control)label114).set_AutoSize(true);
		((Control)label114).set_Font(new Font("仿宋_GB2312", 15f, (FontStyle)1, (GraphicsUnit)3, (byte)134));
		((Control)label114).set_ForeColor(Color.Red);
		((Control)label114).set_Location(new Point(603, 11));
		((Control)label114).set_Name("label114");
		((Control)label114).set_Size(new Size(135, 20));
		((Control)label114).set_TabIndex(79);
		((Control)label114).set_Text("兼容军刀脚本");
		((Control)label115).set_AutoSize(true);
		((Control)label115).set_ForeColor(Color.Blue);
		((Control)label115).set_Location(new Point(217, 50));
		((Control)label115).set_Name("label115");
		((Control)label115).set_Size(new Size(89, 12));
		((Control)label115).set_TabIndex(78);
		((Control)label115).set_Text("脚本开始时间：");
		((Control)listView17).set_Anchor((AnchorStyles)7);
		listView17.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { columnHeader233, columnHeader234 });
		((Control)listView17).set_ContextMenuStrip(contextMenuStrip1);
		((Control)listView17).set_Cursor(Cursors.get_Default());
		((Control)listView17).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		listView17.set_FullRowSelect(true);
		listView17.set_GridLines(true);
		((Control)listView17).set_Location(new Point(0, 3));
		listView17.set_MultiSelect(false);
		((Control)listView17).set_Name("listView17");
		((Control)listView17).set_Size(new Size(203, 493));
		((Control)listView17).set_TabIndex(19);
		listView17.set_UseCompatibleStateImageBehavior(false);
		listView17.set_View((View)1);
		columnHeader233.set_Text("QQ号码");
		columnHeader233.set_Width(71);
		columnHeader234.set_Text("昵称");
		columnHeader234.set_Width(95);
		((Control)button71).set_Location(new Point(516, 6));
		((Control)button71).set_Name("button71");
		((Control)button71).set_Size(new Size(75, 31));
		((Control)button71).set_TabIndex(76);
		((Control)button71).set_Text("停止脚本");
		((ButtonBase)button71).set_UseVisualStyleBackColor(true);
		((Control)button72).set_Location(new Point(224, 6));
		((Control)button72).set_Name("button72");
		((Control)button72).set_Size(new Size(75, 31));
		((Control)button72).set_TabIndex(77);
		((Control)button72).set_Text("编辑脚本");
		((ButtonBase)button72).set_UseVisualStyleBackColor(true);
		((Control)button73).set_Location(new Point(416, 6));
		((Control)button73).set_Name("button73");
		((Control)button73).set_Size(new Size(75, 31));
		((Control)button73).set_TabIndex(75);
		((Control)button73).set_Text("开始脚本");
		((ButtonBase)button73).set_UseVisualStyleBackColor(true);
		((FileDialog)saveFileDialog1).set_Filter("Txt文件|*.txt|所有文件|*.*");
		((FileDialog)saveFileDialog1).add_FileOk((CancelEventHandler)saveFileDialog1_FileOk);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.Control);
		((Form)this).set_ClientSize(new Size(988, 666));
		((Control)this).get_Controls().Add((Control)(object)statusStrip1);
		((Control)this).get_Controls().Add((Control)(object)toolStrip1);
		((Control)this).get_Controls().Add((Control)(object)tabControl1);
		((Control)this).get_Controls().Add((Control)(object)menuStrip1);
		((Control)this).get_Controls().Add((Control)(object)tabControl6);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MainMenuStrip(menuStrip1);
		((Control)this).set_MinimumSize(new Size(950, 600));
		((Control)this).set_Name("Main");
		((Control)this).add_SizeChanged((EventHandler)Main_SizeChanged);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Main_FormClosing));
		((Form)this).add_Load((EventHandler)Main_Load);
		((Control)menuStrip1).ResumeLayout(false);
		((Control)menuStrip1).PerformLayout();
		((Control)contextMenuStrip1).ResumeLayout(false);
		((Control)tabControl1).ResumeLayout(false);
		((Control)tabPageZhzx).ResumeLayout(false);
		((Control)tabPageZhzx).PerformLayout();
		((Control)tabPageParks).ResumeLayout(false);
		((Control)tabControl3).ResumeLayout(false);
		((Control)tabPagePark).ResumeLayout(false);
		((Control)tabPagePark).PerformLayout();
		((Control)tabPageJubao).ResumeLayout(false);
		((Control)tabPageJubao).PerformLayout();
		((Control)tabControl10).ResumeLayout(false);
		((Control)tabPage27).ResumeLayout(false);
		((Control)tabPage27).PerformLayout();
		((Control)tabPage28).ResumeLayout(false);
		((Control)tabPage28).PerformLayout();
		((Control)tabPageCheshi).ResumeLayout(false);
		((Control)tabPageCheshi).PerformLayout();
		((Control)tabPageJiaoben).ResumeLayout(false);
		((Control)tabControl7).ResumeLayout(false);
		((Control)tabPage22).ResumeLayout(false);
		((Control)tabPage22).PerformLayout();
		((Control)contextMenuStrip2).ResumeLayout(false);
		((Control)tabPage23).ResumeLayout(false);
		((Control)tabPage23).PerformLayout();
		((Control)tabPageWoDeCheZiJinKuang).ResumeLayout(false);
		((Control)tabPageWoDeCheZiJinKuang).PerformLayout();
		((Control)tabPage20).ResumeLayout(false);
		((Control)tabPage20).PerformLayout();
		((Control)tabPage21).ResumeLayout(false);
		((Control)tabPage21).PerformLayout();
		((Control)tabPageFriendBuy).ResumeLayout(false);
		((Control)tabControl5).ResumeLayout(false);
		((Control)tabPageShiJian).ResumeLayout(false);
		((Control)tabPageShiJian).PerformLayout();
		((Control)tabPageJilu).ResumeLayout(false);
		((Control)tabPageJilu).PerformLayout();
		((Control)tabControl9).ResumeLayout(false);
		((Control)tabPage24).ResumeLayout(false);
		((Control)tabPage25).ResumeLayout(false);
		((Control)tabPage25).PerformLayout();
		((Control)tabPage26).ResumeLayout(false);
		((Control)tabPage26).PerformLayout();
		((Control)tabPageQueryFriend).ResumeLayout(false);
		((Control)tabPageQueryFriend).PerformLayout();
		((Control)tabControl2).ResumeLayout(false);
		((Control)tabPageJinBen).ResumeLayout(false);
		((Control)tabPageQueryPark).ResumeLayout(false);
		((Control)tabPageQueryPark).PerformLayout();
		((Control)tabPageQueryQQBuyFriend).ResumeLayout(false);
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)tabPage9).ResumeLayout(false);
		((ISupportInitialize)pictureBox5).EndInit();
		((Control)contextMenuStrip4).ResumeLayout(false);
		((Control)tabPage10).ResumeLayout(false);
		((ISupportInitialize)axWindowsMediaPlayer1).EndInit();
		((Control)contextMenuStrip3).ResumeLayout(false);
		((Control)tabPage11).ResumeLayout(false);
		((Control)tabPage11).PerformLayout();
		((Control)tabPageXi).ResumeLayout(false);
		((Control)tabPageXi).PerformLayout();
		((Control)tabPageZone).ResumeLayout(false);
		((Control)tabPageZone).PerformLayout();
		((Control)tabControl8).ResumeLayout(false);
		((Control)tabPage12).ResumeLayout(false);
		((Control)contextMenuStrip5).ResumeLayout(false);
		((Control)tabPage13).ResumeLayout(false);
		((Control)tabPageCity).ResumeLayout(false);
		((Control)tabPageCity).PerformLayout();
		((ISupportInitialize)pictureBoxCity).EndInit();
		((Control)toolStrip1).ResumeLayout(false);
		((Control)toolStrip1).PerformLayout();
		((Control)statusStrip1).ResumeLayout(false);
		((Control)statusStrip1).PerformLayout();
		((ISupportInitialize)pictureBoxValidate).EndInit();
		((Control)MenuNotify).ResumeLayout(false);
		((Control)tabPage1).ResumeLayout(false);
		((Control)tabPage1).PerformLayout();
		((Control)tabPage2).ResumeLayout(false);
		((Control)tabPage2).PerformLayout();
		((Control)tabPage3).ResumeLayout(false);
		((Control)tabPage3).PerformLayout();
		((Control)tabPage4).ResumeLayout(false);
		((Control)tabPage4).PerformLayout();
		((Control)tabControl4).ResumeLayout(false);
		((Control)tabPage5).ResumeLayout(false);
		((Control)tabPage6).ResumeLayout(false);
		((Control)tabPage6).PerformLayout();
		((Control)tabPage7).ResumeLayout(false);
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox4).EndInit();
		((Control)tabPage8).ResumeLayout(false);
		((Control)tabPage8).PerformLayout();
		((Control)tabPage14).ResumeLayout(false);
		((Control)tabPage14).PerformLayout();
		((Control)tabPage15).ResumeLayout(false);
		((Control)tabPage15).PerformLayout();
		((Control)tabPage16).ResumeLayout(false);
		((Control)tabPage16).PerformLayout();
		((Control)tabPage17).ResumeLayout(false);
		((Control)tabPage17).PerformLayout();
		((Control)tabPage18).ResumeLayout(false);
		((Control)tabPage18).PerformLayout();
		((Control)tabPage19).ResumeLayout(false);
		((Control)tabPage19).PerformLayout();
		((Control)tabControl6).ResumeLayout(false);
		((Control)tabPageLogin).ResumeLayout(false);
		((Control)tabPageLogin).PerformLayout();
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)tabPageHaveLogin).ResumeLayout(false);
		((Control)tabPageHaveLogin).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
