   M S B A M L   `   `   `  ����?  ;karl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:karl.View.UserControlskarl.View.UserControls  5      -    'karl.View.UserControls.ClearableTextBox   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:karl.View.UserControls     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5       � 	Resources 5   
    �� 
TargetType��%'   '��       �� 5      " ��6   6+   5      .+�5   
   �� -   5         ��Name$ tbPlaceholder��5      $��Center=�5      $��16(�5      $��Light"�6"   
�������$��5,0,0,0q�5   +    K� ZIndex$ -1��5      ��5   +   �� *
Placehoder+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5      �� 5   
   -   5         ��Name$ tbInput��5      $��Center=�6$   $��16(�5      $��Light"�6    
������ 5      �� 5   
   -   5         ��Name$ btnclear��5      $��30��5      $��0q�5       $��0q�5!      $��Right=�5"      $��X��5#      
������ 
�������$��0q�5%      ��5      �� 	 �� ElementName$	 tbInput��
 �� Path$
 ActualHeight���5      �� $	 tbInput��$
 VerticalAlignment�5&      5*      5+      