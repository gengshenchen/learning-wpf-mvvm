   M S B A M L   `   `   `  ����?  ;karl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:karl.View.UserControlskarl.View.UserControls  5      $    karl.View.UserControls.menubar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:karl.View.UserControls     5      $��70��5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��30 �6   �� 5      $��40 �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6#   
�������.+�5      o� .@�5      m� $
��File��6   $��14(�6)   $��RightToLeft=�67   .@�5      m� $
��Exit��6   m� 5      $
��Save��6   5      m� 5      $
��Edit��6   m� 5      $
��View��6   5      5      �� 5   
   $��0��6   $ 
Horizontal=�6#   $��Right=�6<   
�������.+�5      9� $��theme��6    9� ExpandDirection$
 Left=�6&   .��5      �� $ 
Horizontal=�6!   $
��auto��6:   .+�5      �� -   5         ��Name$ btnDarkTheme��5      $
��auto��63   $��30��6A   $
��Dark��6N   6]   �� 5      -   5        $ btnLightTheme��5      $
��auto��64   $��30��6A   $��Light��6N   6^   5      5      �� 5      -   5        $ btnMin��5      $��-��6%   $��30��61   
��� � �6<   �� 5       -   5        $ btnMax��5       $��+��6%   $��30��61   �� 5!      -   5        $ btnClose��5!      $��X��6'   $��30��63   5"      �� 5$   
   $��1��6   $ 
Horizontal=�6"   
�������.+�5%      �� -   5        $ btnOpen��5%      $
��Open��6'   $��0,0,10,0q�5&      9� 5'      $��Details��6   $ Right=�6(   $��0,0,10,0q�6A   .��5(      �� -   5        $ btnStart��5(      $��Start��6,   $��0,0,10,0q�6R   5)      �� 5*      -   5        $ 	btnNormal��5*         ConfirmButton#��[  6(   $��Normal��6O   $��0,0,10,0q�6v   �� 5+      -	   5        $ btnModal��5+      $��Modal��6(   $��0,0,10,0q�6N   �� 5,      -
   5        $ 
btnProduct��5,      $
��MVVM��6*   $��0,0,10,0q�6O   �� 5.      -   5         ��Name$ txMenuDebug��5.      $	��500��6+   $��0,0,10,0q�67    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5/   "   " �� VerticalScrollBarVisibility$
 Auto=�66   51      52      53      