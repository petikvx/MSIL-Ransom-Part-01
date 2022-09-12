using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExciteRAN;

public sealed class ReferenceList : Form
{
	private IContainer lastHandler = LineStream.lastHandler;

	private Label urlHeader;

	private Label logCollection;

	private Label handlerDisposed;

	public ReferenceList()
	{
		FreeDatabase();
	}

	private void OrderPane(object P_0, EventArgs P_1)
	{
		FileLayout.SaveNetwork(this, (byte)ControlQueue.ResolveMenuItem(0) != 0);
		AssistantFactory.SaveNetwork(this, (FormStartPosition)ControlQueue.ResolveMenuItem(4));
	}

	private void CloneMethod(object P_0, FormClosingEventArgs P_1)
	{
		BuilderLoader.SaveNetwork(P_1, (byte)ControlQueue.ResolveMenuItem(8) != 0);
	}

	private void ReplaceDevice(object P_0, EventArgs P_1)
	{
	}

	protected override void Dispose(bool disposing)
	{
		int num;
		if (disposing)
		{
			while (true)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			num = ((lastHandler > LineStream.lastHandler) ? 1 : 0);
		}
		else
		{
			num = ControlQueue.ResolveMenuItem(12);
		}
		if (num != 0)
		{
			while (true)
			{
				switch (6)
				{
				case 0:
					continue;
				}
				break;
			}
			ImageInfo.SaveNetwork(lastHandler);
		}
		ProjectDesigner.SaveNetwork(this, disposing);
	}

	private void FreeDatabase()
	{
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		urlHeader = RegistryInvoker.SaveNetwork();
		logCollection = RegistryInvoker.SaveNetwork();
		handlerDisposed = RegistryInvoker.SaveNetwork();
		DeviceSettings.SaveNetwork(this);
		DiskResolver.SaveNetwork(urlHeader, (byte)ControlQueue.ResolveMenuItem(16) != 0);
		ContextProvider.SaveNetwork(urlHeader, DeploymentManager.SaveNetwork(SymbolStream.SaveNetwork(1), ControlQueue.OrderPane(20), (FontStyle)ControlQueue.ResolveMenuItem(24), (GraphicsUnit)ControlQueue.ResolveMenuItem(28), (byte)ControlQueue.ResolveMenuItem(32)));
		IconLoader.SaveNetwork(urlHeader, new Point(ControlQueue.ResolveMenuItem(36), ControlQueue.ResolveMenuItem(40)));
		MenuItemConverter.ChangeEditor(urlHeader, SymbolStream.SaveNetwork(32));
		ReferenceInfo.SaveNetwork(urlHeader, new Size(ControlQueue.ResolveMenuItem(44), ControlQueue.ResolveMenuItem(48)));
		TextFileEditor.SaveNetwork(urlHeader, ControlQueue.ResolveMenuItem(52));
		PartitionService.SaveNetwork(urlHeader, SymbolStream.SaveNetwork(45));
		DiskResolver.SaveNetwork(logCollection, (byte)ControlQueue.ResolveMenuItem(56) != 0);
		ContextProvider.SaveNetwork(logCollection, DeploymentManager.SaveNetwork(SymbolStream.SaveNetwork(1), ControlQueue.OrderPane(60), (FontStyle)ControlQueue.ResolveMenuItem(64), (GraphicsUnit)ControlQueue.ResolveMenuItem(68), (byte)ControlQueue.ResolveMenuItem(72)));
		IconLoader.SaveNetwork(logCollection, new Point(ControlQueue.ResolveMenuItem(76), ControlQueue.ResolveMenuItem(80)));
		MenuItemConverter.ChangeEditor(logCollection, SymbolStream.SaveNetwork(90));
		ReferenceInfo.SaveNetwork(logCollection, new Size(ControlQueue.ResolveMenuItem(84), ControlQueue.ResolveMenuItem(88)));
		TextFileEditor.SaveNetwork(logCollection, ControlQueue.ResolveMenuItem(92));
		PartitionService.SaveNetwork(logCollection, SymbolStream.SaveNetwork(103));
		DiskResolver.SaveNetwork(handlerDisposed, (byte)ControlQueue.ResolveMenuItem(96) != 0);
		ContextProvider.SaveNetwork(handlerDisposed, DeploymentManager.SaveNetwork(SymbolStream.SaveNetwork(180), ControlQueue.OrderPane(100), (FontStyle)ControlQueue.ResolveMenuItem(104), (GraphicsUnit)ControlQueue.ResolveMenuItem(108), (byte)ControlQueue.ResolveMenuItem(112)));
		IconLoader.SaveNetwork(handlerDisposed, new Point(ControlQueue.ResolveMenuItem(116), ControlQueue.ResolveMenuItem(120)));
		MenuItemConverter.ChangeEditor(handlerDisposed, SymbolStream.SaveNetwork(223));
		ReferenceInfo.SaveNetwork(handlerDisposed, new Size(ControlQueue.ResolveMenuItem(124), ControlQueue.ResolveMenuItem(128)));
		TextFileEditor.SaveNetwork(handlerDisposed, ControlQueue.ResolveMenuItem(132));
		PartitionService.SaveNetwork(handlerDisposed, SymbolStream.SaveNetwork(236));
		MemoryDesigner.SaveNetwork(handlerDisposed, ReplaceDevice);
		FunctionLoader.SaveNetwork(this, new SizeF(ControlQueue.OrderPane(136), ControlQueue.OrderPane(140)));
		ProcessTable.SaveNetwork(this, (AutoScaleMode)ControlQueue.ResolveMenuItem(144));
		ResourceStack.SaveNetwork(this, ConditionProvider.SaveNetwork());
		ProcessSite.SaveNetwork(this, new Size(ControlQueue.ResolveMenuItem(148), ControlQueue.ResolveMenuItem(152)));
		ConnectionDesigner.SaveNetwork(this, (byte)ControlQueue.ResolveMenuItem(156) != 0);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)handlerDisposed);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)logCollection);
		SymbolProvider.SaveNetwork(StreamSerializer.SaveNetwork(this), (Control)(object)urlHeader);
		StubDesigner.SaveNetwork(this, Reference.SaveNetwork());
		ProjectLoader.SaveNetwork(this, (FormBorderStyle)ControlQueue.ResolveMenuItem(160));
		MenuItemConverter.ResolveMenuItem(this, SymbolStream.SaveNetwork(267));
		PartitionService.SaveNetwork(this, SymbolStream.SaveNetwork(267));
		PluginInfo.SaveNetwork(this, new FormClosingEventHandler(CloneMethod));
		PcitureSettings.SaveNetwork(this, OrderPane);
		DeploymentTree.SaveNetwork(this, (byte)ControlQueue.ResolveMenuItem(164) != 0);
		ContextScope.SaveNetwork(this);
	}
}
