   M S B A M L   `   `   `  ���� \  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source �� 
TargetType   StandardMenu �� 	Resources �� Property �� Value �� 
TargetType  MenuSeparatorBorderBrush �� Path �� RelativeSource	 �� AncestorType
 ��Name J� SnapsToDevicePixels �Name � ColumnDefinitions ��Name z� SharedSizeGroup ��Name F�Name �Name � HorizontalOffset � AllowsTransparency  SubmenuItemBackground � IsSharedSizeScope K� IsItemsHost-    'System.Windows.Input.KeyboardNavigation    DirectionalNavigation J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Color �� Triggers P� Property P� Value �� 
TargetName �� ElementName  ]� 
Conditions! �� Property" �� Value ! MenuItemHighlightedBackground $  SubmenuItemBackgroundHighlighted  BackgroundSelected  MenuDisabledForeground  LightBackground  
Foreground 	 MetroSeparator 
 	TextBrush  MetroMenuItem  ContentFontFamily  ContentFontSize# �� RadiusX$ �� RadiusY% J� Opacity& m� Icon  HighlightBrush' �� Triggers  MenuItemDisabledBrush  StandardContextMenu  ControlBackgroundBrush( �� CornerRadius)   Opacity*   
BlurRadius+ � Triggers, :� RoutedEvent- g� Duration	. W� To/ �� TargetProperty0 �� 
TargetName�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml        �� $ ../Core/Resources.xaml?�%�  &	        &		 ,    &	 �    &	     �� " o� ���� '��       " ��(��       *MenuItem.SeparatorStyleKey+).���  � ��$ 1����  � �� �� " ��.R��� #���  $��1q�$��25,0,0,0q��� 'm�       " m�.���  � �� �� $ 
Foreground� �� "	 o���  � �� �� " m�.R��� $
 Border��
������ 
������ $��1q� .  ._�� $
 Grid�� �� $
 Col0��$��17��$
��Auto �$ MenuItemIconColumnGroup���� $
��Auto �$ MenuTextColumnGroup���� $
��Auto �$ MenuItemIGTColumnGroup���� $
 Col3��$��14 �.+��� $
 Icon��$��0��$��Center=�$
��Icon���� $ 
HeaderHost��$��1��#��z����. $��Header��$��Center=��� $ IGTHost��$��2��$��8,1,8,1q�$��InputGestureText��$��Center=�� $ 
ArrowPanel��$��3��$��4,0,6,0q�$��Center=�.+�F� $ ArrowPanelPath��$��Right=�$��Center=�#��z��"����        �     z � 	=  	= 	� $ SubMenuPopup��$��Right=�$ -1��|�.  #��� -� . ���� $ IsSubmenuOpen� �� *TemplatedParent+.��� $��0,0,5,5q�.+��� $
 SubMenuBorder��#���  $��1q�#���   . ._�� $ SubMenu�� . $��2q�.+���  . $ Cycle=�   $ 2Q�$ Black���� $
 TransitionBorder��$��1,0,0,0q�$��0��$��2��$	��Top=�$
��Left=�#���   .  $��1q�#���   P�  �@m�Role$ TopLevelHeader=�. ���  � ��$ 6,0,6,2q��� $ SubMenuPopup�� � ��$ Bottom=��� $
 Col0�� � ��$ 0���� $
 Col3�� � ��$
 Auto ��� $
 Icon�� � y�$ 	Collapsed=��� $ IGTHost�� � y�$ 	Collapsed=��� $ 
ArrowPanel�� � y�$ 	Collapsed=��� $ SubMenuBorder�� � ��$ 1,1,1,1q��� $ SubMenu�� � ��$ 2,3,2,2q��� $ TransitionBorder�� �� *ActualWidth+$
 Grid�� � ��P�  �@m�Role$ TopLevelItem=�. ���  � ��$ 6,0,6,2q��� $
 Col0�� � ��$ 0���� $
 Col3�� � ��$
 Auto ��� $
 Icon�� � y�$ 	Collapsed=��� $ IGTHost�� � y�$ 	Collapsed=��� $ 
ArrowPanel�� � y�$ 	Collapsed=�P�  �@m�Role$ SubmenuHeader=�. ���  � ��$	 Top=���  � ��$ 10,3,0,3q��� $ Border�� � ��$ 22���� $ Border��# �   � ��P�  �@m�Role$ SubmenuItem=�. ���  � ��$	 Top=���  � ��$ 10,3,0,3q��� $ Border�� � ��$ 22���� $ 
ArrowPanel�� � y�$ 	Collapsed=��� $ Border��# �   � ��]�   �� ! �@m�IsHighlighted" . �� ! �@m�Role$" TopLevelHeader=�./��� $ Border��# �   � ��]�   �� ! �@m�IsHighlighted" . �� ! �@m�Role$" TopLevelItem=�./��� $ Border��# �   � ��]�   �� ! �@m�IsHighlighted" . �� ! �@m�Role$" SubmenuHeader=�./��� $ Border��# �   � ��]�   �� ! �@m�IsHighlighted" . �� ! �@m�Role$" SubmenuItem=�./��� $ Border��# �   � ��]�   �� ! �@m�IsSubmenuOpen" . �� ! �@m�Role$" TopLevelHeader=�./��� $ Border��# �   � ���� $ Border��# �   � ���� $ Border�� � ��$ 1,1,1,0q�P�  �@m�IsSubmenuOpen . . ��� $ ArrowPanelPath��# �   � ��P� " �@m�IsSuspendingPopupAnimation . . ��� $ SubMenuPopup�� � ��$
 None=�P�  Z�  �@m�Icon. ��� $
 Icon�� � y�$ 	Collapsed=�P�  � {� .  . ��� # �   � ��.���  � ��# �  ��  � ��# �  �� " ��.���  � ��# � 
 ��  � �� .  ��  � ��$ 6,2,6,2q���  � �� �� " ��.R��� #��z��#��z��#��z��$��1���� " m�.���  � �� �	#00FFFFFF��  � ��# �  ��  � ��# �  ��  � ��# � 
 ��  � �� �	#00FFFFFF��  � ��$ 0q���  � ��$ 8,2,10,2q���  � �� �� " m�.R�� .+��� $��Bg��$# 0��$$ 0��$	% .65Q�#��z��#��z��#��z��� #��z�� �� $
��Auto ��� $��2 ��� $��* ��� $��17 �.+��� $��IconPresenter��#��z& $��1q�$% .7Q�$��Center=��� $��	Presenter��#��z��#��z��$��2�� P�  �@m�IsHighlighted . . ��� $ Bg��# �   � ����  � �� �	#FFFFFFFF' P�  � {� .  . ���  � ��# �  �� " ��.���  � ��# �  ��  � ��$ 1q���  � ��# �  ��  � ��$ 0,4,0,4q���  � �� �� " ��.R��� $
��Menu��$��5,5,5,5q�$% 0Q�#��z��#��z��#��z��$( 0��   $ 1Q�$	) 0.6Q�$* 5Q�+ :� $, Rectangle.Loaded��.[��� .���� .��W� $- 0:0:0.2D�$. 1X�$/ Opacity�$
0 Menu��._�� .+��� #��z��