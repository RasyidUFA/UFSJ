   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source �� 
TargetType   StandardTextBox �� Property  TextBoxBackground �� Value  
Foreground �� 
TargetType J� SnapsToDevicePixels ��Name �� Triggers	 P� Property
 P� Value  TextBoxBackgroundSelected  SearchTextBox  SearchTextForeground �� 
TargetName  StandardPasswordBox  BackgroundSelected  
Background 	 BorderBrushNormal � 	Resources 
 Key g� Duration	 W� To �� TargetProperty �� 
TargetName W� From'   !System.Windows.VisualStateManager    VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard R� KeyTime R� Value  System.Windows.Visibility J� Opacity  BackgroundHighlighted J� IsHitTestVisible  ControlsDisabledBrush ]� 
Conditions �� Property �� Value N� EnterActions  enterGotFocus N� ExitActions  exitGotFocus�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     ,b&clr-namespace:System;assembly=mscorlib    �� $ ../Core/Resources.xaml?�%�	  &	        &	     &	 R    7  7  �� " ��.���  � ��# �  ��  � ��# �  ��  �@��
CaretBrush# �  ��  � �� �� " ��.R�� #��z�� . .+��� $ PART_ContentHost��$��1q� P� 	 �@J�IsMouseOver
 . . ��� # �   � ��P� 	 �@J�	IsFocused
 . . ��� # �   � ���� " ��.���  � ��# �  ��  � ��# �  ��  �@��
CaretBrush# �  ��  � �� �� " ��.R�� #��z�� . .+��� $��search��#���  $��5,0,0,0q�$��Center=�$��
Search ...��$y�Hidden=��� $ PART_ContentHost��$��1q� P� 	 � ��$
  ��. ��� $ search�� � y�$ Visible=�P� 
 Z� 	 � ��. ��� $ search�� � y�$ Visible=�P� 	 �@J�IsMouseOver
 . . ��� # �   � ���� $ search��# �   � ��P� 	 �@J�	IsFocused
 . . ��� # �   � ���� $ search�� � y�$ Hidden=��� " G�.���  �@G�SelectionBrush# �  ��  � ��$ 1q���  � ��$ 26����  � ��# �  ��  � ��# �  ��  � ��$ 0q���  � ��# � 	 ��  � �� �� " G� ���� enterGotFocus
 .��W� $ 0:0:0.2D�$ .2X�$ Opacity�$ Message���� exitGotFocus
 .��W� $ 0:0:0.2D�$ Opacity�$ Message���� enterHasText
 .��W� $ 0:0:0.2D�$ .2X�$ 0X�$ Opacity�$ Message���� exitHasText
 .��W� $ 0:0:0.2D�$ Opacity�$ Message��.R��    ValidationStates��.   	Valid��  InvalidUnfocused��. �� .��T� $ 
Visibility�$ ValidationErrorElement��..�i� $ 0��  Visible=�  InvalidFocused��. �� .��T� $ 
Visibility�$ ValidationErrorElement��..�i� $ 0��  Visible=�T� $ IsOpen�$ validationTooltip��..�i� $ 0�� ��True��.+��� $
��Base��#��z��#��z��$ 1Q�#��z���� $��FocusRectangle��#��z��$ 0Q�#���  � $��2q�.+��� $��ReadOnlyVisualElement��$ 0Q���Z� �� $��PART_ContentHost��$��0q���.  $��2q�$��Stretch=�$��Center=���Z� �� $��Message��$��
Write Here��#���   .  $	 0.6Q�$
��Left=�$��6,0,0,0q�$��Center=��� $��DisabledVisualElement��#���  #��z��#���   .  $ 0Q� P� 	 �@J�IsMouseOver
 . . ��� $ FocusRectangle�� �@J�Opacity$ 1Q�P� 	 � {�
 .  . ��� $ DisabledVisualElement�� �@J�Opacity$ 1Q�P� 	 �@J�	IsFocused
 . . ��� $ FocusRectangle�� �@J�Opacity$ 1Q�]�  ��  �@J�	IsFocused .  �� 8��   �� 8�� 