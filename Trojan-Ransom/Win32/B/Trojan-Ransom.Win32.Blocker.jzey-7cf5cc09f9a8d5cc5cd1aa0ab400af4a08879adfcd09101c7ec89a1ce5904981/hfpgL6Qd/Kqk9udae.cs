using System;
using System.Resources;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace hfpgL6Qd;

internal class Kqk9udae
{
	internal static int z79a59Q2(TrackBar trackBar_0, int int_0)
	{
		return (int_0 ^ 0x5234) switch
		{
			_ => trackBar_0.get_Value(), 
		};
	}

	internal static bool DRgfcdtP(RadioButton radioButton_0, int int_0)
	{
		return (int_0 ^ 0xF0C0) switch
		{
			_ => radioButton_0.get_Checked(), 
		};
	}

	internal static void mnXsYM6G(TrackBar trackBar_0, int int_0, int int_1, int int_2)
	{
		switch (int_2 ^ 0x3E93)
		{
		}
		trackBar_0.SetRange(int_0, int_1);
	}

	internal static string SPSEDAEB(ResourceManager resourceManager_0, string string_0, int int_0)
	{
		return (int_0 ^ 0x78DE) switch
		{
			_ => resourceManager_0.GetString(string_0), 
		};
	}

	internal static void VolyaAFe(ErrorProvider errorProvider_0, Control control_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0xDEE1)
		{
		}
		errorProvider_0.SetError(control_0, string_0);
	}

	internal static void aAyNzrRv(ErrorProvider errorProvider_0, int int_0)
	{
		switch (int_0 ^ 0x33B7)
		{
		}
		errorProvider_0.Clear();
	}

	internal static int I89MtagN(TextBoxBase textBoxBase_0, int int_0)
	{
		return (int_0 ^ 0xD9DA) switch
		{
			_ => textBoxBase_0.get_SelectionStart(), 
		};
	}

	internal static string smethod_0(string string_0, int int_0, string string_1, int int_1)
	{
		return (int_1 ^ 0x6CF0) switch
		{
			_ => string_0.Insert(int_0, string_1), 
		};
	}

	internal static void dFjNSVFM(TextBoxBase textBoxBase_0, int int_0, int int_1)
	{
		switch (int_1 ^ 0x73FA)
		{
		default:
			textBoxBase_0.set_SelectionLength(int_0);
			break;
		case 1:
			textBoxBase_0.set_SelectionStart(int_0);
			break;
		}
	}

	internal static void IIiodi7q(ObjectCollection objectCollection_0, object[] object_0, int int_0)
	{
		switch (int_0 ^ 0x331A)
		{
		}
		objectCollection_0.AddRange(object_0);
	}

	internal static void XnWuqS8L(ComboBox comboBox_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0x5936)
		{
		}
		comboBox_0.set_Text(string_0);
	}

	internal static string smethod_1(ComboBox comboBox_0, int int_0)
	{
		return (int_0 ^ 0x86D9) switch
		{
			_ => comboBox_0.get_Text(), 
		};
	}

	internal static bool bvAT73DM(object object_0, int int_0)
	{
		return (int_0 ^ 0x63CE) switch
		{
			_ => Versioned.IsNumeric(object_0), 
		};
	}

	internal static void tn4KRRzI(Splitter splitter_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x2594)
		{
		}
		splitter_0.set_TabStop(bool_0);
	}

	internal static void kQiTgUDk(TreeView treeView_0, TreeNodeMouseClickEventHandler treeNodeMouseClickEventHandler_0, int int_0)
	{
		switch (int_0 ^ 0x84EC)
		{
		default:
			treeView_0.remove_NodeMouseClick(treeNodeMouseClickEventHandler_0);
			break;
		case 1:
			treeView_0.add_NodeMouseClick(treeNodeMouseClickEventHandler_0);
			break;
		}
	}

	internal static void xyFknXuj(ToolStripMenuItem toolStripMenuItem_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x125A)
		{
		}
		toolStripMenuItem_0.set_Enabled(bool_0);
	}

	internal static void KkdIIejT(FileDialog fileDialog_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x2459)
		{
		}
		fileDialog_0.set_CheckPathExists(bool_0);
	}

	internal static void K903OnTg(OpenFileDialog openFileDialog_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x4A34)
		{
		}
		openFileDialog_0.set_CheckFileExists(bool_0);
	}

	internal static int YPmr54Ig(Random random_0, int int_0, int int_1, int int_2)
	{
		return (int_2 ^ 0x54FF) switch
		{
			_ => random_0.Next(int_0, int_1), 
		};
	}

	internal static TreeNodeCollection Sflzniow(TreeView treeView_0, int int_0)
	{
		return (TreeNodeCollection)((int_0 ^ 0x1C4F) switch
		{
			_ => treeView_0.get_Nodes(), 
		});
	}
}
