   M S B A M L   `   `   `  ���� \  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source   ScrollBarLineButton �� 
TargetType �� Property �� Value  BackgroundNormal  BorderBrushNormal �� 
TargetType  
Foreground �� Path �� RelativeSource �� Triggers	 P� Property
 P� Value  BackgroundHighlighted  BorderBrushHighlighted  BackgroundSelected  BorderBrushSelected  ScrollBarPageButton �� Triggers ,	 (ScrollBarPageButtonBackgroundHighlighted 
 ScrollBarThumb  VerticalScrollBar � RowDefinitions ]� DecreaseRepeatButton ]� Thumb ]� IncreaseRepeatButton  HorizontalScrollBar � ColumnDefinitions  StandardScrollBar�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml        �� $ ../Core/Resources.xaml?�%�  &	        &	 �    &	
 �    &	     &	 z    &	 �    �� " ��.���  �@J�SnapsToDevicePixels . ��  �@�FocusVisualStyle Z� ��  � |� .  ��  � ��# �  ��  � ��# �  ��  � �� �� " ��.R��� #��z��#��z��$��1q�._�F� $��Center=�$��Center=�#���  ���� $ Content� �� *TemplatedParent+ P� 	 �@J�IsMouseOver
 . . ��� # �   � ���� # �   � ��P� 	 � ��
 . . ��� # �   � ���� # �   � ���� " ��.���  �@J�SnapsToDevicePixels . ��  �@�FocusVisualStyle Z� ��  � ��
 ���� ��  � �� �� " ��.R��� #��z�� P� 	 �@J�IsMouseOver
 . . ���  � ��# � 	 �� " n�.���  �@�FocusVisualStyle Z� ��  �@J�SnapsToDevicePixels . ��  � �� .  ��  � |� .  ��  � ��# �  ��  � ��# �  ��  � �� �� " n�.R��� #��z��#��z��$��1q� P� 	 �@J�IsMouseOver
 . . ��� # �   � ���� # �   � ��P� 	 �@n�
IsDragging
 . . ��� # �   � ���� # �   � ���� " ��.R��  �� $��18 ��� �� $��18 �.+��� $��0��#���   $��M 0 4 L 8 4 L 4 0 Z��$��ScrollBar.LineUpCommand��]� $��
PART_Track��$��1����.  �� #���  $��ScrollBar.PageUpCommand�� n� #��� 
  �� #���  $��ScrollBar.PageDownCommand���� $��2��#���   $��ScrollBar.LineDownCommand��$��M 0 0 L 4 4 L 8 0 Z���� " ��.R��  �� $��18 ��� �� $��18 �.+��� $��0��#���   $��M 0 4 L 4 8 L 4 0 Z��$��ScrollBar.LineLeftCommand��]� $��
PART_Track��$��1����.   �� #���  $��ScrollBar.PageLeftCommand�� n� #��� 
  �� #���  $ ��ScrollBar.PageRightCommand���� $��2��#���   $��M 4 4 L 0 8 L 0 0 Z��$ ��ScrollBar.LineRightCommand���� " ��.���  �@�FocusVisualStyle Z� ��  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle .  P� 	 �@��Orientation$
 Vertical=�. ���  � ��$ 18����  � ��$
 Auto����  � ��# �  P� 	 �@��Orientation$
 
Horizontal=�. ���  � ��$ 18����  � ��$
 Auto����  � ��# �  