   M S B A M L   `   `   `  ����   UFSJ    UFSJ.PresentWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     �Name$  PresentsWindow�� � Title$ Pre Defined Manager��$	��311��$	��479�� � Topmost . $	��300�� � Icon$ ../Resources/STD.ico��$	��400�� � 
ResizeMode$ CanResizeWithGrip=� � WindowStartupLocation$ CenterOwner=�   
Background#���    � AllowsTransparency .  � WindowStyle$
 None=�  BackgroundSelected#���  ����  �� 
TargetType" �.��� 	 �� Property	 � ��  
Foreground
 �� Value#
 �  �� 	 � ��  LightBackground#
 �  �� 	 �@�WindowStyle$

 None=��� 	 � ��
 ��  �� 
TargetType" �.R�� .+���  ��Name$ 
MainBorder��-   $��1q�#���    BorderBrushSelected#���  ._�]� ��. .+��� $ PART_TITLEBAR��$��0,0,0,0q�$��28��$	��Top=�
������ ._�]� ��.  $��0,0,0,0q�.+��� $��4,0,0,4q�$��Center=����	#FFAAAAAA$��NoWrap=�#��z $��16(���  ��Name$ 
PART_CLOSE��-   $��Right=�$��Center=�$��5q�$��20��$��20��  MetroWindowButtonStyle#���  .��F� �����T�8����L�F�=�Q,�8�z6�0@��R�� �Rȱ T�8��� �p��} ���} ����� �(R�����=�U0@��� �<�� �} ȱ �} $˗ ��� �$��S | @ȱ $��S | @�� $˗ �z6�0@��� H��$˗ ����$��S | @(��$��S | @4�$˗ �8�ȱ ��R<�� ��R�=�U0@�8�(R�$F����8�����Rp���RT�8�8��R4�8�R(��T�8��� �� Stretch$ Uniform=����	#FFAAAAAA$��10��$��0,0,0,0q��� $ PART_MAXIMIZE_RESTORE��$��Right=�$��5q�$��Center=�$��Center=�$y�Hidden=�$��20��$��20��#���  .��F� �������[y@��`���[y@+|�����+|�������`�    `� �y<4`� �y<4!d�    !d��D���"!@    ��3    � ��    Q ����x��@� ��o���3o�Q�3��x��@�D���"!@��x��@	$ Uniform=����	#FFAAAAAA$��10��$��0,0,0,0q��� $ PART_MINIMIZE��$��Center=�$��Center=�$��5q�$��Right=�$��20��$��20��#���  $��Bottom=�$y�Hidden=�.��F� +����     -1��- -1��-��� �    ��� 	$ Uniform=����	#FFAAAAAA$��10��$��0,0,0,5q���  ��Name$ WindowsResizeGrip��$��Bottom=�$��Right=���.  $y�	Collapsed=�$��Bottom=��� .u��� #��z��#��z�� �� ContentStringFormat �� ContentStringFormat# z  �� Triggers ]�  ]� 
Conditions ��  �� Property �@�
ResizeMode �� Value$ CanResizeWithGrip=���  �@�WindowState$ Normal=�./���  �� 
TargetName$ WindowsResizeGrip��	 � y�$
 Visible=�.���  � ColumnDefinitions �� $	��63* ��� $	��83* �.+��� -   $ bClose�� 
 #B.19##���  $��Right=�$��0,0,10,0q�$��Bottom=�$��80�� J� RenderTransformOrigin$ 0.44,0.2&�$��1��$��30���� -    ��Name$ 	lstPreDef��$
��10,0q� J� 	AllowDrop .   StandardListBox#��[ �� -   $ bSave�� 
 #B.18##���  $��Right=�$��0,0,95,0q�$��Bottom=�$��80��$ 0.44,0.2&�$��1��$��30�� �� 	IsDefault .  � ToolTip _� �� -    ��Name$ DefSizeT�� �� TextWrapping$
 Wrap=�$��0��$	��Top=�$��7,111,135,0q� �� 	UndoLimit$ 5��$��27��$��Center=�$��Right=�$��1���� -     ��Name$  DefSizeC��$	��Top=�! �� SelectedIndex$! 0��$��
0,111,10,0q�$��27��" �� MaxDropDownHeight$	" 340��$��24��$��Center=�# �� 
IsEditable# . $ �� 
IsReadOnly$ . ���	#FFDADBDC$��1��$��Right=�$��52��.@��� -	   % ��Name$% cSplitBytes��$��Bytes���� -
   $% 
cSplitKilo��$��KB���� -   $% 
cSplitMega��$��MB���� -   $% 
cSplitGiga��$��GB���� -   $% cSplitParts�� 
	 #S.15##��� 	 ���	#FFEDFFF2$��0q��� -   $ DefName��$��27��$��	5,36,10,0q�$
 Wrap=�$	��Top=�$��Center=�$��1���� -   & ��Name$& ln�� 

 #S.0E##��� 
 $
��Left=�$��5,10,0,0q�$	��Top=�$��1��$��42��#���  �� -   $& lv�� 
 #S.21##���  $
��Left=�$��5,85,0,0q�$	��Top=�$��1��$��40��#���  �� -   ' ��Name$' gridSplitter��$��0,0,0,0q�$��2��  BorderBrushHighlighted#���  