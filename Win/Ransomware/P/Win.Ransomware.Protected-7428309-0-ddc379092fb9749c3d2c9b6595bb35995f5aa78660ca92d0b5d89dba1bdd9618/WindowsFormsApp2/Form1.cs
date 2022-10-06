using System;
using System.ComponentModel;
using System.Windows.Forms;
using ConversionBack;

namespace WindowsFormsApp2;

public class Form1 : Form
{
	private IContainer components;

	private Label label2;

	private Button button3;

	private Button button2;

	public Form1()
	{
		InitializeComponent();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		object[] array = new object[3] { this, sender, e };
		ConvertBack.Runner(24304, 352, 71, array);
	}

	private void button2_Click_1(object sender, EventArgs e)
	{
		object[] array = new object[3] { this, sender, e };
		ConvertBack.Runner(24656, 448, 72, array);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		object[] array = new object[3] { this, sender, e };
		ConvertBack.Runner(25104, 16, 73, array);
	}

	private void label2_Click(object sender, EventArgs e)
	{
		object[] array = new object[3] { this, sender, e };
		ConvertBack.Runner(25120, 16, 74, array);
	}

	protected override void Dispose(bool disposing)
	{
		object[] array = new object[2] { this, disposing };
		ConvertBack.Runner(25136, 96, 75, array);
	}

	private void InitializeComponent()
	{
		object[] array = new object[1] { this };
		ConvertBack.Runner(25232, 1440, 76, array);
	}
}
