   M S B A M L   `   `   `  ����?  ;karl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:karlkarl  5   	   ?$clr-namespace:karl.View.UserControlskarl.View.UserControls  5   	       karl.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:karl     5   	   =usercontrols$clr-namespace:karl.View.UserControls     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      �� 5      $��20 �6   .+�5   
   $   karl.View.UserControls.menubar  � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $	��40* �6#   �� 5      $��5 �6#   �� 5      $	��40* �6#   �� 5      $��5 �6#   �� 5      $	��15* �6#   .+�5      (   "karl.View.UserControls.ListviewCtl  $��0��6'   �� 5      $��1��6   $��Stretch=�6+   �� 5      $��2��6   $
��Auto=�6+   .��5      ��  �� Orientation$ Vertical=�6   .+�5      -   'karl.View.UserControls.ClearableTextBox     
Placehoder$ 
First Name��64   $��0,0,0,10q�6L     5      $ 	Last Name��64   $��0,0,0,10q�6L     5       $ email��64   $��0,0,0,10q�6H     5!      $
 addr��64   $��0,0,0,10q�6G   5"      5#      �� 5%      $��3��6   $��Stretch=�6+   �� 5&      $��4��6   
����  �6(   5(      �� 5*   
   $��2��6   
���/���6!   5,      5-      