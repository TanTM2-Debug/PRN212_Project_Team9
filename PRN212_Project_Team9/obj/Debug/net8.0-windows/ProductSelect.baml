   M S B A M L   `   `   `  ����O  KPRN212_Project_Team9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PRN212_Project_Team9PRN212_Project_Team9  5   	   (    "PRN212_Project_Team9.ProductSelect   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:PRN212_Project_Team9     5   	   X TXceed.Wpf.Toolkit, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  ProductSelect��5	   	   $	��327��6   $
��1014��6,   .��5
      � $��0,0,0,23q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataProductListToOrder��5      $
��Left=�6^   $	��Top=�6y   $	��144��6�   $	��362��6�   6�   �� 5   
   $��CurrentDiscount��6   $
��Left=�6*   $��	660,5,0,0q�6E   $	��Top=�6X    J� RenderTransformOrigin$ 
1.632,0.31&�6p     5   
   -   5        $ DiscountsOfProduct��5      $
��Left=�6Z   $	��Top=�6u   $	��186��6�   $	��344��6�   $��
660,36,0,0q�6�   �� 5   
   $��Search:��6   $
��Left=�6"   $��
10,155,0,0q�6=   $	��Top=�6Q   
�������$��54��6{   �� 5   
   -   5         ��Name$ 
TypeSearch��5      $
��Left=�6'   $��
10,186,0,0q�6B   $	��Top=�6V   $	��118��6n   $��26��6z   5      �� 5   
   -   5         ��Name$ InputSearch��5      $
��Left=�6'   $��
69,155,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��217��6�   $��26��6�   �� 5   
   -   5        $��Start��5      $
��Left=�6!   $��138,186,0,0q�6<   $	��Top=�6Q   $��26��6i   $	��148��6u   6�   �� 5   
   -   5        $��Refresh��5      $
��Left=�6#   $��
10,217,0,0q�6>   $	��Top=�6R   $��26��6j   $	��276��6v   6�   �� 5   
   $��	IdProduct��6   $
��Left=�6$   $��
380,21,0,0q�6?   $	��Top=�6S   
����� �$��93��6}   �� 5   
   $��NameProduct��6   $
��Left=�6&   $��
380,62,0,0q�6A   $	��Top=�6U   
����� �$��93��6   �� 5   
   $��
TotalPrice��6   $
��Left=�6%   $��378,103,0,0q�6@   $	��Top=�6U   
����� �$��95��6   �� 5   
   $��Quantity��6   $
��Left=�6#   $��378,142,0,0q�6>   $	��Top=�6S   
����� �$��95��6}   �� 5   
   -   5        $ tbxIdProduct��5      $
��Left=�6(   $��
496,21,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��148��6�   $��26��6�    �� 
IsReadOnly$
 True��6�   �� 5   
   -   5        $ tbxNameProduct��5      $
��Left=�6*   $��
496,62,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6n   $	��148��6�   $��26��6�   $
 True��6�   �� 5   
   -	   5        $ tbxTotalPrice��5      $
��Left=�6)   $��496,103,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��148��6�   $��26��6�   $
 True��6�   %  Xceed.Wpf.Toolkit.IntegerUpDown  5   
   -
   5          Name$ QuantityProduct��5      �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]   Value 05      	   Minimum	 05      
   Maximum
 1005      $��496,142,0,0q�5       $
��Left=�5!   A   $	��Top=�6\   $��26��6t   $	��148��6�   �� 5"   
   -   5        $��SelectProduct��5"      $
��Left=�6)   $��380,181,0,0q�6D   $	��Top=�6Y   $��97��6q   $	��264��6}   6�   5#      5$      