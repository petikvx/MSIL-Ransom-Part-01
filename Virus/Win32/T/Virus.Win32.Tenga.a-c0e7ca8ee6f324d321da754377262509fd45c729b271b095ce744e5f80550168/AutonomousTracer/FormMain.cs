using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CommonSupport;

namespace AutonomousTracer;

public class FormMain : Form
{
	private IContainer components = null;

	private TracerControl tracerControl1;

	private ToolStrip toolStrip1;

	private ToolStripButton toolStripButtonLoad;

	private ToolStripButton toolStripButtonUpdate;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripLabel toolStripLabelFile;

	private string _filePath = null;

	private FileSystemWatcher _watcher = new FileSystemWatcher();

	private long _lastFilePos = 0L;

	private FileStream _fs = null;

	private Tracer _tracer = new Tracer();

	private StreamReader _reader = null;

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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
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
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		Tracer val = new Tracer();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormMain));
		tracerControl1 = new TracerControl();
		toolStrip1 = new ToolStrip();
		toolStripButtonLoad = new ToolStripButton();
		toolStripButtonUpdate = new ToolStripButton();
		toolStripSeparator1 = new ToolStripSeparator();
		toolStripLabelFile = new ToolStripLabel();
		((Control)toolStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		tracerControl1.set_DetailsVisible(false);
		((Control)tracerControl1).set_Dock((DockStyle)5);
		((Control)tracerControl1).set_Location(new Point(0, 25));
		((Control)tracerControl1).set_Name("tracerControl1");
		tracerControl1.set_ShowDetails(false);
		tracerControl1.set_ShowMethodFilter(true);
		((Control)tracerControl1).set_Size(new Size(928, 641));
		((Control)tracerControl1).set_TabIndex(0);
		val.set_Enabled(true);
		tracerControl1.set_Tracer(val);
		toolStrip1.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)toolStripButtonLoad,
			(ToolStripItem)toolStripButtonUpdate,
			(ToolStripItem)toolStripSeparator1,
			(ToolStripItem)toolStripLabelFile
		});
		((Control)toolStrip1).set_Location(new Point(0, 0));
		((Control)toolStrip1).set_Name("toolStrip1");
		((Control)toolStrip1).set_Size(new Size(928, 25));
		((Control)toolStrip1).set_TabIndex(1);
		((Control)toolStrip1).set_Text("toolStrip1");
		((ToolStripItem)toolStripButtonLoad).set_Image((Image)componentResourceManager.GetObject("toolStripButtonLoad.Image"));
		((ToolStripItem)toolStripButtonLoad).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripButtonLoad).set_Name("toolStripButtonLoad");
		((ToolStripItem)toolStripButtonLoad).set_Size(new Size(50, 22));
		((ToolStripItem)toolStripButtonLoad).set_Text("Load");
		((ToolStripItem)toolStripButtonLoad).add_Click((EventHandler)toolStripButtonLoad_Click);
		((ToolStripItem)toolStripButtonUpdate).set_Image((Image)componentResourceManager.GetObject("toolStripButtonUpdate.Image"));
		((ToolStripItem)toolStripButtonUpdate).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripButtonUpdate).set_Name("toolStripButtonUpdate");
		((ToolStripItem)toolStripButtonUpdate).set_Size(new Size(62, 22));
		((ToolStripItem)toolStripButtonUpdate).set_Text("Update");
		((ToolStripItem)toolStripButtonUpdate).add_Click((EventHandler)toolStripButtonUpdate_Click);
		((ToolStripItem)toolStripSeparator1).set_Name("toolStripSeparator1");
		((ToolStripItem)toolStripSeparator1).set_Size(new Size(6, 25));
		((ToolStripItem)toolStripLabelFile).set_Name("toolStripLabelFile");
		((ToolStripItem)toolStripLabelFile).set_Size(new Size(23, 22));
		((ToolStripItem)toolStripLabelFile).set_Text("File");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(928, 666));
		((Control)this).get_Controls().Add((Control)(object)tracerControl1);
		((Control)this).get_Controls().Add((Control)(object)toolStrip1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("FormMain");
		((Control)this).set_Text("Autonomous Tracer v.0.8");
		((Form)this).add_Load((EventHandler)FormMain_Load);
		((Control)toolStrip1).ResumeLayout(false);
		((Control)toolStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public FormMain()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		InitializeComponent();
		TracerItemKeeperSink val = new TracerItemKeeperSink(_tracer);
		val.set_MaxItems(1000000);
		_tracer.Add((ITracerItemSink)(object)val);
		_watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size | NotifyFilters.LastWrite | NotifyFilters.LastAccess | NotifyFilters.CreationTime;
		_watcher.Changed += _watcher_Changed;
	}

	private void FormMain_Load(object sender, EventArgs e)
	{
		tracerControl1.set_Tracer(_tracer);
	}

	private void toolStripButtonLoad_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_Filter("Assemblies (*.log; *.txt)|*.log;*.txt");
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			_tracer.Clear(false);
			_filePath = ((FileDialog)val).get_FileName();
			_watcher.Path = Path.GetDirectoryName(_filePath);
			_watcher.Filter = Path.GetFileName(_filePath);
			_watcher.EnableRaisingEvents = true;
			if (_fs != null)
			{
				_fs.Dispose();
			}
			_lastFilePos = 0L;
			((ToolStripItem)toolStripLabelFile).set_Text(_filePath);
			toolStripButtonUpdate_Click(this, EventArgs.Empty);
		}
	}

	private void _watcher_Changed(object sender, FileSystemEventArgs e)
	{
		if (_fs == null || e.ChangeType == WatcherChangeTypes.Deleted || e.ChangeType == WatcherChangeTypes.Created)
		{
			if (_reader != null)
			{
				_reader.Dispose();
				_reader = null;
			}
			if (_fs != null)
			{
				_fs.Dispose();
				_fs = null;
			}
			if (e.ChangeType == WatcherChangeTypes.Deleted)
			{
				return;
			}
			try
			{
				_fs = new FileStream(_filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				_reader = new StreamReader(_fs);
			}
			catch (Exception ex)
			{
				SystemMonitor.Error(ex.Message);
				_reader = null;
				_fs.Dispose();
				_fs = null;
				return;
			}
		}
		if (_fs == null || !_fs.CanRead)
		{
			return;
		}
		if (_fs.Length < _lastFilePos - 10L)
		{
			_lastFilePos = 0L;
		}
		_fs.Seek(_lastFilePos, SeekOrigin.Begin);
		for (string text = _reader.ReadLine(); text != null; text = _reader.ReadLine())
		{
			TracerItem val = TracerItem.ParseFileItem(text);
			if (val != null)
			{
				_tracer.Add(val);
			}
		}
		_lastFilePos = _fs.Position;
	}

	private void toolStripButtonUpdate_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		GeneralHelper.FireAndForget((DefaultDelegate)delegate
		{
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			_watcher_Changed(null, new FileSystemEventArgs(WatcherChangeTypes.Created, _watcher.Path, _watcher.Filter));
			WinFormsHelper.BeginFilteredManagedInvoke((Control)(object)tracerControl1, new DefaultDelegate(tracerControl1.UpdateUI));
		});
	}
}
