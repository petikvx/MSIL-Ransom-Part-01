using System;
using System.Windows.Forms;
using MetroFramework.Components;

namespace MetroFramework.Interfaces;

public interface IMetroContainerControl : IDisposable, IContainerControl, IMetroControl, IMetroComponent, IMetroStyledComponent
{
	MetroStyleManager StyleManager { get; set; }
}
