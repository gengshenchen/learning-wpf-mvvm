   M S B A M L   `   `   `  ����?  ;karl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:karl.View.UserControlskarl.View.UserControls  5      (    "karl.View.UserControls.ListviewCtl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:karl.View.UserControls     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��80 �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ txtEntry��5      $��0��6$   $��0��61   $��16(�5      $��Center=�6    �� 5   
    �� Orientation$ 
Horizontal=�6   $��0��6/   $��1��6<   $��0,0,10,0q�6M   .+�5      �� -   5         ��Name$ btnAdd��5      $	��Add��6%   $��0��63   $��1��6@   $��40��6P   $
��left=�5      $��0,0,10,0q�61   6C   �� 5      -   5        $ btnDel��5      $	��Del��6%   $��0��63   $��1��6@   $��40��6P   $
��left=�5      $��0,0,10,0q�60   6B   �� 5      -   5        $ btnClr��5      $	��Clr��6%   $��0��63   $��1��6@   $��40��6P   $
��left=�5   
   $��0,0,10,0q�6%   67   5      �� 5   
   -   5         ��Name$ 	lvEntries��5      $��1��6&   $��0��63   $��2��6C   ��5      �� *	Entries+5      5      