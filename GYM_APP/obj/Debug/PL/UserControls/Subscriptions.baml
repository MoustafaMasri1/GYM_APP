   M S B A M L   `   `   `  ����B  >GYM_APP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:GYM_APP.PL.UserControlsGYM_APP.PL.UserControls  5      D @FluentWPF, Version=0.4.0.0, Culture=neutral, PublicKeyToken=nullP6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPFSourceChord.FluentWPF 5      $    GYM_APP.PL.UserControls.NewSUB   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:GYM_APP.PL.UserControls     5      Efw6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPF     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      *  $SourceChord.FluentWPF.PointerTracker    Enabled  . )  #SourceChord.FluentWPF.AcrylicWindow   Enabled .    MaterialFont_AR_EN_SemiBold#���   5       � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   �� 5      $j dpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DialogHost.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��45 �6   �� 5      $��43 �6   �� 5      $��1* �6   .+�5   
   � $��1��6   .+�5      #  MaterialDesignThemes.Wpf.Card  $��	10 0 10 0q�5      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth2=�5      .��5       � .+�5!      ��  �� Orientation$ 
Horizontal=�5"      $
��Left=�5#      $��15 0 0 0q�5$      .+�5%      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ BadgeAccountHorizontal=�5&   !   $
��23.5��5'   !   $
��23.5��5(   !   $��0 0 0 3q�5)   !   $��Center=�5*   !   �� 5+        Main_lbl_Subscription#���  5,   !   $��10 0 0 0q�5-   !   $��Center=�5.   !   $��15(�5/   !     MaterialFont_AR_EN_Bold#���  50   !   51      �� 52      $ 
Horizontal=�6!   $��Right=�6:   .+�53      �� -   5        $��
textSearch��54      $��Right=�55      $	��150��56      $��35��57      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 بحث��59      .  (MaterialDesignThemes.Wpf.TextFieldAssist
   HasClearButton
 . .��5:   R   5;      �� 5<       �� SelectionMode$ Extended=�5=   !   $��Center=�5>   !   $��0 0 0 1q�5?   !    0 ,MaterialDesignFilterChipAccentOutlineListBox#��[ 5@   !   .@�5A      �� -   5        $��chk_ShowDeleteBtns��5A   *     Main_ToolTip_DeleteMode � ToolTip# �  5D   *   .��5E   "     $ Delete=�5F   )   ��5G   )   ��  �� ElementName$ btn_Refresh�� �� Path$ 
Foreground�5H      �� 5I      -   5        $��chk_EnableEditing��5I   *     Main_ToolTip_EditMode# �  5L   .   .��5M   "     $
 Edit=�5N   )   ��5O   )   �� $ btn_Refresh��$ 
Foreground�5P      5Q      �� 5R        Main_ToolTip_Print# �  5S   !     MaterialDesignFlatButton#��[ 5U   !   $	��Top=�5V   !   $��Right=�5W   !   $��43��5X   !   $��45��6-   .��5Y        $ Printer=�5Z   %   $��22��5[   %   $��22��5\   %   $	��-10q�5]   %   5^      �� 5_      -   5        $��btn_Refresh��5a   !     Main_ToolTip_Refresh# �  5`   !   #��[ 5c   !   $��Right=�5d   !   $
��Auto��5e   !   $��45��6/   .��5f        $ Refresh=�5g   %   $��22��5h   %   $��22��5i   %   $	��-10q�5j   %   5k      �� 5l      7  1MaterialDesignThemes.Wpf.Transitions.Transitioner   MoveNextCommand#��Z 5m   !   #��[ 5n   !   $	��Top=�5o   !   $��Right=�5p   !   $��43��5q   !   $��45��5r   !    	 Main_ToolTip_Add# � 	 5s   !   .��5t        $	 Add=�5u   %   $��22��5v   %   $��22��5w   %   $	��-10q�5x   %   5y      5{      5|      5~      5      � 5�   
   $��2��6   $��10q�6   .+�5�        $ Depth2=�5�      .��5�      &	   System.Windows.Controls.DataGrid	  -   5        $��dg_Subscriptions��5�       �� IsTextSearchEnabled . $
��14.5(�5�      $��1q�5�       	  SelectionUnit$ FullRow=�5�       	  CanUserAddRows .   	  SelectionMode$ Extended=�5�       	  ColumnWidth5
  /System.Windows.Controls.DataGridLengthConverter$ *
 5�       	  CanUserReorderColumns .   	  AutoGenerateColumns .   	  HeadersVisibility$	 All=�5�       	  
IsReadOnly . $ 	  HorizontalScrollBarVisibility$ Disabled=�5�       	  	RowHeight$ 49Q�5�       	  Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Width$
 Auto
 5�   !      Header$ #��5�   !    )
 %MaterialDesignDataGridTextColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [
 5�   !    5 1MaterialDesignDataGridTextColumnPopupEditingStyle    EditingElementStyle#  [ 5�   !   !   Binding! 5�   !   �� *Num+5�   !   1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5�      $
 Auto
 5�   !     Main_Col_PCode# �  5�   !    . # [
 5�   !   #  [ 5�   !   ! 5�   !   �� *PCode+5�        5�      $
 Auto
 5�   !     Main_Col_Barcode# �  5�   !   # [
 5�   !   #  [ 5�   !   ! 5�   !   �� *	Barcode+5�        5�        Main_Col_Description# �  5�   !   #  [ 5�   !   ! 5�   !   �� *Description+ 5�      �� 5�   "   " �� 
TargetType"" ��6(   # �� BasedOn## [B��6H   .�5�   &   �� $ �� Property$ � ��% �� Value$% CharacterEllipsis=�6E   5�   #   5�      5  /MaterialDesignThemes.Wpf.DataGridComboBoxColumn  5�      $
 Auto
 5�   !   -   5        cmb_Categories��&   
IsEditable$
& TrueX�5�   !     Main_Col_Category# �  5�   !   4  .System.Windows.Controls.DataGridComboBoxColumn'   SelectedValueBinding' 5�   !   �� *
CategoryID+5�        5�      $
 Auto
 5�   !   -   5        
cmb_Brands��$
& TrueX�5�   !     Main_Col_Brand# �  5�   !   ' 5�   !   �� *	BrandID+5�        5�      $
 Auto
 5�   !     Main_Col_CostPrice# �  5�   !   # [
 5�   !   #  [ 5�   !   ! 5�   !   �� *	CostPrice+5�        5�      $
 Auto
 5�   !     Main_Col_SellPrice# �  5�   !   # [
 5�   !   #  [ 5�   !   ! 5�   !   �� *	SellPrice+5�        5�      $
 Auto
 5�   !     Main_Col_QTY# �  5�   !   # [
 5�   !   #  [ 5�   !   ! 5�   !   �� *QTY+5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      -   5        col_btn_Delete�� . $
 Auto
 5�   \   (   
Visibility$( 	Collapsed=�6i   )   CellTemplate) 5�      �� 5�   "   .R�5�   &   �� )  #MaterialDesignThemes.Wpf.DialogHost*   OpenDialogCommand#��Z* 5�   )   ��5�   *   (  "MaterialDesignThemes.Wpf.ColorZone  5�   .   $��10q�6G   $	��350��6T   $	��100��6`   .��5�   2   �  5�   6   �� 5�   :   $��1* �6H   �� 5�   :   $��45 �6H   .+�5�   6   �� $��dialog_Backround��6@   $y�	Collapsed=�6X   ���#3030306o   �� 5�   6   $��0��6A   $ 
Horizontal=�6N   .+�5�   :     $ DeleteAlert=�5�   =   $��30��5�   =   $��30��5�   =   �� 5�   :   #���  5�   =     Subscription_lbl_Message#���  5�   =   $��3 0 0 0q�5�   =   $��15(�5�   =   $	��Top=�5�   =   $
��Left=�5�   =   5�   7   �� 5�   6   $��1��6A   $ 
Horizontal=�6N   $��Bottom=�6g   $��Right=�6�   .+�5�   :   �� $��btn_DeleteRecord��5�   =   $��5q�5�   =   $��80��5�   =     Subscription_btn_Accept#���  5�   =   +   CloseDialogCommand#��Z+ 5�   =   �� 5�   :     Subscription_btn_Cancel#���  5�   =   #��Z+ 5�   =   $��80��5�   =   5�   7   5   3   5  /   .��5  *     $ Delete=�5  -   $��22��5  -   $��20��5  -   $��-11 0 -50 0q�5  -   5  '   5	  #   5     5     5     5       5  
   ,   CornerRadius$, 5��5     -   Mode$- PrimaryDark=�5     $��2��5     $��25q�5     $��Bottom=�5     $��Center=�5     .��5     '  !MaterialDesignThemes.Wpf.Snackbar  -	   5        .  Name$. SelectRowError��5     /   ActionButtonPlacement$/ Inline=�5     0   MessageQueue0 5     4  .MaterialDesignThemes.Wpf.MessageQueueExtension  5     5     5     5     