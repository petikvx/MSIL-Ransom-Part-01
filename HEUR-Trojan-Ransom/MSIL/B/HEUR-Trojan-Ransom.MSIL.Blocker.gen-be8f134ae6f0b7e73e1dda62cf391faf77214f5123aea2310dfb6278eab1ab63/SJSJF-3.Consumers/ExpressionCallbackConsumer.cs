using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SJSJF_002D3.Mappers;

namespace SJSJF_002D3.Consumers;

public class ExpressionCallbackConsumer : Form
{
	private IContainer m_Server = null;

	private Button m_Parameter;

	private Button exporter;

	private Button m_Collection;

	private Button m_Singleton;

	private Button creator;

	private Button m_Predicate;

	private Button schema;

	private Button _Error;

	private Button m_Callback;

	private Button connection;

	private Button worker;

	private Button facade;

	private Button m_Stub;

	private Button wrapper;

	private Button m_Customer;

	private Button _Instance;

	private Button algo;

	private Button m_Test;

	private Button _Dic;

	public ExpressionCallbackConsumer()
	{
		DisableServer();
		((Form)this).add_Load((EventHandler)PrepareServer);
	}

	private void PrepareServer(object sender, EventArgs e)
	{
		Writer writer = new Writer("Thomas", "Dublin", 23);
		Writer writer2 = new Writer("John", "Sligo", 22);
		Console.WriteLine(writer.RateServer() + " is " + writer.UpdateServer(writer2) + " " + writer2.RateServer());
	}

	protected override void Dispose(bool addkey)
	{
		if (addkey && m_Server != null)
		{
			m_Server.Dispose();
		}
		((Form)this).Dispose(addkey);
	}

	private void DisableServer()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
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
		m_Parameter = new Button();
		exporter = new Button();
		m_Collection = new Button();
		m_Singleton = new Button();
		creator = new Button();
		m_Predicate = new Button();
		schema = new Button();
		_Error = new Button();
		m_Callback = new Button();
		connection = new Button();
		worker = new Button();
		facade = new Button();
		m_Stub = new Button();
		wrapper = new Button();
		m_Customer = new Button();
		_Instance = new Button();
		algo = new Button();
		m_Test = new Button();
		_Dic = new Button();
		((Control)this).SuspendLayout();
		((Control)m_Parameter).set_Dock((DockStyle)1);
		((Control)m_Parameter).set_Location(new Point(0, 0));
		((Control)m_Parameter).set_Name("button1");
		((Control)m_Parameter).set_Size(new Size(744, 23));
		((Control)m_Parameter).set_TabIndex(0);
		((Control)m_Parameter).set_Text("button1");
		((ButtonBase)m_Parameter).set_UseVisualStyleBackColor(true);
		((Control)exporter).set_Dock((DockStyle)1);
		((Control)exporter).set_Location(new Point(0, 23));
		((Control)exporter).set_Name("button2");
		((Control)exporter).set_Size(new Size(744, 23));
		((Control)exporter).set_TabIndex(1);
		((Control)exporter).set_Text("button2");
		((ButtonBase)exporter).set_UseVisualStyleBackColor(true);
		((Control)m_Collection).set_Dock((DockStyle)1);
		((Control)m_Collection).set_Location(new Point(0, 46));
		((Control)m_Collection).set_Name("button3");
		((Control)m_Collection).set_Size(new Size(744, 23));
		((Control)m_Collection).set_TabIndex(2);
		((Control)m_Collection).set_Text("button3");
		((ButtonBase)m_Collection).set_UseVisualStyleBackColor(true);
		((Control)m_Singleton).set_Dock((DockStyle)1);
		((Control)m_Singleton).set_Location(new Point(0, 69));
		((Control)m_Singleton).set_Name("button4");
		((Control)m_Singleton).set_Size(new Size(744, 23));
		((Control)m_Singleton).set_TabIndex(3);
		((Control)m_Singleton).set_Text("button4");
		((ButtonBase)m_Singleton).set_UseVisualStyleBackColor(true);
		((Control)creator).set_Dock((DockStyle)1);
		((Control)creator).set_Location(new Point(0, 92));
		((Control)creator).set_Name("button5");
		((Control)creator).set_Size(new Size(744, 23));
		((Control)creator).set_TabIndex(4);
		((Control)creator).set_Text("button5");
		((ButtonBase)creator).set_UseVisualStyleBackColor(true);
		((Control)m_Predicate).set_Dock((DockStyle)1);
		((Control)m_Predicate).set_Location(new Point(0, 115));
		((Control)m_Predicate).set_Name("button6");
		((Control)m_Predicate).set_Size(new Size(744, 23));
		((Control)m_Predicate).set_TabIndex(5);
		((Control)m_Predicate).set_Text("button6");
		((ButtonBase)m_Predicate).set_UseVisualStyleBackColor(true);
		((Control)schema).set_Dock((DockStyle)1);
		((Control)schema).set_Location(new Point(0, 138));
		((Control)schema).set_Name("button7");
		((Control)schema).set_Size(new Size(744, 23));
		((Control)schema).set_TabIndex(6);
		((Control)schema).set_Text("button7");
		((ButtonBase)schema).set_UseVisualStyleBackColor(true);
		((Control)_Error).set_Dock((DockStyle)1);
		((Control)_Error).set_Location(new Point(0, 161));
		((Control)_Error).set_Name("button8");
		((Control)_Error).set_Size(new Size(744, 23));
		((Control)_Error).set_TabIndex(7);
		((Control)_Error).set_Text("button8");
		((ButtonBase)_Error).set_UseVisualStyleBackColor(true);
		((Control)m_Callback).set_Dock((DockStyle)1);
		((Control)m_Callback).set_Location(new Point(0, 184));
		((Control)m_Callback).set_Name("button9");
		((Control)m_Callback).set_Size(new Size(744, 23));
		((Control)m_Callback).set_TabIndex(8);
		((Control)m_Callback).set_Text("button9");
		((ButtonBase)m_Callback).set_UseVisualStyleBackColor(true);
		((Control)connection).set_Dock((DockStyle)1);
		((Control)connection).set_Location(new Point(0, 207));
		((Control)connection).set_Name("button10");
		((Control)connection).set_Size(new Size(744, 23));
		((Control)connection).set_TabIndex(9);
		((Control)connection).set_Text("button10");
		((ButtonBase)connection).set_UseVisualStyleBackColor(true);
		((Control)worker).set_Dock((DockStyle)1);
		((Control)worker).set_Location(new Point(0, 230));
		((Control)worker).set_Name("button11");
		((Control)worker).set_Size(new Size(744, 23));
		((Control)worker).set_TabIndex(10);
		((Control)worker).set_Text("button11");
		((ButtonBase)worker).set_UseVisualStyleBackColor(true);
		((Control)facade).set_Dock((DockStyle)1);
		((Control)facade).set_Location(new Point(0, 253));
		((Control)facade).set_Name("button12");
		((Control)facade).set_Size(new Size(744, 23));
		((Control)facade).set_TabIndex(11);
		((Control)facade).set_Text("button12");
		((ButtonBase)facade).set_UseVisualStyleBackColor(true);
		((Control)m_Stub).set_Dock((DockStyle)1);
		((Control)m_Stub).set_Location(new Point(0, 276));
		((Control)m_Stub).set_Name("button13");
		((Control)m_Stub).set_Size(new Size(744, 23));
		((Control)m_Stub).set_TabIndex(12);
		((Control)m_Stub).set_Text("button13");
		((ButtonBase)m_Stub).set_UseVisualStyleBackColor(true);
		((Control)wrapper).set_Dock((DockStyle)1);
		((Control)wrapper).set_Location(new Point(0, 299));
		((Control)wrapper).set_Name("button14");
		((Control)wrapper).set_Size(new Size(744, 23));
		((Control)wrapper).set_TabIndex(13);
		((Control)wrapper).set_Text("button14");
		((ButtonBase)wrapper).set_UseVisualStyleBackColor(true);
		((Control)m_Customer).set_Dock((DockStyle)2);
		((Control)m_Customer).set_Location(new Point(0, 385));
		((Control)m_Customer).set_Name("button15");
		((Control)m_Customer).set_Size(new Size(744, 23));
		((Control)m_Customer).set_TabIndex(14);
		((Control)m_Customer).set_Text("button15");
		((ButtonBase)m_Customer).set_UseVisualStyleBackColor(true);
		((Control)_Instance).set_Dock((DockStyle)2);
		((Control)_Instance).set_Location(new Point(0, 362));
		((Control)_Instance).set_Name("button16");
		((Control)_Instance).set_Size(new Size(744, 23));
		((Control)_Instance).set_TabIndex(15);
		((Control)_Instance).set_Text("button16");
		((ButtonBase)_Instance).set_UseVisualStyleBackColor(true);
		((Control)algo).set_Dock((DockStyle)2);
		((Control)algo).set_Location(new Point(0, 339));
		((Control)algo).set_Name("button17");
		((Control)algo).set_Size(new Size(744, 23));
		((Control)algo).set_TabIndex(16);
		((Control)algo).set_Text("button17");
		((ButtonBase)algo).set_UseVisualStyleBackColor(true);
		((Control)m_Test).set_Dock((DockStyle)2);
		((Control)m_Test).set_Location(new Point(0, 316));
		((Control)m_Test).set_Name("button18");
		((Control)m_Test).set_Size(new Size(744, 23));
		((Control)m_Test).set_TabIndex(17);
		((Control)m_Test).set_Text("button18");
		((ButtonBase)m_Test).set_UseVisualStyleBackColor(true);
		((Control)_Dic).set_Dock((DockStyle)2);
		((Control)_Dic).set_Location(new Point(0, 293));
		((Control)_Dic).set_Name("button19");
		((Control)_Dic).set_Size(new Size(744, 23));
		((Control)_Dic).set_TabIndex(18);
		((Control)_Dic).set_Text("button19");
		((ButtonBase)_Dic).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(744, 408));
		((Control)this).get_Controls().Add((Control)(object)_Dic);
		((Control)this).get_Controls().Add((Control)(object)m_Test);
		((Control)this).get_Controls().Add((Control)(object)algo);
		((Control)this).get_Controls().Add((Control)(object)_Instance);
		((Control)this).get_Controls().Add((Control)(object)m_Customer);
		((Control)this).get_Controls().Add((Control)(object)wrapper);
		((Control)this).get_Controls().Add((Control)(object)m_Stub);
		((Control)this).get_Controls().Add((Control)(object)facade);
		((Control)this).get_Controls().Add((Control)(object)worker);
		((Control)this).get_Controls().Add((Control)(object)connection);
		((Control)this).get_Controls().Add((Control)(object)m_Callback);
		((Control)this).get_Controls().Add((Control)(object)_Error);
		((Control)this).get_Controls().Add((Control)(object)schema);
		((Control)this).get_Controls().Add((Control)(object)m_Predicate);
		((Control)this).get_Controls().Add((Control)(object)creator);
		((Control)this).get_Controls().Add((Control)(object)m_Singleton);
		((Control)this).get_Controls().Add((Control)(object)m_Collection);
		((Control)this).get_Controls().Add((Control)(object)exporter);
		((Control)this).get_Controls().Add((Control)(object)m_Parameter);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}
}
