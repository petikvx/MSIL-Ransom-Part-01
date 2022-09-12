using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;

namespace ns14;

[DesignerGenerated]
public class LeaderBoardForm : Form
{
	private IContainer icontainer_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OpenFileDialog1")]
	[CompilerGenerated]
	private OpenFileDialog openFileDialog_0;

	public GClass1 gclass1_0;

	private string string_0;

	private string string_1;

	internal virtual Button btnLoad
	{
		[CompilerGenerated]
		get
		{
			return _btnLoad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnLoad_Click;
			Button val = _btnLoad;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnLoad = value;
			val = _btnLoad;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnBack
	{
		[CompilerGenerated]
		get
		{
			return _btnBack;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnBack_Click;
			Button val = _btnBack;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnBack = value;
			val = _btnBack;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("dgLeaderBoard")]
	internal virtual DataGridView dgLeaderBoard
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual OpenFileDialog OpenFileDialog1
	{
		[CompilerGenerated]
		get
		{
			return openFileDialog_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			CancelEventHandler cancelEventHandler = OpenFileDialog1_FileOk;
			OpenFileDialog val = openFileDialog_0;
			if (val != null)
			{
				((FileDialog)val).remove_FileOk(cancelEventHandler);
			}
			openFileDialog_0 = value;
			val = openFileDialog_0;
			if (val != null)
			{
				((FileDialog)val).add_FileOk(cancelEventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("CName")]
	internal virtual DataGridViewTextBoxColumn CName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Wins")]
	internal virtual DataGridViewTextBoxColumn Wins
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("columnLose")]
	internal virtual DataGridViewTextBoxColumn columnLose
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cTotal")]
	internal virtual DataGridViewTextBoxColumn cTotal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public LeaderBoardForm()
	{
		((Form)this).add_Load((EventHandler)LeaderBoardForm_Load);
		gclass1_0 = new GClass1();
		string_0 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Saved Games\\SouthParkRoulette.csv";
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected O, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(LeaderBoardForm));
		btnLoad = new Button();
		btnBack = new Button();
		dgLeaderBoard = new DataGridView();
		CName = new DataGridViewTextBoxColumn();
		Wins = new DataGridViewTextBoxColumn();
		columnLose = new DataGridViewTextBoxColumn();
		cTotal = new DataGridViewTextBoxColumn();
		OpenFileDialog1 = new OpenFileDialog();
		((ISupportInitialize)dgLeaderBoard).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)btnLoad).set_BackColor(Color.Orange);
		((Control)btnLoad).set_Location(new Point(360, 292));
		((Control)btnLoad).set_Margin(new Padding(4, 4, 4, 4));
		((Control)btnLoad).set_Name("btnLoad");
		((Control)btnLoad).set_Size(new Size(269, 66));
		((Control)btnLoad).set_TabIndex(1);
		((ButtonBase)btnLoad).set_Text("Load");
		((ButtonBase)btnLoad).set_UseVisualStyleBackColor(false);
		((ButtonBase)btnBack).set_BackColor(Color.Orange);
		((Control)btnBack).set_Location(new Point(41, 292));
		((Control)btnBack).set_Margin(new Padding(4, 4, 4, 4));
		((Control)btnBack).set_Name("btnBack");
		((Control)btnBack).set_Size(new Size(269, 66));
		((Control)btnBack).set_TabIndex(2);
		((ButtonBase)btnBack).set_Text("Back");
		((ButtonBase)btnBack).set_UseVisualStyleBackColor(false);
		dgLeaderBoard.set_BackgroundColor(Color.Orange);
		dgLeaderBoard.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dgLeaderBoard.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)CName,
			(DataGridViewColumn)Wins,
			(DataGridViewColumn)columnLose,
			(DataGridViewColumn)cTotal
		});
		((Control)dgLeaderBoard).set_Location(new Point(41, 15));
		((Control)dgLeaderBoard).set_Margin(new Padding(4, 4, 4, 4));
		((Control)dgLeaderBoard).set_Name("dgLeaderBoard");
		dgLeaderBoard.set_RowHeadersWidth(51);
		((Control)dgLeaderBoard).set_Size(new Size(588, 270));
		((Control)dgLeaderBoard).set_TabIndex(3);
		((DataGridViewColumn)CName).set_HeaderText("Name");
		((DataGridViewColumn)CName).set_MinimumWidth(6);
		((DataGridViewColumn)CName).set_Name("CName");
		((DataGridViewColumn)CName).set_ReadOnly(true);
		((DataGridViewColumn)CName).set_Width(125);
		((DataGridViewColumn)Wins).set_HeaderText("cWins");
		((DataGridViewColumn)Wins).set_MinimumWidth(6);
		((DataGridViewColumn)Wins).set_Name("Wins");
		((DataGridViewColumn)Wins).set_ReadOnly(true);
		((DataGridViewColumn)Wins).set_Width(125);
		((DataGridViewColumn)columnLose).set_HeaderText("Losses");
		((DataGridViewColumn)columnLose).set_MinimumWidth(6);
		((DataGridViewColumn)columnLose).set_Name("columnLose");
		((DataGridViewColumn)columnLose).set_ReadOnly(true);
		((DataGridViewColumn)columnLose).set_Width(125);
		((DataGridViewColumn)cTotal).set_HeaderText("Total");
		((DataGridViewColumn)cTotal).set_MinimumWidth(6);
		((DataGridViewColumn)cTotal).set_Name("cTotal");
		((DataGridViewColumn)cTotal).set_ReadOnly(true);
		((DataGridViewColumn)cTotal).set_Width(125);
		((FileDialog)OpenFileDialog1).set_FileName("OpenFileDialog1");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.WindowFrame);
		((Form)this).set_ClientSize(new Size(652, 374));
		((Control)this).get_Controls().Add((Control)(object)dgLeaderBoard);
		((Control)this).get_Controls().Add((Control)(object)btnBack);
		((Control)this).get_Controls().Add((Control)(object)btnLoad);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(4, 4, 4, 4));
		((Control)this).set_Name("LeaderBoardForm");
		((Form)this).set_Text("LeaderBoardForm");
		((ISupportInitialize)dgLeaderBoard).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void btnBack_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void btnLoad_Click(object sender, EventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		((FileDialog)OpenFileDialog1).set_Title("Select your Leaderboard Textfile");
		((FileDialog)OpenFileDialog1).set_Filter("Text File|*.txt;*.csv|All Files (*.*)|*.*");
		((CommonDialog)OpenFileDialog1).ShowDialog();
	}

	private void LeaderBoardForm_Load(object sender, EventArgs e)
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		if (File.Exists(string_0))
		{
			StreamReader streamReader = new StreamReader(string_0);
			while (!streamReader.EndOfStream)
			{
				string_1 = streamReader.ReadLine();
				string[] array = string_1.Split(new char[1] { ',' });
				dgLeaderBoard.get_Rows().Add(new object[4]
				{
					array[0],
					Convert.ToInt32(array[1]),
					Convert.ToInt32(array[2]),
					checked(Convert.ToInt32(array[1]) - Convert.ToInt32(array[2]))
				});
			}
			dgLeaderBoard.Sort(dgLeaderBoard.get_Columns().get_Item(3), ListSortDirection.Descending);
		}
		else if (!File.Exists(string_0))
		{
			Interaction.MsgBox((object)"No Save file detected, Please finish the game to create one\r\nTo load a Save File, Use the load button", (MsgBoxStyle)0, (object)null);
		}
	}

	private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
	{
		dgLeaderBoard.get_Rows().Clear();
		StreamReader streamReader = new StreamReader(((FileDialog)OpenFileDialog1).get_FileName());
		while (!streamReader.EndOfStream)
		{
			string_1 = streamReader.ReadLine();
			string[] array = string_1.Split(new char[1] { ',' });
			dgLeaderBoard.get_Rows().Add(new object[4]
			{
				array[0],
				Convert.ToInt32(array[1]),
				Convert.ToInt32(array[2]),
				Convert.ToInt32(array[3])
			});
		}
	}
}
