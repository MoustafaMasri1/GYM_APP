   M S B A M L   `   `   `  ����B  >GYM_APP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:GYM_APPGYM_APP  5   	   A%clr-namespace:GYM_APP.PL.UserControlsGYM_APP.PL.UserControls  5   	       GYM_APP.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:GYM_APP     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   2local1%clr-namespace:GYM_APP.PL.UserControls  5   	   -   5           MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5	   	     MaterialFont_AR_EN_Regular#���  5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$ 	ClearType=�5   	     MaterialDesignPaper#���  5   	    �� BitmapScalingMode$ HighQuality=�5   	    �� CachingHint$ Unspecified=�5   	    � Title$ Gym Software��5   	    � 
ResizeMode$ 	CanResize=�5   	   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 30Q�6      GlassFrameThickness$ 50q�6*   	 J� CommandBindings	 5      )  #System.Windows.Input.CommandBinding  5   
   -   5        #  System.Windows.SystemCommands
   CloseWindowCommand   Command# Z
 5      6w     5   
   -   5           MaximizeWindowCommand# Z 5      6z     5   
   -   5           MinimizeWindowCommand# Z 5      6z     5    
   -   5           RestoreWindowCommand# Z 5       6y   .��5"      �� -   5         ��Name$ MainWindowBorder��5"   "   
���   �$��0q�6<   ._�5#   
   )  #MaterialDesignThemes.Wpf.DialogHost     CloseOnClickAway . .��5%      �  � ColumnDefinitions 5&      �� 5'      $��75 �6'   �� 5(      $��1* �6'   .+�5+      � 
���   �+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth2=�6,   $��2��6]   .+�5-      ��  ) %MaterialDesignNavigatilRailTabControl#��[ 5.      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ PrimaryDark=�5/      $ Depth5=�50      .@�51      ��    IsHitTestVisibleInChrome .  ' #MaterialDesignNavigationRailTabItem#��[ 53      
���������55      '  !MaterialDesignThemes.Wpf.PackIcon  57   "      Kind$
 Home=�58   !   $��25��59   !     Main_ToolTip_Home � ToolTip# �  5:   !   $��25��5;   !   5=      �� 5>      #��[ 6"   
���������5?        5@   "   $ AccountMultiplePlus=�5A   !   $��25��5B   !     Main_ToolTip_Members# �  5C   !   $��25��5D   !   .��5F      '	   !GYM_APP.PL.UserControls.NewMember	  5G      �� 5H      #��[ 5I       �� 
IsSelected . ��5K        5L   "   $ BadgeAccountHorizontal=�5M   !     Main_ToolTip_Subscription# �  5N   !   $��25��5O   !   $��25��5P   !   .��5R      7
  1MaterialDesignThemes.Wpf.Transitions.Transitioner
   �� SelectedIndex$ 0��6:   ! 
  AutoApplyTransitionOrigins . .@�5S   "   $   GYM_APP.PL.UserControls.NewSUB  <  6MaterialDesignThemes.Wpf.Transitions.TransitionerSlide  5T   "      BackwardWipe 5U   &   3  -MaterialDesignThemes.Wpf.Transitions.FadeWipe  5V   *      ForwardWipe 5X   &   4  .MaterialDesignThemes.Wpf.Transitions.SlideWipe  5Y   *      	Direction$
 Left=�6C   .��5[   &   	  5]   #   5^      5_      �� 5`      #��[ 6"   ��5a        5b   "   $ AccountCash=�5c      $��25��5d      $ Add Cash��5e   !   $��25��5f      .��5h      �  5i   "   �� 5j   &   $��20 �67   �� 5k   &   $��1* �67   �� 5l   &   $��20 �67    � RowDefinitions 5o   "   �� 5p   &   $��50 �64   �� 5q   &   $��4* �64   �� 5r   &   $��1* �64   .+�5u   "   
  $��1��6>   $��1��6K   $ 0��6\    . .@�5v   &   %   GYM_APP.PL.UserControls.AddCash    5w   &    5x   *   5  /MaterialDesignThemes.Wpf.Transitions.CircleWipe  5y   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5{   *   ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5|   .      Kind$ SlideInFromBottom=�6N   .��5~   *   %   GYM_APP.PL.UserControls.Payment  5   '   5�   #   5�      5�      �� 5�      #��[ 6"   ��5�        5�   "   $ 
CashRefund=�5�      $��25��5�      $
 Home��5�      $��25��5�      5�      �� 5�      #��[ 6"   $
 Home��5�        � Cursor$
  Hand��5�      ��5�        5�   "   $ AccountSearch=�5�      $��25��5�      $��25��5�      5�      �� 5�      #��[ 6"   $
 Home��5�      $
  Hand��5�      ��5�        5�   "   $ TextBoxSearch=�5�      $��25��5�      $��25��5�      5�      �� 5�      #��[ 6"   $
 Home��5�      $
  Hand��5�      ��5�        5�   "   $
 Sync=�5�      $��25��5�      $��25��5�      5�      �� 5�      #��[ 6"   ��5�        5�   "   $ Settings=�5�      $��25��5�      $��25��5�      .��5�      � $��0 25 0 0q�6#   .+�5�   "   #   GYM_APP.PL.UserControls.Theme  $
��10 0q�6/   �� 5�   "   -   5        $��cmb_Language��5�   !     Theme_cmb_Language)  #MaterialDesignThemes.Wpf.HintAssist!   Hint#! �  5�   !     	 MaterialDesignFilledComboBox#��[	 5�   !   $	��150��5�   !   $	��Top=�5�   !   $
��Left=�5�   !   $��20 20q�5�   !    
 MaterialFont_AR_EN_SemiBold#��� 
 5�   !   5�   #   5�      5�      5�      5�      � 5�      $��1��6    5�      �� 5�      $��32 �6(   �� 5�      $��1* �6(   .+�5�      � $��0��6   $��32��6(   
������ $	��Top=�6M    5�      �� 5�      $
��Auto �6/   �� 5�      $��1* �6/   �� 5�      $
��Auto �6/   �� 5�      $��1* �6/   �� 5�      $
��Auto �6/   .+�5�      #  MaterialDesignThemes.Wpf.Card  $ Depth1=�5�      $��4��5�      .��5�      �� " �� Orientation$" 
Horizontal=�5�      $��Right=�5�      .+�5�   "   ��   MaterialDesignFlatButton#��[ 5�   !    .   Main_Btn_Minimize# �  5�   !   #��Z 5�   !   .��5�   &     $ WindowMinimize=�5�   %   ��5�   %   �� # �� ElementName$# lbl_User��$ �� Path$$ 
Foreground�5�   #   �� 5�   "   -   5        % ��Name$% RestoreButton��5�   !   $y�	Collapsed=�5�   !   #��[ 5�   !   #��Z 5�   !    .   Main_ToolTip_Restore# �  5�   !   .��5�   &     $ WindowRestore=�5�   %   ��5�   %   �� $# lbl_User��$$ 
Foreground�5�   #   �� 5�   "   -	   5        $% MaximizeButton��5�   )   $y�Visible=�5�   %   #��[ 5�   %   #��Z 5�   %    .   Main_ToolTip_Maximize# �  5�   %   .��5�   &     $ WindowMaximize=�5�   %   ��5�   %   �� $# lbl_User��$$ 
Foreground�5�   #   �� 5�   "   #��[ 5�   !    .   Main_ToolTip_Exit# �  5�   !   #��Z
 5�   !   .��5�   &     $ Close=�5�   %   ��5   %   �� $# lbl_User��$$ 
Foreground�5  #   5     5       5      . $��2��5     $��7 3 0 0q�5     $ Depth1=�5     .��5	     �� $" 
Horizontal=�6)   .+�5
  "     $ AccountCheck=�5  !   $��Center=�5  !   $	��7 0q�5  !   $��25��5  !   $��22��6,   �� 5  "     Main_CurrentUser#���  5  !     MaterialFont_AR_EN_Bold#���  5  !   $��Center=�5  !   $	��0 0q�5  !   �� 5  "   -
   5        $��lbl_User��5  !   $��Moustafa Masri��5  !   #���  5  !   $��Center=�5  !   $��5 0 0 0q�5  !   $��CharacterEllipsis=�5  !   $	��120��5  !    5  !   �� $# lbl_User��$
$ Text��� 5  "   $��6��6,   $��7q�66   �� 5  "     	Main_Role#���  5  !   #���  5   !   $��Center=�5!  !   $	��0 0q�5"  !   �� 5#  "   $��Admin��5$  !   #���  5%  !   $��Center=�5&  !   $��5 0 10 0q�5'  !   5(     5)       5*      . $��0��5,     $��7 4 0 0q�5-     $ Depth1=�5.     .��5/     �� $" 
Horizontal=�6)   .+�50  "     $ Dumbbell=�51  !   $��Center=�52  !   $	��7 0q�53  !   $��25��54  !   $��22��6,   �� 55  "   $��Gym Managment Software��56  !   #���  57  !   $��Center=�58  !   $��0 0 10 0q�59  !   5:     5;     5=     5>     5@     5A     5B     5C     