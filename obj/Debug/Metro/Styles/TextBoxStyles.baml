   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source �� 
TargetType   StandardTextBox �� Property  TextBoxBackground �� Value  
Foreground �� 
TargetType J� SnapsToDevicePixels ��Name �� Triggers	 P� Property
 P� Value  TextBoxBackgroundSelected  SearchTextBox  SearchTextForeground �� 
TargetName  StandardPasswordBox  BackgroundSelected  
Background 	 BorderBrushNormal � 	Resources 
 Key g� Duration	 W� To �� TargetProperty �� 
TargetName W� From'   !System.Windows.VisualStateManager    VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard R� KeyTime R� Value  System.Windows.Visibility J� Opacity  BackgroundHighlighted J� IsHitTestVisible  ControlsDisabledBrush ]� 
Conditions �� Property �� Value N� EnterActions  enterGotFocus N� ExitActions  exitGotFocus�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      ,b&clr-namespace:System;assembly=mscorlib  5        5      �� 5   
   $ ../Core/Resources.xaml?�6   %�  &	        &	     &	     7  7  �� 5      " ��6   .�5	   
   ��  � ��# �  5
      �� 5   
    � ��# �  5      �� 5   
    �@��
CaretBrush# �  5      �� 5   
    � �� 5      �� 5      " ��6"   .R�5      � #��z��6    . .+�5      �� $ PART_ContentHost��6'   $��1q�5   '   5       5      P� 5      	 �@J�IsMouseOver
 . . �5      �� # �  5   %    � ��5      P� 5      	 �@J�	IsFocused
 . . �5      �� # �  5    %    � ��5!      5#      5%      5&      �� 5'      " ��6   .�5)   
   ��  � ��# �  5*      �� 5+   
    � ��# �  5,      �� 5-   
    �@��
CaretBrush# �  5.      �� 5/   
    � �� 50      �� 51      " ��6"   .R�52      � #��z��6    . .+�54      �� $��search��57   $   #���  54   $   $��5,0,0,0q�55   $   $��Center=�56   $   $��
Search ...��58   $   $y�Hidden=�59   $   �� 5:      $ PART_ContentHost��6'   $��1q�5;   '   5<       5=      P� 5>      	 � ��$
  ��5?   "   . �5@      �� $ search��6%    � y�$ Visible=�5B   %   5C      P� 5D      
 5E   "   Z� 	 � ��. �5F      �� $ search��6%    � y�$ Visible=�5H   %   5I      P� 5J      	 �@J�IsMouseOver
 . . �5L      �� # �  5M   %    � ���� 5N      $ search��6%   # �  5P   %    � ��5Q      P� 5R      	 �@J�	IsFocused
 . . �5T      �� # �  5U   %    � ���� 5V      $ search��6%    � y�$ Hidden=�5X   %   5Y      5[      5]      5^      �� 5`      " G�5a      .�5b   
   ��  �@G�SelectionBrush# �  5c      �� 5d   
    � ��$ 1q�5e      �� 5f   
    � ��$ 26��5g      �� 5h   
    � ��# �  5i      �� 5j   
    � ��# �  5k      �� 5l   
    � ��$ 0q�5m      �� 5n   
    � ��# � 	 5o      �� 5p   
    � �� 5q      �� 5r      " G�6"    5s      ���� 5t      enterGotFocus
 .��5u      W� $ 0:0:0.2D�6.   $ .2X�5v   .   $ Opacity�5w   .   $ Message��5x   .   5y      �� 5z      exitGotFocus
 .��5{      W� $ 0:0:0.2D�6.   $ Opacity�5|   .   $ Message��5}   .   5~      �� 5      enterHasText
 .��5�      W� $ 0:0:0.2D�6.   $ .2X�5�   .   $ 0X�5�   .   $ Opacity�5�   .   $ Message��5�   .   5�      �� 5�      exitHasText
 .��5�      W� $ 0:0:0.2D�6.   $ Opacity�5�   .   $ Message��5�   .   5�      5�      .R�5�      �  5�        5�      ValidationStates��. 5�   "     	Valid��6.     5�   "   InvalidUnfocused��. 5�   &   �� .��5�   *   T� $ 
Visibility�6H   $ ValidationErrorElement��5�   H   ..�5�   .   i� $ 0��6E    5�   2    5�   6   Visible=�6J   5�   /   5�   +   5�   '   5�   #     5�   "   InvalidFocused��. 5�   &   �� .��5�   *   T� $ 
Visibility�6H   $ ValidationErrorElement��5�   H   ..�5�   .   i� $ 0��6E    5�   2    5�   6   Visible=�6J   5�   /   5�   +   T� 5�   *   $ IsOpen�6H   $ validationTooltip��5�   H   ..�5�   .   i� $ 0��6E    5�   2   ��5�   6   True��6F   5�   /   5�   +   5�   '   5�   #   5�      .+�5�      �� $
��Base��6$   #��z��5�   $   #��z��5�   $   $ 1Q�5�   $   #��z��5�   $   �� 5�      $��FocusRectangle��6$   #��z��5�   $   $ 0Q�5�   $   #���  5�   $   � 5�      $��2q�6   .+�5�      �� $��ReadOnlyVisualElement��6%   $ 0Q�5�   %   ��5�   %   Z� �� 5�      $��PART_ContentHost��6+   $��0q�5�   +   ��.  $��2q�5�   +   $��Stretch=�5�   +   $��Center=�5�   +   ��5�   +   Z� 5�   +   �� 5�      $��Message��6(   $��
Write Here��5�   (   #���  5�   (    .  $	 0.6Q�5�   (   $
��Left=�5�   (   $��6,0,0,0q�5�   (   $��Center=�5�   (   5�      �� 5�      $��DisabledVisualElement��6$   #���  5�   $   #��z��5�   $   #���  5�   $    .  $ 0Q�5�   $   5�       5�      P� 5�      	 �@J�IsMouseOver
 . . �5�      �� $ FocusRectangle��6%    �@J�Opacity$ 1Q�5�   %   5�      P� 5�      	 � {�
 .  . �5�      �� $ DisabledVisualElement��6%    �@J�Opacity$ 1Q�5�   %   5�      P� 5�      	 �@J�	IsFocused
 . . �5�      �� $ FocusRectangle��6%    �@J�Opacity$ 1Q�5�   %   5�      ]� 5�       5�      �� 5�   "    �@J�	IsFocused . 6K    5�      �� 5�   "   8��  62    5�      �� 5�   "   8�� 62   5�      5�      5�      5�      5�      