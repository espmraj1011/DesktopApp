   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Window2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  	Data Grid��5   	   $	��600��6   $
��1200��6(   .��5	      � .+�5
   
   � $
��Left=�6   $	��500��6*   $	��Top=�67   $
��1150��6O   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��dataGrid��5      $	��250��5      $
��1100��6$   $
��Left=�61   $��	12,21,0,0q�6L   $	��Top=�5   #      	RowHeight$ 30Q�6;      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 100 6J      ColumnHeaderHeight$	 100Q�5         HeadersVisibility$ Column=�64   
�������   RowBackground
 �����   AlternatingRowBackground
 ��ح�
�������$��5q�5   .      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Name��5      
   Width$	
 220 5      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      �� *Name+   ElementStyle 5      �� 5       �� 
TargetType" ��6$   .�5   "   ��  �� Property � �� �� Value$
 Wrap=�6A   �� 5   "    � ��
 ��  �6?   5      5"        5#      $
	 Name��5$      $	
 220 5%       5&      �� *
FatherName+ 5(      �� 5)      " ��6$   .�5*   "   ��  � ��$
 Wrap=�6A   �� 5+   "    � ��
 ��  �6?   5,      5/      4  .System.Windows.Controls.DataGridTemplateColumn  51      $		 DOB��6-      CellTemplate 52      �� 53      .R�54   "   �� $��4q�6A   ��6,   �� *DOB+6A   55         CellEditingTemplate 57      �� 58      .R�59   "   (  "System.Windows.Controls.DatePicker     SelectedDate 6-   �� *DOB+ �� Mode$ TwoWay=�5:      5<        5?      $
	 City��5@      $	
 220 5A       5B      �� *City+ 5D      �� 5E      " ��6$   .�5F   "   ��  � ��$
 Wrap=�6A   �� 5G   "    � ��
 ��  �6?   5H      5K        5N      $	 Medium of Study��5O      $	
 220 5P       5Q      �� *Medium+ 5S      �� 5T      " ��6$   .�5U   "   ��  � ��$
 Wrap=�6A   �� 5V   "    � ��
 ��  �6?   5W      5Y        5[      $
	 Name��5\      $	
 220 5]       5^      �� *
Department+ 5`      �� 5a      " ��6$   .�5b   "   ��  � ��$
 Wrap=�6A   �� 5c   "    � ��
 ��  �6?   5d      5g      5l      5n      5o      5p      