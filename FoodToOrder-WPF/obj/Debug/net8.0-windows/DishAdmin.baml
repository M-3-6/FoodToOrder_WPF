   M S B A M L   `   `   `  ����J  FFoodToOrder_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FoodToOrder_WPFFoodToOrder_WPF  5   	   C&clr-namespace:FoodToOrder_WPF.controlsFoodToOrder_WPF.controls  5   	       FoodToOrder_WPF.DishAdmin   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FoodToOrder_WPF     5   	   =
mycontrols&clr-namespace:FoodToOrder_WPF.controls     5   	     � Title$  
Dish Admin��5	   	   $	��600��6   $	��800��6)   ���#2d2d2d.��5
      (� .��5   
   � -   5        $��DishAdminScreenGrid��5       � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� -   5        $��DishesAdminHeading��5      $��5 5 5 5q�62   $��DISHES��6C    �� TextAlignment$ Center=�6Q   $��18(�6h   $
��Bold"�6v   �� 5      $��1��6    �� Orientation$ 
Horizontal=�6&   .+�5      �� $
 Left=�6   $��17 8 0 8q�61   $	��170��6C   $
��NAME��6O   �� 5      $ Center=�6   $	��0 8q�63   $��70��6@   $��
PRICE(Rs.)��6K   5      �� 5      -   5        $��dishAdminListBox��5   q   ���#2d2d2d$��Center=�6-   $��5 5 5 5q�6Q   $��330pt��6c   $��2��6�   $��Center=�6�   ��6�   �� *Dishes+��5      �� 5      .R�5      �� $ 
Horizontal=�6%   .+�5      �� $	��0 8q�6(   $	��170��65   ��6A   �� *
DishName+�� 5        ��Name$ DishAdminPriceText��6(   $	��0 8q�6D   $��50��6Q   ��6\   �� *Price+*   $FoodToOrder_WPF.controls.DishControl  5!      $��Right=�65      Dish 6R   �� 5#      5$      5&      �� 5'      -   5        $
��Done��5'      $��3��6$   61   5(      5)      5*      