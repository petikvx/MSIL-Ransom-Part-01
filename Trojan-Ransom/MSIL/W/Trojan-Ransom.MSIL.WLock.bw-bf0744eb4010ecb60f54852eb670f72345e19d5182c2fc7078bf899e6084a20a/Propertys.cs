using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

public class Propertys
{
	public object obj;

	private string CM;

	private string CM1;

	private string CM2;

	private string ind;

	private string anch;

	private string AutoTr;

	private string niv;

	public bool Sem;

	private string BkColor;

	private string BkColor1;

	private string BkColor2;

	private string backImage;

	private string backImage1;

	private string backImage2;

	private string bkImageStyle;

	private string bkImageStyle1;

	private string bkImageStyle2;

	private string curs;

	private string curs1;

	private string curs2;

	private string dok;

	private string enab;

	private string styl;

	private string bstyl;

	private string fontFam;

	private string fontBol;

	private string fontItal;

	private string fontUnder;

	private string fontStrike;

	private string fontCol;

	private string Img;

	private string ImgAl;

	private int lft;

	private int tp;

	private int maxWidth;

	private int maxHeight;

	private int minWidth;

	private int minHeight;

	private int padLeft;

	private int padTop;

	private int padRight;

	private int padBottom;

	private int Wid;

	private int Hei;

	private int tabInd;

	private string tabStp;

	private string tg;

	public string txt;

	public object Sep;

	private string txtAl;

	private string txtPos;

	private string txtImRel;

	private string vis;

	private string mf;

	private string cancelCl;

	private string mab;

	private string mib;

	private string AssocExts;

	public int pos;

	private string aScrl;

	private string orientTl;

	private string alig;

	private string aTT;

	private string ChOnCl;

	private string dispSt;

	public object lastSource;

	public object ownIt;

	public object MyOwnIt;

	private string dm;

	private ToolStripDropDownMenu oldMenu;

	private string imScal;

	private string imTranspCol;

	private string shortK;

	private string shSK;

	private string txtDirc;

	private string toolTT;

	private string Aligz;

	private int SelTabPos;

	private int padX;

	private int padY;

	private string val;

	private string AuRu;

	private string AuRC;

	private string AllInp;

	private string aScrl1;

	private string aScrl2;

	private string fxPn;

	private string orient;

	private string fxSplit;

	private string pn1Coll;

	private string pn2Coll;

	private int splWid;

	private int splDis;

	private int splInc;

	private int pn1MinS;

	private int pn2MinS;

	private Control ctrWindow;

	public bool StopedFlag;

	private string strFileName;

	private string pld;

	private int iVolume;

	private int iBalance;

	private string iMute;

	private int iSpeed;

	private bool bOpened;

	public bool bPlaying;

	public string strAlias;

	private string OnFullS;

	private int maxLen;

	private string MuLine;

	private string passCh;

	private string rOnly;

	private string scrlBars;

	private string allowNav;

	private string allowDrop;

	private string cmBrowser;

	private string scrpErrs;

	private string scrBarsEn;

	private string ur;

	private string ShCutEn;

	private string docEnc;

	private string newWin;

	private string CnBox;

	private string FrStyle;

	private string MM;

	private int opac;

	private string ShIc;

	private string ShTB;

	private string StPos;

	private string TMst;

	private string WiStat;

	private int AutScrMinW;

	private int AutScrMinH;

	private int AutScrPosX;

	private int AutScrPosY;

	private string Icn;

	private string TrCol;

	private string AUtAR;

	private string AUtDR;

	private string AUtOC;

	private string AUtRC;

	private string AUtRR;

	private string cBorSt;

	private string HeadVis;

	private string CSBkColor;

	private string CSSBkColor;

	private string CSFrColor;

	private string CSSFrColor;

	private string EdMd;

	private string GrCol;

	private string MultSel;

	private string RdOlTb;

	private string SelMode;

	public string selRows;

	public bool semaforSelect;

	public string selCol;

	public string colsWids;

	public string rowsH;

	public bool isSelecExecute;

	private string tablName;

	private string dbName;

	private string typeName;

	private string lastSelect;

	private OleDbConnection cn;

	private OleDbCommand cmd;

	private OleDbDataReader dr;

	private DataTable dt;

	private int DrDnHeight;

	private int DrDnWidth;

	private string DrDnStyl;

	private int MaxDrDn;

	private string Srtd;

	private int selIn;

	private string selIt;

	private int colWid;

	private string HorScBar;

	private string multCol;

	private string selModeList;

	private string ActLinkCol;

	private string DisLiCol;

	private string LiCo;

	private string VisLiCol;

	private int LiSt;

	private int LiLe;

	private string LinBeh;

	private string LiVis;

	private string LiEn;

	private string InetLin;

	private string LinkNam;

	private string DetUr;

	private string dCol;

	private string cnl;

	private string ShCols;

	private string ShEff;

	private string descr;

	private string sePath;

	private string defEx;

	private string ChFEx;

	private string ChPEx;

	private string flNm;

	private string fltr;

	private int flIn;

	private string iniDir;

	private string ttl;

	private string MuSeFil;

	private string prPic;

	private string prTx;

	private string prDc;

	private string prTl;

	private string prOb;

	private string TbCn;

	private int FrmPg;

	private int ToPg;

	private int Cops;

	private string kpri;

	private string idpr;

	private string rkey;

	private string btnT;

	private string tF;

	private string msDa;

	private string msNet;

	private string dnVs;

	public int status;

	private string TlTp;

	private string MultSelIts;

	private int Intr;

	private int IntrCou;

	public string Name
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			string text = Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null));
			NewLateBinding.LateSet(obj, (Type)null, "Name", new object[1] { value }, (string[])null, (Type[])null);
			if (peremens2.proj != null)
			{
				object proj = peremens2.proj;
				object[] array = new object[2]
				{
					RuntimeHelpers.GetObjectValue(obj),
					text
				};
				bool[] array2 = new bool[2] { true, true };
				NewLateBinding.LateCall(proj, (Type)null, "ChangeName", array, (string[])null, (Type[])null, array2, true);
				if (array2[0])
				{
					obj = RuntimeHelpers.GetObjectValue(array[0]);
				}
				if (array2[1])
				{
					text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
				}
			}
		}
	}

	public string ContextMenu
	{
		get
		{
			return CM;
		}
		set
		{
			CM = value;
		}
	}

	public string ContextMenu1
	{
		get
		{
			return CM1;
		}
		set
		{
			CM1 = value;
		}
	}

	public string ContextMenu2
	{
		get
		{
			return CM2;
		}
		set
		{
			CM2 = value;
		}
	}

	public string Index
	{
		get
		{
			return ind;
		}
		set
		{
			string text = ind;
			ind = value;
			if (peremens2.proj != null)
			{
				object proj = peremens2.proj;
				object[] array = new object[2]
				{
					RuntimeHelpers.GetObjectValue(obj),
					text
				};
				bool[] array2 = new bool[2] { true, true };
				NewLateBinding.LateCall(proj, (Type)null, "ChangeIndex", array, (string[])null, (Type[])null, array2, true);
				if (array2[0])
				{
					obj = RuntimeHelpers.GetObjectValue(array[0]);
				}
				if (array2[1])
				{
					text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
				}
			}
		}
	}

	public string Anchor
	{
		get
		{
			return anch;
		}
		set
		{
			anch = value;
			NewLateBinding.LateSet(obj, (Type)null, "Anchor", new object[1] { RuntimeHelpers.GetObjectValue(peremens.Anchors.GetByIndex(peremens.Anchors.IndexOfKey(Strings.LCase(anch)))) }, (string[])null, (Type[])null);
		}
	}

	public string AutoEllipsis
	{
		get
		{
			return AutoTr;
		}
		set
		{
			AutoTr = value;
			NewLateBinding.LateSet(obj, (Type)null, "AutoEllipsis", new object[1] { peremens.DaOrNet(AutoTr) }, (string[])null, (Type[])null);
		}
	}

	public string ShowInTray
	{
		get
		{
			return niv;
		}
		set
		{
			niv = value;
			if (Iz.IsFORMRunObj(RuntimeHelpers.GetObjectValue(obj)))
			{
				if (peremens.DaOrNet(value))
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "ni", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
				}
				else
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "ni", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
				}
			}
		}
	}

	public string BackColor
	{
		get
		{
			Color color = default(Color);
			if (Iz.IsTl(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				object obj = NewLateBinding.LateGet(this.obj, (Type)null, "BackgroundColor", new object[0], (string[])null, (Type[])null, (bool[])null);
				return peremens.ToMyColor((obj != null) ? ((Color)obj) : color);
			}
			object obj2 = NewLateBinding.LateGet(this.obj, (Type)null, "BackColor", new object[0], (string[])null, (Type[])null, (bool[])null);
			return peremens.ToMyColor((obj2 != null) ? ((Color)obj2) : color);
		}
		set
		{
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
			{
				try
				{
					NewLateBinding.LateSet(obj, (Type)null, "BackColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null);
					BkColor = value;
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (!peremens.IgnorEr)
					{
						Errors.MessangeExclamen(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			BkColor = value;
			if (Iz.IsTl(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				NewLateBinding.LateSet(obj, (Type)null, "BackgroundColor", new object[1] { peremens.FromMyColor(BkColor) }, (string[])null, (Type[])null);
			}
			else
			{
				NewLateBinding.LateSet(obj, (Type)null, "BackColor", new object[1] { peremens.FromMyColor(BkColor) }, (string[])null, (Type[])null);
			}
		}
	}

	public string BackColor1
	{
		get
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Panel1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor", new object[0], (string[])null, (Type[])null, (bool[])null);
			Color color = default(Color);
			return peremens.ToMyColor((obj != null) ? ((Color)obj) : color);
		}
		set
		{
			BkColor1 = value;
			if (Operators.CompareString(peremens.NikakoiEsli(BkColor1), peremens.trans("Никакой"), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
			}
			else
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor", new object[1] { peremens.FromMyColor(BkColor1) }, (string[])null, (Type[])null, false, true);
			}
		}
	}

	public string BackColor2
	{
		get
		{
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor", new object[0], (string[])null, (Type[])null, (bool[])null);
			Color color = default(Color);
			return peremens.ToMyColor((obj != null) ? ((Color)obj) : color);
		}
		set
		{
			BkColor2 = value;
			if (Operators.CompareString(peremens.NikakoiEsli(BkColor2), peremens.trans("Никакой"), false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
			}
			else
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor", new object[1] { peremens.FromMyColor(BkColor2) }, (string[])null, (Type[])null, false, true);
			}
		}
	}

	public string BackgroundImage
	{
		get
		{
			return peremens.GetMinPath(backImage);
		}
		set
		{
			backImage = peremens.GetMaxPath(value);
			if (peremens.IsHttpCompil)
			{
				return;
			}
			if (Operators.CompareString(peremens.NikakoiEsli(backImage), peremens.trans("Никакой"), false) != 0)
			{
				try
				{
					NewLateBinding.LateSet(obj, (Type)null, "BackgroundImage", new object[1] { Image.FromFile(backImage) }, (string[])null, (Type[])null);
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					NewLateBinding.LateSet(obj, (Type)null, "BackgroundImage", new object[1] { null }, (string[])null, (Type[])null);
					if (!peremens.IgnorEr)
					{
						Errors.MessangeCritic(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			NewLateBinding.LateSet(obj, (Type)null, "BackgroundImage", new object[1] { null }, (string[])null, (Type[])null);
		}
	}

	public string BackgroundImage1
	{
		get
		{
			return peremens.GetMinPath(backImage1);
		}
		set
		{
			backImage1 = peremens.GetMaxPath(value);
			if (peremens.IsHttpCompil)
			{
				return;
			}
			if (Operators.CompareString(peremens.NikakoiEsli(backImage1), peremens.trans("Никакой"), false) != 0)
			{
				try
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImage", new object[1] { Image.FromFile(backImage1) }, (string[])null, (Type[])null, false, true);
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImage", new object[1] { null }, (string[])null, (Type[])null, false, true);
					if (!peremens.IgnorEr)
					{
						Errors.MessangeCritic(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImage", new object[1] { null }, (string[])null, (Type[])null, false, true);
		}
	}

	public string BackgroundImage2
	{
		get
		{
			return peremens.GetMinPath(backImage2);
		}
		set
		{
			backImage2 = peremens.GetMaxPath(value);
			if (peremens.IsHttpCompil)
			{
				return;
			}
			if (Operators.CompareString(peremens.NikakoiEsli(backImage2), peremens.trans("Никакой"), false) != 0)
			{
				try
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImage", new object[1] { Image.FromFile(backImage2) }, (string[])null, (Type[])null, false, true);
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImage", new object[1] { null }, (string[])null, (Type[])null, false, true);
					if (!peremens.IgnorEr)
					{
						Errors.MessangeCritic(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImage", new object[1] { null }, (string[])null, (Type[])null, false, true);
		}
	}

	public string BackgroundImageLayout
	{
		get
		{
			return bkImageStyle;
		}
		set
		{
			bkImageStyle = value;
			NewLateBinding.LateSet(obj, (Type)null, "BackgroundImageLayout", new object[1] { RuntimeHelpers.GetObjectValue(peremens.bkImStyles.GetByIndex(peremens.bkImStyles.IndexOfKey(Strings.LCase(bkImageStyle)))) }, (string[])null, (Type[])null);
		}
	}

	public string BackgroundImageLayout1
	{
		get
		{
			return bkImageStyle1;
		}
		set
		{
			bkImageStyle1 = value;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImageLayout", new object[1] { RuntimeHelpers.GetObjectValue(peremens.bkImStyles.GetByIndex(peremens.bkImStyles.IndexOfKey(Strings.LCase(bkImageStyle1)))) }, (string[])null, (Type[])null, false, true);
		}
	}

	public string BackgroundImageLayout2
	{
		get
		{
			return bkImageStyle2;
		}
		set
		{
			bkImageStyle2 = value;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackgroundImageLayout", new object[1] { RuntimeHelpers.GetObjectValue(peremens.bkImStyles.GetByIndex(peremens.bkImStyles.IndexOfKey(Strings.LCase(bkImageStyle2)))) }, (string[])null, (Type[])null, false, true);
		}
	}

	public string Cursor
	{
		get
		{
			return curs;
		}
		set
		{
			curs = value;
			NewLateBinding.LateSet(obj, (Type)null, "Cursor", new object[1] { RuntimeHelpers.GetObjectValue(peremens.Cursori.GetByIndex(peremens.Cursori.IndexOfKey(Strings.LCase(curs)))) }, (string[])null, (Type[])null);
		}
	}

	public string Cursor1
	{
		get
		{
			return curs1;
		}
		set
		{
			curs1 = value;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Cursor", new object[1] { RuntimeHelpers.GetObjectValue(peremens.Cursori.GetByIndex(peremens.Cursori.IndexOfKey(Strings.LCase(curs1)))) }, (string[])null, (Type[])null, false, true);
		}
	}

	public string Cursor2
	{
		get
		{
			return curs2;
		}
		set
		{
			curs2 = value;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Cursor", new object[1] { RuntimeHelpers.GetObjectValue(peremens.Cursori.GetByIndex(peremens.Cursori.IndexOfKey(Strings.LCase(curs2)))) }, (string[])null, (Type[])null, false, true);
		}
	}

	public string Dock
	{
		get
		{
			return dok;
		}
		set
		{
			dok = value;
			NewLateBinding.LateSet(obj, (Type)null, "Dock", new object[1] { RuntimeHelpers.GetObjectValue(peremens.Docks.GetByIndex(peremens.Docks.IndexOfKey(Strings.LCase(dok)))) }, (string[])null, (Type[])null);
		}
	}

	public string Enabled
	{
		get
		{
			return enab;
		}
		set
		{
			enab = value;
		}
	}

	public string FlatStyle
	{
		get
		{
			return styl;
		}
		set
		{
			styl = value;
			NewLateBinding.LateSet(obj, (Type)null, "FlatStyle", new object[1] { RuntimeHelpers.GetObjectValue(peremens.FlatStyles.GetByIndex(peremens.FlatStyles.IndexOfKey(Strings.LCase(styl)))) }, (string[])null, (Type[])null);
		}
	}

	public string BorderStyle
	{
		get
		{
			return bstyl;
		}
		set
		{
			bstyl = value;
			NewLateBinding.LateSet(obj, (Type)null, "BorderStyle", new object[1] { RuntimeHelpers.GetObjectValue(peremens.BorderStyles.GetByIndex(peremens.BorderStyles.IndexOfKey(Strings.LCase(bstyl)))) }, (string[])null, (Type[])null);
		}
	}

	public string FontFamily
	{
		get
		{
			return fontFam;
		}
		set
		{
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
			{
				return;
			}
			FontStyle val = (FontStyle)Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Style", new object[0], (string[])null, (Type[])null, (bool[])null));
			try
			{
				NewLateBinding.LateSet(obj, (Type)null, "Font", new object[1] { (object)new Font(peremens.Fonts.GetByIndex(peremens.Fonts.IndexOfKey(Strings.LCase(value)))!.ToString(), Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Size", new object[0], (string[])null, (Type[])null, (bool[])null)), val) }, (string[])null, (Type[])null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Interaction.MsgBox((object)(Errors.FontNotSupport(value) + "\r\n" + ex2.Message), (MsgBoxStyle)48, (object)null);
				}
				ProjectData.ClearProjectError();
				return;
			}
			fontFam = value;
		}
	}

	public string FontBold
	{
		get
		{
			return fontBol;
		}
		set
		{
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			FontStyle val = (FontStyle)checked(peremens.Int(Conversions.ToString(peremens.DaOrNet(value))) * 1 + peremens.Int(Conversions.ToString(peremens.DaOrNet(fontItal))) * 2 + peremens.Int(Conversions.ToString(peremens.DaOrNet(fontUnder))) * 4 + peremens.Int(Conversions.ToString(peremens.DaOrNet(fontStrike))) * 8);
			FontFamily val2 = (FontFamily)NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontFamily", new object[0], (string[])null, (Type[])null, (bool[])null);
			try
			{
				NewLateBinding.LateSet(obj, (Type)null, "Font", new object[1] { (object)new Font(val2, Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Size", new object[0], (string[])null, (Type[])null, (bool[])null)), val) }, (string[])null, (Type[])null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Interaction.MsgBox((object)(Errors.FontNotSupport(val2.ToString()) + "\r\n" + ex2.Message), (MsgBoxStyle)48, (object)null);
				}
				ProjectData.ClearProjectError();
				return;
			}
			fontBol = value;
		}
	}

	public string FontItalic
	{
		get
		{
			return fontItal;
		}
		set
		{
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			FontStyle val = (FontStyle)checked(peremens.Int(Conversions.ToString(peremens.DaOrNet(fontBol))) * 1 + peremens.Int(Conversions.ToString(peremens.DaOrNet(value))) * 2 + peremens.Int(Conversions.ToString(peremens.DaOrNet(fontUnder))) * 4 + peremens.Int(Conversions.ToString(peremens.DaOrNet(fontStrike))) * 8);
			FontFamily val2 = (FontFamily)NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontFamily", new object[0], (string[])null, (Type[])null, (bool[])null);
			try
			{
				NewLateBinding.LateSet(obj, (Type)null, "Font", new object[1] { (object)new Font(val2, Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Size", new object[0], (string[])null, (Type[])null, (bool[])null)), val) }, (string[])null, (Type[])null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Interaction.MsgBox((object)(Errors.FontNotSupport(val2.ToString()) + "\r\n" + ex2.Message), (MsgBoxStyle)48, (object)null);
				}
				ProjectData.ClearProjectError();
				return;
			}
			fontItal = value;
		}
	}

	public string FontUnderline
	{
		get
		{
			return fontUnder;
		}
		set
		{
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			FontStyle val = (FontStyle)checked(peremens.Int(Conversions.ToString(peremens.DaOrNet(fontBol))) * 1 + peremens.Int(Conversions.ToString(peremens.DaOrNet(fontItal))) * 2 + peremens.Int(Conversions.ToString(peremens.DaOrNet(value))) * 4 + peremens.Int(Conversions.ToString(peremens.DaOrNet(fontStrike))) * 8);
			FontFamily val2 = (FontFamily)NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontFamily", new object[0], (string[])null, (Type[])null, (bool[])null);
			try
			{
				NewLateBinding.LateSet(obj, (Type)null, "Font", new object[1] { (object)new Font(val2, Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Size", new object[0], (string[])null, (Type[])null, (bool[])null)), val) }, (string[])null, (Type[])null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Interaction.MsgBox((object)(Errors.FontNotSupport(val2.ToString()) + "\r\n" + ex2.Message), (MsgBoxStyle)48, (object)null);
				}
				ProjectData.ClearProjectError();
				return;
			}
			fontUnder = value;
		}
	}

	public string FontStrikeout
	{
		get
		{
			return fontStrike;
		}
		set
		{
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			FontStyle val = (FontStyle)checked(peremens.Int(Conversions.ToString(peremens.DaOrNet(fontBol))) * 1 + peremens.Int(Conversions.ToString(peremens.DaOrNet(fontItal))) * 2 + peremens.Int(Conversions.ToString(peremens.DaOrNet(fontUnder))) * 4 + peremens.Int(Conversions.ToString(peremens.DaOrNet(value))) * 8);
			FontFamily val2 = (FontFamily)NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontFamily", new object[0], (string[])null, (Type[])null, (bool[])null);
			try
			{
				NewLateBinding.LateSet(obj, (Type)null, "Font", new object[1] { (object)new Font(val2, Conversions.ToSingle(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Size", new object[0], (string[])null, (Type[])null, (bool[])null)), val) }, (string[])null, (Type[])null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Interaction.MsgBox((object)(Errors.FontNotSupport(val2.ToString()) + "\r\n" + ex2.Message), (MsgBoxStyle)48, (object)null);
				}
				ProjectData.ClearProjectError();
				return;
			}
			fontStrike = value;
		}
	}

	public int FontSize
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "size", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected O, but got Unknown
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			FontStyle val = (FontStyle)Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Style", new object[0], (string[])null, (Type[])null, (bool[])null));
			try
			{
				NewLateBinding.LateSet(obj, (Type)null, "Font", new object[1] { (object)new Font(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "fontfamily", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), (float)value, val) }, (string[])null, (Type[])null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Interaction.MsgBox((object)(Errors.FontNotSupport(Conversions.ToString(value)) + "\r\n" + ex2.Message), (MsgBoxStyle)48, (object)null);
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public string ForeColor
	{
		get
		{
			return fontCol;
		}
		set
		{
			fontCol = value;
			if (Operators.CompareString(peremens.NikakoiEsli(fontCol), peremens.trans("Никакой"), false) == 0)
			{
				NewLateBinding.LateSet(obj, (Type)null, "ForeColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null);
			}
			else
			{
				NewLateBinding.LateSet(obj, (Type)null, "ForeColor", new object[1] { peremens.FromMyColor(fontCol) }, (string[])null, (Type[])null);
			}
		}
	}

	public string Image
	{
		get
		{
			return peremens.GetMinPath(Img);
		}
		set
		{
			Img = peremens.GetMaxPath(value);
			if (peremens.IsHttpCompil)
			{
				return;
			}
			if (Operators.CompareString(peremens.NikakoiEsli(Img), peremens.trans("Никакой"), false) != 0)
			{
				try
				{
					NewLateBinding.LateSet(obj, (Type)null, "Image", new object[1] { Image.FromFile(Img) }, (string[])null, (Type[])null);
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					NewLateBinding.LateSet(obj, (Type)null, "Image", new object[1] { null }, (string[])null, (Type[])null);
					if (!peremens.IgnorEr)
					{
						Errors.MessangeCritic(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			NewLateBinding.LateSet(obj, (Type)null, "Image", new object[1] { null }, (string[])null, (Type[])null);
		}
	}

	public string SizeMode
	{
		get
		{
			return Conversions.ToString(peremens.SizeModes.GetKey(peremens.SizeModes.IndexOfValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "SizeMode", new object[0], (string[])null, (Type[])null, (bool[])null)))));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "SizeMode", new object[1] { RuntimeHelpers.GetObjectValue(peremens.SizeModes.GetByIndex(peremens.SizeModes.IndexOfKey(Strings.LCase(value)))) }, (string[])null, (Type[])null);
		}
	}

	public string ImageAlign
	{
		get
		{
			return ImgAl;
		}
		set
		{
			ImgAl = value;
			NewLateBinding.LateSet(obj, (Type)null, "ImageAlign", new object[1] { RuntimeHelpers.GetObjectValue(peremens.Aligns.GetByIndex(peremens.Aligns.IndexOfKey(Strings.LCase(ImgAl)))) }, (string[])null, (Type[])null);
		}
	}

	public int X
	{
		get
		{
			return lft;
		}
		set
		{
			lft = value;
			if (!Iz.IsFORMobj(RuntimeHelpers.GetObjectValue(obj)))
			{
				NewLateBinding.LateSet(obj, (Type)null, "left", new object[1] { lft }, (string[])null, (Type[])null);
			}
		}
	}

	public int Y
	{
		get
		{
			return tp;
		}
		set
		{
			tp = value;
			if (!Iz.IsFORMobj(RuntimeHelpers.GetObjectValue(obj)))
			{
				NewLateBinding.LateSet(obj, (Type)null, "Top", new object[1] { tp }, (string[])null, (Type[])null);
			}
		}
	}

	public int MaximumWidth
	{
		get
		{
			return maxWidth;
		}
		set
		{
			maxWidth = value;
			object obj = this.obj;
			object[] array = new object[1];
			Size size = new Size(maxWidth, MaximumHeight);
			array[0] = size;
			NewLateBinding.LateSet(obj, (Type)null, "MaximumSize", array, (string[])null, (Type[])null);
		}
	}

	public int MaximumHeight
	{
		get
		{
			return maxHeight;
		}
		set
		{
			maxHeight = value;
			object obj = this.obj;
			object[] array = new object[1];
			Size size = new Size(MaximumWidth, maxHeight);
			array[0] = size;
			NewLateBinding.LateSet(obj, (Type)null, "MaximumSize", array, (string[])null, (Type[])null);
		}
	}

	public int MinimumWidth
	{
		get
		{
			return minWidth;
		}
		set
		{
			minWidth = value;
			object obj = this.obj;
			object[] array = new object[1];
			Size size = new Size(minWidth, MinimumHeight);
			array[0] = size;
			NewLateBinding.LateSet(obj, (Type)null, "MinimumSize", array, (string[])null, (Type[])null);
		}
	}

	public int MinimumHeight
	{
		get
		{
			return minHeight;
		}
		set
		{
			minHeight = value;
			object obj = this.obj;
			object[] array = new object[1];
			Size size = new Size(MinimumWidth, minHeight);
			array[0] = size;
			NewLateBinding.LateSet(obj, (Type)null, "MinimumSize", array, (string[])null, (Type[])null);
		}
	}

	public int PaddingLeft
	{
		get
		{
			return padLeft;
		}
		set
		{
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			padLeft = value;
			if (!Iz.IsPrD(RuntimeHelpers.GetObjectValue(this.obj)))
			{
				object obj = this.obj;
				object[] array = new object[1];
				object[] array2 = array;
				Padding val = default(Padding);
				((Padding)(ref val))._002Ector(padLeft, PaddingTop, PaddingRight, PaddingBottom);
				array2[0] = val;
				NewLateBinding.LateSet(obj, (Type)null, "Padding", array, (string[])null, (Type[])null);
			}
			else if (peremens.isRUN())
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultPageSettings", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Margins", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
		}
	}

	public int PaddingTop
	{
		get
		{
			return padTop;
		}
		set
		{
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			padTop = value;
			if (!Iz.IsPrD(RuntimeHelpers.GetObjectValue(this.obj)))
			{
				object obj = this.obj;
				object[] array = new object[1];
				object[] array2 = array;
				Padding val = default(Padding);
				((Padding)(ref val))._002Ector(PaddingLeft, padTop, PaddingRight, PaddingBottom);
				array2[0] = val;
				NewLateBinding.LateSet(obj, (Type)null, "Padding", array, (string[])null, (Type[])null);
			}
			else if (peremens.isRUN())
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultPageSettings", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Margins", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
		}
	}

	public int PaddingRight
	{
		get
		{
			return padRight;
		}
		set
		{
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			padRight = value;
			if (!Iz.IsPrD(RuntimeHelpers.GetObjectValue(this.obj)))
			{
				object obj = this.obj;
				object[] array = new object[1];
				object[] array2 = array;
				Padding val = default(Padding);
				((Padding)(ref val))._002Ector(PaddingLeft, PaddingTop, padRight, PaddingBottom);
				array2[0] = val;
				NewLateBinding.LateSet(obj, (Type)null, "Padding", array, (string[])null, (Type[])null);
			}
			else if (peremens.isRUN())
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultPageSettings", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Margins", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Right", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
		}
	}

	public int PaddingBottom
	{
		get
		{
			return padBottom;
		}
		set
		{
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			padBottom = value;
			if (!Iz.IsPrD(RuntimeHelpers.GetObjectValue(this.obj)))
			{
				object obj = this.obj;
				object[] array = new object[1];
				object[] array2 = array;
				Padding val = default(Padding);
				((Padding)(ref val))._002Ector(PaddingLeft, PaddingTop, PaddingRight, padBottom);
				array2[0] = val;
				NewLateBinding.LateSet(obj, (Type)null, "Padding", array, (string[])null, (Type[])null);
			}
			else if (peremens.isRUN())
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultPageSettings", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Margins", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bottom", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
		}
	}

	public int Width
	{
		get
		{
			return Wid;
		}
		set
		{
			Wid = value;
			NewLateBinding.LateSet(obj, (Type)null, "Width", new object[1] { Wid }, (string[])null, (Type[])null);
		}
	}

	public int Height
	{
		get
		{
			return Hei;
		}
		set
		{
			Hei = value;
			NewLateBinding.LateSet(obj, (Type)null, "Height", new object[1] { Hei }, (string[])null, (Type[])null);
		}
	}

	public int TabIndex
	{
		get
		{
			return tabInd;
		}
		set
		{
			tabInd = value;
			NewLateBinding.LateSet(obj, (Type)null, "TabIndex", new object[1] { tabInd }, (string[])null, (Type[])null);
		}
	}

	public string TabStop
	{
		get
		{
			return tabStp;
		}
		set
		{
			tabStp = value;
			NewLateBinding.LateSet(obj, (Type)null, "TabStop", new object[1] { peremens.DaOrNet(tabStp) }, (string[])null, (Type[])null);
		}
	}

	public string Tag
	{
		get
		{
			return tg;
		}
		set
		{
			tg = value;
		}
	}

	public string Text
	{
		get
		{
			if (Operators.CompareString(NewLateBinding.LateGet(obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), peremens.ClassAplication + "TextBoks", false) == 0)
			{
				txt = Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "text", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			return txt;
		}
		set
		{
			//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04af: Expected O, but got Unknown
			if (((Operators.CompareString(txt, "-", false) == 0) & (Operators.CompareString(value, "-", false) != 0) & Iz.IsMMs(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.obj, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null)))) && Operators.CompareString(OwnerItem, peremens.trans("Никакой"), false) != 0)
			{
				if (Iz.IsTPl(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ownIt, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null))) | Iz.IsMM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ownIt, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
				{
					bool[] array3;
					if (Sep != null)
					{
						object obj = NewLateBinding.LateGet(ownIt, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array = new object[1] { RuntimeHelpers.GetObjectValue(Sep) };
						object[] array2 = array;
						array3 = new bool[1] { true };
						NewLateBinding.LateCall(obj, (Type)null, "Remove", array2, (string[])null, (Type[])null, array3, true);
						if (array3[0])
						{
							Sep = RuntimeHelpers.GetObjectValue(array[0]);
						}
					}
					object obj2 = NewLateBinding.LateGet(ownIt, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[2]
					{
						Position,
						RuntimeHelpers.GetObjectValue(this.obj)
					};
					object[] array5 = array4;
					array3 = new bool[2] { true, true };
					NewLateBinding.LateCall(obj2, (Type)null, "Insert", array5, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						Position = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
					}
					if (array3[1])
					{
						this.obj = RuntimeHelpers.GetObjectValue(array4[1]);
					}
				}
				else if (Iz.IsMMs(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ownIt, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
				{
					object[] array4;
					bool[] array3;
					if (Sep != null)
					{
						object obj3 = NewLateBinding.LateGet(ownIt, (Type)null, "DropDownItems", new object[0], (string[])null, (Type[])null, (bool[])null);
						array4 = new object[1] { RuntimeHelpers.GetObjectValue(Sep) };
						object[] array6 = array4;
						array3 = new bool[1] { true };
						NewLateBinding.LateCall(obj3, (Type)null, "Remove", array6, (string[])null, (Type[])null, array3, true);
						if (array3[0])
						{
							Sep = RuntimeHelpers.GetObjectValue(array4[0]);
						}
					}
					object obj4 = NewLateBinding.LateGet(ownIt, (Type)null, "DropDownItems", new object[0], (string[])null, (Type[])null, (bool[])null);
					array4 = new object[2]
					{
						Position,
						RuntimeHelpers.GetObjectValue(this.obj)
					};
					object[] array7 = array4;
					array3 = new bool[2] { true, true };
					NewLateBinding.LateCall(obj4, (Type)null, "Insert", array7, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						Position = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
					}
					if (array3[1])
					{
						this.obj = RuntimeHelpers.GetObjectValue(array4[1]);
					}
				}
			}
			txt = value;
			if (Iz.IsCr(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.obj, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				try
				{
					NewLateBinding.LateSet(this.obj, (Type)null, "Text", new object[1] { value }, (string[])null, (Type[])null);
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					return;
				}
			}
			NewLateBinding.LateSet(this.obj, (Type)null, "Text", new object[1] { value }, (string[])null, (Type[])null);
			checked
			{
				if (Iz.IsLLb(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.obj, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
				{
					int length = LinkLength;
					if (Operators.CompareString(LinkNam, "", false) == 0 && ((LinkStart >= 0) & (LinkStart < Text.Length)) && LinkLength > 0)
					{
						if (LinkStart + LinkLength > Text.Length)
						{
							length = Text.Length - LinkStart;
						}
						LinkNam = Text.Substring(LinkStart, length);
					}
				}
				if (!((Operators.CompareString(value, "-", false) == 0) & Iz.IsMMs(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.obj, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null)))) || Operators.CompareString(OwnerItem, peremens.trans("Никакой"), false) == 0)
				{
					return;
				}
				Sep = (object)new ToolStripSeparator();
				NewLateBinding.LateSet(Sep, (Type)null, "tag", new object[1] { RuntimeHelpers.GetObjectValue(this.obj) }, (string[])null, (Type[])null);
				if (Iz.IsTPl(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ownIt, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null))) | Iz.IsMM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ownIt, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null))) | Iz.IsCM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ownIt, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
				{
					object obj5 = NewLateBinding.LateGet(ownIt, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[2]
					{
						Position,
						RuntimeHelpers.GetObjectValue(Sep)
					};
					object[] array8 = array4;
					bool[] array3 = new bool[2] { true, true };
					NewLateBinding.LateCall(obj5, (Type)null, "Insert", array8, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						Position = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
					}
					if (array3[1])
					{
						Sep = RuntimeHelpers.GetObjectValue(array4[1]);
					}
					object obj6 = NewLateBinding.LateGet(ownIt, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
					array4 = new object[1] { RuntimeHelpers.GetObjectValue(this.obj) };
					object[] array9 = array4;
					array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj6, (Type)null, "Remove", array9, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						this.obj = RuntimeHelpers.GetObjectValue(array4[0]);
					}
				}
				else if (Iz.IsMMs(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(ownIt, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
				{
					object obj7 = NewLateBinding.LateGet(ownIt, (Type)null, "DropDownItems", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array4 = new object[2]
					{
						Position,
						RuntimeHelpers.GetObjectValue(Sep)
					};
					object[] array10 = array4;
					bool[] array3 = new bool[2] { true, true };
					NewLateBinding.LateCall(obj7, (Type)null, "Insert", array10, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						Position = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
					}
					if (array3[1])
					{
						Sep = RuntimeHelpers.GetObjectValue(array4[1]);
					}
					object obj8 = NewLateBinding.LateGet(ownIt, (Type)null, "DropDownItems", new object[0], (string[])null, (Type[])null, (bool[])null);
					array4 = new object[1] { RuntimeHelpers.GetObjectValue(this.obj) };
					object[] array11 = array4;
					array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj8, (Type)null, "Remove", array11, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						this.obj = RuntimeHelpers.GetObjectValue(array4[0]);
					}
				}
			}
		}
	}

	public string TextAlign
	{
		get
		{
			return Conversions.ToString(peremens.Aligns.GetKey(peremens.Aligns.IndexOfValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "TextAlign", new object[0], (string[])null, (Type[])null, (bool[])null)))));
		}
		set
		{
			txtAl = value;
			NewLateBinding.LateSet(obj, (Type)null, "TextAlign", new object[1] { RuntimeHelpers.GetObjectValue(peremens.Aligns.GetByIndex(peremens.Aligns.IndexOfKey(Strings.LCase(txtAl)))) }, (string[])null, (Type[])null);
		}
	}

	public string TextPosition
	{
		get
		{
			return txtPos;
		}
		set
		{
			txtPos = value;
			NewLateBinding.LateSet(obj, (Type)null, "TextAlign", new object[1] { RuntimeHelpers.GetObjectValue(peremens.TextPositions.GetByIndex(peremens.TextPositions.IndexOfKey(Strings.LCase(txtPos)))) }, (string[])null, (Type[])null);
		}
	}

	public string TextImageRelation
	{
		get
		{
			return txtImRel;
		}
		set
		{
			txtImRel = value;
			NewLateBinding.LateSet(obj, (Type)null, "TextImageRelation", new object[1] { RuntimeHelpers.GetObjectValue(peremens.TextImages.GetByIndex(peremens.TextImages.IndexOfKey(Strings.LCase(txtImRel)))) }, (string[])null, (Type[])null);
		}
	}

	public string Visible
	{
		get
		{
			return vis;
		}
		set
		{
			vis = value;
		}
	}

	public string MainForm
	{
		get
		{
			return mf;
		}
		set
		{
			mf = value;
		}
	}

	public string ForbidClose
	{
		get
		{
			return cancelCl;
		}
		set
		{
			cancelCl = value;
		}
	}

	public string ForbidMaximize
	{
		get
		{
			return mab;
		}
		set
		{
			mab = value;
		}
	}

	public string ForbidMinimize
	{
		get
		{
			return mib;
		}
		set
		{
			mib = value;
		}
	}

	public string AssociateWithExtensions
	{
		get
		{
			return AssocExts;
		}
		set
		{
			AssocExts = value;
		}
	}

	public string AssociationPassedFile
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public int Position
	{
		get
		{
			return pos;
		}
		set
		{
			pos = value;
			NewLateBinding.LateCall(obj, (Type)null, "MoveToPosition", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	public string Scroll
	{
		get
		{
			return aScrl;
		}
		set
		{
			aScrl = value;
			NewLateBinding.LateSet(obj, (Type)null, "autoScroll", new object[1] { peremens.DaOrNet(aScrl) }, (string[])null, (Type[])null);
		}
	}

	public string Checked
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "Checked", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "Checked", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public string OrientationTools
	{
		get
		{
			return orientTl;
		}
		set
		{
			orientTl = value;
			NewLateBinding.LateSet(obj, (Type)null, "LayoutStyle", new object[1] { Operators.AddObject(peremens.Orientations.GetByIndex(peremens.Orientations.IndexOfKey(Strings.LCase(orientTl))), (object)1) }, (string[])null, (Type[])null);
		}
	}

	public string Alignment
	{
		get
		{
			return alig;
		}
		set
		{
			alig = value;
			NewLateBinding.LateSet(obj, (Type)null, "Alignment", new object[1] { peremens.Int(Conversions.ToString(!peremens.DaOrNet(alig))) }, (string[])null, (Type[])null);
		}
	}

	public string AutoToolTip
	{
		get
		{
			return aTT;
		}
		set
		{
			aTT = value;
			NewLateBinding.LateSet(obj, (Type)null, "AutoToolTip", new object[1] { peremens.DaOrNet(aTT) }, (string[])null, (Type[])null);
		}
	}

	public string CheckOnClick
	{
		get
		{
			return ChOnCl;
		}
		set
		{
			ChOnCl = value;
			NewLateBinding.LateSet(obj, (Type)null, "CheckOnClick", new object[1] { peremens.DaOrNet(ChOnCl) }, (string[])null, (Type[])null);
		}
	}

	public string DisplayStyle
	{
		get
		{
			return dispSt;
		}
		set
		{
			dispSt = value;
			NewLateBinding.LateSet(obj, (Type)null, "DisplayStyle", new object[1] { RuntimeHelpers.GetObjectValue(peremens.DisplayStyles.GetByIndex(peremens.DisplayStyles.IndexOfKey(Strings.LCase(dispSt)))) }, (string[])null, (Type[])null);
		}
	}

	public string OwnerObject
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(peremens.FindOwnerContextMenu(RuntimeHelpers.GetObjectValue(obj)));
			if (objectValue == null)
			{
				objectValue = RuntimeHelpers.GetObjectValue(lastSource);
			}
			if (objectValue == null)
			{
				return peremens.trans("Никакой");
			}
			lastSource = RuntimeHelpers.GetObjectValue(objectValue);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"["), NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"]"));
		}
		set
		{
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
			{
				lastSource = null;
				return;
			}
			if (NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "getmyform", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
			{
				lastSource = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "proj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetMyObjFromUniqName", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "getmyform", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"."), (object)value) }, (string[])null, (Type[])null, (bool[])null));
			}
			if (Information.IsArray(RuntimeHelpers.GetObjectValue(lastSource)))
			{
				lastSource = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(lastSource, new object[1] { 0 }, (string[])null));
			}
			if (lastSource == null)
			{
				return;
			}
			lastSource = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(lastSource, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
			try
			{
				if (Conversions.ToDouble(Index) == 0.0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(lastSource, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ContextMenu", new object[1] { Name }, (string[])null, (Type[])null, false, true);
				}
				else
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(lastSource, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ContextMenu", new object[1] { Name + "[" + Index + "]" }, (string[])null, (Type[])null, false, true);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public string OwnerMenu
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(peremens.FindOwnerContextMenu(RuntimeHelpers.GetObjectValue(obj)));
			if (objectValue == null)
			{
				return peremens.trans("Никакой");
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"["), NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"]"));
		}
		set
		{
		}
	}

	public string OwnerItem
	{
		get
		{
			if (ownIt == null)
			{
				ownIt = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "OwnerItem", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			if (ownIt == null)
			{
				ownIt = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Owner", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			if (ownIt == null)
			{
				return peremens.trans("Никакой");
			}
			if (Operators.CompareString(ownIt.GetType().ToString(), "System.Windows.Forms.ContextMenuStrip", false) == 0)
			{
				ownIt = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "myobj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(ownIt, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(ownIt, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ownIt, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"["), NewLateBinding.LateGet(NewLateBinding.LateGet(ownIt, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"]"));
		}
		set
		{
		}
	}

	public string DropDown
	{
		get
		{
			return dm;
		}
		set
		{
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected O, but got Unknown
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) != 0)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(peremens.GetContextMenu(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null)), value));
				if (objectValue == null)
				{
					if (peremens.isRUN())
					{
						dm = value;
					}
					else
					{
						Errors.MessangeExclamen(Errors.InvalidContextMenu(value, Name));
					}
					return;
				}
				oldMenu = (ToolStripDropDownMenu)NewLateBinding.LateGet(obj, (Type)null, "DropDown", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj, (Type)null, "DropDown", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CnMn", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
			}
			else
			{
				if (fromLoad)
				{
					dm = value;
					return;
				}
				NewLateBinding.LateSet(obj, (Type)null, "DropDown", new object[1] { oldMenu }, (string[])null, (Type[])null);
			}
			dm = value;
		}
	}

	public string ImageScaling
	{
		get
		{
			return imScal;
		}
		set
		{
			imScal = value;
			NewLateBinding.LateSet(obj, (Type)null, "ImageScaling", new object[1] { peremens.Int(Conversions.ToString(!peremens.DaOrNet(imScal))) }, (string[])null, (Type[])null);
		}
	}

	public string ImageTransparentColor
	{
		get
		{
			return imTranspCol;
		}
		set
		{
			imTranspCol = value;
			if (Operators.CompareString(peremens.NikakoiEsli(imTranspCol), peremens.trans("Никакой"), false) == 0)
			{
				NewLateBinding.LateSet(obj, (Type)null, "ImageTransparentColor", new object[1] { null }, (string[])null, (Type[])null);
			}
			else
			{
				NewLateBinding.LateSet(obj, (Type)null, "ImageTransparentColor", new object[1] { peremens.FromMyColor(imTranspCol) }, (string[])null, (Type[])null);
			}
		}
	}

	public string ShortcutKeys
	{
		get
		{
			return shortK;
		}
		set
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			string[] array = value.Split(new char[1] { ';' });
			checked
			{
				int num = array.Length - 1;
				Keys val = default(Keys);
				for (int i = 0; i <= num; i++)
				{
					val = (Keys)Conversions.ToInteger(Operators.AddObject((object)val, peremens.Keyz[Strings.Trim(Strings.LCase(array[i]))]));
				}
				try
				{
					NewLateBinding.LateSet(obj, (Type)null, "ShortcutKeys", new object[1] { val }, (string[])null, (Type[])null);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					if (!peremens.IgnorEr)
					{
						Errors.MessangeCritic(Errors.InvalidKeys(value, Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null))));
					}
					ProjectData.ClearProjectError();
					return;
				}
				shortK = value;
			}
		}
	}

	public string ShowShortcutKeys
	{
		get
		{
			return shSK;
		}
		set
		{
			shSK = value;
			NewLateBinding.LateSet(obj, (Type)null, "ShowShortcutKeys", new object[1] { peremens.DaOrNet(shSK) }, (string[])null, (Type[])null);
		}
	}

	public string TextDirection
	{
		get
		{
			return txtDirc;
		}
		set
		{
			txtDirc = value;
			NewLateBinding.LateSet(obj, (Type)null, "TextDirection", new object[1] { RuntimeHelpers.GetObjectValue(peremens.TextDirections.GetByIndex(peremens.TextDirections.IndexOfKey(Strings.LCase(txtDirc)))) }, (string[])null, (Type[])null);
		}
	}

	public string ToolTipText
	{
		get
		{
			return toolTT;
		}
		set
		{
			toolTT = value;
			NewLateBinding.LateSet(obj, (Type)null, "ToolTipText", new object[1] { toolTT }, (string[])null, (Type[])null);
		}
	}

	public string TabAlignment
	{
		get
		{
			return Aligz;
		}
		set
		{
			Aligz = value;
			NewLateBinding.LateSet(obj, (Type)null, "Alignment", new object[1] { RuntimeHelpers.GetObjectValue(peremens.Alignments.GetByIndex(peremens.Alignments.IndexOfKey(Strings.LCase(Aligz)))) }, (string[])null, (Type[])null);
		}
	}

	public int SelectedTabIndex
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "selectedTab", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
		}
	}

	public int SelectedTabPosition
	{
		get
		{
			return SelTabPos;
		}
		set
		{
			SelTabPos = value;
			NewLateBinding.LateSet(obj, (Type)null, "selectedIndex", new object[1] { SelTabPos }, (string[])null, (Type[])null);
		}
	}

	public int PaddingX
	{
		get
		{
			return padX;
		}
		set
		{
			padX = value;
			object obj = this.obj;
			object[] array = new object[1];
			Point point = new Point(padX, padY);
			array[0] = point;
			NewLateBinding.LateSet(obj, (Type)null, "Padding", array, (string[])null, (Type[])null);
		}
	}

	public int PaddingY
	{
		get
		{
			return padY;
		}
		set
		{
			padY = value;
			object obj = this.obj;
			object[] array = new object[1];
			Point point = new Point(padX, padY);
			array[0] = point;
			NewLateBinding.LateSet(obj, (Type)null, "Padding", array, (string[])null, (Type[])null);
		}
	}

	public string Value
	{
		get
		{
			if (!Iz.IsM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			return val;
		}
		set
		{
			if (peremens.isRUN() & (Operators.CompareString(this.obj.GetType().ToString(), peremens.ClassAplication + "runM", false) == 0))
			{
				object obj = this.obj;
				object[] array = new object[1] { value };
				object[] array2 = array;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj, (Type)null, "RaiseChangingValue", array2, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					value = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				if (NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "myobj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "proj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[0], (string[])null, (Type[])null, (bool[])null) != null && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "myobj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "proj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[1] { Strings.UCase(peremens.MyZnak + peremens.trans("Отменить событие")) }, (string[])null, (Type[])null, (bool[])null), (object)peremens.trans("Да"), false))
				{
					return;
				}
			}
			val = value;
			if (!Iz.IsM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				try
				{
					NewLateBinding.LateSet(this.obj, (Type)null, "value", new object[1] { value }, (string[])null, (Type[])null);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (!peremens.IgnorEr)
					{
						Errors.MessangeInfo(ex2.Message);
					}
					ProjectData.ClearProjectError();
				}
			}
			if (peremens.isRUN() & (Operators.CompareString(this.obj.GetType().ToString(), peremens.ClassAplication + "runM", false) == 0))
			{
				NewLateBinding.LateCall(this.obj, (Type)null, "RaiseChangedValue", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	public string AutoRun
	{
		get
		{
			return AuRu;
		}
		set
		{
			AuRu = value;
			if (peremens.DaOrNet(AuRu) & peremens.isRUN())
			{
				string name = default(string);
				RegistryKey registryKey = peremens.GetRegistryKey("HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", ref name);
				registryKey.SetValue(Path.GetFileNameWithoutExtension(Environment.GetCommandLineArgs()[0]), Environment.GetCommandLineArgs()[0]);
			}
		}
	}

	public string AllowRunCopies
	{
		get
		{
			return AuRC;
		}
		set
		{
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			AuRC = value;
			if ((!peremens.DaOrNet(AuRC) & peremens.isRUN() & !peremens.isDevelop) && Information.UBound((Array)Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName), 1) > 0)
			{
				Interaction.MsgBox((object)peremens.trans("Программа уже запущена"), (MsgBoxStyle)48, (object)null);
				ProjectData.EndApp();
			}
		}
	}

	public string AllowInput
	{
		get
		{
			return AllInp;
		}
		set
		{
			AllInp = value;
		}
	}

	public string Focused
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Focused", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "Focused", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
		}
	}

	public string Type
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (objectValue != null)
			{
				return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "defaultName", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			return "";
		}
		set
		{
		}
	}

	public string Scroll1
	{
		get
		{
			return aScrl1;
		}
		set
		{
			aScrl1 = value;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "autoScroll", new object[1] { peremens.DaOrNet(aScrl1) }, (string[])null, (Type[])null, false, true);
		}
	}

	public string Scroll2
	{
		get
		{
			return aScrl2;
		}
		set
		{
			aScrl2 = value;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "autoScroll", new object[1] { peremens.DaOrNet(aScrl2) }, (string[])null, (Type[])null, false, true);
		}
	}

	public string FixedPanel
	{
		get
		{
			return fxPn;
		}
		set
		{
			fxPn = value;
			NewLateBinding.LateSet(obj, (Type)null, "FixedPanel", new object[1] { RuntimeHelpers.GetObjectValue(peremens.FixedPanels.GetByIndex(peremens.FixedPanels.IndexOfKey(Strings.LCase(fxPn)))) }, (string[])null, (Type[])null);
		}
	}

	public string Orientation
	{
		get
		{
			return orient;
		}
		set
		{
			orient = value;
			NewLateBinding.LateSet(obj, (Type)null, "Orientation", new object[1] { RuntimeHelpers.GetObjectValue(peremens.Orientations.GetByIndex(peremens.Orientations.IndexOfKey(Strings.LCase(orient)))) }, (string[])null, (Type[])null);
		}
	}

	public string FixedSplitter
	{
		get
		{
			return fxSplit;
		}
		set
		{
			fxSplit = value;
			NewLateBinding.LateSet(obj, (Type)null, "IsSplitterFixed", new object[1] { peremens.DaOrNet(fxSplit) }, (string[])null, (Type[])null);
		}
	}

	public string Panel1Collapsed
	{
		get
		{
			return pn1Coll;
		}
		set
		{
			pn1Coll = value;
			NewLateBinding.LateSet(obj, (Type)null, "Panel1Collapsed", new object[1] { peremens.DaOrNet(pn1Coll) }, (string[])null, (Type[])null);
		}
	}

	public string Panel2Collapsed
	{
		get
		{
			return pn2Coll;
		}
		set
		{
			pn2Coll = value;
			NewLateBinding.LateSet(obj, (Type)null, "Panel2Collapsed", new object[1] { peremens.DaOrNet(pn2Coll) }, (string[])null, (Type[])null);
		}
	}

	public int SplitterWidth
	{
		get
		{
			return splWid;
		}
		set
		{
			splWid = value;
			NewLateBinding.LateSet(obj, (Type)null, "SplitterWidth", new object[1] { splWid }, (string[])null, (Type[])null);
		}
	}

	public int SplitterDistance
	{
		get
		{
			return splDis;
		}
		set
		{
			splDis = value;
			NewLateBinding.LateSet(obj, (Type)null, "SplitterDistance", new object[1] { splDis }, (string[])null, (Type[])null);
		}
	}

	public int SplitterIncrement
	{
		get
		{
			return splInc;
		}
		set
		{
			splInc = value;
			NewLateBinding.LateSet(obj, (Type)null, "SplitterIncrement", new object[1] { splInc }, (string[])null, (Type[])null);
		}
	}

	public int Panel1MinSize
	{
		get
		{
			return pn1MinS;
		}
		set
		{
			pn1MinS = value;
			NewLateBinding.LateSet(obj, (Type)null, "Panel1MinSize", new object[1] { pn1MinS }, (string[])null, (Type[])null);
		}
	}

	public int Panel2MinSize
	{
		get
		{
			return pn2MinS;
		}
		set
		{
			pn2MinS = value;
			NewLateBinding.LateSet(obj, (Type)null, "Panel2MinSize", new object[1] { pn2MinS }, (string[])null, (Type[])null);
		}
	}

	public Control MediaWindow
	{
		get
		{
			return ctrWindow;
		}
		set
		{
			ctrWindow = value;
		}
	}

	public string FileNamePlayed
	{
		get
		{
			return peremens.GetMinPath(strFileName);
		}
		set
		{
			strFileName = peremens.GetMaxPath(value);
			if (peremens.isRUN())
			{
				CloseMovie();
			}
		}
	}

	public string Played
	{
		get
		{
			return pld;
		}
		set
		{
			pld = value;
		}
	}

	public int Volume
	{
		get
		{
			return iVolume;
		}
		set
		{
			iVolume = value;
			Balance = iBalance;
		}
	}

	public int Balance
	{
		get
		{
			return iBalance;
		}
		set
		{
			iBalance = value;
			int num = iVolume;
			int num2 = iVolume;
			checked
			{
				if (iBalance < 1000)
				{
					num = (int)Math.Round((double)iBalance * ((double)iVolume / 1000.0));
				}
				if (iBalance > 1000)
				{
					num2 = (int)Math.Round((double)(2000 - iBalance) * ((double)iVolume / 1000.0));
				}
				string lpszCommand = "setaudio " + strAlias + " left volume to " + Conversions.ToString(num2);
				string lpszReturnString = null;
				peremens.mciSendStringA(ref lpszCommand, ref lpszReturnString, 0, IntPtr.Zero);
				lpszReturnString = "setaudio " + strAlias + " right volume to " + Conversions.ToString(num);
				lpszCommand = null;
				peremens.mciSendStringA(ref lpszReturnString, ref lpszCommand, 0, IntPtr.Zero);
			}
		}
	}

	public string Mute
	{
		get
		{
			return iMute;
		}
		set
		{
			iMute = value;
			switch (peremens.DaOrNet(iMute))
			{
			case false:
			{
				string lpszReturnString = "set " + strAlias + " audio all on";
				string lpszCommand = null;
				peremens.mciSendStringA(ref lpszReturnString, ref lpszCommand, 0, IntPtr.Zero);
				break;
			}
			case true:
			{
				string lpszCommand = "set " + strAlias + " audio all off";
				string lpszReturnString = null;
				peremens.mciSendStringA(ref lpszCommand, ref lpszReturnString, 0, IntPtr.Zero);
				break;
			}
			}
		}
	}

	public int Speed
	{
		get
		{
			return iSpeed;
		}
		set
		{
			iSpeed = value;
			string lpszCommand = "SET " + strAlias + " SPEED " + Conversions.ToString(iSpeed);
			string lpszReturnString = Conversions.ToString(0L);
			peremens.mciSendStringA(ref lpszCommand, ref lpszReturnString, 0, IntPtr.Zero);
		}
	}

	public int TotalPosition
	{
		get
		{
			string lpszReturnString = Strings.Space(128);
			string lpszCommand = "SET " + strAlias + " TIME FORMAT MS";
			string lpszReturnString2 = Conversions.ToString(0L);
			peremens.mciSendStringA(ref lpszCommand, ref lpszReturnString2, 0, IntPtr.Zero);
			lpszReturnString2 = "STATUS " + strAlias + " LENGTH";
			if (peremens.mciSendStringA(ref lpszReturnString2, ref lpszReturnString, Strings.Len(lpszReturnString), IntPtr.Zero) == 0)
			{
				return Conversions.ToInteger(Strings.Trim(lpszReturnString));
			}
			return 0;
		}
	}

	public string TotalTime => peremens.ToMyTimeSpan(TotalPosition);

	public int PlayPosition
	{
		get
		{
			string lpszReturnString = Strings.Space(128);
			string lpszCommand = "STATUS " + strAlias + " POSITION";
			if (peremens.mciSendStringA(ref lpszCommand, ref lpszReturnString, Strings.Len(lpszReturnString), IntPtr.Zero) == 0)
			{
				return Conversions.ToInteger(Strings.Trim(lpszReturnString));
			}
			return 0;
		}
		set
		{
			if (bPlaying)
			{
				string lpszCommand = "PLAY " + strAlias + " FROM " + Conversions.ToString(value);
				string lpszReturnString = Conversions.ToString(0L);
				peremens.mciSendStringA(ref lpszCommand, ref lpszReturnString, 0, IntPtr.Zero);
			}
			else
			{
				string lpszReturnString = "SEEK " + strAlias + " TO " + Conversions.ToString(value);
				string lpszCommand = Conversions.ToString(0L);
				peremens.mciSendStringA(ref lpszReturnString, ref lpszCommand, 0, IntPtr.Zero);
			}
		}
	}

	public string PlayTime
	{
		get
		{
			return peremens.ToMyTimeSpan(PlayPosition);
		}
		set
		{
			value = Conversions.ToString(peremens.FromMyTimeSpan(value).TotalMilliseconds);
			PlayPosition = Conversions.ToInteger(value);
		}
	}

	public string OriginalHeight
	{
		get
		{
			string lpszReturnString = Strings.Space(128);
			string lpszCommand = "WHERE " + strAlias + " source";
			if (peremens.mciSendStringA(ref lpszCommand, ref lpszReturnString, Strings.Len(lpszReturnString), IntPtr.Zero) == 0)
			{
				string[] array = Strings.Split(Strings.Trim(lpszReturnString), " ", -1, (CompareMethod)0);
				return Conversions.ToString(new Size(Conversions.ToInteger(array[2]), Conversions.ToInteger(array[3])).Height);
			}
			return Conversions.ToString(0);
		}
		set
		{
		}
	}

	public string OriginalWidth
	{
		get
		{
			string lpszReturnString = Strings.Space(128);
			string lpszCommand = "WHERE " + strAlias + " source";
			if (peremens.mciSendStringA(ref lpszCommand, ref lpszReturnString, Strings.Len(lpszReturnString), IntPtr.Zero) == 0)
			{
				string[] array = Strings.Split(Strings.Trim(lpszReturnString), " ", -1, (CompareMethod)0);
				return Conversions.ToString(new Size(Conversions.ToInteger(array[2]), Conversions.ToInteger(array[3])).Width);
			}
			return Conversions.ToString(0);
		}
		set
		{
		}
	}

	public string OnFullScreen
	{
		get
		{
			return OnFullS;
		}
		set
		{
			OnFullS = value;
		}
	}

	public string HideSelection
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "HideSelection", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "HideSelection", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "HideSelection", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public string WordWrap
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "WordWrap", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "WordWrap", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "WordWrap", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public int MaximumLength
	{
		get
		{
			return maxLen;
		}
		set
		{
			maxLen = value;
			NewLateBinding.LateSet(obj, (Type)null, "MaxLength", new object[1] { maxLen }, (string[])null, (Type[])null);
		}
	}

	public string MultiLine
	{
		get
		{
			return MuLine;
		}
		set
		{
			MuLine = value;
			NewLateBinding.LateSet(obj, (Type)null, "MultiLine", new object[1] { peremens.DaOrNet(MuLine) }, (string[])null, (Type[])null);
		}
	}

	public string PasswordChar
	{
		get
		{
			return passCh;
		}
		set
		{
			passCh = value;
			NewLateBinding.LateSet(obj, (Type)null, "PasswordChar", new object[1] { passCh }, (string[])null, (Type[])null);
		}
	}

	public string ReadOnly
	{
		get
		{
			return rOnly;
		}
		set
		{
			rOnly = value;
			NewLateBinding.LateSet(obj, (Type)null, "ReadOnly", new object[1] { peremens.DaOrNet(rOnly) }, (string[])null, (Type[])null);
		}
	}

	public string ScrollBars
	{
		get
		{
			return scrlBars;
		}
		set
		{
			scrlBars = value;
			NewLateBinding.LateSet(obj, (Type)null, "ScrollBars", new object[1] { RuntimeHelpers.GetObjectValue(peremens.ScrollBarz.GetByIndex(peremens.ScrollBarz.IndexOfKey(Strings.LCase(scrlBars)))) }, (string[])null, (Type[])null);
		}
	}

	public string SelectedText
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "SelectedText", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "SelectedText", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string SelectionStart
	{
		get
		{
			return Conversions.ToString(Operators.AddObject(NewLateBinding.LateGet(obj, (Type)null, "SelectionStart", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		}
		set
		{
			if (Conversions.ToDouble(value) == 0.0)
			{
				value = Conversions.ToString(1);
			}
			NewLateBinding.LateSet(obj, (Type)null, "SelectionStart", new object[1] { Conversions.ToDouble(value) - 1.0 }, (string[])null, (Type[])null);
		}
	}

	public string SelectionLength
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "SelectionLength", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "SelectionLength", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string GetCharIndexFromPosition
	{
		get
		{
			object obj = this.obj;
			object[] array = new object[1];
			Point point = new Point(Conversions.ToInteger(args[0]), Conversions.ToInteger(args[1]));
			array[0] = point;
			return Conversions.ToString(Operators.AddObject(NewLateBinding.LateGet(obj, (Type)null, "GetCharIndexFromPosition", array, (string[])null, (Type[])null, (bool[])null), (object)1));
		}
		set
		{
		}
	}

	public string GetFirstCharIndexFromLine
	{
		get
		{
			if (Operators.ConditionalCompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "lines", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(Conversions.ToDouble(args[0]) - 1.0), false))
			{
				return "";
			}
			return Conversions.ToString(Operators.AddObject(NewLateBinding.LateGet(obj, (Type)null, "GetFirstCharIndexFromLine", new object[1] { Conversions.ToDouble(args[0]) - 1.0 }, (string[])null, (Type[])null, (bool[])null), (object)1));
		}
		set
		{
		}
	}

	public string GetFirstCharIndexOfCurrentLine
	{
		get
		{
			return Conversions.ToString(Operators.AddObject(NewLateBinding.LateGet(obj, (Type)null, "GetFirstCharIndexOfCurrentLine", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		}
		set
		{
		}
	}

	public string GetLineFromCharIndex
	{
		get
		{
			if (Operators.ConditionalCompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(Conversions.ToDouble(args[0]) - 1.0), false))
			{
				return "";
			}
			return Conversions.ToString(Operators.AddObject(NewLateBinding.LateGet(obj, (Type)null, "GetLineFromCharIndex", new object[1] { Conversions.ToDouble(args[0]) - 1.0 }, (string[])null, (Type[])null, (bool[])null), (object)1));
		}
		set
		{
		}
	}

	public string GetXFromCharIndex
	{
		get
		{
			if (Operators.ConditionalCompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(Conversions.ToDouble(args[0]) - 1.0), false))
			{
				return "";
			}
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "GetPositionFromCharIndex", new object[1] { Conversions.ToDouble(args[0]) - 1.0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
		}
	}

	public string GetYFromCharIndex
	{
		get
		{
			if (Operators.ConditionalCompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(Conversions.ToDouble(args[0]) - 1.0), false))
			{
				return "";
			}
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "GetPositionFromCharIndex", new object[1] { Conversions.ToDouble(args[0]) - 1.0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
		}
	}

	public string Line
	{
		get
		{
			if (Operators.ConditionalCompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Lines", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(Conversions.ToDouble(args[0]) - 1.0), false))
			{
				return "";
			}
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "Lines", new object[1] { Conversions.ToDouble(args[0]) - 1.0 }, (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
		}
	}

	public string LinesCount
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Lines", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
		}
	}

	public string Chars
	{
		get
		{
			if (Operators.ConditionalCompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(Conversions.ToDouble(args[0]) - 1.0), false))
			{
				return "";
			}
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Chars", new object[1] { Conversions.ToDouble(args[0]) - 1.0 }, (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
		}
	}

	public string CharsLength
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
		}
	}

	public string AllowNavigation
	{
		get
		{
			return allowNav;
		}
		set
		{
			allowNav = value;
			NewLateBinding.LateSet(obj, (Type)null, "AllowNavigation", new object[1] { peremens.DaOrNet(allowNav) }, (string[])null, (Type[])null);
		}
	}

	public string AllowWebBrowserDrop
	{
		get
		{
			return allowDrop;
		}
		set
		{
			allowDrop = value;
			NewLateBinding.LateSet(obj, (Type)null, "AllowWebBrowserDrop", new object[1] { peremens.DaOrNet(allowDrop) }, (string[])null, (Type[])null);
		}
	}

	public string CanGoBack
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "CanGoBack", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "CanGoBack", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
		}
	}

	public string CanGoForward
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "CanGoForward", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "CanGoForward", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
		}
	}

	public string DocumentText
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "DocumentText", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "DocumentText", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string DocumentTitle
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "DocumentTitle", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
		}
	}

	public string DocumentType
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "DocumentType", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
		}
	}

	public string isBusy
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "isBusy", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "isBusy", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
		}
	}

	public string isOffline
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "IsOffline", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "IsOffline", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
		}
	}

	public string isWebBrowserContextMunuEnabled
	{
		get
		{
			return cmBrowser;
		}
		set
		{
			cmBrowser = value;
			NewLateBinding.LateSet(obj, (Type)null, "IsWebBrowserContextMenuEnabled", new object[1] { peremens.DaOrNet(cmBrowser) }, (string[])null, (Type[])null);
		}
	}

	public string ReadyState
	{
		get
		{
			return Conversions.ToString(peremens.ReadyStates.GetKey(peremens.ReadyStates.IndexOfValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "ReadyState", new object[0], (string[])null, (Type[])null, (bool[])null)))));
		}
		set
		{
		}
	}

	public string StatusText
	{
		get
		{
			try
			{
				return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "StatusText", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}
		set
		{
		}
	}

	public string ScriptErrorsSuppressed
	{
		get
		{
			return scrpErrs;
		}
		set
		{
			scrpErrs = value;
			NewLateBinding.LateSet(obj, (Type)null, "ScriptErrorsSuppressed", new object[1] { !peremens.DaOrNet(scrpErrs) }, (string[])null, (Type[])null);
		}
	}

	public string ScrollBarsEnabled
	{
		get
		{
			return scrBarsEn;
		}
		set
		{
			scrBarsEn = value;
			NewLateBinding.LateSet(obj, (Type)null, "ScrollBarsEnabled", new object[1] { peremens.DaOrNet(scrBarsEn) }, (string[])null, (Type[])null);
		}
	}

	public string Url
	{
		get
		{
			return peremens.GetMinPath(ur);
		}
		set
		{
			ur = peremens.GetMaxPath(value);
		}
	}

	public string WebBrowserShortcutsEnabled
	{
		get
		{
			return ShCutEn;
		}
		set
		{
			ShCutEn = value;
			NewLateBinding.LateSet(obj, (Type)null, "WebBrowserShortcutsEnabled", new object[1] { peremens.DaOrNet(ShCutEn) }, (string[])null, (Type[])null);
		}
	}

	public string DocumentEncoding
	{
		get
		{
			if ((NewLateBinding.LateGet(this.obj, (Type)null, "Document", new object[0], (string[])null, (Type[])null, (bool[])null) == null) | !peremens.isRUN())
			{
				return docEnc;
			}
			SortedList documentEncodings = peremens.DocumentEncodings;
			Type typeFromHandle = typeof(Strings);
			object[] array = new object[1];
			object[] array2 = array;
			object obj = this.obj;
			object obj2 = obj;
			object[] array3 = new object[0];
			object[] array4 = array3;
			string[] array5 = null;
			array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "Document", array4, array5, (Type[])null, (bool[])null), (Type)null, "Encoding", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array6 = array;
			object[] array7 = array6;
			bool[] array8 = new bool[1] { true };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle, "LCase", array7, (string[])null, (Type[])null, array8);
			if (array8[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Document", array3, array5, (Type[])null, (bool[])null), (Type)null, "Encoding", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, true);
			}
			if (documentEncodings.IndexOfValue(RuntimeHelpers.GetObjectValue(obj3)) == -1)
			{
				return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Document", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Encoding", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			SortedList documentEncodings2 = peremens.DocumentEncodings;
			SortedList documentEncodings3 = peremens.DocumentEncodings;
			Type typeFromHandle2 = typeof(Strings);
			array6 = new object[1];
			object[] array9 = array6;
			obj = this.obj;
			object obj4 = obj;
			object[] array10 = new object[0];
			object[] array11 = array10;
			array5 = null;
			array9[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "Document", array11, array5, (Type[])null, (bool[])null), (Type)null, "Encoding", new object[0], (string[])null, (Type[])null, (bool[])null));
			array = array6;
			object[] array12 = array;
			array8 = new bool[1] { true };
			object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle2, "LCase", array12, (string[])null, (Type[])null, array8);
			if (array8[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Document", array10, array5, (Type[])null, (bool[])null), (Type)null, "Encoding", new object[1] { RuntimeHelpers.GetObjectValue(array[0]) }, (string[])null, (Type[])null, true, true);
			}
			return Conversions.ToString(documentEncodings2.GetKey(documentEncodings3.IndexOfValue(RuntimeHelpers.GetObjectValue(obj5))));
		}
		set
		{
			docEnc = value;
			if ((NewLateBinding.LateGet(obj, (Type)null, "Document", new object[0], (string[])null, (Type[])null, (bool[])null) == null) | !peremens.isRUN())
			{
				return;
			}
			if (peremens.DocumentEncodings.IndexOfKey(Strings.LCase(value)) == -1)
			{
				try
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Document", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Encoding", new object[1] { value }, (string[])null, (Type[])null, false, true);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					if (!peremens.IgnorEr)
					{
						Errors.MessangeCritic(Errors.notCollection(peremens.trans("Кодировка"), value, peremens.HWDocumentEncodings));
					}
					ProjectData.ClearProjectError();
				}
				NewLateBinding.LateCall(obj, (Type)null, "Refresh", new object[1] { (object)(WebBrowserRefreshOption)1 }, (string[])null, (Type[])null, (bool[])null, true);
			}
			else
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Document", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Encoding", new object[1] { RuntimeHelpers.GetObjectValue(peremens.DocumentEncodings.GetByIndex(peremens.DocumentEncodings.IndexOfKey(Strings.LCase(docEnc)))) }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateCall(obj, (Type)null, "Refresh", new object[1] { (object)(WebBrowserRefreshOption)1 }, (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	public string EncodingDefault
	{
		get
		{
			if (NewLateBinding.LateGet(this.obj, (Type)null, "Document", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
			{
				return "";
			}
			SortedList documentEncodings = peremens.DocumentEncodings;
			Type typeFromHandle = typeof(Strings);
			object[] array = new object[1];
			object[] array2 = array;
			object obj = this.obj;
			object obj2 = obj;
			object[] array3 = new object[0];
			object[] array4 = array3;
			string[] array5 = null;
			array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "Document", array4, array5, (Type[])null, (bool[])null), (Type)null, "DefaultEncoding", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array6 = array;
			object[] array7 = array6;
			bool[] array8 = new bool[1] { true };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle, "LCase", array7, (string[])null, (Type[])null, array8);
			if (array8[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Document", array3, array5, (Type[])null, (bool[])null), (Type)null, "DefaultEncoding", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, true);
			}
			if (documentEncodings.IndexOfValue(RuntimeHelpers.GetObjectValue(obj3)) == -1)
			{
				return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Document", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultEncoding", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			SortedList documentEncodings2 = peremens.DocumentEncodings;
			SortedList documentEncodings3 = peremens.DocumentEncodings;
			Type typeFromHandle2 = typeof(Strings);
			array6 = new object[1];
			object[] array9 = array6;
			obj = this.obj;
			object obj4 = obj;
			object[] array10 = new object[0];
			object[] array11 = array10;
			array5 = null;
			array9[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "Document", array11, array5, (Type[])null, (bool[])null), (Type)null, "DefaultEncoding", new object[0], (string[])null, (Type[])null, (bool[])null));
			array = array6;
			object[] array12 = array;
			array8 = new bool[1] { true };
			object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle2, "LCase", array12, (string[])null, (Type[])null, array8);
			if (array8[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Document", array10, array5, (Type[])null, (bool[])null), (Type)null, "DefaultEncoding", new object[1] { RuntimeHelpers.GetObjectValue(array[0]) }, (string[])null, (Type[])null, true, true);
			}
			return Conversions.ToString(documentEncodings2.GetKey(documentEncodings3.IndexOfValue(RuntimeHelpers.GetObjectValue(obj5))));
		}
		set
		{
		}
	}

	public string Cookie
	{
		get
		{
			if (NewLateBinding.LateGet(obj, (Type)null, "Document", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
			{
				return "";
			}
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Document", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Cookie", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			if (NewLateBinding.LateGet(obj, (Type)null, "Document", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Document", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Cookie", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
		}
	}

	public string OpenNewWindowLink
	{
		get
		{
			return newWin;
		}
		set
		{
			newWin = value;
		}
	}

	public string ControlBox
	{
		get
		{
			return CnBox;
		}
		set
		{
			CnBox = value;
		}
	}

	public string FormBorderStyle
	{
		get
		{
			return FrStyle;
		}
		set
		{
			FrStyle = value;
		}
	}

	public string MainMenuStrip
	{
		get
		{
			return MM;
		}
		set
		{
			MM = value;
		}
	}

	public int Opacity
	{
		get
		{
			return opac;
		}
		set
		{
			opac = value;
		}
	}

	public string ShowIcon
	{
		get
		{
			return ShIc;
		}
		set
		{
			ShIc = value;
		}
	}

	public string ShowInTaskbar
	{
		get
		{
			return ShTB;
		}
		set
		{
			ShTB = value;
		}
	}

	public string StartPosition
	{
		get
		{
			return StPos;
		}
		set
		{
			StPos = value;
		}
	}

	public string TopMost
	{
		get
		{
			return TMst;
		}
		set
		{
			TMst = value;
		}
	}

	public string WindowState
	{
		get
		{
			return WiStat;
		}
		set
		{
			WiStat = value;
		}
	}

	public int AutoScrollMinSizeWidth
	{
		get
		{
			return AutScrMinW;
		}
		set
		{
			AutScrMinW = value;
			object obj = this.obj;
			object[] array = new object[1];
			Size size = new Size(AutScrMinW, AutScrMinH);
			array[0] = size;
			NewLateBinding.LateSet(obj, (Type)null, "AutoScrollMinSize", array, (string[])null, (Type[])null);
		}
	}

	public int AutoScrollMinSizeHeight
	{
		get
		{
			return AutScrMinH;
		}
		set
		{
			AutScrMinH = value;
			object obj = this.obj;
			object[] array = new object[1];
			Size size = new Size(AutScrMinW, AutScrMinH);
			array[0] = size;
			NewLateBinding.LateSet(obj, (Type)null, "AutoScrollMinSize", array, (string[])null, (Type[])null);
		}
	}

	public int AutoScrollPositionX
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "AutoScrollPosition", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			AutScrPosX = value;
			object obj = this.obj;
			object[] array = new object[1];
			Point point = new Point(AutScrPosX, AutScrPosY);
			array[0] = point;
			NewLateBinding.LateSet(obj, (Type)null, "AutoScrollPosition", array, (string[])null, (Type[])null);
		}
	}

	public int CaptionHeight
	{
		get
		{
			if (!peremens.isRUN())
			{
				try
				{
					return Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.WindowsApplication1, (Type)null, "MainForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.WindowsApplication1, (Type)null, "MainForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClientSize", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			return Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "ClientSize", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)));
		}
		set
		{
		}
	}

	public int CaptionWidth
	{
		get
		{
			if (!peremens.isRUN())
			{
				try
				{
					return Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.WindowsApplication1, (Type)null, "MainForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.WindowsApplication1, (Type)null, "MainForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ClientSize", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			return Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(obj, (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "ClientSize", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)));
		}
		set
		{
		}
	}

	public int AutoScrollPositionY
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "AutoScrollPosition", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			AutScrPosY = value;
			object obj = this.obj;
			object[] array = new object[1];
			Point point = new Point(AutScrPosX, AutScrPosY);
			array[0] = point;
			NewLateBinding.LateSet(obj, (Type)null, "AutoScrollPosition", array, (string[])null, (Type[])null);
		}
	}

	public string Icon
	{
		get
		{
			return peremens.GetMinPath(Icn);
		}
		set
		{
			Icn = peremens.GetMaxPath(value);
		}
	}

	public string TransparentcyKey
	{
		get
		{
			return TrCol;
		}
		set
		{
			TrCol = value;
		}
	}

	public string AllowUserToAddRows
	{
		get
		{
			return AUtAR;
		}
		set
		{
			AUtAR = value;
			NewLateBinding.LateSet(obj, (Type)null, "AllowUserToAddRows", new object[1] { peremens.DaOrNet(AUtAR) }, (string[])null, (Type[])null);
		}
	}

	public string AllowUserToDeleteRows
	{
		get
		{
			return AUtDR;
		}
		set
		{
			AUtDR = value;
			NewLateBinding.LateSet(obj, (Type)null, "AllowUserToDeleteRows", new object[1] { peremens.DaOrNet(AUtDR) }, (string[])null, (Type[])null);
		}
	}

	public string AllowUserToOrderColumns
	{
		get
		{
			return AUtOC;
		}
		set
		{
			AUtOC = value;
			NewLateBinding.LateSet(obj, (Type)null, "AllowUserToOrderColumns", new object[1] { peremens.DaOrNet(AUtOC) }, (string[])null, (Type[])null);
		}
	}

	public string AllowUserToResizeColumns
	{
		get
		{
			return AUtRC;
		}
		set
		{
			AUtRC = value;
			NewLateBinding.LateSet(obj, (Type)null, "AllowUserToResizeColumns", new object[1] { peremens.DaOrNet(AUtRC) }, (string[])null, (Type[])null);
		}
	}

	public string AllowUserToResizeRows
	{
		get
		{
			return AUtRR;
		}
		set
		{
			AUtRR = value;
			NewLateBinding.LateSet(obj, (Type)null, "AllowUserToResizeRows", new object[1] { peremens.DaOrNet(AUtRR) }, (string[])null, (Type[])null);
		}
	}

	public string CellBorderStyle
	{
		get
		{
			return cBorSt;
		}
		set
		{
			cBorSt = value;
			NewLateBinding.LateSet(obj, (Type)null, "CellBorderStyle", new object[1] { RuntimeHelpers.GetObjectValue(peremens.CellBorderStyles.GetByIndex(peremens.CellBorderStyles.IndexOfKey(Strings.LCase(cBorSt)))) }, (string[])null, (Type[])null);
		}
	}

	public string ColumnHeadersVisible
	{
		get
		{
			return HeadVis;
		}
		set
		{
			HeadVis = value;
			NewLateBinding.LateSet(obj, (Type)null, "ColumnHeadersVisible", new object[1] { peremens.DaOrNet(HeadVis) }, (string[])null, (Type[])null);
		}
	}

	public string RowHeadersVisible
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "RowHeadersVisible", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "RowHeadersVisible", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "RowHeadersVisible", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public int ColumnHeadersHeight
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "ColumnHeadersHeight", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "ColumnHeadersHeight", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string Columns
	{
		get
		{
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected O, but got Unknown
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			DataGridViewColumn val = (DataGridViewColumn)NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetFirstColumn", new object[1] { (object)(DataGridViewElementStates)0 }, (string[])null, (Type[])null, (bool[])null);
			string text = "";
			while (val != null)
			{
				text = text + ", \"" + peremens.CreateKovich(val.get_HeaderText()) + "\"";
				object obj = NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array = new object[3]
				{
					val,
					(object)(DataGridViewElementStates)0,
					(object)(DataGridViewElementStates)0
				};
				bool[] array2 = new bool[3] { true, false, false };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "GetNextColumn", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					val = (DataGridViewColumn)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(DataGridViewColumn));
				}
				val = (DataGridViewColumn)obj2;
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				text = text.Substring(2);
			}
			return text;
		}
		set
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			_ = (DataGridViewColumn)NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetFirstColumn", new object[1] { (object)(DataGridViewElementStates)0 }, (string[])null, (Type[])null, (bool[])null);
			CodeString codeString = new CodeString(value, "None", withFormating: false);
			MySplitStruct mySplitStruct = codeString.Split("naOdnomUrovne", ",");
			if (NewLateBinding.LateGet(this.obj, (Type)null, "DataSource", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
			{
				NewLateBinding.LateSet(this.obj, (Type)null, "DataSource", new object[1] { null }, (string[])null, (Type[])null);
			}
			checked
			{
				int i = default(int);
				if (Operators.CompareString(mySplitStruct.texty[0], "", false) != 0)
				{
					int num = mySplitStruct.texty.Length - 1;
					for (i = 0; i <= num; i++)
					{
						mySplitStruct.texty[i] = peremens.UbratKovich(mySplitStruct.texty[i]).str;
						object[] array;
						bool[] array3;
						if (Operators.ConditionalCompareObjectLess((object)i, NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
						{
							object obj = this.obj;
							array = new object[1] { i };
							object[] array2 = array;
							array3 = new bool[1] { true };
							object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Columns", array2, (string[])null, (Type[])null, array3);
							if (array3[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
							}
							NewLateBinding.LateSetComplex(obj2, (Type)null, "HeaderText", new object[1] { mySplitStruct.texty[i] }, (string[])null, (Type[])null, false, true);
							continue;
						}
						object obj3 = NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array4 = new object[2];
						object[] array5 = array4;
						string[] texty = mySplitStruct.texty;
						int num2 = i;
						array5[0] = texty[num2];
						object[] array6 = array4;
						string[] texty2 = mySplitStruct.texty;
						int num3 = i;
						array6[1] = texty2[num3];
						array = array4;
						object[] array7 = array;
						array3 = new bool[2] { true, true };
						NewLateBinding.LateCall(obj3, (Type)null, "Add", array7, (string[])null, (Type[])null, array3, true);
						if (array3[0])
						{
							mySplitStruct.texty[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
						}
						if (array3[1])
						{
							mySplitStruct.texty[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
						}
					}
				}
				int num4 = i;
				int num5 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				int num6 = i;
				for (num4 = num5; num4 >= num6; num4 += -1)
				{
					object obj4 = NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array = new object[1] { num4 };
					object[] array8 = array;
					bool[] array3 = new bool[1] { true };
					NewLateBinding.LateCall(obj4, (Type)null, "RemoveAt", array8, (string[])null, (Type[])null, array3, true);
					if (array3[0])
					{
						num4 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
				}
			}
		}
	}

	public string Rows
	{
		get
		{
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Expected O, but got Unknown
			int num = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetFirstRow", new object[1] { (object)(DataGridViewElementStates)0 }, (string[])null, (Type[])null, (bool[])null));
			string text = "";
			checked
			{
				while (num != -1)
				{
					string text2 = "";
					object obj = this.obj;
					object[] array = new object[1] { num };
					object[] array2 = array;
					bool[] array3 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Rows", array2, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					if (Conversions.ToBoolean(NewLateBinding.LateGet(obj2, (Type)null, "IsNewRow", new object[0], (string[])null, (Type[])null, (bool[])null)))
					{
						break;
					}
					object obj3 = this.obj;
					object[] array4 = new object[1] { num };
					object[] array5 = array4;
					array3 = new bool[1] { true };
					object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "Rows", array5, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
					}
					DataGridViewCellCollection val = (DataGridViewCellCollection)NewLateBinding.LateGet(obj4, (Type)null, "Cells", new object[0], (string[])null, (Type[])null, (bool[])null);
					int num2 = ((BaseCollection)val).get_Count() - 1;
					for (int i = 0; i <= num2; i++)
					{
						object obj5 = RuntimeHelpers.GetObjectValue(val.get_Item(i).get_Value());
						if (val.get_Item(i).get_Value() == DBNull.Value)
						{
							obj5 = "";
						}
						text2 = text2 + " | \"" + peremens.CreateKovich(Conversions.ToString(obj5)) + "\"";
					}
					if (Operators.CompareString(text2, "", false) != 0)
					{
						text2 = text2.Substring(3);
					}
					text = text + ", " + text2;
					object obj6 = NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null);
					array4 = new object[2]
					{
						num,
						(object)(DataGridViewElementStates)0
					};
					object[] array6 = array4;
					array3 = new bool[2] { true, false };
					object obj7 = NewLateBinding.LateGet(obj6, (Type)null, "GetNextRow", array6, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
					}
					num = Conversions.ToInteger(obj7);
				}
				if (Operators.CompareString(text, "", false) != 0)
				{
					text = text.Substring(2);
				}
				return text;
			}
		}
		set
		{
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			CodeString codeString = new CodeString(value, "None", withFormating: false);
			MySplitStruct mySplitStruct = codeString.Split("naOdnomUrovne", ",");
			if (NewLateBinding.LateGet(this.obj, (Type)null, "DataSource", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
			{
				NewLateBinding.LateSet(this.obj, (Type)null, "DataSource", new object[1] { null }, (string[])null, (Type[])null);
			}
			NewLateBinding.LateCall(NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			DataGridViewRow[] mass = null;
			checked
			{
				int num = mySplitStruct.texty.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(mySplitStruct.texty[i], "", false) == 0)
					{
						continue;
					}
					peremens.ReDims(ref mass);
					mass[mass.Length - 1] = new DataGridViewRow();
					mass[mass.Length - 1].CreateCells((DataGridView)this.obj);
					CodeString codeString2 = new CodeString(mySplitStruct.texty[i], Conversions.ToString(false), withFormating: false);
					MySplitStruct mySplitStruct2 = codeString2.Split("naOdnomUrovne", "|");
					if (Operators.CompareString(mySplitStruct2.texty[0], "", false) == 0)
					{
						continue;
					}
					int num2 = mySplitStruct2.texty.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						mySplitStruct2.texty[j] = peremens.UbratKovich(mySplitStruct2.texty[j]).str;
						if (j < ((BaseCollection)mass[mass.Length - 1].get_Cells()).get_Count())
						{
							mass[mass.Length - 1].get_Cells().get_Item(j).set_Value((object)mySplitStruct2.texty[j]);
						}
					}
				}
				if (mass != null)
				{
					object obj = NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array = new object[1] { mass };
					bool[] array2 = new bool[1] { true };
					NewLateBinding.LateCall(obj, (Type)null, "AddRange", array, (string[])null, (Type[])null, array2, true);
					if (array2[0])
					{
						mass = (DataGridViewRow[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(DataGridViewRow[]));
					}
				}
			}
		}
	}

	public string DefaultCellStyleBackColor
	{
		get
		{
			return CSBkColor;
		}
		set
		{
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
			{
				try
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "DefaultCellStyle", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
					CSBkColor = value;
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (!peremens.IgnorEr)
					{
						Errors.MessangeExclamen(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			CSBkColor = value;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "DefaultCellStyle", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor", new object[1] { peremens.FromMyColor(CSBkColor) }, (string[])null, (Type[])null, false, true);
		}
	}

	public string DefaultCellStyleSelectionBackColor
	{
		get
		{
			return CSSBkColor;
		}
		set
		{
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
			{
				try
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "DefaultCellStyle", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionBackColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
					CSSBkColor = value;
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (!peremens.IgnorEr)
					{
						Errors.MessangeExclamen(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			CSSBkColor = value;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "DefaultCellStyle", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionBackColor", new object[1] { peremens.FromMyColor(CSSBkColor) }, (string[])null, (Type[])null, false, true);
		}
	}

	public string DefaultCellStyleForeColor
	{
		get
		{
			return CSFrColor;
		}
		set
		{
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
			{
				try
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "DefaultCellStyle", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ForeColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
					CSFrColor = value;
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (!peremens.IgnorEr)
					{
						Errors.MessangeExclamen(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			CSFrColor = value;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "DefaultCellStyle", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ForeColor", new object[1] { peremens.FromMyColor(CSFrColor) }, (string[])null, (Type[])null, false, true);
		}
	}

	public string DefaultCellStyleSelectionForeColor
	{
		get
		{
			return CSSFrColor;
		}
		set
		{
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
			{
				try
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "DefaultCellStyle", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionForeColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
					CSSFrColor = value;
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (!peremens.IgnorEr)
					{
						Errors.MessangeExclamen(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			CSSFrColor = value;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "DefaultCellStyle", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectionForeColor", new object[1] { peremens.FromMyColor(CSSFrColor) }, (string[])null, (Type[])null, false, true);
		}
	}

	public string EditMode
	{
		get
		{
			return EdMd;
		}
		set
		{
			EdMd = value;
			NewLateBinding.LateSet(obj, (Type)null, "EditMode", new object[1] { RuntimeHelpers.GetObjectValue(peremens.EditModes.GetByIndex(peremens.EditModes.IndexOfKey(Strings.LCase(EdMd)))) }, (string[])null, (Type[])null);
		}
	}

	public string GridColor
	{
		get
		{
			return GrCol;
		}
		set
		{
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
			{
				try
				{
					NewLateBinding.LateSet(obj, (Type)null, "GridColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null);
					GrCol = value;
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (!peremens.IgnorEr)
					{
						Errors.MessangeExclamen(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			GrCol = value;
			NewLateBinding.LateSet(obj, (Type)null, "GridColor", new object[1] { peremens.FromMyColor(GrCol) }, (string[])null, (Type[])null);
		}
	}

	public string MultiSelect
	{
		get
		{
			return MultSel;
		}
		set
		{
			MultSel = value;
			NewLateBinding.LateSet(obj, (Type)null, "MultiSelect", new object[1] { peremens.DaOrNet(MultSel) }, (string[])null, (Type[])null);
		}
	}

	public string ReadOnlyTable
	{
		get
		{
			return RdOlTb;
		}
		set
		{
			RdOlTb = value;
		}
	}

	public string SelectionMode
	{
		get
		{
			return SelMode;
		}
		set
		{
			SelMode = value;
			NewLateBinding.LateSet(obj, (Type)null, "SelectionMode", new object[1] { RuntimeHelpers.GetObjectValue(peremens.SelectionModes.GetByIndex(peremens.SelectionModes.IndexOfKey(Strings.LCase(SelMode)))) }, (string[])null, (Type[])null);
		}
	}

	public string SelectedRows
	{
		get
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "SelectedCells", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				return "";
			}
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "SelectedCells", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			checked
			{
				string[] mass = default(string[]);
				for (int i = 0; i <= num; i++)
				{
					bool[] array4;
					if (mass == null)
					{
						peremens.ReDims(ref mass);
						string[] array = mass;
						int num2 = mass.Length - 1;
						object obj = this.obj;
						object[] array2 = new object[1] { i };
						object[] array3 = array2;
						array4 = new bool[1] { true };
						object obj2 = NewLateBinding.LateGet(obj, (Type)null, "SelectedCells", array3, (string[])null, (Type[])null, array4);
						if (array4[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
						}
						array[num2] = Conversions.ToString(NewLateBinding.LateGet(obj2, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null));
						continue;
					}
					string[] array5 = mass;
					object obj3 = this.obj;
					object[] array6 = new object[1] { i };
					object[] array7 = array6;
					array4 = new bool[1] { true };
					object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "SelectedCells", array7, (string[])null, (Type[])null, array4);
					if (array4[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
					}
					if (Array.IndexOf<string>(array5, NewLateBinding.LateGet(obj4, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()) == -1)
					{
						peremens.ReDims(ref mass);
						string[] array8 = mass;
						int num3 = mass.Length - 1;
						object obj5 = this.obj;
						array6 = new object[1] { i };
						object[] array9 = array6;
						array4 = new bool[1] { true };
						object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "SelectedCells", array9, (string[])null, (Type[])null, array4);
						if (array4[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
						}
						array8[num3] = Conversions.ToString(NewLateBinding.LateGet(obj6, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
				}
				if (mass == null)
				{
					return "";
				}
				Array.Sort(mass);
				return Strings.Join(mass, ",");
			}
		}
		set
		{
			value = peremens.UbratKovich(value).str;
			selRows = value;
			semaforSelect = true;
			while (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "SelectedCells", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.obj, (Type)null, "SelectedCells", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
			}
			string[] array = value.Split(new char[1] { ',' });
			checked
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if ((!Iz.isInteger(ref array[i]) | (Operators.CompareString(array[i], "", false) == 0)) || !Operators.ConditionalCompareObjectLess((object)array[i], NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
					{
						continue;
					}
					string[] array2 = selCol.Split(new char[1] { ',' });
					int num2 = array2.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						if (!(!Iz.isInteger(ref array2[j]) | (Operators.CompareString(array2[j], "", false) == 0)) && Operators.ConditionalCompareObjectLess((object)array2[j], NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
						{
							object obj = this.obj;
							object[] array3 = new object[1];
							object[] array4 = array3;
							int num3 = i;
							array4[0] = array[num3];
							object[] array5 = array3;
							object[] array6 = array5;
							bool[] array7 = new bool[1] { true };
							object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Rows", array6, (string[])null, (Type[])null, array7);
							if (array7[0])
							{
								array[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
							}
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "Cells", new object[1] { Convert.ToInt16(array2[j]) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Selected", new object[1] { true }, (string[])null, (Type[])null, false, true);
						}
					}
				}
				semaforSelect = false;
			}
		}
	}

	public string SelectedColumns
	{
		get
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "SelectedCells", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				return "";
			}
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "SelectedCells", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			checked
			{
				string[] mass = default(string[]);
				for (int i = 0; i <= num; i++)
				{
					bool[] array4;
					if (mass == null)
					{
						peremens.ReDims(ref mass);
						string[] array = mass;
						int num2 = mass.Length - 1;
						object obj = this.obj;
						object[] array2 = new object[1] { i };
						object[] array3 = array2;
						array4 = new bool[1] { true };
						object obj2 = NewLateBinding.LateGet(obj, (Type)null, "SelectedCells", array3, (string[])null, (Type[])null, array4);
						if (array4[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
						}
						array[num2] = Conversions.ToString(NewLateBinding.LateGet(obj2, (Type)null, "ColumnIndex", new object[0], (string[])null, (Type[])null, (bool[])null));
						continue;
					}
					string[] array5 = mass;
					object obj3 = this.obj;
					object[] array6 = new object[1] { i };
					object[] array7 = array6;
					array4 = new bool[1] { true };
					object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "SelectedCells", array7, (string[])null, (Type[])null, array4);
					if (array4[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
					}
					if (Array.IndexOf<string>(array5, NewLateBinding.LateGet(obj4, (Type)null, "ColumnIndex", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()) == -1)
					{
						peremens.ReDims(ref mass);
						string[] array8 = mass;
						int num3 = mass.Length - 1;
						object obj5 = this.obj;
						array6 = new object[1] { i };
						object[] array9 = array6;
						array4 = new bool[1] { true };
						object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "SelectedCells", array9, (string[])null, (Type[])null, array4);
						if (array4[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
						}
						array8[num3] = Conversions.ToString(NewLateBinding.LateGet(obj6, (Type)null, "ColumnIndex", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
				}
				if (mass == null)
				{
					return "";
				}
				Array.Sort(mass);
				return Strings.Join(mass, ",");
			}
		}
		set
		{
			selCol = value;
			SelectedRows = selRows;
		}
	}

	public string ItemValue
	{
		get
		{
			args[0] = peremens.UbratKovich(args[0]).str;
			args[1] = peremens.UbratKovich(args[1]).str;
			string str = Strings.Trim(args[0].Split(new char[1] { ',' })[0]);
			string str2 = Strings.Trim(args[1].Split(new char[1] { ',' })[0]);
			string result = default(string);
			if (Conversions.ToBoolean(Operators.AndObject((object)Iz.isInteger(ref str2), Operators.CompareObjectLess((object)str2, NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), false))) && Conversions.ToBoolean(Operators.AndObject((object)Iz.isInteger(ref str), Operators.CompareObjectLess((object)str, NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), false))))
			{
				object obj = this.obj;
				object[] array = new object[1] { str };
				bool[] array2 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Rows", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					str = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj2, (Type)null, "IsNewRow", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
				{
					try
					{
						object obj3 = this.obj;
						object[] array3 = new object[1] { str };
						bool[] array4 = new bool[1] { true };
						object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "Rows", array3, (string[])null, (Type[])null, array4);
						if (array4[0])
						{
							str = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(string));
						}
						return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "Cells", new object[1] { Convert.ToInt16(str2) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						result = "";
						ProjectData.ClearProjectError();
						return result;
					}
				}
			}
			return result;
		}
		set
		{
			DataGridViewCell[] cells = getCells(args[0], args[1]);
			checked
			{
				if (cells != null)
				{
					int num = cells.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						cells[i].set_Value((object)value);
					}
				}
			}
		}
	}

	public string ItemSelected
	{
		get
		{
			DataGridViewCell[] cells = getCells(args[0], args[1]);
			checked
			{
				if (cells != null)
				{
					int num = cells.Length - 1;
					int num2 = 0;
					while (true)
					{
						if (num2 <= num)
						{
							if (!cells[num2].get_Selected())
							{
								break;
							}
							num2++;
							continue;
						}
						return peremens.DaOrNet(@bool: true);
					}
					return peremens.DaOrNet(@bool: false);
				}
				string result = default(string);
				return result;
			}
		}
		set
		{
			DataGridViewCell[] cells = getCells(args[0], args[1]);
			checked
			{
				if (cells != null)
				{
					int num = cells.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						cells[i].set_Selected(peremens.DaOrNet(value));
					}
				}
			}
		}
	}

	public string RowsReadOnly
	{
		get
		{
			DataGridViewCell[] cells = getCells(args[0], peremens.trans("Все"));
			checked
			{
				if (cells != null)
				{
					int num = cells.Length - 1;
					int num2 = 0;
					while (true)
					{
						if (num2 <= num)
						{
							if (!cells[num2].get_ReadOnly())
							{
								break;
							}
							num2++;
							continue;
						}
						return peremens.DaOrNet(@bool: true);
					}
					return peremens.DaOrNet(@bool: false);
				}
				string result = default(string);
				return result;
			}
		}
		set
		{
			DataGridViewCell[] cells = getCells(args[0], peremens.trans("Все"));
			checked
			{
				if (cells != null)
				{
					int num = cells.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						cells[i].set_ReadOnly(peremens.DaOrNet(value));
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Rows", new object[1] { cells[i].get_RowIndex() }, (string[])null, (Type[])null, (bool[])null), (Type)null, "ReadOnly", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null, false, true);
					}
				}
			}
		}
	}

	public string ColumnReadOnly
	{
		get
		{
			DataGridViewCell[] cells = getCells(peremens.trans("Все"), args[0]);
			checked
			{
				if (cells != null)
				{
					int num = cells.Length - 1;
					int num2 = 0;
					while (true)
					{
						if (num2 <= num)
						{
							if (!cells[num2].get_ReadOnly())
							{
								break;
							}
							num2++;
							continue;
						}
						return peremens.DaOrNet(@bool: true);
					}
					return peremens.DaOrNet(@bool: false);
				}
				string result = default(string);
				return result;
			}
		}
		set
		{
			DataGridViewCell[] cells = getCells(peremens.trans("Все"), args[0]);
			checked
			{
				if (cells != null)
				{
					int num = cells.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						cells[i].set_ReadOnly(peremens.DaOrNet(value));
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Columns", new object[1] { cells[i].get_ColumnIndex() }, (string[])null, (Type[])null, (bool[])null), (Type)null, "ReadOnly", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null, false, true);
					}
				}
			}
		}
	}

	public string ItemReadOnly
	{
		get
		{
			DataGridViewCell[] cells = getCells(args[0], args[1]);
			checked
			{
				if (cells != null)
				{
					int num = cells.Length - 1;
					int num2 = 0;
					while (true)
					{
						if (num2 <= num)
						{
							if (!cells[num2].get_ReadOnly())
							{
								break;
							}
							num2++;
							continue;
						}
						return peremens.DaOrNet(@bool: true);
					}
					return peremens.DaOrNet(@bool: false);
				}
				string result = default(string);
				return result;
			}
		}
		set
		{
			DataGridViewCell[] cells = getCells(args[0], args[1]);
			checked
			{
				if (cells != null)
				{
					int num = cells.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						cells[i].set_ReadOnly(peremens.DaOrNet(value));
					}
				}
			}
		}
	}

	public string ColumnsWidth
	{
		get
		{
			args[0] = peremens.UbratKovich(args[0]).str;
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Columns", new object[1] { Convert.ToInt16(Strings.Trim(args[0].Split(new char[1] { ',' })[0])) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			DataGridViewCell[] cells = getCells(Conversions.ToString(0), args[0]);
			checked
			{
				if (cells != null)
				{
					int num = cells.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Columns", new object[1] { Convert.ToInt16(cells[i].get_ColumnIndex()) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[1] { value }, (string[])null, (Type[])null, false, true);
					}
				}
			}
		}
	}

	public string RowsHeight
	{
		get
		{
			args[0] = peremens.UbratKovich(args[0]).str;
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Rows", new object[1] { Convert.ToInt16(Strings.Trim(args[0].Split(new char[1] { ',' })[0])) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			DataGridViewCell[] cells = getCells(Conversions.ToString(0), args[0]);
			checked
			{
				if (cells != null)
				{
					int num = cells.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Rows", new object[1] { Convert.ToInt16(cells[i].get_ColumnIndex()) }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[1] { value }, (string[])null, (Type[])null, false, true);
					}
				}
			}
		}
	}

	public string RowsCount
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			string text = "";
			checked
			{
				if (Operators.ConditionalCompareObjectLess((object)value, NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					int num = Conversions.ToInteger(value);
					int num2 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
					for (int i = num; i <= num2; i++)
					{
						text += Conversions.ToString(i);
						if (Operators.ConditionalCompareObjectLess((object)i, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1), false))
						{
							text += ",";
						}
					}
					RowsRemove(text);
				}
				else if (Operators.ConditionalCompareObjectGreater((object)value, NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					int num3 = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null));
					int num4 = (int)Math.Round(Conversions.ToDouble(value) - 1.0);
					for (int i = num3; i <= num4; i++)
					{
						RowsAdd("");
					}
				}
			}
		}
	}

	public string ColumnsCount
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			string text = "";
			checked
			{
				if (Operators.ConditionalCompareObjectLess((object)value, NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					int num = Conversions.ToInteger(value);
					int num2 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
					for (int i = num; i <= num2; i++)
					{
						text += Conversions.ToString(i);
						if (Operators.ConditionalCompareObjectLess((object)i, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1), false))
						{
							text += ",";
						}
					}
					ColumnsRemove(text);
				}
				else if (Operators.ConditionalCompareObjectGreater((object)value, NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					int num3 = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null));
					int num4 = (int)Math.Round(Conversions.ToDouble(value) - 1.0);
					for (int i = num3; i <= num4; i++)
					{
						ColumnsAdd("", "");
					}
				}
			}
		}
	}

	public string SelectedRowsCount
	{
		get
		{
			string selectedRows = SelectedRows;
			if (Operators.CompareString(selectedRows, "", false) == 0)
			{
				return Conversions.ToString(0);
			}
			return Conversions.ToString(selectedRows.Split(new char[1] { ',' }).Length);
		}
		set
		{
		}
	}

	public string SelectedColumnsCount
	{
		get
		{
			string selectedColumns = SelectedColumns;
			if (Operators.CompareString(selectedColumns, "", false) == 0)
			{
				return Conversions.ToString(0);
			}
			return Conversions.ToString(selectedColumns.Split(new char[1] { ',' }).Length);
		}
		set
		{
		}
	}

	public string WidthOfColumns
	{
		get
		{
			string text = "";
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string text2 = text;
				object obj = this.obj;
				object[] array = new object[1] { i };
				bool[] array2 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Columns", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				text = Conversions.ToString(Operators.ConcatenateObject((object)text2, NewLateBinding.LateGet(obj2, (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)));
				if (Operators.ConditionalCompareObjectLess((object)i, Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1), false))
				{
					text += ",";
				}
			}
			return text;
		}
		set
		{
			colsWids = value;
			string[] array = value.Split(new char[1] { ',' });
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				int num2;
				if (i < array.Length)
				{
					array[i] = array[i].Trim();
					num2 = ((!((Operators.CompareString(array[i], "", false) == 0) | !Versioned.IsNumeric((object)array[i]))) ? Conversions.ToInteger(array[i]) : 100);
				}
				else
				{
					num2 = 100;
				}
				object obj = this.obj;
				object[] array2 = new object[1] { i };
				bool[] array3 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Columns", array2, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
				}
				NewLateBinding.LateSetComplex(obj2, (Type)null, "Width", new object[1] { num2 }, (string[])null, (Type[])null, false, true);
			}
		}
	}

	public string HeightOfRows
	{
		get
		{
			string text = "";
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string text2 = text;
				object obj = this.obj;
				object[] array = new object[1] { i };
				bool[] array2 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Rows", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				text = Conversions.ToString(Operators.ConcatenateObject((object)text2, NewLateBinding.LateGet(obj2, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)));
				if (Operators.ConditionalCompareObjectLess((object)i, Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1), false))
				{
					text += ",";
				}
			}
			return text;
		}
		set
		{
			rowsH = value;
			string[] array = value.Split(new char[1] { ',' });
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				int num2;
				if (i < array.Length)
				{
					array[i] = array[i].Trim();
					num2 = ((!((Operators.CompareString(array[i], "", false) == 0) | !Versioned.IsNumeric((object)array[i]))) ? Conversions.ToInteger(array[i]) : Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				else
				{
					num2 = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null));
				}
				object obj = this.obj;
				object[] array2 = new object[1] { i };
				bool[] array3 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Rows", array2, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
				}
				NewLateBinding.LateSetComplex(obj2, (Type)null, "Height", new object[1] { num2 }, (string[])null, (Type[])null, false, true);
			}
		}
	}

	public string SelectedItemsValue
	{
		get
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			string text = "";
			DataGridViewCell[] sortCells = getSortCells((DataGridViewSelectedCellCollection)NewLateBinding.LateGet(obj, (Type)null, "SelectedCells", new object[0], (string[])null, (Type[])null, (bool[])null));
			checked
			{
				int num = sortCells.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					text = Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject(Operators.ConcatenateObject((object)"\"", sortCells[i].get_Value()), (object)"\"")));
					if (i < sortCells.Length - 1)
					{
						text += ",";
					}
				}
				return text;
			}
		}
		set
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			string value2 = "";
			DataGridViewCell[] sortCells = getSortCells((DataGridViewSelectedCellCollection)NewLateBinding.LateGet(obj, (Type)null, "SelectedCells", new object[0], (string[])null, (Type[])null, (bool[])null));
			CodeString codeString = new CodeString(value, "None", withFormating: false);
			MySplitStruct mySplitStruct = codeString.Split("naOdnomUrovne", ",");
			checked
			{
				int num = sortCells.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (mySplitStruct.texty.Length > i)
					{
						value2 = peremens.UbratKovich(mySplitStruct.texty[i]).str;
					}
					sortCells[i].set_Value((object)value2);
				}
			}
		}
	}

	public int DropDownHeight
	{
		get
		{
			return DrDnHeight;
		}
		set
		{
			DrDnHeight = value;
			NewLateBinding.LateSet(obj, (Type)null, "DropDownHeight", new object[1] { DrDnHeight }, (string[])null, (Type[])null);
		}
	}

	public int DropDownWidth
	{
		get
		{
			return DrDnWidth;
		}
		set
		{
			DrDnWidth = value;
			NewLateBinding.LateSet(obj, (Type)null, "DropDownWidth", new object[1] { DrDnWidth }, (string[])null, (Type[])null);
		}
	}

	public string DropDownStyle
	{
		get
		{
			return DrDnStyl;
		}
		set
		{
			DrDnStyl = value;
			if (peremens.DaOrNet(DrDnStyl))
			{
				NewLateBinding.LateSet(obj, (Type)null, "DropDownStyle", new object[1] { (object)(ComboBoxStyle)1 }, (string[])null, (Type[])null);
			}
			else
			{
				NewLateBinding.LateSet(obj, (Type)null, "DropDownStyle", new object[1] { (object)(ComboBoxStyle)2 }, (string[])null, (Type[])null);
			}
		}
	}

	public int ItemHeight
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "ItemHeight", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
		}
	}

	public string Items
	{
		get
		{
			string text = "";
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string text2 = text;
				object obj = this.obj;
				object[] array = new object[1] { i };
				bool[] array2 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "items", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				text = text2 + ", \"" + peremens.CreateKovich(Conversions.ToString(obj2)) + "\"";
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				text = text.Substring(2);
			}
			return text;
		}
		set
		{
			CodeString codeString = new CodeString(value, "None", withFormating: false);
			MySplitStruct mySplitStruct = codeString.Split("naOdnomUrovne", ",");
			checked
			{
				int num = mySplitStruct.texty.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					mySplitStruct.texty[i] = peremens.UbratKovich(mySplitStruct.texty[i]).str;
				}
				NewLateBinding.LateCall(NewLateBinding.LateGet(this.obj, (Type)null, "items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				object obj = NewLateBinding.LateGet(this.obj, (Type)null, "items", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array = new object[1] { mySplitStruct.texty };
				object[] array2 = array;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj, (Type)null, "addrange", array2, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					mySplitStruct.texty = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string[]));
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.obj, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "text", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "text", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
			}
		}
	}

	public int MaxDropDownItems
	{
		get
		{
			return MaxDrDn;
		}
		set
		{
			MaxDrDn = value;
			NewLateBinding.LateSet(obj, (Type)null, "MaxDropDownItems", new object[1] { MaxDrDn }, (string[])null, (Type[])null);
		}
	}

	public string Sorted
	{
		get
		{
			return Srtd;
		}
		set
		{
			Srtd = value;
			NewLateBinding.LateSet(obj, (Type)null, "Sorted", new object[1] { peremens.DaOrNet(Srtd) }, (string[])null, (Type[])null);
		}
	}

	public string DroppedDown
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "DroppedDown", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "DroppedDown", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "DroppedDown", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public int SelectedIndex
	{
		get
		{
			return selIn;
		}
		set
		{
			selIn = value;
			if ((!Iz.IsL(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "myobj", new object[0], (string[])null, (Type[])null, (bool[])null))) || !Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "selectionmode", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false)) && selIn >= 0)
			{
				NewLateBinding.LateSet(obj, (Type)null, "SelectedIndex", new object[1] { selIn }, (string[])null, (Type[])null);
			}
		}
	}

	public string SelectedItem
	{
		get
		{
			return selIt;
		}
		set
		{
			selIt = value;
			if (!Iz.IsL(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "myobj", new object[0], (string[])null, (Type[])null, (bool[])null))) || !Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "selectionmode", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				NewLateBinding.LateSet(obj, (Type)null, "SelectedItem", new object[1] { selIt }, (string[])null, (Type[])null);
			}
		}
	}

	public string ItemsItem
	{
		get
		{
			object obj = NewLateBinding.LateGet(this.obj, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[1];
			int num = 0;
			array[0] = args[0];
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Item", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Item", new object[2]
			{
				args[0],
				value
			}, (string[])null, (Type[])null, false, true);
		}
	}

	public string ItemsIndexOf
	{
		get
		{
			object obj = NewLateBinding.LateGet(this.obj, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[1];
			int num = 0;
			array[0] = args[0];
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "IndexOf", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
			}
			return Conversions.ToString(obj2);
		}
		set
		{
		}
	}

	public int ItemsCount
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
		}
	}

	public int ColumnWidth
	{
		get
		{
			return colWid;
		}
		set
		{
			colWid = value;
			NewLateBinding.LateSet(obj, (Type)null, "ColumnWidth", new object[1] { colWid }, (string[])null, (Type[])null);
		}
	}

	public string HorizontalScrollBar
	{
		get
		{
			return HorScBar;
		}
		set
		{
			HorScBar = value;
			NewLateBinding.LateSet(obj, (Type)null, "HorizontalScrollBar", new object[1] { peremens.DaOrNet(HorScBar) }, (string[])null, (Type[])null);
		}
	}

	public string MultiColumn
	{
		get
		{
			return multCol;
		}
		set
		{
			multCol = value;
			NewLateBinding.LateSet(obj, (Type)null, "MultiColumn", new object[1] { peremens.DaOrNet(multCol) }, (string[])null, (Type[])null);
		}
	}

	public string SelectionModeList
	{
		get
		{
			return selModeList;
		}
		set
		{
			selModeList = value;
			if (peremens.DaOrNet(selModeList))
			{
				NewLateBinding.LateSet(obj, (Type)null, "SelectionMode", new object[1] { (object)(SelectionMode)1 }, (string[])null, (Type[])null);
			}
			else
			{
				NewLateBinding.LateSet(obj, (Type)null, "SelectionMode", new object[1] { (object)(SelectionMode)0 }, (string[])null, (Type[])null);
			}
		}
	}

	public string CheckedIndices
	{
		get
		{
			string text = "";
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "CheckedIndices", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string text2 = text;
				object obj = this.obj;
				object[] array = new object[1] { i };
				bool[] array2 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "CheckedIndices", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				text = Conversions.ToString(Operators.ConcatenateObject((object)text2, Operators.ConcatenateObject((object)", ", obj2)));
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				text = text.Substring(2);
			}
			return text;
		}
		set
		{
		}
	}

	public string CheckedItems
	{
		get
		{
			string text = "";
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "CheckedItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string text2 = text;
				object obj = this.obj;
				object[] array = new object[1] { i };
				bool[] array2 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "CheckedItems", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				text = text2 + ", \"" + peremens.CreateKovich(Conversions.ToString(obj2)) + "\"";
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				text = text.Substring(2);
			}
			return text;
		}
		set
		{
		}
	}

	public string SelectedIndices
	{
		get
		{
			string text = "";
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "SelectedIndices", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string text2 = text;
				object obj = this.obj;
				object[] array = new object[1] { i };
				bool[] array2 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "SelectedIndices", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				text = Conversions.ToString(Operators.ConcatenateObject((object)text2, Operators.ConcatenateObject((object)", ", obj2)));
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				text = text.Substring(2);
			}
			return text;
		}
		set
		{
		}
	}

	public string SelectedItems
	{
		get
		{
			string text = "";
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "SelectedItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string text2 = text;
				object obj = this.obj;
				object[] array = new object[1] { i };
				bool[] array2 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "SelectedItems", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				text = text2 + ", \"" + peremens.CreateKovich(Conversions.ToString(obj2)) + "\"";
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				text = text.Substring(2);
			}
			return text;
		}
		set
		{
		}
	}

	public string ActiveLinkColor
	{
		get
		{
			return ActLinkCol;
		}
		set
		{
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
			{
				try
				{
					NewLateBinding.LateSet(obj, (Type)null, "ActiveLinkColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null);
					ActLinkCol = value;
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (!peremens.IgnorEr)
					{
						Errors.MessangeExclamen(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			ActLinkCol = value;
			NewLateBinding.LateSet(obj, (Type)null, "ActiveLinkColor", new object[1] { peremens.FromMyColor(ActLinkCol) }, (string[])null, (Type[])null);
		}
	}

	public string DisabledLinkColor
	{
		get
		{
			return DisLiCol;
		}
		set
		{
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
			{
				try
				{
					NewLateBinding.LateSet(obj, (Type)null, "DisabledLinkColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null);
					DisLiCol = value;
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (!peremens.IgnorEr)
					{
						Errors.MessangeExclamen(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			DisLiCol = value;
			NewLateBinding.LateSet(obj, (Type)null, "DisabledLinkColor", new object[1] { peremens.FromMyColor(DisLiCol) }, (string[])null, (Type[])null);
		}
	}

	public string LinkColor
	{
		get
		{
			return LiCo;
		}
		set
		{
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
			{
				try
				{
					NewLateBinding.LateSet(obj, (Type)null, "LinkColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null);
					LiCo = value;
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (!peremens.IgnorEr)
					{
						Errors.MessangeExclamen(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			LiCo = value;
			NewLateBinding.LateSet(obj, (Type)null, "LinkColor", new object[1] { peremens.FromMyColor(LiCo) }, (string[])null, (Type[])null);
		}
	}

	public string VisitedLinkColor
	{
		get
		{
			return VisLiCol;
		}
		set
		{
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
			{
				try
				{
					NewLateBinding.LateSet(obj, (Type)null, "VisitedLinkColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null);
					VisLiCol = value;
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (!peremens.IgnorEr)
					{
						Errors.MessangeExclamen(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			VisLiCol = value;
			NewLateBinding.LateSet(obj, (Type)null, "VisitedLinkColor", new object[1] { peremens.FromMyColor(VisLiCol) }, (string[])null, (Type[])null);
		}
	}

	public int LinkStart
	{
		get
		{
			return LiSt;
		}
		set
		{
			LiSt = value;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Links", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Start", new object[1] { LiSt }, (string[])null, (Type[])null, false, true);
		}
	}

	public int LinkLength
	{
		get
		{
			return LiLe;
		}
		set
		{
			LiLe = value;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Links", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[1] { LiLe }, (string[])null, (Type[])null, false, true);
		}
	}

	public string LinkBehavior
	{
		get
		{
			return LinBeh;
		}
		set
		{
			LinBeh = value;
			NewLateBinding.LateSet(obj, (Type)null, "LinkBehavior", new object[1] { RuntimeHelpers.GetObjectValue(peremens.LinkBehaviors.GetByIndex(peremens.LinkBehaviors.IndexOfKey(Strings.LCase(LinBeh)))) }, (string[])null, (Type[])null);
		}
	}

	public string LinkVisited
	{
		get
		{
			return LiVis;
		}
		set
		{
			LiVis = value;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Links", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visited", new object[1] { peremens.DaOrNet(LiVis) }, (string[])null, (Type[])null, false, true);
		}
	}

	public string LinkEnabled
	{
		get
		{
			return LiEn;
		}
		set
		{
			LiEn = value;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Links", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Enabled", new object[1] { peremens.DaOrNet(LiEn) }, (string[])null, (Type[])null, false, true);
		}
	}

	public string InternetLink
	{
		get
		{
			return InetLin;
		}
		set
		{
			InetLin = value;
		}
	}

	public string LinkName
	{
		get
		{
			return LinkNam;
		}
		set
		{
			LinkNam = value;
		}
	}

	public string DetectUrls
	{
		get
		{
			return DetUr;
		}
		set
		{
			DetUr = value;
			NewLateBinding.LateSet(obj, (Type)null, "DetectUrls", new object[1] { peremens.DaOrNet(DetUr) }, (string[])null, (Type[])null);
		}
	}

	public string EnableAutoDragDrop
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "EnableAutoDragDrop", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "EnableAutoDragDrop", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "EnableAutoDragDrop", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public int ZoomFactor
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "ZoomFactor", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "ZoomFactor", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string Rtf
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "Rtf", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			try
			{
				NewLateBinding.LateSet(obj, (Type)null, "Rtf", new object[1] { value }, (string[])null, (Type[])null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Errors.MessangeCritic(ex2.Message + " " + peremens.trans("Ошибка в написании RTF кода."));
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public string SelectedRtf
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "SelectedRtf", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "SelectedRtf", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string SelectionAlignment
	{
		get
		{
			return Conversions.ToString(peremens.TextPositions.GetKey(peremens.TextPositions.IndexOfValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "SelectionAlignment", new object[0], (string[])null, (Type[])null, (bool[])null)))));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "SelectionAlignment", new object[1] { RuntimeHelpers.GetObjectValue(peremens.TextPositions.GetByIndex(peremens.TextPositions.IndexOfKey(Strings.LCase(value)))) }, (string[])null, (Type[])null);
		}
	}

	public string SelectionBackColor
	{
		get
		{
			object obj = NewLateBinding.LateGet(this.obj, (Type)null, "SelectionBackColor", new object[0], (string[])null, (Type[])null, (bool[])null);
			Color color = default(Color);
			return peremens.ToMyColor((obj != null) ? ((Color)obj) : color);
		}
		set
		{
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
			{
				try
				{
					NewLateBinding.LateSet(obj, (Type)null, "SelectionBackColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null);
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (!peremens.IgnorEr)
					{
						Errors.MessangeExclamen(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			NewLateBinding.LateSet(obj, (Type)null, "SelectionBackColor", new object[1] { peremens.FromMyColor(value) }, (string[])null, (Type[])null);
		}
	}

	public string SelectionColor
	{
		get
		{
			object obj = NewLateBinding.LateGet(this.obj, (Type)null, "SelectionColor", new object[0], (string[])null, (Type[])null, (bool[])null);
			Color color = default(Color);
			return peremens.ToMyColor((obj != null) ? ((Color)obj) : color);
		}
		set
		{
			if (Operators.CompareString(peremens.NikakoiEsli(value), peremens.trans("Никакой"), false) == 0)
			{
				try
				{
					NewLateBinding.LateSet(obj, (Type)null, "SelectionColor", new object[1] { Color.Transparent }, (string[])null, (Type[])null);
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (!peremens.IgnorEr)
					{
						Errors.MessangeExclamen(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			NewLateBinding.LateSet(obj, (Type)null, "SelectionColor", new object[1] { peremens.FromMyColor(value) }, (string[])null, (Type[])null);
		}
	}

	public int SelectionHangingIndent
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "SelectionHangingIndent", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "SelectionHangingIndent", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public int SelectionIndent
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "SelectionIndent", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "SelectionIndent", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public int SelectionRightIndent
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "SelectionRightIndent", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "SelectionRightIndent", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string SelectionBullet
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "SelectionBullet", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "SelectionBullet", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "SelectionBullet", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public int SelectionCharOffset
	{
		get
		{
			return Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "SelectionCharOffset", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "SelectionCharOffset", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string SelectionFontFamily
	{
		get
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			Font val = (Font)NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null);
			if (val == null)
			{
				int num = Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "SelectionLength", new object[0], (string[])null, (Type[])null, (bool[])null));
				NewLateBinding.LateSet(obj, (Type)null, "SelectionLength", new object[1] { 1 }, (string[])null, (Type[])null);
				val = (Font)NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj, (Type)null, "SelectionLength", new object[1] { num }, (string[])null, (Type[])null);
			}
			if (val == null)
			{
				return "";
			}
			if (peremens.Fonts.IndexOfKey(Strings.LCase(val.get_FontFamily().get_Name())) == -1)
			{
				return "";
			}
			return Conversions.ToString(peremens.Fonts.GetValueList()[peremens.Fonts.IndexOfKey(Strings.LCase(val.get_FontFamily().get_Name()))]);
		}
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Expected O, but got Unknown
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			Font val = (Font)NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null);
			if (val == null)
			{
				int num = Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "SelectionLength", new object[0], (string[])null, (Type[])null, (bool[])null));
				NewLateBinding.LateSet(obj, (Type)null, "SelectionLength", new object[1] { 1 }, (string[])null, (Type[])null);
				val = (Font)NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj, (Type)null, "SelectionLength", new object[1] { num }, (string[])null, (Type[])null);
			}
			if (val == null)
			{
				return;
			}
			try
			{
				NewLateBinding.LateSet(obj, (Type)null, "SelectionFont", new object[1] { (object)new Font(peremens.Fonts.GetByIndex(peremens.Fonts.IndexOfKey(Strings.LCase(value)))!.ToString(), val.get_Size(), val.get_Style()) }, (string[])null, (Type[])null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Interaction.MsgBox((object)(Errors.FontNotSupport(value) + "\r\n" + ex2.Message), (MsgBoxStyle)48, (object)null);
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public string SelectionFontBold
	{
		get
		{
			if (NewLateBinding.LateGet(this.obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
			{
				return "";
			}
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			object[] array2 = new object[0];
			string[] array3 = null;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", array2, array3, (Type[])null, (bool[])null), (Type)null, "Bold", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array4 = array;
			bool[] array5 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array4, (string[])null, (Type[])null, array5);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", array2, array3, (Type[])null, (bool[])null), (Type)null, "Bold", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, true);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected O, but got Unknown
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			Font val = (Font)NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null);
			if (val == null)
			{
				int num = Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "SelectionLength", new object[0], (string[])null, (Type[])null, (bool[])null));
				NewLateBinding.LateSet(obj, (Type)null, "SelectionLength", new object[1] { 1 }, (string[])null, (Type[])null);
				val = (Font)NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj, (Type)null, "SelectionLength", new object[1] { num }, (string[])null, (Type[])null);
			}
			if (val == null)
			{
				return;
			}
			FontStyle val2 = (FontStyle)checked(peremens.Int(Conversions.ToString(peremens.DaOrNet(value))) * 1 + peremens.Int(Conversions.ToString(val.get_Italic())) * 2 + peremens.Int(Conversions.ToString(val.get_Underline())) * 4 + peremens.Int(Conversions.ToString(val.get_Strikeout())) * 8);
			try
			{
				NewLateBinding.LateSet(obj, (Type)null, "SelectionFont", new object[1] { (object)new Font(val.get_FontFamily(), val.get_Size(), val2) }, (string[])null, (Type[])null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Interaction.MsgBox((object)(Errors.FontNotSupport(val.get_FontFamily().ToString()) + "\r\n" + ex2.Message), (MsgBoxStyle)48, (object)null);
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public string SelectionFontItalic
	{
		get
		{
			if (NewLateBinding.LateGet(this.obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
			{
				return "";
			}
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			object[] array2 = new object[0];
			string[] array3 = null;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", array2, array3, (Type[])null, (bool[])null), (Type)null, "Italic", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array4 = array;
			bool[] array5 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array4, (string[])null, (Type[])null, array5);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", array2, array3, (Type[])null, (bool[])null), (Type)null, "Italic", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, true);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected O, but got Unknown
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			Font val = (Font)NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null);
			if (val == null)
			{
				int num = Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "SelectionLength", new object[0], (string[])null, (Type[])null, (bool[])null));
				NewLateBinding.LateSet(obj, (Type)null, "SelectionLength", new object[1] { 1 }, (string[])null, (Type[])null);
				val = (Font)NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj, (Type)null, "SelectionLength", new object[1] { num }, (string[])null, (Type[])null);
			}
			if (val == null)
			{
				return;
			}
			FontStyle val2 = (FontStyle)checked(peremens.Int(Conversions.ToString(val.get_Bold())) * 1 + peremens.Int(Conversions.ToString(peremens.DaOrNet(value))) * 2 + peremens.Int(Conversions.ToString(val.get_Underline())) * 4 + peremens.Int(Conversions.ToString(val.get_Strikeout())) * 8);
			try
			{
				NewLateBinding.LateSet(obj, (Type)null, "SelectionFont", new object[1] { (object)new Font(val.get_FontFamily(), val.get_Size(), val2) }, (string[])null, (Type[])null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Interaction.MsgBox((object)(Errors.FontNotSupport(val.get_FontFamily().ToString()) + "\r\n" + ex2.Message), (MsgBoxStyle)48, (object)null);
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public string SelectionFontUnderline
	{
		get
		{
			if (NewLateBinding.LateGet(this.obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
			{
				return "";
			}
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			object[] array2 = new object[0];
			string[] array3 = null;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", array2, array3, (Type[])null, (bool[])null), (Type)null, "Underline", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array4 = array;
			bool[] array5 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array4, (string[])null, (Type[])null, array5);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", array2, array3, (Type[])null, (bool[])null), (Type)null, "Underline", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, true);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected O, but got Unknown
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			Font val = (Font)NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null);
			if (val == null)
			{
				int num = Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "SelectionLength", new object[0], (string[])null, (Type[])null, (bool[])null));
				NewLateBinding.LateSet(obj, (Type)null, "SelectionLength", new object[1] { 1 }, (string[])null, (Type[])null);
				val = (Font)NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj, (Type)null, "SelectionLength", new object[1] { num }, (string[])null, (Type[])null);
			}
			if (val == null)
			{
				return;
			}
			FontStyle val2 = (FontStyle)checked(peremens.Int(Conversions.ToString(val.get_Bold())) * 1 + peremens.Int(Conversions.ToString(val.get_Italic())) * 2 + peremens.Int(Conversions.ToString(peremens.DaOrNet(value))) * 4 + peremens.Int(Conversions.ToString(val.get_Strikeout())) * 8);
			try
			{
				NewLateBinding.LateSet(obj, (Type)null, "SelectionFont", new object[1] { (object)new Font(val.get_FontFamily(), val.get_Size(), val2) }, (string[])null, (Type[])null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Interaction.MsgBox((object)(Errors.FontNotSupport(val.get_FontFamily().ToString()) + "\r\n" + ex2.Message), (MsgBoxStyle)48, (object)null);
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public string SelectionFontStrikeout
	{
		get
		{
			if (NewLateBinding.LateGet(this.obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
			{
				return "";
			}
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			object[] array2 = new object[0];
			string[] array3 = null;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", array2, array3, (Type[])null, (bool[])null), (Type)null, "Strikeout", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array4 = array;
			bool[] array5 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array4, (string[])null, (Type[])null, array5);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", array2, array3, (Type[])null, (bool[])null), (Type)null, "Strikeout", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, true);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected O, but got Unknown
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			Font val = (Font)NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null);
			if (val == null)
			{
				int num = Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "SelectionLength", new object[0], (string[])null, (Type[])null, (bool[])null));
				NewLateBinding.LateSet(obj, (Type)null, "SelectionLength", new object[1] { 1 }, (string[])null, (Type[])null);
				val = (Font)NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj, (Type)null, "SelectionLength", new object[1] { num }, (string[])null, (Type[])null);
			}
			if (val == null)
			{
				return;
			}
			FontStyle val2 = (FontStyle)checked(peremens.Int(Conversions.ToString(val.get_Bold())) * 1 + peremens.Int(Conversions.ToString(val.get_Italic())) * 2 + peremens.Int(Conversions.ToString(val.get_Underline())) * 4 + peremens.Int(Conversions.ToString(peremens.DaOrNet(value))) * 8);
			try
			{
				NewLateBinding.LateSet(obj, (Type)null, "SelectionFont", new object[1] { (object)new Font(val.get_FontFamily(), val.get_Size(), val2) }, (string[])null, (Type[])null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Interaction.MsgBox((object)(Errors.FontNotSupport(val.get_FontFamily().ToString()) + "\r\n" + ex2.Message), (MsgBoxStyle)48, (object)null);
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public int SelectionFontSize
	{
		get
		{
			if (NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
			{
				return Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "size", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			return Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "size", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected O, but got Unknown
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			Font val = (Font)NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null);
			if (val == null)
			{
				int num = Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "SelectionLength", new object[0], (string[])null, (Type[])null, (bool[])null));
				NewLateBinding.LateSet(obj, (Type)null, "SelectionLength", new object[1] { 1 }, (string[])null, (Type[])null);
				val = (Font)NewLateBinding.LateGet(obj, (Type)null, "SelectionFont", new object[0], (string[])null, (Type[])null, (bool[])null);
				NewLateBinding.LateSet(obj, (Type)null, "SelectionLength", new object[1] { num }, (string[])null, (Type[])null);
			}
			if (val == null)
			{
				return;
			}
			try
			{
				NewLateBinding.LateSet(obj, (Type)null, "SelectionFont", new object[1] { (object)new Font(val.get_FontFamily().get_Name().ToString(), (float)value, val.get_Style()) }, (string[])null, (Type[])null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!peremens.IgnorEr)
				{
					Interaction.MsgBox((object)(Errors.FontNotSupport(Conversions.ToString(value)) + "\r\n" + ex2.Message), (MsgBoxStyle)48, (object)null);
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public string SelectionProtected
	{
		get
		{
			if (NewLateBinding.LateGet(this.obj, (Type)null, "SelectionProtected", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
			{
				return "";
			}
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "SelectionProtected", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "SelectionProtected", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "SelectionProtected", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public string DialogColor
	{
		get
		{
			return dCol;
		}
		set
		{
			dCol = value;
		}
	}

	public string WasCancel
	{
		get
		{
			return cnl;
		}
		set
		{
			cnl = value;
		}
	}

	public string ShowColor
	{
		get
		{
			return ShCols;
		}
		set
		{
			ShCols = value;
		}
	}

	public string ShowEffects
	{
		get
		{
			return ShEff;
		}
		set
		{
			ShEff = value;
		}
	}

	public string Description
	{
		get
		{
			return descr;
		}
		set
		{
			descr = value;
		}
	}

	public string SelectedPath
	{
		get
		{
			return sePath;
		}
		set
		{
			sePath = value;
		}
	}

	public string DefaultExt
	{
		get
		{
			return defEx;
		}
		set
		{
			defEx = value;
		}
	}

	public string CheckFileExists
	{
		get
		{
			return ChFEx;
		}
		set
		{
			ChFEx = value;
		}
	}

	public string CheckPathExists
	{
		get
		{
			return ChPEx;
		}
		set
		{
			ChPEx = value;
		}
	}

	public string FileName
	{
		get
		{
			return flNm;
		}
		set
		{
			flNm = value;
		}
	}

	public string Filter
	{
		get
		{
			return fltr;
		}
		set
		{
			fltr = value;
		}
	}

	public int FilterIndex
	{
		get
		{
			return flIn;
		}
		set
		{
			flIn = value;
		}
	}

	public string InitialDirectory
	{
		get
		{
			return iniDir;
		}
		set
		{
			iniDir = value;
		}
	}

	public string Title
	{
		get
		{
			return ttl;
		}
		set
		{
			ttl = value;
		}
	}

	public string MultiSelectFiles
	{
		get
		{
			return MuSeFil;
		}
		set
		{
			MuSeFil = value;
		}
	}

	public string PrintPicture
	{
		get
		{
			return peremens.GetMinPath(prPic);
		}
		set
		{
			prPic = peremens.GetMaxPath(value);
			if (peremens.IsHttpCompil)
			{
				return;
			}
			if (Operators.CompareString(peremens.NikakoiEsli(prPic), peremens.trans("Никакой"), false) != 0)
			{
				try
				{
					NewLateBinding.LateSet(obj, (Type)null, "picPrint", new object[1] { Image.FromFile(prPic) }, (string[])null, (Type[])null);
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					NewLateBinding.LateSet(obj, (Type)null, "picPrint", new object[1] { null }, (string[])null, (Type[])null);
					if (!peremens.IgnorEr)
					{
						Errors.MessangeCritic(ex2.Message);
					}
					ProjectData.ClearProjectError();
					return;
				}
			}
			NewLateBinding.LateSet(obj, (Type)null, "picPrint", new object[1] { null }, (string[])null, (Type[])null);
		}
	}

	public string PrintText
	{
		get
		{
			return prTx;
		}
		set
		{
			prTx = value;
		}
	}

	public string PrintDocument
	{
		get
		{
			return prDc;
		}
		set
		{
			prDc = value;
			if (peremens.RunProj != null && NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "myobj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "getmyform", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
			{
				NewLateBinding.LateSet(obj, (Type)null, "rtfPrint", new object[1] { peremens.RunProj.GetMyAllFromName(value, "", Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "myobj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "getmyform", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null))) }, (string[])null, (Type[])null);
			}
		}
	}

	public string PrintTable
	{
		get
		{
			return prTl;
		}
		set
		{
			prTl = value;
			if (peremens.RunProj != null && NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "myobj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "getmyform", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
			{
				NewLateBinding.LateSet(obj, (Type)null, "tablPrint", new object[1] { peremens.RunProj.GetMyAllFromName(value, "", Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "myobj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "getmyform", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null))) }, (string[])null, (Type[])null);
			}
		}
	}

	public string PrintObject
	{
		get
		{
			return prOb;
		}
		set
		{
			prOb = value;
			NewLateBinding.LateSet(obj, (Type)null, "objPrint", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string TableOnCenter
	{
		get
		{
			return TbCn;
		}
		set
		{
			TbCn = value;
		}
	}

	public int FromPage
	{
		get
		{
			return FrmPg;
		}
		set
		{
			FrmPg = value;
			if (peremens.isRUN())
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrinterSettings", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FromPage", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
		}
	}

	public int ToPage
	{
		get
		{
			return ToPg;
		}
		set
		{
			ToPg = value;
			if (peremens.isRUN())
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrinterSettings", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToPage", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
		}
	}

	public int Copies
	{
		get
		{
			return Cops;
		}
		set
		{
			Cops = value;
			if (peremens.isRUN())
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrinterSettings", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Copies", new object[1] { value }, (string[])null, (Type[])null, false, true);
			}
		}
	}

	public string CalendarDateFormat
	{
		get
		{
			return Conversions.ToString(peremens.DateFormats.GetKey(peremens.DateFormats.IndexOfValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Format", new object[0], (string[])null, (Type[])null, (bool[])null)))));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "Format", new object[1] { RuntimeHelpers.GetObjectValue(peremens.DateFormats.GetByIndex(peremens.DateFormats.IndexOfKey(Strings.LCase(value)))) }, (string[])null, (Type[])null);
		}
	}

	public string CustomDateFormat
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "CustomFormat", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "CustomFormat", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string ShowUpDown
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "ShowUpDown", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "ShowUpDown", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "ShowUpDown", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public string SelectedDate
	{
		get
		{
			return peremens.ToMyDate(Conversions.ToDate(NewLateBinding.LateGet(obj, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)));
		}
		set
		{
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			DateTime dateTime = peremens.FromMyDate(value);
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLessEqual((object)dateTime, NewLateBinding.LateGet(obj, (Type)null, "MaxDate", new object[0], (string[])null, (Type[])null, (bool[])null), false), Operators.CompareObjectGreaterEqual((object)dateTime, NewLateBinding.LateGet(obj, (Type)null, "MinDate", new object[0], (string[])null, (Type[])null, (bool[])null), false))))
			{
				NewLateBinding.LateSet(obj, (Type)null, "value", new object[1] { dateTime }, (string[])null, (Type[])null);
			}
			else if (!peremens.IgnorEr)
			{
				Interaction.MsgBox((object)Errors.notDateLimit(value, NewLateBinding.LateGet(obj, (Type)null, "MinDate", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(obj, (Type)null, "MaxDate", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()), (MsgBoxStyle)0, (object)null);
			}
		}
	}

	public string LargeChange
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "LargeChange", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "LargeChange", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string SmallChange
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "SmallChange", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "SmallChange", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string Maximum
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "Maximum", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "Maximum", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string Minimum
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "Minimum", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "Minimum", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string TickStyle
	{
		get
		{
			return Conversions.ToString(peremens.TickStyles.GetKey(peremens.TickStyles.IndexOfValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "TickStyle", new object[0], (string[])null, (Type[])null, (bool[])null)))));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "TickStyle", new object[1] { RuntimeHelpers.GetObjectValue(peremens.TickStyles.GetByIndex(peremens.TickStyles.IndexOfKey(Strings.LCase(value)))) }, (string[])null, (Type[])null);
		}
	}

	public string TickFrequency
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "TickFrequency", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "TickFrequency", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string KeyEncryption
	{
		get
		{
			return kpri;
		}
		set
		{
			kpri = value;
		}
	}

	public string IdProgram
	{
		get
		{
			return idpr;
		}
		set
		{
			idpr = value;
		}
	}

	public string IdRegistryProgram
	{
		get
		{
			return rkey;
		}
		set
		{
			rkey = value;
		}
	}

	public string IdUser
	{
		get
		{
			return EncryptRSA(getBiDat());
		}
		set
		{
		}
	}

	public string TextButton
	{
		get
		{
			return btnT;
		}
		set
		{
			btnT = value;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Buttn", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { btnT }, (string[])null, (Type[])null, false, true);
		}
	}

	public string TextField
	{
		get
		{
			return tF;
		}
		set
		{
			tF = value;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "TextB", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { tF }, (string[])null, (Type[])null, false, true);
		}
	}

	public string MessageValid
	{
		get
		{
			return msDa;
		}
		set
		{
			msDa = value;
		}
	}

	public string MessageInvalid
	{
		get
		{
			return msNet;
		}
		set
		{
			msNet = value;
		}
	}

	public string DaysAll
	{
		get
		{
			return dnVs;
		}
		set
		{
			dnVs = value;
		}
	}

	public string DaysLeft
	{
		get
		{
			string text = "";
			long num = DateAndTime.get_Now().Ticks;
			text = Remark;
			if (status == 1)
			{
				return Conversions.ToString(0);
			}
			if (status == 2)
			{
				num = Conversions.ToLong(LastTime());
			}
			if (status == 3)
			{
				return Conversions.ToString(0);
			}
			try
			{
				text = Conversions.ToString(Registry.CurrentUser.OpenSubKey("Software\\" + IdRegistryProgram)!.GetValue("D"));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = Conversions.ToString(0);
				ProjectData.ClearProjectError();
				return result;
			}
			if (text == null)
			{
				return Conversions.ToString(0);
			}
			if (text.Length % 3 != 0)
			{
				return Conversions.ToString(0);
			}
			text = DecryptRSA(text);
			if (!Versioned.IsNumeric((object)text))
			{
				return Conversions.ToString(0);
			}
			long num2 = checked((long)Math.Round(Conversions.ToDouble(text) - (double)num));
			if (num2 < 0L)
			{
				return Conversions.ToString(0);
			}
			return Conversions.ToString(Math.Round((double)num2 / 10000000.0 / 60.0 / 60.0 / 24.0, 1));
		}
		set
		{
		}
	}

	public string TrialStarted
	{
		get
		{
			bool flag = true;
			try
			{
				if (Registry.CurrentUser.OpenSubKey("Software\\" + IdRegistryProgram) == null)
				{
					flag = false;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				flag = false;
				ProjectData.ClearProjectError();
			}
			if (!flag)
			{
				try
				{
					if (Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\" + IdRegistryProgram) != null)
					{
						flag = true;
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			return peremens.DaOrNet(flag);
		}
		set
		{
			if (peremens.DaOrNet(value))
			{
				TrialStart();
				return;
			}
			try
			{
				Registry.CurrentUser.DeleteSubKey("Software\\" + IdRegistryProgram);
				Registry.CurrentUser.DeleteSubKey("Software\\Microsoft\\" + IdRegistryProgram);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public string Activation
	{
		get
		{
			string remark = Remark;
			try
			{
				remark = Conversions.ToString(Registry.CurrentUser.OpenSubKey("Software\\" + IdRegistryProgram)!.GetValue("K"));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = peremens.DaOrNet(@bool: false);
				ProjectData.ClearProjectError();
				return result;
			}
			if (remark == null)
			{
				return peremens.trans("Нет");
			}
			if ((remark.Length == 0) | (remark.Length % 3 != 0))
			{
				return peremens.trans("Нет");
			}
			try
			{
				remark = DecryptRSA(remark);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				string result = peremens.DaOrNet(@bool: false);
				ProjectData.ClearProjectError();
				return result;
			}
			if (Operators.CompareString(getBiDat() + IdProgram, remark, false) == 0)
			{
				return peremens.DaOrNet(@bool: true);
			}
			return peremens.DaOrNet(@bool: false);
		}
		set
		{
			if (peremens.DaOrNet(value))
			{
				Registry.CurrentUser.CreateSubKey("Software\\" + IdRegistryProgram).SetValue("K", KeyIssue(IdUser));
			}
			else
			{
				Registry.CurrentUser.CreateSubKey("Software\\" + IdRegistryProgram).SetValue("K", "");
			}
		}
	}

	public string Remark
	{
		get
		{
			string text = "";
			status = 0;
			if (!peremens.DaOrNet(TrialStarted))
			{
				return peremens.trans("Триальный период еще не запускался, либо был удален.");
			}
			if (Conversions.ToDouble(LastTime()) == 0.0)
			{
				status = 3;
				return peremens.trans("Попытка удалить триальный период.");
			}
			try
			{
				text = Conversions.ToString(Registry.CurrentUser.OpenSubKey("Software\\" + IdRegistryProgram)!.GetValue("D"));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = peremens.trans("Попытка удалить триальный период.");
				ProjectData.ClearProjectError();
				return result;
			}
			if (text == null)
			{
				return "";
			}
			if (text.Length % 3 != 0)
			{
				return "";
			}
			text = DecryptRSA(text);
			if (Operators.CompareString(LastTime(), text, false) > 0)
			{
				status = 1;
				return peremens.trans("Поледний запуск был после окончания триального периода.");
			}
			if ((double)DateAndTime.get_Now().Ticks < Conversions.ToDouble(LastTime()))
			{
				status = 2;
				return peremens.trans("Системное время было изменено на более раннее.");
			}
			string value = EncryptRSA(Conversions.ToString(DateAndTime.get_Now().Ticks));
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\" + IdRegistryProgram).SetValue("L", value);
			return "";
		}
		set
		{
		}
	}

	public string ToolTip
	{
		get
		{
			return TlTp;
		}
		set
		{
			TlTp = value;
			object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Myobj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToolTipa", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[2]
			{
				RuntimeHelpers.GetObjectValue(this.obj),
				TlTp
			};
			object[] array2 = array;
			bool[] array3 = new bool[2] { true, true };
			NewLateBinding.LateCall(obj, (Type)null, "SetToolTip", array2, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				this.obj = RuntimeHelpers.GetObjectValue(array[0]);
			}
			if (array3[1])
			{
				TlTp = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
			}
			if (Iz.IsTr(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.obj, (Type)null, "Myobj", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Myobj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToolTipa", new object[0], (string[])null, (Type[])null, (bool[])null);
				array = new object[2];
				object[] array4 = array;
				object obj3 = this.obj;
				array4[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "TextB", new object[0], (string[])null, (Type[])null, (bool[])null));
				array[1] = TlTp;
				object[] array5 = array;
				object[] array6 = array5;
				array3 = new bool[2] { true, true };
				NewLateBinding.LateCall(obj2, (Type)null, "SetToolTip", array6, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					NewLateBinding.LateSetComplex(obj3, (Type)null, "TextB", new object[1] { RuntimeHelpers.GetObjectValue(array5[0]) }, (string[])null, (Type[])null, true, false);
				}
				if (array3[1])
				{
					TlTp = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(string));
				}
				object obj4 = NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Myobj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToolTipa", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array7 = new object[2];
				object[] array8 = array7;
				obj3 = this.obj;
				array8[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "Buttn", new object[0], (string[])null, (Type[])null, (bool[])null));
				array7[1] = TlTp;
				array = array7;
				object[] array9 = array;
				array3 = new bool[2] { true, true };
				NewLateBinding.LateCall(obj4, (Type)null, "SetToolTip", array9, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					NewLateBinding.LateSetComplex(obj3, (Type)null, "Buttn", new object[1] { RuntimeHelpers.GetObjectValue(array[0]) }, (string[])null, (Type[])null, true, false);
				}
				if (array3[1])
				{
					TlTp = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
				}
			}
		}
	}

	public string MultiSelectItems
	{
		get
		{
			return MultSelIts;
		}
		set
		{
			MultSelIts = value;
			if (peremens.DaOrNet(MultSelIts))
			{
				NewLateBinding.LateSet(obj, (Type)null, "SelectionMode", new object[1] { (object)(SelectionMode)3 }, (string[])null, (Type[])null);
			}
			else
			{
				NewLateBinding.LateSet(obj, (Type)null, "SelectionMode", new object[1] { (object)(SelectionMode)1 }, (string[])null, (Type[])null);
			}
		}
	}

	public string FileIsSent
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "FileIsSent", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "FileIsSent", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "FileIsSent", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public string HideSendingText
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "HideSendingText", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "HideSendingText", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "HideSendingText", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public string HideSendingFiles
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "HideSendingFiles", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "HideSendingFiles", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "HideSendingFiles", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public string HideComboBox
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "HideComboBox", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "HideComboBox", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "HideComboBox", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public string CommandSymbol
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "CommandSymbol", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "CommandSymbol", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string ReceivedCommand
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "ReceivedCommand", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "ReceivedCommand", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string ReceivedText
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "ReceivedText", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "ReceivedText", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string ReceivedFile
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "ReceivedFile", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "ReceivedFile", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string SentCommand
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "SentCommand", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "SentCommand", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string SentText
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "SentText", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "SentText", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string SentFile
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "SentFile", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "SentFile", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string NameInNetwork
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "NameInNetwork", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "NameInNetwork", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string RemoteHost
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "RemoteHost", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "RemoteHost", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string RemotePort
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "RemotePort", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "RemotePort", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string PathForDownloads
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "PathForDownloads", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "PathForDownloads", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string ClientServerType
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "ClientServerType", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "ClientServerType", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string ClientsNames
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "ClientsNames", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "ClientsNames", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string TextBoxString
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "TextBoxString", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "TextBoxString", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string TextBoxLog
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "TextBoxLog", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "TextBoxLog", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string ClientsIPs
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "ClientsIPs", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "ClientsIPs", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string GetClientIp
	{
		get
		{
			object obj = this.obj;
			object[] array = new object[1];
			int num = 0;
			array[0] = args[0];
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "GetClientIp", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "GetClientIp", new object[2]
			{
				args[0],
				value
			}, (string[])null, (Type[])null);
		}
	}

	public string KeepAlive
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "KeepAlive", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "KeepAlive", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "KeepAlive", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public string AllowAutoRedirect
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "AllowAutoRedirect", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "AllowAutoRedirect", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "AllowAutoRedirect", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public string UrlToGo
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "UrlToGo", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "UrlToGo", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string UrlReferer
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "UrlReferer", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "UrlReferer", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string UrlRedirect
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "UrlRedirect", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "UrlRedirect", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string UserAgent
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "UserAgent", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "UserAgent", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string Accept
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "Accept", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "Accept", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string ProxyIp
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "ProxyIp", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "ProxyIp", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string ProxyPort
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "ProxyPort", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "ProxyPort", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string EncodingPage
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "EncodingPage", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "EncodingPage", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string LanguagePage
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "LanguagePage", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "LanguagePage", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string ContentQuery
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "ContentQuery", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "ContentQuery", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string ContentType
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "ContentType", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "ContentType", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string ContentLength
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "ContentLength", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
		}
	}

	public string HttpMethod
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "HttpMethod", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "HttpMethod", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string ResultCode
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "ResultCode", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
		}
	}

	public string TimeOut
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "TimeOut", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "TimeOut", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string TimeDelay
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "TimeDelay", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "TimeDelay", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string Headers
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "Headers", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "Headers", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string CookiesQueries
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "CookiesQueries", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "CookiesQueries", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string ResultQuery
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "ResultQuery", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "ResultQuery", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string FileDownloading
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "FileDownloading", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "FileDownloading", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "FileDownloading", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public string DownloadPause
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "DownloadPause", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "DownloadPause", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "DownloadPause", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public string BufferSize
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "BufferSize", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "BufferSize", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string CheckConnect
	{
		get
		{
			if (peremens.isDevelop & !peremens.isRUN())
			{
				return Conversions.ToString(true);
			}
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "CheckConnect", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "CheckConnect", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
		}
	}

	public string StyleProgress
	{
		get
		{
			return Conversions.ToString(peremens.StylesProgress.GetKey(peremens.StylesProgress.IndexOfValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Style", new object[0], (string[])null, (Type[])null, (bool[])null)))));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "Style", new object[1] { RuntimeHelpers.GetObjectValue(peremens.StylesProgress.GetByIndex(peremens.StylesProgress.IndexOfKey(Strings.LCase(value)))) }, (string[])null, (Type[])null);
		}
	}

	public string MarqueeAnimationSpeed
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "MarqueeAnimationSpeed", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "MarqueeAnimationSpeed", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string StepProgress
	{
		get
		{
			return Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "Step", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "Step", new object[1] { value }, (string[])null, (Type[])null);
		}
	}

	public string RightToLeftLayout
	{
		get
		{
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object obj = this.obj;
			array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "RightToLeftLayout", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(obj, (Type)null, "RightToLeftLayout", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			}
			return Conversions.ToString(obj2);
		}
		set
		{
			NewLateBinding.LateSet(obj, (Type)null, "RightToLeftLayout", new object[1] { peremens.DaOrNet(value) }, (string[])null, (Type[])null);
		}
	}

	public int Interval
	{
		get
		{
			return Intr;
		}
		set
		{
			Intr = value;
		}
	}

	public int IntervalCount
	{
		get
		{
			return IntrCou;
		}
		set
		{
			IntrCou = value;
		}
	}

	public Propertys(object ob)
	{
		//IL_0988: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected O, but got Unknown
		CM = peremens.trans("Никакой");
		CM1 = peremens.trans("Никакой");
		CM2 = peremens.trans("Никакой");
		ind = "0";
		anch = peremens.trans("Слева_Сверху");
		AutoTr = peremens.trans("Да");
		niv = peremens.trans("Нет");
		Sem = false;
		BkColor = peremens.trans("Никакой");
		BkColor1 = peremens.trans("Никакой");
		BkColor2 = peremens.trans("Никакой");
		backImage = peremens.trans("Никакой");
		backImage1 = peremens.trans("Никакой");
		backImage2 = peremens.trans("Никакой");
		bkImageStyle = peremens.trans("Плитка");
		bkImageStyle1 = peremens.trans("Плитка");
		bkImageStyle2 = peremens.trans("Плитка");
		curs = peremens.trans("Обычный");
		curs1 = peremens.trans("Обычный");
		curs2 = peremens.trans("Обычный");
		dok = peremens.trans("Никакой");
		enab = peremens.trans("Да");
		styl = peremens.trans("Обычный");
		bstyl = peremens.trans("Никакой");
		fontFam = peremens.trans("Microsoft Sans Serif");
		fontBol = peremens.trans("Нет");
		fontItal = peremens.trans("Нет");
		fontUnder = peremens.trans("Нет");
		fontStrike = peremens.trans("Нет");
		fontCol = peremens.trans("Черный");
		Img = peremens.trans("Никакой");
		ImgAl = peremens.trans("Центр");
		lft = 0;
		tp = 0;
		maxWidth = 0;
		maxHeight = 0;
		minWidth = 0;
		minHeight = 0;
		padLeft = 0;
		padTop = 0;
		padRight = 0;
		padBottom = 0;
		Wid = 0;
		Hei = 0;
		tabInd = 0;
		tabStp = peremens.trans("Да");
		tg = "";
		txt = "mkjhg";
		txtAl = peremens.trans("Центр");
		txtPos = peremens.trans("Слева");
		txtImRel = peremens.trans("Поверх");
		vis = peremens.trans("Да");
		mf = peremens.trans("Да");
		cancelCl = peremens.trans("Нет");
		mab = peremens.trans("Нет");
		mib = peremens.trans("Нет");
		AssocExts = "";
		pos = 0;
		aScrl = peremens.trans("Нет");
		orientTl = peremens.trans("Горизонтальная");
		alig = peremens.trans("Да");
		aTT = peremens.trans("Нет");
		ChOnCl = peremens.trans("Нет");
		dispSt = peremens.trans("Рисунок и текст");
		dm = peremens.trans("Никакой");
		oldMenu = null;
		imScal = peremens.trans("Нет");
		imTranspCol = peremens.trans("Никакой");
		shortK = peremens.trans("Никакой");
		shSK = peremens.trans("Да");
		txtDirc = peremens.trans("Горизонтальный");
		toolTT = peremens.trans("");
		Aligz = peremens.trans("Сверху");
		SelTabPos = 0;
		padX = 6;
		padY = 3;
		val = "";
		AuRu = peremens.trans("Нет");
		AuRC = peremens.trans("Да");
		AllInp = peremens.trans("Все");
		aScrl1 = peremens.trans("Нет");
		aScrl2 = peremens.trans("Нет");
		fxPn = peremens.trans("Никакой");
		orient = peremens.trans("Вертикальная");
		fxSplit = peremens.trans("Нет");
		pn1Coll = peremens.trans("Нет");
		pn2Coll = peremens.trans("Нет");
		splWid = 4;
		splDis = 25;
		splInc = 1;
		pn1MinS = 25;
		pn2MinS = 25;
		StopedFlag = true;
		strFileName = peremens.trans("Никакой");
		pld = peremens.trans("Нет");
		iVolume = 1000;
		iBalance = 1000;
		iMute = peremens.trans("Нет");
		bOpened = false;
		bPlaying = false;
		strAlias = "video1";
		OnFullS = peremens.trans("Нет");
		maxLen = 32767;
		MuLine = peremens.trans("Нет");
		passCh = "";
		rOnly = peremens.trans("Нет");
		scrlBars = peremens.trans("Нет");
		allowNav = peremens.trans("Да");
		allowDrop = peremens.trans("Да");
		cmBrowser = peremens.trans("Да");
		scrpErrs = peremens.trans("Нет");
		scrBarsEn = peremens.trans("Да");
		ur = "";
		ShCutEn = peremens.trans("Да");
		docEnc = peremens.trans("cyrillic (windows)");
		newWin = peremens.trans("В данном браузере");
		CnBox = peremens.trans("Да");
		FrStyle = peremens.trans("Нормальный");
		MM = peremens.trans("Никакой");
		opac = 100;
		ShIc = peremens.trans("Да");
		ShTB = peremens.trans("Да");
		StPos = peremens.trans("По центру экрана");
		TMst = peremens.trans("Нет");
		WiStat = peremens.trans("Нормальный");
		AutScrMinW = 0;
		AutScrMinH = 0;
		AutScrPosX = 0;
		AutScrPosY = 0;
		Icn = peremens.trans("Никакой");
		TrCol = peremens.trans("Никакой");
		AUtAR = peremens.trans("Да");
		AUtDR = peremens.trans("Да");
		AUtOC = peremens.trans("Нет");
		AUtRC = peremens.trans("Да");
		AUtRR = peremens.trans("Да");
		cBorSt = peremens.trans("Обычный");
		HeadVis = peremens.trans("Да");
		CSBkColor = "255;255;255;";
		CSSBkColor = peremens.ToMyColor(SystemColors.Highlight);
		CSFrColor = peremens.ToMyColor(SystemColors.ControlText);
		CSSFrColor = peremens.ToMyColor(SystemColors.HighlightText);
		EdMd = peremens.trans("Обычный");
		GrCol = peremens.ToMyColor(SystemColors.ControlDark);
		MultSel = peremens.trans("Да");
		RdOlTb = peremens.trans("Нет");
		SelMode = peremens.trans("Ячейки и строки");
		selRows = "0";
		semaforSelect = false;
		selCol = "0";
		cn = new OleDbConnection();
		DrDnHeight = 106;
		DrDnWidth = 75;
		DrDnStyl = peremens.trans("Нет");
		MaxDrDn = 8;
		Srtd = peremens.trans("Нет");
		selIn = 0;
		selIt = "";
		colWid = 0;
		HorScBar = peremens.trans("Нет");
		multCol = peremens.trans("Нет");
		selModeList = peremens.trans("Да");
		ActLinkCol = peremens.ToMyColor(Color.Red);
		DisLiCol = "150; 151; 155;";
		LiCo = "0; 0; 255;";
		VisLiCol = "128; 0; 128;";
		LiSt = 0;
		LiLe = 100;
		LinBeh = peremens.trans("По умолчанию");
		LiVis = peremens.trans("Нет");
		LiEn = peremens.trans("Да");
		InetLin = peremens.trans("Да");
		LinkNam = txt;
		DetUr = peremens.trans("Да");
		dCol = "0; 0; 0;";
		cnl = peremens.trans("Нет");
		ShCols = peremens.trans("Нет");
		ShEff = peremens.trans("Да");
		descr = "";
		sePath = "";
		defEx = "";
		ChFEx = peremens.trans("Да");
		ChPEx = peremens.trans("Да");
		flNm = "";
		fltr = "";
		flIn = 1;
		iniDir = "";
		ttl = "";
		MuSeFil = peremens.trans("Нет");
		prPic = peremens.trans("Никакой");
		prTx = "";
		prDc = "";
		prTl = "";
		prOb = "";
		TbCn = peremens.trans("Да");
		FrmPg = 1;
		ToPg = 999;
		Cops = 1;
		btnT = peremens.trans("Активировать");
		tF = "";
		msDa = peremens.trans("Ключ верный!");
		msNet = peremens.trans("Ключ неверный.");
		dnVs = Conversions.ToString(30);
		status = 0;
		TlTp = "";
		MultSelIts = peremens.trans("Нет");
		Intr = 100;
		IntrCou = 0;
		obj = RuntimeHelpers.GetObjectValue(ob);
	}

	public void MinimizeToTray()
	{
		Sem = true;
		Application.DoEvents();
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowInTaskbar", new object[1] { peremens.trans("Нет") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowInTray", new object[1] { peremens.trans("Да") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "visible", new object[1] { peremens.trans("Нет") }, (string[])null, (Type[])null, false, true);
		Type typeFromHandle = typeof(Strings);
		object[] array = new object[1];
		object obj = this.obj;
		object[] array2 = new object[0];
		object[] array3 = array2;
		string[] array4 = null;
		array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Props", array3, array4, (Type[])null, (bool[])null), (Type)null, "WindowState", new object[0], (string[])null, (Type[])null, (bool[])null));
		object[] array5 = array;
		bool[] array6 = new bool[1] { true };
		object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array5, (string[])null, (Type[])null, array6);
		if (array6[0])
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Props", array2, array4, (Type[])null, (bool[])null), (Type)null, "WindowState", new object[1] { RuntimeHelpers.GetObjectValue(array5[0]) }, (string[])null, (Type[])null, true, true);
		}
		if (Operators.ConditionalCompareObjectNotEqual(obj2, (object)Strings.UCase(peremens.trans("Свернуто")), false))
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WindowState", new object[1] { peremens.trans("Свернуто") }, (string[])null, (Type[])null, false, true);
		}
		Sem = false;
	}

	public void MaximizeFromTray()
	{
		Sem = true;
		Application.DoEvents();
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "WindowState", new object[1] { peremens.trans("Нормальный") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowInTaskbar", new object[1] { peremens.trans("Да") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowInTray", new object[1] { peremens.trans("Нет") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "visible", new object[1] { peremens.trans("Да") }, (string[])null, (Type[])null, false, true);
		Sem = false;
	}

	public void PlayInNewHandle(Control handle)
	{
		MediaWindow = handle;
		bOpened = false;
		int playPosition = PlayPosition;
		CloseMovie();
		OpenMovie(strFileName);
		PlayPosition = playPosition;
	}

	public bool OpenMovie(params string[] args)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		string lpszReturnString;
		string lpszCommand;
		if (!bOpened)
		{
			if (ctrWindow == null)
			{
				ctrWindow = (Control)obj;
			}
			strAlias = "video1" + Conversions.ToString(new Random().Next(1, 10000));
			lpszCommand = "OPEN \"" + args[0] + "\" alias " + strAlias + " TYPE MPEGVIDEO PARENT " + ctrWindow.get_Handle() + " STYLE CHILD";
			lpszReturnString = Conversions.ToString(0L);
			if (peremens.mciSendStringA(ref lpszCommand, ref lpszReturnString, 0, IntPtr.Zero) != 0)
			{
				Errors.MessangeExclamen(peremens.trans("Невозможно открыть/воспроизвести файл") + " \"" + args[0] + "\". " + peremens.trans("Возможно, формат файла не поддерживается и требуется установить кодеки. Либо файл не существует."));
				goto IL_0164;
			}
			FileName = args[0];
			bOpened = true;
		}
		lpszReturnString = "SET " + strAlias + " TIME FORMAT MS";
		lpszCommand = Conversions.ToString(0L);
		peremens.mciSendStringA(ref lpszReturnString, ref lpszCommand, 0, IntPtr.Zero);
		Fit();
		goto IL_0164;
		IL_0164:
		bool result = default(bool);
		return result;
	}

	public bool CloseMovie()
	{
		bool num = bOpened;
		string lpszCommand = "CLOSE " + strAlias;
		string lpszReturnString = Conversions.ToString(0L);
		if (num & (peremens.mciSendStringA(ref lpszCommand, ref lpszReturnString, 0, IntPtr.Zero) == 0))
		{
			bOpened = false;
		}
		bool result = default(bool);
		return result;
	}

	public bool PlayMovie()
	{
		if (!bOpened)
		{
			OpenMovie(strFileName);
		}
		bool num = !bPlaying;
		string lpszCommand = "PLAY " + strAlias;
		string lpszReturnString = Conversions.ToString(0L);
		if (num & (peremens.mciSendStringA(ref lpszCommand, ref lpszReturnString, 0, IntPtr.Zero) == 0))
		{
			bPlaying = true;
		}
		Fit();
		return bPlaying;
	}

	public bool StopMovie()
	{
		bool num = bOpened;
		string lpszCommand = "STOP " + strAlias;
		string lpszReturnString = Conversions.ToString(0L);
		if (num & (peremens.mciSendStringA(ref lpszCommand, ref lpszReturnString, 0, IntPtr.Zero) == 0))
		{
			string lpszCommand2 = "SEEK " + strAlias + " TO START";
			string lpszReturnString2 = Conversions.ToString(0L);
			peremens.mciSendStringA(ref lpszCommand2, ref lpszReturnString2, 0, IntPtr.Zero);
			bPlaying = false;
		}
		return !bPlaying;
	}

	public bool PauseMovie()
	{
		bool num = bPlaying;
		string lpszCommand = "PAUSE " + strAlias;
		string lpszReturnString = Conversions.ToString(0L);
		if (num & (peremens.mciSendStringA(ref lpszCommand, ref lpszReturnString, 0, IntPtr.Zero) == 0))
		{
			bPlaying = false;
		}
		return !bPlaying;
	}

	public bool Fit()
	{
		string lpszReturnString = Strings.Space(128);
		checked
		{
			if (ctrWindow != null)
			{
				string lpszCommand = "WHERE " + strAlias + " source";
				if (peremens.mciSendStringA(ref lpszCommand, ref lpszReturnString, Strings.Len(lpszReturnString), IntPtr.Zero) == 0)
				{
					string[] array = Strings.Split(Strings.Trim(lpszReturnString), " ", -1, (CompareMethod)0);
					Size size = new Size(Conversions.ToInteger(array[2]), Conversions.ToInteger(array[3]));
					if (!size.IsEmpty)
					{
						double num = (double)ctrWindow.get_Width() / (double)size.Width;
						if ((double)size.Height * num > (double)ctrWindow.get_Height())
						{
							num = (double)ctrWindow.get_Height() / (double)size.Height;
						}
						int num2 = (int)Math.Round((double)size.Width * num);
						int num3 = (int)Math.Round((double)size.Height * num);
						int num4 = (int)Math.Round((double)(ctrWindow.get_Width() - num2) / 2.0);
						int num5 = (int)Math.Round((double)(ctrWindow.get_Height() - num3) / 2.0);
						lpszCommand = "PUT " + strAlias + " WINDOW AT " + Conversions.ToString(num4) + " " + Conversions.ToString(num5) + " " + Conversions.ToString(num2) + " " + Conversions.ToString(num3);
						string lpszReturnString2 = Conversions.ToString(0L);
						return peremens.mciSendStringA(ref lpszCommand, ref lpszReturnString2, 0, IntPtr.Zero) == 0;
					}
					return false;
				}
			}
			bool result = default(bool);
			return result;
		}
	}

	public void NavigateNewPage(params string[] args)
	{
		Uri urlFromString = peremens.GetUrlFromString(args[0]);
		if ((object)urlFromString != null)
		{
			object obj = this.obj;
			object[] array = new object[2] { urlFromString, true };
			bool[] array2 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj, (Type)null, "Navigate", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				urlFromString = (Uri)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Uri));
			}
		}
	}

	public void NavigateInFrame(params string[] args)
	{
		Uri urlFromString = peremens.GetUrlFromString(args[0]);
		if ((object)urlFromString != null)
		{
			object obj = this.obj;
			object[] array = new object[2] { urlFromString, null };
			int num = 1;
			array[1] = args[1];
			object[] array2 = array;
			bool[] array3 = new bool[2] { true, true };
			NewLateBinding.LateCall(obj, (Type)null, "Navigate", array2, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				urlFromString = (Uri)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(Uri));
			}
			if (array3[1])
			{
				args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
			}
		}
	}

	public void RefreshPage(params string[] args)
	{
		NewLateBinding.LateCall(obj, (Type)null, "Refresh", new object[1] { RuntimeHelpers.GetObjectValue(peremens.Refreshs.GetByIndex(peremens.Refreshs.IndexOfKey(Strings.LCase(args[0])))) }, (string[])null, (Type[])null, (bool[])null, true);
	}

	public DataGridViewCell[] getCells(string rows, string cols)
	{
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected O, but got Unknown
		DataGridViewCell[] mass = null;
		if ((Operators.CompareString(Strings.Trim(rows), "", false) == 0) | (Operators.CompareString(Strings.Trim(cols), "", false) == 0))
		{
			return null;
		}
		checked
		{
			if (Operators.CompareString(Strings.UCase(Strings.Trim(rows)), Strings.UCase(peremens.trans("Все")), false) == 0)
			{
				rows = "";
				string[] array = new string[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
				int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				int i;
				for (i = 0; i <= num; i++)
				{
					object obj = this.obj;
					object[] array2 = new object[1] { i };
					object[] array3 = array2;
					bool[] array4 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Rows", array3, (string[])null, (Type[])null, array4);
					if (array4[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
					}
					if (!Conversions.ToBoolean(NewLateBinding.LateGet(obj2, (Type)null, "IsNewRow", new object[0], (string[])null, (Type[])null, (bool[])null)))
					{
						string[] array5 = array;
						int num2 = i;
						array5[num2] = array[num2] + Conversions.ToString(i);
					}
				}
				array = (string[])Utils.CopyArray((Array)array, (Array)new string[i + 1]);
				rows = Strings.Join(array, ",");
			}
			if ((Operators.CompareString(Strings.Trim(cols), "", false) == 0) | (Operators.CompareString(Strings.UCase(Strings.Trim(cols)), Strings.UCase(peremens.trans("Все")), false) == 0))
			{
				cols = "";
				int num3 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				for (int i = 0; i <= num3; i++)
				{
					if (i > 0)
					{
						cols += ",";
					}
					cols += Conversions.ToString(i);
				}
			}
			string[] array6 = rows.Split(new char[1] { ',' });
			string[] array7 = cols.Split(new char[1] { ',' });
			int num4 = array6.Length - 1;
			for (int i = 0; i <= num4; i++)
			{
				array6[i] = Strings.Trim(array6[i]);
				if (!Conversions.ToBoolean(Operators.AndObject((object)Iz.isInteger(ref array6[i]), Operators.CompareObjectLess((object)array6[i], NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), false))))
				{
					continue;
				}
				object obj3 = this.obj;
				object[] array2 = new object[1];
				object[] array8 = array2;
				int num2 = i;
				array8[0] = array6[num2];
				object[] array9 = array2;
				object[] array10 = array9;
				bool[] array4 = new bool[1] { true };
				object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "Rows", array10, (string[])null, (Type[])null, array4);
				if (array4[0])
				{
					array6[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
				}
				if (Conversions.ToBoolean(NewLateBinding.LateGet(obj4, (Type)null, "IsNewRow", new object[0], (string[])null, (Type[])null, (bool[])null)))
				{
					continue;
				}
				int num5 = array7.Length - 1;
				for (int j = 0; j <= num5; j++)
				{
					array7[j] = Strings.Trim(array7[j]);
					if (Conversions.ToBoolean(Operators.AndObject((object)Iz.isInteger(ref array7[j]), Operators.CompareObjectLess((object)array7[j], NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), false))))
					{
						peremens.ReDims(ref mass);
						DataGridViewCell[] array11 = mass;
						int num6 = mass.Length - 1;
						object obj5 = this.obj;
						array2 = new object[1];
						object[] array12 = array2;
						num2 = i;
						array12[0] = array6[num2];
						array9 = array2;
						object[] array13 = array9;
						array4 = new bool[1] { true };
						object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "Rows", array13, (string[])null, (Type[])null, array4);
						if (array4[0])
						{
							array6[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(string));
						}
						array11[num6] = (DataGridViewCell)NewLateBinding.LateGet(obj6, (Type)null, "Cells", new object[1] { Convert.ToInt16(array7[j]) }, (string[])null, (Type[])null, (bool[])null);
					}
				}
			}
			return mass;
		}
	}

	public void copyContentRows(int eInd, int bInd, int count)
	{
		checked
		{
			if ((eInd > bInd) & (eInd < bInd + count))
			{
				copyContentRows(eInd, bInd, eInd - bInd);
				copyContentRows(eInd + (eInd - bInd), eInd + count, bInd + count - eInd);
				return;
			}
			int num = eInd + count - 1;
			for (int i = eInd; i <= num; i++)
			{
				object obj = this.obj;
				object[] array = new object[1] { i };
				bool[] array2 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Rows", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				int num2 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "cells", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				for (int j = 0; j <= num2; j++)
				{
					object obj3 = this.obj;
					object[] array3 = new object[1] { i };
					bool[] array4 = new bool[1] { true };
					object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "Rows", array3, (string[])null, (Type[])null, array4);
					if (array4[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
					}
					object[] array5 = new object[1] { j };
					bool[] array6 = new bool[1] { true };
					object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "cells", array5, (string[])null, (Type[])null, array6);
					if (array6[0])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(int));
					}
					object[] array7 = new object[1];
					object obj6 = NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[1] { bInd + (i - eInd) }, (string[])null, (Type[])null, (bool[])null);
					object[] array8 = new object[1] { j };
					bool[] array9 = new bool[1] { true };
					object obj7 = NewLateBinding.LateGet(obj6, (Type)null, "cells", array8, (string[])null, (Type[])null, array9);
					if (array9[0])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
					}
					array7[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj7, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
					NewLateBinding.LateSetComplex(obj5, (Type)null, "value", array7, (string[])null, (Type[])null, false, true);
				}
			}
		}
	}

	public string getVals(params string[] args)
	{
		string text = "";
		checked
		{
			int num = args.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				text = text + "'" + args[i] + "'";
				if (i < args.Length - 1)
				{
					text += ",";
				}
			}
			return text;
		}
	}

	public string getVals(DataGridViewCellCollection args)
	{
		string text = "";
		checked
		{
			int num = ((BaseCollection)args).get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				text = Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject(Operators.ConcatenateObject((object)"'", args.get_Item(i).get_Value()), (object)"'")));
				if (i < ((BaseCollection)args).get_Count() - 1)
				{
					text += ",";
				}
			}
			return text;
		}
	}

	public bool isDBconnect()
	{
		if ((Operators.CompareString(dbName, "", false) != 0) & (Operators.CompareString(tablName, "", false) != 0) & (Operators.CompareString(lastSelect, "", false) != 0))
		{
			return true;
		}
		return false;
	}

	public void RowsAdd(params string[] args)
	{
		checked
		{
			if (isDBconnect())
			{
				string text = "";
				string selectedRows = SelectedRows;
				int num = args.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					text = text + "'" + args[i] + "'";
					if (i < args.Length - 1)
					{
						text += ",";
					}
				}
				SQLqueryInto(typeName, dbName, "INSERT INTO " + tablName + " VALUES(" + getVals(args) + ")");
				SQLquerySelect(typeName, dbName, lastSelect);
				SelectedRows = selectedRows;
			}
			else
			{
				object obj = NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array = new object[1] { args };
				bool[] array2 = new bool[1] { true };
				NewLateBinding.LateCall(obj, (Type)null, "Add", array, (string[])null, (Type[])null, array2, true);
				if (array2[0])
				{
					args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string[]));
				}
			}
		}
	}

	public void ColumnsAdd(params string[] args)
	{
		object obj = NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array = new object[2];
		int num = 0;
		array[0] = args[0];
		int num2 = 1;
		array[1] = args[1];
		object[] array2 = array;
		bool[] array3 = new bool[2] { true, true };
		NewLateBinding.LateCall(obj, (Type)null, "Add", array2, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
		if (array3[1])
		{
			args[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
		}
	}

	public void RowsAddCopies(params string[] args)
	{
		checked
		{
			if (isDBconnect())
			{
				string selectedRows = SelectedRows;
				int num = Conversions.ToInteger(args[0]);
				int num2 = (int)Math.Round((double)peremens.Int(args[0]) + Conversions.ToDouble(args[1]) - 1.0);
				int num4 = default(int);
				for (int i = num; i <= num2; i++)
				{
					string[] array = new string[3] { typeName, dbName, null };
					string[] array2 = array;
					string text = string.Concat("INSERT INTO " + tablName, " VALUES(");
					object[] array3 = new object[1];
					object obj = this.obj;
					object[] array4 = new object[1] { i };
					string[] array5 = null;
					bool[] array6 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "rows", array4, array5, (Type[])null, array6);
					bool[] array7 = array6;
					int num3 = 0;
					if (array7[0])
					{
						num4 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
						i = num4;
					}
					array3[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj2, (Type)null, "cells", new object[0], (string[])null, (Type[])null, (bool[])null));
					object[] array8 = array3;
					object[] array9 = array8;
					bool[] array10 = new bool[1] { true };
					object obj3 = NewLateBinding.LateGet((object)this, (Type)null, "getVals", array9, (string[])null, (Type[])null, array10);
					if (array10[0])
					{
						object obj4 = NewLateBinding.LateGet(obj, (Type)null, "rows", array4, array5, (Type[])null, new bool[1] { true });
						if (array7[num3])
						{
							i = num4;
						}
						NewLateBinding.LateSetComplex(obj4, (Type)null, "cells", new object[1] { RuntimeHelpers.GetObjectValue(array8[0]) }, (string[])null, (Type[])null, true, true);
					}
					array2[2] = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, obj3), (object)")"));
					SQLqueryInto(array);
				}
				SQLquerySelect(typeName, dbName, lastSelect);
				SelectedRows = selectedRows;
			}
			else
			{
				int eInd = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)peremens.Int(Conversions.ToString(NewLateBinding.LateGet(this.obj, (Type)null, "AllowUserToAddRows", new object[0], (string[])null, (Type[])null, (bool[])null)))));
				object obj5 = NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array11 = new object[2];
				object[] array12 = array11;
				int num4 = 0;
				array12[0] = args[0];
				object[] array13 = array11;
				int num3 = 1;
				array13[1] = args[1];
				object[] array8 = array11;
				object[] array14 = array8;
				bool[] array10 = new bool[2] { true, true };
				NewLateBinding.LateCall(obj5, (Type)null, "AddCopies", array14, (string[])null, (Type[])null, array10, true);
				if (array10[0])
				{
					args[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(string));
				}
				if (array10[1])
				{
					args[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[1]), typeof(string));
				}
				copyContentRows(eInd, Conversions.ToInteger(args[0]), Conversions.ToInteger(args[1]));
			}
		}
	}

	public string GetFirstRow(params string[] args)
	{
		return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetFirstRow", new object[1] { RuntimeHelpers.GetObjectValue(peremens.Filters.GetByIndex(peremens.Filters.IndexOfKey(Strings.LCase(args[0])))) }, (string[])null, (Type[])null, (bool[])null));
	}

	public string GetLastRow(params string[] args)
	{
		return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetLastRow", new object[1] { RuntimeHelpers.GetObjectValue(peremens.Filters.GetByIndex(peremens.Filters.IndexOfKey(Strings.LCase(args[0])))) }, (string[])null, (Type[])null, (bool[])null));
	}

	public string GetNextRow(params string[] args)
	{
		object obj = NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array = new object[2];
		int num = 0;
		array[0] = args[0];
		array[1] = RuntimeHelpers.GetObjectValue(peremens.Filters.GetByIndex(peremens.Filters.IndexOfKey(Strings.LCase(args[1]))));
		object[] array2 = array;
		bool[] array3 = new bool[2] { true, false };
		object obj2 = NewLateBinding.LateGet(obj, (Type)null, "GetNextRow", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
		return Conversions.ToString(obj2);
	}

	public string GetPreviousRow(params string[] args)
	{
		object obj = NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array = new object[2];
		int num = 0;
		array[0] = args[0];
		array[1] = RuntimeHelpers.GetObjectValue(peremens.Filters.GetByIndex(peremens.Filters.IndexOfKey(Strings.LCase(args[1]))));
		object[] array2 = array;
		bool[] array3 = new bool[2] { true, false };
		object obj2 = NewLateBinding.LateGet(obj, (Type)null, "GetPreviousRow", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
		return Conversions.ToString(obj2);
	}

	public void RowsInsert(params string[] args)
	{
		args[0] = peremens.UbratKovich(args[0]).str;
		int num = Conversions.ToInteger(args[0].Split(new char[1] { ',' })[0]);
		peremens.DelDims(ref args, 0);
		if (isDBconnect())
		{
			RowsAdd(args);
			return;
		}
		object obj = NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array = new object[2] { num, args };
		bool[] array2 = new bool[2] { true, true };
		NewLateBinding.LateCall(obj, (Type)null, "Insert", array, (string[])null, (Type[])null, array2, true);
		if (array2[0])
		{
			num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
		}
		if (array2[1])
		{
			args = (string[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string[]));
		}
	}

	public void ColumnsInsert(params string[] args)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		args[0] = peremens.UbratKovich(args[0]).str;
		args[1] = peremens.UbratKovich(args[1]).str;
		DataGridViewTextBoxColumn val = new DataGridViewTextBoxColumn();
		DataGridViewColumn val2 = new DataGridViewColumn(val.get_CellTemplate());
		val2.set_Name(args[1]);
		val2.set_HeaderText(args[1]);
		object obj = NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array = new object[2];
		string[] array2 = args[0].Split(new char[1] { ',' });
		int num = 0;
		array[0] = array2[0];
		array[1] = val2;
		object[] array3 = array;
		bool[] array4 = new bool[2] { true, true };
		NewLateBinding.LateCall(obj, (Type)null, "Insert", array3, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			array2[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(string));
		}
		if (array4[1])
		{
			val2 = (DataGridViewColumn)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(DataGridViewColumn));
		}
	}

	public void RowsInsertCopies(params string[] args)
	{
		checked
		{
			if (isDBconnect())
			{
				string selectedRows = SelectedRows;
				int num = Conversions.ToInteger(args[1]);
				int num2 = (int)Math.Round((double)peremens.Int(args[1]) + Conversions.ToDouble(args[2]) - 1.0);
				int num4 = default(int);
				for (int i = num; i <= num2; i++)
				{
					string[] array = new string[3] { typeName, dbName, null };
					string[] array2 = array;
					string text = string.Concat("INSERT INTO " + tablName, " VALUES(");
					object[] array3 = new object[1];
					object obj = this.obj;
					object[] array4 = new object[1] { i };
					string[] array5 = null;
					bool[] array6 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "rows", array4, array5, (Type[])null, array6);
					bool[] array7 = array6;
					int num3 = 0;
					if (array7[0])
					{
						num4 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
						i = num4;
					}
					array3[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj2, (Type)null, "cells", new object[0], (string[])null, (Type[])null, (bool[])null));
					object[] array8 = array3;
					object[] array9 = array8;
					bool[] array10 = new bool[1] { true };
					object obj3 = NewLateBinding.LateGet((object)this, (Type)null, "getVals", array9, (string[])null, (Type[])null, array10);
					if (array10[0])
					{
						object obj4 = NewLateBinding.LateGet(obj, (Type)null, "rows", array4, array5, (Type[])null, new bool[1] { true });
						if (array7[num3])
						{
							i = num4;
						}
						NewLateBinding.LateSetComplex(obj4, (Type)null, "cells", new object[1] { RuntimeHelpers.GetObjectValue(array8[0]) }, (string[])null, (Type[])null, true, true);
					}
					array2[2] = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, obj3), (object)")"));
					SQLqueryInto(array);
				}
				SQLquerySelect(typeName, dbName, lastSelect);
				SelectedRows = selectedRows;
			}
			else
			{
				object obj5 = NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array11 = new object[3];
				object[] array12 = array11;
				int num4 = 1;
				array12[0] = args[1];
				object[] array13 = array11;
				int num3 = 0;
				array13[1] = args[0];
				object[] array14 = array11;
				int num5 = 2;
				array14[2] = args[2];
				object[] array8 = array11;
				object[] array15 = array8;
				bool[] array10 = new bool[3] { true, true, true };
				NewLateBinding.LateCall(obj5, (Type)null, "InsertCopies", array15, (string[])null, (Type[])null, array10, true);
				if (array10[0])
				{
					args[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(string));
				}
				if (array10[1])
				{
					args[num3] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[1]), typeof(string));
				}
				if (array10[2])
				{
					args[num5] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[2]), typeof(string));
				}
				if ((double)peremens.Int(args[0]) <= Conversions.ToDouble(args[1]))
				{
					num5 = 1;
					args[1] = Conversions.ToString(Conversions.ToDouble(args[1]) + (double)peremens.Int(args[2]));
				}
				copyContentRows(Conversions.ToInteger(args[0]), Conversions.ToInteger(args[1]), Conversions.ToInteger(args[2]));
			}
		}
	}

	public void RowsRemove(params string[] args)
	{
		args[0] = peremens.UbratKovich(args[0]).str;
		string[] array = args[0].Split(new char[1] { ',' });
		checked
		{
			int num = array.Length - 1;
			int[] mass = default(int[]);
			for (int i = 0; i <= num; i++)
			{
				peremens.ReDims(ref mass);
				mass[mass.Length - 1] = Conversions.ToInteger(array[i]);
			}
			Array.Sort(mass);
			for (int i = mass.Length - 1; i >= 0; i += -1)
			{
				int[] array2 = mass;
				int num2 = i;
				string str = Conversions.ToString(array2[num2]);
				bool num3 = Iz.isInteger(ref str);
				mass[num2] = Conversions.ToInteger(str);
				if (Conversions.ToBoolean(Operators.AndObject((object)num3, Operators.CompareObjectLess((object)mass[i], NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), false))))
				{
					object obj = this.obj;
					object[] array3 = new object[1];
					int[] array4 = mass;
					num2 = i;
					array3[0] = array4[num2];
					object[] array5 = array3;
					bool[] array6 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Rows", array5, (string[])null, (Type[])null, array6);
					if (array6[0])
					{
						mass[num2] = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(int));
					}
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj2, (Type)null, "IsNewRow", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
					{
						object obj3 = NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array7 = new object[1];
						int[] array8 = mass;
						int num4 = i;
						array7[0] = array8[num4];
						object[] array9 = array7;
						bool[] array10 = new bool[1] { true };
						NewLateBinding.LateCall(obj3, (Type)null, "RemoveAt", array9, (string[])null, (Type[])null, array10, true);
						if (array10[0])
						{
							mass[num4] = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(int));
						}
					}
				}
				else
				{
					Errors.MessangeCritic(Errors.noRows(peremens.trans("удалить строку"), args[0]));
				}
			}
			if (isDBconnect())
			{
			}
		}
	}

	public void ColumnsRemove(params string[] args)
	{
		args[0] = peremens.UbratKovich(args[0]).str;
		string[] array = args[0].Split(new char[1] { ',' });
		checked
		{
			int num = array.Length - 1;
			int[] mass = default(int[]);
			for (int i = 0; i <= num; i++)
			{
				peremens.ReDims(ref mass);
				mass[mass.Length - 1] = Conversions.ToInteger(array[i]);
			}
			Array.Sort(mass);
			for (int i = mass.Length - 1; i >= 0; i += -1)
			{
				int[] array2 = mass;
				int num2 = i;
				string str = Conversions.ToString(array2[num2]);
				bool num3 = Iz.isInteger(ref str);
				mass[num2] = Conversions.ToInteger(str);
				if (Conversions.ToBoolean(Operators.AndObject((object)num3, Operators.CompareObjectLess((object)mass[i], NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), false))))
				{
					object obj = NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array3 = new object[1];
					int[] array4 = mass;
					int num4 = i;
					array3[0] = array4[num4];
					object[] array5 = array3;
					bool[] array6 = new bool[1] { true };
					NewLateBinding.LateCall(obj, (Type)null, "RemoveAt", array5, (string[])null, (Type[])null, array6, true);
					if (array6[0])
					{
						mass[num4] = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(int));
					}
				}
				else
				{
					Errors.MessangeCritic(Errors.noColumns(peremens.trans("удалить столбец"), args[0]));
				}
			}
		}
	}

	public DataGridViewCell[] getSortCells(DataGridViewSelectedCellCollection coll)
	{
		DataGridViewCell[] array = (DataGridViewCell[])(object)new DataGridViewCell[checked(((BaseCollection)coll).get_Count() - 1 + 1)];
		coll.CopyTo(array, 0);
		Array.Sort(array, new peremens.SortByDataGridCell());
		return array;
	}

	public string SearchInTable(params string[] args)
	{
		string text = args[0];
		StringComparison comparisonType = ((!peremens.DaOrNet(args[1])) ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture);
		bool flag = peremens.DaOrNet(args[2]);
		args[3] = args[3].Split(new char[1] { ',' })[0];
		args[4] = args[4].Split(new char[1] { ',' })[0];
		if (Operators.CompareString(args[3], "", false) == 0)
		{
			args[3] = Conversions.ToString(0);
		}
		if (Operators.CompareString(args[4], "", false) == 0)
		{
			args[4] = Conversions.ToString(0);
		}
		int num = Conversions.ToInteger(args[3]);
		int num2 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		checked
		{
			for (int i = num; i <= num2; i++)
			{
				int num3 = Conversions.ToInteger(args[4]);
				int num4 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				for (int j = num3; j <= num4; j++)
				{
					object obj = this.obj;
					object[] array = new object[1] { i };
					bool[] array2 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Rows", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					object[] array3 = new object[1] { j };
					bool[] array4 = new bool[1] { true };
					object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "Cells", array3, (string[])null, (Type[])null, array4);
					if (array4[0])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
					}
					string text2 = Conversions.ToString(NewLateBinding.LateGet(obj3, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
					if (text2 == null)
					{
						continue;
					}
					int num5 = text2.IndexOf(text, 0, comparisonType);
					while (num5 != -1)
					{
						if (unchecked(num5 != -1 && flag) && text2.Length > num5 + text.Length && char.IsLetterOrDigit(text2[num5 + text.Length]))
						{
							num5 = text2.IndexOf(text, num5 + text.Length, comparisonType);
						}
						else if (num5 != -1)
						{
							return Conversions.ToString(i) + "," + Conversions.ToString(j);
						}
					}
				}
				args[4] = Conversions.ToString(0);
			}
			return "-1,-1";
		}
	}

	public string SearchInSelectedCells(params string[] args)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string text = args[0];
		StringComparison stringComparison = ((!peremens.DaOrNet(args[1])) ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture);
		bool flag = peremens.DaOrNet(args[2]);
		DataGridViewCell[] sortCells = getSortCells((DataGridViewSelectedCellCollection)NewLateBinding.LateGet(this.obj, (Type)null, "SelectedCells", new object[0], (string[])null, (Type[])null, (bool[])null));
		checked
		{
			int num = sortCells.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				object value = sortCells[i].get_Value();
				object[] array = new object[3] { text, 0, stringComparison };
				object[] array2 = array;
				bool[] array3 = new bool[3] { true, false, true };
				object obj = NewLateBinding.LateGet(value, (Type)null, "IndexOf", array2, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				if (array3[2])
				{
					stringComparison = (StringComparison)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(StringComparison));
				}
				int num2 = Conversions.ToInteger(obj);
				while (num2 != -1)
				{
					if (unchecked(num2 != -1 && flag) && Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(sortCells[i].get_Value(), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(num2 + text.Length), false) && char.IsLetterOrDigit(Conversions.ToChar(NewLateBinding.LateGet(sortCells[i].get_Value(), (Type)null, "Chars", new object[1] { num2 + text.Length }, (string[])null, (Type[])null, (bool[])null))))
					{
						object value2 = sortCells[i].get_Value();
						object[] array4 = new object[3]
						{
							text,
							num2 + text.Length,
							stringComparison
						};
						object[] array5 = array4;
						array3 = new bool[3] { true, false, true };
						object obj2 = NewLateBinding.LateGet(value2, (Type)null, "IndexOf", array5, (string[])null, (Type[])null, array3);
						if (array3[0])
						{
							text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
						}
						if (array3[2])
						{
							stringComparison = (StringComparison)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[2]), typeof(StringComparison));
						}
						num2 = Conversions.ToInteger(obj2);
					}
					else if (num2 != -1)
					{
						return Conversions.ToString(sortCells[i].get_RowIndex()) + "," + Conversions.ToString(sortCells[i].get_ColumnIndex());
					}
				}
			}
			return "-1,-1";
		}
	}

	public void SearchWithSelect(params string[] args)
	{
		while (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "SelectedCells", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.obj, (Type)null, "SelectedCells", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		}
		string text = args[0];
		StringComparison comparisonType = ((!peremens.DaOrNet(args[1])) ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture);
		bool flag = peremens.DaOrNet(args[2]);
		args[3] = args[3].Split(new char[1] { ',' })[0];
		args[4] = args[4].Split(new char[1] { ',' })[0];
		if (Operators.CompareString(args[3], "", false) == 0)
		{
			args[3] = Conversions.ToString(0);
		}
		if (Operators.CompareString(args[4], "", false) == 0)
		{
			args[4] = Conversions.ToString(0);
		}
		int num = Conversions.ToInteger(args[3]);
		int num2 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		checked
		{
			for (int i = num; i <= num2; i++)
			{
				int num3 = Conversions.ToInteger(args[4]);
				int num4 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				for (int j = num3; j <= num4; j++)
				{
					object obj = this.obj;
					object[] array = new object[1] { i };
					object[] array2 = array;
					bool[] array3 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Rows", array2, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					object[] array4 = new object[1] { j };
					object[] array5 = array4;
					bool[] array6 = new bool[1] { true };
					object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "Cells", array5, (string[])null, (Type[])null, array6);
					if (array6[0])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
					}
					string text2 = Conversions.ToString(NewLateBinding.LateGet(obj3, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
					if (text2 == null)
					{
						continue;
					}
					int num5 = text2.IndexOf(text, 0, comparisonType);
					while (num5 != -1)
					{
						if (unchecked(num5 != -1 && flag) && text2.Length > num5 + text.Length && char.IsLetterOrDigit(text2[num5 + text.Length]))
						{
							num5 = text2.IndexOf(text, num5 + text.Length, comparisonType);
						}
						else if (num5 != -1)
						{
							object obj4 = this.obj;
							object[] array7 = new object[1] { i };
							object[] array8 = array7;
							array6 = new bool[1] { true };
							object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "Rows", array8, (string[])null, (Type[])null, array6);
							if (array6[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(int));
							}
							array = new object[1] { j };
							object[] array9 = array;
							array3 = new bool[1] { true };
							object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "Cells", array9, (string[])null, (Type[])null, array3);
							if (array3[0])
							{
								j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
							}
							NewLateBinding.LateSetComplex(obj6, (Type)null, "Selected", new object[1] { true }, (string[])null, (Type[])null, false, true);
							break;
						}
					}
				}
				args[4] = Conversions.ToString(0);
			}
		}
	}

	public void SaveTable(params string[] args)
	{
		try
		{
			args[0] = peremens.GetMaxPath(args[0]);
			File.WriteAllText(peremens.UbratKovich(args[0]).str, Columns + "~\"\"\"~" + Rows, Encoding.UTF8);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(Errors.FileNotCreate(ex2.Message));
			}
			ProjectData.ClearProjectError();
		}
	}

	public void OpenTable(params string[] args)
	{
		typeName = "";
		dbName = "";
		tablName = "";
		args[0] = peremens.GetMaxPath(args[0]);
		string text = File.ReadAllText(peremens.UbratKovich(args[0]).str, Encoding.UTF8);
		string[] separator = new string[1] { "~\"\"\"~" };
		Columns = text.Split(separator, StringSplitOptions.None)[0];
		Rows = text.Split(separator, StringSplitOptions.None)[1];
	}

	public void OpenAccess(params string[] args)
	{
		typeName = "Access";
		dbName = args[0];
		tablName = args[1];
		lastSelect = "SELECT * FROM [" + tablName + "]";
		SQLquerySelect(typeName, dbName, lastSelect);
	}

	public void OpenExcel(params string[] args)
	{
		typeName = "Excel";
		dbName = args[0];
		tablName = args[1];
		lastSelect = "SELECT * FROM [" + tablName + "]";
		SQLquerySelect(typeName, dbName, lastSelect);
	}

	public void SaveAccess(params string[] args)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		if (Operators.CompareString(typeName, "Access", false) != 0)
		{
			if (!peremens.IgnorEr)
			{
				Interaction.MsgBox((object)Errors.notTableAccess(), (MsgBoxStyle)0, (object)null);
			}
			return;
		}
		cn.Close();
		if (!openOleSql())
		{
			return;
		}
		int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2));
		checked
		{
			for (int i = 0; i <= num; i++)
			{
				string text = "Insert into [" + tablName + "] values(";
				int num2 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				for (int j = 0; j <= num2; j++)
				{
					object obj = this.obj;
					object[] array = new object[1] { i };
					bool[] array2 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Rows", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					object[] array3 = new object[1] { j };
					bool[] array4 = new bool[1] { true };
					object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "Cells", array3, (string[])null, (Type[])null, array4);
					if (array4[0])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
					}
					object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
					text = ((!((objectValue == null) | (objectValue == DBNull.Value))) ? Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject(Operators.ConcatenateObject((object)"'", objectValue), (object)"'"))) : (text + "null"));
					if (Operators.ConditionalCompareObjectLess((object)j, Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "ColumnCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1), false))
					{
						text += ",";
					}
				}
				text += ")";
				cmd = new OleDbCommand(text, cn);
				cmd.ExecuteNonQuery();
			}
			cn.Close();
		}
	}

	public void SQLquerySelect(params string[] args)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		cmd = ConnectToDB(ref args[0], ref args[1], ref args[2]);
		if (cmd == null)
		{
			return;
		}
		dr = cmd.ExecuteReader();
		lastSelect = args[2];
		if (dr.get_IsClosed())
		{
			Interaction.MsgBox((object)peremens.trans("Соединение к БД закрыто"), (MsgBoxStyle)0, (object)null);
			return;
		}
		isSelecExecute = true;
		checked
		{
			int num = dr.get_FieldCount() - 1;
			int i;
			for (i = 0; i <= num; i++)
			{
				if (Operators.ConditionalCompareObjectLess((object)i, NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					object obj = this.obj;
					object[] array = new object[1] { i };
					object[] array2 = array;
					bool[] array3 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Columns", array2, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					NewLateBinding.LateSetComplex(obj2, (Type)null, "HeaderText", new object[1] { dr.GetName(i) }, (string[])null, (Type[])null, false, true);
					object obj3 = this.obj;
					array = new object[1] { i };
					object[] array4 = array;
					array3 = new bool[1] { true };
					object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "Columns", array4, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					NewLateBinding.LateSetComplex(obj4, (Type)null, "ValueType", new object[1] { dr.GetFieldType(i) }, (string[])null, (Type[])null, false, true);
				}
				else
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Add", new object[2]
					{
						dr.GetName(i),
						dr.GetName(i)
					}, (string[])null, (Type[])null, (bool[])null, true);
					object obj5 = this.obj;
					object[] array = new object[1] { i };
					object[] array5 = array;
					bool[] array3 = new bool[1] { true };
					object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "Columns", array5, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					NewLateBinding.LateSetComplex(obj6, (Type)null, "ValueType", new object[1] { dr.GetFieldType(i) }, (string[])null, (Type[])null, false, true);
				}
			}
			int num2 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			int num3 = i;
			for (i = num2; i >= num3; i += -1)
			{
				object obj7 = NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array = new object[1] { i };
				object[] array6 = array;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj7, (Type)null, "RemoveAt", array6, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
			}
			object[] array7 = new object[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
			i = 0;
			while (dr.Read())
			{
				dr.GetValues(array7);
				if (Operators.ConditionalCompareObjectLess((object)i, NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), false))
				{
					object obj8 = this.obj;
					object[] array = new object[1] { i };
					object[] array8 = array;
					bool[] array3 = new bool[1] { true };
					object obj9 = NewLateBinding.LateGet(obj8, (Type)null, "rows", array8, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj9, (Type)null, "isNewRow", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
					{
						int num4 = array7.Length - 1;
						for (int j = 0; j <= num4; j++)
						{
							object obj10 = this.obj;
							object[] array9 = new object[1] { i };
							object[] array10 = array9;
							bool[] array11 = new bool[1] { true };
							object obj11 = NewLateBinding.LateGet(obj10, (Type)null, "rows", array10, (string[])null, (Type[])null, array11);
							if (array11[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(int));
							}
							object[] array12 = new object[1] { j };
							object[] array13 = array12;
							bool[] array14 = new bool[1] { true };
							object obj12 = NewLateBinding.LateGet(obj11, (Type)null, "cells", array13, (string[])null, (Type[])null, array14);
							if (array14[0])
							{
								j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(int));
							}
							NewLateBinding.LateSetComplex(obj12, (Type)null, "value", new object[1] { RuntimeHelpers.GetObjectValue(array7[j]) }, (string[])null, (Type[])null, false, true);
						}
					}
					else
					{
						object obj13 = NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array12 = new object[1] { array7 };
						object[] array15 = array12;
						bool[] array14 = new bool[1] { true };
						NewLateBinding.LateCall(obj13, (Type)null, "Add", array15, (string[])null, (Type[])null, array14, true);
						if (array14[0])
						{
							array7 = (object[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(object[]));
						}
					}
				}
				else
				{
					object obj14 = NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array12 = new object[1] { array7 };
					object[] array16 = array12;
					bool[] array14 = new bool[1] { true };
					NewLateBinding.LateCall(obj14, (Type)null, "Add", array16, (string[])null, (Type[])null, array14, true);
					if (array14[0])
					{
						array7 = (object[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(object[]));
					}
				}
				i++;
			}
			int num5 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			int num6 = i;
			for (i = num5; i >= num6; i += -1)
			{
				object obj15 = this.obj;
				object[] array12 = new object[1] { i };
				object[] array17 = array12;
				bool[] array14 = new bool[1] { true };
				object obj16 = NewLateBinding.LateGet(obj15, (Type)null, "rows", array17, (string[])null, (Type[])null, array14);
				if (array14[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(int));
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj16, (Type)null, "isNewRow", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
				{
					object obj17 = NewLateBinding.LateGet(this.obj, (Type)null, "rows", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array9 = new object[1] { i };
					object[] array18 = array9;
					bool[] array11 = new bool[1] { true };
					NewLateBinding.LateCall(obj17, (Type)null, "RemoveAt", array18, (string[])null, (Type[])null, array11, true);
					if (array11[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(int));
					}
				}
			}
			if (i < 0)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(this.obj, (Type)null, "rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			dr.Close();
			cn.Close();
			isSelecExecute = false;
		}
	}

	public void SQLqueryInto(params string[] args)
	{
		cmd = ConnectToDB(ref args[0], ref args[1], ref args[2]);
		if (cmd != null)
		{
			cmd.ExecuteReader();
		}
		cn.Close();
	}

	public OleDbCommand ConnectToDB(ref string tip, ref string file, ref string command)
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		string text = "";
		file = peremens.GetMaxPath(file);
		if (Operators.CompareString(Strings.UCase(tip), Strings.UCase("Access"), false) == 0)
		{
			text = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + file + "; Persist Security Info = false";
		}
		else
		{
			if (Operators.CompareString(Strings.UCase(tip), Strings.UCase("Excel"), false) != 0)
			{
				return null;
			}
			text = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + file + "; Extended Properties = 'Excel 12.0; HDR = Yes'";
		}
		dt = new DataTable("Temp");
		if (Operators.CompareString(text, cn.get_ConnectionString(), false) != 0)
		{
			cn.Close();
			cn.set_ConnectionString(text);
			if (!openOleSql())
			{
				return null;
			}
		}
		else if (cn.get_State() != ConnectionState.Open && !openOleSql())
		{
			return null;
		}
		return new OleDbCommand(command, cn);
	}

	public bool openOleSql()
	{
		try
		{
			cn.Open();
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (ex2.InnerException != null)
			{
				Interaction.InputBox("Ошибка: " + ex2.Message + "\r\n\r\nОбратитесь на support@algoritm2.ru, если не поможет переустановка MDAC отсюда:", "MDAC", "http://download.microsoft.com/download/c/f/2/cf2b5cd9-7ffd-4c19-971f-9ccaf0b57d48/MDAC_TYP.EXE", -1, -1);
			}
			else
			{
				Errors.MessangeExclamen(ex2.Message);
			}
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void SortTable(params string[] args)
	{
		if (peremens.DaOrNet(args[1]))
		{
			object obj = this.obj;
			object[] array = new object[2];
			object[] array2 = array;
			object obj2 = this.obj;
			object obj3 = obj2;
			object[] array3 = new object[1];
			object[] array4 = array3;
			short num = Convert.ToInt16(args[0]);
			array4[0] = num;
			array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "Columns", array3, (string[])null, (Type[])null, (bool[])null));
			array[1] = ListSortDirection.Ascending;
			object[] array5 = array;
			object[] array6 = array5;
			bool[] array7 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj, (Type)null, "Sort", array6, (string[])null, (Type[])null, array7, true);
			if (array7[0])
			{
				NewLateBinding.LateSetComplex(obj2, (Type)null, "Columns", new object[2]
				{
					num,
					RuntimeHelpers.GetObjectValue(array5[0])
				}, (string[])null, (Type[])null, true, false);
			}
		}
		else
		{
			object obj4 = this.obj;
			object[] array5 = new object[2];
			object[] array8 = array5;
			object obj2 = this.obj;
			object obj5 = obj2;
			object[] array9 = new object[1];
			object[] array10 = array9;
			short num = Convert.ToInt16(args[0]);
			array10[0] = num;
			array8[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj5, (Type)null, "Columns", array9, (string[])null, (Type[])null, (bool[])null));
			array5[1] = ListSortDirection.Descending;
			object[] array = array5;
			object[] array11 = array;
			bool[] array7 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj4, (Type)null, "Sort", array11, (string[])null, (Type[])null, array7, true);
			if (array7[0])
			{
				NewLateBinding.LateSetComplex(obj2, (Type)null, "Columns", new object[2]
				{
					num,
					RuntimeHelpers.GetObjectValue(array[0])
				}, (string[])null, (Type[])null, true, false);
			}
		}
	}

	public string HitTest(params string[] args)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		object obj = this.obj;
		object[] array = new object[2];
		object[] array2 = array;
		int num = 0;
		array2[0] = args[0];
		object[] array3 = array;
		int num2 = 1;
		array3[1] = args[1];
		object[] array4 = array;
		object[] array5 = array4;
		bool[] array6 = new bool[2] { true, true };
		object obj2 = NewLateBinding.LateGet(obj, (Type)null, "HitTest", array5, (string[])null, (Type[])null, array6);
		if (array6[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
		}
		if (array6[1])
		{
			args[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(string));
		}
		HitTestInfo val = (HitTestInfo)obj2;
		if ((val.get_ColumnIndex() != -1) & (val.get_RowIndex() != -1))
		{
			return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[1] { val.get_RowIndex() }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Cells", new object[1] { val.get_ColumnIndex() }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		return "";
	}

	public string HitTestColumn(params string[] args)
	{
		object obj = this.obj;
		object[] array = new object[2];
		int num = 0;
		array[0] = args[0];
		int num2 = 1;
		array[1] = args[1];
		object[] array2 = array;
		bool[] array3 = new bool[2] { true, true };
		object obj2 = NewLateBinding.LateGet(obj, (Type)null, "HitTest", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
		if (array3[1])
		{
			args[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
		}
		return Conversions.ToString(NewLateBinding.LateGet(obj2, (Type)null, "ColumnIndex", new object[0], (string[])null, (Type[])null, (bool[])null));
	}

	public string HitTestRow(params string[] args)
	{
		object obj = this.obj;
		object[] array = new object[2];
		int num = 0;
		array[0] = args[0];
		int num2 = 1;
		array[1] = args[1];
		object[] array2 = array;
		bool[] array3 = new bool[2] { true, true };
		object obj2 = NewLateBinding.LateGet(obj, (Type)null, "HitTest", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
		if (array3[1])
		{
			args[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
		}
		return Conversions.ToString(NewLateBinding.LateGet(obj2, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null));
	}

	public void ItemsAdd(params string[] args)
	{
		object obj = NewLateBinding.LateGet(this.obj, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array = new object[1];
		int num = 0;
		array[0] = args[0];
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "Add", array2, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
	}

	public void ItemsInsert(params string[] args)
	{
		object obj = NewLateBinding.LateGet(this.obj, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array = new object[2];
		int num = 0;
		array[0] = args[0];
		int num2 = 1;
		array[1] = args[1];
		object[] array2 = array;
		bool[] array3 = new bool[2] { true, true };
		NewLateBinding.LateCall(obj, (Type)null, "Insert", array2, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
		if (array3[1])
		{
			args[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
		}
	}

	public void ItemsRemove(params string[] args)
	{
		object obj = NewLateBinding.LateGet(this.obj, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array = new object[1];
		int num = 0;
		array[0] = args[0];
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "Remove", array2, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
	}

	public void ItemsRemoveAt(params string[] args)
	{
		object obj = NewLateBinding.LateGet(this.obj, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array = new object[1];
		int num = 0;
		array[0] = args[0];
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "RemoveAt", array2, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
	}

	public void GoInternetLink(string link = null)
	{
		if (Operators.CompareString(link, (string)null, false) == 0)
		{
			link = LinkName;
		}
		Uri urlFromString = peremens.GetUrlFromString(link);
		try
		{
			if ((object)urlFromString != null)
			{
				Process.Start(urlFromString.AbsoluteUri);
			}
			else
			{
				Process.Start(link);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(ex2.Message);
			}
			ProjectData.ClearProjectError();
		}
	}

	public void SaveFile(params string[] args)
	{
		try
		{
			object obj = this.obj;
			object[] array = new object[1];
			int num = 0;
			array[0] = args[0];
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			NewLateBinding.LateCall(obj, (Type)null, "SaveFile", array2, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(Errors.FileNotCreate(ex2.Message));
			}
			ProjectData.ClearProjectError();
		}
	}

	public void OpenFile(params string[] args)
	{
		try
		{
			if (Operators.CompareString(args[0], "", false) != 0)
			{
				object obj = this.obj;
				object[] array = new object[1];
				int num = 0;
				array[0] = args[0];
				object[] array2 = array;
				bool[] array3 = new bool[1] { true };
				NewLateBinding.LateCall(obj, (Type)null, "LoadFile", array2, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				Errors.MessangeCritic(Errors.FileNotCreate(ex2.Message));
			}
			ProjectData.ClearProjectError();
		}
	}

	public void ShowDialog()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Invalid comparison between Unknown and I4
		DialogResult val = ((!(Iz.IsCDobj(RuntimeHelpers.GetObjectValue(this.obj)) | Iz.IsFDobj(RuntimeHelpers.GetObjectValue(this.obj)))) ? ((DialogResult)Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "dialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null))) : ((DialogResult)Conversions.ToInteger(NewLateBinding.LateGet(this.obj, (Type)null, "ShowDialog", new object[0], (string[])null, (Type[])null, (bool[])null))));
		if (Iz.IsFDobj(RuntimeHelpers.GetObjectValue(this.obj)))
		{
			FontFamily = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FontFamily", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null));
			Type typeFromHandle = typeof(peremens);
			object[] array = new object[1];
			object[] array2 = array;
			object obj = this.obj;
			object obj2 = obj;
			object[] array3 = new object[0];
			object[] array4 = array3;
			string[] array5 = null;
			array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "font", array4, array5, (Type[])null, (bool[])null), (Type)null, "bold", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array6 = array;
			object[] array7 = array6;
			bool[] array8 = new bool[1] { true };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array7, (string[])null, (Type[])null, array8);
			if (array8[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "font", array3, array5, (Type[])null, (bool[])null), (Type)null, "bold", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, true);
			}
			FontBold = Conversions.ToString(obj3);
			Type typeFromHandle2 = typeof(peremens);
			array6 = new object[1];
			object[] array9 = array6;
			obj = this.obj;
			object obj4 = obj;
			object[] array10 = new object[0];
			object[] array11 = array10;
			array5 = null;
			array9[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "font", array11, array5, (Type[])null, (bool[])null), (Type)null, "italic", new object[0], (string[])null, (Type[])null, (bool[])null));
			array = array6;
			object[] array12 = array;
			array8 = new bool[1] { true };
			object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle2, "DaOrNet", array12, (string[])null, (Type[])null, array8);
			if (array8[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "font", array10, array5, (Type[])null, (bool[])null), (Type)null, "italic", new object[1] { RuntimeHelpers.GetObjectValue(array[0]) }, (string[])null, (Type[])null, true, true);
			}
			FontItalic = Conversions.ToString(obj5);
			Type typeFromHandle3 = typeof(peremens);
			array6 = new object[1];
			object[] array13 = array6;
			obj = this.obj;
			object obj6 = obj;
			array10 = new object[0];
			object[] array14 = array10;
			array5 = null;
			array13[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj6, (Type)null, "font", array14, array5, (Type[])null, (bool[])null), (Type)null, "underline", new object[0], (string[])null, (Type[])null, (bool[])null));
			array = array6;
			object[] array15 = array;
			array8 = new bool[1] { true };
			object obj7 = NewLateBinding.LateGet((object)null, typeFromHandle3, "DaOrNet", array15, (string[])null, (Type[])null, array8);
			if (array8[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "font", array10, array5, (Type[])null, (bool[])null), (Type)null, "underline", new object[1] { RuntimeHelpers.GetObjectValue(array[0]) }, (string[])null, (Type[])null, true, true);
			}
			FontUnderline = Conversions.ToString(obj7);
			Type typeFromHandle4 = typeof(peremens);
			array6 = new object[1];
			object[] array16 = array6;
			obj = this.obj;
			object obj8 = obj;
			array10 = new object[0];
			object[] array17 = array10;
			array5 = null;
			array16[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj8, (Type)null, "font", array17, array5, (Type[])null, (bool[])null), (Type)null, "Strikeout", new object[0], (string[])null, (Type[])null, (bool[])null));
			array = array6;
			object[] array18 = array;
			array8 = new bool[1] { true };
			object obj9 = NewLateBinding.LateGet((object)null, typeFromHandle4, "DaOrNet", array18, (string[])null, (Type[])null, array8);
			if (array8[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "font", array10, array5, (Type[])null, (bool[])null), (Type)null, "Strikeout", new object[1] { RuntimeHelpers.GetObjectValue(array[0]) }, (string[])null, (Type[])null, true, true);
			}
			FontStrikeout = Conversions.ToString(obj9);
		}
		if ((int)val == 1)
		{
			WasCancel = peremens.trans("Нет");
		}
		else
		{
			WasCancel = peremens.trans("Да");
		}
	}

	public void ShowPrevDialog()
	{
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "prevdialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Document", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSet(obj, (Type)null, "isPreview", new object[1] { true }, (string[])null, (Type[])null);
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "prevdialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "showdialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
		{
			WasCancel = peremens.trans("Нет");
		}
		else
		{
			WasCancel = peremens.trans("Да");
		}
		NewLateBinding.LateSet(obj, (Type)null, "isPreview", new object[1] { false }, (string[])null, (Type[])null);
	}

	public void ShowPageDialog()
	{
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "pagedialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Document", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "pagedialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "showdialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
		{
			WasCancel = peremens.trans("Нет");
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DefaultPageSettings", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "PageDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PageSettings", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
			PaddingLeft = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "PageDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PageSettings", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Margins", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null));
			PaddingRight = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "PageDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PageSettings", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Margins", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Right", new object[0], (string[])null, (Type[])null, (bool[])null));
			PaddingTop = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "PageDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PageSettings", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Margins", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[0], (string[])null, (Type[])null, (bool[])null));
			PaddingBottom = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "PageDialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PageSettings", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Margins", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Bottom", new object[0], (string[])null, (Type[])null, (bool[])null));
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrinterSettings", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Copies", new object[1] { Copies }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrinterSettings", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToPage", new object[1] { ToPage }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrinterSettings", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FromPage", new object[1] { FromPage }, (string[])null, (Type[])null, false, true);
		}
		else
		{
			WasCancel = peremens.trans("Да");
		}
	}

	public void ShowPrinDialog()
	{
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		NewLateBinding.LateSet(obj, (Type)null, "isPreview", new object[1] { false }, (string[])null, (Type[])null);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "prindialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Document", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "prindialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrinterSettings", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrinterSettings", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
		try
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "prindialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "showdialog", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(DialogResult)1, false))
			{
				WasCancel = peremens.trans("Нет");
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrinterSettings", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "prindialog", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrinterSettings", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
				Copies = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrinterSettings", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Copies", new object[0], (string[])null, (Type[])null, (bool[])null));
				ToPage = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrinterSettings", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToPage", new object[0], (string[])null, (Type[])null, (bool[])null));
				FromPage = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "PrinterSettings", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "FromPage", new object[0], (string[])null, (Type[])null, (bool[])null));
				NewLateBinding.LateCall(NewLateBinding.LateGet(obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Print", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else
			{
				WasCancel = peremens.trans("Да");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)("fff" + ex2.Message), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public string getBiDat()
	{
		object obj = RuntimeHelpers.GetObjectValue(Registry.LocalMachine.OpenSubKey("Hardware\\Description\\System")!.GetValue("SystemBiosVersion"));
		if (Information.IsArray(RuntimeHelpers.GetObjectValue(obj)))
		{
			obj = string.Join(" ", (string[])obj);
		}
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(obj, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)5, false))
		{
			obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Substring", new object[2] { 0, 5 }, (string[])null, (Type[])null, (bool[])null));
		}
		return Conversions.ToString(obj);
	}

	public string KeyValidation(params string[] args)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		Registry.CurrentUser.CreateSubKey("Software\\" + IdRegistryProgram).SetValue("K", args[0]);
		string activation = Activation;
		if (args.Length > 1 && peremens.DaOrNet(args[1]))
		{
			if (peremens.DaOrNet(activation))
			{
				Interaction.MsgBox((object)MessageValid, (MsgBoxStyle)0, (object)null);
			}
			else
			{
				Interaction.MsgBox((object)MessageInvalid, (MsgBoxStyle)0, (object)null);
			}
		}
		return activation;
	}

	public string KeyIssue(params string[] args)
	{
		string text = DecryptRSA(args[0]);
		string result = EncryptRSA(text + IdProgram);
		if (args.Length > 1 && peremens.DaOrNet(args[1]))
		{
			Interaction.InputBox(peremens.trans("Ваш ключ активации") + ":", "", KeyIssue(args[0]), -1, -1);
		}
		return result;
	}

	public string EncryptRSA(string str)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		if (KeyEncryption == null)
		{
			return "";
		}
		rSACryptoServiceProvider.FromXmlString(KeyEncryption);
		byte[] bytes = Encoding.UTF8.GetBytes(str);
		bytes = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: true);
		return peremens.toStrArray(bytes);
	}

	public string DecryptRSA(string str)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		if (KeyEncryption == null)
		{
			return "";
		}
		rSACryptoServiceProvider.FromXmlString(KeyEncryption);
		byte[] rgb = peremens.toByteArray(str);
		rgb = rSACryptoServiceProvider.Decrypt(rgb, fOAEP: true);
		return Encoding.UTF8.GetString(rgb);
	}

	public void TrialStart()
	{
		checked
		{
			long num = (long)Math.Round(Conversions.ToDouble(DaysAll) * 60.0 * 60.0 * 24.0);
			num *= 10000000L;
			string value = EncryptRSA(Conversions.ToString(DateAndTime.get_Now().Ticks + num));
			Registry.CurrentUser.CreateSubKey("Software\\" + IdRegistryProgram).SetValue("D", value);
			string value2 = EncryptRSA(Conversions.ToString(DateAndTime.get_Now().Ticks));
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\" + IdRegistryProgram).SetValue("L", value2);
		}
	}

	public void ActivationCancel()
	{
		Activation = peremens.DaOrNet(@bool: false);
	}

	public string LastTime()
	{
		string text = "";
		try
		{
			text = Conversions.ToString(Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\" + IdRegistryProgram)!.GetValue("L"));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = Conversions.ToString(0);
			ProjectData.ClearProjectError();
			return result;
		}
		if (text == null)
		{
			return Conversions.ToString(0);
		}
		if (text.Length % 3 != 0)
		{
			return Conversions.ToString(0);
		}
		return DecryptRSA(text);
	}

	public void SendToServer(params string[] args)
	{
		object obj = this.obj;
		object[] array = new object[1];
		int num = 0;
		array[0] = args[0];
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "SendToServer", array2, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
	}

	public void SendFileToServer(params string[] args)
	{
		object obj = this.obj;
		object[] array = new object[1];
		int num = 0;
		array[0] = args[0];
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "SendFileToServer", array2, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
	}

	public void SendToClients(params string[] args)
	{
		object obj = this.obj;
		object[] array = new object[1];
		int num = 0;
		array[0] = args[0];
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "SendToClients", array2, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
	}

	public void SendToClientsBut(params string[] args)
	{
		object obj = this.obj;
		object[] array = new object[2];
		int num = 0;
		array[0] = args[0];
		int num2 = 1;
		array[1] = args[1];
		object[] array2 = array;
		bool[] array3 = new bool[2] { true, true };
		NewLateBinding.LateCall(obj, (Type)null, "SendToClientsBut", array2, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
		if (array3[1])
		{
			args[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
		}
	}

	public void SendToClient(params string[] args)
	{
		object obj = this.obj;
		object[] array = new object[2];
		int num = 0;
		array[0] = args[0];
		int num2 = 1;
		array[1] = args[1];
		object[] array2 = array;
		bool[] array3 = new bool[2] { true, true };
		NewLateBinding.LateCall(obj, (Type)null, "SendToClient", array2, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
		if (array3[1])
		{
			args[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
		}
	}

	public void SendFileToClients(params string[] args)
	{
		object obj = this.obj;
		object[] array = new object[1];
		int num = 0;
		array[0] = args[0];
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "SendFileToClients", array2, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
	}

	public void SendFileToClientsBut(params string[] args)
	{
		object obj = this.obj;
		object[] array = new object[2];
		int num = 0;
		array[0] = args[0];
		int num2 = 1;
		array[1] = args[1];
		object[] array2 = array;
		bool[] array3 = new bool[2] { true, true };
		NewLateBinding.LateCall(obj, (Type)null, "SendFileToClientsBut", array2, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
		if (array3[1])
		{
			args[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
		}
	}

	public void SendFileToClient(params string[] args)
	{
		object obj = this.obj;
		object[] array = new object[2];
		int num = 0;
		array[0] = args[0];
		int num2 = 1;
		array[1] = args[1];
		object[] array2 = array;
		bool[] array3 = new bool[2] { true, true };
		NewLateBinding.LateCall(obj, (Type)null, "SendFileToClient", array2, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
		if (array3[1])
		{
			args[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
		}
	}

	public void Log(params string[] args)
	{
		object obj = this.obj;
		object[] array = new object[1];
		int num = 0;
		array[0] = args[0];
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "Log", array2, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
	}

	public void RunCommand(params string[] args)
	{
		object obj = this.obj;
		object[] array = new object[1];
		int num = 0;
		array[0] = args[0];
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "RunCommand", array2, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
	}

	public void ConnectToServer()
	{
		NewLateBinding.LateCall(obj, (Type)null, "ConnectToServer", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void CreateServer()
	{
		NewLateBinding.LateCall(obj, (Type)null, "CreateServer", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void BeginListen()
	{
		NewLateBinding.LateCall(obj, (Type)null, "BeginListen", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void CloseServer()
	{
		NewLateBinding.LateCall(obj, (Type)null, "CloseServer", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void CloseListener()
	{
		NewLateBinding.LateCall(obj, (Type)null, "CloseListener", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void CloseClient()
	{
		NewLateBinding.LateCall(obj, (Type)null, "CloseClient", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void ClearCookie()
	{
		CookiesQueries = "";
	}

	public void GetSourceCodePage(params string[] args)
	{
		try
		{
			object obj = this.obj;
			object[] array = new object[1];
			int num = 0;
			array[0] = args[0];
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			NewLateBinding.LateCall(obj, (Type)null, "GetSourceCodePage", array2, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				throw ex2;
			}
			ProjectData.ClearProjectError();
		}
	}

	public void DownloadFile(params string[] args)
	{
		try
		{
			object obj = this.obj;
			object[] array = new object[2];
			int num = 0;
			array[0] = args[0];
			array[1] = peremens.DaOrNet(args[1]);
			object[] array2 = array;
			object[] array3 = array2;
			bool[] array4 = new bool[2] { true, false };
			NewLateBinding.LateCall(obj, (Type)null, "DownloadFile", array3, (string[])null, (Type[])null, array4, true);
			if (array4[0])
			{
				args[num] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			NewLateBinding.LateSet(this.obj, (Type)null, "FileDownloading", new object[1] { false }, (string[])null, (Type[])null);
			if (!peremens.IgnorEr)
			{
				throw ex2;
			}
			ProjectData.ClearProjectError();
		}
	}

	public void ExecuteQuery()
	{
		try
		{
			NewLateBinding.LateCall(obj, (Type)null, "ExecuteQuery", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				throw ex2;
			}
			ProjectData.ClearProjectError();
		}
	}

	public void DownloadCancel()
	{
		NewLateBinding.LateCall(obj, (Type)null, "DownloadCancel", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void DownloadResume()
	{
		NewLateBinding.LateCall(obj, (Type)null, "DownloadResume", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Refresh()
	{
		NewLateBinding.LateCall(obj, (Type)null, "Refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		if (Iz.IsMd(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			Fit();
		}
	}

	public void Focus()
	{
		NewLateBinding.LateCall(obj, (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		try
		{
			NewLateBinding.LateCall(obj, (Type)null, "select", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void BringToFront()
	{
		NewLateBinding.LateCall(obj, (Type)null, "BringToFront", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void SendToBack()
	{
		NewLateBinding.LateCall(obj, (Type)null, "SendToBack", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Clear()
	{
		NewLateBinding.LateCall(NewLateBinding.LateGet(obj, (Type)null, "items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Cut()
	{
		NewLateBinding.LateCall(obj, (Type)null, "Cut", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Copy()
	{
		NewLateBinding.LateCall(obj, (Type)null, "Copy", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Paste()
	{
		NewLateBinding.LateCall(obj, (Type)null, "Paste", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void SelectAll()
	{
		NewLateBinding.LateCall(obj, (Type)null, "SelectAll", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Undo()
	{
		NewLateBinding.LateCall(obj, (Type)null, "Undo", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Redo()
	{
		NewLateBinding.LateCall(obj, (Type)null, "Redo", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void GoBack()
	{
		NewLateBinding.LateCall(obj, (Type)null, "GoBack", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void GoForward()
	{
		NewLateBinding.LateCall(obj, (Type)null, "GoForward", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void GoHome()
	{
		NewLateBinding.LateCall(obj, (Type)null, "GoHome", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void GoSearch()
	{
		NewLateBinding.LateCall(obj, (Type)null, "GoSearch", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Printing()
	{
		NewLateBinding.LateCall(obj, (Type)null, "Print", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void ShowPageSetupDialog()
	{
		NewLateBinding.LateCall(obj, (Type)null, "ShowPageSetupDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void ShowPrintDialog()
	{
		NewLateBinding.LateCall(obj, (Type)null, "ShowPrintDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void ShowPrintPreviewDialog()
	{
		NewLateBinding.LateCall(obj, (Type)null, "ShowPrintPreviewDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void ShowPropertiesDialog()
	{
		NewLateBinding.LateCall(obj, (Type)null, "ShowPropertiesDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void ShowSaveAsDialog()
	{
		NewLateBinding.LateCall(obj, (Type)null, "ShowSaveAsDialog", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Stop()
	{
		NewLateBinding.LateCall(obj, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Hide()
	{
		NewLateBinding.LateCall(obj, (Type)null, "Hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Close()
	{
		if (peremens.DaOrNet(MainForm))
		{
			PropertysOther propertysOther = new PropertysOther(RuntimeHelpers.GetObjectValue(obj));
			propertysOther.BreakApplication();
		}
		NewLateBinding.LateCall(obj, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Show()
	{
		NewLateBinding.LateCall(obj, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(obj, (Type)null, "focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void ClearTable()
	{
		if (isDBconnect())
		{
			for (int i = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)); i >= 0; i = checked(i + -1))
			{
				object obj = this.obj;
				object[] array = new object[1] { i };
				bool[] array2 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Rows", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj2, (Type)null, "IsNewRow", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
				{
					object obj3 = NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array3 = new object[1] { i };
					bool[] array4 = new bool[1] { true };
					NewLateBinding.LateCall(obj3, (Type)null, "removeAt", array3, (string[])null, (Type[])null, array4, true);
					if (array4[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
					}
				}
			}
		}
		else
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(this.obj, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	public void ScrollToCaret()
	{
		NewLateBinding.LateCall(obj, (Type)null, "ScrollToCaret", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Print()
	{
		NewLateBinding.LateCall(NewLateBinding.LateGet(obj, (Type)null, "PrintDoc", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Print", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Start()
	{
		NewLateBinding.LateCall(obj, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}
}
