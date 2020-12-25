
using System.Collections.Generic;

namespace ShowMeTheXAML
{
    public static class XamlDictionary
    {
        static XamlDictionary()
        {
            XamlResolver.Set("dialogs_sample3", @"<smtx:XamlDisplay UniqueKey=""dialogs_sample3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:DialogHost DialogTheme=""Dark"" HorizontalAlignment=""Center"" VerticalAlignment=""Center"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:DialogHost.DialogContent>
      <StackPanel Margin=""16"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <TextBlock Text=""Add a new fruit."" />
        <TextBox Margin=""0 8 0 0"" HorizontalAlignment=""Stretch"" x:Name=""FruitTextBox"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
        <StackPanel Orientation=""Horizontal"" HorizontalAlignment=""Right"">
          <Button Style=""{StaticResource MaterialDesignFlatButton}"" IsDefault=""True"" Margin=""0 8 8 0"" Content=""ACCEPT"" Command=""{x:Static materialDesign:DialogHost.CloseDialogCommand}"">
            <Button.CommandParameter>
              <system:Boolean xmlns:system=""clr-namespace:System;assembly=mscorlib"">True</system:Boolean>
            </Button.CommandParameter>
          </Button>
          <Button Style=""{StaticResource MaterialDesignFlatButton}"" IsCancel=""True"" Margin=""0 8 8 0"" Content=""CANCEL"" Command=""{x:Static materialDesign:DialogHost.CloseDialogCommand}"">
            <Button.CommandParameter>
              <system:Boolean xmlns:system=""clr-namespace:System;assembly=mscorlib"">False</system:Boolean>
            </Button.CommandParameter>
          </Button>
        </StackPanel>
      </StackPanel>
    </materialDesign:DialogHost.DialogContent>
    <Button Style=""{StaticResource MaterialDesignFloatingActionMiniAccentButton}"" Command=""{x:Static materialDesign:DialogHost.OpenDialogCommand}"" VerticalAlignment=""Bottom"" HorizontalAlignment=""Right"" Content=""{materialDesign:PackIcon Kind=Plus, Size=22}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
  </materialDesign:DialogHost>
</smtx:XamlDisplay>");
XamlResolver.Set("dialogs_sample1", @"<smtx:XamlDisplay UniqueKey=""dialogs_sample1"" Grid.Column=""0"" Grid.Row=""1"" Margin=""5 0 0 0"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:DialogHost DialogTheme=""Inherit"" HorizontalAlignment=""Center"" VerticalAlignment=""Center"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:DialogHost.DialogContent>
      <StackPanel Margin=""16"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <TextBlock Text=""Add a new fruit."" />
        <TextBox Margin=""0 8 0 0"" HorizontalAlignment=""Stretch"" x:Name=""FruitTextBox"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
        <StackPanel Orientation=""Horizontal"" HorizontalAlignment=""Right"">
          <Button Style=""{StaticResource MaterialDesignFlatButton}"" IsDefault=""True"" Margin=""0 8 8 0"" Content=""ACCEPT"" Command=""{x:Static materialDesign:DialogHost.CloseDialogCommand}"">
            <Button.CommandParameter>
              <system:Boolean xmlns:system=""clr-namespace:System;assembly=mscorlib"">True</system:Boolean>
            </Button.CommandParameter>
          </Button>
          <Button Style=""{StaticResource MaterialDesignFlatButton}"" IsCancel=""True"" Margin=""0 8 8 0"" Content=""CANCEL"" Command=""{x:Static materialDesign:DialogHost.CloseDialogCommand}"">
            <Button.CommandParameter>
              <system:Boolean xmlns:system=""clr-namespace:System;assembly=mscorlib"">False</system:Boolean>
            </Button.CommandParameter>
          </Button>
        </StackPanel>
      </StackPanel>
    </materialDesign:DialogHost.DialogContent>
    <Button Style=""{StaticResource MaterialDesignFloatingActionMiniAccentButton}"" Command=""{x:Static materialDesign:DialogHost.OpenDialogCommand}"" VerticalAlignment=""Bottom"" HorizontalAlignment=""Right"" Grid.Row=""0"" Margin=""0 0 28 -20"" Content=""{materialDesign:PackIcon Kind=Plus, Size=22}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
  </materialDesign:DialogHost>
</smtx:XamlDisplay>");
        }
    }
}