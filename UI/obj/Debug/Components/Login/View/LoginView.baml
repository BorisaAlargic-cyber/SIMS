   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:UI.Components.Login.ViewUI.Components.Login.View  5      (    "UI.Components.Login.View.LoginView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:UI.Components.Login.View     5        � SizeToContent$  WidthAndHeight=�5      .��5	      � $��20q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0��6    $��	Username:��6-   �� 5   
   $��1��6,   $��0��6<   $��0��6I   $	��250��6V   ��6   �� *
Username+6V   �� 5   
   $��0��6   $��1��6    $��	Password:��6-   G� 5   
   -   5        $��passwordBox��5      $��1��6W   $��1��6g   $��1��6t   $	��250��6�   �� 5   
   $��2��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Right=�6K   .+�5      �� $��Login��6    �� 	IsDefault . $��2��6W   ��66   �� *LoginCommand+6W   �� 5      $��Cancel��6    �� IsCancel . $��3��6X   ��66   �� *CancelCommand+6X   5      5      5      