   M S B A M L   `   `   `  ����B  >WPFCore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPFCoreWPFCore  5   	       WPFCore.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPFCore     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� $	��Top=�6   .+�5
   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��6g      CanUserAddRows$ False��6�   ��6   �� *	Product+ �� SelectedItem 64   �� *SelectedItem+ �� Mode$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *Name+6Y     5      $ Content��6%   $ 1* 66    6A   �� *	Content+6_     5      $ Price��6%   $ 1* 64    6?   �� *Price+6[   5      �� 5   
   $��12(�6   .��6   Name :6&   �� 5   
   $��12(�6   ��6    �� *	TxtName+	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� ValidatesOnDataErrors$

 True��6z   �� 5   
   $��12(�6   .��6   Price:6&   �� 5   
   $��12(�6   ��6!   �� *
TxtPrice+$	 PropertyChanged=�$

 True��6|   �� 5   
   $��12(�6   .��6   	Content :6)   �� 5   
   $��12(�6   ��6!   �� *
TxtContent+$	 PropertyChanged=�$

 True��6~   �� 5   
   $��12(�6   ��6   �� *
AddCommand+.��6>   Ekle6D   �� 5   
   ��6   �� *DeleteCommand+.��63   Sil68   5      5       