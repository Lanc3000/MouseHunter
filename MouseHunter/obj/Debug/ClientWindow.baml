   M S B A M L   `   `   `  ����F  BMouseHunter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MouseHunterMouseHunter  5   	       MouseHunter.ClientWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MouseHunter     5   	   -   5          �Name$  displayArea��5   	    � Title$ ClientWindow��5   	   $	��450��6   $	��800��6+   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5'      &   System.Windows.Controls.DataGrid  -   5          Name$ dgEventsList��5'         SelectionUnit$
 Cell=�6-      
IsReadOnly .    AutoGenerateColumns .     EnableRowVirtualization . "	   VerticalScrollBarVisibility$
	 Auto=�5)      ��. $��1��5*      $��3��6"   $��5,5,2,5q�66   
   Columns
 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      -   5        idColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Id��5,   ;      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� *id+6^     5-      -   5        
dateColumn��$ Дата��5-   =   $
 Auto 6d    6K   �� *date+6d     5.      -   5        contentColumn��$ Событие��5.   @   $
 Auto 6k    6Q   �� *event+6k     5/      -   5        coordinateColumn��$ Координаты��5/   C   $
 Auto 6w    6W   �� *coordinates+6w   51      �� 53   
   -   5         ��Name$ startBtn��53      $��Start��6#   $��0��63   $��0��6@   $��Center=�6P   $��Center=�6m   $	��120��54      $��10q�6   6)   �� 55   
   $*��$Количество записей:��6   $��0��60   $��1��6=   $��Center=�6M   $��Center=�56      $
��Wrap=�6/   $��11,12,8.4,12q�6C   �� 57   
   -   5         ��Name$ countLbl��57      $��0��6"   $��2��6/   $��Center=�6?   $��Center=�6\   $��11.6,15,8,15q�58      59      5:      