   M S B A M L   `   `   `  ����\  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source   StandardGroupBox �� 
TargetType �� Property  
Foreground �� Value  BackgroundNormal �� 
TargetType J� SnapsToDevicePixels � RowDefinitions  StandardProgressBar  
Background  BorderBrushSelected �Name'    !System.Windows.VisualStateManager	    VisualStateGroups%   System.Windows.VisualStateGroup
   States    System.Windows.VisualState   
Storyboard g� RepeatBehavior �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value8  2System.Windows.Media.Animation.EasingPointKeyFrame $� KeyTime $� Value ��Name  BackgroundSelected J� RenderTransformOrigin �� Triggers P� Property P� Value �� 
TargetName �� Angle�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5        5      �� 5   
   $ ../Core/Resources.xaml?�6   %�  &	        &	 �    �� 5      " ��5      .�5   
   ��  � ��# �  5	      �� 5
   
    � ��# �  5      �� 5   
    � ��$ 2q�5      �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �  .  5      �� 5      $��20 �6,   �� 5      $
��Auto �6,   .+�5      �� $��Header��6+   $��2q�5   +   �� 5      #��z��6+   $��1��5   +   �� 5       . #��z��5   !   #��z��5   !   $��1��5   !   5      5      5!      5"      �� 5#      " �5$      .�5%   
   ��  � ��# �  5&      �� 5'   
    � ��# �  5(      �� 5)   
    � ��# �  5*      �� 5+   
    � ��$ 1q�5,      �� 5-   
    � �� 5.      �� 5/      " �6"   .R�50      � $ TemplateRoot��6   	 51        52      CommonStates��.
 53   "     Determinate��6.     54   "   Indeterminate��. 55   &   �� $ Forever��61   .��56   *   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6H   $ 	Animation��57   H   .\�58   .     $ 0��6C   $
 0.25Q�59   C     5:   .   $ 0:0:1��6C   $
 0.25Q�5;   C     5<   .   $ 0:0:2��6C   $
 0.25Q�5=   C   5>   +   *� 5?   *   $' !(UIElement.RenderTransformOrigin)�6G   $ 	Animation��5@   G   .'�5A   .     $ 0��6B   $ -0.5,0.5&�5B   B     5C   .   $ 0:0:1��6B   $ 0.5,0.5&�5D   B     5E   .   $ 0:0:2��6B   $ 1.5,0.5&�5F   B   5G   +   5H   '   5I   #   5J      .+�5L      �� #��z��6!   #��z��5M   !   #��z��5N   !   �� 5O      $ 
PART_Track��6$   � 5P      $ PART_Indicator��6   }�. $
��Left=�5R      .+�5S      �� $ 	Indicator��6(   #���  5T   (   �� 5U      $ 	Animation��6(   #���  5V   (   $ 0.5,0.5&�5W   (   z�5X   "   V� 5Y   &   .~�5Z   *   �� �� 5[   *   �� 5\   *   T� 5]   *   5^   '   5`      5a      5b       5c      P� 5d       �@�Orientation$ Vertical=�5e   "   . �5f      �� $ TemplateRoot��5g   %    �@�LayoutTransform 5h   "   �� 5i   &   $	 -90Q�66   5k      5l      P� 5m       �@�IsIndeterminate . . �5o      �� $ 	Indicator��5p   %    � y�$ 	Collapsed=�5q   %   5r      5t      5v      5w      5x      