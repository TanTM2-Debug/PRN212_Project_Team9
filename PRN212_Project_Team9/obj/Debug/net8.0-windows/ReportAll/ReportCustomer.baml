   M S B A M L   `   `   `  ����O  KPRN212_Project_Team9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PRN212_Project_Team9.ReportPRN212_Project_Team9.Report  5   	   0    *PRN212_Project_Team9.Report.ReportCustomer   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:PRN212_Project_Team9.Report     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ ReportCustomer��5
   	   $	��600��6    $
��1000��6-   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��2* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$	 Nav��5      $��0��6"    �� Orientation$ Vertical=�62   $��10q�6I   $��80��6U   ���	#FFE2E2E2.+�5      �� $
��Wrap=�6   $��Report��6,   $��16(�6:   $
��Bold"�6H   $��Center=�6Z   �� 5      -   5         ��Name$ btnReportEmployee��5      $��Employee��60   $��	0,10,0,10q�6C   ���	#FFE8AE31$��60��6�   $��35��6�   ��6V   Z� 6�   �� 5      -   5        $ btnReportCustomer��5      $��Customer��60   ���	#FF56DEDB$��60��6q   $��35��6|   $��0,0,0,10q�6�   ��6C   Z� 6�   �� 5      -   5        $ btnBack��5      $
��Back��6&   ���	#FFE8AE31$��60��6c   $��35��6n   $��0,0,0,10q�6z   ��65   Z� 6�   5      � 5   
   $��1��6    � RowDefinitions 5      �� 5      $��2* �6    �� 5      $
��0.5* �6    .+�5      &   System.Windows.Controls.DataGrid  -   5        $��dgReportCustomer��5      $��0��6/      AutoGenerateColumns$
 True��6<   $��	0,10,0,20q�6W      
IsReadOnly$
 True��6j   $��Center=�6|   	   CanUserSortColumns$
	 True��6�   $	��808��6�   �� 5       $��1��6   $��Right=�6&   .+�5!      �� -   5        $��	btnExport��5!   9   $��Export Report to File��6   $��20,10,30,10q�6J   $	��130��6_   $��40��6k   6w   5"      5#      �� 5$   
   $��3��6   $ Vertical=�6%   $��10,10,10,10q�6<   .+�5%      �� -   5        $��	btnLogout��5%      $��LOGOUT��6'   
���  ��$
��Bold"�6v   ��68   Z� ��6N   Z� 6�   5&      5'      5(      