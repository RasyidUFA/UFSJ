   M S B A M L   `   `   `  ����   UFSJ    UFSJ.Windows.MessageWnd   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$
  UFSJ��$	��230��$	��433�� � SizeToContent$ Height=� � 
ResizeMode$ NoResize=� � Icon$( "/UFSJ;component/Resources/UFSJ.ico�� � WindowStartupLocation$ CenterScreen=� � ShowInTaskbar .   � Topmost .    
Background#���   ����  �� 
TargetType" �.���  �� Property � ��  
Foreground	 �� Value#	 �  ��  � ��  LightBackground#	 �  ��  �@�WindowStyle$
	 None=���  � ��	 �� 
 �� 
TargetType"
 �.R�� .+���  ��Name$ 
MainBorder��-   $��1q�#���    BorderBrushSelected#���  ._�]� ��. .+��� $ PART_TITLEBAR��$��0,0,0,0q�$��28��$	��Top=�
������ ._�]� ��.  $��0,0,0,0q�.+��� $��4,0,0,4q�$��Center=����	#FFAAAAAA$��NoWrap=�#��z  $��16(���  ��Name$ 
PART_CLOSE��-   $��Right=�$��Center=�$��5q�$��20��$��20��  MetroWindowButtonStyle#���  .��F� �����T�8����L�F�=�Q,�8�z6�0@��R�� �Rȱ T�8��� �p��} ���} ����� �(R�����=�U0@��� �<�� �} ȱ �} $˗ ��� �$��S | @ȱ $��S | @�� $˗ �z6�0@��� H��$˗ ����$��S | @(��$��S | @4�$˗ �8�ȱ ��R<�� ��R�=�U0@�8�(R�$F����8�����Rp���RT�8�8��R4�8�R(��T�8��� �� Stretch$ Uniform=����	#FFAAAAAA$��10��$��0,0,0,0q��� $ PART_MAXIMIZE_RESTORE��$��Right=�$��5q�$��Center=�$��Center=�$y�Hidden=�$��20��$��20��#���  .��F� �������[y@��`���[y@+|�����+|�������`�    `� �y<4`� �y<4!d�    !d��D���"!@    ��3    � ��    Q ����x��@� ��o���3o�Q�3��x��@�D���"!@��x��@	$ Uniform=����	#FFAAAAAA$��10��$��0,0,0,0q��� $ PART_MINIMIZE��$��Center=�$��Center=�$��5q�$��Right=�$��20��$��20��#���  $��Bottom=�$y�Hidden=�.��F� +����     -1��- -1��-��� �    ��� 	$ Uniform=����	#FFAAAAAA$��10��$��0,0,0,5q��� $��Bottom=�.u��� #��z��#��z�� �� ContentStringFormat �� ContentStringFormat# z  �� Triggers P�  P� Property �@�
ResizeMode P� Value$ CanResizeWithGrip=�. ���  � ��	 �� "
 �.R��� #��z��#��z��#��z��._�� .+��� .u��� #��z��#��z��# z ��  ��Name$ WindowResizeGrip��$��Right=���.  $y�	Collapsed=�$��Bottom=� �� Triggers ]�  ]� 
Conditions ��  �� Property �@�
ResizeMode �� Value$ CanResizeWithGrip=���  �@�WindowState$ Normal=�./���  �� 
TargetName$ WindowResizeGrip�� � y�$	 Visible=�.��� .+��� -    ��Name$ title��$��Label��$	��Top=�$
��Bold"�$
��10,0q�#���  $��16(��� -   $ b1��$��B1��$��Right=�$��	0,0,10,10q�$��Bottom=�$��84��$��29���� -   $ b2��$��B2��$��Right=�$��
0,0,100,10q�$��Bottom=�$��86��$��29���� -    ��Name$
 desc��$��Description��#���  $��0��$��0��$��WrapWithOverflow=�$��Stretch=�$��Stretch=�$��16,31,16,64q��� -   $ b3��$��B3��$��Right=�$��
0,0,192,10q�$��Bottom=�$��84��$��29��