   M S B A M L   `   `   `  ����B  >manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:managermanager  5   	       manager.reg_employee   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:manager     5   	     � Title$  emp_register��5   
   $��473.256��6   $	��850��60   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��Employee Registration��6   $��1��60   $��Center=�6@   $��Center=�6^   $��25(�6y   �� 5   
   $��	Full Name��6   $��Center=�6%   $��2��6B   $��Center=�6O   $��15(�6j   �� 5   
   $��Email Address��6   $��Center=�6(   $��3��6F   $��Center=�6S   $��15(�6n   �� 5   
   $��Username��6   $��Center=�6#   $��4��6A   $��Center=�6N   $��15(�6i   �� 5   
   $��Password��6   $��Center=�6#   $��5��6A   $��Center=�6N   $��15(�6i   �� 5   
   $��Confirm Password��6   $��Center=�6+   $��6��6I   $��Center=�6V   $��15(�6q   �� 5    
   -   5         ��Name$	 reg��5       $��Register��6   $��1��61   $��Center=�6A   $��7��6^   $��Center=�6k   $	��102��6�   $��37��6�   $��15(�6�   $��167,10,11,8q�6�   6�   �� 5!   
   -   5         ��Name$ f_name��5!      $��1��6#   $��Center=�63   $��23��6P   $��2��6]    �� TextWrapping$
 Wrap=�6j   $��Center=�6   $	��220��6�   �� 5"   
   -   5        $ email��5"      $��1��6"   $��Center=�62   $��23��6O   $��3��6\   $
 Wrap=�6i   $��Center=�6~   $	��220��6�   �� 5#   
   -   5        $ username��5#      $��1��6%   $��Center=�65   $��23��6R   $��4��6_   $
 Wrap=�6l   $��Center=�6�   $	��220��6�   G� 5$   
   -   5         G�Name$ password��5$      $��1��6(   $��Center=�68   $��5��6V   $��Center=�6c   $��23��6~   $	��220��6�   G� 5%   
   -   5        $ 
c_password��5%      $��1��6*   $��Center=�6:   $��6��6X   $��Center=�6e   $��23��6�   $	��220��6�   �� 5&   
   -   5        $ back_btn��5&      $
��Back��6#   $
��Left=�62   $��
122,10,0,0q�6M   $	��Top=�6a   $��75��6y   6�   5)      5*      