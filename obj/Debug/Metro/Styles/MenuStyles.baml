   M S B A M L   `   `   `  ����\  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source �� 
TargetType   StandardMenu �� 	Resources �� Property �� Value �� 
TargetType  MenuSeparatorBorderBrush �� Path �� RelativeSource	 �� AncestorType
 ��Name J� SnapsToDevicePixels �Name � ColumnDefinitions ��Name z� SharedSizeGroup ��Name F�Name �Name � HorizontalOffset � AllowsTransparency  SubmenuItemBackground � IsSharedSizeScope K� IsItemsHost-    'System.Windows.Input.KeyboardNavigation    DirectionalNavigation J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Color �� Triggers P� Property P� Value �� 
TargetName �� ElementName  ]� 
Conditions! �� Property" �� Value ! MenuItemHighlightedBackground $  SubmenuItemBackgroundHighlighted  BackgroundSelected  MenuDisabledForeground  LightBackground  
Foreground 	 MetroSeparator 
 MetroMenuItem  ContentFontFamily  ContentFontSize  	TextBrush# �� RadiusX$ �� RadiusY% J� Opacity& m� Icon  BackgroundHighlighted' �� Triggers  MenuItemDisabledBrush  StandardContextMenu  
Background  BorderBrush( �� CornerRadius)   Opacity*   
BlurRadius+ � Triggers, :� RoutedEvent- g� Duration	. W� To/ �� TargetProperty0 �� 
TargetName�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5        5      �� 5   
   $ ../Core/Resources.xaml?�6   %�  &	        &		 Y    &	
 y    &	 �    �� 5      " o�6    5   
   ���� 5	      '��       " ��5
      (��       5	      *MenuItem.SeparatorStyleKey+).�5      ��  � ��$ 1��5      �� 5       � �� 5      �� 5      " ��6*   .R�5      �� #���  6%   $��1q�5   %   $��25,0,0,0q�5   %   5      5      5      �� 5      'm�       " m�6   .�5      ��  � �� 5      �� $ 
Foreground� �� "	 o��� 5       � �� 5      �� 5      " m�6*   .R�5      �� $
 Border��6%   
������ 
������ $��1q�5!   %    .  ._�5#   "   � $
 Grid��6'    5$   &   �� 5%   *   $
 Col0��6;   $��17��5&   ;   $
��Auto �5'   ;   $ MenuItemIconColumnGroup��5(   ;   �� 5)   *   $
��Auto �6;   $ MenuTextColumnGroup��5*   ;   �� 5+   *   $
��Auto �6;   $ MenuItemIGTColumnGroup��5,   ;   �� 5-   *   $
 Col3��6;   $��14 �5.   ;   .+�50   &   �� $
 Icon��51   7   $��0��50   7   $��Center=�52   7   $
��Icon��53   7   �� 54   &   $ 
HeaderHost��56   7   $��1��54   7   #��z��55   7   ��. $��Header��58   7   $��Center=�59   7   �� 5:   &   $ IGTHost��5<   7   $��2��5:   7   $��8,1,8,1q�5;   7   $��InputGestureText��5=   7   $��Center=�5>   7   � 5?   &   $ 
ArrowPanel��5A   +   $��3��5?   +   $��4,0,6,0q�5@   +   $��Center=�5B   +   .+�5C   *   F� $ ArrowPanelPath��6/   $��Right=�5D   /   $��Center=�5E   /   #��z��5F   /   "����        �     z � 	=  	= 	5G   /   5H   '   � 5I   &   $ SubMenuPopup��5L   ,   $��Right=�5J   ,   $ -1��5K   ,   |�.  #��� -�5N   ,    . ��5I   ,   �� $ IsSubmenuOpen� �� *TemplatedParent+.��5P   *   � $��0,0,5,5q�6/   .+�5R   .   �� $
 SubMenuBorder��65   #���  5S   5   $��1q�5T   5   #���  5U   5    . ._�5W   2   � $ SubMenu��67    . $��2q�5Y   7   .+�5Z   6   ��  . $ Cycle=�5[   A   5\   3    5]   2     5^   6   $ 2Q�6G   $ Black��5_   G   5a   /   �� 5c   .   $
 TransitionBorder��5d   5   $��1,0,0,0q�5c   5   $��0��5e   5   $��2��5f   5   $	��Top=�5g   5   $
��Left=�5h   5   #���  5i   5    .  $��1q�5k   5   #���  5l   5   5m   +   5n   '   5o   #   5p       5q      P� 5r   "    �@m�Role$ TopLevelHeader=�5s   *   . �5t   &   ��  � ��$ 6,0,6,2q�5u   -   �� 5v   &   $ SubMenuPopup��6-    � ��$ Bottom=�5x   -   �� 5y   &   $
 Col0��6-    � ��$ 0��5{   -   �� 5|   &   $
 Col3��6-    � ��$
 Auto �5~   -   �� 5   &   $
 Icon��6-    � y�$ 	Collapsed=�5�   -   �� 5�   &   $ IGTHost��6-    � y�$ 	Collapsed=�5�   -   �� 5�   &   $ 
ArrowPanel��6-    � y�$ 	Collapsed=�5�   -   �� 5�   &   $ SubMenuBorder��6-    � ��$ 1,1,1,1q�5�   -   �� 5�   &   $ SubMenu��6-    � ��$ 2,3,2,2q�5�   -   �� 5�   &   $ TransitionBorder��6-    5�   -   �� *ActualWidth+$
 Grid�� � ��5�   #   P� 5�   "    �@m�Role$ TopLevelItem=�5�   *   . �5�   &   ��  � ��$ 6,0,6,2q�5�   -   �� 5�   &   $
 Col0��6-    � ��$ 0��5�   -   �� 5�   &   $
 Col3��6-    � ��$
 Auto �5�   -   �� 5�   &   $
 Icon��6-    � y�$ 	Collapsed=�5�   -   �� 5�   &   $ IGTHost��6-    � y�$ 	Collapsed=�5�   -   �� 5�   &   $ 
ArrowPanel��6-    � y�$ 	Collapsed=�5�   -   5�   #   P� 5�   "    �@m�Role$ SubmenuHeader=�5�   *   . �5�   &   ��  � ��$	 Top=�5�   -   �� 5�   &    � ��$ 10,3,0,3q�5�   -   �� 5�   &   $ Border��6-    � ��$ 22��5�   -   �� 5�   &   $ Border��6-   # �  5�   -    � ��5�   #   P� 5�   "    �@m�Role$ SubmenuItem=�5�   *   . �5�   &   ��  � ��$	 Top=�5�   -   �� 5�   &    � ��$ 10,3,0,3q�5�   -   �� 5�   &   $ Border��6-    � ��$ 22��5�   -   �� 5�   &   $ 
ArrowPanel��6-    � y�$ 	Collapsed=�5�   -   �� 5�   &   $ Border��6-   # �  5�   -    � ��5�   #   ]� 5�   "     5�   &   �� 5�   *   ! �@m�IsHighlighted" . 5�   4   �� 5�   *   ! �@m�Role$" TopLevelHeader=�5�   4   ./�5�   &   �� $ Border��6-   # �  5�   -    � ��5�   #   ]� 5�   "     5�   &   �� 5�   *   ! �@m�IsHighlighted" . 5�   4   �� 5�   *   ! �@m�Role$" TopLevelItem=�5�   4   ./�5�   &   �� $ Border��6-   # �  5�   -    � ��5�   #   ]� 5�   "     5�   &   �� 5�   *   ! �@m�IsHighlighted" . 5�   4   �� 5�   *   ! �@m�Role$" SubmenuHeader=�5�   4   ./�5�   &   �� $ Border��6-   # �  5�   -    � ��5�   #   ]� 5�   "     5�   &   �� 5�   *   ! �@m�IsHighlighted" . 5�   4   �� 5�   *   ! �@m�Role$" SubmenuItem=�5�   4   ./�5�   &   �� $ Border��6-   # �  5�   -    � ��5�   #   ]� 5�   "     5�   &   �� 5�   *   ! �@m�IsSubmenuOpen" . 5�   4   �� 5�   *   ! �@m�Role$" TopLevelHeader=�5�   4   ./�5�   &   �� $ Border��6-   # �  5�   -    � ���� 5�   &   $ Border��6-   # �  5�   -    � ���� 5�   &   $ Border��6-    � ��$ 1,1,1,0q�5�   -   5�   #   P� 5   "    �@m�IsSubmenuOpen . . �5  &   �� $ ArrowPanelPath��6-   # �  5  -    � ��5  #   P� 5  "   " �@m�IsSuspendingPopupAnimation . . �5  &   �� $ SubMenuPopup��6-    � ��$
 None=�5
  -   5  #   P� 5  "    5  *   Z�  �@m�Icon. �5  &   �� $
 Icon��6-    � y�$ 	Collapsed=�5  -   5  #   P� 5  "    � {� .  . �5  &   �� # �  5  -    � ��5  #   5     5     5     5     .�5  
   ��  � ��# �  5     �� 5  
    � ��# �  5      5!     �� 5"     " ��6#   .�5#  
   ��  � ��# �  6/   �� 5$  
    � �� .  6.   �� 5%  
    � ��$ 6,2,6,2q�64   �� 5&  
    � �� 5'     �� 5(     " ��6"   .R�5)     �� #��z��6   #��z��6Y   #��z��6�   $��1��6�   5*     5,     5-     �� 5.     " m�6"   .�5/  
   ��  � �� �	#00FFFFFF6/   �� 50  
    � ��# �  6/   �� 51  
    � ��# �  6-   �� 52  
    � ��# �  6/   �� 53  
    � �� �	#00FFFFFF60   �� 54  
    � ��$ 0q�64   �� 55  
    � ��$ 8,2,10,2q�6,   �� 56  
    � �� 57     �� 58     " m�6"   .R�59     � .+�5:     �� $��Bg��6$   $# 0��6.   $$ 0��6:   $	% .65Q�6F   #��z��6T   #��z��6�   #��z��6�   � 5;     #��z��6    5<     �� 5=  "   $
��Auto �63   �� 5>  "   $��2 �63   �� 5?  "   $��* �63   �� 5@  "   $��17 �63   .+�5B     �� $��IconPresenter��6/   #��z& 6D   $��1q�6n   $% .7Q�6y   $��Center=�6�   �� 5C     $��	Presenter��6/   #��z��6@   #��z��6x   $��2��6�   5D     5E      5F     P� 5G      �@m�IsHighlighted . . �5H     �� $ Bg��6%   # �  65    � ��6e   �� 5I      � �� �	#FFFFFFFF6C   5J     5L     5N     ' 5O  
   P� 5P      � {� .  . �5Q     ��  � ��# �  67   5R     5T     �� 5U     " ��6(   .�5V  
   ��  � ��# �  6/   �� 5W  
    � ��$ 1q�64   �� 5X  
    � ��# �  60   �� 5Y  
    � ��$ 0,4,0,4q�6,   �� 5Z  
    � �� 5[     �� 5\     " ��6"   .R�5]     �� $
��Menu��6   $��5,5,5,5q�6)   $% 0Q�6:   #��z��6F   #��z��6z   #��z��6�   $( 0��6�    5^       5_     $ 1Q�6/   $	) 0.6Q�6?   $* 5Q�6M   + 5a     :� 5b     $, Rectangle.Loaded��6+   .[�5c  "   �� .��5d  &   �� .��5e  *   W� $- 0:0:0.2D�6:   $. 1X�6M   $/ Opacity�6T   $
0 Menu��6x   5f  '   5g  #   5h     ._�5j     � .+�5k     �� #��z��6-   5l     5m     5n     5p     5q     5r     