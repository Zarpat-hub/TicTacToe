   M S B A M L   `   `   `  ���� D  @TicTacToe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TicTacToe	TicTacToe      TicTacToe.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:TicTacToe       � 
ResizeMode$  NoResize=� � Title$ 
MainWindow��$	��623��$
��1000��$��48(�.���� $	��623��$
��1000�� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� ��  �� AngleX$ 0.202Q��� T�  T� X$ 1.056Q�.+�� $ 
1.212,0.76&�$	��600��$	��600��$
��Left=� � RowDefinitions �� $��* ��� $��* ��� $��* � � ColumnDefinitions �� $��* ��� $��* ��� $��* �.+��� -    ��Name$ 
button_0_0��$��0��$��0��$
��Bold"�$��48(��� -   $ 
button_1_0��$��1��$��0��$��48(�$
��Bold"��� -   $ 
button_2_0��$��2��$��0��$��48(�$
��Bold"��� -   $ 
button_0_1��$��0��$��1��$��48(�$
��Bold"��� -   $ 
button_1_1��$��1��$��1��$��48(�$
��Bold"��� -   $ 
button_2_1��$��2��$��1��$��48(�$
��Bold"��� -   $ 
button_0_2��$��0��$��2��$��48(�$
��Bold"��� -   $ 
button_1_2��$��1��$��2��$��48(�$
��Bold"��� -	   $ 
button_2_2��$��2��$��2��$��48(�$
��Bold"��� -
   $ newGameButton�� �� Left$	 665��
	 �� Top$		 431��$ 0.187,0.812&����	#FF47A5D1���	#FF131111
���   �$��Normal"�$	��132��$	��288��.���� $��New Game��$
��Wrap=��� -   
 ��Name$
 	turnLabel��$
��Turn��$	 751��$	 13��$ 0.5,0.5&�$��73��$	��135��$��48(�$��Normal"�z�V� .~��� �� $ -0.712Q��� T� $ -0.856Q��� -    ��Name$ 	turnBlock��$	 768��$	 82��$
��Wrap=�$	��126��$��78��$	��100(�$
��Bold"���  � Language$ pl-pl�