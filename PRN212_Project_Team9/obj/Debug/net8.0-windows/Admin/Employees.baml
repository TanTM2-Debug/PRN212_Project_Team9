   M S B A M L   `   `   `  ����O  KPRN212_Project_Team9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PRN212_Project_Team9PRN212_Project_Team9  5   	   $    PRN212_Project_Team9.Employees   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:PRN212_Project_Team9     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 	Employees��5	   	   $	��700��6   $
��1600��6(   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $	��350 �6   �� 5      $��2* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$	 Nav��5      $��0��6"    �� Orientation$ Vertical=�62   $��10,10,10,10q�6I   ���	#FFE2E2E2.+�5      �� -   5         ��Name$ btnEmployee��5      $��Employee��6*   $��	0,10,0,10q�6=   ���	#FF56DEDB$��60��6~   $��35��6�   ��6P   Z� 6�   �� 5      -   5        $ btnBack��5      $
��Back��6&   ���	#FFE8AE31$��60��6c   $��35��6n   $��0,0,0,10q�6z   ��65   Z� 6�   5      �� 5   
   -   5        $��employeePanel��5   :   $��1��6   $��10,10,10,10q�6%   .+�5      �� $��Search Employees��6   �� 5      $��0��6   $ 
Horizontal=�6&   $��	5,10,5,10q�6?   .+�5      �� -   5         ��Name$ txtSearchEmployee��5      $	��200��65   $��Center=�6A   $��0,0,10,0q�6\   �� 5      -   5        $ btnSearchEmployee��5      $��Search��64   $	��100��6E   6Q   5      �� 5!      $��Employee ID��6   �� 5"      -   5        $��txtEmployeeId��5"      ${�False��6+   ���	#FFFBDCDC6=   �� 5#      $��Fullname��6   �� 5$      -   5        $��txtEmPloyeeName��5$      �� 5%      $��Account��6   �� 5&      -	   5        $��
txtAccount��5&      �� 5'      $��Password��6   �� 5(      -
   5        $��txtPassword��5(      �� 5)      $��Phone��6   �� 5*      -   5        $ txtPhoneNumber��5*      �� 5+      $��	Hire Date��6   (  "System.Windows.Controls.DatePicker  5,      -   5        $��
dpHireDate��5,      �� 5-      $��Position��6   �� 5.      -   5        $��
cbPosition��5.       �� SelectedValuePath$ 
PositionId��6)   �� 5/      -   5        $��btnAddEmployee��5/   #   $	��Add��6   $��	5,10,5,10q�69   $	��200��6L   6X   �� 50      -   5        $��btnUpdateEmployee��50   &   $��Update��6   $��	5,10,5,10q�6?   $	��200��6R   6^   �� 51      -   5        $��btnDeleteEmployee��51   &   $��Delete��6   $��	5,10,5,10q�6?   $	��200��6R   6^   53      �� 54   
   -   5         ��Name$ 
lvEmployee��54      $��2��6'   $��50,0,0,0q�67   ���	#FFE2E2E2��6I   Z� 	 �� View	 55      �� 56      .P�57      �� $��Employee ID��6%   
 �� Width$
 50��6f    �� DisplayMemberBinding 6:   �� *
EmployeeId+6f   �� 58      $��Fullname��6%   $	
 160��6e    67   �� *EmployeeName+6e   �� 59      $��Account��6%   $	
 160��6_    66   �� *	Account+6_   �� 5:      $��Password��6%   $	
 160��6a    67   �� *
Password+6a   �� 5;      $��Phone��6%   $	
 160��6b    64   �� *PhoneNumber+6b   �� 5<      $��	Hire Date��6%   $	
 160��6}    68   �� *
HireDate+ �� StringFormat$ 
dd/MM/yyyy��6}   �� 5=      $��Position��6%   $	
 160��6a    67   �� *
Position+6a   5>      5@      �� 5A   
   $��3��6   $ Vertical=�6%   $��10,10,10,10q�6<   .+�5B      �� -   5        $ 	btnLogout��5B      $��LOGOUT��6)   
���  ��$
��Bold"�6x   ��6:   Z� ��6P   Z� 6�   5C      5D      5E      