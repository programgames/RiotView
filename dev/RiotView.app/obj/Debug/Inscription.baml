   M S B A M L   `   `   `  ����G  CRiotView.app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:RiotView.appRiotView.app  5   	       RiotView.app.Inscription   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:RiotView.app     5   	     � Title$  Inscription��5   	   $	��300��6   $	��300��6*   .��5      � -   5        $��dxfLines��5      
����·� � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��65* �6   �� 5      $
��172* �6   �� 5      $	��55* �6   .+�5   
   �� $��Inscription��6   $��1��6&   $��0��66   $��20(�6C   $��Impact)�6Q   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5       �  � Color$ Black��6#    � Offset$ 0Q�61   � 5!      $ White��6#   $ 1Q�61   5"      5$      �� 5%   
   -   5        $
��User��5%      $��1��6   $��1,3,1,4q�6+   $��1��6<   ���	#FFC0D6EA��6L   �� *Pseudo+6d   �� 5'   
   $��1��6   $��2��6#    d� 	IsChecked 61   �� *Sexe+.��6L   Etes vous une femme ?6c   �� 5*   
   -   5        $��
MotDePasse��5*   K   ���	#FFC0D6EA$��4��6>   $��1,4,1,3q�6]   $��1��6n   ��6   �� *MDP+6n   �� 5+   
   $��Confirmation��6   $��1��6'   $��5��67   $��15(�6D   $��Impact)�6R   ��5,      �� 5-      $ 0.5,1.1&�6&   $ 0.5,0&�69   .��5.      � $ Black��6#   $ 0Q�61   � 5/      $ White��6#   $ 1Q�61   50      52      �� 53   
   -   5        $��MotDePasse2��53   W   ���	#FFC0D6EA$��6��6J   $��1,4,1,3q�6j   $��1��6{   ��6   �� *MDPConfirmation+6{   �� 54   
   $��inscription.png��6   $��0��6)   $��3��69   $��0,0,0,24q�6F   $��2��6X   �� 56   
   $	��Top=�6   $��Date de Naissance��6(   $��1��6D   $��7��6T   $��10(�6a   $��Arial)�6o   $��22��6�   (  "System.Windows.Controls.DatePicker  57   
   ���	#FFC0D6EA$��1��6z   $��8��6�   #��� ��6�      SelectedDate 6   �� *AvailableFrom+	   DisplayDate	 6S   �� *DateTime.Now+6�   �� 58   
   $��1��69   $��9��6I   
����� ���6   �� *CommandeInscription+.��6l   
Inscrire6v   5:      5;      