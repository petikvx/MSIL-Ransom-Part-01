using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FC2ServerLauncher;

public class FormMapCycle : Form
{
	private List<CMap> m_mapList;

	private ListViewColumnSorter lvwColumnSorter;

	private List<string> m_maps;

	private IContainer components;

	private Button buttonOk;

	private Button buttonCancel;

	private Button buttonAdd;

	private Button buttonRemove;

	private Label labelTip;

	private TableLayoutPanel tableLayoutPanel1;

	private Panel panel1;

	private GroupBox groupBoxMaps;

	private Label labelSize;

	private Label label12;

	private Label labelAuthor;

	private Label label10;

	private Label labelMode;

	private Label label8;

	private Label labelCreator;

	private Label label6;

	private Label labelDate;

	private Label label4;

	private Label labelName;

	private Label label1;

	private PictureBox pictureBoxMap;

	private ListView listViewMaps;

	private GroupBox groupBoxSelectedMaps;

	private Label labelSize1;

	private ListView listViewSelectedMaps;

	private Label label3;

	private PictureBox pictureBoxMap1;

	private Label labelAuthor1;

	private Label label18;

	private Label label7;

	private Label labelName1;

	private Label labelMode1;

	private Label label16;

	private Label label11;

	private Label labelDate1;

	private Label labelCreator1;

	private Label label14;

	public bool MultiSelect
	{
		get
		{
			return listViewMaps.get_MultiSelect();
		}
		set
		{
			listViewMaps.set_MultiSelect(value);
		}
	}

	public List<string> Maps
	{
		get
		{
			return m_maps;
		}
		set
		{
			m_maps = value;
		}
	}

	public FormMapCycle()
	{
		InitializeComponent();
	}

	private void FormMapCycle_Load(object sender, EventArgs e)
	{
		SetupListViewMaps();
		LoadMapList();
		FillListViewMaps();
		SelectMaps();
	}

	private void FormMapCycle_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	private void buttonOk_Click(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (listViewSelectedMaps.get_Items().get_Count() == 0)
		{
			MessageBox.Show("Please choose at least one map.", "Far Cry® 2 Server Launcher", (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		GetSelectedMaps();
		((Form)this).set_DialogResult((DialogResult)1);
		((Component)this).Dispose();
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		((Form)this).set_DialogResult((DialogResult)2);
		((Component)this).Dispose();
	}

	private string GetMapNameFromMapFullName(string mapFullName)
	{
		if (mapFullName.Length > CUtils.GetMapExtension().Length + 1 && mapFullName.Substring(mapFullName.Length - CUtils.GetMapExtension().Length, CUtils.GetMapExtension().Length) == CUtils.GetMapExtension())
		{
			return mapFullName.Substring(0, mapFullName.Length - CUtils.GetMapExtension().Length - 1);
		}
		return mapFullName;
	}

	private void SelectMaps()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		if (m_maps == null)
		{
			return;
		}
		foreach (string map in m_maps)
		{
			string mapNameFromMapFullName = GetMapNameFromMapFullName(map);
			foreach (ListViewItem item in listViewMaps.get_Items())
			{
				ListViewItem val = item;
				if (val.get_SubItems().get_Count() > 0)
				{
					CMap cMap = val.get_Tag() as CMap;
					if (cMap.Localize == mapNameFromMapFullName || cMap.Name == mapNameFromMapFullName)
					{
						string text = cMap.DateAdded.ToString().Substring(0, 10);
						ListViewItem val2 = new ListViewItem(new string[7]
						{
							cMap.Localize,
							cMap.MapType.ToString(),
							cMap.Creator,
							cMap.Author,
							text,
							cMap.GameMode,
							cMap.Size
						});
						val2.set_Tag((object)cMap);
						listViewSelectedMaps.get_Items().Add(val2);
					}
				}
			}
		}
	}

	private void GetSelectedMaps()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		m_maps.Clear();
		foreach (ListViewItem item2 in listViewSelectedMaps.get_Items())
		{
			ListViewItem val = item2;
			if (val.get_SubItems().get_Count() > 0)
			{
				CMap cMap = val.get_Tag() as CMap;
				string item = cMap.Localize;
				if (cMap.MapType == EMapType.Custom)
				{
					item = cMap.Name;
				}
				m_maps.Add(item);
			}
		}
	}

	private void listViewMaps_ItemChecked(object sender, ItemCheckedEventArgs e)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		if (listViewMaps.get_MultiSelect() || !e.get_Item().get_Checked())
		{
			return;
		}
		foreach (ListViewItem item in listViewMaps.get_Items())
		{
			ListViewItem val = item;
			if (val != e.get_Item())
			{
				val.set_Checked(false);
			}
		}
	}

	private int GetCheckedCount()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		int num = 0;
		foreach (ListViewItem item in listViewMaps.get_Items())
		{
			ListViewItem val = item;
			if (val.get_Selected())
			{
				num++;
			}
		}
		return num;
	}

	private void LoadMapList()
	{
		m_mapList = new List<CMap>();
		LoadOriginalMapList();
		LoadCustomMapList();
	}

	private void LoadOriginalMapList()
	{
		foreach (CMap value in MainForm.Maps.Values)
		{
			AddToMapList(value);
		}
	}

	private void LoadCustomMapList()
	{
		if (MainForm.Instance.IsRankedSettingsSafe())
		{
			return;
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(CUtils.GetFarCry2PersonalUserMapsFolder());
		if (directoryInfo != null && directoryInfo.Exists)
		{
			string searchPattern = "*." + CUtils.GetMapExtension();
			FileInfo[] files = directoryInfo.GetFiles(searchPattern, SearchOption.AllDirectories);
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				CMap cMap = new CMap();
				cMap.LoadHeader(fileInfo.FullName);
				AddToMapList(cMap);
			}
		}
	}

	private void AddToMapList(CMap map)
	{
		if (MainForm.Instance.FilterMapByGameMode(map))
		{
			m_mapList.Add(map);
		}
	}

	private void SetupListViewMaps()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		lvwColumnSorter = new ListViewColumnSorter();
		listViewMaps.set_ListViewItemSorter((IComparer)lvwColumnSorter);
		ColumnHeader val = new ColumnHeader();
		val.set_Text("Name");
		val.set_Width((int)((double)((Control)listViewMaps).get_Width() * 0.4));
		ColumnHeader val2 = new ColumnHeader();
		val2.set_Text("Type");
		val2.set_Width((int)((double)((Control)listViewMaps).get_Width() * 0.2));
		ColumnHeader val3 = new ColumnHeader();
		val3.set_Text("Creator");
		val3.set_Width((int)((double)((Control)listViewMaps).get_Width() * 0.2));
		ColumnHeader val4 = new ColumnHeader();
		val4.set_Text("Author");
		val4.set_Width((int)((double)((Control)listViewMaps).get_Width() * 0.2));
		ColumnHeader val5 = new ColumnHeader();
		val5.set_Text("Date");
		val5.set_Width((int)((double)((Control)listViewMaps).get_Width() * 0.2));
		ColumnHeader val6 = new ColumnHeader();
		val6.set_Text("Mode");
		val6.set_Width((int)((double)((Control)listViewMaps).get_Width() * 0.2));
		ColumnHeader val7 = new ColumnHeader();
		val7.set_Text("Size");
		val7.set_Width((int)((double)((Control)listViewMaps).get_Width() * 0.2));
		listViewMaps.get_Columns().Add(val);
		listViewMaps.get_Columns().Add(val2);
		listViewMaps.get_Columns().Add(val3);
		listViewMaps.get_Columns().Add(val4);
		listViewMaps.get_Columns().Add(val5);
		listViewMaps.get_Columns().Add(val6);
		listViewMaps.get_Columns().Add(val7);
		lvwColumnSorter = new ListViewColumnSorter();
		listViewSelectedMaps.set_ListViewItemSorter((IComparer)lvwColumnSorter);
		ColumnHeader val8 = new ColumnHeader();
		val8.set_Text("Name");
		val8.set_Width((int)((double)((Control)listViewSelectedMaps).get_Width() * 0.4));
		ColumnHeader val9 = new ColumnHeader();
		val9.set_Text("Type");
		val9.set_Width((int)((double)((Control)listViewSelectedMaps).get_Width() * 0.2));
		ColumnHeader val10 = new ColumnHeader();
		val10.set_Text("Creator");
		val10.set_Width((int)((double)((Control)listViewSelectedMaps).get_Width() * 0.2));
		ColumnHeader val11 = new ColumnHeader();
		val11.set_Text("Author");
		val11.set_Width((int)((double)((Control)listViewSelectedMaps).get_Width() * 0.2));
		ColumnHeader val12 = new ColumnHeader();
		val12.set_Text("Date");
		val12.set_Width((int)((double)((Control)listViewSelectedMaps).get_Width() * 0.2));
		ColumnHeader val13 = new ColumnHeader();
		val13.set_Text("Mode");
		val13.set_Width((int)((double)((Control)listViewSelectedMaps).get_Width() * 0.2));
		ColumnHeader val14 = new ColumnHeader();
		val14.set_Text("Size");
		val14.set_Width((int)((double)((Control)listViewSelectedMaps).get_Width() * 0.2));
		listViewSelectedMaps.get_Columns().Add(val8);
		listViewSelectedMaps.get_Columns().Add(val9);
		listViewSelectedMaps.get_Columns().Add(val10);
		listViewSelectedMaps.get_Columns().Add(val11);
		listViewSelectedMaps.get_Columns().Add(val12);
		listViewSelectedMaps.get_Columns().Add(val13);
		listViewSelectedMaps.get_Columns().Add(val14);
	}

	private void FillListViewMaps()
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		listViewMaps.get_Items().Clear();
		listViewMaps.BeginUpdate();
		foreach (CMap map in m_mapList)
		{
			string text = map.DateAdded.ToString().Substring(0, 10);
			ListViewItem val = new ListViewItem(new string[7]
			{
				map.Localize,
				map.MapType.ToString(),
				map.Creator,
				map.Author,
				text,
				map.GameMode,
				map.Size
			});
			val.set_Tag((object)map);
			listViewMaps.get_Items().Add(val);
		}
		listViewMaps.EndUpdate();
		((Control)listViewMaps).Select();
	}

	private void listViewMaps_ColumnClick(object sender, ColumnClickEventArgs e)
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
		listViewMaps.set_ListViewItemSorter((IComparer)lvwColumnSorter);
		listViewMaps.Sort();
	}

	private void listViewMaps_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			AddMaps();
			e.set_Handled(true);
		}
	}

	private void listViewMaps_DoubleClick(object sender, EventArgs e)
	{
		AddMaps();
	}

	private void buttonAdd_Click(object sender, EventArgs e)
	{
		AddMaps();
	}

	private void AddMaps()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		listViewSelectedMaps.BeginUpdate();
		foreach (ListViewItem item in listViewMaps.get_Items())
		{
			ListViewItem val = item;
			if (val.get_Selected() && val.get_SubItems().get_Count() > 0)
			{
				CMap cMap = val.get_Tag() as CMap;
				string text = cMap.DateAdded.ToString().Substring(0, 10);
				ListViewItem val2 = new ListViewItem(new string[7]
				{
					cMap.Localize,
					cMap.MapType.ToString(),
					cMap.Creator,
					cMap.Author,
					text,
					cMap.GameMode,
					cMap.Size
				});
				val2.set_Tag((object)cMap);
				listViewSelectedMaps.get_Items().Add(val2);
			}
		}
		listViewSelectedMaps.EndUpdate();
	}

	private void listViewSelectedMaps_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 8 || (int)e.get_KeyCode() == 46)
		{
			RemoveMaps();
			e.set_Handled(true);
		}
	}

	private void listViewSelectedMaps_DoubleClick(object sender, EventArgs e)
	{
		RemoveMaps();
	}

	private void buttonRemove_Click(object sender, EventArgs e)
	{
		RemoveMaps();
	}

	private void RemoveMaps()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		listViewSelectedMaps.BeginUpdate();
		foreach (ListViewItem item in listViewSelectedMaps.get_Items())
		{
			ListViewItem val = item;
			if (val.get_Selected())
			{
				listViewSelectedMaps.get_Items().Remove(val);
				((Control)labelName1).set_Text("");
				((Control)labelCreator1).set_Text("");
				((Control)labelAuthor1).set_Text("");
				((Control)labelDate1).set_Text("");
				((Control)labelMode1).set_Text("");
				((Control)labelSize1).set_Text("");
				pictureBoxMap1.set_Image((Image)null);
				((Control)pictureBoxMap1).Refresh();
			}
		}
		listViewSelectedMaps.EndUpdate();
	}

	private void listViewSelectedMaps_ItemDrag(object sender, ItemDragEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		((Control)listViewSelectedMaps).DoDragDrop((object)listViewSelectedMaps.get_SelectedItems(), (DragDropEffects)2);
	}

	private void listViewSelectedMaps_DragEnter(object sender, DragEventArgs e)
	{
		int num = e.get_Data().GetFormats().Length - 1;
		for (int i = 0; i <= num; i++)
		{
			if (e.get_Data().GetFormats()[i].Equals("System.Windows.Forms.ListView+SelectedListViewItemCollection"))
			{
				e.set_Effect((DragDropEffects)2);
			}
		}
	}

	private void listViewSelectedMaps_DragDrop(object sender, DragEventArgs e)
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		if (listViewSelectedMaps.get_SelectedItems().get_Count() == 0)
		{
			return;
		}
		Point point = ((Control)listViewSelectedMaps).PointToClient(new Point(e.get_X(), e.get_Y()));
		ListViewItem val = listViewSelectedMaps.GetItemAt(point.X, point.Y);
		if (val == null)
		{
			val = listViewSelectedMaps.get_Items().get_Item(listViewSelectedMaps.get_Items().get_Count() - 1);
		}
		int index = val.get_Index();
		ListViewItem[] array = (ListViewItem[])(object)new ListViewItem[listViewSelectedMaps.get_SelectedItems().get_Count()];
		for (int i = 0; i <= listViewSelectedMaps.get_SelectedItems().get_Count() - 1; i++)
		{
			array[i] = listViewSelectedMaps.get_SelectedItems().get_Item(i);
		}
		for (int j = 0; j < array.GetLength(0); j++)
		{
			ListViewItem val2 = array[j];
			int num = index;
			if (num == val2.get_Index())
			{
				break;
			}
			num = ((val2.get_Index() >= num) ? (index + j) : (num + 1));
			ListViewItem val3 = (ListViewItem)val2.Clone();
			listViewSelectedMaps.get_Items().Insert(num, val3);
			listViewSelectedMaps.get_Items().Remove(val2);
		}
	}

	private void listViewMaps_SelectedIndexChanged(object sender, EventArgs e)
	{
		ListView val = (ListView)((sender is ListView) ? sender : null);
		if (val.get_SelectedItems().get_Count() > 0)
		{
			CMap cMap = val.get_SelectedItems().get_Item(0).get_Tag() as CMap;
			((Control)labelName).set_Text(cMap.Localize);
			((Control)labelCreator).set_Text(cMap.Creator);
			((Control)labelAuthor).set_Text(cMap.Author);
			((Control)labelDate).set_Text(cMap.DateAdded.ToString());
			((Control)labelMode).set_Text(cMap.GameMode);
			((Control)labelSize).set_Text(cMap.Size);
			pictureBoxMap.set_Image(cMap.Screenshot);
			((Control)pictureBoxMap).Refresh();
		}
	}

	private void listViewSelectedMaps_SelectedIndexChanged(object sender, EventArgs e)
	{
		ListView val = (ListView)((sender is ListView) ? sender : null);
		if (val.get_SelectedItems().get_Count() > 0)
		{
			CMap cMap = val.get_SelectedItems().get_Item(0).get_Tag() as CMap;
			((Control)labelName1).set_Text(cMap.Localize);
			((Control)labelCreator1).set_Text(cMap.Creator);
			((Control)labelAuthor1).set_Text(cMap.Author);
			((Control)labelDate1).set_Text(cMap.DateAdded.ToString());
			((Control)labelMode1).set_Text(cMap.GameMode);
			((Control)labelSize1).set_Text(cMap.Size);
			pictureBoxMap1.set_Image(cMap.Screenshot);
			((Control)pictureBoxMap1).Refresh();
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected O, but got Unknown
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected O, but got Unknown
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Expected O, but got Unknown
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Expected O, but got Unknown
		//IL_0abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Expected O, but got Unknown
		//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb9: Expected O, but got Unknown
		//IL_0ca2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cac: Expected O, but got Unknown
		//IL_0dfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e04: Expected O, but got Unknown
		//IL_0ea3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ead: Expected O, but got Unknown
		//IL_0ee8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef2: Expected O, but got Unknown
		//IL_0eff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f09: Expected O, but got Unknown
		//IL_10de: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e8: Expected O, but got Unknown
		//IL_1176: Unknown result type (might be due to invalid IL or missing references)
		//IL_1180: Expected O, but got Unknown
		//IL_1213: Unknown result type (might be due to invalid IL or missing references)
		//IL_121d: Expected O, but got Unknown
		//IL_122a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1234: Expected O, but got Unknown
		//IL_126f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1279: Expected O, but got Unknown
		//IL_1286: Unknown result type (might be due to invalid IL or missing references)
		//IL_1290: Expected O, but got Unknown
		//IL_1394: Unknown result type (might be due to invalid IL or missing references)
		//IL_139e: Expected O, but got Unknown
		//IL_14f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1503: Expected O, but got Unknown
		//IL_1579: Unknown result type (might be due to invalid IL or missing references)
		//IL_1583: Expected O, but got Unknown
		//IL_16e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16eb: Expected O, but got Unknown
		//IL_1760: Unknown result type (might be due to invalid IL or missing references)
		//IL_176a: Expected O, but got Unknown
		//IL_18a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b2: Expected O, but got Unknown
		//IL_18ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f6: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormMapCycle));
		buttonOk = new Button();
		buttonCancel = new Button();
		buttonAdd = new Button();
		buttonRemove = new Button();
		labelTip = new Label();
		tableLayoutPanel1 = new TableLayoutPanel();
		panel1 = new Panel();
		groupBoxMaps = new GroupBox();
		labelSize = new Label();
		label12 = new Label();
		labelAuthor = new Label();
		label10 = new Label();
		labelMode = new Label();
		label8 = new Label();
		labelCreator = new Label();
		label6 = new Label();
		labelDate = new Label();
		label4 = new Label();
		labelName = new Label();
		label1 = new Label();
		pictureBoxMap = new PictureBox();
		listViewMaps = new ListView();
		groupBoxSelectedMaps = new GroupBox();
		labelSize1 = new Label();
		listViewSelectedMaps = new ListView();
		label3 = new Label();
		pictureBoxMap1 = new PictureBox();
		labelAuthor1 = new Label();
		label18 = new Label();
		label7 = new Label();
		labelName1 = new Label();
		labelMode1 = new Label();
		label16 = new Label();
		label11 = new Label();
		labelDate1 = new Label();
		labelCreator1 = new Label();
		label14 = new Label();
		((Control)tableLayoutPanel1).SuspendLayout();
		((Control)panel1).SuspendLayout();
		((Control)groupBoxMaps).SuspendLayout();
		((ISupportInitialize)pictureBoxMap).BeginInit();
		((Control)groupBoxSelectedMaps).SuspendLayout();
		((ISupportInitialize)pictureBoxMap1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)buttonOk).set_Anchor((AnchorStyles)10);
		((Control)buttonOk).set_Location(new Point(848, 525));
		((Control)buttonOk).set_Name("buttonOk");
		((Control)buttonOk).set_Size(new Size(75, 23));
		((Control)buttonOk).set_TabIndex(2);
		((Control)buttonOk).set_Text("OK");
		((ButtonBase)buttonOk).set_UseVisualStyleBackColor(true);
		((Control)buttonOk).add_Click((EventHandler)buttonOk_Click);
		((Control)buttonCancel).set_Anchor((AnchorStyles)10);
		((Control)buttonCancel).set_Location(new Point(767, 525));
		((Control)buttonCancel).set_Name("buttonCancel");
		((Control)buttonCancel).set_Size(new Size(75, 23));
		((Control)buttonCancel).set_TabIndex(29);
		((Control)buttonCancel).set_Text("Cancel");
		((ButtonBase)buttonCancel).set_UseVisualStyleBackColor(true);
		((Control)buttonCancel).add_Click((EventHandler)buttonCancel_Click);
		((Control)buttonAdd).set_Location(new Point(2, 120));
		((Control)buttonAdd).set_Name("buttonAdd");
		((Control)buttonAdd).set_Size(new Size(75, 23));
		((Control)buttonAdd).set_TabIndex(31);
		((Control)buttonAdd).set_Text("Add -->");
		((ButtonBase)buttonAdd).set_UseVisualStyleBackColor(true);
		((Control)buttonAdd).add_Click((EventHandler)buttonAdd_Click);
		((Control)buttonRemove).set_Location(new Point(2, 149));
		((Control)buttonRemove).set_Name("buttonRemove");
		((Control)buttonRemove).set_Size(new Size(75, 23));
		((Control)buttonRemove).set_TabIndex(32);
		((Control)buttonRemove).set_Text("<-- Remove");
		((ButtonBase)buttonRemove).set_UseVisualStyleBackColor(true);
		((Control)buttonRemove).add_Click((EventHandler)buttonRemove_Click);
		((Control)labelTip).set_Anchor((AnchorStyles)6);
		((Control)labelTip).set_AutoSize(true);
		((Control)labelTip).set_Location(new Point(9, 535));
		((Control)labelTip).set_Name("labelTip");
		((Control)labelTip).set_Size(new Size(283, 13));
		((Control)labelTip).set_TabIndex(33);
		((Control)labelTip).set_Text("* Use drag-drop to change the order of your selected maps");
		((Control)tableLayoutPanel1).set_Anchor((AnchorStyles)15);
		tableLayoutPanel1.set_ColumnCount(3);
		tableLayoutPanel1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel1.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 85f));
		tableLayoutPanel1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel1.get_Controls().Add((Control)(object)panel1, 1, 0);
		tableLayoutPanel1.get_Controls().Add((Control)(object)groupBoxMaps, 0, 0);
		tableLayoutPanel1.get_Controls().Add((Control)(object)groupBoxSelectedMaps, 2, 0);
		((Control)tableLayoutPanel1).set_Location(new Point(12, 12));
		((Control)tableLayoutPanel1).set_Name("tableLayoutPanel1");
		tableLayoutPanel1.set_RowCount(1);
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel1).set_Size(new Size(911, 507));
		((Control)tableLayoutPanel1).set_TabIndex(34);
		((Control)panel1).get_Controls().Add((Control)(object)buttonAdd);
		((Control)panel1).get_Controls().Add((Control)(object)buttonRemove);
		((Control)panel1).set_Dock((DockStyle)5);
		((Control)panel1).set_Location(new Point(416, 3));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(79, 501));
		((Control)panel1).set_TabIndex(35);
		((Control)groupBoxMaps).get_Controls().Add((Control)(object)labelSize);
		((Control)groupBoxMaps).get_Controls().Add((Control)(object)label12);
		((Control)groupBoxMaps).get_Controls().Add((Control)(object)labelAuthor);
		((Control)groupBoxMaps).get_Controls().Add((Control)(object)label10);
		((Control)groupBoxMaps).get_Controls().Add((Control)(object)labelMode);
		((Control)groupBoxMaps).get_Controls().Add((Control)(object)label8);
		((Control)groupBoxMaps).get_Controls().Add((Control)(object)labelCreator);
		((Control)groupBoxMaps).get_Controls().Add((Control)(object)label6);
		((Control)groupBoxMaps).get_Controls().Add((Control)(object)labelDate);
		((Control)groupBoxMaps).get_Controls().Add((Control)(object)label4);
		((Control)groupBoxMaps).get_Controls().Add((Control)(object)labelName);
		((Control)groupBoxMaps).get_Controls().Add((Control)(object)label1);
		((Control)groupBoxMaps).get_Controls().Add((Control)(object)pictureBoxMap);
		((Control)groupBoxMaps).get_Controls().Add((Control)(object)listViewMaps);
		((Control)groupBoxMaps).set_Dock((DockStyle)5);
		((Control)groupBoxMaps).set_Location(new Point(3, 3));
		((Control)groupBoxMaps).set_Name("groupBoxMaps");
		((Control)groupBoxMaps).set_Size(new Size(407, 501));
		((Control)groupBoxMaps).set_TabIndex(29);
		groupBoxMaps.set_TabStop(false);
		((Control)groupBoxMaps).set_Text("Available Maps");
		((Control)labelSize).set_Anchor((AnchorStyles)10);
		((Control)labelSize).set_AutoSize(true);
		((Control)labelSize).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelSize).set_Location(new Point(267, 479));
		((Control)labelSize).set_Name("labelSize");
		((Control)labelSize).set_Size(new Size(0, 13));
		((Control)labelSize).set_TabIndex(38);
		((Control)label12).set_Anchor((AnchorStyles)10);
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_Location(new Point(267, 464));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(27, 13));
		((Control)label12).set_TabIndex(37);
		((Control)label12).set_Text("Size");
		((Control)labelAuthor).set_Anchor((AnchorStyles)6);
		((Control)labelAuthor).set_AutoSize(true);
		((Control)labelAuthor).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelAuthor).set_Location(new Point(141, 479));
		((Control)labelAuthor).set_Name("labelAuthor");
		((Control)labelAuthor).set_Size(new Size(0, 13));
		((Control)labelAuthor).set_TabIndex(36);
		((Control)label10).set_Anchor((AnchorStyles)6);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Location(new Point(141, 464));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(38, 13));
		((Control)label10).set_TabIndex(35);
		((Control)label10).set_Text("Author");
		((Control)labelMode).set_Anchor((AnchorStyles)10);
		((Control)labelMode).set_AutoSize(true);
		((Control)labelMode).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelMode).set_Location(new Point(267, 433));
		((Control)labelMode).set_Name("labelMode");
		((Control)labelMode).set_Size(new Size(0, 13));
		((Control)labelMode).set_TabIndex(34);
		((Control)label8).set_Anchor((AnchorStyles)10);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Location(new Point(267, 418));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(34, 13));
		((Control)label8).set_TabIndex(33);
		((Control)label8).set_Text("Mode");
		((Control)labelCreator).set_Anchor((AnchorStyles)6);
		((Control)labelCreator).set_AutoSize(true);
		((Control)labelCreator).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelCreator).set_Location(new Point(141, 433));
		((Control)labelCreator).set_Name("labelCreator");
		((Control)labelCreator).set_Size(new Size(0, 13));
		((Control)labelCreator).set_TabIndex(32);
		((Control)label6).set_Anchor((AnchorStyles)6);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(141, 418));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(41, 13));
		((Control)label6).set_TabIndex(31);
		((Control)label6).set_Text("Creator");
		((Control)labelDate).set_Anchor((AnchorStyles)10);
		((Control)labelDate).set_AutoSize(true);
		((Control)labelDate).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelDate).set_Location(new Point(267, 383));
		((Control)labelDate).set_Name("labelDate");
		((Control)labelDate).set_Size(new Size(0, 13));
		((Control)labelDate).set_TabIndex(30);
		((Control)label4).set_Anchor((AnchorStyles)10);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(267, 368));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(30, 13));
		((Control)label4).set_TabIndex(29);
		((Control)label4).set_Text("Date");
		((Control)labelName).set_Anchor((AnchorStyles)6);
		((Control)labelName).set_AutoSize(true);
		((Control)labelName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelName).set_Location(new Point(141, 383));
		((Control)labelName).set_Name("labelName");
		((Control)labelName).set_Size(new Size(0, 13));
		((Control)labelName).set_TabIndex(28);
		((Control)label1).set_Anchor((AnchorStyles)6);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(141, 368));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(35, 13));
		((Control)label1).set_TabIndex(27);
		((Control)label1).set_Text("Name");
		((Control)pictureBoxMap).set_Anchor((AnchorStyles)6);
		((Control)pictureBoxMap).set_Location(new Point(6, 367));
		((Control)pictureBoxMap).set_Name("pictureBoxMap");
		((Control)pictureBoxMap).set_Size(new Size(128, 128));
		pictureBoxMap.set_TabIndex(26);
		pictureBoxMap.set_TabStop(false);
		listViewMaps.set_Alignment((ListViewAlignment)0);
		((Control)listViewMaps).set_Anchor((AnchorStyles)15);
		((Control)listViewMaps).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		listViewMaps.set_FullRowSelect(true);
		listViewMaps.set_GridLines(true);
		listViewMaps.set_HideSelection(false);
		((Control)listViewMaps).set_Location(new Point(6, 19));
		((Control)listViewMaps).set_Name("listViewMaps");
		((Control)listViewMaps).set_Size(new Size(395, 342));
		listViewMaps.set_Sorting((SortOrder)1);
		((Control)listViewMaps).set_TabIndex(25);
		listViewMaps.set_UseCompatibleStateImageBehavior(false);
		listViewMaps.set_View((View)1);
		listViewMaps.add_ItemChecked(new ItemCheckedEventHandler(listViewMaps_ItemChecked));
		((Control)listViewMaps).add_DoubleClick((EventHandler)listViewMaps_DoubleClick);
		listViewMaps.add_SelectedIndexChanged((EventHandler)listViewMaps_SelectedIndexChanged);
		((Control)listViewMaps).add_KeyDown(new KeyEventHandler(listViewMaps_KeyDown));
		listViewMaps.add_ColumnClick(new ColumnClickEventHandler(listViewMaps_ColumnClick));
		((Control)groupBoxSelectedMaps).get_Controls().Add((Control)(object)labelSize1);
		((Control)groupBoxSelectedMaps).get_Controls().Add((Control)(object)listViewSelectedMaps);
		((Control)groupBoxSelectedMaps).get_Controls().Add((Control)(object)label3);
		((Control)groupBoxSelectedMaps).get_Controls().Add((Control)(object)pictureBoxMap1);
		((Control)groupBoxSelectedMaps).get_Controls().Add((Control)(object)labelAuthor1);
		((Control)groupBoxSelectedMaps).get_Controls().Add((Control)(object)label18);
		((Control)groupBoxSelectedMaps).get_Controls().Add((Control)(object)label7);
		((Control)groupBoxSelectedMaps).get_Controls().Add((Control)(object)labelName1);
		((Control)groupBoxSelectedMaps).get_Controls().Add((Control)(object)labelMode1);
		((Control)groupBoxSelectedMaps).get_Controls().Add((Control)(object)label16);
		((Control)groupBoxSelectedMaps).get_Controls().Add((Control)(object)label11);
		((Control)groupBoxSelectedMaps).get_Controls().Add((Control)(object)labelDate1);
		((Control)groupBoxSelectedMaps).get_Controls().Add((Control)(object)labelCreator1);
		((Control)groupBoxSelectedMaps).get_Controls().Add((Control)(object)label14);
		((Control)groupBoxSelectedMaps).set_Dock((DockStyle)5);
		((Control)groupBoxSelectedMaps).set_Location(new Point(501, 3));
		((Control)groupBoxSelectedMaps).set_Name("groupBoxSelectedMaps");
		((Control)groupBoxSelectedMaps).set_Size(new Size(407, 501));
		((Control)groupBoxSelectedMaps).set_TabIndex(31);
		groupBoxSelectedMaps.set_TabStop(false);
		((Control)groupBoxSelectedMaps).set_Text("Selected Maps");
		((Control)labelSize1).set_Anchor((AnchorStyles)10);
		((Control)labelSize1).set_AutoSize(true);
		((Control)labelSize1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelSize1).set_Location(new Point(268, 479));
		((Control)labelSize1).set_Name("labelSize1");
		((Control)labelSize1).set_Size(new Size(0, 13));
		((Control)labelSize1).set_TabIndex(51);
		listViewSelectedMaps.set_Alignment((ListViewAlignment)0);
		((Control)listViewSelectedMaps).set_AllowDrop(true);
		((Control)listViewSelectedMaps).set_Anchor((AnchorStyles)15);
		listViewSelectedMaps.set_AutoArrange(false);
		((Control)listViewSelectedMaps).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		listViewSelectedMaps.set_FullRowSelect(true);
		listViewSelectedMaps.set_GridLines(true);
		listViewSelectedMaps.set_HideSelection(false);
		((Control)listViewSelectedMaps).set_Location(new Point(6, 19));
		((Control)listViewSelectedMaps).set_Name("listViewSelectedMaps");
		((Control)listViewSelectedMaps).set_Size(new Size(395, 342));
		((Control)listViewSelectedMaps).set_TabIndex(25);
		listViewSelectedMaps.set_UseCompatibleStateImageBehavior(false);
		listViewSelectedMaps.set_View((View)1);
		((Control)listViewSelectedMaps).add_DragEnter(new DragEventHandler(listViewSelectedMaps_DragEnter));
		((Control)listViewSelectedMaps).add_DragDrop(new DragEventHandler(listViewSelectedMaps_DragDrop));
		((Control)listViewSelectedMaps).add_DoubleClick((EventHandler)listViewSelectedMaps_DoubleClick);
		listViewSelectedMaps.add_SelectedIndexChanged((EventHandler)listViewSelectedMaps_SelectedIndexChanged);
		((Control)listViewSelectedMaps).add_KeyDown(new KeyEventHandler(listViewSelectedMaps_KeyDown));
		listViewSelectedMaps.add_ItemDrag(new ItemDragEventHandler(listViewSelectedMaps_ItemDrag));
		((Control)label3).set_Anchor((AnchorStyles)10);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(268, 464));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(27, 13));
		((Control)label3).set_TabIndex(50);
		((Control)label3).set_Text("Size");
		((Control)pictureBoxMap1).set_Anchor((AnchorStyles)6);
		((Control)pictureBoxMap1).set_Location(new Point(8, 367));
		((Control)pictureBoxMap1).set_Name("pictureBoxMap1");
		((Control)pictureBoxMap1).set_Size(new Size(128, 128));
		pictureBoxMap1.set_TabIndex(39);
		pictureBoxMap1.set_TabStop(false);
		((Control)labelAuthor1).set_Anchor((AnchorStyles)6);
		((Control)labelAuthor1).set_AutoSize(true);
		((Control)labelAuthor1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelAuthor1).set_Location(new Point(143, 479));
		((Control)labelAuthor1).set_Name("labelAuthor1");
		((Control)labelAuthor1).set_Size(new Size(0, 13));
		((Control)labelAuthor1).set_TabIndex(49);
		((Control)label18).set_Anchor((AnchorStyles)6);
		((Control)label18).set_AutoSize(true);
		((Control)label18).set_Location(new Point(143, 368));
		((Control)label18).set_Name("label18");
		((Control)label18).set_Size(new Size(35, 13));
		((Control)label18).set_TabIndex(40);
		((Control)label18).set_Text("Name");
		((Control)label7).set_Anchor((AnchorStyles)6);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(143, 464));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(38, 13));
		((Control)label7).set_TabIndex(48);
		((Control)label7).set_Text("Author");
		((Control)labelName1).set_Anchor((AnchorStyles)6);
		((Control)labelName1).set_AutoSize(true);
		((Control)labelName1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelName1).set_Location(new Point(143, 383));
		((Control)labelName1).set_Name("labelName1");
		((Control)labelName1).set_Size(new Size(0, 13));
		((Control)labelName1).set_TabIndex(41);
		((Control)labelMode1).set_Anchor((AnchorStyles)10);
		((Control)labelMode1).set_AutoSize(true);
		((Control)labelMode1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelMode1).set_Location(new Point(268, 433));
		((Control)labelMode1).set_Name("labelMode1");
		((Control)labelMode1).set_Size(new Size(0, 13));
		((Control)labelMode1).set_TabIndex(47);
		((Control)label16).set_Anchor((AnchorStyles)10);
		((Control)label16).set_AutoSize(true);
		((Control)label16).set_Location(new Point(268, 368));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(30, 13));
		((Control)label16).set_TabIndex(42);
		((Control)label16).set_Text("Date");
		((Control)label11).set_Anchor((AnchorStyles)10);
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Location(new Point(268, 418));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(34, 13));
		((Control)label11).set_TabIndex(46);
		((Control)label11).set_Text("Mode");
		((Control)labelDate1).set_Anchor((AnchorStyles)10);
		((Control)labelDate1).set_AutoSize(true);
		((Control)labelDate1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelDate1).set_Location(new Point(268, 383));
		((Control)labelDate1).set_Name("labelDate1");
		((Control)labelDate1).set_Size(new Size(0, 13));
		((Control)labelDate1).set_TabIndex(43);
		((Control)labelCreator1).set_Anchor((AnchorStyles)6);
		((Control)labelCreator1).set_AutoSize(true);
		((Control)labelCreator1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelCreator1).set_Location(new Point(143, 433));
		((Control)labelCreator1).set_Name("labelCreator1");
		((Control)labelCreator1).set_Size(new Size(0, 13));
		((Control)labelCreator1).set_TabIndex(45);
		((Control)label14).set_Anchor((AnchorStyles)6);
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_Location(new Point(143, 418));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(41, 13));
		((Control)label14).set_TabIndex(44);
		((Control)label14).set_Text("Creator");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(935, 557));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel1);
		((Control)this).get_Controls().Add((Control)(object)labelTip);
		((Control)this).get_Controls().Add((Control)(object)buttonCancel);
		((Control)this).get_Controls().Add((Control)(object)buttonOk);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_MinimumSize(new Size(755, 360));
		((Control)this).set_Name("FormMapCycle");
		((Form)this).set_SizeGripStyle((SizeGripStyle)1);
		((Control)this).set_Text("Map Cycle");
		((Form)this).add_FormClosed(new FormClosedEventHandler(FormMapCycle_FormClosed));
		((Form)this).add_Load((EventHandler)FormMapCycle_Load);
		((Control)tableLayoutPanel1).ResumeLayout(false);
		((Control)panel1).ResumeLayout(false);
		((Control)groupBoxMaps).ResumeLayout(false);
		((Control)groupBoxMaps).PerformLayout();
		((ISupportInitialize)pictureBoxMap).EndInit();
		((Control)groupBoxSelectedMaps).ResumeLayout(false);
		((Control)groupBoxSelectedMaps).PerformLayout();
		((ISupportInitialize)pictureBoxMap1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
