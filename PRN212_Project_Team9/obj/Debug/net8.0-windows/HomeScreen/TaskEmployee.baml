   M S B A M L   `   `   `  ����O  KPRN212_Project_Team9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PRN212_Project_Team9PRN212_Project_Team9  5   	   '    !PRN212_Project_Team9.TaskEmployee   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:PRN212_Project_Team9     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ TaskEmployee��5	   	   $	��600��6   $
��1000��6+   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��2* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$	 Nav��5      $��0��6"   
�������$��10q�6I   $��80��6U   .+�5      �� -   5         ��Name$ 
btnProfile��5      $��Profile��6)   $��	0,10,0,10q�6;   ���	#FFE8AE31$��60��6|   $��35��6�   $��11(�6�   ��6N   Z� 6�   5      � 5   
   $��1��6   .+�5      � $��20q�6    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $��* �6$   .+�5      �� $��0��6   $��Employee Task��6)   $��36(�5      $
��Bold"�6   $��Center=�6,   $��0,0,0,20q�6I   � 5      $��1��6    5      �� 5       $��* �6(   �� 5!      $��* �6(    5$      �� 5%      $��* �6+   �� 5&      $��* �6+   �� 5'      $��* �6+   .+�5*      �� $��0��6!   $��0��6.   $��10q�6>   .+�5+      �� -   5        $ btnOrder��5+   !   $��Order��63   ���	#FFD2A2A2���	#FFBCB9B1$��36(�6r   $	��225��6�   $
��Bold"�6�   $��Bell MT)�6�   6�   5,      �� 5.      $��0��6!   $��1��6.   $��10q�6>   .+�5/      �� -   5        $ btnCustomer��5/   !   $��Customer��66   ���	#FFD2A2A2���	#FFBCB9B1$��36(�6x   $	��225��6�   $
��Bold"�6�   $��Bell MT)�6�   6�   50      �� 52      $��0��6!   $��2��6.   $��10q�6>   .+�53      �� $��Order��6"   ���	#FFD2A2A2���	#FFBCB9B1$��36(�6a   $	��225��6o   $
��Bold"�6|   $��Bell MT)�6�   54      �� 56      $��1��6!   $��0��6.   $��10q�6>   .+�57      �� $��Order��6"   ���	#FFD2A2A2���	#FFBCB9B1$��36(�6a   $	��225��6o   $
��Bold"�6|   $��Bell MT)�6�   58      �� 5:      $��1��6!   $��1��6.   $��10q�6>   .+�5;      �� $��Order��6"   ���	#FFD2A2A2���	#FFBCB9B1$��36(�6a   $	��225��6o   $
��Bold"�6|   $��Bell MT)�6�   5<      �� 5>      $��1��6!   $��2��6.   $��10q�6>   .+�5?      �� $��Order��6"   ���	#FFD2A2A2���	#FFBCB9B1$��36(�6a   $	��225��6o   $
��Bold"�6|   $��Bell MT)�6�   5@      5A      5B      5C      �� 5D   
   $��2��6    �� Orientation$ Vertical=�6%   $��10,10,10,10q�6<   .+�5E      �� -   5        $��	btnLogout��5E      $��LOGOUT��6'   
���  ��$
��Bold"�6v   $��Center=�6�   ��68   Z� ��6N   Z� 6�   5F      5G      5H      