   M S B A M L   `   `   `  ����B  >GYM_APP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:GYM_APP.PL.UserControlsGYM_APP.PL.UserControls  5      %    GYM_APP.PL.UserControls.AddCash   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:GYM_APP.PL.UserControls     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      ��  �� Padding$ 5 0 5 5q�6   ._�5   
   �  � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��50 �6#    � RowDefinitions 5      �� 5      $��50 �6    �� 5      $��1* �6    �� 5      $��90 �6    .+�5      �� $��0��6   $��Center=�6)   $	��Top=�6F    �� Orientation$ 
Horizontal=�5      $��0 10 0 0q�5      .+�5      	�    MaterialDesignTabRadioButton#��[ 5       $��0 0 0 0q�5!       d� 	IsChecked$
 TrueY�5"      {�.  $��Add Cash��5$       � Cursor$
 Hand��6   	� 5%      #��[ 5'      $��10 0 0 0q�5(      $ FalseY�5)      {�.  $��Payment ��5,      $
 Hand��6   5.      �� 5/      $��Personal Information��50        MaterialDesignCardGroupBox#��[ 51      $��5q�52      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ 
PrimaryMid=�53      +  %MaterialDesignThemes.Wpf.ShadowAssist	   ShadowEdges$	 Right=�54      $��1��55      $��0��6   .��56      �  57      �� 58      $
��1.2* �6(   �� 59      $
��1.2* �6(   �� 5:      $
��1.2* �6(   �� 5;      $
��1.2* �6(   �� 5<      $��2* �6(   �� 5=      $��1* �6(   .+�5@      �� $��0��6   {�.  )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Number��6>    % !MaterialDesignFloatingHintTextBox#��[ 6f   $��Center=�6�   (  "System.Windows.Controls.DatePicker  5A      $��1��5B      $
 	Pick Date��5C       ( $MaterialDesignFloatingHintDatePicker#��[ 5D      �� 5E      $��2��5F       �� 
IsEditable . $
 Member��6<   $��Center=�6d   �� 5G      $��3��6   $

 Name��6+   #��[ 6Q   $��Center=�6�   �� 5I       �� TextWrapping$
 Wrap=�5J      $��Stretch=�5K      $	��280��5L       �� AcceptsReturn . " �� VerticalScrollBarVisibility$
 Auto=�5N       �� 	IsEnabled . $��4��5P      $
 Remark��5Q      #��[ 5R      5T      5U      � 5V      $��1��6   $��1��6#   .+�5W      �� $��40��6   $��40��6$   7  1MaterialDesignThemes.Wpf.Transitions.Transitioner   MoveNextCommand#��Z 5X       * &MaterialDesignFloatingActionDarkButton#��[ 5Y       � ToolTip$- 'MaterialDesignFloatingActionLightButton��5Z      .��5[      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ NavigateNext=�5\      $��24��5]      $��24��5^      5_      5`      5a      5c      5d      