   M S B A M L   `   `   `  ���� G  CeBook Reader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:eBook_Reader.VieweBook_Reader.View  ?$clr-namespace:eBook_Reader.ViewModeleBook_Reader.ViewModel  $    eBook_Reader.View.AllBooksView   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     1localclr-namespace:eBook_Reader.View     :	viewmodel$clr-namespace:eBook_Reader.ViewModel     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity    � 	Resources     listPanelTemplate � Orientation��%(   &	        �� .R�� $ 
Horizontal=�.��� ���#fdf8e8 � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��* �.+�]� $��0��$��45�����#e7dbb1.+��� $��Right=�$��Bottom=�$��Right=� �� Orientation$ 
Horizontal=�$��5q�.+���   SortComboBoxStyle#���  $��0 0 5 5q�$��30��$	��105��$��Center=� �� SelectedItem �� *SelectedSortParameter+ �� Mode$ TwoWay=����� *SortParameters+���� .R��� $ 
Horizontal=�$��30�����#fdf8e8.+��� $��16(�$��75��$��0 0 0 5q�$��Center=����� *Name+�� $��20��$��0 0 0 5q� �� BitmapScalingMode$ HighQuality=����� *	ImagePath+.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ SelectionChanged��.  (System.Windows.Interactivity.TriggerBase	   Actions.	 6  0System.Windows.Interactivity.InvokeCommandAction  
   Command
 �� *SortCommand+�� $��30��$��0 0 0 5q�
������ $��1q� �� CornerRadius$ 5�����#fdf8e8._�� 
������  � ColumnDefinitions �� $	��200 ��� .+��� $��Stretch=�$	��130��$��30��$��0��$��Bottom=�
������ $��Center=�$��0q�.���� $#��/Icons/314478_search_icon.png��$��25��$��30��$��Center=�$��1��$ HighQuality=���   AddButtonStyle#���  $��	15 0 0 75q�$��3��$��Bottom=�$
��Left=� K� ZIndex$ 1��$��75��$��75������ *AddEpubBookCommand+.���� $%��/Icons/126583_plus_add_icon.png��$��40���� -    ��Name$ bookList��#��[  $��Disabled=�$��3��
������ 
������ $��10q����� *
BookList+ �� *SelectedBook+$ TwoWay=�����  �� 
TargetType" ��.���  �� Property � �� �� Value
 ���� ��  � �� ��  �� 
TargetType" ��.R��� ���� .R�� .+���   CheckBoxStyle#���  
�������$ 1��$��Right=�$	��Top=���   ListButtonStyle#���  ���#e7dbb1$��2q�$��10q�$	��350��$	��200������ *%#DataContext.NavigateReadBookCommand+ �� RelativeSource ��  �� AncestorType" >����� .���� .+��� $	��170��$	��250��$ HighQuality=�����  �� Path$ 
CoverImage��� $	��150��$��55��.+��� $��14(�$
��Left=�$��DemiBold"�$
��Wrap=����� $ Title��� $��12(�$
��Left=�$
��Wrap=����� $ Author�]� $��3��$��60�����#e7dbb1$��Bottom=�.+��� $ 
Horizontal=�$
��Left=�$��60 0 0 0q�