using MetroFramework.Components;

namespace MetroFramework.Interfaces;

public interface IMetroStyledComponent
{
	MetroStyleManager InternalStyleManager { get; set; }
}
