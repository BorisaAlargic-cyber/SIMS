   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:UI.Dialog.ViewUI.Dialog.View  5      J FCompositeCommon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`Aclr-namespace:CompositeCommon.Converters;assembly=CompositeCommonCompositeCommon.Converters 5
          UI.Dialog.View.DrugView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:UI.Dialog.View     5      i eXceed.Wpf.AvalonDock.Themes.VS2010, Version=3.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4g cXceed.Wpf.AvalonDock.Themes.Aero, Version=3.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4h dXceed.Wpf.AvalonDock.Themes.Metro, Version=3.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4[	 WXceed.Wpf.AvalonDock, Version=3.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4=xcad,http://schemas.xceed.com/wpf/xaml/avalondock    	 5      X
 TXceed.Wpf.Toolkit, Version=3.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit 
 5	      R
convertersAclr-namespace:CompositeCommon.Converters;assembly=CompositeCommon 
 5
        � 	Resources  5      >  8CompositeCommon.Converters.DialogStateToEnabledConverter !  DialogStateToEnabledConverter��%   &	          5   
   63   5      .��5      ) 	 #Xceed.Wpf.AvalonDock.DockingManager     Theme 5   
   +  %Xceed.Wpf.AvalonDock.Themes.AeroTheme  5         Layout. 5   
   , 	 &Xceed.Wpf.AvalonDock.Layout.LayoutRoot     	RootPanel. 5      - 	 'Xceed.Wpf.AvalonDock.Layout.LayoutPanel     Orientation$ Vertical=�6   � 	 �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.ILayoutPanelElement, Xceed.Wpf.AvalonDock, Version=3.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]   Children. 5      6 	 0Xceed.Wpf.AvalonDock.Layout.LayoutAnchorablePane  � 	 �Xceed.Wpf.AvalonDock.Layout.LayoutPositionableGroup`1[[Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable, Xceed.Wpf.AvalonDock, Version=3.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]   	DockWidth$	 200 �6,   �	 	 �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable, Xceed.Wpf.AvalonDock, Version=3.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]] 	  Children. 5      2
 	 ,Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable
  / 	 )Xceed.Wpf.AvalonDock.Layout.LayoutContent   	ContentId$ 
properties��6,   	   Title$
	 Data��6C   
 
  CanHide
 .     CanClose .   
  AutoHideWidth$	 240Q�5   -      Content. 5      �  � ColumnDefinitions 5      �� 5   "   $��* �63    � RowDefinitions 5      �� 5   "   $
��Auto �60   �� 5    "   $��* �60   .+�5#      �� $��0��6)   $��0��69    �� Orientation$ 
Horizontal=�6F   .+�5$   "   �� $��30��6(   $��30��63   $��5q�6?   $��/Icons/search.png��6J   $��Center=�6e   �� 5%   "   $	��150��6*   $��30��66   $��5q�6B   $��0��6M   $��0��6]   ��6j   �� *Search+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ OneWayToSource=�5&      &   System.Windows.Controls.DataGrid  5(      -   5          Name$ DataGrid��5(   '   $��0��69   $��1��6I      SelectionMode$ Single=�6|   $   HorizontalScrollBarVisibility$
 Auto=�6�   $
��Auto��5)   ,      AutoGenerateColumns .     CanUserAddRows .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6m   {�5(   V   �� *DataGridEnabled+��6�   �� *Items+$ PropertyChanged=� �� SelectedItem 5)      �� *SelectedItem+   Columns 5*   "   0  *System.Windows.Controls.DataGridTextColumn  5+   &   ,  &System.Windows.Controls.DataGridColumn   Header$ ID��69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *ID+$ OneWay=�  5,   &   $
 Name��69    6G   �� *Name+$ OneWay=�  5-   &   $ Issue��69    6H   �� *Issue+$ OneWay=�  5.   &   $ Price��69    6H   �� *Price+$ OneWay=�50      51      53      54        55      $	 200 �6,   . 56      
  $ 
properties��6,   $	 Controls��6C   
 .   .  $	 240Q�57   -   . 59      �  5:      �� 5;   "   $��* �63   �� 5<   "   $
��Auto �63    5>      �� 5?   "   $��* �60   .+�5B      � $��0��6#   $��0��63   {�6@   �� *DialogState+ �� 	Converter# [   5C   "   �� 5D   &   $
��Auto �67   �� 5E   &   $
��Auto �67   �� 5F   &   $
��Auto �67    5H   "   �� 5I   &   $
��Auto �64   �� 5J   &   $
��Auto �64   �� 5K   &   $
��Auto �64   �� 5L   &   $
��Auto �64   �� 5M   &   $
��Auto �64   �� 5N   &   $
��Auto �64   .+�5R   "   �� $��0��6(   $��0��68   $
��ID: ��6E   �� 5S   "   $��1��5T      $��0��6   $	��200��6#   ��5S   *   ��  �� Path$ SelectedItem.ID�$ PropertyChanged=� �� ValidatesOnDataErrors .   �� NotifyOnValidationError  . ! �� ValidatesOnExceptions! . 5T   #   �� 5V   "   $��0��6(   $��1��68   $��Name: ��6E   �� 5W   "   $��1��5X      $��1��6   $	��200��6#   ��5W   *   �� $ SelectedItem.Name�$ PropertyChanged=� .   . ! . 5X   #   �� 5[   "   $��0��6(   $��2��68   $��Issue: ��6E   �� 5\   "   $��1��5]      $��2��6   $	��200��6#   " d� 	IsChecked" 5\   +   �� $ SelectedItem.Issue�$ PropertyChanged=� .   . ! . 5]   #   �� 5_   "   $��0��6(   $��3��68   $��Price: ��6E   �� 5`   "   $��1��5a      $��3��6   $	��200��6#   ��5`   *   �� $ SelectedItem.Price�$ PropertyChanged=� .   . ! . 5a   #   �� 5c   "   $��0��6(   $��4��68   $��Manifatorer: ��6E   �� 5d   "   $��1��5e      $��4��6   $	��200��6#   ��5d   *   �� $ SelectedItem.Manifatorer�$ PropertyChanged=� .   . ! . 5e   #   5g      �� 5i      $��1��6)   $��0��69   .+�5j   "   �� $��0��6)   $��1��69   $	��Add��6F   ��6T   �� *
AddCommand+�� 5k   "   $��0��6)   $��2��69   $
��Edit��6F   ��6U   �� *EditCommand+�� 5l   "   $��0��6)   $��3��69   $��Delete��6F   ��6W   �� *DeleteCommand+�� 5m   "   $��0��6)   $��4��69   # �� 	IsDefault# . $��Ok��6W   ��6d   �� *	OkCommand+�� 5n   "   $��0��6)   $��5��69   $ �� IsCancel$ . $��Cancel��6V   ��6g   �� *CancelCommand+5o      5p      5r      5s      5u      5v      5y      5z      