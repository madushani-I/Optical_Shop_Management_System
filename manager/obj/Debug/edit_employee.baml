   M S B A M L   `   `   `  ����B  >manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:managermanager  5   	       manager.edit_employee   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:manager     5   	     � Title$  edit_employee��5   
   $	��450��6    $	��850��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��Edit Employee��6   $��1��6(   $��Center=�68   $��Center=�6V   $��25(�6q   �� 5   
   $��	Full Name��6   $��Center=�6%   $��2��6B   $��Center=�6O   $��15(�6j   �� 5   
   $��Email Address��6   $��Center=�6(   $��3��6F   $��Center=�6S   $��15(�6n   �� 5   
   $��Username��6   $��Center=�6#   $��4��6A   $��Center=�6N   $��15(�6i   �� 5   
   $��Password��6   $��Center=�6#   $��5��6A   $��Center=�6N   $��15(�6i   �� 5   
   $��Enter Employee ID��6   $��Center=�6,   $��6��6J   $��Center=�6W   $��15(�6r   �� 5    
   -   5         ��Name$
 edit��5       $
��Edit��6   $��1��6.   $��Center=�6>   $��7��6[   $��Center=�6h   $	��101��6�   $��37��6�   $��15(�6�   $��
179,0,0,16q�6�   6�   �� 5!   
   -   5         ��Name$ edit_f_name��5!      $��1��6(   $��Center=�68   $��23��6U   $��2��6b    �� TextWrapping$
 Wrap=�6o   $��Center=�6�   $	��220��6�   �� 5"   
   -   5        $ 
edit_email��5"      $��1��6'   $��Center=�67   $��23��6T   $��3��6a   $
 Wrap=�6n   $��Center=�6�   $	��220��6�   �� 5#   
   -   5        $ edit_username��5#      $��1��6*   $��Center=�6:   $��23��6W   $��4��6d   $
 Wrap=�6q   $��Center=�6�   $	��220��6�   G� 5$   
   -   5         G�Name$ edit_password��5$      $��1��6-   $��Center=�6=   $��5��6[   $��Center=�6h   $��23��6�   $	��220��6�   �� 5%   
   -   5        $ 
edit_empid��5%      $��1��6&   $��Center=�66   $��6��6T   $��Center=�6a   $��23��6|   $	��220��6�   �� 5&   
   -   5        $ back_btn��5&      $
��Back��6#   $
��Left=�62   $��74,0,0,0q�6M   $��1��6_   $	��Top=�6l   $��76��6�   6�   5)      5*      