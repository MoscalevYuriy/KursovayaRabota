   M S B A M L   `   `   `  ����J  FKursovayaRabota, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:KursovayaRabotaKursovayaRabota  5   	   !    KursovayaRabota.AdminResult   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:KursovayaRabota     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ 
AdminOlimp��5   	   $	��450��6   $	��800��6)   $	��450��65   $	��800��6E   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ 	#FFFF4BA7��6   � 5      $ 	#FF56CCFF��6    � Offset$ 1Q�61   5      .+�5   
   �� $	��400��6   $��15q�6    
�������$��Center=�6?    �� Padding$ 30q�6Z   $	��550��6g   	 �� CornerRadius$	 20��6v   
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�6E   ._�5      �� $��0,0,0,0q�6   .+�5      � .+�5      �� -   5         ��Name$ buttonAdminOlimpBack��5      $��
Назад��6;   $��0,20,414,20q�6K   ���	#FF01B905���	#FF01B905
�������$��Comic Sans MS)�6�   6�   �� 5      -   5        $ buttonAdminOlimpReload��5      $��Обновить��6=   $��387,20,0,20q�6P   ���	#FFAACDFF���	#FFAACDFF
�������$��Comic Sans MS)�6�   6�   5       &   System.Windows.Controls.DataGrid  5!      -   5          Name$ dataGridResult��5!      $	��194��63      AutoGenerateColumns .     
IsReadOnly .     Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО участника��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6f   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *ФИО_участника+6f     5$      $ ID Олимпиады��6-   $ * 6d    6C   �� *ID_Олимпиады+6d     5%      $) #Колличество баллов��6-   $ * 6p    6I   �� *%#Колличество_баллов+6p   4  .System.Windows.Controls.DataGridTemplateColumn  5&      $
 auto 61      CellTemplate 5'      �� 5(   "   .R�5)   &   ��  ��Name$ imageOlimpEdit��6,   -   5        $��img_237015.png��5)   D   $��15��6\   $��15��6g   6�   5*   #   5,      5.      � 5/      .+�50      �� -   5        $ buttonOlimpAdd��50      $��Сохранить��65   $��
0,20,260,0q�6I   ���	#FF01B905���	#FF01B905
�������$��Comic Sans MS)�6�   $
��Auto��6�   �� 51      -   5        $ buttonOlimpDelete��51      $��Удалить��68   $��
260,20,0,0q�6J   ���	#FF01B905���	#FF01B905
�������$��Comic Sans MS)�6�   52      53      54      55      56      