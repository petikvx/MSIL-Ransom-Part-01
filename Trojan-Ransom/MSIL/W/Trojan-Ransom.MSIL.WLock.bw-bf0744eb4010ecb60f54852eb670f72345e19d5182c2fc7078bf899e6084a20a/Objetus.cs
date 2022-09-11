using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class Objetus
{
	public Control eventObj;

	public object obj;

	public object MyObj;

	public object MyForm;

	public object conteiner;

	private bool click;

	public int dx;

	public int dy;

	public int mdx;

	public int mdy;

	private int markers_perenos;

	public PictureBox[] markers;

	private Point[] raznicaSize;

	private Point[] raznicaLoc;

	public PictureBox HideMarker;

	public Point na4Point;

	public Point endPoint;

	public TreeNode NodeTemp;

	public string ParentTemp;

	public string IndexTemp;

	public string HistoryTemp;

	public string OldFormTemp;

	public bool VstavkaOrCreate;

	public SplitContainer SplitCont;

	public string[] Sobytia;

	public string VBname;

	public TreeView tree;

	public object proj;

	public bool isRun;

	public ToolTip ToolTipa;

	private bool zashita;

	private object ob_cl;

	private DateTime tm;

	public void CreateObject(object ob, bool holostoi = false, bool isRun = false, bool fromEng = false)
	{
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected O, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected O, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected O, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected O, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected O, but got Unknown
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected O, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected O, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected O, but got Unknown
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected O, but got Unknown
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected O, but got Unknown
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected O, but got Unknown
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected O, but got Unknown
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected O, but got Unknown
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Expected O, but got Unknown
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected O, but got Unknown
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected O, but got Unknown
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected O, but got Unknown
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Expected O, but got Unknown
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected O, but got Unknown
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected O, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected O, but got Unknown
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Expected O, but got Unknown
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected O, but got Unknown
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected O, but got Unknown
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Expected O, but got Unknown
		//IL_08b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Expected O, but got Unknown
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected O, but got Unknown
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected O, but got Unknown
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0908: Expected O, but got Unknown
		//IL_0917: Unknown result type (might be due to invalid IL or missing references)
		//IL_0921: Expected O, but got Unknown
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Expected O, but got Unknown
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected O, but got Unknown
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c0: Expected O, but got Unknown
		//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Expected O, but got Unknown
		//IL_0ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Expected O, but got Unknown
		//IL_0b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b16: Expected O, but got Unknown
		//IL_0b45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4f: Expected O, but got Unknown
		//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b88: Expected O, but got Unknown
		//IL_0bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc1: Expected O, but got Unknown
		//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Expected O, but got Unknown
		//IL_0cd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cde: Expected O, but got Unknown
		//IL_0d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d35: Expected O, but got Unknown
		//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Expected O, but got Unknown
		//IL_0d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d79: Expected O, but got Unknown
		//IL_0d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8d: Expected O, but got Unknown
		//IL_0db4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbb: Expected O, but got Unknown
		//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e11: Expected O, but got Unknown
		//IL_0f3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f44: Expected O, but got Unknown
		//IL_0fa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fae: Expected O, but got Unknown
		//IL_0fd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe3: Expected O, but got Unknown
		//IL_109a: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a4: Expected O, but got Unknown
		//IL_10cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d9: Expected O, but got Unknown
		//IL_1139: Unknown result type (might be due to invalid IL or missing references)
		//IL_1143: Expected O, but got Unknown
		//IL_11c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cf: Expected O, but got Unknown
		//IL_11fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1204: Expected O, but got Unknown
		//IL_122f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1239: Expected O, but got Unknown
		//IL_1264: Unknown result type (might be due to invalid IL or missing references)
		//IL_126e: Expected O, but got Unknown
		//IL_1299: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a3: Expected O, but got Unknown
		//IL_12ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d8: Expected O, but got Unknown
		//IL_1303: Unknown result type (might be due to invalid IL or missing references)
		//IL_130d: Expected O, but got Unknown
		//IL_1338: Unknown result type (might be due to invalid IL or missing references)
		//IL_1342: Expected O, but got Unknown
		//IL_136d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1377: Expected O, but got Unknown
		//IL_13a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ac: Expected O, but got Unknown
		//IL_13d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e1: Expected O, but got Unknown
		//IL_140c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1416: Expected O, but got Unknown
		//IL_1441: Unknown result type (might be due to invalid IL or missing references)
		//IL_144b: Expected O, but got Unknown
		//IL_1476: Unknown result type (might be due to invalid IL or missing references)
		//IL_1480: Expected O, but got Unknown
		//IL_14ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b5: Expected O, but got Unknown
		//IL_14e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ea: Expected O, but got Unknown
		//IL_1c67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6e: Expected O, but got Unknown
		//IL_1c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c91: Expected O, but got Unknown
		//IL_1d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d82: Expected O, but got Unknown
		//IL_1e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e43: Expected O, but got Unknown
		//IL_2043: Unknown result type (might be due to invalid IL or missing references)
		//IL_204d: Expected O, but got Unknown
		//IL_20c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ca: Expected O, but got Unknown
		//IL_20d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e2: Expected O, but got Unknown
		//IL_20f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ff: Expected O, but got Unknown
		//IL_2112: Unknown result type (might be due to invalid IL or missing references)
		//IL_211c: Expected O, but got Unknown
		//IL_212f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2139: Expected O, but got Unknown
		//IL_2186: Unknown result type (might be due to invalid IL or missing references)
		//IL_2190: Expected O, but got Unknown
		//IL_2264: Unknown result type (might be due to invalid IL or missing references)
		//IL_226b: Expected O, but got Unknown
		//IL_229b: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a2: Expected O, but got Unknown
		//IL_26a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_26aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_26db: Unknown result type (might be due to invalid IL or missing references)
		//IL_2703: Unknown result type (might be due to invalid IL or missing references)
		//IL_2706: Invalid comparison between Unknown and I4
		//IL_2741: Unknown result type (might be due to invalid IL or missing references)
		//IL_2744: Invalid comparison between Unknown and I4
		//IL_277f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2782: Invalid comparison between Unknown and I4
		//IL_349f: Unknown result type (might be due to invalid IL or missing references)
		//IL_34fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3503: Expected O, but got Unknown
		//IL_350d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3517: Expected O, but got Unknown
		//IL_3521: Unknown result type (might be due to invalid IL or missing references)
		//IL_352b: Expected O, but got Unknown
		//IL_3535: Unknown result type (might be due to invalid IL or missing references)
		//IL_353f: Expected O, but got Unknown
		//IL_3571: Unknown result type (might be due to invalid IL or missing references)
		//IL_357b: Expected O, but got Unknown
		//IL_35ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_35b6: Expected O, but got Unknown
		//IL_35c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_35cf: Expected O, but got Unknown
		//IL_35de: Unknown result type (might be due to invalid IL or missing references)
		//IL_35e8: Expected O, but got Unknown
		//IL_35f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3601: Expected O, but got Unknown
		//IL_3610: Unknown result type (might be due to invalid IL or missing references)
		//IL_361a: Expected O, but got Unknown
		//IL_3629: Unknown result type (might be due to invalid IL or missing references)
		//IL_3633: Expected O, but got Unknown
		//IL_36a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_36b0: Expected O, but got Unknown
		//IL_36bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_36c9: Expected O, but got Unknown
		//IL_36e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_36f1: Expected O, but got Unknown
		//IL_3726: Unknown result type (might be due to invalid IL or missing references)
		//IL_3730: Expected O, but got Unknown
		//IL_373e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3748: Expected O, but got Unknown
		//IL_3756: Unknown result type (might be due to invalid IL or missing references)
		//IL_3760: Expected O, but got Unknown
		//IL_37b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_37c0: Expected O, but got Unknown
		//IL_37f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_37f7: Expected O, but got Unknown
		//IL_3801: Unknown result type (might be due to invalid IL or missing references)
		//IL_380b: Expected O, but got Unknown
		//IL_3878: Unknown result type (might be due to invalid IL or missing references)
		//IL_387f: Expected O, but got Unknown
		//IL_3889: Unknown result type (might be due to invalid IL or missing references)
		//IL_3893: Expected O, but got Unknown
		//IL_38c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_38cb: Expected O, but got Unknown
		//IL_38f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3900: Expected O, but got Unknown
		//IL_392e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3935: Expected O, but got Unknown
		//IL_3960: Unknown result type (might be due to invalid IL or missing references)
		//IL_3966: Expected O, but got Unknown
		//IL_39d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_39dc: Expected O, but got Unknown
		//IL_39ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_39f6: Expected O, but got Unknown
		//IL_3a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a10: Expected O, but got Unknown
		//IL_3b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b6d: Expected O, but got Unknown
		//IL_3ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cb0: Expected O, but got Unknown
		//IL_3d33: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d3d: Expected O, but got Unknown
		//IL_3e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e3c: Expected O, but got Unknown
		//IL_3e56: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e60: Expected O, but got Unknown
		//IL_40a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_40a8: Expected O, but got Unknown
		//IL_414d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4153: Expected O, but got Unknown
		//IL_4179: Unknown result type (might be due to invalid IL or missing references)
		//IL_4183: Expected O, but got Unknown
		//IL_42f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_42ff: Expected O, but got Unknown
		if (!isRun)
		{
			proj = RuntimeHelpers.GetObjectValue(peremens2.proj);
		}
		if (proj != null && NewLateBinding.LateGet(proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null) != null && Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectLessEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false), (object)(Operators.CompareString(ob.GetType().ToString(), peremens.ClassAplication + "F", false) != 0)), (object)(!holostoi))))
		{
			return;
		}
		this.obj = RuntimeHelpers.GetObjectValue(ob);
		MyObj = this;
		this.isRun = isRun;
		NewLateBinding.LateSet(this.obj, (Type)null, "MyObj", new object[1] { RuntimeHelpers.GetObjectValue(MyObj) }, (string[])null, (Type[])null);
		if (peremens.isHelp)
		{
			return;
		}
		if (!Iz.IsMMs(RuntimeHelpers.GetObjectValue(MyObj)))
		{
			if (!Iz.isNoControlObj(RuntimeHelpers.GetObjectValue(this.obj)))
			{
				eventObj = (Control)this.obj;
			}
			if (!isRun & (proj != null) & peremens.isDevelop & !peremens.IsHttpCompil)
			{
				NewLateBinding.LateSet(this.obj, (Type)null, "ContextMenuStrip", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(peremens2.MnFrm, (Type)null, "ObjsMenu", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
			}
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(this.obj, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Polezniy", false))
		{
			return;
		}
		if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)) && !isRun && NewLateBinding.LateGet(MyObj, (Type)null, "tab", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
		{
			NewLateBinding.LateSet(MyObj, (Type)null, "tab", new object[1] { (object)new TabPage(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))) }, (string[])null, (Type[])null);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(MyObj, (Type)null, "tab", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(MyObj, (Type)null, "tab", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BackColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(MyObj, (Type)null, "tab", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "UseVisualStyleBackColor", new object[1] { true }, (string[])null, (Type[])null, false, true);
		}
		ToolTipa = new ToolTip((IContainer)new Container());
		if (isRun)
		{
			if (Iz.IsMMs(RuntimeHelpers.GetObjectValue(MyObj)))
			{
				ToolStripMenuItem val = (ToolStripMenuItem)ob;
				((ToolStripItem)val).add_Click((EventHandler)obj_ClickRun);
				((ToolStripItem)val).add_MouseDown(new MouseEventHandler(obj_MouseDownRun));
				((ToolStripItem)val).add_MouseMove(new MouseEventHandler(obj_MouseMoveRun));
				((ToolStripItem)val).add_MouseUp(new MouseEventHandler(obj_MouseUpRun));
				((ToolStripItem)val).add_Paint(new PaintEventHandler(obj_PaintRun));
				((ToolStripDropDownItem)val).add_DropDownClosed((EventHandler)obj_DropDownClosedRun);
				((ToolStripDropDownItem)val).add_DropDownOpened((EventHandler)obj_DropDownOpenedRun);
				((ToolStripDropDownItem)val).add_DropDownOpening((EventHandler)obj_DropDownOpeningRun);
			}
			else if (Iz.IsCM(RuntimeHelpers.GetObjectValue(MyObj)))
			{
				ContextMenuStrip val2 = (ContextMenuStrip)NewLateBinding.LateGet(ob, (Type)null, "cnmn", new object[0], (string[])null, (Type[])null, (bool[])null);
				((ToolStripDropDown)val2).add_Opening((CancelEventHandler)obj_OpeningRun);
				((ToolStripDropDown)val2).add_Opened((EventHandler)obj_OpenedRun);
				((ToolStripDropDown)val2).add_Closing(new ToolStripDropDownClosingEventHandler(obj_ClosingRun));
				((ToolStripDropDown)val2).add_Closed(new ToolStripDropDownClosedEventHandler(obj_ClosedRun));
			}
			else if (Iz.IsDP(RuntimeHelpers.GetObjectValue(MyObj)))
			{
				runDP runDP2 = (runDP)ob;
				((Control)runDP2).add_Click((EventHandler)obj_ClickRun);
				((Control)((SplitContainer)runDP2).get_Panel1()).add_Click((EventHandler)obj_ClickRun);
				((Control)((SplitContainer)runDP2).get_Panel2()).add_Click((EventHandler)obj_ClickRun);
				((Control)runDP2).add_MouseDown(new MouseEventHandler(obj_MouseDownRun));
				((Control)((SplitContainer)runDP2).get_Panel1()).add_MouseDown(new MouseEventHandler(obj_MouseDownRun));
				((Control)((SplitContainer)runDP2).get_Panel2()).add_MouseDown(new MouseEventHandler(obj_MouseDownRun));
				((Control)runDP2).add_MouseMove(new MouseEventHandler(obj_MouseMoveRun));
				((Control)((SplitContainer)runDP2).get_Panel1()).add_MouseMove(new MouseEventHandler(obj_MouseMoveRun));
				((Control)((SplitContainer)runDP2).get_Panel2()).add_MouseMove(new MouseEventHandler(obj_MouseMoveRun));
				((Control)runDP2).add_MouseUp(new MouseEventHandler(obj_MouseUpRun));
				((Control)((SplitContainer)runDP2).get_Panel1()).add_MouseUp(new MouseEventHandler(obj_MouseUpRun));
				((Control)((SplitContainer)runDP2).get_Panel2()).add_MouseUp(new MouseEventHandler(obj_MouseUpRun));
				((Control)runDP2).add_MouseEnter((EventHandler)obj_MouseEnterRun);
				((Control)((SplitContainer)runDP2).get_Panel1()).add_MouseEnter((EventHandler)obj_MouseEnterRun);
				((Control)((SplitContainer)runDP2).get_Panel2()).add_MouseEnter((EventHandler)obj_MouseEnterRun);
				((Control)runDP2).add_MouseLeave((EventHandler)obj_MouseLeaveRun);
				((Control)((SplitContainer)runDP2).get_Panel1()).add_MouseLeave((EventHandler)obj_MouseLeaveRun);
				((Control)((SplitContainer)runDP2).get_Panel2()).add_MouseLeave((EventHandler)obj_MouseLeaveRun);
				((Control)runDP2).add_MouseHover((EventHandler)obj_MouseHoverRun);
				((Control)((SplitContainer)runDP2).get_Panel1()).add_MouseHover((EventHandler)obj_MouseHoverRun);
				((Control)((SplitContainer)runDP2).get_Panel2()).add_MouseHover((EventHandler)obj_MouseHoverRun);
				((Control)runDP2).add_MouseDoubleClick(new MouseEventHandler(obj_DoubleClickRun));
				((Control)((SplitContainer)runDP2).get_Panel1()).add_MouseDoubleClick(new MouseEventHandler(obj_DoubleClickRun));
				((Control)((SplitContainer)runDP2).get_Panel2()).add_MouseDoubleClick(new MouseEventHandler(obj_DoubleClickRun));
				((Control)runDP2).add_MouseWheel(new MouseEventHandler(obj_MouseWheelRun));
				((Control)((SplitContainer)runDP2).get_Panel1()).add_MouseWheel(new MouseEventHandler(obj_MouseWheelRun));
				((Control)((SplitContainer)runDP2).get_Panel2()).add_MouseWheel(new MouseEventHandler(obj_MouseWheelRun));
				((Control)runDP2).add_KeyPress(new KeyPressEventHandler(obj_KeyPressRun));
				((Panel)((SplitContainer)runDP2).get_Panel1()).add_KeyPress(new KeyPressEventHandler(obj_KeyPressRun));
				((Panel)((SplitContainer)runDP2).get_Panel2()).add_KeyPress(new KeyPressEventHandler(obj_KeyPressRun));
				((Control)runDP2).add_KeyDown(new KeyEventHandler(obj_KeyDownRun));
				((Panel)((SplitContainer)runDP2).get_Panel1()).add_KeyDown(new KeyEventHandler(obj_KeyDownRun));
				((Panel)((SplitContainer)runDP2).get_Panel2()).add_KeyDown(new KeyEventHandler(obj_KeyDownRun));
				((Control)runDP2).add_KeyUp(new KeyEventHandler(obj_KeyUpRun));
				((Panel)((SplitContainer)runDP2).get_Panel1()).add_KeyUp(new KeyEventHandler(obj_KeyUpRun));
				((Panel)((SplitContainer)runDP2).get_Panel2()).add_KeyUp(new KeyEventHandler(obj_KeyUpRun));
				((Control)runDP2).add_GotFocus((EventHandler)obj_GotFocusRun);
				((Control)((SplitContainer)runDP2).get_Panel1()).add_GotFocus((EventHandler)obj_GotFocusRun);
				((Control)((SplitContainer)runDP2).get_Panel2()).add_GotFocus((EventHandler)obj_GotFocusRun);
				((Control)runDP2).add_LostFocus((EventHandler)obj_LostFocusRun);
				((Control)((SplitContainer)runDP2).get_Panel1()).add_LostFocus((EventHandler)obj_LostFocusRun);
				((Control)((SplitContainer)runDP2).get_Panel2()).add_LostFocus((EventHandler)obj_LostFocusRun);
				((ScrollableControl)runDP2).add_Scroll(new ScrollEventHandler(obj_ScrollRun));
				((ScrollableControl)((SplitContainer)runDP2).get_Panel1()).add_Scroll(new ScrollEventHandler(obj_ScrollRun1));
				((ScrollableControl)((SplitContainer)runDP2).get_Panel2()).add_Scroll(new ScrollEventHandler(obj_ScrollRun2));
				((Control)runDP2).add_Paint(new PaintEventHandler(obj_PaintRun));
				((Control)((SplitContainer)runDP2).get_Panel1()).add_Paint(new PaintEventHandler(obj_PaintRun));
				((Control)((SplitContainer)runDP2).get_Panel2()).add_Paint(new PaintEventHandler(obj_PaintRun));
				((SplitContainer)runDP2).add_SplitterMoved(new SplitterEventHandler(obj_SplitterMovedRun));
				((SplitContainer)runDP2).add_SplitterMoving(new SplitterCancelEventHandler(obj_SplitterMovingRun));
			}
			else
			{
				if (Array.IndexOf(Sobytia, peremens.trans("Клик").ToUpper()) != -1)
				{
					eventObj.add_Click((EventHandler)obj_ClickRun);
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Нажатие кнопки мыши").ToUpper()) != -1)
				{
					eventObj.add_MouseDown(new MouseEventHandler(obj_MouseDownRun));
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Отжатие кнопки мыши").ToUpper()) != -1)
				{
					eventObj.add_MouseUp(new MouseEventHandler(obj_MouseUpRun));
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Наведение курсора").ToUpper()) != -1)
				{
					eventObj.add_MouseEnter((EventHandler)obj_MouseEnterRun);
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Отведение курсора").ToUpper()) != -1)
				{
					eventObj.add_MouseLeave((EventHandler)obj_MouseLeaveRun);
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Курсор на объекте").ToUpper()) != -1)
				{
					eventObj.add_MouseHover((EventHandler)obj_MouseHoverRun);
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Движение курсора").ToUpper()) != -1)
				{
					eventObj.add_MouseMove(new MouseEventHandler(obj_MouseMoveRun));
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Двойной клик").ToUpper()) != -1)
				{
					eventObj.add_MouseDoubleClick(new MouseEventHandler(obj_DoubleClickRun));
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Вращение колесика").ToUpper()) != -1)
				{
					eventObj.add_MouseWheel(new MouseEventHandler(obj_MouseWheelRun));
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Нажатие клавиатуры").ToUpper()) != -1)
				{
					eventObj.add_KeyPress(new KeyPressEventHandler(obj_KeyPressRun));
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Нажатие вниз кнопки").ToUpper()) != -1)
				{
					eventObj.add_KeyDown(new KeyEventHandler(obj_KeyDownRun));
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Отжатие кнопки").ToUpper()) != -1)
				{
					eventObj.add_KeyUp(new KeyEventHandler(obj_KeyUpRun));
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Изменение текста").ToUpper()) != -1)
				{
					eventObj.add_TextChanged((EventHandler)obj_TextChangedRun);
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Получение фокуса").ToUpper()) != -1)
				{
					eventObj.add_GotFocus((EventHandler)obj_GotFocusRun);
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Потеря фокуса").ToUpper()) != -1)
				{
					eventObj.add_LostFocus((EventHandler)obj_LostFocusRun);
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Прорисовка").ToUpper()) != -1)
				{
					eventObj.add_Paint(new PaintEventHandler(obj_PaintRun));
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Прокрутка").ToUpper()) != -1)
				{
					if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)))
					{
						runF runF2 = (runF)(object)eventObj;
						((ScrollableControl)runF2).add_Scroll(new ScrollEventHandler(obj_ScrollRun));
					}
					else if (Iz.IsTl(RuntimeHelpers.GetObjectValue(MyObj)))
					{
						runTl runTl2 = (runTl)(object)eventObj;
						((DataGridView)runTl2).add_Scroll(new ScrollEventHandler(obj_ScrollRun));
					}
					else
					{
						Panel val3 = (Panel)eventObj;
						((ScrollableControl)val3).add_Scroll(new ScrollEventHandler(obj_ScrollRun));
					}
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Изменение размеров").ToUpper()) != -1)
				{
					Panel val4 = (Panel)eventObj;
					((Control)val4).add_Resize((EventHandler)obj_ResizeRun);
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Закрытие окна").ToUpper()) != -1)
				{
					runF runF3 = (runF)(object)eventObj;
					((Form)runF3).add_FormClosing(new FormClosingEventHandler(obj_FormClosingRun));
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Изменились размеры").ToUpper()) != -1)
				{
					eventObj.add_SizeChanged((EventHandler)obj_SizeChangedRun);
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Изменились размеры").ToUpper()) != -1)
				{
					eventObj.add_VisibleChanged((EventHandler)obj_VisibleChangedRun);
				}
				if (Iz.IsW(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					runW runW2 = (runW)(object)eventObj;
					if (Array.IndexOf(Sobytia, peremens.trans("Назад можно изменилось").ToUpper()) != -1)
					{
						((WebBrowser)runW2).add_CanGoBackChanged((EventHandler)WebBrowser1_CanGoBackChanged);
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Вперед можно изменилось").ToUpper()) != -1)
					{
						((WebBrowser)runW2).add_CanGoForwardChanged((EventHandler)WebBrowser1_CanGoForwardChanged);
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Страница загрузилась").ToUpper()) != -1)
					{
						((WebBrowser)runW2).add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(WebBrowser1_DocumentCompleted));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Страница загружается").ToUpper()) != -1)
					{
						((WebBrowser)runW2).add_FileDownload((EventHandler)WebBrowser1_FileDownload);
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Перешел по ссылке").ToUpper()) != -1)
					{
						((WebBrowser)runW2).add_Navigated(new WebBrowserNavigatedEventHandler(WebBrowser1_Navigated));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Переходит по ссылке").ToUpper()) != -1)
					{
						((WebBrowser)runW2).add_Navigating(new WebBrowserNavigatingEventHandler(WebBrowser1_Navigating));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Открытие в новом окне").ToUpper()) != -1)
					{
						((WebBrowser)runW2).add_NewWindow((CancelEventHandler)WebBrowser1_NewWindow);
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Статусная строка изменилась").ToUpper()) != -1)
					{
						((WebBrowser)runW2).add_StatusTextChanged((EventHandler)WebBrowser1_StatusTextChanged);
					}
				}
				if (Iz.IsTP(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					runTP runTP2 = (runTP)(object)eventObj;
					if (Array.IndexOf(Sobytia, peremens.trans("Снялось выделение закладки").ToUpper()) != -1)
					{
						((TabControl)runTP2).add_Deselected(new TabControlEventHandler(TabControl_Deselected));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Снимается выделение закладки").ToUpper()) != -1)
					{
						((TabControl)runTP2).add_Deselecting(new TabControlCancelEventHandler(TabControl_Deselecting));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Выделили закладку").ToUpper()) != -1)
					{
						((TabControl)runTP2).add_SelectedIndexChanged((EventHandler)TabControl_SelectedIndexChanged);
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Выделяют закладку").ToUpper()) != -1)
					{
						((TabControl)runTP2).add_Selecting(new TabControlCancelEventHandler(TabControl_Selecting));
					}
				}
				if (Iz.IsTl(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					runTl runTl3 = (runTl)(object)eventObj;
					if (Array.IndexOf(Sobytia, peremens.trans("Изменилось выделение").ToUpper()) != -1)
					{
						((DataGridView)runTl3).add_SelectionChanged((EventHandler)Table_SelectionChangedRun);
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Начало редактирования ячейки").ToUpper()) != -1)
					{
						((DataGridView)runTl3).add_CellBeginEdit(new DataGridViewCellCancelEventHandler(Table_CellBeginEditRun));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Клик по ячейке").ToUpper()) != -1)
					{
						((DataGridView)runTl3).add_CellClick(new DataGridViewCellEventHandler(Table_CellClickRun));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Клик по выделенной ячейке").ToUpper()) != -1)
					{
						((DataGridView)runTl3).add_CellMouseDown(new DataGridViewCellMouseEventHandler(Table_CellMouseDownRun));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Двойной клик по ячейке").ToUpper()) != -1)
					{
						((DataGridView)runTl3).add_CellDoubleClick(new DataGridViewCellEventHandler(Table_CellDoubleClickRun));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Конец редактирования ячеки").ToUpper()) != -1)
					{
						((DataGridView)runTl3).add_CellEndEdit(new DataGridViewCellEventHandler(Table_CellEndEditRun));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Ячейка в фокусе").ToUpper()) != -1)
					{
						((DataGridView)runTl3).add_CellEnter(new DataGridViewCellEventHandler(Table_CellEnterRun));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Ячека потеряла фокус").ToUpper()) != -1)
					{
						((DataGridView)runTl3).add_CellLeave(new DataGridViewCellEventHandler(Table_CellLeaveRun));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Столбец переместили").ToUpper()) != -1)
					{
						((DataGridView)runTl3).add_ColumnDisplayIndexChanged(new DataGridViewColumnEventHandler(Table_ColumnDisplayIndexChangedRun));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Клик по заголовку столбца").ToUpper()) != -1)
					{
						((DataGridView)runTl3).add_ColumnHeaderMouseClick(new DataGridViewCellMouseEventHandler(Table_ColumnHeaderMouseClickRun));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Двойной клик по заголовку столбца").ToUpper()) != -1)
					{
						((DataGridView)runTl3).add_ColumnHeaderMouseDoubleClick(new DataGridViewCellMouseEventHandler(Table_ColumnHeaderMouseDoubleClickRun));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Сортировка столбца").ToUpper()) != -1)
					{
						((DataGridView)runTl3).add_ColumnSortModeChanged(new DataGridViewColumnEventHandler(Table_ColumnSortModeChangedRun));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Изменилась ширина столбца").ToUpper()) != -1)
					{
						((DataGridView)runTl3).add_ColumnWidthChanged(new DataGridViewColumnEventHandler(Table_ColumnWidthChangedRun));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Клик по заголовку строки").ToUpper()) != -1)
					{
						((DataGridView)runTl3).add_RowHeaderMouseClick(new DataGridViewCellMouseEventHandler(Table_RowHeaderMouseClickRun));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Изменилась вышина строки").ToUpper()) != -1)
					{
						((DataGridView)runTl3).add_RowHeightChanged(new DataGridViewRowEventHandler(Table_RowHeightChangedRun));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Добавли строку").ToUpper()) != -1)
					{
						((DataGridView)runTl3).add_RowsAdded(new DataGridViewRowsAddedEventHandler(Table_RowsAddedRun));
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Удалили строку").ToUpper()) != -1)
					{
						((DataGridView)runTl3).add_RowsRemoved(new DataGridViewRowsRemovedEventHandler(Table_RowsRemovedRun));
					}
				}
				if (Iz.IsC(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					runC runC2 = (runC)(object)eventObj;
					if (Array.IndexOf(Sobytia, peremens.trans("Изменение выбранной записи").ToUpper()) != -1)
					{
						((ComboBox)runC2).add_SelectedIndexChanged((EventHandler)obj_SelectedIndexChangedRun);
					}
				}
				if (Iz.IsL(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					runL runL2 = (runL)(object)eventObj;
					if (Array.IndexOf(Sobytia, peremens.trans("Изменение выбранной записи").ToUpper()) != -1)
					{
						((ListBox)runL2).add_SelectedIndexChanged((EventHandler)obj_SelectedIndexChangedRun);
					}
				}
				if (Iz.IsCL(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					runCL runCL2 = (runCL)(object)eventObj;
					if (Array.IndexOf(Sobytia, peremens.trans("Изменение выбранной записи").ToUpper()) != -1)
					{
						((ListBox)runCL2).add_SelectedIndexChanged((EventHandler)obj_SelectedIndexChangedRun);
					}
				}
				if (Iz.IsCr(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					runCr runCr2 = (runCr)(object)eventObj;
					if (Array.IndexOf(Sobytia, peremens.trans("Календарь закрылся").ToUpper()) != -1)
					{
						((DateTimePicker)runCr2).add_CloseUp((EventHandler)obj_CloseUp);
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Календарь раскрылся").ToUpper()) != -1)
					{
						((DateTimePicker)runCr2).add_DropDown((EventHandler)obj_DropDown);
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Значение изменилось").ToUpper()) != -1)
					{
						((DateTimePicker)runCr2).add_ValueChanged((EventHandler)obj_ValueChanged);
					}
				}
				if (Iz.IsTb(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					runTb runTb2 = (runTb)(object)eventObj;
					if (Array.IndexOf(Sobytia, peremens.trans("Значение изменилось").ToUpper()) != -1)
					{
						((TrackBar)runTb2).add_ValueChanged((EventHandler)obj_ValueChanged);
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Движение бегунка").ToUpper()) != -1)
					{
						((TrackBar)runTb2).add_Scroll((EventHandler)obj_ScrollRun);
					}
				}
				if (Iz.IsCS(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					IWinSockEvents winSockEvents = (IWinSockEvents)eventObj;
					if (Array.IndexOf(Sobytia, peremens.trans("Присоединились к серверу").ToUpper()) != -1)
					{
						winSockEvents.ConnectedToServer += obj_ConnectedToServerRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Присоединился клиент").ToUpper()) != -1)
					{
						winSockEvents.ConnectionClient += obj_ConnectionClientRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Изменилось число клиентов").ToUpper()) != -1)
					{
						winSockEvents.CountChanged += obj_CountChangedRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Пришел текст").ToUpper()) != -1)
					{
						winSockEvents.TextReceived += obj_TextReceivedRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Пришла команда").ToUpper()) != -1)
					{
						winSockEvents.CommandReceived += obj_CommandReceivedRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Пришел файл").ToUpper()) != -1)
					{
						winSockEvents.FileReceived += obj_FileReceivedRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Отключение").ToUpper()) != -1)
					{
						winSockEvents.Disconnected += obj_DisconnectedRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Произошла ошибка").ToUpper()) != -1)
					{
						winSockEvents.ErrorReceived += obj_ErrorReceivedRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Отправился текст").ToUpper()) != -1)
					{
						winSockEvents.SendTextComplete += obj_SendTextCompleteRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Отправился файл").ToUpper()) != -1)
					{
						winSockEvents.SendFileComplete += obj_SendFileCompleteRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Идет отправление").ToUpper()) != -1)
					{
						winSockEvents.SendProgress += obj_SendProgressRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Идет прием данных").ToUpper()) != -1)
					{
						winSockEvents.ReceiveProgress += obj_ReceiveProgressRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Изменился статус").ToUpper()) != -1)
					{
						winSockEvents.StateChanged += obj_StateChangedRun;
					}
				}
				if (Iz.IsI(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					IInternetEvents internetEvents = (IInternetEvents)eventObj;
					if (Array.IndexOf(Sobytia, peremens.trans("Отправляется запрос").ToUpper()) != -1)
					{
						internetEvents.SendingQuery += obj_SendingQueryRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Отправился запрос").ToUpper()) != -1)
					{
						internetEvents.SentQuery += obj_SentQueryRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Пришел ответ").ToUpper()) != -1)
					{
						internetEvents.ReceivedResponse += obj_ReceivedResponseRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Идет прием данных").ToUpper()) != -1)
					{
						internetEvents.ReceiveProgress += obj_ReceiveProgressRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Загрузка отменена").ToUpper()) != -1)
					{
						internetEvents.DownloadCancelled += obj_DownloadCancelledRun;
					}
				}
				if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					runF runF4 = (runF)(object)eventObj;
					if (Array.IndexOf(Sobytia, peremens.trans("Сворачивание").ToUpper()) != -1)
					{
						runF4.Minimize += Minimize;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Двойной клик по трею").ToUpper()) != -1)
					{
						runF4.DoubleClickTray += DoubleClickTray;
					}
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Конец проигрывания").ToUpper()) != -1)
				{
					if (Iz.IsMd(RuntimeHelpers.GetObjectValue(MyObj)))
					{
						runMd runMd2 = (runMd)(object)eventObj;
						runMd2.OnEnd += obj_OnEndRun;
					}
					else
					{
						runA runA2 = (runA)(object)eventObj;
						runA2.OnEnd += obj_OnEndRun;
					}
				}
				if (Array.IndexOf(Sobytia, peremens.trans("Изменение отметки").ToUpper()) != -1)
				{
					if (Iz.IsCB(RuntimeHelpers.GetObjectValue(MyObj)))
					{
						CheckBox val5 = (CheckBox)eventObj;
						val5.add_CheckedChanged((EventHandler)obj_CheckedChangedRun);
					}
					else
					{
						RadioButton val6 = (RadioButton)eventObj;
						val6.add_CheckedChanged((EventHandler)obj_CheckedChangedRun);
					}
				}
				if (Iz.IsM(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					runM runM2 = (runM)(object)eventObj;
					if (Array.IndexOf(Sobytia, peremens.trans("Изменение значения").ToUpper()) != -1)
					{
						runM2.ChangingValue += obj_ChangingValueRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Изменилось значение").ToUpper()) != -1)
					{
						runM2.ChangedValue += obj_ChangedValueRun;
					}
				}
				if (Iz.IsLLb(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					runLLb runLLb2 = (runLLb)(object)eventObj;
					if (Array.IndexOf(Sobytia, peremens.trans("Клик по ссылке").ToUpper()) != -1)
					{
						((LinkLabel)runLLb2).add_LinkClicked(new LinkLabelLinkClickedEventHandler(obj_LinkClicked));
					}
				}
				if (Iz.IsRT(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					runRT runRT2 = (runRT)(object)eventObj;
					if (Array.IndexOf(Sobytia, peremens.trans("Горизонтальная прокрутка").ToUpper()) != -1)
					{
						((RichTextBox)runRT2).add_HScroll((EventHandler)obj_HScroll);
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Вертикальная прокрутка").ToUpper()) != -1)
					{
						((RichTextBox)runRT2).add_VScroll((EventHandler)obj_VScroll);
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Клик по ссылке документа").ToUpper()) != -1)
					{
						((RichTextBox)runRT2).add_LinkClicked(new LinkClickedEventHandler(obj_LinkClicked));
					}
				}
				if (Iz.IsTm(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					runTm runTm2 = (runTm)this.obj;
					if (Array.IndexOf(Sobytia, peremens.trans("Тикнул").ToUpper()) != -1)
					{
						((Timer)runTm2).add_Tick((EventHandler)obj_Tick);
					}
				}
				if (Iz.IsTr(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					runTr runTr2 = (runTr)(object)eventObj;
					if (Array.IndexOf(Sobytia, peremens.trans("Клик кнопки").ToUpper()) != -1)
					{
						runTr2.ClickButton += obj_ClickButtonRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Активация успешная").ToUpper()) != -1)
					{
						runTr2.ActivationSuccessul += obj_ActivationSuccessulRun;
					}
					if (Array.IndexOf(Sobytia, peremens.trans("Активация неудачная").ToUpper()) != -1)
					{
						runTr2.ActivationFailed += obj_ActivationFailedRun;
					}
				}
				if (!Iz.isNoControlObj(RuntimeHelpers.GetObjectValue(this.obj)))
				{
					((Component)(object)eventObj).Disposed += obj_DisposedNado;
					eventObj.add_Resize((EventHandler)obj_ResizeNado);
				}
				if (Iz.IsW(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					runW runW3 = (runW)this.obj;
					((WebBrowser)runW3).add_NewWindow((CancelEventHandler)WebBrowser_NewWindowNado);
					((WebBrowser)runW3).add_StatusTextChanged((EventHandler)WebBrowser_StatusTextChangedNado);
				}
			}
			MyEvents myEvents = (MyEvents)this.obj;
			if (Array.IndexOf(Sobytia, peremens.trans("Создание").ToUpper()) != -1)
			{
				myEvents.Created += obj_LoadRun;
			}
		}
		if (holostoi && !fromEng)
		{
			return;
		}
		if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)))
		{
			SplitCont = new SplitContainer();
			SplitCont.set_Orientation((Orientation)0);
			((ScrollableControl)SplitCont.get_Panel1()).set_AutoScroll(true);
			((ScrollableControl)SplitCont.get_Panel2()).set_AutoScroll(false);
			SplitCont.get_Panel2().set_BorderStyle((BorderStyle)1);
			((Control)SplitCont.get_Panel2()).set_BackColor(SystemColors.Control);
			SplitCont.set_Dock((DockStyle)5);
			((ScrollableControl)SplitCont.get_Panel1()).add_Scroll(new ScrollEventHandler(Scroll));
			SplitCont.add_SplitterMoved(new SplitterEventHandler(SplitterMoved));
			((Control)SplitCont.get_Panel2()).add_MouseDown(new MouseEventHandler(obj_MouseDown));
			((Control)SplitCont.get_Panel2()).add_MouseMove(new MouseEventHandler(obj_MouseMove));
			((Control)SplitCont.get_Panel2()).add_MouseUp(new MouseEventHandler(obj_MouseUp));
			((Control)SplitCont.get_Panel2()).add_DoubleClick((EventHandler)obj_DoubleClick);
			((Control)SplitCont.get_Panel2()).add_Click((EventHandler)obj_Click);
			((Control)SplitCont.get_Panel2()).add_Paint(new PaintEventHandler(obj_Paint));
		}
		if (Conversions.ToBoolean(Operators.OrObject(Operators.AndObject(Operators.CompareObjectNotEqual(NewLateBinding.LateGet(this.obj, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"IncludeObj", false), (object)(NewLateBinding.LateGet(MyObj, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null) == null)), (object)Iz.isPoluObj(RuntimeHelpers.GetObjectValue(this.obj)))))
		{
			if (!Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)))
			{
				object objectValue = default(object);
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(this.obj, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
				{
					SplitContainer val7 = ((conteiner == null) ? ((SplitContainer)NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitCont", new object[0], (string[])null, (Type[])null, (bool[])null)) : ((SplitContainer)NewLateBinding.LateGet(conteiner, (Type)null, "SplitCont", new object[0], (string[])null, (Type[])null, (bool[])null)));
					conteiner = val7.get_Panel2();
					val7.set_Panel2MinSize(25);
					checked
					{
						if (val7.get_SplitterDistance() > ((Control)val7).get_Height() - val7.get_Panel2MinSize())
						{
							val7.set_SplitterDistance(((Control)val7).get_Height() - val7.get_Panel2MinSize());
						}
						objectValue = RuntimeHelpers.GetObjectValue(conteiner);
					}
				}
				else
				{
					conteiner = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null));
					if (NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null) != null && NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[0], (string[])null, (Type[])null, (bool[])null) != null && NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null) != null)
					{
						if (Iz.isPanel(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
						{
							if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1, false))
							{
								conteiner = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null));
							}
							else if (NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null) != null && NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null) != NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitCont", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null))
							{
								conteiner = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null));
							}
						}
						else
						{
							conteiner = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null));
						}
					}
					if (Iz.IsDP(RuntimeHelpers.GetObjectValue(conteiner)))
					{
						MsgBoxResult val8;
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(conteiner, (Type)null, "ActivePanel", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
						{
							val8 = Interaction.MsgBox((object)peremens.transInfc("Вы хотите разместить объект на первой из двух панелей?"), (MsgBoxStyle)35, (object)null);
						}
						else
						{
							val8 = ((!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(conteiner, (Type)null, "ActivePanel", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"Panel1", false)) ? ((MsgBoxResult)7) : ((MsgBoxResult)6));
							NewLateBinding.LateSet(conteiner, (Type)null, "ActivePanel", new object[1] { "" }, (string[])null, (Type[])null);
						}
						if ((int)val8 == 6)
						{
							objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(conteiner, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "panel1", new object[0], (string[])null, (Type[])null, (bool[])null));
						}
						else if ((int)val8 == 7)
						{
							objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(conteiner, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "panel2", new object[0], (string[])null, (Type[])null, (bool[])null));
						}
						else if ((int)val8 == 2)
						{
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { "#NotCreateDP" }, (string[])null, (Type[])null, false, true);
							return;
						}
					}
					else if (Operators.CompareString(conteiner.GetType().ToString(), "System.Windows.Forms.SplitterPanel", false) == 0)
					{
						conteiner = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(proj, (Type)null, "activeForm", new object[0], (string[])null, (Type[])null, (bool[])null));
						objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(conteiner, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
					else if (Iz.IsMMs(RuntimeHelpers.GetObjectValue(conteiner)))
					{
						conteiner = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(proj, (Type)null, "activeForm", new object[0], (string[])null, (Type[])null, (bool[])null));
						objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(conteiner, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
					else
					{
						objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(conteiner, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
				}
				if (Iz.isSostObj(RuntimeHelpers.GetObjectValue(objectValue)) && this.obj.GetType().ToString().IndexOf(objectValue.GetType().ToString()) != 0)
				{
					conteiner = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(proj, (Type)null, "activeForm", new object[0], (string[])null, (Type[])null, (bool[])null));
					objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "activeform", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
				}
				if (!Iz.isIncludeObj(RuntimeHelpers.GetObjectValue(this.obj)) & !Iz.isPoluObj(RuntimeHelpers.GetObjectValue(this.obj)))
				{
					while (!Iz.isPanel(RuntimeHelpers.GetObjectValue(objectValue)) & (Operators.CompareString(objectValue.GetType().ToString(), "System.Windows.Forms.SplitterPanel", false) != 0))
					{
						objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "myobj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
				}
				Point xY;
				if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(this.obj, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
				{
					xY = GetXY(RuntimeHelpers.GetObjectValue(this.obj), RuntimeHelpers.GetObjectValue(objectValue), Conversions.ToInteger(Operators.SubtractObject(Operators.DivideObject(NewLateBinding.LateGet(objectValue, (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2), (object)((double)eventObj.get_Width() / 2.0))), Conversions.ToInteger(Operators.SubtractObject(Operators.DivideObject(NewLateBinding.LateGet(objectValue, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2), (object)((double)eventObj.get_Height() / 2.0))));
				}
				else
				{
					xY = GetXY(RuntimeHelpers.GetObjectValue(this.obj), RuntimeHelpers.GetObjectValue(objectValue), peremens.setka, peremens.setka);
					BackPoluObj(odin: true, RuntimeHelpers.GetObjectValue(MyObj));
				}
				if (Iz.isNoMove(RuntimeHelpers.GetObjectValue(this.obj)))
				{
					NewLateBinding.LateSet(this.obj, (Type)null, "left", new object[1] { xY.X }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(this.obj, (Type)null, "top", new object[1] { xY.Y }, (string[])null, (Type[])null);
				}
				else if (!Conversions.ToBoolean(NewLateBinding.LateGet(proj, (Type)null, "UndoRedoNoWrite", new object[0], (string[])null, (Type[])null, (bool[])null)))
				{
					if (VstavkaOrCreate)
					{
						object obj = this.obj;
						object obj2 = obj;
						object[] array = new object[0];
						object[] array2 = array;
						string[] array3 = null;
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj2, (Type)null, "Props", array2, array3, (Type[])null, (bool[])null), (Type)null, "X", new object[1] { Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Props", array, array3, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null), (object)peremens.setka) }, (string[])null, (Type[])null, false, true);
						obj = this.obj;
						object obj3 = obj;
						array = new object[0];
						object[] array4 = array;
						array3 = null;
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj3, (Type)null, "Props", array4, array3, (Type[])null, (bool[])null), (Type)null, "Y", new object[1] { Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Props", array, array3, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null), (object)peremens.setka) }, (string[])null, (Type[])null, false, true);
					}
					else
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[1] { xY.X }, (string[])null, (Type[])null, false, true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[1] { xY.Y }, (string[])null, (Type[])null, false, true);
					}
				}
				object obj4 = NewLateBinding.LateGet(objectValue, (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array5 = new object[1] { RuntimeHelpers.GetObjectValue(this.obj) };
				object[] array6 = array5;
				bool[] array7 = new bool[1] { true };
				NewLateBinding.LateCall(obj4, (Type)null, "Add", array6, (string[])null, (Type[])null, array7, true);
				if (array7[0])
				{
					this.obj = RuntimeHelpers.GetObjectValue(array5[0]);
				}
				if (Iz.IsTP(RuntimeHelpers.GetObjectValue(MyObj)) && !fromEng)
				{
					if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "tabPages", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false), (object)(!VstavkaOrCreate))))
					{
						addTabPage(new TPages());
						addTabPage(new TPages());
					}
				}
				else if ((Iz.IsMM(RuntimeHelpers.GetObjectValue(MyObj)) | Iz.IsCM(RuntimeHelpers.GetObjectValue(MyObj)) | Iz.IsTPl(RuntimeHelpers.GetObjectValue(MyObj))) && !fromEng)
				{
					if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false), (object)(!VstavkaOrCreate))))
					{
						MMenus mMenus = new MMenus();
						if (Iz.IsTPl(RuntimeHelpers.GetObjectValue(MyObj)))
						{
							mMenus = new MMenus(holostoi: false, isRun: false, fromEng: false, ToolPanel: true);
						}
						addMMenuItem(mMenus);
					}
				}
				else if (Iz.IsTl(RuntimeHelpers.GetObjectValue(MyObj)) && !fromEng)
				{
					if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false), (object)(!VstavkaOrCreate))))
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", new object[1] { peremens.trans("Столбец") + "1, " + peremens.trans("Столбец") + "2" }, (string[])null, (Type[])null, false, true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Rows", new object[1] { peremens.trans("Строка") + "1 | " + peremens.trans("Строка") + "1, " + peremens.trans("Строка") + "2 | " + peremens.trans("Строка") + "2" }, (string[])null, (Type[])null, false, true);
					}
				}
				else if ((Iz.IsC(RuntimeHelpers.GetObjectValue(MyObj)) | Iz.IsL(RuntimeHelpers.GetObjectValue(MyObj)) | Iz.IsCL(RuntimeHelpers.GetObjectValue(MyObj))) && !fromEng && Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false), (object)(!VstavkaOrCreate))))
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Items", new object[1] { peremens.trans("Запись") + "1, " + peremens.trans("Запись") + "2" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "text", new object[1] { peremens.trans("Запись") + "1" }, (string[])null, (Type[])null, false, true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedItem", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
				}
			}
		}
		else if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(this.obj, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"IncludeObj", false), (object)VstavkaOrCreate), (object)(NewLateBinding.LateGet(MyObj, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null) == null))))
		{
			object obj5 = proj;
			object[] array5 = new object[1] { RuntimeHelpers.GetObjectValue(MyObj) };
			object[] array8 = array5;
			bool[] array7 = new bool[1] { true };
			object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "GetSostObjFromIncludeObj", array8, (string[])null, (Type[])null, array7);
			if (array7[0])
			{
				MyObj = RuntimeHelpers.GetObjectValue(array5[0]);
			}
			object objectValue2 = RuntimeHelpers.GetObjectValue(obj6);
			if (objectValue2 == null)
			{
				if (!VstavkaOrCreate)
				{
					Interaction.MsgBox((object)Errors.NotSupportIncludeObj(), (MsgBoxStyle)48, (object)null);
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { "" }, (string[])null, (Type[])null, false, true);
				return;
			}
			if (Iz.IsTP(RuntimeHelpers.GetObjectValue(objectValue2)))
			{
				array5 = new object[3]
				{
					RuntimeHelpers.GetObjectValue(MyObj),
					Missing.Value,
					true
				};
				object[] array9 = array5;
				array7 = new bool[3] { true, false, false };
				NewLateBinding.LateCall(objectValue2, (Type)null, "addTabPage", array9, (string[])null, (Type[])null, array7, true);
				if (array7[0])
				{
					MyObj = RuntimeHelpers.GetObjectValue(array5[0]);
				}
			}
			if (Iz.IsMM(RuntimeHelpers.GetObjectValue(objectValue2)) | Iz.IsCM(RuntimeHelpers.GetObjectValue(objectValue2)) | Iz.IsMMs(RuntimeHelpers.GetObjectValue(objectValue2)) | Iz.IsTPl(RuntimeHelpers.GetObjectValue(objectValue2)))
			{
				array5 = new object[1] { RuntimeHelpers.GetObjectValue(MyObj) };
				object[] array10 = array5;
				array7 = new bool[1] { true };
				NewLateBinding.LateCall(objectValue2, (Type)null, "addMMenuItem", array10, (string[])null, (Type[])null, array7, true);
				if (array7[0])
				{
					MyObj = RuntimeHelpers.GetObjectValue(array5[0]);
				}
			}
		}
		checked
		{
			if (Iz.IsMMs(RuntimeHelpers.GetObjectValue(MyObj)))
			{
				ToolStripItem val9 = (ToolStripItem)ob;
				val9.add_MouseDown(new MouseEventHandler(obj_MouseDown));
				val9.add_MouseMove(new MouseEventHandler(obj_MouseMove));
				val9.add_MouseUp(new MouseEventHandler(obj_MouseUp));
				val9.add_DoubleClick((EventHandler)obj_DoubleClick);
				val9.add_Click((EventHandler)obj_Click);
				val9.add_Paint(new PaintEventHandler(obj_Paint));
			}
			else if (Iz.IsDP(RuntimeHelpers.GetObjectValue(MyObj)))
			{
				DP dP = (DP)ob;
				((Control)((SplitContainer)dP).get_Panel1()).add_MouseDown(new MouseEventHandler(obj_MouseDown));
				((Control)((SplitContainer)dP).get_Panel2()).add_MouseDown(new MouseEventHandler(obj_MouseDown));
				((Control)((SplitContainer)dP).get_Panel1()).add_MouseMove(new MouseEventHandler(obj_MouseMove));
				((Control)((SplitContainer)dP).get_Panel2()).add_MouseMove(new MouseEventHandler(obj_MouseMove));
				((Control)((SplitContainer)dP).get_Panel1()).add_MouseUp(new MouseEventHandler(obj_MouseUp));
				((Control)((SplitContainer)dP).get_Panel2()).add_MouseUp(new MouseEventHandler(obj_MouseUp));
				((Control)((SplitContainer)dP).get_Panel1()).add_DoubleClick((EventHandler)obj_DoubleClick);
				((Control)((SplitContainer)dP).get_Panel2()).add_DoubleClick((EventHandler)obj_DoubleClick);
				((Control)((SplitContainer)dP).get_Panel1()).add_Click((EventHandler)obj_Click);
				((Control)((SplitContainer)dP).get_Panel2()).add_Click((EventHandler)obj_Click);
				((Control)((SplitContainer)dP).get_Panel1()).add_Paint(new PaintEventHandler(obj_Paint));
				((Control)((SplitContainer)dP).get_Panel2()).add_Paint(new PaintEventHandler(obj_Paint));
				((Control)dP).add_SizeChanged((EventHandler)obj_Resize);
				((SplitContainer)dP).add_SplitterMoved(new SplitterEventHandler(obj_SplitterMoved));
				((Control)((SplitContainer)dP).get_Panel1()).set_Tag((object)"Panel1");
				((Control)((SplitContainer)dP).get_Panel2()).set_Tag((object)"Panel2");
			}
			else
			{
				eventObj.add_MouseDown(new MouseEventHandler(obj_MouseDown));
				eventObj.add_MouseUp(new MouseEventHandler(obj_MouseUp));
				eventObj.add_MouseMove(new MouseEventHandler(obj_MouseMove));
				eventObj.add_DoubleClick((EventHandler)obj_DoubleClick);
				eventObj.add_Click((EventHandler)obj_Click);
				eventObj.add_GotFocus((EventHandler)obj_GotFocus);
				eventObj.add_Paint(new PaintEventHandler(obj_Paint));
				eventObj.add_SizeChanged((EventHandler)obj_Resize);
				if (Iz.isPanel(RuntimeHelpers.GetObjectValue(this.obj)))
				{
					Panel val10 = (Panel)eventObj;
					((ScrollableControl)val10).add_Scroll(new ScrollEventHandler(obj_Scroll));
					((Control)val10).add_Resize((EventHandler)obj_ResizeNado);
				}
				peremens.HelpObjs = (object[])Utils.CopyArray((Array)peremens.HelpObjs, (Array)new object[peremens.HelpObjs.Length + 1]);
				peremens.HelpObjs[peremens.HelpObjs.Length - 1] = RuntimeHelpers.GetObjectValue(this.obj);
				if (Iz.IsTl(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					DataGridView val11 = (DataGridView)eventObj;
					val11.add_CellClick(new DataGridViewCellEventHandler(obj_CellContentClick));
					val11.add_SelectionChanged((EventHandler)obj_SelectionChanged);
				}
				else if (Iz.IsC(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					ComboBox val12 = (ComboBox)eventObj;
					val12.add_SelectedIndexChanged((EventHandler)obj_SelectedIndexChanged);
				}
				else if (Iz.IsCL(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					CheckedListBox val13 = (CheckedListBox)eventObj;
					((ListBox)val13).add_SelectedIndexChanged((EventHandler)obj_SelectedIndexChanged);
				}
				else if (Iz.IsL(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					ListBox val14 = (ListBox)eventObj;
					val14.add_SelectedIndexChanged((EventHandler)obj_SelectedIndexChanged);
				}
			}
			int num = peremens.MarkCount - 1;
			for (int i = 0; i <= num; i++)
			{
				markers[i] = new PictureBox();
				((Control)markers[i]).set_Width(Conversions.ToInteger(peremens.markerX));
				((Control)markers[i]).set_Height(Conversions.ToInteger(peremens.markerY));
				((Control)markers[i]).set_Visible(false);
				((Control)markers[i]).set_BackColor(Color.White);
				markers[i].set_BorderStyle((BorderStyle)1);
				((Control)markers[i]).add_MouseDown(new MouseEventHandler(markers_MouseDown));
				((Control)markers[i]).add_MouseUp(new MouseEventHandler(markers_MouseUp));
				((Control)markers[i]).add_MouseMove(new MouseEventHandler(markers_MouseMove));
				switch (i)
				{
				case 8:
				{
					PictureBox[] array13 = markers;
					int num2 = i;
					((Control)array13[num2]).set_Width((int)Math.Round((double)((Control)markers[num2]).get_Width() * 1.5));
					PictureBox[] array14 = markers;
					num2 = i;
					((Control)array14[num2]).set_Height((int)Math.Round((double)((Control)markers[num2]).get_Height() * 1.5));
					markers[i].set_Image(peremens.Pictures32.get_Images().get_Item("MoveMarker"));
					markers[i].set_SizeMode((PictureBoxSizeMode)1);
					break;
				}
				case 9:
				{
					PictureBox[] array11 = markers;
					int num2 = i;
					((Control)array11[num2]).set_Width((int)Math.Round((double)((Control)markers[num2]).get_Width() * 1.5));
					PictureBox[] array12 = markers;
					num2 = i;
					((Control)array12[num2]).set_Height((int)Math.Round((double)((Control)markers[num2]).get_Height() * 1.5));
					markers[i].set_Image(peremens.Pictures32.get_Images().get_Item("AddIncludeObj"));
					markers[i].set_SizeMode((PictureBoxSizeMode)1);
					break;
				}
				}
				((Control)markers[i]).set_ContextMenuStrip((ContextMenuStrip)NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ObjsMenu", new object[0], (string[])null, (Type[])null, (bool[])null));
				((Control)markers[i]).set_Tag(RuntimeHelpers.GetObjectValue(MyObj));
				((Control)markers[i]).set_Name("Markers");
			}
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(this.obj, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
			{
				((Control)markers[0]).set_Cursor(Cursors.get_SizeNWSE());
				((Control)markers[7]).set_Cursor(Cursors.get_SizeNWSE());
				((Control)markers[1]).set_Cursor(Cursors.get_SizeNS());
				((Control)markers[6]).set_Cursor(Cursors.get_SizeNS());
				((Control)markers[2]).set_Cursor(Cursors.get_SizeNESW());
				((Control)markers[5]).set_Cursor(Cursors.get_SizeNESW());
				((Control)markers[3]).set_Cursor(Cursors.get_SizeWE());
				((Control)markers[4]).set_Cursor(Cursors.get_SizeWE());
				if (!Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					((Control)GetMyForm().tab).get_Controls().AddRange((Control[])(object)markers);
				}
				else
				{
					((Control)SplitCont.get_Panel1()).get_Controls().Add((Control)this.obj);
					object obj7 = NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "tab", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array5 = new object[1] { SplitCont };
					object[] array15 = array5;
					bool[] array7 = new bool[1] { true };
					NewLateBinding.LateCall(obj7, (Type)null, "Add", array15, (string[])null, (Type[])null, array7, true);
					if (array7[0])
					{
						SplitCont = (SplitContainer)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(SplitContainer));
					}
					object obj8 = NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "tab", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null);
					array5 = new object[1] { markers };
					object[] array16 = array5;
					array7 = new bool[1] { true };
					NewLateBinding.LateCall(obj8, (Type)null, "AddRange", array16, (string[])null, (Type[])null, array7, true);
					if (array7[0])
					{
						markers = (PictureBox[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(PictureBox[]));
					}
					SplitCont.set_Panel2MinSize(0);
					SplitCont.set_SplitterDistance(((Control)SplitCont).get_Height());
					SplitContainer splitCont = SplitCont;
					object? obj9 = peremens.SkinColors["FormsTab"];
					Color color = default(Color);
					((Control)splitCont).set_BackColor((obj9 != null) ? ((Color)obj9) : color);
					((Control)SplitCont.get_Panel1()).set_BackgroundImage((Image)peremens.SkinPictures["FormsTab"]);
					((Control)SplitCont.get_Panel2()).set_BackgroundImage((Image)peremens.SkinPictures["FormsTab"]);
					NewLateBinding.LateSet(MyObj, (Type)null, "splitCont", new object[1] { SplitCont }, (string[])null, (Type[])null);
					object obj10 = NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "TabControl1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TabPages", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array = new object[1];
					object[] array17 = array;
					object obj = MyObj;
					array17[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "tab", new object[0], (string[])null, (Type[])null, (bool[])null));
					array5 = array;
					object[] array18 = array5;
					array7 = new bool[1] { true };
					NewLateBinding.LateCall(obj10, (Type)null, "Add", array18, (string[])null, (Type[])null, array7, true);
					if (array7[0])
					{
						NewLateBinding.LateSetComplex(obj, (Type)null, "tab", new object[1] { RuntimeHelpers.GetObjectValue(array5[0]) }, (string[])null, (Type[])null, true, false);
					}
					obj = new object[1];
					NewLateBinding.LateSet(MyObj, (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(MyObj, (Type)null, "MyObjs", new object[2] { 0, this }, (string[])null, (Type[])null);
					SplitCont.set_SplitterDistance(9999);
					SplitCont.set_SplitterWidth(2);
				}
			}
			else if (conteiner != null)
			{
				((Control)GetMyForm().tab).get_Controls().Add((Control)(object)markers[8]);
				((Control)GetMyForm().tab).get_Controls().Add((Control)(object)markers[9]);
			}
			else
			{
				object obj11 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "tab", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array19 = new object[1];
				object[] array20 = array19;
				PictureBox[] array21 = markers;
				int num2 = 8;
				array20[0] = array21[8];
				object[] array = array19;
				object[] array22 = array;
				bool[] array7 = new bool[1] { true };
				NewLateBinding.LateCall(obj11, (Type)null, "Add", array22, (string[])null, (Type[])null, array7, true);
				if (array7[0])
				{
					markers[num2] = (PictureBox)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(PictureBox));
				}
				object obj12 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "tab", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null);
				array19 = new object[1];
				object[] array23 = array19;
				PictureBox[] array24 = markers;
				num2 = 9;
				array23[0] = array24[9];
				array = array19;
				object[] array25 = array;
				array7 = new bool[1] { true };
				NewLateBinding.LateCall(obj12, (Type)null, "Add", array25, (string[])null, (Type[])null, array7, true);
				if (array7[0])
				{
					markers[num2] = (PictureBox)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(PictureBox));
				}
			}
			((Control)markers[8]).set_Cursor(Cursors.get_SizeAll());
			((Control)markers[9]).set_Cursor(Cursors.get_Hand());
			HideMarker = new PictureBox();
			((Control)HideMarker).SendToBack();
			((Control)HideMarker).set_BackColor(Color.Transparent);
			((Control)HideMarker).set_Width(Conversions.ToInteger(peremens.markerX));
			((Control)HideMarker).set_Height(Conversions.ToInteger(peremens.markerY));
			if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)))
			{
				((Control)SplitCont.get_Panel1()).get_Controls().Add((Control)(object)HideMarker);
			}
			else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(NewLateBinding.LateGet(this.obj, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(this.obj, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"IncludeObj", false))))
			{
				if (NewLateBinding.LateGet(this.obj, (Type)null, "parent", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
				{
					return;
				}
				object obj13 = NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Controls", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array = new object[1] { HideMarker };
				object[] array26 = array;
				bool[] array7 = new bool[1] { true };
				NewLateBinding.LateCall(obj13, (Type)null, "Add", array26, (string[])null, (Type[])null, array7, true);
				if (array7[0])
				{
					HideMarker = (PictureBox)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(PictureBox));
				}
			}
			if (!fromEng)
			{
				AddNode();
			}
		}
		if ((!Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)) & !Iz.IsMMs(RuntimeHelpers.GetObjectValue(MyObj))) && !fromEng)
		{
			GetMyForm().HistoryLevelRun("на передний план", RuntimeHelpers.GetObjectValue(MyObj));
		}
		obj_GotFocus(RuntimeHelpers.GetObjectValue(this.obj), new EventArgs());
		if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)) && proj != null)
		{
			if (NewLateBinding.LateGet(proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
			{
				if (fromEng)
				{
					Type typeFromHandle = typeof(peremens);
					object[] array19 = new object[1];
					object[] array27 = array19;
					object obj = proj;
					array27[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null));
					object[] array = array19;
					object[] array28 = array;
					bool[] array7 = new bool[1] { true };
					NewLateBinding.LateCall((object)null, typeFromHandle, "ReDims", array28, (string[])null, (Type[])null, array7, true);
					if (array7[0])
					{
						NewLateBinding.LateSetComplex(obj, (Type)null, "f", new object[1] { RuntimeHelpers.GetObjectValue(array[0]) }, (string[])null, (Type[])null, true, false);
					}
					NewLateBinding.LateSet(proj, (Type)null, "f", new object[2]
					{
						Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
						RuntimeHelpers.GetObjectValue(MyObj)
					}, (string[])null, (Type[])null);
					NewLateBinding.LateSet(proj, (Type)null, "activeform", new object[1] { RuntimeHelpers.GetObjectValue(MyObj) }, (string[])null, (Type[])null);
				}
				if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2, false))
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "mainform", new object[1] { peremens.trans("Нет") }, (string[])null, (Type[])null, false, true);
				}
				NewLateBinding.LateCall(MyObj, (Type)null, "SetActiveObject", new object[1] { this }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(MyObj, (Type)null, "marker_vis", new object[1] { true }, (string[])null, (Type[])null, (bool[])null, true);
			}
			else if (fromEng)
			{
				Forms[] array29 = new Forms[1] { (Forms)MyObj };
				NewLateBinding.LateSet(proj, (Type)null, "f", new object[1] { array29 }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(proj, (Type)null, "activeform", new object[1] { RuntimeHelpers.GetObjectValue(MyObj) }, (string[])null, (Type[])null);
			}
		}
		if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject((object)(!VstavkaOrCreate & (proj != null)), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(peremens.MyZnak + "none"), false)), (object)(!fromEng))))
		{
			object obj14 = proj;
			object[] array19 = new object[3] { "Создать", "объект", null };
			object[] array30 = array19;
			object? objectValue3 = RuntimeHelpers.GetObjectValue(MyObj);
			peremens.ObjsTreesText ObjsTres = null;
			array30[2] = Perevodi.ToStrFromObj(objectValue3, withParentTree: true, toEng: false, isRun: false, withProgres: false, ref ObjsTres);
			NewLateBinding.LateCall(obj14, (Type)null, "UndoRedo", array19, (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	public TPages addTabPage(TPages TabPage, bool withUndo = false, bool isPaste = false)
	{
		string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(TabPage.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(TabPage.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(peremens.MyZnak + "none"), false))
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(TabPage.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(proj, (Type)null, "GiveName", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)" "), (object)peremens.trans("Закладка")) }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(TabPage.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "text", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(TabPage.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
		}
		TabPage.conteiner = RuntimeHelpers.GetObjectValue(MyObj);
		if (GetMyForm() != null)
		{
			GetMyForm().AddObject(TabPage);
		}
		object obj = NewLateBinding.LateGet(this.obj, (Type)null, "TabPages", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array = new object[1];
		array[0] = RuntimeHelpers.GetObjectValue(TabPage.obj);
		object[] array2 = array;
		object[] array3 = array2;
		bool[] array4 = new bool[1] { true };
		NewLateBinding.LateCall(obj, (Type)null, "Add", array3, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			TabPage.obj = RuntimeHelpers.GetObjectValue(array2[0]);
		}
		if (Operators.CompareString(text, peremens.MyZnak + "none", false) == 0)
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(TabPage.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "position", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "TabPages", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, false, true);
		}
		else
		{
			NewLateBinding.LateCall(TabPage.obj, (Type)null, "moveToPosition", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		if (Operators.CompareString(text, peremens.MyZnak + "none", false) == 0)
		{
			TabPage.NodeRefresh(peremens.MyZnak + "none");
		}
		if (withUndo)
		{
			object obj2 = proj;
			array = new object[3] { "Создать", "объект", null };
			object[] array5 = array;
			peremens.ObjsTreesText ObjsTres = null;
			array5[2] = Perevodi.ToStrFromObj(TabPage, withParentTree: true, toEng: false, isRun: false, withProgres: true, ref ObjsTres);
			NewLateBinding.LateCall(obj2, (Type)null, "UndoRedo", array, (string[])null, (Type[])null, (bool[])null, true);
		}
		return TabPage;
	}

	public MMenus addMMenuItem(MMenus MMenus, bool withUndo = false)
	{
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(MMenus.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(MMenus.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)(peremens.MyZnak + "none"), false))
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(MMenus.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(proj, (Type)null, "GiveName", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)" "), (object)peremens.trans("Пункт")) }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(MMenus.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "text", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(MMenus.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
		}
		MMenus.conteiner = RuntimeHelpers.GetObjectValue(MyObj);
		if (GetMyForm() != null)
		{
			GetMyForm().AddObject(MMenus);
		}
		ToolStripItemCollection val = ((!((Operators.CompareString(this.obj.GetType().ToString(), peremens.ClassAplication + "MM", false) == 0) | (Operators.CompareString(this.obj.GetType().ToString(), peremens.ClassAplication + "runMM", false) == 0) | (Operators.CompareString(this.obj.GetType().ToString(), peremens.ClassAplication + "CM", false) == 0) | (Operators.CompareString(this.obj.GetType().ToString(), peremens.ClassAplication + "runCM", false) == 0) | (Operators.CompareString(this.obj.GetType().ToString(), peremens.ClassAplication + "TPl", false) == 0) | (Operators.CompareString(this.obj.GetType().ToString(), peremens.ClassAplication + "runTPl", false) == 0))) ? ((ToolStripItemCollection)NewLateBinding.LateGet(this.obj, (Type)null, "DropDownItems", new object[0], (string[])null, (Type[])null, (bool[])null)) : ((ToolStripItemCollection)NewLateBinding.LateGet(this.obj, (Type)null, "items", new object[0], (string[])null, (Type[])null, (bool[])null)));
		object[] array = new object[1];
		array[0] = RuntimeHelpers.GetObjectValue(MMenus.obj);
		object[] array2 = array;
		object[] array3 = array2;
		bool[] array4 = new bool[1] { true };
		NewLateBinding.LateCall((object)val, (Type)null, "Add", array3, (string[])null, (Type[])null, array4, true);
		if (array4[0])
		{
			MMenus.obj = RuntimeHelpers.GetObjectValue(array2[0]);
		}
		if (Operators.CompareString(text, peremens.MyZnak + "none", false) == 0)
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(MMenus.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "position", new object[1] { checked(((ArrangedElementCollection)val).get_Count() - 1) }, (string[])null, (Type[])null, false, true);
		}
		else
		{
			NewLateBinding.LateCall(MMenus.obj, (Type)null, "moveToPosition", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		if (Operators.CompareString(text, peremens.MyZnak + "none", false) == 0)
		{
			MMenus.NodeRefresh(peremens.MyZnak + "none");
		}
		if (withUndo)
		{
			object obj = proj;
			array = new object[3] { "Создать", "объект", null };
			object[] array5 = array;
			peremens.ObjsTreesText ObjsTres = null;
			array5[2] = Perevodi.ToStrFromObj(MMenus, withParentTree: true, toEng: false, isRun: false, withProgres: true, ref ObjsTres);
			NewLateBinding.LateCall(obj, (Type)null, "UndoRedo", array, (string[])null, (Type[])null, (bool[])null, true);
		}
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(MMenus.obj, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "text", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(MMenus.obj, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "text", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
		return MMenus;
	}

	public Point GetXY(object obj, object cont, int na4alX, int na4alY)
	{
		checked
		{
			if (NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
			{
				if (NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
				{
					int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
					for (int i = 0; i <= num; i++)
					{
						object obj2 = NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array = new object[1] { i };
						bool[] array2 = new bool[1] { true };
						object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "MyObjs", array, (string[])null, (Type[])null, array2);
						if (array2[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
						}
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(obj, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), false))
						{
							object obj4 = NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
							object[] array3 = new object[1] { i };
							bool[] array4 = new bool[1] { true };
							object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "MyObjs", array3, (string[])null, (Type[])null, array4);
							if (array4[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
							}
							object obj6 = Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "left", new object[0], (string[])null, (Type[])null, (bool[])null), (object)na4alX, false);
							object obj7 = NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
							object[] array5 = new object[1] { i };
							bool[] array6 = new bool[1] { true };
							object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "MyObjs", array5, (string[])null, (Type[])null, array6);
							if (array6[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(int));
							}
							if (Conversions.ToBoolean(Operators.AndObject(obj6, Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj8, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[0], (string[])null, (Type[])null, (bool[])null), (object)na4alY, false))))
							{
								return GetXY(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(cont), na4alX + peremens.setka, na4alY + peremens.setka);
							}
						}
					}
				}
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false), Operators.CompareObjectGreater((object)na4alY, Operators.SubtractObject(NewLateBinding.LateGet(cont, (Type)null, "height", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(obj, (Type)null, "height", new object[0], (string[])null, (Type[])null, (bool[])null)), false))))
				{
					return GetXY(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(cont), na4alX, (int)Math.Round((double)na4alY - (double)peremens.setka / 2.0));
				}
				return new Point(na4alX, na4alY);
			}
			Point result = default(Point);
			return result;
		}
	}

	private void markers_MouseDown(object sender, MouseEventArgs e)
	{
		NewLateBinding.LateCall(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "Peremeschatel", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		markers_perenos = Array.IndexOf((Array)markers, RuntimeHelpers.GetObjectValue(sender));
		if (markers_perenos != -1)
		{
			mdx = e.get_X();
			mdy = e.get_Y();
			NewLateBinding.LateCall(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "marker_vis", new object[1] { false }, (string[])null, (Type[])null, (bool[])null, true);
			SolvRaznica();
			if ((markers_perenos == 8) & Iz.isNoMove(RuntimeHelpers.GetObjectValue(obj)))
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "marker_vis", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private void markers_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a88: Invalid comparison between Unknown and I4
		if (((markers_perenos == 8) & Iz.isNoMove(RuntimeHelpers.GetObjectValue(this.obj))) || (((mdx == e.get_X()) & (mdy == e.get_Y())) | (markers_perenos == 9)) || markers_perenos == -1)
		{
			return;
		}
		checked
		{
			if (unchecked((int)Control.get_ModifierKeys()) == 131072)
			{
				((Control)markers[markers_perenos]).set_Left(((Control)markers[markers_perenos]).get_Left() + e.get_X() - mdx);
				((Control)markers[markers_perenos]).set_Top(((Control)markers[markers_perenos]).get_Top() + e.get_Y() - mdy);
			}
			else
			{
				((Control)markers[markers_perenos]).set_Left(unchecked(checked(((Control)markers[markers_perenos]).get_Left() + e.get_X() - mdx) / peremens.setka) * peremens.setka);
				((Control)markers[markers_perenos]).set_Top(unchecked(checked(((Control)markers[markers_perenos]).get_Top() + e.get_Y() - mdy) / peremens.setka) * peremens.setka);
			}
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			Point point = default(Point);
			for (int i = 0; i <= num; i++)
			{
				int left = ((Control)markers[markers_perenos]).get_Left();
				int top = ((Control)markers[markers_perenos]).get_Top();
				object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ContenerAbsXY", new object[1] { this }, (string[])null, (Type[])null, (bool[])null);
				Point point2 = ((obj != null) ? ((Point)obj) : point);
				left -= point2.X;
				top -= point2.Y;
				object obj2 = NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array = new object[1] { i };
				object[] array2 = array;
				bool[] array3 = new bool[1] { true };
				object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "ActiveObj", array2, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
				object obj4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null));
				object obj5 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "Top", new object[0], (string[])null, (Type[])null, (bool[])null));
				object obj6 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "height", new object[0], (string[])null, (Type[])null, (bool[])null));
				double num2 = Conversions.ToDouble(NewLateBinding.LateGet(objectValue, (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null));
				switch (markers_perenos)
				{
				case 0:
					num2 = Conversions.ToDouble(Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null), (object)left), NewLateBinding.LateGet(this.obj, (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)((Control)markers[markers_perenos]).get_Width()), (object)raznicaSize[i].X));
					obj6 = Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "Top", new object[0], (string[])null, (Type[])null, (bool[])null), (object)top), NewLateBinding.LateGet(this.obj, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)((Control)markers[markers_perenos]).get_Height()), (object)raznicaSize[i].Y);
					obj4 = left + ((Control)markers[markers_perenos]).get_Width() - raznicaLoc[i].X;
					obj5 = top + ((Control)markers[markers_perenos]).get_Height() - raznicaLoc[i].Y;
					break;
				case 1:
					obj6 = Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "Top", new object[0], (string[])null, (Type[])null, (bool[])null), (object)top), NewLateBinding.LateGet(this.obj, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)((Control)markers[markers_perenos]).get_Height()), (object)raznicaSize[i].Y);
					obj5 = top + ((Control)markers[markers_perenos]).get_Height() - raznicaLoc[i].Y;
					break;
				case 2:
					num2 = Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(Operators.SubtractObject((object)left, NewLateBinding.LateGet(this.obj, (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)raznicaSize[i].X), (object)((Control)markers[markers_perenos]).get_Width()));
					obj6 = Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "Top", new object[0], (string[])null, (Type[])null, (bool[])null), (object)top), NewLateBinding.LateGet(this.obj, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)((Control)markers[markers_perenos]).get_Height()), (object)raznicaSize[i].Y);
					obj5 = top + ((Control)markers[markers_perenos]).get_Height() - raznicaLoc[i].Y;
					break;
				case 3:
					num2 = Conversions.ToDouble(Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null), (object)left), NewLateBinding.LateGet(this.obj, (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)((Control)markers[markers_perenos]).get_Width()), (object)raznicaSize[i].X));
					obj4 = left + ((Control)markers[markers_perenos]).get_Width() - raznicaLoc[i].X;
					break;
				case 4:
					if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
					{
						num2 = Conversions.ToDouble(Operators.SubtractObject(Operators.SubtractObject((object)left, NewLateBinding.LateGet(this.obj, (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)raznicaSize[i].X));
					}
					break;
				case 5:
					num2 = Conversions.ToDouble(Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null), (object)left), NewLateBinding.LateGet(this.obj, (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)((Control)markers[markers_perenos]).get_Width()), (object)raznicaSize[i].X));
					obj6 = Operators.AddObject(Operators.SubtractObject(Operators.SubtractObject((object)top, NewLateBinding.LateGet(this.obj, (Type)null, "Top", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)raznicaSize[i].Y), (object)((Control)markers[markers_perenos]).get_Height());
					obj4 = left + ((Control)markers[markers_perenos]).get_Width() - raznicaLoc[i].X;
					break;
				case 6:
					if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
					{
						obj6 = Operators.AddObject(Operators.SubtractObject(Operators.SubtractObject((object)top, NewLateBinding.LateGet(this.obj, (Type)null, "Top", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)raznicaSize[i].Y), (object)((Control)markers[markers_perenos]).get_Height());
					}
					break;
				case 7:
					if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
					{
						num2 = Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(Operators.SubtractObject((object)left, NewLateBinding.LateGet(this.obj, (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)raznicaSize[i].X), (object)((Control)markers[markers_perenos]).get_Width()));
						obj6 = Operators.AddObject(Operators.SubtractObject(Operators.SubtractObject((object)top, NewLateBinding.LateGet(this.obj, (Type)null, "Top", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)raznicaSize[i].Y), (object)((Control)markers[markers_perenos]).get_Height());
					}
					break;
				case 8:
					obj4 = Operators.SubtractObject((object)(left - raznicaLoc[i].X), peremens.markerX);
					obj5 = top - raznicaLoc[i].Y + ((Control)markers[markers_perenos]).get_Height();
					break;
				}
				if (unchecked((int)Control.get_ModifierKeys()) == 131072)
				{
					NewLateBinding.LateSet(objectValue, (Type)null, "Width", new object[1] { num2 }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue, (Type)null, "Height", new object[1] { RuntimeHelpers.GetObjectValue(obj6) }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue, (Type)null, "Left", new object[1] { RuntimeHelpers.GetObjectValue(obj4) }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue, (Type)null, "Top", new object[1] { RuntimeHelpers.GetObjectValue(obj5) }, (string[])null, (Type[])null);
				}
				else
				{
					NewLateBinding.LateSet(objectValue, (Type)null, "Width", new object[1] { unchecked(checked((long)Math.Round(num2)) / peremens.setka) * peremens.setka + 3L }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue, (Type)null, "Height", new object[1] { Operators.AddObject(Operators.MultiplyObject(Operators.IntDivideObject(obj6, (object)peremens.setka), (object)peremens.setka), (object)3) }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue, (Type)null, "Left", new object[1] { Operators.MultiplyObject(Operators.IntDivideObject(obj4, (object)peremens.setka), (object)peremens.setka) }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue, (Type)null, "Top", new object[1] { Operators.MultiplyObject(Operators.IntDivideObject(obj5, (object)peremens.setka), (object)peremens.setka) }, (string[])null, (Type[])null);
				}
			}
		}
	}

	private void markers_MouseUp(object sender, MouseEventArgs e)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		if ((markers_perenos == 8) & Iz.isNoMove(RuntimeHelpers.GetObjectValue(obj)))
		{
			return;
		}
		BackPoluObj((object[])NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[0], (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateCall(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "marker_vis", new object[1] { true }, (string[])null, (Type[])null, (bool[])null, true);
		if (markers_perenos == 9)
		{
			if ((int)e.get_Button() == 1048576)
			{
				NewLateBinding.LateCall(peremens2.MainForm, (Type)null, "AddMenu_Click", new object[2] { null, null }, (string[])null, (Type[])null, (bool[])null, true);
			}
			else if ((int)e.get_Button() == 2097152)
			{
				((ToolStripDropDown)((Control)markers[markers_perenos]).get_ContextMenuStrip()).Show((Control)(object)markers[markers_perenos], 2, 2);
			}
		}
		else
		{
			checked
			{
				if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(obj, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
				{
					((Control)HideMarker).set_Left(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(obj, (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(obj, (Type)null, "width", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)((Control)HideMarker).get_Width())));
					((Control)HideMarker).set_Top(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(obj, (Type)null, "Top", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(obj, (Type)null, "height", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)((Control)HideMarker).get_Height())));
					if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)))
					{
						PictureBox hideMarker = HideMarker;
						((Control)hideMarker).set_Left(((Control)hideMarker).get_Left() + ((Control)HideMarker).get_Width());
						hideMarker = HideMarker;
						((Control)hideMarker).set_Top(((Control)hideMarker).get_Top() + ((Control)HideMarker).get_Height());
					}
					NewLateBinding.LateCall(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "marker_vis", new object[1] { true }, (string[])null, (Type[])null, (bool[])null, true);
				}
				if ((mdx != e.get_X()) | (mdy != e.get_Y()))
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "ContextMenuStrip", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
					Props.IzmenenieBylo();
				}
			}
		}
		markers_perenos = -1;
	}

	public void SolvRaznica()
	{
		if (NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
		{
			return;
		}
		checked
		{
			raznicaSize = new Point[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
			raznicaLoc = new Point[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
			int num = raznicaSize.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				ref Point reference = ref raznicaSize[i];
				object obj = NewLateBinding.LateGet(this.obj, (Type)null, "width", new object[0], (string[])null, (Type[])null, (bool[])null);
				object obj2 = NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array = new object[1] { i };
				object[] array2 = array;
				bool[] array3 = new bool[1] { true };
				object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "ActiveObj", array2, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				reference.X = Conversions.ToInteger(Operators.SubtractObject(obj, NewLateBinding.LateGet(NewLateBinding.LateGet(obj3, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "width", new object[0], (string[])null, (Type[])null, (bool[])null)));
				ref Point reference2 = ref raznicaSize[i];
				object obj4 = NewLateBinding.LateGet(this.obj, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null);
				object obj5 = NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array4 = new object[1] { i };
				object[] array5 = array4;
				array3 = new bool[1] { true };
				object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "ActiveObj", array5, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
				}
				reference2.Y = Conversions.ToInteger(Operators.SubtractObject(obj4, NewLateBinding.LateGet(NewLateBinding.LateGet(obj6, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)));
				ref Point reference3 = ref raznicaLoc[i];
				object obj7 = NewLateBinding.LateGet(this.obj, (Type)null, "left", new object[0], (string[])null, (Type[])null, (bool[])null);
				object obj8 = NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
				array4 = new object[1] { i };
				object[] array6 = array4;
				array3 = new bool[1] { true };
				object obj9 = NewLateBinding.LateGet(obj8, (Type)null, "ActiveObj", array6, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
				}
				reference3.X = Conversions.ToInteger(Operators.SubtractObject(obj7, NewLateBinding.LateGet(NewLateBinding.LateGet(obj9, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "left", new object[0], (string[])null, (Type[])null, (bool[])null)));
				ref Point reference4 = ref raznicaLoc[i];
				object obj10 = NewLateBinding.LateGet(this.obj, (Type)null, "top", new object[0], (string[])null, (Type[])null, (bool[])null);
				object obj11 = NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
				array4 = new object[1] { i };
				object[] array7 = array4;
				array3 = new bool[1] { true };
				object obj12 = NewLateBinding.LateGet(obj11, (Type)null, "ActiveObj", array7, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
				}
				reference4.Y = Conversions.ToInteger(Operators.SubtractObject(obj10, NewLateBinding.LateGet(NewLateBinding.LateGet(obj12, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "top", new object[0], (string[])null, (Type[])null, (bool[])null)));
			}
		}
	}

	public void obj_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Invalid comparison between Unknown and I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576 && Iz.isPanel(RuntimeHelpers.GetObjectValue(obj)))
		{
			na4Point = e.get_Location();
			click = true;
			return;
		}
		if (Conversions.ToBoolean(Operators.OrObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "IsActiveObject", new object[1] { this }, (string[])null, (Type[])null, (bool[])null), (object)false, false), (object)((int)Control.get_ModifierKeys() != 131072)), (object)(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[0], (string[])null, (Type[])null, (bool[])null) == null))))
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SetActiveObject", new object[1] { this }, (string[])null, (Type[])null, (bool[])null, true);
			if (!((Control)markers[8]).get_Visible())
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "marker_vis", new object[1] { true }, (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		if (Conversions.ToBoolean(Operators.OrObject((object)((int)e.get_Button() == 1048576), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "IsActiveObject", new object[1] { this }, (string[])null, (Type[])null, (bool[])null), (object)false, false))))
		{
			peremens.perenos = true;
			dx = e.get_X();
			dy = e.get_Y();
			click = true;
			if (!Iz.isMoveOnlyMarker(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				NewLateBinding.LateSet(obj, (Type)null, "Cursor", new object[1] { Cursors.get_NoMove2D() }, (string[])null, (Type[])null);
			}
			SolvRaznica();
		}
		zashita = true;
	}

	public void obj_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Invalid comparison between Unknown and I4
		if (Iz.isNoMove(RuntimeHelpers.GetObjectValue(this.obj)))
		{
			peremens.perenos = false;
		}
		else
		{
			if (Iz.isMoveOnlyMarker(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				return;
			}
			Point point = default(Point);
			if (zashita)
			{
				zashita = false;
				dx = e.get_X();
				dy = e.get_Y();
			}
			else if (na4Point != point)
			{
				if (Iz.isPanel(RuntimeHelpers.GetObjectValue(this.obj)))
				{
					click = false;
					endPoint = e.get_Location();
					NewLateBinding.LateCall(sender, (Type)null, "refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			else if (peremens.perenos & ((e.get_X() != dx) | (e.get_Y() != dy)))
			{
				if ((NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[0], (string[])null, (Type[])null, (bool[])null) == null) | (raznicaLoc == null))
				{
					peremens.perenos = false;
				}
				else if (Iz.isMoveOnlyMarker(RuntimeHelpers.GetObjectValue(sender)))
				{
					peremens.perenos = false;
				}
				else
				{
					if (!Operators.ConditionalCompareObjectEqual((object)raznicaLoc.Length, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null), false))
					{
						return;
					}
					int num = checked(raznicaLoc.Length - 1);
					for (int i = 0; i <= num; i = checked(i + 1))
					{
						object obj = NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array = new object[1] { i };
						object[] array2 = array;
						bool[] array3 = new bool[1] { true };
						object obj2 = NewLateBinding.LateGet(obj, (Type)null, "ActiveObj", array2, (string[])null, (Type[])null, array3);
						if (array3[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
						}
						if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(obj2)))
						{
							continue;
						}
						if ((int)Control.get_ModifierKeys() == 131072)
						{
							object obj3 = NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
							object[] array4 = new object[1] { i };
							object[] array5 = array4;
							array3 = new bool[1] { true };
							object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "ActiveObj", array5, (string[])null, (Type[])null, array3);
							if (array3[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
							}
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj4, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[1] { Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null), (object)e.get_X()), (object)dx), (object)raznicaLoc[i].X) }, (string[])null, (Type[])null, false, true);
							object obj5 = NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
							array = new object[1] { i };
							object[] array6 = array;
							array3 = new bool[1] { true };
							object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "ActiveObj", array6, (string[])null, (Type[])null, array3);
							if (array3[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
							}
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj6, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[1] { Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null), (object)e.get_Y()), (object)dy), (object)raznicaLoc[i].Y) }, (string[])null, (Type[])null, false, true);
						}
						else
						{
							object obj7 = NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
							array = new object[1] { i };
							object[] array7 = array;
							array3 = new bool[1] { true };
							object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "ActiveObj", array7, (string[])null, (Type[])null, array3);
							if (array3[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
							}
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj8, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Left", new object[1] { Operators.MultiplyObject(Operators.IntDivideObject(Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null), (object)e.get_X()), (object)dx), (object)raznicaLoc[i].X), (object)peremens.setka), (object)peremens.setka) }, (string[])null, (Type[])null, false, true);
							object obj9 = NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
							array = new object[1] { i };
							object[] array8 = array;
							array3 = new bool[1] { true };
							object obj10 = NewLateBinding.LateGet(obj9, (Type)null, "ActiveObj", array8, (string[])null, (Type[])null, array3);
							if (array3[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
							}
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj10, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Top", new object[1] { Operators.MultiplyObject(Operators.IntDivideObject(Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Bounds", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null), (object)e.get_Y()), (object)dy), (object)raznicaLoc[i].Y), (object)peremens.setka), (object)peremens.setka) }, (string[])null, (Type[])null, false, true);
						}
					}
					click = false;
				}
			}
			else if (!peremens.perenos)
			{
				NewLateBinding.LateSet(this.obj, (Type)null, "Cursor", new object[1] { RuntimeHelpers.GetObjectValue(peremens.Cursori[RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "cursor", new object[0], (string[])null, (Type[])null, (bool[])null))]) }, (string[])null, (Type[])null);
			}
		}
	}

	public void obj_MouseUp(object sender, MouseEventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Invalid comparison between Unknown and I4
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Invalid comparison between Unknown and I4
		//IL_0b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba1: Invalid comparison between Unknown and I4
		//IL_0c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c75: Expected O, but got Unknown
		peremens.perenos = false;
		if (Conversions.ToBoolean(Operators.OrObject((object)((int)e.get_Button() == 1048576), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "IsActiveObject", new object[1] { this }, (string[])null, (Type[])null, (bool[])null), (object)false, false))))
		{
			if (Iz.isMoveOnlyMarker(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
			{
				return;
			}
			if (Iz.isPanel(RuntimeHelpers.GetObjectValue(this.obj)))
			{
				if (!click)
				{
					object obj = NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
					if ((int)Control.get_ModifierKeys() != 131072)
					{
						NewLateBinding.LateCall(obj, (Type)null, "ClearActiveObject", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					if (NewLateBinding.LateGet(obj, (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
					{
						int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
						int num4 = default(int);
						for (int i = 0; i <= num; i = checked(i + 1))
						{
							object obj2 = obj;
							object[] array = new object[1] { i };
							object[] array2 = array;
							bool[] array3 = new bool[1] { true };
							object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "MyObjs", array2, (string[])null, (Type[])null, array3);
							if (array3[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
							}
							if (NewLateBinding.LateGet(obj3, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
							{
								continue;
							}
							object[] array4;
							if (sender == NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitCont", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null))
							{
								object obj4 = obj;
								array4 = new object[1] { i };
								object[] array5 = array4;
								array3 = new bool[1] { true };
								object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "MyObjs", array5, (string[])null, (Type[])null, array3);
								if (array3[0])
								{
									i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
								}
								if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
								{
									continue;
								}
							}
							else
							{
								object obj6 = obj;
								array4 = new object[1] { i };
								object[] array6 = array4;
								array3 = new bool[1] { true };
								object obj7 = NewLateBinding.LateGet(obj6, (Type)null, "MyObjs", array6, (string[])null, (Type[])null, array3);
								if (array3[0])
								{
									i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
								}
								if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj7, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
								{
									continue;
								}
							}
							object obj8 = obj;
							array4 = new object[1] { i };
							object[] array7 = array4;
							array3 = new bool[1] { true };
							object obj9 = NewLateBinding.LateGet(obj8, (Type)null, "MyObjs", array7, (string[])null, (Type[])null, array3);
							if (array3[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
							}
							bool num2 = NewLateBinding.LateGet(NewLateBinding.LateGet(obj9, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "parent", new object[0], (string[])null, (Type[])null, (bool[])null) == sender;
							object obj10 = obj;
							object[] array8 = new object[1] { i };
							object[] array9 = array8;
							bool[] array10 = new bool[1] { true };
							object obj11 = NewLateBinding.LateGet(obj10, (Type)null, "MyObjs", array9, (string[])null, (Type[])null, array10);
							if (array10[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
							}
							if (!(num2 & (NewLateBinding.LateGet(obj11, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null) != sender)))
							{
								continue;
							}
							object obj12 = obj;
							array = new object[3];
							object[] array11 = array;
							object obj13 = obj;
							object[] array12 = new object[1] { i };
							object[] array13 = array12;
							string[] array14 = null;
							array10 = new bool[1] { true };
							object obj14 = NewLateBinding.LateGet(obj13, (Type)null, "MyObjs", array13, array14, (Type[])null, array10);
							array3 = array10;
							bool[] array15 = array3;
							int num3 = 0;
							if (array15[0])
							{
								num4 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(int));
								i = num4;
							}
							array11[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj14, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
							array[1] = na4Point;
							array[2] = endPoint;
							array4 = array;
							object[] array16 = array4;
							bool[] array17 = new bool[3] { true, true, true };
							object obj15 = NewLateBinding.LateGet(obj12, (Type)null, "inRectangle", array16, (string[])null, (Type[])null, array17);
							if (array17[0])
							{
								object obj16 = NewLateBinding.LateGet(obj13, (Type)null, "MyObjs", array12, array14, (Type[])null, new bool[1] { true });
								if (array3[num3])
								{
									i = num4;
								}
								NewLateBinding.LateSetComplex(obj16, (Type)null, "obj", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, true);
							}
							if (array17[1])
							{
								na4Point = (Point)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(Point));
							}
							if (array17[2])
							{
								endPoint = (Point)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[2]), typeof(Point));
							}
							if (Conversions.ToBoolean(obj15))
							{
								object obj17 = obj;
								object[] array18 = new object[2];
								object obj18 = proj;
								object[] array19 = new object[0];
								string[] array20 = null;
								object obj19 = NewLateBinding.LateGet(obj18, (Type)null, "ActiveForm", array19, array20, (Type[])null, (bool[])null);
								object[] array21 = new object[1] { i };
								bool[] array22 = new bool[1] { true };
								object obj20 = NewLateBinding.LateGet(obj19, (Type)null, "MyObjs", array21, (string[])null, (Type[])null, array22);
								if (array22[0])
								{
									i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array21[0]), typeof(int));
								}
								array18[0] = RuntimeHelpers.GetObjectValue(obj20);
								array18[1] = true;
								object[] array23 = array18;
								object[] array24 = array23;
								bool[] array25 = new bool[2] { true, false };
								NewLateBinding.LateCall(obj17, (Type)null, "AddActiveObject", array24, (string[])null, (Type[])null, array25, true);
								if (array25[0])
								{
									NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj18, (Type)null, "ActiveForm", array19, array20, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
									{
										i,
										RuntimeHelpers.GetObjectValue(array23[0])
									}, (string[])null, (Type[])null, true, true);
								}
							}
						}
						NewLateBinding.LateCall(obj, (Type)null, "FillListView", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					if (sender != NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitCont", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null) && ((NewLateBinding.LateGet(obj, (Type)null, "ActiveObj", new object[0], (string[])null, (Type[])null, (bool[])null) == null) & !click))
					{
						NewLateBinding.LateCall(obj, (Type)null, "SetActiveObject", new object[1] { this }, (string[])null, (Type[])null, (bool[])null, true);
					}
					obj = null;
				}
				na4Point = default(Point);
				endPoint = default(Point);
				NewLateBinding.LateCall(sender, (Type)null, "refresh", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			na4Point = default(Point);
			endPoint = default(Point);
			if (click)
			{
				if ((int)Control.get_ModifierKeys() == 131072)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AddActiveObject", new object[1] { this }, (string[])null, (Type[])null, (bool[])null, true);
				}
				else
				{
					if (NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "activeobj", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SetActiveObject", new object[1] { this }, (string[])null, (Type[])null, (bool[])null, true);
					}
					if (NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "activeobj", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null) != this)
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SetActiveObject", new object[1] { this }, (string[])null, (Type[])null, (bool[])null, true);
					}
				}
				if (Iz.IsCM(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					object obj21 = NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CnMn", new object[0], (string[])null, (Type[])null, (bool[])null);
					object[] array23 = new object[3]
					{
						RuntimeHelpers.GetObjectValue(this.obj),
						e.get_X(),
						e.get_Y()
					};
					object[] array26 = array23;
					bool[] array25 = new bool[3] { true, false, false };
					NewLateBinding.LateCall(obj21, (Type)null, "Show", array26, (string[])null, (Type[])null, array25, true);
					if (array25[0])
					{
						this.obj = RuntimeHelpers.GetObjectValue(array23[0]);
					}
				}
			}
			else
			{
				BackPoluObj((object[])NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ActiveObj", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			checked
			{
				if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(this.obj, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
				{
					((Control)HideMarker).set_Left(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(this.obj, (Type)null, "Left", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(this.obj, (Type)null, "width", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)((Control)HideMarker).get_Width())));
					((Control)HideMarker).set_Top(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(this.obj, (Type)null, "Top", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(this.obj, (Type)null, "height", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)((Control)HideMarker).get_Height())));
					if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)))
					{
						PictureBox hideMarker = HideMarker;
						((Control)hideMarker).set_Left(((Control)hideMarker).get_Left() + ((Control)HideMarker).get_Width());
						hideMarker = HideMarker;
						((Control)hideMarker).set_Top(((Control)hideMarker).get_Top() + ((Control)HideMarker).get_Height());
					}
				}
				peremens.perenos = false;
				NewLateBinding.LateCall(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "marker_vis", new object[1] { true }, (string[])null, (Type[])null, (bool[])null, true);
				obj_GotFocus(RuntimeHelpers.GetObjectValue(sender), new EventArgs());
			}
		}
		if (((int)e.get_Button() == 2097152) & Iz.IsMMs(RuntimeHelpers.GetObjectValue(MyObj)))
		{
			NewLateBinding.LateCall(this.obj, (Type)null, "Select", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			object obj22 = NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "ObjsMenu", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array27 = new object[3];
			object[] array28 = array27;
			PictureBox[] array29 = markers;
			int num4 = 9;
			array28[0] = array29[9];
			array27[1] = 2;
			array27[2] = 2;
			object[] array23 = array27;
			object[] array30 = array23;
			bool[] array25 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj22, (Type)null, "Show", array30, (string[])null, (Type[])null, array25, true);
			if (array25[0])
			{
				markers[num4] = (PictureBox)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array23[0]), typeof(PictureBox));
			}
		}
		((Control)HideMarker).SendToBack();
		Props.IzmenenieBylo();
		obj_GotFocus(RuntimeHelpers.GetObjectValue(sender), (EventArgs)(object)e);
	}

	public void obj_Click(object sender, EventArgs e)
	{
		if (ob_cl == sender)
		{
			TimeSpan timeSpan = DateTime.Now - tm;
			TimeSpan timeSpan2 = new TimeSpan(4000000L);
			if (timeSpan <= timeSpan2)
			{
				obj_DoubleClick(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}
		ob_cl = RuntimeHelpers.GetObjectValue(sender);
		tm = DateAndTime.get_Now();
	}

	public void obj_DoubleClick(object sender, EventArgs e)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		NewLateBinding.LateSet(peremens2.MainForm, (Type)null, "SelNodes", new object[1] { null }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(peremens2.MainForm, (Type)null, "SelNode", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyObj, (Type)null, "getNode", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
		tree.set_SelectedNode((TreeNode)NewLateBinding.LateGet(MyObj, (Type)null, "getNode", new object[0], (string[])null, (Type[])null, (bool[])null));
	}

	private void obj_GotFocus(object sender, EventArgs e)
	{
		if (!Iz.isMoveOnlyMarker(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "Peremeschatel", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Focus", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	public void BackPoluObj(object[] ob)
	{
		if ((ob == null) | (NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null) == null))
		{
			return;
		}
		checked
		{
			int num = ob.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(ob[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
				{
					if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(NewLateBinding.LateGet(ob[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "top", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(ob[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "top", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
					}
					if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(NewLateBinding.LateGet(ob[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "left", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(ob[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "left", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
					}
					if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(ob[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "left", new object[0], (string[])null, (Type[])null, (bool[])null), Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitCont", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(ob[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)), false))
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(ob[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "left", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitCont", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(ob[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
					}
					if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(ob[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "top", new object[0], (string[])null, (Type[])null, (bool[])null), Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitCont", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(ob[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)), false))
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(ob[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "top", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitCont", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(ob[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
					}
				}
			}
		}
	}

	public void BackPoluObj(bool odin, object ob)
	{
		BackPoluObj(new object[1] { RuntimeHelpers.GetObjectValue(ob) });
	}

	private void obj_Scroll(object sender, ScrollEventArgs e)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		obj_ResizeNado(RuntimeHelpers.GetObjectValue(sender), new EventArgs());
		object obj = NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
		object[] array = new object[2]
		{
			RuntimeHelpers.GetObjectValue(sender),
			e
		};
		bool[] array2 = new bool[2] { true, true };
		NewLateBinding.LateCall(obj, (Type)null, "Scroll", array, (string[])null, (Type[])null, array2, true);
		if (array2[0])
		{
			sender = RuntimeHelpers.GetObjectValue(array[0]);
		}
		if (array2[1])
		{
			e = (ScrollEventArgs)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(ScrollEventArgs));
		}
	}

	private void obj_Resize(object sender, EventArgs e)
	{
	}

	public void obj_Paint(object sender, PaintEventArgs e)
	{
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		Point point = default(Point);
		if (na4Point != point)
		{
			Point[] array = new Point[4]
			{
				na4Point,
				new Point(endPoint.X, na4Point.Y),
				endPoint,
				new Point(na4Point.X, endPoint.Y)
			};
			e.get_Graphics().DrawPolygon(Pens.get_Black(), array);
		}
		if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"0", false))
		{
			if (Iz.IsM(RuntimeHelpers.GetObjectValue(MyObj)))
			{
				NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "FillRectangle", new object[5]
				{
					Brushes.get_White(),
					2,
					2,
					Operators.MultiplyObject(Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2), (object)3),
					6
				}, (string[])null, (Type[])null, (bool[])null, true);
				e.get_Graphics().DrawString(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"(", NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)")")), new Font("Arial", 6f), Brushes.get_Black(), 0f, 0f);
			}
			else
			{
				NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "FillRectangle", new object[5]
				{
					Brushes.get_White(),
					4,
					4,
					Operators.MultiplyObject(Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2), (object)3),
					6
				}, (string[])null, (Type[])null, (bool[])null, true);
				e.get_Graphics().DrawString(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"(", NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)")")), new Font("Arial", 6f), Brushes.get_Black(), 2f, 2f);
				e.get_Graphics().DrawString(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)), new Font("Arial", 6f, (FontStyle)1), Brushes.get_Black(), 2f, Conversions.ToSingle(Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "height", new object[0], (string[])null, (Type[])null, (bool[])null), (object)12)));
			}
		}
		if (Iz.IsMMs(RuntimeHelpers.GetObjectValue(MyObj)))
		{
			object obj = NewLateBinding.LateGet(proj, (Type)null, "activeform", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array2 = new object[1] { RuntimeHelpers.GetObjectValue(MyObj) };
			object[] array3 = array2;
			bool[] array4 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "IsActiveObject", array3, (string[])null, (Type[])null, array4);
			if (array4[0])
			{
				MyObj = RuntimeHelpers.GetObjectValue(array2[0]);
			}
			if (Conversions.ToBoolean(obj2))
			{
				NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "DrawRectangle", new object[5]
				{
					Pens.get_Black(),
					3,
					3,
					Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "width", new object[0], (string[])null, (Type[])null, (bool[])null), (object)6),
					Operators.SubtractObject(NewLateBinding.LateGet(this.obj, (Type)null, "height", new object[0], (string[])null, (Type[])null, (bool[])null), (object)6)
				}, (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		if (!Iz.isPanel(RuntimeHelpers.GetObjectValue(sender)))
		{
			return;
		}
		checked
		{
			int num = peremens.setka * 2;
			Pen val = new Pen(Color.Black, 1f);
			val.set_DashStyle((DashStyle)2);
			val.set_DashPattern(new float[2]
			{
				1f,
				num - 1
			});
			int num2 = Conversions.ToInteger(Operators.DivideObject(NewLateBinding.LateGet(this.obj, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), (object)num));
			for (int i = 0; i <= num2; i++)
			{
				Graphics graphics = e.get_Graphics();
				object[] array5 = new object[5]
				{
					val,
					1,
					i * num + 1,
					null,
					null
				};
				object[] array6 = array5;
				object obj3 = this.obj;
				array6[3] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type)null, "width", new object[0], (string[])null, (Type[])null, (bool[])null));
				array5[4] = i * num + 1;
				object[] array2 = array5;
				object[] array7 = array2;
				bool[] array4 = new bool[5] { true, false, false, true, false };
				NewLateBinding.LateCall((object)graphics, (Type)null, "DrawLine", array7, (string[])null, (Type[])null, array4, true);
				if (array4[0])
				{
					val = (Pen)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(Pen));
				}
				if (array4[3])
				{
					NewLateBinding.LateSetComplex(obj3, (Type)null, "width", new object[1] { RuntimeHelpers.GetObjectValue(array2[3]) }, (string[])null, (Type[])null, true, false);
				}
			}
		}
	}

	public void Scroll(object sender, ScrollEventArgs e)
	{
		NewLateBinding.LateCall(MyObj, (Type)null, "marker_vis", new object[1] { false }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "Timer1", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void SplitterMoved(object sender, SplitterEventArgs e)
	{
		NewLateBinding.LateCall(MyObj, (Type)null, "marker_vis", new object[1] { true }, (string[])null, (Type[])null, (bool[])null, true);
	}

	private void obj_SplitterMoved(object sender, SplitterEventArgs e)
	{
		Props.IzmenenieBylo();
	}

	private void obj_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
	}

	private void obj_SelectionChanged(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "semaforSelect", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
		{
			Props.IzmenenieByloExpert();
		}
	}

	private void obj_SelectedIndexChanged(object sender, EventArgs e)
	{
		Props.IzmenenieBylo();
	}

	public void RunSobyt(object sender, string sobyt, object e, Type type)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		if ((tree == null) | !peremens.isRUN())
		{
			return;
		}
		object obj = proj;
		object[] array = new object[2]
		{
			sobyt,
			RuntimeHelpers.GetObjectValue(GetNode("", withObj: true))
		};
		object[] array2 = array;
		bool[] array3 = new bool[2] { true, false };
		object obj2 = NewLateBinding.LateGet(obj, (Type)null, "FindSobyt", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			sobyt = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		TreeNode val = (TreeNode)obj2;
		if (val == null)
		{
			return;
		}
		try
		{
			object obj3 = proj;
			array = new object[4] { val, 0, null, null };
			object[] array4 = array;
			PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(sender), RuntimeHelpers.GetObjectValue(e), type);
			array4[2] = propertysSobyt;
			array[3] = true;
			object[] array5 = array;
			object[] array6 = array5;
			array3 = new bool[4] { true, false, false, false };
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "RunBlock", array6, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				val = (TreeNode)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(TreeNode));
				if (obj4 == null)
				{
					goto IL_0140;
				}
			}
			else if (obj4 == null)
			{
				goto IL_0140;
			}
			peremens.ErrString errString = (peremens.ErrString)obj4;
			goto IL_014f;
			IL_0140:
			peremens.ErrString errString2 = default(peremens.ErrString);
			errString = errString2;
			goto IL_014f;
			IL_014f:
			peremens.ErrString errString3 = errString;
			if ((Operators.CompareString(errString3.err, "", false) != 0) & (Operators.CompareString(errString3.err, "BreakEvent", false) != 0))
			{
				Errors.MessangeCritic(errString3.err);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!peremens.IgnorEr)
			{
				string text = default(string);
				if (peremens.isRUN() && NewLateBinding.LateGet(proj, (Type)null, "NowNode", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("\r\n" + peremens.trans("Действие"), ": \""), NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "NowNode", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"\""));
				}
				Errors.MessangeCritic(ex2.Message + "\r\n" + peremens.trans("Событие") + ": \"" + val.get_FullPath() + "\"" + text);
			}
			else if (NewLateBinding.LateGet(proj, (Type)null, "NowNode", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
			{
				object obj5 = proj;
				array = new object[4];
				object[] array7 = array;
				object obj6 = proj;
				array7[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj6, (Type)null, "NowNode", new object[0], (string[])null, (Type[])null, (bool[])null));
				array[1] = 0;
				object[] array8 = array;
				PropertysSobyt propertysSobyt = new PropertysSobyt(RuntimeHelpers.GetObjectValue(sender), RuntimeHelpers.GetObjectValue(e), type);
				array8[2] = propertysSobyt;
				array[3] = true;
				object[] array5 = array;
				object[] array9 = array5;
				array3 = new bool[4] { true, false, false, false };
				NewLateBinding.LateCall(obj5, (Type)null, "RunBlock", array9, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					NewLateBinding.LateSetComplex(obj6, (Type)null, "NowNode", new object[1] { RuntimeHelpers.GetObjectValue(array5[0]) }, (string[])null, (Type[])null, true, false);
				}
			}
			ProjectData.ClearProjectError();
		}
		NewLateBinding.LateSet(proj, (Type)null, "recurs", new object[1] { 0 }, (string[])null, (Type[])null);
	}

	public void obj_ClickRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Клик"), e, e.GetType());
	}

	public void obj_MouseDownRun(object sender, MouseEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Нажатие кнопки мыши"), e, ((object)e).GetType());
	}

	public void obj_MouseUpRun(object sender, MouseEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Отжатие кнопки мыши"), e, ((object)e).GetType());
	}

	public void obj_MouseMoveRun(object sender, MouseEventArgs e)
	{
		if (!Conversions.ToBoolean(NewLateBinding.LateGet(proj, (Type)null, "alreadyRun", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Движение курсора"), e, ((object)e).GetType());
		}
	}

	public void obj_MouseEnterRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Наведение курсора"), e, e.GetType());
	}

	public void obj_MouseLeaveRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Отведение курсора"), e, e.GetType());
	}

	public void obj_MouseHoverRun(object sender, EventArgs e)
	{
		if (!Conversions.ToBoolean(NewLateBinding.LateGet(proj, (Type)null, "alreadyRun", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Курсор на объекте"), e, e.GetType());
		}
	}

	public void obj_MouseWheelRun(object sender, MouseEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Вращение колесика"), e, ((object)e).GetType());
	}

	public void obj_DoubleClickRun(object sender, MouseEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Двойной клик"), e, ((object)e).GetType());
	}

	private void obj_KeyPressRun(object sender, KeyPressEventArgs e)
	{
		e.set_Handled(peremens.TextBoxAllow(RuntimeHelpers.GetObjectValue(sender), e));
		if (!e.get_Handled())
		{
			RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Нажатие клавиатуры"), e, ((object)e).GetType());
			if (NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[0], (string[])null, (Type[])null, (bool[])null) != null && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[1] { Strings.UCase(peremens.MyZnak + peremens.trans("Отменить ввод")) }, (string[])null, (Type[])null, (bool[])null), (object)peremens.trans("Да"), false))
			{
				e.set_Handled(true);
			}
		}
	}

	private void obj_KeyDownRun(object sender, KeyEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Нажатие вниз кнопки"), e, ((object)e).GetType());
	}

	private void obj_KeyUpRun(object sender, KeyEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Отжатие кнопки"), e, ((object)e).GetType());
	}

	private void obj_DropDownClosedRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Вложенное меню закрылось"), e, e.GetType());
	}

	private void obj_DropDownOpenedRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Вложенное меню открылось"), e, e.GetType());
	}

	private void obj_DropDownOpeningRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Вложенное меню открывается"), e, e.GetType());
	}

	private void obj_TextChangedRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Изменение текста"), e, e.GetType());
	}

	public void obj_GotFocusRun(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(proj, (Type)null, "isINITIALIZATED", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
		{
			RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Получение фокуса"), e, e.GetType());
		}
	}

	private void obj_LostFocusRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Потеря фокуса"), e, e.GetType());
	}

	public void obj_PaintRun(object sender, PaintEventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(proj, (Type)null, "isINITIALIZATED", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
		{
			RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Прорисовка"), e, ((object)e).GetType());
		}
	}

	public void obj_LoadRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Создание"), e, e.GetType());
	}

	public void obj_ScrollRun(object sender, ScrollEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Прокрутка"), e, ((object)e).GetType());
	}

	public void obj_ScrollRun1(object sender, ScrollEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Прокрутка1"), e, ((object)e).GetType());
	}

	public void obj_ScrollRun2(object sender, ScrollEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Прокрутка2"), e, ((object)e).GetType());
	}

	public void obj_ScrollRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Движение бегунка"), e, e.GetType());
	}

	public void obj_ResizeRun(object sender, EventArgs e)
	{
	}

	private void obj_FormClosingRun(object sender, FormClosingEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Закрытие окна"), new EventArgs(), new EventArgs().GetType());
		Type typeFromHandle = typeof(Strings);
		object[] array = new object[1];
		object[] array2 = array;
		object obj = this.obj;
		object obj2 = obj;
		object[] array3 = new object[0];
		object[] array4 = array3;
		string[] array5 = null;
		array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "Props", array4, array5, (Type[])null, (bool[])null), (Type)null, "ForbidClose", new object[0], (string[])null, (Type[])null, (bool[])null));
		object[] array6 = array;
		object[] array7 = array6;
		bool[] array8 = new bool[1] { true };
		object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array7, (string[])null, (Type[])null, array8);
		if (array8[0])
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Props", array3, array5, (Type[])null, (bool[])null), (Type)null, "ForbidClose", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, true);
		}
		if (Operators.ConditionalCompareObjectEqual(obj3, (object)Strings.UCase(peremens.trans("Да")), false))
		{
			((CancelEventArgs)(object)e).Cancel = true;
			return;
		}
		Type typeFromHandle2 = typeof(Strings);
		array6 = new object[1];
		object[] array9 = array6;
		obj = this.obj;
		object obj4 = obj;
		object[] array10 = new object[0];
		object[] array11 = array10;
		array5 = null;
		array9[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "Props", array11, array5, (Type[])null, (bool[])null), (Type)null, "mainForm", new object[0], (string[])null, (Type[])null, (bool[])null));
		array = array6;
		object[] array12 = array;
		array8 = new bool[1] { true };
		object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle2, "UCase", array12, (string[])null, (Type[])null, array8);
		if (array8[0])
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "Props", array10, array5, (Type[])null, (bool[])null), (Type)null, "mainForm", new object[1] { RuntimeHelpers.GetObjectValue(array[0]) }, (string[])null, (Type[])null, true, true);
		}
		if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(obj5, (object)Strings.UCase(peremens.trans("Да")), false), Operators.CompareObjectEqual(NewLateBinding.LateGet(proj, (Type)null, "isCLOSING", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))))
		{
			NewLateBinding.LateCall(this.obj, (Type)null, "hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			peremens.HookStops();
			if (Conversions.ToBoolean(NewLateBinding.LateGet(proj, (Type)null, "isPotok", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				NewLateBinding.LateSet(proj, (Type)null, "StopPr", new object[1] { true }, (string[])null, (Type[])null);
			}
			else
			{
				NewLateBinding.LateCall(proj, (Type)null, "StopProject", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		else if (Conversions.ToBoolean(NewLateBinding.LateGet(proj, (Type)null, "isONLYFORM", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			if (Conversions.ToBoolean(NewLateBinding.LateGet(proj, (Type)null, "isPotok", new object[0], (string[])null, (Type[])null, (bool[])null)))
			{
				NewLateBinding.LateSet(proj, (Type)null, "StopPr", new object[1] { true }, (string[])null, (Type[])null);
			}
			else
			{
				NewLateBinding.LateCall(proj, (Type)null, "StopProject", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		else
		{
			((CancelEventArgs)(object)e).Cancel = true;
			NewLateBinding.LateCall(this.obj, (Type)null, "hide", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void obj_SplitterMovedRun(object sender, SplitterEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Разделитель перемещен"), e, ((object)e).GetType());
	}

	private void obj_SplitterMovingRun(object sender, SplitterCancelEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Разделитель перемещается"), e, ((object)e).GetType());
		if (NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[0], (string[])null, (Type[])null, (bool[])null) != null && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[1] { Strings.UCase(peremens.MyZnak + peremens.trans("Отменить перемещение")) }, (string[])null, (Type[])null, (bool[])null), (object)peremens.trans("Да"), false))
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void obj_SizeChangedRun(object sender, EventArgs e)
	{
		if (!Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)) || NewLateBinding.LateGet(MyObj, (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
		{
			RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Изменились размеры"), e, e.GetType());
		}
	}

	private void obj_VisibleChangedRun(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(proj, (Type)null, "isINITIALIZATED", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
		{
			RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Изменилась видимость"), e, e.GetType());
		}
	}

	private void WebBrowser1_CanGoBackChanged(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Назад можно изменилось"), e, e.GetType());
	}

	private void WebBrowser1_CanGoForwardChanged(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Вперед можно изменилось"), e, e.GetType());
	}

	private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Страница загрузилась"), e, ((object)e).GetType());
	}

	private void WebBrowser1_FileDownload(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Страница загружается"), e, e.GetType());
	}

	private void WebBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Перешел по ссылке"), e, ((object)e).GetType());
	}

	private void WebBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Переходит по ссылке"), e, ((object)e).GetType());
	}

	private void WebBrowser1_NewWindow(object sender, CancelEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Открытие в новом окне"), e, e.GetType());
	}

	private void WebBrowser1_StatusTextChanged(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Статусная строка изменилась"), e, e.GetType());
	}

	private void TabControl_Deselected(object sender, TabControlEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Снялось выделение закладки"), e, ((object)e).GetType());
	}

	private void TabControl_Deselecting(object sender, TabControlCancelEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Снимается выделение закладки"), e, ((object)e).GetType());
		if (NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[0], (string[])null, (Type[])null, (bool[])null) != null && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[1] { Strings.UCase(peremens.MyZnak + peremens.trans("Отменить событие")) }, (string[])null, (Type[])null, (bool[])null), (object)peremens.trans("Да"), false))
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Выделили закладку"), e, e.GetType());
	}

	private void TabControl_Selecting(object sender, TabControlCancelEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Выделяют закладку"), e, ((object)e).GetType());
		if (NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[0], (string[])null, (Type[])null, (bool[])null) != null && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[1] { Strings.UCase(peremens.MyZnak + peremens.trans("Отменить событие")) }, (string[])null, (Type[])null, (bool[])null), (object)peremens.trans("Да"), false))
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void Table_SelectionChangedRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Изменилось выделение"), e, e.GetType());
	}

	private void Table_CellBeginEditRun(object sender, DataGridViewCellCancelEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Начало редактирования ячейки"), e, ((object)e).GetType());
		if (NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[0], (string[])null, (Type[])null, (bool[])null) != null && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[1] { Strings.UCase(peremens.MyZnak + peremens.trans("Отменить событие")) }, (string[])null, (Type[])null, (bool[])null), (object)peremens.trans("Да"), false))
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void Table_CellClickRun(object sender, DataGridViewCellEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Клик по ячейке"), e, ((object)e).GetType());
	}

	private void Table_CellMouseDownRun(object sender, DataGridViewCellMouseEventArgs e)
	{
		if (((e.get_RowIndex() > -1) & (e.get_ColumnIndex() > -1)) && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Rows", new object[1] { e.get_RowIndex() }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Cells", new object[1] { e.get_ColumnIndex() }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Selected", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
		{
			RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Клик по выделенной ячейке"), e, ((object)e).GetType());
		}
	}

	private void Table_CellDoubleClickRun(object sender, DataGridViewCellEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Двойной клик по ячейке"), e, ((object)e).GetType());
	}

	private void Table_CellEndEditRun(object sender, DataGridViewCellEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Конец редактирования ячеки"), e, ((object)e).GetType());
	}

	private void Table_CellEnterRun(object sender, DataGridViewCellEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Ячейка в фокусе"), e, ((object)e).GetType());
	}

	private void Table_CellLeaveRun(object sender, DataGridViewCellEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Ячека потеряла фокус"), e, ((object)e).GetType());
	}

	private void Table_ColumnDisplayIndexChangedRun(object sender, DataGridViewColumnEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Столбец переместили"), e, ((object)e).GetType());
	}

	private void Table_ColumnHeaderMouseClickRun(object sender, DataGridViewCellMouseEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Клик по заголовку столбца"), e, ((object)e).GetType());
	}

	private void Table_ColumnHeaderMouseDoubleClickRun(object sender, DataGridViewCellMouseEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Двойной клик по заголовку столбца"), e, ((object)e).GetType());
	}

	private void Table_ColumnSortModeChangedRun(object sender, DataGridViewColumnEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Сортировка столбца"), e, ((object)e).GetType());
	}

	private void Table_ColumnWidthChangedRun(object sender, DataGridViewColumnEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Изменилась ширина столбца"), e, ((object)e).GetType());
	}

	private void Table_RowHeaderMouseClickRun(object sender, DataGridViewCellMouseEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Клик по заголовку строки"), e, ((object)e).GetType());
	}

	private void Table_RowHeightChangedRun(object sender, DataGridViewRowEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Изменилась вышина строки"), e, ((object)e).GetType());
	}

	private void Table_RowsAddedRun(object sender, DataGridViewRowsAddedEventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "isSelecExecute", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
		{
			RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Добавли строку"), e, ((object)e).GetType());
		}
	}

	private void Table_RowsRemovedRun(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "isSelecExecute", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
		{
			RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Удалили строку"), e, ((object)e).GetType());
		}
	}

	private void obj_SelectedIndexChangedRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Изменение выбранной записи"), e, e.GetType());
	}

	private void obj_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Type typeFromHandle = typeof(peremens);
		object[] array = new object[1];
		object myObj = MyObj;
		object[] array2 = new object[0];
		string[] array3 = null;
		object obj = NewLateBinding.LateGet(myObj, (Type)null, "obj", array2, array3, (Type[])null, (bool[])null);
		object[] array4 = new object[0];
		string[] array5 = null;
		array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "props", array4, array5, (Type[])null, (bool[])null), (Type)null, "InternetLink", new object[0], (string[])null, (Type[])null, (bool[])null));
		object[] array6 = array;
		bool[] array7 = new bool[1] { true };
		object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array6, (string[])null, (Type[])null, array7);
		if (array7[0])
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", array2, array3, (Type[])null, (bool[])null), (Type)null, "props", array4, array5, (Type[])null, (bool[])null), (Type)null, "InternetLink", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, true);
		}
		if (Conversions.ToBoolean(obj2))
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GoInternetLink", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Клик по ссылке"), e, ((object)e).GetType());
	}

	private void obj_CloseUp(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Календарь закрылся"), e, e.GetType());
	}

	private void obj_DropDown(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Календарь раскрылся"), e, e.GetType());
	}

	private void obj_ValueChanged(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Значение изменилось"), e, e.GetType());
	}

	private void obj_OpeningRun(object sender, CancelEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Открытие"), e, e.GetType());
		if (NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[0], (string[])null, (Type[])null, (bool[])null) != null && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[1] { Strings.UCase(peremens.MyZnak + peremens.trans("Отменить событие")) }, (string[])null, (Type[])null, (bool[])null), (object)peremens.trans("Да"), false))
		{
			e.Cancel = true;
		}
	}

	private void obj_ClosedRun(object sender, ToolStripDropDownClosedEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Закрылось"), e, ((object)e).GetType());
	}

	private void obj_ClosingRun(object sender, ToolStripDropDownClosingEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Закрытие"), e, ((object)e).GetType());
		if (NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[0], (string[])null, (Type[])null, (bool[])null) != null && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[1] { Strings.UCase(peremens.MyZnak + peremens.trans("Отменить событие")) }, (string[])null, (Type[])null, (bool[])null), (object)peremens.trans("Да"), false))
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void obj_OpenedRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Открылось"), e, e.GetType());
	}

	private void obj_ConnectedToServerRun(object sender, WinsockConnectedEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Присоединились к серверу"), e, e.GetType());
	}

	private void obj_ConnectionClientRun(object sender, WinsockConnectionRequestEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Присоединился клиент"), e, e.GetType());
		if (NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[0], (string[])null, (Type[])null, (bool[])null) != null && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[1] { Strings.UCase(peremens.MyZnak + peremens.trans("Отменить событие")) }, (string[])null, (Type[])null, (bool[])null), (object)peremens.trans("Да"), false))
		{
			e.Cancel = true;
		}
	}

	private void obj_CountChangedRun(object sender, WinsockCollectionCountChangedEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Изменилось число клиентов"), e, e.GetType());
	}

	private void obj_TextReceivedRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Пришел текст"), null, GetType());
	}

	private void obj_CommandReceivedRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Пришла команда"), null, GetType());
	}

	private void obj_FileReceivedRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Пришел файл"), null, GetType());
	}

	private void obj_DisconnectedRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Отключение"), null, GetType());
	}

	private void obj_ErrorReceivedRun(object sender, WinsockErrorReceivedEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Произошла ошибка"), e, e.GetType());
	}

	private void obj_SendTextCompleteRun(object sender, WinsockSendEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Отправился текст"), e, e.GetType());
	}

	private void obj_SendFileCompleteRun(object sender, WinsockSendEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Отправился файл"), e, e.GetType());
	}

	private void obj_SendProgressRun(object sender, WinsockSendEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Идет отправление"), e, e.GetType());
	}

	private void obj_ReceiveProgressRun(object sender, WinsockReceiveProgressEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Идет прием данных"), e, e.GetType());
	}

	private void obj_StateChangedRun(object sender, WinsockStateChangedEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Изменился статус"), e, e.GetType());
	}

	private void obj_SendingQueryRun(object sender, CancelEventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Отправляется запрос"), e, e.GetType());
		if (NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[0], (string[])null, (Type[])null, (bool[])null) != null && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[1] { Strings.UCase(peremens.MyZnak + peremens.trans("Отменить событие")) }, (string[])null, (Type[])null, (bool[])null), (object)peremens.trans("Да"), false))
		{
			e.Cancel = true;
		}
	}

	private void obj_SentQueryRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Отправился запрос"), e, e.GetType());
	}

	private void obj_ReceivedResponseRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Пришел ответ"), e, e.GetType());
	}

	private void obj_DownloadCancelledRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Загрузка отменена"), e, e.GetType());
	}

	public void Minimize(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Сворачивание"), null, GetType());
	}

	public void DoubleClickTray(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Двойной клик по трею"), null, GetType());
	}

	private void obj_ChangingValueRun(object sender, string e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Изменение значения"), e, e.GetType());
	}

	private void obj_ChangedValueRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Изменилось значение"), e, e.GetType());
	}

	private void obj_OnEndRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Конец проигрывания"), null, GetType());
	}

	public void obj_CheckedChangedRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Изменение отметки"), e, e.GetType());
	}

	private void obj_HScroll(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Горизонтальная прокрутка"), e, e.GetType());
	}

	private void obj_VScroll(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Вертикальная прокрутка"), e, e.GetType());
	}

	private void obj_LinkClicked(object sender, LinkClickedEventArgs e)
	{
		Type typeFromHandle = typeof(peremens);
		object[] array = new object[1];
		object myObj = MyObj;
		object[] array2 = new object[0];
		string[] array3 = null;
		object obj = NewLateBinding.LateGet(myObj, (Type)null, "obj", array2, array3, (Type[])null, (bool[])null);
		object[] array4 = new object[0];
		string[] array5 = null;
		array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "props", array4, array5, (Type[])null, (bool[])null), (Type)null, "InternetLink", new object[0], (string[])null, (Type[])null, (bool[])null));
		object[] array6 = array;
		bool[] array7 = new bool[1] { true };
		object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array6, (string[])null, (Type[])null, array7);
		if (array7[0])
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", array2, array3, (Type[])null, (bool[])null), (Type)null, "props", array4, array5, (Type[])null, (bool[])null), (Type)null, "InternetLink", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, true);
		}
		if (Conversions.ToBoolean(obj2))
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GoInternetLink", new object[1] { e.get_LinkText() }, (string[])null, (Type[])null, (bool[])null, true);
		}
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Клик по ссылке документа"), e, ((object)e).GetType());
	}

	private void obj_Tick(object sender, EventArgs e)
	{
		if (!Conversions.ToBoolean(NewLateBinding.LateGet(proj, (Type)null, "alreadyRun", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			object obj = this.obj;
			object[] array = new object[0];
			string[] array2 = null;
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "props", array, array2, (Type[])null, (bool[])null), (Type)null, "IntervalCount", new object[1] { Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "props", array, array2, (Type[])null, (bool[])null), (Type)null, "IntervalCount", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, false, true);
			RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Тикнул"), e, e.GetType());
		}
	}

	public void obj_ClickButtonRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Клик кнопки"), e, e.GetType());
	}

	public void obj_ActivationSuccessulRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Активация успешная"), e, e.GetType());
	}

	public void obj_ActivationFailedRun(object sender, EventArgs e)
	{
		RunSobyt(RuntimeHelpers.GetObjectValue(MyObj), peremens.trans("Активация неудачная"), e, e.GetType());
	}

	private void obj_DisposedNado(object sender, EventArgs e)
	{
		if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)))
		{
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				object myObj = MyObj;
				object[] array = new object[1] { i };
				bool[] array2 = new bool[1] { true };
				object obj = NewLateBinding.LateGet(myObj, (Type)null, "MyObjs", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				if (Iz.isPoluObj(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
				{
					object myObj2 = MyObj;
					object[] array3 = new object[1] { i };
					bool[] array4 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(myObj2, (Type)null, "MyObjs", array3, (string[])null, (Type[])null, array4);
					if (array4[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
					}
					NewLateBinding.LateCall(NewLateBinding.LateGet(obj2, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Dispose", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
		}
		if (Iz.IsMd(RuntimeHelpers.GetObjectValue(MyObj)) | Iz.IsA(RuntimeHelpers.GetObjectValue(MyObj)))
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(this.obj, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "CloseMovie", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void obj_ResizeNado(object sender, EventArgs e)
	{
		if (Iz.IsMd(RuntimeHelpers.GetObjectValue(MyObj)))
		{
			NewLateBinding.LateCall(NewLateBinding.LateGet(obj, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "fit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private void WebBrowser_NewWindowNado(object sender, CancelEventArgs e)
	{
		if (NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[0], (string[])null, (Type[])null, (bool[])null) != null && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[1] { Strings.UCase(peremens.MyZnak + peremens.trans("Отменить в новом окне")) }, (string[])null, (Type[])null, (bool[])null), (object)peremens.trans("Да"), false))
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(proj, (Type)null, "Param", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ParamyUp", new object[2]
			{
				Strings.UCase(peremens.MyZnak + peremens.trans("Отменить в новом окне")),
				""
			}, (string[])null, (Type[])null, false, true);
			e.Cancel = true;
		}
		else
		{
			if (!Conversions.ToBoolean(Operators.AndObject((object)(!e.Cancel), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(this.obj, (Type)null, "lastLink", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))))
			{
				return;
			}
			Type typeFromHandle = typeof(Strings);
			object[] array = new object[1];
			object[] array2 = array;
			object obj = this.obj;
			object[] array3 = new object[0];
			object[] array4 = array3;
			string[] array5 = null;
			array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "props", array4, array5, (Type[])null, (bool[])null), (Type)null, "OpenNewWindowLink", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array6 = array;
			bool[] array7 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array6, (string[])null, (Type[])null, array7);
			if (array7[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "props", array3, array5, (Type[])null, (bool[])null), (Type)null, "OpenNewWindowLink", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, true);
			}
			object[] array10;
			object obj4;
			object[] array8;
			bool[] array12;
			if (Operators.ConditionalCompareObjectEqual(obj2, (object)Strings.UCase(peremens.trans("В данном браузере")), false))
			{
				object obj3 = this.obj;
				array8 = new object[1];
				object[] array9 = array8;
				obj4 = this.obj;
				array9[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "lastlink", new object[0], (string[])null, (Type[])null, (bool[])null));
				array10 = array8;
				object[] array11 = array10;
				array12 = new bool[1] { true };
				NewLateBinding.LateCall(obj3, (Type)null, "Navigate", array11, (string[])null, (Type[])null, array12, true);
				if (array12[0])
				{
					NewLateBinding.LateSetComplex(obj4, (Type)null, "lastlink", new object[1] { RuntimeHelpers.GetObjectValue(array10[0]) }, (string[])null, (Type[])null, true, false);
				}
				e.Cancel = true;
				return;
			}
			Type typeFromHandle2 = typeof(Strings);
			array10 = new object[1];
			object[] array13 = array10;
			obj4 = this.obj;
			object obj5 = obj4;
			object[] array14 = new object[0];
			object[] array15 = array14;
			array5 = null;
			array13[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "props", array15, array5, (Type[])null, (bool[])null), (Type)null, "OpenNewWindowLink", new object[0], (string[])null, (Type[])null, (bool[])null));
			array8 = array10;
			object[] array16 = array8;
			array12 = new bool[1] { true };
			object obj6 = NewLateBinding.LateGet((object)null, typeFromHandle2, "UCase", array16, (string[])null, (Type[])null, array12);
			if (array12[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj4, (Type)null, "props", array14, array5, (Type[])null, (bool[])null), (Type)null, "OpenNewWindowLink", new object[1] { RuntimeHelpers.GetObjectValue(array8[0]) }, (string[])null, (Type[])null, true, true);
			}
			if (!Operators.ConditionalCompareObjectEqual(obj6, (object)Strings.UCase(peremens.trans("По умолчанию")), false))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(peremens.RunProj.GetObjFromUniqName(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OpenNewWindowLink", new object[0], (string[])null, (Type[])null, (bool[])null))));
				if (objectValue == null)
				{
					Errors.MessangeExclamen(Errors.InvalidWebBrowser(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "OpenNewWindowLink", new object[0], (string[])null, (Type[])null, (bool[])null))));
					return;
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Url", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.obj, (Type)null, "lastLink", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
				e.Cancel = true;
			}
		}
	}

	private void WebBrowser_StatusTextChangedNado(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(obj, (Type)null, "StatusText", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false) && Uri.IsWellFormedUriString(Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "StatusText", new object[0], (string[])null, (Type[])null, (bool[])null)), UriKind.RelativeOrAbsolute))
		{
			NewLateBinding.LateSet(obj, (Type)null, "lastLink", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "StatusText", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
		}
	}

	public void AddNode(string name = "", int index = -1)
	{
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		if (Operators.CompareString(name, "", false) == 0)
		{
			name = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		object myObj2;
		object myObj;
		object[] array7;
		bool[] array3;
		if (!Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)))
		{
			if (GetMyForm() == null || GetMyForm().GetNode() == null)
			{
				return;
			}
			object node = GetMyForm().GetNode();
			object[] array = new object[1] { name };
			object[] array2 = array;
			array3 = new bool[1] { true };
			object obj = NewLateBinding.LateGet(node, (Type)null, "Nodes", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				name = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			if (obj != null)
			{
				return;
			}
			if (Conversions.ToBoolean(Operators.OrObject((object)(index < 0), Operators.CompareObjectGreater((object)index, NewLateBinding.LateGet(NewLateBinding.LateGet(GetMyForm().GetNode(), (Type)null, "Nodes", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), false))))
			{
				index = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(GetMyForm().GetNode(), (Type)null, "Nodes", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			if (NodeTemp != null)
			{
				object obj2 = NewLateBinding.LateGet(GetMyForm().GetNode(), (Type)null, "Nodes", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array4 = new object[2] { index, NodeTemp };
				object[] array5 = array4;
				array3 = new bool[2] { true, true };
				NewLateBinding.LateCall(obj2, (Type)null, "Insert", array5, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					index = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
				}
				if (array3[1])
				{
					NodeTemp = (TreeNode)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(TreeNode));
				}
				object node2 = GetMyForm().GetNode();
				array4 = new object[1] { index };
				object[] array6 = array4;
				array3 = new bool[1] { true };
				object obj3 = NewLateBinding.LateGet(node2, (Type)null, "Nodes", array6, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					index = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
				}
				NewLateBinding.LateSetComplex(obj3, (Type)null, "Tag", new object[1] { "Obj" }, (string[])null, (Type[])null, false, true);
				NodeTemp = null;
			}
			else
			{
				object obj4 = NewLateBinding.LateGet(GetMyForm().GetNode(), (Type)null, "Nodes", new object[0], (string[])null, (Type[])null, (bool[])null);
				array7 = new object[5] { index, name, name, null, null };
				object[] array8 = array7;
				myObj = MyObj;
				array8[3] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(myObj, (Type)null, "picture", new object[0], (string[])null, (Type[])null, (bool[])null));
				object[] array9 = array7;
				myObj2 = MyObj;
				array9[4] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(myObj2, (Type)null, "picture", new object[0], (string[])null, (Type[])null, (bool[])null));
				array = array7;
				object[] array10 = array;
				array3 = new bool[5] { true, true, true, true, true };
				NewLateBinding.LateCall(obj4, (Type)null, "Insert", array10, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					index = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				if (array3[1])
				{
					name = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
				}
				if (array3[2])
				{
					name = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(string));
				}
				if (array3[3])
				{
					NewLateBinding.LateSetComplex(myObj, (Type)null, "picture", new object[1] { RuntimeHelpers.GetObjectValue(array[3]) }, (string[])null, (Type[])null, true, false);
				}
				if (array3[4])
				{
					NewLateBinding.LateSetComplex(myObj2, (Type)null, "picture", new object[1] { RuntimeHelpers.GetObjectValue(array[4]) }, (string[])null, (Type[])null, true, false);
				}
				object node3 = GetMyForm().GetNode();
				array7 = new object[1] { index };
				object[] array11 = array7;
				array3 = new bool[1] { true };
				object obj5 = NewLateBinding.LateGet(node3, (Type)null, "Nodes", array11, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					index = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(int));
				}
				NewLateBinding.LateSetComplex(obj5, (Type)null, "Tag", new object[1] { "Obj" }, (string[])null, (Type[])null, false, true);
			}
			NewLateBinding.LateCall(GetMyForm().GetNode(), (Type)null, "Expand", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			return;
		}
		if ((index < 0) | (index > tree.get_Nodes().get_Count()))
		{
			index = tree.get_Nodes().get_Count();
		}
		if (tree.get_Nodes().get_Item(name) != null)
		{
			return;
		}
		TreeNodeCollection nodes = tree.get_Nodes();
		object[] array12 = new object[5] { index, name, name, null, null };
		object[] array13 = array12;
		myObj2 = MyObj;
		array13[3] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(myObj2, (Type)null, "picture", new object[0], (string[])null, (Type[])null, (bool[])null));
		object[] array14 = array12;
		myObj = MyObj;
		array14[4] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(myObj, (Type)null, "picture", new object[0], (string[])null, (Type[])null, (bool[])null));
		array7 = array12;
		object[] array15 = array7;
		array3 = new bool[5] { true, true, true, true, true };
		NewLateBinding.LateCall((object)nodes, (Type)null, "Insert", array15, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			index = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(int));
		}
		if (array3[1])
		{
			name = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[1]), typeof(string));
		}
		if (array3[2])
		{
			name = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[2]), typeof(string));
		}
		if (array3[3])
		{
			NewLateBinding.LateSetComplex(myObj2, (Type)null, "picture", new object[1] { RuntimeHelpers.GetObjectValue(array7[3]) }, (string[])null, (Type[])null, true, false);
		}
		if (array3[4])
		{
			NewLateBinding.LateSetComplex(myObj, (Type)null, "picture", new object[1] { RuntimeHelpers.GetObjectValue(array7[4]) }, (string[])null, (Type[])null, true, false);
		}
		tree.get_Nodes().get_Item(index).set_Tag((object)"Obj");
		if (NodeTemp != null)
		{
			if (NodeTemp.get_TreeView() != null)
			{
				NodeTemp.Remove();
			}
			tree.get_Nodes().get_Item(name).get_Nodes()
				.Add(NodeTemp);
			tree.get_Nodes().get_Item(index).get_Nodes()
				.get_Item(0)
				.set_Tag((object)"Obj");
			NodeTemp = null;
			return;
		}
		TreeNodeCollection nodes2 = tree.get_Nodes().get_Item(name).get_Nodes();
		array12 = new object[4] { name, name, null, null };
		object[] array16 = array12;
		myObj2 = MyObj;
		array16[2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(myObj2, (Type)null, "picture", new object[0], (string[])null, (Type[])null, (bool[])null));
		object[] array17 = array12;
		myObj = MyObj;
		array17[3] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(myObj, (Type)null, "picture", new object[0], (string[])null, (Type[])null, (bool[])null));
		array7 = array12;
		object[] array18 = array7;
		array3 = new bool[4] { true, true, true, true };
		NewLateBinding.LateCall((object)nodes2, (Type)null, "Add", array18, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			name = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(string));
		}
		if (array3[1])
		{
			name = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[1]), typeof(string));
		}
		if (array3[2])
		{
			NewLateBinding.LateSetComplex(myObj2, (Type)null, "picture", new object[1] { RuntimeHelpers.GetObjectValue(array7[2]) }, (string[])null, (Type[])null, true, false);
		}
		if (array3[3])
		{
			NewLateBinding.LateSetComplex(myObj, (Type)null, "picture", new object[1] { RuntimeHelpers.GetObjectValue(array7[3]) }, (string[])null, (Type[])null, true, false);
		}
		tree.get_Nodes().get_Item(name).get_Nodes()
			.get_Item(0)
			.set_Tag((object)"Obj");
	}

	public void RemoveNode(string name = "", bool isObj = false)
	{
		if (Operators.CompareString(name, "", false) == 0)
		{
			name = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		if (!Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)) || isObj)
		{
			object obj = NewLateBinding.LateGet(GetMyForm().GetNode(), (Type)null, "Nodes", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[1] { name };
			bool[] array2 = new bool[1] { true };
			NewLateBinding.LateCall(obj, (Type)null, "RemoveByKey", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				name = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
		}
		else
		{
			tree.get_Nodes().get_Item(name).get_Nodes()
				.RemoveByKey(name);
		}
	}

	public bool ExistNode(string name = "", string oldName = "")
	{
		if (Operators.CompareString(name, "", false) == 0)
		{
			name = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		try
		{
			if (!Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)) | (Operators.CompareString(oldName, "", false) != 0))
			{
				if (!Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					oldName = "";
				}
				if (Operators.CompareString(oldName, "", false) == 0)
				{
					object node = GetMyForm().GetNode();
					object[] array = new object[1] { name };
					bool[] array2 = new bool[1] { true };
					object obj = NewLateBinding.LateGet(node, (Type)null, "Nodes", array, (string[])null, (Type[])null, array2);
					if (array2[0])
					{
						name = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					if (obj == null)
					{
						return false;
					}
				}
				else if (tree.get_Nodes().get_Item(oldName).get_Nodes()
					.get_Item(name) == null)
				{
					return false;
				}
			}
			else if (tree.get_Nodes().get_Item(name) == null)
			{
				return false;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}

	public object GetNode(string name = "", bool withObj = false)
	{
		if (Operators.CompareString(name, "", false) == 0)
		{
			name = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		if (Operators.CompareString(name, "", false) == 0)
		{
			return null;
		}
		if (!Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)))
		{
			object myForm = GetMyForm();
			if (myForm == null)
			{
				return null;
			}
			if (NewLateBinding.LateGet(myForm, (Type)null, "GetNode", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
			{
				return null;
			}
			object obj = NewLateBinding.LateGet(myForm, (Type)null, "GetNode", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[1] { name };
			bool[] array2 = new bool[1] { true };
			object result = NewLateBinding.LateGet(obj, (Type)null, "Nodes", array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				name = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			return result;
		}
		if (!withObj)
		{
			return tree.get_Nodes().get_Item(name);
		}
		if (tree.get_Nodes().get_Item(name) != null)
		{
			return tree.get_Nodes().get_Item(name).get_Nodes()
				.get_Item(name);
		}
		return null;
	}

	public Forms GetMyForm(bool withNothing = false)
	{
		if (MyForm != null && isRun)
		{
			return (Forms)MyForm;
		}
		if (Iz.isPoleznie(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			MyForm = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(peremens2.proj, (Type)null, "f", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null));
			return (Forms)MyForm;
		}
		object objectValue = RuntimeHelpers.GetObjectValue(MyObj);
		if (Iz.IsCM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			MyForm = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null));
			return (Forms)MyForm;
		}
		checked
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(this.obj, (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"PoluObj", false))
			{
				if (NewLateBinding.LateGet(MyObj, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null) != null && Iz.IsFORM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyObj, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null))))
				{
					MyForm = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyObj, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null));
					return (Forms)MyForm;
				}
				if (NewLateBinding.LateGet(proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
				{
					return null;
				}
				int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				int num2 = 0;
				object[] array4;
				bool[] array6;
				while (true)
				{
					if (num2 <= num)
					{
						if (NewLateBinding.LateGet(MyObj, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
						{
							object obj = NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "parent", new object[0], (string[])null, (Type[])null, (bool[])null);
							object obj2 = proj;
							object[] array = new object[1] { num2 };
							object[] array2 = array;
							bool[] array3 = new bool[1] { true };
							object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "f", array2, (string[])null, (Type[])null, array3);
							if (array3[0])
							{
								num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
							}
							if (obj == NewLateBinding.LateGet(obj3, (Type)null, "splitcont", new object[0], (string[])null, (Type[])null, (bool[])null))
							{
								break;
							}
						}
						object obj4 = proj;
						array4 = new object[1] { num2 };
						object[] array5 = array4;
						array6 = new bool[1] { true };
						object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "f", array5, (string[])null, (Type[])null, array6);
						if (array6[0])
						{
							num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
						}
						int num3 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
						for (int i = 0; i <= num3; i++)
						{
							object myObj = MyObj;
							object obj6 = proj;
							object[] array = new object[1] { num2 };
							object[] array7 = array;
							bool[] array3 = new bool[1] { true };
							object obj7 = NewLateBinding.LateGet(obj6, (Type)null, "f", array7, (string[])null, (Type[])null, array3);
							if (array3[0])
							{
								num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
							}
							object[] array8 = new object[1] { i };
							object[] array9 = array8;
							bool[] array10 = new bool[1] { true };
							object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "MyObjs", array9, (string[])null, (Type[])null, array10);
							if (array10[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
							}
							if (myObj != obj8)
							{
								continue;
							}
							object obj9 = proj;
							object[] array11 = new object[1] { num2 };
							object[] array12 = array11;
							bool[] array13 = new bool[1] { true };
							object obj10 = NewLateBinding.LateGet(obj9, (Type)null, "f", array12, (string[])null, (Type[])null, array13);
							if (array13[0])
							{
								num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(int));
							}
							if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj10, (Type)null, "MyObjs", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null))))
							{
								object obj11 = proj;
								object[] array14 = new object[1] { num2 };
								object[] array15 = array14;
								bool[] array16 = new bool[1] { true };
								object obj12 = NewLateBinding.LateGet(obj11, (Type)null, "f", array15, (string[])null, (Type[])null, array16);
								if (array16[0])
								{
									num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array14[0]), typeof(int));
								}
								MyForm = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj12, (Type)null, "MyObjs", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null));
								return (Forms)MyForm;
							}
						}
						num2++;
						continue;
					}
					if (NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
					{
						return null;
					}
					MyForm = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(proj, (Type)null, "f", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null));
					return (Forms)MyForm;
				}
				object obj13 = proj;
				array4 = new object[1] { num2 };
				object[] array17 = array4;
				array6 = new bool[1] { true };
				object obj14 = NewLateBinding.LateGet(obj13, (Type)null, "f", array17, (string[])null, (Type[])null, array6);
				if (array6[0])
				{
					num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
				}
				MyForm = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj14, (Type)null, "MyObjs", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null));
				return (Forms)MyForm;
			}
			int num4 = default(int);
			do
			{
				if (NewLateBinding.LateGet(objectValue, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
				{
					objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null));
					if (!Iz.IsCM(RuntimeHelpers.GetObjectValue(objectValue)))
					{
						num4++;
						continue;
					}
					MyForm = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null));
					return (Forms)MyForm;
				}
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "TypeObj", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"IncludeObj", false), (object)(!withNothing))))
				{
					MyForm = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null));
					return (Forms)MyForm;
				}
				if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(MyObj)))
				{
					MyForm = RuntimeHelpers.GetObjectValue(objectValue);
					return (Forms)MyForm;
				}
				if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(objectValue)))
				{
					MyForm = RuntimeHelpers.GetObjectValue(objectValue);
					return (Forms)MyForm;
				}
				if (NewLateBinding.LateGet(this.obj, (Type)null, "parent", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
				{
					if (NewLateBinding.LateGet(proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
					{
						return null;
					}
					int num5 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
					for (int num2 = 0; num2 <= num5; num2++)
					{
						object obj15 = proj;
						object[] array14 = new object[1] { num2 };
						object[] array18 = array14;
						bool[] array16 = new bool[1] { true };
						object obj16 = NewLateBinding.LateGet(obj15, (Type)null, "f", array18, (string[])null, (Type[])null, array16);
						if (array16[0])
						{
							num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array14[0]), typeof(int));
						}
						int num6 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj16, (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
						for (int i = 0; i <= num6; i++)
						{
							object myObj2 = MyObj;
							object obj17 = proj;
							object[] array19 = new object[1] { num2 };
							object[] array20 = array19;
							bool[] array13 = new bool[1] { true };
							object obj18 = NewLateBinding.LateGet(obj17, (Type)null, "f", array20, (string[])null, (Type[])null, array13);
							if (array13[0])
							{
								num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array19[0]), typeof(int));
							}
							object[] array21 = new object[1] { i };
							object[] array22 = array21;
							bool[] array10 = new bool[1] { true };
							object obj19 = NewLateBinding.LateGet(obj18, (Type)null, "MyObjs", array22, (string[])null, (Type[])null, array10);
							if (array10[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array21[0]), typeof(int));
							}
							if (myObj2 == obj19)
							{
								object obj20 = proj;
								object[] array23 = new object[1] { num2 };
								object[] array24 = array23;
								bool[] array6 = new bool[1] { true };
								object obj21 = NewLateBinding.LateGet(obj20, (Type)null, "f", array24, (string[])null, (Type[])null, array6);
								if (array6[0])
								{
									num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array23[0]), typeof(int));
								}
								MyForm = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj21, (Type)null, "MyObjs", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null));
								return (Forms)MyForm;
							}
						}
					}
					if (withNothing)
					{
						return null;
					}
					MyForm = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null));
					return (Forms)MyForm;
				}
				if (Operators.CompareString(objectValue.GetType().ToString(), peremens.ClassAplication + "Forms", false) == 0)
				{
					MyForm = RuntimeHelpers.GetObjectValue(objectValue);
					return (Forms)MyForm;
				}
				return null;
			}
			while (num4 <= 200);
			throw new Exception(Conversions.ToString(Operators.AddObject((object)"Ошибка объекта ", NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "NodeTemp", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))));
		}
	}

	public void NodeRefresh(string oldName = null)
	{
		string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (Operators.CompareString(oldName, (string)null, false) == 0)
		{
			oldName = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(this.obj, (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		if (!ExistNode(oldName) || !(!ExistNode(text, oldName) | (Operators.CompareString(text, oldName, false) != 0)))
		{
			return;
		}
		bool[] array3;
		object obj2;
		try
		{
			object myObj = MyObj;
			object[] array = new object[1] { RuntimeHelpers.GetObjectValue(MyObj) };
			object[] array2 = array;
			array3 = new bool[1] { true };
			object obj = NewLateBinding.LateGet(myObj, (Type)null, "GetNode", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				MyObj = RuntimeHelpers.GetObjectValue(array[0]);
			}
			obj2 = RuntimeHelpers.GetObjectValue(obj);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			obj2 = null;
			ProjectData.ClearProjectError();
		}
		object obj3 = proj;
		object[] array4 = new object[3]
		{
			RuntimeHelpers.GetObjectValue(obj2),
			null,
			null
		};
		object myObj2 = MyObj;
		object[] array5 = new object[1] { oldName };
		object[] array6 = array5;
		array3 = new bool[1] { true };
		object obj4 = NewLateBinding.LateGet(myObj2, (Type)null, "GetNode", array6, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			oldName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
		}
		array4[1] = RuntimeHelpers.GetObjectValue(obj4);
		array4[2] = RuntimeHelpers.GetObjectValue(MyObj);
		object[] array7 = array4;
		bool[] array8 = new bool[3] { true, true, true };
		NewLateBinding.LateCall(obj3, (Type)null, "PerebrosatTreeNodes", array7, (string[])null, (Type[])null, array8, true);
		if (array8[0])
		{
			obj2 = RuntimeHelpers.GetObjectValue(array7[0]);
		}
		if (array8[1])
		{
			NewLateBinding.LateSetComplex(myObj2, (Type)null, "GetNode", new object[2]
			{
				oldName,
				RuntimeHelpers.GetObjectValue(array7[1])
			}, (string[])null, (Type[])null, true, false);
		}
		if (array8[2])
		{
			MyObj = RuntimeHelpers.GetObjectValue(array7[2]);
		}
	}

	public Objetus()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		markers_perenos = -1;
		markers = (PictureBox[])(object)new PictureBox[checked(peremens.MarkCount - 1 + 1)];
		proj = RuntimeHelpers.GetObjectValue(proj);
		tm = default(DateTime);
		if (peremens.isHelp)
		{
			return;
		}
		try
		{
			if (!peremens.isDevelop)
			{
				tree = peremens.RunProj.tree;
			}
			else
			{
				tree = (TreeView)NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "TreeView", new object[0], (string[])null, (Type[])null, (bool[])null);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			try
			{
				tree = (TreeView)NewLateBinding.LateGet(peremens2.MnFrm, (Type)null, "TreeView", new object[0], (string[])null, (Type[])null, (bool[])null);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}
}
