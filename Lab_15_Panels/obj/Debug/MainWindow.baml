   M S B A M L   `   `   `  ����H  DLab_15_Panels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:lab_15_panelslab_15_panels  5   	       lab_15_panels.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:lab_15_panels     5   	     � Title$  
MainWindow��5   	   $
��Auto��6   $
��Auto��6*   ���#c4d6f2.��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��3* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��3* �6   .+�5   
   �� -   5         ��Name$ ButtonChangePanel��5      ���#8db3ef$��1��6A   $��Change Panel��6N   6e   �� 5   
   -   5        $ ButtonChangeTab��5      ���#8fa4c6$��3��6?   $��Change Panel By Index��6L   6l   �� 5   
   -   5        $ ButtonChangeTabByName��5      ���#8fa4c6$��4��6E   $��Change Panel By Name��6R   6q   �� 5   
   -   5         ��Name$ StackPanel01��5      ���#5992ea$��1��6@   $��1��6M   �� 5   
   -   5        $ StackPanel02��5      ���#347ced$��1��6@   $��1��6M   �� 5   
   -   5        $ StackPanel03��5      ���#0c65f2$��1��6@   $��1��6M   �� 5   
   -   5         ��Name$ TabControl01��5      ���#75dadd$��3��6@   $��1��6M   $��2��6]   .@�5      �� -   5         ��Name$ First��5      ���#84e8dc$��First��6:   .��5      �� -	   5         ��Name$ Label01��5      $��First��6)   5      �� 5      -
   5        $ Second��5      ���#56efdd$��Second��6;   .��5       �� -   5        $ Label02��5       $��Second��6)   5!      �� 5"      -   5        $ Third��5"      ���#1cedd4$��Third��6:   .��5#      �� -   5        $ Label03��5#      $��Third��6)   5$      5%      5&      5'      