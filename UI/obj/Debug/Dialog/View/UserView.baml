   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:UI.Dialog.ViewUI.Dialog.View  5      J FCompositeCommon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`Aclr-namespace:CompositeCommon.Converters;assembly=CompositeCommonCompositeCommon.Converters 5
          UI.Dialog.View.UserView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:UI.Dialog.View     5      i eXceed.Wpf.AvalonDock.Themes.VS2010, Version=3.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4g cXceed.Wpf.AvalonDock.Themes.Aero, Version=3.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4h dXceed.Wpf.AvalonDock.Themes.Metro, Version=3.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4[	 WXceed.Wpf.AvalonDock, Version=3.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4=xcad,http://schemas.xceed.com/wpf/xaml/avalondock    	 5      X
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
  AutoHideWidth$	 240Q�5   -      Content. 5      �  � ColumnDefinitions 5      �� 5   "   $��* �63    � RowDefinitions 5      �� 5   "   $
��Auto �60   �� 5   "   $��* �60   .+�5"      �� $��0��6)   $��0��69    �� Orientation$ 
Horizontal=�6F   .+�5#   "   �� $��Search: ��6(   �� 5$   "   $	��150��6*   $��30��66   $��5q�6B   $��0��6M   $��0��6]   ��6j   �� *Search+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ OneWayToSource=�5%      &   System.Windows.Controls.DataGrid  5'      -   5          Name$ DataGrid��5'   '   $��0��69   $��1��6I      SelectionMode$ Single=�6|   $   HorizontalScrollBarVisibility$
 Auto=�6�   $
��Auto��5(   ,      AutoGenerateColumns .     CanUserAddRows .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6m   {�5'   V   �� *DataGridEnabled+��6�   �� *Items+$ PropertyChanged=� �� SelectedItem 5(      �� *SelectedItem+   Columns 5)   "   0  *System.Windows.Controls.DataGridTextColumn  5*   &   ,  &System.Windows.Controls.DataGridColumn   Header$ ID��69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *ID+$ OneWay=�  5+   &   $ Username��69    6K   �� *
Username+$ OneWay=�  5,   &   $ 
First Name��69    6M   �� *	FirstName+$ OneWay=�  5-   &   $ 	Last Name��69    6L   �� *
LastName+$ OneWay=�5/      50      52      53        54      $	 200 �6,   . 55      
  $ 
properties��6,   $	 Controls��6C   
 .   .  $	 240Q�56   -   . 58      �  59      �� 5:   "   $��* �63   �� 5;   "   $
��Auto �63    5=      �� 5>   "   $��* �60   .+�5A      � $��0��6#   $��0��63   {�6@   �� *DialogState+ �� 	Converter# [   5B   "   �� 5C   &   $
��Auto �67   �� 5D   &   $
��Auto �67   �� 5E   &   $
��Auto �67    5G   "   �� 5H   &   $
��Auto �64   �� 5I   &   $
��Auto �64   �� 5J   &   $
��Auto �64   �� 5K   &   $
��Auto �64   �� 5L   &   $
��Auto �64   �� 5M   &   $
��Auto �64   .+�5Q   "   �� $��0��6(   $��0��68   $
��ID: ��6E   �� 5R   "   $��1��5S      $��0��6   $	��200��6#   ��5R   *   ��  �� Path$ SelectedItem.ID�$ PropertyChanged=� �� ValidatesOnDataErrors .   �� NotifyOnValidationError  . ! �� ValidatesOnExceptions! . 5S   #   �� 5U   "   $��0��6(   $��1��68   $��
Username: ��6E   �� 5V   "   $��1��5W      $��1��6   $	��200��6#   ��5V   *   �� $ SelectedItem.Username�$ PropertyChanged=� .   . ! . 5W   #   �� 5Y   "   $��0��6(   $��2��68   $��
Password: ��6E   G� 5Z   "   -   5        " G�Name$" password��5Z   .   $��1��5[      $��2��6   $	��200��6#   �� 5]   "   $��0��6(   $��3��68   $��First Name: ��6E   �� 5^   "   $��1��5_      $��3��6   $	��200��6#   ��5^   *   �� $ SelectedItem.FirstName�$ PropertyChanged=� .   . ! . 5_   #   �� 5a   "   $��0��6(   $��4��68   $��Last Name: ��6E   �� 5b   "   $��1��5c      $��4��6   $	��200��6#   ��5b   *   �� $ SelectedItem.LastName�$ PropertyChanged=� .   . ! . 5c   #   �� 5e   "   $��0��6(   $��5��68   $��User Type: ��6E   �� 5f   "   $��1��6+   $��5��6;   $	��200��6H   # �� DisplayMemberPath$
# Name��5g   R   $ �� SelectedValuePath$$ Value��6k   % �� SelectedValue% 5f   T   �� $ SelectedItem.UserType�$ PropertyChanged=� .   . ! . ��5g   +   �� $ 	UserTypes�5h   #   5j      �� 5l      $��1��6)   $��0��69   .+�5m   "   �� $��0��6)   $��1��69   $	��Add��6F   ��6T   �� *
AddCommand+�� 5n   "   $��0��6)   $��2��69   $
��Edit��6F   ��6U   �� *EditCommand+�� 5o   "   $��0��6)   $��3��69   $��Delete��6F   ��6W   �� *DeleteCommand+�� 5p   "   $��0��6)   $��4��69   & �� 	IsDefault& . $��Ok��6W   ��6d   �� *	OkCommand+�� 5q   "   $��0��6)   $��5��69   ' �� IsCancel' . $��Cancel��6V   ��6g   �� *CancelCommand+5r      5s      5u      5v      5x      5y      5|      5}      