   M S B A M L   `   `   `  ����H  DOnlineShopApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:OnlineShopAppOnlineShopApp  5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       OnlineShopApp.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:OnlineShopApp     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  ZCBR - best online shop��5   	   $	��750��6)   $
��1500��66    � WindowStartupLocation$ CenterScreen=�5	   	   $��1q�5
   	      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   5   	   .��5      � ��5   
   �� 5       �� ImageSource$+ %D:\Labs\OnlineShopApp\background4.jpg��6    j� Stretch$ UniformToFill=�6M    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $	��100��6   $��98��6   $��0,24,0,0q�6(   $	��Top=�6:   ��5      �� 5       �� DecodePixelWidth$	 500��6    �� 	UriSource$% D:\Labs\OnlineShopApp\logo4.png?�65   5      �� 5   
   $��1��6   $	��100��6!   $��29,68,1261,0q�6-   $��Search��6C   
���`���$��20(�6l   $��Buxton Sketch)�6z   $��39��6�   $	��Top=�6�   �� 5   
   $��Search for some product��6   $��1��61   $��40��6A   	 �� 	IsEnabled	 . 
 � Language$
 en-en�6i   $��147,71,355,0q�6z   $	��Top=�6�   $��30(�6�   $��Buxton Sketch)�6�   �� 5    
   $��80��6   $��80��6   $��1��6'   $��
1307,6,3,0q�67   $	��Top=�6K   ��5!      �� 5"      $	 500��6   $&  D:\Labs\OnlineShopApp\basket.png?�65   5$      �� 5%   
   $��70��6   $��70��6   $��1��6'   $��1232,6,88,0q�67   $	��Top=�6L   ��5&      �� 5'      $	 500��6   $$ D:\Labs\OnlineShopApp\like.png?�65   5)      �� 5*   
   $��70��6   $��70��6   $��1��6'   $��1146,6,174,0q�67   $	��Top=�6M   ��5+      �� 5,      $	 500��6   $' !D:\Labs\OnlineShopApp\person1.png?�65   5.      �� 5/   
   $��70��6   $��70��6   $��1��6'   $��1054,6,266,0q�67   $	��Top=�6M   ��50      �� 51      $	 500��6   $&  D:\Labs\OnlineShopApp\libra3.png?�65   53      �� 54   
   -   5         ��Name$ label��54      $
��Like��6   $��1��6.   $
��Left=�6>   $��1235,81,0,0q�6Y   $��30(�6n   $��Buxton Sketch)�6|   $��47��6�   $	��Top=�6�   $��2��6�   �� 55   
   -   5        $ 
label_Copy��55      $��Chart��6$   $��1��64   $
��Left=�6D   $��1307,75,0,0q�6_   $	��Top=�6t   $��30(�6�   $��Buxton Sketch)�6�   �� 56   
   -   5        $ label_Copy1��56      $��Cabinet��6%   $��1��67   $
��Left=�6G   $��1142,81,0,0q�6b   $	��Top=�6w   $��30(�6�   $��Buxton Sketch)�6�   $��2��6�   �� 57   
   -   5        $ label_Copy2��57      $��Compare��6%   $��1��67   $
��Left=�6G   $��1040,80,0,0q�6b   $	��Top=�6w   $��30(�6�   $��Buxton Sketch)�6�   $��2��6�   58      59      