   M S B A M L   `   `   `  ���� G  CeBook Reader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:eBook_Reader.VieweBook_Reader.View  ?$clr-namespace:eBook_Reader.ViewModeleBook_Reader.ViewModel  )    #eBook_Reader.View.FavoriteBooksView   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     1localclr-namespace:eBook_Reader.View     :	viewmodel$clr-namespace:eBook_Reader.ViewModel       � 	Resources     listPanelTemplate��%   &	        �� .R�� .��� ���#fdf8e8 � RowDefinitions �� $
��Auto ��� $
��Auto ��� $��* �.+�]� $��0��$	��100�����#e7dbb1.+���  �� Orientation$ 
Horizontal=�$
��Left=�$��60 0 0 0q�.+���   AddButtonStyle#���  $��60��$��60��$��5q�$	��Top=����� *AddEpubBookCommand+.���� $%��/Icons/126583_plus_add_icon.png��$��30���� -    ��Name$ bookList��#��[  $��Disabled=�$��2��
������ 
������ ���� *FavoriteBooks+ �� SelectedItem �� *SelectedBook+ �� Mode$ TwoWay=�����  �� 
TargetType" ��.���  �� Property � �� �� Value
 ���� ��  � �� �� 	 �� 
TargetType"	 ��.R��� ���� .R��� .+��� �� 
������ 
������ ���� *%#DataContext.NavigateReadBookCommand+
 �� RelativeSource
 ��  �� AncestorType" >����� .���� $��5q�.+��� $	��150��$	��250�� �� BitmapScalingMode$ HighQuality=�����  �� Path$ 
CoverImage��� $��16(�$��Center=����� $ Title��� $��16(�$��Center=����� $ Author�