   M S B A M L   `   `   `  ????>  :HCI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:HCIHCI  5   	   %clr-namespace:HCI.Views	HCI.Views  5   	   -clr-namespace:HCI.ViewModelHCI.ViewModel  5   	       	HCI.Home1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:HCI     5   	   )viewsclr-namespace:HCI.Views     5   	   1	viewModelclr-namespace:HCI.ViewModel     5   	     ? Title$
  Home??5
   	   $	??768??6   $
??1024??6#    ? DataContext 5        HCI.Home1ViewModel  5   
    ? 	Resources 5       ?? DataType!   HCI.ViewModel.HomeViewModel   HCI.Views.HomeView'   !HCI.ViewModel.RenovationViewModel   HCI.Views.RenovationView!   HCI.ViewModel.RoomViewModel   HCI.Views.RoomView%   HCI.ViewModel.MedicineViewModel	   HCI.Views.MedicineView1
   +HCI.ViewModel.RegistrationMedicineViewModel(   "HCI.Views.RegistrationMedicineView-   'HCI.ViewModel.RejectedMedicineViewModel$   HCI.Views.RejectedMedicineView,   &HCI.ViewModel.StaticEquipmentViewModel#   HCI.Views.StaticEquipmentView-   'HCI.ViewModel.DinamicEquipmentViewModel$   HCI.Views.DinamicEquipmentView/   )HCI.ViewModel.RearrangeEquipmentViewModel&    HCI.Views.RearrangeEquipmentView1   +HCI.ViewModel.QuestionnaireHospitaViewModel(   "HCI.Views.QuestionnaireHospitaView??%?  (??       5      *, +)(?? 2     5      *, +)(?? d     5      *, +)(?? ?     5      *, +)(?? ?     5      *,
 +)(?? ?     5      *, +)(?? ,    5!      *, +)(?? ^    5$      *, +)(?? ?    5'      *, +)(?? ?    5*      *, +)?? 5   
   "  6   .R?5        5      ?? 5   
   "  6   .R?5        5      ?? 5   
   "  6   .R?5        5      ?? 5   
   "  6   .R?5      	  5      ?? 5   
   " 
 6   .R?5        5      ?? 5   
   "  6   .R?5        5       ?? 5!   
   "  6   .R?5"        5#      ?? 5$   
   "  6   .R?5%        5&      ?? 5'   
   "  6   .R?5(        5)      ?? 5*   
   "  6   .R?5+        5,      5-      .??5.      ? $??0,0,0,-6q?6    ? RowDefinitions 5/   
   ?? 50      $??123.564 ?6   ?? 51      $??15.436 ?6   ?? 52       ? ColumnDefinitions 56   
   ?? 57      $	??600 ?6   ?? 58      .+?5<   
   ? $??2??6   $??0,0,0,62q?6#    5=      ?? 5>      $
??170* ?6#   ?? 5?      $
??170* ?6#   ?? 5@      $
??134* ?6#   ?? 5A      $
??212* ?6#   ?? 5B      $
??244* ?6#   ?? 5C      $
??180* ?6#   ?? 5D      $	??89* ?6#   ?? 5E      $	??89* ?6#   ?? 5F      $	??89* ?6#   ?? 5G      $	??89* ?6#   ?? 5H      $	??89* ?6#   ?? 5I      $	??89* ?6#   ?? 5J      $	??89* ?6#   ?? 5K      $	??89* ?6#   ?? 5L      $	??89* ?6#   .+?5P      ?? $??15??6   $??Center=?5Q      $??Center=?5R      .+?5S      o? $??47??6   $??30(?6#   ???#F0F0F0??5U      ?? 5V      .R?5W      ??  ?? Orientation$ 
Horizontal=?6)   5X      .@?5Z      m? $
??Home??6    m? CommandParameter$
 home??6-    m? Command 6E   ?? *
NavCommand+m? 5[      $
??Room??6   .@?5\      m? 
???????$??Room review??66   $
 room??6K    6c   ?? *
NavCommand+m? 5]      
???????$??Room renovation??66   $ roomRenovation??6O    6q   ?? *
NavCommand+5^      m? 5_      $??	Equipment??6   .@?5`      m? 
???????$??Equipment review??66   .@?5a      m? 
???????$??Static equipment??6:   $ staticEquipment??6T    6w   ?? *
NavCommand+m? 5b      
???????$??Dinamic equipment??6:   $ dinamicEquipment??6U    6y   ?? *
NavCommand+5c      m? 5d      
???????$??Equipment rearrange??66   $ rearrangeEquipment??6T    6z   ?? *
NavCommand+5e      m? 5f      $??Questionnaire??6    $" QuestionnaireReviewHospitals??68    6h   ?? *
NavCommand+6?   m? 5g      $??	Medicines??6   .@?5h      m? 
???????$??Medicine review??66   $ medicine??6O    6k   ?? *
NavCommand+m? 5i      
???????$??Medicine registration??66   $ registrationMedicine??6U    6}   ?? *
NavCommand+m? 5j      
???????$??Medicine rejected??66   $ rejectedMedicine??6Q    6u   ?? *
NavCommand+5k      5l      5m      5p      ? 5r   
   $??2??6    5s      ?? 5t      $
??248* ?6    ?? 5u      $
??371* ?6    .+?5w      ?? $??0,-24,-423,0q?6B   $??2??6X   ??6   ?? *CurrentViewModel+6X   5x      5{      5|      