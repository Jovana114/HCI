   M S B A M L   `   `   `  ????>  :HCI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:HCI.Pages.RenovationHCI.Pages.Renovation  5   	   )    #HCI.Pages.Renovation.ScheduleSimple   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:HCI.Pages.Renovation     5   	   $	??619??5   	   $	??920??6     ? 	Resources  5	         FocusVisual ?? Property ?? Value ?? StrokeDashArray J? SnapsToDevicePixels  Button.Static.Background ?? Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 RoundedButtonStyle ?? 
TargetType ?? 
TargetType ??Name	 ?? CornerRadius
 ??Name ?? Triggers P? Property P? Value ?? 
TargetName??%B  &	        &	 ?     &	 ?     &	 ?     &	     &	 4    &	 U    &	 v    &	 ?    &		 ?    &	
 ?    7   7  7  7  7  7  7  7  7  7 	 ?? 5
   
   .?5      ??  ? ?? 5      ?? 5      .R?5      ?? $??2q?6$   $	 1 2R?6/   #??? ??6E    . $??1??6?   5      5      5      ?? 5   
   $ 	#FFDDDDDD??6;   ?? 5   
   $ 	#FF707070??67   ?? 5   
   $ 	#FFBEE6FD??6>   ?? 5   
   $ #d0f0c0??6:   ?? 5   
   $ #d0f0c0??6<   ?? 5   
   $ #d0f0c0??68   ?? 5   
   $ #d0f0c0??6=   ?? 5   
   $ 	#FFADB2B5??69   ?? 5   
   $ 	#FF838383??6=   ?? 5   
   " ??6+   .?5      ??  ?@?FocusVisualStyle8   61   ?? 5       ? ??8  6+   ?? 5       ? ??8  6,   ?? 5        ? ??# ? ??6+   ?? 5!       ? ??$ 0q?60   ?? 5"       ? ??$ Center=?6;   ?? 5#       ? ??$ Center=?69   ?? 5$       ? ??$ 1q?6(   ?? 5%       ? ?? 5&      ?? 5'      " ??6&   .R?5(      ?? $ border??6!   $	 20??61   #??z??6C   #??z??6m   #??z??6?    . ._?5)      ?? $
 contentPresenter??6/   |?.  #??z??6[   #??z??6?   ??. # z 6?   #??z??6  5*       5+      P? 5,       ?@??IsDefaulted . . ?5-   "   ?? $ border??6@   # ? ??6T    ? ??5.      P? 5/       ?@J?IsMouseOver . . ?50   "   ?? $ border??6?   8   ? ??6S   ?? 51   "   $ border??6@   8   ? ??6T   52      P? 53       ? ?? . . ?54   "   ?? $ border??6?   8   ? ??6S   ?? 55   "   $ border??6@   8   ? ??6T   56      P? 57       ? {? .  . ?58   "   ?? $ border??6?   8   ? ??6S   ?? 59   "   $ border??6@   8   ? ??6T   ?? 5:   "   $ contentPresenter??6K   8 	  ? ??6i   5;      5=      5?      5@      5A      .??5B      ? ??5C   
   ?? 5D       ?? ImageSource$1 +D:\faks\3\2\HCI\HCI\Resources\Images\bb.jpg??6    ? RowDefinitions 5F   
   ?? 5G      $??45 ?6   ?? 5H      $
??157* ?6   ?? 5I      $
??130* ?6    ? ColumnDefinitions 5L   
   ?? 5M      $??180.949 ?6   ?? 5N      $??125.756 ?6   ?? 5O      $??0.295 ?6   ?? 5P      $	??65* ?6   ?? 5Q      $
??178* ?6   ?? 5R      $
??151* ?6   ?? 5S      $	??95* ?6   ?? 5T      $
??123* ?6   .+?5W   
   ??  J? OpacityMask ?#d0f0c0???#87a96b$??	Underline{?6?   $??
UltraLight"?6[   $??30(?6s   $ ??Schedule simple renovation??6?   $??0??6?   $??8??6?   $??0,0,10,0q?6?   ?? 5X   
   $??1??6   $??5??6"   $??
0,10,85,73q?66   $??2??6J   .+?5Y      ?? 
?????? $??0,0,0,0q?6-   $??Light"?6?   $	??Id:??6R   $??30(?6`   $	??428??6n   $
??Left=?6z   $??47??6?   ?? 5Z      
?????? $??0,32,0,0q?6-   $??Light"?6?   $$??Choose the room for equipment:??6R   $??30(?6{   $	??428??6?   $
??Left=?6?   $??47??6?   ?? 5[      
?????? $??0,32,0,0q?6-   $??Light"?6?   $??Type:??6R   $??30(?6b   $	??411??6p   $
??Left=?6|   $??50??6?   ?? 5\      
?????? $??0,32,0,0q?6-   $??Light"?6?   $??Date:??6R   $??30(?6b   $	??192??6p   $
??Left=?6|   $??47??6?   ?? 5]      
?????? $??0,32,0,0q?6-   $??Light"?6?   $??Time:??6R   $??30(?6b   $	??192??6p   $
??Left=?6|   $??47??6?   ?? 5^      
?????? $??0,32,0,0q?6-   $??Light"?6?   $??	Duration:??6R   $??30(?6f   $	??192??6t   $
??Left=?6?   $??47??6?   5`      ?? 5a   
   -   5         ??Name$ saved??5a       $??28??6   $??20(?60   $	??Top=?6>   $	??129??6V   
 ?   ?
???   ?$??1??6?   $??
0,160,57,0q?6?   $??5??6?   $??2??6?   $??Right=?6?   ?? 5b   
   -   5        $	 set??5b       $??28??6   $??20(?6.   $	??Top=?6<   $	??129??6T   
 ?   ?
???   ?$??1??6?   $??
0,215,57,0q?6?   $??5??6?   $??2??6?   $??Right=?6?   ?? 5d   
   $??1??6   $??4??6"   $??
51,20,10,0q?62   $??3??6F   $??2??6Z   .+?5e      ?? -   5         ??Name$ id??5e   3   $	??317??6   $??0,0,0,0q?6"   ???#F0F0F0$??43??6T   $??20(?6`   ?? 5f      -   5         ??Name$ cbProstorija1??5f   #   $	??317??6   ???#F0F0F0$??0,35,0,0q?6?   $??43??6?   $??20(?6?   ?? 5g      -   5        $
 type??5g   4   $	??317??6   $??0,35,0,0q?6"   ???#F0F0F0$??43??6W   $??20(?6c   (  "System.Windows.Controls.DatePicker  5h      -   5        $??
timePicker??5h      ???#F0F0F0$??0,35,0,0q?6d   $??43??6w   $??20(?6?   $	??317??6?   ?? 5i      -   5        $
??sati??5i      $??43??6L   $??0,35,0,0q?6X   $??20(?6j   ???#F0F0F0$	??317??6?   ?? 5j      -   5        $ durationText??5j      ???#F0F0F0$??0,35,0,0q?6A   $??43??6S   $??20(?6_   $	??317??6m   ?? 5l      -	   5        #??? 
 5l      $??Submit??6B   
??????????#d0f0c0$??20(?6z   $??43??5m      $	??150??6(   $??0,35,0,0q?64   $??3??6F   $??4??6S   $??3??6c   5o      5r      5s      