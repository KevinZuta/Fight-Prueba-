   M S B A M L   `   `   `  ����@  <Fight, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FightFight  5   	       Fight.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Fight     5   	     � Title$  Fight (beta)��5   	   $	��450��6   $	��800��6+    � Icon$  /Fight;component/icono.png��67    � 	Resources 5	         MiEstilo �� 
TargetType �� Property �� Value��%�   &	        �� 5
   
   " ��6!   .�5      ��  � ��$ 12(�6)   �� 5       � ��
 �����6+   �� 5       � ��$ SemiBold"�6+   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��19* �6   �� 5      $
��381* �6   .+�5   
   �� -   5         ��Name$ btnTest��5      $
��Play��6"   $
��Left=�61   $��6,96,0,0q�6N   $	��Top=�6`   $	��120��6x   $��1��6�   r� 5   
   -   5         r�Name$ mediaPlayer��5      	 r� Source$H	 BC:\Users\lucia\source\repos\Fight\videos\Eagle\EagleComboReset.mp4?�6,   $��131,21,10,93q�6x   
 r� LoadedBehavior$
 Manual=�6�   $��1��6�   �� 5   
   -   5         ��Name$ cmbChar��5      $
��Left=�6$   $��6,69,0,0q�6?   $	��Top=�6R   $	��120��6j   $��1��6�   �� 5   
   -   5        $ cmbMov��5      $
��Left=�6#   $��6,42,0,0q�6>   $	��Top=�6P   $	��120��6h   $��1��6t   �� 5   
   -   5         ��Name$ label��5      $��Reproduciendo:��6   #��[  68   $
��Left=�6[   $��	20,0,0,13q�6v   $��Bottom=�6�    J� RenderTransformOrigin$ -0.14,-1.963&�6�   $��2��6�   �� 5   
   -   5        $ lblPlay��5      $�� ��6!   #��[  6,   $
��Left=�6O   $��83,0,0,0q�6j   $��Bottom=�6|   $	��472��6�   $��39��6�   $��1��6�   �� 5   
   -   5         ��Name$ slider��5      $
��Left=�6!   $��	6,149,0,0q�6<   $	��Top=�6O   $	��120��6g    � Minimum$ 0Q�6�   $��1��6�    � Maximum 6�   ��  �� ElementName$ mediaPlayer�� �� Path$+ %NaturalDuration.TimeSpan.TotalSeconds�6�   �� 5   
   -   5        $ 
label_Copy��5      $��App by Conchita��6$   #��[  6>   $
��Left=�6`   $��	571,0,0,4q�6{   $��Bottom=�6�   $ -0.14,-1.963&�6�   $��1��6�   ��5   
   �� 5       �� ImageSource$  /Fight;component/fondo.png��6    j� Stretch$ UniformToFill=�6B   5!      5#      