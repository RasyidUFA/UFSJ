   M S B A M L   `   `   `  ����   UFSJStd    UFSJ.PresentWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     �Name$  PresentsWindow�� � Title$ Pre Defined Manager��$	��311��$	��479�� � Topmost . $	��300��$	��400�� � 
ResizeMode$ CanResizeWithGrip=� � WindowStyle$ 
ToolWindow=� � WindowStartupLocation$ CenterOwner=�.���  � ColumnDefinitions �� $	��63* ��� $	��83* �.+��� -    ��Name$ bClose��   button.close#���   $��Right=�$��	0,0,10,10q�$��Bottom=�$��80�� J� RenderTransformOrigin$ 0.44,0.2&�$��1��$��30���� -   	 ��Name$	 	lstPreDef��$��10q�
 J� 	AllowDrop
 . �� -   $ bSave��  button.save#���  $��Right=�$��	0,0,95,10q�$��Bottom=�$��80��$ 0.44,0.2&�$��1��$��30���� -    ��Name$ DefSizeT�� �� TextWrapping$
 Wrap=�$��0��$	��Top=�$��7,111,100,0q� �� 	UndoLimit$ 5��$��27��$��Center=�
����������	#FFADB2B5
���   � �� SelectionBrush �	#FF3399FF$��Right=�$��1���� -    ��Name$ DefSizeC��$	��Top=� �� SelectedIndex$ 0��$��
0,111,10,0q�$��27�� �� MaxDropDownHeight$	 340��$��24��$��Center=� �� 
IsEditable .  �� 
IsReadOnly . ���	#FFDADBDC$��1��$��Right=�$��85��.@��� -    ��Name$ cSplitBytes��$��Bytes���� -   $ 
cSplitKilo��$��KB���� -	   $ 
cSplitMega��$��MB���� -
   $ 
cSplitGiga��$��GB���� -   $ cSplitParts��  string.part#���  ���	#FFEDFFF2$��0q��� -   $ DefName��$��27��$��	5,36,10,0q�$
 Wrap=�$	��Top=�$��Center=�$��1���� -    ��Name$ ln��  string.name#���  $
��Left=�$��5,10,0,0q�$	��Top=�$��1��$��42���� -   $ lv��  string.value#���  $
��Left=�$��5,85,0,0q�$	��Top=�$��1��$��40���� -    ��Name$ gridSplitter��$��0,0,0,0q�$��2��