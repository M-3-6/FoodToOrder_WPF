   M S B A M L   `   `   `  ����J  FFoodToOrder_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FoodToOrder_WPFFoodToOrder_WPF  5   	       FoodToOrder_WPF.ViewDish   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FoodToOrder_WPF     5   	     � Title$  ViewDish��5   	   $	��600��6   $	��800��6'   ���#2d2d2d.��5
      (� .��5   
   � -   5        $��DishScreenGrid��5       � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6     � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   .+�5      �� $��0��6   $��5 5 5 5q�6%   $��DISHES��66    �� TextAlignment$ Center=�6D   $��18(�6[   $
��Bold"�6i   �� 5      $��1��6   $��0��6%   $��5 5 5 5q�66   $
��NAME��6G   $ Center=�6S   $��14(�6j   $
��Bold"�6x   �� 5      $��1��6   $��1��6%   $��5 5 5 5q�65   $��PRICE (Rs.)��6F   $ Center=�6Y   $��14(�6p   $
��Bold"�6~   �� 5      -   5        $��
DishesList��5   �   $��2��6   $��0��6#   $��5 5 5 5q�64   $
��Left=�6E   $��100pt��6a   ���#2d2d2d$��Center=�6�   �� 5      -   5        $��DishesPriceList��5   �   $��2��6   $��1��6#   $��5 5 5 5q�64   $��Center=�6E   $��100pt��6b   ���#2d2d2d$��Center=�6�   �� 5      -   5        $��
DishImages��5   �   $�� 2��6   $��2��6$   $��5 5 5 5q�64   $��Right=�6E   $��100pt��6a   ���#2d2d2d$��Center=�6�   5       5!      5"      