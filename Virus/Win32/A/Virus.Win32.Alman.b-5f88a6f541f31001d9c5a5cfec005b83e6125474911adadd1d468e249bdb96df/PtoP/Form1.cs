using System;
using System.ComponentModel;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PtoP;

public class Form1 : Form
{
	private const string infDisconn = "######DISCONNECT######";

	private GroupBox groupBox1;

	private RichTextBox richTextBox1;

	private RichTextBox richTextBox2;

	private Button send;

	private Button disconn;

	private Label label1;

	private TextBox uid;

	private Label label2;

	private TextBox uip;

	private Label label3;

	private Button conn;

	private TextBox portnum;

	private bool isconnecting;

	private bool isconnected;

	private bool isclient;

	private Thread th;

	private Thread wait;

	private setPortForm portform;

	public static TcpListener tcp1;

	public static int port;

	private TcpClient tcpc;

	private TcpClient tcps;

	private NetworkStream nsc;

	private NetworkStream nss;

	private Button button1;

	private Container components;

	public extern Form1();

	protected override extern void Dispose(bool disposing);

	private void InitializeComponent()
	{
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if ((int)/*Error near IL_0008: Stack underflow*/ == 1)
			{
				_003F val = checked(/*Error near IL_000b: Stack underflow*/ * 8);
				if (/*Error near IL_0010: Stack underflow*/ >= val)
				{
					/*Error: Could not find block for branch target IL_0010*/;
				}
			}
		}
	}

	[STAThread]
	private static void Main()
	{
		Application.Run((Form)(object)new Form1());
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		portform = new setPortForm();
		((Form)portform).ShowDialog();
		((Control)send).set_Enabled(false);
		((Control)disconn).set_Enabled(false);
		((Control)this).set_Text("P2P聊天(正在等待连接..)");
		tcp1.Start();
		wait = new Thread(waitconn);
		wait.Start();
	}

	private void waitconn()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Invalid comparison between Unknown and I4
		tcps = tcp1.AcceptTcpClient();
		nss = tcps.GetStream();
		string text = "用户请求连接,接受?";
		string text2 = "连接请求";
		((Control)this).set_Text("P2P聊天(与" + ((Control)uid).get_Text() + "会话进行中)");
		DialogResult val = MessageBox.Show(text, text2, (MessageBoxButtons)4);
		if ((int)val == 6)
		{
			string text3 = "#";
			byte[] bytes = Encoding.ASCII.GetBytes(text3.ToCharArray());
			nss.Write(bytes, 0, bytes.Length);
			isconnecting = true;
			isconnected = true;
			isclient = false;
			((Control)conn).set_Enabled(false);
			((Control)disconn).set_Enabled(true);
			((Control)send).set_Enabled(true);
			th = new Thread(acceptmsg);
			th.Start();
		}
		else if ((int)val == 7)
		{
			string text3 = "##";
			byte[] bytes = Encoding.ASCII.GetBytes(text3.ToCharArray());
			nss.Write(bytes, 0, bytes.Length);
			nss.Close();
			tcps.Close();
			disconnect();
		}
	}

	private void conn_Click(object sender, EventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)uip).get_Text().Length == 0 || ((Control)portnum).get_Text().Length == 1)
		{
			string text = "请输入正确的IP地址和端口号";
			string text2 = "错误";
			MessageBox.Show(text, text2);
			return;
		}
		tcpc = new TcpClient();
		string text3 = ((Control)uip).get_Text();
		int num = Convert.ToInt32(((Control)portnum).get_Text(), 10);
		try
		{
			tcpc.Connect(text3, num);
		}
		catch (ArgumentOutOfRangeException)
		{
			string text = "请输入有效的端口号";
			string text2 = "错误";
			MessageBox.Show(text, text2);
			return;
		}
		catch (SocketException)
		{
			string text = "找不到对方,请重新确认对方的网络参数";
			string text2 = "错误";
			MessageBox.Show(text, text2);
			return;
		}
		nsc = tcpc.GetStream();
		byte[] array = new byte[2];
		int num2 = nsc.Read(array, 0, array.Length);
		if (num2 == 1)
		{
			string text = "已经建立连接!";
			string text2 = "完成";
			MessageBox.Show(text, text2);
			isconnecting = true;
			isconnected = true;
			isclient = true;
			((Control)conn).set_Enabled(false);
			((Control)disconn).set_Enabled(true);
			((Control)send).set_Enabled(true);
			th = new Thread(acceptmsg);
			th.Start();
		}
	}

	private void acceptmsg()
	{
		while (isconnecting)
		{
			if (isclient)
			{
				acceptmsg(tcpc, nsc);
			}
			else
			{
				acceptmsg(tcps, nss);
			}
		}
	}

	private void acceptmsg(TcpClient tcpc, NetworkStream ns)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		byte[] array = new byte[1024];
		ns = tcpc.GetStream();
		ns.Read(array, 0, array.Length);
		string @string = Encoding.Unicode.GetString(array);
		if (string.Compare(@string, "######DISCONNECT######") == 0)
		{
			string text = "用户已经断开了连接";
			string text2 = "连接已断开";
			MessageBox.Show(text, text2);
			((TextBoxBase)richTextBox1).AppendText(text + "\n");
			((Control)this).set_Text("P2P聊天(等待连接)");
			ns.Close();
			tcpc.Close();
			disconnect();
		}
		else
		{
			((Control)this).set_Text("P2P聊天(会话进行中)");
			DateTime now = DateTime.Now;
			string text3 = now.ToShortDateString() + "  " + now.ToLongTimeString();
			string text4 = text3 + "  ";
			((TextBoxBase)richTextBox1).AppendText(text4);
			((TextBoxBase)richTextBox1).AppendText(@string);
			((TextBoxBase)richTextBox1).AppendText("\n");
		}
	}

	private void send_Click(object sender, EventArgs e)
	{
		if (isclient)
		{
			sendmsg(nsc);
		}
		else
		{
			sendmsg(nss);
		}
	}

	private void sendmsg(NetworkStream ns)
	{
		string text = ((Control)uid).get_Text() + "说:\n" + ((Control)richTextBox2).get_Text();
		((Control)richTextBox2).set_Text((string)null);
		byte[] array = new byte[1024];
		array = Encoding.Unicode.GetBytes(text.ToCharArray());
		ns.Write(array, 0, array.Length);
		if (string.Compare(text, "######DISCONNECT######") != 0)
		{
			DateTime now = DateTime.Now;
			string text2 = now.ToShortDateString() + " " + now.ToLongTimeString();
			string text3 = text2 + "  我说:\n";
			((TextBoxBase)richTextBox1).AppendText(text3);
			((TextBoxBase)richTextBox1).AppendText(text);
			((TextBoxBase)richTextBox1).AppendText("\n\n");
			((Control)richTextBox2).Focus();
		}
	}

	private void disconn_Click(object sender, EventArgs e)
	{
		if (isclient)
		{
			disconnect(tcpc, nsc);
		}
		else
		{
			disconnect(tcps, nss);
		}
	}

	private void disconnect()
	{
		((Control)conn).set_Enabled(true);
		((Control)disconn).set_Enabled(false);
		((Control)send).set_Enabled(false);
		isconnecting = false;
		wait = new Thread(waitconn);
		wait.Start();
	}

	private void disconnect(TcpClient tcpc, NetworkStream ns)
	{
		byte[] array = new byte[64];
		array = Encoding.Unicode.GetBytes("######DISCONNECT######".ToCharArray());
		ns.Write(array, 0, array.Length);
		ns.Close();
		tcpc.Close();
		disconnect();
	}

	protected override void OnClosed(EventArgs e)
	{
		if (isconnecting)
		{
			if (isclient)
			{
				disconnect(tcpc, nsc);
			}
			else
			{
				disconnect(tcps, nss);
			}
		}
		tcp1.Stop();
		wait.Abort();
	}

	private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		if (e.get_Control() && (int)e.get_KeyCode() == 13)
		{
			send_Click(this, (EventArgs)(object)e);
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Control)richTextBox1).set_Text((string)null);
	}
}
