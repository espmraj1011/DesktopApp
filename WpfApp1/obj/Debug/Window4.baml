   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Window4   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Table��5   	   $	��600��6   $
��1300��6$   .��5	      � .+�5
   
   � $
��Left=�6   $	��500��6*   $	��Top=�67   $
��1250��6O   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��dataGrid��5      $	��250��5      $
��1200��6$   $
��Left=�61   $��	12,21,0,0q�6L   $	��Top=�5   #      	RowHeight$ 30Q�6;      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 100 6J      ColumnHeaderHeight$	 100Q�5         HeadersVisibility$ Column=�64   
�������   RowBackground
 �����   AlternatingRowBackground
 ��ح�
�������$��5q�5   .      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��5      
   Width$	
 200 5      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      �� *Id+   ElementStyle 5      �� 5       �� 
TargetType" ��6$   .�5   "   ��  �� Property � �� �� Value$
 Wrap=�6A   �� 5   "    � ��
 ��  �6?   5         EditingElementStyle 5      �� 5       " ��6$   .�5!   "   ��  � ��
 ��  �6?   5"      5%        5'      $	 
First Name��5(      $	
 200 5)       5*      �� *	FirstName+ 5,      �� 5-      " ��6$   .�5.   "   ��  � ��$
 Wrap=�6A   �� 5/   "    � ��
 ��  �6?   50       52      �� 53      " ��6$   .�54   "   ��  � ��
 ��  �6?   55      58        5:      $	 	Last Name��5;      $	
 200 5<       5=      �� *
LastName+ 5?      �� 5@      " ��6$   .�5A   "   ��  � ��$
 Wrap=�6A   �� 5B   "    � ��
 ��  �6?   5C       5E      �� 5F      " ��6$   .�5G   "   ��  � ��
 ��  �6?   5H      5K        5M      $	 
Department��5N      $	
 200 5O       5P      �� *
Department+ 5R      �� 5S      " ��6$   .�5T   "   ��  � ��$
 Wrap=�6A   �� 5U   "    � ��
 ��  �6?   5V       5X      �� 5Y      " ��6$   .�5Z   "   ��  � ��
 ��  �6?   5[      5^        5`      $	 
Passed Out��5a      $	
 200 5b       5c      �� *	PassedOut+ 5e      �� 5f      " ��6$   .�5g   "   ��  � ��$
 Wrap=�6A   �� 5h   "    � ��
 ��  �6?   5i       5k      �� 5l      " ��6$   .�5m   "   ��  � ��
 ��  �6?   5n      5q        5s      $	 Company��5t      $	
 200 5u       5v      �� *	Company+ 5x      �� 5y      " ��6$   .�5z   "   ��  � ��$
 Wrap=�6A   �� 5{   "    � ��
 ��  �6?   5|       5~      �� 5      " ��6$   .�5�   "   ��  � ��
 ��  �6?   5�      5�      5�      5�      5�      5�      