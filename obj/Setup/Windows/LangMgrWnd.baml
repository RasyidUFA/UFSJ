   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem   UFSJ   UFSJ.LangMgrWnd   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     9System&clr-namespace:System;assembly=mscorlib       � Title$  Language Manager��$	��470��$	��440��$	��440��$	��470�� � Topmost .  � ShowInTaskbar .   � WindowStartupLocation$ CenterOwner=�$��Center=�$��Center=� � AllowsTransparency .  � WindowStyle$
 None=�����  �� 
TargetType" �.���  �� Property � ��   
Foreground �� Value# �   ��  � ��  LightBackground# �  ��  �@�WindowStyle$
 None=���  � �� �� 	 �� 
TargetType"	 �.R�� .+��� 
 ��Name$
 
MainBorder��-   $��1q�#���    BorderBrushSelected#���  ._�]� ��. .+��� $
 PART_TITLEBAR��$��0,0,0,0q�$��28��$	��Top=�
������ ._�]� ��.  $��0,0,0,0q�.+��� $��4,0,0,4q�$��Center=����	#FFAAAAAA$��NoWrap=�#��z  $��16(���  ��Name$ 
PART_CLOSE��-   $��Right=�$��Center=�$��5q�$��20��$��20��  MetroWindowButtonStyle#���  .��F� �����T�8����L�F�=�Q,�8�z6�0@��R�� �Rȱ T�8��� �p��} ���} ����� �(R�����=�U0@��� �<�� �} ȱ �} $˗ ��� �$��S | @ȱ $��S | @�� $˗ �z6�0@��� H��$˗ ����$��S | @(��$��S | @4�$˗ �8�ȱ ��R<�� ��R�=�U0@�8�(R�$F����8�����Rp���RT�8�8��R4�8�R(��T�8��� �� Stretch$ Uniform=����	#FFAAAAAA$��10��$��0,0,0,0q��� $ PART_MAXIMIZE_RESTORE��$��Right=�$��5q�$��Center=�$��Center=�$y�Hidden=�$��20��$��20��#���  .��F� �������[y@��`���[y@+|�����+|�������`�    `� �y<4`� �y<4!d�    !d��D���"!@    ��3    � ��    Q ����x��@� ��o���3o�Q�3��x��@�D���"!@��x��@	$ Uniform=����	#FFAAAAAA$��10��$��0,0,0,0q��� $ PART_MINIMIZE��$��Center=�$��Center=�$��5q�$��Right=�$��20��$��20��#���  $��Bottom=�$y�Hidden=�.��F� +����     -1��- -1��-��� �    ��� 	$ Uniform=����	#FFAAAAAA$��10��$��0,0,0,5q��� $��Bottom=�.u��� #��z��#��z�� �� ContentStringFormat �� ContentStringFormat# z  �� Triggers P�  P� Property �@�
ResizeMode P� Value$ CanResizeWithGrip=�. ���  � �� �� "	 �.R��� #��z��#��z��#��z��._�� .+��� .u��� #��z��#��z��# z ��  ��Name$ WindowResizeGrip��$��Right=���.  $y�	Collapsed=�$��Bottom=� �� Triggers ]�  ]� 
Conditions ��  �� Property �@�
ResizeMode �� Value$ CanResizeWithGrip=���  �@�WindowState$ Normal=�./���  �� 
TargetName$ WindowResizeGrip�� � y�$ Visible=�.��� .+��� -   $
 bAdd��$	��Add��$
��Left=�$��25��$��	10,0,0,10q�$��Bottom=�$��65���� -   $ bEdit��$
��Edit��$
��Left=�$��25��$��	80,0,0,10q�$��Bottom=�$��65��{�.  �� -    ��Name$ lb��$��10,39,217,41q� �� SelectionMode$ Extended=�  StandardListBox#��[ #���   �� -   $ bClose�� 
 #B.19##���  $��Right=�$��25��$��	0,0,10,11q�$��Bottom=�$��65�� �� 	IsDefault . �� -    ��Name$ label��$��Language Manager��$
��Left=�$��10,5,0,0q�$	��Top=�$��18(�$��34��$	��412��$��0,0,0,1q�#���   �� -   $ bRemove��$��Remove��$
��Left=�$��25��$��
150,0,0,10q�$��Bottom=�$��65��{�.  �� -	   $ label1��$)��#Select Language available from List��$��Right=�$��26��$��	0,39,10,0q�$	��Top=�$	��202��#���   