using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraPrinting.Preview;
using Microsoft.VisualBasic.CompilerServices;

namespace System8;

[DesignerGenerated]
public class frmPrintReport : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	[AccessedThroughProperty("PrintDialog1")]
	private PrintDialog printDialog_0;

	[AccessedThroughProperty("PrintControl1")]
	private PrintControl _PrintControl1;

	[AccessedThroughProperty("PrintBarManager1")]
	private PrintBarManager printBarManager_0;

	[AccessedThroughProperty("PreviewBar1")]
	private PreviewBar previewBar_0;

	[AccessedThroughProperty("PrintPreviewBarItem2")]
	private PrintPreviewBarItem _PrintPreviewBarItem2;

	[AccessedThroughProperty("PrintPreviewBarItem3")]
	private PrintPreviewBarItem _PrintPreviewBarItem3;

	[AccessedThroughProperty("PrintPreviewBarItem4")]
	private PrintPreviewBarItem _PrintPreviewBarItem4;

	[AccessedThroughProperty("PrintPreviewBarItem5")]
	private PrintPreviewBarItem _PrintPreviewBarItem5;

	[AccessedThroughProperty("PrintPreviewBarItem6")]
	private PrintPreviewBarItem _PrintPreviewBarItem6;

	[AccessedThroughProperty("PrintPreviewBarItem7")]
	private PrintPreviewBarItem _PrintPreviewBarItem7;

	[AccessedThroughProperty("PrintPreviewBarItem8")]
	private PrintPreviewBarItem _PrintPreviewBarItem8;

	[AccessedThroughProperty("PrintPreviewBarItem9")]
	private PrintPreviewBarItem _PrintPreviewBarItem9;

	[AccessedThroughProperty("PrintPreviewBarItem10")]
	private PrintPreviewBarItem _PrintPreviewBarItem10;

	[AccessedThroughProperty("PrintPreviewBarItem11")]
	private PrintPreviewBarItem _PrintPreviewBarItem11;

	[AccessedThroughProperty("PrintPreviewBarItem12")]
	private PrintPreviewBarItem _PrintPreviewBarItem12;

	[AccessedThroughProperty("PrintPreviewBarItem13")]
	private PrintPreviewBarItem _PrintPreviewBarItem13;

	[AccessedThroughProperty("PrintPreviewBarItem14")]
	private PrintPreviewBarItem _PrintPreviewBarItem14;

	[AccessedThroughProperty("PrintPreviewBarItem15")]
	private PrintPreviewBarItem _PrintPreviewBarItem15;

	[AccessedThroughProperty("ZoomBarEditItem1")]
	private ZoomBarEditItem _ZoomBarEditItem1;

	[AccessedThroughProperty("PrintPreviewRepositoryItemComboBox1")]
	private PrintPreviewRepositoryItemComboBox _PrintPreviewRepositoryItemComboBox1;

	[AccessedThroughProperty("PrintPreviewBarItem16")]
	private PrintPreviewBarItem _PrintPreviewBarItem16;

	[AccessedThroughProperty("PrintPreviewBarItem17")]
	private PrintPreviewBarItem _PrintPreviewBarItem17;

	[AccessedThroughProperty("PrintPreviewBarItem18")]
	private PrintPreviewBarItem _PrintPreviewBarItem18;

	[AccessedThroughProperty("PrintPreviewBarItem19")]
	private PrintPreviewBarItem _PrintPreviewBarItem19;

	[AccessedThroughProperty("PrintPreviewBarItem20")]
	private PrintPreviewBarItem _PrintPreviewBarItem20;

	[AccessedThroughProperty("PrintPreviewBarItem21")]
	private PrintPreviewBarItem _PrintPreviewBarItem21;

	[AccessedThroughProperty("PrintPreviewBarItem22")]
	private PrintPreviewBarItem _PrintPreviewBarItem22;

	[AccessedThroughProperty("PrintPreviewBarItem23")]
	private PrintPreviewBarItem _PrintPreviewBarItem23;

	[AccessedThroughProperty("PrintPreviewBarItem24")]
	private PrintPreviewBarItem _PrintPreviewBarItem24;

	[AccessedThroughProperty("PrintPreviewBarItem25")]
	private PrintPreviewBarItem _PrintPreviewBarItem25;

	[AccessedThroughProperty("PrintPreviewBarItem26")]
	private PrintPreviewBarItem _PrintPreviewBarItem26;

	[AccessedThroughProperty("PreviewBar2")]
	private PreviewBar previewBar_1;

	[AccessedThroughProperty("PrintPreviewStaticItem1")]
	private PrintPreviewStaticItem _PrintPreviewStaticItem1;

	[AccessedThroughProperty("BarStaticItem1")]
	private BarStaticItem _BarStaticItem1;

	[AccessedThroughProperty("ProgressBarEditItem1")]
	private ProgressBarEditItem _ProgressBarEditItem1;

	[AccessedThroughProperty("RepositoryItemProgressBar1")]
	private RepositoryItemProgressBar _RepositoryItemProgressBar1;

	[AccessedThroughProperty("PrintPreviewBarItem1")]
	private PrintPreviewBarItem _PrintPreviewBarItem1;

	[AccessedThroughProperty("BarButtonItem1")]
	private BarButtonItem _BarButtonItem1;

	[AccessedThroughProperty("PrintPreviewStaticItem2")]
	private PrintPreviewStaticItem _PrintPreviewStaticItem2;

	[AccessedThroughProperty("ZoomTrackBarEditItem1")]
	private ZoomTrackBarEditItem _ZoomTrackBarEditItem1;

	[AccessedThroughProperty("RepositoryItemZoomTrackBar1")]
	private RepositoryItemZoomTrackBar _RepositoryItemZoomTrackBar1;

	[AccessedThroughProperty("PreviewBar3")]
	private PreviewBar previewBar_2;

	[AccessedThroughProperty("PrintPreviewSubItem1")]
	private PrintPreviewSubItem _PrintPreviewSubItem1;

	[AccessedThroughProperty("PrintPreviewSubItem2")]
	private PrintPreviewSubItem _PrintPreviewSubItem2;

	[AccessedThroughProperty("PrintPreviewSubItem4")]
	private PrintPreviewSubItem _PrintPreviewSubItem4;

	[AccessedThroughProperty("PrintPreviewBarItem27")]
	private PrintPreviewBarItem _PrintPreviewBarItem27;

	[AccessedThroughProperty("PrintPreviewBarItem28")]
	private PrintPreviewBarItem _PrintPreviewBarItem28;

	[AccessedThroughProperty("BarToolbarsListItem1")]
	private BarToolbarsListItem _BarToolbarsListItem1;

	[AccessedThroughProperty("PrintPreviewSubItem3")]
	private PrintPreviewSubItem _PrintPreviewSubItem3;

	[AccessedThroughProperty("barDockControlTop")]
	private BarDockControl barDockControl_0;

	[AccessedThroughProperty("barDockControlBottom")]
	private BarDockControl barDockControl_1;

	[AccessedThroughProperty("barDockControlLeft")]
	private BarDockControl barDockControl_2;

	[AccessedThroughProperty("barDockControlRight")]
	private BarDockControl barDockControl_3;

	[AccessedThroughProperty("PrintPreviewBarCheckItem1")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem1;

	[AccessedThroughProperty("PrintPreviewBarCheckItem2")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem2;

	[AccessedThroughProperty("PrintPreviewBarCheckItem3")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem3;

	[AccessedThroughProperty("PrintPreviewBarCheckItem4")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem4;

	[AccessedThroughProperty("PrintPreviewBarCheckItem5")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem5;

	[AccessedThroughProperty("PrintPreviewBarCheckItem6")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem6;

	[AccessedThroughProperty("PrintPreviewBarCheckItem7")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem7;

	[AccessedThroughProperty("PrintPreviewBarCheckItem8")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem8;

	[AccessedThroughProperty("PrintPreviewBarCheckItem9")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem9;

	[AccessedThroughProperty("PrintPreviewBarCheckItem10")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem10;

	[AccessedThroughProperty("PrintPreviewBarCheckItem11")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem11;

	[AccessedThroughProperty("PrintPreviewBarCheckItem12")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem12;

	[AccessedThroughProperty("PrintPreviewBarCheckItem13")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem13;

	[AccessedThroughProperty("PrintPreviewBarCheckItem14")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem14;

	[AccessedThroughProperty("PrintPreviewBarCheckItem15")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem15;

	[AccessedThroughProperty("PrintPreviewBarCheckItem16")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem16;

	[AccessedThroughProperty("PrintPreviewBarCheckItem17")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem17;

	internal virtual PrintDialog PrintDialog_0
	{
		[DebuggerNonUserCode]
		get
		{
			return printDialog_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			printDialog_0 = value;
		}
	}

	internal virtual PrintControl PrintControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PrintControl1_Load;
			if (_PrintControl1 != null)
			{
				((UserControl)_PrintControl1).remove_Load(eventHandler);
			}
			_PrintControl1 = value;
			if (_PrintControl1 != null)
			{
				((UserControl)_PrintControl1).add_Load(eventHandler);
			}
		}
	}

	internal virtual PrintBarManager PrintBarManager_0
	{
		[DebuggerNonUserCode]
		get
		{
			return printBarManager_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			printBarManager_0 = value;
		}
	}

	internal virtual PreviewBar PreviewBar_0
	{
		[DebuggerNonUserCode]
		get
		{
			return previewBar_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			previewBar_0 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem2 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem3 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem4
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem4 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem5
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem5 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem6
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem6 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem7
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem7 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem8
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem8 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem9
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem9 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem10
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem10 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem11
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem11 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem12
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem12 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem13
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem13 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem14
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem14 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem15
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem15 = value;
		}
	}

	internal virtual ZoomBarEditItem ZoomBarEditItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ZoomBarEditItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ZoomBarEditItem1 = value;
		}
	}

	internal virtual PrintPreviewRepositoryItemComboBox PrintPreviewRepositoryItemComboBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewRepositoryItemComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewRepositoryItemComboBox1 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem16
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem16 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem17
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem17 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem18
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem18 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem19
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem19 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem20
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem20 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem21
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem21 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem22
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem22 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem23
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem23 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem24
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem24 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem25
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem25 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem26
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem26 = value;
		}
	}

	internal virtual PreviewBar PreviewBar_1
	{
		[DebuggerNonUserCode]
		get
		{
			return previewBar_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			previewBar_1 = value;
		}
	}

	internal virtual PrintPreviewStaticItem PrintPreviewStaticItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewStaticItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewStaticItem1 = value;
		}
	}

	internal virtual BarStaticItem BarStaticItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BarStaticItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BarStaticItem1 = value;
		}
	}

	internal virtual ProgressBarEditItem ProgressBarEditItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBarEditItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBarEditItem1 = value;
		}
	}

	internal virtual RepositoryItemProgressBar RepositoryItemProgressBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RepositoryItemProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RepositoryItemProgressBar1 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem1 = value;
		}
	}

	internal virtual BarButtonItem BarButtonItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BarButtonItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BarButtonItem1 = value;
		}
	}

	internal virtual PrintPreviewStaticItem PrintPreviewStaticItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewStaticItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewStaticItem2 = value;
		}
	}

	internal virtual ZoomTrackBarEditItem ZoomTrackBarEditItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ZoomTrackBarEditItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ZoomTrackBarEditItem1 = value;
		}
	}

	internal virtual RepositoryItemZoomTrackBar RepositoryItemZoomTrackBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RepositoryItemZoomTrackBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RepositoryItemZoomTrackBar1 = value;
		}
	}

	internal virtual PreviewBar PreviewBar_2
	{
		[DebuggerNonUserCode]
		get
		{
			return previewBar_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			previewBar_2 = value;
		}
	}

	internal virtual PrintPreviewSubItem PrintPreviewSubItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewSubItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewSubItem1 = value;
		}
	}

	internal virtual PrintPreviewSubItem PrintPreviewSubItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewSubItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewSubItem2 = value;
		}
	}

	internal virtual PrintPreviewSubItem PrintPreviewSubItem4
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewSubItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewSubItem4 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem27
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem27 = value;
		}
	}

	internal virtual PrintPreviewBarItem PrintPreviewBarItem28
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem28 = value;
		}
	}

	internal virtual BarToolbarsListItem BarToolbarsListItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BarToolbarsListItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BarToolbarsListItem1 = value;
		}
	}

	internal virtual PrintPreviewSubItem PrintPreviewSubItem3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewSubItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewSubItem3 = value;
		}
	}

	internal virtual BarDockControl BarDockControl_0
	{
		[DebuggerNonUserCode]
		get
		{
			return barDockControl_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			barDockControl_0 = value;
		}
	}

	internal virtual BarDockControl BarDockControl_1
	{
		[DebuggerNonUserCode]
		get
		{
			return barDockControl_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			barDockControl_1 = value;
		}
	}

	internal virtual BarDockControl BarDockControl_2
	{
		[DebuggerNonUserCode]
		get
		{
			return barDockControl_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			barDockControl_2 = value;
		}
	}

	internal virtual BarDockControl BarDockControl_3
	{
		[DebuggerNonUserCode]
		get
		{
			return barDockControl_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			barDockControl_3 = value;
		}
	}

	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem1 = value;
		}
	}

	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem2 = value;
		}
	}

	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem3 = value;
		}
	}

	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem4
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem4 = value;
		}
	}

	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem5
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem5 = value;
		}
	}

	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem6
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem6 = value;
		}
	}

	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem7
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem7 = value;
		}
	}

	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem8
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem8 = value;
		}
	}

	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem9
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem9 = value;
		}
	}

	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem10
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem10 = value;
		}
	}

	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem11
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem11 = value;
		}
	}

	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem12
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem12 = value;
		}
	}

	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem13
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem13 = value;
		}
	}

	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem14
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem14 = value;
		}
	}

	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem15
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem15 = value;
		}
	}

	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem16
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem16 = value;
		}
	}

	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem17
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem17 = value;
		}
	}

	[DebuggerNonUserCode]
	public frmPrintReport()
	{
		smethod_0(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		checked
		{
			lock (list_0)
			{
				if (list_0.Count == list_0.Capacity)
				{
					int num = 0;
					int num2 = list_0.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = list_0[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								list_0[num] = list_0[num3];
							}
							num++;
						}
						num3++;
					}
					list_0.RemoveRange(num, list_0.Count - num);
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && icontainer_0 != null) ? true : false)
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
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
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Expected O, but got Unknown
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Expected O, but got Unknown
		//IL_0965: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Expected O, but got Unknown
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Expected O, but got Unknown
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Expected O, but got Unknown
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_099a: Expected O, but got Unknown
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Expected O, but got Unknown
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b9: Expected O, but got Unknown
		//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Expected O, but got Unknown
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Expected O, but got Unknown
		//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e8: Expected O, but got Unknown
		//IL_09f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Expected O, but got Unknown
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a09: Expected O, but got Unknown
		//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1a: Expected O, but got Unknown
		//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Expected O, but got Unknown
		//IL_0a34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Expected O, but got Unknown
		//IL_0a45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4b: Expected O, but got Unknown
		//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5b: Expected O, but got Unknown
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6b: Expected O, but got Unknown
		//IL_0a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7b: Expected O, but got Unknown
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8c: Expected O, but got Unknown
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Expected O, but got Unknown
		//IL_0aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aac: Expected O, but got Unknown
		//IL_0ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abd: Expected O, but got Unknown
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acd: Expected O, but got Unknown
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ade: Expected O, but got Unknown
		//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Expected O, but got Unknown
		//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b68: Expected O, but got Unknown
		//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Expected O, but got Unknown
		//IL_0b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected O, but got Unknown
		//IL_0b8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b95: Expected O, but got Unknown
		//IL_0b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba5: Expected O, but got Unknown
		//IL_0bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb4: Expected O, but got Unknown
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c54: Expected O, but got Unknown
		//IL_0c5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c63: Expected O, but got Unknown
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c72: Expected O, but got Unknown
		//IL_15f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f7: Expected O, but got Unknown
		//IL_1acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad5: Expected O, but got Unknown
		//IL_1ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae4: Expected O, but got Unknown
		//IL_1aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af3: Expected O, but got Unknown
		//IL_1afd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b03: Expected O, but got Unknown
		//IL_1b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b12: Expected O, but got Unknown
		//IL_1b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b22: Expected O, but got Unknown
		//IL_1b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b86: Expected O, but got Unknown
		//IL_1b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b96: Expected O, but got Unknown
		//IL_1bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf9: Expected O, but got Unknown
		//IL_1c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c08: Expected O, but got Unknown
		//IL_1c65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6b: Expected O, but got Unknown
		//IL_1c74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7a: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmPrintReport));
		PrintDialog_0 = new PrintDialog();
		PrintControl1 = new PrintControl();
		PrintBarManager_0 = new PrintBarManager(icontainer_0);
		BarDockControl_0 = new BarDockControl();
		BarDockControl_1 = new BarDockControl();
		BarDockControl_2 = new BarDockControl();
		BarDockControl_3 = new BarDockControl();
		PreviewBar_0 = new PreviewBar();
		PreviewBar_1 = new PreviewBar();
		PreviewBar_2 = new PreviewBar();
		PrintPreviewStaticItem1 = new PrintPreviewStaticItem();
		BarStaticItem1 = new BarStaticItem();
		RepositoryItemProgressBar1 = new RepositoryItemProgressBar();
		ProgressBarEditItem1 = new ProgressBarEditItem();
		PrintPreviewBarItem1 = new PrintPreviewBarItem();
		BarButtonItem1 = new BarButtonItem();
		PrintPreviewStaticItem2 = new PrintPreviewStaticItem();
		RepositoryItemZoomTrackBar1 = new RepositoryItemZoomTrackBar();
		ZoomTrackBarEditItem1 = new ZoomTrackBarEditItem();
		PrintPreviewBarItem2 = new PrintPreviewBarItem();
		PrintPreviewBarItem3 = new PrintPreviewBarItem();
		PrintPreviewBarItem4 = new PrintPreviewBarItem();
		PrintPreviewBarItem5 = new PrintPreviewBarItem();
		PrintPreviewBarItem6 = new PrintPreviewBarItem();
		PrintPreviewBarItem7 = new PrintPreviewBarItem();
		PrintPreviewBarItem8 = new PrintPreviewBarItem();
		PrintPreviewBarItem9 = new PrintPreviewBarItem();
		PrintPreviewBarItem10 = new PrintPreviewBarItem();
		PrintPreviewBarItem11 = new PrintPreviewBarItem();
		PrintPreviewBarItem12 = new PrintPreviewBarItem();
		PrintPreviewBarItem13 = new PrintPreviewBarItem();
		PrintPreviewBarItem14 = new PrintPreviewBarItem();
		PrintPreviewBarItem15 = new PrintPreviewBarItem();
		ZoomBarEditItem1 = new ZoomBarEditItem();
		PrintPreviewRepositoryItemComboBox1 = new PrintPreviewRepositoryItemComboBox();
		PrintPreviewBarItem16 = new PrintPreviewBarItem();
		PrintPreviewBarItem17 = new PrintPreviewBarItem();
		PrintPreviewBarItem18 = new PrintPreviewBarItem();
		PrintPreviewBarItem19 = new PrintPreviewBarItem();
		PrintPreviewBarItem20 = new PrintPreviewBarItem();
		PrintPreviewBarItem21 = new PrintPreviewBarItem();
		PrintPreviewBarItem22 = new PrintPreviewBarItem();
		PrintPreviewBarItem23 = new PrintPreviewBarItem();
		PrintPreviewBarItem24 = new PrintPreviewBarItem();
		PrintPreviewBarItem25 = new PrintPreviewBarItem();
		PrintPreviewBarItem26 = new PrintPreviewBarItem();
		PrintPreviewSubItem1 = new PrintPreviewSubItem();
		PrintPreviewSubItem2 = new PrintPreviewSubItem();
		PrintPreviewSubItem3 = new PrintPreviewSubItem();
		PrintPreviewSubItem4 = new PrintPreviewSubItem();
		PrintPreviewBarItem27 = new PrintPreviewBarItem();
		PrintPreviewBarItem28 = new PrintPreviewBarItem();
		BarToolbarsListItem1 = new BarToolbarsListItem();
		PrintPreviewBarCheckItem1 = new PrintPreviewBarCheckItem();
		PrintPreviewBarCheckItem2 = new PrintPreviewBarCheckItem();
		PrintPreviewBarCheckItem3 = new PrintPreviewBarCheckItem();
		PrintPreviewBarCheckItem4 = new PrintPreviewBarCheckItem();
		PrintPreviewBarCheckItem5 = new PrintPreviewBarCheckItem();
		PrintPreviewBarCheckItem6 = new PrintPreviewBarCheckItem();
		PrintPreviewBarCheckItem7 = new PrintPreviewBarCheckItem();
		PrintPreviewBarCheckItem8 = new PrintPreviewBarCheckItem();
		PrintPreviewBarCheckItem9 = new PrintPreviewBarCheckItem();
		PrintPreviewBarCheckItem10 = new PrintPreviewBarCheckItem();
		PrintPreviewBarCheckItem11 = new PrintPreviewBarCheckItem();
		PrintPreviewBarCheckItem12 = new PrintPreviewBarCheckItem();
		PrintPreviewBarCheckItem13 = new PrintPreviewBarCheckItem();
		PrintPreviewBarCheckItem14 = new PrintPreviewBarCheckItem();
		PrintPreviewBarCheckItem15 = new PrintPreviewBarCheckItem();
		PrintPreviewBarCheckItem16 = new PrintPreviewBarCheckItem();
		PrintPreviewBarCheckItem17 = new PrintPreviewBarCheckItem();
		((ISupportInitialize)PrintBarManager_0).BeginInit();
		((ISupportInitialize)RepositoryItemProgressBar1).BeginInit();
		((ISupportInitialize)RepositoryItemZoomTrackBar1).BeginInit();
		((ISupportInitialize)PrintPreviewRepositoryItemComboBox1).BeginInit();
		((Control)this).SuspendLayout();
		PrintDialog_0.set_UseEXDialog(true);
		PrintControl1.set_BackColor(Color.Empty);
		((Control)PrintControl1).set_Dock((DockStyle)5);
		PrintControl1.set_ForeColor(Color.Empty);
		PrintControl1.set_IsMetric(true);
		PrintControl printControl = PrintControl1;
		Point location = new Point(0, 53);
		((Control)printControl).set_Location(location);
		((Control)PrintControl1).set_Name("PrintControl1");
		PrintControl printControl2 = PrintControl1;
		Size size = new Size(787, 445);
		((Control)printControl2).set_Size(size);
		((Control)PrintControl1).set_TabIndex(6);
		PrintControl1.set_TooltipFont(new Font("Tahoma", 9f));
		((BarManager)PrintBarManager_0).get_Bars().AddRange((Bar[])(object)new Bar[3]
		{
			(Bar)PreviewBar_0,
			(Bar)PreviewBar_1,
			(Bar)PreviewBar_2
		});
		((BarManager)PrintBarManager_0).get_DockControls().Add(BarDockControl_0);
		((BarManager)PrintBarManager_0).get_DockControls().Add(BarDockControl_1);
		((BarManager)PrintBarManager_0).get_DockControls().Add(BarDockControl_2);
		((BarManager)PrintBarManager_0).get_DockControls().Add(BarDockControl_3);
		((BarManager)PrintBarManager_0).set_Form((Control)(object)this);
		PrintBarManager_0.set_ImageStream((ImageCollectionStreamer)componentResourceManager.GetObject("PrintBarManager1.ImageStream"));
		((BarManager)PrintBarManager_0).get_Items().AddRange((BarItem[])(object)new BarItem[57]
		{
			(BarItem)PrintPreviewStaticItem1,
			(BarItem)BarStaticItem1,
			(BarItem)ProgressBarEditItem1,
			(BarItem)PrintPreviewBarItem1,
			(BarItem)BarButtonItem1,
			(BarItem)PrintPreviewStaticItem2,
			(BarItem)ZoomTrackBarEditItem1,
			(BarItem)PrintPreviewBarItem2,
			(BarItem)PrintPreviewBarItem3,
			(BarItem)PrintPreviewBarItem4,
			(BarItem)PrintPreviewBarItem5,
			(BarItem)PrintPreviewBarItem6,
			(BarItem)PrintPreviewBarItem7,
			(BarItem)PrintPreviewBarItem8,
			(BarItem)PrintPreviewBarItem9,
			(BarItem)PrintPreviewBarItem10,
			(BarItem)PrintPreviewBarItem11,
			(BarItem)PrintPreviewBarItem12,
			(BarItem)PrintPreviewBarItem13,
			(BarItem)PrintPreviewBarItem14,
			(BarItem)PrintPreviewBarItem15,
			(BarItem)ZoomBarEditItem1,
			(BarItem)PrintPreviewBarItem16,
			(BarItem)PrintPreviewBarItem17,
			(BarItem)PrintPreviewBarItem18,
			(BarItem)PrintPreviewBarItem19,
			(BarItem)PrintPreviewBarItem20,
			(BarItem)PrintPreviewBarItem21,
			(BarItem)PrintPreviewBarItem22,
			(BarItem)PrintPreviewBarItem23,
			(BarItem)PrintPreviewBarItem24,
			(BarItem)PrintPreviewBarItem25,
			(BarItem)PrintPreviewBarItem26,
			(BarItem)PrintPreviewSubItem1,
			(BarItem)PrintPreviewSubItem2,
			(BarItem)PrintPreviewSubItem3,
			(BarItem)PrintPreviewSubItem4,
			(BarItem)PrintPreviewBarItem27,
			(BarItem)PrintPreviewBarItem28,
			(BarItem)BarToolbarsListItem1,
			(BarItem)PrintPreviewBarCheckItem1,
			(BarItem)PrintPreviewBarCheckItem2,
			(BarItem)PrintPreviewBarCheckItem3,
			(BarItem)PrintPreviewBarCheckItem4,
			(BarItem)PrintPreviewBarCheckItem5,
			(BarItem)PrintPreviewBarCheckItem6,
			(BarItem)PrintPreviewBarCheckItem7,
			(BarItem)PrintPreviewBarCheckItem8,
			(BarItem)PrintPreviewBarCheckItem9,
			(BarItem)PrintPreviewBarCheckItem10,
			(BarItem)PrintPreviewBarCheckItem11,
			(BarItem)PrintPreviewBarCheckItem12,
			(BarItem)PrintPreviewBarCheckItem13,
			(BarItem)PrintPreviewBarCheckItem14,
			(BarItem)PrintPreviewBarCheckItem15,
			(BarItem)PrintPreviewBarCheckItem16,
			(BarItem)PrintPreviewBarCheckItem17
		});
		((BarManager)PrintBarManager_0).set_MainMenu((Bar)(object)PreviewBar_2);
		((BarManager)PrintBarManager_0).set_MaxItemId(57);
		PrintBarManager_0.set_PreviewBar((Bar)(object)PreviewBar_0);
		PrintBarManager_0.set_PrintControl(PrintControl1);
		((ComponentEditorContainer)PrintBarManager_0).get_RepositoryItems().AddRange((RepositoryItem[])(object)new RepositoryItem[3]
		{
			(RepositoryItem)RepositoryItemProgressBar1,
			(RepositoryItem)RepositoryItemZoomTrackBar1,
			(RepositoryItem)PrintPreviewRepositoryItemComboBox1
		});
		((BarManager)PrintBarManager_0).set_StatusBar((Bar)(object)PreviewBar_1);
		((BarManager)PrintBarManager_0).set_TransparentEditors(true);
		((Control)BarDockControl_0).set_CausesValidation(false);
		BarDockControl_0.set_Dock((DockStyle)1);
		BarDockControl obj = BarDockControl_0;
		location = new Point(0, 0);
		obj.set_Location(location);
		BarDockControl obj2 = BarDockControl_0;
		size = new Size(787, 53);
		obj2.set_Size(size);
		((Control)BarDockControl_1).set_CausesValidation(false);
		BarDockControl_1.set_Dock((DockStyle)2);
		BarDockControl obj3 = BarDockControl_1;
		location = new Point(0, 498);
		obj3.set_Location(location);
		BarDockControl obj4 = BarDockControl_1;
		size = new Size(787, 28);
		obj4.set_Size(size);
		((Control)BarDockControl_2).set_CausesValidation(false);
		BarDockControl_2.set_Dock((DockStyle)3);
		BarDockControl obj5 = BarDockControl_2;
		location = new Point(0, 53);
		obj5.set_Location(location);
		BarDockControl obj6 = BarDockControl_2;
		size = new Size(0, 445);
		obj6.set_Size(size);
		((Control)BarDockControl_3).set_CausesValidation(false);
		BarDockControl_3.set_Dock((DockStyle)4);
		BarDockControl obj7 = BarDockControl_3;
		location = new Point(787, 53);
		obj7.set_Location(location);
		BarDockControl obj8 = BarDockControl_3;
		size = new Size(0, 445);
		obj8.set_Size(size);
		((Bar)PreviewBar_0).set_BarName("Toolbar");
		((Bar)PreviewBar_0).set_DockCol(0);
		((Bar)PreviewBar_0).set_DockRow(1);
		((Bar)PreviewBar_0).set_DockStyle((BarDockStyle)2);
		((Bar)PreviewBar_0).get_LinksPersistInfo().AddRange((LinkPersistInfo[])(object)new LinkPersistInfo[26]
		{
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem2),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem3),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem4),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem5, true),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem6, true),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem7),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem8, true),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem9),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem10),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem11),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem12),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem13, true),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem14),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem15, true),
			new LinkPersistInfo((BarItem)(object)ZoomBarEditItem1),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem16),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem17, true),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem18),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem19),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem20),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem21, true),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem22),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem23),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem24, true),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem25),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem26, true)
		});
		PreviewBar_0.set_Text("Toolbar");
		((Bar)PreviewBar_1).set_BarName("Status Bar");
		((Bar)PreviewBar_1).set_CanDockStyle((BarCanDockStyle)16);
		((Bar)PreviewBar_1).set_DockCol(0);
		((Bar)PreviewBar_1).set_DockRow(0);
		((Bar)PreviewBar_1).set_DockStyle((BarDockStyle)4);
		((Bar)PreviewBar_1).get_LinksPersistInfo().AddRange((LinkPersistInfo[])(object)new LinkPersistInfo[7]
		{
			new LinkPersistInfo((BarItem)(object)PrintPreviewStaticItem1),
			new LinkPersistInfo((BarItem)(object)BarStaticItem1, true),
			new LinkPersistInfo((BarItem)(object)ProgressBarEditItem1),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem1),
			new LinkPersistInfo((BarItem)(object)BarButtonItem1),
			new LinkPersistInfo((BarItem)(object)PrintPreviewStaticItem2, true),
			new LinkPersistInfo((BarItem)(object)ZoomTrackBarEditItem1)
		});
		((Bar)PreviewBar_1).get_OptionsBar().set_AllowQuickCustomization(false);
		((Bar)PreviewBar_1).get_OptionsBar().set_DrawDragBorder(false);
		((Bar)PreviewBar_1).get_OptionsBar().set_UseWholeRow(true);
		PreviewBar_1.set_Text("Status Bar");
		((Bar)PreviewBar_2).set_BarName("Main Menu");
		((Bar)PreviewBar_2).set_DockCol(0);
		((Bar)PreviewBar_2).set_DockRow(0);
		((Bar)PreviewBar_2).set_DockStyle((BarDockStyle)2);
		((Bar)PreviewBar_2).get_LinksPersistInfo().AddRange((LinkPersistInfo[])(object)new LinkPersistInfo[3]
		{
			new LinkPersistInfo((BarItem)(object)PrintPreviewSubItem1),
			new LinkPersistInfo((BarItem)(object)PrintPreviewSubItem2),
			new LinkPersistInfo((BarItem)(object)PrintPreviewSubItem3)
		});
		((Bar)PreviewBar_2).get_OptionsBar().set_MultiLine(true);
		((Bar)PreviewBar_2).get_OptionsBar().set_UseWholeRow(true);
		PreviewBar_2.set_Text("Main Menu");
		((BarItem)PrintPreviewStaticItem1).set_Border((BorderStyles)0);
		((BarItem)PrintPreviewStaticItem1).set_Caption("Nothing");
		((BarItem)PrintPreviewStaticItem1).set_Id(0);
		((BarStaticItem)PrintPreviewStaticItem1).set_LeftIndent(1);
		((BarItem)PrintPreviewStaticItem1).set_Name("PrintPreviewStaticItem1");
		((BarStaticItem)PrintPreviewStaticItem1).set_RightIndent(1);
		((BarStaticItem)PrintPreviewStaticItem1).set_TextAlignment((StringAlignment)0);
		PrintPreviewStaticItem1.set_Type("PageOfPages");
		((BarItem)BarStaticItem1).set_Border((BorderStyles)0);
		((BarItem)BarStaticItem1).set_Id(1);
		((BarItem)BarStaticItem1).set_Name("BarStaticItem1");
		BarStaticItem1.set_TextAlignment((StringAlignment)0);
		((BarItem)BarStaticItem1).set_Visibility((BarItemVisibility)3);
		((RepositoryItem)RepositoryItemProgressBar1).set_Name("RepositoryItemProgressBar1");
		((BarEditItem)ProgressBarEditItem1).set_Edit((RepositoryItem)(object)RepositoryItemProgressBar1);
		((BarEditItem)ProgressBarEditItem1).set_EditHeight(12);
		((BarItem)ProgressBarEditItem1).set_Id(2);
		((BarItem)ProgressBarEditItem1).set_Name("ProgressBarEditItem1");
		((BarItem)ProgressBarEditItem1).set_Visibility((BarItemVisibility)1);
		((BarEditItem)ProgressBarEditItem1).set_Width(150);
		((BarItem)PrintPreviewBarItem1).set_Caption("Stop");
		PrintPreviewBarItem1.set_Command((PrintingSystemCommand)64);
		((BarItem)PrintPreviewBarItem1).set_Enabled(false);
		((BarItem)PrintPreviewBarItem1).set_Hint("Stop");
		((BarItem)PrintPreviewBarItem1).set_Id(3);
		((BarItem)PrintPreviewBarItem1).set_Name("PrintPreviewBarItem1");
		((BarItem)PrintPreviewBarItem1).set_Visibility((BarItemVisibility)1);
		((BarItem)BarButtonItem1).set_Alignment((BarItemLinkAlignment)1);
		((BarItem)BarButtonItem1).set_Enabled(false);
		((BarItem)BarButtonItem1).set_Id(4);
		((BarItem)BarButtonItem1).set_Name("BarButtonItem1");
		((BarItem)BarButtonItem1).set_Visibility((BarItemVisibility)3);
		((BarItem)PrintPreviewStaticItem2).set_Alignment((BarItemLinkAlignment)2);
		((BarItem)PrintPreviewStaticItem2).set_Border((BorderStyles)0);
		((BarItem)PrintPreviewStaticItem2).set_Caption("100%");
		((BarItem)PrintPreviewStaticItem2).set_Id(5);
		((BarItem)PrintPreviewStaticItem2).set_Name("PrintPreviewStaticItem2");
		((BarStaticItem)PrintPreviewStaticItem2).set_TextAlignment((StringAlignment)2);
		PrintPreviewStaticItem2.set_Type("ZoomFactor");
		((BarStaticItem)PrintPreviewStaticItem2).set_Width(40);
		((RepositoryItemTrackBar)RepositoryItemZoomTrackBar1).set_Alignment((VertAlignment)2);
		((RepositoryItem)RepositoryItemZoomTrackBar1).set_AllowFocused(false);
		((RepositoryItem)RepositoryItemZoomTrackBar1).set_BorderStyle((BorderStyles)0);
		RepositoryItemZoomTrackBar1.set_Maximum(180);
		RepositoryItemZoomTrackBar1.set_Middle(5);
		((RepositoryItem)RepositoryItemZoomTrackBar1).set_Name("RepositoryItemZoomTrackBar1");
		RepositoryItemZoomTrackBar1.set_ScrollThumbStyle((ScrollThumbStyle)1);
		((BarItem)ZoomTrackBarEditItem1).set_Alignment((BarItemLinkAlignment)2);
		((BarEditItem)ZoomTrackBarEditItem1).set_Edit((RepositoryItem)(object)RepositoryItemZoomTrackBar1);
		((BarEditItem)ZoomTrackBarEditItem1).set_EditValue((object)90);
		((BarItem)ZoomTrackBarEditItem1).set_Enabled(false);
		((BarItem)ZoomTrackBarEditItem1).set_Id(6);
		((BarItem)ZoomTrackBarEditItem1).set_Name("ZoomTrackBarEditItem1");
		ZoomTrackBarEditItem1.set_Range(new int[2] { 10, 500 });
		((BarEditItem)ZoomTrackBarEditItem1).set_Width(140);
		((BarButtonItem)PrintPreviewBarItem2).set_ButtonStyle((BarButtonStyle)2);
		((BarItem)PrintPreviewBarItem2).set_Caption("Document Map");
		PrintPreviewBarItem2.set_Command((PrintingSystemCommand)1);
		((BarItem)PrintPreviewBarItem2).set_Enabled(false);
		((BarItem)PrintPreviewBarItem2).set_Hint("Document Map");
		((BarItem)PrintPreviewBarItem2).set_Id(7);
		((BarItem)PrintPreviewBarItem2).set_ImageIndex(19);
		((BarItem)PrintPreviewBarItem2).set_Name("PrintPreviewBarItem2");
		((BarButtonItem)PrintPreviewBarItem3).set_ButtonStyle((BarButtonStyle)2);
		((BarItem)PrintPreviewBarItem3).set_Caption("Parameters");
		PrintPreviewBarItem3.set_Command((PrintingSystemCommand)2);
		((BarItem)PrintPreviewBarItem3).set_Enabled(false);
		((BarItem)PrintPreviewBarItem3).set_Hint("Parameters");
		((BarItem)PrintPreviewBarItem3).set_Id(8);
		((BarItem)PrintPreviewBarItem3).set_ImageIndex(22);
		((BarItem)PrintPreviewBarItem3).set_Name("PrintPreviewBarItem3");
		((BarItem)PrintPreviewBarItem4).set_Caption("Search");
		PrintPreviewBarItem4.set_Command((PrintingSystemCommand)24);
		((BarItem)PrintPreviewBarItem4).set_Enabled(false);
		((BarItem)PrintPreviewBarItem4).set_Hint("Search");
		((BarItem)PrintPreviewBarItem4).set_Id(9);
		((BarItem)PrintPreviewBarItem4).set_ImageIndex(20);
		((BarItem)PrintPreviewBarItem4).set_Name("PrintPreviewBarItem4");
		((BarItem)PrintPreviewBarItem5).set_Caption("Customize");
		PrintPreviewBarItem5.set_Command((PrintingSystemCommand)5);
		((BarItem)PrintPreviewBarItem5).set_Enabled(false);
		((BarItem)PrintPreviewBarItem5).set_Hint("Customize");
		((BarItem)PrintPreviewBarItem5).set_Id(10);
		((BarItem)PrintPreviewBarItem5).set_ImageIndex(14);
		((BarItem)PrintPreviewBarItem5).set_Name("PrintPreviewBarItem5");
		((BarItem)PrintPreviewBarItem6).set_Caption("Open");
		PrintPreviewBarItem6.set_Command((PrintingSystemCommand)62);
		((BarItem)PrintPreviewBarItem6).set_Enabled(false);
		((BarItem)PrintPreviewBarItem6).set_Hint("Open a document");
		((BarItem)PrintPreviewBarItem6).set_Id(11);
		((BarItem)PrintPreviewBarItem6).set_ImageIndex(23);
		((BarItem)PrintPreviewBarItem6).set_Name("PrintPreviewBarItem6");
		((BarItem)PrintPreviewBarItem7).set_Caption("Save");
		PrintPreviewBarItem7.set_Command((PrintingSystemCommand)63);
		((BarItem)PrintPreviewBarItem7).set_Enabled(false);
		((BarItem)PrintPreviewBarItem7).set_Hint("Save the document");
		((BarItem)PrintPreviewBarItem7).set_Id(12);
		((BarItem)PrintPreviewBarItem7).set_ImageIndex(24);
		((BarItem)PrintPreviewBarItem7).set_Name("PrintPreviewBarItem7");
		((BarItem)PrintPreviewBarItem8).set_Caption("&Print...");
		PrintPreviewBarItem8.set_Command((PrintingSystemCommand)6);
		((BarItem)PrintPreviewBarItem8).set_Enabled(false);
		((BarItem)PrintPreviewBarItem8).set_Hint("Print");
		((BarItem)PrintPreviewBarItem8).set_Id(13);
		((BarItem)PrintPreviewBarItem8).set_ImageIndex(0);
		((BarItem)PrintPreviewBarItem8).set_Name("PrintPreviewBarItem8");
		((BarItem)PrintPreviewBarItem9).set_Caption("P&rint");
		PrintPreviewBarItem9.set_Command((PrintingSystemCommand)7);
		((BarItem)PrintPreviewBarItem9).set_Enabled(false);
		((BarItem)PrintPreviewBarItem9).set_Hint("Quick Print");
		((BarItem)PrintPreviewBarItem9).set_Id(14);
		((BarItem)PrintPreviewBarItem9).set_ImageIndex(1);
		((BarItem)PrintPreviewBarItem9).set_Name("PrintPreviewBarItem9");
		((BarItem)PrintPreviewBarItem10).set_Caption("Page Set&up...");
		PrintPreviewBarItem10.set_Command((PrintingSystemCommand)8);
		((BarItem)PrintPreviewBarItem10).set_Enabled(false);
		((BarItem)PrintPreviewBarItem10).set_Hint("Page Setup");
		((BarItem)PrintPreviewBarItem10).set_Id(15);
		((BarItem)PrintPreviewBarItem10).set_ImageIndex(2);
		((BarItem)PrintPreviewBarItem10).set_Name("PrintPreviewBarItem10");
		((BarItem)PrintPreviewBarItem11).set_Caption("Header And Footer");
		PrintPreviewBarItem11.set_Command((PrintingSystemCommand)9);
		((BarItem)PrintPreviewBarItem11).set_Enabled(false);
		((BarItem)PrintPreviewBarItem11).set_Hint("Header And Footer");
		((BarItem)PrintPreviewBarItem11).set_Id(16);
		((BarItem)PrintPreviewBarItem11).set_ImageIndex(15);
		((BarItem)PrintPreviewBarItem11).set_Name("PrintPreviewBarItem11");
		((BarButtonItem)PrintPreviewBarItem12).set_ActAsDropDown(true);
		((BarButtonItem)PrintPreviewBarItem12).set_ButtonStyle((BarButtonStyle)1);
		((BarItem)PrintPreviewBarItem12).set_Caption("Scale");
		PrintPreviewBarItem12.set_Command((PrintingSystemCommand)58);
		((BarItem)PrintPreviewBarItem12).set_Enabled(false);
		((BarItem)PrintPreviewBarItem12).set_Hint("Scale");
		((BarItem)PrintPreviewBarItem12).set_Id(17);
		((BarItem)PrintPreviewBarItem12).set_ImageIndex(25);
		((BarItem)PrintPreviewBarItem12).set_Name("PrintPreviewBarItem12");
		((BarButtonItem)PrintPreviewBarItem13).set_ButtonStyle((BarButtonStyle)2);
		((BarItem)PrintPreviewBarItem13).set_Caption("Hand Tool");
		PrintPreviewBarItem13.set_Command((PrintingSystemCommand)4);
		((BarItem)PrintPreviewBarItem13).set_Enabled(false);
		((BarItem)PrintPreviewBarItem13).set_Hint("Hand Tool");
		((BarItem)PrintPreviewBarItem13).set_Id(18);
		((BarItem)PrintPreviewBarItem13).set_ImageIndex(16);
		((BarItem)PrintPreviewBarItem13).set_Name("PrintPreviewBarItem13");
		((BarButtonItem)PrintPreviewBarItem14).set_ButtonStyle((BarButtonStyle)2);
		((BarItem)PrintPreviewBarItem14).set_Caption("Magnifier");
		PrintPreviewBarItem14.set_Command((PrintingSystemCommand)10);
		((BarItem)PrintPreviewBarItem14).set_Enabled(false);
		((BarItem)PrintPreviewBarItem14).set_Hint("Magnifier");
		((BarItem)PrintPreviewBarItem14).set_Id(19);
		((BarItem)PrintPreviewBarItem14).set_ImageIndex(3);
		((BarItem)PrintPreviewBarItem14).set_Name("PrintPreviewBarItem14");
		((BarItem)PrintPreviewBarItem15).set_Caption("Zoom Out");
		PrintPreviewBarItem15.set_Command((PrintingSystemCommand)12);
		((BarItem)PrintPreviewBarItem15).set_Enabled(false);
		((BarItem)PrintPreviewBarItem15).set_Hint("Zoom Out");
		((BarItem)PrintPreviewBarItem15).set_Id(20);
		((BarItem)PrintPreviewBarItem15).set_ImageIndex(5);
		((BarItem)PrintPreviewBarItem15).set_Name("PrintPreviewBarItem15");
		((BarItem)ZoomBarEditItem1).set_Caption("Zoom");
		((BarEditItem)ZoomBarEditItem1).set_Edit((RepositoryItem)(object)PrintPreviewRepositoryItemComboBox1);
		((ZoomBarEditItemBase)ZoomBarEditItem1).set_EditValue((object)"100%");
		((BarItem)ZoomBarEditItem1).set_Enabled(false);
		((BarItem)ZoomBarEditItem1).set_Hint("Zoom");
		((BarItem)ZoomBarEditItem1).set_Id(21);
		((BarItem)ZoomBarEditItem1).set_Name("ZoomBarEditItem1");
		((BarEditItem)ZoomBarEditItem1).set_Width(70);
		((RepositoryItemComboBox)PrintPreviewRepositoryItemComboBox1).set_AutoComplete(false);
		((RepositoryItemButtonEdit)PrintPreviewRepositoryItemComboBox1).get_Buttons().AddRange((EditorButton[])(object)new EditorButton[1]
		{
			new EditorButton((ButtonPredefines)(-5))
		});
		((RepositoryItemComboBox)PrintPreviewRepositoryItemComboBox1).set_DropDownRows(11);
		((RepositoryItem)PrintPreviewRepositoryItemComboBox1).set_Name("PrintPreviewRepositoryItemComboBox1");
		((BarItem)PrintPreviewBarItem16).set_Caption("Zoom In");
		PrintPreviewBarItem16.set_Command((PrintingSystemCommand)11);
		((BarItem)PrintPreviewBarItem16).set_Enabled(false);
		((BarItem)PrintPreviewBarItem16).set_Hint("Zoom In");
		((BarItem)PrintPreviewBarItem16).set_Id(22);
		((BarItem)PrintPreviewBarItem16).set_ImageIndex(4);
		((BarItem)PrintPreviewBarItem16).set_Name("PrintPreviewBarItem16");
		((BarItem)PrintPreviewBarItem17).set_Caption("First Page");
		PrintPreviewBarItem17.set_Command((PrintingSystemCommand)16);
		((BarItem)PrintPreviewBarItem17).set_Enabled(false);
		((BarItem)PrintPreviewBarItem17).set_Hint("First Page");
		((BarItem)PrintPreviewBarItem17).set_Id(23);
		((BarItem)PrintPreviewBarItem17).set_ImageIndex(7);
		((BarItem)PrintPreviewBarItem17).set_Name("PrintPreviewBarItem17");
		((BarItem)PrintPreviewBarItem18).set_Caption("Previous Page");
		PrintPreviewBarItem18.set_Command((PrintingSystemCommand)17);
		((BarItem)PrintPreviewBarItem18).set_Enabled(false);
		((BarItem)PrintPreviewBarItem18).set_Hint("Previous Page");
		((BarItem)PrintPreviewBarItem18).set_Id(24);
		((BarItem)PrintPreviewBarItem18).set_ImageIndex(8);
		((BarItem)PrintPreviewBarItem18).set_Name("PrintPreviewBarItem18");
		((BarItem)PrintPreviewBarItem19).set_Caption("Next Page");
		PrintPreviewBarItem19.set_Command((PrintingSystemCommand)18);
		((BarItem)PrintPreviewBarItem19).set_Enabled(false);
		((BarItem)PrintPreviewBarItem19).set_Hint("Next Page");
		((BarItem)PrintPreviewBarItem19).set_Id(25);
		((BarItem)PrintPreviewBarItem19).set_ImageIndex(9);
		((BarItem)PrintPreviewBarItem19).set_Name("PrintPreviewBarItem19");
		((BarItem)PrintPreviewBarItem20).set_Caption("Last Page");
		PrintPreviewBarItem20.set_Command((PrintingSystemCommand)21);
		((BarItem)PrintPreviewBarItem20).set_Enabled(false);
		((BarItem)PrintPreviewBarItem20).set_Hint("Last Page");
		((BarItem)PrintPreviewBarItem20).set_Id(26);
		((BarItem)PrintPreviewBarItem20).set_ImageIndex(10);
		((BarItem)PrintPreviewBarItem20).set_Name("PrintPreviewBarItem20");
		((BarButtonItem)PrintPreviewBarItem21).set_ButtonStyle((BarButtonStyle)1);
		((BarItem)PrintPreviewBarItem21).set_Caption("Multiple Pages");
		PrintPreviewBarItem21.set_Command((PrintingSystemCommand)22);
		((BarItem)PrintPreviewBarItem21).set_Enabled(false);
		((BarItem)PrintPreviewBarItem21).set_Hint("Multiple Pages");
		((BarItem)PrintPreviewBarItem21).set_Id(27);
		((BarItem)PrintPreviewBarItem21).set_ImageIndex(11);
		((BarItem)PrintPreviewBarItem21).set_Name("PrintPreviewBarItem21");
		((BarButtonItem)PrintPreviewBarItem22).set_ButtonStyle((BarButtonStyle)1);
		((BarItem)PrintPreviewBarItem22).set_Caption("&Color...");
		PrintPreviewBarItem22.set_Command((PrintingSystemCommand)23);
		((BarItem)PrintPreviewBarItem22).set_Enabled(false);
		((BarItem)PrintPreviewBarItem22).set_Hint("Background");
		((BarItem)PrintPreviewBarItem22).set_Id(28);
		((BarItem)PrintPreviewBarItem22).set_ImageIndex(12);
		((BarItem)PrintPreviewBarItem22).set_Name("PrintPreviewBarItem22");
		((BarItem)PrintPreviewBarItem23).set_Caption("&Watermark...");
		PrintPreviewBarItem23.set_Command((PrintingSystemCommand)26);
		((BarItem)PrintPreviewBarItem23).set_Enabled(false);
		((BarItem)PrintPreviewBarItem23).set_Hint("Watermark");
		((BarItem)PrintPreviewBarItem23).set_Id(29);
		((BarItem)PrintPreviewBarItem23).set_ImageIndex(21);
		((BarItem)PrintPreviewBarItem23).set_Name("PrintPreviewBarItem23");
		((BarButtonItem)PrintPreviewBarItem24).set_ButtonStyle((BarButtonStyle)1);
		((BarItem)PrintPreviewBarItem24).set_Caption("Export Document...");
		PrintPreviewBarItem24.set_Command((PrintingSystemCommand)27);
		((BarItem)PrintPreviewBarItem24).set_Enabled(false);
		((BarItem)PrintPreviewBarItem24).set_Hint("Export Document...");
		((BarItem)PrintPreviewBarItem24).set_Id(30);
		((BarItem)PrintPreviewBarItem24).set_ImageIndex(18);
		((BarItem)PrintPreviewBarItem24).set_Name("PrintPreviewBarItem24");
		((BarButtonItem)PrintPreviewBarItem25).set_ButtonStyle((BarButtonStyle)1);
		((BarItem)PrintPreviewBarItem25).set_Caption("Send via E-Mail...");
		PrintPreviewBarItem25.set_Command((PrintingSystemCommand)28);
		((BarItem)PrintPreviewBarItem25).set_Enabled(false);
		((BarItem)PrintPreviewBarItem25).set_Hint("Send via E-Mail...");
		((BarItem)PrintPreviewBarItem25).set_Id(31);
		((BarItem)PrintPreviewBarItem25).set_ImageIndex(17);
		((BarItem)PrintPreviewBarItem25).set_Name("PrintPreviewBarItem25");
		((BarItem)PrintPreviewBarItem26).set_Caption("E&xit");
		PrintPreviewBarItem26.set_Command((PrintingSystemCommand)25);
		((BarItem)PrintPreviewBarItem26).set_Enabled(false);
		((BarItem)PrintPreviewBarItem26).set_Hint("Close Preview");
		((BarItem)PrintPreviewBarItem26).set_Id(32);
		((BarItem)PrintPreviewBarItem26).set_ImageIndex(13);
		((BarItem)PrintPreviewBarItem26).set_Name("PrintPreviewBarItem26");
		((BarItem)PrintPreviewSubItem1).set_Caption("&File");
		PrintPreviewSubItem1.set_Command((PrintingSystemCommand)55);
		((BarItem)PrintPreviewSubItem1).set_Id(33);
		((BarLinkContainerItem)PrintPreviewSubItem1).get_LinksPersistInfo().AddRange((LinkPersistInfo[])(object)new LinkPersistInfo[6]
		{
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem10),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem8),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem9),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem24, true),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem25),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem26, true)
		});
		((BarItem)PrintPreviewSubItem1).set_Name("PrintPreviewSubItem1");
		((BarItem)PrintPreviewSubItem2).set_Caption("&View");
		PrintPreviewSubItem2.set_Command((PrintingSystemCommand)56);
		((BarItem)PrintPreviewSubItem2).set_Id(34);
		((BarLinkContainerItem)PrintPreviewSubItem2).get_LinksPersistInfo().AddRange((LinkPersistInfo[])(object)new LinkPersistInfo[2]
		{
			new LinkPersistInfo((BarItem)(object)PrintPreviewSubItem4, true),
			new LinkPersistInfo((BarItem)(object)BarToolbarsListItem1, true)
		});
		((BarItem)PrintPreviewSubItem2).set_Name("PrintPreviewSubItem2");
		((BarItem)PrintPreviewSubItem3).set_Caption("&Background");
		PrintPreviewSubItem3.set_Command((PrintingSystemCommand)57);
		((BarItem)PrintPreviewSubItem3).set_Id(35);
		((BarLinkContainerItem)PrintPreviewSubItem3).get_LinksPersistInfo().AddRange((LinkPersistInfo[])(object)new LinkPersistInfo[2]
		{
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem22),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem23)
		});
		((BarItem)PrintPreviewSubItem3).set_Name("PrintPreviewSubItem3");
		((BarItem)PrintPreviewSubItem4).set_Caption("&Page Layout");
		PrintPreviewSubItem4.set_Command((PrintingSystemCommand)52);
		((BarItem)PrintPreviewSubItem4).set_Id(36);
		((BarLinkContainerItem)PrintPreviewSubItem4).get_LinksPersistInfo().AddRange((LinkPersistInfo[])(object)new LinkPersistInfo[2]
		{
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem27),
			new LinkPersistInfo((BarItem)(object)PrintPreviewBarItem28)
		});
		((BarItem)PrintPreviewSubItem4).set_Name("PrintPreviewSubItem4");
		((BarButtonItem)PrintPreviewBarItem27).set_ButtonStyle((BarButtonStyle)2);
		((BarItem)PrintPreviewBarItem27).set_Caption("&Facing");
		PrintPreviewBarItem27.set_Command((PrintingSystemCommand)53);
		((BarItem)PrintPreviewBarItem27).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarItem27).set_GroupIndex(100);
		((BarItem)PrintPreviewBarItem27).set_Id(37);
		((BarItem)PrintPreviewBarItem27).set_Name("PrintPreviewBarItem27");
		((BarButtonItem)PrintPreviewBarItem28).set_ButtonStyle((BarButtonStyle)2);
		((BarItem)PrintPreviewBarItem28).set_Caption("&Continuous");
		PrintPreviewBarItem28.set_Command((PrintingSystemCommand)54);
		((BarItem)PrintPreviewBarItem28).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarItem28).set_GroupIndex(100);
		((BarItem)PrintPreviewBarItem28).set_Id(38);
		((BarItem)PrintPreviewBarItem28).set_Name("PrintPreviewBarItem28");
		((BarItem)BarToolbarsListItem1).set_Caption("Bars");
		((BarItem)BarToolbarsListItem1).set_Id(39);
		((BarItem)BarToolbarsListItem1).set_Name("BarToolbarsListItem1");
		((BarItem)PrintPreviewBarCheckItem1).set_Caption("PDF File");
		((BarCheckItem)PrintPreviewBarCheckItem1).set_Checked(true);
		PrintPreviewBarCheckItem1.set_Command((PrintingSystemCommand)30);
		((BarItem)PrintPreviewBarCheckItem1).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarCheckItem1).set_GroupIndex(2);
		((BarItem)PrintPreviewBarCheckItem1).set_Hint("PDF File");
		((BarItem)PrintPreviewBarCheckItem1).set_Id(40);
		((BarItem)PrintPreviewBarCheckItem1).set_Name("PrintPreviewBarCheckItem1");
		((BarItem)PrintPreviewBarCheckItem2).set_Caption("HTML File");
		PrintPreviewBarCheckItem2.set_Command((PrintingSystemCommand)37);
		((BarItem)PrintPreviewBarCheckItem2).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarCheckItem2).set_GroupIndex(2);
		((BarItem)PrintPreviewBarCheckItem2).set_Hint("HTML File");
		((BarItem)PrintPreviewBarCheckItem2).set_Id(41);
		((BarItem)PrintPreviewBarCheckItem2).set_Name("PrintPreviewBarCheckItem2");
		((BarItem)PrintPreviewBarCheckItem3).set_Caption("MHT File");
		PrintPreviewBarCheckItem3.set_Command((PrintingSystemCommand)33);
		((BarItem)PrintPreviewBarCheckItem3).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarCheckItem3).set_GroupIndex(2);
		((BarItem)PrintPreviewBarCheckItem3).set_Hint("MHT File");
		((BarItem)PrintPreviewBarCheckItem3).set_Id(42);
		((BarItem)PrintPreviewBarCheckItem3).set_Name("PrintPreviewBarCheckItem3");
		((BarItem)PrintPreviewBarCheckItem4).set_Caption("RTF File");
		PrintPreviewBarCheckItem4.set_Command((PrintingSystemCommand)36);
		((BarItem)PrintPreviewBarCheckItem4).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarCheckItem4).set_GroupIndex(2);
		((BarItem)PrintPreviewBarCheckItem4).set_Hint("RTF File");
		((BarItem)PrintPreviewBarCheckItem4).set_Id(43);
		((BarItem)PrintPreviewBarCheckItem4).set_Name("PrintPreviewBarCheckItem4");
		((BarItem)PrintPreviewBarCheckItem5).set_Caption("XLS File");
		PrintPreviewBarCheckItem5.set_Command((PrintingSystemCommand)34);
		((BarItem)PrintPreviewBarCheckItem5).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarCheckItem5).set_GroupIndex(2);
		((BarItem)PrintPreviewBarCheckItem5).set_Hint("XLS File");
		((BarItem)PrintPreviewBarCheckItem5).set_Id(44);
		((BarItem)PrintPreviewBarCheckItem5).set_Name("PrintPreviewBarCheckItem5");
		((BarItem)PrintPreviewBarCheckItem6).set_Caption("XLSX File");
		PrintPreviewBarCheckItem6.set_Command((PrintingSystemCommand)35);
		((BarItem)PrintPreviewBarCheckItem6).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarCheckItem6).set_GroupIndex(2);
		((BarItem)PrintPreviewBarCheckItem6).set_Hint("XLSX File");
		((BarItem)PrintPreviewBarCheckItem6).set_Id(45);
		((BarItem)PrintPreviewBarCheckItem6).set_Name("PrintPreviewBarCheckItem6");
		((BarItem)PrintPreviewBarCheckItem7).set_Caption("CSV File");
		PrintPreviewBarCheckItem7.set_Command((PrintingSystemCommand)32);
		((BarItem)PrintPreviewBarCheckItem7).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarCheckItem7).set_GroupIndex(2);
		((BarItem)PrintPreviewBarCheckItem7).set_Hint("CSV File");
		((BarItem)PrintPreviewBarCheckItem7).set_Id(46);
		((BarItem)PrintPreviewBarCheckItem7).set_Name("PrintPreviewBarCheckItem7");
		((BarItem)PrintPreviewBarCheckItem8).set_Caption("Text File");
		PrintPreviewBarCheckItem8.set_Command((PrintingSystemCommand)31);
		((BarItem)PrintPreviewBarCheckItem8).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarCheckItem8).set_GroupIndex(2);
		((BarItem)PrintPreviewBarCheckItem8).set_Hint("Text File");
		((BarItem)PrintPreviewBarCheckItem8).set_Id(47);
		((BarItem)PrintPreviewBarCheckItem8).set_Name("PrintPreviewBarCheckItem8");
		((BarItem)PrintPreviewBarCheckItem9).set_Caption("Image File");
		PrintPreviewBarCheckItem9.set_Command((PrintingSystemCommand)29);
		((BarItem)PrintPreviewBarCheckItem9).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarCheckItem9).set_GroupIndex(2);
		((BarItem)PrintPreviewBarCheckItem9).set_Hint("Image File");
		((BarItem)PrintPreviewBarCheckItem9).set_Id(48);
		((BarItem)PrintPreviewBarCheckItem9).set_Name("PrintPreviewBarCheckItem9");
		((BarItem)PrintPreviewBarCheckItem10).set_Caption("PDF File");
		((BarCheckItem)PrintPreviewBarCheckItem10).set_Checked(true);
		PrintPreviewBarCheckItem10.set_Command((PrintingSystemCommand)40);
		((BarItem)PrintPreviewBarCheckItem10).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarCheckItem10).set_GroupIndex(1);
		((BarItem)PrintPreviewBarCheckItem10).set_Hint("PDF File");
		((BarItem)PrintPreviewBarCheckItem10).set_Id(49);
		((BarItem)PrintPreviewBarCheckItem10).set_Name("PrintPreviewBarCheckItem10");
		((BarItem)PrintPreviewBarCheckItem11).set_Caption("MHT File");
		PrintPreviewBarCheckItem11.set_Command((PrintingSystemCommand)43);
		((BarItem)PrintPreviewBarCheckItem11).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarCheckItem11).set_GroupIndex(1);
		((BarItem)PrintPreviewBarCheckItem11).set_Hint("MHT File");
		((BarItem)PrintPreviewBarCheckItem11).set_Id(50);
		((BarItem)PrintPreviewBarCheckItem11).set_Name("PrintPreviewBarCheckItem11");
		((BarItem)PrintPreviewBarCheckItem12).set_Caption("RTF File");
		PrintPreviewBarCheckItem12.set_Command((PrintingSystemCommand)46);
		((BarItem)PrintPreviewBarCheckItem12).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarCheckItem12).set_GroupIndex(1);
		((BarItem)PrintPreviewBarCheckItem12).set_Hint("RTF File");
		((BarItem)PrintPreviewBarCheckItem12).set_Id(51);
		((BarItem)PrintPreviewBarCheckItem12).set_Name("PrintPreviewBarCheckItem12");
		((BarItem)PrintPreviewBarCheckItem13).set_Caption("XLS File");
		PrintPreviewBarCheckItem13.set_Command((PrintingSystemCommand)44);
		((BarItem)PrintPreviewBarCheckItem13).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarCheckItem13).set_GroupIndex(1);
		((BarItem)PrintPreviewBarCheckItem13).set_Hint("XLS File");
		((BarItem)PrintPreviewBarCheckItem13).set_Id(52);
		((BarItem)PrintPreviewBarCheckItem13).set_Name("PrintPreviewBarCheckItem13");
		((BarItem)PrintPreviewBarCheckItem14).set_Caption("XLSX File");
		PrintPreviewBarCheckItem14.set_Command((PrintingSystemCommand)45);
		((BarItem)PrintPreviewBarCheckItem14).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarCheckItem14).set_GroupIndex(1);
		((BarItem)PrintPreviewBarCheckItem14).set_Hint("XLSX File");
		((BarItem)PrintPreviewBarCheckItem14).set_Id(53);
		((BarItem)PrintPreviewBarCheckItem14).set_Name("PrintPreviewBarCheckItem14");
		((BarItem)PrintPreviewBarCheckItem15).set_Caption("CSV File");
		PrintPreviewBarCheckItem15.set_Command((PrintingSystemCommand)42);
		((BarItem)PrintPreviewBarCheckItem15).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarCheckItem15).set_GroupIndex(1);
		((BarItem)PrintPreviewBarCheckItem15).set_Hint("CSV File");
		((BarItem)PrintPreviewBarCheckItem15).set_Id(54);
		((BarItem)PrintPreviewBarCheckItem15).set_Name("PrintPreviewBarCheckItem15");
		((BarItem)PrintPreviewBarCheckItem16).set_Caption("Text File");
		PrintPreviewBarCheckItem16.set_Command((PrintingSystemCommand)41);
		((BarItem)PrintPreviewBarCheckItem16).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarCheckItem16).set_GroupIndex(1);
		((BarItem)PrintPreviewBarCheckItem16).set_Hint("Text File");
		((BarItem)PrintPreviewBarCheckItem16).set_Id(55);
		((BarItem)PrintPreviewBarCheckItem16).set_Name("PrintPreviewBarCheckItem16");
		((BarItem)PrintPreviewBarCheckItem17).set_Caption("Image File");
		PrintPreviewBarCheckItem17.set_Command((PrintingSystemCommand)39);
		((BarItem)PrintPreviewBarCheckItem17).set_Enabled(false);
		((BarBaseButtonItem)PrintPreviewBarCheckItem17).set_GroupIndex(1);
		((BarItem)PrintPreviewBarCheckItem17).set_Hint("Image File");
		((BarItem)PrintPreviewBarCheckItem17).set_Id(56);
		((BarItem)PrintPreviewBarCheckItem17).set_Name("PrintPreviewBarCheckItem17");
		SizeF autoScaleDimensions = new SizeF(7f, 12f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(787, 526);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)PrintControl1);
		((Control)this).get_Controls().Add((Control)(object)BarDockControl_2);
		((Control)this).get_Controls().Add((Control)(object)BarDockControl_3);
		((Control)this).get_Controls().Add((Control)(object)BarDockControl_1);
		((Control)this).get_Controls().Add((Control)(object)BarDockControl_0);
		((Control)this).set_Name("PrintReport");
		((Form)this).set_Text("Print Form");
		((ISupportInitialize)PrintBarManager_0).EndInit();
		((ISupportInitialize)RepositoryItemProgressBar1).EndInit();
		((ISupportInitialize)RepositoryItemZoomTrackBar1).EndInit();
		((ISupportInitialize)PrintPreviewRepositoryItemComboBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void PrintControl1_Load(object sender, EventArgs e)
	{
	}
}
