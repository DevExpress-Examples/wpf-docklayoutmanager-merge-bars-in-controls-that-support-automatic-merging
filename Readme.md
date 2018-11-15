<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication1/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication1/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication1/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/WpfApplication1/MainWindow.xaml))
<!-- default file list end -->
# How to: Merge Bars in Controls That Support Automatic Merging


The automatic bar merging is supported by several DevExpress controls

* <a href="https://documentation.devexpress.com/#WPF/CustomDocument7975">DXTabControl</a> - see <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfCoreDXTabControl_AllowMergingtopic">DXTabControl.AllowMerging Property</a> to learn more on how to enable it.
* <a href="https://documentation.devexpress.com/#WPF/CustomDocument6191">DXDocking</a> - see <a href="https://documentation.devexpress.com/#WPF/CustomDocument9155">MDI Bar Merging</a>.<br><br>In this example, the DockLayoutManager component implements the tabbed MDI interface. The main application window, as well as tabs, contains MainMenuControls which are merged when a document is selected or expanded in the MDI mode. <br><br>There are several properties you can use to control the merging process in DockLayoutManager

* <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfDockingDockLayoutManager_MDIMergeStyletopic">DockLayoutManager.MDIMergeStyle</a> - using this property, it is possible to disable merging or specify what panels will be merged: only active panels or all selected tabs/maximized MDI panels.
* <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfDockingDockLayoutManager_AllowMergingAutoHidePanelstopic">DockLayoutManager.AllowMergingAutoHidePanels</a>.
* <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfBarsBarItem_MergeTypetopic">BarItem.MergeType</a> - specifies whether an item will be removed, replaced or added to the parent bar
* <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfBarsBarItem_MergeOrdertopic">BarItem.MergeOrder</a> - controls the order in which bar items are displayed after merging.

<br/>


