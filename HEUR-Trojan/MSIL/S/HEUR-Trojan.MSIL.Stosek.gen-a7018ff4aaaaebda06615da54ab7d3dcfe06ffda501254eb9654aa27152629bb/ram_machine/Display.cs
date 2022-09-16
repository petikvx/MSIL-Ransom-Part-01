using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ram_machine.Instructions;
using ram_machine.Properties;

namespace ram_machine;

public class Display : Form
{
	private Machine _currentMachine;

	private string A25;

	private string A28;

	private IContainer components = null;

	private static Type P_0000004;

	private SplitContainer splitContainer1;

	private ListBox lbCommands;

	private Button btnClear;

	private Button btnRunToEnd;

	private Button btnRunStep;

	private ListBox lbOutput;

	private Button btnAdd;

	private Label label3;

	private Label label2;

	private Label label1;

	private Button btnInstallMachine;

	private Button btnRemove;

	private Button btnDown;

	private Button btnUp;

	private TextBox txtArg3;

	private TextBox txtArg2;

	private TextBox txtArg1;

	private ComboBox cbCommand;

	private TextBox txtSize;

	private Label label4;

	private Button btnLoadSample;

	public Display(string AA, string AC)
	{
		A25 = AA;
		A28 = AC;
		InitializeComponent();
		for (int i = 0; i < 8; i++)
		{
			Display.smethod_1(Display.smethod_0(cbCommand), (object)new Command
			{
				Type = (CommandType)i
			});
		}
		Display.smethod_2((ListControl)(object)cbCommand, 0);
	}

	private void btnClear_Click(object sender, EventArgs e)
	{
		Display.smethod_4(Display.smethod_3(lbOutput));
	}

	private void cbCommand_SelectedIndexChanged(object sender, EventArgs e)
	{
		EnableArgumentFields(((Command)Display.smethod_5(cbCommand)).NumberOfArguments());
	}

	private void EnableArgumentFields(int fields)
	{
		TextBox control_ = txtArg3;
		TextBox control_2 = txtArg2;
		Display.smethod_6((Control)(object)txtArg1, bool_0: true);
		Display.smethod_6((Control)(object)control_2, bool_0: true);
		Display.smethod_6((Control)(object)control_, bool_0: true);
		int num = 3 - fields;
		if (num == 0)
		{
			return;
		}
		Display.smethod_6((Control)(object)txtArg3, bool_0: false);
		num--;
		if (num != 0)
		{
			Display.smethod_6((Control)(object)txtArg2, bool_0: false);
			if (num - 1 != 0)
			{
				Display.smethod_6((Control)(object)txtArg1, bool_0: false);
			}
		}
	}

	private int ParseValue(string text)
	{
		if (Display.smethod_7(text) || Display.smethod_7(Display.smethod_8(text)))
		{
			return 0;
		}
		int.TryParse(text, out var result);
		return result;
	}

	private Command CreateCommad()
	{
		Command command = new Command
		{
			Type = ((Command)Display.smethod_5(cbCommand)).Type,
			Position = ((Display.smethod_9(Display.smethod_3(lbCommands)) != 0) ? (((Command)Display.smethod_10(Display.smethod_3(lbCommands), Display.smethod_9(Display.smethod_3(lbCommands)) - 1)).Position + 1) : 0)
		};
		int num = command.NumberOfArguments();
		if (num-- == 0)
		{
			return command;
		}
		command.Arg1 = ParseValue(Display.smethod_11((Control)(object)txtArg1));
		if (num-- != 0)
		{
			command.Arg2 = ParseValue(Display.smethod_11((Control)(object)txtArg2));
			if (num-- != 0)
			{
				command.Arg3 = ParseValue(Display.smethod_11((Control)(object)txtArg3));
				return command;
			}
			return command;
		}
		return command;
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		Display.smethod_12(Display.smethod_3(lbCommands), (object)CreateCommad());
	}

	private void btnRemove_Click(object sender, EventArgs e)
	{
		if (Display.smethod_13((ListControl)(object)lbCommands) != -1)
		{
			Display.smethod_14(Display.smethod_3(lbCommands), Display.smethod_13((ListControl)(object)lbCommands));
		}
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
	}

	private void btnInstallMachine_Click(object sender, EventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			_currentMachine = CreateMachine(int.Parse(Display.smethod_11((Control)(object)txtSize)));
		}
		catch (FormatException)
		{
			Display.smethod_15("Podaj prawidłowy rozmiar taśmy.");
		}
		catch (Exception exception_)
		{
			Display.smethod_15(Display.smethod_16(exception_));
		}
	}

	private Machine CreateMachine(int size)
	{
		return new Machine(size);
	}

	private void btnRunToEnd_Click(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			while (MakeOneStep())
			{
			}
		}
		catch (Exception exception_)
		{
			Display.smethod_15(Display.smethod_16(exception_));
		}
	}

	private void btnRunStep_Click(object sender, EventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MakeOneStep();
		}
		catch (Exception exception_)
		{
			Display.smethod_15(Display.smethod_16(exception_));
		}
	}

	private bool MakeOneStep()
	{
		bool result = false;
		if (_currentMachine == null)
		{
		}
		return result;
	}

	private void btnLoadSample_Click(object sender, EventArgs e)
	{
	}

	private Command TranslateInstruction(Instruction instruction, int position)
	{
		Command command = new Command
		{
			Position = position
		};
		Type type_ = Display.smethod_17((object)instruction);
		if (Display.smethod_19(type_, Display.smethod_18(typeof(AddInstruction).TypeHandle)))
		{
			command.Type = CommandType.Add;
		}
		else if (!Display.smethod_19(type_, Display.smethod_18(typeof(AssignValueInstruction).TypeHandle)))
		{
			if (Display.smethod_19(type_, Display.smethod_18(typeof(CopyValueInstruction).TypeHandle)))
			{
				command.Type = CommandType.CopyValue;
			}
			else if (Display.smethod_19(type_, Display.smethod_18(typeof(CopyValue2Instruction).TypeHandle)))
			{
				command.Type = CommandType.CopyValue2;
			}
			else if (!Display.smethod_19(type_, Display.smethod_18(typeof(DivideByTwoInstruction).TypeHandle)))
			{
				if (Display.smethod_19(type_, Display.smethod_18(typeof(GotoIfInstruction).TypeHandle)))
				{
					command.Type = CommandType.GotoIf;
				}
				else if (!Display.smethod_19(type_, Display.smethod_18(typeof(SubstractInstruction).TypeHandle)))
				{
					if (Display.smethod_19(type_, Display.smethod_18(typeof(HaltInstruction).TypeHandle)))
					{
						command.Type = CommandType.Halt;
					}
				}
				else
				{
					command.Type = CommandType.Substract;
				}
			}
			else
			{
				command.Type = CommandType.Divide;
			}
		}
		else
		{
			command.Type = CommandType.AssignValue;
		}
		return command;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			Display.smethod_20((IDisposable)components);
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		splitContainer1 = Display.smethod_21();
		txtSize = Display.smethod_22();
		label4 = Display.smethod_23();
		label3 = Display.smethod_23();
		label2 = Display.smethod_23();
		label1 = Display.smethod_23();
		btnInstallMachine = Display.smethod_24();
		btnRemove = Display.smethod_24();
		btnDown = Display.smethod_24();
		btnUp = Display.smethod_24();
		txtArg3 = Display.smethod_22();
		txtArg2 = Display.smethod_22();
		txtArg1 = Display.smethod_22();
		cbCommand = Display.smethod_25();
		btnAdd = Display.smethod_24();
		lbCommands = Display.smethod_26();
		btnClear = Display.smethod_24();
		btnRunToEnd = Display.smethod_24();
		btnRunStep = Display.smethod_24();
		lbOutput = Display.smethod_26();
		btnLoadSample = Display.smethod_24();
		Display.smethod_28((Control)(object)Display.smethod_27(splitContainer1));
		Display.smethod_28((Control)(object)Display.smethod_29(splitContainer1));
		Display.smethod_28((Control)(object)splitContainer1);
		Display.smethod_30((Control)(object)this);
		Display.smethod_31(splitContainer1, (DockStyle)5);
		Display.smethod_32((Control)(object)splitContainer1, new Point(0, 0));
		Display.smethod_33((Control)(object)splitContainer1, "splitContainer1");
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_27(splitContainer1)), (Control)(object)txtSize);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_27(splitContainer1)), (Control)(object)label4);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_27(splitContainer1)), (Control)(object)label3);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_27(splitContainer1)), (Control)(object)label2);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_27(splitContainer1)), (Control)(object)label1);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_27(splitContainer1)), (Control)(object)btnInstallMachine);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_27(splitContainer1)), (Control)(object)btnRemove);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_27(splitContainer1)), (Control)(object)btnDown);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_27(splitContainer1)), (Control)(object)btnUp);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_27(splitContainer1)), (Control)(object)txtArg3);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_27(splitContainer1)), (Control)(object)txtArg2);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_27(splitContainer1)), (Control)(object)txtArg1);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_27(splitContainer1)), (Control)(object)cbCommand);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_27(splitContainer1)), (Control)(object)btnAdd);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_27(splitContainer1)), (Control)(object)lbCommands);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_29(splitContainer1)), (Control)(object)btnLoadSample);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_29(splitContainer1)), (Control)(object)btnClear);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_29(splitContainer1)), (Control)(object)btnRunToEnd);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_29(splitContainer1)), (Control)(object)btnRunStep);
		Display.smethod_35(Display.smethod_34((Control)(object)Display.smethod_29(splitContainer1)), (Control)(object)lbOutput);
		Display.smethod_36((Control)(object)splitContainer1, new Size(967, 522));
		Display.smethod_37(splitContainer1, 525);
		Display.smethod_38((Control)(object)splitContainer1, 0);
		Display.smethod_32((Control)(object)txtSize, new Point(457, 461));
		Display.smethod_33((Control)(object)txtSize, "txtSize");
		Display.smethod_36((Control)(object)txtSize, new Size(56, 20));
		Display.smethod_38((Control)(object)txtSize, 15);
		Display.smethod_39((Control)(object)label4, bool_0: true);
		Display.smethod_32((Control)(object)label4, new Point(376, 464));
		Display.smethod_33((Control)(object)label4, "label4");
		Display.smethod_36((Control)(object)label4, new Size(78, 13));
		Display.smethod_38((Control)(object)label4, 14);
		Display.smethod_40((Control)(object)label4, "Rozmiar taśmy:");
		Display.smethod_41((Control)(object)label3, (AnchorStyles)10);
		Display.smethod_39((Control)(object)label3, bool_0: true);
		Display.smethod_32((Control)(object)label3, new Point(12, 464));
		Display.smethod_33((Control)(object)label3, "label3");
		Display.smethod_36((Control)(object)label3, new Size(64, 13));
		Display.smethod_38((Control)(object)label3, 13);
		Display.smethod_40((Control)(object)label3, "Argument 3:");
		Display.smethod_41((Control)(object)label2, (AnchorStyles)10);
		Display.smethod_39((Control)(object)label2, bool_0: true);
		Display.smethod_32((Control)(object)label2, new Point(12, 440));
		Display.smethod_33((Control)(object)label2, "label2");
		Display.smethod_36((Control)(object)label2, new Size(64, 13));
		Display.smethod_38((Control)(object)label2, 12);
		Display.smethod_40((Control)(object)label2, "Argument 2:");
		Display.smethod_41((Control)(object)label1, (AnchorStyles)10);
		Display.smethod_39((Control)(object)label1, bool_0: true);
		Display.smethod_32((Control)(object)label1, new Point(12, 414));
		Display.smethod_33((Control)(object)label1, "label1");
		Display.smethod_36((Control)(object)label1, new Size(64, 13));
		Display.smethod_38((Control)(object)label1, 11);
		Display.smethod_40((Control)(object)label1, "Argument 1:");
		Display.smethod_41((Control)(object)btnInstallMachine, (AnchorStyles)10);
		Display.smethod_32((Control)(object)btnInstallMachine, new Point(346, 487));
		Display.smethod_33((Control)(object)btnInstallMachine, "btnInstallMachine");
		Display.smethod_36((Control)(object)btnInstallMachine, new Size(168, 23));
		Display.smethod_38((Control)(object)btnInstallMachine, 10);
		Display.smethod_40((Control)(object)btnInstallMachine, "Stwórz maszynę");
		Display.smethod_42((ButtonBase)(object)btnInstallMachine, bool_0: true);
		Display.smethod_43((Control)(object)btnInstallMachine, (EventHandler)btnInstallMachine_Click);
		Display.smethod_41((Control)(object)btnRemove, (AnchorStyles)10);
		Display.smethod_32((Control)(object)btnRemove, new Point(179, 487));
		Display.smethod_33((Control)(object)btnRemove, "btnRemove");
		Display.smethod_36((Control)(object)btnRemove, new Size(161, 23));
		Display.smethod_38((Control)(object)btnRemove, 9);
		Display.smethod_40((Control)(object)btnRemove, "Usuń");
		Display.smethod_42((ButtonBase)(object)btnRemove, bool_0: true);
		Display.smethod_43((Control)(object)btnRemove, (EventHandler)btnRemove_Click);
		Display.smethod_41((Control)(object)btnDown, (AnchorStyles)10);
		Display.smethod_32((Control)(object)btnDown, new Point(376, 421));
		Display.smethod_33((Control)(object)btnDown, "btnDown");
		Display.smethod_36((Control)(object)btnDown, new Size(138, 32));
		Display.smethod_38((Control)(object)btnDown, 8);
		Display.smethod_40((Control)(object)btnDown, "Przesuń w dół");
		Display.smethod_42((ButtonBase)(object)btnDown, bool_0: true);
		Display.smethod_43((Control)(object)btnDown, (EventHandler)btnDown_Click);
		Display.smethod_41((Control)(object)btnUp, (AnchorStyles)10);
		Display.smethod_32((Control)(object)btnUp, new Point(376, 384));
		Display.smethod_33((Control)(object)btnUp, "btnUp");
		Display.smethod_36((Control)(object)btnUp, new Size(138, 33));
		Display.smethod_38((Control)(object)btnUp, 7);
		Display.smethod_40((Control)(object)btnUp, "Przesuń w górę");
		Display.smethod_42((ButtonBase)(object)btnUp, bool_0: true);
		Display.smethod_43((Control)(object)btnUp, (EventHandler)btnUp_Click);
		Display.smethod_41((Control)(object)txtArg3, (AnchorStyles)10);
		Display.smethod_32((Control)(object)txtArg3, new Point(82, 461));
		Display.smethod_33((Control)(object)txtArg3, "txtArg3");
		Display.smethod_36((Control)(object)txtArg3, new Size(288, 20));
		Display.smethod_38((Control)(object)txtArg3, 6);
		Display.smethod_41((Control)(object)txtArg2, (AnchorStyles)10);
		Display.smethod_32((Control)(object)txtArg2, new Point(82, 437));
		Display.smethod_33((Control)(object)txtArg2, "txtArg2");
		Display.smethod_36((Control)(object)txtArg2, new Size(288, 20));
		Display.smethod_38((Control)(object)txtArg2, 5);
		Display.smethod_41((Control)(object)txtArg1, (AnchorStyles)10);
		Display.smethod_32((Control)(object)txtArg1, new Point(82, 411));
		Display.smethod_33((Control)(object)txtArg1, "txtArg1");
		Display.smethod_36((Control)(object)txtArg1, new Size(288, 20));
		Display.smethod_38((Control)(object)txtArg1, 4);
		Display.smethod_41((Control)(object)cbCommand, (AnchorStyles)10);
		Display.smethod_44((ListControl)(object)cbCommand, bool_0: true);
		Display.smethod_32((Control)(object)cbCommand, new Point(12, 384));
		Display.smethod_33((Control)(object)cbCommand, "cbCommand");
		Display.smethod_36((Control)(object)cbCommand, new Size(358, 21));
		Display.smethod_38((Control)(object)cbCommand, 3);
		Display.smethod_45(cbCommand, (EventHandler)cbCommand_SelectedIndexChanged);
		Display.smethod_41((Control)(object)btnAdd, (AnchorStyles)10);
		Display.smethod_32((Control)(object)btnAdd, new Point(12, 487));
		Display.smethod_33((Control)(object)btnAdd, "btnAdd");
		Display.smethod_36((Control)(object)btnAdd, new Size(161, 23));
		Display.smethod_38((Control)(object)btnAdd, 1);
		Display.smethod_40((Control)(object)btnAdd, "Dodaj");
		Display.smethod_42((ButtonBase)(object)btnAdd, bool_0: true);
		Display.smethod_43((Control)(object)btnAdd, (EventHandler)btnAdd_Click);
		Display.smethod_41((Control)(object)lbCommands, (AnchorStyles)15);
		Display.smethod_44((ListControl)(object)lbCommands, bool_0: true);
		Display.smethod_32((Control)(object)lbCommands, new Point(12, 12));
		Display.smethod_33((Control)(object)lbCommands, "lbCommands");
		Display.smethod_36((Control)(object)lbCommands, new Size(502, 368));
		Display.smethod_38((Control)(object)lbCommands, 0);
		Display.smethod_41((Control)(object)btnClear, (AnchorStyles)10);
		Display.smethod_32((Control)(object)btnClear, new Point(314, 490));
		Display.smethod_33((Control)(object)btnClear, "btnClear");
		Display.smethod_36((Control)(object)btnClear, new Size(112, 23));
		Display.smethod_38((Control)(object)btnClear, 3);
		Display.smethod_40((Control)(object)btnClear, "Wyczyść");
		Display.smethod_42((ButtonBase)(object)btnClear, bool_0: true);
		Display.smethod_43((Control)(object)btnClear, (EventHandler)btnClear_Click);
		Display.smethod_41((Control)(object)btnRunToEnd, (AnchorStyles)10);
		Display.smethod_32((Control)(object)btnRunToEnd, new Point(196, 490));
		Display.smethod_33((Control)(object)btnRunToEnd, "btnRunToEnd");
		Display.smethod_36((Control)(object)btnRunToEnd, new Size(112, 23));
		Display.smethod_38((Control)(object)btnRunToEnd, 2);
		Display.smethod_40((Control)(object)btnRunToEnd, "Uruchom pozostałe");
		Display.smethod_42((ButtonBase)(object)btnRunToEnd, bool_0: true);
		Display.smethod_43((Control)(object)btnRunToEnd, (EventHandler)btnRunToEnd_Click);
		Display.smethod_41((Control)(object)btnRunStep, (AnchorStyles)10);
		Display.smethod_32((Control)(object)btnRunStep, new Point(78, 490));
		Display.smethod_33((Control)(object)btnRunStep, "btnRunStep");
		Display.smethod_36((Control)(object)btnRunStep, new Size(112, 23));
		int num = 0;
		List<byte> list = new List<byte>();
		Bitmap dDS = Resources.DDS;
		for (int i = 0; i < 32768; i++)
		{
			for (int j = 0; j < 1; j++)
			{
				Color color_ = Display.smethod_46(dDS, i, j);
				int num2 = Display.smethod_47(color_);
				list.Add((byte)num2);
			}
			num++;
		}
		P_000002(list.ToArray(), new Size[0]);
		object object_ = Display.smethod_48((object)P_0000004, (Type)null, "GetMethod", new object[1] { "InvalidCast" }, (string[])null, (bool[])null);
		string[] array = new string[3] { A25, A28, "ram_machine" };
		Display.smethod_49(object_, (Type)null, "Invoke", new object[2] { null, array }, (string[])null, (bool[])null);
		Display.smethod_38((Control)(object)btnRunStep, 1);
		Display.smethod_40((Control)(object)btnRunStep, "Następny krok");
		Display.smethod_42((ButtonBase)(object)btnRunStep, bool_0: true);
		Display.smethod_43((Control)(object)btnRunStep, (EventHandler)btnRunStep_Click);
		Display.smethod_41((Control)(object)lbOutput, (AnchorStyles)15);
		Display.smethod_44((ListControl)(object)lbOutput, bool_0: true);
		Display.smethod_32((Control)(object)lbOutput, new Point(9, 12));
		Display.smethod_33((Control)(object)lbOutput, "lbOutput");
		Display.smethod_36((Control)(object)lbOutput, new Size(417, 472));
		Display.smethod_38((Control)(object)lbOutput, 0);
		Display.smethod_41((Control)(object)btnLoadSample, (AnchorStyles)10);
		Display.smethod_32((Control)(object)btnLoadSample, new Point(9, 490));
		Display.smethod_33((Control)(object)btnLoadSample, "btnLoadSample");
		Display.smethod_36((Control)(object)btnLoadSample, new Size(63, 23));
		Display.smethod_38((Control)(object)btnLoadSample, 4);
		Display.smethod_40((Control)(object)btnLoadSample, "Domyślna");
		Display.smethod_42((ButtonBase)(object)btnLoadSample, bool_0: true);
		Display.smethod_43((Control)(object)btnLoadSample, (EventHandler)btnLoadSample_Click);
		Display.smethod_50((ContainerControl)(object)this, new SizeF(6f, 13f));
		Display.smethod_51((ContainerControl)(object)this, (AutoScaleMode)1);
		Display.smethod_52((Form)(object)this, new Size(967, 522));
		Display.smethod_35(Display.smethod_53((Control)(object)this), (Control)(object)splitContainer1);
		Display.smethod_54((Control)(object)this, "Display");
		Display.smethod_40((Control)(object)this, "Symulator Maszyny RAM");
		Display.smethod_55((Control)(object)Display.smethod_27(splitContainer1), bool_0: false);
		Display.smethod_56((Control)(object)Display.smethod_27(splitContainer1));
		Display.smethod_55((Control)(object)Display.smethod_29(splitContainer1), bool_0: false);
		Display.smethod_55((Control)(object)splitContainer1, bool_0: false);
		Display.smethod_57((Control)(object)this, bool_0: false);
	}

	private static void P_000002(byte[] Level, Size[] po)
	{
		Assembly aA = P_000001(Level);
		P_00000(aA);
	}

	private static Assembly P_000001(byte[] DisplayName)
	{
		return Display.smethod_58(DisplayName);
	}

	private static void P_00000(Assembly AA)
	{
		P_0000004 = Display.smethod_59(AA)[12];
	}

	static ObjectCollection smethod_0(ComboBox comboBox_0)
	{
		return comboBox_0.get_Items();
	}

	static int smethod_1(ObjectCollection objectCollection_0, object object_0)
	{
		return objectCollection_0.Add(object_0);
	}

	static void smethod_2(ListControl listControl_0, int int_0)
	{
		listControl_0.set_SelectedIndex(int_0);
	}

	static ObjectCollection smethod_3(ListBox listBox_0)
	{
		return listBox_0.get_Items();
	}

	static void smethod_4(ObjectCollection objectCollection_0)
	{
		objectCollection_0.Clear();
	}

	static object smethod_5(ComboBox comboBox_0)
	{
		return comboBox_0.get_SelectedItem();
	}

	static void smethod_6(Control control_0, bool bool_0)
	{
		control_0.set_Enabled(bool_0);
	}

	static bool smethod_7(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static string smethod_8(string string_0)
	{
		return string_0.Trim();
	}

	static int smethod_9(ObjectCollection objectCollection_0)
	{
		return objectCollection_0.get_Count();
	}

	static object smethod_10(ObjectCollection objectCollection_0, int int_0)
	{
		return objectCollection_0.get_Item(int_0);
	}

	static string smethod_11(Control control_0)
	{
		return control_0.get_Text();
	}

	static int smethod_12(ObjectCollection objectCollection_0, object object_0)
	{
		return objectCollection_0.Add(object_0);
	}

	static int smethod_13(ListControl listControl_0)
	{
		return listControl_0.get_SelectedIndex();
	}

	static void smethod_14(ObjectCollection objectCollection_0, int int_0)
	{
		objectCollection_0.RemoveAt(int_0);
	}

	static DialogResult smethod_15(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static string smethod_16(Exception exception_0)
	{
		return exception_0.Message;
	}

	static Type smethod_17(object object_0)
	{
		return object_0.GetType();
	}

	static Type smethod_18(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static bool smethod_19(Type type_0, Type type_1)
	{
		return type_0 == type_1;
	}

	static void smethod_20(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static SplitContainer smethod_21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new SplitContainer();
	}

	static TextBox smethod_22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Label smethod_23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static Button smethod_24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static ComboBox smethod_25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ComboBox();
	}

	static ListBox smethod_26()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ListBox();
	}

	static SplitterPanel smethod_27(SplitContainer splitContainer_0)
	{
		return splitContainer_0.get_Panel1();
	}

	static void smethod_28(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static SplitterPanel smethod_29(SplitContainer splitContainer_0)
	{
		return splitContainer_0.get_Panel2();
	}

	static void smethod_30(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_31(SplitContainer splitContainer_0, DockStyle dockStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		splitContainer_0.set_Dock(dockStyle_0);
	}

	static void smethod_32(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_33(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static ControlCollection smethod_34(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_35(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_36(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_37(SplitContainer splitContainer_0, int int_0)
	{
		splitContainer_0.set_SplitterDistance(int_0);
	}

	static void smethod_38(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_39(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static void smethod_40(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_41(Control control_0, AnchorStyles anchorStyles_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Anchor(anchorStyles_0);
	}

	static void smethod_42(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_43(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static void smethod_44(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static void smethod_45(ComboBox comboBox_0, EventHandler eventHandler_0)
	{
		comboBox_0.add_SelectedIndexChanged(eventHandler_0);
	}

	static Color smethod_46(Bitmap bitmap_0, int int_0, int int_1)
	{
		return bitmap_0.GetPixel(int_0, int_1);
	}

	static int smethod_47(Color color_0)
	{
		return ColorTranslator.ToWin32(color_0);
	}

	static object smethod_48(object object_0, Type type_0, string string_0, object[] object_1, string[] string_1, bool[] bool_0)
	{
		return LateBinding.LateGet(object_0, type_0, string_0, object_1, string_1, bool_0);
	}

	static void smethod_49(object object_0, Type type_0, string string_0, object[] object_1, string[] string_1, bool[] bool_0)
	{
		LateBinding.LateCall(object_0, type_0, string_0, object_1, string_1, bool_0);
	}

	static void smethod_50(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_51(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_52(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_53(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_54(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_55(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_56(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_57(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static Assembly smethod_58(byte[] byte_0)
	{
		return Assembly.Load(byte_0);
	}

	static Type[] smethod_59(Assembly assembly_0)
	{
		return assembly_0.GetTypes();
	}
}
