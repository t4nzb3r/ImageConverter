   M S B A M L   `   `   `  ����S  ONoggoNoggoImageConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:NoggoNoggoImageConverterNoggoNoggoImageConverter  5   	   )    #NoggoNoggoImageConverter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:NoggoNoggoImageConverter     5   	     � Title$   NoggoNoggo Image Converter��5   	   $	��325��5	   	   $	��570��6    � 
ResizeMode$ NoResize=�5
   	   .��5      � .+�5   
   �� $��Path:��6   $
��Left=�6    $��	10,11,0,0q�6;   $	��Top=�6N   �� 5   
   -   5         ��Name$ 
TxtBoxPath��5      $��Stretch=�6&   $��23��6D   $��
51,14,37,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x    �� 
IsReadOnly . 6�   �� 5   
   -   5         ��Name$ 
BtnOpenImg��5      $	��...��6%   $��Right=�63   $��	0,14,10,0q�6O   $	��Top=�6b   $��22��6z   $��23��6�   6�   �� 5   
   $��Height:��6   $
��Left=�6"   $��	10,54,0,0q�6=   $	��Top=�6P   �� 5   
   -   5         ��Name$ 	LblHeight��5      $��height��6#   $
��Left=�64   $��	63,54,0,0q�6O   $	��Top=�6b   �� 5   
   $��Width:��6   $
��Left=�6!   $��	10,80,0,0q�6<   $	��Top=�6O   �� 5   
   -   5        $ LblWidth��5      $��width��6"   $
��Left=�62   $��	63,80,0,0q�6M   $	��Top=�6`   �� 5   
   $��Numbers:��6   $
��Left=�6#   $��
10,111,0,0q�6>   $	��Top=�6R   �� 5   
   -   5        $ 
LblNumbers��5      $��numbers��6$   $
��Left=�66   $��
76,111,0,0q�6Q   $	��Top=�6e   �� 5   
   $��Numbers for each color:��6   $
��Left=�62   $��
10,137,0,0q�6M   $	��Top=�6a   �� 5   
   -   5        $ LblNumbersEach��5      $��numbersEach��6(   $
��Left=�6>   $��153,137,0,0q�6Y   $	��Top=�6n   �� 5   
   $��Median red:��6   $
��Left=�6&   $��
10,168,0,0q�6A   $	��Top=�6U   �� 5   
   -   5        $ 	LblMedRed��5      $��medRed��6#   $
��Left=�64   $��
88,168,0,0q�6O   $	��Top=�6c   �� 5   
   $��Median green:��6   $
��Left=�6(   $��
10,194,0,0q�6C   $	��Top=�6W   �� 5   
   -   5        $ LblMedGreen��5      $��medGreen��6%   $
��Left=�68   $��101,194,0,0q�6S   $	��Top=�6h   �� 5   
   $��Median blue:��6   $
��Left=�6'   $��
10,220,0,0q�6B   $	��Top=�6V   �� 5    
   -	   5        $ 
LblMedBlue��5       $��medBlue��6$   $
��Left=�66   $��
94,220,0,0q�6Q   $	��Top=�6e   �� 5"   
   -
   5        $ 
BtnConvert��5"      $��Convert��6%   $��Stretch=�67   $��
10,0,10,10q�6U   $��Bottom=�6i   6�   5$      5%      