   M S B A M L   `   `   `  ���� \  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source   StandardDataGrid �� 
TargetType&     System.Windows.Controls.DataGrid �� Property �� Value  LightBackground �� 	Resources  Key �� 
TargetType �� Padding=   7System.Windows.Controls.Primitives.DataGridColumnHeader � ColumnDefinitions	 ��Name  BackgroundSelected  
Foreground
 F�Name �� Stretch J� RenderTransformOrigin n�Name  ColumnHeaderGripperStyle �� Triggers P� Value P� Property �� 
TargetName  BackgroundNormal ]� 
Conditions �� Property �� Value  BackgroundHighlighted �� Angle*   $System.Windows.Controls.DataGridCell J� SnapsToDevicePixels�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml        �� $ ../Core/Resources.xaml?�%5  &	        �� "   .���  �@  SelectionUnit$
 Cell=���  �@  GridLinesVisibility$
 None=���  �@  HeadersVisibility$ Column=���  � ��
 ���� ��  � ��# �  ��  �@  RowBackground# �   ���� ColumnHeaderGripperStyle " n�.���  � ��$ 8����  � ��
 ���� ��  �@�Cursor$ SizeWE����  � �� �� " n�.R��� # z��#��z���� '        "  .���  �@J�SnapsToDevicePixels . ��  � ��$	 120����  � ��$ 28����  �@�Cursor$
 Hand����  � �� �� "  .R�� .+��  �� $��* ��� $
��Auto �.+��� $	 BackgroundBorder��$��2��#���  �� #���  $��14(�$��SemiBold"��� $��6,3,6,3q�$��Center=�F� $
 	SortArrow��$y�	Collapsed=�"����        �@B     � � @B 	$
 Fill=�$��1��$��8��$��6��#���  $��0,0,8,0q�$��Center=�$ 0.5,0.4&�n� $ PART_LeftHeaderGripper��$
��Left=�#���  n� $ PART_RightHeaderGripper��$��Right=�#���   P�  Z�  �@ SortDirection. ��� $ BackgroundBorder��# �   � ��]�  ��  �@J�IsMouseOver . ��  Z�  �@ SortDirection./��� $ BackgroundBorder��# �   � ��P�  �@ SortDirection$ 	AscendingX�. ��� $ 	SortArrow�� � y�$ Visible=��� $ 	SortArrow�� � z� �� $	 180Q�P�  �@ SortDirection$ 
DescendingX�. ��� $ 	SortArrow�� � y�$ Visible=�P�  �@ DisplayIndex$ 0��. ��� $ PART_LeftHeaderGripper�� � y�$ 	Collapsed=��� '        "  .���  �@�FocusVisualStyle Z� ��  � ��
 ���� ��  � ��$ 28����  � ��# �  ��  � �� �� "  .R��� #��z�� . ._��� $��6,3,6,3q�# z  P�  �@J�IsMouseOver . . ��� # �   � ��P�  �@ 
IsSelected . . ��� # �   � ��