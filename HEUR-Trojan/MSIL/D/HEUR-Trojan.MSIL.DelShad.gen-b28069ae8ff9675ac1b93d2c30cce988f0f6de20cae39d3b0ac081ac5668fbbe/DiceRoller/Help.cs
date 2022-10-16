using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace DiceRoller;

[DesignerGenerated]
public class Help : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("SplitContainer1")]
	internal virtual SplitContainer SplitContainer1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TreeView TreeView1
	{
		[CompilerGenerated]
		get
		{
			return _TreeView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			TreeViewEventHandler val = new TreeViewEventHandler(TreeView1_AfterSelect);
			TreeView treeView = _TreeView1;
			if (treeView != null)
			{
				treeView.remove_AfterSelect(val);
			}
			_TreeView1 = value;
			treeView = _TreeView1;
			if (treeView != null)
			{
				treeView.add_AfterSelect(val);
			}
		}
	}

	[field: AccessedThroughProperty("RichTextBox1")]
	internal virtual RichTextBox RichTextBox1
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

	[field: AccessedThroughProperty("PictureBox5")]
	internal virtual PictureBox PictureBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox4")]
	internal virtual PictureBox PictureBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox3")]
	internal virtual PictureBox PictureBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
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

	[field: AccessedThroughProperty("PictureBox10")]
	internal virtual PictureBox PictureBox10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox9")]
	internal virtual PictureBox PictureBox9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox8")]
	internal virtual PictureBox PictureBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox7")]
	internal virtual PictureBox PictureBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox6")]
	internal virtual PictureBox PictureBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Help()
	{
		((Form)this).add_Load((EventHandler)delegate
		{
			Main();
		});
		InitializeComponent();
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
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
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
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0976: Expected O, but got Unknown
		TreeNode val = new TreeNode("How To Play");
		TreeNode val2 = new TreeNode("Lower Categories");
		TreeNode val3 = new TreeNode("Rerolling");
		TreeNode val4 = new TreeNode("Scoring", (TreeNode[])(object)new TreeNode[2] { val2, val3 });
		TreeNode val5 = new TreeNode("Changes From Yahtzee");
		TreeNode val6 = new TreeNode("Controls");
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Help));
		SplitContainer1 = new SplitContainer();
		TreeView1 = new TreeView();
		Panel2 = new Panel();
		PictureBox10 = new PictureBox();
		PictureBox9 = new PictureBox();
		PictureBox8 = new PictureBox();
		PictureBox7 = new PictureBox();
		PictureBox6 = new PictureBox();
		Panel1 = new Panel();
		PictureBox5 = new PictureBox();
		PictureBox4 = new PictureBox();
		PictureBox3 = new PictureBox();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		RichTextBox1 = new RichTextBox();
		((Control)SplitContainer1.get_Panel1()).SuspendLayout();
		((Control)SplitContainer1.get_Panel2()).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((ISupportInitialize)PictureBox10).BeginInit();
		((ISupportInitialize)PictureBox9).BeginInit();
		((ISupportInitialize)PictureBox8).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		SplitContainer1.set_Dock((DockStyle)5);
		SplitContainer1.set_IsSplitterFixed(true);
		((Control)SplitContainer1).set_Location(new Point(0, 0));
		((Control)SplitContainer1).set_Name("SplitContainer1");
		((ScrollableControl)SplitContainer1.get_Panel1()).set_AutoScroll(true);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)TreeView1);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Panel2);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Panel1);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)SplitContainer1).set_Size(new Size(484, 281));
		SplitContainer1.set_SplitterDistance(187);
		((Control)SplitContainer1).set_TabIndex(0);
		((Control)TreeView1).set_Dock((DockStyle)5);
		((Control)TreeView1).set_Location(new Point(0, 0));
		((Control)TreeView1).set_Name("TreeView1");
		val.set_Name("Node0");
		val.set_Text("How To Play");
		val2.set_Name("Node2");
		val2.set_Text("Lower Categories");
		val3.set_Name("Node3");
		val3.set_Text("Rerolling");
		val4.set_Name("Node1");
		val4.set_Text("Scoring");
		val5.set_Name("Node4");
		val5.set_Text("Changes From Yahtzee");
		val6.set_Name("Node5");
		val6.set_Text("Controls");
		TreeView1.get_Nodes().AddRange((TreeNode[])(object)new TreeNode[4] { val, val4, val5, val6 });
		((Control)TreeView1).set_Size(new Size(187, 281));
		((Control)TreeView1).set_TabIndex(0);
		((Control)Panel2).get_Controls().Add((Control)(object)PictureBox10);
		((Control)Panel2).get_Controls().Add((Control)(object)PictureBox9);
		((Control)Panel2).get_Controls().Add((Control)(object)PictureBox8);
		((Control)Panel2).get_Controls().Add((Control)(object)PictureBox7);
		((Control)Panel2).get_Controls().Add((Control)(object)PictureBox6);
		((Control)Panel2).set_Location(new Point(58, 190));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(181, 33));
		((Control)Panel2).set_TabIndex(2);
		((Control)PictureBox10).set_Location(new Point(144, 0));
		((Control)PictureBox10).set_Name("PictureBox10");
		((Control)PictureBox10).set_Size(new Size(30, 30));
		PictureBox10.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox10.set_TabIndex(8);
		PictureBox10.set_TabStop(false);
		((Control)PictureBox9).set_Location(new Point(108, 0));
		((Control)PictureBox9).set_Name("PictureBox9");
		((Control)PictureBox9).set_Size(new Size(30, 30));
		PictureBox9.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox9.set_TabIndex(7);
		PictureBox9.set_TabStop(false);
		((Control)PictureBox8).set_Location(new Point(72, 0));
		((Control)PictureBox8).set_Name("PictureBox8");
		((Control)PictureBox8).set_Size(new Size(30, 30));
		PictureBox8.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox8.set_TabIndex(6);
		PictureBox8.set_TabStop(false);
		((Control)PictureBox7).set_Location(new Point(36, 0));
		((Control)PictureBox7).set_Name("PictureBox7");
		((Control)PictureBox7).set_Size(new Size(30, 30));
		PictureBox7.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox7.set_TabIndex(5);
		PictureBox7.set_TabStop(false);
		((Control)PictureBox6).set_Location(new Point(3, 0));
		((Control)PictureBox6).set_Name("PictureBox6");
		((Control)PictureBox6).set_Size(new Size(30, 30));
		PictureBox6.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox6.set_TabIndex(5);
		PictureBox6.set_TabStop(false);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox5);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox4);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox3);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox2);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox1);
		((Control)Panel1).set_Location(new Point(55, 110));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(181, 39));
		((Control)Panel1).set_TabIndex(1);
		((Control)PictureBox5).set_Location(new Point(147, 6));
		((Control)PictureBox5).set_Name("PictureBox5");
		((Control)PictureBox5).set_Size(new Size(30, 30));
		PictureBox5.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox5.set_TabIndex(4);
		PictureBox5.set_TabStop(false);
		((Control)PictureBox4).set_Location(new Point(111, 6));
		((Control)PictureBox4).set_Name("PictureBox4");
		((Control)PictureBox4).set_Size(new Size(30, 30));
		PictureBox4.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox4.set_TabIndex(3);
		PictureBox4.set_TabStop(false);
		((Control)PictureBox3).set_Location(new Point(75, 6));
		((Control)PictureBox3).set_Name("PictureBox3");
		((Control)PictureBox3).set_Size(new Size(30, 30));
		PictureBox3.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox3.set_TabIndex(2);
		PictureBox3.set_TabStop(false);
		((Control)PictureBox2).set_Location(new Point(39, 6));
		((Control)PictureBox2).set_Name("PictureBox2");
		((Control)PictureBox2).set_Size(new Size(30, 30));
		PictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox2.set_TabIndex(1);
		PictureBox2.set_TabStop(false);
		((Control)PictureBox1).set_Location(new Point(3, 6));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(30, 30));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		((Control)RichTextBox1).set_Dock((DockStyle)5);
		((Control)RichTextBox1).set_Location(new Point(0, 0));
		((Control)RichTextBox1).set_Name("RichTextBox1");
		((TextBoxBase)RichTextBox1).set_ReadOnly(true);
		((Control)RichTextBox1).set_Size(new Size(293, 281));
		((Control)RichTextBox1).set_TabIndex(0);
		RichTextBox1.set_Text("");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(484, 281));
		((Control)this).get_Controls().Add((Control)(object)SplitContainer1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximumSize(new Size(500, 320));
		((Form)this).set_MinimumSize(new Size(500, 320));
		((Control)this).set_Name("Help");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("Help");
		((Control)SplitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)SplitContainer1.get_Panel2()).ResumeLayout(false);
		((Control)SplitContainer1).ResumeLayout(false);
		((Control)Panel2).ResumeLayout(false);
		((ISupportInitialize)PictureBox10).EndInit();
		((ISupportInitialize)PictureBox9).EndInit();
		((ISupportInitialize)PictureBox8).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public void Main()
	{
		TreeView1.ExpandAll();
		((Control)Panel1).set_Visible(false);
		((Control)Panel2).set_Visible(false);
	}

	private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		Font selectionFont = new Font(RichTextBox1.get_Font(), (FontStyle)0);
		Font selectionFont2 = new Font(RichTextBox1.get_Font(), (FontStyle)1);
		TreeView1.get_SelectedNode().Expand();
		switch (e.get_Node().get_Name())
		{
		case "Node5":
			((Control)Panel1).Hide();
			((Control)Panel2).Hide();
			((TextBoxBase)RichTextBox1).Clear();
			((TextBoxBase)RichTextBox1).AppendText("The following shortcuts exist in Not Yahtzee.\r\n\r\n");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Ctrl + N ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("for New Game.\r\n");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("F1 ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("for Help.\r\n");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("F2 ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("for About.");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			((TextBoxBase)RichTextBox1).AppendText("Clicking on one of the Five dice that you have rolled allows you to lock-in that die.");
			((TextBoxBase)RichTextBox1).AppendText("\r\n");
			((TextBoxBase)RichTextBox1).AppendText("For more information, please read the 'Rerolling' section.");
			break;
		case "Node4":
			((Control)Panel1).Hide();
			((Control)Panel2).Hide();
			((TextBoxBase)RichTextBox1).Clear();
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("This section highlights the differences made to the mechanics of Yahtzee in this adaptation.");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			((TextBoxBase)RichTextBox1).AppendText("Not Yahtzee has 10 Categories and Rounds as opposed to the 13 Categories and Rounds of Yahtzee.");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			((TextBoxBase)RichTextBox1).AppendText("Not Yahtzee does not include the following categories: ");
			((TextBoxBase)RichTextBox1).AppendText("\r\n");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Small Straight, Large Straight ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("or ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Chance.");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			((TextBoxBase)RichTextBox1).AppendText("The category of ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Yahtzee ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("can only be scored in once, and is worth ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("50 points ");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Yahtzee ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("required the player to ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("score in a category each turn, ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("if the score would be ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("invalid ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("(such as scoring five 2's in the 'sixes' category) the ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("score equals 0.\r\n");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Not Yahtzee ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("however, allows the player to ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("skip his turn ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("if he so chooses.");
			((TextBoxBase)RichTextBox1).AppendText("This is comparable to the original game, in that it reduces the score of that turn to 0, but it ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("does not lock out any category from scoring.");
			break;
		case "Node3":
			((Control)Panel1).Hide();
			((Control)Panel2).Hide();
			((TextBoxBase)RichTextBox1).Clear();
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("You may roll once per turn, and re-roll two times.");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			((TextBoxBase)RichTextBox1).AppendText("The player may select any of the dice by clicking on them to lock them in.");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			((TextBoxBase)RichTextBox1).AppendText("Rerolling dice generates random dice rolls for all dice, bar those that have been locked.");
			((TextBoxBase)RichTextBox1).AppendText("");
			((TextBoxBase)RichTextBox1).AppendText("");
			break;
		case "Node2":
			((Control)Panel1).Hide();
			((Control)Panel2).Hide();
			((TextBoxBase)RichTextBox1).Clear();
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Lower Categories ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("are hard to achieve and rewarding categories.");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			((TextBoxBase)RichTextBox1).AppendText("Lower Categories are as follows: ");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Three-of-a-Kind ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("A pattern of ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("three ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("of the same number.");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Four-of-a-Kind ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("A pattern of ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("four ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("of the same number.");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Full House ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("A pattern of ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("three ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("of a kind and ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("two ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("of another kind. Scoring a Full House always equals ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("25 points.");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Yahtzee ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("is a pattern of ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("five ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("of a kind. Scoring a Yahtzee always equals ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("50 points.");
			break;
		case "Node1":
			((Control)Panel1).Show();
			((Control)Panel2).Show();
			((TextBoxBase)RichTextBox1).Clear();
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("Scoring in 'Not Yahtzee' is broken up into categories.");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Upper Categories ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("correspond to the faces of the dice, one through six:\r\n");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Lower Categories ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("correspond to patterns in the dice roll, such as 3-of-a-Kind.");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Total Score ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("is the sum of the ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Upper");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText(" and ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Lower ");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("Scores");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n\r\n\r\n\r\n");
			((TextBoxBase)RichTextBox1).AppendText("The above roll can be scored only in the Fives category.\r\n");
			((TextBoxBase)RichTextBox1).AppendText("The score of the Fives category will be 10. [2 x 5 = 10]");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n\r\n\r\n");
			((TextBoxBase)RichTextBox1).AppendText("The above roll can be scored either in the Fives category,\r\n");
			((TextBoxBase)RichTextBox1).AppendText("3-of-a-Kind, or 4-of-a-Kind.\r\n");
			((TextBoxBase)RichTextBox1).AppendText("The score will be the same regardless for which category it is scored in.");
			break;
		case "Node0":
			((Control)Panel1).Hide();
			((Control)Panel2).Hide();
			((TextBoxBase)RichTextBox1).Clear();
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText("'Not Yahtzee' is a dice based game that can be played solo or against friends.");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			((TextBoxBase)RichTextBox1).AppendText("The player rolls 5 dice, and scores the outcome in the appropriate category, ");
			((TextBoxBase)RichTextBox1).AppendText("such as scoring two 3s in the Threes category for 6 points");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			((TextBoxBase)RichTextBox1).AppendText("The game is over when 10 rounds have passed.\r\n");
			((TextBoxBase)RichTextBox1).AppendText("If you're playing against friends, the person with the highest score wins.");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			((TextBoxBase)RichTextBox1).AppendText("The Categories are split into two sections: Upper and Lower.");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			((TextBoxBase)RichTextBox1).AppendText("Categories and Scoring will be explain further under: ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Scoring");
			RichTextBox1.set_SelectionFont(selectionFont);
			((TextBoxBase)RichTextBox1).AppendText(" and ");
			RichTextBox1.set_SelectionFont(selectionFont2);
			((TextBoxBase)RichTextBox1).AppendText("Lower Categories.");
			((TextBoxBase)RichTextBox1).AppendText("\r\n\r\n");
			break;
		}
	}
}
