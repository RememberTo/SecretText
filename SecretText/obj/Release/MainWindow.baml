   M S B A M L   `   `   `  ���� E  ASecretText, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SecretText
SecretText      SecretText.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:SecretText     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$%  Шифр Гронсфельда��$	��720��$
��1280��.��� $��0,0,0,0q� � ColumnDefinitions �� $	��38* ��� $
��170* ��� $
��343* ��� $	��65* ��� $	��10* ��� $	��64* ��� $
��374* ��� $
��170* ��� $	��39* � � RowDefinitions �� $
��147* ��� $	��88* ��� $	��40* ��� $	��10* ��� $	��38* ��� $	��83* ��� $	��67* ��� $	��14* ��� $	��41* ��� $
��162* �����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF071318��� $ 	#FF121C2F�� � Offset$ 1Q�� $ 	#FF1D3445��$ 0.547Q�.+��� -    ��Name$ 	EnterCode��$
��Left=�$	��322��$��27.4,4.8,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��470��)  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Введите текст�� %  !MaterialDesignFloatingHintTextBox#��[  $��18(�
 �� 
CaretBrush
 �	#FF69C9E7���	#FFCDFFFC���	#8955F6FF���	#00000000 �� SelectionBrush �	#FF8BB1CE$��6�� � Cursor$	 Pen��$��2��$��1��$��1���� -   $ 
TextBoxKey��$
��Left=�$��64��$��27.4,77,0,0q�$
 Wrap=�$	��Top=�$	��346��$	 Введите ключ��#��[  $��18(�
 �	#FF69C9E7���	#FFCDFFFC���	#8955F6FF���	#00000000 �	#FF8BB1CE$	 Pen��$��2��$��1��	� -    	�Name$ RadioButton_Decoding��$��Расшифровать�����	#FFCDFFFC$��16(�$
��Left=�$��343,117,0,0q�$	��Top=�$��24��$	��129�� # MaterialDesignAccentRadioButton#��[ ���	#FFBF00EA$
 Hand��$��4��$��2��	� -   $ RadioButton_Encoding��$��Зашифровать�����	#FFCDFFFC$��16(�$
��Left=�$��
343,93,0,0q�$	��Top=�$��24��$	��139��#��[ ���	#FFBF00EA���	#FF09AAE5$
 Hand��$��4��$��2��(  "MaterialDesignThemes.Wpf.RatingBar  $
��Left=�$��
343,59,0,0q�$	��Top=�$��29��$	��139�����	#FFB7C514$
 Hand�� J� RenderTransformOrigin$ 0.5,0.5&�$��2��$��4���� -   $ 
ResultCode��$	��322��$��44.6,4.8,30.4,0q�$
 Wrap=�$	��Top=�$	  ��#��[  $��18(�
 �	#FF69C9E7���	#FFCDFFFC���	#8955F6FF���	#00000000 �	#FF8BB1CE$��6��$	 Pen��$��6��$��2��$��1���� -   $��Добавить файл�� � ToolTip$R LДобавляет текст из файла в текстовое поле�����	#FFCDFFFC$
��Auto��$��0.4,0.394,0,0.406q����	#FF1D1F40$��16(�$��8��$��1���� -   $��Сохранить как��$n hСохроняет расшифрованный или зашифрованный текст в файл�����	#FFCDFFFC$��0,0.394,0.4,0.406q�$
��Auto�����	#FF1D1F40$��7��$��8��$��16(��� -   $��Выполнить�����	#FFCDFFFC$��343,0.8,0.4,0.2q�$ 1.147,-1.95&�$
��Auto�����	#FF1D1F40$��16(�$��2��$��2��$��4���� -	    ��Name$ 
Label_code��$5��/Зашифрованная информация��$��12(����	#FF83B4B1$��40.6,9.8,70.8,26.2q�$��6��$��1���� -
   $ Label_Uncode��$7��1Расшифрованная информация��$��12(����	#FF83B4B1$��40.6,9.8,105.8,41.2q�$��6��$��1���� -   $
��🡄��$P JПеремещает текст из правого окна в левое�����	#FFCDFFFC$��343,9.8,0,82.806q�$ 1.147,-1.95&�$
��Auto�����	#FF1D1F40$��20(�$��2��$��3��$��3��$��2���� -   $
��🡆��$P JПеремещает текст из левого окна в правое�����	#FFCDFFFC$��10,9.8,0.4,82.806q�$ 1.147,-1.95&�$
��Auto�����	#FF1D1F40$��20(�$��4��$��3��$��3��$��2��