   M S B A M L   `   `   `  ����C  ?keyboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:keyboardkeyboard  5   	       keyboard.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:keyboard     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��900��6)    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   	   $|�False��5   	    � 	Resources 5       �� 
TargetType   
mainBorder �� Property �� Value	 �� Color
 �� Opacity  mainTextLeft  mainTextRight �� BasedOn��%d  &	        &	 �     &	 �    7  �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      $	 #90A3BF��6&   $
 .2Q�66   5      �� 5       �@��CornerRadius$ 9��6-   5      �� 5   
   " ��6   .�5      ��  � �� �#1A202C6+   �� 5        � ��$ 14.34(�6)   �� 5!       � ��$ Center=�62   �� 5"       � ��$
 Bold"�6+   �� 5#       � ��$
 Left=�64   �� 5$       � ��$ 5, 0 , 0 ,0q�6'   5%      �� 5&   
   " ��6   8   .�5'      ��  � ��$ Right=�64   �� 5(       � ��$ 0, 0 , 5 ,0q�6'   5)      5+      .��5,      �� #��[  6    �� Padding$ 5q�61   ._�5-   
   �  � RowDefinitions 5.      �� 5/      $	��.1* �6    �� 50      $	��.3* �6    �� 51      $	��.9* �6    .+�53      � $��0��6    � ColumnDefinitions 54      �� 55      $	��.2* �6'   �� 56      $	��.6* �6'   �� 57      $	��.2* �6'   .+�59      �� $��0��6   $��ONEPOS Keyboar��6-   #��[ 6C   � 5:      $��1��6   .+�5;      �� -   5         ��Name$ AR��5;   �    � Cursor$
 Hand��6    $��24(�6[   $
��Bold"�6i   $��30 , 0 , 0,0q�6{   $��AR��6�   $��Center=�6�   $
��Left=�6�   �� 5<      -   5        $ EN��5<   �   $
 Hand��6    $��24(�6[   $
��Bold"�6i   $��0 , 0 , 30,0q�6{   $��EN��6�   $��Center=�6�   $��Right=�6�   5=      �� 5>      -   5        $
 exit��5>   *   $
 Hand��6   $��2��6g   $��X��6w   #��[ 6�   $��25(�6�   5?      �� 5@      -   5         ��Name$ El��5@   r    �� AcceptsReturn$
 True��6    �� TextWrapping$
 Wrap=�6+   " �� VerticalScrollBarVisibility$ Visible=�6?   $��1��6e   6r   >� 5B      -   5         >�Name$ mainKeyboard��5B      $��2��62   5C      5D      5E      