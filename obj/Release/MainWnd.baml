   M S B A M L   `   `   `  ���� [  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  UFSJStd   UFSJ.MainWnd   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/netfx/2007/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     RForms@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     9System&clr-namespace:System;assembly=mscorlib     -     �Name$  
mainWindow�� � Title$ UFSJ# 0.9.7�� J� 	AllowDrop . $	��496��$	��508�� � Icon$ Resources/STD.ico��$	��440��$	��470�� � UseLayoutRounding .  � WindowStartupLocation$ CenterScreen=� � Topmost . $��0q� � 
ResizeMode$ CanMinimize=� J� SnapsToDevicePixels . 	 � TaskbarItemInfo	 *  $System.Windows.Shell.TaskbarItemInfo  -   TaskBarInfo��
   Description$&
  Universal File Splitter & Joiner��   ProgressValue$ 0Q�   ProgressState$
 None=�   ThumbnailClipMargin$
 0,25q�   ThumbButtonInfos 4  .System.Windows.Shell.ThumbButtonInfoCollection  *  $System.Windows.Shell.ThumbButtonInfo  -      DismissWhenClicked .     	IsEnabled .    Description$ Show Options��.���  � RowDefinitions �� �� $��5 ��� $��25 �.+��� -    ��Name$ mainTab�� �� SelectedIndex$ 1�����	#FFDADBDC J� IsManipulationEnabled . 
�������.@��� -    ��Name$ mainTabFile��   MainMetroTab#���     header.file#���  $
��10,4q�$��	-2,-2,0,0q�  MetroUI.MainTheme#���   .  ��.  .��� -    �Name$ fileGird��
�������$��	0,0,-3,-2q�.+��� -   $ fileTab��$ 2��$��Center=�$��	0,-4,-2,0q� �� TabStripPlacement$
 Left=�
����������	#FFDADBDC.@��� -   $ fileTabOptions��  NormalMetroTab#���    header.options#���  $
��10,6q�$��Stretch=� �� 
IsSelected . $��
-2,-2,-1,0q�
���������.  .���� $
��Auto=���.  �� PanningMode$ VerticalOnly=�|�.  .��� -	   $ 
OptionGrid��
������� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~�T� -
   	GridTrans�� � Triggers :�  :� RoutedEvent$ FrameworkElement.Loaded��.[��� .���� .��W�  �� 
TargetName$ 
OptionGrid�� �� TargetProperty$ Opacity�  W� From$  0X�	! W� To$	! 1.0X�" g� Duration$" 0:0:0.30D�W� $ 	GridTrans��$ X�$  50X�$! 0X�$" 0:0:0.35D�.+��� -   # ��Name$# FileOptOntop��  string.ontop#���  $
��Left=�$��	10,10,0,0q�$	��Top=�$��1q��� -   $# FileOptHideProgress��  string.hideprg#���  $
��Left=�$��
141,10,0,0q�$	��Top=�$��1q��� -   $# FileOptShowInfo��  string.showinfo#���  $
��Left=�$��	10,30,0,0q�$	��Top=�$��1q��� $��0,50,0,0q�$ �� Orientation$$ Vertical=�.+�� $��96��$
��10,0q�.+���   string.appearance#���  $
��Left=�$	��Top=� 	 
MetroLabel#��� 	 $��21��$	��126��#���  �� -   % ��Name$% fileAppTheme��$��24��$��
0,27,156,0q�$	��Top=�$ 0��.@��� $	��Red��
& � Tag& �� ' �� Color$' 	#FFBF1A1A���� $��Orange��& �� $' 	#FFC36F0A���� $
��Lime��& �� $' 	#FF76C923���� $��Green��& �� $' 	#FF1B7E1B���� $	��Sky��& �� $' 	#FF0A91C3���� $
��Blue��& �� $' 	#FF1979CA���� $��	Dark Blue��& �� $' 	#FF2D4FC1���� $��Purple��& �� $' 	#FF9D15BB���� $
��Pink��& �� $' 	#FFD8008A���� $��Light��& �� $' 	#FF878787���� $
��Dark��& �� $' 	#FF323232���� -   $% fileAppLanguage��$��24��$��
0,66,156,0q�$	��Top=�$ 0���� -   ( ��Name$( fileAppLangA�� 
 button.apply#��� 
 $��Right=�$��25��$��	0,65,90,0q�$	��Top=�$��61��#���  
�������$��1q��� -   $( fileAppLangM��  button.manage#���  $��25��$��	0,65,24,0q�$	��Top=�$��Right=�$��61��#���  
�������$��1q�� 
�������$��Stretch=�$	��Top=�$��90��.+��� -   $# fileSettingAssociateExt��  string.associate#���  $
��Left=�$��9,29,0,0q�$	��Top=��� -   $# fileSettingIntergrate��  string.integrate#���  $
��Left=�$��	10,69,0,0q�$	��Top=��� -   $# fileSettingStartSilent��  string.startsilent#���  $
��Left=�$��	31,49,0,0q�$	��Top=���   string.association#���  $
��Left=�$	��Top=�$��10,0,0,0q�#��� 	 $��21��$	��126��#���  � $	��Top=�$��0,0,10,0q�$	��110��.+�	� $��Windows INI (*.ini)��$
��Left=�$��	10,32,0,0q�$	��Top=�{�.  	� $��DefGear Script (*.dgs)��$
��Left=�$��	10,52,0,0q�$	��Top=�{�.  	� $��Registry Hive (*.reg)��$
��Left=�$��
157,32,0,0q�$	��Top=�$ 0.502,0.233&�{�.  	� $��Binary Data (*.bin)��$
��Left=�$��
157,52,0,0q�$	��Top=�) d� 	IsChecked$
) TrueY���   string.settings#���  $
��Left=�$	��Top=�$��10,0,0,0q�#��� 	 $��21��$	��126��#���  �� -   $( bSaveSetting��$��Save Setting��$
��Left=�$��21��$��	10,79,0,0q�$	��Top=�$��93��#���  
�������$��1q��� -   $( bLoadSetting��$��Load Setting��$
��Left=�$��21��$��
108,79,0,0q�$	��Top=�$��93��#���  
�������$��1q�� $
��10,0q�$	��107��.+��� -   * ��Name$* fileSettingFormat��$��23��$��0,56,0,0q�+ �� TextWrapping$
+ Wrap=�$	��Top=��� -   , ��Name$, fileSettingPreview��  string.prev#���  $
��Left=�$��0,79,0,0q�$	��Top=��� -   $% 	fileCDefs��$��24��$��
0,27,129,0q�$	��Top=�- �� 
IsReadOnly- . $ 0��.@��� $��UFSJ Standard���� $��UFSJ Hex���� $!��Extension Suffix (Standard)���� $��Extension Prefix���� $��Custom����   string.format#���  $
��Left=�$	��Top=�#��� 	 $��21��$	��126��#���  � $
��10,0q�$��95��.+���   string.script#���  $
��Left=�$	��Top=�#��� 	 $��21��$	��126��#���  �� -   $ fileTabCredits��  header.credits#���  $
��10,6q�
���   �#���  $��	-2,0,-1,0q�
���������.  .��� -   $ CreditsGrid��$ 0.948,0.932&�
�������z�V� .~�T� -   	CredTrans��. T� X$. 0Q� :� $ FrameworkElement.Loaded��.[��� .���� .��W� $ CreditsGrid��$ Opacity�$  0X�$	! 1.0X�$" 0:0:0.30D�W� $ 	CredTrans��$ Y�$  50X�$! 0X�$" 0:0:0.35D�.+��� $��UFSJ Credits��$	��Top=�$��Center=�$��18(����	#FF2742A0�� $*��$Project Manager, Director Programmer��$��0,42,0,0q�$	��Top=�$��Center=����	#FF2742A0$��13(��� $��Muhammad Fahmi Rasyid��$��0,64,0,0q�$	��Top=�$��Center=����	#FF1A264F$ 0.5,0.5&�$��13(��� $��Designer��$��0,96,0,0q�$	��Top=�$��Center=����	#FF2742A0$��13(��� $=��7Muhammad Fahmi Rasyid
Bagas Christianto, Luqman Hanafie��$��	0,128,0,0q�$	��Top=�$��Center=����	#FF1A264F$ 0.5,0.5&�$��42��$��13(��� $��Tester:��$��	0,216,0,0q�$	��Top=�$��Center=����	#FF2742A0$��13(��� $w��qMuhammad Fahmi Rasyid, Supriyono,
Aqila Fitra Khairunnisa, Bagas Christianto, 
Luqman Hanafie, Fuad Haidar Natsir��$��0,0,0,10q�$��Center=����	#FF1A264F$ 0.5,0.5&�$��13(�$��79��$��Bottom=��� -   $ fileTabAbout��  header.about#���  $
��10,6q�
���   �#���  $��	-2,0,-1,0q�
���������.  
�������.��� .+��� -   $, Titles��$
��UFSJ��$��42(�$��	ExtraBold"�$��Expanded&�$��	74,10,0,0q�$
��Left=�$	��Top=�$ 0.5,0.5&�$��58��#���  $	��104���� -   $, Edition��$��#��$��28(�$��	ExtraBold"�$��Expanded&�$��	178,0,0,0q�$
��Left=�$	��Top=�#���  $��41���� -    $, 	FreeLabel��  string.free#���  $
��Left=�$��
183,34,0,0q�$	��Top=�$ 0.5,0.5&�$��18(�$
��Bold"�#���  z�V� .~�T� -!   	FreeTrans��� -"   $��LogoGrid��$��	10,10,0,0q�#���  $
��Left=�$��60��$��60��$	��Top=� :� $ FrameworkElement.Loaded��.[��� .���� .��W� $
 Logo��$ Width�$  0X�$! 60X�$" 0:0:0.30D�/ W� EasingFunction/ -  'System.Windows.Media.Animation.BackEase  0   	Amplitude$	0 0.3Q�7  1System.Windows.Media.Animation.EasingFunctionBase1   
EasingMode$1 EaseOut=�W� $ LogoGrid��$ Width�$  0X�$! 60X�$" 0:0:0.30D�/   $	0 0.3Q�$1 EaseOut=�W� $ Titles��$ Opacity�$  0X�$	! 1.0X�$" 0:0:0.30D�W� $ Edition��$ Opacity�$  0X�$	! 1.0X�$" 0:0:0.30D�W� $ 	FreeTrans��$ X�$  30X�$! 0X�$" 0:0:0.30D�/   $	0 0.3Q�$1 EaseOut=�W� $ 	AboutGrid��$ Opacity�$  0X�$	! 1.0X�$" 0:0:0.30D�.+��� -#   2 ��Name$
2 Logo��$
��Left=�$��60��$	��Top=�$��60��$��Resources/UFSJN.png��$
��Fill=�� -$   $ 	AboutGrid��$
��Left=�$	��306��$��	10,75,0,0q�$	��Top=�$	��315��.+��� -%   $, About��$O��IUniversal File/Folder Splitter and Joiner.
lightweight, speed, powerfull.��$��14(�$��Expanded&�$
��Left=�$	��Top=�$��50��$	��315��
���   �$��0,57,0,0q��� -&   $, About3��$~��xApplication designed with WDExpress 2013
Icons created with Greenfish Icon Editor Pro 3.1
Documentated with Ms Word 2013��$��14(�$��Expanded&�$	��Top=�
���   �$��	0,101,0,0q��� -'   $, About5��$A��;Copyright © 2014 UFASoft Technology
Temanggung, Indonesia.��$��14(�$��Expanded&�
���   �$��54��$��Bottom=��� -(   $, OsInfo��$�� ��$��14(�$��Expanded&�
���   �$��
0,167,0,54q��� -)   $, 	AboutName��$&�� Universal File Splitter & Joiner��$��14(�$��Expanded&�$
��Left=�$	��Top=�$��26��$	��315��
���   ��� -*   $, AboutVersion��$��Version 0.9.6 Build 10629��$��14(�$��Expanded&�$
��Left=�$	��Top=�$��26��$	��315��
���   �$��10,26,-10,0q��� -+   $, FreeLabel_Copy��$
��BETA��$��0,12,3,0q�$	��Top=�$ 0.5,0.5&�$��18(�$
��Bold"�#���  $��Right=�$��71��$��Center=�$��Center=�z�V� .~��� �� �� 3 �� Angle$3 23.309Q�T� $. 1.006Q�4 T� Y$4 -2.334Q���   header.support#���  $��31��$	��Top=�#���  ��.  $��	-3,0,-1,0q�.��� .+��� -,   $2 imgKIR��$��Resources/KIRA.png��$��85,46,109,0q�$	��125��$	��Top=��� --   $2 imgUFSJ��$��Resources/Splash.gif��$��	10,51,0,0q�$
��Left=�$��80��$	��105��$	��Top=�$
��Fill=��� -.   $2 
imgUFASoft��$��Resources/UFASoft.png��$��
10,10,10,0q�$��36��$	��Top=��� -/   $2 imgSMP��$��Resources/SMP.png��$��	0,51,10,0q�$��Right=�$	��111��$	��105��$	��Top=�$ 0.811,0.529&��� -0   $, lInformationSupport��$��UFASoft Technology��$��10,251,10,10q�$ 0.868,0.385&�$��24(�$	��295��$��Center=�$��Center=��� -1   $ fileTabUpdates��$��UPDATES��$
��10,6q�
���   �#���  $y�Hidden=�.��� �� -2   $ mainTabSplit��  header.split#���  
������� .  $
��10,4q�#���  $��0,-2,0,0q���.  ���� 5 �� EndPoint$	5 0,1&�6 �� 
StartPoint$	6 0,0&�.��� 7 � Color$7 	#FFF0F0F0��8 � Offset$8 0Q�� $7 	#FFE5E5E5��$8 1Q�.��� -3   $ 	splitGird�� . 
�������.+���   string.outfile#���  $
��Left=�$��9,55,0,0q�$	��Top=���   string.srcfile#���  $
��Left=�$��9,2,0,0q�$	��Top=��� -4   $, splitInSize��$��No File��$��Right=�$��0,2,71,0q�$	��Top=�$��Right=�9 J� Opacity$	9 0.2Q��� -5   $* splitInPath��$��
14,28,71,0q�$�� ��$	��Top=�$��24��: �� 	UndoLimit$: 5��$��Center=����	#FFADB2B5
�������
���   �; �� SelectionBrush; �	#FF3399FF< �� MaxLines$< 1���� -6   $( splitInBrowse��  button.browse#���  $��Right=�$��24��$��	0,28,10,0q�$	��Top=�$��56��$��11(�#���  $��1,4,1,1q�
��������� -7   $, splitOutSize��$��No File��$��Right=�$��	0,55,71,0q�$	��Top=�$��Right=�$	9 0.2Q��� -8   $* splitOutPath��$��
14,81,71,0q�$�� ��$	��Top=�$��24��$: 5��$��Center=�
����������	#FFADB2B5
���   �; �	#FF3399FF$< 1���� -9   $( splitOutBrowse��#���  $��Right=�$��24��$��	0,81,10,0q�$	��Top=�$��56��$��11(�#���  $��1,4,1,1q�
�������� -:   $ splitOptionGrid��$��	0,110,0,0q� :� $ FrameworkElement.Loaded��.[��� .���� .��W� $ splitOptionGrid��$ Opacity�$  0X�$	! 1.0X�$" 0:0:0.20D�.+���   string.present#���  $
��Left=�$��	10,10,0,0q�$	��Top=���   string.splitto#���  $
��Left=�$��	11,41,0,0q�$	��Top=�$ 	0.491,0.5&��� -;   $% splitOptComboPreDef��$��
70,10,70,0q�$ 0��$	��Top=�= �� 
IsEditable= . - . $��26��$��Center=����	#FFDADBDC.@���   string.autodet#���  �� -<   $* splitOptSizeT��$
+ Wrap=�$��0��$	��Top=�$��71,41,183,0q�$: 5��$��27��$��Center=�
����������	#FFADB2B5
���   �; �	#FF3399FF$��Right=��� -=   $% splitOptSizeC��$��Right=�$	��Top=�$ 0��$��	0,41,70,0q�$��27��> �� MaxDropDownHeight$	> 340��$��24��$��Center=�$	��108��= . - . ���	#FFDADBDC.@��� ->   ? ��Name$? cSplitBytes��$��Bytes���� -?   $? 
cSplitKilo��$��KB���� -@   $? 
cSplitMega��$��MB���� -A   $? 
cSplitGiga��$��GB���� -B   $? cSplitParts��  string.part#���  ���	#FFEDFFF2$��0q��� -C   $# splitOptDelete��   string.deletesource#���   $
��Left=�$��
10,130,0,0q�$	��Top=��� -D   $( splitOpenOutDir�� ! button.opendir#��� ! $
��Left=�$��20��$��	10,0,0,35q�$��Bottom=�$	��139��$��1,4,1,1q�$	 0,0&�$��11(�{�.  #���  
��������� -E   $( splitViewSum�� " button.viewsum#��� " $
��Left=�$��	10,0,0,10q�$	��139��$��1,4,1,1q�$ 0.475,0&�{�.  $��20��$��Bottom=�$��11(�#���  
��������� -F   $( 
splitStart�� # button.split#��� # $��45��$	��104��$��Bottom=�$��Right=�$��	0,0,10,10q�#���  $��1,4,1,1q�
��������� -G   $# splitOptBatch�� $ string.genbatch#��� $ $
��Left=�$��
10,150,0,0q�$	��174��$	��Top=�$ 	0.489,0.6&��� -H   $* splitOptGenerateValue��$��27��$��194,73,107,0q�$
+ Wrap=�$��0��$	��Top=�$��Center=�{�.  ���	#FFADB2B5�� -I   $, splitOptGenerateLabel��#���  $��Right=�$��27��$��	0,73,58,0q�$	��Top=�$��44��{�.  ��  % string.options#��� % $
��Left=�$��
11,105,0,0q�$	��Top=�#���  $��20��$��1,0,5,0q�$	��174��#��� 	 �� -J   $( splitPreManage��#���  $��Right=�$��26��$��	0,10,10,0q�$	��Top=�$��55��$ 0.661,1&�#���  $��1,4,1,1q�
��������� -K   $% splitOptGenerate��$ 0��$��27��$��	70,73,0,0q�$	��Top=�- . $
��Left=�$��Center=�= . ���	#FFDADBDC$
��Left=�$	��119��.@���  & string.ofallpart#��� & ��  ' string.onlyfirst#��� ' {�.  ��  ( string.onlylast#��� ( {�.  ��  ) string.onlynumber#��� ) {�.  �� -L   $ mainTabJoin�� * header.join#��� * 
������� .  $
��10,4q�#���  $��0,-2,0,0q���.  ���� $	5 0,1&�$	6 0,0&�.��� $7 	#FFF0F0F0��$8 0Q�� $7 	#FFE5E5E5��$8 1Q�.��� -M   $ joinGird��
�������.+��� #���  $
��Left=�$��9,2,0,0q�$	��Top=��� #���  $
��Left=�$��9,55,0,0q�$	��Top=��� -N   $* 
joinInPath��$��
14,28,71,0q�$�� ��$	��Top=�$��24��$��Center=�
����������	#FFABADB3; �	#FF3399FF
���   ��� -O   $, 
joinInSize��$��No File��$��Right=�$��0,2,71,0q�$	��Top=�$��Right=�$	9 0.2Q��� -P   $( joinInBrowse��#���  $��Right=�$��24��$��	0,28,10,0q�$	��Top=�$��56��$��11(�
�������#���  $��1q��� -Q   $* joinOutPath��$��
14,81,71,0q�$�� ��$	��Top=�$��24��$��Center=�
����������	#FFABADB3; �	#FF3399FF
���   ��� -R   $, joinOutSize��$��No File��$��Right=�$��	0,55,71,0q�$	��Top=�$��Right=�$	9 0.2Q��� -S   $( joinOutBrowse��#���  $��Right=�$��24��$��	0,81,10,0q�$	��Top=�$��56��$��11(�
�������#���  $��1q�� -T   $ joinOptionGrid��$��	0,110,0,0q� :� $ FrameworkElement.Loaded��.[��� .���� .��W� $ joinOptionGrid��$ Opacity�$  0X�$	! 1.0X�$" 0:0:0.20D�.+��� -U   $# joinOptDelete�� + string.deletepart#��� + $
��Left=�$��	10,35,0,0q�$	��Top=��� -V   $( joinOpenOutDir��#��� ! $
��Left=�$��20��$��	10,0,0,35q�$��Bottom=�$	��139��$��1q�$��11(�{�.  
�������#���  �� -W   $( joinViewSum��#��� " $
��Left=�$��	10,0,0,10q�$	��139��$��1q�{�.  $��20��$��Bottom=�$��11(�
�������#���  �� -X   $( 	joinStart�� , button.join#��� , $��Right=�$��	0,0,10,10q�$	��104��$��45��$��Bottom=�$��1q�
�������#���  �� #��� % $
��Left=�$��	10,10,0,0q�$	��Top=�#���  $��20��$��1,0,5,0q�$	��174��#��� 	 �� -Y   $ mainTabHash�� - header.hash#��� - 
������� .  $
��10,4q�#���  $��0,-2,0,0q�
���������.  .��� -Z   $ HashGrid��
�������.+��� #���  $
��Left=�$��9,2,0,0q�$	��Top=��� #���  $
��Left=�$��9,55,0,0q�$	��Top=��� -[   $* 
hashInPath��$��
14,28,71,0q�$�� ��$	��Top=�$��24��$��Center=�
����������	#FFABADB3; �	#FF3399FF
���   ��� -\   $, 
hashInSize��$��No File��$��Right=�$��0,2,71,0q�$	��Top=�$��Right=�$	9 0.2Q��� -]   $( hashInBrowse��#���  $��Right=�$��24��$��	0,28,10,0q�$	��Top=�$��56��$��11(�
�������#���  $��1q��� -^   $* hashOutPath��$��
14,81,71,0q�$�� ��$	��Top=�$��24��$��Center=�
����������	#FFABADB3; �	#FF3399FF
���   ��� -_   $, hashOutSize��$��No File��$��Right=�$��	0,55,71,0q�$	��Top=�$��Right=�$	9 0.2Q��� -`   $( hashOutBrowse��#���  $��Right=�$��24��$��	0,81,10,0q�$	��Top=�$��56��$��11(�
�������#���  $��1q�� -a   $ hashOptGrid��$��	0,110,0,0q� :� $ FrameworkElement.Loaded��.[��� .���� .��W� $ hashOptGrid��$ Opacity�$  0X�$	! 1.0X�$" 0:0:0.20D�.+��� -b   $* hashOutT��@ �� 
IsReadOnly@ . $��10,0,119,73q�$
+ Wrap=�$�� ��$��51��$��Bottom=�
���   ��� -c   $% hashOutAlgol��$��Right=�$ 0��$��
0,0,10,129q�$��Bottom=�$	��104��$��23��$��Center=�
����������	#FF7CACD9$	> 330��$A �� IsSynchronizedWithCurrentItem$
A TrueY�- . = . .@��� -d   $? 	hashOutA1��$��CRC32���� -e   $? 	hashOutA2��$	��MD5���� -f   $? 	hashOutA3��$��SHA-1���� -g   $? 	hashOutA4��$��SHA-256���� -h   $? 	hashOutA5��$��SHA-384���� -i   $? 	hashOutA6��$��SHA-512���� -j   $( hashOutView��$��Right=�$��23��$��
0,0,10,101q�$��Bottom=�$	��104��$
��View��$��11(�
�������#���  $��1q��� -k   $( hashOutCopy��$��Right=�$��23��$��	0,0,10,73q�$��Bottom=�$	��104��$
��Copy��$��11(�{�.  $ 0.532,0.391&�
�������#���  $��1q��� -l   $( hashOpenOutDir�� . button.openfold#��� . $
��Left=�$��20��$��	10,0,0,35q�$��Bottom=�$	��139��$��2,0,0,0q�$ 0.475,0&�#���  $��11(�{�.  
��������� -m   $( hashViewSum��#��� " $
��Left=�$��	10,0,0,10q�$	��139��
�������$��2,0,0,0q�$ 0.475,0&�{�.  $��20��$��Bottom=�#���  $��11(��� -n   $( 	hashStart�� / button.calc#��� / $��Right=�$	��104��$��45��$��Bottom=�$��1q�$��	0,0,10,10q�
�������#���  �� -o   $# 
hashOptMD5��$	��MD5��$
��Left=�$��	11,55,0,0q�$	��Top=�$
) TrueY�$& 1���� -p   $# hashOptCRC32��$��CRC32��$
��Left=�$��	11,35,0,0q�$	��Top=�$& 0���� -q   $# hashOptSHA1��$��SHA-1��$
��Left=�$��	11,75,0,0q�$	��Top=�$& 2���� -r   $# hashOptSHA2��$��SHA-256��$
��Left=�$��	94,35,0,0q�$	��Top=�$& 3���� -s   $# hashOptSHA3��$��SHA-384��$
��Left=�$��	94,55,0,0q�$	��Top=�$& 4���� -t   $# hashOptSHA4��$��SHA-512��$
��Left=�$��	94,75,0,0q�$	��Top=�$& 5���� -u   $# hashSaveRes�� 0 string.savetospare#��� 0 $
��Left=�$��	10,95,0,0q�$	��Top=��� #��� % $
��Left=�$��	10,10,0,0q�$	��Top=�#���  $��20��$��1,0,5,0q�$	��174��#��� 	 �� -v   $ mainTabCompare�� 1 header.compare#��� 1 $
��Left=�#���  $��0,-2,0,0q� .  ��.  ���� $	5 0,1&�$	6 0,0&�.��� $7 	#FFF0F0F0��$8 0Q�� $7 	#FFE5E5E5��$8 1Q�.��� 
�������.+��� $��Stretch=�$��Stretch=� 2 string.inprogress#��� 2 $��Center=�$��Center=�$��54,159,71,84q��� #���  $
��Left=�$��9,2,0,0q�$	��Top=���  3 string.scdfile#��� 3 $
��Left=�$��9,55,0,0q�$	��Top=��� -w   $* 
diffInPath��$��
14,28,71,0q�$�� ��$	��Top=�$��24��$��Center=�
����������	#FFABADB3; �	#FF3399FF
���   ��� -x   $( diffInBrowse��#���  $��Right=�$��24��$��	0,28,10,0q�$	��Top=�$��56��$��11(�
�������#���  $��1q��� -y   $* diffOutPath��$��
14,81,71,0q�$�� ��$	��Top=�$��24��$��Center=�
����������	#FFABADB3; �	#FF3399FF
���   ��� -z   $( diffOutBrowse��#���  $��Right=�$��24��$��	0,81,10,0q�$	��Top=�$��56��$��11(�
�������#���  $��1q��� -{   $( 	diffStart�� 4 button.compare#��� 4 $��	0,0,10,10q�$��Right=�$	��104��$��45��$��Bottom=�$��1q�
�������#���  �� -|   $( diffOpenOutDir��#��� . $
��Left=�$��20��$��	10,0,0,35q�$��Bottom=�$	��139��
�������$��1q�$ 0.475,0&�#���  $��11(�{�.  �� -}   $( diffViewSum��#��� " $
��Left=�$��	10,0,0,10q�$	��139��
�������$��1q�$ 0.475,0&�{�.  $��20��$��Bottom=�#���  $��11(��� -~   $, 
diffInSize��$��No File��$��Right=�$��0,2,71,0q�$	��Top=�$��Right=�$	9 0.2Q��� -   $, diffOutSize��$��No File��$��Right=�$��	0,55,71,0q�$	��Top=�$��Right=�$	9 0.2Q��� #��� % $
��Left=�$��
10,120,0,0q�$	��Top=�#���  $��20��$��1,0,5,0q�$	��174��#��� 	 ��  5 header.task#��� 5 $
��Left=�$��55�� 6 SpecialMetroTab#��� 6 $��0,-2,0,0q�$y�Hidden=�.��� 
�������B � OverridesDefaultStyleB . .+��� -�   $( 
taskCancel�� 7 button.cancel#��� 7 $��Right=�$��Bottom=�$��90��$��
0,0,10,163q�$��26��B .   . #���  
�������$��1q�� -�   C �Name$C taskChildProgress��$��13��$��
10,36,10,0q�$	��Top=�
�������#���   . � -�   $C taskMainProgress��$��18��$��
10,75,10,0q�$	��Top=�
�������#���   . �� -�   $, taskChildStatus��$��Child Status��$
��Left=�$��	10,10,0,0q�$	��Top=�$ 0.579,0.244&��� -�   $, taskMainStatus��$��Main Status��$
��Left=�$��	10,49,0,0q�$	��Top=�$ 0.579,0.244&��� -�   $, taskProgress��$��100 %��$��Right=�$��	0,49,10,0q�$	��Top=�$ 0.579,0.244&��� -�   $, taskSize��$��FileSize��$��Right=�$��	0,10,10,0q�$	��Top=�$ 0.579,0.244&��� -�   $, taskElapsed��$��Elapsed��$
��Left=�$��	10,93,0,0q�$	��Top=�$ 0.579,0.244&��� -�   $, taskRemaining��$��Remaining : Unknown��$��Right=�$��	0,93,10,0q�$	��Top=�$ 0.579,0.244&��� -�   $( taskHide�� 8 button.hide#��� 8 $
��Left=�$��Bottom=�$��90��$��
10,0,0,163q�$��26��B .   . #���  
�������$��1q��� -�   D ��Name$D mainStatusBar��$��Center=�#���  $��2��.@��� -�   E ��Name$E siStatus�� 9 string.ready#��� 9 
�������$��Stretch=�$	��320����Z� ��  : string.active#��� : $��25��$	��Top=�
�������$��Center=���Z� � -�   $C 	prgStatus��#���  #���  $��1��$��0,0,0,1q����	#FF15B006$	9 0.8Q�