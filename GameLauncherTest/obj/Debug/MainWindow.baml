   M S B A M L   `   `   `  ����K  GGameLauncherTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:GameLauncherTestGameLauncherTest  5   	   !    GameLauncherTest.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:GameLauncherTest     5   	   -   5          � Title$  LOC_Launcher��5	   	   $	��450��6   $	��710��6+   ���	#FF3B4F61 � WindowStyle$
 None=�6N   ��5
      �� 5   
    �� ImageSource$ bin/Debug/Background.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      �� 5      $��0* �6   �� 5      $��0* �6   �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ 	mainLabel��5      $ ��Leap Of Champions Launcher��6#   $��26.667(�6H   $��43��6Z   $	��Top=�6f   
�������$
��Left=�6�   $	��388��6�   $��1��6�   $
��Bold"�6�   ���	#B20000006�   �� 5   
   -   5         ��Name$ launchButton��5      $
��Play��6'   $��Right=�66   $��	0,0,35,72q�6R   $��Bottom=�6e   $	��120��6�   $��35��6�    � ToolTip$ Launch the game!��6�   $��0q�6�   
�������$
��Bold"�6  $��1��6  ��6�   Z� ��5      �� 5       �� EndPoint$	 0,1&�6&    �� 
StartPoint$	 0,0&�65   .��5      � 	 � Color$	 	#FF236E91��6#   
 � Offset$
 0.974Q�65   � 5      $	 	#FF4ED6D6��6#   5      5      �� 5   
   -   5        $ websiteButton��5      $��Visit Website��6(   $��
0,0,35,132q�6@   $��Bottom=�6T   $��35��6o   $ Visit Website��6{   $��0q�6�   
�������$
��Bold"�6�   $��Right=�6�   $	��120��6  $��1��6'  ��6�   Z� ��5      �� 5       $	 0,1&�6&   $	 0,0&�65   .��5!      � $	 	#FF2E3841��6#   � 5"      $	 	#FF2E3841��6#   5#      5%      (  "System.Windows.Controls.WebBrowser  5&   
   $��
25,59,0,72q�6      Source$l fhttps://308f0365df6f2f4f57ea063651346709e7ed4cdc-www.googledrive.com/host/0B7olgEMo6Y6jQzgzZTlvVm1tSDQ?�6)   $��1��6�   $
��Left=�6�   $	��493��6�    J� Opacity$	 0.7Q�6�   �� 5'   
   -   5        $ mainLabel_Copy��5'      $��	v1.2.07
��6(   $��10.667(�6D   $��23��6V   $	��Top=�6b   $��
388,17,0,0q�6z   
�������$
��Left=�6�   $	��120��6�   $��1��6�   �� 5(   
   -   5        $ update��5(      $��Right=�6    $��2��6C   $�� ��6W   $
��Left=�6b   $��
22,387,0,0q�6}   $	��Top=�6�   $��35��6�   $	��363��6�   ���	#B2000000
�������$��16(�6�   $��Segoe UI Light)�6�   &   System.Windows.Media.TextOptions   TextHintingMode$ Animated=�6  �� 5)   
   -   5        $ button��5)      $��2��6!   $�� ��65   $
��Left=�6@   $��
672,10,0,0q�6[   $	��Top=�6o   $��20��6�   $��20��6�   $��0q�6�   ��5*      �� 5+      $ bin/Debug/xButton.png��6   5-      �� 5.   
   -   5        $ button_Copy��5.      $��2��6&   $�� ��6:   $
��Left=�6E   $��
647,10,0,0q�6`   $	��Top=�6t   $��20��6�   $��20��6�   $��0q�6�   ��5/      �� 50      $: 4pack://siteoforigin:,,,/bin/Debug/MinimizeButton.png��6   52      �� 53   
   -	   5         ��Name$ image��53      $��2��6   $
��Left=�63   $	��100��6N   $��
558,90,0,0q�6[   $	��Top=�6o   $	��100��6�    J� OpacityMask
 �����$��bin/Debug/Logo Leaf.png��6�   55      56      