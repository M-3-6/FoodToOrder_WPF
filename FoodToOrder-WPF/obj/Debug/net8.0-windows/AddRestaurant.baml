   M S B A M L   `   `   `  ����J  FFoodToOrder_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FoodToOrder_WPFFoodToOrder_WPF  5   	   #    FoodToOrder_WPF.AddRestaurant   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FoodToOrder_WPF     5   	     � Title$  Add Restaurant��5   	   $	��600��6    $	��800��6-   ���#2d2d2d.��5	      (�  (� Stretch$ Uniform=�6   .��5
   
   � $��15q�6   $��Center=�6   $��Center=�68    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6     � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $
��auto �6#   .+�5   
   �� $��Add Restaurant Details:��6   $��5 5 5 5q�62   $��14(�6C   $��130pt��6Q   �� 5   
   $��1��6   $��Restaurant Name:��6   $��5 5 5 5q�68   $��14(�6I   $��130pt��6W   �� 5      -   5        $��restaurantOpenStatus��5   $   $��2��6   $��Restaurant Open?��6@   $��5 5 5 5q�6[   $��14(�6l   $��130pt��6z   �� 5      -   5        $��restaurantNameLabel��5      $��1��61   $��1��6>   $��5 5 5 5q�6N   $��14(�6_   $��130pt��6m   �� 5   
   $��3��6   $��Add the dishes:��6   $��5 5 5 5q�67   $��14(�6H   $��130pt��6V   �� 5   
   -   5        $��1��5      $��3��6!   $	��Add��6.   $��5 5 5 5q�6<   $��14(�6M   $��130pt��6[   6i   �� 5   
   -   5        $��1��5      $��4��6!   $��Submit��6.   $��5 5 5 5q�6?   $��14(�6P   $��130pt��6^   6l   5       5!      5"      