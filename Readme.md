<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128641117/14.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T325614)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication1/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication1/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication1/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication1/MainWindow.xaml.vb))
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


