   M S B A M L   `   `   `  ����G  CRiotView.app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:RiotView.app.ConverterRiotView.app.Converter  5   	   !    RiotView.app.EcranConnexion   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;
converter1$clr-namespace:RiotView.app.Converter     5   	   Fdg9http://schemas.microsoft.com/netfx/2009/xaml/presentation    5   	     � Title$  	Connexion��5	   	   $	��350��6   $	��525��6(   ���	#FFACAEB9 � 	Resources 5      9  3RiotView.app.Converter.BooleanToVisibilityConverter    BooleanToVisibilityConverter��%   &	          5   
   62   5      .��5      � -   5        $��dxfLines��5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��	Connexion��6   $	��Top=�6$   $��1��6=   $��0��6M   $��32(�6Z   $��Impact)�6h   ��5      �� 5       �� EndPoint$ 0.5,1.7&�6&    �� 
StartPoint$ 0.5,0&�69   .��5       �  � Color$ 	#FFF14747��6#    � Offset$ 0Q�65   � 5!      $ 	#FF1AEC1A��6#   $ 1Q�65   5"      5$      �� 5'   
   -   5        $��Pseudo��5'   O   ���	#FFEEA68C$��1��6B   $��1q�6]   $��1��6h   $
��20px��6x   ��6   �� *Pseudo+6x   �� 5(   
   -   5        $	��Mdp��5(   6   $��2��6   ���	#FFEEA68C$��1q�6A   $��1��6L   $
��20px��6q   ��6\   �� *MDP+6q   �� 5)   
   -   5        $��	Connexion��5)      $��3��6   $��1��6/   $��	Connexion��6?   $
��30px��6S   
���  ��$��18(�6�   $
��Bold"�6�   ��6a   �� *CommandeConnexion+��5*      �� 5+      $ 0.5,1&�6&   $ 0.5,0&�67   .��5,      � $ 	#FFDDF570��6#   $ 0Q�65   � 5-      $ 	#FF82CFCF��6#   $ 1Q�65   5.      50      �� 53   
   ���	#FFACAEB9$��0��6(   $��3��68   $
��30px��6E   $�� 50px��6S   ���	#FFACAEB9��6b   �� *CommandeInscription+.��54      �� $��inscription.png��6   $��0��6-   $��3��6=   $
��30px��6K   55      �� 57   
   ���	#FFACAEB9$��2��6I   $��1��6Y   $
��30px��6g   $�� 50px��6u   ���	#FFACAEB9��6(   �� *CommandeInfo+.��58      �� $��info.png��6   $��2��6'   $��1��67   $
��20px��6D   59      5;      5<      