   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   StandardCheckBox  �� 
TargetType �� Property �� Value  
Background  
Foreground  BorderBrushNormal �� 
TargetType'   !System.Windows.VisualStateManager    VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame	 O� KeyTime
 O� Value R� KeyTime R� Value  System.Windows.Visibility � ColumnDefinitions J� Opacity # LinkbuttonForegroundHighlighted  BackgroundSelected �� Stretch  BorderBrushSelected � UseLayoutRounding �� StrokeStartLineCap �� StrokeEndLineCap  BorderBrushHighlighted �� RadiusY �� RadiusX  StandardRadioButton 	 BackgroundHighlighted ^� PlacementTarget �� RelativeSource ^� ToolTip _� 	Placement � DataContext _� PlacementTarget � Triggers :� RoutedEvent �� Triggers P� Property P� Value  �� 
TargetName! ]� 
Conditions" �� Property# �� Value�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     ,b&clr-namespace:System;assembly=mscorlib  %�  &	        &	 H    �� "  ��.���  �@�FocusVisualStyle Z� ��  � ��# �  ��  � ��# �  ��  � ��$
 Left=���  � ��$	 Top=���  � ��$ 4,1,0,0q���  � ��$ 1q���  � ��# �  ��  � �� �� " ��.R��    CommonStates��.   
Normal��  	MouseOver��. �� .��U� $ (UIElement.Opacity)�$ MouseOverRectangle��.\�  $	 0:0:0.1��$
 1Q�U� $ (UIElement.Opacity)�$
 grid��.\�  $	 0:0:0.1��$
 1Q�  Pressed��. �� .��U� $ (UIElement.Opacity)�$ PressedRectangle��.\�  $	 0:0:0.1��$
 1Q�  Disabled��. �� .��U� $ (UIElement.Opacity)�$ contentPresenter��.\��� $	 0��$	
 .55Q�U� $ (UIElement.Opacity)�$ DisabledVisualElement��.\��� $	 0��$

 0.55Q�  CheckStates��.   Checked��. �� .��U� $ (UIElement.Opacity)�$ 	CheckIcon��.\��� $	 0��$
 1Q�  	Unchecked��  Indeterminate��. �� .��U� $ (UIElement.Opacity)�$ IndeterminateIcon��.\��� $	 0��$
 1Q�  FocusStates��.   Focused��. ��   	Unfocused��  ValidationStates��.   	Valid��  InvalidUnfocused��. �� .��T� $ 
Visibility�$ ValidationErrorElement��..�i� $ 0��  Visible=�  InvalidFocused��. �� .��T� $ 
Visibility�$ ValidationErrorElement��..�i� $ 0��  Visible=�T� $ IsOpen�$ validationTooltip��..�i� $ 0�� ��True�� �� $��16 ��� $��* �.+�� $
��Left=�$	��Top=�.+�� $
��grid��$��14��$��14��$	 0.7Q�$��	1,1,-1,-1q�.+��� $��
Background��#��z��#��z��#��z���� $��MouseOverRectangle��#���  $ 0Q��� $��PressedRectangle��#���  $ 0Q�F� $��	CheckIcon��$ 0Q�"����<[�|$�����_���4\�|d	$��Center=�$	��7.6��$
 Fill=�#���   .  $��Center=�$	��8.9��$ Triangle=�$ Triangle=�$��2���� $��IndeterminateIcon��$��8��$��8��$ 0Q�#���  �� $��DisabledVisualElement��#���  $ 0Q�$ 1��$ 1���� $��1��#���  .���� $��contentPresenter��#��z��#��z��#��z��$��4,0,0,0q�#��z���� "  	�.���  � ��# �  ��  � ��# �  ��  � ��$
 Left=���  � ��$	 Top=���  � ��$ 4,1,0,0q���  � ��$ 1q���  � ��# �  ��  � �� �� " 	�.R��  �� $��16 ��� $��* �.+�� $
��Left=�$��Center=�.+�� $
��grid��$��15��$��15��$	 0.7Q�.+�A� $��
Background��#��z��#��z��$��1q�#��z��A� $��MouseOverEllipse��#���  $��1q�$ 0Q�A� $��PressedEllipse��#���  $��1q�$ 0Q�#��� 	 A� $��	CheckIcon��#���  $��7��$ 0Q�$��7��A� $��DisabledVisualElement��#��� 	 $ 0Q�� $��ValidationErrorElement��$y�	Collapsed=� ��  �� *TemplatedParent+ _� $��validationTooltip��$ Right=� ��  �� *TemplatedParent+ ��  �� *TemplatedParent+ :� $ Canvas.Loaded��.[��� .���� .��T� $ IsHitTestVisible�$ validationTooltip��..�i� $ 0�� ��true��.+�A� $��14��#���  $��1��$��14��A� #���  $��Right=�$��4��$��	0,-2,-1,0q�$	��Top=�$��4��A� ���	#00FFFFFF$��Right=�$��10��$��	0,-5,-4,0q�$	��Top=�$��10���� $��1��#���  .���� $��contentPresenter��#��z��#��z��#��z��#��z��#��z�� P�  �@d�	IsChecked$
 trueY�. ��� $  	CheckIcon�� �@J�Opacity$ 1Q�P�  � �� . . ��� $  PressedEllipse�� �@J�Opacity$ 1Q�P�  �@J�IsMouseOver . . ��� $  MouseOverEllipse�� �@J�Opacity$ 1Q��� $
  grid�� �@J�Opacity$ 1Q�]� ! �� " �@d�	IsChecked$
# trueY��� " � ��# . ./��� $  	CheckIcon��# �   � ��P�  � {� .  . ��� $  contentPresenter�� �@J�Opacity$
 0.55Q��� $
  grid�� �@J�Opacity$
 0.55Q�